<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zWoojinRF_RekapData
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
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.txtTgl2 = New DevExpress.XtraEditors.DateEdit()
    Me.txtTgl1 = New DevExpress.XtraEditors.DateEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.lytTanggal1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.lytTanggal2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytTanggal1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytTanggal2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.txtTgl2)
    Me.LayoutControl1.Controls.Add(Me.txtTgl1)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(674, 101, 250, 350)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(423, 206)
    Me.LayoutControl1.TabIndex = 101
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'txtTgl2
    '
    Me.txtTgl2.EditValue = Nothing
    Me.txtTgl2.Location = New System.Drawing.Point(249, 12)
    Me.txtTgl2.Name = "txtTgl2"
    Me.txtTgl2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl2.Size = New System.Drawing.Size(162, 20)
    Me.txtTgl2.StyleController = Me.LayoutControl1
    Me.txtTgl2.TabIndex = 5
    '
    'txtTgl1
    '
    Me.txtTgl1.EditValue = Nothing
    Me.txtTgl1.Location = New System.Drawing.Point(53, 12)
    Me.txtTgl1.Name = "txtTgl1"
    Me.txtTgl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl1.Size = New System.Drawing.Size(151, 20)
    Me.txtTgl1.StyleController = Me.LayoutControl1
    Me.txtTgl1.TabIndex = 4
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lytTanggal1, Me.lytTanggal2, Me.EmptySpaceItem1})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(423, 206)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'lytTanggal1
    '
    Me.lytTanggal1.Control = Me.txtTgl1
    Me.lytTanggal1.CustomizationFormText = "Tanggal"
    Me.lytTanggal1.Location = New System.Drawing.Point(0, 0)
    Me.lytTanggal1.Name = "lytTanggal1"
    Me.lytTanggal1.Size = New System.Drawing.Size(196, 24)
    Me.lytTanggal1.Text = "Tanggal"
    Me.lytTanggal1.TextSize = New System.Drawing.Size(38, 13)
    '
    'lytTanggal2
    '
    Me.lytTanggal2.Control = Me.txtTgl2
    Me.lytTanggal2.CustomizationFormText = "s/d"
    Me.lytTanggal2.Location = New System.Drawing.Point(196, 0)
    Me.lytTanggal2.Name = "lytTanggal2"
    Me.lytTanggal2.Size = New System.Drawing.Size(207, 24)
    Me.lytTanggal2.Text = "s/d"
    Me.lytTanggal2.TextSize = New System.Drawing.Size(38, 13)
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 24)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(403, 162)
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'zWoojinRF_RekapData
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(423, 255)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Name = "zWoojinRF_RekapData"
    Me.Text = "Filter Laporan"
    Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytTanggal1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytTanggal2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents txtTgl2 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtTgl1 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents lytTanggal1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents lytTanggal2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
