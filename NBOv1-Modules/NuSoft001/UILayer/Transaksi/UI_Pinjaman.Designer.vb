<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Pinjaman
  Inherits NuSoft.Core.Win.Forms.GridInput

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
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colRegional = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontak = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPinjaman = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTermin = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBiaya = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggalAwal = New DevExpress.XtraGrid.Columns.GridColumn()
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
    'xpCol
    '
    Me.xpCol.DisplayableProperties = "Bulan;Akun.Kode;Akun.Nama;Regional.Kode;Regional.Nama;Tanggal;Kode;Kontak.Kode;Ko" & _
    "ntak.Nama;StatusTransaksi;JatuhTempo;Keterangan;Tahun;Jumlah;Id"
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.PengajuanDana)
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTahun, Me.colBulan, Me.colRegional, Me.colKode, Me.colTanggal, Me.colKontak, Me.colTanggalAwal, Me.colPinjaman, Me.colTermin, Me.colBiaya, Me.colKeterangan, Me.colId})
    Me.xGridView.GroupCount = 3
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colRegional, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'ifSource
    '
    Me.ifSource.DisplayableProperties = "Id;Tahun;Bulan;Regional.Nama;Kode;Tanggal;Kontak.Nama;JumlahPinjaman;Termin;Biaya" & _
    ";TanggalAwal;Keterangan"
    Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Pinjaman)
    '
    'barMenu
    '
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
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
    'colRegional
    '
    Me.colRegional.Caption = "Regional"
    Me.colRegional.FieldName = "Regional.Nama"
    Me.colRegional.Name = "colRegional"
    Me.colRegional.Visible = True
    Me.colRegional.VisibleIndex = 0
    '
    'colKode
    '
    Me.colKode.Caption = "No. Kontrak"
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    Me.colKode.Width = 83
    '
    'colTanggal
    '
    Me.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
    Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 1
    '
    'colKontak
    '
    Me.colKontak.Caption = "Kontak"
    Me.colKontak.FieldName = "Kontak.Nama"
    Me.colKontak.Name = "colKontak"
    Me.colKontak.Visible = True
    Me.colKontak.VisibleIndex = 2
    '
    'colPinjaman
    '
    Me.colPinjaman.Caption = "Pinjaman"
    Me.colPinjaman.FieldName = "JumlahPinjaman"
    Me.colPinjaman.Name = "colPinjaman"
    Me.colPinjaman.Visible = True
    Me.colPinjaman.VisibleIndex = 4
    '
    'colTermin
    '
    Me.colTermin.Caption = "Termin"
    Me.colTermin.DisplayFormat.FormatString = "n0"
    Me.colTermin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colTermin.FieldName = "Termin"
    Me.colTermin.Name = "colTermin"
    Me.colTermin.Visible = True
    Me.colTermin.VisibleIndex = 5
    '
    'colBiaya
    '
    Me.colBiaya.Caption = "Biaya"
    Me.colBiaya.DisplayFormat.FormatString = "{0:n2} %"
    Me.colBiaya.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colBiaya.FieldName = "Biaya"
    Me.colBiaya.Name = "colBiaya"
    Me.colBiaya.Visible = True
    Me.colBiaya.VisibleIndex = 6
    '
    'colKeterangan
    '
    Me.colKeterangan.FieldName = "Keterangan"
    Me.colKeterangan.Name = "colKeterangan"
    Me.colKeterangan.Visible = True
    Me.colKeterangan.VisibleIndex = 7
    '
    'colId
    '
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    '
    'colTanggalAwal
    '
    Me.colTanggalAwal.DisplayFormat.FormatString = "dd MMM yyyy"
    Me.colTanggalAwal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colTanggalAwal.FieldName = "TanggalAwal"
    Me.colTanggalAwal.Name = "colTanggalAwal"
    Me.colTanggalAwal.Visible = True
    Me.colTanggalAwal.VisibleIndex = 3
    '
    'UI_Pinjaman
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(765, 402)
    Me.Name = "UI_Pinjaman"
    Me.Text = "Loan Administration"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colRegional As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontak As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPinjaman As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTermin As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBiaya As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggalAwal As DevExpress.XtraGrid.Columns.GridColumn
End Class
