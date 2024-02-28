<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_SanYuPengirimanBarangDialogFindProduksi
  Inherits Core.Win.Forms.DialogForm

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
    Me.xGrid = New DevExpress.XtraGrid.GridControl()
    Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoProduksi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggalx = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelControl1.SuspendLayout()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btn1
    '
    Me.btn1.Appearance.ForeColor = System.Drawing.Color.Green
    Me.btn1.Appearance.Options.UseForeColor = True
    Me.btn1.Location = New System.Drawing.Point(380, 11)
    '
    'btn2
    '
    Me.btn2.Appearance.ForeColor = System.Drawing.Color.Red
    Me.btn2.Appearance.Options.UseForeColor = True
    Me.btn2.Location = New System.Drawing.Point(473, 11)
    '
    'PanelControl1
    '
    Me.PanelControl1.Location = New System.Drawing.Point(0, 334)
    Me.PanelControl1.Size = New System.Drawing.Size(572, 49)
    '
    'xGrid
    '
    Me.xGrid.DataSource = Me.XpCollection1
    Me.xGrid.Location = New System.Drawing.Point(12, 12)
    Me.xGrid.MainView = Me.xGridView
    Me.xGrid.Name = "xGrid"
    Me.xGrid.Size = New System.Drawing.Size(548, 316)
    Me.xGrid.TabIndex = 20
    Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
    '
    'xGridView
    '
    Me.xGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.xGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.xGridView.ColumnPanelRowHeight = 30
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNoProduksi, Me.colTanggalx})
    Me.xGridView.GridControl = Me.xGrid
    Me.xGridView.Name = "xGridView"
    Me.xGridView.NewItemRowText = "Tambah Data"
    Me.xGridView.OptionsCustomization.AllowGroup = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsNavigation.EnterMoveNextColumn = True
    Me.xGridView.OptionsSelection.CheckBoxSelectorColumnWidth = 23
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
    Me.xGridView.OptionsView.AllowHtmlDrawHeaders = True
    Me.xGridView.OptionsView.ShowAutoFilterRow = True
    Me.xGridView.OptionsView.ShowGroupPanel = False
    '
    'colId
    '
    Me.colId.Caption = "GridColumn1"
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    '
    'colNoProduksi
    '
    Me.colNoProduksi.Caption = "No Produksi"
    Me.colNoProduksi.FieldName = "Main.Kode"
    Me.colNoProduksi.Name = "colNoProduksi"
    Me.colNoProduksi.Visible = True
    Me.colNoProduksi.VisibleIndex = 1
    '
    'colTanggalx
    '
    Me.colTanggalx.Caption = "Tanggal"
    Me.colTanggalx.FieldName = "Main.Tanggal"
    Me.colTanggalx.Name = "colTanggalx"
    Me.colTanggalx.Visible = True
    Me.colTanggalx.VisibleIndex = 2
    '
    'XpCollection1
    '
    Me.XpCollection1.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.SanYu_PengirimanBarangDetail)
    '
    'UI_SanYuPengirimanBarangDialogFindProduksi
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(572, 383)
    Me.Controls.Add(Me.xGrid)
    Me.Name = "UI_SanYuPengirimanBarangDialogFindProduksi"
    Me.Text = "UI_SanYuPengirimanBarangDialogFindProduksi"
    Me.Controls.SetChildIndex(Me.PanelControl1, 0)
    Me.Controls.SetChildIndex(Me.xGrid, 0)
    CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelControl1.ResumeLayout(False)
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoProduksi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggalx As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
End Class
