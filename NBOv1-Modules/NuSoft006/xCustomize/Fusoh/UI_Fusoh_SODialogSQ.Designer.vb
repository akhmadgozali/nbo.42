<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_Fusoh_SODialogSQ
	Inherits Core.Win.Forms.DialogForm

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
        Me.xGrid = New DevExpress.XtraGrid.GridControl()
        Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNoSJ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubtotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSpekRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colPeriodeAwal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPeriodeAkhir = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colSpekRepo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
        Me.btn1.Appearance.Options.UseForeColor = True
        Me.btn1.Location = New System.Drawing.Point(765, 11)
        '
        'btn2
        '
        Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btn2.Appearance.Options.UseForeColor = True
        Me.btn2.Location = New System.Drawing.Point(858, 11)
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(0, 446)
        Me.PanelControl1.Size = New System.Drawing.Size(957, 49)
        '
        'xGrid
        '
        Me.xGrid.Location = New System.Drawing.Point(3, 12)
        Me.xGrid.MainView = Me.xGridView
        Me.xGrid.Name = "xGrid"
        Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colSpekRepo})
        Me.xGrid.Size = New System.Drawing.Size(942, 426)
        Me.xGrid.TabIndex = 20
        Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
        '
        'xGridView
        '
        Me.xGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.xGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoSJ, Me.colNoPO, Me.colKodeBarang, Me.GridColumn2, Me.GridColumn1, Me.colQty, Me.colHarga, Me.colSubtotal, Me.colPeriodeAwal, Me.colPeriodeAkhir})
        Me.xGridView.GridControl = Me.xGrid
        Me.xGridView.Name = "xGridView"
        Me.xGridView.NewItemRowText = "Tambah Data"
        Me.xGridView.OptionsBehavior.Editable = False
        Me.xGridView.OptionsCustomization.AllowGroup = False
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.xGridView.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.xGridView.OptionsSelection.MultiSelect = True
        Me.xGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.xGridView.OptionsView.AllowHtmlDrawHeaders = True
        Me.xGridView.OptionsView.ShowAutoFilterRow = True
        Me.xGridView.OptionsView.ShowFooter = True
        Me.xGridView.OptionsView.ShowGroupPanel = False
        '
        'colNoSJ
        '
        Me.colNoSJ.Caption = "No. SQ"
        Me.colNoSJ.FieldName = "Main.Kode"
        Me.colNoSJ.Name = "colNoSJ"
        Me.colNoSJ.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colNoSJ.Visible = True
        Me.colNoSJ.VisibleIndex = 1
        Me.colNoSJ.Width = 80
        '
        'colNoPO
        '
        Me.colNoPO.Caption = "Tanggal"
        Me.colNoPO.FieldName = "Main.Tanggal"
        Me.colNoPO.Name = "colNoPO"
        Me.colNoPO.Visible = True
        Me.colNoPO.VisibleIndex = 2
        Me.colNoPO.Width = 80
        '
        'colKodeBarang
        '
        Me.colKodeBarang.Caption = "Kode Barang"
        Me.colKodeBarang.FieldName = "PartNo"
        Me.colKodeBarang.Name = "colKodeBarang"
        Me.colKodeBarang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colKodeBarang.Visible = True
        Me.colKodeBarang.VisibleIndex = 3
        Me.colKodeBarang.Width = 120
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nama Barang"
        Me.GridColumn2.FieldName = "Barang"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        Me.GridColumn2.Width = 140
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Material"
        Me.GridColumn1.FieldName = "Material"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 140
        '
        'colQty
        '
        Me.colQty.Caption = "Qty"
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 6
        Me.colQty.Width = 45
        '
        'colHarga
        '
        Me.colHarga.Caption = "Harga"
        Me.colHarga.DisplayFormat.FormatString = "n0"
        Me.colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHarga.FieldName = "Harga"
        Me.colHarga.Name = "colHarga"
        Me.colHarga.Visible = True
        Me.colHarga.VisibleIndex = 7
        Me.colHarga.Width = 70
        '
        'colSubtotal
        '
        Me.colSubtotal.Caption = "Subtotal"
        Me.colSubtotal.DisplayFormat.FormatString = "n0"
        Me.colSubtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubtotal.FieldName = "SubTotal"
        Me.colSubtotal.Name = "colSubtotal"
        Me.colSubtotal.Visible = True
        Me.colSubtotal.VisibleIndex = 8
        Me.colSubtotal.Width = 76
        '
        'colSpekRepo
        '
        Me.colSpekRepo.AutoHeight = False
        Me.colSpekRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.colSpekRepo.Name = "colSpekRepo"
        '
        'colPeriodeAwal
        '
        Me.colPeriodeAwal.Caption = "Periode Awal"
        Me.colPeriodeAwal.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colPeriodeAwal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colPeriodeAwal.FieldName = "Main.TanggalBerlakuAwal"
        Me.colPeriodeAwal.Name = "colPeriodeAwal"
        Me.colPeriodeAwal.Visible = True
        Me.colPeriodeAwal.VisibleIndex = 9
        Me.colPeriodeAwal.Width = 70
        '
        'colPeriodeAkhir
        '
        Me.colPeriodeAkhir.Caption = "Periode Akhir"
        Me.colPeriodeAkhir.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colPeriodeAkhir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colPeriodeAkhir.FieldName = "Main.TanggalBerlakuAkhir"
        Me.colPeriodeAkhir.Name = "colPeriodeAkhir"
        Me.colPeriodeAkhir.Visible = True
        Me.colPeriodeAkhir.VisibleIndex = 10
        Me.colPeriodeAkhir.Width = 70
        '
        'UI_Fusoh_SODialogSQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 495)
        Me.Controls.Add(Me.xGrid)
        Me.Name = "UI_Fusoh_SODialogSQ"
        Me.Text = "Daftar Surat Jalan"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        Me.Controls.SetChildIndex(Me.xGrid, 0)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colSpekRepo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
	Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents colSpekRepo As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
	Friend WithEvents colNoPO As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colNoSJ As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubtotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeriodeAwal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeriodeAkhir As DevExpress.XtraGrid.Columns.GridColumn
End Class
