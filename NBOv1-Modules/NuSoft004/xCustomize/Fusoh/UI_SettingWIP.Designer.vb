<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_SettingWIP
  Inherits Core.Win.Forms.DialogForm

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
		Me.components = New System.ComponentModel.Container()
		Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
		Me.txtBarangWIP = New DevExpress.XtraEditors.LookUpEdit()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.txtTanggalMulai = New DevExpress.XtraEditors.DateEdit()
		CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelControl1.SuspendLayout()
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.LayoutControl1.SuspendLayout()
		CType(Me.txtBarangWIP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggalMulai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTanggalMulai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btn1
		'
		Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
		Me.btn1.Appearance.Options.UseForeColor = True
		Me.btn1.Location = New System.Drawing.Point(197, 11)
		'
		'btn2
		'
		Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
		Me.btn2.Appearance.Options.UseForeColor = True
		Me.btn2.Location = New System.Drawing.Point(290, 11)
		'
		'PanelControl1
		'
		Me.PanelControl1.Location = New System.Drawing.Point(0, 177)
		Me.PanelControl1.Size = New System.Drawing.Size(396, 49)
		'
		'LayoutControl1
		'
		Me.LayoutControl1.Controls.Add(Me.txtBarangWIP)
		Me.LayoutControl1.Controls.Add(Me.txtTanggalMulai)
		Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControl1.Name = "LayoutControl1"
		Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(591, 31, 386, 454)
		Me.LayoutControl1.Root = Me.LayoutControlGroup1
		Me.LayoutControl1.Size = New System.Drawing.Size(396, 177)
		Me.LayoutControl1.TabIndex = 9
		Me.LayoutControl1.Text = "LayoutControl1"
		'
		'txtBarangWIP
		'
		Me.txtBarangWIP.Location = New System.Drawing.Point(146, 43)
		Me.txtBarangWIP.Name = "txtBarangWIP"
		Me.txtBarangWIP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtBarangWIP.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 90, "Nama")})
		Me.txtBarangWIP.Properties.DisplayMember = "Nama"
		Me.txtBarangWIP.Properties.NullText = "<Pilih Barang WIP>"
		Me.txtBarangWIP.Properties.ValueMember = "Id"
		Me.txtBarangWIP.Size = New System.Drawing.Size(226, 20)
		Me.txtBarangWIP.StyleController = Me.LayoutControl1
		Me.txtBarangWIP.TabIndex = 7
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.CustomizationFormText = "Root"
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "Root"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(396, 177)
		Me.LayoutControlGroup1.Text = "Root"
		Me.LayoutControlGroup1.TextVisible = False
		'
		'LayoutControlGroup2
		'
		Me.LayoutControlGroup2.CustomizationFormText = "Application"
		Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.EmptySpaceItem2, Me.LayoutControlItem3})
		Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
		Me.LayoutControlGroup2.Size = New System.Drawing.Size(376, 157)
		Me.LayoutControlGroup2.Text = "Umum"
		'
		'LayoutControlItem9
		'
		Me.LayoutControlItem9.Control = Me.txtBarangWIP
		Me.LayoutControlItem9.CustomizationFormText = "PPN BM"
		Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem9.Name = "LayoutControlItem9"
		Me.LayoutControlItem9.Size = New System.Drawing.Size(352, 24)
		Me.LayoutControlItem9.Text = "Default Barang WIP   "
		Me.LayoutControlItem9.TextSize = New System.Drawing.Size(119, 13)
		'
		'EmptySpaceItem2
		'
		Me.EmptySpaceItem2.AllowHotTrack = False
		Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 48)
		Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
		Me.EmptySpaceItem2.Size = New System.Drawing.Size(352, 66)
		Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
		Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.txtTanggalMulai
		Me.LayoutControlItem3.CustomizationFormText = "Permintaan Barang"
		Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(352, 24)
		Me.LayoutControlItem3.Text = "Tanggal Mulai Alur WIP   "
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(119, 13)
		'
		'txtTanggalMulai
		'
		Me.txtTanggalMulai.EditValue = Nothing
		Me.txtTanggalMulai.Location = New System.Drawing.Point(146, 67)
		Me.txtTanggalMulai.Name = "txtTanggalMulai"
		Me.txtTanggalMulai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggalMulai.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTanggalMulai.Size = New System.Drawing.Size(226, 20)
		Me.txtTanggalMulai.StyleController = Me.LayoutControl1
		Me.txtTanggalMulai.TabIndex = 1
		'
		'UI_SettingWIP
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(396, 226)
		Me.Controls.Add(Me.LayoutControl1)
		Me.Name = "UI_SettingWIP"
		Me.Text = "Setting WIP"
		Me.Controls.SetChildIndex(Me.PanelControl1, 0)
		Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
		CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelControl1.ResumeLayout(False)
		CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.LayoutControl1.ResumeLayout(False)
		CType(Me.txtBarangWIP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggalMulai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTanggalMulai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtBarangWIP As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtTanggalMulai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
End Class
