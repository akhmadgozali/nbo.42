﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohOrderPembelianDialog
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohOrderPembelianDialog))
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
    Me.txtHargaShipping = New DevExpress.XtraEditors.TextEdit()
    Me.txtGrandTotal = New DevExpress.XtraEditors.TextEdit()
    Me.txtShippingCost = New DevExpress.XtraEditors.TextEdit()
    Me.txtETA = New DevExpress.XtraEditors.DateEdit()
    Me.txtCustom5 = New DevExpress.XtraEditors.TextEdit()
    Me.txtCustom4 = New DevExpress.XtraEditors.TextEdit()
    Me.txtCustom3 = New DevExpress.XtraEditors.TextEdit()
    Me.txtCustom2 = New DevExpress.XtraEditors.TextEdit()
    Me.txtCustom1 = New DevExpress.XtraEditors.TextEdit()
    Me.lblKontakNama = New DevExpress.XtraEditors.LabelControl()
    Me.txtReffNo = New DevExpress.XtraEditors.TextEdit()
    Me.txtSubTotal = New DevExpress.XtraEditors.TextEdit()
    Me.txtPPH = New DevExpress.XtraEditors.TextEdit()
    Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
    Me.txtPPN = New DevExpress.XtraEditors.TextEdit()
    Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtPajak = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTermin = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtNoPenawaran = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtUang = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTglBerlaku = New DevExpress.XtraEditors.DateEdit()
    Me.txtLeadTime = New DevExpress.XtraEditors.TextEdit()
    Me.txtFOB = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtVia = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtGudang = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtKontakPerson = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.btnRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKodeBarangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
    Me.colKodeBarangRepoGrid = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcCustom1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcCustom2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcCustom3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcCustom4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colOD = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colT = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colL = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSatuanRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colWeight = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWeightM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHargaRepo = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
    Me.colHargaKg = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPPN = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPPNRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colPPH = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPPHRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colPajakInV = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPajakOutV = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKuotaImpor = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKuotaImporRepo2 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
    Me.colKuotaImporRepoViews = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSisaVolume = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colShipping = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKuotaImporRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
    Me.txtCatatan = New DevExpress.XtraEditors.MemoExEdit()
    Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtKaryawan = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtDomestik = New DevExpress.XtraEditors.CheckEdit()
    Me.txtMaker = New DevExpress.XtraEditors.MemoEdit()
    Me.txtETD = New DevExpress.XtraEditors.TextEdit()
    Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.layKontak = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytRegional = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.FOB = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.item2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
    Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
    Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
    Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
    Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
    Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
    Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
    Me.btnAmbilPermintaan = New DevExpress.XtraBars.BarButtonItem()
    Me.btnImpor = New DevExpress.XtraBars.BarButtonItem()
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
    CType(Me.txtHargaShipping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtGrandTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtShippingCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtETA.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtETA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCustom5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCustom4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCustom3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCustom2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCustom1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtReffNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPPH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPPN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPajak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTermin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoPenawaran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglBerlaku.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglBerlaku.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtLeadTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtFOB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtVia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKodeBarangRepoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colHargaRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colPPNRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colPPHRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKuotaImporRepo2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKuotaImporRepoViews, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKuotaImporRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKaryawan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDomestik.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMaker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtETD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.layKontak, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.FOB, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.item2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarStaticItem2, Me.btnRefresh, Me.btnAmbilPermintaan, Me.btnImpor})
    Me.barMan.MaxItemId = 11
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnRefresh, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAmbilPermintaan, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnImpor, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2)})
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
    Me.lytTransaksi.Controls.Add(Me.txtHargaShipping)
    Me.lytTransaksi.Controls.Add(Me.txtGrandTotal)
    Me.lytTransaksi.Controls.Add(Me.txtShippingCost)
    Me.lytTransaksi.Controls.Add(Me.txtETA)
    Me.lytTransaksi.Controls.Add(Me.txtCustom5)
    Me.lytTransaksi.Controls.Add(Me.txtCustom4)
    Me.lytTransaksi.Controls.Add(Me.txtCustom3)
    Me.lytTransaksi.Controls.Add(Me.txtCustom2)
    Me.lytTransaksi.Controls.Add(Me.txtCustom1)
    Me.lytTransaksi.Controls.Add(Me.lblKontakNama)
    Me.lytTransaksi.Controls.Add(Me.txtReffNo)
    Me.lytTransaksi.Controls.Add(Me.txtSubTotal)
    Me.lytTransaksi.Controls.Add(Me.txtPPH)
    Me.lytTransaksi.Controls.Add(Me.txtTotal)
    Me.lytTransaksi.Controls.Add(Me.txtPPN)
    Me.lytTransaksi.Controls.Add(Me.txtStatus)
    Me.lytTransaksi.Controls.Add(Me.txtPajak)
    Me.lytTransaksi.Controls.Add(Me.txtTermin)
    Me.lytTransaksi.Controls.Add(Me.txtNoPenawaran)
    Me.lytTransaksi.Controls.Add(Me.txtUang)
    Me.lytTransaksi.Controls.Add(Me.txtTglBerlaku)
    Me.lytTransaksi.Controls.Add(Me.txtLeadTime)
    Me.lytTransaksi.Controls.Add(Me.txtFOB)
    Me.lytTransaksi.Controls.Add(Me.txtVia)
    Me.lytTransaksi.Controls.Add(Me.txtGudang)
    Me.lytTransaksi.Controls.Add(Me.txtKontakPerson)
    Me.lytTransaksi.Controls.Add(Me.txtRegional)
    Me.lytTransaksi.Controls.Add(Me.txtTanggal)
    Me.lytTransaksi.Controls.Add(Me.btnRefreshNomor)
    Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
    Me.lytTransaksi.Controls.Add(Me.xGrid)
    Me.lytTransaksi.Controls.Add(Me.txtUraian)
    Me.lytTransaksi.Controls.Add(Me.txtCatatan)
    Me.lytTransaksi.Controls.Add(Me.txtKontak)
    Me.lytTransaksi.Controls.Add(Me.txtKaryawan)
    Me.lytTransaksi.Controls.Add(Me.txtDomestik)
    Me.lytTransaksi.Controls.Add(Me.txtMaker)
    Me.lytTransaksi.Controls.Add(Me.txtETD)
    Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytTransaksi.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem28, Me.LayoutControlItem27, Me.LayoutControlItem29})
    Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
    Me.lytTransaksi.Name = "lytTransaksi"
    Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(87, 270, 250, 350)
    Me.lytTransaksi.Root = Me.LayoutControlGroup1
    Me.lytTransaksi.Size = New System.Drawing.Size(1128, 435)
    Me.lytTransaksi.TabIndex = 0
    Me.lytTransaksi.Text = "LayoutControl1"
    '
    'txtHargaShipping
    '
    Me.txtHargaShipping.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtHargaShipping.Location = New System.Drawing.Point(373, 307)
    Me.txtHargaShipping.MenuManager = Me.barMan
    Me.txtHargaShipping.Name = "txtHargaShipping"
    Me.txtHargaShipping.Properties.Appearance.Options.UseTextOptions = True
    Me.txtHargaShipping.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtHargaShipping.Properties.Mask.EditMask = "n"
    Me.txtHargaShipping.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtHargaShipping.Size = New System.Drawing.Size(171, 20)
    Me.txtHargaShipping.StyleController = Me.lytTransaksi
    Me.txtHargaShipping.TabIndex = 21
    '
    'txtGrandTotal
    '
    Me.txtGrandTotal.Location = New System.Drawing.Point(948, 343)
    Me.txtGrandTotal.MenuManager = Me.barMan
    Me.txtGrandTotal.Name = "txtGrandTotal"
    Me.txtGrandTotal.Properties.Appearance.Options.UseTextOptions = True
    Me.txtGrandTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtGrandTotal.Properties.DisplayFormat.FormatString = "n2"
    Me.txtGrandTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtGrandTotal.Size = New System.Drawing.Size(146, 20)
    Me.txtGrandTotal.StyleController = Me.lytTransaksi
    Me.txtGrandTotal.TabIndex = 27
    '
    'txtShippingCost
    '
    Me.txtShippingCost.Location = New System.Drawing.Point(948, 319)
    Me.txtShippingCost.MenuManager = Me.barMan
    Me.txtShippingCost.Name = "txtShippingCost"
    Me.txtShippingCost.Properties.Appearance.Options.UseTextOptions = True
    Me.txtShippingCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtShippingCost.Properties.DisplayFormat.FormatString = "n2"
    Me.txtShippingCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.txtShippingCost.Size = New System.Drawing.Size(146, 20)
    Me.txtShippingCost.StyleController = Me.lytTransaksi
    Me.txtShippingCost.TabIndex = 26
    '
    'txtETA
    '
    Me.txtETA.EditValue = Nothing
    Me.txtETA.Location = New System.Drawing.Point(56, 331)
    Me.txtETA.MenuManager = Me.barMan
    Me.txtETA.Name = "txtETA"
    Me.txtETA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtETA.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtETA.Size = New System.Drawing.Size(238, 20)
    Me.txtETA.StyleController = Me.lytTransaksi
    Me.txtETA.TabIndex = 28
    '
    'txtCustom5
    '
    Me.txtCustom5.Location = New System.Drawing.Point(87, 331)
    Me.txtCustom5.MenuManager = Me.barMan
    Me.txtCustom5.Name = "txtCustom5"
    Me.txtCustom5.Size = New System.Drawing.Size(281, 20)
    Me.txtCustom5.StyleController = Me.lytTransaksi
    Me.txtCustom5.TabIndex = 30
    '
    'txtCustom4
    '
    Me.txtCustom4.Location = New System.Drawing.Point(87, 307)
    Me.txtCustom4.MenuManager = Me.barMan
    Me.txtCustom4.Name = "txtCustom4"
    Me.txtCustom4.Size = New System.Drawing.Size(281, 20)
    Me.txtCustom4.StyleController = Me.lytTransaksi
    Me.txtCustom4.TabIndex = 29
    '
    'txtCustom3
    '
    Me.txtCustom3.Location = New System.Drawing.Point(87, 307)
    Me.txtCustom3.MenuManager = Me.barMan
    Me.txtCustom3.Name = "txtCustom3"
    Me.txtCustom3.Size = New System.Drawing.Size(281, 20)
    Me.txtCustom3.StyleController = Me.lytTransaksi
    Me.txtCustom3.TabIndex = 28
    '
    'txtCustom2
    '
    Me.txtCustom2.Location = New System.Drawing.Point(87, 307)
    Me.txtCustom2.MenuManager = Me.barMan
    Me.txtCustom2.Name = "txtCustom2"
    Me.txtCustom2.Size = New System.Drawing.Size(281, 20)
    Me.txtCustom2.StyleController = Me.lytTransaksi
    Me.txtCustom2.TabIndex = 27
    '
    'txtCustom1
    '
    Me.txtCustom1.Location = New System.Drawing.Point(87, 307)
    Me.txtCustom1.MenuManager = Me.barMan
    Me.txtCustom1.Name = "txtCustom1"
    Me.txtCustom1.Size = New System.Drawing.Size(281, 20)
    Me.txtCustom1.StyleController = Me.lytTransaksi
    Me.txtCustom1.TabIndex = 26
    '
    'lblKontakNama
    '
    Me.lblKontakNama.Location = New System.Drawing.Point(255, 37)
    Me.lblKontakNama.Name = "lblKontakNama"
    Me.lblKontakNama.Size = New System.Drawing.Size(210, 20)
    Me.lblKontakNama.StyleController = Me.lytTransaksi
    Me.lblKontakNama.TabIndex = 25
    '
    'txtReffNo
    '
    Me.txtReffNo.Location = New System.Drawing.Point(107, 155)
    Me.txtReffNo.MenuManager = Me.barMan
    Me.txtReffNo.Name = "txtReffNo"
    Me.txtReffNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtReffNo.Size = New System.Drawing.Size(143, 20)
    Me.txtReffNo.StyleController = Me.lytTransaksi
    Me.txtReffNo.TabIndex = 17
    '
    'txtSubTotal
    '
    Me.txtSubTotal.Location = New System.Drawing.Point(750, 319)
    Me.txtSubTotal.MenuManager = Me.barMan
    Me.txtSubTotal.Name = "txtSubTotal"
    Me.txtSubTotal.Properties.Appearance.Options.UseTextOptions = True
    Me.txtSubTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtSubTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
    Me.txtSubTotal.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
    Me.txtSubTotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
    Me.txtSubTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtSubTotal.Properties.Mask.EditMask = "n2"
    Me.txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtSubTotal.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtSubTotal.Properties.ReadOnly = True
    Me.txtSubTotal.Size = New System.Drawing.Size(95, 20)
    Me.txtSubTotal.StyleController = Me.lytTransaksi
    Me.txtSubTotal.TabIndex = 22
    '
    'txtPPH
    '
    Me.txtPPH.Location = New System.Drawing.Point(750, 367)
    Me.txtPPH.MenuManager = Me.barMan
    Me.txtPPH.Name = "txtPPH"
    Me.txtPPH.Properties.Appearance.Options.UseTextOptions = True
    Me.txtPPH.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtPPH.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
    Me.txtPPH.Properties.AppearanceReadOnly.Options.UseBackColor = True
    Me.txtPPH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtPPH.Properties.Mask.EditMask = "n2"
    Me.txtPPH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtPPH.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtPPH.Properties.ReadOnly = True
    Me.txtPPH.Size = New System.Drawing.Size(95, 20)
    Me.txtPPH.StyleController = Me.lytTransaksi
    Me.txtPPH.TabIndex = 24
    '
    'txtTotal
    '
    Me.txtTotal.Location = New System.Drawing.Point(750, 391)
    Me.txtTotal.MenuManager = Me.barMan
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
    Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
    Me.txtTotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
    Me.txtTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTotal.Properties.Mask.EditMask = "n2"
    Me.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtTotal.Properties.ReadOnly = True
    Me.txtTotal.Size = New System.Drawing.Size(95, 20)
    Me.txtTotal.StyleController = Me.lytTransaksi
    Me.txtTotal.TabIndex = 25
    '
    'txtPPN
    '
    Me.txtPPN.Location = New System.Drawing.Point(750, 343)
    Me.txtPPN.MenuManager = Me.barMan
    Me.txtPPN.Name = "txtPPN"
    Me.txtPPN.Properties.Appearance.Options.UseTextOptions = True
    Me.txtPPN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtPPN.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
    Me.txtPPN.Properties.AppearanceReadOnly.Options.UseBackColor = True
    Me.txtPPN.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtPPN.Properties.Mask.EditMask = "n2"
    Me.txtPPN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtPPN.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtPPN.Properties.ReadOnly = True
    Me.txtPPN.Size = New System.Drawing.Size(95, 20)
    Me.txtPPN.StyleController = Me.lytTransaksi
    Me.txtPPN.TabIndex = 23
    '
    'txtStatus
    '
    Me.txtStatus.Location = New System.Drawing.Point(952, 61)
    Me.txtStatus.MenuManager = Me.barMan
    Me.txtStatus.Name = "txtStatus"
    Me.txtStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
    Me.txtStatus.Properties.DisplayMember = "Value"
    Me.txtStatus.Properties.NullText = "<Status>"
    Me.txtStatus.Properties.ValueMember = "Key"
    Me.txtStatus.Size = New System.Drawing.Size(118, 20)
    Me.txtStatus.StyleController = Me.lytTransaksi
    Me.txtStatus.TabIndex = 5
    '
    'txtPajak
    '
    Me.txtPajak.Location = New System.Drawing.Point(989, 107)
    Me.txtPajak.MenuManager = Me.barMan
    Me.txtPajak.Name = "txtPajak"
    Me.txtPajak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtPajak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPajak.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
    Me.txtPajak.Properties.DisplayMember = "Value"
    Me.txtPajak.Properties.NullText = "<Pilih Tipe Pajak>"
    Me.txtPajak.Properties.ValueMember = "Key"
    Me.txtPajak.Size = New System.Drawing.Size(117, 20)
    Me.txtPajak.StyleController = Me.lytTransaksi
    Me.txtPajak.TabIndex = 11
    '
    'txtTermin
    '
    Me.txtTermin.Location = New System.Drawing.Point(776, 131)
    Me.txtTermin.MenuManager = Me.barMan
    Me.txtTermin.Name = "txtTermin"
    Me.txtTermin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTermin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTermin.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.txtTermin.Properties.DisplayMember = "Kode"
    Me.txtTermin.Properties.NullText = "<Termin>"
    Me.txtTermin.Properties.ValueMember = "This"
    Me.txtTermin.Size = New System.Drawing.Size(119, 20)
    Me.txtTermin.StyleController = Me.lytTransaksi
    Me.txtTermin.TabIndex = 15
    '
    'txtNoPenawaran
    '
    Me.txtNoPenawaran.Location = New System.Drawing.Point(107, 107)
    Me.txtNoPenawaran.MenuManager = Me.barMan
    Me.txtNoPenawaran.Name = "txtNoPenawaran"
    Me.txtNoPenawaran.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNoPenawaran.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtNoPenawaran.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 90, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tanggal", "Tanggal", 70, DevExpress.Utils.FormatType.DateTime, "dd/MMM/yyyy", True, DevExpress.Utils.HorzAlignment.[Default])})
    Me.txtNoPenawaran.Properties.DisplayMember = "Kode"
    Me.txtNoPenawaran.Properties.NullText = "<Pilih NoPenawaran>"
    Me.txtNoPenawaran.Properties.PopupWidth = 300
    Me.txtNoPenawaran.Properties.ValueMember = "This"
    Me.txtNoPenawaran.Size = New System.Drawing.Size(143, 20)
    Me.txtNoPenawaran.StyleController = Me.lytTransaksi
    Me.txtNoPenawaran.TabIndex = 7
    '
    'txtUang
    '
    Me.txtUang.Location = New System.Drawing.Point(776, 107)
    Me.txtUang.MenuManager = Me.barMan
    Me.txtUang.Name = "txtUang"
    Me.txtUang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtUang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtUang.Properties.DisplayMember = "Kode"
    Me.txtUang.Properties.NullText = "<Uang>"
    Me.txtUang.Properties.ValueMember = "This"
    Me.txtUang.Size = New System.Drawing.Size(119, 20)
    Me.txtUang.StyleController = Me.lytTransaksi
    Me.txtUang.TabIndex = 10
    '
    'txtTglBerlaku
    '
    Me.txtTglBerlaku.EditValue = Nothing
    Me.txtTglBerlaku.Location = New System.Drawing.Point(601, 107)
    Me.txtTglBerlaku.MenuManager = Me.barMan
    Me.txtTglBerlaku.Name = "txtTglBerlaku"
    Me.txtTglBerlaku.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTglBerlaku.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglBerlaku.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglBerlaku.Size = New System.Drawing.Size(118, 20)
    Me.txtTglBerlaku.StyleController = Me.lytTransaksi
    Me.txtTglBerlaku.TabIndex = 9
    '
    'txtLeadTime
    '
    Me.txtLeadTime.Location = New System.Drawing.Point(601, 131)
    Me.txtLeadTime.MenuManager = Me.barMan
    Me.txtLeadTime.Name = "txtLeadTime"
    Me.txtLeadTime.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtLeadTime.Properties.NullText = "<Lead Time>"
    Me.txtLeadTime.Size = New System.Drawing.Size(118, 20)
    Me.txtLeadTime.StyleController = Me.lytTransaksi
    Me.txtLeadTime.TabIndex = 14
    '
    'txtFOB
    '
    Me.txtFOB.Location = New System.Drawing.Point(405, 131)
    Me.txtFOB.MenuManager = Me.barMan
    Me.txtFOB.Name = "txtFOB"
    Me.txtFOB.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtFOB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtFOB.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
    Me.txtFOB.Properties.DisplayMember = "Value"
    Me.txtFOB.Properties.NullText = "<Pilih FOB>"
    Me.txtFOB.Properties.ValueMember = "Key"
    Me.txtFOB.Size = New System.Drawing.Size(119, 20)
    Me.txtFOB.StyleController = Me.lytTransaksi
    Me.txtFOB.TabIndex = 13
    '
    'txtVia
    '
    Me.txtVia.Location = New System.Drawing.Point(405, 107)
    Me.txtVia.MenuManager = Me.barMan
    Me.txtVia.Name = "txtVia"
    Me.txtVia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtVia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtVia.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.txtVia.Properties.DisplayMember = "Kode"
    Me.txtVia.Properties.NullText = "<Pilih Via>"
    Me.txtVia.Properties.ValueMember = "This"
    Me.txtVia.Size = New System.Drawing.Size(119, 20)
    Me.txtVia.StyleController = Me.lytTransaksi
    Me.txtVia.TabIndex = 8
    '
    'txtGudang
    '
    Me.txtGudang.Location = New System.Drawing.Point(107, 131)
    Me.txtGudang.MenuManager = Me.barMan
    Me.txtGudang.Name = "txtGudang"
    Me.txtGudang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtGudang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtGudang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtGudang.Properties.DisplayMember = "Kode"
    Me.txtGudang.Properties.NullText = "<Pilih Gudang>"
    Me.txtGudang.Properties.ValueMember = "This"
    Me.txtGudang.Size = New System.Drawing.Size(143, 20)
    Me.txtGudang.StyleController = Me.lytTransaksi
    Me.txtGudang.TabIndex = 12
    '
    'txtKontakPerson
    '
    Me.txtKontakPerson.Location = New System.Drawing.Point(93, 62)
    Me.txtKontakPerson.MenuManager = Me.barMan
    Me.txtKontakPerson.Name = "txtKontakPerson"
    Me.txtKontakPerson.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKontakPerson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontakPerson.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtKontakPerson.Properties.DisplayMember = "Nama"
    Me.txtKontakPerson.Properties.NullText = "<Pilih Kontak Person>"
    Me.txtKontakPerson.Properties.ValueMember = "Nama"
    Me.txtKontakPerson.Size = New System.Drawing.Size(158, 20)
    Me.txtKontakPerson.StyleController = Me.lytTransaksi
    Me.txtKontakPerson.TabIndex = 6
    '
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(767, 61)
    Me.txtRegional.MenuManager = Me.barMan
    Me.txtRegional.Name = "txtRegional"
    Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
    Me.txtRegional.Properties.DisplayMember = "Nama"
    Me.txtRegional.Properties.NullText = "<Pilih Regional>"
    Me.txtRegional.Properties.ValueMember = "This"
    Me.txtRegional.Size = New System.Drawing.Size(118, 20)
    Me.txtRegional.StyleController = Me.lytTransaksi
    Me.txtRegional.TabIndex = 4
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(767, 37)
    Me.txtTanggal.MenuManager = Me.barMan
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
    Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTanggal.Size = New System.Drawing.Size(118, 20)
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
    Me.txtNoTransaksi.Location = New System.Drawing.Point(952, 37)
    Me.txtNoTransaksi.MenuManager = Me.barMan
    Me.txtNoTransaksi.Name = "txtNoTransaksi"
    Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNoTransaksi.Size = New System.Drawing.Size(118, 20)
    Me.txtNoTransaksi.StyleController = Me.lytTransaksi
    Me.txtNoTransaksi.TabIndex = 2
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(12, 179)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.MenuManager = Me.barMan
    Me.xGrid.Name = "xGrid"
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colSatuanRepo, Me.colKuotaImporRepo, Me.colHargaRepo, Me.colKodeBarangRepo, Me.colPPNRepo, Me.colPPHRepo, Me.colKuotaImporRepo2})
    Me.xGrid.Size = New System.Drawing.Size(1094, 124)
    Me.xGrid.TabIndex = 19
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeBarang, Me.colNamaBarang, Me.colOD, Me.colOid, Me.colT, Me.colL, Me.colQty, Me.colSatuan, Me.colWeight, Me.colWeightM, Me.colHarga, Me.colHargaKg, Me.colSubTotal, Me.colPPN, Me.colPPH, Me.colPajakInV, Me.colPajakOutV, Me.colTotal, Me.colCatatan, Me.colKuotaImpor, Me.colCustomer, Me.colShipping})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.NewItemRowText = "Tambah Data"
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
    Me.xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'colKodeBarang
    '
    Me.colKodeBarang.Caption = "Part No."
    Me.colKodeBarang.ColumnEdit = Me.colKodeBarangRepo
    Me.colKodeBarang.FieldName = "Barang!"
    Me.colKodeBarang.Name = "colKodeBarang"
    Me.colKodeBarang.Visible = True
    Me.colKodeBarang.VisibleIndex = 0
    Me.colKodeBarang.Width = 64
    '
    'colKodeBarangRepo
    '
    Me.colKodeBarangRepo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
    Me.colKodeBarangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colKodeBarangRepo.DisplayMember = "Kode"
    Me.colKodeBarangRepo.Name = "colKodeBarangRepo"
    Me.colKodeBarangRepo.NullText = "<Pilih Part No>"
    Me.colKodeBarangRepo.ShowClearButton = False
    Me.colKodeBarangRepo.ShowFooter = False
    Me.colKodeBarangRepo.ValueMember = "This"
    Me.colKodeBarangRepo.View = Me.colKodeBarangRepoGrid
    '
    'colKodeBarangRepoGrid
    '
    Me.colKodeBarangRepoGrid.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcKode, Me.gcNama, Me.gcSatuan, Me.gcCustom1, Me.gcCustom2, Me.gcCustom3, Me.gcCustom4})
    Me.colKodeBarangRepoGrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.colKodeBarangRepoGrid.Name = "colKodeBarangRepoGrid"
    Me.colKodeBarangRepoGrid.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.colKodeBarangRepoGrid.OptionsView.ShowAutoFilterRow = True
    Me.colKodeBarangRepoGrid.OptionsView.ShowGroupPanel = False
    '
    'gcKode
    '
    Me.gcKode.Caption = "Kode"
    Me.gcKode.FieldName = "Kode"
    Me.gcKode.Name = "gcKode"
    Me.gcKode.Visible = True
    Me.gcKode.VisibleIndex = 0
    Me.gcKode.Width = 250
    '
    'gcNama
    '
    Me.gcNama.Caption = "Nama"
    Me.gcNama.FieldName = "Nama"
    Me.gcNama.Name = "gcNama"
    Me.gcNama.Visible = True
    Me.gcNama.VisibleIndex = 1
    Me.gcNama.Width = 300
    '
    'gcSatuan
    '
    Me.gcSatuan.Caption = "Satuan"
    Me.gcSatuan.FieldName = "Satuan.Nama"
    Me.gcSatuan.Name = "gcSatuan"
    Me.gcSatuan.Visible = True
    Me.gcSatuan.VisibleIndex = 2
    Me.gcSatuan.Width = 20
    '
    'gcCustom1
    '
    Me.gcCustom1.Caption = "Out"
    Me.gcCustom1.FieldName = "OutDiameter"
    Me.gcCustom1.Name = "gcCustom1"
    Me.gcCustom1.Visible = True
    Me.gcCustom1.VisibleIndex = 3
    Me.gcCustom1.Width = 59
    '
    'gcCustom2
    '
    Me.gcCustom2.Caption = "IN"
    Me.gcCustom2.FieldName = "InDiameter"
    Me.gcCustom2.Name = "gcCustom2"
    Me.gcCustom2.Visible = True
    Me.gcCustom2.VisibleIndex = 4
    Me.gcCustom2.Width = 59
    '
    'gcCustom3
    '
    Me.gcCustom3.Caption = "Length"
    Me.gcCustom3.FieldName = "Length"
    Me.gcCustom3.Name = "gcCustom3"
    Me.gcCustom3.Visible = True
    Me.gcCustom3.VisibleIndex = 5
    Me.gcCustom3.Width = 59
    '
    'gcCustom4
    '
    Me.gcCustom4.Caption = "Thicknes"
    Me.gcCustom4.FieldName = "Thickness"
    Me.gcCustom4.Name = "gcCustom4"
    Me.gcCustom4.Visible = True
    Me.gcCustom4.VisibleIndex = 6
    Me.gcCustom4.Width = 59
    '
    'colNamaBarang
    '
    Me.colNamaBarang.Caption = "Material"
    Me.colNamaBarang.FieldName = "Barang.Nama"
    Me.colNamaBarang.Name = "colNamaBarang"
    Me.colNamaBarang.OptionsColumn.AllowEdit = False
    Me.colNamaBarang.OptionsColumn.ReadOnly = True
    Me.colNamaBarang.Visible = True
    Me.colNamaBarang.VisibleIndex = 1
    Me.colNamaBarang.Width = 96
    '
    'colOD
    '
    Me.colOD.Caption = "OD"
    Me.colOD.DisplayFormat.FormatString = "n2"
    Me.colOD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colOD.FieldName = "OutDiameter"
    Me.colOD.Name = "colOD"
    Me.colOD.OptionsColumn.AllowEdit = False
    Me.colOD.OptionsColumn.ReadOnly = True
    Me.colOD.Visible = True
    Me.colOD.VisibleIndex = 2
    Me.colOD.Width = 31
    '
    'colOid
    '
    Me.colOid.Caption = "ID"
    Me.colOid.DisplayFormat.FormatString = "n2"
    Me.colOid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colOid.FieldName = "InDiameter"
    Me.colOid.Name = "colOid"
    Me.colOid.OptionsColumn.AllowEdit = False
    Me.colOid.OptionsColumn.ReadOnly = True
    Me.colOid.Visible = True
    Me.colOid.VisibleIndex = 3
    Me.colOid.Width = 31
    '
    'colT
    '
    Me.colT.Caption = "T"
    Me.colT.DisplayFormat.FormatString = "n2"
    Me.colT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colT.FieldName = "Thickness"
    Me.colT.Name = "colT"
    Me.colT.OptionsColumn.AllowEdit = False
    Me.colT.OptionsColumn.ReadOnly = True
    Me.colT.Visible = True
    Me.colT.VisibleIndex = 4
    Me.colT.Width = 31
    '
    'colL
    '
    Me.colL.Caption = "L"
    Me.colL.DisplayFormat.FormatString = "n2"
    Me.colL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colL.FieldName = "Length"
    Me.colL.Name = "colL"
    Me.colL.Visible = True
    Me.colL.VisibleIndex = 5
    Me.colL.Width = 31
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
    Me.colQty.VisibleIndex = 6
    Me.colQty.Width = 50
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
    Me.colSatuan.VisibleIndex = 7
    Me.colSatuan.Width = 39
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
    'colWeight
    '
    Me.colWeight.Caption = "Weight"
    Me.colWeight.DisplayFormat.FormatString = "n2"
    Me.colWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colWeight.FieldName = "Weight"
    Me.colWeight.Name = "colWeight"
    Me.colWeight.OptionsColumn.AllowEdit = False
    Me.colWeight.OptionsColumn.ReadOnly = True
    Me.colWeight.Visible = True
    Me.colWeight.VisibleIndex = 8
    Me.colWeight.Width = 38
    '
    'colWeightM
    '
    Me.colWeightM.Caption = "Weight M"
    Me.colWeightM.FieldName = "WeightManual"
    Me.colWeightM.Name = "colWeightM"
    Me.colWeightM.Visible = True
    Me.colWeightM.VisibleIndex = 9
    Me.colWeightM.Width = 47
    '
    'colHarga
    '
    Me.colHarga.Caption = "Harga"
    Me.colHarga.ColumnEdit = Me.colHargaRepo
    Me.colHarga.FieldName = "Harga"
    Me.colHarga.Name = "colHarga"
    Me.colHarga.Visible = True
    Me.colHarga.VisibleIndex = 10
    Me.colHarga.Width = 56
    '
    'colHargaRepo
    '
    Me.colHargaRepo.AutoHeight = False
    Me.colHargaRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colHargaRepo.Name = "colHargaRepo"
    '
    'colHargaKg
    '
    Me.colHargaKg.Caption = "Harga KG"
    Me.colHargaKg.ColumnEdit = Me.colHargaRepo
    Me.colHargaKg.FieldName = "HargaPerKg"
    Me.colHargaKg.Name = "colHargaKg"
    Me.colHargaKg.Visible = True
    Me.colHargaKg.VisibleIndex = 11
    Me.colHargaKg.Width = 65
    '
    'colSubTotal
    '
    Me.colSubTotal.Caption = "Sub Total"
    Me.colSubTotal.FieldName = "SubTotal"
    Me.colSubTotal.Name = "colSubTotal"
    Me.colSubTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    '
    'colPPN
    '
    Me.colPPN.Caption = "Pajak IN"
    Me.colPPN.ColumnEdit = Me.colPPNRepo
    Me.colPPN.FieldName = "PPN!"
    Me.colPPN.Name = "colPPN"
    Me.colPPN.Visible = True
    Me.colPPN.VisibleIndex = 12
    Me.colPPN.Width = 45
    '
    'colPPNRepo
    '
    Me.colPPNRepo.AutoHeight = False
    Me.colPPNRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colPPNRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.colPPNRepo.DisplayMember = "Kode"
    Me.colPPNRepo.Name = "colPPNRepo"
    Me.colPPNRepo.NullText = "<Pilih Pajak>"
    Me.colPPNRepo.ValueMember = "This"
    '
    'colPPH
    '
    Me.colPPH.Caption = "Pajak Out"
    Me.colPPH.ColumnEdit = Me.colPPHRepo
    Me.colPPH.FieldName = "PPH!"
    Me.colPPH.Name = "colPPH"
    Me.colPPH.Visible = True
    Me.colPPH.VisibleIndex = 13
    Me.colPPH.Width = 46
    '
    'colPPHRepo
    '
    Me.colPPHRepo.AutoHeight = False
    Me.colPPHRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colPPHRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.colPPHRepo.DisplayMember = "Kode"
    Me.colPPHRepo.Name = "colPPHRepo"
    Me.colPPHRepo.NullText = "<Pilih Pajak>"
    Me.colPPHRepo.ValueMember = "This"
    '
    'colPajakInV
    '
    Me.colPajakInV.Caption = "Pajak IN"
    Me.colPajakInV.FieldName = "PPNv"
    Me.colPajakInV.Name = "colPajakInV"
    '
    'colPajakOutV
    '
    Me.colPajakOutV.Caption = "Pajak Out"
    Me.colPajakOutV.FieldName = "PPHv"
    Me.colPajakOutV.Name = "colPajakOutV"
    '
    'colTotal
    '
    Me.colTotal.Caption = "Total"
    Me.colTotal.FieldName = "Total"
    Me.colTotal.Name = "colTotal"
    Me.colTotal.OptionsColumn.AllowEdit = False
    Me.colTotal.OptionsColumn.ReadOnly = True
    Me.colTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colTotal.Visible = True
    Me.colTotal.VisibleIndex = 14
    Me.colTotal.Width = 53
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
    Me.colCatatan.VisibleIndex = 16
    Me.colCatatan.Width = 130
    '
    'colKuotaImpor
    '
    Me.colKuotaImpor.Caption = "Kuota Impor"
    Me.colKuotaImpor.ColumnEdit = Me.colKuotaImporRepo2
    Me.colKuotaImpor.FieldName = "KuotaImpor!"
    Me.colKuotaImpor.Name = "colKuotaImpor"
    Me.colKuotaImpor.Visible = True
    Me.colKuotaImpor.VisibleIndex = 17
    Me.colKuotaImpor.Width = 100
    '
    'colKuotaImporRepo2
    '
    Me.colKuotaImporRepo2.AutoHeight = False
    Me.colKuotaImporRepo2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
    Me.colKuotaImporRepo2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.colKuotaImporRepo2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colKuotaImporRepo2.DisplayMember = "KodeHS"
    Me.colKuotaImporRepo2.Name = "colKuotaImporRepo2"
    Me.colKuotaImporRepo2.NullText = "<Pilih Kuota Impor>"
    Me.colKuotaImporRepo2.ShowFooter = False
    Me.colKuotaImporRepo2.ValueMember = "This"
    Me.colKuotaImporRepo2.View = Me.colKuotaImporRepoViews
    '
    'colKuotaImporRepoViews
    '
    Me.colKuotaImporRepoViews.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.colSisaVolume, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
    Me.colKuotaImporRepoViews.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.colKuotaImporRepoViews.Name = "colKuotaImporRepoViews"
    Me.colKuotaImporRepoViews.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.colKuotaImporRepoViews.OptionsView.ShowGroupPanel = False
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Kode HS"
    Me.GridColumn3.FieldName = "KodeHS"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 0
    '
    'colSisaVolume
    '
    Me.colSisaVolume.Caption = "Sisa Volume"
    Me.colSisaVolume.FieldName = "SisaVolume"
    Me.colSisaVolume.Name = "colSisaVolume"
    Me.colSisaVolume.Visible = True
    Me.colSisaVolume.VisibleIndex = 1
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Expired"
    Me.GridColumn5.FieldName = "Expired"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 2
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "No Perijinan"
    Me.GridColumn6.FieldName = "NoPerijinan"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 3
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Tanggal Mulai"
    Me.GridColumn7.FieldName = "TanggalMulaiBerlaku"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 4
    '
    'GridColumn8
    '
    Me.GridColumn8.Caption = "Pelabuhan"
    Me.GridColumn8.FieldName = "Pelabuhan"
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 5
    '
    'colCustomer
    '
    Me.colCustomer.Caption = "Customer"
    Me.colCustomer.FieldName = "Barang.Customer.Nama"
    Me.colCustomer.Name = "colCustomer"
    Me.colCustomer.OptionsColumn.AllowEdit = False
    Me.colCustomer.OptionsColumn.ReadOnly = True
    Me.colCustomer.Visible = True
    Me.colCustomer.VisibleIndex = 18
    Me.colCustomer.Width = 133
    '
    'colShipping
    '
    Me.colShipping.Caption = "Shipping Cost"
    Me.colShipping.FieldName = "ShippingCost"
    Me.colShipping.Name = "colShipping"
    Me.colShipping.Visible = True
    Me.colShipping.VisibleIndex = 15
    '
    'colKuotaImporRepo
    '
    Me.colKuotaImporRepo.AutoHeight = False
    Me.colKuotaImporRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colKuotaImporRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KodeHS", "Kode HS"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SisaVolume", "Sisa Volume", 20, DevExpress.Utils.FormatType.Numeric, "n0", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Expired", "Expired", 20, DevExpress.Utils.FormatType.Custom, "dd-MMM-yy", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NoPerijinan", "No Perijinan"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TanggalMulaiBerlaku", "Tanggal Mulai", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Descending)})
    Me.colKuotaImporRepo.DisplayMember = "KodeHS"
    Me.colKuotaImporRepo.Name = "colKuotaImporRepo"
    Me.colKuotaImporRepo.NullText = "<Kuota Impor>"
    Me.colKuotaImporRepo.ValueMember = "This"
    '
    'txtUraian
    '
    Me.txtUraian.Location = New System.Drawing.Point(405, 155)
    Me.txtUraian.MenuManager = Me.barMan
    Me.txtUraian.Name = "txtUraian"
    Me.txtUraian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtUraian.Properties.MaxLength = 255
    Me.txtUraian.Size = New System.Drawing.Size(701, 20)
    Me.txtUraian.StyleController = Me.lytTransaksi
    Me.txtUraian.TabIndex = 18
    '
    'txtCatatan
    '
    Me.txtCatatan.Location = New System.Drawing.Point(56, 307)
    Me.txtCatatan.MenuManager = Me.barMan
    Me.txtCatatan.Name = "txtCatatan"
    Me.txtCatatan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtCatatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCatatan.Size = New System.Drawing.Size(238, 20)
    Me.txtCatatan.StyleController = Me.lytTransaksi
    Me.txtCatatan.TabIndex = 20
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(93, 37)
    Me.txtKontak.MenuManager = Me.barMan
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtKontak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontak.Properties.DisplayMember = "Kode"
    Me.txtKontak.Properties.NullText = "<Pilih Vendor>"
    Me.txtKontak.Properties.PopupFormSize = New System.Drawing.Size(330, 0)
    Me.txtKontak.Properties.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
    Me.txtKontak.Properties.ShowClearButton = False
    Me.txtKontak.Properties.ShowFooter = False
    Me.txtKontak.Properties.ValueMember = "This"
    Me.txtKontak.Properties.View = Me.SearchLookUpEdit1View
    Me.txtKontak.Size = New System.Drawing.Size(158, 20)
    Me.txtKontak.StyleController = Me.lytTransaksi
    Me.txtKontak.TabIndex = 0
    '
    'RepositoryItemCheckEdit1
    '
    Me.RepositoryItemCheckEdit1.AutoHeight = False
    Me.RepositoryItemCheckEdit1.Caption = "Check"
    Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
    '
    'SearchLookUpEdit1View
    '
    Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKontakKode, Me.colKontakNama, Me.GridColumn4})
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
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Domestik"
    Me.GridColumn4.ColumnEdit = Me.RepositoryItemCheckEdit1
    Me.GridColumn4.FieldName = "KontakDomestik"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 2
    '
    'txtKaryawan
    '
    Me.txtKaryawan.Location = New System.Drawing.Point(989, 131)
    Me.txtKaryawan.MenuManager = Me.barMan
    Me.txtKaryawan.Name = "txtKaryawan"
    Me.txtKaryawan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtKaryawan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKaryawan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKaryawan.Properties.DisplayMember = "Nama"
    Me.txtKaryawan.Properties.NullText = "<Pilih Karyawan>"
    Me.txtKaryawan.Properties.ShowClearButton = False
    Me.txtKaryawan.Properties.ShowFooter = False
    Me.txtKaryawan.Properties.ValueMember = "This"
    Me.txtKaryawan.Properties.View = Me.GridView1
    Me.txtKaryawan.Size = New System.Drawing.Size(117, 20)
    Me.txtKaryawan.StyleController = Me.lytTransaksi
    Me.txtKaryawan.TabIndex = 16
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
    Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsFind.FindDelay = 500
    Me.GridView1.OptionsFind.SearchInPreview = True
    Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView1.OptionsView.ShowGroupPanel = False
    Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Kode"
    Me.GridColumn1.FieldName = "Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    Me.GridColumn1.Width = 355
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Nama"
    Me.GridColumn2.FieldName = "Nama"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    Me.GridColumn2.Width = 723
    '
    'txtDomestik
    '
    Me.txtDomestik.EditValue = Nothing
    Me.txtDomestik.Location = New System.Drawing.Point(255, 61)
    Me.txtDomestik.MenuManager = Me.barMan
    Me.txtDomestik.Name = "txtDomestik"
    Me.txtDomestik.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtDomestik.Properties.Caption = "Dari Domestik"
    Me.txtDomestik.Size = New System.Drawing.Size(154, 21)
    Me.txtDomestik.StyleController = Me.lytTransaksi
    Me.txtDomestik.TabIndex = 4
    '
    'txtMaker
    '
    Me.txtMaker.Location = New System.Drawing.Point(56, 379)
    Me.txtMaker.MenuManager = Me.barMan
    Me.txtMaker.Name = "txtMaker"
    Me.txtMaker.Size = New System.Drawing.Size(238, 44)
    Me.txtMaker.StyleController = Me.lytTransaksi
    Me.txtMaker.TabIndex = 30
    '
    'txtETD
    '
    Me.txtETD.Location = New System.Drawing.Point(56, 355)
    Me.txtETD.MenuManager = Me.barMan
    Me.txtETD.Name = "txtETD"
    Me.txtETD.Size = New System.Drawing.Size(238, 20)
    Me.txtETD.StyleController = Me.lytTransaksi
    Me.txtETD.TabIndex = 29
    '
    'LayoutControlItem24
    '
    Me.LayoutControlItem24.Control = Me.txtCustom1
    Me.LayoutControlItem24.CustomizationFormText = "Custom1"
    Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 295)
    Me.LayoutControlItem24.Name = "LayoutControlItem24"
    Me.LayoutControlItem24.Size = New System.Drawing.Size(360, 24)
    Me.LayoutControlItem24.Text = "Custom1"
    Me.LayoutControlItem24.TextSize = New System.Drawing.Size(50, 20)
    Me.LayoutControlItem24.TextToControlDistance = 5
    '
    'LayoutControlItem25
    '
    Me.LayoutControlItem25.Control = Me.txtCustom2
    Me.LayoutControlItem25.CustomizationFormText = "Custom2"
    Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 295)
    Me.LayoutControlItem25.Name = "LayoutControlItem25"
    Me.LayoutControlItem25.Size = New System.Drawing.Size(360, 24)
    Me.LayoutControlItem25.Text = "Custom2"
    Me.LayoutControlItem25.TextSize = New System.Drawing.Size(50, 20)
    Me.LayoutControlItem25.TextToControlDistance = 5
    '
    'LayoutControlItem26
    '
    Me.LayoutControlItem26.Control = Me.txtCustom3
    Me.LayoutControlItem26.CustomizationFormText = "Custom3"
    Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 295)
    Me.LayoutControlItem26.Name = "LayoutControlItem26"
    Me.LayoutControlItem26.Size = New System.Drawing.Size(360, 24)
    Me.LayoutControlItem26.Text = "Custom3"
    Me.LayoutControlItem26.TextSize = New System.Drawing.Size(50, 20)
    Me.LayoutControlItem26.TextToControlDistance = 5
    '
    'LayoutControlItem28
    '
    Me.LayoutControlItem28.Control = Me.txtCustom5
    Me.LayoutControlItem28.CustomizationFormText = "Custom5"
    Me.LayoutControlItem28.Location = New System.Drawing.Point(0, 319)
    Me.LayoutControlItem28.Name = "LayoutControlItem28"
    Me.LayoutControlItem28.Size = New System.Drawing.Size(360, 24)
    Me.LayoutControlItem28.Text = "Custom5"
    Me.LayoutControlItem28.TextSize = New System.Drawing.Size(50, 20)
    Me.LayoutControlItem28.TextToControlDistance = 5
    '
    'LayoutControlItem27
    '
    Me.LayoutControlItem27.Control = Me.txtCustom4
    Me.LayoutControlItem27.CustomizationFormText = "Custom4"
    Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 295)
    Me.LayoutControlItem27.Name = "LayoutControlItem27"
    Me.LayoutControlItem27.Size = New System.Drawing.Size(360, 24)
    Me.LayoutControlItem27.Text = "Custom4"
    Me.LayoutControlItem27.TextSize = New System.Drawing.Size(50, 20)
    Me.LayoutControlItem27.TextToControlDistance = 5
    '
    'LayoutControlItem29
    '
    Me.LayoutControlItem29.Control = Me.txtDomestik
    Me.LayoutControlItem29.CustomizationFormText = "LayoutControlItem29"
    Me.LayoutControlItem29.Location = New System.Drawing.Point(237, 24)
    Me.LayoutControlItem29.Name = "LayoutControlItem29"
    Me.LayoutControlItem29.Size = New System.Drawing.Size(158, 25)
    Me.LayoutControlItem29.Text = "LayoutControlItem29"
    Me.LayoutControlItem29.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem29.TextToControlDistance = 0
    Me.LayoutControlItem29.TextVisible = False
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem18, Me.LayoutControlGroup3, Me.LayoutControlItem9, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.FOB, Me.EmptySpaceItem3, Me.LayoutControlItem6, Me.LayoutControlItem5, Me.LayoutControlItem8, Me.LayoutControlItem12, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem3, Me.LayoutControlItem13, Me.LayoutControlItem30, Me.LayoutControlItem31, Me.LayoutControlItem32, Me.EmptySpaceItem1, Me.LayoutControlGroup2, Me.LayoutControlGroup4, Me.EmptySpaceItem5, Me.EmptySpaceItem6, Me.LayoutControlItem36})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(1128, 435)
    Me.LayoutControlGroup1.Text = "Root"
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.xGrid
    Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 167)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(1098, 128)
    Me.LayoutControlItem7.Text = "LayoutControlItem7"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem7.TextToControlDistance = 0
    Me.LayoutControlItem7.TextVisible = False
    '
    'LayoutControlItem18
    '
    Me.LayoutControlItem18.Control = Me.txtCatatan
    Me.LayoutControlItem18.CustomizationFormText = "Catatan"
    Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 295)
    Me.LayoutControlItem18.Name = "LayoutControlItem18"
    Me.LayoutControlItem18.Size = New System.Drawing.Size(286, 24)
    Me.LayoutControlItem18.Text = "Catatan"
    Me.LayoutControlItem18.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem18.TextSize = New System.Drawing.Size(39, 13)
    Me.LayoutControlItem18.TextToControlDistance = 5
    '
    'LayoutControlGroup3
    '
    Me.LayoutControlGroup3.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
    Me.LayoutControlGroup3.AppearanceGroup.BackColor = System.Drawing.SystemColors.ControlDark
    Me.LayoutControlGroup3.AppearanceGroup.BackColor2 = System.Drawing.SystemColors.ControlDark
    Me.LayoutControlGroup3.AppearanceGroup.Options.UseBackColor = True
    Me.LayoutControlGroup3.CustomizationFormText = "Info Utama"
    Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layKontak, Me.LayoutControlItem15, Me.LayoutControlItem17, Me.LayoutControlItem16, Me.LayoutControlItem14, Me.lytRegional, Me.LayoutControlItem1, Me.LayoutControlItem23, Me.EmptySpaceItem2, Me.EmptySpaceItem4})
    Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
    Me.LayoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
    Me.LayoutControlGroup3.Size = New System.Drawing.Size(1098, 95)
    Me.LayoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 15)
    Me.LayoutControlGroup3.Text = "Info Utama"
    '
    'layKontak
    '
    Me.layKontak.Control = Me.txtKontak
    Me.layKontak.CustomizationFormText = "Vendor"
    Me.layKontak.Location = New System.Drawing.Point(0, 0)
    Me.layKontak.MinSize = New System.Drawing.Size(50, 25)
    Me.layKontak.Name = "layKontak"
    Me.layKontak.Size = New System.Drawing.Size(237, 25)
    Me.layKontak.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.layKontak.Text = "Vendor   "
    Me.layKontak.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.layKontak.TextSize = New System.Drawing.Size(70, 13)
    Me.layKontak.TextToControlDistance = 5
    '
    'LayoutControlItem15
    '
    Me.LayoutControlItem15.Control = Me.txtTanggal
    Me.LayoutControlItem15.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem15.Location = New System.Drawing.Point(701, 0)
    Me.LayoutControlItem15.Name = "LayoutControlItem15"
    Me.LayoutControlItem15.Size = New System.Drawing.Size(170, 24)
    Me.LayoutControlItem15.Text = "Tanggal"
    Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem15.TextSize = New System.Drawing.Size(43, 13)
    Me.LayoutControlItem15.TextToControlDistance = 5
    '
    'LayoutControlItem17
    '
    Me.LayoutControlItem17.Control = Me.btnRefreshNomor
    Me.LayoutControlItem17.CustomizationFormText = " "
    Me.LayoutControlItem17.Location = New System.Drawing.Point(1056, 0)
    Me.LayoutControlItem17.Name = "LayoutControlItem17"
    Me.LayoutControlItem17.Size = New System.Drawing.Size(30, 49)
    Me.LayoutControlItem17.Text = " "
    Me.LayoutControlItem17.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem17.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem17.TextToControlDistance = 0
    Me.LayoutControlItem17.TextVisible = False
    Me.LayoutControlItem17.TrimClientAreaToControl = False
    '
    'LayoutControlItem16
    '
    Me.LayoutControlItem16.Control = Me.txtNoTransaksi
    Me.LayoutControlItem16.CustomizationFormText = "No. Transaksi"
    Me.LayoutControlItem16.Location = New System.Drawing.Point(871, 0)
    Me.LayoutControlItem16.Name = "LayoutControlItem16"
    Me.LayoutControlItem16.Size = New System.Drawing.Size(185, 24)
    Me.LayoutControlItem16.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem16.Text = "No. Bukti"
    Me.LayoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem16.TextSize = New System.Drawing.Size(43, 13)
    Me.LayoutControlItem16.TextToControlDistance = 5
    '
    'LayoutControlItem14
    '
    Me.LayoutControlItem14.Control = Me.txtStatus
    Me.LayoutControlItem14.CustomizationFormText = "Status"
    Me.LayoutControlItem14.Location = New System.Drawing.Point(871, 24)
    Me.LayoutControlItem14.Name = "LayoutControlItem14"
    Me.LayoutControlItem14.Size = New System.Drawing.Size(185, 25)
    Me.LayoutControlItem14.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem14.Text = "Status   "
    Me.LayoutControlItem14.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem14.TextSize = New System.Drawing.Size(43, 13)
    Me.LayoutControlItem14.TextToControlDistance = 5
    '
    'lytRegional
    '
    Me.lytRegional.Control = Me.txtRegional
    Me.lytRegional.CustomizationFormText = "Regional"
    Me.lytRegional.Location = New System.Drawing.Point(701, 24)
    Me.lytRegional.Name = "lytRegional"
    Me.lytRegional.Size = New System.Drawing.Size(170, 25)
    Me.lytRegional.Text = "Regional"
    Me.lytRegional.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.lytRegional.TextSize = New System.Drawing.Size(43, 13)
    Me.lytRegional.TextToControlDistance = 5
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtKontakPerson
    Me.LayoutControlItem1.CustomizationFormText = "Kontak Person"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 25)
    Me.LayoutControlItem1.MinSize = New System.Drawing.Size(139, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(237, 24)
    Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem1.Text = "Kontak Person"
    Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(70, 13)
    Me.LayoutControlItem1.TextToControlDistance = 5
    '
    'LayoutControlItem23
    '
    Me.LayoutControlItem23.Control = Me.lblKontakNama
    Me.LayoutControlItem23.CustomizationFormText = "LayoutControlItem23"
    Me.LayoutControlItem23.Location = New System.Drawing.Point(237, 0)
    Me.LayoutControlItem23.MinSize = New System.Drawing.Size(70, 17)
    Me.LayoutControlItem23.Name = "LayoutControlItem23"
    Me.LayoutControlItem23.Size = New System.Drawing.Size(214, 24)
    Me.LayoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem23.Text = "LayoutControlItem23"
    Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem23.TextToControlDistance = 0
    Me.LayoutControlItem23.TextVisible = False
    '
    'EmptySpaceItem2
    '
    Me.EmptySpaceItem2.AllowHotTrack = False
    Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Location = New System.Drawing.Point(451, 0)
    Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Size = New System.Drawing.Size(250, 49)
    Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
    Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem4
    '
    Me.EmptySpaceItem4.AllowHotTrack = False
    Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Location = New System.Drawing.Point(237, 24)
    Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Size = New System.Drawing.Size(214, 25)
    Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
    Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
    Me.LayoutControlItem9.AppearanceItemCaption.Options.UseFont = True
    Me.LayoutControlItem9.Control = Me.txtNoPenawaran
    Me.LayoutControlItem9.CustomizationFormText = "No Penawaran"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 95)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(242, 24)
    Me.LayoutControlItem9.Text = "Ambil Forecast"
    Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(90, 13)
    Me.LayoutControlItem9.TextToControlDistance = 5
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtGudang
    Me.LayoutControlItem2.CustomizationFormText = "Gudang"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 119)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(242, 24)
    Me.LayoutControlItem2.Text = "Gudang"
    Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(90, 13)
    Me.LayoutControlItem2.TextToControlDistance = 5
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtVia
    Me.LayoutControlItem4.CustomizationFormText = "Via"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(358, 95)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(158, 24)
    Me.LayoutControlItem4.Text = "Via"
    Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(30, 13)
    Me.LayoutControlItem4.TextToControlDistance = 5
    '
    'FOB
    '
    Me.FOB.Control = Me.txtFOB
    Me.FOB.CustomizationFormText = "FOB"
    Me.FOB.Location = New System.Drawing.Point(358, 119)
    Me.FOB.Name = "FOB"
    Me.FOB.Size = New System.Drawing.Size(158, 24)
    Me.FOB.Text = "FOB"
    Me.FOB.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.FOB.TextSize = New System.Drawing.Size(30, 13)
    Me.FOB.TextToControlDistance = 5
    '
    'EmptySpaceItem3
    '
    Me.EmptySpaceItem3.AllowHotTrack = False
    Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Location = New System.Drawing.Point(242, 95)
    Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(10, 24)
    Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Size = New System.Drawing.Size(116, 72)
    Me.EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
    Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtTglBerlaku
    Me.LayoutControlItem6.CustomizationFormText = "Tgl Berlaku"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(516, 95)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(195, 24)
    Me.LayoutControlItem6.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem6.Text = "Tgl Berlaku"
    Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(53, 13)
    Me.LayoutControlItem6.TextToControlDistance = 5
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtLeadTime
    Me.LayoutControlItem5.CustomizationFormText = "Lead Time"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(516, 119)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(195, 24)
    Me.LayoutControlItem5.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem5.Text = "Lead Time"
    Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(53, 13)
    Me.LayoutControlItem5.TextToControlDistance = 5
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtUang
    Me.LayoutControlItem8.CustomizationFormText = "Uang"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(711, 95)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(176, 24)
    Me.LayoutControlItem8.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem8.Text = "Uang"
    Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(33, 13)
    Me.LayoutControlItem8.TextToControlDistance = 5
    '
    'LayoutControlItem12
    '
    Me.LayoutControlItem12.Control = Me.txtTermin
    Me.LayoutControlItem12.CustomizationFormText = "Termin"
    Me.LayoutControlItem12.Location = New System.Drawing.Point(711, 119)
    Me.LayoutControlItem12.Name = "LayoutControlItem12"
    Me.LayoutControlItem12.Size = New System.Drawing.Size(176, 24)
    Me.LayoutControlItem12.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem12.Text = "Termin"
    Me.LayoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem12.TextSize = New System.Drawing.Size(33, 13)
    Me.LayoutControlItem12.TextToControlDistance = 5
    '
    'LayoutControlItem10
    '
    Me.LayoutControlItem10.Control = Me.txtPajak
    Me.LayoutControlItem10.CustomizationFormText = "Pajak"
    Me.LayoutControlItem10.Location = New System.Drawing.Point(887, 95)
    Me.LayoutControlItem10.Name = "LayoutControlItem10"
    Me.LayoutControlItem10.Size = New System.Drawing.Size(211, 24)
    Me.LayoutControlItem10.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem10.Text = "Pajak"
    Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem10.TextSize = New System.Drawing.Size(70, 13)
    Me.LayoutControlItem10.TextToControlDistance = 5
    '
    'LayoutControlItem11
    '
    Me.LayoutControlItem11.Control = Me.txtKaryawan
    Me.LayoutControlItem11.CustomizationFormText = "Bag Pembelian"
    Me.LayoutControlItem11.Location = New System.Drawing.Point(887, 119)
    Me.LayoutControlItem11.Name = "LayoutControlItem11"
    Me.LayoutControlItem11.Size = New System.Drawing.Size(211, 24)
    Me.LayoutControlItem11.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem11.Text = "Bag Pembelian"
    Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem11.TextSize = New System.Drawing.Size(70, 13)
    Me.LayoutControlItem11.TextToControlDistance = 5
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
    Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.LayoutControlItem3.Control = Me.txtUraian
    Me.LayoutControlItem3.CustomizationFormText = "Uraian"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(358, 143)
    Me.LayoutControlItem3.MinSize = New System.Drawing.Size(89, 24)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(740, 24)
    Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem3.Text = "Uraian"
    Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(30, 13)
    Me.LayoutControlItem3.TextToControlDistance = 5
    '
    'LayoutControlItem13
    '
    Me.LayoutControlItem13.Control = Me.txtReffNo
    Me.LayoutControlItem13.CustomizationFormText = "Reff Number"
    Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 143)
    Me.LayoutControlItem13.Name = "LayoutControlItem13"
    Me.LayoutControlItem13.Size = New System.Drawing.Size(242, 24)
    Me.LayoutControlItem13.Text = "Reff Number"
    Me.LayoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem13.TextSize = New System.Drawing.Size(90, 13)
    Me.LayoutControlItem13.TextToControlDistance = 5
    '
    'LayoutControlItem30
    '
    Me.LayoutControlItem30.Control = Me.txtETA
    Me.LayoutControlItem30.CustomizationFormText = "ETA"
    Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 319)
    Me.LayoutControlItem30.Name = "LayoutControlItem30"
    Me.LayoutControlItem30.Size = New System.Drawing.Size(286, 24)
    Me.LayoutControlItem30.Text = "ETA"
    Me.LayoutControlItem30.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem30.TextSize = New System.Drawing.Size(39, 13)
    Me.LayoutControlItem30.TextToControlDistance = 5
    '
    'LayoutControlItem31
    '
    Me.LayoutControlItem31.Control = Me.txtETD
    Me.LayoutControlItem31.CustomizationFormText = "ETD"
    Me.LayoutControlItem31.Location = New System.Drawing.Point(0, 343)
    Me.LayoutControlItem31.Name = "LayoutControlItem31"
    Me.LayoutControlItem31.Size = New System.Drawing.Size(286, 24)
    Me.LayoutControlItem31.Text = "ETD"
    Me.LayoutControlItem31.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem31.TextSize = New System.Drawing.Size(39, 13)
    Me.LayoutControlItem31.TextToControlDistance = 5
    '
    'LayoutControlItem32
    '
    Me.LayoutControlItem32.Control = Me.txtMaker
    Me.LayoutControlItem32.CustomizationFormText = "Maker"
    Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 367)
    Me.LayoutControlItem32.Name = "LayoutControlItem32"
    Me.LayoutControlItem32.Size = New System.Drawing.Size(286, 48)
    Me.LayoutControlItem32.Text = "Maker"
    Me.LayoutControlItem32.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem32.TextSize = New System.Drawing.Size(39, 13)
    Me.LayoutControlItem32.TextToControlDistance = 5
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(1098, 0)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(10, 415)
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem19, Me.LayoutControlItem22})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(651, 295)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(198, 120)
    Me.LayoutControlGroup2.Text = "LayoutControlGroup2"
    Me.LayoutControlGroup2.TextVisible = False
    '
    'LayoutControlItem20
    '
    Me.LayoutControlItem20.Control = Me.txtTotal
    Me.LayoutControlItem20.CustomizationFormText = "Total Transaksi"
    Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem20.Name = "LayoutControlItem20"
    Me.LayoutControlItem20.Size = New System.Drawing.Size(174, 24)
    Me.LayoutControlItem20.Text = "Total Transaksi"
    Me.LayoutControlItem20.TextSize = New System.Drawing.Size(72, 13)
    '
    'LayoutControlItem21
    '
    Me.LayoutControlItem21.Control = Me.txtPPH
    Me.LayoutControlItem21.CustomizationFormText = "PPH"
    Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem21.Name = "LayoutControlItem21"
    Me.LayoutControlItem21.Size = New System.Drawing.Size(174, 24)
    Me.LayoutControlItem21.Text = "PPH"
    Me.LayoutControlItem21.TextSize = New System.Drawing.Size(72, 13)
    '
    'LayoutControlItem19
    '
    Me.LayoutControlItem19.Control = Me.txtPPN
    Me.LayoutControlItem19.CustomizationFormText = "PPN"
    Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem19.Name = "LayoutControlItem19"
    Me.LayoutControlItem19.Size = New System.Drawing.Size(174, 24)
    Me.LayoutControlItem19.Text = "PPN"
    Me.LayoutControlItem19.TextSize = New System.Drawing.Size(72, 13)
    '
    'LayoutControlItem22
    '
    Me.LayoutControlItem22.Control = Me.txtSubTotal
    Me.LayoutControlItem22.CustomizationFormText = "Sub Total"
    Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem22.Name = "LayoutControlItem22"
    Me.LayoutControlItem22.Size = New System.Drawing.Size(174, 24)
    Me.LayoutControlItem22.Text = "Sub Total"
    Me.LayoutControlItem22.TextSize = New System.Drawing.Size(72, 13)
    '
    'LayoutControlGroup4
    '
    Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup4"
    Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem34, Me.LayoutControlItem33})
    Me.LayoutControlGroup4.Location = New System.Drawing.Point(849, 295)
    Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
    Me.LayoutControlGroup4.Size = New System.Drawing.Size(249, 120)
    Me.LayoutControlGroup4.Text = "LayoutControlGroup4"
    Me.LayoutControlGroup4.TextVisible = False
    '
    'LayoutControlItem34
    '
    Me.LayoutControlItem34.Control = Me.txtGrandTotal
    Me.LayoutControlItem34.CustomizationFormText = "Grand Total"
    Me.LayoutControlItem34.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem34.Name = "LayoutControlItem34"
    Me.LayoutControlItem34.Size = New System.Drawing.Size(225, 72)
    Me.LayoutControlItem34.Text = "Grand Total"
    Me.LayoutControlItem34.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem34.TextSize = New System.Drawing.Size(70, 20)
    Me.LayoutControlItem34.TextToControlDistance = 5
    '
    'LayoutControlItem33
    '
    Me.LayoutControlItem33.Control = Me.txtShippingCost
    Me.LayoutControlItem33.CustomizationFormText = "Shipping Cost"
    Me.LayoutControlItem33.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem33.Name = "LayoutControlItem33"
    Me.LayoutControlItem33.Size = New System.Drawing.Size(225, 24)
    Me.LayoutControlItem33.Text = "Shipping Cost"
    Me.LayoutControlItem33.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem33.TextSize = New System.Drawing.Size(70, 20)
    Me.LayoutControlItem33.TextToControlDistance = 5
    '
    'EmptySpaceItem5
    '
    Me.EmptySpaceItem5.AllowHotTrack = False
    Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Location = New System.Drawing.Point(536, 295)
    Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Size = New System.Drawing.Size(115, 120)
    Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
    Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem6
    '
    Me.EmptySpaceItem6.AllowHotTrack = False
    Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Location = New System.Drawing.Point(286, 319)
    Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Size = New System.Drawing.Size(250, 96)
    Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
    Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem36
    '
    Me.LayoutControlItem36.Control = Me.txtHargaShipping
    Me.LayoutControlItem36.CustomizationFormText = "Harga Shipping"
    Me.LayoutControlItem36.Location = New System.Drawing.Point(286, 295)
    Me.LayoutControlItem36.Name = "LayoutControlItem36"
    Me.LayoutControlItem36.Size = New System.Drawing.Size(250, 24)
    Me.LayoutControlItem36.Text = "Harga Shipping"
    Me.LayoutControlItem36.TextSize = New System.Drawing.Size(72, 13)
    '
    'item2
    '
    Me.item2.CustomizationFormText = "item2"
    Me.item2.Location = New System.Drawing.Point(0, 0)
    Me.item2.Name = "item2"
    Me.item2.Size = New System.Drawing.Size(0, 0)
    Me.item2.Text = "item2"
    Me.item2.TextSize = New System.Drawing.Size(50, 20)
    Me.item2.TextToControlDistance = 5
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
    'btnRefresh
    '
    Me.btnRefresh.Caption = "Refresh"
    Me.btnRefresh.Glyph = CType(resources.GetObject("btnRefresh.Glyph"), System.Drawing.Image)
    Me.btnRefresh.Id = 8
    Me.btnRefresh.LargeGlyph = CType(resources.GetObject("btnRefresh.LargeGlyph"), System.Drawing.Image)
    Me.btnRefresh.Name = "btnRefresh"
    '
    'btnAmbilPermintaan
    '
    Me.btnAmbilPermintaan.Caption = "Ambil Permintaan"
    Me.btnAmbilPermintaan.Glyph = CType(resources.GetObject("btnAmbilPermintaan.Glyph"), System.Drawing.Image)
    Me.btnAmbilPermintaan.Id = 9
    Me.btnAmbilPermintaan.LargeGlyph = CType(resources.GetObject("btnAmbilPermintaan.LargeGlyph"), System.Drawing.Image)
    Me.btnAmbilPermintaan.Name = "btnAmbilPermintaan"
    Me.btnAmbilPermintaan.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    '
    'btnImpor
    '
    Me.btnImpor.Caption = "Impor"
    Me.btnImpor.Glyph = CType(resources.GetObject("btnImpor.Glyph"), System.Drawing.Image)
    Me.btnImpor.Id = 10
    Me.btnImpor.LargeGlyph = CType(resources.GetObject("btnImpor.LargeGlyph"), System.Drawing.Image)
    Me.btnImpor.Name = "btnImpor"
    '
    'UI_FusohOrderPembelianDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1134, 468)
    Me.Controls.Add(Me.hideContainerRight)
    Me.KeyPreview = True
    Me.Name = "UI_FusohOrderPembelianDialog"
    Me.Text = "Order Pembelian"
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
    CType(Me.txtHargaShipping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtGrandTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtShippingCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtETA.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtETA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCustom5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCustom4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCustom3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCustom2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCustom1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtReffNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPPH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPPN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPajak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTermin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoPenawaran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglBerlaku.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglBerlaku.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtLeadTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtFOB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtVia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontakPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKodeBarangRepoGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colHargaRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colPPNRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colPPHRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKuotaImporRepo2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKuotaImporRepoViews, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKuotaImporRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKaryawan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDomestik.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMaker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtETD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.layKontak, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytRegional, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.FOB, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.item2, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents txtGudang As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
	Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
	Friend WithEvents txtVia As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents txtLeadTime As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtFOB As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents txtTglBerlaku As DevExpress.XtraEditors.DateEdit
	Friend WithEvents txtUang As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents txtNoPenawaran As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents txtTermin As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents txtPajak As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colPPN As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colPPH As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKuotaImpor As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKuotaImporRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
	Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents DocumentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
	Friend WithEvents Document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
	Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtPPN As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtSubTotal As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtPPH As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtReffNo As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtCatatan As DevExpress.XtraEditors.MemoExEdit
	Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents item2 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents lblKontakNama As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents layKontak As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytRegional As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents FOB As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtCustom3 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtCustom2 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtCustom1 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtCustom5 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtCustom4 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPajakInV As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPajakOutV As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHargaRepo As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
  Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKodeBarangRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
  Friend WithEvents colKodeBarangRepoGrid As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcSatuan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtKaryawan As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnAmbilPermintaan As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents gcCustom1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcCustom2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcCustom3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcCustom4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPPNRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colPPHRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colOD As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colT As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colL As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeight As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtDomestik As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents txtETA As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colWeightM As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHargaKg As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKuotaImporRepo2 As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
  Friend WithEvents colKuotaImporRepoViews As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSisaVolume As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtMaker As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtGrandTotal As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtShippingCost As DevExpress.XtraEditors.TextEdit
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
	Friend WithEvents colShipping As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents txtETD As DevExpress.XtraEditors.TextEdit
	Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
	Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents btnImpor As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents txtHargaShipping As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
End Class