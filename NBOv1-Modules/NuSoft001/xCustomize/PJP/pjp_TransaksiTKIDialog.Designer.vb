<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pjp_TransaksiTKIDialog
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
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xpColTKI = New DevExpress.Xpo.XPCollection(Me.components)
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTglDaftar = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggalMedicalPra = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggalMedicalFull = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggalMedicalOnline = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggalPasporPengajuan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggalPasporKeluar = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggalVisa = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggalTicket = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggalBerangkat = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
    Me.txtTglDaftar = New DevExpress.XtraEditors.DateEdit()
    Me.txtNamaTKI = New DevExpress.XtraEditors.TextEdit()
    Me.txtKodeTKI = New DevExpress.XtraEditors.TextEdit()
    Me.txtTglSKCK = New DevExpress.XtraEditors.DateEdit()
    Me.txtTglVisa = New DevExpress.XtraEditors.DateEdit()
    Me.txtTglMedicalTerusan = New DevExpress.XtraEditors.DateEdit()
    Me.txtTglMedicalFull = New DevExpress.XtraEditors.DateEdit()
    Me.txtTglTiket = New DevExpress.XtraEditors.DateEdit()
    Me.txtTglRekomPaspor = New DevExpress.XtraEditors.DateEdit()
    Me.txtTglMedicalPra = New DevExpress.XtraEditors.DateEdit()
    Me.txtNilai = New DevExpress.XtraEditors.TextEdit()
    Me.btnTampilkan = New DevExpress.XtraEditors.SimpleButton()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpColTKI, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.LayoutControl1.SuspendLayout()
    CType(Me.txtTglDaftar.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglDaftar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNamaTKI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKodeTKI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglSKCK.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglSKCK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglVisa.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglVisa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglMedicalTerusan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglMedicalTerusan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglMedicalFull.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglMedicalFull.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglTiket.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglTiket.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglRekomPaspor.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglRekomPaspor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglMedicalPra.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTglMedicalPra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNilai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.DataSource = Me.xpColTKI
    Me.xGrid.Location = New System.Drawing.Point(12, 175)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.Name = "xGrid"
    Me.xGrid.Size = New System.Drawing.Size(719, 210)
    Me.xGrid.TabIndex = 100
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xpColTKI
    '
    Me.xpColTKI.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.xPJPTKI)
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colKode, Me.colNama, Me.colTglDaftar, Me.colTanggalMedicalPra, Me.colTanggalMedicalFull, Me.colTanggalMedicalOnline, Me.colTanggalPasporPengajuan, Me.colTanggalPasporKeluar, Me.colTanggalVisa, Me.colTanggalTicket, Me.colTanggalBerangkat})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsBehavior.ReadOnly = True
    Me.xGridView.OptionsCustomization.AllowColumnMoving = False
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[True]
    Me.xGridView.OptionsView.ColumnAutoWidth = False
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'colId
    '
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    '
    'colKode
    '
    Me.colKode.Caption = "Kode TKI"
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    Me.colKode.Width = 116
    '
    'colNama
    '
    Me.colNama.Caption = "Nama TKI"
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 1
    Me.colNama.Width = 219
    '
    'colTglDaftar
    '
    Me.colTglDaftar.Caption = "Tanggal Daftar"
    Me.colTglDaftar.DisplayFormat.FormatString = "dd MMM yy"
    Me.colTglDaftar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTglDaftar.FieldName = "TanggalDaftar"
    Me.colTglDaftar.Name = "colTglDaftar"
    Me.colTglDaftar.Visible = True
    Me.colTglDaftar.VisibleIndex = 2
    Me.colTglDaftar.Width = 136
    '
    'colTanggalMedicalPra
    '
    Me.colTanggalMedicalPra.Caption = "Tgl Medical Pra"
    Me.colTanggalMedicalPra.DisplayFormat.FormatString = "dd MMM yy"
    Me.colTanggalMedicalPra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTanggalMedicalPra.FieldName = "TanggalMedicalPra"
    Me.colTanggalMedicalPra.Name = "colTanggalMedicalPra"
    Me.colTanggalMedicalPra.Visible = True
    Me.colTanggalMedicalPra.VisibleIndex = 3
    Me.colTanggalMedicalPra.Width = 117
    '
    'colTanggalMedicalFull
    '
    Me.colTanggalMedicalFull.Caption = "Tanggal Medical Full"
    Me.colTanggalMedicalFull.DisplayFormat.FormatString = "dd MMM yy"
    Me.colTanggalMedicalFull.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTanggalMedicalFull.FieldName = "TanggalMedicalFull"
    Me.colTanggalMedicalFull.Name = "colTanggalMedicalFull"
    Me.colTanggalMedicalFull.Visible = True
    Me.colTanggalMedicalFull.VisibleIndex = 4
    Me.colTanggalMedicalFull.Width = 117
    '
    'colTanggalMedicalOnline
    '
    Me.colTanggalMedicalOnline.Caption = "Tanggal Medical Online"
    Me.colTanggalMedicalOnline.DisplayFormat.FormatString = "dd MMM yy"
    Me.colTanggalMedicalOnline.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTanggalMedicalOnline.FieldName = "TanggalMedicalOnline"
    Me.colTanggalMedicalOnline.Name = "colTanggalMedicalOnline"
    Me.colTanggalMedicalOnline.Visible = True
    Me.colTanggalMedicalOnline.VisibleIndex = 5
    Me.colTanggalMedicalOnline.Width = 122
    '
    'colTanggalPasporPengajuan
    '
    Me.colTanggalPasporPengajuan.Caption = "Tanggal Pengajuan Paspor"
    Me.colTanggalPasporPengajuan.DisplayFormat.FormatString = "dd MMM yy"
    Me.colTanggalPasporPengajuan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTanggalPasporPengajuan.FieldName = "TanggalPasporPengajuan"
    Me.colTanggalPasporPengajuan.Name = "colTanggalPasporPengajuan"
    Me.colTanggalPasporPengajuan.Visible = True
    Me.colTanggalPasporPengajuan.VisibleIndex = 6
    '
    'colTanggalPasporKeluar
    '
    Me.colTanggalPasporKeluar.Caption = "Tanggal Paspor"
    Me.colTanggalPasporKeluar.DisplayFormat.FormatString = "dd MMM yy"
    Me.colTanggalPasporKeluar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTanggalPasporKeluar.FieldName = "TanggalPasporKeluar"
    Me.colTanggalPasporKeluar.Name = "colTanggalPasporKeluar"
    Me.colTanggalPasporKeluar.Visible = True
    Me.colTanggalPasporKeluar.VisibleIndex = 7
    '
    'colTanggalVisa
    '
    Me.colTanggalVisa.Caption = "Tanggal Visa"
    Me.colTanggalVisa.DisplayFormat.FormatString = "dd MMM yy"
    Me.colTanggalVisa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTanggalVisa.FieldName = "TanggalVisa"
    Me.colTanggalVisa.Name = "colTanggalVisa"
    Me.colTanggalVisa.Visible = True
    Me.colTanggalVisa.VisibleIndex = 8
    '
    'colTanggalTicket
    '
    Me.colTanggalTicket.Caption = "Tanggal Ticket"
    Me.colTanggalTicket.DisplayFormat.FormatString = "dd MMM yy"
    Me.colTanggalTicket.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTanggalTicket.FieldName = "TanggalTicket"
    Me.colTanggalTicket.Name = "colTanggalTicket"
    Me.colTanggalTicket.Visible = True
    Me.colTanggalTicket.VisibleIndex = 9
    '
    'colTanggalBerangkat
    '
    Me.colTanggalBerangkat.Caption = "Tanggal Berangkat"
    Me.colTanggalBerangkat.DisplayFormat.FormatString = "dd MMM yy"
    Me.colTanggalBerangkat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTanggalBerangkat.FieldName = "TanggalBerangkat"
    Me.colTanggalBerangkat.Name = "colTanggalBerangkat"
    Me.colTanggalBerangkat.Visible = True
    Me.colTanggalBerangkat.VisibleIndex = 10
    '
    'LayoutControl1
    '
    Me.LayoutControl1.Controls.Add(Me.txtTglDaftar)
    Me.LayoutControl1.Controls.Add(Me.txtNamaTKI)
    Me.LayoutControl1.Controls.Add(Me.txtKodeTKI)
    Me.LayoutControl1.Controls.Add(Me.txtTglSKCK)
    Me.LayoutControl1.Controls.Add(Me.txtTglVisa)
    Me.LayoutControl1.Controls.Add(Me.txtTglMedicalTerusan)
    Me.LayoutControl1.Controls.Add(Me.txtTglMedicalFull)
    Me.LayoutControl1.Controls.Add(Me.txtTglTiket)
    Me.LayoutControl1.Controls.Add(Me.txtTglRekomPaspor)
    Me.LayoutControl1.Controls.Add(Me.txtTglMedicalPra)
    Me.LayoutControl1.Controls.Add(Me.txtNilai)
    Me.LayoutControl1.Controls.Add(Me.btnTampilkan)
    Me.LayoutControl1.Controls.Add(Me.xGrid)
    Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControl1.Name = "LayoutControl1"
    Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(623, 218, 250, 350)
    Me.LayoutControl1.Root = Me.LayoutControlGroup1
    Me.LayoutControl1.Size = New System.Drawing.Size(743, 421)
    Me.LayoutControl1.TabIndex = 105
    Me.LayoutControl1.Text = "LayoutControl1"
    '
    'txtTglDaftar
    '
    Me.txtTglDaftar.EditValue = Nothing
    Me.txtTglDaftar.Location = New System.Drawing.Point(145, 67)
    Me.txtTglDaftar.Name = "txtTglDaftar"
    Me.txtTglDaftar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglDaftar.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglDaftar.Size = New System.Drawing.Size(180, 20)
    Me.txtTglDaftar.StyleController = Me.LayoutControl1
    Me.txtTglDaftar.TabIndex = 113
    '
    'txtNamaTKI
    '
    Me.txtNamaTKI.Location = New System.Drawing.Point(450, 43)
    Me.txtNamaTKI.Name = "txtNamaTKI"
    Me.txtNamaTKI.Size = New System.Drawing.Size(181, 20)
    Me.txtNamaTKI.StyleController = Me.LayoutControl1
    Me.txtNamaTKI.TabIndex = 112
    '
    'txtKodeTKI
    '
    Me.txtKodeTKI.Location = New System.Drawing.Point(145, 43)
    Me.txtKodeTKI.Name = "txtKodeTKI"
    Me.txtKodeTKI.Size = New System.Drawing.Size(180, 20)
    Me.txtKodeTKI.StyleController = Me.LayoutControl1
    Me.txtKodeTKI.TabIndex = 111
    '
    'txtTglSKCK
    '
    Me.txtTglSKCK.EditValue = Nothing
    Me.txtTglSKCK.Location = New System.Drawing.Point(450, 139)
    Me.txtTglSKCK.Name = "txtTglSKCK"
    Me.txtTglSKCK.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglSKCK.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglSKCK.Size = New System.Drawing.Size(181, 20)
    Me.txtTglSKCK.StyleController = Me.LayoutControl1
    Me.txtTglSKCK.TabIndex = 110
    '
    'txtTglVisa
    '
    Me.txtTglVisa.EditValue = Nothing
    Me.txtTglVisa.Location = New System.Drawing.Point(450, 91)
    Me.txtTglVisa.Name = "txtTglVisa"
    Me.txtTglVisa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglVisa.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglVisa.Size = New System.Drawing.Size(181, 20)
    Me.txtTglVisa.StyleController = Me.LayoutControl1
    Me.txtTglVisa.TabIndex = 109
    '
    'txtTglMedicalTerusan
    '
    Me.txtTglMedicalTerusan.EditValue = Nothing
    Me.txtTglMedicalTerusan.Location = New System.Drawing.Point(145, 139)
    Me.txtTglMedicalTerusan.Name = "txtTglMedicalTerusan"
    Me.txtTglMedicalTerusan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglMedicalTerusan.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglMedicalTerusan.Size = New System.Drawing.Size(180, 20)
    Me.txtTglMedicalTerusan.StyleController = Me.LayoutControl1
    Me.txtTglMedicalTerusan.TabIndex = 108
    '
    'txtTglMedicalFull
    '
    Me.txtTglMedicalFull.EditValue = Nothing
    Me.txtTglMedicalFull.Location = New System.Drawing.Point(145, 115)
    Me.txtTglMedicalFull.Name = "txtTglMedicalFull"
    Me.txtTglMedicalFull.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglMedicalFull.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglMedicalFull.Size = New System.Drawing.Size(180, 20)
    Me.txtTglMedicalFull.StyleController = Me.LayoutControl1
    Me.txtTglMedicalFull.TabIndex = 107
    '
    'txtTglTiket
    '
    Me.txtTglTiket.EditValue = Nothing
    Me.txtTglTiket.Location = New System.Drawing.Point(450, 115)
    Me.txtTglTiket.Name = "txtTglTiket"
    Me.txtTglTiket.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglTiket.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglTiket.Size = New System.Drawing.Size(181, 20)
    Me.txtTglTiket.StyleController = Me.LayoutControl1
    Me.txtTglTiket.TabIndex = 106
    '
    'txtTglRekomPaspor
    '
    Me.txtTglRekomPaspor.EditValue = Nothing
    Me.txtTglRekomPaspor.Location = New System.Drawing.Point(450, 67)
    Me.txtTglRekomPaspor.Name = "txtTglRekomPaspor"
    Me.txtTglRekomPaspor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglRekomPaspor.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglRekomPaspor.Size = New System.Drawing.Size(181, 20)
    Me.txtTglRekomPaspor.StyleController = Me.LayoutControl1
    Me.txtTglRekomPaspor.TabIndex = 105
    '
    'txtTglMedicalPra
    '
    Me.txtTglMedicalPra.EditValue = Nothing
    Me.txtTglMedicalPra.Location = New System.Drawing.Point(145, 91)
    Me.txtTglMedicalPra.Name = "txtTglMedicalPra"
    Me.txtTglMedicalPra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglMedicalPra.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTglMedicalPra.Size = New System.Drawing.Size(180, 20)
    Me.txtTglMedicalPra.StyleController = Me.LayoutControl1
    Me.txtTglMedicalPra.TabIndex = 104
    '
    'txtNilai
    '
    Me.txtNilai.Location = New System.Drawing.Point(133, 389)
    Me.txtNilai.Name = "txtNilai"
    Me.txtNilai.Size = New System.Drawing.Size(598, 20)
    Me.txtNilai.StyleController = Me.LayoutControl1
    Me.txtNilai.TabIndex = 103
    '
    'btnTampilkan
    '
    Me.btnTampilkan.Location = New System.Drawing.Point(635, 137)
    Me.btnTampilkan.Name = "btnTampilkan"
    Me.btnTampilkan.Size = New System.Drawing.Size(84, 22)
    Me.btnTampilkan.StyleController = Me.LayoutControl1
    Me.btnTampilkan.TabIndex = 102
    Me.btnTampilkan.Text = "Tampilkan Data"
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlItem2, Me.LayoutControlItem3})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(743, 421)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "Filter Data"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.EmptySpaceItem1, Me.LayoutControlItem1, Me.LayoutControlItem10})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(723, 163)
    Me.LayoutControlGroup2.Text = "Filter Data"
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.btnTampilkan
    Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
    Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
    Me.LayoutControlItem4.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
    Me.LayoutControlItem4.Location = New System.Drawing.Point(611, 94)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(88, 26)
    Me.LayoutControlItem4.Text = "LayoutControlItem4"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem4.TextToControlDistance = 0
    Me.LayoutControlItem4.TextVisible = False
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtTglMedicalPra
    Me.LayoutControlItem5.CustomizationFormText = "Tanggal Medical Pra"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(305, 24)
    Me.LayoutControlItem5.Text = "Tanggal Medical Pra"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(118, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtTglRekomPaspor
    Me.LayoutControlItem6.CustomizationFormText = "Tanggal Rekom Paspor"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(305, 24)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(306, 24)
    Me.LayoutControlItem6.Text = "Tanggal Rekom Paspor"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(118, 13)
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.txtTglTiket
    Me.LayoutControlItem7.CustomizationFormText = "Tanggal Tiket"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(305, 72)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(306, 24)
    Me.LayoutControlItem7.Text = "Tanggal Tiket"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(118, 13)
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.txtTglMedicalFull
    Me.LayoutControlItem8.CustomizationFormText = "Tanggal Medical Full"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(305, 24)
    Me.LayoutControlItem8.Text = "Tanggal Medical Full"
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(118, 13)
    '
    'LayoutControlItem9
    '
    Me.LayoutControlItem9.Control = Me.txtTglMedicalTerusan
    Me.LayoutControlItem9.CustomizationFormText = "Tanggal Medical Terusan"
    Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 96)
    Me.LayoutControlItem9.Name = "LayoutControlItem9"
    Me.LayoutControlItem9.Size = New System.Drawing.Size(305, 24)
    Me.LayoutControlItem9.Text = "Tanggal Medical Terusan"
    Me.LayoutControlItem9.TextSize = New System.Drawing.Size(118, 13)
    '
    'LayoutControlItem10
    '
    Me.LayoutControlItem10.Control = Me.txtTglVisa
    Me.LayoutControlItem10.CustomizationFormText = "Tanggal Visa"
    Me.LayoutControlItem10.Location = New System.Drawing.Point(305, 48)
    Me.LayoutControlItem10.Name = "LayoutControlItem10"
    Me.LayoutControlItem10.Size = New System.Drawing.Size(306, 24)
    Me.LayoutControlItem10.Text = "Tanggal Visa"
    Me.LayoutControlItem10.TextSize = New System.Drawing.Size(118, 13)
    '
    'LayoutControlItem11
    '
    Me.LayoutControlItem11.Control = Me.txtTglSKCK
    Me.LayoutControlItem11.CustomizationFormText = "Tanggal SKCK"
    Me.LayoutControlItem11.Location = New System.Drawing.Point(305, 96)
    Me.LayoutControlItem11.Name = "LayoutControlItem11"
    Me.LayoutControlItem11.Size = New System.Drawing.Size(306, 24)
    Me.LayoutControlItem11.Text = "Tanggal SKCK"
    Me.LayoutControlItem11.TextSize = New System.Drawing.Size(118, 13)
    '
    'LayoutControlItem12
    '
    Me.LayoutControlItem12.Control = Me.txtKodeTKI
    Me.LayoutControlItem12.CustomizationFormText = "Kode TKI"
    Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem12.Name = "LayoutControlItem12"
    Me.LayoutControlItem12.Size = New System.Drawing.Size(305, 24)
    Me.LayoutControlItem12.Text = "Kode TKI"
    Me.LayoutControlItem12.TextSize = New System.Drawing.Size(118, 13)
    '
    'LayoutControlItem13
    '
    Me.LayoutControlItem13.Control = Me.txtNamaTKI
    Me.LayoutControlItem13.CustomizationFormText = "Nama TKI"
    Me.LayoutControlItem13.Location = New System.Drawing.Point(305, 0)
    Me.LayoutControlItem13.Name = "LayoutControlItem13"
    Me.LayoutControlItem13.Size = New System.Drawing.Size(306, 24)
    Me.LayoutControlItem13.Text = "Nama TKI"
    Me.LayoutControlItem13.TextSize = New System.Drawing.Size(118, 13)
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(611, 0)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(88, 94)
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtTglDaftar
    Me.LayoutControlItem1.CustomizationFormText = "Tanggal Daftar"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(305, 24)
    Me.LayoutControlItem1.Text = "Tanggal Daftar"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(118, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtNilai
    Me.LayoutControlItem2.CustomizationFormText = "Nilai Default"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 377)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(723, 24)
    Me.LayoutControlItem2.Text = "Nilai Default"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(118, 13)
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.xGrid
    Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 163)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(723, 214)
    Me.LayoutControlItem3.Text = "LayoutControlItem3"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem3.TextToControlDistance = 0
    Me.LayoutControlItem3.TextVisible = False
    '
    'LabelControl1
    '
    Me.LabelControl1.Location = New System.Drawing.Point(194, 352)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(19, 13)
    Me.LabelControl1.TabIndex = 104
    Me.LabelControl1.Text = "Nilai"
    '
    'pjp_TransaksiTKIDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(743, 470)
    Me.Controls.Add(Me.LayoutControl1)
    Me.Controls.Add(Me.LabelControl1)
    Me.Name = "pjp_TransaksiTKIDialog"
    Me.Text = "Ambil Nama TKI"
    Me.Controls.SetChildIndex(Me.LabelControl1, 0)
    Me.Controls.SetChildIndex(Me.LayoutControl1, 0)
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpColTKI, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.LayoutControl1.ResumeLayout(False)
    CType(Me.txtTglDaftar.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglDaftar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNamaTKI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKodeTKI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglSKCK.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglSKCK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglVisa.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglVisa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglMedicalTerusan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglMedicalTerusan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglMedicalFull.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglMedicalFull.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglTiket.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglTiket.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglRekomPaspor.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglRekomPaspor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglMedicalPra.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTglMedicalPra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNilai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents xpColTKI As DevExpress.Xpo.XPCollection
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTglDaftar As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnTampilkan As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents txtNilai As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtTglTiket As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtTglRekomPaspor As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtTglMedicalPra As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtTglMedicalTerusan As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtTglMedicalFull As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtTglSKCK As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtTglVisa As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtNamaTKI As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtKodeTKI As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents txtTglDaftar As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colTanggalMedicalPra As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggalMedicalFull As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggalMedicalOnline As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggalPasporPengajuan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggalPasporKeluar As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggalVisa As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggalTicket As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggalBerangkat As DevExpress.XtraGrid.Columns.GridColumn
End Class
