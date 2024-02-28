Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls
Imports NuSoft.Core.SSystem
Imports NuSoft.NPO.Modules.ModSys
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Logic
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Travel.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Travel.Services

Friend Class UI_TravelDPDialog
	Private editAssign As Boolean = False
	Private setting As NuSoft001.Logic.FinaSetting
	Private settingSales As SalesSetting
	Private openSO As List(Of Travel_Order)
	Private instance As Travel_DownPayment

	Sub New()
		InitializeComponent()
		NoDropIdentityMap = True
	End Sub
	Overrides Sub LoadBeforeInitialize()
		setting = New NuSoft001.Logic.FinaSetting(session)
		settingSales = New SalesSetting(session)
		BindingDataSource()
	End Sub
	Overrides Sub InitializeData()
		MyBase.InitializeData()
		session.ReloadChangedObjects()
		If Tipe = InputType.Tambah Then
			BindingSO(Nothing)
			Dim defaultRegional = UserInfo.GetDefaultRegional(session)
			If Not defaultRegional Is Nothing Then
				txtRegional.EditValue = defaultRegional
			Else
				txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
			End If
			txtNoTransaksi.Text = ""
			txtTanggal.EditValue = Now
			txtAkun.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtAkun)
			UpdateKurs()
			txtNominal.Value = 0
			txtUraian.Text = settingSales.UraianDP
		Else
			editAssign = True
			instance = session.GetObjectByKey(Of Travel_DownPayment)(Convert.ToInt64(IdToEdit))
			BindingSO(instance.TravelOrder)
			txtRegional.EditValue = instance.Regional
			txtNoTransaksi.EditValue = instance.Kode
			txtPelanggan.EditValue = instance.Pelanggan
			UpdateSOSource()
			txtOrder.EditValue = instance.TravelOrder
			txtTanggal.EditValue = instance.Tanggal
			txtAkun.EditValue = instance.AkunKasBank
			txtUang.EditValue = instance.Uang
			txtKurs.Value = instance.Kurs
			txtNominal.Value = instance.Nominal
			txtUraian.Text = instance.Uraian
			editAssign = False
		End If
		txtPelanggan.Focus()
	End Sub
	Overrides Sub LoadAfterInitialize()
		SetFormat()
		If Tipe = InputType.Tambah Then
			Me.Text = "Travel Down Payment [DP] : Tambah Data"
		Else
			Me.Text = "Travel Down Payment [DP] : Edit Data " & instance.Kode
			If instance.AutoStatus <> "Posting" Then
				DisableControl()
			End If
			If NuSoft001.Persistent.Periode.CheckLockedPeriod(session, instance.Tanggal) Then
				DisableControl()
			End If
			If NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit = False Then
				DisableControl()
			End If
		End If
	End Sub
	Private Sub CheckBeforeSave()
		If txtRegional.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan regional", -1)
		End If
		If txtPelanggan.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan pelanggan", -2)
		End If
		If txtOrder.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan travel order", -3)
		End If
		If txtTanggal.DateTime = Nothing Then
			Throw New Utils.Exception("Masukkan tanggal", -4)
		End If
		If txtAkun.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan coa kas/bank", -5)
		End If
		If txtKurs.Value <= 0 Then
			Throw New Utils.Exception("Kurs harus lebih besar dari 0", -6)
		End If
		If txtNominal.Value <= 0 Then
			Throw New Utils.Exception("Masukkan nominal", -7)
		End If
		If String.IsNullOrEmpty(txtUraian.Text) Then
			Throw New Utils.Exception("Masukkan uraian DP", -8)
		End If

		' ======== cek kode ========
		If String.IsNullOrEmpty(txtNoTransaksi.Text) Then
			Return
		End If
		If Tipe = InputType.Edit AndAlso txtNoTransaksi.Text.ToLower = instance.Kode.ToLower Then
			Return
		End If

		Dim dataKode = New XPQuery(Of Travel_DownPayment)(session).Where(Function(w) w.Kode = txtNoTransaksi.Text).ToList
		If dataKode.Count > 0 Then
			Throw New Utils.Exception("Kode '" & txtNoTransaksi.Text & "' sudah ada yang memakai." & vbCrLf & "Harap ganti dengan kode lain", -9)
		End If
	End Sub
	Overrides Sub SimpanData()
		CheckBeforeSave()

		Try
			Dim item As Travel_DownPayment
			If Tipe = InputType.Tambah Then
				item = New Travel_DownPayment(session)
			Else
				item = instance
			End If
			item.Regional = CType(txtRegional.EditValue, Regional)
			item.Pelanggan = CType(txtPelanggan.EditValue, Kontak)
			item.TravelOrder = CType(txtOrder.EditValue, Travel_Order)
			item.Tanggal = txtTanggal.DateTime
			item.AkunKasBank = CType(txtAkun.EditValue, Coa)
			item.Uang = CType(txtUang.EditValue, MataUang)
			item.Kurs = txtKurs.Value
			item.Nominal = txtNominal.Value
			item.Uraian = txtUraian.EditValue
			If String.IsNullOrEmpty(txtNoTransaksi.Text) Then
				'== kode otomatis
				item.Kode = TravelDownPaymentServices.GetNomor(session, setting, item.Tanggal, item.Regional)
			Else
				item.Kode = txtNoTransaksi.Text
			End If

			' == jurnal gl
			TravelDownPaymentServices.SetGL(item, setting, settingSales)

			'======= Simpan instance
			session.CommitChanges()
		Catch ex As Utils.Exception
			Throw New Utils.Exception(ex)
		End Try

		'======= Konfirmasi Cetak Laporan
		Dim frm As New RF_TravelDataTransaksi(Persistent.SumberDataJenis.CP, MainClass.reportName.zTravelVoucherDP)
		frm.txtNoBukti1.EditValue = instance.Kode

		Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
		Dim reportCode As String = ""
		reportCode = MainClass.GetReport(MainClass.reportName.zTravelVoucherDP)
		message = String.Format(message, "DP Penjualan")

		Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, settingSales.PreviewSave)
	End Sub
	Overrides Sub ErrorSimpan(ex As Utils.Exception)
		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case -1 : txtRegional.Focus()
			Case -2 : txtPelanggan.Focus()
			Case -3 : txtOrder.Focus()
			Case -4 : txtTanggal.Focus()
			Case -5 : txtAkun.Focus()
			Case -6 : txtKurs.Focus()
			Case -7 : txtNominal.Focus()
			Case -8 : txtUraian.Focus()
			Case -9 : txtNoTransaksi.Focus()
		End Select
	End Sub

	Private Sub BindingDataSource()
		txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
		txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
		txtAkun.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Kas, NuSoft001.Persistent.CoaEnum.eKind.Bank})
		txtKurs.Properties.MinValue = 1
		txtKurs.Properties.MaxValue = Decimal.MaxValue
		txtNominal.Properties.MinValue = 0
		txtNominal.Properties.MaxValue = Decimal.MaxValue
	End Sub
	Private Sub BindingSO(editedSO As Travel_Order)
		openSO = New XPQuery(Of Travel_Order)(session).Where(Function(w) w.AutoStatus = "Posting" OrElse w.AutoStatus = "DP").ToList
		If Not editedSO Is Nothing Then
			Dim find = openSO.Find(Function(f) f Is editedSO)
			If find Is Nothing Then
				openSO.Add(editedSO)
			End If
		End If

		Dim groupCustomer = openSO.GroupBy(Function(g) g.Pelanggan).Select(Function(s) s.Key).ToList
		txtPelanggan.Properties.DataSource = groupCustomer
	End Sub
	Private Sub SetFormat()
		txtKurs.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		txtKurs.Properties.DisplayFormat.FormatString = setting.NumericFormatToString
		txtKurs.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		txtKurs.Properties.EditFormat.FormatString = setting.NumericFormatToString
		txtNominal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		txtNominal.Properties.DisplayFormat.FormatString = setting.NumericFormatToString
		txtNominal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		txtNominal.Properties.EditFormat.FormatString = setting.NumericFormatToString
	End Sub
	Private Sub DisableControl()
		txtRegional.Enabled = False
		txtNoTransaksi.Enabled = False
		txtPelanggan.Enabled = False
		txtOrder.Enabled = False
		txtTanggal.Enabled = False
		txtAkun.Enabled = False
		txtUang.Enabled = False
		txtKurs.Enabled = False
		txtNominal.Enabled = False
		txtUraian.Enabled = False
		EnableVisibleSaveButton(False, True)
	End Sub

	Private Sub ChangeCode()
		If Not instance Is Nothing Then
			If txtTanggal.DateTime.ToString("yyyyMM") <> instance.Tanggal.ToString("yyyyMM") Then
				txtNoTransaksi.Text = String.Empty
			Else
				If Not CType(txtRegional.EditValue, Regional) Is instance.Regional Then
					txtNoTransaksi.Text = String.Empty
				Else
					If instance.Kode <> txtNoTransaksi.Text Then txtNoTransaksi.Text = instance.Kode
				End If
			End If
		End If
	End Sub
	Private Sub UpdateKurs()
		If editAssign Then Return
		If txtUang.EditValue Is Nothing Then Return
		If CType(txtUang.EditValue, MataUang).Id = setting.MultiMataUangDefault Then
			txtKurs.Value = 1
			txtKurs.Properties.ReadOnly = True
		Else
			txtKurs.Value = NuSoft001.Logic.Kurs.getKursPajak(session, CType(txtUang.EditValue, NuSoft001.Persistent.MataUang), txtTanggal.DateTime)
			txtKurs.Properties.ReadOnly = False
		End If
	End Sub
	Private Sub UpdateSOSource()
		txtOrder.EditValue = Nothing
		If Not txtPelanggan.EditValue Is Nothing Then
			Dim plg = CType(txtPelanggan.EditValue, Kontak)
			txtOrder.Properties.DataSource = openSO.Where(Function(w) w.Pelanggan Is plg).ToList
		End If
	End Sub

	Private Sub txtRegional_EditValueChanged(sender As Object, e As EventArgs) Handles txtRegional.EditValueChanged
		If Not editAssign Then ChangeCode()
	End Sub
	Private Sub txtTanggal_DateTimeChanged(sender As Object, e As EventArgs) Handles txtTanggal.DateTimeChanged
		If Not editAssign Then
			ChangeCode()
			UpdateKurs()
		End If
	End Sub
	Private Sub txtPelanggan_EditValueChanged(sender As Object, e As EventArgs) Handles txtPelanggan.EditValueChanged
		If Not editAssign Then UpdateSOSource()
	End Sub
	Private Sub txtAkun_EditValueChanged(sender As Object, e As EventArgs) Handles txtAkun.EditValueChanged
		If Not editAssign Then
			If Not txtAkun.EditValue Is Nothing Then
				Dim akun = CType(txtAkun.EditValue, Coa)
				txtUang.EditValue = akun.MataUang
				UpdateKurs()
			End If
		End If
	End Sub
	Private Sub txtOrder_EditValueChanged(sender As Object, e As EventArgs) Handles txtOrder.EditValueChanged
		If txtOrder.EditValue Is Nothing Then
			txtSOJmlJamaah.Text = ""
			txtSOUraian.Text = ""
			txtSOTotal.Text = ""
			xGrid.DataSource = Nothing
		Else
			Dim so = CType(txtOrder.EditValue, Travel_Order)
			txtSOJmlJamaah.Text = so.ReffNumber
			txtSOUraian.Text = so.Uraian
			txtSOTotal.Text = so.Uang.Kode & " " & so.Total.ToString("n0")
			If Tipe = InputType.Tambah Then
				xGrid.DataSource = New XPQuery(Of Travel_DownPayment)(session).Where(Function(w) w.TravelOrder Is so).ToList
			Else
				xGrid.DataSource = New XPQuery(Of Travel_DownPayment)(session).Where(Function(w) w.TravelOrder Is so AndAlso w.Kode <> instance.Kode).ToList
			End If
			xGridView.ExpandAllGroups()
		End If
	End Sub

	Private Sub txtNoTransaksi_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtNoTransaksi.ButtonClick
		txtNoTransaksi.Text = TravelDownPaymentServices.GetNomor(session, setting, txtTanggal.DateTime, txtRegional.EditValue)
	End Sub
End Class