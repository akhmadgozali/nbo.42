<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zWoojin_Brankas
  Inherits Core.Win.Forms.GridBinding

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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(zWoojin_Brankas))
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
    Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
    Me.colN1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN11 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN12 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN13 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN14 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN15 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN16 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN17 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN18 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN19 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN20 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN21 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN22 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN23 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN24 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colN25 = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.DataSource = Me.xpCol
    Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
    Me.xGrid.Size = New System.Drawing.Size(765, 374)
    '
    'xpCol
    '
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.zWoojinBrankas)
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSaveLayout})
    Me.barMan.MaxItemId = 7
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTanggal, Me.colKeterangan, Me.colN1, Me.colN2, Me.colN3, Me.colN4, Me.colN5, Me.colN6, Me.colN7, Me.colN8, Me.colN9, Me.colN10, Me.colN11, Me.colN12, Me.colN13, Me.colN14, Me.colN15, Me.colN16, Me.colN17, Me.colN18, Me.colN19, Me.colN20, Me.colN21, Me.colN22, Me.colN23, Me.colN24, Me.colN25})
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.ColumnAutoWidth = False
    Me.xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSaveLayout, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'colId
    '
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    '
    'colTanggal
    '
    Me.colTanggal.ColumnEdit = Me.RepositoryItemDateEdit1
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 0
    '
    'RepositoryItemDateEdit1
    '
    Me.RepositoryItemDateEdit1.AutoHeight = False
    Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
    '
    'colKeterangan
    '
    Me.colKeterangan.FieldName = "Keterangan"
    Me.colKeterangan.Name = "colKeterangan"
    Me.colKeterangan.Visible = True
    Me.colKeterangan.VisibleIndex = 1
    '
    'btnSaveLayout
    '
    Me.btnSaveLayout.Caption = "Save Layout"
    Me.btnSaveLayout.Glyph = CType(resources.GetObject("btnSaveLayout.Glyph"), System.Drawing.Image)
    Me.btnSaveLayout.Id = 6
    Me.btnSaveLayout.LargeGlyph = CType(resources.GetObject("btnSaveLayout.LargeGlyph"), System.Drawing.Image)
    Me.btnSaveLayout.Name = "btnSaveLayout"
    '
    'colN1
    '
    Me.colN1.FieldName = "N1"
    Me.colN1.Name = "colN1"
    Me.colN1.Visible = True
    Me.colN1.VisibleIndex = 2
    '
    'colN2
    '
    Me.colN2.FieldName = "N2"
    Me.colN2.Name = "colN2"
    Me.colN2.Visible = True
    Me.colN2.VisibleIndex = 3
    '
    'colN3
    '
    Me.colN3.FieldName = "N3"
    Me.colN3.Name = "colN3"
    Me.colN3.Visible = True
    Me.colN3.VisibleIndex = 4
    '
    'colN4
    '
    Me.colN4.FieldName = "N4"
    Me.colN4.Name = "colN4"
    Me.colN4.Visible = True
    Me.colN4.VisibleIndex = 5
    '
    'colN5
    '
    Me.colN5.FieldName = "N5"
    Me.colN5.Name = "colN5"
    Me.colN5.Visible = True
    Me.colN5.VisibleIndex = 6
    '
    'colN6
    '
    Me.colN6.FieldName = "N6"
    Me.colN6.Name = "colN6"
    Me.colN6.Visible = True
    Me.colN6.VisibleIndex = 7
    '
    'colN7
    '
    Me.colN7.FieldName = "N7"
    Me.colN7.Name = "colN7"
    Me.colN7.Visible = True
    Me.colN7.VisibleIndex = 8
    '
    'colN8
    '
    Me.colN8.FieldName = "N8"
    Me.colN8.Name = "colN8"
    Me.colN8.Visible = True
    Me.colN8.VisibleIndex = 9
    '
    'colN9
    '
    Me.colN9.FieldName = "N9"
    Me.colN9.Name = "colN9"
    Me.colN9.Visible = True
    Me.colN9.VisibleIndex = 10
    '
    'colN10
    '
    Me.colN10.FieldName = "N10"
    Me.colN10.Name = "colN10"
    Me.colN10.Visible = True
    Me.colN10.VisibleIndex = 11
    '
    'colN11
    '
    Me.colN11.FieldName = "N11"
    Me.colN11.Name = "colN11"
    Me.colN11.Visible = True
    Me.colN11.VisibleIndex = 12
    '
    'colN12
    '
    Me.colN12.FieldName = "N12"
    Me.colN12.Name = "colN12"
    Me.colN12.Visible = True
    Me.colN12.VisibleIndex = 13
    '
    'colN13
    '
    Me.colN13.FieldName = "N13"
    Me.colN13.Name = "colN13"
    Me.colN13.Visible = True
    Me.colN13.VisibleIndex = 14
    '
    'colN14
    '
    Me.colN14.FieldName = "N14"
    Me.colN14.Name = "colN14"
    Me.colN14.Visible = True
    Me.colN14.VisibleIndex = 15
    '
    'colN15
    '
    Me.colN15.FieldName = "N15"
    Me.colN15.Name = "colN15"
    Me.colN15.Visible = True
    Me.colN15.VisibleIndex = 16
    '
    'colN16
    '
    Me.colN16.FieldName = "N16"
    Me.colN16.Name = "colN16"
    Me.colN16.Visible = True
    Me.colN16.VisibleIndex = 17
    '
    'colN17
    '
    Me.colN17.FieldName = "N17"
    Me.colN17.Name = "colN17"
    Me.colN17.Visible = True
    Me.colN17.VisibleIndex = 18
    '
    'colN18
    '
    Me.colN18.FieldName = "N18"
    Me.colN18.Name = "colN18"
    Me.colN18.Visible = True
    Me.colN18.VisibleIndex = 19
    '
    'colN19
    '
    Me.colN19.FieldName = "N19"
    Me.colN19.Name = "colN19"
    Me.colN19.Visible = True
    Me.colN19.VisibleIndex = 20
    '
    'colN20
    '
    Me.colN20.FieldName = "N20"
    Me.colN20.Name = "colN20"
    Me.colN20.Visible = True
    Me.colN20.VisibleIndex = 21
    '
    'colN21
    '
    Me.colN21.FieldName = "N21"
    Me.colN21.Name = "colN21"
    Me.colN21.Visible = True
    Me.colN21.VisibleIndex = 22
    '
    'colN22
    '
    Me.colN22.FieldName = "N22"
    Me.colN22.Name = "colN22"
    Me.colN22.Visible = True
    Me.colN22.VisibleIndex = 23
    '
    'colN23
    '
    Me.colN23.FieldName = "N23"
    Me.colN23.Name = "colN23"
    Me.colN23.Visible = True
    Me.colN23.VisibleIndex = 24
    '
    'colN24
    '
    Me.colN24.FieldName = "N24"
    Me.colN24.Name = "colN24"
    Me.colN24.Visible = True
    Me.colN24.VisibleIndex = 25
    '
    'colN25
    '
    Me.colN25.FieldName = "N25"
    Me.colN25.Name = "colN25"
    Me.colN25.Visible = True
    Me.colN25.VisibleIndex = 26
    '
    'zWoojin_Brankas
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(765, 401)
    Me.Name = "zWoojin_Brankas"
    Me.Text = "Daftar Brankas"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
  Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents colN1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN7 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN8 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN9 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN11 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN13 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN14 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN15 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN16 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN17 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN18 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN19 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN20 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN21 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN22 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN23 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN24 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colN25 As DevExpress.XtraGrid.Columns.GridColumn
End Class
