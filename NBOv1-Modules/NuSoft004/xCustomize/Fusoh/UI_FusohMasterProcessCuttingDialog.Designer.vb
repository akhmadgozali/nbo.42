<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohMasterProcessCuttingDialog
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
		Me.txtDefaultFG = New DevExpress.XtraEditors.ComboBoxEdit()
		Me.txtKeterangan = New DevExpress.XtraEditors.MemoEdit()
        Me.txtKode = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lytMaster.SuspendLayout()
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDefaultFG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lytMaster
        '
        Me.lytMaster.Controls.Add(Me.txtNama)
        Me.lytMaster.Controls.Add(Me.txtDefaultFG)
        Me.lytMaster.Controls.Add(Me.txtKeterangan)
        Me.lytMaster.Controls.Add(Me.txtKode)
        Me.lytMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lytMaster.Location = New System.Drawing.Point(0, 0)
        Me.lytMaster.Name = "lytMaster"
        Me.lytMaster.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(703, 93, 250, 350)
        Me.lytMaster.Root = Me.LayoutControlGroup1
        Me.lytMaster.Size = New System.Drawing.Size(425, 196)
        Me.lytMaster.TabIndex = 110
        Me.lytMaster.Text = "LayoutControl1"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(80, 36)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Properties.MaxLength = 100
        Me.txtNama.Size = New System.Drawing.Size(333, 20)
        Me.txtNama.StyleController = Me.lytMaster
        Me.txtNama.TabIndex = 111
        '
        'txtDefaultFG
        '
        Me.txtDefaultFG.Location = New System.Drawing.Point(349, 12)
        Me.txtDefaultFG.Name = "txtDefaultFG"
        Me.txtDefaultFG.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDefaultFG.Properties.Items.AddRange(New Object() {"Tidak Ada", "OP 1", "OP 2", "OP 3", "OP 4", "OP 5"})
        Me.txtDefaultFG.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtDefaultFG.Size = New System.Drawing.Size(64, 20)
        Me.txtDefaultFG.StyleController = Me.lytMaster
        Me.txtDefaultFG.TabIndex = 111
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(80, 60)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Properties.MaxLength = 255
        Me.txtKeterangan.Size = New System.Drawing.Size(333, 124)
        Me.txtKeterangan.StyleController = Me.lytMaster
        Me.txtKeterangan.TabIndex = 112
        '
        'txtKode
        '
        Me.txtKode.EditValue = ""
        Me.txtKode.Location = New System.Drawing.Point(80, 12)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Properties.MaxLength = 10
        Me.txtKode.Size = New System.Drawing.Size(91, 20)
        Me.txtKode.StyleController = Me.lytMaster
        Me.txtKode.TabIndex = 100
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem41, Me.LayoutControlItem3, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(425, 196)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtKode
        Me.LayoutControlItem1.CustomizationFormText = "Kode"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(163, 24)
        Me.LayoutControlItem1.Text = "Kode"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.Control = Me.txtNama
        Me.LayoutControlItem41.CustomizationFormText = "Nama Part"
        Me.LayoutControlItem41.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(405, 24)
        Me.LayoutControlItem41.Text = "Nama     "
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtKeterangan
        Me.LayoutControlItem3.CustomizationFormText = "Keterangan   "
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(405, 128)
        Me.LayoutControlItem3.Text = "Keterangan   "
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(65, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtDefaultFG
        Me.LayoutControlItem2.CustomizationFormText = "Default OP untuk jadi Finish Good   "
        Me.LayoutControlItem2.Location = New System.Drawing.Point(163, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(242, 24)
        Me.LayoutControlItem2.Text = "Default OP untuk jadi Finish Good   "
        Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(169, 13)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'UI_FusohMasterProcessCuttingDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 245)
        Me.Controls.Add(Me.lytMaster)
        Me.Name = "UI_FusohMasterProcessCuttingDialog"
        Me.Text = "Master Process Cutting"
        Me.Controls.SetChildIndex(Me.lytMaster, 0)
        CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lytMaster.ResumeLayout(False)
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDefaultFG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lytMaster As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtNama As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtDefaultFG As DevExpress.XtraEditors.ComboBoxEdit
	Friend WithEvents txtKeterangan As DevExpress.XtraEditors.MemoEdit
	Friend WithEvents txtKode As DevExpress.XtraEditors.TextEdit
End Class
