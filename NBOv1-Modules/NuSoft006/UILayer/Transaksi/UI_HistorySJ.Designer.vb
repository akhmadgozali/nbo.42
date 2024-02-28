<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_HistorySJ
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.xGridViewDetail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSJKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSJTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSJQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSJUraian = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xGrid = New DevExpress.XtraGrid.GridControl()
        Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKodeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyDikirim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyBelumDikirim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtUraian = New DevExpress.XtraEditors.TextEdit()
        Me.txtReffNumber = New DevExpress.XtraEditors.TextEdit()
        Me.txtTanggal = New DevExpress.XtraEditors.TextEdit()
        Me.txtPelangganNama = New DevExpress.XtraEditors.TextEdit()
        Me.txtPelangganKode = New DevExpress.XtraEditors.TextEdit()
        Me.txtNomorSO = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridViewDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReffNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPelangganNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPelangganKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomorSO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xGridViewDetail
        '
        Me.xGridViewDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSJKode, Me.colSJTanggal, Me.colSJQty, Me.colSJUraian})
        Me.xGridViewDetail.GridControl = Me.xGrid
        Me.xGridViewDetail.Name = "xGridViewDetail"
        Me.xGridViewDetail.OptionsBehavior.Editable = False
        Me.xGridViewDetail.OptionsDetail.EnableMasterViewMode = False
        Me.xGridViewDetail.OptionsView.ShowGroupPanel = False
        '
        'colSJKode
        '
        Me.colSJKode.Caption = "Kode"
        Me.colSJKode.FieldName = "Main.Kode"
        Me.colSJKode.Name = "colSJKode"
        Me.colSJKode.Visible = True
        Me.colSJKode.VisibleIndex = 0
        Me.colSJKode.Width = 95
        '
        'colSJTanggal
        '
        Me.colSJTanggal.Caption = "Tanggal"
        Me.colSJTanggal.DisplayFormat.FormatString = "D"
        Me.colSJTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colSJTanggal.FieldName = "Main.Tanggal"
        Me.colSJTanggal.Name = "colSJTanggal"
        Me.colSJTanggal.Visible = True
        Me.colSJTanggal.VisibleIndex = 1
        Me.colSJTanggal.Width = 150
        '
        'colSJQty
        '
        Me.colSJQty.Caption = "Qty"
        Me.colSJQty.DisplayFormat.FormatString = "n0"
        Me.colSJQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSJQty.FieldName = "Qty"
        Me.colSJQty.Name = "colSJQty"
        Me.colSJQty.Visible = True
        Me.colSJQty.VisibleIndex = 2
        Me.colSJQty.Width = 60
        '
        'colSJUraian
        '
        Me.colSJUraian.Caption = "Uraian"
        Me.colSJUraian.FieldName = "Main.Uraian"
        Me.colSJUraian.Name = "colSJUraian"
        Me.colSJUraian.Visible = True
        Me.colSJUraian.VisibleIndex = 3
        Me.colSJUraian.Width = 453
        '
        'xGrid
        '
        GridLevelNode1.LevelTemplate = Me.xGridViewDetail
        GridLevelNode1.RelationName = "DaftarSJDetail"
        Me.xGrid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.xGrid.Location = New System.Drawing.Point(12, 102)
        Me.xGrid.MainView = Me.xGridView
        Me.xGrid.Name = "xGrid"
        Me.xGrid.ShowOnlyPredefinedDetails = True
        Me.xGrid.Size = New System.Drawing.Size(776, 363)
        Me.xGrid.TabIndex = 7
        Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView, Me.xGridViewDetail})
        '
        'xGridView
        '
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeBarang, Me.colNamaBarang, Me.colSatuan, Me.colQty, Me.colQtyDikirim, Me.colQtyBelumDikirim, Me.colCatatan})
        Me.xGridView.GridControl = Me.xGrid
        Me.xGridView.Name = "xGridView"
        Me.xGridView.OptionsBehavior.Editable = False
        Me.xGridView.OptionsDetail.AllowZoomDetail = False
        Me.xGridView.OptionsDetail.ShowDetailTabs = False
        Me.xGridView.OptionsView.ShowGroupPanel = False
        '
        'colKodeBarang
        '
        Me.colKodeBarang.Caption = "Kode Barang"
        Me.colKodeBarang.FieldName = "Barang.Kode"
        Me.colKodeBarang.Name = "colKodeBarang"
        Me.colKodeBarang.Visible = True
        Me.colKodeBarang.VisibleIndex = 0
        Me.colKodeBarang.Width = 90
        '
        'colNamaBarang
        '
        Me.colNamaBarang.Caption = "Nama Barang"
        Me.colNamaBarang.FieldName = "Barang.Nama"
        Me.colNamaBarang.Name = "colNamaBarang"
        Me.colNamaBarang.Visible = True
        Me.colNamaBarang.VisibleIndex = 1
        Me.colNamaBarang.Width = 200
        '
        'colSatuan
        '
        Me.colSatuan.Caption = "Satuan"
        Me.colSatuan.FieldName = "Satuan.Kode"
        Me.colSatuan.Name = "colSatuan"
        Me.colSatuan.Visible = True
        Me.colSatuan.VisibleIndex = 2
        Me.colSatuan.Width = 60
        '
        'colQty
        '
        Me.colQty.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colQty.AppearanceCell.Options.UseBackColor = True
        Me.colQty.Caption = "Qty"
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 3
        Me.colQty.Width = 60
        '
        'colQtyDikirim
        '
        Me.colQtyDikirim.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colQtyDikirim.AppearanceCell.Options.UseBackColor = True
        Me.colQtyDikirim.Caption = "Qty SJ"
        Me.colQtyDikirim.FieldName = "JumlahQtySJ"
        Me.colQtyDikirim.Name = "colQtyDikirim"
        Me.colQtyDikirim.Visible = True
        Me.colQtyDikirim.VisibleIndex = 4
        Me.colQtyDikirim.Width = 60
        '
        'colQtyBelumDikirim
        '
        Me.colQtyBelumDikirim.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colQtyBelumDikirim.AppearanceCell.Options.UseBackColor = True
        Me.colQtyBelumDikirim.Caption = "Qty Belum Dikirim"
        Me.colQtyBelumDikirim.FieldName = "QtyBelumDikirim"
        Me.colQtyBelumDikirim.Name = "colQtyBelumDikirim"
        Me.colQtyBelumDikirim.Visible = True
        Me.colQtyBelumDikirim.VisibleIndex = 5
        Me.colQtyBelumDikirim.Width = 90
        '
        'colCatatan
        '
        Me.colCatatan.Caption = "Catatan"
        Me.colCatatan.FieldName = "Catatan"
        Me.colCatatan.Name = "colCatatan"
        Me.colCatatan.Visible = True
        Me.colCatatan.VisibleIndex = 6
        Me.colCatatan.Width = 198
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtUraian)
        Me.LayoutControl1.Controls.Add(Me.txtReffNumber)
        Me.LayoutControl1.Controls.Add(Me.txtTanggal)
        Me.LayoutControl1.Controls.Add(Me.xGrid)
        Me.LayoutControl1.Controls.Add(Me.txtPelangganNama)
        Me.LayoutControl1.Controls.Add(Me.txtPelangganKode)
        Me.LayoutControl1.Controls.Add(Me.txtNomorSO)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(605, 266, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(800, 477)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtUraian
        '
        Me.txtUraian.Location = New System.Drawing.Point(85, 60)
        Me.txtUraian.Name = "txtUraian"
        Me.txtUraian.Properties.ReadOnly = True
        Me.txtUraian.Size = New System.Drawing.Size(703, 20)
        Me.txtUraian.StyleController = Me.LayoutControl1
        Me.txtUraian.TabIndex = 10
        '
        'txtReffNumber
        '
        Me.txtReffNumber.Location = New System.Drawing.Point(598, 12)
        Me.txtReffNumber.Name = "txtReffNumber"
        Me.txtReffNumber.Properties.ReadOnly = True
        Me.txtReffNumber.Size = New System.Drawing.Size(190, 20)
        Me.txtReffNumber.StyleController = Me.LayoutControl1
        Me.txtReffNumber.TabIndex = 9
        '
        'txtTanggal
        '
        Me.txtTanggal.Location = New System.Drawing.Point(343, 12)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Properties.ReadOnly = True
        Me.txtTanggal.Size = New System.Drawing.Size(178, 20)
        Me.txtTanggal.StyleController = Me.LayoutControl1
        Me.txtTanggal.TabIndex = 8
        '
        'txtPelangganNama
        '
        Me.txtPelangganNama.Location = New System.Drawing.Point(197, 36)
        Me.txtPelangganNama.Name = "txtPelangganNama"
        Me.txtPelangganNama.Properties.ReadOnly = True
        Me.txtPelangganNama.Size = New System.Drawing.Size(591, 20)
        Me.txtPelangganNama.StyleController = Me.LayoutControl1
        Me.txtPelangganNama.TabIndex = 6
        '
        'txtPelangganKode
        '
        Me.txtPelangganKode.Location = New System.Drawing.Point(85, 36)
        Me.txtPelangganKode.Name = "txtPelangganKode"
        Me.txtPelangganKode.Properties.ReadOnly = True
        Me.txtPelangganKode.Size = New System.Drawing.Size(108, 20)
        Me.txtPelangganKode.StyleController = Me.LayoutControl1
        Me.txtPelangganKode.TabIndex = 5
        '
        'txtNomorSO
        '
        Me.txtNomorSO.Location = New System.Drawing.Point(85, 12)
        Me.txtNomorSO.Name = "txtNomorSO"
        Me.txtNomorSO.Properties.ReadOnly = True
        Me.txtNomorSO.Size = New System.Drawing.Size(181, 20)
        Me.txtNomorSO.StyleController = Me.LayoutControl1
        Me.txtNomorSO.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem7, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(800, 477)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtNomorSO
        Me.LayoutControlItem1.CustomizationFormText = "Nomor PO   "
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(258, 24)
        Me.LayoutControlItem1.Text = "Nomor SO   "
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(70, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtPelangganKode
        Me.LayoutControlItem2.CustomizationFormText = "Vendor"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(185, 24)
        Me.LayoutControlItem2.Text = "Pelanggan"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(70, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem4.Control = Me.xGrid
        Me.LayoutControlItem4.CustomizationFormText = "Detail Order Pembelian [PO] :"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(780, 385)
        Me.LayoutControlItem4.Text = "Detail Order Penjualan [SO] :"
        Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(161, 13)
        Me.LayoutControlItem4.TextToControlDistance = 5
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtUraian
        Me.LayoutControlItem7.CustomizationFormText = "Uraian"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(780, 24)
        Me.LayoutControlItem7.Text = "Uraian"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(70, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtPelangganNama
        Me.LayoutControlItem3.CustomizationFormText = " "
        Me.LayoutControlItem3.Location = New System.Drawing.Point(185, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(595, 24)
        Me.LayoutControlItem3.Text = " "
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtTanggal
        Me.LayoutControlItem5.CustomizationFormText = "Tanggal"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(258, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(255, 24)
        Me.LayoutControlItem5.Text = "Tanggal"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(70, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtReffNumber
        Me.LayoutControlItem6.CustomizationFormText = "Gudang"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(513, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(267, 24)
        Me.LayoutControlItem6.Text = "Reff Number   "
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(70, 13)
        '
        'UI_HistorySJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 477)
        Me.Controls.Add(Me.LayoutControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UI_HistorySJ"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History Surat Jalan [SJ]"
        CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridViewDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtUraian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReffNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPelangganNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPelangganKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomorSO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtPelangganNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPelangganKode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomorSO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtReffNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTanggal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtUraian As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colKodeBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyDikirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyBelumDikirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xGridViewDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSJKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSJTanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSJUraian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSJQty As DevExpress.XtraGrid.Columns.GridColumn
End Class
