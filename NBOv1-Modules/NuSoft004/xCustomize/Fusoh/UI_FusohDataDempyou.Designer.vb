<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohDataDempyou
  Inherits Core.Win.Forms.GridBinding

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
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSerial = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSNLength = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colWeight = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colLength = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.xGrid.Size = New System.Drawing.Size(800, 423)
    '
    'xpCol
    '
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Fusoh_OrderProduksiBahanBaku)
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.colQty, Me.colSerial, Me.colSNLength, Me.colLength, Me.colWeight, Me.colCatatan})
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.ShowGroupPanel = False
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
    Me.colId.Visible = True
    Me.colId.VisibleIndex = 0
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "No Bukti"
    Me.GridColumn1.FieldName = "Main.Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsColumn.AllowEdit = False
    Me.GridColumn1.OptionsColumn.ReadOnly = True
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 1
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Kode Barang"
    Me.GridColumn2.FieldName = "Barang.Kode"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.OptionsColumn.AllowEdit = False
    Me.GridColumn2.OptionsColumn.ReadOnly = True
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 2
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Nama Barang"
    Me.GridColumn3.FieldName = "Barang.Nama"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.OptionsColumn.AllowEdit = False
    Me.GridColumn3.OptionsColumn.ReadOnly = True
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 3
    '
    'colQty
    '
    Me.colQty.FieldName = "Qty"
    Me.colQty.Name = "colQty"
    Me.colQty.Visible = True
    Me.colQty.VisibleIndex = 4
    '
    'colSerial
    '
    Me.colSerial.FieldName = "Serial"
    Me.colSerial.Name = "colSerial"
    Me.colSerial.Visible = True
    Me.colSerial.VisibleIndex = 5
    '
    'colSNLength
    '
    Me.colSNLength.FieldName = "SNLength"
    Me.colSNLength.Name = "colSNLength"
    Me.colSNLength.Visible = True
    Me.colSNLength.VisibleIndex = 6
    '
    'colWeight
    '
    Me.colWeight.FieldName = "Weight"
    Me.colWeight.Name = "colWeight"
    Me.colWeight.Visible = True
    Me.colWeight.VisibleIndex = 8
    '
    'colCatatan
    '
    Me.colCatatan.FieldName = "Catatan"
    Me.colCatatan.Name = "colCatatan"
    Me.colCatatan.Visible = True
    Me.colCatatan.VisibleIndex = 9
    '
    'colLength
    '
    Me.colLength.FieldName = "Length"
    Me.colLength.Name = "colLength"
    Me.colLength.Visible = True
    Me.colLength.VisibleIndex = 7
    '
    'UI_FusohDataDempyou
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 450)
    Me.Name = "UI_FusohDataDempyou"
    Me.Text = "UI_FusohDataDempyou"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSerial As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSNLength As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeight As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLength As DevExpress.XtraGrid.Columns.GridColumn
End Class
