<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_BarangLokasi
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
		Me.components = New System.ComponentModel.Container()
		Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
		Me.gridLokasi = New DevExpress.XtraGrid.GridControl()
		Me.gridLokasiView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLokasi = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
		Me.Bar3 = New DevExpress.XtraBars.Bar()
		Me.btnCetak = New DevExpress.XtraBars.BarButtonItem()
		Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
		Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gridLokasi, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gridLokasiView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'XpCollection1
		'
		Me.XpCollection1.DisplayableProperties = "This;created_date;created_user;last_date;last_modified;Id;Lokasi;Barang.Kode;Bara" &
		"ng.Nama;Gudang.Kode"
		Me.XpCollection1.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.BarangLokasi)
		'
		'gridLokasi
		'
		Me.gridLokasi.DataSource = Me.XpCollection1
		Me.gridLokasi.Dock = System.Windows.Forms.DockStyle.Fill
		Me.gridLokasi.Location = New System.Drawing.Point(0, 0)
		Me.gridLokasi.MainView = Me.gridLokasiView
		Me.gridLokasi.Name = "gridLokasi"
		Me.gridLokasi.Size = New System.Drawing.Size(800, 425)
		Me.gridLokasi.TabIndex = 0
		Me.gridLokasi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridLokasiView})
		'
		'gridLokasiView
		'
		Me.gridLokasiView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn1, Me.colLokasi})
		Me.gridLokasiView.GridControl = Me.gridLokasi
		Me.gridLokasiView.GroupCount = 1
		Me.gridLokasiView.Name = "gridLokasiView"
		Me.gridLokasiView.OptionsDetail.EnableMasterViewMode = False
		Me.gridLokasiView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)})
		'
		'GridColumn2
		'
		Me.GridColumn2.Caption = "Kode Barang"
		Me.GridColumn2.FieldName = "Barang.Kode"
		Me.GridColumn2.Name = "GridColumn2"
		Me.GridColumn2.Visible = True
		Me.GridColumn2.VisibleIndex = 0
		'
		'GridColumn1
		'
		Me.GridColumn1.Caption = "Gudang"
		Me.GridColumn1.FieldName = "Gudang.Kode"
		Me.GridColumn1.Name = "GridColumn1"
		Me.GridColumn1.Visible = True
		Me.GridColumn1.VisibleIndex = 1
		'
		'colLokasi
		'
		Me.colLokasi.FieldName = "Lokasi"
		Me.colLokasi.Name = "colLokasi"
		Me.colLokasi.Visible = True
		Me.colLokasi.VisibleIndex = 2
		'
		'BarManager1
		'
		Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
		Me.BarManager1.DockControls.Add(Me.barDockControlTop)
		Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
		Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
		Me.BarManager1.DockControls.Add(Me.barDockControlRight)
		Me.BarManager1.Form = Me
		Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnCetak})
		Me.BarManager1.MaxItemId = 1
		Me.BarManager1.StatusBar = Me.Bar3
		'
		'Bar3
		'
		Me.Bar3.BarName = "Status bar"
		Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
		Me.Bar3.DockCol = 0
		Me.Bar3.DockRow = 0
		Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
		Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnCetak)})
		Me.Bar3.OptionsBar.AllowQuickCustomization = False
		Me.Bar3.OptionsBar.DrawDragBorder = False
		Me.Bar3.OptionsBar.UseWholeRow = True
		Me.Bar3.Text = "Status bar"
		'
		'btnCetak
		'
		Me.btnCetak.Caption = "Cetak"
		Me.btnCetak.Id = 0
		Me.btnCetak.Name = "btnCetak"
		'
		'barDockControlTop
		'
		Me.barDockControlTop.CausesValidation = False
		Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
		Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
		Me.barDockControlTop.Size = New System.Drawing.Size(800, 0)
		'
		'barDockControlBottom
		'
		Me.barDockControlBottom.CausesValidation = False
		Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.barDockControlBottom.Location = New System.Drawing.Point(0, 425)
		Me.barDockControlBottom.Size = New System.Drawing.Size(800, 25)
		'
		'barDockControlLeft
		'
		Me.barDockControlLeft.CausesValidation = False
		Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
		Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
		Me.barDockControlLeft.Size = New System.Drawing.Size(0, 425)
		'
		'barDockControlRight
		'
		Me.barDockControlRight.CausesValidation = False
		Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
		Me.barDockControlRight.Location = New System.Drawing.Point(800, 0)
		Me.barDockControlRight.Size = New System.Drawing.Size(0, 425)
		'
		'GridColumn3
		'
		Me.GridColumn3.Caption = "Nama Barang"
		Me.GridColumn3.FieldName = "Barang.Nama"
		Me.GridColumn3.Name = "GridColumn3"
		Me.GridColumn3.Visible = True
		Me.GridColumn3.VisibleIndex = 0
		'
		'UI_BarangLokasi
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.gridLokasi)
		Me.Controls.Add(Me.barDockControlLeft)
		Me.Controls.Add(Me.barDockControlRight)
		Me.Controls.Add(Me.barDockControlBottom)
		Me.Controls.Add(Me.barDockControlTop)
		Me.Name = "UI_BarangLokasi"
		Me.Text = "Daftar Lokasi Barang"
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gridLokasi, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gridLokasiView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
	Friend WithEvents gridLokasi As DevExpress.XtraGrid.GridControl
	Friend WithEvents gridLokasiView As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
	Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
	Friend WithEvents btnCetak As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
	Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
	Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
	Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
	Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colLokasi As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
End Class
