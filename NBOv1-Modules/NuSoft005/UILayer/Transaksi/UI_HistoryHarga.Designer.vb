<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_HistoryHarga
    Inherits Core.Win.Forms.BlankForm

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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtNamaBarang = New DevExpress.XtraEditors.TextEdit()
        Me.txtKodeBarang = New DevExpress.XtraEditors.TextEdit()
        Me.xGrid = New DevExpress.XtraGrid.GridControl()
        Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.colNamaSupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKodeSupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtNamaBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKodeBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtNamaBarang)
        Me.LayoutControl1.Controls.Add(Me.txtKodeBarang)
        Me.LayoutControl1.Controls.Add(Me.xGrid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(570, 239, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1008, 450)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(88, 36)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Properties.ReadOnly = True
        Me.txtNamaBarang.Size = New System.Drawing.Size(908, 20)
        Me.txtNamaBarang.StyleController = Me.LayoutControl1
        Me.txtNamaBarang.TabIndex = 6
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Location = New System.Drawing.Point(88, 12)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Properties.ReadOnly = True
        Me.txtKodeBarang.Size = New System.Drawing.Size(908, 20)
        Me.txtKodeBarang.StyleController = Me.LayoutControl1
        Me.txtKodeBarang.TabIndex = 5
        '
        'xGrid
        '
        Me.xGrid.Location = New System.Drawing.Point(12, 72)
        Me.xGrid.MainView = Me.xGridView
        Me.xGrid.Name = "xGrid"
        Me.xGrid.Size = New System.Drawing.Size(984, 366)
        Me.xGrid.TabIndex = 4
        Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
        '
        'xGridView
        '
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKode, Me.colTanggal, Me.colKodeSupplier, Me.colNamaSupplier, Me.colHarga, Me.colQty, Me.colSatuan, Me.colKeterangan})
        Me.xGridView.GridControl = Me.xGrid
        Me.xGridView.Name = "xGridView"
        Me.xGridView.OptionsBehavior.Editable = False
        Me.xGridView.OptionsView.ShowGroupPanel = False
        '
        'colKode
        '
        Me.colKode.Caption = "Kode Transaksi"
        Me.colKode.Name = "colKode"
        Me.colKode.Visible = True
        Me.colKode.VisibleIndex = 0
        Me.colKode.Width = 90
        '
        'colTanggal
        '
        Me.colTanggal.Caption = "Tanggal"
        Me.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTanggal.Name = "colTanggal"
        Me.colTanggal.Visible = True
        Me.colTanggal.VisibleIndex = 1
        Me.colTanggal.Width = 90
        '
        'colHarga
        '
        Me.colHarga.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colHarga.AppearanceCell.Options.UseBackColor = True
        Me.colHarga.AppearanceHeader.Options.UseTextOptions = True
        Me.colHarga.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colHarga.Caption = "Harga"
        Me.colHarga.DisplayFormat.FormatString = "n0"
        Me.colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHarga.Name = "colHarga"
        Me.colHarga.Visible = True
        Me.colHarga.VisibleIndex = 4
        Me.colHarga.Width = 90
        '
        'colQty
        '
        Me.colQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQty.Caption = "Qty"
        Me.colQty.DisplayFormat.FormatString = "n0"
        Me.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQty.Name = "colQty"
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 5
        Me.colQty.Width = 60
        '
        'colSatuan
        '
        Me.colSatuan.Caption = "Satuan"
        Me.colSatuan.Name = "colSatuan"
        Me.colSatuan.Visible = True
        Me.colSatuan.VisibleIndex = 6
        Me.colSatuan.Width = 90
        '
        'colKeterangan
        '
        Me.colKeterangan.Caption = "Keterangan"
        Me.colKeterangan.Name = "colKeterangan"
        Me.colKeterangan.Visible = True
        Me.colKeterangan.VisibleIndex = 7
        Me.colKeterangan.Width = 256
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1008, 450)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.xGrid
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(988, 370)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtKodeBarang
        Me.LayoutControlItem2.CustomizationFormText = "Kode Barang"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(988, 24)
        Me.LayoutControlItem2.Text = "Kode Barang"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(73, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtNamaBarang
        Me.LayoutControlItem3.CustomizationFormText = "Nama Barang   "
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(988, 24)
        Me.LayoutControlItem3.Text = "Nama Barang   "
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(73, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 48)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(988, 12)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'colNamaSupplier
        '
        Me.colNamaSupplier.Caption = "Nama Supplier"
        Me.colNamaSupplier.Name = "colNamaSupplier"
        Me.colNamaSupplier.Visible = True
        Me.colNamaSupplier.VisibleIndex = 3
        Me.colNamaSupplier.Width = 200
        '
        'colKodeSupplier
        '
        Me.colKodeSupplier.Caption = "Kode Supplier"
        Me.colKodeSupplier.Name = "colKodeSupplier"
        Me.colKodeSupplier.Visible = True
        Me.colKodeSupplier.VisibleIndex = 2
        Me.colKodeSupplier.Width = 90
        '
        'UI_HistoryHarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 450)
        Me.Controls.Add(Me.LayoutControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UI_HistoryHarga"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History Harga"
        CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtNamaBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKodeBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNamaBarang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKodeBarang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKodeSupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaSupplier As DevExpress.XtraGrid.Columns.GridColumn
End Class
