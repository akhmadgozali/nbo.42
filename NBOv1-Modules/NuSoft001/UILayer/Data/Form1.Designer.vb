<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

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
		Me.nChartLR = New DevExpress.XtraCharts.ChartControl()
		CType(Me.nChartLR, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(SimpleDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Pie3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Pie3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Pie3DSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Pie3DSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'nChartLR
		'
		Me.nChartLR.AppearanceNameSerializable = "Nature Colors"
		SimpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1"
		Me.nChartLR.Diagram = SimpleDiagram3D1
		Me.nChartLR.EmptyChartText.Text = "Data Kosong"
		Me.nChartLR.Location = New System.Drawing.Point(21, 22)
		Me.nChartLR.Name = "nChartLR"
		Series1.ArgumentDataMember = "f_contact.Nama"
		PiePointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
		Pie3DSeriesLabel1.PointOptions = PiePointOptions1
		Series1.Label = Pie3DSeriesLabel1
		PiePointOptions2.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
		PiePointOptions2.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
		PiePointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
		Series1.LegendPointOptions = PiePointOptions2
		Series1.LegendText = "Legend"
		Series1.Name = "LabaRugiSeries"
		Series1.SynchronizePointOptions = False
		Series1.ValueDataMembersSerializable = "saldo"
		Pie3DSeriesView1.SizeAsPercentage = 100.0R
		Series1.View = Pie3DSeriesView1
		Me.nChartLR.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
		PiePointOptions3.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
		Pie3DSeriesLabel2.PointOptions = PiePointOptions3
		Me.nChartLR.SeriesTemplate.Label = Pie3DSeriesLabel2
		Pie3DSeriesView2.SizeAsPercentage = 100.0R
		Me.nChartLR.SeriesTemplate.View = Pie3DSeriesView2
		Me.nChartLR.Size = New System.Drawing.Size(352, 134)
		Me.nChartLR.TabIndex = 12
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.nChartLR)
		Me.Name = "Form1"
		Me.Text = "Form1"
		CType(SimpleDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Pie3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Pie3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Pie3DSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Pie3DSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nChartLR, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents nChartLR As DevExpress.XtraCharts.ChartControl
End Class
