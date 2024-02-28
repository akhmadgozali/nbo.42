<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_SaldoAwalHutangDialog
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
    Me.lytTransaksi = New DevExpress.XtraLayout.LayoutControl()
    Me.txtNamaKontak = New DevExpress.XtraEditors.LabelControl()
    Me.txtKurs = New DevExpress.XtraEditors.TextEdit()
    Me.txtNilaiHutang = New DevExpress.XtraEditors.TextEdit()
    Me.txtNoTransaksi = New DevExpress.XtraEditors.TextEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtUang = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtValas = New DevExpress.XtraEditors.TextEdit()
    Me.txtKeterangan = New DevExpress.XtraEditors.TextEdit()
    Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytTransaksi.SuspendLayout()
    CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNilaiHutang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtValas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lytTransaksi
    '
    Me.lytTransaksi.Controls.Add(Me.txtNamaKontak)
    Me.lytTransaksi.Controls.Add(Me.txtKurs)
    Me.lytTransaksi.Controls.Add(Me.txtNilaiHutang)
    Me.lytTransaksi.Controls.Add(Me.txtNoTransaksi)
    Me.lytTransaksi.Controls.Add(Me.txtTanggal)
    Me.lytTransaksi.Controls.Add(Me.txtRegional)
    Me.lytTransaksi.Controls.Add(Me.txtUang)
    Me.lytTransaksi.Controls.Add(Me.txtValas)
    Me.lytTransaksi.Controls.Add(Me.txtKeterangan)
    Me.lytTransaksi.Controls.Add(Me.txtKontak)
    Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
    Me.lytTransaksi.Name = "lytTransaksi"
    Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(562, 219, 250, 350)
    Me.lytTransaksi.Root = Me.LayoutControlGroup1
    Me.lytTransaksi.Size = New System.Drawing.Size(376, 219)
    Me.lytTransaksi.TabIndex = 100
    Me.lytTransaksi.Text = "LayoutControl1"
    '
    'txtNamaKontak
    '
    Me.txtNamaKontak.Location = New System.Drawing.Point(189, 84)
    Me.txtNamaKontak.Name = "txtNamaKontak"
    Me.txtNamaKontak.Size = New System.Drawing.Size(63, 13)
    Me.txtNamaKontak.StyleController = Me.lytTransaksi
    Me.txtNamaKontak.TabIndex = 17
    Me.txtNamaKontak.Text = "Nama Kontak"
    '
    'txtKurs
    '
    Me.txtKurs.Location = New System.Drawing.Point(250, 133)
    Me.txtKurs.Name = "txtKurs"
    Me.txtKurs.Properties.Appearance.Options.UseTextOptions = True
    Me.txtKurs.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtKurs.Properties.Mask.EditMask = "n2"
    Me.txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtKurs.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtKurs.Size = New System.Drawing.Size(114, 20)
    Me.txtKurs.StyleController = Me.lytTransaksi
    Me.txtKurs.TabIndex = 16
    '
    'txtNilaiHutang
    '
    Me.txtNilaiHutang.Location = New System.Drawing.Point(72, 109)
    Me.txtNilaiHutang.Name = "txtNilaiHutang"
    Me.txtNilaiHutang.Properties.Appearance.Options.UseTextOptions = True
    Me.txtNilaiHutang.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtNilaiHutang.Properties.Mask.EditMask = "n2"
    Me.txtNilaiHutang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtNilaiHutang.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtNilaiHutang.Size = New System.Drawing.Size(292, 20)
    Me.txtNilaiHutang.StyleController = Me.lytTransaksi
    Me.txtNilaiHutang.TabIndex = 11
    '
    'txtNoTransaksi
    '
    Me.txtNoTransaksi.Location = New System.Drawing.Point(72, 12)
    Me.txtNoTransaksi.Name = "txtNoTransaksi"
    Me.txtNoTransaksi.Size = New System.Drawing.Size(292, 20)
    Me.txtNoTransaksi.StyleController = Me.lytTransaksi
    Me.txtNoTransaksi.TabIndex = 4
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(72, 36)
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.Mask.EditMask = ""
    Me.txtTanggal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.txtTanggal.Size = New System.Drawing.Size(292, 20)
    Me.txtTanggal.StyleController = Me.lytTransaksi
    Me.txtTanggal.TabIndex = 8
    '
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(72, 60)
    Me.txtRegional.Name = "txtRegional"
    Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtRegional.Properties.DisplayMember = "Kode"
    Me.txtRegional.Properties.NullText = ""
    Me.txtRegional.Properties.ValueMember = "This"
    Me.txtRegional.Size = New System.Drawing.Size(292, 20)
    Me.txtRegional.StyleController = Me.lytTransaksi
    Me.txtRegional.TabIndex = 10
    '
    'txtUang
    '
    Me.txtUang.Location = New System.Drawing.Point(72, 133)
    Me.txtUang.Name = "txtUang"
    Me.txtUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtUang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtUang.Properties.DisplayMember = "Kode"
    Me.txtUang.Properties.NullText = ""
    Me.txtUang.Properties.ValueMember = "This"
    Me.txtUang.Size = New System.Drawing.Size(114, 20)
    Me.txtUang.StyleController = Me.lytTransaksi
    Me.txtUang.TabIndex = 9
    '
    'txtValas
    '
    Me.txtValas.Location = New System.Drawing.Point(72, 157)
    Me.txtValas.Name = "txtValas"
    Me.txtValas.Properties.Appearance.Options.UseTextOptions = True
    Me.txtValas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtValas.Properties.Mask.EditMask = "n2"
    Me.txtValas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtValas.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtValas.Size = New System.Drawing.Size(114, 20)
    Me.txtValas.StyleController = Me.lytTransaksi
    Me.txtValas.TabIndex = 7
    '
    'txtKeterangan
    '
    Me.txtKeterangan.Location = New System.Drawing.Point(72, 181)
    Me.txtKeterangan.Name = "txtKeterangan"
    Me.txtKeterangan.Size = New System.Drawing.Size(292, 20)
    Me.txtKeterangan.StyleController = Me.lytTransaksi
    Me.txtKeterangan.TabIndex = 6
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(72, 84)
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontak.Properties.DisplayMember = "Kode"
    Me.txtKontak.Properties.NullText = ""
    Me.txtKontak.Properties.ValueMember = "This"
    Me.txtKontak.Properties.View = Me.SearchLookUpEdit1View
    Me.txtKontak.Size = New System.Drawing.Size(113, 20)
    Me.txtKontak.StyleController = Me.lytTransaksi
    Me.txtKontak.TabIndex = 12
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
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem2, Me.LayoutControlItem10, Me.EmptySpaceItem2})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(376, 219)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtKeterangan
    Me.LayoutControlItem3.CustomizationFormText = "Tanggal Pakai"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 169)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(356, 30)
    Me.LayoutControlItem3.Text = "Keterangan"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(57, 13)
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtNoTransaksi
    Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(356, 24)
    Me.LayoutControlItem1.Text = "No Bukti"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(57, 13)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtValas
    Me.LayoutControlItem4.CustomizationFormText = "Tanggal Beli"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 145)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(178, 24)
    Me.LayoutControlItem4.Text = "Valas"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(57, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtTanggal
    Me.LayoutControlItem5.CustomizationFormText = "Kode"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(356, 24)
    Me.LayoutControlItem5.Text = "Tanggal"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(57, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtUang
    Me.LayoutControlItem6.CustomizationFormText = "Nilai Residu"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 121)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(178, 24)
    Me.LayoutControlItem6.Text = "Uang"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(57, 13)
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.txtRegional
    Me.LayoutControlItem7.CustomizationFormText = "Nama"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(356, 24)
    Me.LayoutControlItem7.Text = "Regional"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(57, 13)
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtNilaiHutang
    Me.LayoutControlItem8.CustomizationFormText = "Harga Beli"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 97)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(356, 24)
    Me.LayoutControlItem8.Text = "Nilai Hutang"
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(57, 13)
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.Control = Me.txtKontak
    Me.LayoutControlItem9.CustomizationFormText = "Qty"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(177, 0)
    Me.LayoutControlItem9.MinSize = New System.Drawing.Size(177, 25)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(177, 25)
    Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem9.Text = "Kontak"
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(57, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtKurs
    Me.LayoutControlItem2.CustomizationFormText = "Kurs"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(178, 121)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(178, 24)
    Me.LayoutControlItem2.Text = "Kurs"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(57, 13)
    '
    'LayoutControlItem10
    '
    Me.LayoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = True
    Me.LayoutControlItem10.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.LayoutControlItem10.Control = Me.txtNamaKontak
    Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
    Me.LayoutControlItem10.Location = New System.Drawing.Point(177, 72)
    Me.LayoutControlItem10.Name = "LayoutControlItem10"
    Me.LayoutControlItem10.Size = New System.Drawing.Size(179, 25)
    Me.LayoutControlItem10.Text = "LayoutControlItem10"
    Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem10.TextToControlDistance = 0
    Me.LayoutControlItem10.TextVisible = False
    '
    'EmptySpaceItem2
    '
    Me.EmptySpaceItem2.AllowHotTrack = False
    Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Location = New System.Drawing.Point(178, 145)
    Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Size = New System.Drawing.Size(178, 24)
    Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
    Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
    '
    'UI_SaldoAwalHutangDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(376, 268)
    Me.Controls.Add(Me.lytTransaksi)
    Me.Name = "UI_SaldoAwalHutangDialog"
    Me.Text = "Saldo Awal Hutang"
    Me.Controls.SetChildIndex(Me.lytTransaksi, 0)
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytTransaksi.ResumeLayout(False)
    CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNilaiHutang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtValas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lytTransaksi As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtNilaiHutang As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtKurs As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtNoTransaksi As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtNamaKontak As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtUang As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtValas As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtKeterangan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
End Class
