<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_SaldoProyek
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
    Me.txtDivisi = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtSubProyek = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtAkun2 = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtAkun1 = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtProyek = New DevExpress.XtraEditors.LookUpEdit()
    Me.chkSaldoNol = New DevExpress.XtraEditors.CheckEdit()
    Me.txtPeriodeAkhir = New DevExpress.XtraEditors.DateEdit()
    Me.txtPeriodeAwal = New DevExpress.XtraEditors.DateEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.lytPeriode2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytPeriode22 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytAkun1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytAkun2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.txtDivisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSubProyek.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAkun2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAkun1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtProyek.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkSaldoNol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytPeriode2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytPeriode22, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytAkun1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytAkun2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.txtDivisi)
    Me.LayoutControl1.Controls.Add(Me.txtSubProyek)
    Me.LayoutControl1.Controls.Add(Me.txtAkun2)
    Me.LayoutControl1.Controls.Add(Me.txtAkun1)
    Me.LayoutControl1.Controls.Add(Me.txtProyek)
    Me.LayoutControl1.Controls.Add(Me.chkSaldoNol)
    Me.LayoutControl1.Controls.Add(Me.txtPeriodeAkhir)
    Me.LayoutControl1.Controls.Add(Me.txtPeriodeAwal)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(566, 136, 250, 350)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(313, 170)
    Me.LayoutControl1.TabIndex = 106
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'txtDivisi
    '
    Me.txtDivisi.Location = New System.Drawing.Point(69, 60)
    Me.txtDivisi.Name = "txtDivisi"
    Me.txtDivisi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtDivisi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.txtDivisi.Properties.DisplayMember = "Kode"
    Me.txtDivisi.Properties.NullText = "<Pilih Divisi>"
    Me.txtDivisi.Properties.ValueMember = "This"
    Me.txtDivisi.Size = New System.Drawing.Size(232, 20)
    Me.txtDivisi.StyleController = Me.LayoutControl1
    Me.txtDivisi.TabIndex = 111
    '
    'txtSubProyek
    '
    Me.txtSubProyek.Location = New System.Drawing.Point(69, 36)
    Me.txtSubProyek.Name = "txtSubProyek"
    Me.txtSubProyek.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtSubProyek.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 50, "Nama")})
    Me.txtSubProyek.Properties.DisplayMember = "Kode"
    Me.txtSubProyek.Properties.NullText = "<Pilih Sub Proyek>"
    Me.txtSubProyek.Properties.ValueMember = "This"
    Me.txtSubProyek.Size = New System.Drawing.Size(232, 20)
    Me.txtSubProyek.StyleController = Me.LayoutControl1
    Me.txtSubProyek.TabIndex = 110
    '
    'txtAkun2
    '
    Me.txtAkun2.Location = New System.Drawing.Point(169, 108)
    Me.txtAkun2.Name = "txtAkun2"
    Me.txtAkun2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtAkun2.Properties.DisplayMember = "Kode"
    Me.txtAkun2.Properties.NullText = "<Pilih COA>"
    Me.txtAkun2.Properties.ValueMember = "This"
    Me.txtAkun2.Properties.View = Me.SearchLookUpEdit2View
    Me.txtAkun2.Size = New System.Drawing.Size(132, 20)
    Me.txtAkun2.StyleController = Me.LayoutControl1
    Me.txtAkun2.TabIndex = 109
    '
    'SearchLookUpEdit2View
    '
    Me.SearchLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
    Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
    Me.SearchLookUpEdit2View.OptionsFind.AlwaysVisible = True
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
    'txtAkun1
    '
    Me.txtAkun1.Location = New System.Drawing.Point(69, 108)
    Me.txtAkun1.Name = "txtAkun1"
    Me.txtAkun1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtAkun1.Properties.DisplayMember = "Kode"
    Me.txtAkun1.Properties.NullText = "<Pilih COA>"
    Me.txtAkun1.Properties.ValueMember = "This"
    Me.txtAkun1.Properties.View = Me.SearchLookUpEdit1View
    Me.txtAkun1.Size = New System.Drawing.Size(96, 20)
    Me.txtAkun1.StyleController = Me.LayoutControl1
    Me.txtAkun1.TabIndex = 108
    '
    'SearchLookUpEdit1View
    '
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
    'txtProyek
    '
    Me.txtProyek.Location = New System.Drawing.Point(69, 12)
    Me.txtProyek.Name = "txtProyek"
    Me.txtProyek.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtProyek.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 60, "Nama")})
    Me.txtProyek.Properties.DisplayMember = "Kode"
    Me.txtProyek.Properties.NullText = "<Pilih Proyek>"
    Me.txtProyek.Properties.ValueMember = "This"
    Me.txtProyek.Size = New System.Drawing.Size(232, 20)
    Me.txtProyek.StyleController = Me.LayoutControl1
    Me.txtProyek.TabIndex = 107
    '
    'chkSaldoNol
    '
    Me.chkSaldoNol.Location = New System.Drawing.Point(12, 132)
    Me.chkSaldoNol.Name = "chkSaldoNol"
    Me.chkSaldoNol.Properties.Caption = "Tampilkan Saldo Nol"
    Me.chkSaldoNol.Size = New System.Drawing.Size(289, 19)
    Me.chkSaldoNol.StyleController = Me.LayoutControl1
    Me.chkSaldoNol.TabIndex = 106
    '
    'txtPeriodeAkhir
    '
    Me.txtPeriodeAkhir.EditValue = Nothing
    Me.txtPeriodeAkhir.Location = New System.Drawing.Point(169, 84)
    Me.txtPeriodeAkhir.Name = "txtPeriodeAkhir"
    Me.txtPeriodeAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAkhir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAkhir.Size = New System.Drawing.Size(132, 20)
    Me.txtPeriodeAkhir.StyleController = Me.LayoutControl1
    Me.txtPeriodeAkhir.TabIndex = 105
    Me.txtPeriodeAkhir.Visible = False
    '
    'txtPeriodeAwal
    '
    Me.txtPeriodeAwal.EditValue = Nothing
    Me.txtPeriodeAwal.Location = New System.Drawing.Point(69, 84)
    Me.txtPeriodeAwal.Name = "txtPeriodeAwal"
    Me.txtPeriodeAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAwal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeAwal.Size = New System.Drawing.Size(96, 20)
    Me.txtPeriodeAwal.StyleController = Me.LayoutControl1
    Me.txtPeriodeAwal.TabIndex = 104
    Me.txtPeriodeAwal.Visible = False
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lytPeriode2, Me.lytPeriode22, Me.LayoutControlItem5, Me.LayoutControlItem1, Me.lytAkun1, Me.lytAkun2, Me.LayoutControlItem2, Me.LayoutControlItem3})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(313, 170)
    Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'lytPeriode2
    '
    Me.lytPeriode2.Control = Me.txtPeriodeAwal
    Me.lytPeriode2.CustomizationFormText = "Periode"
    Me.lytPeriode2.Location = New System.Drawing.Point(0, 72)
    Me.lytPeriode2.Name = "lytPeriode2"
    Me.lytPeriode2.Size = New System.Drawing.Size(157, 24)
    Me.lytPeriode2.Text = "Periode"
    Me.lytPeriode2.TextSize = New System.Drawing.Size(54, 13)
    '
    'lytPeriode22
    '
    Me.lytPeriode22.Control = Me.txtPeriodeAkhir
    Me.lytPeriode22.CustomizationFormText = "Tahun"
    Me.lytPeriode22.Location = New System.Drawing.Point(157, 72)
    Me.lytPeriode22.Name = "lytPeriode22"
    Me.lytPeriode22.Size = New System.Drawing.Size(136, 24)
    Me.lytPeriode22.Text = "Tahun"
    Me.lytPeriode22.TextSize = New System.Drawing.Size(0, 0)
    Me.lytPeriode22.TextToControlDistance = 0
    Me.lytPeriode22.TextVisible = False
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.chkSaldoNol
    Me.LayoutControlItem5.CustomizationFormText = "TampilkanSaldoNol"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 120)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(293, 30)
    Me.LayoutControlItem5.Text = "LayoutControlItem5"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem5.TextToControlDistance = 0
    Me.LayoutControlItem5.TextVisible = False
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtProyek
    Me.LayoutControlItem1.CustomizationFormText = "Proyek"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(293, 24)
    Me.LayoutControlItem1.Text = "Proyek"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(54, 13)
    '
    'lytAkun1
    '
    Me.lytAkun1.Control = Me.txtAkun1
    Me.lytAkun1.CustomizationFormText = "Akun"
    Me.lytAkun1.Location = New System.Drawing.Point(0, 96)
    Me.lytAkun1.Name = "lytAkun1"
    Me.lytAkun1.Size = New System.Drawing.Size(157, 24)
    Me.lytAkun1.Text = "Akun"
    Me.lytAkun1.TextSize = New System.Drawing.Size(54, 13)
    '
    'lytAkun2
    '
    Me.lytAkun2.Control = Me.txtAkun2
    Me.lytAkun2.CustomizationFormText = "Akun2"
    Me.lytAkun2.Location = New System.Drawing.Point(157, 96)
    Me.lytAkun2.Name = "lytAkun2"
    Me.lytAkun2.Size = New System.Drawing.Size(136, 24)
    Me.lytAkun2.Text = "Akun2"
    Me.lytAkun2.TextSize = New System.Drawing.Size(0, 0)
    Me.lytAkun2.TextToControlDistance = 0
    Me.lytAkun2.TextVisible = False
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtSubProyek
    Me.LayoutControlItem2.CustomizationFormText = "Sub Proyek"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(293, 24)
    Me.LayoutControlItem2.Text = "Sub Proyek"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(54, 13)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtDivisi
    Me.LayoutControlItem3.CustomizationFormText = "Divisi"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(293, 24)
    Me.LayoutControlItem3.Text = "Divisi"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(54, 13)
    '
    'RF_SaldoProyek
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(313, 219)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Name = "RF_SaldoProyek"
    Me.Text = "Filter Laporan - Neraca"
    Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.txtDivisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSubProyek.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAkun2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAkun1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtProyek.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkSaldoNol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytPeriode2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytPeriode22, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytAkun1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytAkun2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtPeriodeAkhir As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtPeriodeAwal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents lytPeriode2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytPeriode22 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents chkSaldoNol As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtProyek As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtAkun1 As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents lytAkun1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtAkun2 As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents lytAkun2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtSubProyek As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtDivisi As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
End Class
