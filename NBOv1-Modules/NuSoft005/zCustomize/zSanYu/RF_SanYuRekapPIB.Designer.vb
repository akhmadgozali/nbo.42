<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RF_SanYuRekapPIB
  Inherits Core.Win.Forms.FilterForm

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
    Me.txtTgl2 = New DevExpress.XtraEditors.DateEdit()
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.txtFasilitasKite = New DevExpress.XtraEditors.CheckEdit()
    Me.txtNoPendaftaran = New DevExpress.XtraEditors.TextEdit()
    Me.txtKPBC = New DevExpress.XtraEditors.TextEdit()
    Me.txtNoPengajuan = New DevExpress.XtraEditors.TextEdit()
    Me.txtTgl1 = New DevExpress.XtraEditors.DateEdit()
    Me.txtTglPendaftaran2 = New DevExpress.XtraEditors.DateEdit()
    Me.txtTglPendaftaran = New DevExpress.XtraEditors.DateEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.txtFasilitasKite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoPendaftaran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKPBC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoPengajuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglPendaftaran2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglPendaftaran2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglPendaftaran.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglPendaftaran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtTgl2
    '
    Me.txtTgl2.EditValue = Nothing
    Me.txtTgl2.Location = New System.Drawing.Point(318, 12)
    Me.txtTgl2.Name = "txtTgl2"
    Me.txtTgl2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.txtTgl2.Properties.DisplayFormat.FormatString = "D"
    Me.txtTgl2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTgl2.Size = New System.Drawing.Size(142, 20)
    Me.txtTgl2.StyleController = Me.LayoutControl1
    Me.txtTgl2.TabIndex = 104
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.txtFasilitasKite)
    Me.LayoutControl1.Controls.Add(Me.txtNoPendaftaran)
    Me.LayoutControl1.Controls.Add(Me.txtKPBC)
    Me.LayoutControl1.Controls.Add(Me.txtNoPengajuan)
    Me.LayoutControl1.Controls.Add(Me.txtTgl2)
    Me.LayoutControl1.Controls.Add(Me.txtTgl1)
    Me.LayoutControl1.Controls.Add(Me.txtTglPendaftaran2)
    Me.LayoutControl1.Controls.Add(Me.txtTglPendaftaran)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(472, 360)
    Me.LayoutControl1.TabIndex = 115
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'txtFasilitasKite
    '
    Me.txtFasilitasKite.Location = New System.Drawing.Point(12, 132)
    Me.txtFasilitasKite.Name = "txtFasilitasKite"
    Me.txtFasilitasKite.Properties.AllowGrayed = True
    Me.txtFasilitasKite.Properties.Caption = "Fasilitas KITE"
    Me.txtFasilitasKite.Size = New System.Drawing.Size(221, 19)
    Me.txtFasilitasKite.StyleController = Me.LayoutControl1
    Me.txtFasilitasKite.TabIndex = 111
    '
    'txtNoPendaftaran
    '
    Me.txtNoPendaftaran.Location = New System.Drawing.Point(92, 84)
    Me.txtNoPendaftaran.Name = "txtNoPendaftaran"
    Me.txtNoPendaftaran.Size = New System.Drawing.Size(368, 20)
    Me.txtNoPendaftaran.StyleController = Me.LayoutControl1
    Me.txtNoPendaftaran.TabIndex = 108
    '
    'txtKPBC
    '
    Me.txtKPBC.Location = New System.Drawing.Point(92, 60)
    Me.txtKPBC.Name = "txtKPBC"
    Me.txtKPBC.Size = New System.Drawing.Size(368, 20)
    Me.txtKPBC.StyleController = Me.LayoutControl1
    Me.txtKPBC.TabIndex = 107
    '
    'txtNoPengajuan
    '
    Me.txtNoPengajuan.Location = New System.Drawing.Point(92, 36)
    Me.txtNoPengajuan.Name = "txtNoPengajuan"
    Me.txtNoPengajuan.Size = New System.Drawing.Size(368, 20)
    Me.txtNoPengajuan.StyleController = Me.LayoutControl1
    Me.txtNoPengajuan.TabIndex = 106
    '
    'txtTgl1
    '
    Me.txtTgl1.EditValue = Nothing
    Me.txtTgl1.Location = New System.Drawing.Point(92, 12)
    Me.txtTgl1.Name = "txtTgl1"
    Me.txtTgl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.txtTgl1.Properties.DisplayFormat.FormatString = "D"
    Me.txtTgl1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTgl1.Size = New System.Drawing.Size(142, 20)
    Me.txtTgl1.StyleController = Me.LayoutControl1
    Me.txtTgl1.TabIndex = 103
    '
    'txtTglPendaftaran2
    '
    Me.txtTglPendaftaran2.EditValue = Nothing
    Me.txtTglPendaftaran2.Location = New System.Drawing.Point(317, 108)
    Me.txtTglPendaftaran2.Name = "txtTglPendaftaran2"
    Me.txtTglPendaftaran2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglPendaftaran2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglPendaftaran2.Properties.Mask.EditMask = ""
    Me.txtTglPendaftaran2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.txtTglPendaftaran2.Size = New System.Drawing.Size(143, 20)
    Me.txtTglPendaftaran2.StyleController = Me.LayoutControl1
    Me.txtTglPendaftaran2.TabIndex = 110
    '
    'txtTglPendaftaran
    '
    Me.txtTglPendaftaran.EditValue = Nothing
    Me.txtTglPendaftaran.Location = New System.Drawing.Point(92, 108)
    Me.txtTglPendaftaran.Name = "txtTglPendaftaran"
    Me.txtTglPendaftaran.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglPendaftaran.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglPendaftaran.Properties.Mask.EditMask = ""
    Me.txtTglPendaftaran.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.txtTglPendaftaran.Size = New System.Drawing.Size(141, 20)
    Me.txtTglPendaftaran.StyleController = Me.LayoutControl1
    Me.txtTglPendaftaran.TabIndex = 109
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem2, Me.LayoutControlItem8})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(472, 360)
    Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtTgl1
    Me.LayoutControlItem1.CustomizationFormText = "Tgl PIB"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(226, 24)
    Me.LayoutControlItem1.Text = "Tgl PIB"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(77, 13)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtNoPengajuan
    Me.LayoutControlItem3.CustomizationFormText = "No Pengajuan"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(452, 24)
    Me.LayoutControlItem3.Text = "No Pengajuan"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(77, 13)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtKPBC
    Me.LayoutControlItem4.CustomizationFormText = "KPBC"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(452, 24)
    Me.LayoutControlItem4.Text = "KPBC"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(77, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtNoPendaftaran
    Me.LayoutControlItem5.CustomizationFormText = "No Pendaftaran"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(452, 24)
    Me.LayoutControlItem5.Text = "No Pendaftaran"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(77, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtTglPendaftaran
    Me.LayoutControlItem6.CustomizationFormText = "Tgl Pendaftaran"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 96)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(225, 24)
    Me.LayoutControlItem6.Text = "Tgl Pendaftaran"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(77, 13)
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.txtTglPendaftaran2
    Me.LayoutControlItem7.CustomizationFormText = "s/d"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(225, 96)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(227, 244)
    Me.LayoutControlItem7.Text = "s/d"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(77, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtTgl2
    Me.LayoutControlItem2.CustomizationFormText = "s/d"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(226, 0)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(226, 24)
    Me.LayoutControlItem2.Text = "s/d"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(77, 13)
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtFasilitasKite
    Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 120)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(225, 220)
    Me.LayoutControlItem8.Text = "LayoutControlItem8"
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem8.TextToControlDistance = 0
    Me.LayoutControlItem8.TextVisible = False
    '
    'RF_SanYuRekapPIB
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(472, 409)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Name = "RF_SanYuRekapPIB"
    Me.Text = "Filter Rekap PIB"
    Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.txtFasilitasKite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoPendaftaran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKPBC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoPengajuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglPendaftaran2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglPendaftaran2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglPendaftaran.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglPendaftaran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtTgl2 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtTgl1 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtNoPengajuan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtNoPendaftaran As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtKPBC As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtTglPendaftaran2 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtTglPendaftaran As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtFasilitasKite As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
End Class
