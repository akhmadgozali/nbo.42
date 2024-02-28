<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Anggaran
  Inherits Core.Win.Forms.GridInput

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
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan01 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan02 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan03 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan04 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan05 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan06 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan07 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan08 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan09 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan11 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan12 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.DataSource = Me.xpCol
    '
    'xpCol
    '
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Anggaran)
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1})
    Me.barMan.MaxItemId = 14
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTahun, Me.GridColumn1, Me.GridColumn2, Me.colBulan01, Me.colBulan02, Me.colBulan03, Me.colBulan04, Me.colBulan05, Me.colBulan06, Me.colBulan07, Me.colBulan08, Me.colBulan09, Me.colBulan10, Me.colBulan11, Me.colBulan12})
    Me.xGridView.GroupCount = 1
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.OptionsView.ColumnAutoWidth = False
    Me.xGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'barMenu
    '
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'colId
    '
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    '
    'colTahun
    '
    Me.colTahun.Caption = "Tahun"
    Me.colTahun.FieldName = "Tahun"
    Me.colTahun.Name = "colTahun"
    Me.colTahun.Visible = True
    Me.colTahun.VisibleIndex = 0
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Kode COA"
    Me.GridColumn1.FieldName = "Akun.Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    Me.GridColumn1.Width = 109
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Nama COA"
    Me.GridColumn2.FieldName = "Akun.Nama"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.OptionsColumn.AllowEdit = False
    Me.GridColumn2.OptionsColumn.ReadOnly = True
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    Me.GridColumn2.Width = 248
    '
    'colBulan01
    '
    Me.colBulan01.Caption = "Januari"
    Me.colBulan01.FieldName = "Bulan01"
    Me.colBulan01.Name = "colBulan01"
    Me.colBulan01.Visible = True
    Me.colBulan01.VisibleIndex = 2
    '
    'colBulan02
    '
    Me.colBulan02.Caption = "Februari"
    Me.colBulan02.FieldName = "Bulan02"
    Me.colBulan02.Name = "colBulan02"
    Me.colBulan02.Visible = True
    Me.colBulan02.VisibleIndex = 3
    '
    'colBulan03
    '
    Me.colBulan03.Caption = "Maret"
    Me.colBulan03.FieldName = "Bulan03"
    Me.colBulan03.Name = "colBulan03"
    Me.colBulan03.Visible = True
    Me.colBulan03.VisibleIndex = 4
    '
    'colBulan04
    '
    Me.colBulan04.Caption = "April"
    Me.colBulan04.FieldName = "Bulan04"
    Me.colBulan04.Name = "colBulan04"
    Me.colBulan04.Visible = True
    Me.colBulan04.VisibleIndex = 5
    '
    'colBulan05
    '
    Me.colBulan05.Caption = "Mei"
    Me.colBulan05.FieldName = "Bulan05"
    Me.colBulan05.Name = "colBulan05"
    Me.colBulan05.Visible = True
    Me.colBulan05.VisibleIndex = 6
    '
    'colBulan06
    '
    Me.colBulan06.Caption = "Juni"
    Me.colBulan06.FieldName = "Bulan06"
    Me.colBulan06.Name = "colBulan06"
    Me.colBulan06.Visible = True
    Me.colBulan06.VisibleIndex = 7
    '
    'colBulan07
    '
    Me.colBulan07.Caption = "Juli"
    Me.colBulan07.FieldName = "Bulan07"
    Me.colBulan07.Name = "colBulan07"
    Me.colBulan07.Visible = True
    Me.colBulan07.VisibleIndex = 8
    '
    'colBulan08
    '
    Me.colBulan08.Caption = "Agustus"
    Me.colBulan08.FieldName = "Bulan08"
    Me.colBulan08.Name = "colBulan08"
    Me.colBulan08.Visible = True
    Me.colBulan08.VisibleIndex = 9
    '
    'colBulan09
    '
    Me.colBulan09.Caption = "September"
    Me.colBulan09.FieldName = "Bulan09"
    Me.colBulan09.Name = "colBulan09"
    Me.colBulan09.Visible = True
    Me.colBulan09.VisibleIndex = 10
    '
    'colBulan10
    '
    Me.colBulan10.Caption = "Oktober"
    Me.colBulan10.FieldName = "Bulan10"
    Me.colBulan10.Name = "colBulan10"
    Me.colBulan10.Visible = True
    Me.colBulan10.VisibleIndex = 11
    '
    'colBulan11
    '
    Me.colBulan11.Caption = "November"
    Me.colBulan11.FieldName = "Bulan11"
    Me.colBulan11.Name = "colBulan11"
    Me.colBulan11.Visible = True
    Me.colBulan11.VisibleIndex = 12
    '
    'colBulan12
    '
    Me.colBulan12.Caption = "Desember"
    Me.colBulan12.FieldName = "Bulan12"
    Me.colBulan12.Name = "colBulan12"
    Me.colBulan12.Visible = True
    Me.colBulan12.VisibleIndex = 13
    '
    'BarButtonItem1
    '
    Me.BarButtonItem1.Caption = "Create"
    Me.BarButtonItem1.Id = 13
    Me.BarButtonItem1.Name = "BarButtonItem1"
    '
    'UI_Anggaran
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Name = "UI_Anggaran"
    Me.Text = "Master Anggaran"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan01 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan02 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan03 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan04 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan05 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan06 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan07 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan08 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan09 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan10 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan11 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan12 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
End Class
