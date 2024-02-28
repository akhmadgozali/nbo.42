<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zRexxaRF_Piutang
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
    Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.txtJabatan = New DevExpress.XtraEditors.TextEdit()
    Me.txtMataUang = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtPenandatangan = New DevExpress.XtraEditors.TextEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.lytTanggal = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtJabatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMataUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPenandatangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytTanggal, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtKontak
    '
    Me.txtKontak.EditValue = "<Pilih Kontak>"
    Me.txtKontak.Location = New System.Drawing.Point(91, 36)
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontak.Properties.DisplayMember = "Kode"
    Me.txtKontak.Properties.NullText = "<Pilih Kontak>"
    Me.txtKontak.Properties.ValueMember = "This"
    Me.txtKontak.Properties.View = Me.SearchLookUpEdit1View
    Me.txtKontak.Size = New System.Drawing.Size(371, 20)
    Me.txtKontak.StyleController = Me.LayoutControl1
    Me.txtKontak.TabIndex = 113
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
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.txtTanggal)
    Me.LayoutControl1.Controls.Add(Me.txtJabatan)
    Me.LayoutControl1.Controls.Add(Me.txtKontak)
    Me.LayoutControl1.Controls.Add(Me.txtMataUang)
    Me.LayoutControl1.Controls.Add(Me.txtPenandatangan)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(510, 91, 250, 350)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(474, 203)
    Me.LayoutControl1.TabIndex = 118
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(91, 12)
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.DisplayFormat.FormatString = "dd-MMMM-yyyy"
    Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTanggal.Size = New System.Drawing.Size(371, 20)
    Me.txtTanggal.StyleController = Me.LayoutControl1
    Me.txtTanggal.TabIndex = 117
    '
    'txtJabatan
    '
    Me.txtJabatan.Location = New System.Drawing.Point(91, 149)
    Me.txtJabatan.Name = "txtJabatan"
    Me.txtJabatan.Size = New System.Drawing.Size(371, 20)
    Me.txtJabatan.StyleController = Me.LayoutControl1
    Me.txtJabatan.TabIndex = 116
    '
    'txtMataUang
    '
    Me.txtMataUang.Location = New System.Drawing.Point(91, 60)
    Me.txtMataUang.Name = "txtMataUang"
    Me.txtMataUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtMataUang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 40, "Nama")})
    Me.txtMataUang.Properties.DisplayMember = "Kode"
    Me.txtMataUang.Properties.NullText = ""
    Me.txtMataUang.Properties.ValueMember = "This"
    Me.txtMataUang.Size = New System.Drawing.Size(371, 20)
    Me.txtMataUang.StyleController = Me.LayoutControl1
    Me.txtMataUang.TabIndex = 107
    '
    'txtPenandatangan
    '
    Me.txtPenandatangan.Location = New System.Drawing.Point(91, 125)
    Me.txtPenandatangan.Name = "txtPenandatangan"
    Me.txtPenandatangan.Size = New System.Drawing.Size(371, 20)
    Me.txtPenandatangan.StyleController = Me.LayoutControl1
    Me.txtPenandatangan.TabIndex = 114
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.SimpleLabelItem1, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.lytTanggal})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(474, 203)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtJabatan
    Me.LayoutControlItem2.CustomizationFormText = "Jabatan"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 137)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(454, 24)
    Me.LayoutControlItem2.Text = "Jabatan"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(76, 13)
    '
    'SimpleLabelItem1
    '
    Me.SimpleLabelItem1.AllowHotTrack = False
    Me.SimpleLabelItem1.CustomizationFormText = "Footer"
    Me.SimpleLabelItem1.Location = New System.Drawing.Point(0, 96)
    Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
    Me.SimpleLabelItem1.Size = New System.Drawing.Size(454, 17)
    Me.SimpleLabelItem1.Text = "Footer"
    Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(76, 13)
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtPenandatangan
    Me.LayoutControlItem1.CustomizationFormText = "Penandatangan"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 113)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(454, 24)
    Me.LayoutControlItem1.Text = "Penandatangan"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(76, 13)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtKontak
    Me.LayoutControlItem3.CustomizationFormText = "Kontak"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(454, 24)
    Me.LayoutControlItem3.Text = "Kontak"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(76, 13)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtMataUang
    Me.LayoutControlItem4.CustomizationFormText = "Mata Uang"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(454, 24)
    Me.LayoutControlItem4.Text = "Mata Uang"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(76, 13)
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 72)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(454, 24)
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem2
    '
    Me.EmptySpaceItem2.AllowHotTrack = False
    Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 161)
    Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Size = New System.Drawing.Size(454, 22)
    Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
    Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
    '
    'lytTanggal
    '
    Me.lytTanggal.Control = Me.txtTanggal
    Me.lytTanggal.CustomizationFormText = "Per Tanggal"
    Me.lytTanggal.Location = New System.Drawing.Point(0, 0)
    Me.lytTanggal.Name = "lytTanggal"
    Me.lytTanggal.Size = New System.Drawing.Size(454, 24)
    Me.lytTanggal.Text = "Per Tanggal"
    Me.lytTanggal.TextSize = New System.Drawing.Size(76, 13)
    '
    'zRexxaRF_Piutang
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(474, 252)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Name = "zRexxaRF_Piutang"
    Me.Text = "Filter Laporan"
    Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtJabatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMataUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPenandatangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytTanggal, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtPenandatangan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtJabatan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtMataUang As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents lytTanggal As DevExpress.XtraLayout.LayoutControlItem
End Class
