<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_RasioKeuangan
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
    Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
    Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
    Me.lytRatioKeuangan = New DevExpress.XtraLayout.LayoutControl()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
    Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.CheckEdit3 = New DevExpress.XtraEditors.CheckEdit()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.SimpleLabelItem2 = New DevExpress.XtraLayout.SimpleLabelItem()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytRatioKeuangan, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytRatioKeuangan.SuspendLayout()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lytRatioKeuangan
    '
    Me.lytRatioKeuangan.Controls.Add(Me.CheckEdit3)
    Me.lytRatioKeuangan.Controls.Add(Me.CheckEdit2)
    Me.lytRatioKeuangan.Controls.Add(Me.CheckEdit1)
    Me.lytRatioKeuangan.Controls.Add(Me.MemoEdit1)
    Me.lytRatioKeuangan.Controls.Add(Me.ChartControl1)
    Me.lytRatioKeuangan.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytRatioKeuangan.Location = New System.Drawing.Point(0, 0)
    Me.lytRatioKeuangan.Name = "lytRatioKeuangan"
    Me.lytRatioKeuangan.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(515, 197, 250, 350)
    Me.lytRatioKeuangan.Root = Me.LayoutControlGroup1
    Me.lytRatioKeuangan.Size = New System.Drawing.Size(765, 401)
    Me.lytRatioKeuangan.TabIndex = 0
    Me.lytRatioKeuangan.Text = "LayoutControl1"
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.SimpleLabelItem1, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.SimpleLabelItem2})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(765, 401)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 103)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(246, 278)
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'SimpleLabelItem1
    '
    Me.SimpleLabelItem1.AllowHotTrack = False
    Me.SimpleLabelItem1.CustomizationFormText = "Rasio Keuangan "
    Me.SimpleLabelItem1.Location = New System.Drawing.Point(0, 0)
    Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
    Me.SimpleLabelItem1.Size = New System.Drawing.Size(745, 17)
    Me.SimpleLabelItem1.Text = "Rasio Keuangan "
    Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(80, 13)
    '
    'ChartControl1
    '
    XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
    Me.ChartControl1.Diagram = XyDiagram1
    Me.ChartControl1.Location = New System.Drawing.Point(258, 172)
    Me.ChartControl1.Name = "ChartControl1"
    Series1.Name = "Series 1"
    Series2.Name = "Series 2"
    Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
    Me.ChartControl1.Size = New System.Drawing.Size(495, 217)
    Me.ChartControl1.TabIndex = 4
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.ChartControl1
    Me.LayoutControlItem1.CustomizationFormText = "Chart Control"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(246, 160)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(499, 221)
    Me.LayoutControlItem1.Text = "Chart Control"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem1.TextToControlDistance = 0
    Me.LayoutControlItem1.TextVisible = False
    '
    'MemoEdit1
    '
    Me.MemoEdit1.Location = New System.Drawing.Point(258, 29)
    Me.MemoEdit1.Name = "MemoEdit1"
    Me.MemoEdit1.Size = New System.Drawing.Size(495, 139)
    Me.MemoEdit1.StyleController = Me.lytRatioKeuangan
    Me.MemoEdit1.TabIndex = 5
    Me.MemoEdit1.UseOptimizedRendering = True
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.MemoEdit1
    Me.LayoutControlItem2.CustomizationFormText = "Memo Edit"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(246, 17)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(499, 143)
    Me.LayoutControlItem2.Text = "Memo Edit"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem2.TextToControlDistance = 0
    Me.LayoutControlItem2.TextVisible = False
    '
    'CheckEdit1
    '
    Me.CheckEdit1.Location = New System.Drawing.Point(12, 46)
    Me.CheckEdit1.Name = "CheckEdit1"
    Me.CheckEdit1.Properties.Caption = "Current Ratio"
    Me.CheckEdit1.Size = New System.Drawing.Size(242, 19)
    Me.CheckEdit1.StyleController = Me.lytRatioKeuangan
    Me.CheckEdit1.TabIndex = 6
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.CheckEdit1
    Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 34)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(246, 23)
    Me.LayoutControlItem3.Text = "LayoutControlItem3"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem3.TextToControlDistance = 0
    Me.LayoutControlItem3.TextVisible = False
    '
    'CheckEdit2
    '
    Me.CheckEdit2.Location = New System.Drawing.Point(12, 69)
    Me.CheckEdit2.Name = "CheckEdit2"
    Me.CheckEdit2.Properties.Caption = "Cash Ratio"
    Me.CheckEdit2.Size = New System.Drawing.Size(242, 19)
    Me.CheckEdit2.StyleController = Me.lytRatioKeuangan
    Me.CheckEdit2.TabIndex = 7
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.CheckEdit2
    Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 57)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(246, 23)
    Me.LayoutControlItem4.Text = "LayoutControlItem4"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem4.TextToControlDistance = 0
    Me.LayoutControlItem4.TextVisible = False
    '
    'CheckEdit3
    '
    Me.CheckEdit3.Location = New System.Drawing.Point(12, 92)
    Me.CheckEdit3.Name = "CheckEdit3"
    Me.CheckEdit3.Properties.Caption = "Quick (Acid Test) Ratio"
    Me.CheckEdit3.Size = New System.Drawing.Size(242, 19)
    Me.CheckEdit3.StyleController = Me.lytRatioKeuangan
    Me.CheckEdit3.TabIndex = 8
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.CheckEdit3
    Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 80)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(246, 23)
    Me.LayoutControlItem5.Text = "LayoutControlItem5"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem5.TextToControlDistance = 0
    Me.LayoutControlItem5.TextVisible = False
    '
    'SimpleLabelItem2
    '
    Me.SimpleLabelItem2.AllowHotTrack = False
    Me.SimpleLabelItem2.CustomizationFormText = "Rasio Likuiditas"
    Me.SimpleLabelItem2.Location = New System.Drawing.Point(0, 17)
    Me.SimpleLabelItem2.Name = "SimpleLabelItem2"
    Me.SimpleLabelItem2.Size = New System.Drawing.Size(246, 17)
    Me.SimpleLabelItem2.Text = "Rasio Likuiditas"
    Me.SimpleLabelItem2.TextSize = New System.Drawing.Size(80, 13)
    '
    'UI_RasioKeuangan
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(765, 401)
    Me.Controls.Add(Me.lytRatioKeuangan)
    Me.Name = "UI_RasioKeuangan"
    Me.Text = "UI_RasioKeuangan"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytRatioKeuangan, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytRatioKeuangan.ResumeLayout(False)
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lytRatioKeuangan As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
  Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents CheckEdit3 As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents SimpleLabelItem2 As DevExpress.XtraLayout.SimpleLabelItem
End Class
