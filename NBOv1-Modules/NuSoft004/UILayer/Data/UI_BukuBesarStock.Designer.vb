<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_BukuBesarStock
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
    Me.components = New System.ComponentModel.Container()
    Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
    Me.colKode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colCatatan = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colNilaiPersediaanQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colTotalQtyHPP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colNilaiPersediaan = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colTotalHPP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.GridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.GridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.colSelisih = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.XpInstantFeedbackSource1 = New DevExpress.Xpo.XPInstantFeedbackSource(Me.components)
    Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.DataSource = Me.XpInstantFeedbackSource1
    Me.xGrid.MainView = Me.BandedGridView1
    Me.xGrid.Size = New System.Drawing.Size(1052, 469)
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
    '
    'xGridView
    '
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
    'BandedGridView1
    '
    Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gridBand2, Me.gridBand3})
    Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colKode, Me.colTanggal, Me.colCatatan, Me.colNilaiPersediaanQty, Me.colTotalQtyHPP, Me.colNilaiPersediaan, Me.colTotalHPP, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.colSelisih})
    Me.BandedGridView1.GridControl = Me.xGrid
    Me.BandedGridView1.Name = "BandedGridView1"
    Me.BandedGridView1.NewItemRowText = "Tambah data"
    Me.BandedGridView1.OptionsCustomization.AllowGroup = False
    Me.BandedGridView1.OptionsDetail.EnableMasterViewMode = False
    Me.BandedGridView1.OptionsView.ShowGroupPanel = False
    '
    'colKode
    '
    Me.colKode.Caption = "No Bukti"
    Me.colKode.FieldName = "Kode"
    Me.colKode.Name = "colKode"
    Me.colKode.Visible = True
    Me.colKode.Width = 97
    '
    'colTanggal
    '
    Me.colTanggal.Caption = "Tanggal"
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.Width = 87
    '
    'colCatatan
    '
    Me.colCatatan.Caption = "Catatan"
    Me.colCatatan.FieldName = "Catatan"
    Me.colCatatan.Name = "colCatatan"
    Me.colCatatan.Visible = True
    Me.colCatatan.Width = 291
    '
    'colNilaiPersediaanQty
    '
    Me.colNilaiPersediaanQty.AppearanceHeader.Options.UseTextOptions = True
    Me.colNilaiPersediaanQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colNilaiPersediaanQty.Caption = "Qty Stock"
    Me.colNilaiPersediaanQty.DisplayFormat.FormatString = "n0"
    Me.colNilaiPersediaanQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colNilaiPersediaanQty.FieldName = "NilaiPersediaanQtyAlias"
    Me.colNilaiPersediaanQty.Name = "colNilaiPersediaanQty"
    Me.colNilaiPersediaanQty.Visible = True
    Me.colNilaiPersediaanQty.Width = 53
    '
    'colTotalQtyHPP
    '
    Me.colTotalQtyHPP.AppearanceHeader.Options.UseTextOptions = True
    Me.colTotalQtyHPP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colTotalQtyHPP.Caption = "Qty HPP"
    Me.colTotalQtyHPP.DisplayFormat.FormatString = "n0"
    Me.colTotalQtyHPP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colTotalQtyHPP.FieldName = "TotalQtyHPP"
    Me.colTotalQtyHPP.Name = "colTotalQtyHPP"
    Me.colTotalQtyHPP.Visible = True
    Me.colTotalQtyHPP.Width = 53
    '
    'colNilaiPersediaan
    '
    Me.colNilaiPersediaan.AppearanceHeader.Options.UseTextOptions = True
    Me.colNilaiPersediaan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colNilaiPersediaan.Caption = "Nilai Persediaan"
    Me.colNilaiPersediaan.DisplayFormat.FormatString = "n0"
    Me.colNilaiPersediaan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colNilaiPersediaan.FieldName = "NilaiPersediaanAlias"
    Me.colNilaiPersediaan.Name = "colNilaiPersediaan"
    Me.colNilaiPersediaan.Visible = True
    Me.colNilaiPersediaan.Width = 77
    '
    'colTotalHPP
    '
    Me.colTotalHPP.AppearanceHeader.Options.UseTextOptions = True
    Me.colTotalHPP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.colTotalHPP.Caption = "Nilai HPP"
    Me.colTotalHPP.DisplayFormat.FormatString = "n0"
    Me.colTotalHPP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colTotalHPP.FieldName = "TotalHPP"
    Me.colTotalHPP.Name = "colTotalHPP"
    Me.colTotalHPP.Visible = True
    Me.colTotalHPP.Width = 82
    '
    'GridColumn1
    '
    Me.GridColumn1.Caption = "No Bukti"
    Me.GridColumn1.FieldName = "Gl.Kode"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.Visible = True
    Me.GridColumn1.Width = 100
    '
    'GridColumn2
    '
    Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.GridColumn2.Caption = "Nilai Persediaan"
    Me.GridColumn2.DisplayFormat.FormatString = "n0"
    Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn2.FieldName = "Gl.NilaiPersediaanAlias"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.Visible = True
    Me.GridColumn2.Width = 90
    '
    'GridColumn3
    '
    Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.GridColumn3.Caption = "Saldo"
    Me.GridColumn3.DisplayFormat.FormatString = "n0"
    Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.GridColumn3.FieldName = "Gl.Saldo"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.Width = 104
    '
    'colSelisih
    '
    Me.colSelisih.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
    Me.colSelisih.AppearanceHeader.Options.UseFont = True
    Me.colSelisih.AppearanceHeader.Options.UseTextOptions = True
    Me.colSelisih.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.colSelisih.Caption = "Persediaan"
    Me.colSelisih.DisplayFormat.FormatString = "n0"
    Me.colSelisih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colSelisih.FieldName = "SelisihPersediaan"
    Me.colSelisih.Name = "colSelisih"
    Me.colSelisih.Visible = True
    '
    'XpInstantFeedbackSource1
    '
    Me.XpInstantFeedbackSource1.DefaultSorting = "Tanggal DESC; Id DESC"
    Me.XpInstantFeedbackSource1.DisplayableProperties = "Id;Kode;Tanggal;Catatan;NilaiPersediaanQtyAlias;TotalQtyHPP;NilaiPersediaanAlias;" &
    "TotalHPP;Gl.Kode;Gl.NilaiPersediaanAlias;Gl.Saldo;SelisihPersediaan"
    Me.XpInstantFeedbackSource1.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.StockMain)
    '
    'GridBand1
    '
    Me.GridBand1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
    Me.GridBand1.AppearanceHeader.Options.UseFont = True
    Me.GridBand1.AppearanceHeader.Options.UseTextOptions = True
    Me.GridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridBand1.Caption = "Persediaan"
    Me.GridBand1.Columns.Add(Me.colKode)
    Me.GridBand1.Columns.Add(Me.colTanggal)
    Me.GridBand1.Columns.Add(Me.colCatatan)
    Me.GridBand1.Columns.Add(Me.colNilaiPersediaanQty)
    Me.GridBand1.Columns.Add(Me.colTotalQtyHPP)
    Me.GridBand1.Columns.Add(Me.colNilaiPersediaan)
    Me.GridBand1.Columns.Add(Me.colTotalHPP)
    Me.GridBand1.Name = "GridBand1"
    Me.GridBand1.VisibleIndex = 0
    Me.GridBand1.Width = 740
    '
    'gridBand2
    '
    Me.gridBand2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gridBand2.AppearanceHeader.Options.UseFont = True
    Me.gridBand2.AppearanceHeader.Options.UseTextOptions = True
    Me.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gridBand2.Caption = "GL"
    Me.gridBand2.Columns.Add(Me.GridColumn1)
    Me.gridBand2.Columns.Add(Me.GridColumn2)
    Me.gridBand2.Columns.Add(Me.GridColumn3)
    Me.gridBand2.Name = "gridBand2"
    Me.gridBand2.VisibleIndex = 1
    Me.gridBand2.Width = 294
    '
    'gridBand3
    '
    Me.gridBand3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
    Me.gridBand3.AppearanceHeader.Options.UseFont = True
    Me.gridBand3.AppearanceHeader.Options.UseTextOptions = True
    Me.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.gridBand3.Caption = "Selisih"
    Me.gridBand3.Columns.Add(Me.colSelisih)
    Me.gridBand3.Name = "gridBand3"
    Me.gridBand3.VisibleIndex = 2
    Me.gridBand3.Width = 75
    '
    'UI_BukuBesarStock
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1052, 496)
    Me.Name = "UI_BukuBesarStock"
    Me.Text = "Cek Nilai Persediaan"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colKode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colNilaiPersediaan As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colTotalHPP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colNilaiPersediaanQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colTotalQtyHPP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colCatatan As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents colSelisih As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents XpInstantFeedbackSource1 As DevExpress.Xpo.XPInstantFeedbackSource
  Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
