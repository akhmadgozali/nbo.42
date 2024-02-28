﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Prepayment
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_Prepayment))
    Me.colCreate = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCreateUser = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colModif = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colModifUser = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colReg = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCatatanApprove = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnCetakVoucher = New DevExpress.XtraBars.BarButtonItem()
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
    Me.xGrid.Size = New System.Drawing.Size(765, 374)
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnCetakVoucher})
    Me.barMan.MaxItemId = 14
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCreate, Me.colCreateUser, Me.colModif, Me.colModifUser, Me.colId, Me.colTahun, Me.colBulan, Me.colKode, Me.colTanggal, Me.colReg, Me.colKeterangan, Me.colStatus, Me.colCatatanApprove})
    Me.xGridView.GroupCount = 3
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsLayout.Columns.StoreAllOptions = True
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colReg, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'ifSource
    '
    Me.ifSource.DisplayableProperties = "created_date;created_user;last_date;last_modified;Id;Tahun;Bulan;Kode;Tanggal;Reg" & _
    "ional.Kode;Keterangan;Status;CatatanApprove"
    Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.PrePaymentMain)
    '
    'popMenu
    '
    Me.popMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCetakVoucher, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
    '
    'barMenu
    '
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'colCreate
    '
    Me.colCreate.Caption = "Tanggal Input"
    Me.colCreate.FieldName = "created_date"
    Me.colCreate.Name = "colCreate"
    '
    'colCreateUser
    '
    Me.colCreateUser.Caption = "User Input"
    Me.colCreateUser.FieldName = "created_user"
    Me.colCreateUser.Name = "colCreateUser"
    '
    'colModif
    '
    Me.colModif.Caption = "Tanggal Edit"
    Me.colModif.FieldName = "last_date"
    Me.colModif.Name = "colModif"
    '
    'colModifUser
    '
    Me.colModifUser.Caption = "User Edit"
    Me.colModifUser.FieldName = "last_modified"
    Me.colModifUser.Name = "colModifUser"
    '
    'colId
    '
    Me.colId.Caption = "ID"
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    Me.colId.OptionsColumn.ReadOnly = True
    '
    'colTahun
    '
    Me.colTahun.Caption = "Tahun"
    Me.colTahun.FieldName = "Tahun"
    Me.colTahun.Name = "colTahun"
    Me.colTahun.OptionsColumn.ReadOnly = True
    Me.colTahun.Visible = True
    Me.colTahun.VisibleIndex = 0
    '
    'colBulan
    '
    Me.colBulan.Caption = "Bulan"
    Me.colBulan.DisplayFormat.FormatString = "MMMM"
    Me.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colBulan.FieldName = "Bulan"
    Me.colBulan.Name = "colBulan"
    Me.colBulan.OptionsColumn.ReadOnly = True
    Me.colBulan.Visible = True
    Me.colBulan.VisibleIndex = 2
    '
    'colKode
    '
    Me.colKode.Caption = "No Bukti"
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    Me.colKode.Width = 83
    '
    'colTanggal
    '
    Me.colTanggal.Caption = "Tanggal"
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 1
    '
    'colReg
    '
    Me.colReg.Caption = "Regional"
    Me.colReg.FieldName = "Regional.Kode"
    Me.colReg.Name = "colReg"
    Me.colReg.OptionsColumn.ReadOnly = True
    Me.colReg.Visible = True
    Me.colReg.VisibleIndex = 6
    '
    'colKeterangan
    '
    Me.colKeterangan.Caption = "Keterangan"
    Me.colKeterangan.FieldName = "Keterangan"
    Me.colKeterangan.Name = "colKeterangan"
    Me.colKeterangan.Visible = True
    Me.colKeterangan.VisibleIndex = 2
    '
    'colStatus
    '
    Me.colStatus.Caption = "Status"
    Me.colStatus.FieldName = "Status"
    Me.colStatus.Name = "colStatus"
    Me.colStatus.Visible = True
    Me.colStatus.VisibleIndex = 3
    '
    'colCatatanApprove
    '
    Me.colCatatanApprove.Caption = "Catatan Approve"
    Me.colCatatanApprove.FieldName = "CatatanApprove"
    Me.colCatatanApprove.Name = "colCatatanApprove"
    '
    'btnCetakVoucher
    '
    Me.btnCetakVoucher.Caption = "Cetak Voucher"
    Me.btnCetakVoucher.Glyph = CType(resources.GetObject("btnCetakVoucher.Glyph"), System.Drawing.Image)
    Me.btnCetakVoucher.Id = 13
    Me.btnCetakVoucher.LargeGlyph = CType(resources.GetObject("btnCetakVoucher.LargeGlyph"), System.Drawing.Image)
    Me.btnCetakVoucher.Name = "btnCetakVoucher"
    '
    'UI_Prepayment
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(765, 401)
    Me.Name = "UI_Prepayment"
    Me.Text = "Prepayment"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colCreate As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCreateUser As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colModif As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colModifUser As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colReg As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCatatanApprove As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnCetakVoucher As DevExpress.XtraBars.BarButtonItem
End Class