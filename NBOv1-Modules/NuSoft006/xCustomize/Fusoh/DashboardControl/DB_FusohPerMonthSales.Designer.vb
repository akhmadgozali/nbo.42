Imports NuSoft.Core.Win.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DB_FusohPerMonthSales
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
		Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
		Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
		Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
		Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
		Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
		Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
		Me.xChart = New DevExpress.XtraCharts.ChartControl()
		CType(Me.xChart, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'xChart
		'
		Me.xChart.AppearanceNameSerializable = "Pastel Kit"
		Me.xChart.BorderOptions.Color = System.Drawing.Color.White
		Me.xChart.BorderOptions.Visible = False
		XyDiagram1.AxisX.Label.DateTimeOptions.AutoFormat = False
		XyDiagram1.AxisX.Label.DateTimeOptions.Format = DevExpress.XtraCharts.DateTimeFormat.Custom
		XyDiagram1.AxisX.Label.DateTimeOptions.FormatString = "MMMM"
		XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
		XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
		Me.xChart.Diagram = XyDiagram1
		Me.xChart.Dock = System.Windows.Forms.DockStyle.Fill
		Me.xChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
		Me.xChart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
		Me.xChart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
		Me.xChart.Legend.EquallySpacedItems = False
		Me.xChart.Location = New System.Drawing.Point(0, 0)
		Me.xChart.Name = "xChart"
		Series1.ArgumentDataMember = "Tanggal"
		Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
		Series1.CrosshairLabelPattern = "{A:MMMM} : {V:n0}"
		PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
		PointOptions1.ValueNumericOptions.Precision = 0
		SideBySideBarSeriesLabel1.PointOptions = PointOptions1
		Series1.Label = SideBySideBarSeriesLabel1
		Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
		Series1.Name = "Series 4"
		Series1.ShowInLegend = False
		Series1.SummaryFunction = "SUM([Total])"
		SideBySideBarSeriesView1.BarWidth = 1.0R
		Series1.View = SideBySideBarSeriesView1
		Me.xChart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
		Me.xChart.SeriesTemplate.ArgumentDataMember = "Tanggal"
		Me.xChart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
		Me.xChart.SeriesTemplate.SummaryFunction = "SUM([Total])"
		Me.xChart.Size = New System.Drawing.Size(900, 483)
		Me.xChart.TabIndex = 1
		ChartTitle1.Text = "Per Month - YTD Sales"
		ChartTitle1.TextColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(211, Byte), Integer))
		Me.xChart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
		'
		'DB_FusohPerMonthSales
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.xChart)
		Me.Name = "DB_FusohPerMonthSales"
		Me.Size = New System.Drawing.Size(900, 483)
		CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xChart, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Private WithEvents xChart As DevExpress.XtraCharts.ChartControl
End Class
