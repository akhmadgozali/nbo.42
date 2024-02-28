<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohSaldoAwalDialog
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
		Me.lytTransaksiSA = New DevExpress.XtraLayout.LayoutControl()
		Me.btnSerial = New DevExpress.XtraEditors.SimpleButton()
		Me.txtTotal = New DevExpress.XtraEditors.SpinEdit()
		Me.txtCustomer = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtSatuan = New DevExpress.XtraEditors.TextEdit()
		Me.txtMaterial = New DevExpress.XtraEditors.TextEdit()
		Me.txtBarang = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.gcKode = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.gcNama = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.gcSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.gcTipeBarang = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.txtQty = New DevExpress.XtraEditors.SpinEdit()
		Me.txtHarga = New DevExpress.XtraEditors.SpinEdit()
		Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
		Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
		Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
		Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lytTransaksiSA, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.lytTransaksiSA.SuspendLayout()
		CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtSatuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtMaterial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtHarga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lytTransaksiSA
		'
		Me.lytTransaksiSA.Controls.Add(Me.btnSerial)
		Me.lytTransaksiSA.Controls.Add(Me.txtTotal)
		Me.lytTransaksiSA.Controls.Add(Me.txtCustomer)
		Me.lytTransaksiSA.Controls.Add(Me.txtSatuan)
		Me.lytTransaksiSA.Controls.Add(Me.txtMaterial)
		Me.lytTransaksiSA.Controls.Add(Me.txtBarang)
		Me.lytTransaksiSA.Controls.Add(Me.txtQty)
		Me.lytTransaksiSA.Controls.Add(Me.txtHarga)
		Me.lytTransaksiSA.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lytTransaksiSA.Location = New System.Drawing.Point(0, 0)
		Me.lytTransaksiSA.Name = "lytTransaksiSA"
		Me.lytTransaksiSA.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(408, 15, 250, 350)
		Me.lytTransaksiSA.Root = Me.LayoutControlGroup1
		Me.lytTransaksiSA.Size = New System.Drawing.Size(311, 216)
		Me.lytTransaksiSA.TabIndex = 114
		Me.lytTransaksiSA.Text = "LayoutControl1"
		'
		'btnSerial
		'
		Me.btnSerial.Enabled = False
		Me.btnSerial.Location = New System.Drawing.Point(93, 60)
		Me.btnSerial.Name = "btnSerial"
		Me.btnSerial.Size = New System.Drawing.Size(206, 22)
		Me.btnSerial.StyleController = Me.lytTransaksiSA
		Me.btnSerial.TabIndex = 115
		Me.btnSerial.Text = "Serial"
		'
		'txtTotal
		'
		Me.txtTotal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.txtTotal.Enabled = False
		Me.txtTotal.Location = New System.Drawing.Point(91, 184)
		Me.txtTotal.Name = "txtTotal"
		Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
		Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtTotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTotal.Properties.DisplayFormat.FormatString = "n2"
		Me.txtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.txtTotal.Properties.EditFormat.FormatString = "n2"
		Me.txtTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.txtTotal.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
		Me.txtTotal.Properties.Mask.EditMask = "n2"
		Me.txtTotal.Size = New System.Drawing.Size(208, 20)
		Me.txtTotal.StyleController = Me.lytTransaksiSA
		Me.txtTotal.TabIndex = 115
		'
		'txtCustomer
		'
		Me.txtCustomer.Location = New System.Drawing.Point(91, 12)
		Me.txtCustomer.Name = "txtCustomer"
		Me.txtCustomer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtCustomer.Properties.DisplayMember = "Nama"
		Me.txtCustomer.Properties.NullText = "<Pilih Customer>"
		Me.txtCustomer.Properties.PopupFormSize = New System.Drawing.Size(300, 0)
		Me.txtCustomer.Properties.ShowFooter = False
		Me.txtCustomer.Properties.ValueMember = "This"
		Me.txtCustomer.Properties.View = Me.GridView2
		Me.txtCustomer.Size = New System.Drawing.Size(208, 20)
		Me.txtCustomer.StyleController = Me.lytTransaksiSA
		Me.txtCustomer.TabIndex = 115
		'
		'GridView2
		'
		Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
		Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.GridView2.Name = "GridView2"
		Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.GridView2.OptionsView.ShowGroupPanel = False
		'
		'GridColumn1
		'
		Me.GridColumn1.Caption = "Kode"
		Me.GridColumn1.FieldName = "Kode"
		Me.GridColumn1.Name = "GridColumn1"
		Me.GridColumn1.Visible = True
		Me.GridColumn1.VisibleIndex = 0
		Me.GridColumn1.Width = 293
		'
		'GridColumn2
		'
		Me.GridColumn2.Caption = "Nama"
		Me.GridColumn2.FieldName = "Nama"
		Me.GridColumn2.Name = "GridColumn2"
		Me.GridColumn2.Visible = True
		Me.GridColumn2.VisibleIndex = 1
		Me.GridColumn2.Width = 519
		'
		'txtSatuan
		'
		Me.txtSatuan.Enabled = False
		Me.txtSatuan.EnterMoveNextControl = True
		Me.txtSatuan.Location = New System.Drawing.Point(91, 110)
		Me.txtSatuan.Name = "txtSatuan"
		Me.txtSatuan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtSatuan.Size = New System.Drawing.Size(208, 20)
		Me.txtSatuan.StyleController = Me.lytTransaksiSA
		Me.txtSatuan.TabIndex = 115
		'
		'txtMaterial
		'
		Me.txtMaterial.Enabled = False
		Me.txtMaterial.Location = New System.Drawing.Point(91, 86)
		Me.txtMaterial.Name = "txtMaterial"
		Me.txtMaterial.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtMaterial.Size = New System.Drawing.Size(208, 20)
		Me.txtMaterial.StyleController = Me.lytTransaksiSA
		Me.txtMaterial.TabIndex = 115
		'
		'txtBarang
		'
		Me.txtBarang.Location = New System.Drawing.Point(91, 36)
		Me.txtBarang.Name = "txtBarang"
		Me.txtBarang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtBarang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtBarang.Properties.DisplayMember = "Kode"
		Me.txtBarang.Properties.NullText = "<Pilih Part No.>"
		Me.txtBarang.Properties.PopupFormSize = New System.Drawing.Size(500, 0)
		Me.txtBarang.Properties.ValueMember = "This"
		Me.txtBarang.Properties.View = Me.GridView1
		Me.txtBarang.Size = New System.Drawing.Size(208, 20)
		Me.txtBarang.StyleController = Me.lytTransaksiSA
		Me.txtBarang.TabIndex = 108
		'
		'GridView1
		'
		Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcKode, Me.gcNama, Me.gcSatuan, Me.gcTipeBarang})
		Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.GridView1.Name = "GridView1"
		Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.GridView1.OptionsView.ShowGroupPanel = False
		Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcTipeBarang, DevExpress.Data.ColumnSortOrder.Descending)})
		'
		'gcKode
		'
		Me.gcKode.Caption = "Kode"
		Me.gcKode.FieldName = "Kode"
		Me.gcKode.Name = "gcKode"
		Me.gcKode.Visible = True
		Me.gcKode.VisibleIndex = 0
		Me.gcKode.Width = 150
		'
		'gcNama
		'
		Me.gcNama.Caption = "Nama"
		Me.gcNama.FieldName = "Nama"
		Me.gcNama.Name = "gcNama"
		Me.gcNama.Visible = True
		Me.gcNama.VisibleIndex = 1
		Me.gcNama.Width = 120
		'
		'gcSatuan
		'
		Me.gcSatuan.Caption = "Satuan"
		Me.gcSatuan.FieldName = "Satuan.Nama"
		Me.gcSatuan.Name = "gcSatuan"
		Me.gcSatuan.Visible = True
		Me.gcSatuan.VisibleIndex = 2
		Me.gcSatuan.Width = 45
		'
		'gcTipeBarang
		'
		Me.gcTipeBarang.Caption = "Tipe Barang"
		Me.gcTipeBarang.FieldName = "TipeBarang"
		Me.gcTipeBarang.Name = "gcTipeBarang"
		Me.gcTipeBarang.Visible = True
		Me.gcTipeBarang.VisibleIndex = 3
		Me.gcTipeBarang.Width = 69
		'
		'txtQty
		'
		Me.txtQty.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.txtQty.Location = New System.Drawing.Point(91, 136)
		Me.txtQty.Name = "txtQty"
		Me.txtQty.Properties.Appearance.Options.UseTextOptions = True
		Me.txtQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtQty.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtQty.Properties.DisplayFormat.FormatString = "n0"
		Me.txtQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.txtQty.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
		Me.txtQty.Properties.Mask.EditMask = "n0"
		Me.txtQty.Size = New System.Drawing.Size(208, 20)
		Me.txtQty.StyleController = Me.lytTransaksiSA
		Me.txtQty.TabIndex = 110
		'
		'txtHarga
		'
		Me.txtHarga.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
		Me.txtHarga.Location = New System.Drawing.Point(91, 160)
		Me.txtHarga.Name = "txtHarga"
		Me.txtHarga.Properties.Appearance.Options.UseTextOptions = True
		Me.txtHarga.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
		Me.txtHarga.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.txtHarga.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtHarga.Properties.DisplayFormat.FormatString = "n2"
		Me.txtHarga.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.txtHarga.Properties.EditFormat.FormatString = "n2"
		Me.txtHarga.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.txtHarga.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
		Me.txtHarga.Properties.Mask.EditMask = "n2"
		Me.txtHarga.Size = New System.Drawing.Size(208, 20)
		Me.txtHarga.StyleController = Me.lytTransaksiSA
		Me.txtHarga.TabIndex = 112
		'
		'LayoutControlGroup1
		'
		Me.LayoutControlGroup1.CustomizationFormText = "Root"
		Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
		Me.LayoutControlGroup1.GroupBordersVisible = False
		Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.SimpleSeparator1, Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem7, Me.EmptySpaceItem1})
		Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlGroup1.Name = "Root"
		Me.LayoutControlGroup1.Size = New System.Drawing.Size(311, 216)
		Me.LayoutControlGroup1.Text = "Root"
		Me.LayoutControlGroup1.TextVisible = False
		'
		'LayoutControlItem5
		'
		Me.LayoutControlItem5.Control = Me.txtBarang
		Me.LayoutControlItem5.CustomizationFormText = "Barang"
		Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
		Me.LayoutControlItem5.Name = "LayoutControlItem5"
		Me.LayoutControlItem5.Size = New System.Drawing.Size(291, 24)
		Me.LayoutControlItem5.Text = "Part No"
		Me.LayoutControlItem5.TextSize = New System.Drawing.Size(76, 13)
		'
		'LayoutControlItem6
		'
		Me.LayoutControlItem6.Control = Me.txtQty
		Me.LayoutControlItem6.CustomizationFormText = "Qty"
		Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 124)
		Me.LayoutControlItem6.Name = "LayoutControlItem6"
		Me.LayoutControlItem6.Size = New System.Drawing.Size(291, 24)
		Me.LayoutControlItem6.Text = "Qty"
		Me.LayoutControlItem6.TextSize = New System.Drawing.Size(76, 13)
		'
		'LayoutControlItem8
		'
		Me.LayoutControlItem8.Control = Me.txtHarga
		Me.LayoutControlItem8.CustomizationFormText = "Harga"
		Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 148)
		Me.LayoutControlItem8.Name = "LayoutControlItem8"
		Me.LayoutControlItem8.Size = New System.Drawing.Size(291, 24)
		Me.LayoutControlItem8.Text = "Harga"
		Me.LayoutControlItem8.TextSize = New System.Drawing.Size(76, 13)
		'
		'LayoutControlItem2
		'
		Me.LayoutControlItem2.Control = Me.txtMaterial
		Me.LayoutControlItem2.CustomizationFormText = "Material"
		Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 74)
		Me.LayoutControlItem2.Name = "LayoutControlItem2"
		Me.LayoutControlItem2.Size = New System.Drawing.Size(291, 24)
		Me.LayoutControlItem2.Text = "Material"
		Me.LayoutControlItem2.TextSize = New System.Drawing.Size(76, 13)
		'
		'LayoutControlItem3
		'
		Me.LayoutControlItem3.Control = Me.txtSatuan
		Me.LayoutControlItem3.CustomizationFormText = "Satuan"
		Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 98)
		Me.LayoutControlItem3.Name = "LayoutControlItem3"
		Me.LayoutControlItem3.Size = New System.Drawing.Size(291, 24)
		Me.LayoutControlItem3.Text = "Satuan"
		Me.LayoutControlItem3.TextSize = New System.Drawing.Size(76, 13)
		'
		'SimpleSeparator1
		'
		Me.SimpleSeparator1.AllowHotTrack = False
		Me.SimpleSeparator1.CustomizationFormText = "SimpleSeparator1"
		Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 122)
		Me.SimpleSeparator1.Name = "SimpleSeparator1"
		Me.SimpleSeparator1.Size = New System.Drawing.Size(291, 2)
		Me.SimpleSeparator1.Text = "SimpleSeparator1"
		'
		'LayoutControlItem1
		'
		Me.LayoutControlItem1.Control = Me.txtCustomer
		Me.LayoutControlItem1.CustomizationFormText = "Customer          "
		Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
		Me.LayoutControlItem1.Name = "LayoutControlItem1"
		Me.LayoutControlItem1.Size = New System.Drawing.Size(291, 24)
		Me.LayoutControlItem1.Text = "Customer          "
		Me.LayoutControlItem1.TextSize = New System.Drawing.Size(76, 13)
		'
		'LayoutControlItem4
		'
		Me.LayoutControlItem4.Control = Me.txtTotal
		Me.LayoutControlItem4.CustomizationFormText = "Total"
		Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 172)
		Me.LayoutControlItem4.Name = "LayoutControlItem4"
		Me.LayoutControlItem4.Size = New System.Drawing.Size(291, 24)
		Me.LayoutControlItem4.Text = "Total"
		Me.LayoutControlItem4.TextSize = New System.Drawing.Size(76, 13)
		'
		'LayoutControlItem7
		'
		Me.LayoutControlItem7.Control = Me.btnSerial
		Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
		Me.LayoutControlItem7.Location = New System.Drawing.Point(81, 48)
		Me.LayoutControlItem7.Name = "LayoutControlItem7"
		Me.LayoutControlItem7.Size = New System.Drawing.Size(210, 26)
		Me.LayoutControlItem7.Text = "LayoutControlItem7"
		Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
		Me.LayoutControlItem7.TextToControlDistance = 0
		Me.LayoutControlItem7.TextVisible = False
		'
		'EmptySpaceItem1
		'
		Me.EmptySpaceItem1.AllowHotTrack = False
		Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
		Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 48)
		Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
		Me.EmptySpaceItem1.Size = New System.Drawing.Size(81, 26)
		Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
		Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
		'
		'UI_FusohSaldoAwalDialog
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(311, 265)
		Me.Controls.Add(Me.lytTransaksiSA)
		Me.Name = "UI_FusohSaldoAwalDialog"
		Me.Text = "UI_SaldoAwalDialog"
		Me.Controls.SetChildIndex(Me.lytTransaksiSA, 0)
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lytTransaksiSA, System.ComponentModel.ISupportInitialize).EndInit()
		Me.lytTransaksiSA.ResumeLayout(False)
		CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtSatuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtMaterial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtHarga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents lytTransaksiSA As DevExpress.XtraLayout.LayoutControl
	Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtBarang As DevExpress.XtraEditors.SearchLookUpEdit
	Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents gcKode As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents gcNama As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents gcSatuan As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents txtMaterial As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtSatuan As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
	Friend WithEvents txtCustomer As DevExpress.XtraEditors.SearchLookUpEdit
	Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents txtTotal As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents txtQty As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents txtHarga As DevExpress.XtraEditors.SpinEdit
	Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents gcTipeBarang As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents btnSerial As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
	Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
