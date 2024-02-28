<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_TutupBukuDialog
  Inherits Core.Win.Forms.InputDialog

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
		Me.lytCo = New DevExpress.XtraLayout.LayoutControl()
		Me.txtPeriode = New DevExpress.XtraEditors.TextEdit()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.txtTutupPeriode = New DevExpress.XtraEditors.CheckEdit()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lytCo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.lytCo.SuspendLayout()
		CType(Me.txtPeriode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTutupPeriode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lytCo
		'
		Me.lytCo.Controls.Add(Me.txtPeriode)
		Me.lytCo.Controls.Add(Me.txtTutupPeriode)
		Me.lytCo.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lytCo.Location = New System.Drawing.Point(0, 0)
		Me.lytCo.Name = "lytCo"
		Me.lytCo.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(55, 151, 250, 350)
		Me.lytCo.Root = Me.LayoutControlGroup1
		Me.lytCo.Size = New System.Drawing.Size(298, 69)
		Me.lytCo.TabIndex = 2
		Me.lytCo.Text = "LayoutControl1"
		'
		'txtPeriode
		'
		Me.txtPeriode.Enabled = False
		Me.txtPeriode.Location = New System.Drawing.Point(75, 12)
		Me.txtPeriode.Name = "txtPeriode"
		Me.txtPeriode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtPeriode.Properties.ReadOnly = True
		Me.txtPeriode.Size = New System.Drawing.Size(211, 20)
		Me.txtPeriode.StyleController = Me.lytCo
		Me.txtPeriode.TabIndex = 1
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.CustomizationFormText = "Root"
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.EmptySpaceItem2})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "Root"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(298, 69)
		Me.LayoutControlGroup1.Text = "Root"
		Me.LayoutControlGroup1.TextVisible = False
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.txtPeriode
		Me.LayoutControlItem1.CustomizationFormText = "Periode        "
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(278, 24)
		Me.LayoutControlItem1.Text = "Periode        "
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(60, 13)
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.txtTutupPeriode
		Me.LayoutControlItem3.CustomizationFormText = "Nilai"
		Me.LayoutControlItem3.Location = New System.Drawing.Point(61, 24)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(217, 25)
		Me.LayoutControlItem3.Text = "Nilai"
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem3.TextToControlDistance = 0
		Me.LayoutControlItem3.TextVisible = False
		'
		'EmptySpaceItem2
		'
		Me.EmptySpaceItem2.AllowHotTrack = False
		Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 24)
		Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Size = New System.Drawing.Size(61, 25)
		Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
		Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
		'
		'txtTutupPeriode
		'
		Me.txtTutupPeriode.EditValue = Nothing
		Me.txtTutupPeriode.Location = New System.Drawing.Point(73, 36)
		Me.txtTutupPeriode.Name = "txtTutupPeriode"
		Me.txtTutupPeriode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtTutupPeriode.Properties.Caption = "Tutup Periode"
		Me.txtTutupPeriode.Size = New System.Drawing.Size(213, 21)
		Me.txtTutupPeriode.StyleController = Me.lytCo
		Me.txtTutupPeriode.TabIndex = 4
		'
		'UI_TutupBukuDialog
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(298, 118)
		Me.Controls.Add(Me.lytCo)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Name = "UI_TutupBukuDialog"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Tutup Buku"
		Me.Controls.SetChildIndex(Me.lytCo, 0)
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lytCo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.lytCo.ResumeLayout(False)
		CType(Me.txtPeriode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTutupPeriode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents lytCo As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtPeriode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtTutupPeriode As DevExpress.XtraEditors.CheckEdit
End Class
