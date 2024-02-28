<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_TipeTransaksiDialog
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
  Me.components = New System.ComponentModel.Container()
  Me.xpAkun = New DevExpress.Xpo.XPCollection(Me.components)
  Me.txtKode = New DevExpress.XtraEditors.TextEdit()
  Me.txtAkunPendapatan = New DevExpress.XtraEditors.LookUpEdit()
  Me.txtAkunHPP = New DevExpress.XtraEditors.LookUpEdit()
  Me.lytMaster = New DevExpress.XtraLayout.LayoutControl()
  Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
  Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
  CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.xpAkun, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtAkunPendapatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtAkunHPP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.lytMaster, System.ComponentModel.ISupportInitialize).BeginInit()
  Me.lytMaster.SuspendLayout()
  CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
  Me.SuspendLayout()
  '
  'xpAkun
  '
  Me.xpAkun.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Coa)
  '
  'txtKode
  '
  Me.txtKode.Location = New System.Drawing.Point(101, 12)
  Me.txtKode.Name = "txtKode"
  Me.txtKode.Size = New System.Drawing.Size(219, 20)
  Me.txtKode.StyleController = Me.lytMaster
  Me.txtKode.TabIndex = 100
  '
  'txtAkunPendapatan
  '
  Me.txtAkunPendapatan.Location = New System.Drawing.Point(101, 36)
  Me.txtAkunPendapatan.Name = "txtAkunPendapatan"
  Me.txtAkunPendapatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtAkunPendapatan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 60, "Nama")})
  Me.txtAkunPendapatan.Properties.DataSource = Me.xpAkun
  Me.txtAkunPendapatan.Properties.DisplayMember = "Kode"
  Me.txtAkunPendapatan.Properties.NullText = "<Pilih Akun Pendapatan>"
  Me.txtAkunPendapatan.Properties.ValueMember = "This"
  Me.txtAkunPendapatan.Size = New System.Drawing.Size(219, 20)
  Me.txtAkunPendapatan.StyleController = Me.lytMaster
  Me.txtAkunPendapatan.TabIndex = 102
  '
  'txtAkunHPP
  '
  Me.txtAkunHPP.Location = New System.Drawing.Point(101, 60)
  Me.txtAkunHPP.Name = "txtAkunHPP"
  Me.txtAkunHPP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.txtAkunHPP.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 60, "Nama")})
  Me.txtAkunHPP.Properties.DataSource = Me.xpAkun
  Me.txtAkunHPP.Properties.DisplayMember = "Kode"
  Me.txtAkunHPP.Properties.NullText = "<Pilih Akun HPP>"
  Me.txtAkunHPP.Properties.ValueMember = "This"
  Me.txtAkunHPP.Size = New System.Drawing.Size(219, 20)
  Me.txtAkunHPP.StyleController = Me.lytMaster
  Me.txtAkunHPP.TabIndex = 104
  '
  'lytMaster
  '
  Me.lytMaster.Controls.Add(Me.txtAkunHPP)
  Me.lytMaster.Controls.Add(Me.txtAkunPendapatan)
  Me.lytMaster.Controls.Add(Me.txtKode)
  Me.lytMaster.Dock = System.Windows.Forms.DockStyle.Fill
  Me.lytMaster.Location = New System.Drawing.Point(0, 0)
  Me.lytMaster.Name = "lytMaster"
  Me.lytMaster.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(55, 151, 250, 350)
  Me.lytMaster.Root = Me.LayoutControlGroup1
  Me.lytMaster.Size = New System.Drawing.Size(332, 93)
  Me.lytMaster.TabIndex = 106
  Me.lytMaster.Text = "LayoutControl1"
  '
  'LayoutControlGroup1
  '
  Me.LayoutControlGroup1.CustomizationFormText = "Root"
  Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
  Me.LayoutControlGroup1.GroupBordersVisible = False
  Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
  Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControlGroup1.Name = "Root"
  Me.LayoutControlGroup1.Size = New System.Drawing.Size(332, 93)
  Me.LayoutControlGroup1.Text = "Root"
  Me.LayoutControlGroup1.TextVisible = False
  '
  'LayoutControlItem1
  '
  Me.LayoutControlItem1.Control = Me.txtKode
  Me.LayoutControlItem1.CustomizationFormText = "Kode"
  Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControlItem1.Name = "LayoutControlItem1"
  Me.LayoutControlItem1.Size = New System.Drawing.Size(312, 24)
  Me.LayoutControlItem1.Text = "Kode"
  Me.LayoutControlItem1.TextSize = New System.Drawing.Size(85, 13)
  '
  'LayoutControlItem2
  '
  Me.LayoutControlItem2.Control = Me.txtAkunPendapatan
  Me.LayoutControlItem2.CustomizationFormText = "Akun Pendapatan"
  Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
  Me.LayoutControlItem2.Name = "LayoutControlItem2"
  Me.LayoutControlItem2.Size = New System.Drawing.Size(312, 24)
  Me.LayoutControlItem2.Text = "Akun Pendapatan"
  Me.LayoutControlItem2.TextSize = New System.Drawing.Size(85, 13)
  '
  'LayoutControlItem3
  '
  Me.LayoutControlItem3.Control = Me.txtAkunHPP
  Me.LayoutControlItem3.CustomizationFormText = "Akun Hpp"
  Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
  Me.LayoutControlItem3.Name = "LayoutControlItem3"
  Me.LayoutControlItem3.Size = New System.Drawing.Size(312, 25)
  Me.LayoutControlItem3.Text = "Akun Hpp"
  Me.LayoutControlItem3.TextSize = New System.Drawing.Size(85, 13)
  '
  'UI_TipeTransaksiDialog
  '
  Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
  Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
  Me.ClientSize = New System.Drawing.Size(332, 142)
  Me.Controls.Add(Me.lytMaster)
  Me.Name = "UI_TipeTransaksiDialog"
  Me.Text = "TipeTransaksi"
  Me.Controls.SetChildIndex(Me.lytMaster, 0)
  CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.xpAkun, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtAkunPendapatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtAkunHPP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.lytMaster, System.ComponentModel.ISupportInitialize).EndInit()
  Me.lytMaster.ResumeLayout(False)
  CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
  Me.ResumeLayout(False)

 End Sub
 Friend WithEvents xpAkun As DevExpress.Xpo.XPCollection
 Friend WithEvents txtKode As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtAkunPendapatan As DevExpress.XtraEditors.LookUpEdit
 Friend WithEvents txtAkunHPP As DevExpress.XtraEditors.LookUpEdit
 Friend WithEvents lytMaster As DevExpress.XtraLayout.LayoutControl
 Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
 Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
End Class
