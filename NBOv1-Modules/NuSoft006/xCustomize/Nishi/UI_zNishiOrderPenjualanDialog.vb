Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors.Controls

Friend Class UI_zNishiOrderPenjualanDialog
  Private instance As NuSoft004.Persistent.NishiOrderPembelian
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of NuSoft004.Persistent.NishiOrderPembelianDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Private salesSetting As Logic.SalesSetting

  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    NuSoft004.Persistent.NishiOrderPembelian.AutoSaveOnEndEdit = False
    NuSoft004.Persistent.NishiOrderPembelianDetail.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    xGridView.OptionsLayout.StoreAllOptions = True
    setting = New NuSoft001.Logic.FinaSetting(session)
    salesSetting = New Logic.SalesSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SOTransaksi.xml")) = True Then
    '  lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SOTransaksi.xml"))
    'End If
    'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SOTransaksiGrid.xml")) = True Then
    '  xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SOTransaksiGrid.xml"))
    'End If
    'colDivisi.Visible = setting.MultiDivisi
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New NuSoft004.Persistent.NishiOrderPembelian(session)
      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
      gridInvoice.DataSource = instance.Invoice
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of NuSoft004.Persistent.NishiOrderPembelian)(Convert.ToInt64(IdToEdit))
      txtStatus.EditValue = instance.StatusTransaksi
      txtNoTransaksi.Text = instance.Kode
      txtTanggal.EditValue = instance.Tanggal
      txtKontak.EditValue = instance.Pelanggan
      txtRegional.EditValue = instance.Regional
      txtKontakPerson.EditValue = instance.KontakPerson
      txtUraian.Text = instance.Uraian
      txtTipeJO.EditValue = instance.JenisJO
      txtJenisBarang.EditValue = instance.TipeBarangJO
      txtNoRef.Text = instance.ReffNo
      txtQty.EditValue = instance.Qty
      txtSatuan.EditValue = instance.Satuan


      If instance.JenisJO = NuSoft004.Persistent.NishiJenisJO.Ekspor Then
        eTxtBillLading.EditValue = instance.d_blno
        eTxtConsignee.EditValue = instance.d_consignee
        If Not instance.d_coo.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtCOO.EditValue = instance.d_coo
        If Not instance.d_eta.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtETA.EditValue = instance.d_eta
        If Not instance.d_etd.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtETD.EditValue = instance.d_etd
        eTxtGW.EditValue = instance.d_gw
        If Not instance.d_insurance.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtInsurance.EditValue = instance.d_insurance
        eTxtInvoiceNo.EditValue = instance.d_invono
        If Not instance.d_invdate.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtInvoiceTanggal.EditValue = instance.d_invdate
        txteAmountInvoice.EditValue = instance.AmountInvoice

        eTxtMeass.EditValue = instance.d_meass
        eTxtNPE.EditValue = instance.d_npeno
        eTxtNW.EditValue = instance.d_nw
        eTxtOther.EditValue = instance.d_other
        eTxtPackingNo.EditValue = instance.d_packingno
        If Not instance.d_packingdate.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtPackingTanggal.EditValue = instance.d_packingdate
        eTxtParty.EditValue = instance.d_party
        eTxtPEBNo.EditValue = instance.d_pebno
        If Not instance.d_pickup.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtPickup.EditValue = instance.d_pickup
        eTxtShipper.EditValue = instance.d_shipper
        eTxtShipping.EditValue = instance.d_shippinginstruction
        eTxtVessel.EditValue = instance.d_vessel
        eTxtTujuan.Text = instance.d_tujuan
        If Not instance.d_tglsi.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtTglSI.EditValue = instance.d_tglsi
        If Not instance.d_tglreqtrucking.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtTglRecTrucking.EditValue = instance.d_tglreqtrucking
        If Not instance.d_tglsurattugas.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtTglSuratTugas.EditValue = instance.d_tglsurattugas

        If Not instance.d_pebtglreq.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtPEBReq.EditValue = instance.d_pebtglreq
        If Not instance.d_pebtglterima.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtPEBTerima.EditValue = instance.d_pebtglterima
        If Not instance.d_bltglreq.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtBLReq.EditValue = instance.d_bltglreq
        If Not instance.d_bltglterima.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtBLTerima.EditValue = instance.d_bltglterima
        eTxtBLSurender.EditValue = instance.d_blorisurender
        If Not instance.d_asuransitglreq.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtAsuransiReq.EditValue = instance.d_asuransitglreq
        If Not instance.d_asuransitglterima.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtAsuransiTerima.EditValue = instance.d_asuransitglterima
        If Not instance.d_cootgldraft.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtCOODraft.EditValue = instance.d_cootgldraft
        If Not instance.d_cootglkomunikasi.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtCOOKomunikasi.EditValue = instance.d_cootglkomunikasi
        If Not instance.d_cootglpersetujuan.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtCOOPersetujuan.EditValue = instance.d_cootglpersetujuan
        eTxtPOLPOD.Text = instance.d_polpod
        eTxtMBL.Text = instance.d_nombl
        eTxtPabean.Text = instance.d_nopabean
        If Not instance.d_tglaju.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtAju.Text = instance.d_tglaju
        etxtNoAju.Text = instance.d_ajouno
        If Not instance.d_original.ToString("dd/mm/yyyy") = "01/00/0001" Then eTxtTerimaOriginal.EditValue = instance.d_original
      End If
      If instance.JenisJO = NuSoft004.Persistent.NishiJenisJO.Impor Then
        itxtAJOU.EditValue = instance.d_ajouno
        If Not instance.d_billing.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtBilling.EditValue = instance.d_billing
        itxtBLNo.EditValue = instance.d_blno
        If Not instance.d_bpn.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtBPN.EditValue = instance.d_bpn
        itxtConsignee.EditValue = instance.d_consignee
        If Not instance.d_delivery.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtDelivery.EditValue = instance.d_delivery
        If Not instance.d_do.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtDO.EditValue = instance.d_do
        itxtDraftPIB.EditValue = instance.d_pib
        If Not instance.d_email.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtEmail.EditValue = instance.d_email
        If Not instance.d_draftpib.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtDraftPIB.EditValue = instance.d_draftpib
        If Not instance.d_eta.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtETA.EditValue = instance.d_eta
        itxtGW.EditValue = instance.d_gw
        itxtInvoiceNo.EditValue = instance.d_invono
        If Not instance.d_invdate.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtInvoiceTgl.EditValue = instance.d_invdate
        itxtMeass.EditValue = instance.d_meass
        itxtNW.EditValue = instance.d_nw
        If Not instance.d_original.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtOriginal.EditValue = instance.d_original
        itxtOther.EditValue = instance.d_other
        itxtParty.EditValue = instance.d_party
        itxtPListNo.EditValue = instance.d_packingno
        If Not instance.d_packingdate.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtPListTanggal.EditValue = instance.d_packingdate
        itxtShipper.EditValue = instance.d_shipper
        itxtVessel.EditValue = instance.d_vessel

        itxt20.Text = instance.d_20
        itxt40.Text = instance.d_40
        If Not instance.d_tglbl.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtBL.EditValue = instance.d_tglbl
        If Not instance.d_tglbc.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtBC.EditValue = instance.d_tglbc
        If Not instance.d_tglsk.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtSK.EditValue = instance.d_tglsk
        If Not instance.d_tgldoctag.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtDocTagihan.EditValue = instance.d_tgldoctag

        If Not instance.d_sppbtgl.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtSPPB.EditValue = instance.d_sppbtgl
        If Not instance.d_dobyrtgl.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtDOBayar.EditValue = instance.d_dobyrtgl
        If Not instance.d_doambiltgl.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtDOAmbil.EditValue = instance.d_doambiltgl
        itxtDOTerbit.Text = instance.d_doterbittgl
        If Not instance.d_terimatagihantgl.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtTagihan.EditValue = instance.d_terimatagihantgl
        If Not instance.d_coo.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtCOO.EditValue = instance.d_coo
        itxtPOLPOD.Text = instance.d_polpod
        itxtMBL.Text = instance.d_nombl
        itxtPabean.Text = instance.d_nopabean
        If Not instance.d_tglaju.ToString("dd/mm/yyyy") = "01/00/0001" Then itxtTglAju.EditValue = instance.d_tglaju
      End If

      setLayout(instance.JenisJO)
      xGrid.DataSource = From p In instance.Detail Select p Where p.Id <> 0
      instance.Detail.CriteriaString = ""
      xGrid.DataSource = instance.Detail
      gridInvoice.DataSource = instance.Invoice
      editAssign = False
    End If
    'lytItem.Selected = True
    SetNomor()
    xGridView.OptionsBehavior.Editable = True
    xGridView.OptionsBehavior.ReadOnly = False
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Job Order [JO]: Tambah Data"
    Else
      Me.Text = "Job Order [JO]: Edit Data " & instance.Kode
      If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
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
  Overrides Sub SimpanData()
    'If Not dValidation.Validate() Then
    '  Exit Sub
    'End If
    If (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
      Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If

    For i = detailToDelete.Count - 1 To 0 Step -1
      detailToDelete(i).Delete()
    Next

    Try
      '======= Simpan Main
      If Not txtKontak.EditValue Is Nothing Then
        instance.Pelanggan = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      Else
        instance.Pelanggan = Nothing
      End If
      'instance.KontakAlamat = CType(txtAlamat.EditValue, NuSoft001.Persistent.KontakAlamat)
      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      instance.KontakPerson = txtKontakPerson.EditValue
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.Uraian = txtUraian.Text
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
      instance.JenisJO = CType(txtTipeJO.EditValue, NuSoft004.Persistent.NishiJenisJO)
      instance.TipeBarangJO = CType(txtJenisBarang.EditValue, NuSoft004.Persistent.NishiTipeBarangJO)
      instance.ReffNo = txtNoRef.Text
      instance.Qty = txtQty.EditValue
      instance.Satuan = txtSatuan.EditValue


      If instance.JenisJO = NuSoft004.Persistent.NishiJenisJO.Ekspor Then
        instance.d_blno = eTxtBillLading.EditValue
        instance.d_consignee = eTxtConsignee.EditValue
        instance.d_coo = eTxtCOO.DateTime
        'instance.d_tanggal = eTxtDateOfRecord.EditValue
        instance.d_eta = eTxtETA.DateTime
        instance.d_etd = eTxtETD.DateTime
        instance.d_gw = eTxtGW.EditValue
        instance.d_insurance = eTxtInsurance.DateTime
        instance.d_invono = eTxtInvoiceNo.EditValue
        instance.d_invdate = eTxtInvoiceTanggal.DateTime
        instance.AmountInvoice = txteAmountInvoice.EditValue
        instance.d_meass = eTxtMeass.EditValue
        instance.d_npeno = eTxtNPE.EditValue
        instance.d_nw = eTxtNW.EditValue
        instance.d_other = eTxtOther.EditValue
        instance.d_packingno = eTxtPackingNo.EditValue
        instance.d_packingdate = eTxtPackingTanggal.DateTime
        instance.d_party = eTxtParty.EditValue
        instance.d_pebno = eTxtPEBNo.EditValue
        instance.d_pickup = eTxtPickup.DateTime
        instance.d_shipper = eTxtShipper.EditValue
        instance.d_shippinginstruction = eTxtShipping.EditValue
        instance.d_vessel = eTxtVessel.EditValue
        instance.d_tujuan = eTxtTujuan.Text
        instance.d_tglsi = eTxtTglSI.DateTime
        instance.d_tglreqtrucking = eTxtTglRecTrucking.DateTime
        instance.d_tglsurattugas = eTxtTglSuratTugas.DateTime
        instance.d_pebtglreq = eTxtPEBReq.DateTime
        instance.d_pebtglterima = eTxtPEBTerima.DateTime
        instance.d_bltglreq = eTxtBLReq.DateTime
        instance.d_bltglterima = eTxtBLTerima.DateTime
        instance.d_blorisurender = eTxtBLSurender.DateTime
        instance.d_asuransitglreq = eTxtAsuransiReq.DateTime
        instance.d_asuransitglterima = eTxtAsuransiTerima.DateTime
        instance.d_cootgldraft = eTxtCOODraft.DateTime
        instance.d_cootglkomunikasi = eTxtCOOKomunikasi.DateTime
        instance.d_cootglpersetujuan = eTxtCOOPersetujuan.DateTime
        instance.d_polpod = eTxtPOLPOD.Text
        instance.d_nombl = eTxtMBL.Text
        instance.d_nopabean = eTxtPabean.Text
        instance.d_tglaju = eTxtAju.DateTime
        instance.d_ajouno = etxtNoAju.Text
        instance.d_original = eTxtTerimaOriginal.DateTime
      End If
      If instance.JenisJO = NuSoft004.Persistent.NishiJenisJO.Impor Then
        instance.d_ajouno = itxtAJOU.EditValue
        instance.d_billing = itxtBilling.DateTime
        instance.d_blno = itxtBLNo.EditValue
        instance.d_bpn = itxtBPN.DateTime
        instance.d_consignee = itxtConsignee.EditValue
        instance.d_delivery = itxtDelivery.DateTime
        instance.d_do = itxtDO.DateTime
        instance.d_pib = itxtDraftPIB.EditValue
        instance.d_email = itxtEmail.DateTime
        instance.d_draftpib = itxtDraftPIB.DateTime
        instance.d_eta = itxtETA.DateTime
        instance.d_gw = itxtGW.EditValue
        instance.d_invono = itxtInvoiceNo.EditValue
        instance.d_invdate = itxtInvoiceTgl.DateTime
        instance.d_meass = itxtMeass.EditValue
        instance.d_nw = itxtNW.EditValue
        instance.d_original = itxtOriginal.DateTime
        instance.d_other = itxtOther.EditValue
        instance.d_party = itxtParty.EditValue
        instance.d_packingno = itxtPListNo.EditValue
        instance.d_packingdate = itxtPListTanggal.DateTime
        instance.d_shipper = itxtShipper.EditValue
        instance.d_vessel = itxtVessel.EditValue

        instance.d_20 = itxt20.Text
        instance.d_40 = itxt40.Text
        instance.d_tglbl = itxtBL.DateTime
        instance.d_tglbc = itxtBC.DateTime
        instance.d_tglsk = itxtSK.DateTime
        instance.d_tgldoctag = itxtDocTagihan.DateTime
        instance.d_sppbtgl = itxtSPPB.DateTime
        instance.d_dobyrtgl = itxtDOBayar.DateTime
        instance.d_doambiltgl = itxtDOAmbil.DateTime
        instance.d_doterbittgl = itxtDOTerbit.Text
        instance.d_terimatagihantgl = itxtTagihan.DateTime
        instance.d_coo = itxtCOO.DateTime
        instance.d_polpod = itxtPOLPOD.Text
        instance.d_nombl = itxtMBL.Text
        instance.d_nopabean = itxtPabean.Text
        instance.d_tglaju = itxtTglAju.DateTime
      End If


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
    Dim frm As RF_zNishiVoucher '(Persistent.SumberDataJenis.JO, MainClass.reportName.zNishiVoucherJO)
    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    If instance.JenisJO = NuSoft004.Persistent.NishiJenisJO.Impor Then
      frm = New RF_zNishiVoucher(Persistent.SumberDataJenis.JO, MainClass.reportName.zNishiVoucherJOImpor)
      reportCode = MainClass.GetReport(MainClass.reportName.zNishiVoucherJOImpor)
    Else
      frm = New RF_zNishiVoucher(Persistent.SumberDataJenis.JO, MainClass.reportName.zNishiVoucherJOEkspor)
      reportCode = MainClass.GetReport(MainClass.reportName.zNishiVoucherJOEkspor)
    End If


    frm.txtNoBukti1.EditValue = instance.Kode

    message = String.Format(message, "Order Penjualan")
    Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
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
    If salesSetting.FilterKontak = True Then
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Id", salesSetting.TipeKontak, BinaryOperatorType.Equal))
    Else
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
    End If
    'txtKaryawan.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(Session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
    txtTipeJO.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft004.Persistent.NishiJenisJO))
    txtJenisBarang.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft004.Persistent.NishiTipeBarangJO))

    colKodeBarangRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Barang)(session, New BinaryOperator("Jenis", NuSoft004.Persistent.JenisBarang.Persediaan, BinaryOperatorType.Equal))
    colSatuanRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Satuan)(session)
    colDivisiRepo.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(session)
    colProyekRepo.DataSource = New XPCollection(Of NuSoft001.Persistent.Proyek)(session)
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
  End Sub
  Private Sub SetFormat()
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatString
    colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
    txtQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtQty.Properties.Mask.EditMask = setting.NumericFormatToString
    txteAmountInvoice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txteAmountInvoice.Properties.Mask.EditMask = setting.NumericFormatToString
    'MsgBox("Formatnya : " & setting.NumericFormatToString.ToString)
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
    txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
    txtUraian.EditValue = salesSetting.UraianSO
    txtTipeJO.EditValue = NuSoft004.Persistent.NishiJenisJO.Impor
    txtJenisBarang.EditValue = NuSoft004.Persistent.NishiTipeBarangJO.Coil
    setLayout(NuSoft004.Persistent.NishiJenisJO.Impor)
    eTxtNW.EditValue = 0.0
    eTxtGW.EditValue = 0.0
    txtQty.EditValue = 0.0
    txteAmountInvoice.EditValue = 0.0
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.JO)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    txtKontak.Properties.ReadOnly = True
    txtTanggal.Properties.ReadOnly = True
    txtNoTransaksi.Properties.ReadOnly = True
    txtStatus.Properties.ReadOnly = True
    txtRegional.Properties.ReadOnly = True
    txtUraian.Properties.ReadOnly = True
    txtKontakPerson.Properties.ReadOnly = True
    txtTipeJO.Properties.ReadOnly = True
    txtNoRef.Enabled = False
    txtUraian.Enabled = False
    'txtNoPenawaran.Enabled = False

    xGridView.OptionsBehavior.Editable = False
    AllowSave = False
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
  Private Sub txtKontak_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtKontak.ButtonClick
    If e.Button.Index = 1 Then
      Dim frm As Core.Win.Forms.InputBase = GetAddForm(sender)
      frm.session = session
      frm.Tipe = InputType.Tambah
      frm.Owner = Me
      If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
        RefreshLookupSources(sender)
        '        SetValue(sender)
      End If
    End If
  End Sub
  Private Function GetAddForm(sender As Object) As Core.Win.Forms.InputBase
    If sender Is txtKontak Then
      Return New NuSoft001.UI_KontakDialog
      'ElseIf sender Is txtKontak Then
      '  Return New UI_KontakDialog
    Else
      Return Nothing
    End If
  End Function
  Private Sub SetValue(sender As Object)
    'If sender Is txtAkun Then
    '  txtAkun.EditValue = Core.Win.Component.XtraLookUpEdit.GetLastValue(txtAkun)
    'ElseIf sender Is txtKontak Then
    '  txtKontak.EditValue = Core.Win.Component.XtraLookUpEdit.GetLastValue(txtKontak)
    'End If
  End Sub
  Private Sub RefreshLookupSources(sender As Object)
    BindingDataSource()
  End Sub
  Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
    If Not e.NewValue Is Nothing Then
      lblKontakNama.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Nama
      eTxtConsignee.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Nama
      itxtConsignee.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Nama
      'isikan data detailnya
      txtPhoneNumber.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Telepon
      txtDebitLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasPiutang)
      txtCreditLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasHutang)

      txtKontakPerson.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakPerson)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))

      Dim xpTransaksi As New XPCollection(Of NuSoft004.Persistent.NishiOrderPembelian)(session, New BinaryOperator("Pelanggan", CType(e.NewValue, NuSoft001.Persistent.Kontak), BinaryOperatorType.Equal))
      xGHistory.DataSource = xpTransaksi

      eTxtShipper.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Nama
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
          ChangeCode()
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
  End Sub
  Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    If Not e.Value Is Nothing Then
      Dim row As NuSoft004.Persistent.NishiOrderPembelianDetail = CType(xGridView.GetRow(e.RowHandle), NuSoft004.Persistent.NishiOrderPembelianDetail)
      If e.Column Is colKodeBarang Then
        If Not row Is Nothing Then
          Dim xbarang As NuSoft004.Persistent.Barang = CType(e.Value, NuSoft004.Persistent.Barang)
          Dim xHarga As Double = 0
          row.Satuan = xbarang.Satuan
        End If
      End If
    End If
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("SOTransaksiGrid.xml"))
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As NuSoft004.Persistent.NishiOrderPembelianDetail = CType(xGridView.GetRow(e.RowHandle), NuSoft004.Persistent.NishiOrderPembelianDetail)
    row.Barang = Nothing
    row.Qty = 1
    row.Main = instance
    row.Catatan = ""
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As NuSoft004.Persistent.NishiOrderPembelianDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), NuSoft004.Persistent.NishiOrderPembelianDetail)
      xGridView.DeleteRow(xGridView.FocusedRowHandle)
      detailToDelete.Add(Id)
    End If
    If e.KeyCode = Windows.Forms.Keys.F12 Then
      Dim xData As NuSoft004.Persistent.NishiOrderPembelianDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), NuSoft004.Persistent.NishiOrderPembelianDetail)
      Dim a As New NuSoft004.Logic.Stock
      a.showDataStock(Me.MenuId, Me.NamaDatabase, session, xData.Barang.Id)
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
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub
  Private Sub setLayout(Jenis As NuSoft004.Persistent.NishiJenisJO)
    lytImpor.Enabled = (Jenis = NuSoft004.Persistent.NishiJenisJO.Impor)
    lytImporStatus.Enabled = (Jenis = NuSoft004.Persistent.NishiJenisJO.Impor)
    lytEkspor.Enabled = Not (Jenis = NuSoft004.Persistent.NishiJenisJO.Impor)
    lytEksporStatus.Enabled = Not (Jenis = NuSoft004.Persistent.NishiJenisJO.Impor)
  End Sub
  Private Sub txtTipeJO_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtTipeJO.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Dim item As NuSoft004.Persistent.NishiJenisJO = CType(e.NewValue, NuSoft004.Persistent.NishiJenisJO)
      setLayout(item)
    End If
  End Sub
End Class