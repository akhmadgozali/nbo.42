<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_OrderPenjualanDialogSQ
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
        Me.colNoSQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSpekRepo = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubtotal = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.btn1.Location = New System.Drawing.Point(797, 11)
        '
        'btn2
        '
        Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btn2.Appearance.Options.UseForeColor = True
        Me.btn2.Location = New System.Drawing.Point(890, 11)
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(0, 446)
        Me.PanelControl1.Size = New System.Drawing.Size(989, 49)
        '
        'xGrid
        '
        Me.xGrid.Location = New System.Drawing.Point(3, 12)
        Me.xGrid.MainView = Me.xGridView
        Me.xGrid.Name = "xGrid"
        Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colSpekRepo})
        Me.xGrid.Size = New System.Drawing.Size(974, 426)
        Me.xGrid.TabIndex = 20
        Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
        '
        'xGridView
        '
        Me.xGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.xGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoSQ, Me.colTanggal, Me.colKodeBarang, Me.colNamaBarang, Me.colQty, Me.colHarga, Me.colSubtotal})
        Me.xGridView.GridControl = Me.xGrid
        Me.xGridView.Name = "xGridView"
        Me.xGridView.NewItemRowText = "Tambah Data"
        Me.xGridView.OptionsCustomization.AllowGroup = False
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.xGridView.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.xGridView.OptionsSelection.MultiSelect = True
        Me.xGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.xGridView.OptionsView.AllowHtmlDrawHeaders = True
        Me.xGridView.OptionsView.ShowAutoFilterRow = True
        Me.xGridView.OptionsView.ShowGroupPanel = False
        '
        'colNoSQ
        '
        Me.colNoSQ.Caption = "No. SQ"
        Me.colNoSQ.FieldName = "Main.Kode"
        Me.colNoSQ.Name = "colNoSQ"
        Me.colNoSQ.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colNoSQ.Visible = True
        Me.colNoSQ.VisibleIndex = 1
        Me.colNoSQ.Width = 110
        '
        'colTanggal
        '
        Me.colTanggal.Caption = "Tanggal"
        Me.colTanggal.FieldName = "Main.Tanggal"
        Me.colTanggal.Name = "colTanggal"
        Me.colTanggal.OptionsColumn.AllowEdit = False
        Me.colTanggal.OptionsColumn.ReadOnly = True
        Me.colTanggal.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colTanggal.Visible = True
        Me.colTanggal.VisibleIndex = 2
        Me.colTanggal.Width = 130
        '
        'colKodeBarang
        '
        Me.colKodeBarang.Caption = "Kode Barang"
        Me.colKodeBarang.FieldName = "Barang.Kode"
        Me.colKodeBarang.Name = "colKodeBarang"
        Me.colKodeBarang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colKodeBarang.Visible = True
        Me.colKodeBarang.VisibleIndex = 3
        Me.colKodeBarang.Width = 160
        '
        'colNamaBarang
        '
        Me.colNamaBarang.Caption = "Nama Barang"
        Me.colNamaBarang.FieldName = "Barang.Nama"
        Me.colNamaBarang.Name = "colNamaBarang"
        Me.colNamaBarang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colNamaBarang.Visible = True
        Me.colNamaBarang.VisibleIndex = 4
        Me.colNamaBarang.Width = 300
        '
        'colQty
        '
        Me.colQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQty.Caption = "Qty"
        Me.colQty.DisplayFormat.FormatString = "n0"
        Me.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQty.FieldName = "QtyBelumSO"
        Me.colQty.Name = "colQty"
        Me.colQty.OptionsColumn.AllowEdit = False
        Me.colQty.OptionsColumn.ReadOnly = True
        Me.colQty.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 5
        Me.colQty.Width = 60
        '
        'colSpekRepo
        '
        Me.colSpekRepo.AutoHeight = False
        Me.colSpekRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.colSpekRepo.Name = "colSpekRepo"
        '
        'colHarga
        '
        Me.colHarga.AppearanceHeader.Options.UseTextOptions = True
        Me.colHarga.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colHarga.Caption = "Harga"
        Me.colHarga.DisplayFormat.FormatString = "n0"
        Me.colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHarga.FieldName = "Harga"
        Me.colHarga.Name = "colHarga"
        Me.colHarga.Visible = True
        Me.colHarga.VisibleIndex = 6
        Me.colHarga.Width = 76
        '
        'colSubtotal
        '
        Me.colSubtotal.AppearanceHeader.Options.UseTextOptions = True
        Me.colSubtotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSubtotal.Caption = "Sub Total"
        Me.colSubtotal.DisplayFormat.FormatString = "n0"
        Me.colSubtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubtotal.FieldName = "SubTotal"
        Me.colSubtotal.Name = "colSubtotal"
        Me.colSubtotal.Visible = True
        Me.colSubtotal.VisibleIndex = 7
        Me.colSubtotal.Width = 90
        '
        'UI_OrderPenjualanDialogSQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 495)
        Me.Controls.Add(Me.xGrid)
        Me.Name = "UI_OrderPenjualanDialogSQ"
        Me.Text = "Daftar Penawaran [SQ]"
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
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoSQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubtotal As DevExpress.XtraGrid.Columns.GridColumn
End Class
