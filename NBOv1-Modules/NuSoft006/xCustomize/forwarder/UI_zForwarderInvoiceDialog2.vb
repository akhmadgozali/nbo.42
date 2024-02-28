Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Friend Class UI_zForwarderInvoiceDialog2
  Private instance As Persistent.zForwarderInvoice
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.zForwarderInvoiceDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Private salesSetting As Logic.SalesSetting
  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.zForwarderInvoice.AutoSaveOnEndEdit = False
    Persistent.zForwarderInvoiceDetail.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    salesSetting = New Logic.SalesSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    colInvoice.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    colStuffing.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    colDestination.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    colTotal.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.zForwarderInvoice(session)
      instance.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}

      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.zForwarderInvoice)(Convert.ToInt64(IdToEdit))
      txtNoTransaksi.Text = instance.Kode
      txtTanggal.EditValue = instance.Tanggal
      txtKontak.EditValue = instance.Customer
      txtUraian.EditValue = instance.Uraian
      txtKontakPerson.EditValue = instance.KontakPerson
      txtAlamat.EditValue = instance.Alamat
      txtRegional.EditValue = instance.Regional
      txtKontakPerson.EditValue = instance.KontakPerson
      txtShipment.EditValue = instance.Shipment
      txtCatatan.EditValue = instance.Catatan
      txtNoPPN.EditValue = instance.NoFakturPPN
      txtTipe.EditValue = instance.Tipe
      txtDiscount.EditValue = instance.NilaiDisc
      txtPPN.EditValue = instance.NilaiPPN
      txtPPH.EditValue = instance.NilaiPPH
      txtStatus.EditValue = instance.StatusTransaksi


      txtDRYTriplek.EditValue = instance.DryTriplek
      txtDRYCargoNET.EditValue = instance.DryCargo
      txtDRYPlastik40.EditValue = instance.DryJaring40
      txtDRYPlastik20.EditValue = instance.DryJaring20
      txtDRYSanitari40.EditValue = instance.DryPhytosanitary40
      txtDRYSantitari20.EditValue = instance.DryPhytosanitary20
      txtDryTruckingLCL.EditValue = instance.DryTruckingLCL
      txtDRYTrucking20.EditValue = instance.DryTrucking20
      txtDRYTrucking40.EditValue = instance.DryTrucking40
      txtDryCTNS.EditValue = instance.DryCTNS
      txtICEMonitoring40.EditValue = instance.IceMonitoring40
      txtICEMonitoring20.EditValue = instance.IceMonitoring20
      txtICERecooling40.EditValue = instance.IceRecooling40
      txtICERecooling20.EditValue = instance.IceRecooling20
      txtICEVHC.EditValue = instance.IceItem
      txtICEFee40.EditValue = instance.IceShipment40
      txtICEFee20.EditValue = instance.IceShipment20
      txtICEtbs.EditValue = instance.IceShipmentTBS

      xGrid.DataSource = From p In instance.Detail Select p Where p.Id <> 0
      instance.Detail.CriteriaString = ""
      xGrid.DataSource = instance.Detail
      editAssign = False
    End If
    LoadLayout(CType(txtTipe.EditValue, Persistent.zForwarderType))
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Invoice Penjualan [IV] : Tambah Data"
    Else
      Me.Text = "Invoice Penjualan [IV] : Edit Data " & instance.Kode
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
    For i = detailToDelete.Count - 1 To 0 Step -1
      detailToDelete(i).Delete()
    Next

    Try
      '======= Simpan Main
      If txtNoTransaksi.EditValue Is Nothing Then
        ChangeCode()
      End If
      If Not txtKontak.EditValue Is Nothing Then
        instance.Customer = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      Else
        instance.Customer = Nothing
      End If
      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      instance.KontakPerson = txtKontakPerson.EditValue
      instance.Alamat = txtAlamat.EditValue
      instance.Uang = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.Uraian = txtUraian.EditValue
      instance.Catatan = txtUraian.Text
      instance.Shipment = CType(txtShipment.EditValue, Persistent.zShipment)
      instance.Tipe = CType(txtTipe.EditValue, Persistent.zForwarderType)
      instance.NilaiDisc = txtDiscount.EditValue
      instance.NilaiPPN = txtPPN.EditValue
      instance.NilaiPPH = txtPPH.EditValue
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)

      instance.DryTriplek = txtDRYTriplek.EditValue
      instance.DryCargo = txtDRYCargoNET.EditValue
      instance.DryJaring40 = txtDRYPlastik40.EditValue
      instance.DryJaring20 = txtDRYPlastik20.EditValue
      instance.DryPhytosanitary40 = txtDRYSanitari40.EditValue
      instance.DryPhytosanitary20 = txtDRYSantitari20.EditValue
      instance.DryTruckingLCL = txtDryTruckingLCL.EditValue
      instance.DryTrucking20 = txtDRYTrucking20.EditValue
      instance.DryTrucking40 = txtDRYTrucking40.EditValue
      instance.DryCTNS = txtDryCTNS.EditValue
      instance.IceMonitoring40 = txtICEMonitoring40.EditValue
      instance.IceMonitoring20 = txtICEMonitoring20.EditValue
      instance.IceRecooling40 = txtICERecooling40.EditValue
      instance.IceRecooling20 = txtICERecooling20.EditValue
      instance.IceItem = txtICEVHC.EditValue
      instance.IceShipment40 = txtICEFee40.EditValue
      instance.IceShipment20 = txtICEFee20.EditValue
      instance.IceShipmentTBS = txtICEtbs.EditValue


      'buatkan jurnalnya
      instance.GL.Sumber = instance.Sumber
      instance.GL.Tanggal = txtTanggal.EditValue
      instance.Gl.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.Gl.Kode = instance.Kode
      instance.GL.ModuleId = NPO.Modules.ModuleId.Sales
      instance.GL.MataUang = "RP"
      instance.GL.Kurs = 1
      instance.Gl.Kontak = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      instance.Gl.KontakNama = txtKontak.Text
      instance.Gl.Uraian = txtUraian.Text

      SimpanGL(instance.Uang.PiutangDagang, 1, instance.Total, 0, 0, 0)
      SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaCustom1)), 2, 0, instance.Total, 0, 0)
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
    'Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.IV)
    'frm.txtNoBukti1.Text = instance.Kode

    'Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    'Dim reportCode As String = ""
    'reportCode = MainClass.GetReport(MainClass.reportName.VoucherIV)
    'message = String.Format(message, "Invoice Penjualan")

    'Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message)
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
    txtNoTransaksi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
    txtNoTransaksi.Properties.Mask.EditMask = nomor.Mask
    txtNoTransaksi.Text = nomor.Kode
  End Sub
  Private Sub BindingDataSource()
    If salesSetting.FilterKontak = True Then
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Id", salesSetting.TipeKontak, BinaryOperatorType.Equal))
    Else
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
    End If
    txtRegional.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Regional)(session)
    txtShipment.Properties.DataSource = New XPCollection(Of Persistent.zShipment)(session)
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
    colDestinationRepo.DataSource = New XPCollection(Of Persistent.zDestination)(session)
    txtTipe.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.zForwarderType))
    colStuffingRepo.DataSource = New XPCollection(Of Persistent.zForwarderStuffing)(session)
  End Sub
  Private Sub SetFormat()
    colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotal.DisplayFormat.FormatString = setting.NumericFormatToString
    colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString

    colCTNS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colPartay20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colPartay40.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colPartayLCL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDryCTNSValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDryTrucking20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDryTrucking40.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDryTruckingLCL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDryCOO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDryPhytosanitary20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDryPhytosanitary40.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDryJaring20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDryJaring40.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDryCargo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDryTriplek.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDryMeratus.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDryDocFee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDrySealFee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDryServiceCharge.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDryLOLO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDryNotulPeb.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colIceShipmentFee20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colIceShipmentFee40.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colIceShipmentFeeTBS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colIceCustomInspection.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colIceCOO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colIceVHCItem.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colIceVHCValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colIceSealFee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colIceRecooling20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colIceRecooling40.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colIceMonitoring20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colIceMonitoring40.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colIceNotulPeb.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colBiayaLainLain.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colCTNS.DisplayFormat.FormatString = setting.NumericFormatToString
    colPartay20.DisplayFormat.FormatString = setting.NumericFormatToString
    colPartay40.DisplayFormat.FormatString = setting.NumericFormatToString
    colPartayLCL.DisplayFormat.FormatString = setting.NumericFormatToString
    colDryCTNSValue.DisplayFormat.FormatString = setting.NumericFormatToString
    colDryTrucking20.DisplayFormat.FormatString = setting.NumericFormatToString
    colDryTrucking40.DisplayFormat.FormatString = setting.NumericFormatToString
    colDryTruckingLCL.DisplayFormat.FormatString = setting.NumericFormatToString
    colDryCOO.DisplayFormat.FormatString = setting.NumericFormatToString
    colDryPhytosanitary20.DisplayFormat.FormatString = setting.NumericFormatToString
    colDryPhytosanitary40.DisplayFormat.FormatString = setting.NumericFormatToString
    colDryJaring20.DisplayFormat.FormatString = setting.NumericFormatToString
    colDryJaring40.DisplayFormat.FormatString = setting.NumericFormatToString
    colDryCargo.DisplayFormat.FormatString = setting.NumericFormatToString
    colDryTriplek.DisplayFormat.FormatString = setting.NumericFormatToString
    colDryMeratus.DisplayFormat.FormatString = setting.NumericFormatToString
    colDryDocFee.DisplayFormat.FormatString = setting.NumericFormatToString
    colDrySealFee.DisplayFormat.FormatString = setting.NumericFormatToString
    colDryServiceCharge.DisplayFormat.FormatString = setting.NumericFormatToString
    colDryLOLO.DisplayFormat.FormatString = setting.NumericFormatToString
    colDryNotulPeb.DisplayFormat.FormatString = setting.NumericFormatToString
    colIceShipmentFee20.DisplayFormat.FormatString = setting.NumericFormatToString
    colIceShipmentFee40.DisplayFormat.FormatString = setting.NumericFormatToString
    colIceShipmentFeeTBS.DisplayFormat.FormatString = setting.NumericFormatToString
    colIceCustomInspection.DisplayFormat.FormatString = setting.NumericFormatToString
    colIceCOO.DisplayFormat.FormatString = setting.NumericFormatToString
    colIceVHCItem.DisplayFormat.FormatString = setting.NumericFormatToString
    colIceVHCValue.DisplayFormat.FormatString = setting.NumericFormatToString
    colIceSealFee.DisplayFormat.FormatString = setting.NumericFormatToString
    colIceRecooling20.DisplayFormat.FormatString = setting.NumericFormatToString
    colIceRecooling40.DisplayFormat.FormatString = setting.NumericFormatToString
    colIceMonitoring20.DisplayFormat.FormatString = setting.NumericFormatToString
    colIceMonitoring40.DisplayFormat.FormatString = setting.NumericFormatToString
    colIceNotulPeb.DisplayFormat.FormatString = setting.NumericFormatToString
    colBiayaLainLain.DisplayFormat.FormatString = setting.NumericFormatToString


    txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtDiscount.Properties.Mask.EditMask = setting.NumericFormatToString
    txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtSubTotal.Properties.Mask.EditMask = setting.NumericFormatToString
    txtPPN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtPPN.Properties.Mask.EditMask = setting.NumericFormatToString
    txtPPH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtPPH.Properties.Mask.EditMask = setting.NumericFormatToString
    txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtTotal.Properties.Mask.EditMask = setting.NumericFormatToString

    txtDRYTriplek.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtDRYCargoNET.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtDRYPlastik40.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtDRYPlastik20.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtDRYSanitari40.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtDRYSantitari20.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtDryTruckingLCL.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtDRYTrucking20.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtDRYTrucking40.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtDryCTNS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtICEMonitoring40.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtICEMonitoring20.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtICERecooling40.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtICERecooling20.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtICEVHC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtICEFee40.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtICEtbs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtICEFee20.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtDRYTriplek.Properties.Mask.EditMask = setting.NumericFormatToString
    txtDRYCargoNET.Properties.Mask.EditMask = setting.NumericFormatToString
    txtDRYPlastik40.Properties.Mask.EditMask = setting.NumericFormatToString
    txtDRYPlastik20.Properties.Mask.EditMask = setting.NumericFormatToString
    txtDRYSanitari40.Properties.Mask.EditMask = setting.NumericFormatToString
    txtDRYSantitari20.Properties.Mask.EditMask = setting.NumericFormatToString
    txtDryTruckingLCL.Properties.Mask.EditMask = setting.NumericFormatToString
    txtDRYTrucking20.Properties.Mask.EditMask = setting.NumericFormatToString
    txtDRYTrucking40.Properties.Mask.EditMask = setting.NumericFormatToString
    txtDryCTNS.Properties.Mask.EditMask = setting.NumericFormatToString
    txtICEMonitoring40.Properties.Mask.EditMask = setting.NumericFormatToString
    txtICEMonitoring20.Properties.Mask.EditMask = setting.NumericFormatToString
    txtICERecooling40.Properties.Mask.EditMask = setting.NumericFormatToString
    txtICERecooling20.Properties.Mask.EditMask = setting.NumericFormatToString
    txtICEVHC.Properties.Mask.EditMask = setting.NumericFormatToString
    txtICEFee40.Properties.Mask.EditMask = setting.NumericFormatToString
    txtICEtbs.Properties.Mask.EditMask = setting.NumericFormatToString
    txtICEFee20.Properties.Mask.EditMask = setting.NumericFormatToString
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
    txtShipment.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtShipment)
    txtTipe.EditValue = Persistent.zForwarderType.Ice
    txtUraian.EditValue = "Invoice Penjualan"
    txtDiscount.EditValue = 0
    txtPPN.EditValue = 0
    txtPPH.EditValue = 0

    txtDRYTriplek.EditValue = 0
    txtDRYCargoNET.EditValue = 0
    txtDRYPlastik40.EditValue = 0
    txtDRYPlastik20.EditValue = 0
    txtDRYSanitari40.EditValue = 0
    txtDRYSantitari20.EditValue = 0
    txtDryTruckingLCL.EditValue = 0
    txtDRYTrucking20.EditValue = 0
    txtDRYTrucking40.EditValue = 0
    txtDryCTNS.EditValue = 0
    txtICEMonitoring40.EditValue = 0
    txtICEMonitoring20.EditValue = 0
    txtICERecooling40.EditValue = 0
    txtICERecooling20.EditValue = 0
    txtICEVHC.EditValue = 0
    txtICEFee40.EditValue = 0
    txtICEtbs.EditValue = 0
    txtICEFee20.EditValue = 0
  End Sub
  Private Sub LoadLayout(zTipe As Persistent.zForwarderType)
    'lytSpaceKosong.Visibility = LayoutVisibility.Always
    If zTipe = Persistent.zForwarderType.Dry Then
      lytDRY.Visibility = LayoutVisibility.Always
      colPartayLCL.Visible = True
      gbCTNS.Visible = True
      gbTrucking.Visible = True
      gbCOODRY.Visible = True
      gbPhytosanitary.Visible = True
      gbPlastik.Visible = True
      gbCargo.Visible = True
      gbTriplek.Visible = True
      gbDryLain.Visible = True

      gbShipment.Visible = False
      gbShipment2.Visible = False
      gbCustom.Visible = False
      gbCOOICE.Visible = False
      gbVHC.Visible = False
      gbSeal.Visible = False
      gbRecooling.Visible = False
      gbMonitoring.Visible = False
      gbNotul.Visible = False
      lytICE.Visibility = LayoutVisibility.Never
    Else
      lytDRY.Visibility = LayoutVisibility.Never
      colPartayLCL.Visible = False
      gbCTNS.Visible = False
      gbTrucking.Visible = False
      gbCOODRY.Visible = False
      gbPhytosanitary.Visible = False
      gbPlastik.Visible = False
      gbCargo.Visible = False
      gbTriplek.Visible = False
      gbDryLain.Visible = False

      gbShipment.Visible = True
      gbShipment2.Visible = True
      gbCustom.Visible = True
      gbCOOICE.Visible = True
      gbVHC.Visible = True
      gbSeal.Visible = True
      gbRecooling.Visible = True
      gbMonitoring.Visible = True
      gbNotul.Visible = True
      lytICE.Visibility = LayoutVisibility.Always
    End If
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.IV)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    txtKontak.Properties.ReadOnly = True
    txtTanggal.Properties.ReadOnly = True
    txtNoTransaksi.Properties.ReadOnly = True
    txtRegional.Properties.ReadOnly = True
    txtUraian.Properties.ReadOnly = True
    txtKontakPerson.Properties.ReadOnly = True
    txtShipment.Properties.ReadOnly = True
    txtNoPPN.Properties.ReadOnly = True
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

  Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
    If Not e.NewValue Is Nothing Then
      layKontakNama.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Nama
      'isikan data detailnya
      txtPhoneNumber.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Telepon
      txtDebitLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasPiutang)
      txtCreditLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasHutang)

      txtKontakPerson.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.KontakPerson)(session, New BinaryOperator("Kontak", e.NewValue, BinaryOperatorType.Equal))
      Dim xpTransaksi As New XPCollection(Of Persistent.zForwarderInvoice)(session, New BinaryOperator("Customer", CType(e.NewValue, NuSoft001.Persistent.Kontak), BinaryOperatorType.Equal))
      xGHistory.DataSource = xpTransaksi
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
  Private Sub HitungTotal()
    txtSubTotal.EditValue = instance.SubTotal - instance.NilaiDisc
    txtTotal.EditValue = instance.Total ' instance.SubTotal + instance.NilaiPPN - instance.NilaiPPH
  End Sub
  Private Sub SimpanGL(Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, DebitValas As Double, KreditValas As Double, Optional Catatan As String = "")
    Dim item As Persistent.GlMainDetail
    If instance.Gl.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
      item = instance.GL.Detail.Single(Function(m) m.Urutan = Urutan)
      item.Akun = Akun
      item.MataUang = item.Akun.MataUang
      item.Main = instance.GL
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
        item.Kurs = 1
      End If
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
        item.Kurs = 1
      End If
      instance.Gl.Detail.Add(item)
    End If
  End Sub
  Private Sub txtTipe_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTipe.EditValueChanging
    LoadLayout(CType(e.NewValue, Persistent.zForwarderType))
    instance.Tipe = CType(e.NewValue, Persistent.zForwarderType)
    xGrid.RefreshDataSource()
    HitungTotal()
  End Sub
  Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    HitungTotal()
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("IVForwarderDialogGrid.xml"))
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.zForwarderInvoiceDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.zForwarderInvoiceDetail)
    row.InvoiceNo = ""
    row.Main = instance
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.zForwarderInvoiceDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.zForwarderInvoiceDetail)
      xGridView.DeleteRow(xGridView.FocusedRowHandle)
      detailToDelete.Add(Id)
    End If
  End Sub
End Class