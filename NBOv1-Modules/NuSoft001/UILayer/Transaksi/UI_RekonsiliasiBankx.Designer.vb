<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_RekonsiliasiBankx
  Inherits NuSoft.Core.Win.Forms.BlankForm

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
    Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
    Me.cmdOK = New DevExpress.XtraEditors.SimpleButton()
    Me.txtAkun = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.txtSaldo = New DevExpress.XtraEditors.TextEdit()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
    Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
    Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
    Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
    Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
    Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
    Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
    Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.txtAkun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl1.SuspendLayout()
    CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl2.SuspendLayout()
    CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl3.SuspendLayout()
    CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupControl4.SuspendLayout()
    Me.SuspendLayout()
    '
    'PanelControl1
    '
    Me.PanelControl1.Controls.Add(Me.cmdOK)
    Me.PanelControl1.Controls.Add(Me.txtAkun)
    Me.PanelControl1.Controls.Add(Me.txtTanggal)
    Me.PanelControl1.Controls.Add(Me.LabelControl2)
    Me.PanelControl1.Controls.Add(Me.LabelControl3)
    Me.PanelControl1.Controls.Add(Me.LabelControl1)
    Me.PanelControl1.Controls.Add(Me.txtSaldo)
    Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
    Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
    Me.PanelControl1.Name = "PanelControl1"
    Me.PanelControl1.Size = New System.Drawing.Size(1127, 37)
    Me.PanelControl1.TabIndex = 0
    '
    'cmdOK
    '
    Me.cmdOK.Location = New System.Drawing.Point(623, 5)
    Me.cmdOK.Name = "cmdOK"
    Me.cmdOK.Size = New System.Drawing.Size(75, 23)
    Me.cmdOK.TabIndex = 4
    Me.cmdOK.Text = "OK"
    '
    'txtAkun
    '
    Me.txtAkun.Location = New System.Drawing.Point(476, 8)
    Me.txtAkun.Name = "txtAkun"
    Me.txtAkun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtAkun.Properties.NullText = "Pilih akun"
    Me.txtAkun.Size = New System.Drawing.Size(100, 20)
    Me.txtAkun.TabIndex = 3
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(110, 8)
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Size = New System.Drawing.Size(100, 20)
    Me.txtTanggal.TabIndex = 2
    '
    'LabelControl2
    '
    Me.LabelControl2.Location = New System.Drawing.Point(10, 11)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(94, 13)
    Me.LabelControl2.TabIndex = 1
    Me.LabelControl2.Text = "Tanggal Rek. Koran"
    '
    'LabelControl3
    '
    Me.LabelControl3.Location = New System.Drawing.Point(257, 11)
    Me.LabelControl3.Name = "LabelControl3"
    Me.LabelControl3.Size = New System.Drawing.Size(52, 13)
    Me.LabelControl3.TabIndex = 1
    Me.LabelControl3.Text = "Saldo Bank"
    '
    'LabelControl1
    '
    Me.LabelControl1.Location = New System.Drawing.Point(446, 12)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(24, 13)
    Me.LabelControl1.TabIndex = 1
    Me.LabelControl1.Text = "Akun"
    '
    'txtSaldo
    '
    Me.txtSaldo.Location = New System.Drawing.Point(312, 8)
    Me.txtSaldo.Name = "txtSaldo"
    Me.txtSaldo.Properties.Appearance.Options.UseTextOptions = True
    Me.txtSaldo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.txtSaldo.Properties.Mask.EditMask = "n2"
    Me.txtSaldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.txtSaldo.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.txtSaldo.Size = New System.Drawing.Size(100, 20)
    Me.txtSaldo.TabIndex = 0
    '
    'xGrid
    '
    Me.xGrid.Dock = System.Windows.Forms.DockStyle.Fill
    Me.xGrid.Location = New System.Drawing.Point(0, 37)
    Me.xGrid.MainView = Me.GridView1
    Me.xGrid.Name = "xGrid"
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
    Me.xGrid.Size = New System.Drawing.Size(1127, 478)
    Me.xGrid.TabIndex = 1
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'GridView1
    '
    Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridView1.Appearance.ViewCaption.Options.UseTextOptions = True
    Me.GridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
    Me.GridView1.GridControl = Me.xGrid
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsView.ColumnAutoWidth = False
    Me.GridView1.OptionsView.ShowFooter = True
    Me.GridView1.OptionsView.ShowGroupPanel = False
    Me.GridView1.OptionsView.ShowViewCaption = True
    Me.GridView1.ViewCaption = "Transaksi - Belum Kliring"
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Tanggal"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Nomor"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Uraian"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 2
    Me.GridColumn3.Width = 150
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Kontak"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 3
    Me.GridColumn4.Width = 100
    '
    'GridColumn5
    '
    Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn5.Caption = "Masuk [Debit]"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 4
    Me.GridColumn5.Width = 100
    '
    'GridColumn6
    '
    Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn6.Caption = "Keluar [Kredit]"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 5
    Me.GridColumn6.Width = 100
    '
    'GridColumn7
    '
    Me.GridColumn7.Caption = "Cek"
    Me.GridColumn7.Name = "GridColumn7"
    Me.GridColumn7.Visible = True
    Me.GridColumn7.VisibleIndex = 6
    '
    'GridColumn8
    '
    Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn8.Caption = "X"
    Me.GridColumn8.ColumnEdit = Me.RepositoryItemCheckEdit1
    Me.GridColumn8.Name = "GridColumn8"
    Me.GridColumn8.Visible = True
    Me.GridColumn8.VisibleIndex = 7
    '
    'RepositoryItemCheckEdit1
    '
    Me.RepositoryItemCheckEdit1.AutoHeight = False
    Me.RepositoryItemCheckEdit1.Caption = "Check"
    Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.GroupControl4)
    Me.Panel1.Controls.Add(Me.GroupControl3)
    Me.Panel1.Controls.Add(Me.GroupControl2)
    Me.Panel1.Controls.Add(Me.GroupControl1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.Panel1.Location = New System.Drawing.Point(0, 515)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(1127, 99)
    Me.Panel1.TabIndex = 3
    '
    'GroupControl1
    '
    Me.GroupControl1.Controls.Add(Me.LabelControl5)
    Me.GroupControl1.Controls.Add(Me.LabelControl7)
    Me.GroupControl1.Controls.Add(Me.LabelControl6)
    Me.GroupControl1.Controls.Add(Me.LabelControl4)
    Me.GroupControl1.Location = New System.Drawing.Point(10, 6)
    Me.GroupControl1.Name = "GroupControl1"
    Me.GroupControl1.Size = New System.Drawing.Size(189, 82)
    Me.GroupControl1.TabIndex = 10
    Me.GroupControl1.Text = "Total Kliring"
    '
    'LabelControl5
    '
    Me.LabelControl5.Location = New System.Drawing.Point(5, 43)
    Me.LabelControl5.Name = "LabelControl5"
    Me.LabelControl5.Size = New System.Drawing.Size(30, 13)
    Me.LabelControl5.TabIndex = 1
    Me.LabelControl5.Text = "Keluar"
    '
    'LabelControl6
    '
    Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
    Me.LabelControl6.Location = New System.Drawing.Point(52, 24)
    Me.LabelControl6.Name = "LabelControl6"
    Me.LabelControl6.Size = New System.Drawing.Size(132, 13)
    Me.LabelControl6.TabIndex = 1
    Me.LabelControl6.Text = "0"
    '
    'LabelControl4
    '
    Me.LabelControl4.Location = New System.Drawing.Point(5, 24)
    Me.LabelControl4.Name = "LabelControl4"
    Me.LabelControl4.Size = New System.Drawing.Size(30, 13)
    Me.LabelControl4.TabIndex = 1
    Me.LabelControl4.Text = "Masuk"
    '
    'LabelControl7
    '
    Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
    Me.LabelControl7.Location = New System.Drawing.Point(52, 43)
    Me.LabelControl7.Name = "LabelControl7"
    Me.LabelControl7.Size = New System.Drawing.Size(132, 13)
    Me.LabelControl7.TabIndex = 1
    Me.LabelControl7.Text = "0"
    '
    'GroupControl2
    '
    Me.GroupControl2.Controls.Add(Me.LabelControl12)
    Me.GroupControl2.Controls.Add(Me.LabelControl8)
    Me.GroupControl2.Controls.Add(Me.LabelControl13)
    Me.GroupControl2.Controls.Add(Me.LabelControl9)
    Me.GroupControl2.Controls.Add(Me.LabelControl10)
    Me.GroupControl2.Controls.Add(Me.LabelControl11)
    Me.GroupControl2.Location = New System.Drawing.Point(214, 6)
    Me.GroupControl2.Name = "GroupControl2"
    Me.GroupControl2.Size = New System.Drawing.Size(247, 82)
    Me.GroupControl2.TabIndex = 11
    Me.GroupControl2.Text = "Bank"
    '
    'LabelControl8
    '
    Me.LabelControl8.Location = New System.Drawing.Point(5, 43)
    Me.LabelControl8.Name = "LabelControl8"
    Me.LabelControl8.Size = New System.Drawing.Size(101, 13)
    Me.LabelControl8.TabIndex = 1
    Me.LabelControl8.Text = "Setoran Diperjalanan"
    '
    'LabelControl9
    '
    Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
    Me.LabelControl9.Location = New System.Drawing.Point(112, 43)
    Me.LabelControl9.Name = "LabelControl9"
    Me.LabelControl9.Size = New System.Drawing.Size(132, 13)
    Me.LabelControl9.TabIndex = 1
    Me.LabelControl9.Text = "0"
    '
    'LabelControl10
    '
    Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
    Me.LabelControl10.Location = New System.Drawing.Point(112, 24)
    Me.LabelControl10.Name = "LabelControl10"
    Me.LabelControl10.Size = New System.Drawing.Size(132, 13)
    Me.LabelControl10.TabIndex = 1
    Me.LabelControl10.Text = "0"
    '
    'LabelControl11
    '
    Me.LabelControl11.Location = New System.Drawing.Point(5, 24)
    Me.LabelControl11.Name = "LabelControl11"
    Me.LabelControl11.Size = New System.Drawing.Size(26, 13)
    Me.LabelControl11.TabIndex = 1
    Me.LabelControl11.Text = "Saldo"
    '
    'LabelControl12
    '
    Me.LabelControl12.Location = New System.Drawing.Point(5, 62)
    Me.LabelControl12.Name = "LabelControl12"
    Me.LabelControl12.Size = New System.Drawing.Size(24, 13)
    Me.LabelControl12.TabIndex = 1
    Me.LabelControl12.Text = "Total"
    '
    'LabelControl13
    '
    Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.LabelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
    Me.LabelControl13.Location = New System.Drawing.Point(112, 62)
    Me.LabelControl13.Name = "LabelControl13"
    Me.LabelControl13.Size = New System.Drawing.Size(132, 13)
    Me.LabelControl13.TabIndex = 1
    Me.LabelControl13.Text = "0"
    '
    'GroupControl3
    '
    Me.GroupControl3.Controls.Add(Me.LabelControl14)
    Me.GroupControl3.Controls.Add(Me.LabelControl15)
    Me.GroupControl3.Controls.Add(Me.LabelControl16)
    Me.GroupControl3.Controls.Add(Me.LabelControl17)
    Me.GroupControl3.Controls.Add(Me.LabelControl18)
    Me.GroupControl3.Controls.Add(Me.LabelControl19)
    Me.GroupControl3.Location = New System.Drawing.Point(476, 6)
    Me.GroupControl3.Name = "GroupControl3"
    Me.GroupControl3.Size = New System.Drawing.Size(247, 82)
    Me.GroupControl3.TabIndex = 12
    Me.GroupControl3.Text = "General Ledger"
    '
    'LabelControl14
    '
    Me.LabelControl14.Location = New System.Drawing.Point(5, 62)
    Me.LabelControl14.Name = "LabelControl14"
    Me.LabelControl14.Size = New System.Drawing.Size(24, 13)
    Me.LabelControl14.TabIndex = 1
    Me.LabelControl14.Text = "Total"
    '
    'LabelControl15
    '
    Me.LabelControl15.Location = New System.Drawing.Point(5, 43)
    Me.LabelControl15.Name = "LabelControl15"
    Me.LabelControl15.Size = New System.Drawing.Size(82, 13)
    Me.LabelControl15.TabIndex = 1
    Me.LabelControl15.Text = "Cek/Giro Beredar"
    '
    'LabelControl16
    '
    Me.LabelControl16.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.LabelControl16.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
    Me.LabelControl16.Location = New System.Drawing.Point(112, 62)
    Me.LabelControl16.Name = "LabelControl16"
    Me.LabelControl16.Size = New System.Drawing.Size(132, 13)
    Me.LabelControl16.TabIndex = 1
    Me.LabelControl16.Text = "0"
    '
    'LabelControl17
    '
    Me.LabelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.LabelControl17.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
    Me.LabelControl17.Location = New System.Drawing.Point(112, 43)
    Me.LabelControl17.Name = "LabelControl17"
    Me.LabelControl17.Size = New System.Drawing.Size(132, 13)
    Me.LabelControl17.TabIndex = 1
    Me.LabelControl17.Text = "0"
    '
    'LabelControl18
    '
    Me.LabelControl18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.LabelControl18.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
    Me.LabelControl18.Location = New System.Drawing.Point(112, 24)
    Me.LabelControl18.Name = "LabelControl18"
    Me.LabelControl18.Size = New System.Drawing.Size(132, 13)
    Me.LabelControl18.TabIndex = 1
    Me.LabelControl18.Text = "0"
    '
    'LabelControl19
    '
    Me.LabelControl19.Location = New System.Drawing.Point(5, 24)
    Me.LabelControl19.Name = "LabelControl19"
    Me.LabelControl19.Size = New System.Drawing.Size(26, 13)
    Me.LabelControl19.TabIndex = 1
    Me.LabelControl19.Text = "Saldo"
    '
    'GroupControl4
    '
    Me.GroupControl4.Controls.Add(Me.LabelControl24)
    Me.GroupControl4.Controls.Add(Me.LabelControl25)
    Me.GroupControl4.Location = New System.Drawing.Point(742, 6)
    Me.GroupControl4.Name = "GroupControl4"
    Me.GroupControl4.Size = New System.Drawing.Size(247, 82)
    Me.GroupControl4.TabIndex = 13
    Me.GroupControl4.Text = "Selisih"
    '
    'LabelControl24
    '
    Me.LabelControl24.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.LabelControl24.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
    Me.LabelControl24.Location = New System.Drawing.Point(112, 24)
    Me.LabelControl24.Name = "LabelControl24"
    Me.LabelControl24.Size = New System.Drawing.Size(132, 13)
    Me.LabelControl24.TabIndex = 1
    Me.LabelControl24.Text = "0"
    '
    'LabelControl25
    '
    Me.LabelControl25.Location = New System.Drawing.Point(5, 24)
    Me.LabelControl25.Name = "LabelControl25"
    Me.LabelControl25.Size = New System.Drawing.Size(29, 13)
    Me.LabelControl25.TabIndex = 1
    Me.LabelControl25.Text = "Selisih"
    '
    'UI_RekonsiliasiBank
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1127, 614)
    Me.Controls.Add(Me.xGrid)
    Me.Controls.Add(Me.PanelControl1)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "UI_RekonsiliasiBank"
    Me.Text = "Rekonsiliasi Bank"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    Me.PanelControl1.PerformLayout()
    CType(Me.txtAkun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl1.ResumeLayout(False)
    Me.GroupControl1.PerformLayout()
    CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl2.ResumeLayout(False)
    Me.GroupControl2.PerformLayout()
    CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl3.ResumeLayout(False)
    Me.GroupControl3.PerformLayout()
    CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupControl4.ResumeLayout(False)
    Me.GroupControl4.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
  Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents txtAkun As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtSaldo As DevExpress.XtraEditors.TextEdit
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
  Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
End Class
