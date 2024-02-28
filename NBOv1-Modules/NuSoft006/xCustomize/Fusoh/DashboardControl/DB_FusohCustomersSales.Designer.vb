Imports NuSoft.Core.Win.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DB_FusohCustomersSales
	Inherits NuSoftUserControl

	'UserControl overrides dispose to clean up the component list.
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
		Dim SimpleDiagram1 As DevExpress.XtraCharts.SimpleDiagram = New DevExpress.XtraCharts.SimpleDiagram()
		Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
		Dim PieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
		Dim PiePointOptions1 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
		Dim PieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
		Dim PieSeriesLabel2 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
		Dim PiePointOptions2 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
		Dim PieSeriesView2 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
		Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
		Me.xChart = New DevExpress.XtraCharts.ChartControl()
		CType(Me.xChart, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(SimpleDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'xChart
		'
		Me.xChart.BorderOptions.Visible = False
		SimpleDiagram1.EqualPieSize = False
		Me.xChart.Diagram = SimpleDiagram1
		Me.xChart.Dock = System.Windows.Forms.DockStyle.Fill
		Me.xChart.Legend.EquallySpacedItems = False
		Me.xChart.Location = New System.Drawing.Point(0, 0)
		Me.xChart.Name = "xChart"
		Series1.ArgumentDataMember = "Customer"
		PieSeriesLabel1.ColumnIndent = 6
		PiePointOptions1.PointView = DevExpress.XtraCharts.PointView.Argument
		PiePointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
		PieSeriesLabel1.PointOptions = PiePointOptions1
		PieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Radial
		PieSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
		Series1.Label = PieSeriesLabel1
		Series1.Name = "Series 1"
		Series1.ShowInLegend = False
		Series1.SummaryFunction = "SUM([SalesOmzet])"
		PieSeriesView1.RuntimeExploding = False
		Series1.View = PieSeriesView1
		Me.xChart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
		Me.xChart.SeriesTemplate.ArgumentDataMember = "Customer"
		PiePointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
		PieSeriesLabel2.PointOptions = PiePointOptions2
		Me.xChart.SeriesTemplate.Label = PieSeriesLabel2
		Me.xChart.SeriesTemplate.SummaryFunction = "SUM([SalesOmzet])"
		Me.xChart.SeriesTemplate.TopNOptions.Enabled = True
		PieSeriesView2.RuntimeExploding = False
		Me.xChart.SeriesTemplate.View = PieSeriesView2
		Me.xChart.Size = New System.Drawing.Size(674, 425)
		Me.xChart.TabIndex = 1
		ChartTitle1.Text = "Top 5 Customers - YTD Sales"
		ChartTitle1.TextColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(211, Byte), Integer))
		Me.xChart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
		'
		'DB_FusohCustomersSales
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.xChart)
		Me.Name = "DB_FusohCustomersSales"
		Me.Size = New System.Drawing.Size(674, 425)
		CType(SimpleDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xChart, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Private WithEvents xChart As DevExpress.XtraCharts.ChartControl
End Class
