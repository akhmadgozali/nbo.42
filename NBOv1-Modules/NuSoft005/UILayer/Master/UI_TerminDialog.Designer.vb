<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_TerminDialog
    Inherits Core.Win.Forms.InputDialog

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
  Me.txtKode = New DevExpress.XtraEditors.TextEdit()
  Me.txtTempo = New DevExpress.XtraEditors.TextEdit()
  Me.txtDisc = New DevExpress.XtraEditors.TextEdit()
  Me.txtDenda = New DevExpress.XtraEditors.TextEdit()
  Me.txtDiscP = New DevExpress.XtraEditors.TextEdit()
  Me.txtDendaP = New DevExpress.XtraEditors.TextEdit()
  Me.lytMasterTermin = New DevExpress.XtraLayout.LayoutControl()
  Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
  Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
  Me.SimpleLabelItem2 = New DevExpress.XtraLayout.SimpleLabelItem()
  Me.SimpleLabelItem3 = New DevExpress.XtraLayout.SimpleLabelItem()
  Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
  CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtTempo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtDisc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtDenda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtDiscP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtDendaP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.lytMasterTermin, System.ComponentModel.ISupportInitialize).BeginInit()
  Me.lytMasterTermin.SuspendLayout()
  CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.SimpleLabelItem3, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
  Me.SuspendLayout()
  '
  'txtKode
  '
  Me.txtKode.Location = New System.Drawing.Point(143, 12)
  Me.txtKode.Name = "txtKode"
  Me.txtKode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtKode.Size = New System.Drawing.Size(115, 20)
  Me.txtKode.StyleController = Me.lytMasterTermin
  Me.txtKode.TabIndex = 103
  '
  'txtTempo
  '
  Me.txtTempo.Location = New System.Drawing.Point(143, 36)
  Me.txtTempo.Name = "txtTempo"
  Me.txtTempo.Properties.Appearance.Options.UseTextOptions = True
  Me.txtTempo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
  Me.txtTempo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtTempo.Size = New System.Drawing.Size(50, 20)
  Me.txtTempo.StyleController = Me.lytMasterTermin
  Me.txtTempo.TabIndex = 103
  '
  'txtDisc
  '
  Me.txtDisc.Location = New System.Drawing.Point(350, 60)
  Me.txtDisc.Name = "txtDisc"
  Me.txtDisc.Properties.Appearance.Options.UseTextOptions = True
  Me.txtDisc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
  Me.txtDisc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtDisc.Size = New System.Drawing.Size(50, 20)
  Me.txtDisc.StyleController = Me.lytMasterTermin
  Me.txtDisc.TabIndex = 103
  '
  'txtDenda
  '
  Me.txtDenda.Location = New System.Drawing.Point(350, 84)
  Me.txtDenda.Name = "txtDenda"
  Me.txtDenda.Properties.Appearance.Options.UseTextOptions = True
  Me.txtDenda.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
  Me.txtDenda.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtDenda.Size = New System.Drawing.Size(50, 20)
  Me.txtDenda.StyleController = Me.lytMasterTermin
  Me.txtDenda.TabIndex = 105
  '
  'txtDiscP
  '
  Me.txtDiscP.Location = New System.Drawing.Point(143, 60)
  Me.txtDiscP.Name = "txtDiscP"
  Me.txtDiscP.Properties.Appearance.Options.UseTextOptions = True
  Me.txtDiscP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
  Me.txtDiscP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtDiscP.Size = New System.Drawing.Size(50, 20)
  Me.txtDiscP.StyleController = Me.lytMasterTermin
  Me.txtDiscP.TabIndex = 103
  '
  'txtDendaP
  '
  Me.txtDendaP.Location = New System.Drawing.Point(143, 84)
  Me.txtDendaP.Name = "txtDendaP"
  Me.txtDendaP.Properties.Appearance.Options.UseTextOptions = True
  Me.txtDendaP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
  Me.txtDendaP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtDendaP.Size = New System.Drawing.Size(50, 20)
  Me.txtDendaP.StyleController = Me.lytMasterTermin
  Me.txtDendaP.TabIndex = 105
  '
  'lytMasterTermin
  '
  Me.lytMasterTermin.Controls.Add(Me.txtDenda)
  Me.lytMasterTermin.Controls.Add(Me.txtDendaP)
  Me.lytMasterTermin.Controls.Add(Me.txtKode)
  Me.lytMasterTermin.Controls.Add(Me.txtTempo)
  Me.lytMasterTermin.Controls.Add(Me.txtDiscP)
  Me.lytMasterTermin.Controls.Add(Me.txtDisc)
  Me.lytMasterTermin.Dock = System.Windows.Forms.DockStyle.Fill
  Me.lytMasterTermin.Location = New System.Drawing.Point(0, 0)
  Me.lytMasterTermin.Name = "lytMasterTermin"
  Me.lytMasterTermin.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(684, 234, 250, 350)
  Me.lytMasterTermin.Root = Me.LayoutControlGroup1
  Me.lytMasterTermin.Size = New System.Drawing.Size(443, 117)
  Me.lytMasterTermin.TabIndex = 108
  Me.lytMasterTermin.Text = "LayoutControl1"
  '
  'LayoutControlGroup1
  '
  Me.LayoutControlGroup1.CustomizationFormText = "Root"
  Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
  Me.LayoutControlGroup1.GroupBordersVisible = False
  Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem4, Me.SimpleLabelItem3, Me.EmptySpaceItem1, Me.SimpleLabelItem2, Me.SimpleLabelItem1})
  Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControlGroup1.Name = "Root"
  Me.LayoutControlGroup1.Size = New System.Drawing.Size(443, 117)
  Me.LayoutControlGroup1.Text = "Root"
  Me.LayoutControlGroup1.TextVisible = False
  '
  'LayoutControlItem1
  '
  Me.LayoutControlItem1.Control = Me.txtKode
  Me.LayoutControlItem1.CustomizationFormText = "Kode"
  Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControlItem1.Name = "LayoutControlItem1"
  Me.LayoutControlItem1.Size = New System.Drawing.Size(250, 24)
  Me.LayoutControlItem1.Text = "Kode"
  Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
  Me.LayoutControlItem1.TextSize = New System.Drawing.Size(126, 20)
  Me.LayoutControlItem1.TextToControlDistance = 5
  '
  'LayoutControlItem2
  '
  Me.LayoutControlItem2.Control = Me.txtTempo
  Me.LayoutControlItem2.CustomizationFormText = "Jatuh Tempo"
  Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
  Me.LayoutControlItem2.Name = "LayoutControlItem2"
  Me.LayoutControlItem2.Size = New System.Drawing.Size(185, 24)
  Me.LayoutControlItem2.Text = "Jatuh Tempo"
  Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
  Me.LayoutControlItem2.TextSize = New System.Drawing.Size(126, 20)
  Me.LayoutControlItem2.TextToControlDistance = 5
  '
  'LayoutControlItem3
  '
  Me.LayoutControlItem3.Control = Me.txtDiscP
  Me.LayoutControlItem3.CustomizationFormText = "Akan Mendapatkan Diskon"
  Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
  Me.LayoutControlItem3.Name = "LayoutControlItem3"
  Me.LayoutControlItem3.Size = New System.Drawing.Size(185, 24)
  Me.LayoutControlItem3.Text = "Akan Mendapatkan Diskon"
  Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
  Me.LayoutControlItem3.TextSize = New System.Drawing.Size(126, 20)
  Me.LayoutControlItem3.TextToControlDistance = 5
  '
  'LayoutControlItem4
  '
  Me.LayoutControlItem4.Control = Me.txtDendaP
  Me.LayoutControlItem4.CustomizationFormText = "Akan Mendapatkan Denda"
  Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
  Me.LayoutControlItem4.Name = "LayoutControlItem4"
  Me.LayoutControlItem4.Size = New System.Drawing.Size(185, 25)
  Me.LayoutControlItem4.Text = "Akan Mendapatkan Denda"
  Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
  Me.LayoutControlItem4.TextSize = New System.Drawing.Size(126, 20)
  Me.LayoutControlItem4.TextToControlDistance = 5
  '
  'LayoutControlItem5
  '
  Me.LayoutControlItem5.Control = Me.txtDisc
  Me.LayoutControlItem5.CustomizationFormText = "%   Jika Membayar Kurang dari"
  Me.LayoutControlItem5.Location = New System.Drawing.Point(185, 48)
  Me.LayoutControlItem5.Name = "LayoutControlItem5"
  Me.LayoutControlItem5.Size = New System.Drawing.Size(207, 24)
  Me.LayoutControlItem5.Text = "%   Jika Membayar Kurang dari"
  Me.LayoutControlItem5.TextSize = New System.Drawing.Size(149, 13)
  '
  'LayoutControlItem6
  '
  Me.LayoutControlItem6.Control = Me.txtDenda
  Me.LayoutControlItem6.CustomizationFormText = "%   Jika Membayar Lebih dari"
  Me.LayoutControlItem6.Location = New System.Drawing.Point(185, 72)
  Me.LayoutControlItem6.Name = "LayoutControlItem6"
  Me.LayoutControlItem6.Size = New System.Drawing.Size(207, 25)
  Me.LayoutControlItem6.Text = "%   Jika Membayar Lebih dari"
  Me.LayoutControlItem6.TextSize = New System.Drawing.Size(149, 13)
  '
  'SimpleLabelItem1
  '
  Me.SimpleLabelItem1.AllowHotTrack = False
  Me.SimpleLabelItem1.CustomizationFormText = "Hari"
  Me.SimpleLabelItem1.Location = New System.Drawing.Point(392, 48)
  Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
  Me.SimpleLabelItem1.Size = New System.Drawing.Size(31, 24)
  Me.SimpleLabelItem1.Text = "Hari"
  Me.SimpleLabelItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
  Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(19, 13)
  '
  'SimpleLabelItem2
  '
  Me.SimpleLabelItem2.AllowHotTrack = False
  Me.SimpleLabelItem2.CustomizationFormText = "Hari"
  Me.SimpleLabelItem2.Location = New System.Drawing.Point(392, 72)
  Me.SimpleLabelItem2.Name = "SimpleLabelItem2"
  Me.SimpleLabelItem2.Size = New System.Drawing.Size(31, 25)
  Me.SimpleLabelItem2.Text = "Hari"
  Me.SimpleLabelItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
  Me.SimpleLabelItem2.TextSize = New System.Drawing.Size(19, 13)
  '
  'SimpleLabelItem3
  '
  Me.SimpleLabelItem3.AllowHotTrack = False
  Me.SimpleLabelItem3.CustomizationFormText = "Hari"
  Me.SimpleLabelItem3.Location = New System.Drawing.Point(185, 24)
  Me.SimpleLabelItem3.Name = "SimpleLabelItem3"
  Me.SimpleLabelItem3.Size = New System.Drawing.Size(238, 24)
  Me.SimpleLabelItem3.Text = "Hari"
  Me.SimpleLabelItem3.TextSize = New System.Drawing.Size(149, 13)
  '
  'EmptySpaceItem1
  '
  Me.EmptySpaceItem1.AllowHotTrack = False
  Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
  Me.EmptySpaceItem1.Location = New System.Drawing.Point(250, 0)
  Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
  Me.EmptySpaceItem1.Size = New System.Drawing.Size(173, 24)
  Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
  Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
  '
  'UI_TerminDialog
  '
  Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
  Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
  Me.ClientSize = New System.Drawing.Size(443, 166)
  Me.Controls.Add(Me.lytMasterTermin)
  Me.Name = "UI_TerminDialog"
  Me.Text = "Termin :"
  Me.Controls.SetChildIndex(Me.lytMasterTermin, 0)
  CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtTempo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtDisc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtDenda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtDiscP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtDendaP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.lytMasterTermin, System.ComponentModel.ISupportInitialize).EndInit()
  Me.lytMasterTermin.ResumeLayout(False)
  CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.SimpleLabelItem3, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
  Me.ResumeLayout(False)

 End Sub
 Friend WithEvents txtKode As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtTempo As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtDisc As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtDenda As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtDiscP As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtDendaP As DevExpress.XtraEditors.TextEdit
 Friend WithEvents lytMasterTermin As DevExpress.XtraLayout.LayoutControl
 Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
 Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents SimpleLabelItem3 As DevExpress.XtraLayout.SimpleLabelItem
 Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
 Friend WithEvents SimpleLabelItem2 As DevExpress.XtraLayout.SimpleLabelItem
 Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
End Class
