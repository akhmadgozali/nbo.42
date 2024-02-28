<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_SaldoAwalDialog
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
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.lytTransaksiSA = New DevExpress.XtraLayout.LayoutControl()
    Me.txtKaryawan = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtHarga = New DevExpress.XtraEditors.TextEdit()
    Me.txtSatuan = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtQty = New DevExpress.XtraEditors.TextEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.txtGudang = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.txtBarang = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytTransaksiSA, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytTransaksiSA.SuspendLayout()
    CType(Me.txtKaryawan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtHarga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSatuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtNoTransaksi
    '
    Me.txtNoTransaksi.Location = New System.Drawing.Point(63, 36)
    Me.txtNoTransaksi.Name = "txtNoTransaksi"
    Me.txtNoTransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNoTransaksi.Properties.ReadOnly = True
    Me.txtNoTransaksi.Size = New System.Drawing.Size(175, 20)
    Me.txtNoTransaksi.StyleController = Me.lytTransaksiSA
    Me.txtNoTransaksi.TabIndex = 104
    '
    'lytTransaksiSA
    '
    Me.lytTransaksiSA.Controls.Add(Me.txtKaryawan)
    Me.lytTransaksiSA.Controls.Add(Me.txtHarga)
    Me.lytTransaksiSA.Controls.Add(Me.txtSatuan)
    Me.lytTransaksiSA.Controls.Add(Me.txtQty)
    Me.lytTransaksiSA.Controls.Add(Me.txtTanggal)
    Me.lytTransaksiSA.Controls.Add(Me.txtNoTransaksi)
    Me.lytTransaksiSA.Controls.Add(Me.txtGudang)
    Me.lytTransaksiSA.Controls.Add(Me.txtRegional)
    Me.lytTransaksiSA.Controls.Add(Me.txtBarang)
    Me.lytTransaksiSA.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytTransaksiSA.Location = New System.Drawing.Point(0, 0)
    Me.lytTransaksiSA.Name = "lytTransaksiSA"
    Me.lytTransaksiSA.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(408, 14, 250, 350)
    Me.lytTransaksiSA.Root = Me.LayoutControlGroup1
    Me.lytTransaksiSA.Size = New System.Drawing.Size(250, 240)
    Me.lytTransaksiSA.TabIndex = 114
    Me.lytTransaksiSA.Text = "LayoutControl1"
    '
    'txtKaryawan
    '
    Me.txtKaryawan.EditValue = ""
    Me.txtKaryawan.Location = New System.Drawing.Point(63, 204)
    Me.txtKaryawan.Name = "txtKaryawan"
    Me.txtKaryawan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKaryawan.Properties.DisplayMember = "Kode"
    Me.txtKaryawan.Properties.NullText = "<Pilih Karyawan>"
    Me.txtKaryawan.Properties.ValueMember = "This"
    Me.txtKaryawan.Properties.View = Me.SearchLookUpEdit1View
    Me.txtKaryawan.Size = New System.Drawing.Size(175, 20)
    Me.txtKaryawan.StyleController = Me.lytTransaksiSA
    Me.txtKaryawan.TabIndex = 113
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
    'txtHarga
    '
    Me.txtHarga.EditValue = "0"
    Me.txtHarga.Location = New System.Drawing.Point(63, 180)
    Me.txtHarga.Name = "txtHarga"
    Me.txtHarga.Properties.Appearance.Options.UseTextOptions = True
    Me.txtHarga.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtHarga.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtHarga.Properties.Mask.EditMask = "n2"
    Me.txtHarga.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtHarga.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtHarga.Size = New System.Drawing.Size(175, 20)
    Me.txtHarga.StyleController = Me.lytTransaksiSA
    Me.txtHarga.TabIndex = 112
    '
    'txtSatuan
    '
    Me.txtSatuan.Location = New System.Drawing.Point(63, 156)
    Me.txtSatuan.Name = "txtSatuan"
    Me.txtSatuan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtSatuan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtSatuan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 30, "Nama")})
    Me.txtSatuan.Properties.DisplayMember = "Kode"
    Me.txtSatuan.Properties.NullText = "<Pilih Satuan>"
    Me.txtSatuan.Properties.PopupWidth = 50
    Me.txtSatuan.Properties.ValueMember = "This"
    Me.txtSatuan.Size = New System.Drawing.Size(175, 20)
    Me.txtSatuan.StyleController = Me.lytTransaksiSA
    Me.txtSatuan.TabIndex = 109
    '
    'txtQty
    '
    Me.txtQty.EditValue = "0"
    Me.txtQty.Location = New System.Drawing.Point(63, 132)
    Me.txtQty.Name = "txtQty"
    Me.txtQty.Properties.Appearance.Options.UseTextOptions = True
    Me.txtQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtQty.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtQty.Properties.Mask.EditMask = "n2"
    Me.txtQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtQty.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtQty.Size = New System.Drawing.Size(175, 20)
    Me.txtQty.StyleController = Me.lytTransaksiSA
    Me.txtQty.TabIndex = 110
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(63, 12)
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
    Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTanggal.Properties.ReadOnly = True
    Me.txtTanggal.Size = New System.Drawing.Size(175, 20)
    Me.txtTanggal.StyleController = Me.lytTransaksiSA
    Me.txtTanggal.TabIndex = 106
    '
    'txtGudang
    '
    Me.txtGudang.Location = New System.Drawing.Point(63, 84)
    Me.txtGudang.Name = "txtGudang"
    Me.txtGudang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtGudang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtGudang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 80, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 120, "Nama")})
    Me.txtGudang.Properties.DisplayMember = "Kode"
    Me.txtGudang.Properties.NullText = "<Pilih Gudang>"
    Me.txtGudang.Properties.PopupWidth = 200
    Me.txtGudang.Properties.ValueMember = "This"
    Me.txtGudang.Size = New System.Drawing.Size(175, 20)
    Me.txtGudang.StyleController = Me.lytTransaksiSA
    Me.txtGudang.TabIndex = 109
    '
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(63, 60)
    Me.txtRegional.Name = "txtRegional"
    Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 80, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 120, "Nama")})
    Me.txtRegional.Properties.DisplayMember = "Nama"
    Me.txtRegional.Properties.NullText = "<Pilih Regional>"
    Me.txtRegional.Properties.PopupWidth = 200
    Me.txtRegional.Properties.ValueMember = "This"
    Me.txtRegional.Size = New System.Drawing.Size(175, 20)
    Me.txtRegional.StyleController = Me.lytTransaksiSA
    Me.txtRegional.TabIndex = 107
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem9})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(250, 267)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtBarang
    Me.LayoutControlItem5.CustomizationFormText = "Barang"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(230, 24)
    Me.LayoutControlItem5.Text = "Barang"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(48, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtQty
    Me.LayoutControlItem6.CustomizationFormText = "Qty"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 120)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(230, 24)
    Me.LayoutControlItem6.Text = "Qty"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(48, 13)
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.txtSatuan
    Me.LayoutControlItem7.CustomizationFormText = "Satuan"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 144)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(230, 24)
    Me.LayoutControlItem7.Text = "Satuan"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(48, 13)
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtHarga
    Me.LayoutControlItem8.CustomizationFormText = "Harga"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 168)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(230, 24)
    Me.LayoutControlItem8.Text = "Harga"
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(48, 13)
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtTanggal
    Me.LayoutControlItem1.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(230, 24)
    Me.LayoutControlItem1.Text = "Tanggal"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(48, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtNoTransaksi
    Me.LayoutControlItem2.CustomizationFormText = "No. Bukti"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(230, 24)
    Me.LayoutControlItem2.Text = "No. Bukti"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(48, 13)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtRegional
    Me.LayoutControlItem3.CustomizationFormText = "Regional"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(230, 24)
    Me.LayoutControlItem3.Text = "Regional"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(48, 13)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtGudang
    Me.LayoutControlItem4.CustomizationFormText = "Gudang"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(230, 24)
    Me.LayoutControlItem4.Text = "Gudang"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(48, 13)
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.Control = Me.txtKaryawan
    Me.LayoutControlItem9.CustomizationFormText = "Karyawan"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 192)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(230, 28)
    Me.LayoutControlItem9.Text = "Karyawan"
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(48, 13)
    '
    'txtBarang
    '
    Me.txtBarang.Location = New System.Drawing.Point(63, 108)
    Me.txtBarang.Name = "txtBarang"
    Me.txtBarang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtBarang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtBarang.Properties.DisplayMember = "Kode"
    Me.txtBarang.Properties.NullText = "<Pilih Barang>"
    Me.txtBarang.Properties.PopupFormSize = New System.Drawing.Size(300, 0)
    Me.txtBarang.Properties.ValueMember = "This"
    Me.txtBarang.Properties.View = Me.GridView1
    Me.txtBarang.Size = New System.Drawing.Size(175, 20)
    Me.txtBarang.StyleController = Me.lytTransaksiSA
    Me.txtBarang.TabIndex = 108
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcKode, Me.gcNama, Me.gcSatuan})
    Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView1.OptionsView.ShowGroupPanel = False
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
    'UI_SaldoAwalDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(250, 289)
    Me.Controls.Add(Me.lytTransaksiSA)
    Me.Name = "UI_SaldoAwalDialog"
    Me.Text = "UI_SaldoAwalDialog"
    Me.Controls.SetChildIndex(Me.lytTransaksiSA, 0)
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytTransaksiSA, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytTransaksiSA.ResumeLayout(False)
    CType(Me.txtKaryawan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtHarga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSatuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtGudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
 Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
 Friend WithEvents txtGudang As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
 Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtHarga As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtSatuan As DevExpress.XtraEditors.LookUpEdit
 Friend WithEvents lytTransaksiSA As DevExpress.XtraLayout.LayoutControl
 Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
 Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtKaryawan As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtBarang As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcSatuan As DevExpress.XtraGrid.Columns.GridColumn
End Class
