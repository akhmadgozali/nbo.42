<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_MesitechSettingCashFlow
  Inherits Core.Win.Forms.GridBinding

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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_MesitechSettingCashFlow))
    Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
    Me.btnDown = New DevExpress.XtraEditors.SimpleButton()
    Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
    Me.btnUp = New DevExpress.XtraEditors.SimpleButton()
    Me.lbl = New DevExpress.XtraEditors.LabelControl()
    Me.colTipe = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUrutan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
    Me.colLevel = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colLevelRepo = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
    Me.colSpasi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCashFlowTanda = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTandaRepo = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colNamaRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colLevelRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colTandaRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.DataSource = Me.xpCol
    Me.xGrid.Location = New System.Drawing.Point(0, 43)
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colLevelRepo, Me.colNamaRepo, Me.colTandaRepo})
    Me.xGrid.Size = New System.Drawing.Size(911, 368)
    '
    'xpCol
    '
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.CustomReportMain)
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTipe, Me.colUrutan, Me.colNama, Me.colLevel, Me.colSpasi, Me.colCashFlowTanda, Me.colKode})
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsCustomization.AllowSort = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
    Me.xGridView.OptionsView.ShowGroupPanel = False
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colUrutan, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'barMenu
    '
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'PanelControl1
    '
    Me.PanelControl1.Controls.Add(Me.btnDown)
    Me.PanelControl1.Controls.Add(Me.btnUp)
    Me.PanelControl1.Controls.Add(Me.lbl)
    Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
    Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
    Me.PanelControl1.Name = "PanelControl1"
    Me.PanelControl1.Size = New System.Drawing.Size(911, 43)
    Me.PanelControl1.TabIndex = 9
    '
    'btnDown
    '
    Me.btnDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnDown.ImageIndex = 0
    Me.btnDown.ImageList = Me.ImageCollection1
    Me.btnDown.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
    Me.btnDown.Location = New System.Drawing.Point(874, 8)
    Me.btnDown.Name = "btnDown"
    Me.btnDown.Size = New System.Drawing.Size(25, 25)
    Me.btnDown.TabIndex = 4
    '
    'ImageCollection1
    '
    Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
    Me.ImageCollection1.Images.SetKeyName(0, "arrow_down.png")
    Me.ImageCollection1.Images.SetKeyName(1, "arrow_up.png")
    '
    'btnUp
    '
    Me.btnUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnUp.ImageIndex = 1
    Me.btnUp.ImageList = Me.ImageCollection1
    Me.btnUp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
    Me.btnUp.Location = New System.Drawing.Point(843, 8)
    Me.btnUp.Name = "btnUp"
    Me.btnUp.Size = New System.Drawing.Size(25, 25)
    Me.btnUp.TabIndex = 3
    '
    'lbl
    '
    Me.lbl.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lbl.Location = New System.Drawing.Point(10, 8)
    Me.lbl.Name = "lbl"
    Me.lbl.Size = New System.Drawing.Size(80, 25)
    Me.lbl.TabIndex = 1
    Me.lbl.Text = "AKTIVA"
    '
    'colTipe
    '
    Me.colTipe.FieldName = "Tipe"
    Me.colTipe.Name = "colTipe"
    '
    'colUrutan
    '
    Me.colUrutan.FieldName = "Urutan"
    Me.colUrutan.Name = "colUrutan"
    '
    'colNama
    '
    Me.colNama.ColumnEdit = Me.colNamaRepo
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 0
    '
    'colNamaRepo
    '
    Me.colNamaRepo.AutoHeight = False
    Me.colNamaRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.colNamaRepo.Name = "colNamaRepo"
    '
    'colLevel
    '
    Me.colLevel.ColumnEdit = Me.colLevelRepo
    Me.colLevel.FieldName = "Level"
    Me.colLevel.Name = "colLevel"
    Me.colLevel.Visible = True
    Me.colLevel.VisibleIndex = 1
    '
    'colLevelRepo
    '
    Me.colLevelRepo.AutoHeight = False
    Me.colLevelRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colLevelRepo.Name = "colLevelRepo"
    Me.colLevelRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    '
    'colSpasi
    '
    Me.colSpasi.FieldName = "Spasi"
    Me.colSpasi.Name = "colSpasi"
    Me.colSpasi.Visible = True
    Me.colSpasi.VisibleIndex = 2
    '
    'colCashFlowTanda
    '
    Me.colCashFlowTanda.Caption = "Tanda"
    Me.colCashFlowTanda.ColumnEdit = Me.colTandaRepo
    Me.colCashFlowTanda.FieldName = "CashFlowTanda"
    Me.colCashFlowTanda.Name = "colCashFlowTanda"
    '
    'colTandaRepo
    '
    Me.colTandaRepo.AutoHeight = False
    Me.colTandaRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colTandaRepo.Items.AddRange(New Object() {"Plus", "Minus"})
    Me.colTandaRepo.Name = "colTandaRepo"
    Me.colTandaRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    '
    'colKode
    '
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    '
    'UI_MesitechSettingCashFlow
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(911, 438)
    Me.Controls.Add(Me.PanelControl1)
    Me.Name = "UI_MesitechSettingCashFlow"
    Me.Text = "Setting Custom Report"
    Me.xpCol = Me.xpCol
    Me.Controls.SetChildIndex(Me.PanelControl1, 0)
    Me.Controls.SetChildIndex(Me.xGrid, 0)
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    Me.PanelControl1.PerformLayout()
    CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colNamaRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colLevelRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colTandaRepo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents lbl As DevExpress.XtraEditors.LabelControl
  Friend WithEvents btnDown As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents btnUp As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents colTipe As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUrutan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLevel As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSpasi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCashFlowTanda As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLevelRepo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents colNamaRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents colTandaRepo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
End Class
