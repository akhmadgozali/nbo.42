<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_SanYuSetting
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
    Me.xpKontak = New DevExpress.Xpo.XPCollection(Me.components)
    Me.lytSetting = New DevExpress.XtraLayout.LayoutControl()
    Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colJenisPenjualan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.colJenisPenjualanRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.xpKontak, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytSetting, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytSetting.SuspendLayout()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colJenisPenjualanRepo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btn1
    '
    Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
    Me.btn1.Appearance.Options.UseForeColor = True
    Me.btn1.Location = New System.Drawing.Point(238, 11)
    '
    'btn2
    '
    Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
    Me.btn2.Appearance.Options.UseForeColor = True
    Me.btn2.Location = New System.Drawing.Point(331, 11)
    '
    'PanelControl1
    '
    Me.PanelControl1.Location = New System.Drawing.Point(0, 416)
    Me.PanelControl1.Size = New System.Drawing.Size(426, 49)
    '
    'xpKontak
    '
    Me.xpKontak.CriteriaString = "[TipeKontak.Id] = 2"
    Me.xpKontak.DisplayableProperties = "This;created_date;created_user;last_date;last_modified;Id;TipeKontak.Id;TipeKonta" &
    "k;Kode;Nama;JenisPenjualan"
    Me.xpKontak.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.SanYu_Kontak)
    '
    'lytSetting
    '
    Me.lytSetting.Controls.Add(Me.GridControl1)
    Me.lytSetting.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytSetting.Location = New System.Drawing.Point(0, 0)
    Me.lytSetting.Name = "lytSetting"
    Me.lytSetting.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(589, 174, 250, 350)
    Me.lytSetting.Root = Me.LayoutControlGroup1
    Me.lytSetting.Size = New System.Drawing.Size(426, 416)
    Me.lytSetting.TabIndex = 10
    Me.lytSetting.Text = "LayoutControl1"
    '
    'GridControl1
    '
    Me.GridControl1.DataSource = Me.xpKontak
    Me.GridControl1.Location = New System.Drawing.Point(24, 62)
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colJenisPenjualanRepo})
    Me.GridControl1.Size = New System.Drawing.Size(378, 330)
    Me.GridControl1.TabIndex = 0
    Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode, Me.colNama, Me.colJenisPenjualan})
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsDetail.EnableMasterViewMode = False
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'colKode
    '
    Me.colKode.Caption = "Kode"
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    Me.colKode.Width = 63
    '
    'colNama
    '
    Me.colNama.Caption = "Nama"
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 1
    Me.colNama.Width = 105
    '
    'colJenisPenjualan
    '
    Me.colJenisPenjualan.Caption = "Jenis"
    Me.colJenisPenjualan.ColumnEdit = Me.colJenisPenjualanRepo
    Me.colJenisPenjualan.FieldName = "JenisPenjualan"
    Me.colJenisPenjualan.Name = "colJenisPenjualan"
    Me.colJenisPenjualan.Visible = True
    Me.colJenisPenjualan.VisibleIndex = 2
    Me.colJenisPenjualan.Width = 89
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(426, 416)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'TabbedControlGroup1
    '
    Me.TabbedControlGroup1.CustomizationFormText = "TabbedControlGroup1"
    Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
    Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup2
    Me.TabbedControlGroup1.SelectedTabPageIndex = 0
    Me.TabbedControlGroup1.Size = New System.Drawing.Size(406, 396)
    Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
    Me.TabbedControlGroup1.Text = "TabbedControlGroup1"
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "Buyer"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(382, 350)
    Me.LayoutControlGroup2.Text = "Buyer"
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.Control = Me.GridControl1
    Me.LayoutControlItem9.CustomizationFormText = "Setting Mata Uang"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(382, 350)
    Me.LayoutControlItem9.Text = "setting Jenis Penjualan Buyer"
    Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(141, 13)
    '
    'colJenisPenjualanRepo
    '
    Me.colJenisPenjualanRepo.AutoHeight = False
    Me.colJenisPenjualanRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.colJenisPenjualanRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Name")})
    Me.colJenisPenjualanRepo.DisplayMember = "Value"
    Me.colJenisPenjualanRepo.Name = "colJenisPenjualanRepo"
    Me.colJenisPenjualanRepo.NullText = "<Pilih Jenis Penjualan>"
    Me.colJenisPenjualanRepo.ValueMember = "Key"
    '
    'UI_SanYuSetting
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(426, 465)
    Me.Controls.Add(Me.lytSetting)
    Me.Name = "UI_SanYuSetting"
    Me.Text = "Setting Module Sales"
    Me.Controls.SetChildIndex(Me.PanelControl1, 0)
    Me.Controls.SetChildIndex(Me.lytSetting, 0)
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    CType(Me.xpKontak, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytSetting, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytSetting.ResumeLayout(False)
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colJenisPenjualanRepo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colJenisPenjualan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents lytSetting As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents xpKontak As DevExpress.Xpo.XPCollection
  Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colJenisPenjualanRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
