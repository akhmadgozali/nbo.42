<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_BarangDialog
    Inherits Core.Win.Forms.InputDialog

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
        Me.txtNama = New DevExpress.XtraEditors.TextEdit()
        Me.lytMaster = New DevExpress.XtraLayout.LayoutControl()
        Me.txtCustom10 = New DevExpress.XtraEditors.TextEdit()
        Me.txtCustom9 = New DevExpress.XtraEditors.TextEdit()
        Me.txtCustom8 = New DevExpress.XtraEditors.TextEdit()
        Me.txtCustom7 = New DevExpress.XtraEditors.TextEdit()
        Me.txtCustom6 = New DevExpress.XtraEditors.TextEdit()
        Me.txtCustom5 = New DevExpress.XtraEditors.TextEdit()
        Me.txtCustom4 = New DevExpress.XtraEditors.TextEdit()
        Me.txtCustom2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtCustom3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtCustom1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtLength = New DevExpress.XtraEditors.SpinEdit()
        Me.txtBarcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtThickness = New DevExpress.XtraEditors.SpinEdit()
        Me.txtID = New DevExpress.XtraEditors.SpinEdit()
        Me.txtOD = New DevExpress.XtraEditors.SpinEdit()
        Me.xGridPenyusun = New DevExpress.XtraGrid.GridControl()
        Me.xGridPenyusunView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKodeBarangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.colKodeBarangRepoSearch = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSatuanRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtHargaBeli = New DevExpress.XtraEditors.CalcEdit()
        Me.txtNote = New DevExpress.XtraEditors.MemoEdit()
        Me.txtMerk = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtSubKategori = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtKategori = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtAktif = New DevExpress.XtraEditors.CheckEdit()
        Me.txtStockOrder = New DevExpress.XtraEditors.TextEdit()
        Me.txtStockCurrent = New DevExpress.XtraEditors.TextEdit()
        Me.txtStockMin = New DevExpress.XtraEditors.TextEdit()
        Me.txtStockMax = New DevExpress.XtraEditors.TextEdit()
        Me.xGridLokasi = New DevExpress.XtraGrid.GridControl()
        Me.xGridLokasiView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGudang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGudangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colLokasi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPajakOut = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtPajakIn = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtJenis = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtKode = New DevExpress.XtraEditors.TextEdit()
        Me.txtTipe = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtUang = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtHargaJual1 = New DevExpress.XtraEditors.CalcEdit()
        Me.txtHargaJual2 = New DevExpress.XtraEditors.CalcEdit()
        Me.txtHargaJual3 = New DevExpress.XtraEditors.CalcEdit()
        Me.txtHargaJual4 = New DevExpress.XtraEditors.CalcEdit()
        Me.txtHargaJual5 = New DevExpress.XtraEditors.CalcEdit()
        Me.txtAkunPersediaan = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAkunPendapatan = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAkunDiscPembelian = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAkunDiscPenjualan = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAkunReturPembelian = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAkunReturPenjualan = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAkunHPP = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtFeeAgen = New DevExpress.XtraEditors.CalcEdit()
        Me.txtSatuan = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtSatuanDasar = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSDKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSDNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lytCustom1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lytCustom3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lytCustom6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lytCustom7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lytCustom2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lytCustom8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lytCustom9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lytCustom4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lytCustom10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lytCustom5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup11 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.tabBarangDialog = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.tabBarangDialogGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lytSettingAkuntansi = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup9 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup10 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.xpSatuan = New DevExpress.Xpo.XPCollection(Me.components)
        CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lytMaster.SuspendLayout()
        CType(Me.txtCustom10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustom9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustom8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustom7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustom6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustom5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustom4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustom2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustom3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustom1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLength.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThickness.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridPenyusun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridPenyusunView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colKodeBarangRepoSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHargaBeli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMerk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubKategori.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKategori.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAktif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockCurrent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridLokasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridLokasiView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colGudangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPajakOut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPajakIn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHargaJual1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHargaJual2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHargaJual3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHargaJual4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHargaJual5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAkunPersediaan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAkunPendapatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAkunDiscPembelian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAkunDiscPenjualan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAkunReturPembelian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAkunReturPenjualan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAkunHPP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFeeAgen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSatuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSatuanDasar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytCustom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytCustom3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytCustom6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytCustom7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytCustom2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytCustom8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytCustom9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytCustom4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytCustom10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytCustom5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabBarangDialog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabBarangDialogGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytSettingAkuntansi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xpSatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(101, 62)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNama.Size = New System.Drawing.Size(162, 20)
        Me.txtNama.StyleController = Me.lytMaster
        Me.txtNama.TabIndex = 101
        '
        'lytMaster
        '
        Me.lytMaster.Controls.Add(Me.txtCustom10)
        Me.lytMaster.Controls.Add(Me.txtCustom9)
        Me.lytMaster.Controls.Add(Me.txtCustom8)
        Me.lytMaster.Controls.Add(Me.txtCustom7)
        Me.lytMaster.Controls.Add(Me.txtCustom6)
        Me.lytMaster.Controls.Add(Me.txtCustom5)
        Me.lytMaster.Controls.Add(Me.txtCustom4)
        Me.lytMaster.Controls.Add(Me.txtCustom2)
        Me.lytMaster.Controls.Add(Me.txtCustom3)
        Me.lytMaster.Controls.Add(Me.txtCustom1)
        Me.lytMaster.Controls.Add(Me.txtLength)
        Me.lytMaster.Controls.Add(Me.txtBarcode)
        Me.lytMaster.Controls.Add(Me.txtThickness)
        Me.lytMaster.Controls.Add(Me.txtID)
        Me.lytMaster.Controls.Add(Me.txtOD)
        Me.lytMaster.Controls.Add(Me.xGridPenyusun)
        Me.lytMaster.Controls.Add(Me.txtHargaBeli)
        Me.lytMaster.Controls.Add(Me.txtNote)
        Me.lytMaster.Controls.Add(Me.txtMerk)
        Me.lytMaster.Controls.Add(Me.txtSubKategori)
        Me.lytMaster.Controls.Add(Me.txtKategori)
        Me.lytMaster.Controls.Add(Me.txtAktif)
        Me.lytMaster.Controls.Add(Me.txtStockOrder)
        Me.lytMaster.Controls.Add(Me.txtStockCurrent)
        Me.lytMaster.Controls.Add(Me.txtStockMin)
        Me.lytMaster.Controls.Add(Me.txtStockMax)
        Me.lytMaster.Controls.Add(Me.xGridLokasi)
        Me.lytMaster.Controls.Add(Me.txtPajakOut)
        Me.lytMaster.Controls.Add(Me.txtPajakIn)
        Me.lytMaster.Controls.Add(Me.txtJenis)
        Me.lytMaster.Controls.Add(Me.txtKode)
        Me.lytMaster.Controls.Add(Me.txtNama)
        Me.lytMaster.Controls.Add(Me.txtTipe)
        Me.lytMaster.Controls.Add(Me.txtUang)
        Me.lytMaster.Controls.Add(Me.txtHargaJual1)
        Me.lytMaster.Controls.Add(Me.txtHargaJual2)
        Me.lytMaster.Controls.Add(Me.txtHargaJual3)
        Me.lytMaster.Controls.Add(Me.txtHargaJual4)
        Me.lytMaster.Controls.Add(Me.txtHargaJual5)
        Me.lytMaster.Controls.Add(Me.txtAkunPersediaan)
        Me.lytMaster.Controls.Add(Me.txtAkunPendapatan)
        Me.lytMaster.Controls.Add(Me.txtAkunDiscPembelian)
        Me.lytMaster.Controls.Add(Me.txtAkunDiscPenjualan)
        Me.lytMaster.Controls.Add(Me.txtAkunReturPembelian)
        Me.lytMaster.Controls.Add(Me.txtAkunReturPenjualan)
        Me.lytMaster.Controls.Add(Me.txtAkunHPP)
        Me.lytMaster.Controls.Add(Me.txtFeeAgen)
        Me.lytMaster.Controls.Add(Me.txtSatuan)
        Me.lytMaster.Controls.Add(Me.txtSatuanDasar)
        Me.lytMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lytMaster.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup6, Me.LayoutControlGroup11})
        Me.lytMaster.Location = New System.Drawing.Point(0, 0)
        Me.lytMaster.Name = "lytMaster"
        Me.lytMaster.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(703, 93, 250, 350)
        Me.lytMaster.Root = Me.LayoutControlGroup1
        Me.lytMaster.Size = New System.Drawing.Size(473, 259)
        Me.lytMaster.TabIndex = 110
        Me.lytMaster.Text = "LayoutControl1"
        '
        'txtCustom10
        '
        Me.txtCustom10.Location = New System.Drawing.Point(336, 134)
        Me.txtCustom10.Name = "txtCustom10"
        Me.txtCustom10.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtCustom10.Size = New System.Drawing.Size(121, 20)
        Me.txtCustom10.StyleController = Me.lytMaster
        Me.txtCustom10.TabIndex = 147
        '
        'txtCustom9
        '
        Me.txtCustom9.Location = New System.Drawing.Point(336, 110)
        Me.txtCustom9.Name = "txtCustom9"
        Me.txtCustom9.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtCustom9.Size = New System.Drawing.Size(121, 20)
        Me.txtCustom9.StyleController = Me.lytMaster
        Me.txtCustom9.TabIndex = 146
        '
        'txtCustom8
        '
        Me.txtCustom8.Location = New System.Drawing.Point(336, 86)
        Me.txtCustom8.Name = "txtCustom8"
        Me.txtCustom8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtCustom8.Size = New System.Drawing.Size(121, 20)
        Me.txtCustom8.StyleController = Me.lytMaster
        Me.txtCustom8.TabIndex = 145
        '
        'txtCustom7
        '
        Me.txtCustom7.Location = New System.Drawing.Point(336, 62)
        Me.txtCustom7.Name = "txtCustom7"
        Me.txtCustom7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtCustom7.Size = New System.Drawing.Size(121, 20)
        Me.txtCustom7.StyleController = Me.lytMaster
        Me.txtCustom7.TabIndex = 144
        '
        'txtCustom6
        '
        Me.txtCustom6.Location = New System.Drawing.Point(336, 38)
        Me.txtCustom6.Name = "txtCustom6"
        Me.txtCustom6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtCustom6.Size = New System.Drawing.Size(121, 20)
        Me.txtCustom6.StyleController = Me.lytMaster
        Me.txtCustom6.TabIndex = 143
        '
        'txtCustom5
        '
        Me.txtCustom5.Location = New System.Drawing.Point(101, 134)
        Me.txtCustom5.Name = "txtCustom5"
        Me.txtCustom5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtCustom5.Size = New System.Drawing.Size(131, 20)
        Me.txtCustom5.StyleController = Me.lytMaster
        Me.txtCustom5.TabIndex = 11
        '
        'txtCustom4
        '
        Me.txtCustom4.Location = New System.Drawing.Point(101, 110)
        Me.txtCustom4.Name = "txtCustom4"
        Me.txtCustom4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtCustom4.Size = New System.Drawing.Size(131, 20)
        Me.txtCustom4.StyleController = Me.lytMaster
        Me.txtCustom4.TabIndex = 9
        '
        'txtCustom2
        '
        Me.txtCustom2.Location = New System.Drawing.Point(101, 62)
        Me.txtCustom2.Name = "txtCustom2"
        Me.txtCustom2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtCustom2.Size = New System.Drawing.Size(131, 20)
        Me.txtCustom2.StyleController = Me.lytMaster
        Me.txtCustom2.TabIndex = 8
        '
        'txtCustom3
        '
        Me.txtCustom3.Location = New System.Drawing.Point(101, 86)
        Me.txtCustom3.Name = "txtCustom3"
        Me.txtCustom3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtCustom3.Size = New System.Drawing.Size(131, 20)
        Me.txtCustom3.StyleController = Me.lytMaster
        Me.txtCustom3.TabIndex = 10
        '
        'txtCustom1
        '
        Me.txtCustom1.Location = New System.Drawing.Point(101, 38)
        Me.txtCustom1.Name = "txtCustom1"
        Me.txtCustom1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtCustom1.Size = New System.Drawing.Size(131, 20)
        Me.txtCustom1.StyleController = Me.lytMaster
        Me.txtCustom1.TabIndex = 7
        '
        'txtLength
        '
        Me.txtLength.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLength.Location = New System.Drawing.Point(101, 110)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLength.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtLength.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtLength.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtLength.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtLength.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtLength.Size = New System.Drawing.Size(356, 20)
        Me.txtLength.StyleController = Me.lytMaster
        Me.txtLength.TabIndex = 152
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(101, 134)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtBarcode.Size = New System.Drawing.Size(356, 20)
        Me.txtBarcode.StyleController = Me.lytMaster
        Me.txtBarcode.TabIndex = 111
        '
        'txtThickness
        '
        Me.txtThickness.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtThickness.Location = New System.Drawing.Point(101, 86)
        Me.txtThickness.Name = "txtThickness"
        Me.txtThickness.Properties.Appearance.Options.UseTextOptions = True
        Me.txtThickness.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtThickness.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtThickness.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtThickness.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtThickness.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtThickness.Size = New System.Drawing.Size(356, 20)
        Me.txtThickness.StyleController = Me.lytMaster
        Me.txtThickness.TabIndex = 151
        '
        'txtID
        '
        Me.txtID.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtID.Location = New System.Drawing.Point(101, 62)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.Options.UseTextOptions = True
        Me.txtID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtID.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtID.Size = New System.Drawing.Size(356, 20)
        Me.txtID.StyleController = Me.lytMaster
        Me.txtID.TabIndex = 151
        '
        'txtOD
        '
        Me.txtOD.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOD.Location = New System.Drawing.Point(101, 38)
        Me.txtOD.Name = "txtOD"
        Me.txtOD.Properties.Appearance.Options.UseTextOptions = True
        Me.txtOD.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtOD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtOD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOD.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtOD.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtOD.Size = New System.Drawing.Size(356, 20)
        Me.txtOD.StyleController = Me.lytMaster
        Me.txtOD.TabIndex = 151
        '
        'xGridPenyusun
        '
        Me.xGridPenyusun.Location = New System.Drawing.Point(20, 61)
        Me.xGridPenyusun.MainView = Me.xGridPenyusunView
        Me.xGridPenyusun.Name = "xGridPenyusun"
        Me.xGridPenyusun.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colKodeBarangRepo, Me.colSatuanRepo})
        Me.xGridPenyusun.Size = New System.Drawing.Size(433, 178)
        Me.xGridPenyusun.TabIndex = 156
        Me.xGridPenyusun.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridPenyusunView})
        '
        'xGridPenyusunView
        '
        Me.xGridPenyusunView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeBarang, Me.colNamaBarang, Me.colQty, Me.colSatuan, Me.colCatatan})
        Me.xGridPenyusunView.GridControl = Me.xGridPenyusun
        Me.xGridPenyusunView.Name = "xGridPenyusunView"
        Me.xGridPenyusunView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridPenyusunView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.xGridPenyusunView.OptionsView.ShowGroupPanel = False
        '
        'colKodeBarang
        '
        Me.colKodeBarang.Caption = "Kode"
        Me.colKodeBarang.ColumnEdit = Me.colKodeBarangRepo
        Me.colKodeBarang.FieldName = "BarangPenyusun!"
        Me.colKodeBarang.Name = "colKodeBarang"
        Me.colKodeBarang.Visible = True
        Me.colKodeBarang.VisibleIndex = 0
        Me.colKodeBarang.Width = 89
        '
        'colKodeBarangRepo
        '
        Me.colKodeBarangRepo.AutoHeight = False
        Me.colKodeBarangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.colKodeBarangRepo.DisplayMember = "Kode"
        Me.colKodeBarangRepo.Name = "colKodeBarangRepo"
        Me.colKodeBarangRepo.NullText = "<Pilih Barang>"
        Me.colKodeBarangRepo.ValueMember = "This"
        Me.colKodeBarangRepo.View = Me.colKodeBarangRepoSearch
        '
        'colKodeBarangRepoSearch
        '
        Me.colKodeBarangRepoSearch.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcKode, Me.gcNama, Me.gcSatuan})
        Me.colKodeBarangRepoSearch.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.colKodeBarangRepoSearch.Name = "colKodeBarangRepoSearch"
        Me.colKodeBarangRepoSearch.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.colKodeBarangRepoSearch.OptionsView.ShowGroupPanel = False
        '
        'gcKode
        '
        Me.gcKode.Caption = "Kode"
        Me.gcKode.FieldName = "Kode"
        Me.gcKode.Name = "gcKode"
        Me.gcKode.Visible = True
        Me.gcKode.VisibleIndex = 0
        Me.gcKode.Width = 293
        '
        'gcNama
        '
        Me.gcNama.Caption = "Nama"
        Me.gcNama.FieldName = "Nama"
        Me.gcNama.Name = "gcNama"
        Me.gcNama.Visible = True
        Me.gcNama.VisibleIndex = 1
        Me.gcNama.Width = 519
        '
        'gcSatuan
        '
        Me.gcSatuan.Caption = "Satuan"
        Me.gcSatuan.FieldName = "Satuan.Nama"
        Me.gcSatuan.Name = "gcSatuan"
        Me.gcSatuan.Visible = True
        Me.gcSatuan.VisibleIndex = 2
        Me.gcSatuan.Width = 266
        '
        'colNamaBarang
        '
        Me.colNamaBarang.Caption = "Nama"
        Me.colNamaBarang.FieldName = "BarangPenyusun.Nama"
        Me.colNamaBarang.Name = "colNamaBarang"
        Me.colNamaBarang.Visible = True
        Me.colNamaBarang.VisibleIndex = 1
        Me.colNamaBarang.Width = 130
        '
        'colQty
        '
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 2
        Me.colQty.Width = 40
        '
        'colSatuan
        '
        Me.colSatuan.Caption = "Satuan"
        Me.colSatuan.ColumnEdit = Me.colSatuanRepo
        Me.colSatuan.FieldName = "Satuan!"
        Me.colSatuan.Name = "colSatuan"
        Me.colSatuan.Visible = True
        Me.colSatuan.VisibleIndex = 3
        Me.colSatuan.Width = 51
        '
        'colSatuanRepo
        '
        Me.colSatuanRepo.AutoHeight = False
        Me.colSatuanRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.colSatuanRepo.DisplayMember = "Kode"
        Me.colSatuanRepo.Name = "colSatuanRepo"
        Me.colSatuanRepo.ValueMember = "This"
        '
        'colCatatan
        '
        Me.colCatatan.Caption = "Catatan"
        Me.colCatatan.FieldName = "Catatan"
        Me.colCatatan.Name = "colCatatan"
        Me.colCatatan.Visible = True
        Me.colCatatan.VisibleIndex = 4
        Me.colCatatan.Width = 105
        '
        'txtHargaBeli
        '
        Me.txtHargaBeli.Location = New System.Drawing.Point(101, 206)
        Me.txtHargaBeli.Name = "txtHargaBeli"
        Me.txtHargaBeli.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtHargaBeli.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHargaBeli.Properties.DisplayFormat.FormatString = "n0"
        Me.txtHargaBeli.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaBeli.Properties.EditFormat.FormatString = "n0"
        Me.txtHargaBeli.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaBeli.Size = New System.Drawing.Size(162, 20)
        Me.txtHargaBeli.StyleController = Me.lytMaster
        Me.txtHargaBeli.TabIndex = 155
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(101, 134)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNote.Size = New System.Drawing.Size(356, 109)
        Me.txtNote.StyleController = Me.lytMaster
        Me.txtNote.TabIndex = 154
        '
        'txtMerk
        '
        Me.txtMerk.Location = New System.Drawing.Point(317, 86)
        Me.txtMerk.Name = "txtMerk"
        Me.txtMerk.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtMerk.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMerk.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.txtMerk.Properties.DisplayMember = "Kode"
        Me.txtMerk.Properties.NullText = "<Pilih Merk>"
        Me.txtMerk.Properties.ValueMember = "This"
        Me.txtMerk.Size = New System.Drawing.Size(140, 20)
        Me.txtMerk.StyleController = Me.lytMaster
        Me.txtMerk.TabIndex = 153
        '
        'txtSubKategori
        '
        Me.txtSubKategori.Location = New System.Drawing.Point(317, 62)
        Me.txtSubKategori.Name = "txtSubKategori"
        Me.txtSubKategori.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtSubKategori.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSubKategori.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.txtSubKategori.Properties.DisplayMember = "Kode"
        Me.txtSubKategori.Properties.NullText = "<Pilih Sub Kategori>"
        Me.txtSubKategori.Properties.ValueMember = "This"
        Me.txtSubKategori.Size = New System.Drawing.Size(140, 20)
        Me.txtSubKategori.StyleController = Me.lytMaster
        Me.txtSubKategori.TabIndex = 152
        '
        'txtKategori
        '
        Me.txtKategori.Location = New System.Drawing.Point(317, 38)
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtKategori.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKategori.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.txtKategori.Properties.DisplayMember = "Kode"
        Me.txtKategori.Properties.NullText = "<Pilih Kategori>"
        Me.txtKategori.Properties.ValueMember = "This"
        Me.txtKategori.Size = New System.Drawing.Size(140, 20)
        Me.txtKategori.StyleController = Me.lytMaster
        Me.txtKategori.TabIndex = 151
        '
        'txtAktif
        '
        Me.txtAktif.Location = New System.Drawing.Point(406, 38)
        Me.txtAktif.Name = "txtAktif"
        Me.txtAktif.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtAktif.Properties.Caption = ""
        Me.txtAktif.Size = New System.Drawing.Size(23, 21)
        Me.txtAktif.StyleController = Me.lytMaster
        Me.txtAktif.TabIndex = 150
        '
        'txtStockOrder
        '
        Me.txtStockOrder.Location = New System.Drawing.Point(101, 62)
        Me.txtStockOrder.Name = "txtStockOrder"
        Me.txtStockOrder.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStockOrder.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtStockOrder.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtStockOrder.Properties.ReadOnly = True
        Me.txtStockOrder.Size = New System.Drawing.Size(131, 20)
        Me.txtStockOrder.StyleController = Me.lytMaster
        Me.txtStockOrder.TabIndex = 149
        '
        'txtStockCurrent
        '
        Me.txtStockCurrent.Location = New System.Drawing.Point(101, 38)
        Me.txtStockCurrent.Name = "txtStockCurrent"
        Me.txtStockCurrent.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStockCurrent.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtStockCurrent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtStockCurrent.Properties.ReadOnly = True
        Me.txtStockCurrent.Size = New System.Drawing.Size(131, 20)
        Me.txtStockCurrent.StyleController = Me.lytMaster
        Me.txtStockCurrent.TabIndex = 149
        '
        'txtStockMin
        '
        Me.txtStockMin.Location = New System.Drawing.Point(101, 110)
        Me.txtStockMin.Name = "txtStockMin"
        Me.txtStockMin.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStockMin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtStockMin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtStockMin.Properties.Mask.EditMask = "n0"
        Me.txtStockMin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtStockMin.Size = New System.Drawing.Size(131, 20)
        Me.txtStockMin.StyleController = Me.lytMaster
        Me.txtStockMin.TabIndex = 149
        '
        'txtStockMax
        '
        Me.txtStockMax.Location = New System.Drawing.Point(101, 86)
        Me.txtStockMax.Name = "txtStockMax"
        Me.txtStockMax.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStockMax.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtStockMax.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtStockMax.Properties.Mask.EditMask = "n0"
        Me.txtStockMax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtStockMax.Size = New System.Drawing.Size(131, 20)
        Me.txtStockMax.StyleController = Me.lytMaster
        Me.txtStockMax.TabIndex = 148
        '
        'xGridLokasi
        '
        Me.xGridLokasi.Location = New System.Drawing.Point(16, 38)
        Me.xGridLokasi.MainView = Me.xGridLokasiView
        Me.xGridLokasi.Name = "xGridLokasi"
        Me.xGridLokasi.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colGudangRepo})
        Me.xGridLokasi.Size = New System.Drawing.Size(441, 205)
        Me.xGridLokasi.TabIndex = 1
        Me.xGridLokasi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridLokasiView})
        '
        'xGridLokasiView
        '
        Me.xGridLokasiView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGudang, Me.colLokasi})
        Me.xGridLokasiView.GridControl = Me.xGridLokasi
        Me.xGridLokasiView.Name = "xGridLokasiView"
        Me.xGridLokasiView.NewItemRowText = "<Tambah Data>"
        Me.xGridLokasiView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridLokasiView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.xGridLokasiView.OptionsView.ShowGroupPanel = False
        '
        'colGudang
        '
        Me.colGudang.Caption = "Gudang"
        Me.colGudang.ColumnEdit = Me.colGudangRepo
        Me.colGudang.FieldName = "Gudang!"
        Me.colGudang.Name = "colGudang"
        Me.colGudang.Visible = True
        Me.colGudang.VisibleIndex = 0
        Me.colGudang.Width = 128
        '
        'colGudangRepo
        '
        Me.colGudangRepo.AutoHeight = False
        Me.colGudangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.colGudangRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.colGudangRepo.DisplayMember = "Kode"
        Me.colGudangRepo.Name = "colGudangRepo"
        Me.colGudangRepo.NullText = "<Pilih Gudang>"
        Me.colGudangRepo.ValueMember = "This"
        '
        'colLokasi
        '
        Me.colLokasi.Caption = "Lokasi/Rak"
        Me.colLokasi.FieldName = "Lokasi"
        Me.colLokasi.Name = "colLokasi"
        Me.colLokasi.Visible = True
        Me.colLokasi.VisibleIndex = 1
        Me.colLokasi.Width = 393
        '
        'txtPajakOut
        '
        Me.txtPajakOut.Location = New System.Drawing.Point(330, 196)
        Me.txtPajakOut.Name = "txtPajakOut"
        Me.txtPajakOut.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtPajakOut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPajakOut.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NilaiPajak", 60, "Nilai")})
        Me.txtPajakOut.Properties.DisplayMember = "Kode"
        Me.txtPajakOut.Properties.NullText = "<Pilih Pajak>"
        Me.txtPajakOut.Properties.ValueMember = "This"
        Me.txtPajakOut.Size = New System.Drawing.Size(115, 20)
        Me.txtPajakOut.StyleController = Me.lytMaster
        Me.txtPajakOut.TabIndex = 121
        '
        'txtPajakIn
        '
        Me.txtPajakIn.Location = New System.Drawing.Point(113, 196)
        Me.txtPajakIn.Name = "txtPajakIn"
        Me.txtPajakIn.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtPajakIn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPajakIn.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NilaiPajak", 60, "Nilai")})
        Me.txtPajakIn.Properties.DisplayMember = "Kode"
        Me.txtPajakIn.Properties.NullText = "<Pilih Pajak>"
        Me.txtPajakIn.Properties.ValueMember = "This"
        Me.txtPajakIn.Size = New System.Drawing.Size(113, 20)
        Me.txtPajakIn.StyleController = Me.lytMaster
        Me.txtPajakIn.TabIndex = 121
        '
        'txtJenis
        '
        Me.txtJenis.Location = New System.Drawing.Point(101, 86)
        Me.txtJenis.Name = "txtJenis"
        Me.txtJenis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtJenis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJenis.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", 60, "Nama")})
        Me.txtJenis.Properties.DisplayMember = "Value"
        Me.txtJenis.Properties.NullText = "<Pilih Jenis>"
        Me.txtJenis.Properties.ValueMember = "Key"
        Me.txtJenis.Size = New System.Drawing.Size(162, 20)
        Me.txtJenis.StyleController = Me.lytMaster
        Me.txtJenis.TabIndex = 121
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(101, 38)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtKode.Size = New System.Drawing.Size(162, 20)
        Me.txtKode.StyleController = Me.lytMaster
        Me.txtKode.TabIndex = 100
        '
        'txtTipe
        '
        Me.txtTipe.Location = New System.Drawing.Point(101, 110)
        Me.txtTipe.Name = "txtTipe"
        Me.txtTipe.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtTipe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTipe.Properties.DisplayMember = "Value"
        Me.txtTipe.Properties.NullText = "<Pilih Tipe>"
        Me.txtTipe.Properties.ValueMember = "Key"
        Me.txtTipe.Size = New System.Drawing.Size(162, 20)
        Me.txtTipe.StyleController = Me.lytMaster
        Me.txtTipe.TabIndex = 123
        '
        'txtUang
        '
        Me.txtUang.Location = New System.Drawing.Point(101, 182)
        Me.txtUang.Name = "txtUang"
        Me.txtUang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 60, "Nama")})
        Me.txtUang.Properties.DisplayMember = "Kode"
        Me.txtUang.Properties.NullText = "<Pilih Mata Uang>"
        Me.txtUang.Properties.ValueMember = "This"
        Me.txtUang.Size = New System.Drawing.Size(162, 20)
        Me.txtUang.StyleController = Me.lytMaster
        Me.txtUang.TabIndex = 109
        '
        'txtHargaJual1
        '
        Me.txtHargaJual1.Location = New System.Drawing.Point(318, 94)
        Me.txtHargaJual1.Name = "txtHargaJual1"
        Me.txtHargaJual1.Properties.Appearance.Options.UseTextOptions = True
        Me.txtHargaJual1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtHargaJual1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtHargaJual1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHargaJual1.Properties.DisplayFormat.FormatString = "n0"
        Me.txtHargaJual1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual1.Properties.EditFormat.FormatString = "n0"
        Me.txtHargaJual1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual1.Properties.Mask.EditMask = "n0"
        Me.txtHargaJual1.Size = New System.Drawing.Size(127, 20)
        Me.txtHargaJual1.StyleController = Me.lytMaster
        Me.txtHargaJual1.TabIndex = 111
        '
        'txtHargaJual2
        '
        Me.txtHargaJual2.Location = New System.Drawing.Point(318, 118)
        Me.txtHargaJual2.Name = "txtHargaJual2"
        Me.txtHargaJual2.Properties.Appearance.Options.UseTextOptions = True
        Me.txtHargaJual2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtHargaJual2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtHargaJual2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHargaJual2.Properties.DisplayFormat.FormatString = "n0"
        Me.txtHargaJual2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual2.Properties.EditFormat.FormatString = "n0"
        Me.txtHargaJual2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual2.Properties.Mask.EditMask = "n0"
        Me.txtHargaJual2.Size = New System.Drawing.Size(127, 20)
        Me.txtHargaJual2.StyleController = Me.lytMaster
        Me.txtHargaJual2.TabIndex = 113
        '
        'txtHargaJual3
        '
        Me.txtHargaJual3.Location = New System.Drawing.Point(318, 142)
        Me.txtHargaJual3.Name = "txtHargaJual3"
        Me.txtHargaJual3.Properties.Appearance.Options.UseTextOptions = True
        Me.txtHargaJual3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtHargaJual3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtHargaJual3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHargaJual3.Properties.DisplayFormat.FormatString = "n0"
        Me.txtHargaJual3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual3.Properties.EditFormat.FormatString = "n0"
        Me.txtHargaJual3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual3.Properties.Mask.EditMask = "n0"
        Me.txtHargaJual3.Size = New System.Drawing.Size(127, 20)
        Me.txtHargaJual3.StyleController = Me.lytMaster
        Me.txtHargaJual3.TabIndex = 115
        '
        'txtHargaJual4
        '
        Me.txtHargaJual4.Location = New System.Drawing.Point(318, 166)
        Me.txtHargaJual4.Name = "txtHargaJual4"
        Me.txtHargaJual4.Properties.Appearance.Options.UseTextOptions = True
        Me.txtHargaJual4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtHargaJual4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtHargaJual4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHargaJual4.Properties.DisplayFormat.FormatString = "n0"
        Me.txtHargaJual4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual4.Properties.EditFormat.FormatString = "n0"
        Me.txtHargaJual4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual4.Properties.Mask.EditMask = "n0"
        Me.txtHargaJual4.Size = New System.Drawing.Size(127, 20)
        Me.txtHargaJual4.StyleController = Me.lytMaster
        Me.txtHargaJual4.TabIndex = 117
        '
        'txtHargaJual5
        '
        Me.txtHargaJual5.Location = New System.Drawing.Point(318, 190)
        Me.txtHargaJual5.Name = "txtHargaJual5"
        Me.txtHargaJual5.Properties.Appearance.Options.UseTextOptions = True
        Me.txtHargaJual5.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtHargaJual5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtHargaJual5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHargaJual5.Properties.DisplayFormat.FormatString = "n0"
        Me.txtHargaJual5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual5.Properties.EditFormat.FormatString = "n0"
        Me.txtHargaJual5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual5.Properties.Mask.EditMask = "n0"
        Me.txtHargaJual5.Size = New System.Drawing.Size(127, 20)
        Me.txtHargaJual5.StyleController = Me.lytMaster
        Me.txtHargaJual5.TabIndex = 119
        '
        'txtAkunPersediaan
        '
        Me.txtAkunPersediaan.Location = New System.Drawing.Point(113, 65)
        Me.txtAkunPersediaan.Name = "txtAkunPersediaan"
        Me.txtAkunPersediaan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtAkunPersediaan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAkunPersediaan.Properties.DisplayMember = "Kode"
        Me.txtAkunPersediaan.Properties.NullText = "<Pilih Akun>"
        Me.txtAkunPersediaan.Properties.PopupSizeable = False
        Me.txtAkunPersediaan.Properties.ValueMember = "This"
        Me.txtAkunPersediaan.Properties.View = Me.SearchLookUpEdit1View
        Me.txtAkunPersediaan.Size = New System.Drawing.Size(114, 20)
        Me.txtAkunPersediaan.StyleController = Me.lytMaster
        Me.txtAkunPersediaan.TabIndex = 142
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsFind.AlwaysVisible = True
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.SearchLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Kode"
        Me.GridColumn1.FieldName = "Kode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 276
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nama"
        Me.GridColumn2.FieldName = "Nama"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 802
        '
        'txtAkunPendapatan
        '
        Me.txtAkunPendapatan.Location = New System.Drawing.Point(113, 89)
        Me.txtAkunPendapatan.Name = "txtAkunPendapatan"
        Me.txtAkunPendapatan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtAkunPendapatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAkunPendapatan.Properties.DisplayMember = "Kode"
        Me.txtAkunPendapatan.Properties.NullText = "<Pilih Akun>"
        Me.txtAkunPendapatan.Properties.ValueMember = "This"
        Me.txtAkunPendapatan.Properties.View = Me.GridView1
        Me.txtAkunPendapatan.Size = New System.Drawing.Size(114, 20)
        Me.txtAkunPendapatan.StyleController = Me.lytMaster
        Me.txtAkunPendapatan.TabIndex = 111
        '
        'GridView1
        '
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Kode"
        Me.GridColumn3.FieldName = "Kode"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 276
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Nama"
        Me.GridColumn4.FieldName = "Nama"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 802
        '
        'txtAkunDiscPembelian
        '
        Me.txtAkunDiscPembelian.Location = New System.Drawing.Point(113, 113)
        Me.txtAkunDiscPembelian.Name = "txtAkunDiscPembelian"
        Me.txtAkunDiscPembelian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtAkunDiscPembelian.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAkunDiscPembelian.Properties.DisplayMember = "Kode"
        Me.txtAkunDiscPembelian.Properties.NullText = "<Pilih Akun>"
        Me.txtAkunDiscPembelian.Properties.ValueMember = "This"
        Me.txtAkunDiscPembelian.Properties.View = Me.GridView2
        Me.txtAkunDiscPembelian.Size = New System.Drawing.Size(114, 20)
        Me.txtAkunDiscPembelian.StyleController = Me.lytMaster
        Me.txtAkunDiscPembelian.TabIndex = 117
        '
        'GridView2
        '
        Me.GridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsFind.AlwaysVisible = True
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn5, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Kode"
        Me.GridColumn5.FieldName = "Kode"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 276
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Nama"
        Me.GridColumn6.FieldName = "Nama"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 802
        '
        'txtAkunDiscPenjualan
        '
        Me.txtAkunDiscPenjualan.Location = New System.Drawing.Point(113, 137)
        Me.txtAkunDiscPenjualan.Name = "txtAkunDiscPenjualan"
        Me.txtAkunDiscPenjualan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtAkunDiscPenjualan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAkunDiscPenjualan.Properties.DisplayMember = "Kode"
        Me.txtAkunDiscPenjualan.Properties.NullText = "<Pilih Akun>"
        Me.txtAkunDiscPenjualan.Properties.ValueMember = "This"
        Me.txtAkunDiscPenjualan.Properties.View = Me.GridView3
        Me.txtAkunDiscPenjualan.Size = New System.Drawing.Size(114, 20)
        Me.txtAkunDiscPenjualan.StyleController = Me.lytMaster
        Me.txtAkunDiscPenjualan.TabIndex = 115
        '
        'GridView3
        '
        Me.GridView3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsFind.AlwaysVisible = True
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn7, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Kode"
        Me.GridColumn7.FieldName = "Kode"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        Me.GridColumn7.Width = 276
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Nama"
        Me.GridColumn8.FieldName = "Nama"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 802
        '
        'txtAkunReturPembelian
        '
        Me.txtAkunReturPembelian.Location = New System.Drawing.Point(331, 65)
        Me.txtAkunReturPembelian.Name = "txtAkunReturPembelian"
        Me.txtAkunReturPembelian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtAkunReturPembelian.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAkunReturPembelian.Properties.DisplayMember = "Kode"
        Me.txtAkunReturPembelian.Properties.NullText = "<Pilih Akun>"
        Me.txtAkunReturPembelian.Properties.ValueMember = "This"
        Me.txtAkunReturPembelian.Properties.View = Me.GridView4
        Me.txtAkunReturPembelian.Size = New System.Drawing.Size(114, 20)
        Me.txtAkunReturPembelian.StyleController = Me.lytMaster
        Me.txtAkunReturPembelian.TabIndex = 121
        '
        'GridView4
        '
        Me.GridView4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn10})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsFind.AlwaysVisible = True
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn9, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Kode"
        Me.GridColumn9.FieldName = "Kode"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        Me.GridColumn9.Width = 276
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Nama"
        Me.GridColumn10.FieldName = "Nama"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 1
        Me.GridColumn10.Width = 802
        '
        'txtAkunReturPenjualan
        '
        Me.txtAkunReturPenjualan.Location = New System.Drawing.Point(331, 89)
        Me.txtAkunReturPenjualan.Name = "txtAkunReturPenjualan"
        Me.txtAkunReturPenjualan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtAkunReturPenjualan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAkunReturPenjualan.Properties.DisplayMember = "Kode"
        Me.txtAkunReturPenjualan.Properties.NullText = "<Pilih Akun>"
        Me.txtAkunReturPenjualan.Properties.ValueMember = "This"
        Me.txtAkunReturPenjualan.Properties.View = Me.GridView5
        Me.txtAkunReturPenjualan.Size = New System.Drawing.Size(114, 20)
        Me.txtAkunReturPenjualan.StyleController = Me.lytMaster
        Me.txtAkunReturPenjualan.TabIndex = 119
        '
        'GridView5
        '
        Me.GridView5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn12})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsFind.AlwaysVisible = True
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn11, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Kode"
        Me.GridColumn11.FieldName = "Kode"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 0
        Me.GridColumn11.Width = 276
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Nama"
        Me.GridColumn12.FieldName = "Nama"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 1
        Me.GridColumn12.Width = 802
        '
        'txtAkunHPP
        '
        Me.txtAkunHPP.Location = New System.Drawing.Point(331, 113)
        Me.txtAkunHPP.Name = "txtAkunHPP"
        Me.txtAkunHPP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtAkunHPP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAkunHPP.Properties.DisplayMember = "Kode"
        Me.txtAkunHPP.Properties.NullText = "<Pilih Akun>"
        Me.txtAkunHPP.Properties.ValueMember = "This"
        Me.txtAkunHPP.Properties.View = Me.GridView6
        Me.txtAkunHPP.Size = New System.Drawing.Size(114, 20)
        Me.txtAkunHPP.StyleController = Me.lytMaster
        Me.txtAkunHPP.TabIndex = 113
        '
        'GridView6
        '
        Me.GridView6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn14})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsFind.AlwaysVisible = True
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        Me.GridView6.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn13, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Kode"
        Me.GridColumn13.FieldName = "Kode"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        Me.GridColumn13.Width = 276
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Nama"
        Me.GridColumn14.FieldName = "Nama"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 1
        Me.GridColumn14.Width = 802
        '
        'txtFeeAgen
        '
        Me.txtFeeAgen.Location = New System.Drawing.Point(317, 110)
        Me.txtFeeAgen.Name = "txtFeeAgen"
        Me.txtFeeAgen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFeeAgen.Properties.DisplayFormat.FormatString = "n0"
        Me.txtFeeAgen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFeeAgen.Properties.EditFormat.FormatString = "n0"
        Me.txtFeeAgen.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFeeAgen.Properties.Mask.EditMask = "n0"
        Me.txtFeeAgen.Size = New System.Drawing.Size(140, 20)
        Me.txtFeeAgen.StyleController = Me.lytMaster
        Me.txtFeeAgen.TabIndex = 157
        '
        'txtSatuan
        '
        Me.txtSatuan.Location = New System.Drawing.Point(101, 134)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtSatuan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSatuan.Properties.DisplayMember = "Kode"
        Me.txtSatuan.Properties.NullText = "<Pilih Satuan>"
        Me.txtSatuan.Properties.ValueMember = "This"
        Me.txtSatuan.Properties.View = Me.GridView7
        Me.txtSatuan.Size = New System.Drawing.Size(162, 20)
        Me.txtSatuan.StyleController = Me.lytMaster
        Me.txtSatuan.TabIndex = 109
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSKode, Me.colSNama})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colSKode
        '
        Me.colSKode.Caption = "Kode"
        Me.colSKode.FieldName = "Kode"
        Me.colSKode.Name = "colSKode"
        Me.colSKode.Visible = True
        Me.colSKode.VisibleIndex = 0
        Me.colSKode.Width = 90
        '
        'colSNama
        '
        Me.colSNama.Caption = "Nama"
        Me.colSNama.FieldName = "Nama"
        Me.colSNama.Name = "colSNama"
        Me.colSNama.Visible = True
        Me.colSNama.VisibleIndex = 1
        Me.colSNama.Width = 294
        '
        'txtSatuanDasar
        '
        Me.txtSatuanDasar.Location = New System.Drawing.Point(101, 158)
        Me.txtSatuanDasar.Name = "txtSatuanDasar"
        Me.txtSatuanDasar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtSatuanDasar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSatuanDasar.Properties.DisplayMember = "Kode"
        Me.txtSatuanDasar.Properties.NullText = "<Pilih Satuan Dasar>"
        Me.txtSatuanDasar.Properties.ValueMember = "This"
        Me.txtSatuanDasar.Properties.View = Me.GridView8
        Me.txtSatuanDasar.Size = New System.Drawing.Size(162, 20)
        Me.txtSatuanDasar.StyleController = Me.lytMaster
        Me.txtSatuanDasar.TabIndex = 107
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSDKode, Me.colSDNama})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'colSDKode
        '
        Me.colSDKode.Caption = "Kode"
        Me.colSDKode.FieldName = "Kode"
        Me.colSDKode.Name = "colSDKode"
        Me.colSDKode.Visible = True
        Me.colSDKode.VisibleIndex = 0
        Me.colSDKode.Width = 90
        '
        'colSDNama
        '
        Me.colSDNama.Caption = "Nama"
        Me.colSDNama.FieldName = "Nama"
        Me.colSDNama.Name = "colSDNama"
        Me.colSDNama.Visible = True
        Me.colSDNama.VisibleIndex = 1
        Me.colSDNama.Width = 294
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.CustomizationFormText = "Custom"
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lytCustom1, Me.lytCustom3, Me.lytCustom6, Me.lytCustom7, Me.lytCustom2, Me.lytCustom8, Me.lytCustom9, Me.lytCustom4, Me.lytCustom10, Me.lytCustom5})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(445, 209)
        Me.LayoutControlGroup6.Text = "Custom"
        '
        'lytCustom1
        '
        Me.lytCustom1.Control = Me.txtCustom1
        Me.lytCustom1.CustomizationFormText = "Custom 1"
        Me.lytCustom1.Location = New System.Drawing.Point(0, 0)
        Me.lytCustom1.Name = "lytCustom1"
        Me.lytCustom1.Size = New System.Drawing.Size(220, 24)
        Me.lytCustom1.Text = "Custom 1"
        Me.lytCustom1.TextSize = New System.Drawing.Size(51, 13)
        '
        'lytCustom3
        '
        Me.lytCustom3.Control = Me.txtCustom3
        Me.lytCustom3.CustomizationFormText = "Custom 3"
        Me.lytCustom3.Location = New System.Drawing.Point(0, 48)
        Me.lytCustom3.Name = "lytCustom3"
        Me.lytCustom3.Size = New System.Drawing.Size(220, 24)
        Me.lytCustom3.Text = "Custom 3"
        Me.lytCustom3.TextSize = New System.Drawing.Size(51, 13)
        '
        'lytCustom6
        '
        Me.lytCustom6.Control = Me.txtCustom6
        Me.lytCustom6.CustomizationFormText = "Custom 6"
        Me.lytCustom6.Location = New System.Drawing.Point(220, 0)
        Me.lytCustom6.Name = "lytCustom6"
        Me.lytCustom6.Size = New System.Drawing.Size(225, 24)
        Me.lytCustom6.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.lytCustom6.Text = "Custom 6"
        Me.lytCustom6.TextSize = New System.Drawing.Size(51, 13)
        '
        'lytCustom7
        '
        Me.lytCustom7.Control = Me.txtCustom7
        Me.lytCustom7.CustomizationFormText = "Custom 7"
        Me.lytCustom7.Location = New System.Drawing.Point(220, 24)
        Me.lytCustom7.Name = "lytCustom7"
        Me.lytCustom7.Size = New System.Drawing.Size(225, 24)
        Me.lytCustom7.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.lytCustom7.Text = "Custom 7"
        Me.lytCustom7.TextSize = New System.Drawing.Size(51, 13)
        '
        'lytCustom2
        '
        Me.lytCustom2.Control = Me.txtCustom2
        Me.lytCustom2.CustomizationFormText = "Custom 2"
        Me.lytCustom2.Location = New System.Drawing.Point(0, 24)
        Me.lytCustom2.Name = "lytCustom2"
        Me.lytCustom2.Size = New System.Drawing.Size(220, 24)
        Me.lytCustom2.Text = "Custom 2"
        Me.lytCustom2.TextSize = New System.Drawing.Size(51, 13)
        '
        'lytCustom8
        '
        Me.lytCustom8.Control = Me.txtCustom8
        Me.lytCustom8.CustomizationFormText = "Custom 8"
        Me.lytCustom8.Location = New System.Drawing.Point(220, 48)
        Me.lytCustom8.Name = "lytCustom8"
        Me.lytCustom8.Size = New System.Drawing.Size(225, 24)
        Me.lytCustom8.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.lytCustom8.Text = "Custom 8"
        Me.lytCustom8.TextSize = New System.Drawing.Size(51, 13)
        '
        'lytCustom9
        '
        Me.lytCustom9.Control = Me.txtCustom9
        Me.lytCustom9.CustomizationFormText = "Custom 9"
        Me.lytCustom9.Location = New System.Drawing.Point(220, 72)
        Me.lytCustom9.Name = "lytCustom9"
        Me.lytCustom9.Size = New System.Drawing.Size(225, 24)
        Me.lytCustom9.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.lytCustom9.Text = "Custom 9"
        Me.lytCustom9.TextSize = New System.Drawing.Size(51, 13)
        '
        'lytCustom4
        '
        Me.lytCustom4.Control = Me.txtCustom4
        Me.lytCustom4.CustomizationFormText = "Custom 4"
        Me.lytCustom4.Location = New System.Drawing.Point(0, 72)
        Me.lytCustom4.Name = "lytCustom4"
        Me.lytCustom4.Size = New System.Drawing.Size(220, 24)
        Me.lytCustom4.Text = "Custom 4"
        Me.lytCustom4.TextSize = New System.Drawing.Size(51, 13)
        '
        'lytCustom10
        '
        Me.lytCustom10.Control = Me.txtCustom10
        Me.lytCustom10.CustomizationFormText = "Custom 10"
        Me.lytCustom10.Location = New System.Drawing.Point(220, 96)
        Me.lytCustom10.Name = "lytCustom10"
        Me.lytCustom10.Size = New System.Drawing.Size(225, 113)
        Me.lytCustom10.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.lytCustom10.Text = "Custom 10"
        Me.lytCustom10.TextSize = New System.Drawing.Size(51, 13)
        '
        'lytCustom5
        '
        Me.lytCustom5.Control = Me.txtCustom5
        Me.lytCustom5.CustomizationFormText = "Custom 5"
        Me.lytCustom5.Location = New System.Drawing.Point(0, 96)
        Me.lytCustom5.Name = "lytCustom5"
        Me.lytCustom5.Size = New System.Drawing.Size(220, 113)
        Me.lytCustom5.Text = "Custom 5"
        Me.lytCustom5.TextSize = New System.Drawing.Size(51, 13)
        '
        'LayoutControlGroup11
        '
        Me.LayoutControlGroup11.CustomizationFormText = "Spesifikasi"
        Me.LayoutControlGroup11.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem36, Me.LayoutControlItem37, Me.LayoutControlItem38, Me.LayoutControlItem39, Me.LayoutControlItem34})
        Me.LayoutControlGroup11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup11.Name = "LayoutControlGroup11"
        Me.LayoutControlGroup11.Size = New System.Drawing.Size(445, 209)
        Me.LayoutControlGroup11.Text = "Spesifikasi"
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.txtOD
        Me.LayoutControlItem36.CustomizationFormText = "Out Diameter"
        Me.LayoutControlItem36.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(445, 24)
        Me.LayoutControlItem36.Text = "Out Diameter"
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.Control = Me.txtID
        Me.LayoutControlItem37.CustomizationFormText = "In Diameter"
        Me.LayoutControlItem37.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(445, 24)
        Me.LayoutControlItem37.Text = "In Diameter"
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.Control = Me.txtThickness
        Me.LayoutControlItem38.CustomizationFormText = "Thickness"
        Me.LayoutControlItem38.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(445, 24)
        Me.LayoutControlItem38.Text = "Thickness"
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.Control = Me.txtBarcode
        Me.LayoutControlItem39.CustomizationFormText = "Barcode"
        Me.LayoutControlItem39.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(445, 113)
        Me.LayoutControlItem39.Text = "Barcode"
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.txtLength
        Me.LayoutControlItem34.CustomizationFormText = "Length"
        Me.LayoutControlItem34.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(445, 24)
        Me.LayoutControlItem34.Text = "Length"
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.tabBarangDialog})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(473, 259)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'tabBarangDialog
        '
        Me.tabBarangDialog.CustomizationFormText = "TabbedControlGroup1"
        Me.tabBarangDialog.Location = New System.Drawing.Point(0, 0)
        Me.tabBarangDialog.Name = "tabBarangDialog"
        Me.tabBarangDialog.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.tabBarangDialog.SelectedTabPage = Me.tabBarangDialogGeneral
        Me.tabBarangDialog.SelectedTabPageIndex = 0
        Me.tabBarangDialog.Size = New System.Drawing.Size(453, 239)
        Me.tabBarangDialog.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.tabBarangDialogGeneral, Me.lytSettingAkuntansi, Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.LayoutControlGroup10})
        Me.tabBarangDialog.Text = "tabBarangDialog"
        '
        'tabBarangDialogGeneral
        '
        Me.tabBarangDialogGeneral.CustomizationFormText = "General"
        Me.tabBarangDialogGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlGroup7, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem7, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem33, Me.EmptySpaceItem2, Me.LayoutControlItem28})
        Me.tabBarangDialogGeneral.Location = New System.Drawing.Point(0, 0)
        Me.tabBarangDialogGeneral.Name = "tabBarangDialogGeneral"
        Me.tabBarangDialogGeneral.Size = New System.Drawing.Size(445, 209)
        Me.tabBarangDialogGeneral.Text = "General"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtKode
        Me.LayoutControlItem1.CustomizationFormText = "Kode"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(251, 24)
        Me.LayoutControlItem1.Text = "Part No"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup7.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup7.CustomizationFormText = "Harga Jual"
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13})
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(251, 25)
        Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(194, 184)
        Me.LayoutControlGroup7.Text = "Harga Jual"
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtHargaJual1
        Me.LayoutControlItem9.CustomizationFormText = "Level 1"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(170, 24)
        Me.LayoutControlItem9.Text = "Level 1"
        Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(34, 13)
        Me.LayoutControlItem9.TextToControlDistance = 5
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtHargaJual2
        Me.LayoutControlItem10.CustomizationFormText = "Level 2"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(170, 24)
        Me.LayoutControlItem10.Text = "Level 2"
        Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(34, 13)
        Me.LayoutControlItem10.TextToControlDistance = 5
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtHargaJual3
        Me.LayoutControlItem11.CustomizationFormText = "Level 3"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(170, 24)
        Me.LayoutControlItem11.Text = "Level 3"
        Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(34, 13)
        Me.LayoutControlItem11.TextToControlDistance = 5
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtHargaJual4
        Me.LayoutControlItem12.CustomizationFormText = "Level 4"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(170, 24)
        Me.LayoutControlItem12.Text = "Level 4"
        Me.LayoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(34, 20)
        Me.LayoutControlItem12.TextToControlDistance = 5
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtHargaJual5
        Me.LayoutControlItem13.CustomizationFormText = "Level 5"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(170, 45)
        Me.LayoutControlItem13.Text = "Level 5"
        Me.LayoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(34, 20)
        Me.LayoutControlItem13.TextToControlDistance = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtNama
        Me.LayoutControlItem2.CustomizationFormText = "Nama"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(251, 24)
        Me.LayoutControlItem2.Text = "Material"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtSatuan
        Me.LayoutControlItem3.CustomizationFormText = "Satuan"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(251, 24)
        Me.LayoutControlItem3.Text = "Satuan"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtSatuanDasar
        Me.LayoutControlItem4.CustomizationFormText = "Satuan Dasar"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(251, 24)
        Me.LayoutControlItem4.Text = "Satuan Dasar"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtUang
        Me.LayoutControlItem7.CustomizationFormText = "Uang"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(251, 24)
        Me.LayoutControlItem7.Text = "Uang"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtJenis
        Me.LayoutControlItem5.CustomizationFormText = "Jenis"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(251, 24)
        Me.LayoutControlItem5.Text = "Jenis"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtTipe
        Me.LayoutControlItem6.CustomizationFormText = "Tipe"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(251, 24)
        Me.LayoutControlItem6.Text = "Tipe"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.txtHargaBeli
        Me.LayoutControlItem33.CustomizationFormText = "Harga Beli"
        Me.LayoutControlItem33.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(251, 41)
        Me.LayoutControlItem33.Text = "Harga Beli"
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(82, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(251, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(139, 25)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.txtAktif
        Me.LayoutControlItem28.CustomizationFormText = "Aktif"
        Me.LayoutControlItem28.Location = New System.Drawing.Point(390, 0)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(55, 25)
        Me.LayoutControlItem28.Text = "Aktif"
        Me.LayoutControlItem28.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem28.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(23, 13)
        Me.LayoutControlItem28.TextToControlDistance = 5
        '
        'lytSettingAkuntansi
        '
        Me.lytSettingAkuntansi.CustomizationFormText = "Akuntansi"
        Me.lytSettingAkuntansi.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup8, Me.LayoutControlGroup9})
        Me.lytSettingAkuntansi.Location = New System.Drawing.Point(0, 0)
        Me.lytSettingAkuntansi.Name = "lytSettingAkuntansi"
        Me.lytSettingAkuntansi.Size = New System.Drawing.Size(445, 209)
        Me.lytSettingAkuntansi.Text = "Akuntansi"
        '
        'LayoutControlGroup8
        '
        Me.LayoutControlGroup8.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup8.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup8.CustomizationFormText = "Akun"
        Me.LayoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem15, Me.LayoutControlItem17, Me.LayoutControlItem21, Me.LayoutControlItem20, Me.LayoutControlItem16, Me.LayoutControlItem19, Me.LayoutControlItem18})
        Me.LayoutControlGroup8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup8.Name = "LayoutControlGroup8"
        Me.LayoutControlGroup8.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 5, 5)
        Me.LayoutControlGroup8.Size = New System.Drawing.Size(445, 131)
        Me.LayoutControlGroup8.Text = "Akun"
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtAkunPersediaan
        Me.LayoutControlItem15.CustomizationFormText = "Persediaan"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(203, 24)
        Me.LayoutControlItem15.Text = "Persediaan"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.txtAkunHPP
        Me.LayoutControlItem17.CustomizationFormText = "HPP"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(203, 48)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(218, 48)
        Me.LayoutControlItem17.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.LayoutControlItem17.Text = "HPP"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtAkunReturPembelian
        Me.LayoutControlItem21.CustomizationFormText = "Retur Pembelian"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(203, 0)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(218, 24)
        Me.LayoutControlItem21.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.LayoutControlItem21.Text = "Retur Pembelian"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.txtAkunReturPenjualan
        Me.LayoutControlItem20.CustomizationFormText = "Retur Penjualan"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(203, 24)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(218, 24)
        Me.LayoutControlItem20.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.LayoutControlItem20.Text = "Retur Penjualan"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtAkunPendapatan
        Me.LayoutControlItem16.CustomizationFormText = "Pendapatan"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(203, 24)
        Me.LayoutControlItem16.Text = "Pendapatan"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txtAkunDiscPembelian
        Me.LayoutControlItem19.CustomizationFormText = "Diskon Pembelian"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(203, 24)
        Me.LayoutControlItem19.Text = "Diskon Pembelian"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtAkunDiscPenjualan
        Me.LayoutControlItem18.CustomizationFormText = "Diskon Penjualan"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(203, 24)
        Me.LayoutControlItem18.Text = "Diskon Penjualan"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlGroup9
        '
        Me.LayoutControlGroup9.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup9.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup9.CustomizationFormText = "Pajak"
        Me.LayoutControlGroup9.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem22, Me.LayoutControlItem23})
        Me.LayoutControlGroup9.Location = New System.Drawing.Point(0, 131)
        Me.LayoutControlGroup9.Name = "LayoutControlGroup9"
        Me.LayoutControlGroup9.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 5, 5)
        Me.LayoutControlGroup9.Size = New System.Drawing.Size(445, 78)
        Me.LayoutControlGroup9.Text = "Pajak"
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtPajakIn
        Me.LayoutControlItem22.CustomizationFormText = "Pajak IN"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(202, 43)
        Me.LayoutControlItem22.Text = "Pajak IN"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.txtPajakOut
        Me.LayoutControlItem23.CustomizationFormText = "Pajak Out"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(202, 0)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(219, 43)
        Me.LayoutControlItem23.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.LayoutControlItem23.Text = "Pajak Out"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "Lokasi"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem14})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(445, 209)
        Me.LayoutControlGroup4.Text = "Lokasi"
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.xGridLokasi
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(445, 209)
        Me.LayoutControlItem14.Text = "LayoutControlItem14"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextToControlDistance = 0
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "Produksi"
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(445, 209)
        Me.LayoutControlGroup5.Text = "Produksi"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Bahan Penyusun Produksi"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(445, 209)
        Me.LayoutControlGroup2.Text = "Bahan Penyusun Produksi"
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.xGridPenyusun
        Me.LayoutControlItem8.CustomizationFormText = "Bahan Penyusun"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(437, 182)
        Me.LayoutControlItem8.Text = "Bahan Penyusun"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextToControlDistance = 0
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlGroup10
        '
        Me.LayoutControlGroup10.CustomizationFormText = "Lain-lain"
        Me.LayoutControlGroup10.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem32, Me.LayoutControlItem29, Me.LayoutControlItem26, Me.LayoutControlItem27, Me.LayoutControlItem24, Me.LayoutControlItem30, Me.LayoutControlItem25, Me.LayoutControlItem31, Me.LayoutControlItem35})
        Me.LayoutControlGroup10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup10.Name = "LayoutControlGroup10"
        Me.LayoutControlGroup10.Size = New System.Drawing.Size(445, 209)
        Me.LayoutControlGroup10.Text = "Lain-lain"
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem32.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LayoutControlItem32.Control = Me.txtNote
        Me.LayoutControlItem32.CustomizationFormText = "Note"
        Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(445, 113)
        Me.LayoutControlItem32.Text = "Note"
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.txtKategori
        Me.LayoutControlItem29.CustomizationFormText = "Kategori"
        Me.LayoutControlItem29.Location = New System.Drawing.Point(220, 0)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(225, 24)
        Me.LayoutControlItem29.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.LayoutControlItem29.Text = "Kategori"
        Me.LayoutControlItem29.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(61, 13)
        Me.LayoutControlItem29.TextToControlDistance = 5
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.txtStockCurrent
        Me.LayoutControlItem26.CustomizationFormText = "Stock"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(220, 24)
        Me.LayoutControlItem26.Text = "Stock"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.txtStockOrder
        Me.LayoutControlItem27.CustomizationFormText = "Stock Order"
        Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(220, 24)
        Me.LayoutControlItem27.Text = "Stock Order"
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.txtStockMax
        Me.LayoutControlItem24.CustomizationFormText = "Stock Maksimal"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(220, 24)
        Me.LayoutControlItem24.Text = "Stock Maksimal"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.txtSubKategori
        Me.LayoutControlItem30.CustomizationFormText = "Sub Kategori"
        Me.LayoutControlItem30.Location = New System.Drawing.Point(220, 24)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(225, 24)
        Me.LayoutControlItem30.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.LayoutControlItem30.Text = "Sub Kategori"
        Me.LayoutControlItem30.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(61, 13)
        Me.LayoutControlItem30.TextToControlDistance = 5
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.txtStockMin
        Me.LayoutControlItem25.CustomizationFormText = "Stock Minimal"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(220, 24)
        Me.LayoutControlItem25.Text = "Stock Minimal"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.txtMerk
        Me.LayoutControlItem31.CustomizationFormText = "Merk"
        Me.LayoutControlItem31.Location = New System.Drawing.Point(220, 48)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(225, 24)
        Me.LayoutControlItem31.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.LayoutControlItem31.Text = "Merk"
        Me.LayoutControlItem31.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(61, 13)
        Me.LayoutControlItem31.TextToControlDistance = 5
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.Control = Me.txtFeeAgen
        Me.LayoutControlItem35.CustomizationFormText = "Fee Agen"
        Me.LayoutControlItem35.Location = New System.Drawing.Point(220, 72)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(225, 24)
        Me.LayoutControlItem35.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.LayoutControlItem35.Text = "Fee Agen"
        Me.LayoutControlItem35.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(61, 13)
        Me.LayoutControlItem35.TextToControlDistance = 5
        '
        'xpSatuan
        '
        Me.xpSatuan.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Coa)
        '
        'UI_BarangDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 308)
        Me.Controls.Add(Me.lytMaster)
        Me.Name = "UI_BarangDialog"
        Me.Text = "Master ITEM"
        Me.Controls.SetChildIndex(Me.lytMaster, 0)
        CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lytMaster.ResumeLayout(False)
        CType(Me.txtCustom10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustom9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustom8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustom7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustom6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustom5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustom4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustom2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustom3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustom1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLength.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThickness.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridPenyusun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridPenyusunView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colKodeBarangRepo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colKodeBarangRepoSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHargaBeli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMerk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubKategori.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKategori.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAktif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockCurrent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockMin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockMax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridLokasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridLokasiView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colGudangRepo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPajakOut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPajakIn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHargaJual1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHargaJual2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHargaJual3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHargaJual4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHargaJual5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAkunPersediaan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAkunPendapatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAkunDiscPembelian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAkunDiscPenjualan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAkunReturPembelian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAkunReturPenjualan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAkunHPP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFeeAgen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSatuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSatuanDasar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytCustom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytCustom3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytCustom6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytCustom7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytCustom2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytCustom8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytCustom9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytCustom4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytCustom10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytCustom5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabBarangDialog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabBarangDialogGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytSettingAkuntansi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xpSatuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNama As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtKode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtPajakOut As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtPajakIn As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtJenis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents xpSatuan As DevExpress.Xpo.XPCollection
    Friend WithEvents xGridLokasi As DevExpress.XtraGrid.GridControl
    Friend WithEvents xGridLokasiView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGudang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLokasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGudangRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtTipe As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtCustom1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustom2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustom4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustom3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustom5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lytMaster As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents tabBarangDialog As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents tabBarangDialogGeneral As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lytSettingAkuntansi As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lytCustom1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lytCustom2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lytCustom3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lytCustom5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lytCustom4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup9 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtCustom10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustom9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustom8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustom7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustom6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lytCustom6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lytCustom7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lytCustom8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lytCustom9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lytCustom10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup10 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtStockMax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtStockCurrent As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStockMin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtAktif As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtStockOrder As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtKategori As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtSubKategori As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtMerk As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtHargaBeli As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtHargaJual1 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtHargaJual2 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtHargaJual3 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtHargaJual4 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtHargaJual5 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents xGridPenyusun As DevExpress.XtraGrid.GridControl
    Friend WithEvents xGridPenyusunView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKodeBarangRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents colKodeBarangRepoSearch As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSatuanRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcSatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAkunPersediaan As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAkunPendapatan As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAkunDiscPembelian As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAkunDiscPenjualan As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAkunReturPembelian As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAkunReturPenjualan As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAkunHPP As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlGroup11 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtOD As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtLength As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtBarcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtThickness As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtID As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtFeeAgen As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtSatuan As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtSatuanDasar As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSDKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSDNama As DevExpress.XtraGrid.Columns.GridColumn
End Class
