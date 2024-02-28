<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_RekapData
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
    Me.txtKeterangan = New DevExpress.XtraEditors.TextEdit()
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.txtKodeBarang = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.txtTgl2 = New DevExpress.XtraEditors.DateEdit()
    Me.txtNoBukti1 = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTgl1 = New DevExpress.XtraEditors.DateEdit()
    Me.txtKontak = New DevExpress.XtraEditors.TextEdit()
    Me.txtNoBukti2 = New DevExpress.XtraEditors.LookUpEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.txtKodeBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoBukti1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoBukti2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtKeterangan
    '
    Me.txtKeterangan.Location = New System.Drawing.Point(71, 108)
    Me.txtKeterangan.Name = "txtKeterangan"
    Me.txtKeterangan.Size = New System.Drawing.Size(412, 20)
    Me.txtKeterangan.StyleController = Me.LayoutControl1
    Me.txtKeterangan.TabIndex = 120
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.txtKodeBarang)
    Me.LayoutControl1.Controls.Add(Me.txtKeterangan)
    Me.LayoutControl1.Controls.Add(Me.txtTgl2)
    Me.LayoutControl1.Controls.Add(Me.txtNoBukti1)
    Me.LayoutControl1.Controls.Add(Me.txtTgl1)
    Me.LayoutControl1.Controls.Add(Me.txtKontak)
    Me.LayoutControl1.Controls.Add(Me.txtNoBukti2)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(495, 148)
    Me.LayoutControl1.TabIndex = 127
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'txtKodeBarang
    '
    Me.txtKodeBarang.Location = New System.Drawing.Point(71, 60)
    Me.txtKodeBarang.Name = "txtKodeBarang"
    Me.txtKodeBarang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKodeBarang.Properties.DisplayMember = "Kode"
    Me.txtKodeBarang.Properties.NullText = "<Semua Barang>"
    Me.txtKodeBarang.Properties.ValueMember = "This"
    Me.txtKodeBarang.Properties.View = Me.SearchLookUpEdit1View
    Me.txtKodeBarang.Size = New System.Drawing.Size(412, 20)
    Me.txtKodeBarang.StyleController = Me.LayoutControl1
    Me.txtKodeBarang.TabIndex = 121
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
    'txtTgl2
    '
    Me.txtTgl2.EditValue = Nothing
    Me.txtTgl2.Location = New System.Drawing.Point(308, 36)
    Me.txtTgl2.Name = "txtTgl2"
    Me.txtTgl2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.txtTgl2.Properties.DisplayFormat.FormatString = "D"
    Me.txtTgl2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTgl2.Size = New System.Drawing.Size(175, 20)
    Me.txtTgl2.StyleController = Me.LayoutControl1
    Me.txtTgl2.TabIndex = 118
    '
    'txtNoBukti1
    '
    Me.txtNoBukti1.Location = New System.Drawing.Point(71, 12)
    Me.txtNoBukti1.Name = "txtNoBukti1"
    Me.txtNoBukti1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtNoBukti1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "No Transaksi")})
    Me.txtNoBukti1.Properties.DisplayMember = "Kode"
    Me.txtNoBukti1.Properties.NullText = ""
    Me.txtNoBukti1.Properties.ValueMember = "Kode"
    Me.txtNoBukti1.Size = New System.Drawing.Size(174, 20)
    Me.txtNoBukti1.StyleController = Me.LayoutControl1
    Me.txtNoBukti1.TabIndex = 115
    '
    'txtTgl1
    '
    Me.txtTgl1.EditValue = Nothing
    Me.txtTgl1.Location = New System.Drawing.Point(71, 36)
    Me.txtTgl1.Name = "txtTgl1"
    Me.txtTgl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.txtTgl1.Properties.DisplayFormat.FormatString = "D"
    Me.txtTgl1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTgl1.Size = New System.Drawing.Size(174, 20)
    Me.txtTgl1.StyleController = Me.LayoutControl1
    Me.txtTgl1.TabIndex = 117
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(71, 84)
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Size = New System.Drawing.Size(412, 20)
    Me.txtKontak.StyleController = Me.LayoutControl1
    Me.txtKontak.TabIndex = 119
    '
    'txtNoBukti2
    '
    Me.txtNoBukti2.Location = New System.Drawing.Point(308, 12)
    Me.txtNoBukti2.Name = "txtNoBukti2"
    Me.txtNoBukti2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtNoBukti2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "No Transaksi")})
    Me.txtNoBukti2.Properties.DisplayMember = "Kode"
    Me.txtNoBukti2.Properties.NullText = ""
    Me.txtNoBukti2.Properties.ValueMember = "Kode"
    Me.txtNoBukti2.Size = New System.Drawing.Size(175, 20)
    Me.txtNoBukti2.StyleController = Me.LayoutControl1
    Me.txtNoBukti2.TabIndex = 116
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(495, 148)
    Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtNoBukti1
    Me.LayoutControlItem1.CustomizationFormText = "No Bukti"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(237, 24)
    Me.LayoutControlItem1.Text = "No Bukti PO"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(56, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtNoBukti2
    Me.LayoutControlItem2.CustomizationFormText = "s/d"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(237, 0)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(238, 24)
    Me.LayoutControlItem2.Text = "s/d"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(56, 13)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtTgl1
    Me.LayoutControlItem3.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(237, 24)
    Me.LayoutControlItem3.Text = "Tanggal PO"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(56, 13)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtTgl2
    Me.LayoutControlItem4.CustomizationFormText = "s/d"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(237, 24)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(238, 24)
    Me.LayoutControlItem4.Text = "s/d"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(56, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtKontak
    Me.LayoutControlItem5.CustomizationFormText = "Customer"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(475, 24)
    Me.LayoutControlItem5.Text = "Customer"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(56, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtKeterangan
    Me.LayoutControlItem6.CustomizationFormText = "Customer"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 96)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(475, 32)
    Me.LayoutControlItem6.Text = "Uraian"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(56, 13)
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.txtKodeBarang
    Me.LayoutControlItem7.CustomizationFormText = "Barang"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(475, 24)
    Me.LayoutControlItem7.Text = "Barang"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(56, 13)
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
    'RF_RekapData
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(495, 197)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Name = "RF_RekapData"
    Me.Text = "RF_Rekap"
    Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.txtKodeBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoBukti1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoBukti2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtKeterangan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtTgl2 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtTgl1 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtKontak As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtNoBukti1 As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtNoBukti2 As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtKodeBarang As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
End Class
