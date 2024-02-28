<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xMesitechVerifikasiJurnal
  Inherits Core.Win.Forms.BlankForm

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
    Me.lytTransaksi = New DevExpress.XtraLayout.LayoutControl()
    Me.gcMain = New DevExpress.XtraGrid.GridControl()
    Me.gcMainView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUraian = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colcreated_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colcreated_user = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnVerifikasi = New DevExpress.XtraEditors.SimpleButton()
    Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
    Me.txtKontak = New DevExpress.XtraEditors.TextEdit()
    Me.txtNoBukti = New DevExpress.XtraEditors.TextEdit()
    Me.gcDetail = New DevExpress.XtraGrid.GridControl()
    Me.gcDetailView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKodeCoa = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaCOA = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDebit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKredit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKurs = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDebitValas = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKreditValas = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
    Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.lytTransaksi.SuspendLayout()
    CType(Me.gcMain, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gcMainView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoBukti.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gcDetail, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.gcDetailView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lytTransaksi
    '
    Me.lytTransaksi.Controls.Add(Me.gcMain)
    Me.lytTransaksi.Controls.Add(Me.btnVerifikasi)
    Me.lytTransaksi.Controls.Add(Me.txtUraian)
    Me.lytTransaksi.Controls.Add(Me.txtKontak)
    Me.lytTransaksi.Controls.Add(Me.txtNoBukti)
    Me.lytTransaksi.Controls.Add(Me.gcDetail)
    Me.lytTransaksi.Controls.Add(Me.txtTanggal)
    Me.lytTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lytTransaksi.Location = New System.Drawing.Point(0, 0)
    Me.lytTransaksi.Name = "lytTransaksi"
    Me.lytTransaksi.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(434, 364, 250, 350)
    Me.lytTransaksi.Root = Me.LayoutControlGroup1
    Me.lytTransaksi.Size = New System.Drawing.Size(759, 395)
    Me.lytTransaksi.TabIndex = 0
    Me.lytTransaksi.Text = "LayoutControl1"
    '
    'gcMain
    '
    Me.gcMain.Location = New System.Drawing.Point(24, 43)
    Me.gcMain.MainView = Me.gcMainView
    Me.gcMain.Name = "gcMain"
    Me.gcMain.Size = New System.Drawing.Size(711, 123)
    Me.gcMain.TabIndex = 13
    Me.gcMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gcMainView})
    '
    'gcMainView
    '
    Me.gcMainView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode, Me.colTanggal, Me.GridColumn1, Me.colUraian, Me.colSaldo, Me.colStatus, Me.colcreated_date, Me.colcreated_user})
    Me.gcMainView.GridControl = Me.gcMain
    Me.gcMainView.Name = "gcMainView"
    Me.gcMainView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
    Me.gcMainView.OptionsBehavior.Editable = False
    Me.gcMainView.OptionsBehavior.ReadOnly = True
    Me.gcMainView.OptionsDetail.EnableMasterViewMode = False
    Me.gcMainView.OptionsView.ShowGroupPanel = False
    Me.gcMainView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTanggal, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colKode, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'colKode
    '
    Me.colKode.Caption = "No Bukti"
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    '
    'colTanggal
    '
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 1
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Kontak"
    Me.GridColumn1.FieldName = "Kontak.Nama"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 2
    '
    'colUraian
    '
    Me.colUraian.Caption = "Uraian"
    Me.colUraian.FieldName = "Uraian"
    Me.colUraian.Name = "colUraian"
    Me.colUraian.Visible = True
    Me.colUraian.VisibleIndex = 3
    '
    'colSaldo
    '
    Me.colSaldo.Caption = "Saldo"
    Me.colSaldo.FieldName = "Saldo"
    Me.colSaldo.Name = "colSaldo"
    Me.colSaldo.Visible = True
    Me.colSaldo.VisibleIndex = 4
    '
    'colStatus
    '
    Me.colStatus.Caption = "Status"
    Me.colStatus.FieldName = "Status"
    Me.colStatus.Name = "colStatus"
    Me.colStatus.Visible = True
    Me.colStatus.VisibleIndex = 5
    '
    'colcreated_date
    '
    Me.colcreated_date.Caption = "Tanggal Input"
    Me.colcreated_date.FieldName = "created_date"
    Me.colcreated_date.Name = "colcreated_date"
    Me.colcreated_date.Visible = True
    Me.colcreated_date.VisibleIndex = 6
    '
    'colcreated_user
    '
    Me.colcreated_user.Caption = "User Input"
    Me.colcreated_user.FieldName = "created_user"
    Me.colcreated_user.Name = "colcreated_user"
    Me.colcreated_user.Visible = True
    Me.colcreated_user.VisibleIndex = 7
    '
    'btnVerifikasi
    '
    Me.btnVerifikasi.Location = New System.Drawing.Point(70, 339)
    Me.btnVerifikasi.Name = "btnVerifikasi"
    Me.btnVerifikasi.Size = New System.Drawing.Size(132, 22)
    Me.btnVerifikasi.StyleController = Me.lytTransaksi
    Me.btnVerifikasi.TabIndex = 11
    Me.btnVerifikasi.Text = "Verifikasi Jurnal"
    '
    'txtUraian
    '
    Me.txtUraian.Location = New System.Drawing.Point(66, 305)
    Me.txtUraian.Name = "txtUraian"
    Me.txtUraian.Size = New System.Drawing.Size(305, 20)
    Me.txtUraian.StyleController = Me.lytTransaksi
    Me.txtUraian.TabIndex = 10
    '
    'txtKontak
    '
    Me.txtKontak.Location = New System.Drawing.Point(66, 281)
    Me.txtKontak.Name = "txtKontak"
    Me.txtKontak.Size = New System.Drawing.Size(305, 20)
    Me.txtKontak.StyleController = Me.lytTransaksi
    Me.txtKontak.TabIndex = 9
    '
    'txtNoBukti
    '
    Me.txtNoBukti.Location = New System.Drawing.Point(66, 233)
    Me.txtNoBukti.Name = "txtNoBukti"
    Me.txtNoBukti.Size = New System.Drawing.Size(305, 20)
    Me.txtNoBukti.StyleController = Me.lytTransaksi
    Me.txtNoBukti.TabIndex = 7
    '
    'gcDetail
    '
    Me.gcDetail.Location = New System.Drawing.Point(402, 249)
    Me.gcDetail.MainView = Me.gcDetailView
    Me.gcDetail.Name = "gcDetail"
    Me.gcDetail.Size = New System.Drawing.Size(333, 122)
    Me.gcDetail.TabIndex = 6
    Me.gcDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gcDetailView})
    '
    'gcDetailView
    '
    Me.gcDetailView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeCoa, Me.colNamaCOA, Me.colDebit, Me.colKredit, Me.colKurs, Me.colDebitValas, Me.colKreditValas, Me.colKeterangan})
    Me.gcDetailView.GridControl = Me.gcDetail
    Me.gcDetailView.Name = "gcDetailView"
    Me.gcDetailView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
    Me.gcDetailView.OptionsBehavior.Editable = False
    Me.gcDetailView.OptionsBehavior.ReadOnly = True
    Me.gcDetailView.OptionsDetail.EnableMasterViewMode = False
    Me.gcDetailView.OptionsView.ShowGroupPanel = False
    Me.gcDetailView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDebitValas, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'colKodeCoa
    '
    Me.colKodeCoa.Caption = "Kode COA"
    Me.colKodeCoa.FieldName = "Akun.Kode"
    Me.colKodeCoa.Name = "colKodeCoa"
    Me.colKodeCoa.Visible = True
    Me.colKodeCoa.VisibleIndex = 0
    '
    'colNamaCOA
    '
    Me.colNamaCOA.Caption = "Nama COA"
    Me.colNamaCOA.FieldName = "Akun.Nama"
    Me.colNamaCOA.Name = "colNamaCOA"
    Me.colNamaCOA.Visible = True
    Me.colNamaCOA.VisibleIndex = 1
    '
    'colDebit
    '
    Me.colDebit.Caption = "Debit"
    Me.colDebit.FieldName = "Debit"
    Me.colDebit.Name = "colDebit"
    Me.colDebit.Visible = True
    Me.colDebit.VisibleIndex = 2
    '
    'colKredit
    '
    Me.colKredit.Caption = "Kredit"
    Me.colKredit.FieldName = "Kredit"
    Me.colKredit.Name = "colKredit"
    Me.colKredit.Visible = True
    Me.colKredit.VisibleIndex = 3
    '
    'colKurs
    '
    Me.colKurs.FieldName = "Kurs"
    Me.colKurs.Name = "colKurs"
    '
    'colDebitValas
    '
    Me.colDebitValas.FieldName = "DebitValas"
    Me.colDebitValas.Name = "colDebitValas"
    '
    'colKreditValas
    '
    Me.colKreditValas.FieldName = "KreditValas"
    Me.colKreditValas.Name = "colKreditValas"
    '
    'colKeterangan
    '
    Me.colKeterangan.Caption = "Catatan"
    Me.colKeterangan.FieldName = "Keterangan"
    Me.colKeterangan.Name = "colKeterangan"
    Me.colKeterangan.Visible = True
    Me.colKeterangan.VisibleIndex = 4
    '
    'txtTanggal
    '
    Me.txtTanggal.EditValue = Nothing
    Me.txtTanggal.Location = New System.Drawing.Point(66, 257)
    Me.txtTanggal.Name = "txtTanggal"
    Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtTanggal.Properties.Mask.EditMask = ""
    Me.txtTanggal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
    Me.txtTanggal.Size = New System.Drawing.Size(305, 20)
    Me.txtTanggal.StyleController = Me.lytTransaksi
    Me.txtTanggal.TabIndex = 8
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.CustomizationFormText = "Root"
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup2, Me.EmptySpaceItem5})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(759, 395)
    Me.LayoutControlGroup1.Text = "Root"
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlGroup3
    '
    Me.LayoutControlGroup3.CustomizationFormText = "Detail Transaksi"
    Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.EmptySpaceItem7})
    Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 190)
    Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
    Me.LayoutControlGroup3.Size = New System.Drawing.Size(739, 185)
    Me.LayoutControlGroup3.Text = "Detail Transaksi"
    '
    'LayoutControlItem3
    '
    Me.LayoutControlItem3.Control = Me.gcDetail
    Me.LayoutControlItem3.CustomizationFormText = "Jurnal"
    Me.LayoutControlItem3.Location = New System.Drawing.Point(378, 0)
    Me.LayoutControlItem3.Name = "LayoutControlItem3"
    Me.LayoutControlItem3.Size = New System.Drawing.Size(337, 142)
    Me.LayoutControlItem3.Text = "Jurnal"
    Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
    Me.LayoutControlItem3.TextSize = New System.Drawing.Size(39, 13)
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.txtNoBukti
    Me.LayoutControlItem1.CustomizationFormText = "No Bukti"
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(351, 24)
    Me.LayoutControlItem1.Text = "No Bukti"
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(39, 13)
    '
    'LayoutControlItem4
    '
    Me.LayoutControlItem4.Control = Me.txtTanggal
    Me.LayoutControlItem4.CustomizationFormText = "Tanggal"
    Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem4.Name = "LayoutControlItem4"
    Me.LayoutControlItem4.Size = New System.Drawing.Size(351, 24)
    Me.LayoutControlItem4.Text = "Tanggal"
    Me.LayoutControlItem4.TextSize = New System.Drawing.Size(39, 13)
    '
    'LayoutControlItem5
    '
    Me.LayoutControlItem5.Control = Me.txtKontak
    Me.LayoutControlItem5.CustomizationFormText = "Kontak"
    Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem5.Name = "LayoutControlItem5"
    Me.LayoutControlItem5.Size = New System.Drawing.Size(351, 24)
    Me.LayoutControlItem5.Text = "Kontak"
    Me.LayoutControlItem5.TextSize = New System.Drawing.Size(39, 13)
    '
    'LayoutControlItem6
    '
    Me.LayoutControlItem6.Control = Me.txtUraian
    Me.LayoutControlItem6.CustomizationFormText = "Uraian"
    Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem6.Name = "LayoutControlItem6"
    Me.LayoutControlItem6.Size = New System.Drawing.Size(351, 24)
    Me.LayoutControlItem6.Text = "Uraian"
    Me.LayoutControlItem6.TextSize = New System.Drawing.Size(39, 13)
    '
    'LayoutControlItem7
    '
    Me.LayoutControlItem7.Control = Me.btnVerifikasi
    Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
    Me.LayoutControlItem7.Location = New System.Drawing.Point(46, 106)
    Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(136, 26)
    Me.LayoutControlItem7.MinSize = New System.Drawing.Size(136, 26)
    Me.LayoutControlItem7.Name = "LayoutControlItem7"
    Me.LayoutControlItem7.Size = New System.Drawing.Size(136, 26)
    Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.LayoutControlItem7.Text = "LayoutControlItem7"
    Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem7.TextToControlDistance = 0
    Me.LayoutControlItem7.TextVisible = False
    '
    'EmptySpaceItem1
    '
    Me.EmptySpaceItem1.AllowHotTrack = False
    Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 96)
    Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
    Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
    Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
    Me.EmptySpaceItem1.Size = New System.Drawing.Size(351, 10)
    Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
    Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem2
    '
    Me.EmptySpaceItem2.AllowHotTrack = False
    Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 132)
    Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
    Me.EmptySpaceItem2.Size = New System.Drawing.Size(351, 10)
    Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
    Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem3
    '
    Me.EmptySpaceItem3.AllowHotTrack = False
    Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 106)
    Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
    Me.EmptySpaceItem3.Size = New System.Drawing.Size(46, 26)
    Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
    Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem4
    '
    Me.EmptySpaceItem4.AllowHotTrack = False
    Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Location = New System.Drawing.Point(351, 0)
    Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
    Me.EmptySpaceItem4.Size = New System.Drawing.Size(27, 142)
    Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
    Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.CustomizationFormText = "Data Transaksi"
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem6, Me.LayoutControlItem8})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(739, 180)
    Me.LayoutControlGroup2.Text = "Data Transaksi"
    '
    'EmptySpaceItem6
    '
    Me.EmptySpaceItem6.AllowHotTrack = False
    Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Location = New System.Drawing.Point(0, 127)
    Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
    Me.EmptySpaceItem6.Size = New System.Drawing.Size(715, 10)
    Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
    Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
    '
    'LayoutControlItem8
    '
    Me.LayoutControlItem8.Control = Me.gcMain
    Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
    Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlItem8.Name = "LayoutControlItem8"
    Me.LayoutControlItem8.Size = New System.Drawing.Size(715, 127)
    Me.LayoutControlItem8.Text = "LayoutControlItem8"
    Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem8.TextToControlDistance = 0
    Me.LayoutControlItem8.TextVisible = False
    '
    'EmptySpaceItem5
    '
    Me.EmptySpaceItem5.AllowHotTrack = False
    Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 180)
    Me.EmptySpaceItem5.MaxSize = New System.Drawing.Size(0, 10)
    Me.EmptySpaceItem5.MinSize = New System.Drawing.Size(10, 10)
    Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
    Me.EmptySpaceItem5.Size = New System.Drawing.Size(739, 10)
    Me.EmptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
    Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
    Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
    '
    'EmptySpaceItem7
    '
    Me.EmptySpaceItem7.AllowHotTrack = False
    Me.EmptySpaceItem7.CustomizationFormText = "EmptySpaceItem7"
    Me.EmptySpaceItem7.Location = New System.Drawing.Point(182, 106)
    Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
    Me.EmptySpaceItem7.Size = New System.Drawing.Size(169, 26)
    Me.EmptySpaceItem7.Text = "EmptySpaceItem7"
    Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
    '
    'xMesitechVerifikasiJurnal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Controls.Add(Me.lytTransaksi)
    Me.Name = "xMesitechVerifikasiJurnal"
    Me.Text = "xMesitechVerifikasiJurnal"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.lytTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
    Me.lytTransaksi.ResumeLayout(False)
    CType(Me.gcMain, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gcMainView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoBukti.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gcDetail, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.gcDetailView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lytTransaksi As DevExpress.XtraLayout.LayoutControl
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents gcDetail As DevExpress.XtraGrid.GridControl
  Friend WithEvents gcDetailView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents btnVerifikasi As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents txtUraian As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtKontak As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtNoBukti As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents gcMain As DevExpress.XtraGrid.GridControl
  Friend WithEvents gcMainView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUraian As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_user As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKodeCoa As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaCOA As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDebit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKredit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKurs As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDebitValas As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKreditValas As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
  Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
End Class
