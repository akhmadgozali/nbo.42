<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_SanYuPIB
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
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKurs = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoPengajuan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoPendaftaran = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTglPendaftaran = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKPBC = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUmur = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colJatuhTempo = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colReffNo = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.xGrid.Size = New System.Drawing.Size(800, 423)
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTahun, Me.colBulan, Me.colKode, Me.colTanggal, Me.GridColumn1, Me.GridColumn2, Me.colCatatan, Me.GridColumn3, Me.colKurs, Me.colNoPengajuan, Me.colNoPendaftaran, Me.colTglPendaftaran, Me.colKPBC, Me.colUmur, Me.colJatuhTempo, Me.colReffNo})
    Me.xGridView.GroupCount = 2
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.OptionsView.ColumnAutoWidth = False
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'ifSource
    '
    Me.ifSource.DisplayableProperties = "Id;Kode;Tanggal;Bulan;Tahun;Pelanggan.Kode;Pelanggan.Nama;Catatan;InvoicePenjuala" & _
    "n.Kode;NoPengajuan;NoPendaftaran;TglPendaftaran;KPBC;Umur;JatuhTempo;Uang.Kode;K" & _
    "urs;ReffNo"
    Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.SanYu_PEB)
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
    Me.colId.OptionsColumn.ReadOnly = True
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
    Me.colBulan.FieldName = "Bulan"
    Me.colBulan.Name = "colBulan"
    Me.colBulan.Visible = True
    Me.colBulan.VisibleIndex = 3
    '
    'colKode
    '
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    '
    'colTanggal
    '
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 1
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "Pelanggan"
    Me.GridColumn1.FieldName = "Pelanggan.Nama"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.VisibleIndex = 2
    '
    'GridColumn2
    '
    Me.GridColumn2.Caption = "No Invoice"
    Me.GridColumn2.FieldName = "InvoicePenjualan.Kode"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.VisibleIndex = 3
    '
    'colCatatan
    '
    Me.colCatatan.FieldName = "Catatan"
    Me.colCatatan.Name = "colCatatan"
    Me.colCatatan.Visible = True
    Me.colCatatan.VisibleIndex = 5
    '
    'GridColumn3
    '
    Me.GridColumn3.FieldName = "Uang.Kode"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 6
    '
    'colKurs
    '
    Me.colKurs.FieldName = "Kurs"
    Me.colKurs.Name = "colKurs"
    Me.colKurs.Visible = True
    Me.colKurs.VisibleIndex = 7
    '
    'colNoPengajuan
    '
    Me.colNoPengajuan.FieldName = "NoPengajuan"
    Me.colNoPengajuan.Name = "colNoPengajuan"
    Me.colNoPengajuan.Visible = True
    Me.colNoPengajuan.VisibleIndex = 8
    '
    'colNoPendaftaran
    '
    Me.colNoPendaftaran.FieldName = "NoPendaftaran"
    Me.colNoPendaftaran.Name = "colNoPendaftaran"
    Me.colNoPendaftaran.Visible = True
    Me.colNoPendaftaran.VisibleIndex = 9
    '
    'colTglPendaftaran
    '
    Me.colTglPendaftaran.FieldName = "TglPendaftaran"
    Me.colTglPendaftaran.Name = "colTglPendaftaran"
    Me.colTglPendaftaran.Visible = True
    Me.colTglPendaftaran.VisibleIndex = 10
    '
    'colKPBC
    '
    Me.colKPBC.FieldName = "KPBC"
    Me.colKPBC.Name = "colKPBC"
    Me.colKPBC.Visible = True
    Me.colKPBC.VisibleIndex = 11
    '
    'colUmur
    '
    Me.colUmur.FieldName = "Umur"
    Me.colUmur.Name = "colUmur"
    Me.colUmur.Visible = True
    Me.colUmur.VisibleIndex = 12
    '
    'colJatuhTempo
    '
    Me.colJatuhTempo.FieldName = "JatuhTempo"
    Me.colJatuhTempo.Name = "colJatuhTempo"
    Me.colJatuhTempo.Visible = True
    Me.colJatuhTempo.VisibleIndex = 13
    '
    'colReffNo
    '
    Me.colReffNo.Caption = "No PEB"
    Me.colReffNo.FieldName = "ReffNo"
    Me.colReffNo.Name = "colReffNo"
    Me.colReffNo.Visible = True
    Me.colReffNo.VisibleIndex = 4
    Me.colReffNo.Width = 95
    '
    'UI_SanYuPIB
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 450)
    Me.Name = "UI_SanYuPIB"
    Me.Text = "PEB"
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
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKurs As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoPengajuan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoPendaftaran As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTglPendaftaran As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKPBC As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUmur As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colJatuhTempo As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colReffNo As DevExpress.XtraGrid.Columns.GridColumn
End Class
