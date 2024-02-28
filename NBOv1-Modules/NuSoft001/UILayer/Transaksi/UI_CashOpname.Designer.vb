<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_CashOpname
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
    Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAkun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAkunKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAkunNama = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.xGrid.Size = New System.Drawing.Size(765, 375)
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTahun, Me.colBulan, Me.colTanggal, Me.colAkun, Me.colSaldo, Me.colKeterangan, Me.colAkunKode, Me.colAkunNama})
    Me.xGridView.GroupCount = 2
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Descending)})
    '
    'ifSource
    '
    Me.ifSource.DisplayableProperties = "Tahun;Bulan;Id;Tanggal;Akun.Kode;Akun.Nama;Total;Keterangan"
    Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.CashOpname)
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
    Me.colTahun.FieldName = "Tahun"
    Me.colTahun.Name = "colTahun"
    Me.colTahun.Visible = True
    Me.colTahun.VisibleIndex = 0
    '
    'colBulan
    '
    Me.colBulan.DisplayFormat.FormatString = "MMMM"
    Me.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colBulan.FieldName = "Bulan"
    Me.colBulan.GroupFormat.FormatString = "MMMM"
    Me.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colBulan.Name = "colBulan"
    Me.colBulan.Visible = True
    Me.colBulan.VisibleIndex = 0
    '
    'colTanggal
    '
    Me.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
    Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 0
    Me.colTanggal.Width = 104
    '
    'colAkun
    '
    Me.colAkun.Caption = "Akun"
    Me.colAkun.FieldName = "Akun.Nama"
    Me.colAkun.Name = "colAkun"
    Me.colAkun.UnboundExpression = "Concat([Akun.Kode],' | ',[Akun.Nama] )"
    Me.colAkun.UnboundType = DevExpress.Data.UnboundColumnType.[String]
    Me.colAkun.Visible = True
    Me.colAkun.VisibleIndex = 1
    Me.colAkun.Width = 150
    '
    'colSaldo
    '
    Me.colSaldo.AppearanceHeader.Options.UseTextOptions = True
    Me.colSaldo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colSaldo.FieldName = "Total"
    Me.colSaldo.Name = "colSaldo"
    Me.colSaldo.Visible = True
    Me.colSaldo.VisibleIndex = 2
    Me.colSaldo.Width = 100
    '
    'colKeterangan
    '
    Me.colKeterangan.FieldName = "Keterangan"
    Me.colKeterangan.Name = "colKeterangan"
    Me.colKeterangan.Visible = True
    Me.colKeterangan.VisibleIndex = 3
    Me.colKeterangan.Width = 250
    '
    'colAkunKode
    '
    Me.colAkunKode.FieldName = "Akun.Kode"
    Me.colAkunKode.Name = "colAkunKode"
    '
    'colAkunNama
    '
    Me.colAkunNama.FieldName = "Akun.Nama"
    Me.colAkunNama.Name = "colAkunNama"
    '
    'UI_CashOpname
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(765, 402)
    Me.Name = "UI_CashOpname"
    Me.Text = "Cash Opname"
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
  Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAkunKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAkunNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAkun As DevExpress.XtraGrid.Columns.GridColumn
End Class