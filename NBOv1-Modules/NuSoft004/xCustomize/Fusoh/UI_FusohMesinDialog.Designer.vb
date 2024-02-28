<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohMesinDialog
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
		Me.lytMaster = New DevExpress.XtraLayout.LayoutControl()
		Me.txtNama = New DevExpress.XtraEditors.TextEdit()
		Me.txtKode = New DevExpress.XtraEditors.TextEdit()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lytMaster, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.lytMaster.SuspendLayout()
		CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lytMaster
		'
		Me.lytMaster.Controls.Add(Me.txtNama)
		Me.lytMaster.Controls.Add(Me.txtKode)
		Me.lytMaster.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lytMaster.Location = New System.Drawing.Point(0, 0)
		Me.lytMaster.Name = "lytMaster"
		Me.lytMaster.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(703, 93, 250, 350)
		Me.lytMaster.Root = Me.LayoutControlGroup1
		Me.lytMaster.Size = New System.Drawing.Size(392, 71)
		Me.lytMaster.TabIndex = 110
		Me.lytMaster.Text = "LayoutControl1"
		'
		'txtNama
		'
		Me.txtNama.Location = New System.Drawing.Point(57, 36)
		Me.txtNama.Name = "txtNama"
		Me.txtNama.Size = New System.Drawing.Size(323, 20)
		Me.txtNama.StyleController = Me.lytMaster
		Me.txtNama.TabIndex = 111
		'
		'txtKode
		'
		Me.txtKode.Location = New System.Drawing.Point(57, 12)
		Me.txtKode.Name = "txtKode"
		Me.txtKode.Size = New System.Drawing.Size(323, 20)
		Me.txtKode.StyleController = Me.lytMaster
		Me.txtKode.TabIndex = 100
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.CustomizationFormText = "Root"
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem41})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "Root"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(392, 71)
		Me.LayoutControlGroup1.Text = "Root"
		Me.LayoutControlGroup1.TextVisible = False
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.txtKode
		Me.LayoutControlItem1.CustomizationFormText = "Kode"
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(372, 24)
		Me.LayoutControlItem1.Text = "Kode     "
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(42, 13)
		'
		'LayoutControlItem41
		'
		Me.LayoutControlItem41.Control = Me.txtNama
		Me.LayoutControlItem41.CustomizationFormText = "Nama Part"
		Me.LayoutControlItem41.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem41.Name = "LayoutControlItem41"
		Me.LayoutControlItem41.Size = New System.Drawing.Size(372, 27)
		Me.LayoutControlItem41.Text = "Nama     "
		Me.LayoutControlItem41.TextSize = New System.Drawing.Size(42, 13)
		'
		'UI_FusohMesinDialog
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(392, 120)
		Me.Controls.Add(Me.lytMaster)
		Me.Name = "UI_FusohMesinDialog"
		Me.Text = "Master Mesin"
		Me.Controls.SetChildIndex(Me.lytMaster, 0)
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lytMaster, System.ComponentModel.ISupportInitialize).EndInit()
		Me.lytMaster.ResumeLayout(False)
		CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents txtKode As DevExpress.XtraEditors.TextEdit
	Friend WithEvents lytMaster As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtNama As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
End Class
