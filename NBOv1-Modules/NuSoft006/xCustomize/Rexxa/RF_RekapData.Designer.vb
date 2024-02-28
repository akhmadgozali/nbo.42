<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zRexaRF_RekapData
  Inherits Core.Win.Forms.FilterForm

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
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.chkSaldoNol = New DevExpress.XtraEditors.CheckEdit()
    Me.txtPeriode = New DevExpress.XtraEditors.DateEdit()
    Me.txtKodeBarang = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtGudang = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtCustomer = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtTgl2 = New DevExpress.XtraEditors.DateEdit()
    Me.txtTgl1 = New DevExpress.XtraEditors.DateEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.lytTanggal1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytTanggal2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytCustomer = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.lytPeriode = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytCheckSaldoNol = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.chkSaldoNol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriode.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKodeBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytTanggal1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytTanggal2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytPeriode, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytCheckSaldoNol, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.chkSaldoNol)
    Me.LayoutControl1.Controls.Add(Me.txtPeriode)
    Me.LayoutControl1.Controls.Add(Me.txtKodeBarang)
    Me.LayoutControl1.Controls.Add(Me.txtGudang)
    Me.LayoutControl1.Controls.Add(Me.txtCustomer)
    Me.LayoutControl1.Controls.Add(Me.txtTgl2)
    Me.LayoutControl1.Controls.Add(Me.txtTgl1)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(674, 101, 250, 350)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(423, 206)
    Me.LayoutControl1.TabIndex = 101
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'chkSaldoNol
    '
    Me.chkSaldoNol.Location = New System.Drawing.Point(80, 132)
    Me.chkSaldoNol.Name = "chkSaldoNol"
    Me.chkSaldoNol.Properties.Caption = ""
    Me.chkSaldoNol.Size = New System.Drawing.Size(331, 19)
    Me.chkSaldoNol.StyleController = Me.LayoutControl1
    Me.chkSaldoNol.TabIndex = 10
    '
    'txtPeriode
    '
    Me.txtPeriode.EditValue = Nothing
    Me.txtPeriode.Location = New System.Drawing.Point(80, 12)
    Me.txtPeriode.Name = "txtPeriode"
    Me.txtPeriode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriode.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriode.Size = New System.Drawing.Size(331, 20)
    Me.txtPeriode.StyleController = Me.LayoutControl1
    Me.txtPeriode.TabIndex = 9
    '
    'txtKodeBarang
    '
    Me.txtKodeBarang.Location = New System.Drawing.Point(80, 108)
    Me.txtKodeBarang.Name = "txtKodeBarang"
    Me.txtKodeBarang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKodeBarang.Properties.DisplayMember = "Kode"
    Me.txtKodeBarang.Properties.NullText = "<Pilih Kode Barang>"
    Me.txtKodeBarang.Properties.ValueMember = "This"
    Me.txtKodeBarang.Properties.View = Me.SearchLookUpEdit2View
    Me.txtKodeBarang.Size = New System.Drawing.Size(331, 20)
    Me.txtKodeBarang.StyleController = Me.LayoutControl1
    Me.txtKodeBarang.TabIndex = 8
    '
    'SearchLookUpEdit2View
    '
    Me.SearchLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
    Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
    Me.SearchLookUpEdit2View.OptionsFind.FindDelay = 500
    Me.SearchLookUpEdit2View.OptionsFind.SearchInPreview = True
    Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
    Me.SearchLookUpEdit2View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
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
    'txtGudang
    '
    Me.txtGudang.Location = New System.Drawing.Point(80, 60)
    Me.txtGudang.Name = "txtGudang"
    Me.txtGudang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtGudang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtGudang.Properties.DisplayMember = "Kode"
    Me.txtGudang.Properties.NullText = "<Pilih Gudang>"
    Me.txtGudang.Properties.ValueMember = "This"
    Me.txtGudang.Size = New System.Drawing.Size(124, 20)
    Me.txtGudang.StyleController = Me.LayoutControl1
    Me.txtGudang.TabIndex = 7
    '
    'txtCustomer
    '
    Me.txtCustomer.EditValue = "<Pilih Customer>"
    Me.txtCustomer.Location = New System.Drawing.Point(80, 84)
    Me.txtCustomer.Name = "txtCustomer"
    Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCustomer.Properties.DisplayMember = "Kode"
    Me.txtCustomer.Properties.NullText = "<Pilih Customer>"
    Me.txtCustomer.Properties.ValueMember = "This"
    Me.txtCustomer.Properties.View = Me.SearchLookUpEdit1View
    Me.txtCustomer.Size = New System.Drawing.Size(331, 20)
    Me.txtCustomer.StyleController = Me.LayoutControl1
    Me.txtCustomer.TabIndex = 6
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
    'txtTgl2
    '
    Me.txtTgl2.EditValue = Nothing
    Me.txtTgl2.Location = New System.Drawing.Point(276, 36)
    Me.txtTgl2.Name = "txtTgl2"
    Me.txtTgl2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl2.Size = New System.Drawing.Size(135, 20)
    Me.txtTgl2.StyleController = Me.LayoutControl1
    Me.txtTgl2.TabIndex = 5
    '
    'txtTgl1
    '
    Me.txtTgl1.EditValue = Nothing
    Me.txtTgl1.Location = New System.Drawing.Point(80, 36)
    Me.txtTgl1.Name = "txtTgl1"
    Me.txtTgl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl1.Size = New System.Drawing.Size(124, 20)
    Me.txtTgl1.StyleController = Me.LayoutControl1
    Me.txtTgl1.TabIndex = 4
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lytTanggal1, Me.lytTanggal2, Me.lytCustomer, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.lytPeriode, Me.lytCheckSaldoNol})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(423, 206)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'lytTanggal1
    '
    Me.lytTanggal1.Control = Me.txtTgl1
    Me.lytTanggal1.CustomizationFormText = "Tanggal"
    Me.lytTanggal1.Location = New System.Drawing.Point(0, 24)
    Me.lytTanggal1.Name = "lytTanggal1"
    Me.lytTanggal1.Size = New System.Drawing.Size(196, 24)
    Me.lytTanggal1.Text = "Tanggal"
    Me.lytTanggal1.TextSize = New System.Drawing.Size(65, 13)
    '
    'lytTanggal2
    '
    Me.lytTanggal2.Control = Me.txtTgl2
    Me.lytTanggal2.CustomizationFormText = "s/d"
    Me.lytTanggal2.Location = New System.Drawing.Point(196, 24)
    Me.lytTanggal2.Name = "lytTanggal2"
    Me.lytTanggal2.Size = New System.Drawing.Size(207, 24)
    Me.lytTanggal2.Text = "s/d"
    Me.lytTanggal2.TextSize = New System.Drawing.Size(65, 13)
    '
    'lytCustomer
    '
    Me.lytCustomer.Control = Me.txtCustomer
    Me.lytCustomer.CustomizationFormText = "Customer"
    Me.lytCustomer.Location = New System.Drawing.Point(0, 72)
    Me.lytCustomer.Name = "lytCustomer"
    Me.lytCustomer.Size = New System.Drawing.Size(403, 24)
    Me.lytCustomer.Text = "Customer"
    Me.lytCustomer.TextSize = New System.Drawing.Size(65, 13)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtGudang
    Me.LayoutControlItem4.CustomizationFormText = "Gudang"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(196, 24)
    Me.LayoutControlItem4.Text = "Gudang"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(65, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtKodeBarang
    Me.LayoutControlItem5.CustomizationFormText = "Kode Barang"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(403, 24)
    Me.LayoutControlItem5.Text = "Kode Barang"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(65, 13)
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(196, 48)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(207, 24)
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'lytPeriode
    '
    Me.lytPeriode.Control = Me.txtPeriode
    Me.lytPeriode.CustomizationFormText = "Periode"
    Me.lytPeriode.Location = New System.Drawing.Point(0, 0)
    Me.lytPeriode.Name = "lytPeriode"
    Me.lytPeriode.Size = New System.Drawing.Size(403, 24)
    Me.lytPeriode.Text = "Periode"
    Me.lytPeriode.TextSize = New System.Drawing.Size(65, 13)
    Me.lytPeriode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    '
    'lytCheckSaldoNol
    '
    Me.lytCheckSaldoNol.Control = Me.chkSaldoNol
    Me.lytCheckSaldoNol.CustomizationFormText = "Tampilkan Nol"
    Me.lytCheckSaldoNol.Location = New System.Drawing.Point(0, 120)
    Me.lytCheckSaldoNol.Name = "lytCheckSaldoNol"
    Me.lytCheckSaldoNol.Size = New System.Drawing.Size(403, 66)
    Me.lytCheckSaldoNol.Text = "Tampilkan Nol"
    Me.lytCheckSaldoNol.TextSize = New System.Drawing.Size(65, 13)
    Me.lytCheckSaldoNol.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    '
    'zRexaRF_RekapData
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(423, 255)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Name = "zRexaRF_RekapData"
    Me.Text = "Filter Laporan"
    Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.chkSaldoNol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriode.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKodeBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytTanggal1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytTanggal2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytCustomer, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytPeriode, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytCheckSaldoNol, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents txtKodeBarang As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtGudang As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtCustomer As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtTgl2 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtTgl1 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents lytTanggal1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytTanggal2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytCustomer As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtPeriode As DevExpress.XtraEditors.DateEdit
  Friend WithEvents lytPeriode As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents chkSaldoNol As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents lytCheckSaldoNol As DevExpress.XtraLayout.LayoutControlItem
End Class
