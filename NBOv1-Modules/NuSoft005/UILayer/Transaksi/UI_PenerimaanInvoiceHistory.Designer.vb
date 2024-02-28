<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_PenerimaanInvoiceHistory
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
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colcreated_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colcreated_user = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.collast_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.collast_modified = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUraian = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCoaKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCoaNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNilaiBayar = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKurs = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNilaiBayarCash = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNilaiBayarRetur = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.xGrid.Size = New System.Drawing.Size(759, 395)
    Me.xGrid.TabIndex = 0
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcreated_date, Me.colcreated_user, Me.collast_date, Me.collast_modified, Me.colNoTransaksi, Me.colTanggal, Me.colUraian, Me.colCoaKode, Me.colCoaNama, Me.colNilaiBayar, Me.colKurs, Me.colNilaiBayarCash, Me.colNilaiBayarRetur, Me.colCatatan})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'colcreated_date
    '
    Me.colcreated_date.FieldName = "created_date"
    Me.colcreated_date.Name = "colcreated_date"
    '
    'colcreated_user
    '
    Me.colcreated_user.FieldName = "created_user"
    Me.colcreated_user.Name = "colcreated_user"
    '
    'collast_date
    '
    Me.collast_date.FieldName = "last_date"
    Me.collast_date.Name = "collast_date"
    '
    'collast_modified
    '
    Me.collast_modified.FieldName = "last_modified"
    Me.collast_modified.Name = "collast_modified"
    '
    'colNoTransaksi
    '
    Me.colNoTransaksi.Caption = "No Bukti"
    Me.colNoTransaksi.FieldName = "Main.Kode"
    Me.colNoTransaksi.Name = "colNoTransaksi"
    Me.colNoTransaksi.Visible = True
    Me.colNoTransaksi.VisibleIndex = 0
    '
    'colTanggal
    '
    Me.colTanggal.Caption = "Tanggal"
    Me.colTanggal.FieldName = "Main.Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 1
    '
    'colUraian
    '
    Me.colUraian.Caption = "Uraian"
    Me.colUraian.FieldName = "Main.Uraian"
    Me.colUraian.Name = "colUraian"
    Me.colUraian.Visible = True
    Me.colUraian.VisibleIndex = 2
    '
    'colCoaKode
    '
    Me.colCoaKode.Caption = "COA"
    Me.colCoaKode.FieldName = "Main.coakasbank.Kode"
    Me.colCoaKode.Name = "colCoaKode"
    Me.colCoaKode.Visible = True
    Me.colCoaKode.VisibleIndex = 3
    '
    'colCoaNama
    '
    Me.colCoaNama.Caption = "Nama COA"
    Me.colCoaNama.FieldName = "Main.coakasbank.Nama"
    Me.colCoaNama.Name = "colCoaNama"
    Me.colCoaNama.Visible = True
    Me.colCoaNama.VisibleIndex = 4
    '
    'colNilaiBayar
    '
    Me.colNilaiBayar.FieldName = "NilaiBayar"
    Me.colNilaiBayar.Name = "colNilaiBayar"
    Me.colNilaiBayar.Visible = True
    Me.colNilaiBayar.VisibleIndex = 5
    '
    'colKurs
    '
    Me.colKurs.FieldName = "Kurs"
    Me.colKurs.Name = "colKurs"
    Me.colKurs.Visible = True
    Me.colKurs.VisibleIndex = 6
    '
    'colNilaiBayarCash
    '
    Me.colNilaiBayarCash.FieldName = "NilaiBayarCash"
    Me.colNilaiBayarCash.Name = "colNilaiBayarCash"
    Me.colNilaiBayarCash.Visible = True
    Me.colNilaiBayarCash.VisibleIndex = 7
    '
    'colNilaiBayarRetur
    '
    Me.colNilaiBayarRetur.FieldName = "NilaiBayarRetur"
    Me.colNilaiBayarRetur.Name = "colNilaiBayarRetur"
    '
    'colCatatan
    '
    Me.colCatatan.FieldName = "Catatan"
    Me.colCatatan.Name = "colCatatan"
    '
    'UI_PenerimaanInvoiceHistory
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Controls.Add(Me.xGrid)
    Me.Name = "UI_PenerimaanInvoiceHistory"
    Me.Text = "UI_PenerimaanInvoiceHistory"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colcreated_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_user As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_modified As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoTransaksi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUraian As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCoaKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCoaNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilaiBayar As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKurs As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilaiBayarCash As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNilaiBayarRetur As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
End Class
