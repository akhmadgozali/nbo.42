﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RF_FusohRekapTransaksi
  Inherits Core.Win.Forms.FilterForm

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
		Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
		Me.txtKeterangan = New DevExpress.XtraEditors.TextEdit()
		Me.txtTgl2 = New DevExpress.XtraEditors.DateEdit()
		Me.txtTgl1 = New DevExpress.XtraEditors.DateEdit()
		Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
		Me.txtKontak = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
		Me.txtNoBukti1 = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtNoBukti2 = New DevExpress.XtraEditors.LookUpEdit()
		Me.txtBarangJadi = New DevExpress.XtraEditors.SearchLookUpEdit()
		Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
		Me.chkStock0 = New DevExpress.XtraEditors.CheckEdit()
		Me.chkTampilkanDetail = New DevExpress.XtraEditors.CheckEdit()
		CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNoBukti1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNoBukti2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtBarangJadi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chkStock0.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chkTampilkanDetail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LabelControl7
		'
		Me.LabelControl7.Location = New System.Drawing.Point(270, 15)
		Me.LabelControl7.Name = "LabelControl7"
		Me.LabelControl7.Size = New System.Drawing.Size(15, 13)
		Me.LabelControl7.TabIndex = 113
		Me.LabelControl7.Text = "s/d"
		'
		'LabelControl6
		'
		Me.LabelControl6.Location = New System.Drawing.Point(9, 93)
		Me.LabelControl6.Name = "LabelControl6"
		Me.LabelControl6.Size = New System.Drawing.Size(56, 13)
		Me.LabelControl6.TabIndex = 112
		Me.LabelControl6.Text = "Keterangan"
		'
		'txtKeterangan
		'
		Me.txtKeterangan.Location = New System.Drawing.Point(93, 90)
		Me.txtKeterangan.Name = "txtKeterangan"
		Me.txtKeterangan.Size = New System.Drawing.Size(367, 20)
		Me.txtKeterangan.TabIndex = 107
		'
		'txtTgl2
		'
		Me.txtTgl2.EditValue = Nothing
		Me.txtTgl2.Location = New System.Drawing.Point(291, 38)
		Me.txtTgl2.Name = "txtTgl2"
		Me.txtTgl2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTgl2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.txtTgl2.Properties.DisplayFormat.FormatString = "D"
		Me.txtTgl2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.txtTgl2.Size = New System.Drawing.Size(170, 20)
		Me.txtTgl2.TabIndex = 104
		'
		'txtTgl1
		'
		Me.txtTgl1.EditValue = Nothing
		Me.txtTgl1.Location = New System.Drawing.Point(94, 38)
		Me.txtTgl1.Name = "txtTgl1"
		Me.txtTgl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtTgl1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.txtTgl1.Properties.DisplayFormat.FormatString = "D"
		Me.txtTgl1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
		Me.txtTgl1.Size = New System.Drawing.Size(170, 20)
		Me.txtTgl1.TabIndex = 103
		'
		'LabelControl4
		'
		Me.LabelControl4.Location = New System.Drawing.Point(270, 41)
		Me.LabelControl4.Name = "LabelControl4"
		Me.LabelControl4.Size = New System.Drawing.Size(15, 13)
		Me.LabelControl4.TabIndex = 114
		Me.LabelControl4.Text = "s/d"
		'
		'LabelControl3
		'
		Me.LabelControl3.Location = New System.Drawing.Point(9, 67)
		Me.LabelControl3.Name = "LabelControl3"
		Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
		Me.LabelControl3.TabIndex = 111
		Me.LabelControl3.Text = "Customer"
		'
		'LabelControl2
		'
		Me.LabelControl2.Location = New System.Drawing.Point(10, 41)
		Me.LabelControl2.Name = "LabelControl2"
		Me.LabelControl2.Size = New System.Drawing.Size(38, 13)
		Me.LabelControl2.TabIndex = 109
		Me.LabelControl2.Text = "Tanggal"
		'
		'txtKontak
		'
		Me.txtKontak.Location = New System.Drawing.Point(93, 64)
		Me.txtKontak.Name = "txtKontak"
		Me.txtKontak.Size = New System.Drawing.Size(367, 20)
		Me.txtKontak.TabIndex = 106
		'
		'LabelControl1
		'
		Me.LabelControl1.Location = New System.Drawing.Point(10, 15)
		Me.LabelControl1.Name = "LabelControl1"
		Me.LabelControl1.Size = New System.Drawing.Size(43, 13)
		Me.LabelControl1.TabIndex = 108
		Me.LabelControl1.Text = "No. Bukti"
		'
		'txtNoBukti1
		'
		Me.txtNoBukti1.Location = New System.Drawing.Point(94, 12)
		Me.txtNoBukti1.Name = "txtNoBukti1"
		Me.txtNoBukti1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtNoBukti1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "No Transaksi")})
		Me.txtNoBukti1.Properties.DisplayMember = "Kode"
		Me.txtNoBukti1.Properties.NullText = ""
		Me.txtNoBukti1.Properties.ValueMember = "Kode"
		Me.txtNoBukti1.Size = New System.Drawing.Size(170, 20)
		Me.txtNoBukti1.TabIndex = 101
		'
		'txtNoBukti2
		'
		Me.txtNoBukti2.Location = New System.Drawing.Point(291, 12)
		Me.txtNoBukti2.Name = "txtNoBukti2"
		Me.txtNoBukti2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtNoBukti2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode", "No Transaksi")})
		Me.txtNoBukti2.Properties.DisplayMember = "Kode"
		Me.txtNoBukti2.Properties.NullText = ""
		Me.txtNoBukti2.Properties.ValueMember = "Kode"
		Me.txtNoBukti2.Size = New System.Drawing.Size(170, 20)
		Me.txtNoBukti2.TabIndex = 102
		'
		'txtBarangJadi
		'
		Me.txtBarangJadi.Location = New System.Drawing.Point(93, 117)
		Me.txtBarangJadi.Name = "txtBarangJadi"
		Me.txtBarangJadi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.txtBarangJadi.Properties.DisplayMember = "Kode"
		Me.txtBarangJadi.Properties.NullText = "<Pilih Kode Barang Jadi>"
		Me.txtBarangJadi.Properties.ValueMember = "This"
		Me.txtBarangJadi.Properties.View = Me.SearchLookUpEdit1View
		Me.txtBarangJadi.Size = New System.Drawing.Size(367, 20)
		Me.txtBarangJadi.TabIndex = 115
		'
		'SearchLookUpEdit1View
		'
		Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
		Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
		Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
		Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
		Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
		'
		'GridColumn1
		'
		Me.GridColumn1.Caption = "Kode"
		Me.GridColumn1.FieldName = "Kode"
		Me.GridColumn1.Name = "GridColumn1"
		Me.GridColumn1.Visible = True
		Me.GridColumn1.VisibleIndex = 0
		'
		'GridColumn2
		'
		Me.GridColumn2.Caption = "Nama"
		Me.GridColumn2.FieldName = "Nama"
		Me.GridColumn2.Name = "GridColumn2"
		Me.GridColumn2.Visible = True
		Me.GridColumn2.VisibleIndex = 1
		'
		'LabelControl5
		'
		Me.LabelControl5.Location = New System.Drawing.Point(9, 120)
		Me.LabelControl5.Name = "LabelControl5"
		Me.LabelControl5.Size = New System.Drawing.Size(56, 13)
		Me.LabelControl5.TabIndex = 116
		Me.LabelControl5.Text = "Barang Jadi"
		'
		'chkStock0
		'
		Me.chkStock0.Location = New System.Drawing.Point(90, 143)
		Me.chkStock0.Name = "chkStock0"
		Me.chkStock0.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.chkStock0.Properties.Caption = "Tampilkan Stock 0"
		Me.chkStock0.Size = New System.Drawing.Size(162, 21)
		Me.chkStock0.TabIndex = 152
		'
		'chkTampilkanDetail
		'
		Me.chkTampilkanDetail.Location = New System.Drawing.Point(91, 170)
		Me.chkTampilkanDetail.Name = "chkTampilkanDetail"
		Me.chkTampilkanDetail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
		Me.chkTampilkanDetail.Properties.Caption = "Tampilkan Detail"
		Me.chkTampilkanDetail.Size = New System.Drawing.Size(162, 21)
		Me.chkTampilkanDetail.TabIndex = 153
		'
		'RF_FusohRekapTransaksi
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(474, 247)
		Me.Controls.Add(Me.chkTampilkanDetail)
		Me.Controls.Add(Me.chkStock0)
		Me.Controls.Add(Me.LabelControl5)
		Me.Controls.Add(Me.txtBarangJadi)
		Me.Controls.Add(Me.LabelControl7)
		Me.Controls.Add(Me.LabelControl6)
		Me.Controls.Add(Me.txtKeterangan)
		Me.Controls.Add(Me.txtTgl2)
		Me.Controls.Add(Me.txtTgl1)
		Me.Controls.Add(Me.LabelControl4)
		Me.Controls.Add(Me.LabelControl3)
		Me.Controls.Add(Me.LabelControl2)
		Me.Controls.Add(Me.txtKontak)
		Me.Controls.Add(Me.LabelControl1)
		Me.Controls.Add(Me.txtNoBukti1)
		Me.Controls.Add(Me.txtNoBukti2)
		Me.Name = "RF_FusohRekapTransaksi"
		Me.Text = "Filter Laporan"
		Me.Controls.SetChildIndex(Me.txtNoBukti2, 0)
		Me.Controls.SetChildIndex(Me.txtNoBukti1, 0)
		Me.Controls.SetChildIndex(Me.LabelControl1, 0)
		Me.Controls.SetChildIndex(Me.txtKontak, 0)
		Me.Controls.SetChildIndex(Me.LabelControl2, 0)
		Me.Controls.SetChildIndex(Me.LabelControl3, 0)
		Me.Controls.SetChildIndex(Me.LabelControl4, 0)
		Me.Controls.SetChildIndex(Me.txtTgl1, 0)
		Me.Controls.SetChildIndex(Me.txtTgl2, 0)
		Me.Controls.SetChildIndex(Me.txtKeterangan, 0)
		Me.Controls.SetChildIndex(Me.LabelControl6, 0)
		Me.Controls.SetChildIndex(Me.LabelControl7, 0)
		Me.Controls.SetChildIndex(Me.txtBarangJadi, 0)
		Me.Controls.SetChildIndex(Me.LabelControl5, 0)
		Me.Controls.SetChildIndex(Me.chkStock0, 0)
		Me.Controls.SetChildIndex(Me.chkTampilkanDetail, 0)
		CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNoBukti1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNoBukti2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtBarangJadi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkStock0.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkTampilkanDetail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtKeterangan As DevExpress.XtraEditors.TextEdit
  Friend WithEvents txtTgl2 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtTgl1 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtKontak As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtNoBukti1 As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtNoBukti2 As DevExpress.XtraEditors.LookUpEdit
	Friend WithEvents txtBarangJadi As DevExpress.XtraEditors.SearchLookUpEdit
	Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents chkStock0 As DevExpress.XtraEditors.CheckEdit
	Friend WithEvents chkTampilkanDetail As DevExpress.XtraEditors.CheckEdit
End Class