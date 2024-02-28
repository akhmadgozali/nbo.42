<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RF_NeracaLevel
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
    Me.txtPeriodeTahun = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.txtLevel = New DevExpress.XtraEditors.LookUpEdit()
    Me.chkSaldoNol = New DevExpress.XtraEditors.CheckEdit()
    Me.txtPeriodeBulan = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.lytPeriode1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.txtPeriodeTahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkSaldoNol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPeriodeBulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytPeriode1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.txtPeriodeTahun)
    Me.LayoutControl1.Controls.Add(Me.txtLevel)
    Me.LayoutControl1.Controls.Add(Me.chkSaldoNol)
    Me.LayoutControl1.Controls.Add(Me.txtPeriodeBulan)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(566, 136, 250, 350)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(338, 116)
    Me.LayoutControl1.TabIndex = 107
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'txtPeriodeTahun
    '
    Me.txtPeriodeTahun.Location = New System.Drawing.Point(242, 12)
    Me.txtPeriodeTahun.Name = "txtPeriodeTahun"
    Me.txtPeriodeTahun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeTahun.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    Me.txtPeriodeTahun.Size = New System.Drawing.Size(84, 20)
    Me.txtPeriodeTahun.StyleController = Me.LayoutControl1
    Me.txtPeriodeTahun.TabIndex = 108
    '
    'txtLevel
    '
    Me.txtLevel.Location = New System.Drawing.Point(90, 36)
    Me.txtLevel.Name = "txtLevel"
    Me.txtLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtLevel.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Level")})
    Me.txtLevel.Properties.DisplayMember = "Value"
    Me.txtLevel.Properties.NullText = ""
    Me.txtLevel.Properties.ValueMember = "Key"
    Me.txtLevel.Size = New System.Drawing.Size(236, 20)
    Me.txtLevel.StyleController = Me.LayoutControl1
    Me.txtLevel.TabIndex = 107
    '
    'chkSaldoNol
    '
    Me.chkSaldoNol.Location = New System.Drawing.Point(12, 60)
    Me.chkSaldoNol.Name = "chkSaldoNol"
    Me.chkSaldoNol.Properties.Caption = "Tampilkan Saldo Nol"
    Me.chkSaldoNol.Size = New System.Drawing.Size(314, 19)
    Me.chkSaldoNol.StyleController = Me.LayoutControl1
    Me.chkSaldoNol.TabIndex = 106
    '
    'txtPeriodeBulan
    '
    Me.txtPeriodeBulan.Location = New System.Drawing.Point(90, 12)
    Me.txtPeriodeBulan.Name = "txtPeriodeBulan"
    Me.txtPeriodeBulan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtPeriodeBulan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    Me.txtPeriodeBulan.Size = New System.Drawing.Size(148, 20)
    Me.txtPeriodeBulan.StyleController = Me.LayoutControl1
    Me.txtPeriodeBulan.TabIndex = 0
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lytPeriode1, Me.LayoutControlItem5, Me.LayoutControlItem1, Me.LayoutControlItem2})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(338, 106)
    Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'lytPeriode1
    '
    Me.lytPeriode1.Control = Me.txtPeriodeBulan
    Me.lytPeriode1.CustomizationFormText = "Periode"
    Me.lytPeriode1.Location = New System.Drawing.Point(0, 0)
    Me.lytPeriode1.Name = "lytPeriode1"
    Me.lytPeriode1.Size = New System.Drawing.Size(230, 24)
    Me.lytPeriode1.Text = "Periode"
    Me.lytPeriode1.TextSize = New System.Drawing.Size(75, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.chkSaldoNol
    Me.LayoutControlItem5.CustomizationFormText = "TampilkanSaldoNol"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(318, 48)
    Me.LayoutControlItem5.Text = "LayoutControlItem5"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem5.TextToControlDistance = 0
    Me.LayoutControlItem5.TextVisible = False
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtLevel
    Me.LayoutControlItem1.CustomizationFormText = "Tampilkan Level"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(318, 24)
    Me.LayoutControlItem1.Text = "Tampilkan Level"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(75, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtPeriodeTahun
    Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(230, 0)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(88, 24)
    Me.LayoutControlItem2.Text = "LayoutControlItem2"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem2.TextToControlDistance = 0
    Me.LayoutControlItem2.TextVisible = False
    '
    'RF_NeracaLevel
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(338, 165)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Name = "RF_NeracaLevel"
    Me.Text = "Filter Neraca"
    Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.txtPeriodeTahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkSaldoNol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPeriodeBulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytPeriode1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents chkSaldoNol As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents txtPeriodeBulan As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents lytPeriode1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtLevel As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtPeriodeTahun As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
