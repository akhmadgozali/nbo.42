<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_MessageForm
	Inherits Core.Win.Forms.NuSoftForm

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
		Me.txt = New DevExpress.XtraEditors.MemoEdit()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.LayoutControl1.SuspendLayout()
		CType(Me.txt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LayoutControl1
		'
		Me.LayoutControl1.Controls.Add(Me.txt)
		Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControl1.Name = "LayoutControl1"
		Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(874, 150, 250, 350)
		Me.LayoutControl1.Root = Me.LayoutControlGroup1
		Me.LayoutControl1.Size = New System.Drawing.Size(455, 454)
		Me.LayoutControl1.TabIndex = 9
		Me.LayoutControl1.Text = "LayoutControl1"
		'
		'txt
		'
		Me.txt.Location = New System.Drawing.Point(12, 12)
		Me.txt.Name = "txt"
		Me.txt.Properties.ReadOnly = True
		Me.txt.Size = New System.Drawing.Size(431, 430)
		Me.txt.StyleController = Me.LayoutControl1
		Me.txt.TabIndex = 1
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.CustomizationFormText = "Root"
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "Root"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(455, 454)
		Me.LayoutControlGroup1.Text = "Root"
		Me.LayoutControlGroup1.TextVisible = False
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.txt
		Me.LayoutControlItem3.CustomizationFormText = "Permintaan Barang"
		Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(435, 434)
		Me.LayoutControlItem3.Text = "Permintaan Barang"
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem3.TextToControlDistance = 0
		Me.LayoutControlItem3.TextVisible = False
		'
		'UI_MessageForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(455, 454)
		Me.Controls.Add(Me.LayoutControl1)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "UI_MessageForm"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Box"
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.LayoutControl1.ResumeLayout(False)
		CType(Me.txt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
	Public WithEvents txt As DevExpress.XtraEditors.MemoEdit
End Class
