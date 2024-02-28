<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_SanYuKuotaImpor
  Inherits Core.Win.Forms.GridInput

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
    Me.colKodeHS = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoLampiran = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colVolume = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colMataUang = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNegara = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPelabuhan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colExpired = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colSisa = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTerpakai = New DevExpress.XtraGrid.Columns.GridColumn()
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
    '
    'xpCol
    '
    Me.xpCol.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent.SanYu_KuotaImpor)
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKodeHS, Me.colNoLampiran, Me.colVolume, Me.colTerpakai, Me.colSisa, Me.colSatuan, Me.colHarga, Me.colMataUang, Me.colNegara, Me.colPelabuhan, Me.colExpired, Me.colKeterangan, Me.colId})
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    '
    'barMenu
    '
    Me.barMenu.OptionsBar.AllowQuickCustomization = False
    Me.barMenu.OptionsBar.DrawDragBorder = False
    Me.barMenu.OptionsBar.UseWholeRow = True
    '
    'colKodeHS
    '
    Me.colKodeHS.FieldName = "KodeHS"
    Me.colKodeHS.Name = "colKodeHS"
    Me.colKodeHS.Visible = True
    Me.colKodeHS.VisibleIndex = 0
    '
    'colKeterangan
    '
    Me.colKeterangan.FieldName = "Keterangan"
    Me.colKeterangan.Name = "colKeterangan"
    Me.colKeterangan.Visible = True
    Me.colKeterangan.VisibleIndex = 11
    '
    'colNoLampiran
    '
    Me.colNoLampiran.FieldName = "NoLampiran"
    Me.colNoLampiran.Name = "colNoLampiran"
    Me.colNoLampiran.Visible = True
    Me.colNoLampiran.VisibleIndex = 1
    '
    'colVolume
    '
    Me.colVolume.DisplayFormat.FormatString = "n2"
    Me.colVolume.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colVolume.FieldName = "Volume"
    Me.colVolume.Name = "colVolume"
    Me.colVolume.Visible = True
    Me.colVolume.VisibleIndex = 2
    '
    'colSatuan
    '
    Me.colSatuan.Caption = "Satuan"
    Me.colSatuan.FieldName = "Satuan.Kode"
    Me.colSatuan.Name = "colSatuan"
    Me.colSatuan.OptionsColumn.ReadOnly = True
    Me.colSatuan.Visible = True
    Me.colSatuan.VisibleIndex = 5
    '
    'colHarga
    '
    Me.colHarga.DisplayFormat.FormatString = "n0"
    Me.colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colHarga.FieldName = "Harga"
    Me.colHarga.Name = "colHarga"
    Me.colHarga.Visible = True
    Me.colHarga.VisibleIndex = 6
    '
    'colMataUang
    '
    Me.colMataUang.Caption = "Mata Uang"
    Me.colMataUang.FieldName = "MataUang.Kode"
    Me.colMataUang.Name = "colMataUang"
    Me.colMataUang.OptionsColumn.ReadOnly = True
    Me.colMataUang.Visible = True
    Me.colMataUang.VisibleIndex = 7
    '
    'colNegara
    '
    Me.colNegara.FieldName = "Negara"
    Me.colNegara.Name = "colNegara"
    Me.colNegara.Visible = True
    Me.colNegara.VisibleIndex = 8
    '
    'colPelabuhan
    '
    Me.colPelabuhan.FieldName = "Pelabuhan"
    Me.colPelabuhan.Name = "colPelabuhan"
    Me.colPelabuhan.Visible = True
    Me.colPelabuhan.VisibleIndex = 9
    '
    'colExpired
    '
    Me.colExpired.DisplayFormat.FormatString = "dd-MMM-yy"
    Me.colExpired.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colExpired.FieldName = "Expired"
    Me.colExpired.Name = "colExpired"
    Me.colExpired.Visible = True
    Me.colExpired.VisibleIndex = 10
    '
    'colId
    '
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    '
    'colSisa
    '
    Me.colSisa.Caption = "Sisa Volume"
    Me.colSisa.DisplayFormat.FormatString = "n4"
    Me.colSisa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colSisa.FieldName = "SisaVolume"
    Me.colSisa.Name = "colSisa"
    Me.colSisa.Visible = True
    Me.colSisa.VisibleIndex = 4
    '
    'colTerpakai
    '
    Me.colTerpakai.Caption = "Terpakai"
    Me.colTerpakai.DisplayFormat.FormatString = "n4"
    Me.colTerpakai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    Me.colTerpakai.FieldName = "VolumeTerpakai"
    Me.colTerpakai.Name = "colTerpakai"
    Me.colTerpakai.Visible = True
    Me.colTerpakai.VisibleIndex = 3
    '
    'UI_SanYuKuotaImpor
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 395)
    Me.Name = "UI_SanYuKuotaImpor"
    Me.Text = "Kuota Impor"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents colKodeHS As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoLampiran As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colVolume As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colMataUang As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNegara As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPelabuhan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colExpired As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTerpakai As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colSisa As DevExpress.XtraGrid.Columns.GridColumn
End Class
