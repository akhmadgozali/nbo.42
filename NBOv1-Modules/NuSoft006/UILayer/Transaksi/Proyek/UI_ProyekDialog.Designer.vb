<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_ProyekDialog
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
    Me.txtKode = New DevExpress.XtraEditors.TextEdit()
    Me.lytMasterProyek = New DevExpress.XtraLayout.LayoutControl()
    Me.txtRAB = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.txtNoKontrak = New DevExpress.XtraEditors.TextEdit()
    Me.txtNama = New DevExpress.XtraEditors.TextEdit()
    Me.txtTglSelesai = New DevExpress.XtraEditors.DateEdit()
    Me.txtTglMulai = New DevExpress.XtraEditors.DateEdit()
    Me.txtCustomer = New DevExpress.XtraEditors.LookUpEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUraian = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytMasterProyek, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytMasterProyek.SuspendLayout()
    CType(Me.txtRAB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoKontrak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglSelesai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglSelesai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglMulai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglMulai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtKode
    '
    Me.txtKode.Location = New System.Drawing.Point(72, 12)
    Me.txtKode.Name = "txtKode"
    Me.txtKode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKode.Size = New System.Drawing.Size(305, 20)
    Me.txtKode.StyleController = Me.lytMasterProyek
    Me.txtKode.TabIndex = 100
    '
    'lytMasterProyek
    '
    Me.lytMasterProyek.Controls.Add(Me.txtRAB)
    Me.lytMasterProyek.Controls.Add(Me.txtNoKontrak)
    Me.lytMasterProyek.Controls.Add(Me.txtKode)
    Me.lytMasterProyek.Controls.Add(Me.txtNama)
    Me.lytMasterProyek.Controls.Add(Me.txtTglSelesai)
    Me.lytMasterProyek.Controls.Add(Me.txtTglMulai)
    Me.lytMasterProyek.Controls.Add(Me.txtCustomer)
    Me.lytMasterProyek.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytMasterProyek.Location = New System.Drawing.Point(0, 0)
    Me.lytMasterProyek.Name = "lytMasterProyek"
    Me.lytMasterProyek.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(647, 154, 250, 350)
    Me.lytMasterProyek.Root = Me.LayoutControlGroup1
    Me.lytMasterProyek.Size = New System.Drawing.Size(389, 193)
    Me.lytMasterProyek.TabIndex = 112
    Me.lytMasterProyek.Text = "LayoutControl1"
    '
    'txtRAB
    '
    Me.txtRAB.Location = New System.Drawing.Point(72, 132)
    Me.txtRAB.Name = "txtRAB"
    Me.txtRAB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRAB.Properties.DisplayMember = "Kode"
    Me.txtRAB.Properties.NullText = "<Pilih Data>"
    Me.txtRAB.Properties.ValueMember = "This"
    Me.txtRAB.Properties.View = Me.SearchLookUpEdit1View
    Me.txtRAB.Size = New System.Drawing.Size(305, 20)
    Me.txtRAB.StyleController = Me.lytMasterProyek
    Me.txtRAB.TabIndex = 111
    '
    'SearchLookUpEdit1View
    '
    Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode, Me.colTahun, Me.GridColumn1, Me.colUraian})
    Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
    Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
    '
    'txtNoKontrak
    '
    Me.txtNoKontrak.Location = New System.Drawing.Point(72, 84)
    Me.txtNoKontrak.Name = "txtNoKontrak"
    Me.txtNoKontrak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNoKontrak.Size = New System.Drawing.Size(305, 20)
    Me.txtNoKontrak.StyleController = Me.lytMasterProyek
    Me.txtNoKontrak.TabIndex = 106
    '
    'txtNama
    '
    Me.txtNama.Location = New System.Drawing.Point(72, 36)
    Me.txtNama.Name = "txtNama"
    Me.txtNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNama.Size = New System.Drawing.Size(305, 20)
    Me.txtNama.StyleController = Me.lytMasterProyek
    Me.txtNama.TabIndex = 102
    '
    'txtTglSelesai
    '
    Me.txtTglSelesai.EditValue = Nothing
    Me.txtTglSelesai.Location = New System.Drawing.Point(241, 108)
    Me.txtTglSelesai.Name = "txtTglSelesai"
    Me.txtTglSelesai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTglSelesai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglSelesai.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglSelesai.Properties.Mask.EditMask = ""
    Me.txtTglSelesai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.txtTglSelesai.Size = New System.Drawing.Size(136, 20)
    Me.txtTglSelesai.StyleController = Me.lytMasterProyek
    Me.txtTglSelesai.TabIndex = 110
    '
    'txtTglMulai
    '
    Me.txtTglMulai.EditValue = Nothing
    Me.txtTglMulai.Location = New System.Drawing.Point(72, 108)
    Me.txtTglMulai.Name = "txtTglMulai"
    Me.txtTglMulai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTglMulai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglMulai.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglMulai.Properties.Mask.EditMask = ""
    Me.txtTglMulai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.txtTglMulai.Size = New System.Drawing.Size(142, 20)
    Me.txtTglMulai.StyleController = Me.lytMasterProyek
    Me.txtTglMulai.TabIndex = 108
    '
    'txtCustomer
    '
    Me.txtCustomer.Location = New System.Drawing.Point(72, 60)
    Me.txtCustomer.Name = "txtCustomer"
    Me.txtCustomer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtCustomer.Properties.DisplayMember = "Kode"
    Me.txtCustomer.Properties.NullText = ""
    Me.txtCustomer.Properties.ValueMember = "This"
    Me.txtCustomer.Size = New System.Drawing.Size(305, 20)
    Me.txtCustomer.StyleController = Me.lytMasterProyek
    Me.txtCustomer.TabIndex = 104
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(389, 193)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtKode
    Me.LayoutControlItem1.CustomizationFormText = "Kode"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(369, 24)
    Me.LayoutControlItem1.Text = "Kode"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(57, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtNama
    Me.LayoutControlItem2.CustomizationFormText = "Nama"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(369, 24)
    Me.LayoutControlItem2.Text = "Nama"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(57, 13)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtCustomer
    Me.LayoutControlItem3.CustomizationFormText = "Customer"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(369, 24)
    Me.LayoutControlItem3.Text = "Customer"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(57, 13)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtNoKontrak
    Me.LayoutControlItem4.CustomizationFormText = "No. Kontrak"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(369, 24)
    Me.LayoutControlItem4.Text = "No. Kontrak"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(57, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtTglMulai
    Me.LayoutControlItem5.CustomizationFormText = "Tgl Mulai"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(206, 24)
    Me.LayoutControlItem5.Text = "Tgl Mulai"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(57, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtTglSelesai
    Me.LayoutControlItem6.CustomizationFormText = " s/d"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(206, 96)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(163, 24)
    Me.LayoutControlItem6.Text = " s/d"
    Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(18, 13)
    Me.LayoutControlItem6.TextToControlDistance = 5
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.txtRAB
    Me.LayoutControlItem7.CustomizationFormText = "RAB"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 120)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(369, 53)
    Me.LayoutControlItem7.Text = "RAB"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(57, 13)
    '
    'colKode
    '
    Me.colKode.Caption = "No RAB"
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    Me.colKode.Width = 153
    '
    'colTahun
    '
    Me.colTahun.Caption = "Tanggal"
    Me.colTahun.FieldName = "Tanggal"
    Me.colTahun.Name = "colTahun"
    Me.colTahun.Visible = True
    Me.colTahun.VisibleIndex = 1
    Me.colTahun.Width = 118
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Pelanggan"
    Me.GridColumn1.FieldName = "Pelanggan.Nama"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 2
    Me.GridColumn1.Width = 309
    '
    'colUraian
    '
    Me.colUraian.Caption = "Uraian"
    Me.colUraian.FieldName = "Uraian"
    Me.colUraian.Name = "colUraian"
    Me.colUraian.Visible = True
    Me.colUraian.VisibleIndex = 3
    Me.colUraian.Width = 498
    '
    'UI_ProyekDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(389, 242)
    Me.Controls.Add(Me.lytMasterProyek)
    Me.Name = "UI_ProyekDialog"
    Me.Text = "Proyek :"
    Me.Controls.SetChildIndex(Me.lytMasterProyek, 0)
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytMasterProyek, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytMasterProyek.ResumeLayout(False)
    CType(Me.txtRAB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoKontrak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglSelesai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglSelesai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglMulai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglMulai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
 Friend WithEvents txtKode As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtNama As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtNoKontrak As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtCustomer As DevExpress.XtraEditors.LookUpEdit
 Friend WithEvents txtTglMulai As DevExpress.XtraEditors.DateEdit
 Friend WithEvents txtTglSelesai As DevExpress.XtraEditors.DateEdit
 Friend WithEvents lytMasterProyek As DevExpress.XtraLayout.LayoutControl
 Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
 Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtRAB As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUraian As DevExpress.XtraGrid.Columns.GridColumn
End Class
