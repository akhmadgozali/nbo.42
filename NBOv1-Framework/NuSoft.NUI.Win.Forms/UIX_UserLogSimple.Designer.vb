<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UIX_UserLogSimple
    Inherits Core.Win.Forms.GridInput

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
        Me.xGridDetail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProperty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOldValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJenis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAktivitas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserAgent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserHostAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserHostName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.dbRepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.XpServerCollectionSource1 = New DevExpress.Xpo.XPServerCollectionSource(Me.components)
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbRepo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpServerCollectionSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xGrid
        '
        Me.xGrid.DataSource = Me.xpCol
        Me.xGrid.Size = New System.Drawing.Size(765, 374)
        Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridDetail})
        '
        'barMan
        '
        Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarEditItem1})
        Me.barMan.MaxItemId = 11
        Me.barMan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.dbRepo})
        '
        'xGridView
        '
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTanggal, Me.colUser, Me.colJenis, Me.colAktivitas, Me.colUserAgent, Me.colUserHostAddress, Me.colUserHostName, Me.colBulan, Me.colTahun, Me.colId})
        Me.xGridView.GroupCount = 2
        Me.xGridView.OptionsBehavior.Editable = False
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridView.OptionsSelection.MultiSelect = True
        Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTanggal, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'barMenu
        '
        Me.barMenu.OptionsBar.AllowQuickCustomization = False
        Me.barMenu.OptionsBar.DrawDragBorder = False
        Me.barMenu.OptionsBar.UseWholeRow = True
        '
        'xGridDetail
        '
        Me.xGridDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProperty, Me.colOldValue, Me.colNewValue})
        Me.xGridDetail.GridControl = Me.xGrid
        Me.xGridDetail.Name = "xGridDetail"
        Me.xGridDetail.OptionsBehavior.Editable = False
        Me.xGridDetail.OptionsDetail.EnableMasterViewMode = False
        Me.xGridDetail.OptionsView.ShowGroupPanel = False
        '
        'colProperty
        '
        Me.colProperty.Caption = "Nama Field"
        Me.colProperty.FieldName = "NamaProperty"
        Me.colProperty.Name = "colProperty"
        Me.colProperty.Visible = True
        Me.colProperty.VisibleIndex = 0
        '
        'colOldValue
        '
        Me.colOldValue.Caption = "Value Lama"
        Me.colOldValue.FieldName = "ValueLama"
        Me.colOldValue.Name = "colOldValue"
        Me.colOldValue.Visible = True
        Me.colOldValue.VisibleIndex = 1
        '
        'colNewValue
        '
        Me.colNewValue.Caption = "Value Baru"
        Me.colNewValue.FieldName = "ValueBaru"
        Me.colNewValue.Name = "colNewValue"
        Me.colNewValue.Visible = True
        Me.colNewValue.VisibleIndex = 2
        '
        'colTanggal
        '
        Me.colTanggal.DisplayFormat.FormatString = "G"
        Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colTanggal.FieldName = "Tanggal"
        Me.colTanggal.Name = "colTanggal"
        Me.colTanggal.Visible = True
        Me.colTanggal.VisibleIndex = 0
        '
        'colUser
        '
        Me.colUser.FieldName = "User"
        Me.colUser.Name = "colUser"
        Me.colUser.Visible = True
        Me.colUser.VisibleIndex = 1
        '
        'colJenis
        '
        Me.colJenis.FieldName = "Jenis"
        Me.colJenis.Name = "colJenis"
        Me.colJenis.Visible = True
        Me.colJenis.VisibleIndex = 2
        '
        'colAktivitas
        '
        Me.colAktivitas.FieldName = "Aktivitas"
        Me.colAktivitas.Name = "colAktivitas"
        Me.colAktivitas.Visible = True
        Me.colAktivitas.VisibleIndex = 3
        '
        'colUserAgent
        '
        Me.colUserAgent.FieldName = "UserAgent"
        Me.colUserAgent.Name = "colUserAgent"
        Me.colUserAgent.Visible = True
        Me.colUserAgent.VisibleIndex = 4
        '
        'colUserHostAddress
        '
        Me.colUserHostAddress.FieldName = "UserHostAddress"
        Me.colUserHostAddress.Name = "colUserHostAddress"
        Me.colUserHostAddress.Visible = True
        Me.colUserHostAddress.VisibleIndex = 5
        '
        'colUserHostName
        '
        Me.colUserHostName.FieldName = "UserHostName"
        Me.colUserHostName.Name = "colUserHostName"
        Me.colUserHostName.Visible = True
        Me.colUserHostName.VisibleIndex = 6
        '
        'colBulan
        '
        Me.colBulan.FieldName = "Bulan"
        Me.colBulan.GroupFormat.FormatString = "MMMM"
        Me.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBulan.Name = "colBulan"
        Me.colBulan.OptionsColumn.ReadOnly = True
        Me.colBulan.Visible = True
        Me.colBulan.VisibleIndex = 8
        '
        'colTahun
        '
        Me.colTahun.Caption = "Tahun"
        Me.colTahun.FieldName = "Tanggal"
        Me.colTahun.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateYear
        Me.colTahun.Name = "colTahun"
        Me.colTahun.Visible = True
        Me.colTahun.VisibleIndex = 9
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.BarStaticItem1.Caption = "Database : "
        Me.BarStaticItem1.Id = 9
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "<Pilih Database>"
        Me.BarEditItem1.Edit = Me.dbRepo
        Me.BarEditItem1.Id = 10
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.Width = 150
        '
        'dbRepo
        '
        Me.dbRepo.AutoHeight = False
        Me.dbRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dbRepo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NamaAlias", "Nama")})
        Me.dbRepo.DisplayMember = "NamaAlias"
        Me.dbRepo.Name = "dbRepo"
        Me.dbRepo.NullText = "<Pilih Database>"
        Me.dbRepo.ShowHeader = False
        Me.dbRepo.ValueMember = "NamaDatabase"
        '
        'XpServerCollectionSource1
        '
        Me.XpServerCollectionSource1.ObjectType = GetType(NuSoft.NPO.SimpleLog)
        '
        'colId
        '
        Me.colId.Caption = "Id"
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'UIX_UserLogSimple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 401)
        Me.Name = "UIX_UserLogSimple"
        Me.Text = "User Log"
        Me.xpCol = Me.xpCol
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbRepo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpServerCollectionSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAktivitas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserAgent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserHostAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserHostName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents dbRepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents XpServerCollectionSource1 As DevExpress.Xpo.XPServerCollectionSource
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xGridDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProperty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOldValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNewValue As DevExpress.XtraGrid.Columns.GridColumn
End Class
