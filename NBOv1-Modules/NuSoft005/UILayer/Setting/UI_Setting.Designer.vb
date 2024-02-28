<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Setting
  Inherits Core.Win.Forms.DialogForm

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
		Me.xpColTipeKontak = New DevExpress.Xpo.XPCollection()
		Me.xpCOA = New DevExpress.Xpo.XPCollection()
		Me.chkPreview = New DevExpress.XtraEditors.CheckEdit()
		Me.lytSetting = New DevExpress.XtraLayout.LayoutControl()
		Me.txtBM = New DevExpress.XtraEditors.LookUpEdit()
		Me.xpPajak = New DevExpress.Xpo.XPCollection()
		Me.txtApprovePO = New DevExpress.XtraEditors.CheckEdit()
		Me.txtSettingCOAHutang = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtGudang = New DevExpress.XtraEditors.LookUpEdit()
		Me.xpGudang = New DevExpress.Xpo.XPCollection()
		Me.chkAPRegional = New DevExpress.XtraEditors.CheckEdit()
		Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
		Me.xpRegional = New DevExpress.Xpo.XPCollection()
		Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCoaRegionalRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
		Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
		Me.xpUang = New DevExpress.Xpo.XPCollection()
		Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHutangDagang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHutangDagangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
		Me.colUM = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colUMRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
		Me.txtFilterKontak = New DevExpress.XtraEditors.CheckEdit()
		Me.txtMultiPO = New DevExpress.XtraEditors.CheckEdit()
		Me.txtTipeKontak = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtVP = New DevExpress.XtraEditors.TextEdit()
		Me.txtRI = New DevExpress.XtraEditors.TextEdit()
		Me.txtGR = New DevExpress.XtraEditors.TextEdit()
		Me.txtPO = New DevExpress.XtraEditors.TextEdit()
		Me.txtDP = New DevExpress.XtraEditors.TextEdit()
		Me.txtRQ = New DevExpress.XtraEditors.TextEdit()
		Me.txtAuto = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtCoaHutangSementara = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtCoaPPN = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtCoaPPH = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtCoaBiaya = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtCoaPembulatan = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtCoaAdmin = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtCoaPendapatan = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.R = New DevExpress.XtraLayout.TabbedControlGroup()
		Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		Me.chkEditRI = New DevExpress.XtraEditors.CheckEdit()
		Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.txtSelisihRI = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colKode1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colNama1 = New DevExpress.XtraGrid.Columns.GridColumn()
		CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelControl1.SuspendLayout()
		CType(Me.xpColTipeKontak, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xpCOA, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chkPreview.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lytSetting, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.lytSetting.SuspendLayout()
		CType(Me.txtBM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xpPajak, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtApprovePO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtSettingCOAHutang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xpGudang, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chkAPRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xpRegional, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colCoaRegionalRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xpUang, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colHutangDagangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colUMRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtFilterKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtMultiPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTipeKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtVP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtGR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtDP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRQ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtAuto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCoaHutangSementara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCoaPPN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCoaPPH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCoaBiaya.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCoaPembulatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCoaAdmin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCoaPendapatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.R, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chkEditRI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtSelisihRI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btn1
		'
		Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
		Me.btn1.Appearance.Options.UseForeColor = True
		Me.btn1.Location = New System.Drawing.Point(197, 11)
		'
		'btn2
		'
		Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
		Me.btn2.Appearance.Options.UseForeColor = True
		Me.btn2.Location = New System.Drawing.Point(290, 11)
		'
		'PanelControl1
		'
		Me.PanelControl1.Location = New System.Drawing.Point(0, 361)
		Me.PanelControl1.Size = New System.Drawing.Size(424, 49)
		'
		'xpColTipeKontak
		'
		Me.xpColTipeKontak.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.TipeKontak)
		'
		'xpCOA
		'
		Me.xpCOA.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Coa)
		'
		'chkPreview
		'
		Me.chkPreview.Location = New System.Drawing.Point(24, 234)
		Me.chkPreview.Name = "chkPreview"
		Me.chkPreview.Properties.Caption = "Preview Report Setelah Simpan Transaksi"
		Me.chkPreview.Size = New System.Drawing.Size(376, 19)
		Me.chkPreview.StyleController = Me.lytSetting
		Me.chkPreview.TabIndex = 6
		'
		'lytSetting
		'
		Me.lytSetting.Controls.Add(Me.txtSelisihRI)
		Me.lytSetting.Controls.Add(Me.chkEditRI)
		Me.lytSetting.Controls.Add(Me.txtBM)
		Me.lytSetting.Controls.Add(Me.txtApprovePO)
		Me.lytSetting.Controls.Add(Me.txtSettingCOAHutang)
		Me.lytSetting.Controls.Add(Me.txtGudang)
		Me.lytSetting.Controls.Add(Me.chkAPRegional)
		Me.lytSetting.Controls.Add(Me.GridControl2)
		Me.lytSetting.Controls.Add(Me.GridControl1)
		Me.lytSetting.Controls.Add(Me.chkPreview)
		Me.lytSetting.Controls.Add(Me.txtFilterKontak)
		Me.lytSetting.Controls.Add(Me.txtMultiPO)
		Me.lytSetting.Controls.Add(Me.txtTipeKontak)
		Me.lytSetting.Controls.Add(Me.txtVP)
		Me.lytSetting.Controls.Add(Me.txtRI)
		Me.lytSetting.Controls.Add(Me.txtGR)
		Me.lytSetting.Controls.Add(Me.txtPO)
		Me.lytSetting.Controls.Add(Me.txtDP)
		Me.lytSetting.Controls.Add(Me.txtRQ)
		Me.lytSetting.Controls.Add(Me.txtAuto)
		Me.lytSetting.Controls.Add(Me.txtCoaHutangSementara)
		Me.lytSetting.Controls.Add(Me.txtCoaPPN)
		Me.lytSetting.Controls.Add(Me.txtCoaPPH)
		Me.lytSetting.Controls.Add(Me.txtCoaBiaya)
		Me.lytSetting.Controls.Add(Me.txtCoaPembulatan)
		Me.lytSetting.Controls.Add(Me.txtCoaAdmin)
		Me.lytSetting.Controls.Add(Me.txtCoaPendapatan)
		Me.lytSetting.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lytSetting.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem21, Me.LayoutControlGroup6, Me.LayoutControlItem14})
		Me.lytSetting.Location = New System.Drawing.Point(0, 0)
		Me.lytSetting.Name = "lytSetting"
		Me.lytSetting.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(513, 152, 250, 350)
		Me.lytSetting.Root = Me.LayoutControlGroup1
		Me.lytSetting.Size = New System.Drawing.Size(424, 361)
		Me.lytSetting.TabIndex = 9
		Me.lytSetting.Text = "LayoutControl1"
		'
		'txtBM
		'
		Me.txtBM.Location = New System.Drawing.Point(143, 257)
		Me.txtBM.Name = "txtBM"
		Me.txtBM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtBM.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NilaiPajak", "Nilai")})
		Me.txtBM.Properties.DataSource = Me.xpPajak
		Me.txtBM.Properties.DisplayMember = "Kode"
		Me.txtBM.Properties.NullText = "<Pilih Pajak>"
		Me.txtBM.Properties.ValueMember = "Id"
		Me.txtBM.Size = New System.Drawing.Size(257, 20)
		Me.txtBM.StyleController = Me.lytSetting
		Me.txtBM.TabIndex = 15
		'
		'xpPajak
		'
		Me.xpPajak.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Pajak)
		'
		'txtApprovePO
		'
		Me.txtApprovePO.Location = New System.Drawing.Point(24, 141)
		Me.txtApprovePO.Name = "txtApprovePO"
		Me.txtApprovePO.Properties.Caption = "Approval Purchase Order"
		Me.txtApprovePO.Size = New System.Drawing.Size(376, 19)
		Me.txtApprovePO.StyleController = Me.lytSetting
		Me.txtApprovePO.TabIndex = 14
		'
		'txtSettingCOAHutang
		'
		Me.txtSettingCOAHutang.Location = New System.Drawing.Point(143, 46)
		Me.txtSettingCOAHutang.Name = "txtSettingCOAHutang"
		Me.txtSettingCOAHutang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtSettingCOAHutang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Tipe")})
		Me.txtSettingCOAHutang.Properties.DisplayMember = "Value"
		Me.txtSettingCOAHutang.Properties.NullText = "<Pilih Tipe Hutang>"
		Me.txtSettingCOAHutang.Properties.ValueMember = "Key"
		Me.txtSettingCOAHutang.Size = New System.Drawing.Size(257, 20)
		Me.txtSettingCOAHutang.StyleController = Me.lytSetting
		Me.txtSettingCOAHutang.TabIndex = 13
		'
		'txtGudang
		'
		Me.txtGudang.Location = New System.Drawing.Point(143, 117)
		Me.txtGudang.Name = "txtGudang"
		Me.txtGudang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtGudang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
		Me.txtGudang.Properties.DataSource = Me.xpGudang
		Me.txtGudang.Properties.DisplayMember = "Kode"
		Me.txtGudang.Properties.NullText = "<Pilih Gudang>"
		Me.txtGudang.Properties.ValueMember = "Id"
		Me.txtGudang.Size = New System.Drawing.Size(257, 20)
		Me.txtGudang.StyleController = Me.lytSetting
		Me.txtGudang.TabIndex = 12
		'
		'xpGudang
		'
		Me.xpGudang.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Gudang)
		'
		'chkAPRegional
		'
		Me.chkAPRegional.Location = New System.Drawing.Point(24, 46)
		Me.chkAPRegional.Name = "chkAPRegional"
		Me.chkAPRegional.Properties.Caption = "Setting Hutang Dari Regional"
		Me.chkAPRegional.Size = New System.Drawing.Size(376, 19)
		Me.chkAPRegional.StyleController = Me.lytSetting
		Me.chkAPRegional.TabIndex = 11
		'
		'GridControl2
		'
		Me.GridControl2.DataSource = Me.xpRegional
		Me.GridControl2.Location = New System.Drawing.Point(24, 187)
		Me.GridControl2.MainView = Me.GridView2
		Me.GridControl2.Name = "GridControl2"
		Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colCoaRegionalRepo})
		Me.GridControl2.Size = New System.Drawing.Size(376, 150)
		Me.GridControl2.TabIndex = 10
		Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
		'
		'xpRegional
		'
		Me.xpRegional.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent.xRegional)
		'
		'GridView2
		'
		Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
		Me.GridView2.GridControl = Me.GridControl2
		Me.GridView2.Name = "GridView2"
		Me.GridView2.OptionsDetail.EnableMasterViewMode = False
		Me.GridView2.OptionsView.ShowGroupPanel = False
		'
		'GridColumn1
		'
		Me.GridColumn1.Caption = "Kode"
		Me.GridColumn1.FieldName = "Kode"
		Me.GridColumn1.Name = "GridColumn1"
		Me.GridColumn1.Visible = True
		Me.GridColumn1.VisibleIndex = 0
		Me.GridColumn1.Width = 63
		'
		'GridColumn2
		'
		Me.GridColumn2.Caption = "Nama"
		Me.GridColumn2.FieldName = "Nama"
		Me.GridColumn2.Name = "GridColumn2"
		Me.GridColumn2.Visible = True
		Me.GridColumn2.VisibleIndex = 1
		Me.GridColumn2.Width = 105
		'
		'GridColumn3
		'
		Me.GridColumn3.Caption = "Hutang"
		Me.GridColumn3.ColumnEdit = Me.colCoaRegionalRepo
		Me.GridColumn3.FieldName = "CoaAP"
		Me.GridColumn3.Name = "GridColumn3"
		Me.GridColumn3.Visible = True
		Me.GridColumn3.VisibleIndex = 2
		Me.GridColumn3.Width = 89
		'
		'colCoaRegionalRepo
		'
		Me.colCoaRegionalRepo.AutoHeight = False
		Me.colCoaRegionalRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colCoaRegionalRepo.DataSource = Me.xpCOA
		Me.colCoaRegionalRepo.DisplayMember = "Kode"
		Me.colCoaRegionalRepo.Name = "colCoaRegionalRepo"
		Me.colCoaRegionalRepo.NullText = "<Pilih COA>"
		Me.colCoaRegionalRepo.ValueMember = "This"
		Me.colCoaRegionalRepo.View = Me.RepositoryItemSearchLookUpEdit1View
		'
		'RepositoryItemSearchLookUpEdit1View
		'
		Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn16, Me.GridColumn17})
		Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
		Me.RepositoryItemSearchLookUpEdit1View.OptionsFind.AlwaysVisible = True
		Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
		Me.RepositoryItemSearchLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn16, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'GridColumn16
		'
		Me.GridColumn16.Caption = "Kode"
		Me.GridColumn16.FieldName = "Kode"
		Me.GridColumn16.Name = "GridColumn16"
		Me.GridColumn16.Visible = True
		Me.GridColumn16.VisibleIndex = 0
		Me.GridColumn16.Width = 276
		'
		'GridColumn17
		'
		Me.GridColumn17.Caption = "Nama"
		Me.GridColumn17.FieldName = "Nama"
		Me.GridColumn17.Name = "GridColumn17"
		Me.GridColumn17.Visible = True
		Me.GridColumn17.VisibleIndex = 1
		Me.GridColumn17.Width = 802
		'
		'GridControl1
		'
		Me.GridControl1.DataSource = Me.xpUang
		Me.GridControl1.Location = New System.Drawing.Point(24, 46)
		Me.GridControl1.MainView = Me.GridView1
		Me.GridControl1.Name = "GridControl1"
		Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colHutangDagangRepo, Me.colUMRepo})
		Me.GridControl1.Size = New System.Drawing.Size(376, 291)
		Me.GridControl1.TabIndex = 0
		Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
		'
		'xpUang
		'
		Me.xpUang.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.MataUang)
		'
		'GridView1
		'
		Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode, Me.colNama, Me.colHutangDagang, Me.colUM})
		Me.GridView1.GridControl = Me.GridControl1
		Me.GridView1.Name = "GridView1"
		Me.GridView1.OptionsDetail.EnableMasterViewMode = False
		Me.GridView1.OptionsView.ShowGroupPanel = False
		'
		'colKode
		'
		Me.colKode.Caption = "Kode"
		Me.colKode.FieldName = "Kode"
		Me.colKode.Name = "colKode"
		Me.colKode.Visible = True
		Me.colKode.VisibleIndex = 0
		Me.colKode.Width = 63
		'
		'colNama
		'
		Me.colNama.Caption = "Nama"
		Me.colNama.FieldName = "Nama"
		Me.colNama.Name = "colNama"
		Me.colNama.Visible = True
		Me.colNama.VisibleIndex = 1
		Me.colNama.Width = 105
		'
		'colHutangDagang
		'
		Me.colHutangDagang.Caption = "Hutang"
		Me.colHutangDagang.ColumnEdit = Me.colHutangDagangRepo
		Me.colHutangDagang.FieldName = "HutangDagang!"
		Me.colHutangDagang.Name = "colHutangDagang"
		Me.colHutangDagang.Visible = True
		Me.colHutangDagang.VisibleIndex = 2
		Me.colHutangDagang.Width = 89
		'
		'colHutangDagangRepo
		'
		Me.colHutangDagangRepo.AutoHeight = False
		Me.colHutangDagangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colHutangDagangRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 50, "Nama")})
		Me.colHutangDagangRepo.DataSource = Me.xpCOA
		Me.colHutangDagangRepo.DisplayMember = "Kode"
		Me.colHutangDagangRepo.Name = "colHutangDagangRepo"
		Me.colHutangDagangRepo.NullText = "<Pilih COA>"
		Me.colHutangDagangRepo.ValueMember = "This"
		'
		'colUM
		'
		Me.colUM.Caption = "Uang Muka"
		Me.colUM.ColumnEdit = Me.colUMRepo
		Me.colUM.FieldName = "UMPembelian!"
		Me.colUM.Name = "colUM"
		Me.colUM.Visible = True
		Me.colUM.VisibleIndex = 3
		Me.colUM.Width = 93
		'
		'colUMRepo
		'
		Me.colUMRepo.AutoHeight = False
		Me.colUMRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colUMRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 50, "Nama")})
		Me.colUMRepo.DataSource = Me.xpCOA
		Me.colUMRepo.DisplayMember = "Kode"
		Me.colUMRepo.Name = "colUMRepo"
		Me.colUMRepo.NullText = "<Pilih Coa>"
		Me.colUMRepo.ValueMember = "This"
		'
		'txtFilterKontak
		'
		Me.txtFilterKontak.Location = New System.Drawing.Point(24, 70)
		Me.txtFilterKontak.Name = "txtFilterKontak"
		Me.txtFilterKontak.Properties.Caption = "Filter Kontak"
		Me.txtFilterKontak.Size = New System.Drawing.Size(376, 19)
		Me.txtFilterKontak.StyleController = Me.lytSetting
		Me.txtFilterKontak.TabIndex = 5
		'
		'txtMultiPO
		'
		Me.txtMultiPO.Location = New System.Drawing.Point(24, 164)
		Me.txtMultiPO.Name = "txtMultiPO"
		Me.txtMultiPO.Properties.Caption = "Multi PO Pada Transaksi"
		Me.txtMultiPO.Size = New System.Drawing.Size(376, 19)
		Me.txtMultiPO.StyleController = Me.lytSetting
		Me.txtMultiPO.TabIndex = 5
		'
		'txtTipeKontak
		'
		Me.txtTipeKontak.Location = New System.Drawing.Point(143, 93)
		Me.txtTipeKontak.Name = "txtTipeKontak"
		Me.txtTipeKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTipeKontak.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
		Me.txtTipeKontak.Properties.DataSource = Me.xpColTipeKontak
		Me.txtTipeKontak.Properties.DisplayMember = "Nama"
		Me.txtTipeKontak.Properties.NullText = ""
		Me.txtTipeKontak.Properties.PopupSizeable = False
		Me.txtTipeKontak.Properties.ValueMember = "Id"
		Me.txtTipeKontak.Size = New System.Drawing.Size(257, 20)
		Me.txtTipeKontak.StyleController = Me.lytSetting
		Me.txtTipeKontak.TabIndex = 1
		'
		'txtVP
		'
		Me.txtVP.Location = New System.Drawing.Point(143, 166)
		Me.txtVP.Name = "txtVP"
		Me.txtVP.Size = New System.Drawing.Size(257, 20)
		Me.txtVP.StyleController = Me.lytSetting
		Me.txtVP.TabIndex = 1
		'
		'txtRI
		'
		Me.txtRI.Location = New System.Drawing.Point(143, 142)
		Me.txtRI.Name = "txtRI"
		Me.txtRI.Size = New System.Drawing.Size(257, 20)
		Me.txtRI.StyleController = Me.lytSetting
		Me.txtRI.TabIndex = 1
		'
		'txtGR
		'
		Me.txtGR.Location = New System.Drawing.Point(143, 118)
		Me.txtGR.Name = "txtGR"
		Me.txtGR.Size = New System.Drawing.Size(257, 20)
		Me.txtGR.StyleController = Me.lytSetting
		Me.txtGR.TabIndex = 1
		'
		'txtPO
		'
		Me.txtPO.Location = New System.Drawing.Point(143, 70)
		Me.txtPO.Name = "txtPO"
		Me.txtPO.Size = New System.Drawing.Size(257, 20)
		Me.txtPO.StyleController = Me.lytSetting
		Me.txtPO.TabIndex = 1
		'
		'txtDP
		'
		Me.txtDP.Location = New System.Drawing.Point(143, 94)
		Me.txtDP.Name = "txtDP"
		Me.txtDP.Size = New System.Drawing.Size(257, 20)
		Me.txtDP.StyleController = Me.lytSetting
		Me.txtDP.TabIndex = 1
		'
		'txtRQ
		'
		Me.txtRQ.Location = New System.Drawing.Point(143, 46)
		Me.txtRQ.Name = "txtRQ"
		Me.txtRQ.Size = New System.Drawing.Size(257, 20)
		Me.txtRQ.StyleController = Me.lytSetting
		Me.txtRQ.TabIndex = 1
		'
		'txtAuto
		'
		Me.txtAuto.Location = New System.Drawing.Point(143, 210)
		Me.txtAuto.Name = "txtAuto"
		Me.txtAuto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtAuto.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Name")})
		Me.txtAuto.Properties.DisplayMember = "Value"
		Me.txtAuto.Properties.NullText = ""
		Me.txtAuto.Properties.PopupSizeable = False
		Me.txtAuto.Properties.ValueMember = "Key"
		Me.txtAuto.Size = New System.Drawing.Size(257, 20)
		Me.txtAuto.StyleController = Me.lytSetting
		Me.txtAuto.TabIndex = 1
		'
		'txtCoaHutangSementara
		'
		Me.txtCoaHutangSementara.Location = New System.Drawing.Point(143, 46)
		Me.txtCoaHutangSementara.Name = "txtCoaHutangSementara"
		Me.txtCoaHutangSementara.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtCoaHutangSementara.Properties.DataSource = Me.xpCOA
		Me.txtCoaHutangSementara.Properties.DisplayMember = "Kode"
		Me.txtCoaHutangSementara.Properties.NullText = ""
		Me.txtCoaHutangSementara.Properties.PopupSizeable = False
		Me.txtCoaHutangSementara.Properties.ValueMember = "Id"
		Me.txtCoaHutangSementara.Properties.View = Me.SearchLookUpEdit1View
		Me.txtCoaHutangSementara.Size = New System.Drawing.Size(257, 20)
		Me.txtCoaHutangSementara.StyleController = Me.lytSetting
		Me.txtCoaHutangSementara.TabIndex = 1
		'
		'SearchLookUpEdit1View
		'
		Me.SearchLookUpEdit1View.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcKode, Me.gcNama})
		Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
		Me.SearchLookUpEdit1View.OptionsFind.AlwaysVisible = True
		Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
		Me.SearchLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcKode, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'gcKode
		'
		Me.gcKode.Caption = "Kode"
		Me.gcKode.FieldName = "Kode"
		Me.gcKode.Name = "gcKode"
		Me.gcKode.Visible = True
		Me.gcKode.VisibleIndex = 0
		Me.gcKode.Width = 276
		'
		'gcNama
		'
		Me.gcNama.Caption = "Nama"
		Me.gcNama.FieldName = "Nama"
		Me.gcNama.Name = "gcNama"
		Me.gcNama.Visible = True
		Me.gcNama.VisibleIndex = 1
		Me.gcNama.Width = 802
		'
		'txtCoaPPN
		'
		Me.txtCoaPPN.Location = New System.Drawing.Point(143, 70)
		Me.txtCoaPPN.Name = "txtCoaPPN"
		Me.txtCoaPPN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtCoaPPN.Properties.DataSource = Me.xpCOA
		Me.txtCoaPPN.Properties.DisplayMember = "Kode"
		Me.txtCoaPPN.Properties.NullText = ""
		Me.txtCoaPPN.Properties.PopupSizeable = False
		Me.txtCoaPPN.Properties.ValueMember = "Id"
		Me.txtCoaPPN.Properties.View = Me.GridView3
		Me.txtCoaPPN.Size = New System.Drawing.Size(257, 20)
		Me.txtCoaPPN.StyleController = Me.lytSetting
		Me.txtCoaPPN.TabIndex = 1
		'
		'GridView3
		'
		Me.GridView3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5})
		Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.GridView3.Name = "GridView3"
		Me.GridView3.OptionsFind.AlwaysVisible = True
		Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.GridView3.OptionsView.ShowGroupPanel = False
		Me.GridView3.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn4, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'GridColumn4
		'
		Me.GridColumn4.Caption = "Kode"
		Me.GridColumn4.FieldName = "Kode"
		Me.GridColumn4.Name = "GridColumn4"
		Me.GridColumn4.Visible = True
		Me.GridColumn4.VisibleIndex = 0
		Me.GridColumn4.Width = 276
		'
		'GridColumn5
		'
		Me.GridColumn5.Caption = "Nama"
		Me.GridColumn5.FieldName = "Nama"
		Me.GridColumn5.Name = "GridColumn5"
		Me.GridColumn5.Visible = True
		Me.GridColumn5.VisibleIndex = 1
		Me.GridColumn5.Width = 802
		'
		'txtCoaPPH
		'
		Me.txtCoaPPH.Location = New System.Drawing.Point(143, 94)
		Me.txtCoaPPH.Name = "txtCoaPPH"
		Me.txtCoaPPH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtCoaPPH.Properties.DataSource = Me.xpCOA
		Me.txtCoaPPH.Properties.DisplayMember = "Kode"
		Me.txtCoaPPH.Properties.NullText = ""
		Me.txtCoaPPH.Properties.PopupSizeable = False
		Me.txtCoaPPH.Properties.ValueMember = "Id"
		Me.txtCoaPPH.Properties.View = Me.GridView4
		Me.txtCoaPPH.Size = New System.Drawing.Size(257, 20)
		Me.txtCoaPPH.StyleController = Me.lytSetting
		Me.txtCoaPPH.TabIndex = 1
		'
		'GridView4
		'
		Me.GridView4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7})
		Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.GridView4.Name = "GridView4"
		Me.GridView4.OptionsFind.AlwaysVisible = True
		Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.GridView4.OptionsView.ShowGroupPanel = False
		Me.GridView4.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn6, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'GridColumn6
		'
		Me.GridColumn6.Caption = "Kode"
		Me.GridColumn6.FieldName = "Kode"
		Me.GridColumn6.Name = "GridColumn6"
		Me.GridColumn6.Visible = True
		Me.GridColumn6.VisibleIndex = 0
		Me.GridColumn6.Width = 276
		'
		'GridColumn7
		'
		Me.GridColumn7.Caption = "Nama"
		Me.GridColumn7.FieldName = "Nama"
		Me.GridColumn7.Name = "GridColumn7"
		Me.GridColumn7.Visible = True
		Me.GridColumn7.VisibleIndex = 1
		Me.GridColumn7.Width = 802
		'
		'txtCoaBiaya
		'
		Me.txtCoaBiaya.Location = New System.Drawing.Point(143, 118)
		Me.txtCoaBiaya.Name = "txtCoaBiaya"
		Me.txtCoaBiaya.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtCoaBiaya.Properties.DataSource = Me.xpCOA
		Me.txtCoaBiaya.Properties.DisplayMember = "Kode"
		Me.txtCoaBiaya.Properties.NullText = ""
		Me.txtCoaBiaya.Properties.PopupSizeable = False
		Me.txtCoaBiaya.Properties.ValueMember = "Id"
		Me.txtCoaBiaya.Properties.View = Me.GridView5
		Me.txtCoaBiaya.Size = New System.Drawing.Size(257, 20)
		Me.txtCoaBiaya.StyleController = Me.lytSetting
		Me.txtCoaBiaya.TabIndex = 1
		'
		'GridView5
		'
		Me.GridView5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9})
		Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.GridView5.Name = "GridView5"
		Me.GridView5.OptionsFind.AlwaysVisible = True
		Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.GridView5.OptionsView.ShowGroupPanel = False
		Me.GridView5.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn8, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'GridColumn8
		'
		Me.GridColumn8.Caption = "Kode"
		Me.GridColumn8.FieldName = "Kode"
		Me.GridColumn8.Name = "GridColumn8"
		Me.GridColumn8.Visible = True
		Me.GridColumn8.VisibleIndex = 0
		Me.GridColumn8.Width = 276
		'
		'GridColumn9
		'
		Me.GridColumn9.Caption = "Nama"
		Me.GridColumn9.FieldName = "Nama"
		Me.GridColumn9.Name = "GridColumn9"
		Me.GridColumn9.Visible = True
		Me.GridColumn9.VisibleIndex = 1
		Me.GridColumn9.Width = 802
		'
		'txtCoaPembulatan
		'
		Me.txtCoaPembulatan.Location = New System.Drawing.Point(143, 142)
		Me.txtCoaPembulatan.Name = "txtCoaPembulatan"
		Me.txtCoaPembulatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtCoaPembulatan.Properties.DataSource = Me.xpCOA
		Me.txtCoaPembulatan.Properties.DisplayMember = "Kode"
		Me.txtCoaPembulatan.Properties.NullText = ""
		Me.txtCoaPembulatan.Properties.PopupSizeable = False
		Me.txtCoaPembulatan.Properties.ValueMember = "Id"
		Me.txtCoaPembulatan.Properties.View = Me.GridView6
		Me.txtCoaPembulatan.Size = New System.Drawing.Size(257, 20)
		Me.txtCoaPembulatan.StyleController = Me.lytSetting
		Me.txtCoaPembulatan.TabIndex = 1
		'
		'GridView6
		'
		Me.GridView6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn10, Me.GridColumn11})
		Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.GridView6.Name = "GridView6"
		Me.GridView6.OptionsFind.AlwaysVisible = True
		Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.GridView6.OptionsView.ShowGroupPanel = False
		Me.GridView6.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn10, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'GridColumn10
		'
		Me.GridColumn10.Caption = "Kode"
		Me.GridColumn10.FieldName = "Kode"
		Me.GridColumn10.Name = "GridColumn10"
		Me.GridColumn10.Visible = True
		Me.GridColumn10.VisibleIndex = 0
		Me.GridColumn10.Width = 276
		'
		'GridColumn11
		'
		Me.GridColumn11.Caption = "Nama"
		Me.GridColumn11.FieldName = "Nama"
		Me.GridColumn11.Name = "GridColumn11"
		Me.GridColumn11.Visible = True
		Me.GridColumn11.VisibleIndex = 1
		Me.GridColumn11.Width = 802
		'
		'txtCoaAdmin
		'
		Me.txtCoaAdmin.Location = New System.Drawing.Point(143, 166)
		Me.txtCoaAdmin.Name = "txtCoaAdmin"
		Me.txtCoaAdmin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtCoaAdmin.Properties.DataSource = Me.xpCOA
		Me.txtCoaAdmin.Properties.DisplayMember = "Kode"
		Me.txtCoaAdmin.Properties.NullText = ""
		Me.txtCoaAdmin.Properties.PopupSizeable = False
		Me.txtCoaAdmin.Properties.ValueMember = "Id"
		Me.txtCoaAdmin.Properties.View = Me.GridView7
		Me.txtCoaAdmin.Size = New System.Drawing.Size(257, 20)
		Me.txtCoaAdmin.StyleController = Me.lytSetting
		Me.txtCoaAdmin.TabIndex = 1
		'
		'GridView7
		'
		Me.GridView7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn12, Me.GridColumn13})
		Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.GridView7.Name = "GridView7"
		Me.GridView7.OptionsFind.AlwaysVisible = True
		Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.GridView7.OptionsView.ShowGroupPanel = False
		Me.GridView7.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn12, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'GridColumn12
		'
		Me.GridColumn12.Caption = "Kode"
		Me.GridColumn12.FieldName = "Kode"
		Me.GridColumn12.Name = "GridColumn12"
		Me.GridColumn12.Visible = True
		Me.GridColumn12.VisibleIndex = 0
		Me.GridColumn12.Width = 276
		'
		'GridColumn13
		'
		Me.GridColumn13.Caption = "Nama"
		Me.GridColumn13.FieldName = "Nama"
		Me.GridColumn13.Name = "GridColumn13"
		Me.GridColumn13.Visible = True
		Me.GridColumn13.VisibleIndex = 1
		Me.GridColumn13.Width = 802
		'
		'txtCoaPendapatan
		'
		Me.txtCoaPendapatan.Location = New System.Drawing.Point(143, 190)
		Me.txtCoaPendapatan.Name = "txtCoaPendapatan"
		Me.txtCoaPendapatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtCoaPendapatan.Properties.DataSource = Me.xpCOA
		Me.txtCoaPendapatan.Properties.DisplayMember = "Kode"
		Me.txtCoaPendapatan.Properties.NullText = ""
		Me.txtCoaPendapatan.Properties.PopupSizeable = False
		Me.txtCoaPendapatan.Properties.ValueMember = "Id"
		Me.txtCoaPendapatan.Properties.View = Me.GridView8
		Me.txtCoaPendapatan.Size = New System.Drawing.Size(257, 20)
		Me.txtCoaPendapatan.StyleController = Me.lytSetting
		Me.txtCoaPendapatan.TabIndex = 1
		'
		'GridView8
		'
		Me.GridView8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn14, Me.GridColumn15})
		Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.GridView8.Name = "GridView8"
		Me.GridView8.OptionsFind.AlwaysVisible = True
		Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.GridView8.OptionsView.ShowGroupPanel = False
		Me.GridView8.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn14, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'GridColumn14
		'
		Me.GridColumn14.Caption = "Kode"
		Me.GridColumn14.FieldName = "Kode"
		Me.GridColumn14.Name = "GridColumn14"
		Me.GridColumn14.Visible = True
		Me.GridColumn14.VisibleIndex = 0
		Me.GridColumn14.Width = 276
		'
		'GridColumn15
		'
		Me.GridColumn15.Caption = "Nama"
		Me.GridColumn15.FieldName = "Nama"
		Me.GridColumn15.Name = "GridColumn15"
		Me.GridColumn15.Visible = True
		Me.GridColumn15.VisibleIndex = 1
		Me.GridColumn15.Width = 802
		'
		'LayoutControlItem21
		'
		Me.LayoutControlItem21.Control = Me.chkAPRegional
		Me.LayoutControlItem21.CustomizationFormText = "SettingRegional"
		Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem21.Name = "LayoutControlItem21"
		Me.LayoutControlItem21.Size = New System.Drawing.Size(380, 295)
		Me.LayoutControlItem21.Text = "SettingRegional"
		Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem21.TextToControlDistance = 0
		Me.LayoutControlItem21.TextVisible = False
		'
		'LayoutControlGroup6
		'
		Me.LayoutControlGroup6.CustomizationFormText = "LayoutControlGroup6"
		Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
		Me.LayoutControlGroup6.Size = New System.Drawing.Size(380, 295)
		Me.LayoutControlGroup6.Text = "LayoutControlGroup6"
		'
		'LayoutControlItem14
		'
		Me.LayoutControlItem14.Control = Me.GridControl2
		Me.LayoutControlItem14.CustomizationFormText = "GridRegional"
		Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 141)
		Me.LayoutControlItem14.Name = "LayoutControlItem14"
		Me.LayoutControlItem14.Size = New System.Drawing.Size(380, 154)
		Me.LayoutControlItem14.Text = "GridRegional"
		Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem14.TextToControlDistance = 0
		Me.LayoutControlItem14.TextVisible = False
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.R})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(424, 361)
		Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
		Me.LayoutControlGroup1.TextVisible = False
		'
		'R
		'
		Me.R.CustomizationFormText = "R"
		Me.R.Location = New System.Drawing.Point(0, 0)
		Me.R.Name = "R"
		Me.R.SelectedTabPage = Me.LayoutControlGroup2
		Me.R.SelectedTabPageIndex = 0
		Me.R.Size = New System.Drawing.Size(404, 341)
		Me.R.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlGroup5})
		Me.R.Text = "R"
		'
		'LayoutControlGroup2
		'
		Me.LayoutControlGroup2.CustomizationFormText = "Application"
		Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlItem26})
		Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
		Me.LayoutControlGroup2.Size = New System.Drawing.Size(380, 295)
		Me.LayoutControlGroup2.Text = "Application"
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.txtFilterKontak
		Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(380, 23)
		Me.LayoutControlItem1.Text = "LayoutControlItem1"
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem1.TextToControlDistance = 0
		Me.LayoutControlItem1.TextVisible = False
		'
		'LayoutControlItem2
		'
		Me.LayoutControlItem2.Control = Me.txtTipeKontak
		Me.LayoutControlItem2.CustomizationFormText = "Kategori"
		Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 47)
		Me.LayoutControlItem2.Name = "LayoutControlItem2"
		Me.LayoutControlItem2.Size = New System.Drawing.Size(380, 24)
		Me.LayoutControlItem2.Text = "Kategori"
		Me.LayoutControlItem2.TextSize = New System.Drawing.Size(116, 13)
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.txtMultiPO
		Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
		Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 118)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(380, 23)
		Me.LayoutControlItem3.Text = "LayoutControlItem3"
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem3.TextToControlDistance = 0
		Me.LayoutControlItem3.TextVisible = False
		'
		'LayoutControlItem4
		'
		Me.LayoutControlItem4.Control = Me.txtAuto
		Me.LayoutControlItem4.CustomizationFormText = "Auto Filter"
		Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 164)
		Me.LayoutControlItem4.Name = "LayoutControlItem4"
		Me.LayoutControlItem4.Size = New System.Drawing.Size(380, 24)
		Me.LayoutControlItem4.Text = "Auto Filter"
		Me.LayoutControlItem4.TextSize = New System.Drawing.Size(116, 13)
		'
		'LayoutControlItem5
		'
		Me.LayoutControlItem5.Control = Me.chkPreview
		Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
		Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 188)
		Me.LayoutControlItem5.Name = "LayoutControlItem5"
		Me.LayoutControlItem5.Size = New System.Drawing.Size(380, 23)
		Me.LayoutControlItem5.Text = "LayoutControlItem5"
		Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem5.TextToControlDistance = 0
		Me.LayoutControlItem5.TextVisible = False
		'
		'LayoutControlItem22
		'
		Me.LayoutControlItem22.Control = Me.txtGudang
		Me.LayoutControlItem22.CustomizationFormText = "Gudang Default"
		Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 71)
		Me.LayoutControlItem22.Name = "LayoutControlItem22"
		Me.LayoutControlItem22.Size = New System.Drawing.Size(380, 24)
		Me.LayoutControlItem22.Text = "Gudang Default"
		Me.LayoutControlItem22.TextSize = New System.Drawing.Size(116, 13)
		'
		'LayoutControlItem23
		'
		Me.LayoutControlItem23.Control = Me.txtSettingCOAHutang
		Me.LayoutControlItem23.CustomizationFormText = "Coa Hutang (RI)"
		Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem23.Name = "LayoutControlItem23"
		Me.LayoutControlItem23.Size = New System.Drawing.Size(380, 24)
		Me.LayoutControlItem23.Text = "Setting Coa Hutang (RI)"
		Me.LayoutControlItem23.TextSize = New System.Drawing.Size(116, 13)
		'
		'LayoutControlItem24
		'
		Me.LayoutControlItem24.Control = Me.txtApprovePO
		Me.LayoutControlItem24.CustomizationFormText = "LayoutControlItem24"
		Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 95)
		Me.LayoutControlItem24.Name = "LayoutControlItem24"
		Me.LayoutControlItem24.Size = New System.Drawing.Size(380, 23)
		Me.LayoutControlItem24.Text = "LayoutControlItem24"
		Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem24.TextToControlDistance = 0
		Me.LayoutControlItem24.TextVisible = False
		'
		'LayoutControlItem25
		'
		Me.LayoutControlItem25.Control = Me.txtBM
		Me.LayoutControlItem25.CustomizationFormText = "Pajak BM"
		Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 211)
		Me.LayoutControlItem25.Name = "LayoutControlItem25"
		Me.LayoutControlItem25.Size = New System.Drawing.Size(380, 84)
		Me.LayoutControlItem25.Text = "Pajak BM"
		Me.LayoutControlItem25.TextSize = New System.Drawing.Size(116, 13)
		'
		'LayoutControlGroup3
		'
		Me.LayoutControlGroup3.CustomizationFormText = "COA"
		Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem27})
		Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
		Me.LayoutControlGroup3.Size = New System.Drawing.Size(380, 295)
		Me.LayoutControlGroup3.Text = "COA"
		'
		'LayoutControlItem6
		'
		Me.LayoutControlItem6.Control = Me.txtCoaHutangSementara
		Me.LayoutControlItem6.CustomizationFormText = "Hutang Belum Tertagih"
		Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem6.Name = "LayoutControlItem6"
		Me.LayoutControlItem6.Size = New System.Drawing.Size(380, 24)
		Me.LayoutControlItem6.Text = "Hutang Belum Tertagih"
		Me.LayoutControlItem6.TextSize = New System.Drawing.Size(116, 13)
		'
		'LayoutControlItem7
		'
		Me.LayoutControlItem7.Control = Me.txtCoaPPN
		Me.LayoutControlItem7.CustomizationFormText = "Pajak PPN"
		Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem7.Name = "LayoutControlItem7"
		Me.LayoutControlItem7.Size = New System.Drawing.Size(380, 24)
		Me.LayoutControlItem7.Text = "Pajak PPN"
		Me.LayoutControlItem7.TextSize = New System.Drawing.Size(116, 13)
		'
		'LayoutControlItem8
		'
		Me.LayoutControlItem8.Control = Me.txtCoaPPH
		Me.LayoutControlItem8.CustomizationFormText = "Pajak PPH"
		Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 48)
		Me.LayoutControlItem8.Name = "LayoutControlItem8"
		Me.LayoutControlItem8.Size = New System.Drawing.Size(380, 24)
		Me.LayoutControlItem8.Text = "Pajak PPH"
		Me.LayoutControlItem8.TextSize = New System.Drawing.Size(116, 13)
		'
		'LayoutControlItem9
		'
		Me.LayoutControlItem9.Control = Me.txtCoaBiaya
		Me.LayoutControlItem9.CustomizationFormText = "Biaya Lain"
		Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 72)
		Me.LayoutControlItem9.Name = "LayoutControlItem9"
		Me.LayoutControlItem9.Size = New System.Drawing.Size(380, 24)
		Me.LayoutControlItem9.Text = "Biaya Lain"
		Me.LayoutControlItem9.TextSize = New System.Drawing.Size(116, 13)
		'
		'LayoutControlItem10
		'
		Me.LayoutControlItem10.Control = Me.txtCoaPembulatan
		Me.LayoutControlItem10.CustomizationFormText = "Pembulatan"
		Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 96)
		Me.LayoutControlItem10.Name = "LayoutControlItem10"
		Me.LayoutControlItem10.Size = New System.Drawing.Size(380, 24)
		Me.LayoutControlItem10.Text = "Pembulatan"
		Me.LayoutControlItem10.TextSize = New System.Drawing.Size(116, 13)
		'
		'LayoutControlItem11
		'
		Me.LayoutControlItem11.Control = Me.txtCoaAdmin
		Me.LayoutControlItem11.CustomizationFormText = "Administrasi Bank"
		Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 120)
		Me.LayoutControlItem11.Name = "LayoutControlItem11"
		Me.LayoutControlItem11.Size = New System.Drawing.Size(380, 24)
		Me.LayoutControlItem11.Text = "Administrasi Bank"
		Me.LayoutControlItem11.TextSize = New System.Drawing.Size(116, 13)
		'
		'LayoutControlItem12
		'
		Me.LayoutControlItem12.Control = Me.txtCoaPendapatan
		Me.LayoutControlItem12.CustomizationFormText = "Pendapatan(diskon)"
		Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 144)
		Me.LayoutControlItem12.Name = "LayoutControlItem12"
		Me.LayoutControlItem12.Size = New System.Drawing.Size(380, 24)
		Me.LayoutControlItem12.Text = "Pendapatan(diskon)"
		Me.LayoutControlItem12.TextSize = New System.Drawing.Size(116, 13)
		'
		'LayoutControlGroup4
		'
		Me.LayoutControlGroup4.CustomizationFormText = "Uang"
		Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem13})
		Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
		Me.LayoutControlGroup4.Size = New System.Drawing.Size(380, 295)
		Me.LayoutControlGroup4.Text = "Uang"
		'
		'LayoutControlItem13
		'
		Me.LayoutControlItem13.Control = Me.GridControl1
		Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
		Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem13.Name = "LayoutControlItem13"
		Me.LayoutControlItem13.Size = New System.Drawing.Size(380, 295)
		Me.LayoutControlItem13.Text = "LayoutControlItem13"
		Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem13.TextToControlDistance = 0
		Me.LayoutControlItem13.TextVisible = False
		'
		'LayoutControlGroup5
		'
		Me.LayoutControlGroup5.CustomizationFormText = "Uraian"
		Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem20})
		Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
		Me.LayoutControlGroup5.Size = New System.Drawing.Size(380, 295)
		Me.LayoutControlGroup5.Text = "Uraian"
		'
		'LayoutControlItem15
		'
		Me.LayoutControlItem15.Control = Me.txtRQ
		Me.LayoutControlItem15.CustomizationFormText = "Permintaan Penawaran"
		Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem15.Name = "LayoutControlItem15"
		Me.LayoutControlItem15.Size = New System.Drawing.Size(380, 24)
		Me.LayoutControlItem15.Text = "Permintaan Penawaran"
		Me.LayoutControlItem15.TextSize = New System.Drawing.Size(116, 13)
		'
		'LayoutControlItem16
		'
		Me.LayoutControlItem16.Control = Me.txtPO
		Me.LayoutControlItem16.CustomizationFormText = "Order Pembelian"
		Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem16.Name = "LayoutControlItem16"
		Me.LayoutControlItem16.Size = New System.Drawing.Size(380, 24)
		Me.LayoutControlItem16.Text = "Order Pembelian"
		Me.LayoutControlItem16.TextSize = New System.Drawing.Size(116, 13)
		'
		'LayoutControlItem17
		'
		Me.LayoutControlItem17.Control = Me.txtDP
		Me.LayoutControlItem17.CustomizationFormText = "DP Pembelian"
		Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 48)
		Me.LayoutControlItem17.Name = "LayoutControlItem17"
		Me.LayoutControlItem17.Size = New System.Drawing.Size(380, 24)
		Me.LayoutControlItem17.Text = "DP Pembelian"
		Me.LayoutControlItem17.TextSize = New System.Drawing.Size(116, 13)
		'
		'LayoutControlItem18
		'
		Me.LayoutControlItem18.Control = Me.txtGR
		Me.LayoutControlItem18.CustomizationFormText = "Penerimaan Barang"
		Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 72)
		Me.LayoutControlItem18.Name = "LayoutControlItem18"
		Me.LayoutControlItem18.Size = New System.Drawing.Size(380, 24)
		Me.LayoutControlItem18.Text = "Penerimaan Barang"
		Me.LayoutControlItem18.TextSize = New System.Drawing.Size(116, 13)
		'
		'LayoutControlItem19
		'
		Me.LayoutControlItem19.Control = Me.txtRI
		Me.LayoutControlItem19.CustomizationFormText = "Invoice Pembelian"
		Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 96)
		Me.LayoutControlItem19.Name = "LayoutControlItem19"
		Me.LayoutControlItem19.Size = New System.Drawing.Size(380, 24)
		Me.LayoutControlItem19.Text = "Invoice Pembelian"
		Me.LayoutControlItem19.TextSize = New System.Drawing.Size(116, 13)
		'
		'LayoutControlItem20
		'
		Me.LayoutControlItem20.Control = Me.txtVP
		Me.LayoutControlItem20.CustomizationFormText = "Pembayaran Hutang"
		Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 120)
		Me.LayoutControlItem20.Name = "LayoutControlItem20"
		Me.LayoutControlItem20.Size = New System.Drawing.Size(380, 175)
		Me.LayoutControlItem20.Text = "Pembayaran Hutang"
		Me.LayoutControlItem20.TextSize = New System.Drawing.Size(116, 13)
		'
		'chkEditRI
		'
		Me.chkEditRI.Location = New System.Drawing.Point(24, 187)
		Me.chkEditRI.Name = "chkEditRI"
		Me.chkEditRI.Properties.Caption = "Edit Qty dan Harga Invoice Pembelian"
		Me.chkEditRI.Size = New System.Drawing.Size(376, 19)
		Me.chkEditRI.StyleController = Me.lytSetting
		Me.chkEditRI.TabIndex = 16
		'
		'LayoutControlItem26
		'
		Me.LayoutControlItem26.Control = Me.chkEditRI
		Me.LayoutControlItem26.CustomizationFormText = "LayoutControlItem26"
		Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 141)
		Me.LayoutControlItem26.Name = "LayoutControlItem26"
		Me.LayoutControlItem26.Size = New System.Drawing.Size(380, 23)
		Me.LayoutControlItem26.Text = "LayoutControlItem26"
		Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem26.TextToControlDistance = 0
		Me.LayoutControlItem26.TextVisible = False
		'
		'txtSelisihRI
		'
		Me.txtSelisihRI.Location = New System.Drawing.Point(143, 214)
		Me.txtSelisihRI.Name = "txtSelisihRI"
		Me.txtSelisihRI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtSelisihRI.Properties.DataSource = Me.xpCOA
		Me.txtSelisihRI.Properties.DisplayMember = "Kode"
		Me.txtSelisihRI.Properties.NullText = ""
		Me.txtSelisihRI.Properties.ValueMember = "Id"
		Me.txtSelisihRI.Properties.View = Me.GridView9
		Me.txtSelisihRI.Size = New System.Drawing.Size(257, 20)
		Me.txtSelisihRI.StyleController = Me.lytSetting
		Me.txtSelisihRI.TabIndex = 17
		'
		'LayoutControlItem27
		'
		Me.LayoutControlItem27.Control = Me.txtSelisihRI
		Me.LayoutControlItem27.CustomizationFormText = "Selisih Invoice"
		Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 168)
		Me.LayoutControlItem27.Name = "LayoutControlItem27"
		Me.LayoutControlItem27.Size = New System.Drawing.Size(380, 127)
		Me.LayoutControlItem27.Text = "Selisih Invoice"
		Me.LayoutControlItem27.TextSize = New System.Drawing.Size(116, 13)
		'
		'GridView9
		'
		Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode1, Me.colNama1})
		Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.GridView9.Name = "GridView9"
		Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.GridView9.OptionsView.ShowGroupPanel = False
		'
		'colKode1
		'
		Me.colKode1.FieldName = "Kode"
		Me.colKode1.Name = "colKode1"
		Me.colKode1.Visible = True
		Me.colKode1.VisibleIndex = 0
		'
		'colNama1
		'
		Me.colNama1.FieldName = "Nama"
		Me.colNama1.Name = "colNama1"
		Me.colNama1.Visible = True
		Me.colNama1.VisibleIndex = 1
		'
		'UI_Setting
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(424, 410)
		Me.Controls.Add(Me.lytSetting)
		Me.Name = "UI_Setting"
		Me.Text = "Setting Module Purchase"
		Me.Controls.SetChildIndex(Me.PanelControl1, 0)
		Me.Controls.SetChildIndex(Me.lytSetting, 0)
		CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelControl1.ResumeLayout(False)
		CType(Me.xpColTipeKontak, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpCOA, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkPreview.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lytSetting, System.ComponentModel.ISupportInitialize).EndInit()
		Me.lytSetting.ResumeLayout(False)
		CType(Me.txtBM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpPajak, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtApprovePO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtSettingCOAHutang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpGudang, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkAPRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpRegional, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colCoaRegionalRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpUang, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colHutangDagangRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colUMRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtFilterKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtMultiPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTipeKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtVP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtRI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtGR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtRQ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtAuto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCoaHutangSementara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCoaPPN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCoaPPH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCoaBiaya.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCoaPembulatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCoaAdmin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCoaPendapatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.R, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkEditRI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtSelisihRI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents xpColTipeKontak As DevExpress.Xpo.XPCollection
  Friend WithEvents xpCOA As DevExpress.Xpo.XPCollection
  Friend WithEvents txtFilterKontak As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents txtMultiPO As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents txtTipeKontak As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtAuto As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtRQ As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtPO As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtDP As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtRI As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtVP As DevExpress.XtraEditors.TextEdit
  Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents xpUang As DevExpress.Xpo.XPCollection
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHutangDagang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHutangDagangRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colUM As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUMRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents txtGR As DevExpress.XtraEditors.TextEdit
  Friend WithEvents chkPreview As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
  Friend WithEvents lytSetting As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents R As DevExpress.XtraLayout.TabbedControlGroup
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents chkAPRegional As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents xpRegional As DevExpress.Xpo.XPCollection
  Friend WithEvents txtCoaHutangSementara As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtCoaPPN As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtCoaPPH As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtCoaBiaya As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtCoaPembulatan As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtCoaAdmin As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtCoaPendapatan As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
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
  Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtGudang As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents xpGudang As DevExpress.Xpo.XPCollection
  Friend WithEvents colCoaRegionalRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
  Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents txtSettingCOAHutang As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtApprovePO As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtBM As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents xpPajak As DevExpress.Xpo.XPCollection
	Friend WithEvents chkEditRI As DevExpress.XtraEditors.CheckEdit
	Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtSelisihRI As DevExpress.XtraEditors.SearchLookUpEdit
	Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colKode1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNama1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
End Class
