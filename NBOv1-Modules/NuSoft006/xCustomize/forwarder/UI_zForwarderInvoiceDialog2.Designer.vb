<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_zForwarderInvoiceDialog2
  Inherits Core.Win.Forms.InputMDI

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_zForwarderInvoiceDialog2))
    Me.colKodeBarangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.xxHapus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
    Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
    Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
    Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
    Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
    Me.navInfo = New DevExpress.XtraNavBar.NavBarGroup()
    Me.NavBarGroupControlContainer3 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
    Me.txtDebitLimit = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
    Me.txtCreditLimit = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
    Me.txtSaldoAP = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
    Me.txtSaldoAR = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
    Me.txtPhoneNumber = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
    Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
    Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
    Me.NavBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
    Me.xGHistory = New DevExpress.XtraGrid.GridControl()
    Me.xGHistoryView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.navHistory = New DevExpress.XtraNavBar.NavBarGroup()
    Me.navCatatan = New DevExpress.XtraNavBar.NavBarGroup()
    Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
    Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.txtDRYTriplek = New DevExpress.XtraEditors.TextEdit()
    Me.txtDRYCargoNET = New DevExpress.XtraEditors.TextEdit()
    Me.txtICEMonitoring40 = New DevExpress.XtraEditors.TextEdit()
    Me.txtICEMonitoring20 = New DevExpress.XtraEditors.TextEdit()
    Me.txtICERecooling40 = New DevExpress.XtraEditors.TextEdit()
    Me.txtICERecooling20 = New DevExpress.XtraEditors.TextEdit()
    Me.txtICEVHC = New DevExpress.XtraEditors.TextEdit()
    Me.txtICEFee40 = New DevExpress.XtraEditors.TextEdit()
    Me.txtDRYPlastik40 = New DevExpress.XtraEditors.TextEdit()
    Me.txtDRYPlastik20 = New DevExpress.XtraEditors.TextEdit()
    Me.txtDRYSanitari40 = New DevExpress.XtraEditors.TextEdit()
    Me.txtDRYSantitari20 = New DevExpress.XtraEditors.TextEdit()
    Me.txtDryTruckingLCL = New DevExpress.XtraEditors.TextEdit()
    Me.txtDRYTrucking20 = New DevExpress.XtraEditors.TextEdit()
    Me.txtICEtbs = New DevExpress.XtraEditors.TextEdit()
    Me.txtDRYTrucking40 = New DevExpress.XtraEditors.TextEdit()
    Me.txtICEFee20 = New DevExpress.XtraEditors.TextEdit()
    Me.txtDryCTNS = New DevExpress.XtraEditors.TextEdit()
    Me.txtTipe = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtPPH = New DevExpress.XtraEditors.TextEdit()
    Me.txtDiscount = New DevExpress.XtraEditors.TextEdit()
    Me.txtPPN = New DevExpress.XtraEditors.TextEdit()
    Me.txtSubTotal = New DevExpress.XtraEditors.TextEdit()
    Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
    Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtNoPPN = New DevExpress.XtraEditors.TextEdit()
    Me.txtShipment = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtKontakPerson = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
    Me.gbInvoice = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colInvoice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colStuffing = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colStuffingRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
    Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gbDestination = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colDestination = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colDestinationRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.gbTotal = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colTotal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colCTNS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colPartay20 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colPartay40 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colPartayLCL = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gbCTNS = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colDryCTNSValue = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gbTrucking = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colDryTrucking20 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colDryTrucking40 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colDryTruckingLCL = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gbCOODRY = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colDryCOO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gbPhytosanitary = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colDryPhytosanitary20 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colDryPhytosanitary40 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gbPlastik = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colDryJaring20 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colDryJaring40 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gbCargo = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colDryCargo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gbTriplek = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colDryTriplek = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gbDryLain = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colDryMeratus = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colDryDocFee = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colDrySealFee = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colDryServiceCharge = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colDryLOLO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colDryNotulPeb = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gbShipment = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colIceShipmentFee20 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colIceShipmentFee40 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gbShipment2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colIceShipmentFeeTBS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gbCustom = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colIceCustomInspection = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gbCOOICE = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colIceCOO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gbVHC = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colIceVHCItem = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colIceVHCValue = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gbSeal = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colIceSealFee = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gbRecooling = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colIceRecooling20 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colIceRecooling40 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gbMonitoring = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colIceMonitoring20 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colIceMonitoring40 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gbNotul = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colIceNotulPeb = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gbBiayaLain = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.colBiayaLainLain = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
    Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtAlamat = New DevExpress.XtraEditors.MemoEdit()
    Me.txtCatatan = New DevExpress.XtraEditors.MemoExEdit()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.layKontak = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.layKontakNama = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem21 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem10 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem11 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.lytRegional = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytDRY = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytICE = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
    Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
    Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
    Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
    Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xxHapus, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.hideContainerRight.SuspendLayout()
    Me.DockPanel1.SuspendLayout()
    Me.DockPanel1_Container.SuspendLayout()
    CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.NavBarControl1.SuspendLayout()
    Me.NavBarGroupControlContainer3.SuspendLayout()
    Me.NavBarGroupControlContainer1.SuspendLayout()
    CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.NavBarGroupControlContainer2.SuspendLayout()
    CType(Me.xGHistory, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGHistoryView, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.DockPanel2.SuspendLayout()
    Me.DockPanel2_Container.SuspendLayout()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.txtDRYTriplek.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDRYCargoNET.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtICEMonitoring40.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtICEMonitoring20.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtICERecooling40.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtICERecooling20.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtICEVHC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtICEFee40.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDRYPlastik40.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDRYPlastik20.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDRYSanitari40.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDRYSantitari20.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDryTruckingLCL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDRYTrucking20.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtICEtbs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDRYTrucking40.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtICEFee20.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDryCTNS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTipe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPPH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPPN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoPPN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtShipment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colStuffingRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colDestinationRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layKontak, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layKontakNama, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem21, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytDRY, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytICE, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarStaticItem2})
    Me.barMan.MaxItemId = 9
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2)})
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'colKodeBarangRepo
    '
    Me.colKodeBarangRepo.AutoHeight = False
    Me.colKodeBarangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colKodeBarangRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "No. Akun"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama Akun")})
    Me.colKodeBarangRepo.DisplayMember = "Kode"
    Me.colKodeBarangRepo.Name = "colKodeBarangRepo"
    Me.colKodeBarangRepo.NullText = "<Pilih Barang>"
    Me.colKodeBarangRepo.PopupWidth = 300
    Me.colKodeBarangRepo.ValueMember = "This"
    '
    'xxHapus
    '
    Me.xxHapus.AutoHeight = False
    Me.xxHapus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.xxHapus.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.xxHapus.DisplayMember = "Kode"
    Me.xxHapus.Name = "xxHapus"
    Me.xxHapus.NullText = "<Pilih Divisi>"
    Me.xxHapus.ShowHeader = False
    Me.xxHapus.ValueMember = "This"
    '
    'DockManager1
    '
    Me.DockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight})
    Me.DockManager1.Form = Me
    Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel2})
    Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
    '
    'hideContainerRight
    '
    Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
    Me.hideContainerRight.Controls.Add(Me.DockPanel1)
    Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.hideContainerRight.Location = New System.Drawing.Point(978, 0)
    Me.hideContainerRight.Name = "hideContainerRight"
    Me.hideContainerRight.Size = New System.Drawing.Size(19, 489)
    '
    'DockPanel1
    '
    Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
    Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
    Me.DockPanel1.ID = New System.Guid("6988d464-fb4c-47a6-9314-7c4a87e69e68")
    Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
    Me.DockPanel1.Name = "DockPanel1"
    Me.DockPanel1.OriginalSize = New System.Drawing.Size(250, 200)
    Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
    Me.DockPanel1.SavedIndex = 0
    Me.DockPanel1.Size = New System.Drawing.Size(250, 489)
    Me.DockPanel1.Text = "Panel Informasi"
    Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
    '
    'DockPanel1_Container
    '
    Me.DockPanel1_Container.Controls.Add(Me.NavBarControl1)
    Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
    Me.DockPanel1_Container.Name = "DockPanel1_Container"
    Me.DockPanel1_Container.Size = New System.Drawing.Size(242, 462)
    Me.DockPanel1_Container.TabIndex = 0
    '
    'NavBarControl1
    '
    Me.NavBarControl1.ActiveGroup = Me.navInfo
    Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer1)
    Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer2)
    Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer3)
    Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.navInfo, Me.navHistory, Me.navCatatan})
    Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
    Me.NavBarControl1.Name = "NavBarControl1"
    Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 242
    Me.NavBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar
    Me.NavBarControl1.Size = New System.Drawing.Size(242, 462)
    Me.NavBarControl1.TabIndex = 0
    Me.NavBarControl1.Text = "NavBarControl1"
    '
    'navInfo
    '
    Me.navInfo.Caption = "Informasi Kontak"
    Me.navInfo.ControlContainer = Me.NavBarGroupControlContainer3
    Me.navInfo.Expanded = True
    Me.navInfo.GroupClientHeight = 110
    Me.navInfo.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
    Me.navInfo.Name = "navInfo"
    '
    'NavBarGroupControlContainer3
    '
    Me.NavBarGroupControlContainer3.Controls.Add(Me.txtDebitLimit)
    Me.NavBarGroupControlContainer3.Controls.Add(Me.LabelControl21)
    Me.NavBarGroupControlContainer3.Controls.Add(Me.txtCreditLimit)
    Me.NavBarGroupControlContainer3.Controls.Add(Me.LabelControl18)
    Me.NavBarGroupControlContainer3.Controls.Add(Me.txtSaldoAP)
    Me.NavBarGroupControlContainer3.Controls.Add(Me.LabelControl19)
    Me.NavBarGroupControlContainer3.Controls.Add(Me.txtSaldoAR)
    Me.NavBarGroupControlContainer3.Controls.Add(Me.LabelControl17)
    Me.NavBarGroupControlContainer3.Controls.Add(Me.txtPhoneNumber)
    Me.NavBarGroupControlContainer3.Controls.Add(Me.LabelControl16)
    Me.NavBarGroupControlContainer3.Name = "NavBarGroupControlContainer3"
    Me.NavBarGroupControlContainer3.Size = New System.Drawing.Size(234, 103)
    Me.NavBarGroupControlContainer3.TabIndex = 2
    '
    'txtDebitLimit
    '
    Me.txtDebitLimit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDebitLimit.Location = New System.Drawing.Point(97, 85)
    Me.txtDebitLimit.Name = "txtDebitLimit"
    Me.txtDebitLimit.Size = New System.Drawing.Size(7, 13)
    Me.txtDebitLimit.TabIndex = 4
    Me.txtDebitLimit.Text = "0"
    '
    'LabelControl21
    '
    Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl21.Location = New System.Drawing.Point(11, 85)
    Me.LabelControl21.Name = "LabelControl21"
    Me.LabelControl21.Size = New System.Drawing.Size(61, 13)
    Me.LabelControl21.TabIndex = 4
    Me.LabelControl21.Text = "Debit Limit"
    '
    'txtCreditLimit
    '
    Me.txtCreditLimit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCreditLimit.Location = New System.Drawing.Point(97, 66)
    Me.txtCreditLimit.Name = "txtCreditLimit"
    Me.txtCreditLimit.Size = New System.Drawing.Size(7, 13)
    Me.txtCreditLimit.TabIndex = 3
    Me.txtCreditLimit.Text = "0"
    '
    'LabelControl18
    '
    Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl18.Location = New System.Drawing.Point(11, 66)
    Me.LabelControl18.Name = "LabelControl18"
    Me.LabelControl18.Size = New System.Drawing.Size(65, 13)
    Me.LabelControl18.TabIndex = 3
    Me.LabelControl18.Text = "Credit Limit"
    '
    'txtSaldoAP
    '
    Me.txtSaldoAP.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSaldoAP.Location = New System.Drawing.Point(97, 46)
    Me.txtSaldoAP.Name = "txtSaldoAP"
    Me.txtSaldoAP.Size = New System.Drawing.Size(7, 13)
    Me.txtSaldoAP.TabIndex = 2
    Me.txtSaldoAP.Text = "0"
    '
    'LabelControl19
    '
    Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl19.Location = New System.Drawing.Point(11, 47)
    Me.LabelControl19.Name = "LabelControl19"
    Me.LabelControl19.Size = New System.Drawing.Size(49, 13)
    Me.LabelControl19.TabIndex = 2
    Me.LabelControl19.Text = "Saldo AP"
    '
    'txtSaldoAR
    '
    Me.txtSaldoAR.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSaldoAR.Location = New System.Drawing.Point(97, 28)
    Me.txtSaldoAR.Name = "txtSaldoAR"
    Me.txtSaldoAR.Size = New System.Drawing.Size(7, 13)
    Me.txtSaldoAR.TabIndex = 1
    Me.txtSaldoAR.Text = "0"
    '
    'LabelControl17
    '
    Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl17.Location = New System.Drawing.Point(11, 28)
    Me.LabelControl17.Name = "LabelControl17"
    Me.LabelControl17.Size = New System.Drawing.Size(51, 13)
    Me.LabelControl17.TabIndex = 1
    Me.LabelControl17.Text = "Saldo AR"
    '
    'txtPhoneNumber
    '
    Me.txtPhoneNumber.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPhoneNumber.Location = New System.Drawing.Point(99, 9)
    Me.txtPhoneNumber.Name = "txtPhoneNumber"
    Me.txtPhoneNumber.Size = New System.Drawing.Size(5, 13)
    Me.txtPhoneNumber.TabIndex = 0
    Me.txtPhoneNumber.Text = "-"
    '
    'LabelControl16
    '
    Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl16.Location = New System.Drawing.Point(11, 9)
    Me.LabelControl16.Name = "LabelControl16"
    Me.LabelControl16.Size = New System.Drawing.Size(55, 13)
    Me.LabelControl16.TabIndex = 0
    Me.LabelControl16.Text = "Phone No."
    '
    'NavBarGroupControlContainer1
    '
    Me.NavBarGroupControlContainer1.Controls.Add(Me.MemoEdit1)
    Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
    Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(234, 93)
    Me.NavBarGroupControlContainer1.TabIndex = 0
    '
    'MemoEdit1
    '
    Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MemoEdit1.Location = New System.Drawing.Point(0, 0)
    Me.MemoEdit1.MenuManager = Me.barMan
    Me.MemoEdit1.Name = "MemoEdit1"
    Me.MemoEdit1.Size = New System.Drawing.Size(234, 93)
    Me.MemoEdit1.TabIndex = 0
    Me.MemoEdit1.UseOptimizedRendering = True
    '
    'NavBarGroupControlContainer2
    '
    Me.NavBarGroupControlContainer2.Controls.Add(Me.xGHistory)
    Me.NavBarGroupControlContainer2.Name = "NavBarGroupControlContainer2"
    Me.NavBarGroupControlContainer2.Size = New System.Drawing.Size(234, 193)
    Me.NavBarGroupControlContainer2.TabIndex = 1
    '
    'xGHistory
    '
    Me.xGHistory.Dock = System.Windows.Forms.DockStyle.Fill
    Me.xGHistory.Location = New System.Drawing.Point(0, 0)
    Me.xGHistory.MainView = Me.xGHistoryView
    Me.xGHistory.MenuManager = Me.barMan
    Me.xGHistory.Name = "xGHistory"
    Me.xGHistory.Size = New System.Drawing.Size(234, 193)
    Me.xGHistory.TabIndex = 0
    Me.xGHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGHistoryView})
    '
    'xGHistoryView
    '
    Me.xGHistoryView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colKode, Me.colTanggal, Me.colKeterangan})
    Me.xGHistoryView.GridControl = Me.xGHistory
    Me.xGHistoryView.Name = "xGHistoryView"
    Me.xGHistoryView.OptionsBehavior.Editable = False
    Me.xGHistoryView.OptionsBehavior.ReadOnly = True
    Me.xGHistoryView.OptionsDetail.EnableMasterViewMode = False
    Me.xGHistoryView.OptionsView.ColumnAutoWidth = False
    Me.xGHistoryView.OptionsView.ShowGroupPanel = False
    '
    'colID
    '
    Me.colID.Caption = "ID"
    Me.colID.Name = "colID"
    '
    'colKode
    '
    Me.colKode.Caption = "No. Transaksi"
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    Me.colKode.Width = 106
    '
    'colTanggal
    '
    Me.colTanggal.Caption = "Tanggal"
    Me.colTanggal.DisplayFormat.FormatString = "dd/MM/yy"
    Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 1
    Me.colTanggal.Width = 81
    '
    'colKeterangan
    '
    Me.colKeterangan.Caption = "Keterangan"
    Me.colKeterangan.FieldName = "Catatan"
    Me.colKeterangan.Name = "colKeterangan"
    Me.colKeterangan.Visible = True
    Me.colKeterangan.VisibleIndex = 2
    Me.colKeterangan.Width = 361
    '
    'navHistory
    '
    Me.navHistory.Caption = "History Transaksi"
    Me.navHistory.ControlContainer = Me.NavBarGroupControlContainer2
    Me.navHistory.Expanded = True
    Me.navHistory.GroupClientHeight = 200
    Me.navHistory.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
    Me.navHistory.Name = "navHistory"
    '
    'navCatatan
    '
    Me.navCatatan.Caption = "Catatan Kontak"
    Me.navCatatan.ControlContainer = Me.NavBarGroupControlContainer1
    Me.navCatatan.Expanded = True
    Me.navCatatan.GroupClientHeight = 100
    Me.navCatatan.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
    Me.navCatatan.Name = "navCatatan"
    '
    'DockPanel2
    '
    Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
    Me.DockPanel2.DockedAsTabbedDocument = True
    Me.DockPanel2.ID = New System.Guid("b7129287-a5f5-4623-9bff-ab6c88adf43f")
    Me.DockPanel2.Name = "DockPanel2"
    Me.DockPanel2.OriginalSize = New System.Drawing.Size(991, 483)
    Me.DockPanel2.Text = "DockPanel2"
    '
    'DockPanel2_Container
    '
    Me.DockPanel2_Container.Controls.Add(Me.LayoutControl1)
    Me.DockPanel2_Container.Location = New System.Drawing.Point(0, 0)
    Me.DockPanel2_Container.Name = "DockPanel2_Container"
    Me.DockPanel2_Container.Size = New System.Drawing.Size(991, 483)
    Me.DockPanel2_Container.TabIndex = 0
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.txtDRYTriplek)
    Me.LayoutControl1.Controls.Add(Me.txtDRYCargoNET)
    Me.LayoutControl1.Controls.Add(Me.txtICEMonitoring40)
    Me.LayoutControl1.Controls.Add(Me.txtICEMonitoring20)
    Me.LayoutControl1.Controls.Add(Me.txtICERecooling40)
    Me.LayoutControl1.Controls.Add(Me.txtICERecooling20)
    Me.LayoutControl1.Controls.Add(Me.txtICEVHC)
    Me.LayoutControl1.Controls.Add(Me.txtICEFee40)
    Me.LayoutControl1.Controls.Add(Me.txtDRYPlastik40)
    Me.LayoutControl1.Controls.Add(Me.txtDRYPlastik20)
    Me.LayoutControl1.Controls.Add(Me.txtDRYSanitari40)
    Me.LayoutControl1.Controls.Add(Me.txtDRYSantitari20)
    Me.LayoutControl1.Controls.Add(Me.txtDryTruckingLCL)
    Me.LayoutControl1.Controls.Add(Me.txtDRYTrucking20)
    Me.LayoutControl1.Controls.Add(Me.txtICEtbs)
    Me.LayoutControl1.Controls.Add(Me.txtDRYTrucking40)
    Me.LayoutControl1.Controls.Add(Me.txtICEFee20)
    Me.LayoutControl1.Controls.Add(Me.txtDryCTNS)
    Me.LayoutControl1.Controls.Add(Me.txtTipe)
    Me.LayoutControl1.Controls.Add(Me.txtPPH)
    Me.LayoutControl1.Controls.Add(Me.txtDiscount)
    Me.LayoutControl1.Controls.Add(Me.txtPPN)
    Me.LayoutControl1.Controls.Add(Me.txtSubTotal)
    Me.LayoutControl1.Controls.Add(Me.txtTotal)
    Me.LayoutControl1.Controls.Add(Me.txtStatus)
    Me.LayoutControl1.Controls.Add(Me.txtNoPPN)
    Me.LayoutControl1.Controls.Add(Me.txtShipment)
    Me.LayoutControl1.Controls.Add(Me.txtKontakPerson)
    Me.LayoutControl1.Controls.Add(Me.txtRegional)
    Me.LayoutControl1.Controls.Add(Me.txtTanggal)
    Me.LayoutControl1.Controls.Add(Me.btnRefreshNomor)
    Me.LayoutControl1.Controls.Add(Me.txtNoTransaksi)
    Me.LayoutControl1.Controls.Add(Me.xGrid)
    Me.LayoutControl1.Controls.Add(Me.txtUraian)
    Me.LayoutControl1.Controls.Add(Me.txtKontak)
    Me.LayoutControl1.Controls.Add(Me.txtAlamat)
    Me.LayoutControl1.Controls.Add(Me.txtCatatan)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4})
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(396, 446, 250, 350)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(991, 483)
    Me.LayoutControl1.TabIndex = 0
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'txtDRYTriplek
    '
    Me.txtDRYTriplek.Location = New System.Drawing.Point(313, 422)
    Me.txtDRYTriplek.MenuManager = Me.barMan
    Me.txtDRYTriplek.Name = "txtDRYTriplek"
    Me.txtDRYTriplek.Properties.Appearance.Options.UseTextOptions = True
    Me.txtDRYTriplek.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtDRYTriplek.Properties.Mask.EditMask = "n2"
    Me.txtDRYTriplek.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtDRYTriplek.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtDRYTriplek.Size = New System.Drawing.Size(95, 20)
    Me.txtDRYTriplek.StyleController = Me.LayoutControl1
    Me.txtDRYTriplek.TabIndex = 22
    '
    'txtDRYCargoNET
    '
    Me.txtDRYCargoNET.Location = New System.Drawing.Point(119, 422)
    Me.txtDRYCargoNET.MenuManager = Me.barMan
    Me.txtDRYCargoNET.Name = "txtDRYCargoNET"
    Me.txtDRYCargoNET.Properties.Appearance.Options.UseTextOptions = True
    Me.txtDRYCargoNET.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtDRYCargoNET.Properties.Mask.EditMask = "n2"
    Me.txtDRYCargoNET.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtDRYCargoNET.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtDRYCargoNET.Size = New System.Drawing.Size(95, 20)
    Me.txtDRYCargoNET.StyleController = Me.LayoutControl1
    Me.txtDRYCargoNET.TabIndex = 21
    '
    'txtICEMonitoring40
    '
    Me.txtICEMonitoring40.Location = New System.Drawing.Point(680, 398)
    Me.txtICEMonitoring40.MenuManager = Me.barMan
    Me.txtICEMonitoring40.Name = "txtICEMonitoring40"
    Me.txtICEMonitoring40.Properties.Appearance.Options.UseTextOptions = True
    Me.txtICEMonitoring40.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtICEMonitoring40.Properties.Mask.EditMask = "n2"
    Me.txtICEMonitoring40.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtICEMonitoring40.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtICEMonitoring40.Size = New System.Drawing.Size(50, 20)
    Me.txtICEMonitoring40.StyleController = Me.LayoutControl1
    Me.txtICEMonitoring40.TabIndex = 30
    '
    'txtICEMonitoring20
    '
    Me.txtICEMonitoring20.Location = New System.Drawing.Point(531, 398)
    Me.txtICEMonitoring20.MenuManager = Me.barMan
    Me.txtICEMonitoring20.Name = "txtICEMonitoring20"
    Me.txtICEMonitoring20.Properties.Appearance.Options.UseTextOptions = True
    Me.txtICEMonitoring20.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtICEMonitoring20.Properties.Mask.EditMask = "n2"
    Me.txtICEMonitoring20.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtICEMonitoring20.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtICEMonitoring20.Size = New System.Drawing.Size(50, 20)
    Me.txtICEMonitoring20.StyleController = Me.LayoutControl1
    Me.txtICEMonitoring20.TabIndex = 29
    '
    'txtICERecooling40
    '
    Me.txtICERecooling40.Location = New System.Drawing.Point(680, 374)
    Me.txtICERecooling40.MenuManager = Me.barMan
    Me.txtICERecooling40.Name = "txtICERecooling40"
    Me.txtICERecooling40.Properties.Appearance.Options.UseTextOptions = True
    Me.txtICERecooling40.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtICERecooling40.Properties.Mask.EditMask = "n2"
    Me.txtICERecooling40.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtICERecooling40.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtICERecooling40.Size = New System.Drawing.Size(50, 20)
    Me.txtICERecooling40.StyleController = Me.LayoutControl1
    Me.txtICERecooling40.TabIndex = 28
    '
    'txtICERecooling20
    '
    Me.txtICERecooling20.Location = New System.Drawing.Point(531, 374)
    Me.txtICERecooling20.MenuManager = Me.barMan
    Me.txtICERecooling20.Name = "txtICERecooling20"
    Me.txtICERecooling20.Properties.Appearance.Options.UseTextOptions = True
    Me.txtICERecooling20.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtICERecooling20.Properties.Mask.EditMask = "n2"
    Me.txtICERecooling20.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtICERecooling20.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtICERecooling20.Size = New System.Drawing.Size(50, 20)
    Me.txtICERecooling20.StyleController = Me.LayoutControl1
    Me.txtICERecooling20.TabIndex = 27
    '
    'txtICEVHC
    '
    Me.txtICEVHC.Location = New System.Drawing.Point(680, 350)
    Me.txtICEVHC.MenuManager = Me.barMan
    Me.txtICEVHC.Name = "txtICEVHC"
    Me.txtICEVHC.Properties.Appearance.Options.UseTextOptions = True
    Me.txtICEVHC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtICEVHC.Properties.Mask.EditMask = "n2"
    Me.txtICEVHC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtICEVHC.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtICEVHC.Size = New System.Drawing.Size(50, 20)
    Me.txtICEVHC.StyleController = Me.LayoutControl1
    Me.txtICEVHC.TabIndex = 26
    '
    'txtICEFee40
    '
    Me.txtICEFee40.Location = New System.Drawing.Point(680, 326)
    Me.txtICEFee40.MenuManager = Me.barMan
    Me.txtICEFee40.Name = "txtICEFee40"
    Me.txtICEFee40.Properties.Appearance.Options.UseTextOptions = True
    Me.txtICEFee40.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtICEFee40.Properties.Mask.EditMask = "n2"
    Me.txtICEFee40.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtICEFee40.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtICEFee40.Size = New System.Drawing.Size(50, 20)
    Me.txtICEFee40.StyleController = Me.LayoutControl1
    Me.txtICEFee40.TabIndex = 24
    '
    'txtDRYPlastik40
    '
    Me.txtDRYPlastik40.Location = New System.Drawing.Point(313, 398)
    Me.txtDRYPlastik40.MenuManager = Me.barMan
    Me.txtDRYPlastik40.Name = "txtDRYPlastik40"
    Me.txtDRYPlastik40.Properties.Appearance.Options.UseTextOptions = True
    Me.txtDRYPlastik40.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtDRYPlastik40.Properties.Mask.EditMask = "n2"
    Me.txtDRYPlastik40.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtDRYPlastik40.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtDRYPlastik40.Size = New System.Drawing.Size(95, 20)
    Me.txtDRYPlastik40.StyleController = Me.LayoutControl1
    Me.txtDRYPlastik40.TabIndex = 20
    '
    'txtDRYPlastik20
    '
    Me.txtDRYPlastik20.Location = New System.Drawing.Point(119, 398)
    Me.txtDRYPlastik20.MenuManager = Me.barMan
    Me.txtDRYPlastik20.Name = "txtDRYPlastik20"
    Me.txtDRYPlastik20.Properties.Appearance.Options.UseTextOptions = True
    Me.txtDRYPlastik20.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtDRYPlastik20.Properties.Mask.EditMask = "n2"
    Me.txtDRYPlastik20.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtDRYPlastik20.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtDRYPlastik20.Size = New System.Drawing.Size(95, 20)
    Me.txtDRYPlastik20.StyleController = Me.LayoutControl1
    Me.txtDRYPlastik20.TabIndex = 19
    '
    'txtDRYSanitari40
    '
    Me.txtDRYSanitari40.Location = New System.Drawing.Point(313, 374)
    Me.txtDRYSanitari40.MenuManager = Me.barMan
    Me.txtDRYSanitari40.Name = "txtDRYSanitari40"
    Me.txtDRYSanitari40.Properties.Appearance.Options.UseTextOptions = True
    Me.txtDRYSanitari40.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtDRYSanitari40.Properties.Mask.EditMask = "n2"
    Me.txtDRYSanitari40.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtDRYSanitari40.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtDRYSanitari40.Size = New System.Drawing.Size(95, 20)
    Me.txtDRYSanitari40.StyleController = Me.LayoutControl1
    Me.txtDRYSanitari40.TabIndex = 18
    '
    'txtDRYSantitari20
    '
    Me.txtDRYSantitari20.Location = New System.Drawing.Point(119, 374)
    Me.txtDRYSantitari20.MenuManager = Me.barMan
    Me.txtDRYSantitari20.Name = "txtDRYSantitari20"
    Me.txtDRYSantitari20.Properties.Appearance.Options.UseTextOptions = True
    Me.txtDRYSantitari20.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtDRYSantitari20.Properties.Mask.EditMask = "n2"
    Me.txtDRYSantitari20.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtDRYSantitari20.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtDRYSantitari20.Size = New System.Drawing.Size(95, 20)
    Me.txtDRYSantitari20.StyleController = Me.LayoutControl1
    Me.txtDRYSantitari20.TabIndex = 17
    '
    'txtDryTruckingLCL
    '
    Me.txtDryTruckingLCL.Location = New System.Drawing.Point(313, 350)
    Me.txtDryTruckingLCL.MenuManager = Me.barMan
    Me.txtDryTruckingLCL.Name = "txtDryTruckingLCL"
    Me.txtDryTruckingLCL.Properties.Appearance.Options.UseTextOptions = True
    Me.txtDryTruckingLCL.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtDryTruckingLCL.Properties.Mask.EditMask = "n2"
    Me.txtDryTruckingLCL.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtDryTruckingLCL.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtDryTruckingLCL.Size = New System.Drawing.Size(95, 20)
    Me.txtDryTruckingLCL.StyleController = Me.LayoutControl1
    Me.txtDryTruckingLCL.TabIndex = 16
    '
    'txtDRYTrucking20
    '
    Me.txtDRYTrucking20.Location = New System.Drawing.Point(313, 326)
    Me.txtDRYTrucking20.MenuManager = Me.barMan
    Me.txtDRYTrucking20.Name = "txtDRYTrucking20"
    Me.txtDRYTrucking20.Properties.Appearance.Options.UseTextOptions = True
    Me.txtDRYTrucking20.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtDRYTrucking20.Properties.Mask.EditMask = "n2"
    Me.txtDRYTrucking20.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtDRYTrucking20.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtDRYTrucking20.Size = New System.Drawing.Size(95, 20)
    Me.txtDRYTrucking20.StyleController = Me.LayoutControl1
    Me.txtDRYTrucking20.TabIndex = 14
    '
    'txtICEtbs
    '
    Me.txtICEtbs.Location = New System.Drawing.Point(531, 350)
    Me.txtICEtbs.MenuManager = Me.barMan
    Me.txtICEtbs.Name = "txtICEtbs"
    Me.txtICEtbs.Properties.Appearance.Options.UseTextOptions = True
    Me.txtICEtbs.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtICEtbs.Properties.Mask.EditMask = "n2"
    Me.txtICEtbs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtICEtbs.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtICEtbs.Size = New System.Drawing.Size(50, 20)
    Me.txtICEtbs.StyleController = Me.LayoutControl1
    Me.txtICEtbs.TabIndex = 25
    '
    'txtDRYTrucking40
    '
    Me.txtDRYTrucking40.Location = New System.Drawing.Point(119, 350)
    Me.txtDRYTrucking40.MenuManager = Me.barMan
    Me.txtDRYTrucking40.Name = "txtDRYTrucking40"
    Me.txtDRYTrucking40.Properties.Appearance.Options.UseTextOptions = True
    Me.txtDRYTrucking40.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtDRYTrucking40.Properties.Mask.EditMask = "n2"
    Me.txtDRYTrucking40.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtDRYTrucking40.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtDRYTrucking40.Size = New System.Drawing.Size(95, 20)
    Me.txtDRYTrucking40.StyleController = Me.LayoutControl1
    Me.txtDRYTrucking40.TabIndex = 15
    '
    'txtICEFee20
    '
    Me.txtICEFee20.Location = New System.Drawing.Point(531, 326)
    Me.txtICEFee20.MenuManager = Me.barMan
    Me.txtICEFee20.Name = "txtICEFee20"
    Me.txtICEFee20.Properties.Appearance.Options.UseTextOptions = True
    Me.txtICEFee20.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtICEFee20.Properties.Mask.EditMask = "n2"
    Me.txtICEFee20.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtICEFee20.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtICEFee20.Size = New System.Drawing.Size(50, 20)
    Me.txtICEFee20.StyleController = Me.LayoutControl1
    Me.txtICEFee20.TabIndex = 23
    '
    'txtDryCTNS
    '
    Me.txtDryCTNS.Location = New System.Drawing.Point(119, 326)
    Me.txtDryCTNS.MenuManager = Me.barMan
    Me.txtDryCTNS.Name = "txtDryCTNS"
    Me.txtDryCTNS.Properties.Appearance.Options.UseTextOptions = True
    Me.txtDryCTNS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtDryCTNS.Properties.Mask.EditMask = "n2"
    Me.txtDryCTNS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtDryCTNS.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtDryCTNS.Size = New System.Drawing.Size(95, 20)
    Me.txtDryCTNS.StyleController = Me.LayoutControl1
    Me.txtDryCTNS.TabIndex = 13
    '
    'txtTipe
    '
    Me.txtTipe.Location = New System.Drawing.Point(792, 119)
    Me.txtTipe.MenuManager = Me.barMan
    Me.txtTipe.Name = "txtTipe"
    Me.txtTipe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTipe.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Tipe")})
    Me.txtTipe.Properties.DisplayMember = "Value"
    Me.txtTipe.Properties.NullText = ""
    Me.txtTipe.Properties.ValueMember = "Key"
    Me.txtTipe.Size = New System.Drawing.Size(173, 20)
    Me.txtTipe.StyleController = Me.LayoutControl1
    Me.txtTipe.TabIndex = 10
    '
    'txtPPH
    '
    Me.txtPPH.Location = New System.Drawing.Point(853, 379)
    Me.txtPPH.MenuManager = Me.barMan
    Me.txtPPH.Name = "txtPPH"
    Me.txtPPH.Properties.Appearance.Options.UseTextOptions = True
    Me.txtPPH.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtPPH.Properties.Mask.EditMask = "n2"
    Me.txtPPH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtPPH.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtPPH.Size = New System.Drawing.Size(117, 20)
    Me.txtPPH.StyleController = Me.LayoutControl1
    Me.txtPPH.TabIndex = 34
    '
    'txtDiscount
    '
    Me.txtDiscount.Location = New System.Drawing.Point(853, 307)
    Me.txtDiscount.MenuManager = Me.barMan
    Me.txtDiscount.Name = "txtDiscount"
    Me.txtDiscount.Properties.Appearance.Options.UseTextOptions = True
    Me.txtDiscount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtDiscount.Properties.Mask.EditMask = "n2"
    Me.txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtDiscount.Size = New System.Drawing.Size(117, 20)
    Me.txtDiscount.StyleController = Me.LayoutControl1
    Me.txtDiscount.TabIndex = 31
    '
    'txtPPN
    '
    Me.txtPPN.Location = New System.Drawing.Point(853, 355)
    Me.txtPPN.MenuManager = Me.barMan
    Me.txtPPN.Name = "txtPPN"
    Me.txtPPN.Properties.Appearance.Options.UseTextOptions = True
    Me.txtPPN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtPPN.Properties.Mask.EditMask = "n2"
    Me.txtPPN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtPPN.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtPPN.Size = New System.Drawing.Size(117, 20)
    Me.txtPPN.StyleController = Me.LayoutControl1
    Me.txtPPN.TabIndex = 33
    '
    'txtSubTotal
    '
    Me.txtSubTotal.Location = New System.Drawing.Point(853, 331)
    Me.txtSubTotal.MenuManager = Me.barMan
    Me.txtSubTotal.Name = "txtSubTotal"
    Me.txtSubTotal.Properties.Appearance.Options.UseTextOptions = True
    Me.txtSubTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtSubTotal.Properties.Mask.EditMask = "n2"
    Me.txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtSubTotal.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtSubTotal.Size = New System.Drawing.Size(117, 20)
    Me.txtSubTotal.StyleController = Me.LayoutControl1
    Me.txtSubTotal.TabIndex = 32
    '
    'txtTotal
    '
    Me.txtTotal.Location = New System.Drawing.Point(853, 403)
    Me.txtTotal.MenuManager = Me.barMan
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
    Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtTotal.Properties.Mask.EditMask = "n2"
    Me.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtTotal.Size = New System.Drawing.Size(117, 20)
    Me.txtTotal.StyleController = Me.LayoutControl1
    Me.txtTotal.TabIndex = 35
    '
    'txtStatus
    '
    Me.txtStatus.Location = New System.Drawing.Point(868, 22)
    Me.txtStatus.MenuManager = Me.barMan
    Me.txtStatus.Name = "txtStatus"
    Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
    Me.txtStatus.Properties.DisplayMember = "Value"
    Me.txtStatus.Properties.NullText = "<Status>"
    Me.txtStatus.Properties.ValueMember = "Key"
    Me.txtStatus.Size = New System.Drawing.Size(98, 20)
    Me.txtStatus.StyleController = Me.LayoutControl1
    Me.txtStatus.TabIndex = 4
    '
    'txtNoPPN
    '
    Me.txtNoPPN.Location = New System.Drawing.Point(558, 119)
    Me.txtNoPPN.MenuManager = Me.barMan
    Me.txtNoPPN.Name = "txtNoPPN"
    Me.txtNoPPN.Size = New System.Drawing.Size(230, 20)
    Me.txtNoPPN.StyleController = Me.LayoutControl1
    Me.txtNoPPN.TabIndex = 9
    '
    'txtShipment
    '
    Me.txtShipment.Location = New System.Drawing.Point(792, 79)
    Me.txtShipment.MenuManager = Me.barMan
    Me.txtShipment.Name = "txtShipment"
    Me.txtShipment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtShipment.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.txtShipment.Properties.DisplayMember = "Kode"
    Me.txtShipment.Properties.NullText = "<Pilih Shipment Mode>"
    Me.txtShipment.Properties.ValueMember = "This"
    Me.txtShipment.Size = New System.Drawing.Size(173, 20)
    Me.txtShipment.StyleController = Me.LayoutControl1
    Me.txtShipment.TabIndex = 7
    '
    'txtKontakPerson
    '
    Me.txtKontakPerson.Location = New System.Drawing.Point(107, 63)
    Me.txtKontakPerson.MenuManager = Me.barMan
    Me.txtKontakPerson.Name = "txtKontakPerson"
    Me.txtKontakPerson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontakPerson.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 30, "Nama")})
    Me.txtKontakPerson.Properties.DisplayMember = "Nama"
    Me.txtKontakPerson.Properties.NullText = "<Pilih Kontak Person>"
    Me.txtKontakPerson.Properties.PopupWidth = 30
    Me.txtKontakPerson.Properties.ValueMember = "Nama"
    Me.txtKontakPerson.Size = New System.Drawing.Size(124, 20)
    Me.txtKontakPerson.StyleController = Me.LayoutControl1
    Me.txtKontakPerson.TabIndex = 5
    '
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(558, 79)
    Me.txtRegional.MenuManager = Me.barMan
    Me.txtRegional.Name = "txtRegional"
    Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 80, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 120, "Nama")})
    Me.txtRegional.Properties.DisplayMember = "Nama"
    Me.txtRegional.Properties.NullText = "<Pilih Regional>"
    Me.txtRegional.Properties.PopupWidth = 200
    Me.txtRegional.Properties.ValueMember = "This"
    Me.txtRegional.Size = New System.Drawing.Size(230, 20)
    Me.txtRegional.StyleController = Me.LayoutControl1
    Me.txtRegional.TabIndex = 6
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(463, 22)
    Me.txtTanggal.MenuManager = Me.barMan
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
    Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTanggal.Size = New System.Drawing.Size(110, 20)
    Me.txtTanggal.StyleController = Me.LayoutControl1
    Me.txtTanggal.TabIndex = 1
    '
    'btnRefreshNomor
    '
    Me.btnRefreshNomor.AutoWidthInLayoutControl = True
    Me.btnRefreshNomor.Image = CType(resources.GetObject("btnRefreshNomor.Image"), System.Drawing.Image)
    Me.btnRefreshNomor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
    Me.btnRefreshNomor.Location = New System.Drawing.Point(765, 22)
    Me.btnRefreshNomor.Name = "btnRefreshNomor"
    Me.btnRefreshNomor.Size = New System.Drawing.Size(26, 22)
    Me.btnRefreshNomor.StyleController = Me.LayoutControl1
    Me.btnRefreshNomor.TabIndex = 3
    '
    'txtNoTransaksi
    '
    Me.txtNoTransaksi.Location = New System.Drawing.Point(660, 22)
    Me.txtNoTransaksi.MenuManager = Me.barMan
    Me.txtNoTransaksi.Name = "txtNoTransaksi"
    Me.txtNoTransaksi.Size = New System.Drawing.Size(101, 20)
    Me.txtNoTransaksi.StyleController = Me.LayoutControl1
    Me.txtNoTransaksi.TabIndex = 2
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(12, 172)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.MenuManager = Me.barMan
    Me.xGrid.Name = "xGrid"
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colDestinationRepo, Me.colStuffingRepo})
    Me.xGrid.Size = New System.Drawing.Size(970, 114)
    Me.xGrid.TabIndex = 12
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gbInvoice, Me.gbDestination, Me.gbTotal, Me.gridBand7, Me.gridBand6, Me.gbCTNS, Me.gbTrucking, Me.gbCOODRY, Me.gbPhytosanitary, Me.gbPlastik, Me.gbCargo, Me.gbTriplek, Me.gbDryLain, Me.gbShipment, Me.gbShipment2, Me.gbCustom, Me.gbCOOICE, Me.gbVHC, Me.gbSeal, Me.gbRecooling, Me.gbMonitoring, Me.gbNotul, Me.gbBiayaLain})
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colInvoice, Me.colStuffing, Me.colDestination, Me.colTotal, Me.colCTNS, Me.colPartay20, Me.colPartay40, Me.colPartayLCL, Me.colIceShipmentFee20, Me.colIceShipmentFee40, Me.colIceShipmentFeeTBS, Me.colIceCustomInspection, Me.colIceCOO, Me.colIceVHCItem, Me.colIceVHCValue, Me.colIceSealFee, Me.colIceRecooling20, Me.colIceRecooling40, Me.colIceMonitoring20, Me.colIceMonitoring40, Me.colIceNotulPeb, Me.colDryCTNSValue, Me.colDryTrucking20, Me.colDryTrucking40, Me.colDryTruckingLCL, Me.colDryCOO, Me.colDryPhytosanitary20, Me.colDryPhytosanitary40, Me.colDryJaring20, Me.colDryJaring40, Me.colDryCargo, Me.colDryTriplek, Me.colDryMeratus, Me.colDryDocFee, Me.colDrySealFee, Me.colDryServiceCharge, Me.colDryLOLO, Me.colDryNotulPeb, Me.colBiayaLainLain})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.NewItemRowText = "Tambah Data"
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.ColumnAutoWidth = False
    Me.xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'gbInvoice
    '
    Me.gbInvoice.Columns.Add(Me.colInvoice)
    Me.gbInvoice.Columns.Add(Me.colStuffing)
    Me.gbInvoice.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    Me.gbInvoice.Name = "gbInvoice"
    Me.gbInvoice.VisibleIndex = 0
    Me.gbInvoice.Width = 199
    '
    'colInvoice
    '
    Me.colInvoice.Caption = "Invoice"
    Me.colInvoice.FieldName = "InvoiceNo"
    Me.colInvoice.Name = "colInvoice"
    Me.colInvoice.Visible = True
    Me.colInvoice.Width = 97
    '
    'colStuffing
    '
    Me.colStuffing.Caption = "Stuffing No"
    Me.colStuffing.ColumnEdit = Me.colStuffingRepo
    Me.colStuffing.FieldName = "Stuffing!"
    Me.colStuffing.Name = "colStuffing"
    Me.colStuffing.Visible = True
    Me.colStuffing.Width = 102
    '
    'colStuffingRepo
    '
    Me.colStuffingRepo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.colStuffingRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colStuffingRepo.DisplayMember = "Kode"
    Me.colStuffingRepo.Name = "colStuffingRepo"
    Me.colStuffingRepo.ValueMember = "This"
    Me.colStuffingRepo.View = Me.RepositoryItemSearchLookUpEdit1View
    '
    'RepositoryItemSearchLookUpEdit1View
    '
    Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
    Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
    Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Kode"
    Me.GridColumn1.FieldName = "Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Tanggal"
    Me.GridColumn2.FieldName = "Tanggal"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    '
    'gbDestination
    '
    Me.gbDestination.Columns.Add(Me.colDestination)
    Me.gbDestination.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    Me.gbDestination.Name = "gbDestination"
    Me.gbDestination.VisibleIndex = 1
    Me.gbDestination.Width = 128
    '
    'colDestination
    '
    Me.colDestination.Caption = "Destination"
    Me.colDestination.ColumnEdit = Me.colDestinationRepo
    Me.colDestination.FieldName = "Destination!"
    Me.colDestination.Name = "colDestination"
    Me.colDestination.Visible = True
    Me.colDestination.Width = 128
    '
    'colDestinationRepo
    '
    Me.colDestinationRepo.AutoHeight = False
    Me.colDestinationRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colDestinationRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.colDestinationRepo.DisplayMember = "Kode"
    Me.colDestinationRepo.Name = "colDestinationRepo"
    Me.colDestinationRepo.NullText = "<Pilih Destination>"
    Me.colDestinationRepo.ValueMember = "This"
    '
    'gbTotal
    '
    Me.gbTotal.Columns.Add(Me.colTotal)
    Me.gbTotal.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    Me.gbTotal.Name = "gbTotal"
    Me.gbTotal.VisibleIndex = 2
    Me.gbTotal.Width = 159
    '
    'colTotal
    '
    Me.colTotal.Caption = "Total"
    Me.colTotal.FieldName = "Total"
    Me.colTotal.Name = "colTotal"
    Me.colTotal.OptionsColumn.AllowEdit = False
    Me.colTotal.OptionsColumn.ReadOnly = True
    Me.colTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n2}")})
    Me.colTotal.Visible = True
    Me.colTotal.Width = 159
    '
    'gridBand7
    '
    Me.gridBand7.Columns.Add(Me.colCTNS)
    Me.gridBand7.Name = "gridBand7"
    Me.gridBand7.VisibleIndex = 3
    Me.gridBand7.Width = 62
    '
    'colCTNS
    '
    Me.colCTNS.Caption = "CTNS"
    Me.colCTNS.FieldName = "CTNS"
    Me.colCTNS.Name = "colCTNS"
    Me.colCTNS.Visible = True
    Me.colCTNS.Width = 62
    '
    'gridBand6
    '
    Me.gridBand6.Caption = "PARTAY"
    Me.gridBand6.Columns.Add(Me.colPartay20)
    Me.gridBand6.Columns.Add(Me.colPartay40)
    Me.gridBand6.Columns.Add(Me.colPartayLCL)
    Me.gridBand6.Name = "gridBand6"
    Me.gridBand6.VisibleIndex = 4
    Me.gridBand6.Width = 103
    '
    'colPartay20
    '
    Me.colPartay20.Caption = "20"""
    Me.colPartay20.FieldName = "Partay20"
    Me.colPartay20.Name = "colPartay20"
    Me.colPartay20.Visible = True
    Me.colPartay20.Width = 28
    '
    'colPartay40
    '
    Me.colPartay40.Caption = "40"""
    Me.colPartay40.FieldName = "Partay40"
    Me.colPartay40.Name = "colPartay40"
    Me.colPartay40.Visible = True
    Me.colPartay40.Width = 34
    '
    'colPartayLCL
    '
    Me.colPartayLCL.Caption = "LCL"
    Me.colPartayLCL.FieldName = "PartayLCL"
    Me.colPartayLCL.Name = "colPartayLCL"
    Me.colPartayLCL.Visible = True
    Me.colPartayLCL.Width = 41
    '
    'gbCTNS
    '
    Me.gbCTNS.Columns.Add(Me.colDryCTNSValue)
    Me.gbCTNS.Name = "gbCTNS"
    Me.gbCTNS.VisibleIndex = 5
    Me.gbCTNS.Width = 137
    '
    'colDryCTNSValue
    '
    Me.colDryCTNSValue.Caption = "CTNS"
    Me.colDryCTNSValue.FieldName = "DryCTNSValue"
    Me.colDryCTNSValue.Name = "colDryCTNSValue"
    Me.colDryCTNSValue.Visible = True
    Me.colDryCTNSValue.Width = 137
    '
    'gbTrucking
    '
    Me.gbTrucking.AppearanceHeader.Options.UseTextOptions = True
    Me.gbTrucking.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gbTrucking.Caption = "BIAYA TRUCKING"
    Me.gbTrucking.Columns.Add(Me.colDryTrucking20)
    Me.gbTrucking.Columns.Add(Me.colDryTrucking40)
    Me.gbTrucking.Columns.Add(Me.colDryTruckingLCL)
    Me.gbTrucking.Name = "gbTrucking"
    Me.gbTrucking.VisibleIndex = 6
    Me.gbTrucking.Width = 225
    '
    'colDryTrucking20
    '
    Me.colDryTrucking20.Caption = "20"""
    Me.colDryTrucking20.FieldName = "DryTrucking20"
    Me.colDryTrucking20.Name = "colDryTrucking20"
    Me.colDryTrucking20.Visible = True
    '
    'colDryTrucking40
    '
    Me.colDryTrucking40.Caption = "40"""
    Me.colDryTrucking40.FieldName = "DryTrucking40"
    Me.colDryTrucking40.Name = "colDryTrucking40"
    Me.colDryTrucking40.Visible = True
    '
    'colDryTruckingLCL
    '
    Me.colDryTruckingLCL.Caption = "LCL"
    Me.colDryTruckingLCL.FieldName = "DryTruckingLCL"
    Me.colDryTruckingLCL.Name = "colDryTruckingLCL"
    Me.colDryTruckingLCL.Visible = True
    '
    'gbCOODRY
    '
    Me.gbCOODRY.Columns.Add(Me.colDryCOO)
    Me.gbCOODRY.Name = "gbCOODRY"
    Me.gbCOODRY.VisibleIndex = 7
    Me.gbCOODRY.Width = 75
    '
    'colDryCOO
    '
    Me.colDryCOO.Caption = "COO"
    Me.colDryCOO.FieldName = "DryCOO"
    Me.colDryCOO.Name = "colDryCOO"
    Me.colDryCOO.Visible = True
    '
    'gbPhytosanitary
    '
    Me.gbPhytosanitary.AppearanceHeader.Options.UseTextOptions = True
    Me.gbPhytosanitary.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gbPhytosanitary.Caption = "PHITOSANITARY"
    Me.gbPhytosanitary.Columns.Add(Me.colDryPhytosanitary20)
    Me.gbPhytosanitary.Columns.Add(Me.colDryPhytosanitary40)
    Me.gbPhytosanitary.Name = "gbPhytosanitary"
    Me.gbPhytosanitary.VisibleIndex = 8
    Me.gbPhytosanitary.Width = 150
    '
    'colDryPhytosanitary20
    '
    Me.colDryPhytosanitary20.Caption = "20"""
    Me.colDryPhytosanitary20.FieldName = "DryPhytosanitary20"
    Me.colDryPhytosanitary20.Name = "colDryPhytosanitary20"
    Me.colDryPhytosanitary20.Visible = True
    '
    'colDryPhytosanitary40
    '
    Me.colDryPhytosanitary40.Caption = "40"""
    Me.colDryPhytosanitary40.FieldName = "DryPhytosanitary40"
    Me.colDryPhytosanitary40.Name = "colDryPhytosanitary40"
    Me.colDryPhytosanitary40.Visible = True
    '
    'gbPlastik
    '
    Me.gbPlastik.AppearanceHeader.Options.UseTextOptions = True
    Me.gbPlastik.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gbPlastik.Caption = "PLASTIK DAN JARING"
    Me.gbPlastik.Columns.Add(Me.colDryJaring20)
    Me.gbPlastik.Columns.Add(Me.colDryJaring40)
    Me.gbPlastik.Name = "gbPlastik"
    Me.gbPlastik.VisibleIndex = 9
    Me.gbPlastik.Width = 150
    '
    'colDryJaring20
    '
    Me.colDryJaring20.Caption = "20"""
    Me.colDryJaring20.FieldName = "DryJaring20"
    Me.colDryJaring20.Name = "colDryJaring20"
    Me.colDryJaring20.Visible = True
    '
    'colDryJaring40
    '
    Me.colDryJaring40.Caption = "40"""
    Me.colDryJaring40.FieldName = "DryJaring40"
    Me.colDryJaring40.Name = "colDryJaring40"
    Me.colDryJaring40.Visible = True
    '
    'gbCargo
    '
    Me.gbCargo.Caption = "CARGO"
    Me.gbCargo.Columns.Add(Me.colDryCargo)
    Me.gbCargo.Name = "gbCargo"
    Me.gbCargo.VisibleIndex = 10
    Me.gbCargo.Width = 75
    '
    'colDryCargo
    '
    Me.colDryCargo.Caption = "NET"
    Me.colDryCargo.FieldName = "DryCargo"
    Me.colDryCargo.Name = "colDryCargo"
    Me.colDryCargo.Visible = True
    '
    'gbTriplek
    '
    Me.gbTriplek.AppearanceHeader.Options.UseTextOptions = True
    Me.gbTriplek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gbTriplek.Caption = "Triplek & Strapping Band"
    Me.gbTriplek.Columns.Add(Me.colDryTriplek)
    Me.gbTriplek.Name = "gbTriplek"
    Me.gbTriplek.VisibleIndex = 11
    Me.gbTriplek.Width = 130
    '
    'colDryTriplek
    '
    Me.colDryTriplek.Caption = "FOR CIF, UI, TEA"
    Me.colDryTriplek.FieldName = "DryTriplek"
    Me.colDryTriplek.Name = "colDryTriplek"
    Me.colDryTriplek.Visible = True
    Me.colDryTriplek.Width = 130
    '
    'gbDryLain
    '
    Me.gbDryLain.Columns.Add(Me.colDryMeratus)
    Me.gbDryLain.Columns.Add(Me.colDryDocFee)
    Me.gbDryLain.Columns.Add(Me.colDrySealFee)
    Me.gbDryLain.Columns.Add(Me.colDryServiceCharge)
    Me.gbDryLain.Columns.Add(Me.colDryLOLO)
    Me.gbDryLain.Columns.Add(Me.colDryNotulPeb)
    Me.gbDryLain.Name = "gbDryLain"
    Me.gbDryLain.VisibleIndex = 12
    Me.gbDryLain.Width = 479
    '
    'colDryMeratus
    '
    Me.colDryMeratus.Caption = "B/L Meratus"
    Me.colDryMeratus.FieldName = "DryMeratus"
    Me.colDryMeratus.Name = "colDryMeratus"
    Me.colDryMeratus.Visible = True
    Me.colDryMeratus.Width = 81
    '
    'colDryDocFee
    '
    Me.colDryDocFee.Caption = "Doc. Fee"
    Me.colDryDocFee.FieldName = "DryDocFee"
    Me.colDryDocFee.Name = "colDryDocFee"
    Me.colDryDocFee.Visible = True
    '
    'colDrySealFee
    '
    Me.colDrySealFee.Caption = "Seal Fee"
    Me.colDrySealFee.FieldName = "DrySealFee"
    Me.colDrySealFee.Name = "colDrySealFee"
    Me.colDrySealFee.Visible = True
    Me.colDrySealFee.Width = 81
    '
    'colDryServiceCharge
    '
    Me.colDryServiceCharge.Caption = "Service Charge"
    Me.colDryServiceCharge.FieldName = "DryServiceCharge"
    Me.colDryServiceCharge.Name = "colDryServiceCharge"
    Me.colDryServiceCharge.Visible = True
    Me.colDryServiceCharge.Width = 92
    '
    'colDryLOLO
    '
    Me.colDryLOLO.Caption = "BIAYA LOLO"
    Me.colDryLOLO.FieldName = "DryLOLO"
    Me.colDryLOLO.Name = "colDryLOLO"
    Me.colDryLOLO.Visible = True
    '
    'colDryNotulPeb
    '
    Me.colDryNotulPeb.Caption = "NOTUL PEB"
    Me.colDryNotulPeb.FieldName = "DryNotulPeb"
    Me.colDryNotulPeb.Name = "colDryNotulPeb"
    Me.colDryNotulPeb.Visible = True
    '
    'gbShipment
    '
    Me.gbShipment.AppearanceHeader.Options.UseTextOptions = True
    Me.gbShipment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gbShipment.Caption = "SHIPMENT FEE"
    Me.gbShipment.Columns.Add(Me.colIceShipmentFee20)
    Me.gbShipment.Columns.Add(Me.colIceShipmentFee40)
    Me.gbShipment.Name = "gbShipment"
    Me.gbShipment.VisibleIndex = 13
    Me.gbShipment.Width = 150
    '
    'colIceShipmentFee20
    '
    Me.colIceShipmentFee20.Caption = "20"""
    Me.colIceShipmentFee20.FieldName = "IceShipmentFee20"
    Me.colIceShipmentFee20.Name = "colIceShipmentFee20"
    Me.colIceShipmentFee20.Visible = True
    '
    'colIceShipmentFee40
    '
    Me.colIceShipmentFee40.Caption = "40"""
    Me.colIceShipmentFee40.FieldName = "IceShipmentFee40"
    Me.colIceShipmentFee40.Name = "colIceShipmentFee40"
    Me.colIceShipmentFee40.Visible = True
    '
    'gbShipment2
    '
    Me.gbShipment2.Caption = "FEE"
    Me.gbShipment2.Columns.Add(Me.colIceShipmentFeeTBS)
    Me.gbShipment2.Name = "gbShipment2"
    Me.gbShipment2.VisibleIndex = 14
    Me.gbShipment2.Width = 75
    '
    'colIceShipmentFeeTBS
    '
    Me.colIceShipmentFeeTBS.Caption = "TBS/KIAT"
    Me.colIceShipmentFeeTBS.FieldName = "IceShipmentFeeTBS"
    Me.colIceShipmentFeeTBS.Name = "colIceShipmentFeeTBS"
    Me.colIceShipmentFeeTBS.Visible = True
    '
    'gbCustom
    '
    Me.gbCustom.AppearanceHeader.Options.UseTextOptions = True
    Me.gbCustom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gbCustom.Caption = "CUSTOM"
    Me.gbCustom.Columns.Add(Me.colIceCustomInspection)
    Me.gbCustom.Name = "gbCustom"
    Me.gbCustom.VisibleIndex = 15
    Me.gbCustom.Width = 75
    '
    'colIceCustomInspection
    '
    Me.colIceCustomInspection.Caption = "Inspection"
    Me.colIceCustomInspection.FieldName = "IceCustomInspection"
    Me.colIceCustomInspection.Name = "colIceCustomInspection"
    Me.colIceCustomInspection.Visible = True
    '
    'gbCOOICE
    '
    Me.gbCOOICE.Columns.Add(Me.colIceCOO)
    Me.gbCOOICE.Name = "gbCOOICE"
    Me.gbCOOICE.VisibleIndex = 16
    Me.gbCOOICE.Width = 75
    '
    'colIceCOO
    '
    Me.colIceCOO.FieldName = "IceCOO"
    Me.colIceCOO.Name = "colIceCOO"
    Me.colIceCOO.Visible = True
    '
    'gbVHC
    '
    Me.gbVHC.AppearanceHeader.Options.UseTextOptions = True
    Me.gbVHC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gbVHC.Caption = "VHC"
    Me.gbVHC.Columns.Add(Me.colIceVHCItem)
    Me.gbVHC.Columns.Add(Me.colIceVHCValue)
    Me.gbVHC.Name = "gbVHC"
    Me.gbVHC.VisibleIndex = 17
    Me.gbVHC.Width = 138
    '
    'colIceVHCItem
    '
    Me.colIceVHCItem.Caption = "Item"
    Me.colIceVHCItem.FieldName = "IceVHCItem"
    Me.colIceVHCItem.Name = "colIceVHCItem"
    Me.colIceVHCItem.Visible = True
    Me.colIceVHCItem.Width = 44
    '
    'colIceVHCValue
    '
    Me.colIceVHCValue.Caption = "Value"
    Me.colIceVHCValue.FieldName = "IceVHCValue"
    Me.colIceVHCValue.Name = "colIceVHCValue"
    Me.colIceVHCValue.Visible = True
    Me.colIceVHCValue.Width = 94
    '
    'gbSeal
    '
    Me.gbSeal.AppearanceHeader.Options.UseTextOptions = True
    Me.gbSeal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gbSeal.Caption = "SEAL"
    Me.gbSeal.Columns.Add(Me.colIceSealFee)
    Me.gbSeal.Name = "gbSeal"
    Me.gbSeal.VisibleIndex = 18
    Me.gbSeal.Width = 80
    '
    'colIceSealFee
    '
    Me.colIceSealFee.Caption = "FEE"
    Me.colIceSealFee.FieldName = "IceSealFee"
    Me.colIceSealFee.Name = "colIceSealFee"
    Me.colIceSealFee.Visible = True
    Me.colIceSealFee.Width = 80
    '
    'gbRecooling
    '
    Me.gbRecooling.AppearanceHeader.Options.UseTextOptions = True
    Me.gbRecooling.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gbRecooling.Caption = "RECOOLING/SHIFT"
    Me.gbRecooling.Columns.Add(Me.colIceRecooling20)
    Me.gbRecooling.Columns.Add(Me.colIceRecooling40)
    Me.gbRecooling.Name = "gbRecooling"
    Me.gbRecooling.VisibleIndex = 19
    Me.gbRecooling.Width = 164
    '
    'colIceRecooling20
    '
    Me.colIceRecooling20.Caption = "20"""
    Me.colIceRecooling20.FieldName = "IceRecooling20"
    Me.colIceRecooling20.Name = "colIceRecooling20"
    Me.colIceRecooling20.Visible = True
    Me.colIceRecooling20.Width = 86
    '
    'colIceRecooling40
    '
    Me.colIceRecooling40.Caption = "40"""
    Me.colIceRecooling40.FieldName = "IceRecooling40"
    Me.colIceRecooling40.Name = "colIceRecooling40"
    Me.colIceRecooling40.Visible = True
    Me.colIceRecooling40.Width = 78
    '
    'gbMonitoring
    '
    Me.gbMonitoring.AppearanceHeader.Options.UseTextOptions = True
    Me.gbMonitoring.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gbMonitoring.Caption = "MONITORING/SHIFT"
    Me.gbMonitoring.Columns.Add(Me.colIceMonitoring20)
    Me.gbMonitoring.Columns.Add(Me.colIceMonitoring40)
    Me.gbMonitoring.Name = "gbMonitoring"
    Me.gbMonitoring.VisibleIndex = 20
    Me.gbMonitoring.Width = 152
    '
    'colIceMonitoring20
    '
    Me.colIceMonitoring20.Caption = "20"""
    Me.colIceMonitoring20.FieldName = "IceMonitoring20"
    Me.colIceMonitoring20.Name = "colIceMonitoring20"
    Me.colIceMonitoring20.Visible = True
    Me.colIceMonitoring20.Width = 74
    '
    'colIceMonitoring40
    '
    Me.colIceMonitoring40.Caption = "40"""
    Me.colIceMonitoring40.FieldName = "IceMonitoring40"
    Me.colIceMonitoring40.Name = "colIceMonitoring40"
    Me.colIceMonitoring40.Visible = True
    Me.colIceMonitoring40.Width = 78
    '
    'gbNotul
    '
    Me.gbNotul.AppearanceHeader.Options.UseTextOptions = True
    Me.gbNotul.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gbNotul.Caption = "NOTUL"
    Me.gbNotul.Columns.Add(Me.colIceNotulPeb)
    Me.gbNotul.Name = "gbNotul"
    Me.gbNotul.VisibleIndex = 21
    Me.gbNotul.Width = 75
    '
    'colIceNotulPeb
    '
    Me.colIceNotulPeb.Caption = "PEB"
    Me.colIceNotulPeb.FieldName = "IceNotulPeb"
    Me.colIceNotulPeb.Name = "colIceNotulPeb"
    Me.colIceNotulPeb.Visible = True
    '
    'gbBiayaLain
    '
    Me.gbBiayaLain.Caption = "Biaya"
    Me.gbBiayaLain.Columns.Add(Me.colBiayaLainLain)
    Me.gbBiayaLain.Name = "gbBiayaLain"
    Me.gbBiayaLain.VisibleIndex = 22
    Me.gbBiayaLain.Width = 75
    '
    'colBiayaLainLain
    '
    Me.colBiayaLainLain.Caption = "Lain-Lain"
    Me.colBiayaLainLain.FieldName = "BiayaLainLain"
    Me.colBiayaLainLain.Name = "colBiayaLainLain"
    Me.colBiayaLainLain.Visible = True
    '
    'txtUraian
    '
    Me.txtUraian.Location = New System.Drawing.Point(107, 143)
    Me.txtUraian.MenuManager = Me.barMan
    Me.txtUraian.Name = "txtUraian"
    Me.txtUraian.Properties.MaxLength = 255
    Me.txtUraian.Size = New System.Drawing.Size(875, 20)
    Me.txtUraian.StyleController = Me.LayoutControl1
    Me.txtUraian.TabIndex = 11
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(82, 22)
    Me.txtKontak.MenuManager = Me.barMan
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontak.Properties.DisplayMember = "Kode"
    Me.txtKontak.Properties.NullText = "<Pilih Customer>"
    Me.txtKontak.Properties.PopupFormSize = New System.Drawing.Size(330, 0)
    Me.txtKontak.Properties.ShowClearButton = False
    Me.txtKontak.Properties.ShowFooter = False
    Me.txtKontak.Properties.ValueMember = "This"
    Me.txtKontak.Properties.View = Me.SearchLookUpEdit1View
    Me.txtKontak.Size = New System.Drawing.Size(124, 20)
    Me.txtKontak.StyleController = Me.LayoutControl1
    Me.txtKontak.TabIndex = 0
    '
    'SearchLookUpEdit1View
    '
    Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKontakKode, Me.colKontakNama})
    Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
    Me.SearchLookUpEdit1View.OptionsFind.FindDelay = 500
    Me.SearchLookUpEdit1View.OptionsFind.SearchInPreview = True
    Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
    Me.SearchLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colKontakKode, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'colKontakKode
    '
    Me.colKontakKode.Caption = "Kode"
    Me.colKontakKode.FieldName = "Kode"
    Me.colKontakKode.Name = "colKontakKode"
    Me.colKontakKode.Visible = True
    Me.colKontakKode.VisibleIndex = 0
    Me.colKontakKode.Width = 355
    '
    'colKontakNama
    '
    Me.colKontakNama.Caption = "Nama"
    Me.colKontakNama.FieldName = "Nama"
    Me.colKontakNama.Name = "colKontakNama"
    Me.colKontakNama.Visible = True
    Me.colKontakNama.VisibleIndex = 1
    Me.colKontakNama.Width = 723
    '
    'txtAlamat
    '
    Me.txtAlamat.Location = New System.Drawing.Point(107, 87)
    Me.txtAlamat.MenuManager = Me.barMan
    Me.txtAlamat.Name = "txtAlamat"
    Me.txtAlamat.Size = New System.Drawing.Size(124, 52)
    Me.txtAlamat.StyleController = Me.LayoutControl1
    Me.txtAlamat.TabIndex = 8
    Me.txtAlamat.UseOptimizedRendering = True
    '
    'txtCatatan
    '
    Me.txtCatatan.Location = New System.Drawing.Point(12, 330)
    Me.txtCatatan.MenuManager = Me.barMan
    Me.txtCatatan.Name = "txtCatatan"
    Me.txtCatatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCatatan.Size = New System.Drawing.Size(190, 20)
    Me.txtCatatan.StyleController = Me.LayoutControl1
    Me.txtCatatan.TabIndex = 12
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtCatatan
    Me.LayoutControlItem4.CustomizationFormText = "Catatan"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 302)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(194, 144)
    Me.LayoutControlItem4.Text = "Catatan"
    Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(73, 13)
    Me.LayoutControlItem4.TextToControlDistance = 5
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem7, Me.LayoutControlGroup3, Me.EmptySpaceItem7, Me.EmptySpaceItem8, Me.EmptySpaceItem9, Me.LayoutControlItem1, Me.EmptySpaceItem10, Me.EmptySpaceItem11, Me.LayoutControlGroup2, Me.lytRegional, Me.LayoutControlItem2, Me.LayoutControlItem10, Me.LayoutControlItem19, Me.LayoutControlItem8, Me.lytDRY, Me.lytICE})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(994, 466)
    Me.LayoutControlGroup1.Text = "Root"
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtUraian
    Me.LayoutControlItem3.CustomizationFormText = "Uraian"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 131)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(974, 24)
    Me.LayoutControlItem3.Text = "Uraian"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.xGrid
    Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 160)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(974, 118)
    Me.LayoutControlItem7.Text = "LayoutControlItem7"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem7.TextToControlDistance = 0
    Me.LayoutControlItem7.TextVisible = False
    '
    'LayoutControlGroup3
    '
    Me.LayoutControlGroup3.AppearanceGroup.BackColor = System.Drawing.SystemColors.ControlDark
    Me.LayoutControlGroup3.AppearanceGroup.BackColor2 = System.Drawing.SystemColors.ControlDark
    Me.LayoutControlGroup3.AppearanceGroup.Options.UseBackColor = True
    Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup3"
    Me.LayoutControlGroup3.GroupBordersVisible = False
    Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem16, Me.layKontakNama, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.EmptySpaceItem5, Me.LayoutControlItem15, Me.EmptySpaceItem6, Me.LayoutControlItem14, Me.LayoutControlItem17, Me.EmptySpaceItem21})
    Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
    Me.LayoutControlGroup3.Size = New System.Drawing.Size(974, 46)
    Me.LayoutControlGroup3.Text = "LayoutControlGroup3"
    Me.LayoutControlGroup3.TextVisible = False
    '
    'layKontak
    '
    Me.layKontak.Control = Me.txtKontak
    Me.layKontak.CustomizationFormText = "Vendor"
    Me.layKontak.Location = New System.Drawing.Point(10, 10)
    Me.layKontak.MinSize = New System.Drawing.Size(50, 25)
    Me.layKontak.Name = "layKontak"
    Me.layKontak.Size = New System.Drawing.Size(188, 26)
    Me.layKontak.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.layKontak.Text = "Customer   "
    Me.layKontak.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.layKontak.TextSize = New System.Drawing.Size(55, 13)
    Me.layKontak.TextToControlDistance = 5
    '
    'LayoutControlItem16
    '
    Me.LayoutControlItem16.Control = Me.txtNoTransaksi
    Me.LayoutControlItem16.CustomizationFormText = "No. Transaksi"
    Me.LayoutControlItem16.Location = New System.Drawing.Point(591, 10)
    Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(162, 26)
    Me.LayoutControlItem16.MinSize = New System.Drawing.Size(162, 26)
    Me.LayoutControlItem16.Name = "LayoutControlItem16"
    Me.LayoutControlItem16.Size = New System.Drawing.Size(162, 26)
    Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem16.Text = "No. Bukti   "
    Me.LayoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem16.TextSize = New System.Drawing.Size(52, 13)
    Me.LayoutControlItem16.TextToControlDistance = 5
    '
    'layKontakNama
    '
    Me.layKontakNama.AllowHotTrack = False
    Me.layKontakNama.CustomizationFormText = "kontak nama"
    Me.layKontakNama.Location = New System.Drawing.Point(198, 10)
    Me.layKontakNama.Name = "layKontakNama"
    Me.layKontakNama.Size = New System.Drawing.Size(201, 26)
    Me.layKontakNama.Text = "-"
    Me.layKontakNama.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.layKontakNama.TextSize = New System.Drawing.Size(4, 13)
    '
    'EmptySpaceItem2
    '
    Me.EmptySpaceItem2.AllowHotTrack = False
    Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
    Me.EmptySpaceItem2.FillControlToClientArea = False
    Me.EmptySpaceItem2.Location = New System.Drawing.Point(10, 0)
    Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(948, 10)
    Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(948, 10)
    Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Size = New System.Drawing.Size(948, 10)
    Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
    Me.EmptySpaceItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
    Me.EmptySpaceItem2.TrimClientAreaToControl = False
    '
    'EmptySpaceItem3
    '
    Me.EmptySpaceItem3.AllowHotTrack = False
    Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
    Me.EmptySpaceItem3.FillControlToClientArea = False
    Me.EmptySpaceItem3.Location = New System.Drawing.Point(10, 36)
    Me.EmptySpaceItem3.MaxSize = New System.Drawing.Size(948, 10)
    Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(948, 10)
    Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Size = New System.Drawing.Size(948, 10)
    Me.EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
    Me.EmptySpaceItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
    Me.EmptySpaceItem3.TrimClientAreaToControl = False
    '
    'EmptySpaceItem4
    '
    Me.EmptySpaceItem4.AllowHotTrack = False
    Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 0)
    Me.EmptySpaceItem4.MaxSize = New System.Drawing.Size(10, 46)
    Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(10, 46)
    Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Size = New System.Drawing.Size(10, 46)
    Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
    Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem5
    '
    Me.EmptySpaceItem5.AllowHotTrack = False
    Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Location = New System.Drawing.Point(958, 0)
    Me.EmptySpaceItem5.MaxSize = New System.Drawing.Size(16, 46)
    Me.EmptySpaceItem5.MinSize = New System.Drawing.Size(16, 46)
    Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Size = New System.Drawing.Size(16, 46)
    Me.EmptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
    Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem15
    '
    Me.LayoutControlItem15.Control = Me.txtTanggal
    Me.LayoutControlItem15.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem15.Location = New System.Drawing.Point(399, 10)
    Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(166, 26)
    Me.LayoutControlItem15.MinSize = New System.Drawing.Size(166, 26)
    Me.LayoutControlItem15.Name = "LayoutControlItem15"
    Me.LayoutControlItem15.Size = New System.Drawing.Size(166, 26)
    Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem15.Text = "Tanggal   "
    Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem15.TextSize = New System.Drawing.Size(47, 13)
    Me.LayoutControlItem15.TextToControlDistance = 5
    '
    'EmptySpaceItem6
    '
    Me.EmptySpaceItem6.AllowHotTrack = False
    Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Location = New System.Drawing.Point(565, 10)
    Me.EmptySpaceItem6.MaxSize = New System.Drawing.Size(26, 26)
    Me.EmptySpaceItem6.MinSize = New System.Drawing.Size(26, 26)
    Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Size = New System.Drawing.Size(26, 26)
    Me.EmptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
    Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem14
    '
    Me.LayoutControlItem14.Control = Me.txtStatus
    Me.LayoutControlItem14.CustomizationFormText = "Status"
    Me.LayoutControlItem14.Location = New System.Drawing.Point(811, 10)
    Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(147, 26)
    Me.LayoutControlItem14.MinSize = New System.Drawing.Size(147, 26)
    Me.LayoutControlItem14.Name = "LayoutControlItem14"
    Me.LayoutControlItem14.Size = New System.Drawing.Size(147, 26)
    Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem14.Text = "Status   "
    Me.LayoutControlItem14.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem14.TextSize = New System.Drawing.Size(40, 13)
    Me.LayoutControlItem14.TextToControlDistance = 5
    '
    'LayoutControlItem17
    '
    Me.LayoutControlItem17.Control = Me.btnRefreshNomor
    Me.LayoutControlItem17.CustomizationFormText = " "
    Me.LayoutControlItem17.Location = New System.Drawing.Point(753, 10)
    Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(30, 26)
    Me.LayoutControlItem17.MinSize = New System.Drawing.Size(30, 26)
    Me.LayoutControlItem17.Name = "LayoutControlItem17"
    Me.LayoutControlItem17.Size = New System.Drawing.Size(30, 26)
    Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem17.Text = " "
    Me.LayoutControlItem17.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem17.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem17.TextToControlDistance = 0
    Me.LayoutControlItem17.TextVisible = False
    Me.LayoutControlItem17.TrimClientAreaToControl = False
    '
    'EmptySpaceItem21
    '
    Me.EmptySpaceItem21.AllowHotTrack = False
    Me.EmptySpaceItem21.CustomizationFormText = "EmptySpaceItem21"
    Me.EmptySpaceItem21.Location = New System.Drawing.Point(783, 10)
    Me.EmptySpaceItem21.MaxSize = New System.Drawing.Size(28, 26)
    Me.EmptySpaceItem21.MinSize = New System.Drawing.Size(28, 26)
    Me.EmptySpaceItem21.Name = "EmptySpaceItem21"
    Me.EmptySpaceItem21.Size = New System.Drawing.Size(28, 26)
    Me.EmptySpaceItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem21.Text = "EmptySpaceItem21"
    Me.EmptySpaceItem21.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem7
    '
    Me.EmptySpaceItem7.AllowHotTrack = False
    Me.EmptySpaceItem7.CustomizationFormText = "EmptySpaceItem7"
    Me.EmptySpaceItem7.Location = New System.Drawing.Point(0, 46)
    Me.EmptySpaceItem7.MaxSize = New System.Drawing.Size(0, 5)
    Me.EmptySpaceItem7.MinSize = New System.Drawing.Size(10, 5)
    Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
    Me.EmptySpaceItem7.Size = New System.Drawing.Size(974, 5)
    Me.EmptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem7.Text = "EmptySpaceItem7"
    Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem8
    '
    Me.EmptySpaceItem8.AllowHotTrack = False
    Me.EmptySpaceItem8.CustomizationFormText = "EmptySpaceItem8"
    Me.EmptySpaceItem8.Location = New System.Drawing.Point(0, 155)
    Me.EmptySpaceItem8.MaxSize = New System.Drawing.Size(0, 5)
    Me.EmptySpaceItem8.MinSize = New System.Drawing.Size(10, 5)
    Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
    Me.EmptySpaceItem8.Size = New System.Drawing.Size(974, 5)
    Me.EmptySpaceItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem8.Text = "EmptySpaceItem8"
    Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem9
    '
    Me.EmptySpaceItem9.AllowHotTrack = False
    Me.EmptySpaceItem9.CustomizationFormText = "EmptySpaceItem9"
    Me.EmptySpaceItem9.Location = New System.Drawing.Point(0, 278)
    Me.EmptySpaceItem9.MaxSize = New System.Drawing.Size(0, 5)
    Me.EmptySpaceItem9.MinSize = New System.Drawing.Size(10, 5)
    Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
    Me.EmptySpaceItem9.Size = New System.Drawing.Size(974, 5)
    Me.EmptySpaceItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem9.Text = "EmptySpaceItem9"
    Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtKontakPerson
    Me.LayoutControlItem1.CustomizationFormText = "Kontak Person"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 51)
    Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(223, 24)
    Me.LayoutControlItem1.MinSize = New System.Drawing.Size(223, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(223, 24)
    Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem1.Text = "Kontak Person"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(92, 13)
    '
    'EmptySpaceItem10
    '
    Me.EmptySpaceItem10.AllowHotTrack = False
    Me.EmptySpaceItem10.CustomizationFormText = "EmptySpaceItem10"
    Me.EmptySpaceItem10.Location = New System.Drawing.Point(957, 51)
    Me.EmptySpaceItem10.MaxSize = New System.Drawing.Size(17, 80)
    Me.EmptySpaceItem10.MinSize = New System.Drawing.Size(17, 80)
    Me.EmptySpaceItem10.Name = "EmptySpaceItem10"
    Me.EmptySpaceItem10.Size = New System.Drawing.Size(17, 80)
    Me.EmptySpaceItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem10.Text = "EmptySpaceItem10"
    Me.EmptySpaceItem10.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem11
    '
    Me.EmptySpaceItem11.AllowHotTrack = False
    Me.EmptySpaceItem11.CustomizationFormText = "EmptySpaceItem11"
    Me.EmptySpaceItem11.Location = New System.Drawing.Point(223, 51)
    Me.EmptySpaceItem11.MinSize = New System.Drawing.Size(104, 24)
    Me.EmptySpaceItem11.Name = "EmptySpaceItem11"
    Me.EmptySpaceItem11.Size = New System.Drawing.Size(323, 80)
    Me.EmptySpaceItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem11.Text = "EmptySpaceItem11"
    Me.EmptySpaceItem11.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem23, Me.LayoutControlItem13, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem1})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(734, 283)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(240, 163)
    Me.LayoutControlGroup2.Text = "LayoutControlGroup2"
    Me.LayoutControlGroup2.TextVisible = False
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.Control = Me.txtTotal
    Me.LayoutControlItem9.CustomizationFormText = "Total Transaksi"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 96)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(216, 24)
    Me.LayoutControlItem9.Text = "Total Transaksi"
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem23
    '
    Me.LayoutControlItem23.Control = Me.txtPPN
    Me.LayoutControlItem23.CustomizationFormText = "PPN"
    Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem23.Name = "LayoutControlItem23"
    Me.LayoutControlItem23.Size = New System.Drawing.Size(216, 24)
    Me.LayoutControlItem23.Text = "PPN"
    Me.LayoutControlItem23.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem13
    '
    Me.LayoutControlItem13.Control = Me.txtSubTotal
    Me.LayoutControlItem13.CustomizationFormText = "Sub Total"
    Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem13.Name = "LayoutControlItem13"
    Me.LayoutControlItem13.Size = New System.Drawing.Size(216, 24)
    Me.LayoutControlItem13.Text = "Sub Total"
    Me.LayoutControlItem13.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtDiscount
    Me.LayoutControlItem5.CustomizationFormText = "Discount"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(216, 24)
    Me.LayoutControlItem5.MinSize = New System.Drawing.Size(216, 24)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(216, 24)
    Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem5.Text = "Discount"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtPPH
    Me.LayoutControlItem6.CustomizationFormText = "PPH"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(216, 24)
    Me.LayoutControlItem6.Text = "PPH"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(92, 13)
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 120)
    Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(0, 19)
    Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(10, 19)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(216, 19)
    Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'lytRegional
    '
    Me.lytRegional.Control = Me.txtRegional
    Me.lytRegional.CustomizationFormText = "Regional"
    Me.lytRegional.Location = New System.Drawing.Point(546, 51)
    Me.lytRegional.MinSize = New System.Drawing.Size(77, 40)
    Me.lytRegional.Name = "lytRegional"
    Me.lytRegional.Size = New System.Drawing.Size(234, 40)
    Me.lytRegional.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.lytRegional.Text = "Regional"
    Me.lytRegional.TextLocation = DevExpress.Utils.Locations.Top
    Me.lytRegional.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtAlamat
    Me.LayoutControlItem2.CustomizationFormText = "Alamat"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 75)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(223, 56)
    Me.LayoutControlItem2.Text = "Alamat"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem10
    '
    Me.LayoutControlItem10.Control = Me.txtShipment
    Me.LayoutControlItem10.CustomizationFormText = "Pajak"
    Me.LayoutControlItem10.Location = New System.Drawing.Point(780, 51)
    Me.LayoutControlItem10.MinSize = New System.Drawing.Size(77, 40)
    Me.LayoutControlItem10.Name = "LayoutControlItem10"
    Me.LayoutControlItem10.Size = New System.Drawing.Size(177, 40)
    Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem10.Text = "Shipment Mode"
    Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem10.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem19
    '
    Me.LayoutControlItem19.Control = Me.txtNoPPN
    Me.LayoutControlItem19.CustomizationFormText = "No Faktur PPN"
    Me.LayoutControlItem19.Location = New System.Drawing.Point(546, 91)
    Me.LayoutControlItem19.MinSize = New System.Drawing.Size(106, 40)
    Me.LayoutControlItem19.Name = "LayoutControlItem19"
    Me.LayoutControlItem19.Size = New System.Drawing.Size(234, 40)
    Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem19.Text = "No Faktur PPN"
    Me.LayoutControlItem19.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem19.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtTipe
    Me.LayoutControlItem8.CustomizationFormText = "Tipe"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(780, 91)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(177, 40)
    Me.LayoutControlItem8.Text = "Tipe"
    Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(92, 13)
    '
    'lytDRY
    '
    Me.lytDRY.CustomizationFormText = "DRY"
    Me.lytDRY.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem11, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem27, Me.LayoutControlItem34, Me.LayoutControlItem35})
    Me.lytDRY.Location = New System.Drawing.Point(0, 283)
    Me.lytDRY.Name = "lytDRY"
    Me.lytDRY.Size = New System.Drawing.Size(412, 163)
    Me.lytDRY.Text = "DRY"
    '
    'LayoutControlItem12
    '
    Me.LayoutControlItem12.Control = Me.txtDRYTrucking40
    Me.LayoutControlItem12.CustomizationFormText = "Trucking 40"""
    Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem12.Name = "LayoutControlItem12"
    Me.LayoutControlItem12.Size = New System.Drawing.Size(194, 24)
    Me.LayoutControlItem12.Text = "Trucking 40"""
    Me.LayoutControlItem12.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem11
    '
    Me.LayoutControlItem11.Control = Me.txtDryCTNS
    Me.LayoutControlItem11.CustomizationFormText = "CTNS"
    Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem11.Name = "LayoutControlItem11"
    Me.LayoutControlItem11.Size = New System.Drawing.Size(194, 24)
    Me.LayoutControlItem11.Text = "CTNS"
    Me.LayoutControlItem11.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem21
    '
    Me.LayoutControlItem21.Control = Me.txtDRYTrucking20
    Me.LayoutControlItem21.CustomizationFormText = "Trucking 20"""
    Me.LayoutControlItem21.Location = New System.Drawing.Point(194, 0)
    Me.LayoutControlItem21.Name = "LayoutControlItem21"
    Me.LayoutControlItem21.Size = New System.Drawing.Size(194, 24)
    Me.LayoutControlItem21.Text = "Trucking 20"""
    Me.LayoutControlItem21.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem22
    '
    Me.LayoutControlItem22.Control = Me.txtDryTruckingLCL
    Me.LayoutControlItem22.CustomizationFormText = "Trucking LCL"
    Me.LayoutControlItem22.Location = New System.Drawing.Point(194, 24)
    Me.LayoutControlItem22.Name = "LayoutControlItem22"
    Me.LayoutControlItem22.Size = New System.Drawing.Size(194, 24)
    Me.LayoutControlItem22.Text = "Trucking LCL"
    Me.LayoutControlItem22.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem24
    '
    Me.LayoutControlItem24.Control = Me.txtDRYSantitari20
    Me.LayoutControlItem24.CustomizationFormText = "Phytosanitary 20"""
    Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem24.Name = "LayoutControlItem24"
    Me.LayoutControlItem24.Size = New System.Drawing.Size(194, 24)
    Me.LayoutControlItem24.Text = "Phytosanitary 20"""
    Me.LayoutControlItem24.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem25
    '
    Me.LayoutControlItem25.Control = Me.txtDRYSanitari40
    Me.LayoutControlItem25.CustomizationFormText = "Phytosanitary 40"""
    Me.LayoutControlItem25.Location = New System.Drawing.Point(194, 48)
    Me.LayoutControlItem25.Name = "LayoutControlItem25"
    Me.LayoutControlItem25.Size = New System.Drawing.Size(194, 24)
    Me.LayoutControlItem25.Text = "Phytosanitary 40"""
    Me.LayoutControlItem25.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem26
    '
    Me.LayoutControlItem26.Control = Me.txtDRYPlastik20
    Me.LayoutControlItem26.CustomizationFormText = "Plastik dll 20"""
    Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem26.Name = "LayoutControlItem26"
    Me.LayoutControlItem26.Size = New System.Drawing.Size(194, 24)
    Me.LayoutControlItem26.Text = "Plastik dll 20"""
    Me.LayoutControlItem26.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem27
    '
    Me.LayoutControlItem27.Control = Me.txtDRYPlastik40
    Me.LayoutControlItem27.CustomizationFormText = "Plastik dll 40"""
    Me.LayoutControlItem27.Location = New System.Drawing.Point(194, 72)
    Me.LayoutControlItem27.Name = "LayoutControlItem27"
    Me.LayoutControlItem27.Size = New System.Drawing.Size(194, 24)
    Me.LayoutControlItem27.Text = "Plastik dll 40"""
    Me.LayoutControlItem27.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem34
    '
    Me.LayoutControlItem34.Control = Me.txtDRYCargoNET
    Me.LayoutControlItem34.CustomizationFormText = "Cargo NET"
    Me.LayoutControlItem34.Location = New System.Drawing.Point(0, 96)
    Me.LayoutControlItem34.Name = "LayoutControlItem34"
    Me.LayoutControlItem34.Size = New System.Drawing.Size(194, 24)
    Me.LayoutControlItem34.Text = "Cargo NET"
    Me.LayoutControlItem34.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem35
    '
    Me.LayoutControlItem35.Control = Me.txtDRYTriplek
    Me.LayoutControlItem35.CustomizationFormText = "Triplek dll"
    Me.LayoutControlItem35.Location = New System.Drawing.Point(194, 96)
    Me.LayoutControlItem35.Name = "LayoutControlItem35"
    Me.LayoutControlItem35.Size = New System.Drawing.Size(194, 24)
    Me.LayoutControlItem35.Text = "Triplek dll"
    Me.LayoutControlItem35.TextSize = New System.Drawing.Size(92, 13)
    '
    'lytICE
    '
    Me.lytICE.CustomizationFormText = "ICE"
    Me.lytICE.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem18, Me.LayoutControlItem20, Me.LayoutControlItem28, Me.LayoutControlItem29, Me.LayoutControlItem30, Me.LayoutControlItem31, Me.LayoutControlItem32, Me.LayoutControlItem33})
    Me.lytICE.Location = New System.Drawing.Point(412, 283)
    Me.lytICE.Name = "lytICE"
    Me.lytICE.Size = New System.Drawing.Size(322, 163)
    Me.lytICE.Text = "ICE"
    '
    'LayoutControlItem18
    '
    Me.LayoutControlItem18.Control = Me.txtICEtbs
    Me.LayoutControlItem18.CustomizationFormText = "Shipment TBS/KIAT"
    Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem18.Name = "LayoutControlItem18"
    Me.LayoutControlItem18.Size = New System.Drawing.Size(149, 24)
    Me.LayoutControlItem18.Text = "Shipment TBS/KIAT"
    Me.LayoutControlItem18.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem20
    '
    Me.LayoutControlItem20.Control = Me.txtICEFee20
    Me.LayoutControlItem20.CustomizationFormText = "Shipment Fee 20"""
    Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem20.Name = "LayoutControlItem20"
    Me.LayoutControlItem20.Size = New System.Drawing.Size(149, 24)
    Me.LayoutControlItem20.Text = "Shipment Fee 20"""
    Me.LayoutControlItem20.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem28
    '
    Me.LayoutControlItem28.Control = Me.txtICEFee40
    Me.LayoutControlItem28.CustomizationFormText = "Shipment Fee 40"""
    Me.LayoutControlItem28.Location = New System.Drawing.Point(149, 0)
    Me.LayoutControlItem28.Name = "LayoutControlItem28"
    Me.LayoutControlItem28.Size = New System.Drawing.Size(149, 24)
    Me.LayoutControlItem28.Text = "Shipment Fee 40"""
    Me.LayoutControlItem28.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem29
    '
    Me.LayoutControlItem29.Control = Me.txtICEVHC
    Me.LayoutControlItem29.CustomizationFormText = "VHC"
    Me.LayoutControlItem29.Location = New System.Drawing.Point(149, 24)
    Me.LayoutControlItem29.Name = "LayoutControlItem29"
    Me.LayoutControlItem29.Size = New System.Drawing.Size(149, 24)
    Me.LayoutControlItem29.Text = "VHC"
    Me.LayoutControlItem29.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem30
    '
    Me.LayoutControlItem30.Control = Me.txtICERecooling20
    Me.LayoutControlItem30.CustomizationFormText = "Recooling 20"""
    Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem30.Name = "LayoutControlItem30"
    Me.LayoutControlItem30.Size = New System.Drawing.Size(149, 24)
    Me.LayoutControlItem30.Text = "Recooling 20"""
    Me.LayoutControlItem30.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem31
    '
    Me.LayoutControlItem31.Control = Me.txtICERecooling40
    Me.LayoutControlItem31.CustomizationFormText = "Recooling 40"""
    Me.LayoutControlItem31.Location = New System.Drawing.Point(149, 48)
    Me.LayoutControlItem31.Name = "LayoutControlItem31"
    Me.LayoutControlItem31.Size = New System.Drawing.Size(149, 24)
    Me.LayoutControlItem31.Text = "Recooling 40"""
    Me.LayoutControlItem31.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem32
    '
    Me.LayoutControlItem32.Control = Me.txtICEMonitoring20
    Me.LayoutControlItem32.CustomizationFormText = "Monitoring 20"""
    Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem32.Name = "LayoutControlItem32"
    Me.LayoutControlItem32.Size = New System.Drawing.Size(149, 48)
    Me.LayoutControlItem32.Text = "Monitoring 20"""
    Me.LayoutControlItem32.TextSize = New System.Drawing.Size(92, 13)
    '
    'LayoutControlItem33
    '
    Me.LayoutControlItem33.Control = Me.txtICEMonitoring40
    Me.LayoutControlItem33.CustomizationFormText = "Monitoring 40"""
    Me.LayoutControlItem33.Location = New System.Drawing.Point(149, 72)
    Me.LayoutControlItem33.Name = "LayoutControlItem33"
    Me.LayoutControlItem33.Size = New System.Drawing.Size(149, 48)
    Me.LayoutControlItem33.Text = "Monitoring 40"""
    Me.LayoutControlItem33.TextSize = New System.Drawing.Size(92, 13)
    '
    'DocumentManager1
    '
    Me.DocumentManager1.ContainerControl = Me
    Me.DocumentManager1.View = Me.TabbedView1
    Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1})
    '
    'TabbedView1
    '
    Me.TabbedView1.DocumentGroupProperties.ShowTabHeader = False
    Me.TabbedView1.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() {Me.DocumentGroup1})
    Me.TabbedView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.Document1})
    '
    'DocumentGroup1
    '
    Me.DocumentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.Document1})
    '
    'Document1
    '
    Me.Document1.Caption = "DockPanel2"
    Me.Document1.FloatLocation = New System.Drawing.Point(0, 0)
    Me.Document1.FloatSize = New System.Drawing.Size(200, 200)
    Me.Document1.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[True]
    Me.Document1.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
    Me.Document1.Properties.ShowPinButton = DevExpress.Utils.DefaultBoolean.[True]
    '
    'BarStaticItem1
    '
    Me.BarStaticItem1.Caption = "xx"
    Me.BarStaticItem1.Id = 6
    Me.BarStaticItem1.Name = "BarStaticItem1"
    Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
    '
    'BarStaticItem2
    '
    Me.BarStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
    Me.BarStaticItem2.Caption = "Tekan Ctrl+Del untuk Menghapus Baris Pada Grid"
    Me.BarStaticItem2.Id = 7
    Me.BarStaticItem2.Name = "BarStaticItem2"
    Me.BarStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
    '
    'UI_zForwarderInvoiceDialog2
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(997, 516)
    Me.Controls.Add(Me.hideContainerRight)
    Me.KeyPreview = True
    Me.Name = "UI_zForwarderInvoiceDialog2"
    Me.Text = "Penerimaan Invoice"
    Me.Controls.SetChildIndex(Me.hideContainerRight, 0)
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xxHapus, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.hideContainerRight.ResumeLayout(False)
    Me.DockPanel1.ResumeLayout(False)
    Me.DockPanel1_Container.ResumeLayout(False)
    CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.NavBarControl1.ResumeLayout(False)
    Me.NavBarGroupControlContainer3.ResumeLayout(False)
    Me.NavBarGroupControlContainer3.PerformLayout()
    Me.NavBarGroupControlContainer1.ResumeLayout(False)
    CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.NavBarGroupControlContainer2.ResumeLayout(False)
    CType(Me.xGHistory, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGHistoryView, System.ComponentModel.ISupportInitialize).EndInit()
    Me.DockPanel2.ResumeLayout(False)
    Me.DockPanel2_Container.ResumeLayout(False)
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.txtDRYTriplek.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDRYCargoNET.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtICEMonitoring40.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtICEMonitoring20.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtICERecooling40.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtICERecooling20.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtICEVHC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtICEFee40.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDRYPlastik40.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDRYPlastik20.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDRYSanitari40.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDRYSantitari20.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDryTruckingLCL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDRYTrucking20.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtICEtbs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDRYTrucking40.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtICEFee20.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDryCTNS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTipe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPPH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPPN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoPPN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtShipment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colStuffingRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colDestinationRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layKontak, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layKontakNama, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem21, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytDRY, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytICE, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.Document1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
  Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
  Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
  Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
  Friend WithEvents navInfo As DevExpress.XtraNavBar.NavBarGroup
  Friend WithEvents navHistory As DevExpress.XtraNavBar.NavBarGroup
  Friend WithEvents navCatatan As DevExpress.XtraNavBar.NavBarGroup
  Friend WithEvents NavBarGroupControlContainer3 As DevExpress.XtraNavBar.NavBarGroupControlContainer
  Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
  Friend WithEvents NavBarGroupControlContainer2 As DevExpress.XtraNavBar.NavBarGroupControlContainer
  Friend WithEvents xGHistory As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGHistoryView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
  Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
  Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
  Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents txtUraian As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents layKontak As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents layKontakNama As DevExpress.XtraLayout.SimpleLabelItem
  Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents btnRefreshNomor As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents lytRegional As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colKodeBarangRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents xxHapus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents txtKontakPerson As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtPhoneNumber As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtDebitLimit As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtCreditLimit As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtSaldoAP As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtSaldoAR As DevExpress.XtraEditors.LabelControl
  Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents DocumentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
  Friend WithEvents Document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
  Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
  Friend WithEvents EmptySpaceItem10 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtShipment As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem11 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtNoPPN As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem21 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtPPN As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtSubTotal As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtAlamat As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents txtCatatan As DevExpress.XtraEditors.MemoExEdit
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colDestinationRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents txtPPH As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtDiscount As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
  Friend WithEvents colInvoice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colDestination As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colTotal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colCTNS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colPartay20 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colPartay40 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colPartayLCL As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colIceShipmentFee20 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colIceShipmentFee40 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colIceShipmentFeeTBS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colIceCustomInspection As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colIceCOO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colIceVHCItem As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colIceVHCValue As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colIceSealFee As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colIceRecooling20 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colIceRecooling40 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colIceMonitoring20 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colIceMonitoring40 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colIceNotulPeb As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colDryCTNSValue As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colDryTrucking20 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colDryTrucking40 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colDryTruckingLCL As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colDryCOO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colDryPhytosanitary20 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colDryPhytosanitary40 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colDryJaring20 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colDryJaring40 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colDryCargo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colDryTriplek As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colDryMeratus As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colDryDocFee As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colDrySealFee As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colDryServiceCharge As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colDryLOLO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colDryNotulPeb As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colBiayaLainLain As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents txtTipe As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtICEtbs As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtDRYTrucking40 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtICEFee20 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtDryCTNS As DevExpress.XtraEditors.TextEdit
  Friend WithEvents lytDRY As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytICE As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtDryTruckingLCL As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtDRYTrucking20 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtICEMonitoring40 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtICEMonitoring20 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtICERecooling40 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtICERecooling20 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtICEVHC As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtICEFee40 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtDRYPlastik40 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtDRYPlastik20 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtDRYSanitari40 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtDRYSantitari20 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtDRYTriplek As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtDRYCargoNET As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents gbInvoice As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents colStuffing As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colStuffingRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
  Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gbDestination As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbTotal As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbCTNS As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbTrucking As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbCOODRY As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbPhytosanitary As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbPlastik As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbCargo As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbTriplek As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbDryLain As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbShipment As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbShipment2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbCustom As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbCOOICE As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbVHC As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbSeal As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbRecooling As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbMonitoring As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbNotul As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gbBiayaLain As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
