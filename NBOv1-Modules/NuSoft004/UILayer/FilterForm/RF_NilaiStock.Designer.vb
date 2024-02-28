<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_NilaiStock
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
  Me.txtMerk = New DevExpress.XtraEditors.LookUpEdit()
  Me.txtSubKategori = New DevExpress.XtraEditors.LookUpEdit()
  Me.txtKategori = New DevExpress.XtraEditors.LookUpEdit()
  Me.txtGudang = New DevExpress.XtraEditors.LookUpEdit()
  Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
  Me.txtKodeBarang2 = New DevExpress.XtraEditors.LookUpEdit()
  Me.txtKodeBarang1 = New DevExpress.XtraEditors.LookUpEdit()
  Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
  Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
  CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
  Me.LayoutControl1.SuspendLayout()
  CType(Me.txtMerk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtSubKategori.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtKategori.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtKodeBarang2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtKodeBarang1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
  'LayoutControl1
  '
  Me.LayoutControl1.Controls.Add(Me.txtMerk)
  Me.LayoutControl1.Controls.Add(Me.txtSubKategori)
  Me.LayoutControl1.Controls.Add(Me.txtKategori)
  Me.LayoutControl1.Controls.Add(Me.txtGudang)
  Me.LayoutControl1.Controls.Add(Me.txtTanggal)
  Me.LayoutControl1.Controls.Add(Me.txtKodeBarang2)
  Me.LayoutControl1.Controls.Add(Me.txtKodeBarang1)
  Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
  Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControl1.Name = "LayoutControl1"
  Me.LayoutControl1.Root = Me.LayoutControlGroup1
  Me.LayoutControl1.Size = New System.Drawing.Size(415, 165)
  Me.LayoutControl1.TabIndex = 102
  Me.LayoutControl1.Text = "LayoutControl1"
  '
  'txtMerk
  '
  Me.txtMerk.Location = New System.Drawing.Point(75, 132)
  Me.txtMerk.Name = "txtMerk"
  Me.txtMerk.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtMerk.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtMerk.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
  Me.txtMerk.Properties.DisplayMember = "Kode"
  Me.txtMerk.Properties.NullText = "<Pilih Merk>"
  Me.txtMerk.Properties.ValueMember = "This"
  Me.txtMerk.Size = New System.Drawing.Size(328, 20)
  Me.txtMerk.StyleController = Me.LayoutControl1
  Me.txtMerk.TabIndex = 10
  '
  'txtSubKategori
  '
  Me.txtSubKategori.Location = New System.Drawing.Point(75, 108)
  Me.txtSubKategori.Name = "txtSubKategori"
  Me.txtSubKategori.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtSubKategori.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtSubKategori.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
  Me.txtSubKategori.Properties.DisplayMember = "Kode"
  Me.txtSubKategori.Properties.NullText = "<Pilih Sub Kategori>"
  Me.txtSubKategori.Properties.ValueMember = "This"
  Me.txtSubKategori.Size = New System.Drawing.Size(328, 20)
  Me.txtSubKategori.StyleController = Me.LayoutControl1
  Me.txtSubKategori.TabIndex = 9
  '
  'txtKategori
  '
  Me.txtKategori.Location = New System.Drawing.Point(75, 84)
  Me.txtKategori.Name = "txtKategori"
  Me.txtKategori.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtKategori.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtKategori.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
  Me.txtKategori.Properties.DisplayMember = "Kode"
  Me.txtKategori.Properties.NullText = "<Pilih Kategori>"
  Me.txtKategori.Properties.ValueMember = "This"
  Me.txtKategori.Size = New System.Drawing.Size(328, 20)
  Me.txtKategori.StyleController = Me.LayoutControl1
  Me.txtKategori.TabIndex = 8
  '
  'txtGudang
  '
  Me.txtGudang.Location = New System.Drawing.Point(75, 60)
  Me.txtGudang.Name = "txtGudang"
  Me.txtGudang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtGudang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtGudang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
  Me.txtGudang.Properties.DisplayMember = "Kode"
  Me.txtGudang.Properties.NullText = "<Pilih Gudang>"
  Me.txtGudang.Properties.ValueMember = "This"
  Me.txtGudang.Size = New System.Drawing.Size(328, 20)
  Me.txtGudang.StyleController = Me.LayoutControl1
  Me.txtGudang.TabIndex = 7
  '
  'txtTanggal
  '
  Me.txtTanggal.EditValue = Nothing
  Me.txtTanggal.Location = New System.Drawing.Point(75, 36)
  Me.txtTanggal.Name = "txtTanggal"
  Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtTanggal.Size = New System.Drawing.Size(328, 20)
  Me.txtTanggal.StyleController = Me.LayoutControl1
  Me.txtTanggal.TabIndex = 6
  '
  'txtKodeBarang2
  '
  Me.txtKodeBarang2.Location = New System.Drawing.Point(253, 12)
  Me.txtKodeBarang2.Name = "txtKodeBarang2"
  Me.txtKodeBarang2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
  Me.txtKodeBarang2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtKodeBarang2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtKodeBarang2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
  Me.txtKodeBarang2.Properties.DisplayMember = "Kode"
  Me.txtKodeBarang2.Properties.NullText = "<Pilih Item>"
  Me.txtKodeBarang2.Properties.ValueMember = "This"
  Me.txtKodeBarang2.Size = New System.Drawing.Size(150, 20)
  Me.txtKodeBarang2.StyleController = Me.LayoutControl1
  Me.txtKodeBarang2.TabIndex = 5
  '
  'txtKodeBarang1
  '
  Me.txtKodeBarang1.Location = New System.Drawing.Point(75, 12)
  Me.txtKodeBarang1.Name = "txtKodeBarang1"
  Me.txtKodeBarang1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
  Me.txtKodeBarang1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtKodeBarang1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtKodeBarang1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
  Me.txtKodeBarang1.Properties.DisplayMember = "Kode"
  Me.txtKodeBarang1.Properties.NullText = "<Pilih Item>"
  Me.txtKodeBarang1.Properties.ValueMember = "This"
  Me.txtKodeBarang1.Size = New System.Drawing.Size(149, 20)
  Me.txtKodeBarang1.StyleController = Me.LayoutControl1
  Me.txtKodeBarang1.TabIndex = 4
  '
  'LayoutControlGroup1
  '
  Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
  Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
  Me.LayoutControlGroup1.GroupBordersVisible = False
  Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7})
  Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
  Me.LayoutControlGroup1.Size = New System.Drawing.Size(415, 165)
  Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
  Me.LayoutControlGroup1.TextVisible = False
  '
  'LayoutControlItem1
  '
  Me.LayoutControlItem1.Control = Me.txtKodeBarang1
  Me.LayoutControlItem1.CustomizationFormText = "Item"
  Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControlItem1.Name = "LayoutControlItem1"
  Me.LayoutControlItem1.Size = New System.Drawing.Size(216, 24)
  Me.LayoutControlItem1.Text = "Item"
  Me.LayoutControlItem1.TextSize = New System.Drawing.Size(60, 13)
  '
  'LayoutControlItem2
  '
  Me.LayoutControlItem2.Control = Me.txtKodeBarang2
  Me.LayoutControlItem2.CustomizationFormText = "s/d"
  Me.LayoutControlItem2.Location = New System.Drawing.Point(216, 0)
  Me.LayoutControlItem2.Name = "LayoutControlItem2"
  Me.LayoutControlItem2.Size = New System.Drawing.Size(179, 24)
  Me.LayoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
  Me.LayoutControlItem2.Text = "s/d"
  Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
  Me.LayoutControlItem2.TextSize = New System.Drawing.Size(15, 13)
  Me.LayoutControlItem2.TextToControlDistance = 5
  '
  'LayoutControlItem3
  '
  Me.LayoutControlItem3.Control = Me.txtTanggal
  Me.LayoutControlItem3.CustomizationFormText = "Tanggal"
  Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
  Me.LayoutControlItem3.Name = "LayoutControlItem3"
  Me.LayoutControlItem3.Size = New System.Drawing.Size(395, 24)
  Me.LayoutControlItem3.Text = "Tanggal"
  Me.LayoutControlItem3.TextSize = New System.Drawing.Size(60, 13)
  '
  'LayoutControlItem4
  '
  Me.LayoutControlItem4.Control = Me.txtGudang
  Me.LayoutControlItem4.CustomizationFormText = "Gudang"
  Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
  Me.LayoutControlItem4.Name = "LayoutControlItem4"
  Me.LayoutControlItem4.Size = New System.Drawing.Size(395, 24)
  Me.LayoutControlItem4.Text = "Gudang"
  Me.LayoutControlItem4.TextSize = New System.Drawing.Size(60, 13)
  '
  'LayoutControlItem5
  '
  Me.LayoutControlItem5.Control = Me.txtKategori
  Me.LayoutControlItem5.CustomizationFormText = "Kategori"
  Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
  Me.LayoutControlItem5.Name = "LayoutControlItem5"
  Me.LayoutControlItem5.Size = New System.Drawing.Size(395, 24)
  Me.LayoutControlItem5.Text = "Kategori"
  Me.LayoutControlItem5.TextSize = New System.Drawing.Size(60, 13)
  '
  'LayoutControlItem6
  '
  Me.LayoutControlItem6.Control = Me.txtSubKategori
  Me.LayoutControlItem6.CustomizationFormText = "Sub kategori"
  Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 96)
  Me.LayoutControlItem6.Name = "LayoutControlItem6"
  Me.LayoutControlItem6.Size = New System.Drawing.Size(395, 24)
  Me.LayoutControlItem6.Text = "Sub kategori"
  Me.LayoutControlItem6.TextSize = New System.Drawing.Size(60, 13)
  '
  'LayoutControlItem7
  '
  Me.LayoutControlItem7.Control = Me.txtMerk
  Me.LayoutControlItem7.CustomizationFormText = "Merk"
  Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 120)
  Me.LayoutControlItem7.Name = "LayoutControlItem7"
  Me.LayoutControlItem7.Size = New System.Drawing.Size(395, 25)
  Me.LayoutControlItem7.Text = "Merk"
  Me.LayoutControlItem7.TextSize = New System.Drawing.Size(60, 13)
  '
  'RF_NilaiStock
  '
  Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
  Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
  Me.ClientSize = New System.Drawing.Size(415, 214)
  Me.Controls.Add(Me.LayoutControl1)
  Me.Name = "RF_NilaiStock"
  Me.Text = "Filter Laporan - Nilai Stock"
  Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
  CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
  Me.LayoutControl1.ResumeLayout(False)
  CType(Me.txtMerk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtSubKategori.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtKategori.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtKodeBarang2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtKodeBarang1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
 Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
 Friend WithEvents txtMerk As DevExpress.XtraEditors.LookUpEdit
 Friend WithEvents txtSubKategori As DevExpress.XtraEditors.LookUpEdit
 Friend WithEvents txtKategori As DevExpress.XtraEditors.LookUpEdit
 Friend WithEvents txtGudang As DevExpress.XtraEditors.LookUpEdit
 Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
 Friend WithEvents txtKodeBarang2 As DevExpress.XtraEditors.LookUpEdit
 Friend WithEvents txtKodeBarang1 As DevExpress.XtraEditors.LookUpEdit
 Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
 Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
End Class
