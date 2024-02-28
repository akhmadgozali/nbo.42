<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_AktivaKelompokDialog
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
    Me.txtKode = New DevExpress.XtraEditors.TextEdit()
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.txtUmur = New DevExpress.XtraEditors.TextEdit()
    Me.txtTipe = New DevExpress.XtraEditors.LookUpEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.txtCoaAsset = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.txtCoaDepresiasi = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.txtCoaAkumDepr = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.txtCOAWriteOff = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.txtUmur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTipe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCoaAsset.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCoaDepresiasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCoaAkumDepr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCOAWriteOff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtKode
    '
    Me.txtKode.Location = New System.Drawing.Point(115, 12)
    Me.txtKode.Name = "txtKode"
    Me.txtKode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKode.Size = New System.Drawing.Size(246, 20)
    Me.txtKode.StyleController = Me.LayoutControl1
    Me.txtKode.TabIndex = 0
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.txtKode)
    Me.LayoutControl1.Controls.Add(Me.txtUmur)
    Me.LayoutControl1.Controls.Add(Me.txtTipe)
    Me.LayoutControl1.Controls.Add(Me.txtCoaAsset)
    Me.LayoutControl1.Controls.Add(Me.txtCoaDepresiasi)
    Me.LayoutControl1.Controls.Add(Me.txtCoaAkumDepr)
    Me.LayoutControl1.Controls.Add(Me.txtCOAWriteOff)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(421, 327, 250, 350)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(373, 207)
    Me.LayoutControl1.TabIndex = 110
    Me.LayoutControl1.Text = "lytMaster"
    '
    'txtUmur
    '
    Me.txtUmur.Location = New System.Drawing.Point(115, 36)
    Me.txtUmur.Name = "txtUmur"
    Me.txtUmur.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtUmur.Size = New System.Drawing.Size(69, 20)
    Me.txtUmur.StyleController = Me.LayoutControl1
    Me.txtUmur.TabIndex = 108
    '
    'txtTipe
    '
    Me.txtTipe.Location = New System.Drawing.Point(115, 60)
    Me.txtTipe.Name = "txtTipe"
    Me.txtTipe.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTipe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTipe.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")})
    Me.txtTipe.Properties.DisplayMember = "Value"
    Me.txtTipe.Properties.NullText = ""
    Me.txtTipe.Properties.ValueMember = "Key"
    Me.txtTipe.Size = New System.Drawing.Size(246, 20)
    Me.txtTipe.StyleController = Me.LayoutControl1
    Me.txtTipe.TabIndex = 108
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.SimpleLabelItem1})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(373, 207)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtKode
    Me.LayoutControlItem1.CustomizationFormText = "Nama"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(353, 24)
    Me.LayoutControlItem1.Text = "Nama"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(100, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtUmur
    Me.LayoutControlItem2.CustomizationFormText = "Umur"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(176, 24)
    Me.LayoutControlItem2.Text = "Umur"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(100, 13)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtTipe
    Me.LayoutControlItem3.CustomizationFormText = "Tipe Penyusutan"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(353, 24)
    Me.LayoutControlItem3.Text = "Tipe Penyusutan"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(100, 13)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtCoaAsset
    Me.LayoutControlItem4.CustomizationFormText = "Coa Asset"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(353, 24)
    Me.LayoutControlItem4.Text = "Coa Asset"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(100, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtCoaDepresiasi
    Me.LayoutControlItem5.CustomizationFormText = "Coa Depresiasi"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(353, 24)
    Me.LayoutControlItem5.Text = "Coa Depresiasi"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(100, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtCoaAkumDepr
    Me.LayoutControlItem6.CustomizationFormText = "Coa Akum Depresiasi"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 120)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(353, 24)
    Me.LayoutControlItem6.Text = "Coa Akum Depresiasi"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(100, 13)
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.txtCOAWriteOff
    Me.LayoutControlItem7.CustomizationFormText = "Coa Write Off"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 144)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(353, 43)
    Me.LayoutControlItem7.Text = "Coa Write Off"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(100, 13)
    '
    'SimpleLabelItem1
    '
    Me.SimpleLabelItem1.AllowHotTrack = False
    Me.SimpleLabelItem1.CustomizationFormText = "Bulan"
    Me.SimpleLabelItem1.Location = New System.Drawing.Point(176, 24)
    Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
    Me.SimpleLabelItem1.Size = New System.Drawing.Size(177, 24)
    Me.SimpleLabelItem1.Text = "Bulan"
    Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(100, 13)
    '
    'txtCoaAsset
    '
    Me.txtCoaAsset.Location = New System.Drawing.Point(115, 84)
    Me.txtCoaAsset.Name = "txtCoaAsset"
    Me.txtCoaAsset.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtCoaAsset.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtCoaAsset.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCoaAsset.Properties.DisplayMember = "Kode"
    Me.txtCoaAsset.Properties.NullText = ""
    Me.txtCoaAsset.Properties.ShowClearButton = False
    Me.txtCoaAsset.Properties.ShowFooter = False
    Me.txtCoaAsset.Properties.ValueMember = "This"
    Me.txtCoaAsset.Properties.View = Me.SearchLookUpEdit1View
    Me.txtCoaAsset.Size = New System.Drawing.Size(246, 20)
    Me.txtCoaAsset.StyleController = Me.LayoutControl1
    Me.txtCoaAsset.TabIndex = 108
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
    'txtCoaDepresiasi
    '
    Me.txtCoaDepresiasi.Location = New System.Drawing.Point(115, 108)
    Me.txtCoaDepresiasi.Name = "txtCoaDepresiasi"
    Me.txtCoaDepresiasi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtCoaDepresiasi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtCoaDepresiasi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCoaDepresiasi.Properties.DisplayMember = "Kode"
    Me.txtCoaDepresiasi.Properties.NullText = ""
    Me.txtCoaDepresiasi.Properties.ShowClearButton = False
    Me.txtCoaDepresiasi.Properties.ShowFooter = False
    Me.txtCoaDepresiasi.Properties.ValueMember = "This"
    Me.txtCoaDepresiasi.Properties.View = Me.GridView1
    Me.txtCoaDepresiasi.Size = New System.Drawing.Size(246, 20)
    Me.txtCoaDepresiasi.StyleController = Me.LayoutControl1
    Me.txtCoaDepresiasi.TabIndex = 108
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
    Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsFind.AlwaysVisible = True
    Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView1.OptionsView.ShowGroupPanel = False
    Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'txtCoaAkumDepr
    '
    Me.txtCoaAkumDepr.Location = New System.Drawing.Point(115, 132)
    Me.txtCoaAkumDepr.Name = "txtCoaAkumDepr"
    Me.txtCoaAkumDepr.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtCoaAkumDepr.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtCoaAkumDepr.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCoaAkumDepr.Properties.DisplayMember = "Kode"
    Me.txtCoaAkumDepr.Properties.NullText = ""
    Me.txtCoaAkumDepr.Properties.ShowClearButton = False
    Me.txtCoaAkumDepr.Properties.ShowFooter = False
    Me.txtCoaAkumDepr.Properties.ValueMember = "This"
    Me.txtCoaAkumDepr.Properties.View = Me.GridView2
    Me.txtCoaAkumDepr.Size = New System.Drawing.Size(246, 20)
    Me.txtCoaAkumDepr.StyleController = Me.LayoutControl1
    Me.txtCoaAkumDepr.TabIndex = 108
    '
    'GridView2
    '
    Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
    Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView2.Name = "GridView2"
    Me.GridView2.OptionsFind.AlwaysVisible = True
    Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView2.OptionsView.ShowGroupPanel = False
    Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'txtCOAWriteOff
    '
    Me.txtCOAWriteOff.Location = New System.Drawing.Point(115, 156)
    Me.txtCOAWriteOff.Name = "txtCOAWriteOff"
    Me.txtCOAWriteOff.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtCOAWriteOff.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtCOAWriteOff.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCOAWriteOff.Properties.DisplayMember = "Kode"
    Me.txtCOAWriteOff.Properties.NullText = ""
    Me.txtCOAWriteOff.Properties.ShowClearButton = False
    Me.txtCOAWriteOff.Properties.ShowFooter = False
    Me.txtCOAWriteOff.Properties.ValueMember = "This"
    Me.txtCOAWriteOff.Properties.View = Me.GridView3
    Me.txtCOAWriteOff.Size = New System.Drawing.Size(246, 20)
    Me.txtCOAWriteOff.StyleController = Me.LayoutControl1
    Me.txtCOAWriteOff.TabIndex = 108
    '
    'GridView3
    '
    Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6})
    Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView3.Name = "GridView3"
    Me.GridView3.OptionsFind.AlwaysVisible = True
    Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView3.OptionsView.ShowGroupPanel = False
    Me.GridView3.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn5, DevExpress.Data.ColumnSortOrder.Ascending)})
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
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Kode"
    Me.GridColumn3.FieldName = "Kode"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 0
    Me.GridColumn3.Width = 276
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Nama"
    Me.GridColumn4.FieldName = "Nama"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 1
    Me.GridColumn4.Width = 802
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Kode"
    Me.GridColumn5.FieldName = "Kode"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 0
    Me.GridColumn5.Width = 276
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Nama"
    Me.GridColumn6.FieldName = "Nama"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 1
    Me.GridColumn6.Width = 802
    '
    'UI_AktivaKelompokDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(373, 256)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Name = "UI_AktivaKelompokDialog"
    Me.Text = "UI_AktivaKelompokDialog"
    Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.txtUmur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTipe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCoaAsset.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCoaDepresiasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCoaAkumDepr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCOAWriteOff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtKode As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtTipe As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtUmur As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
  Friend WithEvents txtCoaAsset As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtCoaDepresiasi As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtCoaAkumDepr As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtCOAWriteOff As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
