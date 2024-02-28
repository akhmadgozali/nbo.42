﻿Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Travel.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Travel.NonPersistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Travel.Services
Imports DevExpress.XtraGrid.Views.Base
Imports System.ComponentModel

Friend Class UI_TravelPembayaranDialog
	Private instance As Travel_PembayaranInvoice
	Private isShown As Boolean
	Private editAssign As Boolean = False
	Private detailToDelete As New List(Of Travel_PembayaranInvoiceDetail)
	Private setting As NuSoft001.Logic.FinaSetting
	Private settingsales As Logic.SalesSetting
	Private sumber As Persistent.SumberDataCollection
	Private detailPiutang As List(Of Travel_DaftarPembayaran)

	Sub New()
		InitializeComponent()
		NoDropIdentityMap = True
	End Sub
	Overrides Sub LoadBeforeInitialize()
		setting = New NuSoft001.Logic.FinaSetting(session)
		settingsales = New Logic.SalesSetting(session)
		BindingDataSource()
		sumber = New Persistent.SumberDataCollection(session)
		'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("CPTransaksi.xml")) = True Then
		'	lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("CPTransaksi.xml"))
		'End If
	End Sub
	Overrides Sub InitializeData()
		MyBase.InitializeData()
		session.ReloadChangedObjects()
		detailPiutang = New List(Of Travel_DaftarPembayaran)
		If Tipe = InputType.Tambah Then
			instance = New Travel_PembayaranInvoice(session)
			instance.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}

			xGrid.DataSource = Nothing
			LoadDefault()
			ChangeCode()
		Else
			editAssign = True
			xGrid.DataSource = Nothing
			instance = session.GetObjectByKey(Of Travel_PembayaranInvoice)(Convert.ToInt64(IdToEdit))
			txtTanggal.EditValue = instance.Tanggal
			txtNoTransaksi.EditValue = instance.Kode
			txtRegional.EditValue = instance.Regional
			txtStatus.EditValue = instance.StatusTransaksi

      txtCaraBayar.EditValue = instance.BankCaraBayar

      txtAkun.EditValue = instance.coakasbank
			txtKurs.EditValue = instance.Kurs
			txtNilaiKas.EditValue = instance.Total
			txtNilaiValas.EditValue = instance.TotalValas
			txtNilaiAdministrasi.EditValue = instance.TotalAdminBank
			txtNilaiPendapatan.EditValue = instance.TotalDiscount
			txtNilaiPembulatan.EditValue = instance.TotalPembulatan
			txtNilaiPPH.EditValue = instance.TotalPPH
			txtNoPPH.EditValue = instance.NomorPPH
			txtUraian.EditValue = instance.Uraian

			txtKontak.EditValue = instance.Pelanggan
			txtKontak.Enabled = False
			txtKontak.Properties.ReadOnly = True

      If CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Id = setting.MultiMataUangDefault Then
        txtKurs.Properties.ReadOnly = True
      Else
        txtKurs.Properties.ReadOnly = False
      End If

      editAssign = False
      UpdatePiutangSource()
			HitungSaldo()
		End If
		SetNomor()
		xGrid.DataSource = detailPiutang
		txtKontak.Focus()
	End Sub
	Overrides Sub LoadAfterInitialize()
		SetFormat()
		If Tipe = InputType.Tambah Then
			Me.Text = "Travel - Pembayaran Invoice [CP] : Tambah Data"
		Else
			Me.Text = "Travel - Pembayaran Invoice [CP] : Edit Data " & instance.Kode
			'If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
			'	DisableControl()
			'End If
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
		If txtTanggal.DateTime = Nothing Then
			Throw New Utils.Exception("Masukkan tanggal", -2)
		End If
		If txtKontak.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan pelanggan", -3)
		End If
		If txtUang.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan mata uang", -4)
		End If
    If String.IsNullOrEmpty(txtUraian.Text) Then
      Throw New Utils.Exception("Masukkan uraian", -5)
    End If
    If CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Id <> setting.MultiMataUangDefault Then
      If CType(txtKurs.EditValue, Double) <= 1 Then
        Throw New Utils.Exception("Masukkan kurs", -6)
      End If
    End If

    For Each item In detailPiutang
			Dim selisih = item.JumlahBayarValas - (item.SisaPiutang * item.KursBayar)
			If selisih > 1 Then
				Throw New Utils.Exception("Pembayaran invoice '" & item.Invoice.Kode & "' tidak boleh melebihi sisa piutang", -99)
			End If
		Next

		' ======== cek kode ========
		If String.IsNullOrEmpty(txtNoTransaksi.Text) Then
			Return
		End If
		If Tipe = InputType.Edit AndAlso txtNoTransaksi.Text.ToLower = instance.Kode.ToLower Then
			Return
		End If

		Dim dataKode = New XPQuery(Of Travel_PembayaranInvoice)(session).Where(Function(w) w.Kode = txtNoTransaksi.Text).ToList
		If dataKode.Count > 0 Then
			Throw New Utils.Exception("Kode '" & txtNoTransaksi.Text & "' sudah ada yang memakai." & vbCrLf & "Harap ganti dengan kode lain", -1)
		End If
	End Sub
	Overrides Sub SimpanData()
		CheckBeforeSave()

		Try
			'======= Simpan Main
			If String.IsNullOrEmpty(txtNoTransaksi.Text) Then
				txtNoTransaksi.Text = instance.Number.GetNewNumber.Kode
			End If

			If Not txtKontak.EditValue Is Nothing Then
				instance.Pelanggan = CType(txtKontak.EditValue, Kontak)
			Else
				instance.Pelanggan = Nothing
			End If
			instance.Tanggal = txtTanggal.DateTime
			instance.Kode = txtNoTransaksi.Text
			instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
			instance.StatusTransaksi = CType(txtStatus.EditValue, StatusTransaksiEnum)

      instance.PembayaranPajak = False
      instance.BankCaraBayar = CType(txtCaraBayar.EditValue, Persistent.BankCaraBayar)
      instance.coakasbank = CType(txtAkun.EditValue, Coa)
			instance.Kurs = txtKurs.EditValue
			instance.Total = txtNilaiKas.EditValue
			instance.TotalValas = txtNilaiValas.EditValue
			instance.TotalAdminBank = txtNilaiAdministrasi.EditValue
			instance.TotalDiscount = txtNilaiPendapatan.EditValue
			instance.TotalPembulatan = txtNilaiPembulatan.EditValue
			instance.TotalPPH = txtNilaiPPH.EditValue
			instance.NomorPPH = txtNoPPH.EditValue
			instance.Uraian = txtUraian.EditValue

			'isikan detailnya
			For j = instance.Detail.Count - 1 To 0 Step -1
				Dim x = instance.Detail(j)
				Dim found = detailPiutang.Find(Function(f) f.Invoice Is x.NoInvoice AndAlso f.JumlahBayarValas > 0)
				If found Is Nothing Then
					x.Delete()
				End If
			Next

			Dim urutan = 1
			For Each item In detailPiutang
				If item.JumlahBayarValas > 0 Then
					Dim found = instance.Detail.ToList.Find(Function(f) f.NoInvoice Is item.Invoice)
					If found Is Nothing Then
						found = New Travel_PembayaranInvoiceDetail(session)
						found.Main = instance
						found.NoInvoice = item.Invoice
					End If
					found.Catatan = item.Catatan
					found.Kurs = item.KursBayar
					found.NilaiBayar = item.JumlahBayarValas
					found.NilaiBayarCash = item.JumlahBayarValas
					found.NilaiBayarRetur = 0
					found.Urutan = urutan
					urutan += 1
				End If
			Next

			TravelPembayaranServices.SetGL(instance, setting, settingsales)

			instance.Save()
			'======= Simpan instance
			session.CommitChanges()
		Catch ex As Utils.Exception
			Throw New Utils.Exception(ex)
		Catch ex As Exception
			If ex.Message.Contains("Duplicate entry") Then
				instance.Kode = instance.Number.GetNewNumber.Kode
				session.CommitChanges()
			Else
				Throw New Exception(ex.Message, ex.InnerException)
			End If
		End Try

    '======= Konfirmasi Cetak Laporan
    Dim frm As New RF_TravelDataTransaksi(Persistent.SumberDataJenis.CP, MainClass.reportName.zTravelVoucherCP)
    frm.txtNoBukti1.EditValue = instance.Kode

		Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
		Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.zTravelVoucherCP)
    message = String.Format(message, "Pembayaran Invoice")

		Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, settingsales.PreviewSave)
	End Sub
	Overrides Sub ErrorSimpan(ex As Utils.Exception)
		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case -1 : txtRegional.Focus()
			Case -2 : txtTanggal.Focus()
			Case -3 : txtKontak.Focus()
			Case -4 : txtUang.Focus()
			Case -5 : txtUraian.Focus()
			Case -99 : xGrid.Focus()
		End Select
	End Sub

	Private Sub ChangeCode()
		If txtTanggal.EditValue Is Nothing OrElse instance.Tanggal = Nothing Then
			Return
		End If
		If setting.FormatNomor.Contains(NuSoft001.My.Resources.FormatRegional) AndAlso (txtRegional.EditValue Is Nothing OrElse instance.Regional Is Nothing) Then
			Return
		End If
		If setting.FormatNomor.Contains(NuSoft001.My.Resources.FormatSumber) AndAlso instance.Sumber Is Nothing Then
			Return
		End If

		Dim nomor As Core.Modules.NumberResult = instance.Number.GetNewNumber
		'txtNoTransaksi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
		'txtNoTransaksi.Properties.Mask.EditMask = nomor.Mask
		txtNoTransaksi.Text = nomor.Kode
	End Sub
	Private Sub BindingDataSource()
		If settingsales.FilterKontak = True Then
			txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Id", settingsales.TipeKontak, BinaryOperatorType.Equal))
		Else
			txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
		End If
		txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
		txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
		txtCaraBayar.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.BankCaraBayar))
		txtAkun.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Kas, NuSoft001.Persistent.CoaEnum.eKind.Bank})
		txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
	End Sub
	Private Sub SetFormat()
		colNilaiInvoice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colNilaiInvoice.DisplayFormat.FormatString = setting.NumericFormatToString
		colNilaiInvoice.SummaryItem.DisplayFormat = setting.NumericFormatString
		colTerbayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colTerbayar.DisplayFormat.FormatString = setting.NumericFormatToString
		colTerbayar.SummaryItem.DisplayFormat = setting.NumericFormatString
		colSisaPiutang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colSisaPiutang.DisplayFormat.FormatString = setting.NumericFormatToString
		colSisaPiutang.SummaryItem.DisplayFormat = setting.NumericFormatString
		colJumlahBayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colJumlahBayar.DisplayFormat.FormatString = setting.NumericFormatToString
		colJumlahBayar.SummaryItem.DisplayFormat = setting.NumericFormatString
		colKursBayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colKursBayar.DisplayFormat.FormatString = setting.NumericFormatToString
		colKursBayar.SummaryItem.DisplayFormat = setting.NumericFormatString
		colJumlahBayarValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colJumlahBayarValas.DisplayFormat.FormatString = setting.NumericFormatToString
		colJumlahBayarValas.SummaryItem.DisplayFormat = setting.NumericFormatString

		txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtKurs.Properties.Mask.EditMask = setting.NumericFormatToString
		txtKurs.Properties.Mask.UseMaskAsDisplayFormat = True
		txtNilaiKas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtNilaiKas.Properties.Mask.EditMask = setting.NumericFormatToString
		txtNilaiKas.Properties.Mask.UseMaskAsDisplayFormat = True
		txtNilaiValas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtNilaiValas.Properties.Mask.EditMask = setting.NumericFormatToString
		txtNilaiValas.Properties.Mask.UseMaskAsDisplayFormat = True
		txtNilaiAdministrasi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtNilaiAdministrasi.Properties.Mask.EditMask = setting.NumericFormatToString
		txtNilaiAdministrasi.Properties.Mask.UseMaskAsDisplayFormat = True
		txtNilaiPembulatan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtNilaiPembulatan.Properties.Mask.EditMask = setting.NumericFormatToString
		txtNilaiPembulatan.Properties.Mask.UseMaskAsDisplayFormat = True
		txtNilaiPendapatan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtNilaiPendapatan.Properties.Mask.EditMask = setting.NumericFormatToString
		txtNilaiPendapatan.Properties.Mask.UseMaskAsDisplayFormat = True
		txtNilaiPPH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtNilaiPPH.Properties.Mask.EditMask = setting.NumericFormatToString
		txtNilaiPPH.Properties.Mask.UseMaskAsDisplayFormat = True
	End Sub
	Private Sub LoadDefault()
		Dim defaultRegional = UserInfo.GetDefaultRegional(session)
		lblKontakNama.Text = ""
		txtTanggal.EditValue = Now
		If Not defaultRegional Is Nothing Then
			txtRegional.EditValue = defaultRegional
		Else
			txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
		End If
		instance.Tanggal = txtTanggal.DateTime
		instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
		txtUraian.Text = settingsales.UraianCP
		txtAkun.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtAkun)
		txtNilaiKas.Value = 0
		txtKurs.Value = 1
		txtNilaiValas.Value = 0
		txtNilaiAdministrasi.Value = 0
		txtNilaiPembulatan.Value = 0
		txtNilaiPendapatan.Value = 0
		txtNilaiPPH.Value = 0
		txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
		txtCaraBayar.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtCaraBayar)
		UpdateKurs()
		xGrid.DataSource = Nothing
	End Sub
	Private Sub SetNomor()
		instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.CP)
		instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
	End Sub
	Private Sub DisableControl()
		'txtKontak.Enabled = False
		'txtTanggal.Enabled = False
		'txtNoTransaksi.Enabled = False
		'txtRegional.Enabled = False
		'txtTipe.Enabled = False
		'txtCashAdvance.Enabled = False
		'txtUraian.Enabled = False
		'txtAkun.Enabled = False
		'txtMataUang.Enabled = False
		'txtKurs.Enabled = False
		'xGridView.OptionsBehavior.Editable = False
		'txtCatatan.Enabled = False
		'txtCaraBayar.Enabled = False
		'txtNoCekGiro.Enabled = False
		'txtNoAC.Enabled = False
		'txtBank.Enabled = False
		'txtAkunGiro.Enabled = False
		'txtJatuhTempo.Enabled = False
		'AllowSave = False
	End Sub
	Private Sub GantiTanggalTahun()
		Dim str As String = "Edit tanggal dengan tahun berbeda akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"

		If Tipe = InputType.Edit AndAlso isShown Then
			If instance.Tanggal.Year <> CDate(txtTanggal.EditValue).Year Then
				If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Tanggal", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
					instance.Tanggal = txtTanggal.DateTime
					ChangeCode()
				Else
					txtTanggal.EditValue = instance.Tanggal
				End If
			Else
				instance.Tanggal = txtTanggal.DateTime
				ChangeCode()
			End If
		ElseIf Tipe = InputType.Tambah Then
			instance.Tanggal = txtTanggal.DateTime
			ChangeCode()
		End If
	End Sub
	Private Sub GantiTanggalBulan()
		Dim str As String = "Edit tanggal dengan bulan dan tahun berbeda akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"

		If Tipe = InputType.Edit AndAlso isShown Then
			If instance.Tanggal.Month <> CDate(txtTanggal.EditValue).Month OrElse instance.Tanggal.Year <> CDate(txtTanggal.EditValue).Year Then
				If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Tanggal", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
					instance.Tanggal = txtTanggal.DateTime
					ChangeCode()
				Else
					txtTanggal.EditValue = instance.Tanggal
				End If
			Else
				instance.Tanggal = txtTanggal.DateTime
				ChangeCode()
			End If
		ElseIf Tipe = InputType.Tambah Then
			instance.Tanggal = txtTanggal.DateTime
			ChangeCode()
		End If
	End Sub
	Private Sub UpdateKurs()
		If editAssign Then Return
		If txtUang.EditValue Is Nothing Then Return
		If CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Id = setting.MultiMataUangDefault Then
			txtKurs.Value = 1
			txtKurs.Properties.ReadOnly = True
		Else
			txtKurs.Value = NuSoft001.Logic.Kurs.getKursPajak(session, CType(txtUang.EditValue, NuSoft001.Persistent.MataUang), txtTanggal.DateTime)
			txtKurs.Properties.ReadOnly = False
		End If
	End Sub
	Private Sub UpdatePiutangSource()
		If editAssign Then Return
		If txtKontak.EditValue Is Nothing Then Return

		Dim daftarPiutang = New XPQuery(Of Travel_Invoice)(session).Where(Function(w) w.Pelanggan Is CType(txtKontak.EditValue, Kontak) AndAlso w.SisaPiutang > 0).ToList
		detailPiutang = New List(Of Travel_DaftarPembayaran)
		For Each item In daftarPiutang
			'Dim kurs = 1
			'If item.Uang.Id <> setting.MultiMataUangDefault Then kurs = NuSoft001.Logic.Kurs.getKursPajak(session, item.Uang, txtTanggal.DateTime)
			detailPiutang.Add(New Travel_DaftarPembayaran() With {
				.Invoice = item,
				.Terbayar = item.TotalPembayaran,
				.KursBayar = .Invoice.Kurs
			})
		Next

		'================ edit data
		If Tipe = InputType.Edit Then
			Dim itemEdit = session.GetObjectByKey(Of Travel_PembayaranInvoice)(Convert.ToInt64(IdToEdit))
			For Each item In itemEdit.Detail
				Dim found = detailPiutang.Find(Function(f) f.Invoice Is item.NoInvoice)
				If found Is Nothing Then
					found = New Travel_DaftarPembayaran() With {.Invoice = item.NoInvoice, .Terbayar = item.NoInvoice.TotalPembayaran}
					detailPiutang.Add(found)
				End If
				found.Terbayar -= item.NilaiBayarCash
				found.JumlahBayarValas = item.NilaiBayarCash
				found.KursBayar = item.Kurs
				found.JumlahBayar = item.NilaiBayarCashKurs
				found.Catatan = item.Catatan
			Next
		End If

		xGrid.DataSource = detailPiutang
	End Sub
	Private Sub HitungSaldo()
		If editAssign Then Return
		If txtUang.EditValue Is Nothing Then Return
		If detailPiutang Is Nothing Then Return

		Dim mataUang = CType(txtUang.EditValue, MataUang)
		Dim mataUangDefault = session.GetObjectByKey(Of MataUang)(setting.MultiMataUangDefault)
		Dim totalBayar = detailPiutang.Sum(Function(s) s.JumlahBayar)

		lbTotal.Text = String.Format("{0} {1}", mataUangDefault.Kode, totalBayar.ToString(setting.FormatAngka))
		txtNilaiKas.EditValue = totalBayar + ((CDbl(txtNilaiPendapatan.EditValue) + CDbl(txtNilaiPembulatan.EditValue) - CDbl(txtNilaiAdministrasi.EditValue) - CDbl(txtNilaiPPH.EditValue)) * CDbl(txtKurs.EditValue))
		If mataUang.Id = setting.MultiMataUangDefault Then
			txtNilaiValas.EditValue = 0
		Else
			txtNilaiValas.EditValue = CDbl(txtNilaiKas.EditValue) / CDbl(txtKurs.EditValue)
		End If
	End Sub

	Private Sub txtKontak_EditValueChanged(sender As Object, e As EventArgs) Handles txtKontak.EditValueChanged
		If txtKontak.EditValue Is Nothing Then Return
		Dim kontak = CType(txtKontak.EditValue, Kontak)
		lblKontakNama.Text = kontak.Nama

		UpdatePiutangSource()
		HitungSaldo()
	End Sub
	Private Sub txtRegional_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtRegional.EditValueChanging
		Dim str As String = "Edit regional transaksi akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"
		Try
			If Tipe = InputType.Edit AndAlso isShown Then
				If Not instance.Regional Is e.NewValue Then
					If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Regional", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
						instance.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
						ChangeCode()
					Else
						e.Cancel = True
					End If
				Else
					instance.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
					ChangeCode()
				End If
			ElseIf Tipe = InputType.Tambah Then
				instance.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
				ChangeCode()
			End If
		Catch ex As Exception
			If ex.Message.Contains("Object reference not set to an instance") Then
			Else
				DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Ganti Regional", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
			End If
		End Try
	End Sub
	Private Sub txtTanggal_DateTimeChanged(sender As Object, e As EventArgs) Handles txtTanggal.DateTimeChanged
		Dim str As String = "Edit tanggal dengan bulan dan tahun berbeda akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"
		Try
			If Tipe = InputType.Edit AndAlso isShown Then
				If instance.Tanggal.Month <> CDate(txtTanggal.EditValue).Month OrElse instance.Tanggal.Year <> CDate(txtTanggal.EditValue).Year Then
					If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Tanggal", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
						instance.Tanggal = txtTanggal.DateTime
						ChangeCode()
					Else
						txtTanggal.EditValue = instance.Tanggal
					End If
				Else
					instance.Tanggal = txtTanggal.DateTime
					ChangeCode()
				End If
			ElseIf Tipe = InputType.Tambah Then
				instance.Tanggal = txtTanggal.DateTime
				ChangeCode()
			End If

			UpdateKurs()
			HitungSaldo()
		Catch ex As Exception
			If ex.Message.Contains("Object reference not set to an instance") Then
			Else
				DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Me.Text, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
			End If
		End Try
	End Sub
	Private Sub Me_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
		isShown = True
	End Sub
	Protected Overrides Sub OnKeyDown(e As System.Windows.Forms.KeyEventArgs)
		MyBase.OnKeyDown(e)
		If e.Control AndAlso e.Shift Then
			'xGrid.Focus()
		End If
	End Sub
	Private Sub btnRefreshNomor_Click(sender As Object, e As EventArgs) Handles btnRefreshNomor.Click
		ChangeCode()
	End Sub
	Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
		BindingDataSource()
	End Sub

	Private Sub txtAkun_EditValueChanged(sender As Object, e As EventArgs) Handles txtAkun.EditValueChanged
		If txtAkun.EditValue Is Nothing Then Return

		Dim akun = CType(txtAkun.EditValue, Coa)
		Dim setting As New NuSoft001.Logic.FinaSetting(session)
		layAkunKasBankNama.Text = akun.Nama

		txtUang.EditValue = akun.MataUang
		UpdateKurs()
		HitungSaldo()
	End Sub
	Private Sub txtKurs_EditValueChanged(sender As Object, e As EventArgs) Handles txtKurs.EditValueChanged
		If editAssign Then Return
		If txtUang.EditValue Is Nothing Then Return
		If detailPiutang Is Nothing Then Return

		xGridView.BeginUpdate()
		Dim mataUang = CType(txtUang.EditValue, MataUang)
		For Each item In detailPiutang
			If item.Invoice.Uang Is mataUang Then
				item.KursBayar = txtKurs.Value
				item.JumlahBayar = item.JumlahBayarValas * item.KursBayar
			End If
		Next
		xGridView.EndUpdate()
		xGridView.UpdateSummary()
		HitungSaldo()
	End Sub
	Private Sub txtNilaiPPH_EditValueChanged(sender As Object, e As EventArgs) Handles txtNilaiAdministrasi.EditValueChanged, txtNilaiPembulatan.EditValueChanged, txtNilaiPendapatan.EditValueChanged, txtNilaiPPH.EditValueChanged
		HitungSaldo()
	End Sub
	Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
		Dim row = CType(xGridView.GetRow(e.RowHandle), Travel_DaftarPembayaran)
		If e.Column Is colJumlahBayarValas Then
			row.JumlahBayar = e.Value * row.KursBayar
		ElseIf e.Column Is colKursBayar Then
			row.JumlahBayar = row.JumlahBayarValas * e.Value
		ElseIf e.Column Is colJumlahBayar Then
			row.JumlahBayarValas = e.Value / row.KursBayar
		End If
		xGridView.UpdateSummary()
		HitungSaldo()
	End Sub
	Private Sub xGridView_ShowingEditor(sender As Object, e As CancelEventArgs) Handles xGridView.ShowingEditor
		Dim row = CType(xGridView.GetFocusedRow, Travel_DaftarPembayaran)
		If row.Invoice.AutoStatus = "Refund" Then e.Cancel = True
	End Sub
End Class