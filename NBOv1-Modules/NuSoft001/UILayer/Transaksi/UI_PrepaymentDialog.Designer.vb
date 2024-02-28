<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_PrepaymentDialog
  Inherits NuSoft.Core.Win.Forms.InputDialog

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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_PrepaymentDialog))
    Me.txtKontakNama = New DevExpress.XtraEditors.LabelControl()
    Me.lytPengajuanDana = New DevExpress.XtraLayout.LayoutControl()
    Me.txtStatus = New DevExpress.XtraEditors.LookUpEdit()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTypeRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colReffNo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKodeKontak = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
    Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaKontak = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUangRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colNilai = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colType2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colType2Repo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.colReffNo2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPPH = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCOA = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCoaRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.txtRefreshNomor = New DevExpress.XtraEditors.SimpleButton()
    Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytPengajuanDana, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytPengajuanDana.SuspendLayout()
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colTypeRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKontakRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colUangRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colType2Repo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colCoaRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtKontakNama
    '
    Me.txtKontakNama.Appearance.ForeColor = System.Drawing.Color.Black
    Me.txtKontakNama.Location = New System.Drawing.Point(243, 37)
    Me.txtKontakNama.Name = "txtKontakNama"
    Me.txtKontakNama.Size = New System.Drawing.Size(196, 20)
    Me.txtKontakNama.StyleController = Me.lytPengajuanDana
    Me.txtKontakNama.TabIndex = 7
    '
    'lytPengajuanDana
    '
    Me.lytPengajuanDana.Controls.Add(Me.txtStatus)
    Me.lytPengajuanDana.Controls.Add(Me.xGrid)
    Me.lytPengajuanDana.Controls.Add(Me.txtKontakNama)
    Me.lytPengajuanDana.Controls.Add(Me.txtNoTransaksi)
    Me.lytPengajuanDana.Controls.Add(Me.txtRefreshNomor)
    Me.lytPengajuanDana.Controls.Add(Me.txtUraian)
    Me.lytPengajuanDana.Controls.Add(Me.txtTanggal)
    Me.lytPengajuanDana.Controls.Add(Me.txtRegional)
    Me.lytPengajuanDana.Controls.Add(Me.txtKontak)
    Me.lytPengajuanDana.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytPengajuanDana.Location = New System.Drawing.Point(0, 0)
    Me.lytPengajuanDana.Name = "lytPengajuanDana"
    Me.lytPengajuanDana.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(462, 333, 250, 350)
    Me.lytPengajuanDana.Root = Me.LayoutControlGroup1
    Me.lytPengajuanDana.Size = New System.Drawing.Size(893, 530)
    Me.lytPengajuanDana.TabIndex = 102
    Me.lytPengajuanDana.Text = "LayoutControl1"
    '
    'txtStatus
    '
    Me.txtStatus.Location = New System.Drawing.Point(687, 61)
    Me.txtStatus.Name = "txtStatus"
    Me.txtStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Status")})
    Me.txtStatus.Properties.DisplayMember = "Value"
    Me.txtStatus.Properties.NullText = "<Pilih Status>"
    Me.txtStatus.Properties.ValueMember = "Key"
    Me.txtStatus.Size = New System.Drawing.Size(153, 20)
    Me.txtStatus.StyleController = Me.lytPengajuanDana
    Me.txtStatus.TabIndex = 103
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(12, 130)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.Name = "xGrid"
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colTypeRepo, Me.colUangRepo, Me.colKontakRepo, Me.colType2Repo, Me.colCoaRepo})
    Me.xGrid.Size = New System.Drawing.Size(869, 388)
    Me.xGrid.TabIndex = 102
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colType, Me.colReffNo, Me.colKodeKontak, Me.colNamaKontak, Me.colUang, Me.colNilai, Me.colCatatan, Me.colType2, Me.colReffNo2, Me.colPPH, Me.colTotal, Me.colCOA})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.ColumnAutoWidth = False
    Me.xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'colType
    '
    Me.colType.Caption = "Tipe"
    Me.colType.ColumnEdit = Me.colTypeRepo
    Me.colType.FieldName = "Type"
    Me.colType.Name = "colType"
    Me.colType.Visible = True
    Me.colType.VisibleIndex = 0
    Me.colType.Width = 73
    '
    'colTypeRepo
    '
    Me.colTypeRepo.AutoHeight = False
    Me.colTypeRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colTypeRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Tipe")})
    Me.colTypeRepo.DisplayMember = "Value"
    Me.colTypeRepo.Name = "colTypeRepo"
    Me.colTypeRepo.NullText = "<Pilih Type>"
    Me.colTypeRepo.ValueMember = "Key"
    '
    'colReffNo
    '
    Me.colReffNo.Caption = "No Referensi"
    Me.colReffNo.FieldName = "ReffNo"
    Me.colReffNo.Name = "colReffNo"
    Me.colReffNo.Visible = True
    Me.colReffNo.VisibleIndex = 1
    Me.colReffNo.Width = 104
    '
    'colKodeKontak
    '
    Me.colKodeKontak.Caption = "Kode Kontak"
    Me.colKodeKontak.ColumnEdit = Me.colKontakRepo
    Me.colKodeKontak.FieldName = "Kontak!"
    Me.colKodeKontak.Name = "colKodeKontak"
    Me.colKodeKontak.Visible = True
    Me.colKodeKontak.VisibleIndex = 2
    Me.colKodeKontak.Width = 105
    '
    'colKontakRepo
    '
    Me.colKontakRepo.AutoHeight = False
    Me.colKontakRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colKontakRepo.DisplayMember = "Nama"
    Me.colKontakRepo.Name = "colKontakRepo"
    Me.colKontakRepo.NullText = "<Pilih Kontak>"
    Me.colKontakRepo.ValueMember = "This"
    Me.colKontakRepo.View = Me.RepositoryItemSearchLookUpEdit1View
    '
    'RepositoryItemSearchLookUpEdit1View
    '
    Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
    Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
    Me.RepositoryItemSearchLookUpEdit1View.OptionsFind.FindDelay = 500
    Me.RepositoryItemSearchLookUpEdit1View.OptionsFind.SearchInPreview = True
    Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
    Me.RepositoryItemSearchLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
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
    'colNamaKontak
    '
    Me.colNamaKontak.Caption = "Nama Kontak"
    Me.colNamaKontak.FieldName = "Kontak.Nama"
    Me.colNamaKontak.Name = "colNamaKontak"
    Me.colNamaKontak.OptionsColumn.ReadOnly = True
    Me.colNamaKontak.Width = 104
    '
    'colUang
    '
    Me.colUang.Caption = "Uang"
    Me.colUang.ColumnEdit = Me.colUangRepo
    Me.colUang.FieldName = "MataUang!"
    Me.colUang.Name = "colUang"
    Me.colUang.Visible = True
    Me.colUang.VisibleIndex = 3
    Me.colUang.Width = 50
    '
    'colUangRepo
    '
    Me.colUangRepo.AutoHeight = False
    Me.colUangRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colUangRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 40, "Nama")})
    Me.colUangRepo.DisplayMember = "Kode"
    Me.colUangRepo.Name = "colUangRepo"
    Me.colUangRepo.NullText = "<Uang>"
    Me.colUangRepo.ValueMember = "This"
    '
    'colNilai
    '
    Me.colNilai.FieldName = "Nilai"
    Me.colNilai.Name = "colNilai"
    Me.colNilai.Visible = True
    Me.colNilai.VisibleIndex = 4
    Me.colNilai.Width = 128
    '
    'colCatatan
    '
    Me.colCatatan.FieldName = "Catatan"
    Me.colCatatan.Name = "colCatatan"
    Me.colCatatan.Visible = True
    Me.colCatatan.VisibleIndex = 5
    Me.colCatatan.Width = 138
    '
    'colType2
    '
    Me.colType2.Caption = "Type"
    Me.colType2.ColumnEdit = Me.colType2Repo
    Me.colType2.FieldName = "Type2"
    Me.colType2.Name = "colType2"
    Me.colType2.Visible = True
    Me.colType2.VisibleIndex = 6
    Me.colType2.Width = 84
    '
    'colType2Repo
    '
    Me.colType2Repo.AutoHeight = False
    Me.colType2Repo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colType2Repo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Type")})
    Me.colType2Repo.DisplayMember = "Value"
    Me.colType2Repo.Name = "colType2Repo"
    Me.colType2Repo.NullText = "<Pilih Type>"
    Me.colType2Repo.ValueMember = "Key"
    '
    'colReffNo2
    '
    Me.colReffNo2.Caption = "Reff No"
    Me.colReffNo2.FieldName = "ReffNo2"
    Me.colReffNo2.Name = "colReffNo2"
    Me.colReffNo2.Visible = True
    Me.colReffNo2.VisibleIndex = 7
    '
    'colPPH
    '
    Me.colPPH.Caption = "PPh23"
    Me.colPPH.FieldName = "NilaiPPh23"
    Me.colPPH.Name = "colPPH"
    Me.colPPH.Visible = True
    Me.colPPH.VisibleIndex = 8
    '
    'colTotal
    '
    Me.colTotal.Caption = "Total"
    Me.colTotal.FieldName = "Total"
    Me.colTotal.Name = "colTotal"
    Me.colTotal.Visible = True
    Me.colTotal.VisibleIndex = 9
    '
    'colCOA
    '
    Me.colCOA.Caption = "COA"
    Me.colCOA.ColumnEdit = Me.colCoaRepo
    Me.colCOA.FieldName = "Coa!"
    Me.colCOA.Name = "colCOA"
    Me.colCOA.Visible = True
    Me.colCOA.VisibleIndex = 10
    '
    'colCoaRepo
    '
    Me.colCoaRepo.AutoHeight = False
    Me.colCoaRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colCoaRepo.DisplayMember = "Kode"
    Me.colCoaRepo.Name = "colCoaRepo"
    Me.colCoaRepo.NullText = "<Pilih Coa>"
    Me.colCoaRepo.ValueMember = "This"
    Me.colCoaRepo.View = Me.GridView1
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
    Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsFind.FindDelay = 500
    Me.GridView1.OptionsFind.SearchInPreview = True
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
    'txtNoTransaksi
    '
    Me.txtNoTransaksi.Location = New System.Drawing.Point(687, 37)
    Me.txtNoTransaksi.Name = "txtNoTransaksi"
    Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNoTransaksi.Size = New System.Drawing.Size(153, 20)
    Me.txtNoTransaksi.StyleController = Me.lytPengajuanDana
    Me.txtNoTransaksi.TabIndex = 2
    '
    'txtRefreshNomor
    '
    Me.txtRefreshNomor.Image = CType(resources.GetObject("txtRefreshNomor.Image"), System.Drawing.Image)
    Me.txtRefreshNomor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
    Me.txtRefreshNomor.Location = New System.Drawing.Point(844, 37)
    Me.txtRefreshNomor.Name = "txtRefreshNomor"
    Me.txtRefreshNomor.Size = New System.Drawing.Size(31, 22)
    Me.txtRefreshNomor.StyleController = Me.lytPengajuanDana
    Me.txtRefreshNomor.TabIndex = 3
    '
    'txtUraian
    '
    Me.txtUraian.Location = New System.Drawing.Point(46, 106)
    Me.txtUraian.Name = "txtUraian"
    Me.txtUraian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtUraian.Size = New System.Drawing.Size(835, 20)
    Me.txtUraian.StyleController = Me.lytPengajuanDana
    Me.txtUraian.TabIndex = 4
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(489, 37)
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
    Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTanggal.Size = New System.Drawing.Size(148, 20)
    Me.txtTanggal.StyleController = Me.lytPengajuanDana
    Me.txtTanggal.TabIndex = 1
    '
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(489, 61)
    Me.txtRegional.Name = "txtRegional"
    Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
    Me.txtRegional.Properties.DisplayMember = "Kode"
    Me.txtRegional.Properties.NullText = "<Pilih Regional>"
    Me.txtRegional.Properties.ValueMember = "This"
    Me.txtRegional.Size = New System.Drawing.Size(148, 20)
    Me.txtRegional.StyleController = Me.lytPengajuanDana
    Me.txtRegional.TabIndex = 1
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(71, 37)
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontak.Properties.DisplayMember = "Kode"
    Me.txtKontak.Properties.NullText = "<Pilih Kontak>"
    Me.txtKontak.Properties.ValueMember = "This"
    Me.txtKontak.Properties.View = Me.SearchLookUpEdit1View
    Me.txtKontak.Size = New System.Drawing.Size(168, 20)
    Me.txtKontak.StyleController = Me.lytPengajuanDana
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
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlGroup2, Me.LayoutControlItem12})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(893, 530)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtUraian
    Me.LayoutControlItem8.CustomizationFormText = "Uraian"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 94)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(873, 24)
    Me.LayoutControlItem8.Text = "Uraian"
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(31, 13)
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "Info Utama"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.LayoutControlItem7})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(873, 94)
    Me.LayoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 15)
    Me.LayoutControlGroup2.Text = "Info Utama"
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtKontak
    Me.LayoutControlItem2.CustomizationFormText = "Karyawan"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(225, 48)
    Me.LayoutControlItem2.Text = "Karyawan"
    Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(48, 13)
    Me.LayoutControlItem2.TextToControlDistance = 5
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtKontakNama
    Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(225, 0)
    Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(200, 0)
    Me.LayoutControlItem5.MinSize = New System.Drawing.Size(200, 17)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(200, 24)
    Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem5.Text = "LayoutControlItem5"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem5.TextToControlDistance = 0
    Me.LayoutControlItem5.TextVisible = False
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtTanggal
    Me.LayoutControlItem1.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(425, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(198, 24)
    Me.LayoutControlItem1.Text = "Tanggal"
    Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(41, 13)
    Me.LayoutControlItem1.TextToControlDistance = 5
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtNoTransaksi
    Me.LayoutControlItem3.CustomizationFormText = "No Bukti"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(623, 0)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(203, 24)
    Me.LayoutControlItem3.Text = "No Bukti"
    Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(41, 13)
    Me.LayoutControlItem3.TextToControlDistance = 5
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtRefreshNomor
    Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(826, 0)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(35, 48)
    Me.LayoutControlItem4.Text = "LayoutControlItem4"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem4.TextToControlDistance = 0
    Me.LayoutControlItem4.TextVisible = False
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtRegional
    Me.LayoutControlItem6.CustomizationFormText = "Regional"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(425, 24)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(198, 24)
    Me.LayoutControlItem6.Text = "Regional"
    Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(41, 13)
    Me.LayoutControlItem6.TextToControlDistance = 5
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(225, 24)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(200, 24)
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.txtStatus
    Me.LayoutControlItem7.CustomizationFormText = "Status"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(623, 24)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(203, 24)
    Me.LayoutControlItem7.Text = "Status"
    Me.LayoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(41, 13)
    Me.LayoutControlItem7.TextToControlDistance = 5
    '
    'LayoutControlItem12
    '
    Me.LayoutControlItem12.Control = Me.xGrid
    Me.LayoutControlItem12.CustomizationFormText = "Detail"
    Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 118)
    Me.LayoutControlItem12.Name = "LayoutControlItem12"
    Me.LayoutControlItem12.Size = New System.Drawing.Size(873, 392)
    Me.LayoutControlItem12.Text = "Detail"
    Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem12.TextToControlDistance = 0
    Me.LayoutControlItem12.TextVisible = False
    '
    'UI_PrepaymentDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(893, 579)
    Me.Controls.Add(Me.lytPengajuanDana)
    Me.Name = "UI_PrepaymentDialog"
    Me.Text = "UI_PrepaymentDialog"
    Me.Controls.SetChildIndex(Me.lytPengajuanDana, 0)
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytPengajuanDana, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytPengajuanDana.ResumeLayout(False)
    CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colTypeRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKontakRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colUangRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colType2Repo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colCoaRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtRefreshNomor As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtUraian As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtKontakNama As DevExpress.XtraEditors.LabelControl
  Friend WithEvents lytPengajuanDana As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colReffNo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKodeKontak As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaKontak As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilai As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTypeRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colKontakRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
  Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colUangRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtStatus As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colType2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colType2Repo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colReffNo2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPPH As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCOA As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCoaRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
