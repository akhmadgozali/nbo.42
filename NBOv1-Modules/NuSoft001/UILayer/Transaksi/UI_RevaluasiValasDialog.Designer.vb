<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_RevaluasiValasDialog
  Inherits NuSoft.Core.Win.Forms.InputDialog

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
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.lytRv = New DevExpress.XtraLayout.LayoutControl()
    Me.xGridDetail = New DevExpress.XtraGrid.GridControl()
    Me.xGridDetailView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colCOA = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.coLCOANamax = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontak = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNilaiValas = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNilaiFungsional = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNilaiKurs = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNilaiSelisih = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtRegional = New DevExpress.XtraEditors.LookUpEdit()
    Me.xGridCoa = New DevExpress.XtraGrid.GridControl()
    Me.xGridCoaView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colCoaKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCoaNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.xGridUang = New DevExpress.XtraGrid.GridControl()
    Me.xGridUangView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKurs = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtKontak = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtAkun = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
    Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.lytGrid = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytRv, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytRv.SuspendLayout()
    CType(Me.xGridDetail, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridDetailView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridCoa, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridCoaView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridUang, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridUangView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtAkun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'session
    '
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(426, 37)
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.DisplayFormat.FormatString = "D"
    Me.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.txtTanggal.Size = New System.Drawing.Size(191, 20)
    Me.txtTanggal.StyleController = Me.lytRv
    Me.txtTanggal.TabIndex = 1
    '
    'lytRv
    '
    Me.lytRv.Controls.Add(Me.xGridDetail)
    Me.lytRv.Controls.Add(Me.txtRegional)
    Me.lytRv.Controls.Add(Me.xGridCoa)
    Me.lytRv.Controls.Add(Me.xGridUang)
    Me.lytRv.Controls.Add(Me.txtTanggal)
    Me.lytRv.Controls.Add(Me.txtKontak)
    Me.lytRv.Controls.Add(Me.txtAkun)
    Me.lytRv.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytRv.Location = New System.Drawing.Point(0, 0)
    Me.lytRv.Name = "lytRv"
    Me.lytRv.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(521, 61, 388, 350)
    Me.lytRv.Root = Me.LayoutControlGroup1
    Me.lytRv.Size = New System.Drawing.Size(635, 387)
    Me.lytRv.TabIndex = 105
    Me.lytRv.Text = "LayoutControl1"
    '
    'xGridDetail
    '
    Me.xGridDetail.Location = New System.Drawing.Point(24, 159)
    Me.xGridDetail.MainView = Me.xGridDetailView
    Me.xGridDetail.Name = "xGridDetail"
    Me.xGridDetail.Size = New System.Drawing.Size(587, 204)
    Me.xGridDetail.TabIndex = 107
    Me.xGridDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridDetailView})
    '
    'xGridDetailView
    '
    Me.xGridDetailView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCOA, Me.coLCOANamax, Me.colKontak, Me.colNilaiValas, Me.colNilaiFungsional, Me.colNilaiKurs, Me.colNilaiSelisih})
    Me.xGridDetailView.GridControl = Me.xGridDetail
    Me.xGridDetailView.Name = "xGridDetailView"
    Me.xGridDetailView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridDetailView.OptionsView.ColumnAutoWidth = False
    Me.xGridDetailView.OptionsView.ShowGroupPanel = False
    '
    'colCOA
    '
    Me.colCOA.Caption = "COA"
    Me.colCOA.FieldName = "Coa.Kode"
    Me.colCOA.Name = "colCOA"
    Me.colCOA.Visible = True
    Me.colCOA.VisibleIndex = 0
    '
    'coLCOANamax
    '
    Me.coLCOANamax.Caption = "COA Nama"
    Me.coLCOANamax.FieldName = "Coa.Nama"
    Me.coLCOANamax.Name = "coLCOANamax"
    '
    'colKontak
    '
    Me.colKontak.Caption = "Kontak"
    Me.colKontak.FieldName = "Kontak.Nama"
    Me.colKontak.Name = "colKontak"
    Me.colKontak.Visible = True
    Me.colKontak.VisibleIndex = 1
    '
    'colNilaiValas
    '
    Me.colNilaiValas.Caption = "Nilai Valas"
    Me.colNilaiValas.FieldName = "NilaiValas"
    Me.colNilaiValas.Name = "colNilaiValas"
    Me.colNilaiValas.Visible = True
    Me.colNilaiValas.VisibleIndex = 2
    '
    'colNilaiFungsional
    '
    Me.colNilaiFungsional.Caption = "Nilai Fungsional"
    Me.colNilaiFungsional.FieldName = "NilaiFungsional"
    Me.colNilaiFungsional.Name = "colNilaiFungsional"
    Me.colNilaiFungsional.Visible = True
    Me.colNilaiFungsional.VisibleIndex = 3
    '
    'colNilaiKurs
    '
    Me.colNilaiKurs.Caption = "Kurs"
    Me.colNilaiKurs.FieldName = "NilaiKurs"
    Me.colNilaiKurs.Name = "colNilaiKurs"
    Me.colNilaiKurs.Visible = True
    Me.colNilaiKurs.VisibleIndex = 4
    '
    'colNilaiSelisih
    '
    Me.colNilaiSelisih.Caption = "Selisih"
    Me.colNilaiSelisih.FieldName = "NilaiSelisih"
    Me.colNilaiSelisih.Name = "colNilaiSelisih"
    Me.colNilaiSelisih.OptionsColumn.ReadOnly = True
    Me.colNilaiSelisih.Visible = True
    Me.colNilaiSelisih.VisibleIndex = 5
    '
    'txtRegional
    '
    Me.txtRegional.Location = New System.Drawing.Point(96, 61)
    Me.txtRegional.Name = "txtRegional"
    Me.txtRegional.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtRegional.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtRegional.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
    Me.txtRegional.Properties.DisplayMember = "Kode"
    Me.txtRegional.Properties.NullText = "<Pilih Regional>"
    Me.txtRegional.Properties.ValueMember = "This"
    Me.txtRegional.Size = New System.Drawing.Size(521, 20)
    Me.txtRegional.StyleController = Me.lytRv
    Me.txtRegional.TabIndex = 106
    '
    'xGridCoa
    '
    Me.xGridCoa.Location = New System.Drawing.Point(24, 159)
    Me.xGridCoa.MainView = Me.xGridCoaView
    Me.xGridCoa.Name = "xGridCoa"
    Me.xGridCoa.Size = New System.Drawing.Size(587, 204)
    Me.xGridCoa.TabIndex = 104
    Me.xGridCoa.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridCoaView})
    '
    'xGridCoaView
    '
    Me.xGridCoaView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCoaKode, Me.colCoaNama})
    Me.xGridCoaView.GridControl = Me.xGridCoa
    Me.xGridCoaView.Name = "xGridCoaView"
    Me.xGridCoaView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridCoaView.OptionsView.ShowGroupPanel = False
    '
    'colCoaKode
    '
    Me.colCoaKode.Caption = "Kode"
    Me.colCoaKode.FieldName = "Coa.Kode"
    Me.colCoaKode.Name = "colCoaKode"
    Me.colCoaKode.OptionsColumn.AllowEdit = False
    Me.colCoaKode.OptionsColumn.ReadOnly = True
    Me.colCoaKode.Visible = True
    Me.colCoaKode.VisibleIndex = 0
    Me.colCoaKode.Width = 55
    '
    'colCoaNama
    '
    Me.colCoaNama.Caption = "Nama"
    Me.colCoaNama.FieldName = "Coa.Nama"
    Me.colCoaNama.Name = "colCoaNama"
    Me.colCoaNama.OptionsColumn.AllowEdit = False
    Me.colCoaNama.OptionsColumn.ReadOnly = True
    Me.colCoaNama.Visible = True
    Me.colCoaNama.VisibleIndex = 1
    Me.colCoaNama.Width = 119
    '
    'xGridUang
    '
    Me.xGridUang.Location = New System.Drawing.Point(24, 159)
    Me.xGridUang.MainView = Me.xGridUangView
    Me.xGridUang.Name = "xGridUang"
    Me.xGridUang.Size = New System.Drawing.Size(587, 204)
    Me.xGridUang.TabIndex = 103
    Me.xGridUang.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridUangView})
    '
    'xGridUangView
    '
    Me.xGridUangView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode, Me.colNama, Me.colKurs})
    Me.xGridUangView.GridControl = Me.xGridUang
    Me.xGridUangView.Name = "xGridUangView"
    Me.xGridUangView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridUangView.OptionsView.ShowGroupPanel = False
    '
    'colKode
    '
    Me.colKode.Caption = "Kode"
    Me.colKode.FieldName = "Uang.Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.OptionsColumn.AllowEdit = False
    Me.colKode.OptionsColumn.ReadOnly = True
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    Me.colKode.Width = 55
    '
    'colNama
    '
    Me.colNama.Caption = "Nama"
    Me.colNama.FieldName = "Uang.Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.OptionsColumn.AllowEdit = False
    Me.colNama.OptionsColumn.ReadOnly = True
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 1
    Me.colNama.Width = 119
    '
    'colKurs
    '
    Me.colKurs.Caption = "Kurs"
    Me.colKurs.FieldName = "Kurs"
    Me.colKurs.Name = "colKurs"
    Me.colKurs.Visible = True
    Me.colKurs.VisibleIndex = 2
    Me.colKurs.Width = 79
    '
    'txtKontak
    '
    Me.txtKontak.EditValue = "<Pilih Kontak>"
    Me.txtKontak.Location = New System.Drawing.Point(96, 37)
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtKontak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtKontak.Properties.DisplayMember = "Kode"
    Me.txtKontak.Properties.NullText = "<Pilih Kontak>"
    Me.txtKontak.Properties.ShowClearButton = False
    Me.txtKontak.Properties.ShowFooter = False
    Me.txtKontak.Properties.ValueMember = "This"
    Me.txtKontak.Properties.View = Me.SearchLookUpEdit1View
    Me.txtKontak.Size = New System.Drawing.Size(248, 20)
    Me.txtKontak.StyleController = Me.lytRv
    Me.txtKontak.TabIndex = 105
    '
    'SearchLookUpEdit1View
    '
    Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKontakKode, Me.colKontakNama})
    Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
    Me.SearchLookUpEdit1View.OptionsFind.FindDelay = 500
    Me.SearchLookUpEdit1View.OptionsFind.SearchInPreview = True
    Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
    Me.SearchLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colKontakKode, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'colKontakKode
    '
    Me.colKontakKode.Caption = "Kode"
    Me.colKontakKode.FieldName = "Kode"
    Me.colKontakKode.Name = "colKontakKode"
    Me.colKontakKode.Visible = True
    Me.colKontakKode.VisibleIndex = 0
    Me.colKontakKode.Width = 355
    '
    'colKontakNama
    '
    Me.colKontakNama.Caption = "Nama"
    Me.colKontakNama.FieldName = "Nama"
    Me.colKontakNama.Name = "colKontakNama"
    Me.colKontakNama.Visible = True
    Me.colKontakNama.VisibleIndex = 1
    Me.colKontakNama.Width = 723
    '
    'txtAkun
    '
    Me.txtAkun.Location = New System.Drawing.Point(96, 85)
    Me.txtAkun.Name = "txtAkun"
    Me.txtAkun.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    Me.txtAkun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtAkun.Properties.DisplayMember = "Kode"
    Me.txtAkun.Properties.NullText = "<Pilih Coa>"
    Me.txtAkun.Properties.ValueMember = "This"
    Me.txtAkun.Properties.View = Me.GridView1
    Me.txtAkun.Size = New System.Drawing.Size(521, 20)
    Me.txtAkun.StyleController = Me.lytRv
    Me.txtAkun.TabIndex = 0
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcKode, Me.gcNama})
    Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsFind.AlwaysVisible = True
    Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView1.OptionsView.ShowGroupPanel = False
    Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcKode, DevExpress.Data.ColumnSortOrder.Ascending)})
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
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.TabbedControlGroup1})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(635, 387)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "Filter"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem6, Me.LayoutControlItem5})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(615, 113)
    Me.LayoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 10)
    Me.LayoutControlGroup2.Text = "Data Utama"
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtAkun
    Me.LayoutControlItem1.CustomizationFormText = "Coa Selisih Kurs"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(603, 24)
    Me.LayoutControlItem1.Text = "Coa Selisih Kurs"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(75, 13)
    '
    'LayoutControlItem2
    '
    Me.LayoutControlItem2.Control = Me.txtTanggal
    Me.LayoutControlItem2.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem2.Location = New System.Drawing.Point(330, 0)
    Me.LayoutControlItem2.Name = "LayoutControlItem2"
    Me.LayoutControlItem2.Size = New System.Drawing.Size(273, 24)
    Me.LayoutControlItem2.Text = "Tanggal"
    Me.LayoutControlItem2.TextSize = New System.Drawing.Size(75, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtRegional
    Me.LayoutControlItem6.CustomizationFormText = "Regional"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(603, 24)
    Me.LayoutControlItem6.Text = "Regional"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(75, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtKontak
    Me.LayoutControlItem5.CustomizationFormText = "Kontak"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(330, 24)
    Me.LayoutControlItem5.Text = "Kontak"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(75, 13)
    '
    'TabbedControlGroup1
    '
    Me.TabbedControlGroup1.CustomizationFormText = "TabbedControlGroup1"
    Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 113)
    Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
    Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup3
    Me.TabbedControlGroup1.SelectedTabPageIndex = 0
    Me.TabbedControlGroup1.Size = New System.Drawing.Size(615, 254)
    Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlGroup5})
    Me.TabbedControlGroup1.Text = "TabbedControlGroup1"
    '
    'LayoutControlGroup3
    '
    Me.LayoutControlGroup3.CustomizationFormText = "Nilai Kurs"
    Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3})
    Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
    Me.LayoutControlGroup3.Size = New System.Drawing.Size(591, 208)
    Me.LayoutControlGroup3.Text = "Nilai Kurs"
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.xGridUang
    Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(591, 208)
    Me.LayoutControlItem3.Text = "LayoutControlItem3"
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem3.TextToControlDistance = 0
    Me.LayoutControlItem3.TextVisible = False
    '
    'LayoutControlGroup4
    '
    Me.LayoutControlGroup4.CustomizationFormText = "COA"
    Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4})
    Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
    Me.LayoutControlGroup4.Size = New System.Drawing.Size(591, 208)
    Me.LayoutControlGroup4.Text = "COA"
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.xGridCoa
    Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(591, 208)
    Me.LayoutControlItem4.Text = "LayoutControlItem4"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem4.TextToControlDistance = 0
    Me.LayoutControlItem4.TextVisible = False
    '
    'LayoutControlGroup5
    '
    Me.LayoutControlGroup5.CustomizationFormText = "Detail"
    Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lytGrid})
    Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
    Me.LayoutControlGroup5.Size = New System.Drawing.Size(591, 208)
    Me.LayoutControlGroup5.Text = "Detail"
    '
    'lytGrid
    '
    Me.lytGrid.Control = Me.xGridDetail
    Me.lytGrid.CustomizationFormText = "LayoutControlItem7"
    Me.lytGrid.Location = New System.Drawing.Point(0, 0)
    Me.lytGrid.Name = "lytGrid"
    Me.lytGrid.Size = New System.Drawing.Size(591, 208)
    Me.lytGrid.Text = "lytGrid"
    Me.lytGrid.TextSize = New System.Drawing.Size(0, 0)
    Me.lytGrid.TextToControlDistance = 0
    Me.lytGrid.TextVisible = False
    '
    'UI_RevaluasiValasDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(635, 436)
    Me.Controls.Add(Me.lytRv)
    Me.Name = "UI_RevaluasiValasDialog"
    Me.Text = "Revaluasi Valuta Asing"
    Me.Controls.SetChildIndex(Me.lytRv, 0)
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytRv, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytRv.ResumeLayout(False)
    CType(Me.xGridDetail, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridDetailView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtRegional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridCoa, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridCoaView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridUang, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridUangView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtAkun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytGrid, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents xGridUang As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridUangView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKurs As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents xGridCoa As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridCoaView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colCoaKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCoaNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents lytRv As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents txtKontak As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtAkun As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtRegional As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents xGridDetail As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridDetailView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents lytGrid As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents colCOA As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontak As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilaiValas As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilaiFungsional As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilaiKurs As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilaiSelisih As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents coLCOANamax As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
  Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
End Class
