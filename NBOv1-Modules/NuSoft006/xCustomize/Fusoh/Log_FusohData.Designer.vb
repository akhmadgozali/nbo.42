<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Log_FusohData
    Inherits Core.Win.Forms.BlankForm

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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Log_FusohData))
        Me.xGridViewDetail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNamaProperty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValueLama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValueBaru = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xGrid = New DevExpress.XtraGrid.GridControl()
        Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJenis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTabel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserAgent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserHostAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserHostName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTabelX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnTampilkanData = New DevExpress.XtraEditors.SimpleButton()
        Me.txtKode = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridViewDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xGridViewDetail
        '
        Me.xGridViewDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNamaProperty, Me.colValueLama, Me.colValueBaru})
        Me.xGridViewDetail.GridControl = Me.xGrid
        Me.xGridViewDetail.Name = "xGridViewDetail"
        Me.xGridViewDetail.OptionsBehavior.Editable = False
        Me.xGridViewDetail.OptionsDetail.EnableMasterViewMode = False
        Me.xGridViewDetail.OptionsView.ShowGroupPanel = False
        '
        'colNamaProperty
        '
        Me.colNamaProperty.Caption = "Field"
        Me.colNamaProperty.FieldName = "NamaProperty"
        Me.colNamaProperty.Name = "colNamaProperty"
        Me.colNamaProperty.Visible = True
        Me.colNamaProperty.VisibleIndex = 0
        '
        'colValueLama
        '
        Me.colValueLama.Caption = "Value Lama"
        Me.colValueLama.FieldName = "ValueLama"
        Me.colValueLama.Name = "colValueLama"
        Me.colValueLama.Visible = True
        Me.colValueLama.VisibleIndex = 1
        '
        'colValueBaru
        '
        Me.colValueBaru.Caption = "Value Baru"
        Me.colValueBaru.FieldName = "ValueBaru"
        Me.colValueBaru.Name = "colValueBaru"
        Me.colValueBaru.Visible = True
        Me.colValueBaru.VisibleIndex = 2
        '
        'xGrid
        '
        GridLevelNode1.LevelTemplate = Me.xGridViewDetail
        GridLevelNode1.RelationName = "Detail"
        Me.xGrid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.xGrid.Location = New System.Drawing.Point(12, 38)
        Me.xGrid.MainView = Me.xGridView
        Me.xGrid.Name = "xGrid"
        Me.xGrid.Size = New System.Drawing.Size(1093, 525)
        Me.xGrid.TabIndex = 7
        Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView, Me.xGridViewDetail})
        '
        'xGridView
        '
        Me.xGridView.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xGridView.Appearance.HeaderPanel.Options.UseFont = True
        Me.xGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.xGridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTahun, Me.colBulan, Me.colTanggal, Me.colUser, Me.colJenis, Me.colTabel, Me.colUserAgent, Me.colUserHostAddress, Me.colUserHostName, Me.colTabelX})
        Me.xGridView.GridControl = Me.xGrid
        Me.xGridView.GroupCount = 3
        Me.xGridView.Name = "xGridView"
        Me.xGridView.OptionsBehavior.Editable = False
        Me.xGridView.OptionsView.ShowGroupedColumns = True
        Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTanggal, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colTahun
        '
        Me.colTahun.Caption = "Tahun"
        Me.colTahun.FieldName = "Tahun"
        Me.colTahun.Name = "colTahun"
        '
        'colBulan
        '
        Me.colBulan.Caption = "Bulan"
        Me.colBulan.DisplayFormat.FormatString = "MMMM"
        Me.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBulan.FieldName = "Bulan"
        Me.colBulan.GroupFormat.FormatString = "MMMM"
        Me.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBulan.Name = "colBulan"
        '
        'colTanggal
        '
        Me.colTanggal.Caption = "Tanggal"
        Me.colTanggal.DisplayFormat.FormatString = "dddd, dd MMMM yyyy HH:mm:ss"
        Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTanggal.FieldName = "Tanggal"
        Me.colTanggal.GroupFormat.FormatString = "dddd, dd MMMM yyyy HH:mm:ss"
        Me.colTanggal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTanggal.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value
        Me.colTanggal.Name = "colTanggal"
        Me.colTanggal.Visible = True
        Me.colTanggal.VisibleIndex = 0
        Me.colTanggal.Width = 250
        '
        'colUser
        '
        Me.colUser.Caption = "User"
        Me.colUser.FieldName = "User"
        Me.colUser.Name = "colUser"
        Me.colUser.Visible = True
        Me.colUser.VisibleIndex = 1
        Me.colUser.Width = 250
        '
        'colJenis
        '
        Me.colJenis.AppearanceCell.Options.UseTextOptions = True
        Me.colJenis.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colJenis.Caption = "Jenis"
        Me.colJenis.FieldName = "Jenis"
        Me.colJenis.Name = "colJenis"
        Me.colJenis.Visible = True
        Me.colJenis.VisibleIndex = 2
        Me.colJenis.Width = 70
        '
        'colTabel
        '
        Me.colTabel.AppearanceCell.Options.UseTextOptions = True
        Me.colTabel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTabel.Caption = "Tabel"
        Me.colTabel.FieldName = "colTabel"
        Me.colTabel.Name = "colTabel"
        Me.colTabel.UnboundExpression = "Iif([TableName] == 'm06ddetailquotation', 'Detail' , 'Main')"
        Me.colTabel.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colTabel.Visible = True
        Me.colTabel.VisibleIndex = 3
        Me.colTabel.Width = 70
        '
        'colUserAgent
        '
        Me.colUserAgent.Caption = "User Agent"
        Me.colUserAgent.FieldName = "UserAgent"
        Me.colUserAgent.Name = "colUserAgent"
        Me.colUserAgent.Visible = True
        Me.colUserAgent.VisibleIndex = 4
        Me.colUserAgent.Width = 230
        '
        'colUserHostAddress
        '
        Me.colUserHostAddress.Caption = "Host Address"
        Me.colUserHostAddress.FieldName = "UserHostAddress"
        Me.colUserHostAddress.Name = "colUserHostAddress"
        Me.colUserHostAddress.Visible = True
        Me.colUserHostAddress.VisibleIndex = 5
        Me.colUserHostAddress.Width = 100
        '
        'colUserHostName
        '
        Me.colUserHostName.Caption = "Host Name"
        Me.colUserHostName.FieldName = "UserHostName"
        Me.colUserHostName.Name = "colUserHostName"
        Me.colUserHostName.Visible = True
        Me.colUserHostName.VisibleIndex = 6
        Me.colUserHostName.Width = 105
        '
        'colTabelX
        '
        Me.colTabelX.Caption = "TabelX"
        Me.colTabelX.FieldName = "TableName"
        Me.colTabelX.Name = "colTabelX"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.xGrid)
        Me.LayoutControl1.Controls.Add(Me.btnTampilkanData)
        Me.LayoutControl1.Controls.Add(Me.txtKode)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(803, 466, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1117, 575)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnTampilkanData
        '
        Me.btnTampilkanData.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTampilkanData.Appearance.Options.UseFont = True
        Me.btnTampilkanData.Image = CType(resources.GetObject("btnTampilkanData.Image"), System.Drawing.Image)
        Me.btnTampilkanData.Location = New System.Drawing.Point(275, 12)
        Me.btnTampilkanData.Name = "btnTampilkanData"
        Me.btnTampilkanData.Size = New System.Drawing.Size(146, 22)
        Me.btnTampilkanData.StyleController = Me.LayoutControl1
        Me.btnTampilkanData.TabIndex = 6
        Me.btnTampilkanData.Text = "Tampilkan Data"
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(87, 12)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(184, 20)
        Me.txtKode.StyleController = Me.LayoutControl1
        Me.txtKode.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1117, 575)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtKode
        Me.LayoutControlItem1.CustomizationFormText = "Periode SO"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(50, 25)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(263, 26)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Kode :"
        Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(70, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnTampilkanData
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(263, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(150, 26)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.xGrid
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(1097, 529)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(413, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(684, 26)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'Log_FusohData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 575)
        Me.Controls.Add(Me.LayoutControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Log_FusohData"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UI_FusohDataSOTracking"
        CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridViewDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents btnTampilkanData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTglAkhir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtTglAwal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtKode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTabel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserAgent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserHostAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserHostName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTabelX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xGridViewDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNamaProperty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValueLama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValueBaru As DevExpress.XtraGrid.Columns.GridColumn
End Class
