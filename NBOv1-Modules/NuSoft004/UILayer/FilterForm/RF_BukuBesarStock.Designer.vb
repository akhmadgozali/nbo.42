<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_BukuBesarStock
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
    Me.chkSaldo = New DevExpress.XtraEditors.CheckEdit()
    Me.txtKodeBarang2 = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtKodeBarang1 = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtGudang = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtSubKategori = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtMerk = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtKategori = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTglAkhir = New DevExpress.XtraEditors.DateEdit()
    Me.txtTglAwal = New DevExpress.XtraEditors.DateEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.lytTanggal1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytTanggal2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.chkSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKodeBarang2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKodeBarang1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSubKategori.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMerk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKategori.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytTanggal1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytTanggal2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.chkSaldo)
    Me.LayoutControl1.Controls.Add(Me.txtKodeBarang2)
    Me.LayoutControl1.Controls.Add(Me.txtKodeBarang1)
    Me.LayoutControl1.Controls.Add(Me.txtGudang)
    Me.LayoutControl1.Controls.Add(Me.txtSubKategori)
    Me.LayoutControl1.Controls.Add(Me.txtMerk)
    Me.LayoutControl1.Controls.Add(Me.txtKategori)
    Me.LayoutControl1.Controls.Add(Me.txtTglAkhir)
    Me.LayoutControl1.Controls.Add(Me.txtTglAwal)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(740, 165, 250, 350)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(338, 206)
    Me.LayoutControl1.TabIndex = 104
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'chkSaldo
    '
    Me.chkSaldo.Location = New System.Drawing.Point(12, 156)
    Me.chkSaldo.Name = "chkSaldo"
    Me.chkSaldo.Properties.Caption = "Tampilkan Selalu Saldo Awal"
    Me.chkSaldo.Size = New System.Drawing.Size(314, 19)
    Me.chkSaldo.StyleController = Me.LayoutControl1
    Me.chkSaldo.TabIndex = 111
    '
    'txtKodeBarang2
    '
    Me.txtKodeBarang2.Location = New System.Drawing.Point(210, 36)
    Me.txtKodeBarang2.Name = "txtKodeBarang2"
    Me.txtKodeBarang2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKodeBarang2.Properties.DisplayMember = "Kode"
    Me.txtKodeBarang2.Properties.NullText = "<Pilih Barang>"
    Me.txtKodeBarang2.Properties.ValueMember = "This"
    Me.txtKodeBarang2.Properties.View = Me.SearchLookUpEdit2View
    Me.txtKodeBarang2.Size = New System.Drawing.Size(116, 20)
    Me.txtKodeBarang2.StyleController = Me.LayoutControl1
    Me.txtKodeBarang2.TabIndex = 110
    '
    'SearchLookUpEdit2View
    '
    Me.SearchLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
    Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
    Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Kode"
    Me.GridColumn1.FieldName = "Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    Me.GridColumn1.Width = 293
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Nama"
    Me.GridColumn2.FieldName = "Nama"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    Me.GridColumn2.Width = 519
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Satuan"
    Me.GridColumn3.FieldName = "Satuan.Nama"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    Me.GridColumn3.Width = 266
    '
    'txtKodeBarang1
    '
    Me.txtKodeBarang1.Location = New System.Drawing.Point(70, 36)
    Me.txtKodeBarang1.Name = "txtKodeBarang1"
    Me.txtKodeBarang1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKodeBarang1.Properties.DisplayMember = "Kode"
    Me.txtKodeBarang1.Properties.NullText = "<Pilih Barang>"
    Me.txtKodeBarang1.Properties.ValueMember = "This"
    Me.txtKodeBarang1.Properties.View = Me.SearchLookUpEdit1View
    Me.txtKodeBarang1.Size = New System.Drawing.Size(111, 20)
    Me.txtKodeBarang1.StyleController = Me.LayoutControl1
    Me.txtKodeBarang1.TabIndex = 109
    '
    'SearchLookUpEdit1View
    '
    Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcKode, Me.gcNama, Me.gcSatuan})
    Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
    Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
    'txtGudang
    '
    Me.txtGudang.Location = New System.Drawing.Point(70, 60)
    Me.txtGudang.Name = "txtGudang"
    Me.txtGudang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtGudang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtGudang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtGudang.Properties.DisplayMember = "Kode"
    Me.txtGudang.Properties.NullText = "<Pilih Gudang>"
    Me.txtGudang.Properties.ValueMember = "This"
    Me.txtGudang.Size = New System.Drawing.Size(256, 20)
    Me.txtGudang.StyleController = Me.LayoutControl1
    Me.txtGudang.TabIndex = 108
    '
    'txtSubKategori
    '
    Me.txtSubKategori.Location = New System.Drawing.Point(70, 108)
    Me.txtSubKategori.Name = "txtSubKategori"
    Me.txtSubKategori.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtSubKategori.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtSubKategori.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtSubKategori.Properties.DisplayMember = "Kode"
    Me.txtSubKategori.Properties.NullText = "<Pilih Sub Kategori>"
    Me.txtSubKategori.Properties.ValueMember = "This"
    Me.txtSubKategori.Size = New System.Drawing.Size(256, 20)
    Me.txtSubKategori.StyleController = Me.LayoutControl1
    Me.txtSubKategori.TabIndex = 107
    '
    'txtMerk
    '
    Me.txtMerk.Location = New System.Drawing.Point(70, 132)
    Me.txtMerk.Name = "txtMerk"
    Me.txtMerk.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtMerk.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtMerk.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtMerk.Properties.DisplayMember = "Kode"
    Me.txtMerk.Properties.NullText = "<Pilih Merk>"
    Me.txtMerk.Properties.ValueMember = "This"
    Me.txtMerk.Size = New System.Drawing.Size(256, 20)
    Me.txtMerk.StyleController = Me.LayoutControl1
    Me.txtMerk.TabIndex = 106
    '
    'txtKategori
    '
    Me.txtKategori.Location = New System.Drawing.Point(70, 84)
    Me.txtKategori.Name = "txtKategori"
    Me.txtKategori.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKategori.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKategori.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtKategori.Properties.DisplayMember = "Kode"
    Me.txtKategori.Properties.NullText = "<Pilih Kategori>"
    Me.txtKategori.Properties.ValueMember = "This"
    Me.txtKategori.Size = New System.Drawing.Size(256, 20)
    Me.txtKategori.StyleController = Me.LayoutControl1
    Me.txtKategori.TabIndex = 105
    '
    'txtTglAkhir
    '
    Me.txtTglAkhir.EditValue = Nothing
    Me.txtTglAkhir.Location = New System.Drawing.Point(205, 12)
    Me.txtTglAkhir.Name = "txtTglAkhir"
    Me.txtTglAkhir.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTglAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglAkhir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglAkhir.Properties.Mask.EditMask = "0000"
    Me.txtTglAkhir.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
    Me.txtTglAkhir.Size = New System.Drawing.Size(121, 20)
    Me.txtTglAkhir.StyleController = Me.LayoutControl1
    Me.txtTglAkhir.TabIndex = 102
    '
    'txtTglAwal
    '
    Me.txtTglAwal.EditValue = Nothing
    Me.txtTglAwal.Location = New System.Drawing.Point(70, 12)
    Me.txtTglAwal.Name = "txtTglAwal"
    Me.txtTglAwal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTglAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglAwal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglAwal.Properties.Mask.EditMask = ""
    Me.txtTglAwal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.txtTglAwal.Size = New System.Drawing.Size(111, 20)
    Me.txtTglAwal.StyleController = Me.LayoutControl1
    Me.txtTglAwal.TabIndex = 101
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lytTanggal1, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem1, Me.lytTanggal2, Me.LayoutControlItem4, Me.LayoutControlItem9})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(338, 206)
    Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'lytTanggal1
    '
    Me.lytTanggal1.Control = Me.txtTglAwal
    Me.lytTanggal1.CustomizationFormText = "Periode"
    Me.lytTanggal1.Location = New System.Drawing.Point(0, 0)
    Me.lytTanggal1.Name = "lytTanggal1"
    Me.lytTanggal1.Size = New System.Drawing.Size(173, 24)
    Me.lytTanggal1.Text = "Periode"
    Me.lytTanggal1.TextSize = New System.Drawing.Size(55, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtKategori
    Me.LayoutControlItem5.CustomizationFormText = "Kategori"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(318, 24)
    Me.LayoutControlItem5.Text = "Kategori"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(55, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtMerk
    Me.LayoutControlItem6.CustomizationFormText = "Merk"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 120)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(318, 24)
    Me.LayoutControlItem6.Text = "Merk"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(55, 13)
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.txtSubKategori
    Me.LayoutControlItem7.CustomizationFormText = "Sub Katgori"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 96)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(318, 24)
    Me.LayoutControlItem7.Text = "Sub Katgori"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(55, 13)
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtGudang
    Me.LayoutControlItem8.CustomizationFormText = "Gudang"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(318, 24)
    Me.LayoutControlItem8.Text = "Gudang"
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(55, 13)
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtKodeBarang1
    Me.LayoutControlItem1.CustomizationFormText = "Barang"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(173, 24)
    Me.LayoutControlItem1.Text = "Barang"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(55, 13)
    '
    'lytTanggal2
    '
    Me.lytTanggal2.Control = Me.txtTglAkhir
    Me.lytTanggal2.CustomizationFormText = "s/d"
    Me.lytTanggal2.Location = New System.Drawing.Point(173, 0)
    Me.lytTanggal2.Name = "lytTanggal2"
    Me.lytTanggal2.Size = New System.Drawing.Size(145, 24)
    Me.lytTanggal2.Text = "s/d"
    Me.lytTanggal2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.lytTanggal2.TextSize = New System.Drawing.Size(20, 13)
    Me.lytTanggal2.TextToControlDistance = 0
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtKodeBarang2
    Me.LayoutControlItem4.CustomizationFormText = "s/d"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(173, 24)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(145, 24)
    Me.LayoutControlItem4.Text = "s/d"
    Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(20, 13)
    Me.LayoutControlItem4.TextToControlDistance = 5
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.Control = Me.chkSaldo
    Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 144)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(318, 42)
    Me.LayoutControlItem9.Text = "LayoutControlItem9"
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem9.TextToControlDistance = 0
    Me.LayoutControlItem9.TextVisible = False
    '
    'RF_BukuBesarStock
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(338, 255)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Name = "RF_BukuBesarStock"
    Me.Text = "Filter Laporan - Buku Besar Stock"
    Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.chkSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKodeBarang2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKodeBarang1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSubKategori.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMerk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKategori.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytTanggal1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytTanggal2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents lytTanggal2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytTanggal1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtSubKategori As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtMerk As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtKategori As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtGudang As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtTglAkhir As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtTglAwal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtKodeBarang1 As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtKodeBarang2 As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents chkSaldo As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcSatuan As DevExpress.XtraGrid.Columns.GridColumn
End Class
