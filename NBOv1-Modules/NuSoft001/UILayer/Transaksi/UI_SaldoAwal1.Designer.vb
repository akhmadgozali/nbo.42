<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_SaldoAwal1
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_SaldoAwal1))
    Me.colNoTrans = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKodeCoa = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaCoa = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontak = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colDebit = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKurs = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.xGrid.DataSource = Me.ifSource
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.GridColumn1, Me.colNoTrans, Me.colKodeCoa, Me.colNamaCoa, Me.colKontak, Me.colDebit, Me.colKurs})
    Me.xGridView.GroupCount = 1
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'ifSource
    '
    Me.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties")
    Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.GlMain)
    '
    'barMenu
    '
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'colNoTrans
    '
    Me.colNoTrans.Caption = "No Transaksi"
    Me.colNoTrans.FieldName = "Kode"
    Me.colNoTrans.Name = "colNoTrans"
    Me.colNoTrans.Visible = True
    Me.colNoTrans.VisibleIndex = 0
    '
    'colKodeCoa
    '
    Me.colKodeCoa.Caption = "Kode COA"
    Me.colKodeCoa.FieldName = "fCOA.Kode"
    Me.colKodeCoa.Name = "colKodeCoa"
    Me.colKodeCoa.Visible = True
    Me.colKodeCoa.VisibleIndex = 1
    '
    'colNamaCoa
    '
    Me.colNamaCoa.Caption = "Nama COA"
    Me.colNamaCoa.FieldName = "fCOA.Nama"
    Me.colNamaCoa.Name = "colNamaCoa"
    Me.colNamaCoa.Visible = True
    Me.colNamaCoa.VisibleIndex = 2
    '
    'colKontak
    '
    Me.colKontak.Caption = "Kontak"
    Me.colKontak.FieldName = "Kontak.Nama"
    Me.colKontak.Name = "colKontak"
    Me.colKontak.Visible = True
    Me.colKontak.VisibleIndex = 3
    '
    'colDebit
    '
    Me.colDebit.Caption = "Saldo"
    Me.colDebit.FieldName = "Saldo"
    Me.colDebit.Name = "colDebit"
    Me.colDebit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colDebit.Visible = True
    Me.colDebit.VisibleIndex = 4
    '
    'colKurs
    '
    Me.colKurs.Caption = "Kurs"
    Me.colKurs.FieldName = "Kurs"
    Me.colKurs.Name = "colKurs"
    Me.colKurs.Visible = True
    Me.colKurs.VisibleIndex = 5
    '
    'colID
    '
    Me.colID.Caption = "ID"
    Me.colID.FieldName = "Id"
    Me.colID.Name = "colID"
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Regional"
    Me.GridColumn1.FieldName = "Regional.Nama"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'UI_SaldoAwal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Name = "UI_SaldoAwal"
    Me.Text = "Saldo Awal"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colNoTrans As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKodeCoa As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaCoa As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontak As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colDebit As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKurs As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
