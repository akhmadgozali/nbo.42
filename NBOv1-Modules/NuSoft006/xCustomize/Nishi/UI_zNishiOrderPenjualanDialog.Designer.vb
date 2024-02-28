<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_zNishiOrderPenjualanDialog
  Inherits Core.Win.Forms.InputMDI

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_zNishiOrderPenjualanDialog))
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
    Me.lytTransaksi = New DevExpress.XtraLayout.LayoutControl()
    Me.eTxtDateOfRecord = New DevExpress.XtraEditors.TextEdit()
    Me.gridInvoice = New DevExpress.XtraGrid.GridControl()
    Me.gridInvoiceView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.eTxtBillLading = New DevExpress.XtraEditors.TextEdit()
    Me.eTxtVessel = New DevExpress.XtraEditors.TextEdit()
    Me.eTxtShipper = New DevExpress.XtraEditors.TextEdit()
    Me.eTxtConsignee = New DevExpress.XtraEditors.TextEdit()
    Me.eTxtNW = New DevExpress.XtraEditors.TextEdit()
    Me.eTxtMeass = New DevExpress.XtraEditors.TextEdit()
    Me.eTxtShipping = New DevExpress.XtraEditors.TextEdit()
    Me.eTxtInvoiceNo = New DevExpress.XtraEditors.TextEdit()
    Me.eTxtPackingNo = New DevExpress.XtraEditors.TextEdit()
    Me.eTxtParty = New DevExpress.XtraEditors.TextEdit()
    Me.eTxtGW = New DevExpress.XtraEditors.TextEdit()
    Me.eTxtOther = New DevExpress.XtraEditors.MemoEdit()
    Me.txteAmountInvoice = New DevExpress.XtraEditors.TextEdit()
    Me.txtJenisBarang = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtQty = New DevExpress.XtraEditors.TextEdit()
    Me.txtSatuan = New DevExpress.XtraEditors.TextEdit()
    Me.itxtBLNo = New DevExpress.XtraEditors.TextEdit()
    Me.itxtShipper = New DevExpress.XtraEditors.TextEdit()
    Me.itxtConsignee = New DevExpress.XtraEditors.TextEdit()
    Me.itxtAJOU = New DevExpress.XtraEditors.TextEdit()
    Me.itxtInvoiceNo = New DevExpress.XtraEditors.TextEdit()
    Me.itxtPListNo = New DevExpress.XtraEditors.TextEdit()
    Me.itxtNW = New DevExpress.XtraEditors.TextEdit()
    Me.itxtMeass = New DevExpress.XtraEditors.TextEdit()
    Me.itxtParty = New DevExpress.XtraEditors.TextEdit()
    Me.itxtGW = New DevExpress.XtraEditors.TextEdit()
    Me.itxtVessel = New DevExpress.XtraEditors.TextEdit()
    Me.itxtOther = New DevExpress.XtraEditors.MemoEdit()
    Me.itxt20 = New DevExpress.XtraEditors.TextEdit()
    Me.itxt40 = New DevExpress.XtraEditors.TextEdit()
    Me.itxtPOLPOD = New DevExpress.XtraEditors.TextEdit()
    Me.itxtMBL = New DevExpress.XtraEditors.TextEdit()
    Me.itxtPabean = New DevExpress.XtraEditors.TextEdit()
    Me.itxtBilling = New DevExpress.XtraEditors.DateEdit()
    Me.etxtNoAju = New DevExpress.XtraEditors.TextEdit()
    Me.eTxtNPE = New DevExpress.XtraEditors.TextEdit()
    Me.eTxtPEBNo = New DevExpress.XtraEditors.TextEdit()
    Me.eTxtTujuan = New DevExpress.XtraEditors.TextEdit()
    Me.eTxtPOLPOD = New DevExpress.XtraEditors.TextEdit()
    Me.eTxtMBL = New DevExpress.XtraEditors.TextEdit()
    Me.eTxtPabean = New DevExpress.XtraEditors.TextEdit()
    Me.lblKontakNama = New DevExpress.XtraEditors.LabelControl()
    Me.txtNoRef = New DevExpress.XtraEditors.TextEdit()
    Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTipeJO = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtKontakPerson = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKodeBarangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
    Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSatuanRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDivisiRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colProyekRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colHargaRepo = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
    Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
    Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.eTxtETD = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtInvoiceTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtPackingTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtETA = New DevExpress.XtraEditors.DateEdit()
    Me.itxtBPN = New DevExpress.XtraEditors.DateEdit()
    Me.itxtDO = New DevExpress.XtraEditors.DateEdit()
    Me.itxtDraftPIB = New DevExpress.XtraEditors.DateEdit()
    Me.itxtBL = New DevExpress.XtraEditors.DateEdit()
    Me.itxtOriginal = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtCOO = New DevExpress.XtraEditors.DateEdit()
    Me.itxtETA = New DevExpress.XtraEditors.DateEdit()
    Me.itxtPListTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.itxtInvoiceTgl = New DevExpress.XtraEditors.DateEdit()
    Me.itxtEmail = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtInsurance = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtPickup = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtTglSI = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtTglRecTrucking = New DevExpress.XtraEditors.DateEdit()
    Me.itxtBC = New DevExpress.XtraEditors.DateEdit()
    Me.itxtSK = New DevExpress.XtraEditors.DateEdit()
    Me.itxtDocTagihan = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtTglSuratTugas = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtCOOKomunikasi = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtCOODraft = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtAsuransiReq = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtBLSurender = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtAsuransiTerima = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtCOOPersetujuan = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtAju = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtTerimaOriginal = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtPEBReq = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtPEBTerima = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtBLReq = New DevExpress.XtraEditors.DateEdit()
    Me.eTxtBLTerima = New DevExpress.XtraEditors.DateEdit()
    Me.itxtSPPB = New DevExpress.XtraEditors.DateEdit()
    Me.itxtDOBayar = New DevExpress.XtraEditors.DateEdit()
    Me.itxtDOAmbil = New DevExpress.XtraEditors.DateEdit()
    Me.itxtDelivery = New DevExpress.XtraEditors.DateEdit()
    Me.itxtTagihan = New DevExpress.XtraEditors.DateEdit()
    Me.itxtCOO = New DevExpress.XtraEditors.DateEdit()
    Me.itxtTglAju = New DevExpress.XtraEditors.DateEdit()
    Me.itxtDOTerbit = New DevExpress.XtraEditors.TextEdit()
    Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem58 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
    Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
    Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
    Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
    Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
    Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
    Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
    Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem22 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.layKontak = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytRegional = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.lytItem = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.lytImpor = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.lytImporStatus = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.lytEkspor = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.lytEksporStatus = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem23 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem93 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem94 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem57 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem12 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem13 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem95 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem59 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem17 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem81 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem60 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem14 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem18 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem82 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem83 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem84 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem85 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem86 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem87 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem88 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem89 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem90 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem91 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem21 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem92 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem46 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem10 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem11 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem47 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem53 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem54 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem55 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem56 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem52 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem24 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem25 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem49 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem51 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem15 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem50 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem48 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem16 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem61 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem62 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem63 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem64 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem65 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem19 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem67 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem68 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem69 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem70 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem71 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem72 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem73 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem74 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem20 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem75 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem76 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem77 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem78 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem79 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem80 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem66 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
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
    CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytTransaksi.SuspendLayout()
    CType(Me.eTxtDateOfRecord.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gridInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gridInvoiceView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtBillLading.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtVessel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtShipper.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtConsignee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtNW.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtMeass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtShipping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtInvoiceNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtPackingNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtParty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtGW.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtOther.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txteAmountInvoice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtJenisBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSatuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtBLNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtShipper.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtConsignee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtAJOU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtInvoiceNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtPListNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtNW.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtMeass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtParty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtGW.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtVessel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtOther.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxt20.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxt40.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtPOLPOD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtMBL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtPabean.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtBilling.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtBilling.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.etxtNoAju.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtNPE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtPEBNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtTujuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtPOLPOD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtMBL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtPabean.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTipeJO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colDivisiRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colProyekRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colHargaRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtETD.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtETD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtInvoiceTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtInvoiceTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtPackingTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtPackingTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtETA.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtETA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtBPN.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtBPN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtDO.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtDO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtDraftPIB.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtDraftPIB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtBL.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtBL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtOriginal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtOriginal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtCOO.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtCOO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtETA.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtETA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtPListTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtPListTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtInvoiceTgl.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtInvoiceTgl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtEmail.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtInsurance.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtInsurance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtPickup.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtPickup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtTglSI.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtTglSI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtTglRecTrucking.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtTglRecTrucking.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtBC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtBC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtSK.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtSK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtDocTagihan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtDocTagihan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtTglSuratTugas.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtTglSuratTugas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtCOOKomunikasi.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtCOOKomunikasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtCOODraft.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtCOODraft.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtAsuransiReq.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtAsuransiReq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtBLSurender.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtBLSurender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtAsuransiTerima.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtAsuransiTerima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtCOOPersetujuan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtCOOPersetujuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtAju.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtAju.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtTerimaOriginal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtTerimaOriginal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtPEBReq.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtPEBReq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtPEBTerima.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtPEBTerima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtBLReq.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtBLReq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtBLTerima.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.eTxtBLTerima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtSPPB.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtSPPB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtDOBayar.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtDOBayar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtDOAmbil.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtDOAmbil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtDelivery.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtDelivery.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtTagihan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtTagihan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtCOO.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtCOO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtTglAju.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtTglAju.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.itxtDOTerbit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem58, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem22, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layKontak, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytItem, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytImpor, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytImporStatus, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytEkspor, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytEksporStatus, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem23, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem93, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem94, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem57, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem12, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem13, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem95, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem59, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem17, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem81, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem60, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem14, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem18, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem82, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem83, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem84, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem85, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem86, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem87, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem88, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem89, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem90, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem91, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem21, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem92, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem53, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem55, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem24, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem25, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem15, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem16, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem61, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem62, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem63, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem64, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem65, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem19, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem67, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem68, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem69, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem70, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem71, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem72, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem73, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem74, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem20, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem75, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem76, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem77, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem78, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem79, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem80, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem66, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarStaticItem2, Me.BarButtonItem1, Me.btnRefresh, Me.BarButtonItem2})
    Me.barMan.MaxItemId = 11
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnRefresh, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2)})
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
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
    Me.hideContainerRight.Location = New System.Drawing.Point(1115, 0)
    Me.hideContainerRight.Name = "hideContainerRight"
    Me.hideContainerRight.Size = New System.Drawing.Size(19, 441)
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
    Me.DockPanel1.Size = New System.Drawing.Size(250, 441)
    Me.DockPanel1.Text = "Panel Informasi"
    Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
    '
    'DockPanel1_Container
    '
    Me.DockPanel1_Container.Controls.Add(Me.NavBarControl1)
    Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
    Me.DockPanel1_Container.Name = "DockPanel1_Container"
    Me.DockPanel1_Container.Size = New System.Drawing.Size(242, 414)
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
    Me.NavBarControl1.Size = New System.Drawing.Size(242, 414)
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
    Me.NavBarGroupControlContainer3.Size = New System.Drawing.Size(234, 106)
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
    Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(234, 96)
    Me.NavBarGroupControlContainer1.TabIndex = 0
    '
    'MemoEdit1
    '
    Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MemoEdit1.Location = New System.Drawing.Point(0, 0)
    Me.MemoEdit1.MenuManager = Me.barMan
    Me.MemoEdit1.Name = "MemoEdit1"
    Me.MemoEdit1.Size = New System.Drawing.Size(234, 96)
    Me.MemoEdit1.TabIndex = 0
    '
    'NavBarGroupControlContainer2
    '
    Me.NavBarGroupControlContainer2.Controls.Add(Me.xGHistory)
    Me.NavBarGroupControlContainer2.Name = "NavBarGroupControlContainer2"
    Me.NavBarGroupControlContainer2.Size = New System.Drawing.Size(234, 196)
    Me.NavBarGroupControlContainer2.TabIndex = 1
    '
    'xGHistory
    '
    Me.xGHistory.Dock = System.Windows.Forms.DockStyle.Fill
    Me.xGHistory.Location = New System.Drawing.Point(0, 0)
    Me.xGHistory.MainView = Me.xGHistoryView
    Me.xGHistory.MenuManager = Me.barMan
    Me.xGHistory.Name = "xGHistory"
    Me.xGHistory.Size = New System.Drawing.Size(234, 196)
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
    Me.DockPanel2.OriginalSize = New System.Drawing.Size(1128, 435)
    Me.DockPanel2.Text = "DockPanel2"
    '
    'DockPanel2_Container
    '
    Me.DockPanel2_Container.Controls.Add(Me.lytTransaksi)
    Me.DockPanel2_Container.Location = New System.Drawing.Point(0, 0)
    Me.DockPanel2_Container.Name = "DockPanel2_Container"
    Me.DockPanel2_Container.Size = New System.Drawing.Size(1128, 435)
    Me.DockPanel2_Container.TabIndex = 0
    '
    'lytTransaksi
    '
    Me.lytTransaksi.Controls.Add(Me.eTxtDateOfRecord)
    Me.lytTransaksi.Controls.Add(Me.gridInvoice)
    Me.lytTransaksi.Controls.Add(Me.txtJenisBarang)
    Me.lytTransaksi.Controls.Add(Me.txtQty)
    Me.lytTransaksi.Controls.Add(Me.txtSatuan)
    Me.lytTransaksi.Controls.Add(Me.eTxtBillLading)
    Me.lytTransaksi.Controls.Add(Me.eTxtVessel)
    Me.lytTransaksi.Controls.Add(Me.eTxtShipper)
    Me.lytTransaksi.Controls.Add(Me.eTxtConsignee)
    Me.lytTransaksi.Controls.Add(Me.eTxtNW)
    Me.lytTransaksi.Controls.Add(Me.eTxtMeass)
    Me.lytTransaksi.Controls.Add(Me.eTxtShipping)
    Me.lytTransaksi.Controls.Add(Me.eTxtInvoiceNo)
    Me.lytTransaksi.Controls.Add(Me.eTxtPackingNo)
    Me.lytTransaksi.Controls.Add(Me.eTxtParty)
    Me.lytTransaksi.Controls.Add(Me.eTxtGW)
    Me.lytTransaksi.Controls.Add(Me.eTxtOther)
    Me.lytTransaksi.Controls.Add(Me.txteAmountInvoice)
    Me.lytTransaksi.Controls.Add(Me.itxtBLNo)
    Me.lytTransaksi.Controls.Add(Me.itxtShipper)
    Me.lytTransaksi.Controls.Add(Me.itxtConsignee)
    Me.lytTransaksi.Controls.Add(Me.itxtAJOU)
    Me.lytTransaksi.Controls.Add(Me.itxtInvoiceNo)
    Me.lytTransaksi.Controls.Add(Me.itxtPListNo)
    Me.lytTransaksi.Controls.Add(Me.itxtNW)
    Me.lytTransaksi.Controls.Add(Me.itxtMeass)
    Me.lytTransaksi.Controls.Add(Me.itxtParty)
    Me.lytTransaksi.Controls.Add(Me.itxtGW)
    Me.lytTransaksi.Controls.Add(Me.itxtVessel)
    Me.lytTransaksi.Controls.Add(Me.itxtOther)
    Me.lytTransaksi.Controls.Add(Me.itxt20)
    Me.lytTransaksi.Controls.Add(Me.itxt40)
    Me.lytTransaksi.Controls.Add(Me.itxtPOLPOD)
    Me.lytTransaksi.Controls.Add(Me.itxtMBL)
    Me.lytTransaksi.Controls.Add(Me.itxtPabean)
    Me.lytTransaksi.Controls.Add(Me.itxtBilling)
    Me.lytTransaksi.Controls.Add(Me.etxtNoAju)
    Me.lytTransaksi.Controls.Add(Me.eTxtNPE)
    Me.lytTransaksi.Controls.Add(Me.eTxtPEBNo)
    Me.lytTransaksi.Controls.Add(Me.eTxtTujuan)
    Me.lytTransaksi.Controls.Add(Me.eTxtPOLPOD)
    Me.lytTransaksi.Controls.Add(Me.eTxtMBL)
    Me.lytTransaksi.Controls.Add(Me.eTxtPabean)
    Me.lytTransaksi.Controls.Add(Me.lblKontakNama)
    Me.lytTransaksi.Controls.Add(Me.txtNoRef)
    Me.lytTransaksi.Controls.Add(Me.txtStatus)
    Me.lytTransaksi.Controls.Add(Me.txtTipeJO)
    Me.lytTransaksi.Controls.Add(Me.txtKontakPerson)
    Me.lytTransaksi.Controls.Add(Me.txtRegional)
    Me.lytTransaksi.Controls.Add(Me.txtTanggal)
    Me.lytTransaksi.Controls.Add(Me.btnRefreshNomor)
    Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
    Me.lytTransaksi.Controls.Add(Me.xGrid)
    Me.lytTransaksi.Controls.Add(Me.txtUraian)
    Me.lytTransaksi.Controls.Add(Me.txtKontak)
    Me.lytTransaksi.Controls.Add(Me.eTxtETD)
    Me.lytTransaksi.Controls.Add(Me.eTxtInvoiceTanggal)
    Me.lytTransaksi.Controls.Add(Me.eTxtPackingTanggal)
    Me.lytTransaksi.Controls.Add(Me.eTxtETA)
    Me.lytTransaksi.Controls.Add(Me.itxtBPN)
    Me.lytTransaksi.Controls.Add(Me.itxtDO)
    Me.lytTransaksi.Controls.Add(Me.itxtDraftPIB)
    Me.lytTransaksi.Controls.Add(Me.itxtBL)
    Me.lytTransaksi.Controls.Add(Me.itxtOriginal)
    Me.lytTransaksi.Controls.Add(Me.eTxtCOO)
    Me.lytTransaksi.Controls.Add(Me.itxtETA)
    Me.lytTransaksi.Controls.Add(Me.itxtPListTanggal)
    Me.lytTransaksi.Controls.Add(Me.itxtInvoiceTgl)
    Me.lytTransaksi.Controls.Add(Me.itxtEmail)
    Me.lytTransaksi.Controls.Add(Me.eTxtInsurance)
    Me.lytTransaksi.Controls.Add(Me.eTxtPickup)
    Me.lytTransaksi.Controls.Add(Me.eTxtTglSI)
    Me.lytTransaksi.Controls.Add(Me.eTxtTglRecTrucking)
    Me.lytTransaksi.Controls.Add(Me.itxtBC)
    Me.lytTransaksi.Controls.Add(Me.itxtSK)
    Me.lytTransaksi.Controls.Add(Me.itxtDocTagihan)
    Me.lytTransaksi.Controls.Add(Me.eTxtTglSuratTugas)
    Me.lytTransaksi.Controls.Add(Me.eTxtCOOKomunikasi)
    Me.lytTransaksi.Controls.Add(Me.eTxtCOODraft)
    Me.lytTransaksi.Controls.Add(Me.eTxtAsuransiReq)
    Me.lytTransaksi.Controls.Add(Me.eTxtBLSurender)
    Me.lytTransaksi.Controls.Add(Me.eTxtAsuransiTerima)
    Me.lytTransaksi.Controls.Add(Me.eTxtCOOPersetujuan)
    Me.lytTransaksi.Controls.Add(Me.eTxtAju)
    Me.lytTransaksi.Controls.Add(Me.eTxtTerimaOriginal)
    Me.lytTransaksi.Controls.Add(Me.eTxtPEBReq)
    Me.lytTransaksi.Controls.Add(Me.eTxtPEBTerima)
    Me.lytTransaksi.Controls.Add(Me.eTxtBLReq)
    Me.lytTransaksi.Controls.Add(Me.eTxtBLTerima)
    Me.lytTransaksi.Controls.Add(Me.itxtSPPB)
    Me.lytTransaksi.Controls.Add(Me.itxtDOBayar)
    Me.lytTransaksi.Controls.Add(Me.itxtDOAmbil)
    Me.lytTransaksi.Controls.Add(Me.itxtDelivery)
    Me.lytTransaksi.Controls.Add(Me.itxtTagihan)
    Me.lytTransaksi.Controls.Add(Me.itxtCOO)
    Me.lytTransaksi.Controls.Add(Me.itxtTglAju)
    Me.lytTransaksi.Controls.Add(Me.itxtDOTerbit)
    Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytTransaksi.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem35, Me.LayoutControlGroup4, Me.LayoutControlItem10, Me.LayoutControlItem58})
    Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
    Me.lytTransaksi.Name = "lytTransaksi"
    Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(125, 0, 447, 350)
    Me.lytTransaksi.Root = Me.LayoutControlGroup1
    Me.lytTransaksi.Size = New System.Drawing.Size(1128, 435)
    Me.lytTransaksi.TabIndex = 0
    Me.lytTransaksi.Text = "LayoutControl1"
    '
    'eTxtDateOfRecord
    '
    Me.eTxtDateOfRecord.Location = New System.Drawing.Point(138, 164)
    Me.eTxtDateOfRecord.MenuManager = Me.barMan
    Me.eTxtDateOfRecord.Name = "eTxtDateOfRecord"
    Me.eTxtDateOfRecord.Size = New System.Drawing.Size(249, 20)
    Me.eTxtDateOfRecord.StyleController = Me.lytTransaksi
    Me.eTxtDateOfRecord.TabIndex = 11
    '
    'gridInvoice
    '
    Me.gridInvoice.Location = New System.Drawing.Point(24, 300)
    Me.gridInvoice.MainView = Me.gridInvoiceView
    Me.gridInvoice.MenuManager = Me.barMan
    Me.gridInvoice.Name = "gridInvoice"
    Me.gridInvoice.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
    Me.gridInvoice.Size = New System.Drawing.Size(354, 87)
    Me.gridInvoice.TabIndex = 40
    Me.gridInvoice.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridInvoiceView})
    '
    'gridInvoiceView
    '
    Me.gridInvoiceView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
    Me.gridInvoiceView.GridControl = Me.gridInvoice
    Me.gridInvoiceView.Name = "gridInvoiceView"
    Me.gridInvoiceView.OptionsDetail.EnableMasterViewMode = False
    Me.gridInvoiceView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
    Me.gridInvoiceView.OptionsView.ShowGroupPanel = False
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Invoice No"
    Me.GridColumn1.FieldName = "InvoiceNo"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Invoice Date"
    Me.GridColumn2.ColumnEdit = Me.RepositoryItemDateEdit1
    Me.GridColumn2.FieldName = "InvoceDate"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    '
    'RepositoryItemDateEdit1
    '
    Me.RepositoryItemDateEdit1.AutoHeight = False
    Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
    '
    'eTxtBillLading
    '
    Me.eTxtBillLading.Location = New System.Drawing.Point(138, 164)
    Me.eTxtBillLading.MenuManager = Me.barMan
    Me.eTxtBillLading.Name = "eTxtBillLading"
    Me.eTxtBillLading.Size = New System.Drawing.Size(246, 20)
    Me.eTxtBillLading.StyleController = Me.lytTransaksi
    Me.eTxtBillLading.TabIndex = 15
    '
    'eTxtVessel
    '
    Me.eTxtVessel.Location = New System.Drawing.Point(138, 188)
    Me.eTxtVessel.MenuManager = Me.barMan
    Me.eTxtVessel.Name = "eTxtVessel"
    Me.eTxtVessel.Size = New System.Drawing.Size(246, 20)
    Me.eTxtVessel.StyleController = Me.lytTransaksi
    Me.eTxtVessel.TabIndex = 17
    '
    'eTxtShipper
    '
    Me.eTxtShipper.Location = New System.Drawing.Point(138, 237)
    Me.eTxtShipper.MenuManager = Me.barMan
    Me.eTxtShipper.Name = "eTxtShipper"
    Me.eTxtShipper.Size = New System.Drawing.Size(246, 20)
    Me.eTxtShipper.StyleController = Me.lytTransaksi
    Me.eTxtShipper.TabIndex = 23
    '
    'eTxtConsignee
    '
    Me.eTxtConsignee.Location = New System.Drawing.Point(138, 261)
    Me.eTxtConsignee.MenuManager = Me.barMan
    Me.eTxtConsignee.Name = "eTxtConsignee"
    Me.eTxtConsignee.Size = New System.Drawing.Size(246, 20)
    Me.eTxtConsignee.StyleController = Me.lytTransaksi
    Me.eTxtConsignee.TabIndex = 25
    '
    'eTxtNW
    '
    Me.eTxtNW.Location = New System.Drawing.Point(512, 164)
    Me.eTxtNW.MenuManager = Me.barMan
    Me.eTxtNW.Name = "eTxtNW"
    Me.eTxtNW.Size = New System.Drawing.Size(104, 20)
    Me.eTxtNW.StyleController = Me.lytTransaksi
    Me.eTxtNW.TabIndex = 12
    '
    'eTxtMeass
    '
    Me.eTxtMeass.Location = New System.Drawing.Point(512, 188)
    Me.eTxtMeass.MenuManager = Me.barMan
    Me.eTxtMeass.Name = "eTxtMeass"
    Me.eTxtMeass.Size = New System.Drawing.Size(210, 20)
    Me.eTxtMeass.StyleController = Me.lytTransaksi
    Me.eTxtMeass.TabIndex = 16
    '
    'eTxtShipping
    '
    Me.eTxtShipping.Location = New System.Drawing.Point(138, 285)
    Me.eTxtShipping.MenuManager = Me.barMan
    Me.eTxtShipping.Name = "eTxtShipping"
    Me.eTxtShipping.Size = New System.Drawing.Size(246, 20)
    Me.eTxtShipping.StyleController = Me.lytTransaksi
    Me.eTxtShipping.TabIndex = 27
    '
    'eTxtInvoiceNo
    '
    Me.eTxtInvoiceNo.Location = New System.Drawing.Point(138, 309)
    Me.eTxtInvoiceNo.MenuManager = Me.barMan
    Me.eTxtInvoiceNo.Name = "eTxtInvoiceNo"
    Me.eTxtInvoiceNo.Size = New System.Drawing.Size(126, 20)
    Me.eTxtInvoiceNo.StyleController = Me.lytTransaksi
    Me.eTxtInvoiceNo.TabIndex = 29
    '
    'eTxtPackingNo
    '
    Me.eTxtPackingNo.Location = New System.Drawing.Point(138, 333)
    Me.eTxtPackingNo.MenuManager = Me.barMan
    Me.eTxtPackingNo.Name = "eTxtPackingNo"
    Me.eTxtPackingNo.Size = New System.Drawing.Size(126, 20)
    Me.eTxtPackingNo.StyleController = Me.lytTransaksi
    Me.eTxtPackingNo.TabIndex = 31
    '
    'eTxtParty
    '
    Me.eTxtParty.Location = New System.Drawing.Point(512, 212)
    Me.eTxtParty.MenuManager = Me.barMan
    Me.eTxtParty.Name = "eTxtParty"
    Me.eTxtParty.Size = New System.Drawing.Size(210, 20)
    Me.eTxtParty.StyleController = Me.lytTransaksi
    Me.eTxtParty.TabIndex = 18
    '
    'eTxtGW
    '
    Me.eTxtGW.Location = New System.Drawing.Point(620, 164)
    Me.eTxtGW.MenuManager = Me.barMan
    Me.eTxtGW.Name = "eTxtGW"
    Me.eTxtGW.Size = New System.Drawing.Size(102, 20)
    Me.eTxtGW.StyleController = Me.lytTransaksi
    Me.eTxtGW.TabIndex = 13
    '
    'eTxtOther
    '
    Me.eTxtOther.Location = New System.Drawing.Point(853, 164)
    Me.eTxtOther.MenuManager = Me.barMan
    Me.eTxtOther.Name = "eTxtOther"
    Me.eTxtOther.Size = New System.Drawing.Size(241, 145)
    Me.eTxtOther.StyleController = Me.lytTransaksi
    Me.eTxtOther.TabIndex = 14
    '
    'txteAmountInvoice
    '
    Me.txteAmountInvoice.Location = New System.Drawing.Point(512, 310)
    Me.txteAmountInvoice.MenuManager = Me.barMan
    Me.txteAmountInvoice.Name = "txteAmountInvoice"
    Me.txteAmountInvoice.Properties.Appearance.Options.UseTextOptions = True
    Me.txteAmountInvoice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txteAmountInvoice.Properties.EditFormat.FormatString = "n2"
    Me.txteAmountInvoice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txteAmountInvoice.Properties.Mask.EditMask = "n2"
    Me.txteAmountInvoice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txteAmountInvoice.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txteAmountInvoice.Size = New System.Drawing.Size(210, 20)
    Me.txteAmountInvoice.StyleController = Me.lytTransaksi
    Me.txteAmountInvoice.TabIndex = 39
    '
    'txtJenisBarang
    '
    Me.txtJenisBarang.Location = New System.Drawing.Point(138, 164)
    Me.txtJenisBarang.MenuManager = Me.barMan
    Me.txtJenisBarang.Name = "txtJenisBarang"
    Me.txtJenisBarang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtJenisBarang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Jenis")})
    Me.txtJenisBarang.Properties.DisplayMember = "Value"
    Me.txtJenisBarang.Properties.NullText = "<Pilih Jenis>"
    Me.txtJenisBarang.Properties.ValueMember = "Key"
    Me.txtJenisBarang.Size = New System.Drawing.Size(282, 20)
    Me.txtJenisBarang.StyleController = Me.lytTransaksi
    Me.txtJenisBarang.TabIndex = 36
    '
    'txtQty
    '
    Me.txtQty.Location = New System.Drawing.Point(138, 188)
    Me.txtQty.MenuManager = Me.barMan
    Me.txtQty.Name = "txtQty"
    Me.txtQty.Size = New System.Drawing.Size(282, 20)
    Me.txtQty.StyleController = Me.lytTransaksi
    Me.txtQty.TabIndex = 37
    '
    'txtSatuan
    '
    Me.txtSatuan.Location = New System.Drawing.Point(138, 212)
    Me.txtSatuan.MenuManager = Me.barMan
    Me.txtSatuan.Name = "txtSatuan"
    Me.txtSatuan.Size = New System.Drawing.Size(282, 20)
    Me.txtSatuan.StyleController = Me.lytTransaksi
    Me.txtSatuan.TabIndex = 38
    '
    'itxtBLNo
    '
    Me.itxtBLNo.Location = New System.Drawing.Point(138, 164)
    Me.itxtBLNo.MenuManager = Me.barMan
    Me.itxtBLNo.Name = "itxtBLNo"
    Me.itxtBLNo.Size = New System.Drawing.Size(240, 20)
    Me.itxtBLNo.StyleController = Me.lytTransaksi
    Me.itxtBLNo.TabIndex = 11
    '
    'itxtShipper
    '
    Me.itxtShipper.Location = New System.Drawing.Point(138, 212)
    Me.itxtShipper.MenuManager = Me.barMan
    Me.itxtShipper.Name = "itxtShipper"
    Me.itxtShipper.Size = New System.Drawing.Size(240, 20)
    Me.itxtShipper.StyleController = Me.lytTransaksi
    Me.itxtShipper.TabIndex = 17
    '
    'itxtConsignee
    '
    Me.itxtConsignee.Location = New System.Drawing.Point(138, 236)
    Me.itxtConsignee.MenuManager = Me.barMan
    Me.itxtConsignee.Name = "itxtConsignee"
    Me.itxtConsignee.Size = New System.Drawing.Size(240, 20)
    Me.itxtConsignee.StyleController = Me.lytTransaksi
    Me.itxtConsignee.TabIndex = 19
    '
    'itxtAJOU
    '
    Me.itxtAJOU.Location = New System.Drawing.Point(506, 260)
    Me.itxtAJOU.MenuManager = Me.barMan
    Me.itxtAJOU.Name = "itxtAJOU"
    Me.itxtAJOU.Size = New System.Drawing.Size(272, 20)
    Me.itxtAJOU.StyleController = Me.lytTransaksi
    Me.itxtAJOU.TabIndex = 20
    '
    'itxtInvoiceNo
    '
    Me.itxtInvoiceNo.Location = New System.Drawing.Point(138, 308)
    Me.itxtInvoiceNo.MenuManager = Me.barMan
    Me.itxtInvoiceNo.Name = "itxtInvoiceNo"
    Me.itxtInvoiceNo.Size = New System.Drawing.Size(109, 20)
    Me.itxtInvoiceNo.StyleController = Me.lytTransaksi
    Me.itxtInvoiceNo.TabIndex = 21
    '
    'itxtPListNo
    '
    Me.itxtPListNo.Location = New System.Drawing.Point(138, 391)
    Me.itxtPListNo.MenuManager = Me.barMan
    Me.itxtPListNo.Name = "itxtPListNo"
    Me.itxtPListNo.Size = New System.Drawing.Size(126, 20)
    Me.itxtPListNo.StyleController = Me.lytTransaksi
    Me.itxtPListNo.TabIndex = 23
    '
    'itxtNW
    '
    Me.itxtNW.Location = New System.Drawing.Point(506, 188)
    Me.itxtNW.MenuManager = Me.barMan
    Me.itxtNW.Name = "itxtNW"
    Me.itxtNW.Size = New System.Drawing.Size(120, 20)
    Me.itxtNW.StyleController = Me.lytTransaksi
    Me.itxtNW.TabIndex = 12
    '
    'itxtMeass
    '
    Me.itxtMeass.Location = New System.Drawing.Point(506, 212)
    Me.itxtMeass.MenuManager = Me.barMan
    Me.itxtMeass.Name = "itxtMeass"
    Me.itxtMeass.Size = New System.Drawing.Size(272, 20)
    Me.itxtMeass.StyleController = Me.lytTransaksi
    Me.itxtMeass.TabIndex = 16
    '
    'itxtParty
    '
    Me.itxtParty.Location = New System.Drawing.Point(506, 236)
    Me.itxtParty.MenuManager = Me.barMan
    Me.itxtParty.Name = "itxtParty"
    Me.itxtParty.Size = New System.Drawing.Size(272, 20)
    Me.itxtParty.StyleController = Me.lytTransaksi
    Me.itxtParty.TabIndex = 18
    '
    'itxtGW
    '
    Me.itxtGW.Location = New System.Drawing.Point(630, 188)
    Me.itxtGW.MenuManager = Me.barMan
    Me.itxtGW.Name = "itxtGW"
    Me.itxtGW.Size = New System.Drawing.Size(148, 20)
    Me.itxtGW.StyleController = Me.lytTransaksi
    Me.itxtGW.TabIndex = 13
    '
    'itxtVessel
    '
    Me.itxtVessel.Location = New System.Drawing.Point(506, 164)
    Me.itxtVessel.MenuManager = Me.barMan
    Me.itxtVessel.Name = "itxtVessel"
    Me.itxtVessel.Size = New System.Drawing.Size(272, 20)
    Me.itxtVessel.StyleController = Me.lytTransaksi
    Me.itxtVessel.TabIndex = 25
    '
    'itxtOther
    '
    Me.itxtOther.Location = New System.Drawing.Point(909, 164)
    Me.itxtOther.MenuManager = Me.barMan
    Me.itxtOther.Name = "itxtOther"
    Me.itxtOther.Size = New System.Drawing.Size(185, 150)
    Me.itxtOther.StyleController = Me.lytTransaksi
    Me.itxtOther.TabIndex = 14
    '
    'itxt20
    '
    Me.itxt20.Location = New System.Drawing.Point(138, 284)
    Me.itxt20.MenuManager = Me.barMan
    Me.itxt20.Name = "itxt20"
    Me.itxt20.Size = New System.Drawing.Size(243, 20)
    Me.itxt20.StyleController = Me.lytTransaksi
    Me.itxt20.TabIndex = 28
    '
    'itxt40
    '
    Me.itxt40.Location = New System.Drawing.Point(138, 308)
    Me.itxt40.MenuManager = Me.barMan
    Me.itxt40.Name = "itxt40"
    Me.itxt40.Size = New System.Drawing.Size(243, 20)
    Me.itxt40.StyleController = Me.lytTransaksi
    Me.itxt40.TabIndex = 30
    '
    'itxtPOLPOD
    '
    Me.itxtPOLPOD.Location = New System.Drawing.Point(791, 188)
    Me.itxtPOLPOD.MenuManager = Me.barMan
    Me.itxtPOLPOD.Name = "itxtPOLPOD"
    Me.itxtPOLPOD.Size = New System.Drawing.Size(175, 20)
    Me.itxtPOLPOD.StyleController = Me.lytTransaksi
    Me.itxtPOLPOD.TabIndex = 16
    '
    'itxtMBL
    '
    Me.itxtMBL.Location = New System.Drawing.Point(791, 212)
    Me.itxtMBL.MenuManager = Me.barMan
    Me.itxtMBL.Name = "itxtMBL"
    Me.itxtMBL.Size = New System.Drawing.Size(175, 20)
    Me.itxtMBL.StyleController = Me.lytTransaksi
    Me.itxtMBL.TabIndex = 19
    '
    'itxtPabean
    '
    Me.itxtPabean.Location = New System.Drawing.Point(791, 236)
    Me.itxtPabean.MenuManager = Me.barMan
    Me.itxtPabean.Name = "itxtPabean"
    Me.itxtPabean.Size = New System.Drawing.Size(175, 20)
    Me.itxtPabean.StyleController = Me.lytTransaksi
    Me.itxtPabean.TabIndex = 22
    '
    'itxtBilling
    '
    Me.itxtBilling.EditValue = Nothing
    Me.itxtBilling.Location = New System.Drawing.Point(138, 164)
    Me.itxtBilling.MenuManager = Me.barMan
    Me.itxtBilling.Name = "itxtBilling"
    Me.itxtBilling.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtBilling.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtBilling.Properties.NullText = "<Masukkan Tanggal>"
    Me.itxtBilling.Size = New System.Drawing.Size(243, 20)
    Me.itxtBilling.StyleController = Me.lytTransaksi
    Me.itxtBilling.TabIndex = 11
    '
    'etxtNoAju
    '
    Me.etxtNoAju.Location = New System.Drawing.Point(901, 284)
    Me.etxtNoAju.MenuManager = Me.barMan
    Me.etxtNoAju.Name = "etxtNoAju"
    Me.etxtNoAju.Size = New System.Drawing.Size(193, 20)
    Me.etxtNoAju.StyleController = Me.lytTransaksi
    Me.etxtNoAju.TabIndex = 27
    '
    'eTxtNPE
    '
    Me.eTxtNPE.Location = New System.Drawing.Point(138, 164)
    Me.eTxtNPE.MenuManager = Me.barMan
    Me.eTxtNPE.Name = "eTxtNPE"
    Me.eTxtNPE.Size = New System.Drawing.Size(309, 20)
    Me.eTxtNPE.StyleController = Me.lytTransaksi
    Me.eTxtNPE.TabIndex = 11
    '
    'eTxtPEBNo
    '
    Me.eTxtPEBNo.Location = New System.Drawing.Point(138, 188)
    Me.eTxtPEBNo.MenuManager = Me.barMan
    Me.eTxtPEBNo.Name = "eTxtPEBNo"
    Me.eTxtPEBNo.Size = New System.Drawing.Size(309, 20)
    Me.eTxtPEBNo.StyleController = Me.lytTransaksi
    Me.eTxtPEBNo.TabIndex = 14
    '
    'eTxtTujuan
    '
    Me.eTxtTujuan.Location = New System.Drawing.Point(138, 287)
    Me.eTxtTujuan.MenuManager = Me.barMan
    Me.eTxtTujuan.Name = "eTxtTujuan"
    Me.eTxtTujuan.Size = New System.Drawing.Size(309, 20)
    Me.eTxtTujuan.StyleController = Me.lytTransaksi
    Me.eTxtTujuan.TabIndex = 28
    '
    'eTxtPOLPOD
    '
    Me.eTxtPOLPOD.Location = New System.Drawing.Point(901, 188)
    Me.eTxtPOLPOD.MenuManager = Me.barMan
    Me.eTxtPOLPOD.Name = "eTxtPOLPOD"
    Me.eTxtPOLPOD.Size = New System.Drawing.Size(193, 20)
    Me.eTxtPOLPOD.StyleController = Me.lytTransaksi
    Me.eTxtPOLPOD.TabIndex = 16
    '
    'eTxtMBL
    '
    Me.eTxtMBL.Location = New System.Drawing.Point(901, 212)
    Me.eTxtMBL.MenuManager = Me.barMan
    Me.eTxtMBL.Name = "eTxtMBL"
    Me.eTxtMBL.Size = New System.Drawing.Size(193, 20)
    Me.eTxtMBL.StyleController = Me.lytTransaksi
    Me.eTxtMBL.TabIndex = 19
    '
    'eTxtPabean
    '
    Me.eTxtPabean.Location = New System.Drawing.Point(901, 236)
    Me.eTxtPabean.MenuManager = Me.barMan
    Me.eTxtPabean.Name = "eTxtPabean"
    Me.eTxtPabean.Size = New System.Drawing.Size(193, 20)
    Me.eTxtPabean.StyleController = Me.lytTransaksi
    Me.eTxtPabean.TabIndex = 21
    '
    'lblKontakNama
    '
    Me.lblKontakNama.Location = New System.Drawing.Point(311, 37)
    Me.lblKontakNama.Name = "lblKontakNama"
    Me.lblKontakNama.Size = New System.Drawing.Size(212, 20)
    Me.lblKontakNama.StyleController = Me.lytTransaksi
    Me.lblKontakNama.TabIndex = 30
    '
    'txtNoRef
    '
    Me.txtNoRef.Location = New System.Drawing.Point(268, 106)
    Me.txtNoRef.MenuManager = Me.barMan
    Me.txtNoRef.Name = "txtNoRef"
    Me.txtNoRef.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNoRef.Size = New System.Drawing.Size(362, 20)
    Me.txtNoRef.StyleController = Me.lytTransaksi
    Me.txtNoRef.TabIndex = 8
    '
    'txtStatus
    '
    Me.txtStatus.Location = New System.Drawing.Point(919, 61)
    Me.txtStatus.MenuManager = Me.barMan
    Me.txtStatus.Name = "txtStatus"
    Me.txtStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
    Me.txtStatus.Properties.DisplayMember = "Value"
    Me.txtStatus.Properties.NullText = "<Status>"
    Me.txtStatus.Properties.ValueMember = "Key"
    Me.txtStatus.Size = New System.Drawing.Size(151, 20)
    Me.txtStatus.StyleController = Me.lytTransaksi
    Me.txtStatus.TabIndex = 6
    '
    'txtTipeJO
    '
    Me.txtTipeJO.Location = New System.Drawing.Point(74, 106)
    Me.txtTipeJO.MenuManager = Me.barMan
    Me.txtTipeJO.Name = "txtTipeJO"
    Me.txtTipeJO.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTipeJO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTipeJO.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Kode")})
    Me.txtTipeJO.Properties.DisplayMember = "Value"
    Me.txtTipeJO.Properties.NullText = "<Tipe>"
    Me.txtTipeJO.Properties.PopupWidth = 20
    Me.txtTipeJO.Properties.ValueMember = "Key"
    Me.txtTipeJO.Size = New System.Drawing.Size(112, 20)
    Me.txtTipeJO.StyleController = Me.lytTransaksi
    Me.txtTipeJO.TabIndex = 7
    '
    'txtKontakPerson
    '
    Me.txtKontakPerson.Location = New System.Drawing.Point(92, 61)
    Me.txtKontakPerson.MenuManager = Me.barMan
    Me.txtKontakPerson.Name = "txtKontakPerson"
    Me.txtKontakPerson.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKontakPerson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontakPerson.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 30, "Nama")})
    Me.txtKontakPerson.Properties.DisplayMember = "Nama"
    Me.txtKontakPerson.Properties.NullText = "<Pilih Kontak Person>"
    Me.txtKontakPerson.Properties.PopupWidth = 30
    Me.txtKontakPerson.Properties.ValueMember = "Nama"
    Me.txtKontakPerson.Size = New System.Drawing.Size(215, 20)
    Me.txtKontakPerson.StyleController = Me.lytTransaksi
    Me.txtKontakPerson.TabIndex = 4
    '
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(699, 61)
    Me.txtRegional.MenuManager = Me.barMan
    Me.txtRegional.Name = "txtRegional"
    Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 80, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 120, "Nama")})
    Me.txtRegional.Properties.DisplayMember = "Nama"
    Me.txtRegional.Properties.NullText = "<Pilih Regional>"
    Me.txtRegional.Properties.PopupWidth = 200
    Me.txtRegional.Properties.ValueMember = "This"
    Me.txtRegional.Size = New System.Drawing.Size(153, 20)
    Me.txtRegional.StyleController = Me.lytTransaksi
    Me.txtRegional.TabIndex = 5
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(699, 37)
    Me.txtTanggal.MenuManager = Me.barMan
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
    Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTanggal.Size = New System.Drawing.Size(153, 20)
    Me.txtTanggal.StyleController = Me.lytTransaksi
    Me.txtTanggal.TabIndex = 1
    '
    'btnRefreshNomor
    '
    Me.btnRefreshNomor.AutoWidthInLayoutControl = True
    Me.btnRefreshNomor.Image = CType(resources.GetObject("btnRefreshNomor.Image"), System.Drawing.Image)
    Me.btnRefreshNomor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
    Me.btnRefreshNomor.Location = New System.Drawing.Point(1074, 37)
    Me.btnRefreshNomor.Name = "btnRefreshNomor"
    Me.btnRefreshNomor.Size = New System.Drawing.Size(26, 22)
    Me.btnRefreshNomor.StyleController = Me.lytTransaksi
    Me.btnRefreshNomor.TabIndex = 3
    '
    'txtNoTransaksi
    '
    Me.txtNoTransaksi.Location = New System.Drawing.Point(919, 37)
    Me.txtNoTransaksi.MenuManager = Me.barMan
    Me.txtNoTransaksi.Name = "txtNoTransaksi"
    Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNoTransaksi.Size = New System.Drawing.Size(151, 20)
    Me.txtNoTransaksi.StyleController = Me.lytTransaksi
    Me.txtNoTransaksi.TabIndex = 2
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(24, 164)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.MenuManager = Me.barMan
    Me.xGrid.Name = "xGrid"
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colSatuanRepo, Me.colDivisiRepo, Me.colProyekRepo, Me.colHargaRepo, Me.colKodeBarangRepo})
    Me.xGrid.Size = New System.Drawing.Size(1070, 247)
    Me.xGrid.TabIndex = 11
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeBarang, Me.colNamaBarang, Me.colQty, Me.colSatuan, Me.colCatatan})
    Me.xGridView.CustomizationFormBounds = New System.Drawing.Rectangle(750, 426, 210, 172)
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.NewItemRowText = "Tambah Data"
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsLayout.StoreAllOptions = True
    Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
    Me.xGridView.OptionsView.ColumnAutoWidth = False
    Me.xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'colKodeBarang
    '
    Me.colKodeBarang.Caption = "Kode Barang"
    Me.colKodeBarang.ColumnEdit = Me.colKodeBarangRepo
    Me.colKodeBarang.FieldName = "Barang!"
    Me.colKodeBarang.Name = "colKodeBarang"
    Me.colKodeBarang.Visible = True
    Me.colKodeBarang.VisibleIndex = 0
    Me.colKodeBarang.Width = 92
    '
    'colKodeBarangRepo
    '
    Me.colKodeBarangRepo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.colKodeBarangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colKodeBarangRepo.DisplayMember = "Kode"
    Me.colKodeBarangRepo.Name = "colKodeBarangRepo"
    Me.colKodeBarangRepo.NullText = "<Pilih Barang>"
    Me.colKodeBarangRepo.ShowClearButton = False
    Me.colKodeBarangRepo.ShowFooter = False
    Me.colKodeBarangRepo.ValueMember = "This"
    Me.colKodeBarangRepo.View = Me.RepositoryItemSearchLookUpEdit1View
    '
    'RepositoryItemSearchLookUpEdit1View
    '
    Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
    Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
    Me.RepositoryItemSearchLookUpEdit1View.OptionsFind.FindDelay = 500
    Me.RepositoryItemSearchLookUpEdit1View.OptionsFind.SearchInPreview = True
    Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
    Me.RepositoryItemSearchLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Kode"
    Me.GridColumn3.FieldName = "Kode"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 0
    Me.GridColumn3.Width = 355
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Nama"
    Me.GridColumn4.FieldName = "Nama"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 1
    Me.GridColumn4.Width = 723
    '
    'colNamaBarang
    '
    Me.colNamaBarang.Caption = "Nama Barang"
    Me.colNamaBarang.FieldName = "Barang.Nama"
    Me.colNamaBarang.Name = "colNamaBarang"
    Me.colNamaBarang.OptionsColumn.AllowEdit = False
    Me.colNamaBarang.OptionsColumn.ReadOnly = True
    Me.colNamaBarang.Visible = True
    Me.colNamaBarang.VisibleIndex = 1
    Me.colNamaBarang.Width = 152
    '
    'colQty
    '
    Me.colQty.AppearanceCell.Options.UseTextOptions = True
    Me.colQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colQty.AppearanceHeader.Options.UseTextOptions = True
    Me.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colQty.Caption = "Qty"
    Me.colQty.FieldName = "Qty"
    Me.colQty.Name = "colQty"
    Me.colQty.OptionsColumn.AllowSize = False
    Me.colQty.OptionsColumn.FixedWidth = True
    Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colQty.Visible = True
    Me.colQty.VisibleIndex = 2
    Me.colQty.Width = 57
    '
    'colSatuan
    '
    Me.colSatuan.AppearanceCell.Options.UseTextOptions = True
    Me.colSatuan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
    Me.colSatuan.AppearanceHeader.Options.UseTextOptions = True
    Me.colSatuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colSatuan.Caption = "Satuan"
    Me.colSatuan.ColumnEdit = Me.colSatuanRepo
    Me.colSatuan.FieldName = "Satuan!"
    Me.colSatuan.Name = "colSatuan"
    Me.colSatuan.Visible = True
    Me.colSatuan.VisibleIndex = 3
    Me.colSatuan.Width = 85
    '
    'colSatuanRepo
    '
    Me.colSatuanRepo.AutoHeight = False
    Me.colSatuanRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colSatuanRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.colSatuanRepo.DisplayMember = "Kode"
    Me.colSatuanRepo.Name = "colSatuanRepo"
    Me.colSatuanRepo.NullText = "<Pilih Satuan>"
    Me.colSatuanRepo.ValueMember = "This"
    '
    'colCatatan
    '
    Me.colCatatan.AppearanceCell.Options.UseTextOptions = True
    Me.colCatatan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
    Me.colCatatan.AppearanceHeader.Options.UseTextOptions = True
    Me.colCatatan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
    Me.colCatatan.Caption = "Catatan"
    Me.colCatatan.FieldName = "Catatan"
    Me.colCatatan.Name = "colCatatan"
    Me.colCatatan.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
    Me.colCatatan.Visible = True
    Me.colCatatan.VisibleIndex = 4
    Me.colCatatan.Width = 204
    '
    'colDivisiRepo
    '
    Me.colDivisiRepo.AutoHeight = False
    Me.colDivisiRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colDivisiRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.colDivisiRepo.DisplayMember = "Kode"
    Me.colDivisiRepo.Name = "colDivisiRepo"
    Me.colDivisiRepo.NullText = "<Divisi>"
    Me.colDivisiRepo.ValueMember = "This"
    '
    'colProyekRepo
    '
    Me.colProyekRepo.AutoHeight = False
    Me.colProyekRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colProyekRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.colProyekRepo.DisplayMember = "Kode"
    Me.colProyekRepo.Name = "colProyekRepo"
    Me.colProyekRepo.NullText = "<Proyek>"
    Me.colProyekRepo.ValueMember = "This"
    '
    'colHargaRepo
    '
    Me.colHargaRepo.AutoHeight = False
    Me.colHargaRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colHargaRepo.Name = "colHargaRepo"
    '
    'txtUraian
    '
    Me.txtUraian.Location = New System.Drawing.Point(712, 106)
    Me.txtUraian.MenuManager = Me.barMan
    Me.txtUraian.Name = "txtUraian"
    Me.txtUraian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtUraian.Properties.MaxLength = 255
    Me.txtUraian.Size = New System.Drawing.Size(334, 20)
    Me.txtUraian.StyleController = Me.lytTransaksi
    Me.txtUraian.TabIndex = 9
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(92, 37)
    Me.txtKontak.MenuManager = Me.barMan
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtKontak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontak.Properties.DisplayMember = "Kode"
    Me.txtKontak.Properties.NullText = "<Pilih Customer>"
    Me.txtKontak.Properties.PopupFormSize = New System.Drawing.Size(330, 0)
    Me.txtKontak.Properties.ShowClearButton = False
    Me.txtKontak.Properties.ShowFooter = False
    Me.txtKontak.Properties.ValueMember = "This"
    Me.txtKontak.Properties.View = Me.SearchLookUpEdit1View
    Me.txtKontak.Size = New System.Drawing.Size(215, 20)
    Me.txtKontak.StyleController = Me.lytTransaksi
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
    'eTxtETD
    '
    Me.eTxtETD.EditValue = Nothing
    Me.eTxtETD.Location = New System.Drawing.Point(138, 212)
    Me.eTxtETD.MenuManager = Me.barMan
    Me.eTxtETD.Name = "eTxtETD"
    Me.eTxtETD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtETD.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtETD.Properties.Mask.EditMask = ""
    Me.eTxtETD.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtETD.Size = New System.Drawing.Size(115, 20)
    Me.eTxtETD.StyleController = Me.lytTransaksi
    Me.eTxtETD.TabIndex = 19
    '
    'eTxtInvoiceTanggal
    '
    Me.eTxtInvoiceTanggal.EditValue = Nothing
    Me.eTxtInvoiceTanggal.Location = New System.Drawing.Point(268, 309)
    Me.eTxtInvoiceTanggal.MenuManager = Me.barMan
    Me.eTxtInvoiceTanggal.Name = "eTxtInvoiceTanggal"
    Me.eTxtInvoiceTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtInvoiceTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtInvoiceTanggal.Properties.Mask.EditMask = ""
    Me.eTxtInvoiceTanggal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtInvoiceTanggal.Size = New System.Drawing.Size(116, 20)
    Me.eTxtInvoiceTanggal.StyleController = Me.lytTransaksi
    Me.eTxtInvoiceTanggal.TabIndex = 30
    '
    'eTxtPackingTanggal
    '
    Me.eTxtPackingTanggal.EditValue = Nothing
    Me.eTxtPackingTanggal.Location = New System.Drawing.Point(268, 333)
    Me.eTxtPackingTanggal.MenuManager = Me.barMan
    Me.eTxtPackingTanggal.Name = "eTxtPackingTanggal"
    Me.eTxtPackingTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtPackingTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtPackingTanggal.Properties.Mask.EditMask = ""
    Me.eTxtPackingTanggal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtPackingTanggal.Size = New System.Drawing.Size(116, 20)
    Me.eTxtPackingTanggal.StyleController = Me.lytTransaksi
    Me.eTxtPackingTanggal.TabIndex = 31
    '
    'eTxtETA
    '
    Me.eTxtETA.EditValue = Nothing
    Me.eTxtETA.Location = New System.Drawing.Point(257, 212)
    Me.eTxtETA.MenuManager = Me.barMan
    Me.eTxtETA.Name = "eTxtETA"
    Me.eTxtETA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtETA.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtETA.Properties.Mask.EditMask = ""
    Me.eTxtETA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtETA.Size = New System.Drawing.Size(127, 20)
    Me.eTxtETA.StyleController = Me.lytTransaksi
    Me.eTxtETA.TabIndex = 20
    '
    'itxtBPN
    '
    Me.itxtBPN.EditValue = Nothing
    Me.itxtBPN.Location = New System.Drawing.Point(138, 212)
    Me.itxtBPN.MenuManager = Me.barMan
    Me.itxtBPN.Name = "itxtBPN"
    Me.itxtBPN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtBPN.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtBPN.Properties.Mask.EditMask = ""
    Me.itxtBPN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtBPN.Size = New System.Drawing.Size(243, 20)
    Me.itxtBPN.StyleController = Me.lytTransaksi
    Me.itxtBPN.TabIndex = 20
    '
    'itxtDO
    '
    Me.itxtDO.EditValue = Nothing
    Me.itxtDO.Location = New System.Drawing.Point(138, 188)
    Me.itxtDO.MenuManager = Me.barMan
    Me.itxtDO.Name = "itxtDO"
    Me.itxtDO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtDO.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtDO.Properties.Mask.EditMask = ""
    Me.itxtDO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtDO.Size = New System.Drawing.Size(243, 20)
    Me.itxtDO.StyleController = Me.lytTransaksi
    Me.itxtDO.TabIndex = 14
    '
    'itxtDraftPIB
    '
    Me.itxtDraftPIB.EditValue = Nothing
    Me.itxtDraftPIB.Location = New System.Drawing.Point(138, 236)
    Me.itxtDraftPIB.MenuManager = Me.barMan
    Me.itxtDraftPIB.Name = "itxtDraftPIB"
    Me.itxtDraftPIB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtDraftPIB.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtDraftPIB.Properties.Mask.EditMask = ""
    Me.itxtDraftPIB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtDraftPIB.Size = New System.Drawing.Size(243, 20)
    Me.itxtDraftPIB.StyleController = Me.lytTransaksi
    Me.itxtDraftPIB.TabIndex = 23
    '
    'itxtBL
    '
    Me.itxtBL.EditValue = Nothing
    Me.itxtBL.Location = New System.Drawing.Point(138, 260)
    Me.itxtBL.MenuManager = Me.barMan
    Me.itxtBL.Name = "itxtBL"
    Me.itxtBL.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtBL.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtBL.Properties.Mask.EditMask = ""
    Me.itxtBL.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtBL.Size = New System.Drawing.Size(243, 20)
    Me.itxtBL.StyleController = Me.lytTransaksi
    Me.itxtBL.TabIndex = 26
    '
    'itxtOriginal
    '
    Me.itxtOriginal.EditValue = Nothing
    Me.itxtOriginal.Location = New System.Drawing.Point(138, 332)
    Me.itxtOriginal.MenuManager = Me.barMan
    Me.itxtOriginal.Name = "itxtOriginal"
    Me.itxtOriginal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtOriginal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtOriginal.Properties.Mask.EditMask = ""
    Me.itxtOriginal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtOriginal.Size = New System.Drawing.Size(243, 20)
    Me.itxtOriginal.StyleController = Me.lytTransaksi
    Me.itxtOriginal.TabIndex = 32
    '
    'eTxtCOO
    '
    Me.eTxtCOO.EditValue = Nothing
    Me.eTxtCOO.Location = New System.Drawing.Point(138, 212)
    Me.eTxtCOO.MenuManager = Me.barMan
    Me.eTxtCOO.Name = "eTxtCOO"
    Me.eTxtCOO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtCOO.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtCOO.Properties.Mask.EditMask = ""
    Me.eTxtCOO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtCOO.Size = New System.Drawing.Size(309, 20)
    Me.eTxtCOO.StyleController = Me.lytTransaksi
    Me.eTxtCOO.TabIndex = 17
    '
    'itxtETA
    '
    Me.itxtETA.EditValue = Nothing
    Me.itxtETA.Location = New System.Drawing.Point(138, 188)
    Me.itxtETA.MenuManager = Me.barMan
    Me.itxtETA.Name = "itxtETA"
    Me.itxtETA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtETA.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtETA.Properties.Mask.EditMask = ""
    Me.itxtETA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtETA.Size = New System.Drawing.Size(240, 20)
    Me.itxtETA.StyleController = Me.lytTransaksi
    Me.itxtETA.TabIndex = 15
    '
    'itxtPListTanggal
    '
    Me.itxtPListTanggal.EditValue = Nothing
    Me.itxtPListTanggal.Location = New System.Drawing.Point(268, 391)
    Me.itxtPListTanggal.MenuManager = Me.barMan
    Me.itxtPListTanggal.Name = "itxtPListTanggal"
    Me.itxtPListTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtPListTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtPListTanggal.Properties.Mask.EditMask = ""
    Me.itxtPListTanggal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtPListTanggal.Size = New System.Drawing.Size(110, 20)
    Me.itxtPListTanggal.StyleController = Me.lytTransaksi
    Me.itxtPListTanggal.TabIndex = 24
    '
    'itxtInvoiceTgl
    '
    Me.itxtInvoiceTgl.EditValue = Nothing
    Me.itxtInvoiceTgl.Location = New System.Drawing.Point(138, 308)
    Me.itxtInvoiceTgl.MenuManager = Me.barMan
    Me.itxtInvoiceTgl.Name = "itxtInvoiceTgl"
    Me.itxtInvoiceTgl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtInvoiceTgl.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtInvoiceTgl.Properties.Mask.EditMask = ""
    Me.itxtInvoiceTgl.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtInvoiceTgl.Size = New System.Drawing.Size(240, 20)
    Me.itxtInvoiceTgl.StyleController = Me.lytTransaksi
    Me.itxtInvoiceTgl.TabIndex = 22
    '
    'itxtEmail
    '
    Me.itxtEmail.EditValue = Nothing
    Me.itxtEmail.Location = New System.Drawing.Point(138, 260)
    Me.itxtEmail.MenuManager = Me.barMan
    Me.itxtEmail.Name = "itxtEmail"
    Me.itxtEmail.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtEmail.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtEmail.Properties.Mask.EditMask = ""
    Me.itxtEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtEmail.Size = New System.Drawing.Size(240, 20)
    Me.itxtEmail.StyleController = Me.lytTransaksi
    Me.itxtEmail.TabIndex = 20
    '
    'eTxtInsurance
    '
    Me.eTxtInsurance.EditValue = Nothing
    Me.eTxtInsurance.Location = New System.Drawing.Point(138, 237)
    Me.eTxtInsurance.MenuManager = Me.barMan
    Me.eTxtInsurance.Name = "eTxtInsurance"
    Me.eTxtInsurance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtInsurance.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtInsurance.Properties.Mask.EditMask = ""
    Me.eTxtInsurance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtInsurance.Size = New System.Drawing.Size(309, 20)
    Me.eTxtInsurance.StyleController = Me.lytTransaksi
    Me.eTxtInsurance.TabIndex = 22
    '
    'eTxtPickup
    '
    Me.eTxtPickup.EditValue = Nothing
    Me.eTxtPickup.Location = New System.Drawing.Point(138, 262)
    Me.eTxtPickup.MenuManager = Me.barMan
    Me.eTxtPickup.Name = "eTxtPickup"
    Me.eTxtPickup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtPickup.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtPickup.Properties.Mask.EditMask = ""
    Me.eTxtPickup.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtPickup.Size = New System.Drawing.Size(309, 20)
    Me.eTxtPickup.StyleController = Me.lytTransaksi
    Me.eTxtPickup.TabIndex = 25
    '
    'eTxtTglSI
    '
    Me.eTxtTglSI.EditValue = Nothing
    Me.eTxtTglSI.Location = New System.Drawing.Point(138, 311)
    Me.eTxtTglSI.MenuManager = Me.barMan
    Me.eTxtTglSI.Name = "eTxtTglSI"
    Me.eTxtTglSI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtTglSI.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtTglSI.Properties.Mask.EditMask = ""
    Me.eTxtTglSI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtTglSI.Size = New System.Drawing.Size(309, 20)
    Me.eTxtTglSI.StyleController = Me.lytTransaksi
    Me.eTxtTglSI.TabIndex = 31
    '
    'eTxtTglRecTrucking
    '
    Me.eTxtTglRecTrucking.EditValue = Nothing
    Me.eTxtTglRecTrucking.Location = New System.Drawing.Point(138, 335)
    Me.eTxtTglRecTrucking.MenuManager = Me.barMan
    Me.eTxtTglRecTrucking.Name = "eTxtTglRecTrucking"
    Me.eTxtTglRecTrucking.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtTglRecTrucking.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtTglRecTrucking.Properties.Mask.EditMask = ""
    Me.eTxtTglRecTrucking.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtTglRecTrucking.Size = New System.Drawing.Size(309, 20)
    Me.eTxtTglRecTrucking.StyleController = Me.lytTransaksi
    Me.eTxtTglRecTrucking.TabIndex = 33
    '
    'itxtBC
    '
    Me.itxtBC.EditValue = Nothing
    Me.itxtBC.Location = New System.Drawing.Point(509, 164)
    Me.itxtBC.MenuManager = Me.barMan
    Me.itxtBC.Name = "itxtBC"
    Me.itxtBC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtBC.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtBC.Properties.Mask.EditMask = ""
    Me.itxtBC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtBC.Size = New System.Drawing.Size(150, 20)
    Me.itxtBC.StyleController = Me.lytTransaksi
    Me.itxtBC.TabIndex = 12
    '
    'itxtSK
    '
    Me.itxtSK.EditValue = Nothing
    Me.itxtSK.Location = New System.Drawing.Point(509, 188)
    Me.itxtSK.MenuManager = Me.barMan
    Me.itxtSK.Name = "itxtSK"
    Me.itxtSK.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtSK.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtSK.Properties.Mask.EditMask = ""
    Me.itxtSK.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtSK.Size = New System.Drawing.Size(150, 20)
    Me.itxtSK.StyleController = Me.lytTransaksi
    Me.itxtSK.TabIndex = 15
    '
    'itxtDocTagihan
    '
    Me.itxtDocTagihan.EditValue = Nothing
    Me.itxtDocTagihan.Location = New System.Drawing.Point(509, 212)
    Me.itxtDocTagihan.MenuManager = Me.barMan
    Me.itxtDocTagihan.Name = "itxtDocTagihan"
    Me.itxtDocTagihan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtDocTagihan.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtDocTagihan.Properties.Mask.EditMask = ""
    Me.itxtDocTagihan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtDocTagihan.Size = New System.Drawing.Size(150, 20)
    Me.itxtDocTagihan.StyleController = Me.lytTransaksi
    Me.itxtDocTagihan.TabIndex = 18
    '
    'eTxtTglSuratTugas
    '
    Me.eTxtTglSuratTugas.EditValue = Nothing
    Me.eTxtTglSuratTugas.Location = New System.Drawing.Point(138, 359)
    Me.eTxtTglSuratTugas.MenuManager = Me.barMan
    Me.eTxtTglSuratTugas.Name = "eTxtTglSuratTugas"
    Me.eTxtTglSuratTugas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtTglSuratTugas.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtTglSuratTugas.Properties.Mask.EditMask = ""
    Me.eTxtTglSuratTugas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtTglSuratTugas.Size = New System.Drawing.Size(309, 20)
    Me.eTxtTglSuratTugas.StyleController = Me.lytTransaksi
    Me.eTxtTglSuratTugas.TabIndex = 35
    '
    'eTxtCOOKomunikasi
    '
    Me.eTxtCOOKomunikasi.EditValue = Nothing
    Me.eTxtCOOKomunikasi.Location = New System.Drawing.Point(575, 356)
    Me.eTxtCOOKomunikasi.MenuManager = Me.barMan
    Me.eTxtCOOKomunikasi.Name = "eTxtCOOKomunikasi"
    Me.eTxtCOOKomunikasi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtCOOKomunikasi.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtCOOKomunikasi.Properties.Mask.EditMask = ""
    Me.eTxtCOOKomunikasi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtCOOKomunikasi.Size = New System.Drawing.Size(197, 20)
    Me.eTxtCOOKomunikasi.StyleController = Me.lytTransaksi
    Me.eTxtCOOKomunikasi.TabIndex = 34
    '
    'eTxtCOODraft
    '
    Me.eTxtCOODraft.EditValue = Nothing
    Me.eTxtCOODraft.Location = New System.Drawing.Point(575, 332)
    Me.eTxtCOODraft.MenuManager = Me.barMan
    Me.eTxtCOODraft.Name = "eTxtCOODraft"
    Me.eTxtCOODraft.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtCOODraft.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtCOODraft.Properties.Mask.EditMask = ""
    Me.eTxtCOODraft.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtCOODraft.Size = New System.Drawing.Size(197, 20)
    Me.eTxtCOODraft.StyleController = Me.lytTransaksi
    Me.eTxtCOODraft.TabIndex = 32
    '
    'eTxtAsuransiReq
    '
    Me.eTxtAsuransiReq.EditValue = Nothing
    Me.eTxtAsuransiReq.Location = New System.Drawing.Point(575, 284)
    Me.eTxtAsuransiReq.MenuManager = Me.barMan
    Me.eTxtAsuransiReq.Name = "eTxtAsuransiReq"
    Me.eTxtAsuransiReq.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtAsuransiReq.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtAsuransiReq.Properties.Mask.EditMask = ""
    Me.eTxtAsuransiReq.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtAsuransiReq.Size = New System.Drawing.Size(197, 20)
    Me.eTxtAsuransiReq.StyleController = Me.lytTransaksi
    Me.eTxtAsuransiReq.TabIndex = 26
    '
    'eTxtBLSurender
    '
    Me.eTxtBLSurender.EditValue = Nothing
    Me.eTxtBLSurender.Location = New System.Drawing.Point(575, 260)
    Me.eTxtBLSurender.MenuManager = Me.barMan
    Me.eTxtBLSurender.Name = "eTxtBLSurender"
    Me.eTxtBLSurender.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtBLSurender.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtBLSurender.Properties.Mask.EditMask = ""
    Me.eTxtBLSurender.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtBLSurender.Size = New System.Drawing.Size(197, 20)
    Me.eTxtBLSurender.StyleController = Me.lytTransaksi
    Me.eTxtBLSurender.TabIndex = 23
    '
    'eTxtAsuransiTerima
    '
    Me.eTxtAsuransiTerima.EditValue = Nothing
    Me.eTxtAsuransiTerima.Location = New System.Drawing.Point(575, 308)
    Me.eTxtAsuransiTerima.MenuManager = Me.barMan
    Me.eTxtAsuransiTerima.Name = "eTxtAsuransiTerima"
    Me.eTxtAsuransiTerima.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtAsuransiTerima.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtAsuransiTerima.Properties.Mask.EditMask = ""
    Me.eTxtAsuransiTerima.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtAsuransiTerima.Size = New System.Drawing.Size(197, 20)
    Me.eTxtAsuransiTerima.StyleController = Me.lytTransaksi
    Me.eTxtAsuransiTerima.TabIndex = 29
    '
    'eTxtCOOPersetujuan
    '
    Me.eTxtCOOPersetujuan.EditValue = Nothing
    Me.eTxtCOOPersetujuan.Location = New System.Drawing.Point(901, 164)
    Me.eTxtCOOPersetujuan.MenuManager = Me.barMan
    Me.eTxtCOOPersetujuan.Name = "eTxtCOOPersetujuan"
    Me.eTxtCOOPersetujuan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtCOOPersetujuan.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtCOOPersetujuan.Properties.Mask.EditMask = ""
    Me.eTxtCOOPersetujuan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtCOOPersetujuan.Size = New System.Drawing.Size(193, 20)
    Me.eTxtCOOPersetujuan.StyleController = Me.lytTransaksi
    Me.eTxtCOOPersetujuan.TabIndex = 13
    '
    'eTxtAju
    '
    Me.eTxtAju.EditValue = Nothing
    Me.eTxtAju.Location = New System.Drawing.Point(901, 260)
    Me.eTxtAju.MenuManager = Me.barMan
    Me.eTxtAju.Name = "eTxtAju"
    Me.eTxtAju.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtAju.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtAju.Properties.Mask.EditMask = ""
    Me.eTxtAju.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtAju.Size = New System.Drawing.Size(193, 20)
    Me.eTxtAju.StyleController = Me.lytTransaksi
    Me.eTxtAju.TabIndex = 24
    '
    'eTxtTerimaOriginal
    '
    Me.eTxtTerimaOriginal.EditValue = Nothing
    Me.eTxtTerimaOriginal.Location = New System.Drawing.Point(901, 308)
    Me.eTxtTerimaOriginal.MenuManager = Me.barMan
    Me.eTxtTerimaOriginal.Name = "eTxtTerimaOriginal"
    Me.eTxtTerimaOriginal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtTerimaOriginal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtTerimaOriginal.Properties.Mask.EditMask = ""
    Me.eTxtTerimaOriginal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtTerimaOriginal.Size = New System.Drawing.Size(193, 20)
    Me.eTxtTerimaOriginal.StyleController = Me.lytTransaksi
    Me.eTxtTerimaOriginal.TabIndex = 30
    '
    'eTxtPEBReq
    '
    Me.eTxtPEBReq.EditValue = Nothing
    Me.eTxtPEBReq.Location = New System.Drawing.Point(575, 164)
    Me.eTxtPEBReq.MenuManager = Me.barMan
    Me.eTxtPEBReq.Name = "eTxtPEBReq"
    Me.eTxtPEBReq.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtPEBReq.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtPEBReq.Properties.Mask.EditMask = ""
    Me.eTxtPEBReq.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtPEBReq.Size = New System.Drawing.Size(197, 20)
    Me.eTxtPEBReq.StyleController = Me.lytTransaksi
    Me.eTxtPEBReq.TabIndex = 12
    '
    'eTxtPEBTerima
    '
    Me.eTxtPEBTerima.EditValue = Nothing
    Me.eTxtPEBTerima.Location = New System.Drawing.Point(575, 188)
    Me.eTxtPEBTerima.MenuManager = Me.barMan
    Me.eTxtPEBTerima.Name = "eTxtPEBTerima"
    Me.eTxtPEBTerima.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtPEBTerima.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtPEBTerima.Properties.Mask.EditMask = ""
    Me.eTxtPEBTerima.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtPEBTerima.Size = New System.Drawing.Size(197, 20)
    Me.eTxtPEBTerima.StyleController = Me.lytTransaksi
    Me.eTxtPEBTerima.TabIndex = 15
    '
    'eTxtBLReq
    '
    Me.eTxtBLReq.EditValue = Nothing
    Me.eTxtBLReq.Location = New System.Drawing.Point(575, 212)
    Me.eTxtBLReq.MenuManager = Me.barMan
    Me.eTxtBLReq.Name = "eTxtBLReq"
    Me.eTxtBLReq.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtBLReq.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtBLReq.Properties.Mask.EditMask = ""
    Me.eTxtBLReq.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtBLReq.Size = New System.Drawing.Size(197, 20)
    Me.eTxtBLReq.StyleController = Me.lytTransaksi
    Me.eTxtBLReq.TabIndex = 18
    '
    'eTxtBLTerima
    '
    Me.eTxtBLTerima.EditValue = Nothing
    Me.eTxtBLTerima.Location = New System.Drawing.Point(575, 236)
    Me.eTxtBLTerima.MenuManager = Me.barMan
    Me.eTxtBLTerima.Name = "eTxtBLTerima"
    Me.eTxtBLTerima.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtBLTerima.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.eTxtBLTerima.Properties.Mask.EditMask = ""
    Me.eTxtBLTerima.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.eTxtBLTerima.Size = New System.Drawing.Size(197, 20)
    Me.eTxtBLTerima.StyleController = Me.lytTransaksi
    Me.eTxtBLTerima.TabIndex = 20
    '
    'itxtSPPB
    '
    Me.itxtSPPB.EditValue = Nothing
    Me.itxtSPPB.Location = New System.Drawing.Point(509, 236)
    Me.itxtSPPB.MenuManager = Me.barMan
    Me.itxtSPPB.Name = "itxtSPPB"
    Me.itxtSPPB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtSPPB.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtSPPB.Properties.Mask.EditMask = ""
    Me.itxtSPPB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtSPPB.Size = New System.Drawing.Size(150, 20)
    Me.itxtSPPB.StyleController = Me.lytTransaksi
    Me.itxtSPPB.TabIndex = 21
    '
    'itxtDOBayar
    '
    Me.itxtDOBayar.EditValue = Nothing
    Me.itxtDOBayar.Location = New System.Drawing.Point(509, 260)
    Me.itxtDOBayar.MenuManager = Me.barMan
    Me.itxtDOBayar.Name = "itxtDOBayar"
    Me.itxtDOBayar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtDOBayar.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtDOBayar.Properties.Mask.EditMask = ""
    Me.itxtDOBayar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtDOBayar.Size = New System.Drawing.Size(150, 20)
    Me.itxtDOBayar.StyleController = Me.lytTransaksi
    Me.itxtDOBayar.TabIndex = 24
    '
    'itxtDOAmbil
    '
    Me.itxtDOAmbil.EditValue = Nothing
    Me.itxtDOAmbil.Location = New System.Drawing.Point(509, 284)
    Me.itxtDOAmbil.MenuManager = Me.barMan
    Me.itxtDOAmbil.Name = "itxtDOAmbil"
    Me.itxtDOAmbil.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtDOAmbil.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtDOAmbil.Properties.Mask.EditMask = ""
    Me.itxtDOAmbil.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtDOAmbil.Size = New System.Drawing.Size(150, 20)
    Me.itxtDOAmbil.StyleController = Me.lytTransaksi
    Me.itxtDOAmbil.TabIndex = 27
    '
    'itxtDelivery
    '
    Me.itxtDelivery.EditValue = Nothing
    Me.itxtDelivery.Location = New System.Drawing.Point(509, 332)
    Me.itxtDelivery.MenuManager = Me.barMan
    Me.itxtDelivery.Name = "itxtDelivery"
    Me.itxtDelivery.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtDelivery.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtDelivery.Properties.Mask.EditMask = ""
    Me.itxtDelivery.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtDelivery.Size = New System.Drawing.Size(150, 20)
    Me.itxtDelivery.StyleController = Me.lytTransaksi
    Me.itxtDelivery.TabIndex = 31
    '
    'itxtTagihan
    '
    Me.itxtTagihan.EditValue = Nothing
    Me.itxtTagihan.Location = New System.Drawing.Point(509, 356)
    Me.itxtTagihan.MenuManager = Me.barMan
    Me.itxtTagihan.Name = "itxtTagihan"
    Me.itxtTagihan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtTagihan.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtTagihan.Properties.Mask.EditMask = ""
    Me.itxtTagihan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtTagihan.Size = New System.Drawing.Size(150, 20)
    Me.itxtTagihan.StyleController = Me.lytTransaksi
    Me.itxtTagihan.TabIndex = 33
    '
    'itxtCOO
    '
    Me.itxtCOO.EditValue = Nothing
    Me.itxtCOO.Location = New System.Drawing.Point(791, 164)
    Me.itxtCOO.MenuManager = Me.barMan
    Me.itxtCOO.Name = "itxtCOO"
    Me.itxtCOO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtCOO.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtCOO.Properties.Mask.EditMask = ""
    Me.itxtCOO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtCOO.Size = New System.Drawing.Size(175, 20)
    Me.itxtCOO.StyleController = Me.lytTransaksi
    Me.itxtCOO.TabIndex = 13
    '
    'itxtTglAju
    '
    Me.itxtTglAju.EditValue = Nothing
    Me.itxtTglAju.Location = New System.Drawing.Point(791, 260)
    Me.itxtTglAju.MenuManager = Me.barMan
    Me.itxtTglAju.Name = "itxtTglAju"
    Me.itxtTglAju.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtTglAju.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.itxtTglAju.Properties.Mask.EditMask = ""
    Me.itxtTglAju.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.itxtTglAju.Size = New System.Drawing.Size(175, 20)
    Me.itxtTglAju.StyleController = Me.lytTransaksi
    Me.itxtTglAju.TabIndex = 25
    '
    'itxtDOTerbit
    '
    Me.itxtDOTerbit.Location = New System.Drawing.Point(509, 308)
    Me.itxtDOTerbit.MenuManager = Me.barMan
    Me.itxtDOTerbit.Name = "itxtDOTerbit"
    Me.itxtDOTerbit.Size = New System.Drawing.Size(150, 20)
    Me.itxtDOTerbit.StyleController = Me.lytTransaksi
    Me.itxtDOTerbit.TabIndex = 29
    '
    'LayoutControlItem35
    '
    Me.LayoutControlItem35.Control = Me.eTxtDateOfRecord
    Me.LayoutControlItem35.CustomizationFormText = "Date of record"
    Me.LayoutControlItem35.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem35.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem35.MinSize = New System.Drawing.Size(159, 24)
    Me.LayoutControlItem35.Name = "LayoutControlItem35"
    Me.LayoutControlItem35.Size = New System.Drawing.Size(367, 24)
    Me.LayoutControlItem35.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem35.Text = "Date of record"
    Me.LayoutControlItem35.TextSize = New System.Drawing.Size(111, 13)
    Me.LayoutControlItem35.TextToControlDistance = 5
    '
    'LayoutControlGroup4
    '
    Me.LayoutControlGroup4.CustomizationFormText = "Item Barang"
    Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7})
    Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
    Me.LayoutControlGroup4.Size = New System.Drawing.Size(1074, 251)
    Me.LayoutControlGroup4.Text = "Item Barang"
    '
    'LayoutControlItem10
    '
    Me.LayoutControlItem10.Control = Me.itxtInvoiceNo
    Me.LayoutControlItem10.CustomizationFormText = "No && Date Inv"
    Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 144)
    Me.LayoutControlItem10.Name = "LayoutControlItem10"
    Me.LayoutControlItem10.Size = New System.Drawing.Size(227, 24)
    Me.LayoutControlItem10.Text = "No && Date Inv"
    Me.LayoutControlItem10.TextSize = New System.Drawing.Size(111, 13)
    Me.LayoutControlItem10.TextToControlDistance = 5
    '
    'LayoutControlItem58
    '
    Me.LayoutControlItem58.Control = Me.itxtInvoiceTgl
    Me.LayoutControlItem58.CustomizationFormText = "LayoutControlItem58"
    Me.LayoutControlItem58.Location = New System.Drawing.Point(0, 144)
    Me.LayoutControlItem58.Name = "LayoutControlItem58"
    Me.LayoutControlItem58.Size = New System.Drawing.Size(358, 24)
    Me.LayoutControlItem58.Text = "LayoutControlItem58"
    Me.LayoutControlItem58.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem58.TextToControlDistance = 0
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlItem12, Me.EmptySpaceItem3, Me.TabbedControlGroup1, Me.LayoutControlItem21, Me.LayoutControlItem3, Me.EmptySpaceItem22})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(1128, 435)
    Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
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
    Me.Document1.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
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
    'BarButtonItem1
    '
    Me.BarButtonItem1.Caption = "Refresh Master"
    Me.BarButtonItem1.Id = 8
    Me.BarButtonItem1.Name = "BarButtonItem1"
    '
    'btnRefresh
    '
    Me.btnRefresh.Caption = "Refresh"
    Me.btnRefresh.Glyph = CType(resources.GetObject("btnRefresh.Glyph"), System.Drawing.Image)
    Me.btnRefresh.Id = 9
    Me.btnRefresh.LargeGlyph = CType(resources.GetObject("btnRefresh.LargeGlyph"), System.Drawing.Image)
    Me.btnRefresh.Name = "btnRefresh"
    '
    'BarButtonItem2
    '
    Me.BarButtonItem2.Caption = "BarButtonItem2"
    Me.BarButtonItem2.Id = 10
    Me.BarButtonItem2.Name = "BarButtonItem2"
    '
    'LayoutControlGroup3
    '
    Me.LayoutControlGroup3.CustomizationFormText = "Info Utama"
    Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.lytRegional, Me.LayoutControlItem1, Me.LayoutControlItem14, Me.EmptySpaceItem6, Me.LayoutControlItem28, Me.EmptySpaceItem2})
    Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
    Me.LayoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
    Me.LayoutControlGroup3.Size = New System.Drawing.Size(1098, 94)
    Me.LayoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 15)
    Me.LayoutControlGroup3.Text = "Info Utama"
    '
    'LayoutControlItem12
    '
    Me.LayoutControlItem12.Control = Me.txtTipeJO
    Me.LayoutControlItem12.CustomizationFormText = "Termin"
    Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 94)
    Me.LayoutControlItem12.Name = "LayoutControlItem12"
    Me.LayoutControlItem12.Size = New System.Drawing.Size(178, 24)
    Me.LayoutControlItem12.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem12.Text = "Tipe JO"
    Me.LayoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem12.TextSize = New System.Drawing.Size(52, 13)
    Me.LayoutControlItem12.TextToControlDistance = 5
    '
    'EmptySpaceItem3
    '
    Me.EmptySpaceItem3.AllowHotTrack = False
    Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Location = New System.Drawing.Point(1038, 94)
    Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Size = New System.Drawing.Size(60, 24)
    Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
    Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
    '
    'TabbedControlGroup1
    '
    Me.TabbedControlGroup1.CustomizationFormText = "TabbedControlGroup1"
    Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 118)
    Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
    Me.TabbedControlGroup1.SelectedTabPage = Me.lytItem
    Me.TabbedControlGroup1.SelectedTabPageIndex = 0
    Me.TabbedControlGroup1.Size = New System.Drawing.Size(1098, 297)
    Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lytItem, Me.lytImpor, Me.lytImporStatus, Me.lytEkspor, Me.lytEksporStatus})
    Me.TabbedControlGroup1.Text = "TabbedControlGroup1"
    '
    'LayoutControlItem21
    '
    Me.LayoutControlItem21.Control = Me.txtNoRef
    Me.LayoutControlItem21.CustomizationFormText = "Reff Number"
    Me.LayoutControlItem21.Location = New System.Drawing.Point(178, 94)
    Me.LayoutControlItem21.Name = "LayoutControlItem21"
    Me.LayoutControlItem21.Size = New System.Drawing.Size(444, 24)
    Me.LayoutControlItem21.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem21.Text = "Reff Number"
    Me.LayoutControlItem21.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem21.TextSize = New System.Drawing.Size(68, 13)
    Me.LayoutControlItem21.TextToControlDistance = 5
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtUraian
    Me.LayoutControlItem3.CustomizationFormText = "Uraian"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(622, 94)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(416, 24)
    Me.LayoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
    Me.LayoutControlItem3.Text = "Uraian"
    Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(68, 13)
    Me.LayoutControlItem3.TextToControlDistance = 5
    '
    'EmptySpaceItem22
    '
    Me.EmptySpaceItem22.AllowHotTrack = False
    Me.EmptySpaceItem22.CustomizationFormText = "EmptySpaceItem22"
    Me.EmptySpaceItem22.Location = New System.Drawing.Point(1098, 0)
    Me.EmptySpaceItem22.Name = "EmptySpaceItem22"
    Me.EmptySpaceItem22.Size = New System.Drawing.Size(10, 415)
    Me.EmptySpaceItem22.Text = "EmptySpaceItem22"
    Me.EmptySpaceItem22.TextSize = New System.Drawing.Size(0, 0)
    '
    'layKontak
    '
    Me.layKontak.Control = Me.txtKontak
    Me.layKontak.CustomizationFormText = "Vendor"
    Me.layKontak.Location = New System.Drawing.Point(0, 0)
    Me.layKontak.Name = "layKontak"
    Me.layKontak.Size = New System.Drawing.Size(293, 24)
    Me.layKontak.Text = "Customer   "
    Me.layKontak.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.layKontak.TextSize = New System.Drawing.Size(69, 13)
    Me.layKontak.TextToControlDistance = 5
    '
    'LayoutControlItem15
    '
    Me.LayoutControlItem15.Control = Me.txtTanggal
    Me.LayoutControlItem15.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem15.Location = New System.Drawing.Point(633, 0)
    Me.LayoutControlItem15.Name = "LayoutControlItem15"
    Me.LayoutControlItem15.Size = New System.Drawing.Size(205, 24)
    Me.LayoutControlItem15.Text = "Tanggal   "
    Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem15.TextSize = New System.Drawing.Size(43, 13)
    Me.LayoutControlItem15.TextToControlDistance = 5
    '
    'LayoutControlItem16
    '
    Me.LayoutControlItem16.Control = Me.txtNoTransaksi
    Me.LayoutControlItem16.CustomizationFormText = "No. Transaksi"
    Me.LayoutControlItem16.Location = New System.Drawing.Point(838, 0)
    Me.LayoutControlItem16.Name = "LayoutControlItem16"
    Me.LayoutControlItem16.Size = New System.Drawing.Size(218, 24)
    Me.LayoutControlItem16.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem16.Text = "No. Bukti   "
    Me.LayoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem16.TextSize = New System.Drawing.Size(43, 13)
    Me.LayoutControlItem16.TextToControlDistance = 5
    '
    'LayoutControlItem17
    '
    Me.LayoutControlItem17.Control = Me.btnRefreshNomor
    Me.LayoutControlItem17.CustomizationFormText = " "
    Me.LayoutControlItem17.Location = New System.Drawing.Point(1056, 0)
    Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(30, 26)
    Me.LayoutControlItem17.MinSize = New System.Drawing.Size(30, 26)
    Me.LayoutControlItem17.Name = "LayoutControlItem17"
    Me.LayoutControlItem17.Size = New System.Drawing.Size(30, 48)
    Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem17.Text = " "
    Me.LayoutControlItem17.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem17.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem17.TextToControlDistance = 0
    Me.LayoutControlItem17.TextVisible = False
    Me.LayoutControlItem17.TrimClientAreaToControl = False
    '
    'lytRegional
    '
    Me.lytRegional.Control = Me.txtRegional
    Me.lytRegional.CustomizationFormText = "Regional"
    Me.lytRegional.Location = New System.Drawing.Point(633, 24)
    Me.lytRegional.Name = "lytRegional"
    Me.lytRegional.Size = New System.Drawing.Size(205, 24)
    Me.lytRegional.Text = "Regional"
    Me.lytRegional.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.lytRegional.TextSize = New System.Drawing.Size(43, 13)
    Me.lytRegional.TextToControlDistance = 5
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtKontakPerson
    Me.LayoutControlItem1.CustomizationFormText = "Kontak Person"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(293, 24)
    Me.LayoutControlItem1.Text = "Kontak Person   "
    Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(69, 13)
    Me.LayoutControlItem1.TextToControlDistance = 5
    '
    'LayoutControlItem14
    '
    Me.LayoutControlItem14.Control = Me.txtStatus
    Me.LayoutControlItem14.CustomizationFormText = "Status"
    Me.LayoutControlItem14.Location = New System.Drawing.Point(838, 24)
    Me.LayoutControlItem14.Name = "LayoutControlItem14"
    Me.LayoutControlItem14.Size = New System.Drawing.Size(218, 24)
    Me.LayoutControlItem14.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem14.Text = "Status   "
    Me.LayoutControlItem14.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem14.TextSize = New System.Drawing.Size(43, 13)
    Me.LayoutControlItem14.TextToControlDistance = 5
    '
    'EmptySpaceItem6
    '
    Me.EmptySpaceItem6.AllowHotTrack = False
    Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Location = New System.Drawing.Point(509, 0)
    Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Size = New System.Drawing.Size(124, 48)
    Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
    Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem28
    '
    Me.LayoutControlItem28.Control = Me.lblKontakNama
    Me.LayoutControlItem28.CustomizationFormText = "NamaKontak"
    Me.LayoutControlItem28.Location = New System.Drawing.Point(293, 0)
    Me.LayoutControlItem28.MinSize = New System.Drawing.Size(70, 17)
    Me.LayoutControlItem28.Name = "LayoutControlItem28"
    Me.LayoutControlItem28.Size = New System.Drawing.Size(216, 24)
    Me.LayoutControlItem28.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem28.Text = "NamaKontak"
    Me.LayoutControlItem28.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem28.TextToControlDistance = 0
    Me.LayoutControlItem28.TextVisible = False
    '
    'EmptySpaceItem2
    '
    Me.EmptySpaceItem2.AllowHotTrack = False
    Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Location = New System.Drawing.Point(293, 24)
    Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(216, 24)
    Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(216, 24)
    Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Size = New System.Drawing.Size(216, 24)
    Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
    Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
    '
    'lytItem
    '
    Me.lytItem.CustomizationFormText = "Item"
    Me.lytItem.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem31, Me.EmptySpaceItem23, Me.LayoutControlItem93, Me.LayoutControlItem94})
    Me.lytItem.Location = New System.Drawing.Point(0, 0)
    Me.lytItem.Name = "lytItem"
    Me.lytItem.Size = New System.Drawing.Size(1074, 251)
    Me.lytItem.Text = "Item"
    '
    'lytImpor
    '
    Me.lytImpor.CustomizationFormText = "Ekspor"
    Me.lytImpor.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.EmptySpaceItem4, Me.EmptySpaceItem5, Me.LayoutControlItem57, Me.EmptySpaceItem12, Me.EmptySpaceItem13, Me.LayoutControlItem34, Me.LayoutControlItem95, Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlItem13, Me.LayoutControlItem18, Me.LayoutControlItem59})
    Me.lytImpor.Location = New System.Drawing.Point(0, 0)
    Me.lytImpor.Name = "lytImpor"
    Me.lytImpor.Size = New System.Drawing.Size(1074, 251)
    Me.lytImpor.Text = "Impor"
    '
    'lytImporStatus
    '
    Me.lytImporStatus.CustomizationFormText = "Status Dok Impor"
    Me.lytImporStatus.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem32, Me.EmptySpaceItem17, Me.LayoutControlItem26, Me.LayoutControlItem27, Me.LayoutControlItem81, Me.LayoutControlItem60, Me.LayoutControlItem30, Me.LayoutControlItem22, Me.LayoutControlItem25, Me.LayoutControlItem23, Me.LayoutControlItem29, Me.LayoutControlItem24, Me.EmptySpaceItem14, Me.EmptySpaceItem18, Me.LayoutControlItem82, Me.LayoutControlItem83, Me.LayoutControlItem84, Me.LayoutControlItem85, Me.LayoutControlItem86, Me.LayoutControlItem87, Me.LayoutControlItem88, Me.LayoutControlItem89, Me.LayoutControlItem90, Me.LayoutControlItem91, Me.EmptySpaceItem21, Me.LayoutControlItem92})
    Me.lytImporStatus.Location = New System.Drawing.Point(0, 0)
    Me.lytImporStatus.Name = "lytImporStatus"
    Me.lytImporStatus.Size = New System.Drawing.Size(1074, 251)
    Me.lytImporStatus.Text = "Status Dok Impor"
    '
    'lytEkspor
    '
    Me.lytEkspor.CustomizationFormText = "Impor"
    Me.lytEkspor.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem38, Me.LayoutControlItem39, Me.LayoutControlItem40, Me.LayoutControlItem41, Me.LayoutControlItem42, Me.LayoutControlItem45, Me.LayoutControlItem46, Me.EmptySpaceItem7, Me.EmptySpaceItem8, Me.EmptySpaceItem9, Me.LayoutControlItem36, Me.EmptySpaceItem10, Me.EmptySpaceItem11, Me.LayoutControlItem43, Me.LayoutControlItem44, Me.LayoutControlItem47, Me.LayoutControlItem53, Me.LayoutControlItem54, Me.LayoutControlItem55, Me.LayoutControlItem56, Me.LayoutControlItem52, Me.EmptySpaceItem24, Me.LayoutControlItem33, Me.EmptySpaceItem25})
    Me.lytEkspor.Location = New System.Drawing.Point(0, 0)
    Me.lytEkspor.Name = "lytEkspor"
    Me.lytEkspor.Size = New System.Drawing.Size(1074, 251)
    Me.lytEkspor.Text = "Ekspor"
    '
    'lytEksporStatus
    '
    Me.lytEksporStatus.CustomizationFormText = "Status Dok Ekspor"
    Me.lytEksporStatus.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem49, Me.LayoutControlItem51, Me.EmptySpaceItem15, Me.LayoutControlItem37, Me.LayoutControlItem50, Me.LayoutControlItem48, Me.EmptySpaceItem16, Me.LayoutControlItem61, Me.LayoutControlItem62, Me.LayoutControlItem63, Me.LayoutControlItem64, Me.LayoutControlItem65, Me.EmptySpaceItem19, Me.LayoutControlItem67, Me.LayoutControlItem68, Me.LayoutControlItem69, Me.LayoutControlItem70, Me.LayoutControlItem71, Me.LayoutControlItem72, Me.LayoutControlItem73, Me.LayoutControlItem74, Me.EmptySpaceItem20, Me.LayoutControlItem75, Me.LayoutControlItem76, Me.LayoutControlItem77, Me.LayoutControlItem78, Me.LayoutControlItem79, Me.LayoutControlItem80, Me.LayoutControlItem66})
    Me.lytEksporStatus.Location = New System.Drawing.Point(0, 0)
    Me.lytEksporStatus.Name = "lytEksporStatus"
    Me.lytEksporStatus.Size = New System.Drawing.Size(1074, 251)
    Me.lytEksporStatus.Text = "Status Dok Ekspor"
    '
    'LayoutControlItem31
    '
    Me.LayoutControlItem31.Control = Me.txtJenisBarang
    Me.LayoutControlItem31.CustomizationFormText = "Jenis Barang"
    Me.LayoutControlItem31.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem31.Name = "LayoutControlItem31"
    Me.LayoutControlItem31.Size = New System.Drawing.Size(400, 24)
    Me.LayoutControlItem31.Text = "Jenis Stock"
    Me.LayoutControlItem31.TextSize = New System.Drawing.Size(111, 13)
    '
    'EmptySpaceItem23
    '
    Me.EmptySpaceItem23.AllowHotTrack = False
    Me.EmptySpaceItem23.CustomizationFormText = "EmptySpaceItem23"
    Me.EmptySpaceItem23.Location = New System.Drawing.Point(400, 0)
    Me.EmptySpaceItem23.Name = "EmptySpaceItem23"
    Me.EmptySpaceItem23.Size = New System.Drawing.Size(674, 251)
    Me.EmptySpaceItem23.Text = "EmptySpaceItem23"
    Me.EmptySpaceItem23.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem93
    '
    Me.LayoutControlItem93.Control = Me.txtQty
    Me.LayoutControlItem93.CustomizationFormText = "Qty"
    Me.LayoutControlItem93.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem93.Name = "LayoutControlItem93"
    Me.LayoutControlItem93.Size = New System.Drawing.Size(400, 24)
    Me.LayoutControlItem93.Text = "Qty"
    Me.LayoutControlItem93.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem94
    '
    Me.LayoutControlItem94.Control = Me.txtSatuan
    Me.LayoutControlItem94.CustomizationFormText = "Barang"
    Me.LayoutControlItem94.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem94.Name = "LayoutControlItem94"
    Me.LayoutControlItem94.Size = New System.Drawing.Size(400, 203)
    Me.LayoutControlItem94.Text = "Barang"
    Me.LayoutControlItem94.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.itxtETA
    Me.LayoutControlItem2.CustomizationFormText = "ETA"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(358, 24)
    Me.LayoutControlItem2.Text = "ETA"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.itxtBLNo
    Me.LayoutControlItem4.CustomizationFormText = "BL No"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(358, 24)
    Me.LayoutControlItem4.Text = "BL No"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.itxtShipper
    Me.LayoutControlItem5.CustomizationFormText = "Shipper"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(358, 24)
    Me.LayoutControlItem5.Text = "Shipper"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.itxtConsignee
    Me.LayoutControlItem6.CustomizationFormText = "Consignee"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(358, 24)
    Me.LayoutControlItem6.Text = "Consignee"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.itxtEmail
    Me.LayoutControlItem8.CustomizationFormText = "Email"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 96)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(358, 24)
    Me.LayoutControlItem8.Text = "Email"
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem19
    '
    Me.LayoutControlItem19.Control = Me.itxtMeass
    Me.LayoutControlItem19.CustomizationFormText = "Meass"
    Me.LayoutControlItem19.Location = New System.Drawing.Point(368, 48)
    Me.LayoutControlItem19.Name = "LayoutControlItem19"
    Me.LayoutControlItem19.Size = New System.Drawing.Size(390, 24)
    Me.LayoutControlItem19.Text = "Meass"
    Me.LayoutControlItem19.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem20
    '
    Me.LayoutControlItem20.Control = Me.itxtParty
    Me.LayoutControlItem20.CustomizationFormText = "Party"
    Me.LayoutControlItem20.Location = New System.Drawing.Point(368, 72)
    Me.LayoutControlItem20.Name = "LayoutControlItem20"
    Me.LayoutControlItem20.Size = New System.Drawing.Size(390, 24)
    Me.LayoutControlItem20.Text = "Party"
    Me.LayoutControlItem20.TextSize = New System.Drawing.Size(111, 13)
    '
    'EmptySpaceItem4
    '
    Me.EmptySpaceItem4.AllowHotTrack = False
    Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Location = New System.Drawing.Point(368, 120)
    Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Size = New System.Drawing.Size(390, 131)
    Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
    Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem5
    '
    Me.EmptySpaceItem5.AllowHotTrack = False
    Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Location = New System.Drawing.Point(771, 154)
    Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Size = New System.Drawing.Size(303, 97)
    Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
    Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem57
    '
    Me.LayoutControlItem57.Control = Me.itxtPListTanggal
    Me.LayoutControlItem57.CustomizationFormText = "LayoutControlItem57"
    Me.LayoutControlItem57.Location = New System.Drawing.Point(244, 227)
    Me.LayoutControlItem57.Name = "LayoutControlItem57"
    Me.LayoutControlItem57.Size = New System.Drawing.Size(114, 24)
    Me.LayoutControlItem57.Text = "LayoutControlItem57"
    Me.LayoutControlItem57.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem57.TextToControlDistance = 0
    Me.LayoutControlItem57.TextVisible = False
    '
    'EmptySpaceItem12
    '
    Me.EmptySpaceItem12.AllowHotTrack = False
    Me.EmptySpaceItem12.CustomizationFormText = "EmptySpaceItem12"
    Me.EmptySpaceItem12.Location = New System.Drawing.Point(358, 0)
    Me.EmptySpaceItem12.MaxSize = New System.Drawing.Size(10, 0)
    Me.EmptySpaceItem12.MinSize = New System.Drawing.Size(10, 10)
    Me.EmptySpaceItem12.Name = "EmptySpaceItem12"
    Me.EmptySpaceItem12.Size = New System.Drawing.Size(10, 251)
    Me.EmptySpaceItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem12.Text = "EmptySpaceItem12"
    Me.EmptySpaceItem12.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem13
    '
    Me.EmptySpaceItem13.AllowHotTrack = False
    Me.EmptySpaceItem13.CustomizationFormText = "EmptySpaceItem13"
    Me.EmptySpaceItem13.Location = New System.Drawing.Point(758, 0)
    Me.EmptySpaceItem13.MaxSize = New System.Drawing.Size(13, 0)
    Me.EmptySpaceItem13.MinSize = New System.Drawing.Size(13, 10)
    Me.EmptySpaceItem13.Name = "EmptySpaceItem13"
    Me.EmptySpaceItem13.Size = New System.Drawing.Size(13, 251)
    Me.EmptySpaceItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem13.Text = "EmptySpaceItem13"
    Me.EmptySpaceItem13.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem34
    '
    Me.LayoutControlItem34.Control = Me.itxtOther
    Me.LayoutControlItem34.CustomizationFormText = "Other"
    Me.LayoutControlItem34.Location = New System.Drawing.Point(771, 0)
    Me.LayoutControlItem34.MaxSize = New System.Drawing.Size(0, 154)
    Me.LayoutControlItem34.MinSize = New System.Drawing.Size(119, 154)
    Me.LayoutControlItem34.Name = "LayoutControlItem34"
    Me.LayoutControlItem34.Size = New System.Drawing.Size(303, 154)
    Me.LayoutControlItem34.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem34.Text = "Other"
    Me.LayoutControlItem34.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem95
    '
    Me.LayoutControlItem95.Control = Me.gridInvoice
    Me.LayoutControlItem95.CustomizationFormText = "Invoice No && Date"
    Me.LayoutControlItem95.Location = New System.Drawing.Point(0, 120)
    Me.LayoutControlItem95.Name = "LayoutControlItem95"
    Me.LayoutControlItem95.Size = New System.Drawing.Size(358, 107)
    Me.LayoutControlItem95.Text = "Invoice No && Date"
    Me.LayoutControlItem95.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem95.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.Control = Me.itxtAJOU
    Me.LayoutControlItem9.CustomizationFormText = "AJU No"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(368, 96)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(390, 24)
    Me.LayoutControlItem9.Text = "AJU No"
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem11
    '
    Me.LayoutControlItem11.Control = Me.itxtPListNo
    Me.LayoutControlItem11.CustomizationFormText = "No && Date P.List"
    Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 227)
    Me.LayoutControlItem11.Name = "LayoutControlItem11"
    Me.LayoutControlItem11.Size = New System.Drawing.Size(244, 24)
    Me.LayoutControlItem11.Text = "No && Date P.List"
    Me.LayoutControlItem11.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem13
    '
    Me.LayoutControlItem13.Control = Me.itxtVessel
    Me.LayoutControlItem13.CustomizationFormText = "Vessel"
    Me.LayoutControlItem13.Location = New System.Drawing.Point(368, 0)
    Me.LayoutControlItem13.Name = "LayoutControlItem13"
    Me.LayoutControlItem13.Size = New System.Drawing.Size(390, 24)
    Me.LayoutControlItem13.Text = "Vessel"
    Me.LayoutControlItem13.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem18
    '
    Me.LayoutControlItem18.Control = Me.itxtNW
    Me.LayoutControlItem18.CustomizationFormText = "NW/GW (KGS)"
    Me.LayoutControlItem18.Location = New System.Drawing.Point(368, 24)
    Me.LayoutControlItem18.Name = "LayoutControlItem18"
    Me.LayoutControlItem18.Size = New System.Drawing.Size(238, 24)
    Me.LayoutControlItem18.Text = "NW/GW (KGS)"
    Me.LayoutControlItem18.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem59
    '
    Me.LayoutControlItem59.Control = Me.itxtGW
    Me.LayoutControlItem59.CustomizationFormText = "LayoutControlItem59"
    Me.LayoutControlItem59.Location = New System.Drawing.Point(606, 24)
    Me.LayoutControlItem59.Name = "LayoutControlItem59"
    Me.LayoutControlItem59.Size = New System.Drawing.Size(152, 24)
    Me.LayoutControlItem59.Text = "LayoutControlItem59"
    Me.LayoutControlItem59.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem59.TextToControlDistance = 0
    Me.LayoutControlItem59.TextVisible = False
    '
    'LayoutControlItem32
    '
    Me.LayoutControlItem32.Control = Me.itxtBPN
    Me.LayoutControlItem32.CustomizationFormText = "BPN/SPPB"
    Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem32.MaxSize = New System.Drawing.Size(359, 24)
    Me.LayoutControlItem32.MinSize = New System.Drawing.Size(359, 24)
    Me.LayoutControlItem32.Name = "LayoutControlItem32"
    Me.LayoutControlItem32.Size = New System.Drawing.Size(361, 24)
    Me.LayoutControlItem32.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem32.Text = "BPN/SPPB"
    Me.LayoutControlItem32.TextSize = New System.Drawing.Size(111, 13)
    '
    'EmptySpaceItem17
    '
    Me.EmptySpaceItem17.AllowHotTrack = False
    Me.EmptySpaceItem17.CustomizationFormText = "EmptySpaceItem17"
    Me.EmptySpaceItem17.Location = New System.Drawing.Point(653, 120)
    Me.EmptySpaceItem17.Name = "EmptySpaceItem17"
    Me.EmptySpaceItem17.Size = New System.Drawing.Size(293, 131)
    Me.EmptySpaceItem17.Text = "EmptySpaceItem17"
    Me.EmptySpaceItem17.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem26
    '
    Me.LayoutControlItem26.Control = Me.itxtBC
    Me.LayoutControlItem26.CustomizationFormText = "Tgl BC 23"
    Me.LayoutControlItem26.Location = New System.Drawing.Point(371, 0)
    Me.LayoutControlItem26.Name = "LayoutControlItem26"
    Me.LayoutControlItem26.Size = New System.Drawing.Size(268, 24)
    Me.LayoutControlItem26.Text = "Tgl BC 23"
    Me.LayoutControlItem26.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem27
    '
    Me.LayoutControlItem27.Control = Me.itxtSK
    Me.LayoutControlItem27.CustomizationFormText = "Tgl SK"
    Me.LayoutControlItem27.Location = New System.Drawing.Point(371, 24)
    Me.LayoutControlItem27.Name = "LayoutControlItem27"
    Me.LayoutControlItem27.Size = New System.Drawing.Size(268, 24)
    Me.LayoutControlItem27.Text = "Tgl SK"
    Me.LayoutControlItem27.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem81
    '
    Me.LayoutControlItem81.Control = Me.itxtSPPB
    Me.LayoutControlItem81.CustomizationFormText = "SPPBTgl"
    Me.LayoutControlItem81.Location = New System.Drawing.Point(371, 72)
    Me.LayoutControlItem81.Name = "LayoutControlItem81"
    Me.LayoutControlItem81.Size = New System.Drawing.Size(268, 24)
    Me.LayoutControlItem81.Text = "Tgl SPPB"
    Me.LayoutControlItem81.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem60
    '
    Me.LayoutControlItem60.Control = Me.itxtDocTagihan
    Me.LayoutControlItem60.CustomizationFormText = "Tgl Terima Doc Tagihan"
    Me.LayoutControlItem60.Location = New System.Drawing.Point(371, 48)
    Me.LayoutControlItem60.Name = "LayoutControlItem60"
    Me.LayoutControlItem60.Size = New System.Drawing.Size(268, 24)
    Me.LayoutControlItem60.Text = "Tgl Terima Doc Tagihan"
    Me.LayoutControlItem60.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem30
    '
    Me.LayoutControlItem30.Control = Me.itxtDO
    Me.LayoutControlItem30.CustomizationFormText = "DO"
    Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem30.MaxSize = New System.Drawing.Size(359, 24)
    Me.LayoutControlItem30.MinSize = New System.Drawing.Size(359, 24)
    Me.LayoutControlItem30.Name = "LayoutControlItem30"
    Me.LayoutControlItem30.Size = New System.Drawing.Size(361, 24)
    Me.LayoutControlItem30.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem30.Text = "DO"
    Me.LayoutControlItem30.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem22
    '
    Me.LayoutControlItem22.Control = Me.itxtDraftPIB
    Me.LayoutControlItem22.CustomizationFormText = "Draft PIB"
    Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem22.MaxSize = New System.Drawing.Size(359, 24)
    Me.LayoutControlItem22.MinSize = New System.Drawing.Size(359, 24)
    Me.LayoutControlItem22.Name = "LayoutControlItem22"
    Me.LayoutControlItem22.Size = New System.Drawing.Size(361, 24)
    Me.LayoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem22.Text = "Draft PIB"
    Me.LayoutControlItem22.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem25
    '
    Me.LayoutControlItem25.Control = Me.itxtBL
    Me.LayoutControlItem25.CustomizationFormText = "Tgl BL"
    Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 96)
    Me.LayoutControlItem25.Name = "LayoutControlItem25"
    Me.LayoutControlItem25.Size = New System.Drawing.Size(361, 24)
    Me.LayoutControlItem25.Text = "Tgl BL"
    Me.LayoutControlItem25.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem23
    '
    Me.LayoutControlItem23.Control = Me.itxt20
    Me.LayoutControlItem23.CustomizationFormText = "20"""
    Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 120)
    Me.LayoutControlItem23.MaxSize = New System.Drawing.Size(361, 24)
    Me.LayoutControlItem23.MinSize = New System.Drawing.Size(361, 24)
    Me.LayoutControlItem23.Name = "LayoutControlItem23"
    Me.LayoutControlItem23.Size = New System.Drawing.Size(361, 24)
    Me.LayoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem23.Text = "20"""
    Me.LayoutControlItem23.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem29
    '
    Me.LayoutControlItem29.Control = Me.itxtOriginal
    Me.LayoutControlItem29.CustomizationFormText = "Original"
    Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 168)
    Me.LayoutControlItem29.MaxSize = New System.Drawing.Size(359, 24)
    Me.LayoutControlItem29.MinSize = New System.Drawing.Size(359, 24)
    Me.LayoutControlItem29.Name = "LayoutControlItem29"
    Me.LayoutControlItem29.Size = New System.Drawing.Size(361, 83)
    Me.LayoutControlItem29.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem29.Text = "Original"
    Me.LayoutControlItem29.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem24
    '
    Me.LayoutControlItem24.Control = Me.itxt40
    Me.LayoutControlItem24.CustomizationFormText = "40"""
    Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 144)
    Me.LayoutControlItem24.Name = "LayoutControlItem24"
    Me.LayoutControlItem24.Size = New System.Drawing.Size(361, 24)
    Me.LayoutControlItem24.Text = "40"""
    Me.LayoutControlItem24.TextSize = New System.Drawing.Size(111, 13)
    '
    'EmptySpaceItem14
    '
    Me.EmptySpaceItem14.AllowHotTrack = False
    Me.EmptySpaceItem14.CustomizationFormText = "EmptySpaceItem14"
    Me.EmptySpaceItem14.Location = New System.Drawing.Point(639, 0)
    Me.EmptySpaceItem14.Name = "EmptySpaceItem14"
    Me.EmptySpaceItem14.Size = New System.Drawing.Size(14, 251)
    Me.EmptySpaceItem14.Text = "EmptySpaceItem14"
    Me.EmptySpaceItem14.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem18
    '
    Me.EmptySpaceItem18.AllowHotTrack = False
    Me.EmptySpaceItem18.CustomizationFormText = "EmptySpaceItem18"
    Me.EmptySpaceItem18.Location = New System.Drawing.Point(361, 0)
    Me.EmptySpaceItem18.Name = "EmptySpaceItem18"
    Me.EmptySpaceItem18.Size = New System.Drawing.Size(10, 251)
    Me.EmptySpaceItem18.Text = "EmptySpaceItem18"
    Me.EmptySpaceItem18.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem82
    '
    Me.LayoutControlItem82.Control = Me.itxtDOBayar
    Me.LayoutControlItem82.CustomizationFormText = "DOByrTgl"
    Me.LayoutControlItem82.Location = New System.Drawing.Point(371, 96)
    Me.LayoutControlItem82.Name = "LayoutControlItem82"
    Me.LayoutControlItem82.Size = New System.Drawing.Size(268, 24)
    Me.LayoutControlItem82.Text = "Tgl Bayar DO"
    Me.LayoutControlItem82.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem83
    '
    Me.LayoutControlItem83.Control = Me.itxtDOAmbil
    Me.LayoutControlItem83.CustomizationFormText = "DOAmbilTgl"
    Me.LayoutControlItem83.Location = New System.Drawing.Point(371, 120)
    Me.LayoutControlItem83.Name = "LayoutControlItem83"
    Me.LayoutControlItem83.Size = New System.Drawing.Size(268, 24)
    Me.LayoutControlItem83.Text = "Tgl Ambil DO"
    Me.LayoutControlItem83.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem84
    '
    Me.LayoutControlItem84.Control = Me.itxtDOTerbit
    Me.LayoutControlItem84.CustomizationFormText = "DOTerbitTgl"
    Me.LayoutControlItem84.Location = New System.Drawing.Point(371, 144)
    Me.LayoutControlItem84.Name = "LayoutControlItem84"
    Me.LayoutControlItem84.Size = New System.Drawing.Size(268, 24)
    Me.LayoutControlItem84.Text = "Terbit DO"
    Me.LayoutControlItem84.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem85
    '
    Me.LayoutControlItem85.Control = Me.itxtDelivery
    Me.LayoutControlItem85.CustomizationFormText = "DeliveryTgl"
    Me.LayoutControlItem85.Location = New System.Drawing.Point(371, 168)
    Me.LayoutControlItem85.Name = "LayoutControlItem85"
    Me.LayoutControlItem85.Size = New System.Drawing.Size(268, 24)
    Me.LayoutControlItem85.Text = "Tgl Delivery"
    Me.LayoutControlItem85.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem86
    '
    Me.LayoutControlItem86.Control = Me.itxtTagihan
    Me.LayoutControlItem86.CustomizationFormText = "TerimaTagihanTgl"
    Me.LayoutControlItem86.Location = New System.Drawing.Point(371, 192)
    Me.LayoutControlItem86.Name = "LayoutControlItem86"
    Me.LayoutControlItem86.Size = New System.Drawing.Size(268, 59)
    Me.LayoutControlItem86.Text = "Tgl Terima Tagihan"
    Me.LayoutControlItem86.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem87
    '
    Me.LayoutControlItem87.Control = Me.itxtCOO
    Me.LayoutControlItem87.CustomizationFormText = "Tgll COO"
    Me.LayoutControlItem87.Location = New System.Drawing.Point(653, 0)
    Me.LayoutControlItem87.Name = "LayoutControlItem87"
    Me.LayoutControlItem87.Size = New System.Drawing.Size(293, 24)
    Me.LayoutControlItem87.Text = "Tgl COO"
    Me.LayoutControlItem87.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem88
    '
    Me.LayoutControlItem88.Control = Me.itxtPOLPOD
    Me.LayoutControlItem88.CustomizationFormText = "POL/POD"
    Me.LayoutControlItem88.Location = New System.Drawing.Point(653, 24)
    Me.LayoutControlItem88.Name = "LayoutControlItem88"
    Me.LayoutControlItem88.Size = New System.Drawing.Size(293, 24)
    Me.LayoutControlItem88.Text = "POL/POD"
    Me.LayoutControlItem88.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem89
    '
    Me.LayoutControlItem89.Control = Me.itxtMBL
    Me.LayoutControlItem89.CustomizationFormText = "No. MBL"
    Me.LayoutControlItem89.Location = New System.Drawing.Point(653, 48)
    Me.LayoutControlItem89.Name = "LayoutControlItem89"
    Me.LayoutControlItem89.Size = New System.Drawing.Size(293, 24)
    Me.LayoutControlItem89.Text = "No. MBL"
    Me.LayoutControlItem89.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem90
    '
    Me.LayoutControlItem90.Control = Me.itxtPabean
    Me.LayoutControlItem90.CustomizationFormText = "No. Pabean"
    Me.LayoutControlItem90.Location = New System.Drawing.Point(653, 72)
    Me.LayoutControlItem90.Name = "LayoutControlItem90"
    Me.LayoutControlItem90.Size = New System.Drawing.Size(293, 24)
    Me.LayoutControlItem90.Text = "No. Pabean"
    Me.LayoutControlItem90.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem91
    '
    Me.LayoutControlItem91.Control = Me.itxtTglAju
    Me.LayoutControlItem91.CustomizationFormText = "Tgl Aju"
    Me.LayoutControlItem91.Location = New System.Drawing.Point(653, 96)
    Me.LayoutControlItem91.Name = "LayoutControlItem91"
    Me.LayoutControlItem91.Size = New System.Drawing.Size(293, 24)
    Me.LayoutControlItem91.Text = "Tgl Aju"
    Me.LayoutControlItem91.TextSize = New System.Drawing.Size(111, 13)
    '
    'EmptySpaceItem21
    '
    Me.EmptySpaceItem21.AllowHotTrack = False
    Me.EmptySpaceItem21.CustomizationFormText = "EmptySpaceItem21"
    Me.EmptySpaceItem21.Location = New System.Drawing.Point(946, 0)
    Me.EmptySpaceItem21.Name = "EmptySpaceItem21"
    Me.EmptySpaceItem21.Size = New System.Drawing.Size(128, 251)
    Me.EmptySpaceItem21.Text = "EmptySpaceItem21"
    Me.EmptySpaceItem21.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem92
    '
    Me.LayoutControlItem92.Control = Me.itxtBilling
    Me.LayoutControlItem92.CustomizationFormText = "Billing"
    Me.LayoutControlItem92.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem92.Name = "LayoutControlItem92"
    Me.LayoutControlItem92.Size = New System.Drawing.Size(361, 24)
    Me.LayoutControlItem92.Text = "Billing"
    Me.LayoutControlItem92.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem38
    '
    Me.LayoutControlItem38.Control = Me.eTxtBillLading
    Me.LayoutControlItem38.CustomizationFormText = "Bill of Lading No"
    Me.LayoutControlItem38.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem38.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem38.MinSize = New System.Drawing.Size(159, 24)
    Me.LayoutControlItem38.Name = "LayoutControlItem38"
    Me.LayoutControlItem38.Size = New System.Drawing.Size(364, 24)
    Me.LayoutControlItem38.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem38.Text = "Bill of Lading No"
    Me.LayoutControlItem38.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem39
    '
    Me.LayoutControlItem39.Control = Me.eTxtVessel
    Me.LayoutControlItem39.CustomizationFormText = "Vessel/VOY"
    Me.LayoutControlItem39.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem39.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem39.MinSize = New System.Drawing.Size(159, 24)
    Me.LayoutControlItem39.Name = "LayoutControlItem39"
    Me.LayoutControlItem39.Size = New System.Drawing.Size(364, 24)
    Me.LayoutControlItem39.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem39.Text = "Vessel/VOY"
    Me.LayoutControlItem39.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem40
    '
    Me.LayoutControlItem40.Control = Me.eTxtETD
    Me.LayoutControlItem40.CustomizationFormText = "ETD/ETA"
    Me.LayoutControlItem40.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem40.MaxSize = New System.Drawing.Size(0, 25)
    Me.LayoutControlItem40.MinSize = New System.Drawing.Size(50, 25)
    Me.LayoutControlItem40.Name = "LayoutControlItem40"
    Me.LayoutControlItem40.Size = New System.Drawing.Size(233, 25)
    Me.LayoutControlItem40.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem40.Text = "ETD/ETA"
    Me.LayoutControlItem40.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem41
    '
    Me.LayoutControlItem41.Control = Me.eTxtShipper
    Me.LayoutControlItem41.CustomizationFormText = "Shipper"
    Me.LayoutControlItem41.Location = New System.Drawing.Point(0, 73)
    Me.LayoutControlItem41.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem41.MinSize = New System.Drawing.Size(159, 24)
    Me.LayoutControlItem41.Name = "LayoutControlItem41"
    Me.LayoutControlItem41.Size = New System.Drawing.Size(364, 24)
    Me.LayoutControlItem41.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem41.Text = "Shipper"
    Me.LayoutControlItem41.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem42
    '
    Me.LayoutControlItem42.Control = Me.eTxtConsignee
    Me.LayoutControlItem42.CustomizationFormText = "Consignee"
    Me.LayoutControlItem42.Location = New System.Drawing.Point(0, 97)
    Me.LayoutControlItem42.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem42.MinSize = New System.Drawing.Size(159, 24)
    Me.LayoutControlItem42.Name = "LayoutControlItem42"
    Me.LayoutControlItem42.Size = New System.Drawing.Size(364, 24)
    Me.LayoutControlItem42.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem42.Text = "Consignee"
    Me.LayoutControlItem42.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem45
    '
    Me.LayoutControlItem45.Control = Me.eTxtNW
    Me.LayoutControlItem45.CustomizationFormText = "NW/GW (KGS)"
    Me.LayoutControlItem45.Location = New System.Drawing.Point(374, 0)
    Me.LayoutControlItem45.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem45.MinSize = New System.Drawing.Size(159, 24)
    Me.LayoutControlItem45.Name = "LayoutControlItem45"
    Me.LayoutControlItem45.Size = New System.Drawing.Size(222, 24)
    Me.LayoutControlItem45.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem45.Text = "NW/GW (KGS)"
    Me.LayoutControlItem45.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem46
    '
    Me.LayoutControlItem46.Control = Me.eTxtMeass
    Me.LayoutControlItem46.CustomizationFormText = "MEASS"
    Me.LayoutControlItem46.Location = New System.Drawing.Point(374, 24)
    Me.LayoutControlItem46.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem46.MinSize = New System.Drawing.Size(159, 24)
    Me.LayoutControlItem46.Name = "LayoutControlItem46"
    Me.LayoutControlItem46.Size = New System.Drawing.Size(328, 24)
    Me.LayoutControlItem46.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem46.Text = "MEASS"
    Me.LayoutControlItem46.TextSize = New System.Drawing.Size(111, 13)
    '
    'EmptySpaceItem7
    '
    Me.EmptySpaceItem7.AllowHotTrack = False
    Me.EmptySpaceItem7.CustomizationFormText = "EmptySpaceItem7"
    Me.EmptySpaceItem7.Location = New System.Drawing.Point(0, 193)
    Me.EmptySpaceItem7.MinSize = New System.Drawing.Size(104, 24)
    Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
    Me.EmptySpaceItem7.Size = New System.Drawing.Size(364, 58)
    Me.EmptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem7.Text = "EmptySpaceItem7"
    Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem8
    '
    Me.EmptySpaceItem8.AllowHotTrack = False
    Me.EmptySpaceItem8.CustomizationFormText = "EmptySpaceItem8"
    Me.EmptySpaceItem8.Location = New System.Drawing.Point(374, 107)
    Me.EmptySpaceItem8.MaxSize = New System.Drawing.Size(0, 39)
    Me.EmptySpaceItem8.MinSize = New System.Drawing.Size(10, 39)
    Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
    Me.EmptySpaceItem8.Size = New System.Drawing.Size(328, 39)
    Me.EmptySpaceItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem8.Text = "EmptySpaceItem8"
    Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem9
    '
    Me.EmptySpaceItem9.AllowHotTrack = False
    Me.EmptySpaceItem9.CustomizationFormText = "EmptySpaceItem9"
    Me.EmptySpaceItem9.Location = New System.Drawing.Point(715, 149)
    Me.EmptySpaceItem9.MinSize = New System.Drawing.Size(104, 24)
    Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
    Me.EmptySpaceItem9.Size = New System.Drawing.Size(359, 102)
    Me.EmptySpaceItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem9.Text = "EmptySpaceItem9"
    Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem36
    '
    Me.LayoutControlItem36.Control = Me.eTxtShipping
    Me.LayoutControlItem36.CustomizationFormText = "Shipping Instruction"
    Me.LayoutControlItem36.Location = New System.Drawing.Point(0, 121)
    Me.LayoutControlItem36.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem36.MinSize = New System.Drawing.Size(159, 24)
    Me.LayoutControlItem36.Name = "LayoutControlItem36"
    Me.LayoutControlItem36.Size = New System.Drawing.Size(364, 24)
    Me.LayoutControlItem36.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem36.Text = "Shipping Instruction"
    Me.LayoutControlItem36.TextSize = New System.Drawing.Size(111, 13)
    '
    'EmptySpaceItem10
    '
    Me.EmptySpaceItem10.AllowHotTrack = False
    Me.EmptySpaceItem10.CustomizationFormText = "EmptySpaceItem10"
    Me.EmptySpaceItem10.Location = New System.Drawing.Point(364, 0)
    Me.EmptySpaceItem10.MaxSize = New System.Drawing.Size(10, 0)
    Me.EmptySpaceItem10.MinSize = New System.Drawing.Size(10, 10)
    Me.EmptySpaceItem10.Name = "EmptySpaceItem10"
    Me.EmptySpaceItem10.Size = New System.Drawing.Size(10, 251)
    Me.EmptySpaceItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem10.Text = "EmptySpaceItem10"
    Me.EmptySpaceItem10.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem11
    '
    Me.EmptySpaceItem11.AllowHotTrack = False
    Me.EmptySpaceItem11.CustomizationFormText = "EmptySpaceItem11"
    Me.EmptySpaceItem11.Location = New System.Drawing.Point(702, 0)
    Me.EmptySpaceItem11.MaxSize = New System.Drawing.Size(13, 0)
    Me.EmptySpaceItem11.MinSize = New System.Drawing.Size(13, 10)
    Me.EmptySpaceItem11.Name = "EmptySpaceItem11"
    Me.EmptySpaceItem11.Size = New System.Drawing.Size(13, 251)
    Me.EmptySpaceItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem11.Text = "EmptySpaceItem11"
    Me.EmptySpaceItem11.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem43
    '
    Me.LayoutControlItem43.Control = Me.eTxtInvoiceNo
    Me.LayoutControlItem43.CustomizationFormText = "No && Date Of Invoice"
    Me.LayoutControlItem43.Location = New System.Drawing.Point(0, 145)
    Me.LayoutControlItem43.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem43.MinSize = New System.Drawing.Size(159, 24)
    Me.LayoutControlItem43.Name = "LayoutControlItem43"
    Me.LayoutControlItem43.Size = New System.Drawing.Size(244, 24)
    Me.LayoutControlItem43.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem43.Text = "No && Date Of Invoice"
    Me.LayoutControlItem43.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem44
    '
    Me.LayoutControlItem44.Control = Me.eTxtPackingNo
    Me.LayoutControlItem44.CustomizationFormText = "No && Date Of P.List"
    Me.LayoutControlItem44.Location = New System.Drawing.Point(0, 169)
    Me.LayoutControlItem44.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem44.MinSize = New System.Drawing.Size(159, 24)
    Me.LayoutControlItem44.Name = "LayoutControlItem44"
    Me.LayoutControlItem44.Size = New System.Drawing.Size(244, 24)
    Me.LayoutControlItem44.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem44.Text = "No && Date Of P.List"
    Me.LayoutControlItem44.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem47
    '
    Me.LayoutControlItem47.Control = Me.eTxtParty
    Me.LayoutControlItem47.CustomizationFormText = "PARTY"
    Me.LayoutControlItem47.Location = New System.Drawing.Point(374, 48)
    Me.LayoutControlItem47.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem47.MinSize = New System.Drawing.Size(159, 24)
    Me.LayoutControlItem47.Name = "LayoutControlItem47"
    Me.LayoutControlItem47.Size = New System.Drawing.Size(328, 24)
    Me.LayoutControlItem47.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem47.Text = "PARTY"
    Me.LayoutControlItem47.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem53
    '
    Me.LayoutControlItem53.Control = Me.eTxtInvoiceTanggal
    Me.LayoutControlItem53.CustomizationFormText = "LayoutControlItem53"
    Me.LayoutControlItem53.Location = New System.Drawing.Point(244, 145)
    Me.LayoutControlItem53.Name = "LayoutControlItem53"
    Me.LayoutControlItem53.Size = New System.Drawing.Size(120, 24)
    Me.LayoutControlItem53.Text = "LayoutControlItem53"
    Me.LayoutControlItem53.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem53.TextToControlDistance = 0
    Me.LayoutControlItem53.TextVisible = False
    '
    'LayoutControlItem54
    '
    Me.LayoutControlItem54.Control = Me.eTxtPackingTanggal
    Me.LayoutControlItem54.CustomizationFormText = "LayoutControlItem54"
    Me.LayoutControlItem54.Location = New System.Drawing.Point(244, 169)
    Me.LayoutControlItem54.Name = "LayoutControlItem54"
    Me.LayoutControlItem54.Size = New System.Drawing.Size(120, 24)
    Me.LayoutControlItem54.Text = "LayoutControlItem54"
    Me.LayoutControlItem54.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem54.TextToControlDistance = 0
    Me.LayoutControlItem54.TextVisible = False
    '
    'LayoutControlItem55
    '
    Me.LayoutControlItem55.Control = Me.eTxtGW
    Me.LayoutControlItem55.CustomizationFormText = "/"
    Me.LayoutControlItem55.Location = New System.Drawing.Point(596, 0)
    Me.LayoutControlItem55.Name = "LayoutControlItem55"
    Me.LayoutControlItem55.Size = New System.Drawing.Size(106, 24)
    Me.LayoutControlItem55.Text = "/"
    Me.LayoutControlItem55.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem55.TextToControlDistance = 0
    Me.LayoutControlItem55.TextVisible = False
    '
    'LayoutControlItem56
    '
    Me.LayoutControlItem56.Control = Me.eTxtETA
    Me.LayoutControlItem56.CustomizationFormText = "LayoutControlItem56"
    Me.LayoutControlItem56.Location = New System.Drawing.Point(233, 48)
    Me.LayoutControlItem56.Name = "LayoutControlItem56"
    Me.LayoutControlItem56.Size = New System.Drawing.Size(131, 25)
    Me.LayoutControlItem56.Text = "LayoutControlItem56"
    Me.LayoutControlItem56.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem56.TextToControlDistance = 0
    Me.LayoutControlItem56.TextVisible = False
    '
    'LayoutControlItem52
    '
    Me.LayoutControlItem52.Control = Me.eTxtOther
    Me.LayoutControlItem52.CustomizationFormText = "Other"
    Me.LayoutControlItem52.Location = New System.Drawing.Point(715, 0)
    Me.LayoutControlItem52.MaxSize = New System.Drawing.Size(0, 149)
    Me.LayoutControlItem52.MinSize = New System.Drawing.Size(119, 149)
    Me.LayoutControlItem52.Name = "LayoutControlItem52"
    Me.LayoutControlItem52.Size = New System.Drawing.Size(359, 149)
    Me.LayoutControlItem52.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem52.Text = "Other"
    Me.LayoutControlItem52.TextSize = New System.Drawing.Size(111, 13)
    '
    'EmptySpaceItem24
    '
    Me.EmptySpaceItem24.AllowHotTrack = False
    Me.EmptySpaceItem24.CustomizationFormText = "EmptySpaceItem24"
    Me.EmptySpaceItem24.Location = New System.Drawing.Point(374, 72)
    Me.EmptySpaceItem24.MaxSize = New System.Drawing.Size(0, 35)
    Me.EmptySpaceItem24.MinSize = New System.Drawing.Size(10, 35)
    Me.EmptySpaceItem24.Name = "EmptySpaceItem24"
    Me.EmptySpaceItem24.Size = New System.Drawing.Size(328, 35)
    Me.EmptySpaceItem24.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem24.Text = "EmptySpaceItem24"
    Me.EmptySpaceItem24.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem33
    '
    Me.LayoutControlItem33.Control = Me.txteAmountInvoice
    Me.LayoutControlItem33.CustomizationFormText = "Amount Invoice"
    Me.LayoutControlItem33.Location = New System.Drawing.Point(374, 146)
    Me.LayoutControlItem33.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem33.MinSize = New System.Drawing.Size(168, 24)
    Me.LayoutControlItem33.Name = "LayoutControlItem33"
    Me.LayoutControlItem33.Size = New System.Drawing.Size(328, 24)
    Me.LayoutControlItem33.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem33.Text = "Amount Invoice"
    Me.LayoutControlItem33.TextSize = New System.Drawing.Size(111, 13)
    '
    'EmptySpaceItem25
    '
    Me.EmptySpaceItem25.AllowHotTrack = False
    Me.EmptySpaceItem25.CustomizationFormText = "EmptySpaceItem25"
    Me.EmptySpaceItem25.Location = New System.Drawing.Point(374, 170)
    Me.EmptySpaceItem25.MinSize = New System.Drawing.Size(104, 24)
    Me.EmptySpaceItem25.Name = "EmptySpaceItem25"
    Me.EmptySpaceItem25.Size = New System.Drawing.Size(328, 81)
    Me.EmptySpaceItem25.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem25.Text = "EmptySpaceItem25"
    Me.EmptySpaceItem25.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem49
    '
    Me.LayoutControlItem49.Control = Me.eTxtInsurance
    Me.LayoutControlItem49.CustomizationFormText = "Insurance"
    Me.LayoutControlItem49.Location = New System.Drawing.Point(0, 73)
    Me.LayoutControlItem49.MaxSize = New System.Drawing.Size(427, 25)
    Me.LayoutControlItem49.MinSize = New System.Drawing.Size(427, 25)
    Me.LayoutControlItem49.Name = "LayoutControlItem49"
    Me.LayoutControlItem49.Size = New System.Drawing.Size(427, 25)
    Me.LayoutControlItem49.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem49.Text = "Insurance"
    Me.LayoutControlItem49.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem51
    '
    Me.LayoutControlItem51.Control = Me.eTxtPickup
    Me.LayoutControlItem51.CustomizationFormText = "Pick Up"
    Me.LayoutControlItem51.Location = New System.Drawing.Point(0, 98)
    Me.LayoutControlItem51.MaxSize = New System.Drawing.Size(427, 25)
    Me.LayoutControlItem51.MinSize = New System.Drawing.Size(427, 25)
    Me.LayoutControlItem51.Name = "LayoutControlItem51"
    Me.LayoutControlItem51.Size = New System.Drawing.Size(427, 25)
    Me.LayoutControlItem51.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem51.Text = "Pick Up"
    Me.LayoutControlItem51.TextSize = New System.Drawing.Size(111, 13)
    '
    'EmptySpaceItem15
    '
    Me.EmptySpaceItem15.AllowHotTrack = False
    Me.EmptySpaceItem15.CustomizationFormText = "EmptySpaceItem15"
    Me.EmptySpaceItem15.Location = New System.Drawing.Point(763, 168)
    Me.EmptySpaceItem15.Name = "EmptySpaceItem15"
    Me.EmptySpaceItem15.Size = New System.Drawing.Size(311, 51)
    Me.EmptySpaceItem15.Text = "EmptySpaceItem15"
    Me.EmptySpaceItem15.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem37
    '
    Me.LayoutControlItem37.Control = Me.eTxtNPE
    Me.LayoutControlItem37.CustomizationFormText = "NPE No"
    Me.LayoutControlItem37.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem37.MaxSize = New System.Drawing.Size(427, 24)
    Me.LayoutControlItem37.MinSize = New System.Drawing.Size(427, 24)
    Me.LayoutControlItem37.Name = "LayoutControlItem37"
    Me.LayoutControlItem37.Size = New System.Drawing.Size(427, 24)
    Me.LayoutControlItem37.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem37.Text = "NPE No"
    Me.LayoutControlItem37.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem50
    '
    Me.LayoutControlItem50.Control = Me.eTxtCOO
    Me.LayoutControlItem50.CustomizationFormText = "COO"
    Me.LayoutControlItem50.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem50.MaxSize = New System.Drawing.Size(427, 25)
    Me.LayoutControlItem50.MinSize = New System.Drawing.Size(427, 25)
    Me.LayoutControlItem50.Name = "LayoutControlItem50"
    Me.LayoutControlItem50.Size = New System.Drawing.Size(427, 25)
    Me.LayoutControlItem50.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem50.Text = "COO"
    Me.LayoutControlItem50.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem48
    '
    Me.LayoutControlItem48.Control = Me.eTxtPEBNo
    Me.LayoutControlItem48.CustomizationFormText = "PEB No"
    Me.LayoutControlItem48.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem48.MaxSize = New System.Drawing.Size(427, 24)
    Me.LayoutControlItem48.MinSize = New System.Drawing.Size(427, 24)
    Me.LayoutControlItem48.Name = "LayoutControlItem48"
    Me.LayoutControlItem48.Size = New System.Drawing.Size(427, 24)
    Me.LayoutControlItem48.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem48.Text = "PEB No"
    Me.LayoutControlItem48.TextSize = New System.Drawing.Size(111, 13)
    '
    'EmptySpaceItem16
    '
    Me.EmptySpaceItem16.AllowHotTrack = False
    Me.EmptySpaceItem16.CustomizationFormText = "EmptySpaceItem16"
    Me.EmptySpaceItem16.Location = New System.Drawing.Point(0, 219)
    Me.EmptySpaceItem16.Name = "EmptySpaceItem16"
    Me.EmptySpaceItem16.Size = New System.Drawing.Size(1074, 32)
    Me.EmptySpaceItem16.Text = "EmptySpaceItem16"
    Me.EmptySpaceItem16.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem61
    '
    Me.LayoutControlItem61.Control = Me.eTxtTglSuratTugas
    Me.LayoutControlItem61.CustomizationFormText = "Tgl Surat Tugas"
    Me.LayoutControlItem61.Location = New System.Drawing.Point(0, 195)
    Me.LayoutControlItem61.MaxSize = New System.Drawing.Size(427, 24)
    Me.LayoutControlItem61.MinSize = New System.Drawing.Size(427, 24)
    Me.LayoutControlItem61.Name = "LayoutControlItem61"
    Me.LayoutControlItem61.Size = New System.Drawing.Size(427, 24)
    Me.LayoutControlItem61.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem61.Text = "Tgl Surat Tugas"
    Me.LayoutControlItem61.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem62
    '
    Me.LayoutControlItem62.Control = Me.eTxtTujuan
    Me.LayoutControlItem62.CustomizationFormText = "Tujuan"
    Me.LayoutControlItem62.Location = New System.Drawing.Point(0, 123)
    Me.LayoutControlItem62.MaxSize = New System.Drawing.Size(427, 24)
    Me.LayoutControlItem62.MinSize = New System.Drawing.Size(427, 24)
    Me.LayoutControlItem62.Name = "LayoutControlItem62"
    Me.LayoutControlItem62.Size = New System.Drawing.Size(427, 24)
    Me.LayoutControlItem62.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem62.Text = "Tujuan"
    Me.LayoutControlItem62.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem63
    '
    Me.LayoutControlItem63.Control = Me.eTxtTglSI
    Me.LayoutControlItem63.CustomizationFormText = "Tgl Buat SI"
    Me.LayoutControlItem63.Location = New System.Drawing.Point(0, 147)
    Me.LayoutControlItem63.MaxSize = New System.Drawing.Size(427, 24)
    Me.LayoutControlItem63.MinSize = New System.Drawing.Size(427, 24)
    Me.LayoutControlItem63.Name = "LayoutControlItem63"
    Me.LayoutControlItem63.Size = New System.Drawing.Size(427, 24)
    Me.LayoutControlItem63.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem63.Text = "Tgl Buat SI"
    Me.LayoutControlItem63.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem64
    '
    Me.LayoutControlItem64.Control = Me.eTxtTglRecTrucking
    Me.LayoutControlItem64.CustomizationFormText = "Tgl Req Trucking"
    Me.LayoutControlItem64.Location = New System.Drawing.Point(0, 171)
    Me.LayoutControlItem64.MaxSize = New System.Drawing.Size(427, 24)
    Me.LayoutControlItem64.MinSize = New System.Drawing.Size(427, 24)
    Me.LayoutControlItem64.Name = "LayoutControlItem64"
    Me.LayoutControlItem64.Size = New System.Drawing.Size(427, 24)
    Me.LayoutControlItem64.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem64.Text = "Tgl Req Trucking"
    Me.LayoutControlItem64.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem65
    '
    Me.LayoutControlItem65.Control = Me.eTxtPEBReq
    Me.LayoutControlItem65.CustomizationFormText = "TGL Req PEB"
    Me.LayoutControlItem65.Location = New System.Drawing.Point(437, 0)
    Me.LayoutControlItem65.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem65.MinSize = New System.Drawing.Size(168, 24)
    Me.LayoutControlItem65.Name = "LayoutControlItem65"
    Me.LayoutControlItem65.Size = New System.Drawing.Size(315, 24)
    Me.LayoutControlItem65.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem65.Text = "TGL Req PEB"
    Me.LayoutControlItem65.TextSize = New System.Drawing.Size(111, 13)
    '
    'EmptySpaceItem19
    '
    Me.EmptySpaceItem19.AllowHotTrack = False
    Me.EmptySpaceItem19.CustomizationFormText = "EmptySpaceItem19"
    Me.EmptySpaceItem19.Location = New System.Drawing.Point(427, 0)
    Me.EmptySpaceItem19.Name = "EmptySpaceItem19"
    Me.EmptySpaceItem19.Size = New System.Drawing.Size(10, 219)
    Me.EmptySpaceItem19.Text = "EmptySpaceItem19"
    Me.EmptySpaceItem19.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem67
    '
    Me.LayoutControlItem67.Control = Me.eTxtCOOKomunikasi
    Me.LayoutControlItem67.CustomizationFormText = "Tgl Komunikasi COO"
    Me.LayoutControlItem67.Location = New System.Drawing.Point(437, 192)
    Me.LayoutControlItem67.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem67.MinSize = New System.Drawing.Size(168, 24)
    Me.LayoutControlItem67.Name = "LayoutControlItem67"
    Me.LayoutControlItem67.Size = New System.Drawing.Size(315, 27)
    Me.LayoutControlItem67.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem67.Text = "Tgl Komunikasi COO"
    Me.LayoutControlItem67.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem68
    '
    Me.LayoutControlItem68.Control = Me.eTxtPEBTerima
    Me.LayoutControlItem68.CustomizationFormText = "Tgl Terima PEB"
    Me.LayoutControlItem68.Location = New System.Drawing.Point(437, 24)
    Me.LayoutControlItem68.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem68.MinSize = New System.Drawing.Size(168, 24)
    Me.LayoutControlItem68.Name = "LayoutControlItem68"
    Me.LayoutControlItem68.Size = New System.Drawing.Size(315, 24)
    Me.LayoutControlItem68.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem68.Text = "Tgl Terima PEB"
    Me.LayoutControlItem68.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem69
    '
    Me.LayoutControlItem69.Control = Me.eTxtBLTerima
    Me.LayoutControlItem69.CustomizationFormText = "Tgl Terima BL"
    Me.LayoutControlItem69.Location = New System.Drawing.Point(437, 72)
    Me.LayoutControlItem69.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem69.MinSize = New System.Drawing.Size(168, 24)
    Me.LayoutControlItem69.Name = "LayoutControlItem69"
    Me.LayoutControlItem69.Size = New System.Drawing.Size(315, 24)
    Me.LayoutControlItem69.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem69.Text = "Tgl Terima BL"
    Me.LayoutControlItem69.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem70
    '
    Me.LayoutControlItem70.Control = Me.eTxtBLReq
    Me.LayoutControlItem70.CustomizationFormText = "Tgl Req BL"
    Me.LayoutControlItem70.Location = New System.Drawing.Point(437, 48)
    Me.LayoutControlItem70.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem70.MinSize = New System.Drawing.Size(168, 24)
    Me.LayoutControlItem70.Name = "LayoutControlItem70"
    Me.LayoutControlItem70.Size = New System.Drawing.Size(315, 24)
    Me.LayoutControlItem70.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem70.Text = "Tgl Req BL"
    Me.LayoutControlItem70.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem71
    '
    Me.LayoutControlItem71.Control = Me.eTxtCOODraft
    Me.LayoutControlItem71.CustomizationFormText = "Tgl Draft COO"
    Me.LayoutControlItem71.Location = New System.Drawing.Point(437, 168)
    Me.LayoutControlItem71.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem71.MinSize = New System.Drawing.Size(168, 24)
    Me.LayoutControlItem71.Name = "LayoutControlItem71"
    Me.LayoutControlItem71.Size = New System.Drawing.Size(315, 24)
    Me.LayoutControlItem71.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem71.Text = "Tgl Draft COO"
    Me.LayoutControlItem71.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem72
    '
    Me.LayoutControlItem72.Control = Me.eTxtAsuransiReq
    Me.LayoutControlItem72.CustomizationFormText = "Tgl Req Asuransi"
    Me.LayoutControlItem72.Location = New System.Drawing.Point(437, 120)
    Me.LayoutControlItem72.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem72.MinSize = New System.Drawing.Size(168, 24)
    Me.LayoutControlItem72.Name = "LayoutControlItem72"
    Me.LayoutControlItem72.Size = New System.Drawing.Size(315, 24)
    Me.LayoutControlItem72.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem72.Text = "Tgl Req Asuransi"
    Me.LayoutControlItem72.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem73
    '
    Me.LayoutControlItem73.Control = Me.eTxtBLSurender
    Me.LayoutControlItem73.CustomizationFormText = "BL Surender Ori"
    Me.LayoutControlItem73.Location = New System.Drawing.Point(437, 96)
    Me.LayoutControlItem73.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem73.MinSize = New System.Drawing.Size(168, 24)
    Me.LayoutControlItem73.Name = "LayoutControlItem73"
    Me.LayoutControlItem73.Size = New System.Drawing.Size(315, 24)
    Me.LayoutControlItem73.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem73.Text = "BL Surender Ori"
    Me.LayoutControlItem73.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem74
    '
    Me.LayoutControlItem74.Control = Me.eTxtAsuransiTerima
    Me.LayoutControlItem74.CustomizationFormText = "Tgl Terima Asuransi"
    Me.LayoutControlItem74.Location = New System.Drawing.Point(437, 144)
    Me.LayoutControlItem74.MaxSize = New System.Drawing.Size(0, 24)
    Me.LayoutControlItem74.MinSize = New System.Drawing.Size(168, 24)
    Me.LayoutControlItem74.Name = "LayoutControlItem74"
    Me.LayoutControlItem74.Size = New System.Drawing.Size(315, 24)
    Me.LayoutControlItem74.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem74.Text = "Tgl Terima Asuransi"
    Me.LayoutControlItem74.TextSize = New System.Drawing.Size(111, 13)
    '
    'EmptySpaceItem20
    '
    Me.EmptySpaceItem20.AllowHotTrack = False
    Me.EmptySpaceItem20.CustomizationFormText = "EmptySpaceItem20"
    Me.EmptySpaceItem20.Location = New System.Drawing.Point(752, 0)
    Me.EmptySpaceItem20.Name = "EmptySpaceItem20"
    Me.EmptySpaceItem20.Size = New System.Drawing.Size(11, 219)
    Me.EmptySpaceItem20.Text = "EmptySpaceItem20"
    Me.EmptySpaceItem20.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem75
    '
    Me.LayoutControlItem75.Control = Me.eTxtCOOPersetujuan
    Me.LayoutControlItem75.CustomizationFormText = "Tgl Persetujuan COO"
    Me.LayoutControlItem75.Location = New System.Drawing.Point(763, 0)
    Me.LayoutControlItem75.Name = "LayoutControlItem75"
    Me.LayoutControlItem75.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem75.Text = "Tgl Persetujuan COO"
    Me.LayoutControlItem75.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem76
    '
    Me.LayoutControlItem76.Control = Me.eTxtPOLPOD
    Me.LayoutControlItem76.CustomizationFormText = "POL/POD"
    Me.LayoutControlItem76.Location = New System.Drawing.Point(763, 24)
    Me.LayoutControlItem76.Name = "LayoutControlItem76"
    Me.LayoutControlItem76.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem76.Text = "POL/POD"
    Me.LayoutControlItem76.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem77
    '
    Me.LayoutControlItem77.Control = Me.eTxtMBL
    Me.LayoutControlItem77.CustomizationFormText = "No. MBL"
    Me.LayoutControlItem77.Location = New System.Drawing.Point(763, 48)
    Me.LayoutControlItem77.Name = "LayoutControlItem77"
    Me.LayoutControlItem77.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem77.Text = "No. MBL"
    Me.LayoutControlItem77.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem78
    '
    Me.LayoutControlItem78.Control = Me.eTxtPabean
    Me.LayoutControlItem78.CustomizationFormText = "No. Pabean"
    Me.LayoutControlItem78.Location = New System.Drawing.Point(763, 72)
    Me.LayoutControlItem78.Name = "LayoutControlItem78"
    Me.LayoutControlItem78.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem78.Text = "No. Pabean"
    Me.LayoutControlItem78.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem79
    '
    Me.LayoutControlItem79.Control = Me.eTxtAju
    Me.LayoutControlItem79.CustomizationFormText = "Tgl Aju"
    Me.LayoutControlItem79.Location = New System.Drawing.Point(763, 96)
    Me.LayoutControlItem79.Name = "LayoutControlItem79"
    Me.LayoutControlItem79.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem79.Text = "Tgl Aju"
    Me.LayoutControlItem79.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem80
    '
    Me.LayoutControlItem80.Control = Me.eTxtTerimaOriginal
    Me.LayoutControlItem80.CustomizationFormText = "Terima Original"
    Me.LayoutControlItem80.Location = New System.Drawing.Point(763, 144)
    Me.LayoutControlItem80.Name = "LayoutControlItem80"
    Me.LayoutControlItem80.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem80.Text = "Terima Original"
    Me.LayoutControlItem80.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem66
    '
    Me.LayoutControlItem66.Control = Me.etxtNoAju
    Me.LayoutControlItem66.CustomizationFormText = "No Aju"
    Me.LayoutControlItem66.Location = New System.Drawing.Point(763, 120)
    Me.LayoutControlItem66.Name = "LayoutControlItem66"
    Me.LayoutControlItem66.Size = New System.Drawing.Size(311, 24)
    Me.LayoutControlItem66.Text = "No Aju"
    Me.LayoutControlItem66.TextSize = New System.Drawing.Size(111, 13)
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.xGrid
    Me.LayoutControlItem7.CustomizationFormText = "Detail"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(1074, 251)
    Me.LayoutControlItem7.Text = "Detail"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem7.TextToControlDistance = 0
    Me.LayoutControlItem7.TextVisible = False
    '
    'UI_zNishiOrderPenjualanDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1134, 468)
    Me.Controls.Add(Me.hideContainerRight)
    Me.KeyPreview = True
    Me.Name = "UI_zNishiOrderPenjualanDialog"
    Me.Text = "Job Order"
    Me.Controls.SetChildIndex(Me.hideContainerRight, 0)
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
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
    CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytTransaksi.ResumeLayout(False)
    CType(Me.eTxtDateOfRecord.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gridInvoice, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gridInvoiceView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtBillLading.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtVessel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtShipper.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtConsignee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtNW.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtMeass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtShipping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtInvoiceNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtPackingNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtParty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtGW.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtOther.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txteAmountInvoice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtJenisBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSatuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtBLNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtShipper.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtConsignee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtAJOU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtInvoiceNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtPListNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtNW.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtMeass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtParty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtGW.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtVessel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtOther.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxt20.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxt40.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtPOLPOD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtMBL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtPabean.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtBilling.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtBilling.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.etxtNoAju.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtNPE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtPEBNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtTujuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtPOLPOD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtMBL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtPabean.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTipeJO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colDivisiRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colProyekRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colHargaRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtETD.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtETD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtInvoiceTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtInvoiceTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtPackingTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtPackingTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtETA.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtETA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtBPN.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtBPN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtDO.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtDO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtDraftPIB.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtDraftPIB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtBL.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtBL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtOriginal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtOriginal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtCOO.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtCOO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtETA.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtETA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtPListTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtPListTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtInvoiceTgl.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtInvoiceTgl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtEmail.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtInsurance.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtInsurance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtPickup.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtPickup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtTglSI.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtTglSI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtTglRecTrucking.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtTglRecTrucking.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtBC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtBC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtSK.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtSK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtDocTagihan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtDocTagihan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtTglSuratTugas.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtTglSuratTugas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtCOOKomunikasi.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtCOOKomunikasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtCOODraft.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtCOODraft.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtAsuransiReq.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtAsuransiReq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtBLSurender.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtBLSurender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtAsuransiTerima.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtAsuransiTerima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtCOOPersetujuan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtCOOPersetujuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtAju.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtAju.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtTerimaOriginal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtTerimaOriginal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtPEBReq.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtPEBReq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtPEBTerima.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtPEBTerima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtBLReq.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtBLReq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtBLTerima.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.eTxtBLTerima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtSPPB.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtSPPB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtDOBayar.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtDOBayar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtDOAmbil.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtDOAmbil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtDelivery.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtDelivery.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtTagihan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtTagihan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtCOO.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtCOO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtTglAju.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtTglAju.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.itxtDOTerbit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem58, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.Document1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem22, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layKontak, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytItem, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytImpor, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytImporStatus, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytEkspor, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytEksporStatus, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem23, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem93, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem94, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem57, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem12, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem13, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem95, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem59, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem17, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem81, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem60, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem14, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem18, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem82, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem83, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem84, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem85, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem86, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem87, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem88, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem89, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem90, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem91, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem21, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem92, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem53, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem55, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem24, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem25, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem15, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem16, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem61, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem62, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem63, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem64, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem65, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem19, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem67, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem68, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem69, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem70, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem71, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem72, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem73, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem74, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem20, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem75, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem76, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem77, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem78, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem79, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem80, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem66, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents lytTransaksi As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents txtUraian As DevExpress.XtraEditors.TextEdit
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents btnRefreshNomor As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
  Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents xxHapus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents txtKontakPerson As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents colSatuanRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
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
  Friend WithEvents txtTipeJO As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents colDivisiRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtNoRef As DevExpress.XtraEditors.TextEdit
  Friend WithEvents colProyekRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents lblKontakNama As DevExpress.XtraEditors.LabelControl
  Friend WithEvents colHargaRepo As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
  Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKodeBarangRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
  Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents itxtParty As DevExpress.XtraEditors.TextEdit
  Friend WithEvents itxtMeass As DevExpress.XtraEditors.TextEdit
  Friend WithEvents itxtNW As DevExpress.XtraEditors.TextEdit
  Friend WithEvents itxtVessel As DevExpress.XtraEditors.TextEdit
  Friend WithEvents itxtPListNo As DevExpress.XtraEditors.TextEdit
  Friend WithEvents itxtInvoiceNo As DevExpress.XtraEditors.TextEdit
  Friend WithEvents itxtAJOU As DevExpress.XtraEditors.TextEdit
  Friend WithEvents itxtConsignee As DevExpress.XtraEditors.TextEdit
  Friend WithEvents itxtShipper As DevExpress.XtraEditors.TextEdit
  Friend WithEvents itxtBLNo As DevExpress.XtraEditors.TextEdit
  Friend WithEvents eTxtNPE As DevExpress.XtraEditors.TextEdit
  Friend WithEvents eTxtShipping As DevExpress.XtraEditors.TextEdit
  Friend WithEvents eTxtDateOfRecord As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents eTxtPEBNo As DevExpress.XtraEditors.TextEdit
  Friend WithEvents eTxtParty As DevExpress.XtraEditors.TextEdit
  Friend WithEvents eTxtMeass As DevExpress.XtraEditors.TextEdit
  Friend WithEvents eTxtNW As DevExpress.XtraEditors.TextEdit
  Friend WithEvents eTxtPackingNo As DevExpress.XtraEditors.TextEdit
  Friend WithEvents eTxtInvoiceNo As DevExpress.XtraEditors.TextEdit
  Friend WithEvents eTxtConsignee As DevExpress.XtraEditors.TextEdit
  Friend WithEvents eTxtShipper As DevExpress.XtraEditors.TextEdit
  Friend WithEvents eTxtVessel As DevExpress.XtraEditors.TextEdit
  Friend WithEvents eTxtBillLading As DevExpress.XtraEditors.TextEdit
  Friend WithEvents eTxtGW As DevExpress.XtraEditors.TextEdit
  Friend WithEvents itxtGW As DevExpress.XtraEditors.TextEdit
  Friend WithEvents itxtETA As DevExpress.XtraEditors.DateEdit
  Friend WithEvents itxtInvoiceTgl As DevExpress.XtraEditors.DateEdit
  Friend WithEvents itxtPListTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtOther As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents itxtOther As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents eTxtETD As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtETA As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtInvoiceTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtPackingTanggal As DevExpress.XtraEditors.DateEdit
  Friend itxtEmail As DevExpress.XtraEditors.DateEdit
  Friend itxtDO As DevExpress.XtraEditors.DateEdit
  Friend itxtDraftPIB As DevExpress.XtraEditors.DateEdit
  Friend itxtOriginal As DevExpress.XtraEditors.DateEdit
  Friend itxtBPN As DevExpress.XtraEditors.DateEdit
  Friend eTxtCOO As DevExpress.XtraEditors.DateEdit
  Friend eTxtInsurance As DevExpress.XtraEditors.DateEdit
  Friend eTxtPickup As DevExpress.XtraEditors.DateEdit
  Friend WithEvents itxt40 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents itxt20 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents eTxtTujuan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents itxtBL As DevExpress.XtraEditors.DateEdit
  Friend WithEvents itxtBC As DevExpress.XtraEditors.DateEdit
  Friend WithEvents itxtSK As DevExpress.XtraEditors.DateEdit
  Friend WithEvents itxtDocTagihan As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtTglSI As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtTglRecTrucking As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtTglSuratTugas As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtPabean As DevExpress.XtraEditors.TextEdit
  Friend WithEvents eTxtMBL As DevExpress.XtraEditors.TextEdit
  Friend WithEvents eTxtPOLPOD As DevExpress.XtraEditors.TextEdit
  Friend WithEvents eTxtCOOPersetujuan As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtAju As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtTerimaOriginal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtCOOKomunikasi As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtCOODraft As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtAsuransiTerima As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtAsuransiReq As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtBLSurender As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtPEBReq As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtPEBTerima As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtBLReq As DevExpress.XtraEditors.DateEdit
  Friend WithEvents eTxtBLTerima As DevExpress.XtraEditors.DateEdit
  Friend WithEvents itxtPabean As DevExpress.XtraEditors.TextEdit
  Friend WithEvents itxtMBL As DevExpress.XtraEditors.TextEdit
  Friend WithEvents itxtPOLPOD As DevExpress.XtraEditors.TextEdit
  Friend WithEvents itxtSPPB As DevExpress.XtraEditors.DateEdit
  Friend WithEvents itxtDOBayar As DevExpress.XtraEditors.DateEdit
  Friend WithEvents itxtDOAmbil As DevExpress.XtraEditors.DateEdit
  Friend WithEvents itxtDelivery As DevExpress.XtraEditors.DateEdit
  Friend WithEvents itxtTagihan As DevExpress.XtraEditors.DateEdit
  Friend WithEvents itxtCOO As DevExpress.XtraEditors.DateEdit
  Friend WithEvents itxtTglAju As DevExpress.XtraEditors.DateEdit
  Friend WithEvents etxtNoAju As DevExpress.XtraEditors.TextEdit
  Friend WithEvents itxtBilling As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtJenisBarang As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtSatuan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem58 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents itxtDOTerbit As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txteAmountInvoice As DevExpress.XtraEditors.TextEdit
  Friend WithEvents gridInvoice As DevExpress.XtraGrid.GridControl
  Friend WithEvents gridInvoiceView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents layKontak As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytRegional As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
  Friend WithEvents lytItem As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem23 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem93 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem94 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytImpor As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem57 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem12 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem13 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem95 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem59 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytImporStatus As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem17 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem81 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem60 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem14 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem18 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem82 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem83 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem84 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem85 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem86 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem87 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem88 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem89 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem90 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem91 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem21 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem92 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytEkspor As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem46 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem10 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem11 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem47 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem53 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem54 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem55 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem56 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem52 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem24 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem25 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents lytEksporStatus As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem49 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem51 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem15 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem50 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem48 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem16 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem61 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem62 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem63 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem64 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem65 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem19 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem67 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem68 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem69 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem70 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem71 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem72 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem73 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem74 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem20 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem75 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem76 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem77 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem78 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem79 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem80 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem66 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem22 As DevExpress.XtraLayout.EmptySpaceItem
End Class
