<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Kontak
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_Kontak))
    Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAlamat = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAktif = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBatasHutang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBatasPiutang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colcreated_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colcreated_user = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.collast_date = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.collast_modified = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNPWP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNPKP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColKategori = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.btnSaveLayout = New DevExpress.XtraBars.BarButtonItem()
    Me.btnImporData = New DevExpress.XtraBars.BarButtonItem()
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
    Me.xGrid.Size = New System.Drawing.Size(765, 374)
    '
    'xpCol
    '
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft008.Persistent.Kontak)
    '
    'barMan
    '
    Me.barMan.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSaveLayout, Me.btnImporData})
    Me.barMan.MaxItemId = 15
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColKategori, Me.colKode, Me.colNama, Me.colAlamat, Me.colAktif, Me.colKeterangan, Me.colId, Me.colBatasHutang, Me.colBatasPiutang, Me.colcreated_date, Me.colcreated_user, Me.collast_date, Me.collast_modified, Me.colNPWP, Me.colNPKP})
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    '
    'barMenu
    '
    Me.barMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnImporData)})
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'colKode
    '
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.VisibleIndex = 0
    Me.colKode.Width = 150
    '
    'colNama
    '
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 1
    Me.colNama.Width = 200
    '
    'colAlamat
    '
    Me.colAlamat.FieldName = "Alamat"
    Me.colAlamat.Name = "colAlamat"
    Me.colAlamat.Visible = True
    Me.colAlamat.VisibleIndex = 2
    Me.colAlamat.Width = 250
    '
    'colKeterangan
    '
    Me.colKeterangan.FieldName = "Keterangan"
    Me.colKeterangan.Name = "colKeterangan"
    Me.colKeterangan.Visible = True
    Me.colKeterangan.VisibleIndex = 4
    '
    'colAktif
    '
    Me.colAktif.AppearanceHeader.Options.UseTextOptions = True
    Me.colAktif.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colAktif.FieldName = "Aktif"
    Me.colAktif.Name = "colAktif"
    Me.colAktif.Visible = True
    Me.colAktif.VisibleIndex = 3
    Me.colAktif.Width = 50
    '
    'colId
    '
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    '
    'colBatasHutang
    '
    Me.colBatasHutang.Caption = "Batas Hutang"
    Me.colBatasHutang.FieldName = "BatasHutang"
    Me.colBatasHutang.Name = "colBatasHutang"
    '
    'colBatasPiutang
    '
    Me.colBatasPiutang.Caption = "Batas Piutang"
    Me.colBatasPiutang.FieldName = "BatasPiutang"
    Me.colBatasPiutang.Name = "colBatasPiutang"
    '
    'colcreated_date
    '
    Me.colcreated_date.Caption = "Tgl Create"
    Me.colcreated_date.FieldName = "created_date"
    Me.colcreated_date.Name = "colcreated_date"
    '
    'colcreated_user
    '
    Me.colcreated_user.Caption = "User Create"
    Me.colcreated_user.FieldName = "created_user"
    Me.colcreated_user.Name = "colcreated_user"
    '
    'collast_date
    '
    Me.collast_date.Caption = "Tgl Edit"
    Me.collast_date.FieldName = "last_date"
    Me.collast_date.Name = "collast_date"
    '
    'collast_modified
    '
    Me.collast_modified.Caption = "User Edit"
    Me.collast_modified.FieldName = "last_modified"
    Me.collast_modified.Name = "collast_modified"
    '
    'colNPWP
    '
    Me.colNPWP.Caption = "No NPWP"
    Me.colNPWP.FieldName = "NPWP"
    Me.colNPWP.Name = "colNPWP"
    '
    'colNPKP
    '
    Me.colNPKP.Caption = "PKP"
    Me.colNPKP.FieldName = "NPKP"
    Me.colNPKP.Name = "colNPKP"
    '
    'ColKategori
    '
    Me.ColKategori.Caption = "Kategori"
    Me.ColKategori.FieldName = "TipeKontak.Nama"
    Me.ColKategori.Name = "ColKategori"
    Me.ColKategori.Visible = True
    Me.ColKategori.VisibleIndex = 5
    '
    'btnSaveLayout
    '
    Me.btnSaveLayout.Caption = "Save Layout"
    Me.btnSaveLayout.Glyph = CType(resources.GetObject("btnSaveLayout.Glyph"), System.Drawing.Image)
    Me.btnSaveLayout.Id = 13
    Me.btnSaveLayout.LargeGlyph = CType(resources.GetObject("btnSaveLayout.LargeGlyph"), System.Drawing.Image)
    Me.btnSaveLayout.Name = "btnSaveLayout"
    '
    'btnImporData
    '
    Me.btnImporData.Caption = "Impor Data"
    Me.btnImporData.Id = 14
    Me.btnImporData.Name = "btnImporData"
    '
    'UI_Kontak
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(765, 401)
    Me.Name = "UI_Kontak"
    Me.Text = "Daftar Kontak"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAlamat As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAktif As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents ColKategori As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBatasHutang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBatasPiutang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colcreated_user As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_date As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents collast_modified As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNPWP As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNPKP As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnSaveLayout As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents btnImporData As DevExpress.XtraBars.BarButtonItem
End Class
