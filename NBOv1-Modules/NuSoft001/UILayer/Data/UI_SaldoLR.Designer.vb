<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_SaldoLR
	Inherits Core.Win.Forms.GridOutput

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
		Dim SimpleDiagram3D1 As DevExpress.XtraCharts.SimpleDiagram3D = New DevExpress.XtraCharts.SimpleDiagram3D()
		Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
		Dim Pie3DSeriesLabel1 As DevExpress.XtraCharts.Pie3DSeriesLabel = New DevExpress.XtraCharts.Pie3DSeriesLabel()
		Dim PiePointOptions1 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
		Dim PiePointOptions2 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
		Dim Pie3DSeriesView1 As DevExpress.XtraCharts.Pie3DSeriesView = New DevExpress.XtraCharts.Pie3DSeriesView()
		Dim Pie3DSeriesLabel2 As DevExpress.XtraCharts.Pie3DSeriesLabel = New DevExpress.XtraCharts.Pie3DSeriesLabel()
		Dim PiePointOptions3 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
		Dim Pie3DSeriesView2 As DevExpress.XtraCharts.Pie3DSeriesView = New DevExpress.XtraCharts.Pie3DSeriesView()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_SaldoLR))
		Me.nChart = New DevExpress.XtraCharts.ChartControl()
		Me.txtPeriode = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
		Me.btnFilter = New DevExpress.XtraBars.BarButtonItem()
		Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSaldoAkhir = New DevExpress.XtraGrid.Columns.GridColumn()
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainerControl1.SuspendLayout()
		CType(Me.chartPopUp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nChart, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(SimpleDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Pie3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Pie3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Pie3DSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Pie3DSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPeriode, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPeriode.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'barMan
		'
		Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFilter})
		Me.barMan.MaxItemId = 24
		Me.barMan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtPeriode})
		'
		'xGrid
		'
		Me.xGrid.Size = New System.Drawing.Size(800, 212)
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.colSaldoAkhir})
		Me.xGridView.OptionsBehavior.Editable = False
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsSelection.MultiSelect = True
		Me.xGridView.OptionsView.ColumnAutoWidth = False
		'
		'barMenu
		'
		Me.barMenu.OptionsBar.AllowQuickCustomization = False
		Me.barMenu.OptionsBar.DrawDragBorder = False
		Me.barMenu.OptionsBar.UseWholeRow = True
		'
		'SplitContainerControl1
		'
		Me.SplitContainerControl1.Panel2.Controls.Add(Me.nChart)
		Me.SplitContainerControl1.Size = New System.Drawing.Size(800, 423)
		'
		'nChart
		'
		SimpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1"
		Me.nChart.Diagram = SimpleDiagram3D1
		Me.nChart.Dock = System.Windows.Forms.DockStyle.Fill
		Me.nChart.Location = New System.Drawing.Point(0, 0)
		Me.nChart.Name = "nChart"
		PiePointOptions1.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
		PiePointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent
		Pie3DSeriesLabel1.PointOptions = PiePointOptions1
		Series1.Label = Pie3DSeriesLabel1
		PiePointOptions2.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
		PiePointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent
		Series1.LegendPointOptions = PiePointOptions2
		Series1.LegendText = "Biaya"
		Series1.Name = "Series 1"
		Series1.SynchronizePointOptions = False
		Series1.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[True]
		Pie3DSeriesView1.SizeAsPercentage = 100.0R
		Series1.View = Pie3DSeriesView1
		Me.nChart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
		PiePointOptions3.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
		Pie3DSeriesLabel2.PointOptions = PiePointOptions3
		Me.nChart.SeriesTemplate.Label = Pie3DSeriesLabel2
		Pie3DSeriesView2.SizeAsPercentage = 100.0R
		Me.nChart.SeriesTemplate.View = Pie3DSeriesView2
		Me.nChart.Size = New System.Drawing.Size(800, 206)
		Me.nChart.TabIndex = 0
		'
		'txtPeriode
		'
		Me.txtPeriode.AutoHeight = False
		Me.txtPeriode.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtPeriode.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtPeriode.Name = "txtPeriode"
		'
		'btnFilter
		'
		Me.btnFilter.Caption = "Filter"
		Me.btnFilter.Glyph = CType(resources.GetObject("btnFilter.Glyph"), System.Drawing.Image)
		Me.btnFilter.Id = 23
		Me.btnFilter.LargeGlyph = CType(resources.GetObject("btnFilter.LargeGlyph"), System.Drawing.Image)
		Me.btnFilter.Name = "btnFilter"
		'
		'GridColumn1
		'
		Me.GridColumn1.Caption = "Kode"
		Me.GridColumn1.FieldName = "Kode"
		Me.GridColumn1.Name = "GridColumn1"
		Me.GridColumn1.Visible = True
		Me.GridColumn1.VisibleIndex = 0
		Me.GridColumn1.Width = 101
		'
		'GridColumn2
		'
		Me.GridColumn2.Caption = "Nama"
		Me.GridColumn2.FieldName = "Nama"
		Me.GridColumn2.Name = "GridColumn2"
		Me.GridColumn2.Visible = True
		Me.GridColumn2.VisibleIndex = 1
		Me.GridColumn2.Width = 342
		'
		'colSaldoAkhir
		'
		Me.colSaldoAkhir.Caption = "Saldo"
		Me.colSaldoAkhir.FieldName = "SaldoAkhir"
		Me.colSaldoAkhir.Name = "colSaldoAkhir"
		Me.colSaldoAkhir.Visible = True
		Me.colSaldoAkhir.VisibleIndex = 2
		Me.colSaldoAkhir.Width = 125
		'
		'UI_SaldoLR
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Name = "UI_SaldoLR"
		Me.Text = "Saldo Laba Rugi"
		Me.xpCol = Me.xpCol
		CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainerControl1.ResumeLayout(False)
		CType(Me.chartPopUp, System.ComponentModel.ISupportInitialize).EndInit()
		CType(SimpleDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Pie3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Pie3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Pie3DSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Pie3DSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nChart, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPeriode.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPeriode, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents nChart As DevExpress.XtraCharts.ChartControl
	Friend WithEvents txtPeriode As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
	Friend WithEvents btnFilter As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSaldoAkhir As DevExpress.XtraGrid.Columns.GridColumn
End Class
