<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RF_SanYuVoucherProduksi
  Inherits Core.Win.Forms.FilterForm

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.txtNoRencanaProduksi = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.xNoRencana = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.xNoSO = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.xNoSOPelanggan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.xBahanJadi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtPelanggan = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtProses = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.txtNoBukti = New DevExpress.XtraEditors.TextEdit()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.txtNoRencanaProduksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPelanggan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtProses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoBukti.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.txtNoBukti)
    Me.LayoutControl1.Controls.Add(Me.txtNoRencanaProduksi)
    Me.LayoutControl1.Controls.Add(Me.txtPelanggan)
    Me.LayoutControl1.Controls.Add(Me.txtProses)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(419, 36, 250, 350)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(364, 234)
    Me.LayoutControl1.TabIndex = 120
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'txtNoRencanaProduksi
    '
    Me.txtNoRencanaProduksi.Location = New System.Drawing.Point(100, 36)
    Me.txtNoRencanaProduksi.Name = "txtNoRencanaProduksi"
    Me.txtNoRencanaProduksi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtNoRencanaProduksi.Properties.DisplayMember = "Main.OrderPenjualan.NomorPO"
    Me.txtNoRencanaProduksi.Properties.NullText = ""
    Me.txtNoRencanaProduksi.Properties.ValueMember = "This"
    Me.txtNoRencanaProduksi.Properties.View = Me.SearchLookUpEdit1View
    Me.txtNoRencanaProduksi.Size = New System.Drawing.Size(252, 20)
    Me.txtNoRencanaProduksi.StyleController = Me.LayoutControl1
    Me.txtNoRencanaProduksi.TabIndex = 119
    '
    'SearchLookUpEdit1View
    '
    Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.xNoRencana, Me.xNoSO, Me.xNoSOPelanggan, Me.xBahanJadi})
    Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
    Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
    '
    'xNoRencana
    '
    Me.xNoRencana.Caption = "No Rencana"
    Me.xNoRencana.FieldName = "Main.Kode"
    Me.xNoRencana.Name = "xNoRencana"
    Me.xNoRencana.Visible = True
    Me.xNoRencana.VisibleIndex = 0
    '
    'xNoSO
    '
    Me.xNoSO.Caption = "No SO"
    Me.xNoSO.FieldName = "Main.OrderPenjualan.Kode"
    Me.xNoSO.Name = "xNoSO"
    Me.xNoSO.Visible = True
    Me.xNoSO.VisibleIndex = 1
    '
    'xNoSOPelanggan
    '
    Me.xNoSOPelanggan.Caption = "No PO Pelanggan"
    Me.xNoSOPelanggan.FieldName = "Main.OrderPenjualan.NomorPO"
    Me.xNoSOPelanggan.Name = "xNoSOPelanggan"
    Me.xNoSOPelanggan.Visible = True
    Me.xNoSOPelanggan.VisibleIndex = 2
    '
    'xBahanJadi
    '
    Me.xBahanJadi.Caption = "Bahan Jadi"
    Me.xBahanJadi.FieldName = "Barang.Nama"
    Me.xBahanJadi.Name = "xBahanJadi"
    Me.xBahanJadi.Visible = True
    Me.xBahanJadi.VisibleIndex = 3
    '
    'txtPelanggan
    '
    Me.txtPelanggan.Location = New System.Drawing.Point(100, 12)
    Me.txtPelanggan.Name = "txtPelanggan"
    Me.txtPelanggan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPelanggan.Properties.DisplayMember = "Nama"
    Me.txtPelanggan.Properties.NullText = ""
    Me.txtPelanggan.Properties.ValueMember = "This"
    Me.txtPelanggan.Properties.View = Me.GridView1
    Me.txtPelanggan.Size = New System.Drawing.Size(252, 20)
    Me.txtPelanggan.StyleController = Me.LayoutControl1
    Me.txtPelanggan.TabIndex = 118
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3})
    Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Kode"
    Me.GridColumn2.FieldName = "Kode"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 0
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Nama"
    Me.GridColumn3.FieldName = "Nama"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 1
    '
    'txtProses
    '
    Me.txtProses.Location = New System.Drawing.Point(100, 60)
    Me.txtProses.Name = "txtProses"
    Me.txtProses.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtProses.Properties.DisplayMember = "Proses.Nama"
    Me.txtProses.Properties.NullText = ""
    Me.txtProses.Properties.ValueMember = "Id"
    Me.txtProses.Properties.View = Me.GridView2
    Me.txtProses.Size = New System.Drawing.Size(252, 20)
    Me.txtProses.StyleController = Me.LayoutControl1
    Me.txtProses.TabIndex = 106
    '
    'GridView2
    '
    Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode, Me.colTanggal, Me.GridColumn1})
    Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView2.Name = "GridView2"
    Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView2.OptionsView.ShowGroupPanel = False
    '
    'colKode
    '
    Me.colKode.Caption = "No Bukti"
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    '
    'colTanggal
    '
    Me.colTanggal.Caption = "Tanggal"
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 1
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Proses"
    Me.GridColumn1.FieldName = "Proses.Nama"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 2
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(364, 234)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtPelanggan
    Me.LayoutControlItem1.CustomizationFormText = "Pelanggan"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(344, 24)
    Me.LayoutControlItem1.Text = "Pelanggan"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(85, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtNoRencanaProduksi
    Me.LayoutControlItem2.CustomizationFormText = "Rencana Produksi"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(344, 24)
    Me.LayoutControlItem2.Text = "Rencana Produksi"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(85, 13)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtProses
    Me.LayoutControlItem3.CustomizationFormText = "Item Jadi"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(344, 24)
    Me.LayoutControlItem3.Text = "Proses"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(85, 13)
    '
    'txtNoBukti
    '
    Me.txtNoBukti.Location = New System.Drawing.Point(100, 202)
    Me.txtNoBukti.Name = "txtNoBukti"
    Me.txtNoBukti.Size = New System.Drawing.Size(252, 20)
    Me.txtNoBukti.StyleController = Me.LayoutControl1
    Me.txtNoBukti.TabIndex = 120
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtNoBukti
    Me.LayoutControlItem4.CustomizationFormText = "No Bukti"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 190)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(344, 24)
    Me.LayoutControlItem4.Text = "No Bukti"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(85, 13)
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 72)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(344, 118)
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'RF_SanYuVoucherProduksi
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(364, 283)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Name = "RF_SanYuVoucherProduksi"
    Me.Text = "Filter Laporan"
    Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.txtNoRencanaProduksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPelanggan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtProses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoBukti.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtNoRencanaProduksi As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtPelanggan As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents txtProses As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents xNoRencana As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents xNoSO As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents xNoSOPelanggan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents xBahanJadi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtNoBukti As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
