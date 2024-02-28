<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_AkunDialog
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
    Me.txtTipeAkun = New DevExpress.XtraEditors.LookUpEdit()
    Me.lytMasterAkun = New DevExpress.XtraLayout.LayoutControl()
    Me.txtCFOUT = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtCFIN = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtSubAkun = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtFormat = New DevExpress.XtraEditors.TextEdit()
    Me.txtAkunIntegrasi = New DevExpress.XtraEditors.CheckEdit()
    Me.txtCFGabung = New DevExpress.XtraEditors.CheckEdit()
    Me.txtKeterangan = New DevExpress.XtraEditors.TextEdit()
    Me.txtCFMinus = New DevExpress.XtraEditors.TextEdit()
    Me.txtDivisi = New DevExpress.XtraEditors.LookUpEdit()
    Me.xpDivisi = New DevExpress.Xpo.XPCollection(Me.components)
    Me.txtCFPlus = New DevExpress.XtraEditors.TextEdit()
    Me.txtBank = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtKode = New DevExpress.XtraEditors.TextEdit()
    Me.txtAktif = New DevExpress.XtraEditors.CheckEdit()
    Me.txtMataUang = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtNama = New DevExpress.XtraEditors.TextEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.xpAkun = New DevExpress.Xpo.XPCollection(Me.components)
    Me.xpBank = New DevExpress.Xpo.XPCollection(Me.components)
    Me.xpMataUang = New DevExpress.Xpo.XPCollection(Me.components)
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTipeAkun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytMasterAkun, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytMasterAkun.SuspendLayout()
    CType(Me.txtCFOUT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCFIN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSubAkun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAkunIntegrasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCFGabung.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCFMinus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDivisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpDivisi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCFPlus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAktif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMataUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpAkun, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpBank, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpMataUang, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtTipeAkun
    '
    Me.txtTipeAkun.Location = New System.Drawing.Point(85, 12)
    Me.txtTipeAkun.Name = "txtTipeAkun"
    Me.txtTipeAkun.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTipeAkun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTipeAkun.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.txtTipeAkun.Properties.DisplayMember = "Kode"
    Me.txtTipeAkun.Properties.NullText = "<Pilih Tipe Akun>"
    Me.txtTipeAkun.Properties.ShowHeader = False
    Me.txtTipeAkun.Properties.ValueMember = "This"
    Me.txtTipeAkun.Size = New System.Drawing.Size(129, 20)
    Me.txtTipeAkun.StyleController = Me.lytMasterAkun
    Me.txtTipeAkun.TabIndex = 0
    '
    'lytMasterAkun
    '
    Me.lytMasterAkun.Controls.Add(Me.txtCFOUT)
    Me.lytMasterAkun.Controls.Add(Me.txtCFIN)
    Me.lytMasterAkun.Controls.Add(Me.txtSubAkun)
    Me.lytMasterAkun.Controls.Add(Me.txtFormat)
    Me.lytMasterAkun.Controls.Add(Me.txtAkunIntegrasi)
    Me.lytMasterAkun.Controls.Add(Me.txtCFGabung)
    Me.lytMasterAkun.Controls.Add(Me.txtKeterangan)
    Me.lytMasterAkun.Controls.Add(Me.txtCFMinus)
    Me.lytMasterAkun.Controls.Add(Me.txtDivisi)
    Me.lytMasterAkun.Controls.Add(Me.txtCFPlus)
    Me.lytMasterAkun.Controls.Add(Me.txtTipeAkun)
    Me.lytMasterAkun.Controls.Add(Me.txtBank)
    Me.lytMasterAkun.Controls.Add(Me.txtKode)
    Me.lytMasterAkun.Controls.Add(Me.txtAktif)
    Me.lytMasterAkun.Controls.Add(Me.txtMataUang)
    Me.lytMasterAkun.Controls.Add(Me.txtNama)
    Me.lytMasterAkun.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytMasterAkun.Location = New System.Drawing.Point(0, 0)
    Me.lytMasterAkun.Name = "lytMasterAkun"
    Me.lytMasterAkun.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(655, 205, 250, 350)
    Me.lytMasterAkun.Root = Me.LayoutControlGroup1
    Me.lytMasterAkun.Size = New System.Drawing.Size(441, 335)
    Me.lytMasterAkun.TabIndex = 100
    Me.lytMasterAkun.Text = "LayoutControl1"
    '
    'txtCFOUT
    '
    Me.txtCFOUT.Location = New System.Drawing.Point(97, 285)
    Me.txtCFOUT.Name = "txtCFOUT"
    Me.txtCFOUT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCFOUT.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtCFOUT.Properties.DisplayMember = "Nama"
    Me.txtCFOUT.Properties.NullText = "<Pilih Cash Flow>"
    Me.txtCFOUT.Properties.ValueMember = "This"
    Me.txtCFOUT.Size = New System.Drawing.Size(320, 20)
    Me.txtCFOUT.StyleController = Me.lytMasterAkun
    Me.txtCFOUT.TabIndex = 15
    '
    'txtCFIN
    '
    Me.txtCFIN.Location = New System.Drawing.Point(97, 261)
    Me.txtCFIN.Name = "txtCFIN"
    Me.txtCFIN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCFIN.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtCFIN.Properties.DisplayMember = "Nama"
    Me.txtCFIN.Properties.NullText = "<Pilih Cash Flow>"
    Me.txtCFIN.Properties.ValueMember = "This"
    Me.txtCFIN.Size = New System.Drawing.Size(320, 20)
    Me.txtCFIN.StyleController = Me.lytMasterAkun
    Me.txtCFIN.TabIndex = 14
    '
    'txtSubAkun
    '
    Me.txtSubAkun.EditValue = "<Pilih Akun Induk>"
    Me.txtSubAkun.Location = New System.Drawing.Point(85, 84)
    Me.txtSubAkun.Name = "txtSubAkun"
    Me.txtSubAkun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtSubAkun.Properties.DataSource = Me.xpAkun
    Me.txtSubAkun.Properties.DisplayMember = "Kode"
    Me.txtSubAkun.Properties.NullText = "<Pilih Induk Akun>"
    Me.txtSubAkun.Properties.ValueMember = "This"
    Me.txtSubAkun.Properties.View = Me.SearchLookUpEdit1View
    Me.txtSubAkun.Size = New System.Drawing.Size(129, 20)
    Me.txtSubAkun.StyleController = Me.lytMasterAkun
    Me.txtSubAkun.TabIndex = 13
    '
    'SearchLookUpEdit1View
    '
    Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcKode, Me.gcNama})
    Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
    Me.SearchLookUpEdit1View.OptionsFind.AlwaysVisible = True
    Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
    Me.SearchLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcKode, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'gcKode
    '
    Me.gcKode.Caption = "Kode"
    Me.gcKode.FieldName = "Kode"
    Me.gcKode.Name = "gcKode"
    Me.gcKode.Visible = True
    Me.gcKode.VisibleIndex = 0
    Me.gcKode.Width = 276
    '
    'gcNama
    '
    Me.gcNama.Caption = "Nama"
    Me.gcNama.FieldName = "Nama"
    Me.gcNama.Name = "gcNama"
    Me.gcNama.Visible = True
    Me.gcNama.VisibleIndex = 1
    Me.gcNama.Width = 802
    '
    'txtFormat
    '
    Me.txtFormat.Location = New System.Drawing.Point(306, 109)
    Me.txtFormat.Name = "txtFormat"
    Me.txtFormat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtFormat.Properties.MaxLength = 2
    Me.txtFormat.Size = New System.Drawing.Size(123, 20)
    Me.txtFormat.StyleController = Me.lytMasterAkun
    Me.txtFormat.TabIndex = 9
    '
    'txtAkunIntegrasi
    '
    Me.txtAkunIntegrasi.Location = New System.Drawing.Point(131, 157)
    Me.txtAkunIntegrasi.Name = "txtAkunIntegrasi"
    Me.txtAkunIntegrasi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtAkunIntegrasi.Properties.Caption = ""
    Me.txtAkunIntegrasi.Size = New System.Drawing.Size(21, 21)
    Me.txtAkunIntegrasi.StyleController = Me.lytMasterAkun
    Me.txtAkunIntegrasi.TabIndex = 11
    '
    'txtCFGabung
    '
    Me.txtCFGabung.Location = New System.Drawing.Point(12, 157)
    Me.txtCFGabung.Name = "txtCFGabung"
    Me.txtCFGabung.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtCFGabung.Properties.Caption = ""
    Me.txtCFGabung.Size = New System.Drawing.Size(21, 21)
    Me.txtCFGabung.StyleController = Me.lytMasterAkun
    Me.txtCFGabung.TabIndex = 10
    '
    'txtKeterangan
    '
    Me.txtKeterangan.Location = New System.Drawing.Point(85, 133)
    Me.txtKeterangan.Name = "txtKeterangan"
    Me.txtKeterangan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKeterangan.Size = New System.Drawing.Size(344, 20)
    Me.txtKeterangan.StyleController = Me.lytMasterAkun
    Me.txtKeterangan.TabIndex = 12
    '
    'txtCFMinus
    '
    Me.txtCFMinus.Location = New System.Drawing.Point(97, 237)
    Me.txtCFMinus.Name = "txtCFMinus"
    Me.txtCFMinus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtCFMinus.Size = New System.Drawing.Size(320, 20)
    Me.txtCFMinus.StyleController = Me.lytMasterAkun
    Me.txtCFMinus.TabIndex = 1
    '
    'txtDivisi
    '
    Me.txtDivisi.Location = New System.Drawing.Point(306, 37)
    Me.txtDivisi.Name = "txtDivisi"
    Me.txtDivisi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtDivisi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtDivisi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode")})
    Me.txtDivisi.Properties.DataSource = Me.xpDivisi
    Me.txtDivisi.Properties.DisplayMember = "Kode"
    Me.txtDivisi.Properties.NullText = "<Pilih Divisi>"
    Me.txtDivisi.Properties.ShowHeader = False
    Me.txtDivisi.Properties.ValueMember = "This"
    Me.txtDivisi.Size = New System.Drawing.Size(123, 20)
    Me.txtDivisi.StyleController = Me.lytMasterAkun
    Me.txtDivisi.TabIndex = 8
    '
    'xpDivisi
    '
    Me.xpDivisi.ObjectType = GetType(NuSoft.NPO.Modules.ModSys.Divisi)
    '
    'txtCFPlus
    '
    Me.txtCFPlus.Location = New System.Drawing.Point(97, 213)
    Me.txtCFPlus.Name = "txtCFPlus"
    Me.txtCFPlus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtCFPlus.Size = New System.Drawing.Size(320, 20)
    Me.txtCFPlus.StyleController = Me.lytMasterAkun
    Me.txtCFPlus.TabIndex = 0
    '
    'txtBank
    '
    Me.txtBank.Location = New System.Drawing.Point(306, 61)
    Me.txtBank.Name = "txtBank"
    Me.txtBank.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtBank.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtBank.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtBank.Properties.DataSource = Me.xpBank
    Me.txtBank.Properties.DisplayMember = "Nama"
    Me.txtBank.Properties.NullText = "<Pilih Bank>"
    Me.txtBank.Properties.ValueMember = "This"
    Me.txtBank.Size = New System.Drawing.Size(123, 20)
    Me.txtBank.StyleController = Me.lytMasterAkun
    Me.txtBank.TabIndex = 7
    '
    'txtKode
    '
    Me.txtKode.Location = New System.Drawing.Point(85, 36)
    Me.txtKode.Name = "txtKode"
    Me.txtKode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKode.Size = New System.Drawing.Size(129, 20)
    Me.txtKode.StyleController = Me.lytMasterAkun
    Me.txtKode.TabIndex = 2
    '
    'txtAktif
    '
    Me.txtAktif.Location = New System.Drawing.Point(306, 12)
    Me.txtAktif.Name = "txtAktif"
    Me.txtAktif.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtAktif.Properties.Caption = ""
    Me.txtAktif.Size = New System.Drawing.Size(123, 21)
    Me.txtAktif.StyleController = Me.lytMasterAkun
    Me.txtAktif.TabIndex = 1
    '
    'txtMataUang
    '
    Me.txtMataUang.Location = New System.Drawing.Point(306, 85)
    Me.txtMataUang.Name = "txtMataUang"
    Me.txtMataUang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtMataUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtMataUang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode")})
    Me.txtMataUang.Properties.DataSource = Me.xpMataUang
    Me.txtMataUang.Properties.DisplayMember = "Kode"
    Me.txtMataUang.Properties.NullText = "<Pilih Mata Uang>"
    Me.txtMataUang.Properties.ShowHeader = False
    Me.txtMataUang.Properties.ValueMember = "This"
    Me.txtMataUang.Size = New System.Drawing.Size(123, 20)
    Me.txtMataUang.StyleController = Me.lytMasterAkun
    Me.txtMataUang.TabIndex = 6
    '
    'txtNama
    '
    Me.txtNama.Location = New System.Drawing.Point(85, 60)
    Me.txtNama.Name = "txtNama"
    Me.txtNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtNama.Size = New System.Drawing.Size(129, 20)
    Me.txtNama.StyleController = Me.lytMasterAkun
    Me.txtNama.TabIndex = 3
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlGroup2, Me.LayoutControlItem4, Me.LayoutControlItem2, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem3, Me.LayoutControlItem8, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.EmptySpaceItem1, Me.LayoutControlItem14, Me.LayoutControlItem15})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(441, 335)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtTipeAkun
    Me.LayoutControlItem1.CustomizationFormText = "Tipe"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(206, 24)
    Me.LayoutControlItem1.Text = "Tipe"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(70, 13)
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
    Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
    Me.LayoutControlGroup2.CustomizationFormText = "Nama Cash Flow"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem16, Me.LayoutControlItem6})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 170)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(421, 145)
    Me.LayoutControlGroup2.Text = "Nama Cash Flow"
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtCFPlus
    Me.LayoutControlItem5.CustomizationFormText = "Bertambah"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(397, 24)
    Me.LayoutControlItem5.Text = "Bertambah"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(70, 13)
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.txtCFIN
    Me.LayoutControlItem7.CustomizationFormText = "Cash Flow IN"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(397, 24)
    Me.LayoutControlItem7.Text = "Cash Flow IN"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(70, 13)
    '
    'LayoutControlItem16
    '
    Me.LayoutControlItem16.Control = Me.txtCFOUT
    Me.LayoutControlItem16.CustomizationFormText = "Cash Flow Out"
    Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem16.Name = "LayoutControlItem16"
    Me.LayoutControlItem16.Size = New System.Drawing.Size(397, 30)
    Me.LayoutControlItem16.Text = "Cash Flow Out"
    Me.LayoutControlItem16.TextSize = New System.Drawing.Size(70, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtCFMinus
    Me.LayoutControlItem6.CustomizationFormText = "Berkurang"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(397, 24)
    Me.LayoutControlItem6.Text = "Berkurang"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(70, 13)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtAktif
    Me.LayoutControlItem4.CustomizationFormText = "Aktif"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(206, 0)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(215, 25)
    Me.LayoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem4.Text = "Aktif"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(70, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtKode
    Me.LayoutControlItem2.CustomizationFormText = "Kode"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(206, 24)
    Me.LayoutControlItem2.Text = "Kode"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(70, 13)
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.Control = Me.txtBank
    Me.LayoutControlItem9.CustomizationFormText = "Bank"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(206, 49)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(215, 24)
    Me.LayoutControlItem9.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem9.Text = "Bank"
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(70, 13)
    '
    'LayoutControlItem10
    '
    Me.LayoutControlItem10.Control = Me.txtDivisi
    Me.LayoutControlItem10.CustomizationFormText = "Divisi"
    Me.LayoutControlItem10.Location = New System.Drawing.Point(206, 25)
    Me.LayoutControlItem10.Name = "LayoutControlItem10"
    Me.LayoutControlItem10.Size = New System.Drawing.Size(215, 24)
    Me.LayoutControlItem10.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem10.Text = "Divisi"
    Me.LayoutControlItem10.TextSize = New System.Drawing.Size(70, 13)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.txtNama
    Me.LayoutControlItem3.CustomizationFormText = "Nama"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(206, 24)
    Me.LayoutControlItem3.Text = "Nama"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(70, 13)
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtMataUang
    Me.LayoutControlItem8.CustomizationFormText = "Mata Uang"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(206, 73)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(215, 24)
    Me.LayoutControlItem8.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem8.Text = "Mata Uang"
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(70, 13)
    '
    'LayoutControlItem11
    '
    Me.LayoutControlItem11.Control = Me.txtFormat
    Me.LayoutControlItem11.CustomizationFormText = "Format Nomor"
    Me.LayoutControlItem11.Location = New System.Drawing.Point(206, 97)
    Me.LayoutControlItem11.Name = "LayoutControlItem11"
    Me.LayoutControlItem11.Size = New System.Drawing.Size(215, 24)
    Me.LayoutControlItem11.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
    Me.LayoutControlItem11.Text = "Format Nomor"
    Me.LayoutControlItem11.TextSize = New System.Drawing.Size(70, 13)
    '
    'LayoutControlItem12
    '
    Me.LayoutControlItem12.Control = Me.txtCFGabung
    Me.LayoutControlItem12.CustomizationFormText = "Gabung Cash Flow"
    Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 145)
    Me.LayoutControlItem12.Name = "LayoutControlItem12"
    Me.LayoutControlItem12.Size = New System.Drawing.Size(119, 25)
    Me.LayoutControlItem12.Text = "Gabung Cash Flow"
    Me.LayoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Right
    Me.LayoutControlItem12.TextSize = New System.Drawing.Size(89, 13)
    Me.LayoutControlItem12.TextToControlDistance = 5
    '
    'LayoutControlItem13
    '
    Me.LayoutControlItem13.Control = Me.txtAkunIntegrasi
    Me.LayoutControlItem13.CustomizationFormText = "Akun Untuk Integrasi"
    Me.LayoutControlItem13.Location = New System.Drawing.Point(119, 145)
    Me.LayoutControlItem13.Name = "LayoutControlItem13"
    Me.LayoutControlItem13.Size = New System.Drawing.Size(131, 25)
    Me.LayoutControlItem13.Text = "Akun Untuk Integrasi"
    Me.LayoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
    Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Right
    Me.LayoutControlItem13.TextSize = New System.Drawing.Size(101, 13)
    Me.LayoutControlItem13.TextToControlDistance = 5
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(250, 145)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(171, 25)
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem14
    '
    Me.LayoutControlItem14.Control = Me.txtKeterangan
    Me.LayoutControlItem14.CustomizationFormText = "Keterangan"
    Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 121)
    Me.LayoutControlItem14.Name = "LayoutControlItem14"
    Me.LayoutControlItem14.Size = New System.Drawing.Size(421, 24)
    Me.LayoutControlItem14.Text = "Keterangan"
    Me.LayoutControlItem14.TextSize = New System.Drawing.Size(70, 13)
    '
    'LayoutControlItem15
    '
    Me.LayoutControlItem15.Control = Me.txtSubAkun
    Me.LayoutControlItem15.CustomizationFormText = "Induk"
    Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem15.Name = "LayoutControlItem15"
    Me.LayoutControlItem15.Size = New System.Drawing.Size(206, 49)
    Me.LayoutControlItem15.Text = "Induk"
    Me.LayoutControlItem15.TextSize = New System.Drawing.Size(70, 13)
    '
    'xpAkun
    '
    Me.xpAkun.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Coa)
    '
    'xpBank
    '
    Me.xpBank.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Bank)
    '
    'xpMataUang
    '
    Me.xpMataUang.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.MataUang)
    '
    'UI_AkunDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(441, 384)
    Me.Controls.Add(Me.lytMasterAkun)
    Me.Name = "UI_AkunDialog"
    Me.Text = "UI_AkunDialog"
    Me.Controls.SetChildIndex(Me.lytMasterAkun, 0)
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTipeAkun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytMasterAkun, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytMasterAkun.ResumeLayout(False)
    CType(Me.txtCFOUT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCFIN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSubAkun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAkunIntegrasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCFGabung.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCFMinus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDivisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpDivisi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCFPlus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAktif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMataUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpAkun, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpBank, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpMataUang, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtTipeAkun As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtKode As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtNama As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtCFMinus As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtCFPlus As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtKeterangan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtMataUang As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtBank As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtCFGabung As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents txtAktif As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents xpAkun As DevExpress.Xpo.XPCollection
  Friend WithEvents xpMataUang As DevExpress.Xpo.XPCollection
  Friend WithEvents xpBank As DevExpress.Xpo.XPCollection
  Friend WithEvents txtDivisi As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents xpDivisi As DevExpress.Xpo.XPCollection
  Friend WithEvents txtAkunIntegrasi As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents txtFormat As DevExpress.XtraEditors.TextEdit
  Friend WithEvents lytMasterAkun As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtSubAkun As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtCFOUT As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtCFIN As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
End Class
