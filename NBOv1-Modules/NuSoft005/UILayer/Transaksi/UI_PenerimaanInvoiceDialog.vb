Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Friend Class UI_PenerimaanInvoiceDialog
  Private instance As Persistent.PenerimaanInvoice
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.PenerimaanInvoiceDetail)
  Private detailtodeleteDP As New List(Of Persistent.PenerimaanInvoiceDP)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private settingpurchase As Logic.PurchaseSetting
  Private sumber As Persistent.SumberDataCollection
  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.PenerimaanInvoice.AutoSaveOnEndEdit = False
    Persistent.PenerimaanInvoiceDetail.AutoSaveOnEndEdit = False
    Persistent.PenerimaanInvoiceDP.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    settingpurchase = New Logic.PurchaseSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("RITransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("RITransaksi.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("RITransaksiGrid.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("RITransaksiGrid.xml"))
    End If
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
		Dim xTipePajak As Persistent.eTipePajak
		If Tipe = InputType.Tambah Then
			instance = New Persistent.PenerimaanInvoice(session)
			instance.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
			xGrid.DataSource = Nothing
			LoadDefault()
			xTipePajak = Persistent.eTipePajak.TanpaPajak
			ChangeCode()
			txtKontak.Focus()
			xGrid.DataSource = instance.Detail
			xGridDP.DataSource = instance.DetailDP
		Else

			editAssign = True
			xGrid.DataSource = Nothing
			instance = session.GetObjectByKey(Of Persistent.PenerimaanInvoice)(Convert.ToInt64(IdToEdit))
			xTipePajak = instance.TipePajak
			setTipeTransaksi(instance.TipeTransaksi)
			txtNoTransaksi.Text = instance.Kode
			txtTanggal.EditValue = instance.Tanggal
			txtKontak.EditValue = instance.Vendor
			txtRegional.EditValue = instance.Regional
			txtKontakPerson.EditValue = instance.KontakPerson
			txtTglBerlaku.DateTime = instance.TanggalBerlaku
			txtUang.EditValue = instance.Uang
			txtKurs.Text = instance.Kurs
			txtPajak.EditValue = xTipePajak
			txtTermin.EditValue = instance.Termin
			txtUraian.Text = instance.Catatan
			txtTipeTransaksi.EditValue = instance.TipeTransaksi
			txtNoInvoiceVendor.EditValue = instance.NoReffVendor

			txtTermin.EditValue = instance.Termin
			txtTglBerlaku.EditValue = instance.TanggalBerlaku
			txtJenisPajak.EditValue = instance.JenisPajak
			txtNoPPN.Text = instance.NoSNPPN
			txtNoPPH.Text = instance.NoSNPPh
			txtKaryawan.EditValue = instance.Karyawan
			txtNoPO.EditValue = instance.NoOrder
			txtStatus.EditValue = instance.StatusTransaksi
			txtCoaHutang.EditValue = instance.CoaHutang

			xGrid.DataSource = instance.Detail
			xGridDP.DataSource = instance.DetailDP
			editAssign = False
			HitungTotal()
		End If
		setTipeTransaksi(CType(txtTipeTransaksi.EditValue, Persistent.eTipeInvoicePembelian))
		txtPajak.EditValue = xTipePajak
		SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Penerimaan Invoice [RI] : Tambah Data"
    Else
      Me.Text = "Penerimaan Invoice [RI] : Edit Data " & instance.Kode
      If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
        DisableControl(True)
      End If
      If NuSoft001.Persistent.Periode.CheckLockedPeriod(session, instance.Tanggal) Then
        DisableControl(False)
      End If
      If NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit = False Then
        DisableControl(False)
      End If
    End If
  End Sub
  Overrides Sub SimpanData()
    If (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
      Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If

    For i = detailToDelete.Count - 1 To 0 Step -1
      detailToDelete(i).Delete()
    Next

    'Dim xSetingCoaHutang As Persistent.eTipeHutangInvoice

    Try
      'Dim xCoaHutang As NuSoft001.Persistent.Coa, pRegional As Persistent.xRegional
      'pRegional = session.GetObjectByKey(Of Persistent.xRegional)(CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id)
      ''hutang dagang (K)
      'Select Case xSetingCoaHutang
      '  Case Persistent.eTipeHutangInvoice.Uang : xCoaHutang = instance.Uang.HutangDagang
      '  Case Persistent.eTipeHutangInvoice.Regional : xCoaHutang = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(pRegional.CoaAP))
      '  Case Persistent.eTipeHutangInvoice.Manual : xCoaHutang = CType(txtCoaHutang.EditValue, NuSoft001.Persistent.Coa)
      '  Case Else : xCoaHutang = instance.Uang.HutangDagang
      'End Select

      'xCoaHutang = instance.Uang.HutangDagang
      '======= Simpan Main
      If Tipe = InputType.Tambah Then
        If txtNoTransaksi.EditValue Is Nothing Then
          txtNoTransaksi.EditValue = instance.Number.GetNewNumber.Kode
        End If
      End If

      If Not txtKontak.EditValue Is Nothing Then
        instance.Vendor = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      Else
        instance.Vendor = Nothing
      End If
      instance.Kode = txtNoTransaksi.Text
      instance.Tanggal = txtTanggal.DateTime
      instance.KontakPerson = txtKontakPerson.EditValue
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.TipePajak = CType(txtPajak.EditValue, Persistent.eTipePajak)
      instance.Uang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang)
      instance.Kurs = CType(txtKurs.Text, Double)
      instance.Termin = CType(txtTermin.EditValue, Persistent.Termin)
      instance.TanggalBerlaku = txtTglBerlaku.DateTime
      instance.JenisPajak = CType(txtJenisPajak.EditValue, Persistent.eJenisPajak)
      instance.NoSNPPN = txtNoPPN.Text
      instance.NoSNPPh = txtNoPPH.Text
      instance.Catatan = txtUraian.Text
      instance.NoReffVendor = txtNoInvoiceVendor.Text

      instance.Karyawan = CType(txtKaryawan.EditValue, NuSoft001.Persistent.Kontak)
      instance.NoOrder = CType(txtNoPO.EditValue, Persistent.OrderPembelian)
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
      instance.TipeTransaksi = CType(txtTipeTransaksi.EditValue, Persistent.eTipeInvoicePembelian)
			instance.CoaHutang = CType(txtCoaHutang.EditValue, NuSoft001.Persistent.Coa)

			For pi = 0 To instance.Detail.Count - 1
				instance.Detail(pi).Barang.LastPurchase = instance.Detail(pi).Harga
			Next

			'jurnalnya
			instance.Gl.Sumber = instance.Sumber
      instance.Gl.Tanggal = txtTanggal.EditValue
      instance.Gl.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.Gl.Kode = txtNoTransaksi.Text
      instance.Gl.ModuleId = NPO.Modules.ModuleId.Purchase
      instance.Gl.MataUang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Simbol
      instance.Gl.Kurs = txtKurs.EditValue
      instance.Gl.Kontak = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      instance.Gl.KontakNama = txtKontak.Text
      instance.Gl.Uraian = txtUraian.Text

      Dim i As Byte = 1
			If CType(txtTipeTransaksi.EditValue, Persistent.eTipeInvoicePembelian) = Persistent.eTipeInvoicePembelian.PakaiPO Then
				'hutang sementara  (D) -->ambilkan dari DPP
				'MsgBox("nilainya : " & instance.Detail.Sum(Function(m) m.PenerimaanBarang.SubTotal) * instance.Kurs)
				SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingpurchase.CoaHutangSementara)), i, instance.Detail.Sum(Function(m) m.PenerimaanBarang.SubTotal) * instance.Kurs, 0, instance.Detail.Sum(Function(m) m.PenerimaanBarang.SubTotal), 0)
				i = i + 1

				''carikan jika ada selisih
				'Dim xPenerimaan As Double = instance.Detail.Sum(Function(m) m.PenerimaanBarang.SubTotal) * instance.Kurs
				'Dim xHutang As Double = instance.SubTotal * instance.Kurs
				'Dim xSelisih As Double = xHutang - xPenerimaan

				'If xSelisih <> 0 Then
				'	SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingpurchase.CoaSelisihRI)), i, xSelisih, 0, 0, 0)
				'	i = i + 1
				'End If
			Else
				'biaya hpp (jasa) (D)
				Dim a = From z In instance.Detail Group z By z.Barang.CoaCost, z.Proyek Into Group Select CoaCost, Proyek, SubTotal = Group.Sum(Function(x) x.DPP * x.Main.Kurs)
        For Each x In a
          SimpanGL(x.CoaCost, i, x.SubTotal, 0, 0, 0, "", x.Proyek)
          i = i + 1
        Next
      End If

      If instance.PPN > 0 Then      'PPN (D)
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingpurchase.CoaPPN)), i, (instance.PPN - instance.NilaiDPPajak) * instance.Kurs, 0, 0, 0)
        i = i + 1
      End If
      If instance.NilaiDP > 0 Then 'DP (K)
        SimpanGL(CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).UMPembelian, i, 0, (instance.NilaiDP - instance.NilaiDPPajak) * instance.Kurs, 0, (instance.NilaiDP - instance.NilaiDPPajak))
        i = i + 1
      End If

      If instance.PPH > 0 Then      'PPH (K)
        SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingpurchase.CoaPPH)), i, 0, instance.PPH * instance.Kurs, 0, 0)
        i = i + 1
      End If

      'DP nya

      'If settingpurchase.SetingAPRegional = False Then
      '  xCoaHutang = instance.Uang.HutangDagang
      'Else
      '  xCoaHutang = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(pRegional.CoaAP))
      'End If
      'SimpanGL(instance.Uang.HutangDagang, i, 0, instance.Total * instance.Kurs, 0, instance.Total)
      SimpanGL(instance.CoaHutang, i, 0, instance.Total * instance.Kurs, 0, instance.Total)
      i = i + 1

      ''selisih kurs antara penerimaan barang dengan invoice
      If CType(txtTipeTransaksi.EditValue, Persistent.eTipeInvoicePembelian) = Persistent.eTipeInvoicePembelian.PakaiPO Then
        If instance.SelisihKurs <> 0 Then
          If instance.Uang.Id = setting.MultiMataUangDefault Then
            If instance.SelisihKurs > 0 Then
							SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingpurchase.CoaSelisihRI)), i, 0, instance.SelisihKurs, 0, 0, "Selisih pembulatan")
						Else
							SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingpurchase.CoaSelisihRI)), i, (instance.SelisihKurs * -1), 0, 0, 0, "Selisih pembulatan")
						End If
          Else
            If instance.SelisihKurs > 0 Then
              SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(setting.MultiMataUangAkunKurs)), i, 0, instance.SelisihKurs, 0, 0, "Selisih kurs penerimaan barang")
            Else
              SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(setting.MultiMataUangAkunKurs)), i, (instance.SelisihKurs * -1), 0, 0, 0, "Selisih kurs penerimaan barang")
            End If
          End If
          i = i + 1
        End If
      End If

      'Dim xMessage As String = ""
      'MsgBox("Jumlahnya adalah :" & instance.Gl.Detail.Count - 1)
      'For i = 0 To instance.Gl.Detail.Count - 1
      '  xMessage += i & ":" & instance.Gl.Detail(i).Akun.Nama.ToString & " " & instance.Gl.Detail(i).Debit.ToString & "~" & instance.Gl.Detail(i).Kredit.ToString & vbCrLf
      'Next
      'MsgBox(xMessage)

      instance.Save()

      'update status penerimaan
      If Not instance.NoOrder Is Nothing Then
        Dim c = From z In instance.Detail Group By z.PenerimaanBarang Into Group Select PenerimaanBarang, Qty = Group.Sum(Function(x) x.Qty)
        For Each x In c
          x.PenerimaanBarang.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
        Next
      End If
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
    Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.RI)
    frm.txtNoBukti1.EditValue = instance.Kode
    'frm.txtTgl1.DateTime = instance.Tanggal
    'frm.txtTgl2.DateTime = Nothing

    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.VoucherPenerimaanInvoice)
    message = String.Format(message, "Invoice Pembelian")

    Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, settingpurchase.PreviewReport)
  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtRegional.Focus()
      Case -3 : txtUraian.Focus()
      Case -4 : txtTanggal.Focus()
      Case -5, -7 : xGrid.Focus()
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
    txtNoTransaksi.Text = nomor.Kode
  End Sub
  Private Sub BindingDataSource()
    If settingpurchase.FilterKontak = True Then
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Id", settingpurchase.TipeKontak, BinaryOperatorType.Equal))
    Else
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
    End If
    txtKaryawan.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
    txtTermin.Properties.DataSource = New XPCollection(Of Persistent.Termin)(session)
    txtPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eTipePajak))
    txtJenisPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eJenisPajak))
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
    txtJenis.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.TipeTransaksi)(session)
    txtTipeTransaksi.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eTipeInvoicePembelian))
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
    colSatuanRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Satuan)(session)
    colDivisiRepo.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(session)
    colProyekRepo.DataSource = New XPCollection(Of NuSoft001.Persistent.Proyek)(session)
    txtCoaHutang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Coa)(session)
  End Sub
  Private Sub SetFormat()
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatToString
    colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
    colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHarga.DisplayFormat.FormatString = setting.NumericFormatToString
    colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotal.DisplayFormat.FormatString = setting.NumericFormatToString
    colPPH.SummaryItem.DisplayFormat = setting.NumericFormatString
    colPPN.SummaryItem.DisplayFormat = setting.NumericFormatString
    colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString
    colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colSubTotal.DisplayFormat.FormatString = setting.NumericFormatToString
    colDisc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDisc.DisplayFormat.FormatString = setting.NumericFormatToString
    colDiscP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDiscP.DisplayFormat.FormatString = setting.NumericFormatToString

    txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtSubTotal.Properties.Mask.EditMask = setting.NumericFormatToString
    txtPPN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtPPN.Properties.Mask.EditMask = setting.NumericFormatToString
    txtPPH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtPPH.Properties.Mask.EditMask = setting.NumericFormatToString
    txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtTotal.Properties.Mask.EditMask = setting.NumericFormatToString
    txtDP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtDP.Properties.Mask.EditMask = setting.NumericFormatToString
    colNilaiDP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiDP.DisplayFormat.FormatString = setting.NumericFormatToString
    colNilaiDP.SummaryItem.DisplayFormat = setting.NumericFormatString
    colNilaiPajak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiPajak.DisplayFormat.FormatString = setting.NumericFormatToString
    colNilaiPajak.SummaryItem.DisplayFormat = setting.NumericFormatString
  End Sub
  Private Sub LoadDefault()
    If xpSettingRegional Is Nothing Then
      xpSettingRegional = New XPCollection(Of NuSoft001.Persistent.SettingRegional)(session)
    End If
    defaultRegional = UserInfo.GetDefaultRegional(session)
    txtTanggal.EditValue = Now
    If Not defaultRegional Is Nothing Then
      txtRegional.EditValue = defaultRegional
    Else
      txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
    End If
    instance.Tanggal = txtTanggal.DateTime
    instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
    txtPajak.EditValue = Persistent.eTipePajak.TanpaPajak
    txtKurs.Text = 1.0
    txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
    txtTipeTransaksi.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtTipeTransaksi)
    txtUang.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
    txtUraian.EditValue = settingpurchase.UraianRI
    txtJenisPajak.EditValue = Persistent.eJenisPajak.Penggantian
    txtCoaHutang.EditValue = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).HutangDagang
    setTipeTransaksi(txtTipeTransaksi.EditValue)
  End Sub
  'Private Sub SetNomor()
  '  instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.RI)
  '  instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  'End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.RI)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
    instance.Gl.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl(xSave As Boolean)
    txtKontak.Enabled = False
    txtKontak.Properties.ReadOnly = True
    txtTanggal.Enabled = False
    txtNoTransaksi.Enabled = False
    txtNoTransaksi.Properties.ReadOnly = True
    txtStatus.Enabled = False
    txtRegional.Enabled = False
    txtTipeTransaksi.Enabled = False
    txtUang.Enabled = False
    txtKurs.Enabled = False
    txtKontakPerson.Enabled = False
    txtPajak.Enabled = False
    txtNoInvoiceVendor.Enabled = False
    txtTglBerlaku.Enabled = False
    txtTermin.Enabled = False
    txtNoPO.Enabled = False
    txtKaryawan.Enabled = False
    txtJenisPajak.Enabled = False
    txtNoPPN.Enabled = False
    txtNoPPH.Enabled = False
    txtCoaHutang.Enabled = False
    txtJenis.Enabled = False
    btnRefreshNomor.Enabled = False
    btnRefreshNomor.Enabled = False
    xGridView.OptionsBehavior.Editable = False
    'xGridDPView.OptionsBehavior.Editable = False

    txtTanggal.Enabled = xSave
    txtUraian.Enabled = xSave
    AllowSave = xSave
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

  Private Function GetViewInfo(navBar As NavBarControl) As NavBarViewInfo
    Dim fi As FieldInfo = GetType(NavBarControl).GetField("viewInfo", BindingFlags.NonPublic Or BindingFlags.Instance)
    Return CType(fi.GetValue(navBar), NavBarViewInfo)
  End Function
  Private Function GetGroupPainter(navBar As NavBarControl) As ExplorerBarNavGroupPainter
    Dim fi As FieldInfo = GetType(NavBarControl).GetField("groupPainter", BindingFlags.NonPublic Or BindingFlags.Instance)
    Return CType(fi.GetValue(navBar), ExplorerBarNavGroupPainter)
  End Function
  Private Sub navCatatan_CalcGroupClientHeight(sender As Object, e As NavBarCalcGroupClientHeightEventArgs) Handles navCatatan.CalcGroupClientHeight
    Dim vi As NavBarViewInfo = GetViewInfo(NavBarControl1)
    Dim gi As NavGroupInfoArgs = CType(vi.Groups((vi.Groups.Count - 1)), NavGroupInfoArgs)
    Dim groupPainter As ExplorerBarNavGroupPainter = GetGroupPainter(NavBarControl1)
    'groupPainter.CalcFooterBounds(gi, gi.Bounds)
    Dim delta As Integer = gi.Bounds.Top - vi.Client.Top
    Dim ch As Integer = vi.Client.Height - delta - gi.Bounds.Height - gi.FooterBounds.Height
    e.Height = ch
  End Sub

  Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
    If Not e.NewValue Is Nothing Then
      lblKontakNama.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Nama
      'isikan data detailnya
      txtPhoneNumber.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Telepon
      txtDebitLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasPiutang)
      txtCreditLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasHutang)

      txtKontakPerson.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakPerson)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))
      If instance.NoOrder Is Nothing Then
        txtNoPO.Properties.DataSource = New XPCollection(Of Persistent.PenerimaanBarang)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal), New BinaryOperator("StatusTransaksi", NuSoft001.Persistent.StatusTransaksiEnum.Posting))).GroupBy(Function(m) m.NoOrder).Select(Function(m) m.Key)
      Else
        txtNoPO.Properties.DataSource = New XPCollection(Of Persistent.PenerimaanBarang)(session, New GroupOperator(GroupOperatorType.Or, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})), New BinaryOperator("NoOrder", instance.NoOrder.Id, BinaryOperatorType.Equal))).GroupBy(Function(m) m.NoOrder).Select(Function(m) m.Key)
      End If

      xGHistory.DataSource = New XPCollection(Of Persistent.PenerimaanInvoice)(session, New BinaryOperator("Vendor", e.NewValue, BinaryOperatorType.Equal))

      If editAssign = False Then
        'hapus transaksi detailnya dulu,
        For i = instance.Detail.Count - 1 To 0 Step -1
          instance.Detail(i).Delete()
        Next
        For i = instance.DetailDP.Count - 1 To 0 Step -1
          instance.DetailDP(i).Delete()
        Next
      End If
    End If
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
        End If
      ElseIf Tipe = InputType.Tambah Then
        instance.Tanggal = txtTanggal.DateTime
        ChangeCode()
      End If
    Catch ex As Exception
      If ex.Message.Contains("Object reference not set to an instance") Then
      Else
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Me.Text, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
      End If
    End Try
    If Not txtUang.EditValue Is Nothing Then
      Dim setting As New NuSoft001.Logic.FinaSetting(session)
      If CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Id = setting.MultiMataUangDefault Then
        txtKurs.Text = 1
      Else
        txtKurs.Text = NuSoft001.Logic.Kurs.getKursPajak(session, CType(txtUang.EditValue, NuSoft001.Persistent.MataUang), txtTanggal.DateTime)
      End If
    End If

  End Sub
  Private Sub Me_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
    isShown = True
  End Sub
  Protected Overrides Sub OnKeyDown(e As System.Windows.Forms.KeyEventArgs)
    MyBase.OnKeyDown(e)
    If e.Control AndAlso e.Shift Then
      xGrid.Focus()
    End If
  End Sub
  Private Sub btnRefreshNomor_Click(sender As Object, e As EventArgs) Handles btnRefreshNomor.Click
    ChangeCode()
  End Sub
  Private Sub txtNoPO_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtNoPO.EditValueChanging
    If Not e.NewValue Is Nothing And editAssign = False Then
      Dim setting As New NuSoft001.Logic.FinaSetting(session)
      Dim xDataPO As Persistent.OrderPembelian = CType(e.NewValue, Persistent.OrderPembelian)
      Dim data As Persistent.PenerimaanInvoiceDetail
      txtKontakPerson.EditValue = xDataPO.KontakPerson
      txtPajak.EditValue = xDataPO.TipePajak
      txtUang.EditValue = xDataPO.Uang
      txtTermin.EditValue = xDataPO.Termin
      txtKaryawan.EditValue = xDataPO.Karyawan
      instance.TipePajak = xDataPO.TipePajak
      If CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Id = setting.MultiMataUangDefault Then
        txtKurs.Text = 1
        txtKurs.Properties.ReadOnly = True
      Else
        txtKurs.Text = NuSoft001.Logic.Kurs.getKursPajak(session, CType(txtUang.EditValue, NuSoft001.Persistent.MataUang), txtTanggal.DateTime)
        txtKurs.Properties.ReadOnly = False
      End If
      If Not txtTermin.EditValue Is Nothing Then
        txtTglBerlaku.EditValue = DateAdd(DateInterval.Day, CType(txtTermin.EditValue, Persistent.Termin).Tempo, txtTanggal.DateTime)
      End If

      Dim xCoaHutang As NuSoft001.Persistent.Coa, pRegional As Persistent.xRegional
      pRegional = session.GetObjectByKey(Of Persistent.xRegional)(CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id)
      'hutang dagang (K)
      Select Case CType(settingpurchase.SettingCoaHutang, Persistent.eTipeHutangInvoice)
        Case Persistent.eTipeHutangInvoice.Uang : xCoaHutang = xDataPO.Uang.HutangDagang
        Case Persistent.eTipeHutangInvoice.Regional : xCoaHutang = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(pRegional.CoaAP))
        Case Else : xCoaHutang = xDataPO.Uang.HutangDagang
      End Select
      txtCoaHutang.EditValue = xCoaHutang


      For i = instance.Detail.Count - 1 To 0 Step -1
        instance.Detail(i).Delete()
      Next
      'Dim xDataGR As Persistent.PenerimaanBarang = session.FindObject(Of Persistent.PenerimaanBarang)(New GroupOperator(GroupOperatorType.And, New BinaryOperator("NoOrder", xDataPO, BinaryOperatorType.Equal), New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})))
      Dim xDataGR As New XPCollection(Of Persistent.PenerimaanBarangDetail)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("OrderDetail.Main", xDataPO, BinaryOperatorType.Equal), New InOperator("Main.StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress})))
      For i = 0 To xDataGR.Count - 1
        data = New Persistent.PenerimaanInvoiceDetail(session)
        data.Barang = xDataGR(i).Barang
        data.Qty = xDataGR(i).Qty
        data.Satuan = xDataGR(i).Satuan
        data.Harga = xDataGR(i).OrderDetail.Harga
        data.DiscountPersen = xDataGR(i).OrderDetail.DiscountPersen
        data.Discount = (data.DiscountPersen / 100) * data.Harga '(row.DiscountPersen / 100) * (row.Harga)
        data.PPN = xDataGR(i).OrderDetail.PPN
        data.PPNp = xDataGR(i).OrderDetail.PPNp
        data.PPH = xDataGR(i).OrderDetail.PPH
        data.PPHp = xDataGR(i).OrderDetail.PPHp
        data.Catatan = xDataGR(i).Catatan
        data.Divisi = xDataGR(i).Divisi
        data.Proyek = xDataGR(i).OrderDetail.Proyek
        data.PenerimaanBarang = xDataGR(i)
        instance.Detail.Add(data)
      Next
      'isikan data DP
      For i = instance.DetailDP.Count - 1 To 0 Step -1
        instance.DetailDP(i).Delete()
      Next
      Dim DataDP As New XPCollection(Of Persistent.DPPembelian)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("PO", xDataPO, BinaryOperatorType.Equal), New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.AP, BinaryOperatorType.Equal)))

      Dim item As Persistent.PenerimaanInvoiceDP
      For pI = 0 To DataDP.Count - 1
        item = New Persistent.PenerimaanInvoiceDP(session)
        item.DP = DataDP(pI)
        item.NilaiDP = DataDP(pI).NilaiDP
        item.NilaiPajak = DataDP(pI).PPNValue
        instance.DetailDP.Add(item)
      Next
      xGridDP.DataSource = instance.DetailDP
      HitungTotal()
    End If
  End Sub
  Private Sub HitungTotal()
    txtSubTotal.EditValue = instance.SubTotal
    txtPPN.EditValue = instance.PPN
    txtPPH.EditValue = instance.PPH
    txtDP.EditValue = instance.NilaiDP
    txtTotal.EditValue = instance.Total
  End Sub
  Private Sub SimpanGL(Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, DebitValas As Double, KreditValas As Double, Optional Catatan As String = "", Optional Proyek As NuSoft001.Persistent.Proyek = Nothing)
    Dim item As Persistent.GlMainDetail
    'MsgBox("Akun : " & Akun.Nama & "->" & Debit.ToString("n2") & " --> " & Kredit.ToString("n2"))
    If (Debit + Kredit) <> 0 Then
      If instance.Gl.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
        item = instance.Gl.Detail.Single(Function(m) m.Urutan = Urutan)

        item.Akun = Akun
        item.MataUang = item.Akun.MataUang
        item.Main = instance.Gl
        item.Urutan = Urutan
        item.Debit = Debit
        item.Kredit = Kredit
        item.Keterangan = Catatan
        If Akun.MataUang.Id = setting.MultiMataUangDefault Then
          item.DebitValas = 0
          item.KreditValas = 0
          item.Kurs = 1
        Else
          item.DebitValas = DebitValas
          item.KreditValas = KreditValas
          item.Kurs = txtKurs.EditValue
        End If
        'item.Proyek = Proyek
      Else
        item = New Persistent.GlMainDetail(session)

        item.Akun = Akun
        item.MataUang = item.Akun.MataUang
        item.Main = instance.Gl
        item.Urutan = Urutan
        item.Debit = Debit
        item.Kredit = Kredit
        item.Keterangan = Catatan
        If Akun.MataUang.Id = setting.MultiMataUangDefault Then
          item.DebitValas = 0
          item.KreditValas = 0
          item.Kurs = 1
        Else
          item.DebitValas = DebitValas
          item.KreditValas = KreditValas
          item.Kurs = txtKurs.EditValue
        End If
        'item.Proyek = Proyek
        instance.Gl.Detail.Add(item)
      End If

    End If
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub
  Private Sub setTipeTransaksi(xTipe As Persistent.eTipeInvoicePembelian)
		If xTipe = Persistent.eTipeInvoicePembelian.PakaiPO Then
			txtPajak.Properties.ReadOnly = True
			txtUang.Properties.ReadOnly = True
			txtPajak.EditValue = Persistent.eTipePajak.TanpaPajak
			xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
			colKodeBarangRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Barang)(session)
			xGridView.OptionsBehavior.ReadOnly = True
		Else
			txtPajak.Properties.ReadOnly = False
			txtUang.Properties.ReadOnly = False
			xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
			colKodeBarangRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Barang)(session)
			xGridView.OptionsBehavior.ReadOnly = False
			If editAssign = False Then
				txtNoPO.EditValue = Nothing
				For pI = instance.Detail.Count - 1 To 0 Step -1
					instance.Detail(pI).Delete()
				Next
			End If
			HitungTotal()
		End If
		If settingpurchase.EditHargaRI = True Then
			xGridView.OptionsBehavior.ReadOnly = False
			colQty.OptionsColumn.AllowEdit = True
			colQty.OptionsColumn.ReadOnly = False
			colHarga.OptionsColumn.AllowEdit = True
			colHarga.OptionsColumn.ReadOnly = False
		End If
	End Sub
  Private Sub txtTipeTransaksi_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTipeTransaksi.EditValueChanging
    If Not e.NewValue Is Nothing And editAssign = False Then
      setTipeTransaksi(CType(e.NewValue, Persistent.eTipeInvoicePembelian))
    End If
  End Sub
  Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    If Not e.Value Is Nothing Then
      Dim row As Persistent.PenerimaanInvoiceDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.PenerimaanInvoiceDetail)
      If e.Column Is colKodeBarang Then
        If Not row Is Nothing Then
          Dim xbarang As NuSoft004.Persistent.Barang = CType(e.Value, NuSoft004.Persistent.Barang)
          row.Satuan = xbarang.Satuan
          row.Harga = xbarang.LastPurchase
          row.PPN = xbarang.PajakIN
          row.PPH = xbarang.PajakOUT
          row.PPNp = xbarang.PajakIN.NilaiPajak
          row.PPHp = xbarang.PajakOUT.NilaiPajak
        End If
      End If
      HitungTotal()
    End If
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("RITransaksiGrid.xml"))
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.PenerimaanInvoiceDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.PenerimaanInvoiceDetail)
    row.Barang = Nothing
    row.Qty = 0
    row.Main = instance
    row.Catatan = ""
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If CType(txtTipeTransaksi.EditValue, Persistent.eTipeInvoicePembelian) = Persistent.eTipeInvoicePembelian.TanpaPO Then
      If e.KeyCode = Windows.Forms.Keys.Delete Then
        Dim Id As Persistent.PenerimaanInvoiceDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.PenerimaanInvoiceDetail)
        xGridView.DeleteRow(xGridView.FocusedRowHandle)
        detailToDelete.Add(Id)
      End If
    End If
  End Sub
  Private Sub txtPajak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPajak.EditValueChanging
    If Not e.NewValue Is Nothing Then
      instance.TipePajak = CType(e.NewValue, Persistent.eTipePajak)
      xGrid.RefreshDataSource()
      HitungTotal()
    End If
  End Sub
End Class