<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_FusohCekStockHPPSerial
  Inherits Core.Win.Forms.BlankForm

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
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colSerial = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLengthIn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLengthOut = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
		Me.txtSelisih = New DevExpress.XtraEditors.MemoEdit()
		Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
		Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
		Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.xGridStockOut = New DevExpress.XtraGrid.GridControl()
		Me.xGridStockOutView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
		Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.LayoutControl1.SuspendLayout()
		CType(Me.txtSelisih.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridStockOut, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridStockOutView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'xGrid
		'
		Me.xGrid.Location = New System.Drawing.Point(24, 46)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.Name = "xGrid"
		Me.xGrid.Size = New System.Drawing.Size(900, 380)
		Me.xGrid.TabIndex = 1
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSerial, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.colLengthIn, Me.colLengthOut})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'colSerial
		'
		Me.colSerial.Caption = "Serial"
		Me.colSerial.FieldName = "Serial"
		Me.colSerial.Name = "colSerial"
		Me.colSerial.OptionsColumn.ReadOnly = True
		Me.colSerial.Visible = True
		Me.colSerial.VisibleIndex = 3
		'
		'GridColumn1
		'
		Me.GridColumn1.Caption = "No Bukti"
		Me.GridColumn1.FieldName = "DetailMain.Main.Kode"
		Me.GridColumn1.Name = "GridColumn1"
		Me.GridColumn1.Visible = True
		Me.GridColumn1.VisibleIndex = 0
		'
		'GridColumn2
		'
		Me.GridColumn2.Caption = "Qty"
		Me.GridColumn2.FieldName = "DetailMain.QtyIn"
		Me.GridColumn2.Name = "GridColumn2"
		Me.GridColumn2.Visible = True
		Me.GridColumn2.VisibleIndex = 1
		'
		'GridColumn3
		'
		Me.GridColumn3.Caption = "Harga"
		Me.GridColumn3.FieldName = "HargaSerial"
		Me.GridColumn3.Name = "GridColumn3"
		Me.GridColumn3.Visible = True
		Me.GridColumn3.VisibleIndex = 2
		'
		'colLengthIn
		'
		Me.colLengthIn.Caption = "Length IN"
		Me.colLengthIn.FieldName = "LengthIn"
		Me.colLengthIn.Name = "colLengthIn"
		Me.colLengthIn.OptionsColumn.AllowEdit = False
		Me.colLengthIn.Visible = True
		Me.colLengthIn.VisibleIndex = 4
		'
		'colLengthOut
		'
		Me.colLengthOut.Caption = "Length Out"
		Me.colLengthOut.FieldName = "LengthOut"
		Me.colLengthOut.Name = "colLengthOut"
		Me.colLengthOut.OptionsColumn.AllowEdit = False
		Me.colLengthOut.Visible = True
		Me.colLengthOut.VisibleIndex = 5
		'
		'LayoutControl1
		'
		Me.LayoutControl1.Controls.Add(Me.txtSelisih)
		Me.LayoutControl1.Controls.Add(Me.btnExport)
		Me.LayoutControl1.Controls.Add(Me.GridControl2)
		Me.LayoutControl1.Controls.Add(Me.xGridStockOut)
		Me.LayoutControl1.Controls.Add(Me.xGrid)
		Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControl1.Name = "LayoutControl1"
		Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(804, 116, 250, 404)
		Me.LayoutControl1.Root = Me.LayoutControlGroup1
		Me.LayoutControl1.Size = New System.Drawing.Size(948, 450)
		Me.LayoutControl1.TabIndex = 2
		Me.LayoutControl1.Text = "LayoutControl1"
		'
		'txtSelisih
		'
		Me.txtSelisih.Location = New System.Drawing.Point(56, 228)
		Me.txtSelisih.Name = "txtSelisih"
		Me.txtSelisih.Size = New System.Drawing.Size(868, 172)
		Me.txtSelisih.StyleController = Me.LayoutControl1
		Me.txtSelisih.TabIndex = 7
		'
		'btnExport
		'
		Me.btnExport.Location = New System.Drawing.Point(24, 404)
		Me.btnExport.Name = "btnExport"
		Me.btnExport.Size = New System.Drawing.Size(91, 22)
		Me.btnExport.StyleController = Me.LayoutControl1
		Me.btnExport.TabIndex = 6
		Me.btnExport.Text = "Export"
		'
		'GridControl2
		'
		Me.GridControl2.Location = New System.Drawing.Point(24, 46)
		Me.GridControl2.MainView = Me.GridView2
		Me.GridControl2.Name = "GridControl2"
		Me.GridControl2.Size = New System.Drawing.Size(900, 380)
		Me.GridControl2.TabIndex = 5
		Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
		'
		'GridView2
		'
		Me.GridView2.GridControl = Me.GridControl2
		Me.GridView2.Name = "GridView2"
		'
		'xGridStockOut
		'
		Me.xGridStockOut.Location = New System.Drawing.Point(24, 46)
		Me.xGridStockOut.MainView = Me.xGridStockOutView
		Me.xGridStockOut.Name = "xGridStockOut"
		Me.xGridStockOut.Size = New System.Drawing.Size(900, 178)
		Me.xGridStockOut.TabIndex = 4
		Me.xGridStockOut.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridStockOutView})
		'
		'xGridStockOutView
		'
		Me.xGridStockOutView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
		Me.xGridStockOutView.GridControl = Me.xGridStockOut
		Me.xGridStockOutView.Name = "xGridStockOutView"
		Me.xGridStockOutView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridStockOutView.OptionsView.ShowGroupPanel = False
		'
		'GridColumn4
		'
		Me.GridColumn4.Caption = "Serial"
		Me.GridColumn4.FieldName = "Serial"
		Me.GridColumn4.Name = "GridColumn4"
		Me.GridColumn4.Visible = True
		Me.GridColumn4.VisibleIndex = 0
		'
		'GridColumn5
		'
		Me.GridColumn5.Caption = "Length"
		Me.GridColumn5.FieldName = "Length"
		Me.GridColumn5.Name = "GridColumn5"
		Me.GridColumn5.Visible = True
		Me.GridColumn5.VisibleIndex = 1
		'
		'GridColumn6
		'
		Me.GridColumn6.Caption = "HPP"
		Me.GridColumn6.DisplayFormat.FormatString = "n2"
		Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.GridColumn6.FieldName = "HPP"
		Me.GridColumn6.Name = "GridColumn6"
		Me.GridColumn6.Visible = True
		Me.GridColumn6.VisibleIndex = 2
		'
		'GridColumn7
		'
		Me.GridColumn7.Caption = "Hpp Stock Detail"
		Me.GridColumn7.FieldName = "Row.DetailMain.TotalHPP"
		Me.GridColumn7.Name = "GridColumn7"
		Me.GridColumn7.Visible = True
		Me.GridColumn7.VisibleIndex = 3
		'
		'GridColumn8
		'
		Me.GridColumn8.Caption = "No Transaksi"
		Me.GridColumn8.FieldName = "Row.DetailMain.Main.Kode"
		Me.GridColumn8.Name = "GridColumn8"
		Me.GridColumn8.Visible = True
		Me.GridColumn8.VisibleIndex = 4
		'
		'GridColumn9
		'
		Me.GridColumn9.Caption = "No Pembelian"
		Me.GridColumn9.FieldName = "NoGR"
		Me.GridColumn9.Name = "GridColumn9"
		Me.GridColumn9.Visible = True
		Me.GridColumn9.VisibleIndex = 5
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.CustomizationFormText = "Root"
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "Root"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(948, 450)
		Me.LayoutControlGroup1.Text = "Root"
		Me.LayoutControlGroup1.TextVisible = False
		'
		'TabbedControlGroup1
		'
		Me.TabbedControlGroup1.CustomizationFormText = "TabbedControlGroup1"
		Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
		Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup3
		Me.TabbedControlGroup1.SelectedTabPageIndex = 1
		Me.TabbedControlGroup1.Size = New System.Drawing.Size(928, 430)
		Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlGroup4})
		Me.TabbedControlGroup1.Text = "TabbedControlGroup1"
		'
		'LayoutControlGroup3
		'
		Me.LayoutControlGroup3.CustomizationFormText = "Stock OUT"
		Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LayoutControlItem5})
		Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
		Me.LayoutControlGroup3.Size = New System.Drawing.Size(904, 384)
		Me.LayoutControlGroup3.Text = "Stock OUT"
		'
		'LayoutControlItem2
		'
		Me.LayoutControlItem2.Control = Me.xGridStockOut
		Me.LayoutControlItem2.CustomizationFormText = "Stock Out"
		Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem2.Name = "LayoutControlItem2"
		Me.LayoutControlItem2.Size = New System.Drawing.Size(904, 182)
		Me.LayoutControlItem2.Text = "Stock Out"
		Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem2.TextToControlDistance = 0
		Me.LayoutControlItem2.TextVisible = False
		'
		'LayoutControlItem4
		'
		Me.LayoutControlItem4.Control = Me.btnExport
		Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
		Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 358)
		Me.LayoutControlItem4.Name = "LayoutControlItem4"
		Me.LayoutControlItem4.Size = New System.Drawing.Size(95, 26)
		Me.LayoutControlItem4.Text = "LayoutControlItem4"
		Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem4.TextToControlDistance = 0
		Me.LayoutControlItem4.TextVisible = False
		'
		'EmptySpaceItem1
		'
		Me.EmptySpaceItem1.AllowHotTrack = False
		Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
		Me.EmptySpaceItem1.Location = New System.Drawing.Point(95, 358)
		Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
		Me.EmptySpaceItem1.Size = New System.Drawing.Size(809, 26)
		Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
		Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem5
		'
		Me.LayoutControlItem5.Control = Me.txtSelisih
		Me.LayoutControlItem5.CustomizationFormText = "Selisih"
		Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 182)
		Me.LayoutControlItem5.Name = "LayoutControlItem5"
		Me.LayoutControlItem5.Size = New System.Drawing.Size(904, 176)
		Me.LayoutControlItem5.Text = "Selisih"
		Me.LayoutControlItem5.TextSize = New System.Drawing.Size(29, 13)
		'
		'LayoutControlGroup2
		'
		Me.LayoutControlGroup2.CustomizationFormText = "Stock IN"
		Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
		Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
		Me.LayoutControlGroup2.Size = New System.Drawing.Size(904, 384)
		Me.LayoutControlGroup2.Text = "Stock IN"
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.xGrid
		Me.LayoutControlItem1.CustomizationFormText = "Stock IN"
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(904, 384)
		Me.LayoutControlItem1.Text = "Stock IN"
		Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem1.TextToControlDistance = 0
		Me.LayoutControlItem1.TextVisible = False
		'
		'LayoutControlGroup4
		'
		Me.LayoutControlGroup4.CustomizationFormText = "Selisih "
		Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3})
		Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
		Me.LayoutControlGroup4.Size = New System.Drawing.Size(904, 384)
		Me.LayoutControlGroup4.Text = "Selisih "
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.GridControl2
		Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
		Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(904, 384)
		Me.LayoutControlItem3.Text = "LayoutControlItem3"
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem3.TextToControlDistance = 0
		Me.LayoutControlItem3.TextVisible = False
		'
		'GridColumn10
		'
		Me.GridColumn10.Caption = "HPP Detail Out"
		Me.GridColumn10.FieldName = "Row.DetailMain.TotalHPP"
		Me.GridColumn10.Name = "GridColumn10"
		Me.GridColumn10.Visible = True
		Me.GridColumn10.VisibleIndex = 6
		'
		'GridColumn11
		'
		Me.GridColumn11.Caption = "HPP Detail Qty"
		Me.GridColumn11.FieldName = "Row.DetailMain.QtyOut"
		Me.GridColumn11.Name = "GridColumn11"
		Me.GridColumn11.Visible = True
		Me.GridColumn11.VisibleIndex = 7
		'
		'GridColumn12
		'
		Me.GridColumn12.Caption = "Harga HPP IN"
		Me.GridColumn12.FieldName = "HargaGR"
		Me.GridColumn12.Name = "GridColumn12"
		Me.GridColumn12.Visible = True
		Me.GridColumn12.VisibleIndex = 8
		'
		'UI_FusohCekStockHPPSerial
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(948, 450)
		Me.Controls.Add(Me.LayoutControl1)
		Me.Name = "UI_FusohCekStockHPPSerial"
		Me.Text = "UI_FusohCekStockHPPSerial"
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.LayoutControl1.ResumeLayout(False)
		CType(Me.txtSelisih.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridStockOut, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridStockOutView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colSerial As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLengthIn As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLengthOut As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents xGridStockOut As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridStockOutView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
  Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtSelisih As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
End Class
