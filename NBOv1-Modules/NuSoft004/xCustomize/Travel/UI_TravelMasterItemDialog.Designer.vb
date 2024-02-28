<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_TravelMasterItemDialog
	Inherits Core.Win.Forms.InputDialog

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
        Me.txtNama = New DevExpress.XtraEditors.TextEdit()
        Me.lytMaster = New DevExpress.XtraLayout.LayoutControl()
        Me.txtHargaJual1 = New DevExpress.XtraEditors.CalcEdit()
        Me.txtHargaBeli = New DevExpress.XtraEditors.CalcEdit()
        Me.txtNote = New DevExpress.XtraEditors.MemoEdit()
        Me.txtAktif = New DevExpress.XtraEditors.CheckEdit()
        Me.txtPajakOut = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtPajakIn = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtSatuanDasar = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtSatuan = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtKode = New DevExpress.XtraEditors.TextEdit()
        Me.txtUang = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtAkunPersediaan = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAkunPendapatan = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAkunDiscPembelian = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAkunDiscPenjualan = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAkunReturPembelian = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAkunReturPenjualan = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAkunHPP = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtStockMax = New DevExpress.XtraEditors.SpinEdit()
        Me.txtStockMin = New DevExpress.XtraEditors.SpinEdit()
        Me.txtStockOrder = New DevExpress.XtraEditors.SpinEdit()
        Me.txtStockCurrent = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.tabBarangDialogGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup9 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup10 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtHargaJual2 = New DevExpress.XtraEditors.CalcEdit()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtHargaJual3 = New DevExpress.XtraEditors.CalcEdit()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtHargaJual4 = New DevExpress.XtraEditors.CalcEdit()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtHargaJual5 = New DevExpress.XtraEditors.CalcEdit()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lytMaster.SuspendLayout()
        CType(Me.txtHargaJual1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHargaBeli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAktif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPajakOut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPajakIn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSatuanDasar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSatuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAkunPersediaan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAkunPendapatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAkunDiscPembelian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAkunDiscPenjualan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAkunReturPembelian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAkunReturPenjualan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAkunHPP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockCurrent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabBarangDialogGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHargaJual2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHargaJual3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHargaJual4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHargaJual5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(109, 71)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNama.Size = New System.Drawing.Size(340, 20)
        Me.txtNama.StyleController = Me.lytMaster
        Me.txtNama.TabIndex = 101
        '
        'lytMaster
        '
        Me.lytMaster.Controls.Add(Me.txtHargaJual5)
        Me.lytMaster.Controls.Add(Me.txtHargaJual4)
        Me.lytMaster.Controls.Add(Me.txtHargaJual3)
        Me.lytMaster.Controls.Add(Me.txtHargaJual2)
        Me.lytMaster.Controls.Add(Me.txtHargaJual1)
        Me.lytMaster.Controls.Add(Me.txtHargaBeli)
        Me.lytMaster.Controls.Add(Me.txtNote)
        Me.lytMaster.Controls.Add(Me.txtAktif)
        Me.lytMaster.Controls.Add(Me.txtPajakOut)
        Me.lytMaster.Controls.Add(Me.txtPajakIn)
        Me.lytMaster.Controls.Add(Me.txtSatuanDasar)
        Me.lytMaster.Controls.Add(Me.txtSatuan)
        Me.lytMaster.Controls.Add(Me.txtKode)
        Me.lytMaster.Controls.Add(Me.txtNama)
        Me.lytMaster.Controls.Add(Me.txtUang)
        Me.lytMaster.Controls.Add(Me.txtAkunPersediaan)
        Me.lytMaster.Controls.Add(Me.txtAkunPendapatan)
        Me.lytMaster.Controls.Add(Me.txtAkunDiscPembelian)
        Me.lytMaster.Controls.Add(Me.txtAkunDiscPenjualan)
        Me.lytMaster.Controls.Add(Me.txtAkunReturPembelian)
        Me.lytMaster.Controls.Add(Me.txtAkunReturPenjualan)
        Me.lytMaster.Controls.Add(Me.txtAkunHPP)
        Me.lytMaster.Controls.Add(Me.txtStockMax)
        Me.lytMaster.Controls.Add(Me.txtStockMin)
        Me.lytMaster.Controls.Add(Me.txtStockOrder)
        Me.lytMaster.Controls.Add(Me.txtStockCurrent)
        Me.lytMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lytMaster.Location = New System.Drawing.Point(0, 0)
        Me.lytMaster.Name = "lytMaster"
        Me.lytMaster.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(703, 93, 250, 350)
        Me.lytMaster.Root = Me.LayoutControlGroup1
        Me.lytMaster.Size = New System.Drawing.Size(473, 346)
        Me.lytMaster.TabIndex = 110
        Me.lytMaster.Text = "LayoutControl1"
        '
        'txtHargaJual1
        '
        Me.txtHargaJual1.Location = New System.Drawing.Point(109, 191)
        Me.txtHargaJual1.Name = "txtHargaJual1"
        Me.txtHargaJual1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtHargaJual1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHargaJual1.Properties.DisplayFormat.FormatString = "n0"
        Me.txtHargaJual1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual1.Properties.EditFormat.FormatString = "n0"
        Me.txtHargaJual1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual1.Size = New System.Drawing.Size(340, 20)
        Me.txtHargaJual1.StyleController = Me.lytMaster
        Me.txtHargaJual1.TabIndex = 156
        '
        'txtHargaBeli
        '
        Me.txtHargaBeli.Location = New System.Drawing.Point(109, 167)
        Me.txtHargaBeli.Name = "txtHargaBeli"
        Me.txtHargaBeli.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtHargaBeli.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHargaBeli.Properties.DisplayFormat.FormatString = "n0"
        Me.txtHargaBeli.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaBeli.Properties.EditFormat.FormatString = "n0"
        Me.txtHargaBeli.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaBeli.Size = New System.Drawing.Size(340, 20)
        Me.txtHargaBeli.StyleController = Me.lytMaster
        Me.txtHargaBeli.TabIndex = 155
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(109, 142)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtNote.Size = New System.Drawing.Size(340, 180)
        Me.txtNote.StyleController = Me.lytMaster
        Me.txtNote.TabIndex = 154
        '
        'txtAktif
        '
        Me.txtAktif.Location = New System.Drawing.Point(388, 46)
        Me.txtAktif.Name = "txtAktif"
        Me.txtAktif.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtAktif.Properties.Caption = "Aktif"
        Me.txtAktif.Size = New System.Drawing.Size(61, 21)
        Me.txtAktif.StyleController = Me.lytMaster
        Me.txtAktif.TabIndex = 150
        '
        'txtPajakOut
        '
        Me.txtPajakOut.Location = New System.Drawing.Point(330, 204)
        Me.txtPajakOut.Name = "txtPajakOut"
        Me.txtPajakOut.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtPajakOut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPajakOut.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NilaiPajak", 60, "Nilai")})
        Me.txtPajakOut.Properties.DisplayMember = "Kode"
        Me.txtPajakOut.Properties.NullText = "<Pilih Pajak>"
        Me.txtPajakOut.Properties.ValueMember = "This"
        Me.txtPajakOut.Size = New System.Drawing.Size(107, 20)
        Me.txtPajakOut.StyleController = Me.lytMaster
        Me.txtPajakOut.TabIndex = 121
        '
        'txtPajakIn
        '
        Me.txtPajakIn.Location = New System.Drawing.Point(121, 204)
        Me.txtPajakIn.Name = "txtPajakIn"
        Me.txtPajakIn.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtPajakIn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPajakIn.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NilaiPajak", 60, "Nilai")})
        Me.txtPajakIn.Properties.DisplayMember = "Kode"
        Me.txtPajakIn.Properties.NullText = "<Pilih Pajak>"
        Me.txtPajakIn.Properties.ValueMember = "This"
        Me.txtPajakIn.Size = New System.Drawing.Size(105, 20)
        Me.txtPajakIn.StyleController = Me.lytMaster
        Me.txtPajakIn.TabIndex = 121
        '
        'txtSatuanDasar
        '
        Me.txtSatuanDasar.Location = New System.Drawing.Point(109, 119)
        Me.txtSatuanDasar.Name = "txtSatuanDasar"
        Me.txtSatuanDasar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtSatuanDasar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSatuanDasar.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 60, "Nama")})
        Me.txtSatuanDasar.Properties.DisplayMember = "Kode"
        Me.txtSatuanDasar.Properties.NullText = "<Pilih Satuan Dasar>"
        Me.txtSatuanDasar.Properties.ValueMember = "This"
        Me.txtSatuanDasar.Size = New System.Drawing.Size(340, 20)
        Me.txtSatuanDasar.StyleController = Me.lytMaster
        Me.txtSatuanDasar.TabIndex = 107
        '
        'txtSatuan
        '
        Me.txtSatuan.Location = New System.Drawing.Point(109, 95)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtSatuan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSatuan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 60, "Nama")})
        Me.txtSatuan.Properties.DisplayMember = "Kode"
        Me.txtSatuan.Properties.NullText = "<Pilih Satuan>"
        Me.txtSatuan.Properties.ValueMember = "This"
        Me.txtSatuan.Size = New System.Drawing.Size(340, 20)
        Me.txtSatuan.StyleController = Me.lytMaster
        Me.txtSatuan.TabIndex = 109
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(109, 46)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtKode.Size = New System.Drawing.Size(275, 20)
        Me.txtKode.StyleController = Me.lytMaster
        Me.txtKode.TabIndex = 100
        '
        'txtUang
        '
        Me.txtUang.Location = New System.Drawing.Point(109, 143)
        Me.txtUang.Name = "txtUang"
        Me.txtUang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtUang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", 30, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", 60, "Nama")})
        Me.txtUang.Properties.DisplayMember = "Kode"
        Me.txtUang.Properties.NullText = "<Pilih Mata Uang>"
        Me.txtUang.Properties.ValueMember = "This"
        Me.txtUang.Size = New System.Drawing.Size(340, 20)
        Me.txtUang.StyleController = Me.lytMaster
        Me.txtUang.TabIndex = 109
        '
        'txtAkunPersediaan
        '
        Me.txtAkunPersediaan.Location = New System.Drawing.Point(121, 73)
        Me.txtAkunPersediaan.Name = "txtAkunPersediaan"
        Me.txtAkunPersediaan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtAkunPersediaan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAkunPersediaan.Properties.DisplayMember = "Kode"
        Me.txtAkunPersediaan.Properties.NullText = "<Pilih Akun>"
        Me.txtAkunPersediaan.Properties.PopupSizeable = False
        Me.txtAkunPersediaan.Properties.ValueMember = "This"
        Me.txtAkunPersediaan.Properties.View = Me.SearchLookUpEdit1View
        Me.txtAkunPersediaan.Size = New System.Drawing.Size(106, 20)
        Me.txtAkunPersediaan.StyleController = Me.lytMaster
        Me.txtAkunPersediaan.TabIndex = 142
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsFind.AlwaysVisible = True
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.SearchLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Kode"
        Me.GridColumn1.FieldName = "Kode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 276
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nama"
        Me.GridColumn2.FieldName = "Nama"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 802
        '
        'txtAkunPendapatan
        '
        Me.txtAkunPendapatan.Location = New System.Drawing.Point(121, 97)
        Me.txtAkunPendapatan.Name = "txtAkunPendapatan"
        Me.txtAkunPendapatan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtAkunPendapatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAkunPendapatan.Properties.DisplayMember = "Kode"
        Me.txtAkunPendapatan.Properties.NullText = "<Pilih Akun>"
        Me.txtAkunPendapatan.Properties.ValueMember = "This"
        Me.txtAkunPendapatan.Properties.View = Me.GridView1
        Me.txtAkunPendapatan.Size = New System.Drawing.Size(106, 20)
        Me.txtAkunPendapatan.StyleController = Me.lytMaster
        Me.txtAkunPendapatan.TabIndex = 111
        '
        'GridView1
        '
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Kode"
        Me.GridColumn3.FieldName = "Kode"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 276
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Nama"
        Me.GridColumn4.FieldName = "Nama"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 802
        '
        'txtAkunDiscPembelian
        '
        Me.txtAkunDiscPembelian.Location = New System.Drawing.Point(121, 121)
        Me.txtAkunDiscPembelian.Name = "txtAkunDiscPembelian"
        Me.txtAkunDiscPembelian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtAkunDiscPembelian.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAkunDiscPembelian.Properties.DisplayMember = "Kode"
        Me.txtAkunDiscPembelian.Properties.NullText = "<Pilih Akun>"
        Me.txtAkunDiscPembelian.Properties.ValueMember = "This"
        Me.txtAkunDiscPembelian.Properties.View = Me.GridView2
        Me.txtAkunDiscPembelian.Size = New System.Drawing.Size(106, 20)
        Me.txtAkunDiscPembelian.StyleController = Me.lytMaster
        Me.txtAkunDiscPembelian.TabIndex = 117
        '
        'GridView2
        '
        Me.GridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsFind.AlwaysVisible = True
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn5, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Kode"
        Me.GridColumn5.FieldName = "Kode"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 276
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Nama"
        Me.GridColumn6.FieldName = "Nama"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 802
        '
        'txtAkunDiscPenjualan
        '
        Me.txtAkunDiscPenjualan.Location = New System.Drawing.Point(121, 145)
        Me.txtAkunDiscPenjualan.Name = "txtAkunDiscPenjualan"
        Me.txtAkunDiscPenjualan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtAkunDiscPenjualan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAkunDiscPenjualan.Properties.DisplayMember = "Kode"
        Me.txtAkunDiscPenjualan.Properties.NullText = "<Pilih Akun>"
        Me.txtAkunDiscPenjualan.Properties.ValueMember = "This"
        Me.txtAkunDiscPenjualan.Properties.View = Me.GridView3
        Me.txtAkunDiscPenjualan.Size = New System.Drawing.Size(106, 20)
        Me.txtAkunDiscPenjualan.StyleController = Me.lytMaster
        Me.txtAkunDiscPenjualan.TabIndex = 115
        '
        'GridView3
        '
        Me.GridView3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsFind.AlwaysVisible = True
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn7, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Kode"
        Me.GridColumn7.FieldName = "Kode"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        Me.GridColumn7.Width = 276
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Nama"
        Me.GridColumn8.FieldName = "Nama"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 802
        '
        'txtAkunReturPembelian
        '
        Me.txtAkunReturPembelian.Location = New System.Drawing.Point(331, 73)
        Me.txtAkunReturPembelian.Name = "txtAkunReturPembelian"
        Me.txtAkunReturPembelian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtAkunReturPembelian.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAkunReturPembelian.Properties.DisplayMember = "Kode"
        Me.txtAkunReturPembelian.Properties.NullText = "<Pilih Akun>"
        Me.txtAkunReturPembelian.Properties.ValueMember = "This"
        Me.txtAkunReturPembelian.Properties.View = Me.GridView4
        Me.txtAkunReturPembelian.Size = New System.Drawing.Size(106, 20)
        Me.txtAkunReturPembelian.StyleController = Me.lytMaster
        Me.txtAkunReturPembelian.TabIndex = 121
        '
        'GridView4
        '
        Me.GridView4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn10})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsFind.AlwaysVisible = True
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn9, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Kode"
        Me.GridColumn9.FieldName = "Kode"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        Me.GridColumn9.Width = 276
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Nama"
        Me.GridColumn10.FieldName = "Nama"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 1
        Me.GridColumn10.Width = 802
        '
        'txtAkunReturPenjualan
        '
        Me.txtAkunReturPenjualan.Location = New System.Drawing.Point(331, 97)
        Me.txtAkunReturPenjualan.Name = "txtAkunReturPenjualan"
        Me.txtAkunReturPenjualan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtAkunReturPenjualan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAkunReturPenjualan.Properties.DisplayMember = "Kode"
        Me.txtAkunReturPenjualan.Properties.NullText = "<Pilih Akun>"
        Me.txtAkunReturPenjualan.Properties.ValueMember = "This"
        Me.txtAkunReturPenjualan.Properties.View = Me.GridView5
        Me.txtAkunReturPenjualan.Size = New System.Drawing.Size(106, 20)
        Me.txtAkunReturPenjualan.StyleController = Me.lytMaster
        Me.txtAkunReturPenjualan.TabIndex = 119
        '
        'GridView5
        '
        Me.GridView5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn12})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsFind.AlwaysVisible = True
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn11, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Kode"
        Me.GridColumn11.FieldName = "Kode"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 0
        Me.GridColumn11.Width = 276
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Nama"
        Me.GridColumn12.FieldName = "Nama"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 1
        Me.GridColumn12.Width = 802
        '
        'txtAkunHPP
        '
        Me.txtAkunHPP.Location = New System.Drawing.Point(331, 121)
        Me.txtAkunHPP.Name = "txtAkunHPP"
        Me.txtAkunHPP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtAkunHPP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAkunHPP.Properties.DisplayMember = "Kode"
        Me.txtAkunHPP.Properties.NullText = "<Pilih Akun>"
        Me.txtAkunHPP.Properties.ValueMember = "This"
        Me.txtAkunHPP.Properties.View = Me.GridView6
        Me.txtAkunHPP.Size = New System.Drawing.Size(106, 20)
        Me.txtAkunHPP.StyleController = Me.lytMaster
        Me.txtAkunHPP.TabIndex = 113
        '
        'GridView6
        '
        Me.GridView6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn14})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsFind.AlwaysVisible = True
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        Me.GridView6.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn13, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Kode"
        Me.GridColumn13.FieldName = "Kode"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        Me.GridColumn13.Width = 276
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Nama"
        Me.GridColumn14.FieldName = "Nama"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 1
        Me.GridColumn14.Width = 802
        '
        'txtStockMax
        '
        Me.txtStockMax.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtStockMax.Location = New System.Drawing.Point(109, 94)
        Me.txtStockMax.Name = "txtStockMax"
        Me.txtStockMax.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStockMax.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtStockMax.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtStockMax.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStockMax.Properties.DisplayFormat.FormatString = "n0"
        Me.txtStockMax.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtStockMax.Properties.EditFormat.FormatString = "n0"
        Me.txtStockMax.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtStockMax.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtStockMax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtStockMax.Size = New System.Drawing.Size(340, 20)
        Me.txtStockMax.StyleController = Me.lytMaster
        Me.txtStockMax.TabIndex = 148
        '
        'txtStockMin
        '
        Me.txtStockMin.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtStockMin.Location = New System.Drawing.Point(109, 118)
        Me.txtStockMin.Name = "txtStockMin"
        Me.txtStockMin.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStockMin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtStockMin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtStockMin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStockMin.Properties.DisplayFormat.FormatString = "n0"
        Me.txtStockMin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtStockMin.Properties.EditFormat.FormatString = "n0"
        Me.txtStockMin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtStockMin.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtStockMin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtStockMin.Size = New System.Drawing.Size(340, 20)
        Me.txtStockMin.StyleController = Me.lytMaster
        Me.txtStockMin.TabIndex = 149
        '
        'txtStockOrder
        '
        Me.txtStockOrder.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtStockOrder.Location = New System.Drawing.Point(109, 70)
        Me.txtStockOrder.Name = "txtStockOrder"
        Me.txtStockOrder.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStockOrder.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtStockOrder.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtStockOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStockOrder.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtStockOrder.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtStockOrder.Properties.ReadOnly = True
        Me.txtStockOrder.Size = New System.Drawing.Size(340, 20)
        Me.txtStockOrder.StyleController = Me.lytMaster
        Me.txtStockOrder.TabIndex = 149
        '
        'txtStockCurrent
        '
        Me.txtStockCurrent.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtStockCurrent.Location = New System.Drawing.Point(109, 46)
        Me.txtStockCurrent.Name = "txtStockCurrent"
        Me.txtStockCurrent.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStockCurrent.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtStockCurrent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtStockCurrent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStockCurrent.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtStockCurrent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtStockCurrent.Properties.ReadOnly = True
        Me.txtStockCurrent.Size = New System.Drawing.Size(340, 20)
        Me.txtStockCurrent.StyleController = Me.lytMaster
        Me.txtStockCurrent.TabIndex = 149
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(473, 346)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.CustomizationFormText = "TabbedControlGroup1"
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.tabBarangDialogGeneral
        Me.TabbedControlGroup1.SelectedTabPageIndex = 0
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(453, 326)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.tabBarangDialogGeneral, Me.LayoutControlGroup3, Me.LayoutControlGroup10})
        Me.TabbedControlGroup1.Text = "TabbedControlGroup1"
        '
        'tabBarangDialogGeneral
        '
        Me.tabBarangDialogGeneral.CustomizationFormText = "General"
        Me.tabBarangDialogGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem7, Me.LayoutControlItem33, Me.LayoutControlItem28, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.EmptySpaceItem2})
        Me.tabBarangDialogGeneral.Location = New System.Drawing.Point(0, 0)
        Me.tabBarangDialogGeneral.Name = "tabBarangDialogGeneral"
        Me.tabBarangDialogGeneral.Size = New System.Drawing.Size(429, 280)
        Me.tabBarangDialogGeneral.Text = "General"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtKode
        Me.LayoutControlItem1.CustomizationFormText = "Kode"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(364, 25)
        Me.LayoutControlItem1.Text = "Kode"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtNama
        Me.LayoutControlItem2.CustomizationFormText = "Nama"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(429, 24)
        Me.LayoutControlItem2.Text = "Nama"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtSatuan
        Me.LayoutControlItem3.CustomizationFormText = "Satuan"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 49)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(429, 24)
        Me.LayoutControlItem3.Text = "Satuan"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtSatuanDasar
        Me.LayoutControlItem4.CustomizationFormText = "Satuan Dasar"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 73)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(429, 24)
        Me.LayoutControlItem4.Text = "Satuan Dasar"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtUang
        Me.LayoutControlItem7.CustomizationFormText = "Uang"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 97)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(429, 24)
        Me.LayoutControlItem7.Text = "Uang"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.txtHargaBeli
        Me.LayoutControlItem33.CustomizationFormText = "Harga Beli"
        Me.LayoutControlItem33.Location = New System.Drawing.Point(0, 121)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(429, 24)
        Me.LayoutControlItem33.Text = "Harga Beli"
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.txtAktif
        Me.LayoutControlItem28.CustomizationFormText = "Aktif"
        Me.LayoutControlItem28.Location = New System.Drawing.Point(364, 0)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(65, 25)
        Me.LayoutControlItem28.Text = "Aktif"
        Me.LayoutControlItem28.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem28.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem28.TextToControlDistance = 0
        Me.LayoutControlItem28.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtHargaJual1
        Me.LayoutControlItem5.CustomizationFormText = "Harga Jual"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 145)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(429, 24)
        Me.LayoutControlItem5.Text = "Harga Jual 1"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "Akuntansi"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup8, Me.LayoutControlGroup9, Me.EmptySpaceItem1})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(429, 280)
        Me.LayoutControlGroup3.Text = "Akuntansi"
        '
        'LayoutControlGroup8
        '
        Me.LayoutControlGroup8.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup8.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup8.CustomizationFormText = "Akun"
        Me.LayoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem15, Me.LayoutControlItem17, Me.LayoutControlItem21, Me.LayoutControlItem20, Me.LayoutControlItem16, Me.LayoutControlItem19, Me.LayoutControlItem18})
        Me.LayoutControlGroup8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup8.Name = "LayoutControlGroup8"
        Me.LayoutControlGroup8.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 5, 5)
        Me.LayoutControlGroup8.Size = New System.Drawing.Size(429, 131)
        Me.LayoutControlGroup8.Text = "Akun"
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtAkunPersediaan
        Me.LayoutControlItem15.CustomizationFormText = "Persediaan"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem15.Text = "Persediaan"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.txtAkunHPP
        Me.LayoutControlItem17.CustomizationFormText = "HPP"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(195, 48)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(210, 48)
        Me.LayoutControlItem17.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.LayoutControlItem17.Text = "HPP"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtAkunReturPembelian
        Me.LayoutControlItem21.CustomizationFormText = "Retur Pembelian"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(195, 0)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(210, 24)
        Me.LayoutControlItem21.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.LayoutControlItem21.Text = "Retur Pembelian"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.txtAkunReturPenjualan
        Me.LayoutControlItem20.CustomizationFormText = "Retur Penjualan"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(195, 24)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(210, 24)
        Me.LayoutControlItem20.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.LayoutControlItem20.Text = "Retur Penjualan"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtAkunPendapatan
        Me.LayoutControlItem16.CustomizationFormText = "Pendapatan"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem16.Text = "Pendapatan"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txtAkunDiscPembelian
        Me.LayoutControlItem19.CustomizationFormText = "Diskon Pembelian"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem19.Text = "Diskon Pembelian"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtAkunDiscPenjualan
        Me.LayoutControlItem18.CustomizationFormText = "Diskon Penjualan"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem18.Text = "Diskon Penjualan"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlGroup9
        '
        Me.LayoutControlGroup9.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup9.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup9.CustomizationFormText = "Pajak"
        Me.LayoutControlGroup9.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem22, Me.LayoutControlItem23})
        Me.LayoutControlGroup9.Location = New System.Drawing.Point(0, 131)
        Me.LayoutControlGroup9.Name = "LayoutControlGroup9"
        Me.LayoutControlGroup9.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 5, 5)
        Me.LayoutControlGroup9.Size = New System.Drawing.Size(429, 59)
        Me.LayoutControlGroup9.Text = "Pajak"
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtPajakIn
        Me.LayoutControlItem22.CustomizationFormText = "Pajak IN"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(194, 24)
        Me.LayoutControlItem22.Text = "Pajak IN"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.txtPajakOut
        Me.LayoutControlItem23.CustomizationFormText = "Pajak Out"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(194, 0)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(211, 24)
        Me.LayoutControlItem23.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0)
        Me.LayoutControlItem23.Text = "Pajak Out"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlGroup10
        '
        Me.LayoutControlGroup10.CustomizationFormText = "Lain-lain"
        Me.LayoutControlGroup10.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem32, Me.LayoutControlItem26, Me.LayoutControlItem27, Me.LayoutControlItem24, Me.LayoutControlItem25})
        Me.LayoutControlGroup10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup10.Name = "LayoutControlGroup10"
        Me.LayoutControlGroup10.Size = New System.Drawing.Size(429, 280)
        Me.LayoutControlGroup10.Text = "Lain-lain"
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem32.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LayoutControlItem32.Control = Me.txtNote
        Me.LayoutControlItem32.CustomizationFormText = "Note"
        Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(429, 184)
        Me.LayoutControlItem32.Text = "Note"
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.txtStockCurrent
        Me.LayoutControlItem26.CustomizationFormText = "Stock"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(429, 24)
        Me.LayoutControlItem26.Text = "Stock"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.txtStockOrder
        Me.LayoutControlItem27.CustomizationFormText = "Stock Order"
        Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(429, 24)
        Me.LayoutControlItem27.Text = "Stock Order"
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.txtStockMax
        Me.LayoutControlItem24.CustomizationFormText = "Stock Maksimal"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(429, 24)
        Me.LayoutControlItem24.Text = "Stock Maksimal"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.txtStockMin
        Me.LayoutControlItem25.CustomizationFormText = "Stock Minimal"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(429, 24)
        Me.LayoutControlItem25.Text = "Stock Minimal"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(82, 13)
        '
        'txtHargaJual2
        '
        Me.txtHargaJual2.Location = New System.Drawing.Point(109, 215)
        Me.txtHargaJual2.Name = "txtHargaJual2"
        Me.txtHargaJual2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtHargaJual2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHargaJual2.Properties.DisplayFormat.FormatString = "n0"
        Me.txtHargaJual2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual2.Properties.EditFormat.FormatString = "n0"
        Me.txtHargaJual2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual2.Size = New System.Drawing.Size(340, 20)
        Me.txtHargaJual2.StyleController = Me.lytMaster
        Me.txtHargaJual2.TabIndex = 157
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtHargaJual2
        Me.LayoutControlItem6.CustomizationFormText = "Harga Jual 2"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 169)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(429, 24)
        Me.LayoutControlItem6.Text = "Harga Jual 2"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(82, 13)
        '
        'txtHargaJual3
        '
        Me.txtHargaJual3.Location = New System.Drawing.Point(109, 239)
        Me.txtHargaJual3.Name = "txtHargaJual3"
        Me.txtHargaJual3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtHargaJual3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHargaJual3.Properties.DisplayFormat.FormatString = "n0"
        Me.txtHargaJual3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual3.Properties.EditFormat.FormatString = "n0"
        Me.txtHargaJual3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual3.Size = New System.Drawing.Size(340, 20)
        Me.txtHargaJual3.StyleController = Me.lytMaster
        Me.txtHargaJual3.TabIndex = 157
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtHargaJual3
        Me.LayoutControlItem8.CustomizationFormText = "Harga Jual 3"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 193)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(429, 24)
        Me.LayoutControlItem8.Text = "Harga Jual 3"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(82, 13)
        '
        'txtHargaJual4
        '
        Me.txtHargaJual4.Location = New System.Drawing.Point(109, 263)
        Me.txtHargaJual4.Name = "txtHargaJual4"
        Me.txtHargaJual4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtHargaJual4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHargaJual4.Properties.DisplayFormat.FormatString = "n0"
        Me.txtHargaJual4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual4.Properties.EditFormat.FormatString = "n0"
        Me.txtHargaJual4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual4.Size = New System.Drawing.Size(340, 20)
        Me.txtHargaJual4.StyleController = Me.lytMaster
        Me.txtHargaJual4.TabIndex = 157
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtHargaJual4
        Me.LayoutControlItem9.CustomizationFormText = "Harga Jual 4"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 217)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(429, 24)
        Me.LayoutControlItem9.Text = "Harga Jual 4"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(82, 13)
        '
        'txtHargaJual5
        '
        Me.txtHargaJual5.Location = New System.Drawing.Point(109, 287)
        Me.txtHargaJual5.Name = "txtHargaJual5"
        Me.txtHargaJual5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtHargaJual5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHargaJual5.Properties.DisplayFormat.FormatString = "n0"
        Me.txtHargaJual5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual5.Properties.EditFormat.FormatString = "n0"
        Me.txtHargaJual5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHargaJual5.Size = New System.Drawing.Size(340, 20)
        Me.txtHargaJual5.StyleController = Me.lytMaster
        Me.txtHargaJual5.TabIndex = 157
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtHargaJual5
        Me.LayoutControlItem10.CustomizationFormText = "Harga Jual 5"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 241)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(429, 24)
        Me.LayoutControlItem10.Text = "Harga Jual 5"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(82, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 190)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(429, 90)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 265)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(429, 15)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'UI_TravelMasterItemDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 395)
        Me.Controls.Add(Me.lytMaster)
        Me.Name = "UI_TravelMasterItemDialog"
        Me.Text = "Master ITEM"
        Me.Controls.SetChildIndex(Me.lytMaster, 0)
        CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lytMaster.ResumeLayout(False)
        CType(Me.txtHargaJual1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHargaBeli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAktif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPajakOut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPajakIn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSatuanDasar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSatuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAkunPersediaan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAkunPendapatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAkunDiscPembelian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAkunDiscPenjualan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAkunReturPembelian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAkunReturPenjualan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAkunHPP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockMax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockMin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockCurrent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabBarangDialogGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHargaJual2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHargaJual3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHargaJual4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHargaJual5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNama As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtKode As DevExpress.XtraEditors.TextEdit
	Friend WithEvents txtSatuanDasar As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents txtUang As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents txtPajakOut As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents txtPajakIn As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtSatuan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lytMaster As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtAktif As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtHargaBeli As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtAkunPersediaan As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAkunPendapatan As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAkunDiscPembelian As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAkunDiscPenjualan As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAkunReturPembelian As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAkunReturPenjualan As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAkunHPP As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup9 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup10 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents tabBarangDialogGeneral As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtHargaJual1 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtStockMax As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtStockMin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtStockOrder As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtStockCurrent As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtHargaJual5 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtHargaJual4 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtHargaJual3 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtHargaJual2 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
