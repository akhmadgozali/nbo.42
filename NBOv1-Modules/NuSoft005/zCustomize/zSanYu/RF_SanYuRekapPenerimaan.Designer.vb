<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RF_SanYuRekapPenerimaan
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
    Me.txtTgl1 = New DevExpress.XtraEditors.DateEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.txtNoBukti1 = New DevExpress.XtraEditors.TextEdit()
    Me.txtNoBukti2 = New DevExpress.XtraEditors.TextEdit()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.txtFasilitasKite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoBukti1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoBukti2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtTgl2
    '
    Me.txtTgl2.EditValue = Nothing
    Me.txtTgl2.Location = New System.Drawing.Point(313, 12)
    Me.txtTgl2.Name = "txtTgl2"
    Me.txtTgl2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.txtTgl2.Properties.DisplayFormat.FormatString = "D"
    Me.txtTgl2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTgl2.Size = New System.Drawing.Size(147, 20)
    Me.txtTgl2.StyleController = Me.LayoutControl1
    Me.txtTgl2.TabIndex = 104
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.txtFasilitasKite)
    Me.LayoutControl1.Controls.Add(Me.txtTgl2)
    Me.LayoutControl1.Controls.Add(Me.txtTgl1)
    Me.LayoutControl1.Controls.Add(Me.txtNoBukti1)
    Me.LayoutControl1.Controls.Add(Me.txtNoBukti2)
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
    Me.txtFasilitasKite.Location = New System.Drawing.Point(12, 60)
    Me.txtFasilitasKite.Name = "txtFasilitasKite"
    Me.txtFasilitasKite.Properties.AllowGrayed = True
    Me.txtFasilitasKite.Properties.Caption = "Domestik"
    Me.txtFasilitasKite.Size = New System.Drawing.Size(448, 19)
    Me.txtFasilitasKite.StyleController = Me.LayoutControl1
    Me.txtFasilitasKite.TabIndex = 111
    '
    'txtTgl1
    '
    Me.txtTgl1.EditValue = Nothing
    Me.txtTgl1.Location = New System.Drawing.Point(87, 12)
    Me.txtTgl1.Name = "txtTgl1"
    Me.txtTgl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTgl1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
    Me.txtTgl1.Properties.DisplayFormat.FormatString = "D"
    Me.txtTgl1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTgl1.Size = New System.Drawing.Size(147, 20)
    Me.txtTgl1.StyleController = Me.LayoutControl1
    Me.txtTgl1.TabIndex = 103
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem5, Me.LayoutControlItem2, Me.LayoutControlItem8, Me.LayoutControlItem3})
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
    Me.LayoutControlItem1.Text = "Tanggal"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(72, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtNoBukti1
    Me.LayoutControlItem5.CustomizationFormText = "No Pendaftaran"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(226, 24)
    Me.LayoutControlItem5.Text = "No Penerimaan"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(72, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtTgl2
    Me.LayoutControlItem2.CustomizationFormText = "s/d"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(226, 0)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(226, 24)
    Me.LayoutControlItem2.Text = "s/d"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(72, 13)
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtFasilitasKite
    Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(452, 292)
    Me.LayoutControlItem8.Text = "LayoutControlItem8"
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem8.TextToControlDistance = 0
    Me.LayoutControlItem8.TextVisible = False
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtNoBukti2
    Me.LayoutControlItem3.CustomizationFormText = "sd"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(226, 24)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(226, 24)
    Me.LayoutControlItem3.Text = "sd"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(72, 13)
    '
    'txtNoBukti1
    '
    Me.txtNoBukti1.Location = New System.Drawing.Point(87, 36)
    Me.txtNoBukti1.Name = "txtNoBukti1"
    Me.txtNoBukti1.Size = New System.Drawing.Size(147, 20)
    Me.txtNoBukti1.StyleController = Me.LayoutControl1
    Me.txtNoBukti1.TabIndex = 108
    '
    'txtNoBukti2
    '
    Me.txtNoBukti2.EditValue = ""
    Me.txtNoBukti2.Location = New System.Drawing.Point(313, 36)
    Me.txtNoBukti2.Name = "txtNoBukti2"
    Me.txtNoBukti2.Properties.NullText = "[EditValue is null]"
    Me.txtNoBukti2.Size = New System.Drawing.Size(147, 20)
    Me.txtNoBukti2.StyleController = Me.LayoutControl1
    Me.txtNoBukti2.TabIndex = 112
    '
    'RF_SanYuRekapPenerimaan
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(472, 409)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Name = "RF_SanYuRekapPenerimaan"
    Me.Text = "Filter Rekap Penerimaan Barang"
    Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.txtFasilitasKite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoBukti1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoBukti2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtTgl2 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtTgl1 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtFasilitasKite As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtNoBukti1 As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtNoBukti2 As DevExpress.XtraEditors.TextEdit
End Class
