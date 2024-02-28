<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_SanyuBarangImpor
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
    Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_SanyuBarangImpor))
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.Kode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.Kategori = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKategoriRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
    Me.RepositoryItemSearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.Jenis = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colJenisRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.Tipe = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTipeRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    Me.Satuan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.Tebal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.Lebar = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.Panjang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.FasilitasKite = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHargaRepo = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
    Me.colSpekRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
    Me.colSatuanRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
    Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnBrowse = New DevExpress.XtraEditors.SimpleButton()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
    Me.txtPemisah = New DevExpress.XtraEditors.TextEdit()
    Me.txtNamaFile = New DevExpress.XtraEditors.TextEdit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colKategoriRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemSearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colJenisRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colTipeRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colHargaRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colSpekRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPemisah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNamaFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btn1
    '
    Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
    Me.btn1.Appearance.Options.UseForeColor = True
    Me.btn1.Location = New System.Drawing.Point(601, 11)
    '
    'btn2
    '
    Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
    Me.btn2.Appearance.Options.UseForeColor = True
    Me.btn2.Location = New System.Drawing.Point(694, 11)
    '
    'PanelControl1
    '
    Me.PanelControl1.Location = New System.Drawing.Point(0, 372)
    Me.PanelControl1.Size = New System.Drawing.Size(790, 49)
    '
    'xGrid
    '
    Me.xGrid.Location = New System.Drawing.Point(12, 36)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.Name = "xGrid"
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colHargaRepo, Me.colSpekRepo, Me.colSatuanRepo, Me.colKategoriRepo, Me.colJenisRepo, Me.colTipeRepo})
    Me.xGrid.Size = New System.Drawing.Size(769, 319)
    Me.xGrid.TabIndex = 127
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.xGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.xGridView.ColumnPanelRowHeight = 30
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kode, Me.Nama, Me.Kategori, Me.Jenis, Me.Tipe, Me.Satuan, Me.Tebal, Me.Lebar, Me.Panjang, Me.FasilitasKite})
    StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    StyleFormatCondition1.Appearance.Options.UseBackColor = True
    StyleFormatCondition1.ApplyToRow = True
    StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
    StyleFormatCondition1.Expression = "IsNullOrEmpty([Barang.Nama])"
    Me.xGridView.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.NewItemRowText = "Tambah Data"
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
    Me.xGridView.OptionsView.AllowHtmlDrawHeaders = True
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'Kode
    '
    Me.Kode.Caption = "Kode"
    Me.Kode.FieldName = "Kode"
    Me.Kode.Name = "Kode"
    Me.Kode.Visible = True
    Me.Kode.VisibleIndex = 0
    Me.Kode.Width = 50
    '
    'Nama
    '
    Me.Nama.Caption = "Nama"
    Me.Nama.FieldName = "Nama"
    Me.Nama.Name = "Nama"
    Me.Nama.Visible = True
    Me.Nama.VisibleIndex = 1
    Me.Nama.Width = 50
    '
    'Kategori
    '
    Me.Kategori.Caption = "Kategori"
    Me.Kategori.FieldName = "Kategori.Kode"
    Me.Kategori.Name = "Kategori"
    Me.Kategori.Visible = True
    Me.Kategori.VisibleIndex = 2
    Me.Kategori.Width = 50
    '
    'colKategoriRepo
    '
    Me.colKategoriRepo.AutoHeight = False
    Me.colKategoriRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colKategoriRepo.DisplayMember = "Kode"
    Me.colKategoriRepo.Name = "colKategoriRepo"
    Me.colKategoriRepo.NullText = "<Pilih Kategori>"
    Me.colKategoriRepo.ValueMember = "This"
    Me.colKategoriRepo.View = Me.RepositoryItemSearchLookUpEdit2View
    '
    'RepositoryItemSearchLookUpEdit2View
    '
    Me.RepositoryItemSearchLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
    Me.RepositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.RepositoryItemSearchLookUpEdit2View.Name = "RepositoryItemSearchLookUpEdit2View"
    Me.RepositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.RepositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Kode"
    Me.GridColumn3.FieldName = "Kode"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 0
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Nama"
    Me.GridColumn4.FieldName = "Nama"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 1
    '
    'Jenis
    '
    Me.Jenis.Caption = "Jenis"
    Me.Jenis.ColumnEdit = Me.colJenisRepo
    Me.Jenis.FieldName = "Jenis"
    Me.Jenis.Name = "Jenis"
    Me.Jenis.Visible = True
    Me.Jenis.VisibleIndex = 3
    Me.Jenis.Width = 50
    '
    'colJenisRepo
    '
    Me.colJenisRepo.AutoHeight = False
    Me.colJenisRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colJenisRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Kode")})
    Me.colJenisRepo.DisplayMember = "Value"
    Me.colJenisRepo.Name = "colJenisRepo"
    Me.colJenisRepo.NullText = "<Pilih Jenis>"
    Me.colJenisRepo.ValueMember = "Key"
    '
    'Tipe
    '
    Me.Tipe.Caption = "Tipe"
    Me.Tipe.ColumnEdit = Me.colTipeRepo
    Me.Tipe.FieldName = "Tipe"
    Me.Tipe.Name = "Tipe"
    Me.Tipe.Visible = True
    Me.Tipe.VisibleIndex = 4
    Me.Tipe.Width = 50
    '
    'colTipeRepo
    '
    Me.colTipeRepo.AutoHeight = False
    Me.colTipeRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colTipeRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Kode")})
    Me.colTipeRepo.DisplayMember = "Value"
    Me.colTipeRepo.Name = "colTipeRepo"
    Me.colTipeRepo.NullText = "<Pilih Tipe>"
    Me.colTipeRepo.ValueMember = "Key"
    '
    'Satuan
    '
    Me.Satuan.Caption = "Satuan"
    Me.Satuan.FieldName = "Satuan.Kode"
    Me.Satuan.Name = "Satuan"
    Me.Satuan.Visible = True
    Me.Satuan.VisibleIndex = 5
    Me.Satuan.Width = 50
    '
    'Tebal
    '
    Me.Tebal.Caption = "Tebal"
    Me.Tebal.FieldName = "Tebal"
    Me.Tebal.Name = "Tebal"
    Me.Tebal.Visible = True
    Me.Tebal.VisibleIndex = 6
    Me.Tebal.Width = 50
    '
    'Lebar
    '
    Me.Lebar.Caption = "Lebar"
    Me.Lebar.FieldName = "Lebar"
    Me.Lebar.Name = "Lebar"
    Me.Lebar.Visible = True
    Me.Lebar.VisibleIndex = 7
    Me.Lebar.Width = 50
    '
    'Panjang
    '
    Me.Panjang.Caption = "Panjang"
    Me.Panjang.FieldName = "Panjang"
    Me.Panjang.Name = "Panjang"
    Me.Panjang.Visible = True
    Me.Panjang.VisibleIndex = 8
    Me.Panjang.Width = 50
    '
    'FasilitasKite
    '
    Me.FasilitasKite.Caption = "FasilitasKite"
    Me.FasilitasKite.FieldName = "FasilitasKite"
    Me.FasilitasKite.Name = "FasilitasKite"
    Me.FasilitasKite.Visible = True
    Me.FasilitasKite.VisibleIndex = 9
    Me.FasilitasKite.Width = 50
    '
    'colHargaRepo
    '
    Me.colHargaRepo.AutoHeight = False
    Me.colHargaRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colHargaRepo.Name = "colHargaRepo"
    '
    'colSpekRepo
    '
    Me.colSpekRepo.AutoHeight = False
    Me.colSpekRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colSpekRepo.Name = "colSpekRepo"
    '
    'colSatuanRepo
    '
    Me.colSatuanRepo.AutoHeight = False
    Me.colSatuanRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colSatuanRepo.DisplayMember = "Kode"
    Me.colSatuanRepo.Name = "colSatuanRepo"
    Me.colSatuanRepo.NullText = "<Pilih Satuan>"
    Me.colSatuanRepo.ValueMember = "This"
    Me.colSatuanRepo.View = Me.RepositoryItemSearchLookUpEdit1View
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
    Me.GridColumn2.Caption = "Nama"
    Me.GridColumn2.FieldName = "Nama"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    '
    'btnBrowse
    '
    Me.btnBrowse.AutoWidthInLayoutControl = True
    Me.btnBrowse.Image = CType(resources.GetObject("btnBrowse.Image"), System.Drawing.Image)
    Me.btnBrowse.Location = New System.Drawing.Point(434, 8)
    Me.btnBrowse.Name = "btnBrowse"
    Me.btnBrowse.Size = New System.Drawing.Size(73, 22)
    Me.btnBrowse.TabIndex = 126
    Me.btnBrowse.Text = "Browse"
    '
    'LabelControl1
    '
    Me.LabelControl1.Location = New System.Drawing.Point(690, 13)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(39, 13)
    Me.LabelControl1.TabIndex = 124
    Me.LabelControl1.Text = "Pemisah"
    '
    'LabelControl3
    '
    Me.LabelControl3.Location = New System.Drawing.Point(12, 12)
    Me.LabelControl3.Name = "LabelControl3"
    Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
    Me.LabelControl3.TabIndex = 125
    Me.LabelControl3.Text = "Nama File"
    '
    'txtPemisah
    '
    Me.txtPemisah.EditValue = ";"
    Me.txtPemisah.Location = New System.Drawing.Point(735, 10)
    Me.txtPemisah.Name = "txtPemisah"
    Me.txtPemisah.Size = New System.Drawing.Size(46, 20)
    Me.txtPemisah.TabIndex = 122
    '
    'txtNamaFile
    '
    Me.txtNamaFile.Location = New System.Drawing.Point(83, 9)
    Me.txtNamaFile.Name = "txtNamaFile"
    Me.txtNamaFile.Properties.ReadOnly = True
    Me.txtNamaFile.Size = New System.Drawing.Size(345, 20)
    Me.txtNamaFile.TabIndex = 123
    '
    'UI_SanyuBarangImpor
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(790, 421)
    Me.Controls.Add(Me.xGrid)
    Me.Controls.Add(Me.btnBrowse)
    Me.Controls.Add(Me.LabelControl1)
    Me.Controls.Add(Me.LabelControl3)
    Me.Controls.Add(Me.txtPemisah)
    Me.Controls.Add(Me.txtNamaFile)
    Me.Name = "UI_SanyuBarangImpor"
    Me.Text = "Impor Data Excell"
    Me.Controls.SetChildIndex(Me.PanelControl1, 0)
    Me.Controls.SetChildIndex(Me.txtNamaFile, 0)
    Me.Controls.SetChildIndex(Me.txtPemisah, 0)
    Me.Controls.SetChildIndex(Me.LabelControl3, 0)
    Me.Controls.SetChildIndex(Me.LabelControl1, 0)
    Me.Controls.SetChildIndex(Me.btnBrowse, 0)
    Me.Controls.SetChildIndex(Me.xGrid, 0)
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colKategoriRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemSearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colJenisRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colTipeRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colHargaRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colSpekRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colSatuanRepo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPemisah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNamaFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents Kode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents Kategori As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents Jenis As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents Tipe As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents Satuan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents Tebal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents Lebar As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents Panjang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents FasilitasKite As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHargaRepo As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
  Friend WithEvents colSpekRepo As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
  Friend WithEvents btnBrowse As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtPemisah As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtNamaFile As DevExpress.XtraEditors.TextEdit
  Friend WithEvents colSatuanRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
  Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKategoriRepo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
  Friend WithEvents RepositoryItemSearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colJenisRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents colTipeRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
