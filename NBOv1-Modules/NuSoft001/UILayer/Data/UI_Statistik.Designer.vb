<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Statistik
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
    Me.components = New System.ComponentModel.Container()
    Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
    Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
    Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
    Dim SimpleDiagram3D1 As DevExpress.XtraCharts.SimpleDiagram3D = New DevExpress.XtraCharts.SimpleDiagram3D()
    Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim Pie3DSeriesLabel1 As DevExpress.XtraCharts.Pie3DSeriesLabel = New DevExpress.XtraCharts.Pie3DSeriesLabel()
    Dim PiePointOptions1 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
    Dim PiePointOptions2 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
    Dim Pie3DSeriesView1 As DevExpress.XtraCharts.Pie3DSeriesView = New DevExpress.XtraCharts.Pie3DSeriesView()
    Dim Pie3DSeriesLabel2 As DevExpress.XtraCharts.Pie3DSeriesLabel = New DevExpress.XtraCharts.Pie3DSeriesLabel()
    Dim PiePointOptions3 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
    Dim Pie3DSeriesView2 As DevExpress.XtraCharts.Pie3DSeriesView = New DevExpress.XtraCharts.Pie3DSeriesView()
    Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
    Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim PointOptions2 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
    Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_Statistik))
    Me.lytStatistik = New DevExpress.XtraLayout.LayoutControl()
    Me.nChartKas = New DevExpress.XtraCharts.ChartControl()
    Me.nChartLR = New DevExpress.XtraCharts.ChartControl()
    Me.nChartNeraca = New DevExpress.XtraCharts.ChartControl()
    Me.xGridCOA = New DevExpress.XtraGrid.GridControl()
    Me.xGridCoaView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSaldoValas = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtBulan = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.txtTahun = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
    Me.Bar3 = New DevExpress.XtraBars.Bar()
    Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
    Me.btnPrintPreview = New DevExpress.XtraBars.BarButtonItem()
    Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
    Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytStatistik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lytStatistik.SuspendLayout()
        CType(Me.nChartKas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nChartLR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SimpleDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Pie3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Pie3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Pie3DSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Pie3DSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nChartNeraca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridCOA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridCoaView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lytStatistik
        '
        Me.lytStatistik.Controls.Add(Me.nChartKas)
        Me.lytStatistik.Controls.Add(Me.nChartLR)
        Me.lytStatistik.Controls.Add(Me.nChartNeraca)
        Me.lytStatistik.Controls.Add(Me.xGridCOA)
        Me.lytStatistik.Controls.Add(Me.txtBulan)
        Me.lytStatistik.Controls.Add(Me.txtTahun)
        Me.lytStatistik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lytStatistik.Location = New System.Drawing.Point(0, 0)
        Me.lytStatistik.Name = "lytStatistik"
        Me.lytStatistik.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(521, 309, 250, 350)
        Me.lytStatistik.Root = Me.LayoutControlGroup1
        Me.lytStatistik.Size = New System.Drawing.Size(759, 375)
        Me.lytStatistik.TabIndex = 0
        Me.lytStatistik.Text = "lytStatistik"
        '
        'nChartKas
        '
        Me.nChartKas.AppearanceNameSerializable = "Nature Colors"
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Label.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.Rotated = True
        Me.nChartKas.Diagram = XyDiagram1
        Me.nChartKas.EmptyChartText.Text = "Data Kosong"
        Me.nChartKas.Legend.Visible = False
        Me.nChartKas.Location = New System.Drawing.Point(17, 224)
        Me.nChartKas.Name = "nChartKas"
        Series1.ArgumentDataMember = "AkunDetail.Nama"
        PointOptions1.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        PointOptions1.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
        Series1.LegendPointOptions = PointOptions1
        Series1.LegendText = "Legend"
        Series1.Name = "SeriesKasBank"
        Series1.SynchronizePointOptions = False
        Series1.ValueDataMembersSerializable = "SaldoAwal"
        SideBySideBarSeriesView1.ColorEach = True
        Series1.View = SideBySideBarSeriesView1
        Me.nChartKas.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.nChartKas.Size = New System.Drawing.Size(359, 134)
        Me.nChartKas.TabIndex = 12
        '
        'nChartLR
        '
        Me.nChartLR.AppearanceNameSerializable = "Nature Colors"
        SimpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1"
        Me.nChartLR.Diagram = SimpleDiagram3D1
        Me.nChartLR.EmptyChartText.Text = "Data Kosong"
        Me.nChartLR.Location = New System.Drawing.Point(390, 224)
        Me.nChartLR.Name = "nChartLR"
        Series2.ArgumentDataMember = "f_contact.Nama"
        PiePointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Pie3DSeriesLabel1.PointOptions = PiePointOptions1
        Series2.Label = Pie3DSeriesLabel1
        PiePointOptions2.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        PiePointOptions2.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
        PiePointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Series2.LegendPointOptions = PiePointOptions2
        Series2.LegendText = "Legend"
        Series2.Name = "LabaRugiSeries"
        Series2.SynchronizePointOptions = False
        Series2.ValueDataMembersSerializable = "saldo"
        Pie3DSeriesView1.SizeAsPercentage = 100.0R
        Series2.View = Pie3DSeriesView1
        Me.nChartLR.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        PiePointOptions3.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        Pie3DSeriesLabel2.PointOptions = PiePointOptions3
        Me.nChartLR.SeriesTemplate.Label = Pie3DSeriesLabel2
        Pie3DSeriesView2.SizeAsPercentage = 100.0R
        Me.nChartLR.SeriesTemplate.View = Pie3DSeriesView2
        Me.nChartLR.Size = New System.Drawing.Size(352, 134)
        Me.nChartLR.TabIndex = 11
        '
        'nChartNeraca
        '
        Me.nChartNeraca.AppearanceNameSerializable = "Nature Colors"
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.Label.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.nChartNeraca.Diagram = XyDiagram2
        Me.nChartNeraca.EmptyChartText.Text = "Data Kosong"
        Me.nChartNeraca.Location = New System.Drawing.Point(390, 61)
        Me.nChartNeraca.Name = "nChartNeraca"
        Series3.ArgumentDataMember = "f_contact.Nama"
        PointOptions2.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        PointOptions2.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
        Series3.LegendPointOptions = PointOptions2
        Series3.LegendText = "Legend"
        Series3.Name = "Series 1"
        Series3.SynchronizePointOptions = False
        Series3.ValueDataMembersSerializable = "saldo"
        SideBySideBarSeriesView2.ColorEach = True
        Series3.View = SideBySideBarSeriesView2
        Me.nChartNeraca.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3}
        Me.nChartNeraca.Size = New System.Drawing.Size(352, 130)
        Me.nChartNeraca.TabIndex = 7
        '
        'xGridCOA
        '
        Me.xGridCOA.Location = New System.Drawing.Point(17, 61)
        Me.xGridCOA.MainView = Me.xGridCoaView
        Me.xGridCOA.Name = "xGridCOA"
        Me.xGridCOA.Size = New System.Drawing.Size(359, 130)
        Me.xGridCOA.TabIndex = 4
        Me.xGridCOA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridCoaView})
        '
        'xGridCoaView
        '
        Me.xGridCoaView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode, Me.colNama, Me.colUang, Me.colSaldo, Me.colSaldoValas})
        Me.xGridCoaView.GridControl = Me.xGridCOA
        Me.xGridCoaView.Name = "xGridCoaView"
        Me.xGridCoaView.OptionsBehavior.Editable = False
        Me.xGridCoaView.OptionsBehavior.ReadOnly = True
        Me.xGridCoaView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridCoaView.OptionsView.ShowFooter = True
        Me.xGridCoaView.OptionsView.ShowGroupPanel = False
        '
        'colKode
        '
        Me.colKode.Caption = "Kode"
        Me.colKode.FieldName = "AkunDetail.Kode"
        Me.colKode.Name = "colKode"
        Me.colKode.Visible = True
        Me.colKode.VisibleIndex = 0
        '
        'colNama
        '
        Me.colNama.Caption = "Nama"
        Me.colNama.FieldName = "AkunDetail.Nama"
        Me.colNama.Name = "colNama"
        Me.colNama.Visible = True
        Me.colNama.VisibleIndex = 1
        '
        'colUang
        '
        Me.colUang.Caption = "Uang"
        Me.colUang.FieldName = "AkunDetail.MataUang.Kode"
        Me.colUang.Name = "colUang"
        Me.colUang.Visible = True
        Me.colUang.VisibleIndex = 2
        '
        'colSaldo
        '
        Me.colSaldo.Caption = "Saldo"
        Me.colSaldo.FieldName = "SaldoAwal"
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colSaldo.Visible = True
        Me.colSaldo.VisibleIndex = 3
        '
        'colSaldoValas
        '
        Me.colSaldoValas.Caption = "Saldo Valas"
        Me.colSaldoValas.FieldName = "SaldoAwalValas"
        Me.colSaldoValas.Name = "colSaldoValas"
        Me.colSaldoValas.Visible = True
        Me.colSaldoValas.VisibleIndex = 4
        '
        'txtBulan
        '
        Me.txtBulan.Location = New System.Drawing.Point(562, 12)
        Me.txtBulan.Name = "txtBulan"
        Me.txtBulan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBulan.Properties.PopupSizeable = True
        Me.txtBulan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtBulan.Size = New System.Drawing.Size(120, 20)
        Me.txtBulan.StyleController = Me.lytStatistik
        Me.txtBulan.TabIndex = 8
        '
        'txtTahun
        '
        Me.txtTahun.Location = New System.Drawing.Point(686, 12)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTahun.Size = New System.Drawing.Size(61, 20)
        Me.txtTahun.StyleController = Me.lytStatistik
        Me.txtTahun.TabIndex = 9
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.SimpleLabelItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(759, 375)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtBulan
        Me.LayoutControlItem3.CustomizationFormText = "Periode"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(509, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(165, 25)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(165, 25)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(165, 25)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Periode"
        Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(36, 13)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtTahun
        Me.LayoutControlItem4.CustomizationFormText = "Tahun"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(674, 0)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(50, 25)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(65, 25)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Tahun"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(254, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(255, 25)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Saldo Kas && Bank"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(373, 163)
        Me.LayoutControlGroup2.Text = "Saldo Kas && Bank"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.xGridCOA
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(104, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(363, 134)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "Neraca"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(373, 25)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(366, 163)
        Me.LayoutControlGroup3.Text = "Neraca"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.nChartNeraca
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(356, 134)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "Top 5 Saldo Kas && Bank"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 188)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(373, 167)
        Me.LayoutControlGroup4.Text = "Top 5 Saldo Kas && Bank"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.nChartKas
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(104, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(363, 138)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "Laba Rugi"
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(373, 188)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(366, 167)
        Me.LayoutControlGroup5.Text = "Laba Rugi"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.nChartLR
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(356, 138)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'SimpleLabelItem1
        '
        Me.SimpleLabelItem1.AllowHotTrack = False
        Me.SimpleLabelItem1.CustomizationFormText = "Statistik && Analisa Data"
        Me.SimpleLabelItem1.Location = New System.Drawing.Point(0, 0)
        Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
        Me.SimpleLabelItem1.Size = New System.Drawing.Size(254, 25)
        Me.SimpleLabelItem1.Text = "Statistik && Analisa Data"
        Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(111, 13)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnPrintPreview, Me.btnRefresh})
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPrintPreview, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Refresh"
        Me.btnRefresh.Glyph = CType(resources.GetObject("btnRefresh.Glyph"), System.Drawing.Image)
        Me.btnRefresh.Id = 1
        Me.btnRefresh.LargeGlyph = CType(resources.GetObject("btnRefresh.LargeGlyph"), System.Drawing.Image)
        Me.btnRefresh.Name = "btnRefresh"
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.Caption = "Print Preview"
        Me.btnPrintPreview.Glyph = CType(resources.GetObject("btnPrintPreview.Glyph"), System.Drawing.Image)
        Me.btnPrintPreview.Id = 0
        Me.btnPrintPreview.LargeGlyph = CType(resources.GetObject("btnPrintPreview.LargeGlyph"), System.Drawing.Image)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(759, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 375)
        Me.barDockControlBottom.Size = New System.Drawing.Size(759, 27)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 375)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(759, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 375)
        '
        'UI_Statistik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 402)
        Me.Controls.Add(Me.lytStatistik)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "UI_Statistik"
        Me.Text = "Statistik Dan Analisa Data"
        CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytStatistik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lytStatistik.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nChartKas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SimpleDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Pie3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Pie3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Pie3DSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Pie3DSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nChartLR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nChartNeraca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridCOA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridCoaView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lytStatistik As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents xGridCOA As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridCoaView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents nChartNeraca As DevExpress.XtraCharts.ChartControl
  Friend WithEvents nChartLR As DevExpress.XtraCharts.ChartControl
  Friend WithEvents nChartKas As DevExpress.XtraCharts.ChartControl
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtBulan As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSaldoValas As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
  Friend WithEvents btnPrintPreview As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
  Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents txtTahun As DevExpress.XtraEditors.ComboBoxEdit
End Class
