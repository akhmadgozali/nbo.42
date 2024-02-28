<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_FusohCekDempyou
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
    Me.components = New System.ComponentModel.Container()
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colId2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSerial = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colMillsheet = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colLength = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.Dock = System.Windows.Forms.DockStyle.Fill
    Me.xGrid.Location = New System.Drawing.Point(0, 0)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.Name = "xGrid"
    Me.xGrid.Size = New System.Drawing.Size(800, 450)
    Me.xGrid.TabIndex = 11
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId2, Me.colKode2, Me.colTanggal2, Me.GridColumn1, Me.GridColumn2, Me.colSerial, Me.colMillsheet, Me.colLength})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsBehavior.ReadOnly = True
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'colId2
    '
    Me.colId2.FieldName = "Id"
    Me.colId2.Name = "colId2"
    Me.colId2.OptionsColumn.ReadOnly = True
    '
    'colKode2
    '
    Me.colKode2.Caption = "No Transaksi"
    Me.colKode2.FieldName = "Main.Kode"
    Me.colKode2.Name = "colKode2"
    Me.colKode2.Visible = True
    Me.colKode2.VisibleIndex = 0
    '
    'colTanggal2
    '
    Me.colTanggal2.Caption = "Tanggal"
    Me.colTanggal2.DisplayFormat.FormatString = "d/MMM/yy"
    Me.colTanggal2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTanggal2.FieldName = "Main.Tanggal"
    Me.colTanggal2.Name = "colTanggal2"
    Me.colTanggal2.Visible = True
    Me.colTanggal2.VisibleIndex = 1
    Me.colTanggal2.Width = 72
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Part No"
    Me.GridColumn1.FieldName = "Barang.Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 2
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "Part Name"
    Me.GridColumn2.FieldName = "Barang.Nama"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 3
    '
    'colSerial
    '
    Me.colSerial.Caption = "SN"
    Me.colSerial.FieldName = "Serial"
    Me.colSerial.Name = "colSerial"
    Me.colSerial.Visible = True
    Me.colSerial.VisibleIndex = 4
    '
    'colMillsheet
    '
    Me.colMillsheet.Caption = "Mill Sheet"
    Me.colMillsheet.FieldName = "Millsheet"
    Me.colMillsheet.Name = "colMillsheet"
    Me.colMillsheet.Visible = True
    Me.colMillsheet.VisibleIndex = 5
    '
    'colLength
    '
    Me.colLength.Caption = "Length"
    Me.colLength.FieldName = "Length"
    Me.colLength.Name = "colLength"
    Me.colLength.Visible = True
    Me.colLength.VisibleIndex = 6
    '
    'UI_FusohCekDempyou
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 450)
    Me.Controls.Add(Me.xGrid)
    Me.Name = "UI_FusohCekDempyou"
    Me.Text = "UI_FusohCekDempyou"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colId2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSerial As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colMillsheet As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLength As DevExpress.XtraGrid.Columns.GridColumn
End Class
