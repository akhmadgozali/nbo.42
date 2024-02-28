<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_FusohDataSerial
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
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colMillSheet = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSerial = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colLengthIn = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colLengthOut = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWeightIN = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWeightOUT = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.DataSource = Me.xpCol
    '
    'xpCol
    '
    Me.xpCol.DisplayableProperties = "This;created_date;created_user;last_date;last_modified;Id;MillSheet;Serial;Length" &
    "In;LengthOut;SisaLength;DetailMain.Barang.Kode;DetailMain.Barang.Nama;WeightIN;W" &
    "eightOUT"
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Fusoh_StokSerial)
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.colMillSheet, Me.colSerial, Me.colLengthIn, Me.colLengthOut, Me.colWeightIN, Me.colWeightOUT})
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.ShowFooter = True
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'barMenu
    '
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Kode Barang"
    Me.GridColumn1.FieldName = "DetailMain.Barang.Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsColumn.AllowEdit = False
    Me.GridColumn1.OptionsColumn.ReadOnly = True
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 0
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Nama Barang"
    Me.GridColumn2.FieldName = "DetailMain.Barang.Nama"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.OptionsColumn.AllowEdit = False
    Me.GridColumn2.OptionsColumn.ReadOnly = True
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 1
    '
    'colMillSheet
    '
    Me.colMillSheet.Caption = "Mill Sheet"
    Me.colMillSheet.FieldName = "MillSheet"
    Me.colMillSheet.Name = "colMillSheet"
    Me.colMillSheet.Visible = True
    Me.colMillSheet.VisibleIndex = 2
    '
    'colSerial
    '
    Me.colSerial.Caption = "Serial"
    Me.colSerial.FieldName = "Serial"
    Me.colSerial.Name = "colSerial"
    Me.colSerial.Visible = True
    Me.colSerial.VisibleIndex = 3
    '
    'colLengthIn
    '
    Me.colLengthIn.FieldName = "LengthIn"
    Me.colLengthIn.Name = "colLengthIn"
    Me.colLengthIn.OptionsColumn.AllowEdit = False
    Me.colLengthIn.OptionsColumn.ReadOnly = True
    Me.colLengthIn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colLengthIn.Visible = True
    Me.colLengthIn.VisibleIndex = 4
    '
    'colLengthOut
    '
    Me.colLengthOut.FieldName = "LengthOut"
    Me.colLengthOut.Name = "colLengthOut"
    Me.colLengthOut.OptionsColumn.AllowEdit = False
    Me.colLengthOut.OptionsColumn.ReadOnly = True
    Me.colLengthOut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    Me.colLengthOut.Visible = True
    Me.colLengthOut.VisibleIndex = 5
    '
    'colWeightIN
    '
    Me.colWeightIN.FieldName = "WeightIN"
    Me.colWeightIN.Name = "colWeightIN"
    Me.colWeightIN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    '
    'colWeightOUT
    '
    Me.colWeightOUT.FieldName = "WeightOUT"
    Me.colWeightOUT.Name = "colWeightOUT"
    Me.colWeightOUT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
    '
    'UI_FusohDataSerial
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Name = "UI_FusohDataSerial"
    Me.Text = "Master Data Gudang"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAlamat As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoTelp As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoFax As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colMillSheet As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSerial As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLengthIn As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLengthOut As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeightIN As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeightOUT As DevExpress.XtraGrid.Columns.GridColumn
End Class
