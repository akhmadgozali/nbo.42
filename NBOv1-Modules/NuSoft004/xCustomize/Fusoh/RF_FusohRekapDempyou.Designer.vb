<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RF_FusohRekap
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
    Me.txtTgl2 = New DevExpress.XtraEditors.DateEdit()
    Me.txtTgl1 = New DevExpress.XtraEditors.DateEdit()
    Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.txtNoBukti1 = New DevExpress.XtraEditors.LookUpEdit()
    Me.txtNoBukti2 = New DevExpress.XtraEditors.LookUpEdit()
    Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
    Me.txtCustomer = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colKontakKode = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKontakNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtNoLOT = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
    Me.txtMillSheet = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
    Me.txtBarangFG = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
    Me.txtBarangRM = New DevExpress.XtraEditors.SearchLookUpEdit()
    Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.txtNoPO = New DevExpress.XtraEditors.TextEdit()
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoBukti1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoBukti2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoLOT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMillSheet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBarangFG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtBarangRM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNoPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.LabelControl2.Location = New System.Drawing.Point(9, 41)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(38, 13)
    Me.LabelControl2.TabIndex = 109
    Me.LabelControl2.Text = "Tanggal"
    '
    'LabelControl1
    '
    Me.LabelControl1.Location = New System.Drawing.Point(9, 15)
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
    'LabelControl8
    '
    Me.LabelControl8.Location = New System.Drawing.Point(9, 119)
    Me.LabelControl8.Name = "LabelControl8"
    Me.LabelControl8.Size = New System.Drawing.Size(39, 13)
    Me.LabelControl8.TabIndex = 117
    Me.LabelControl8.Text = "No. LOT"
    '
    'txtCustomer
    '
    Me.txtCustomer.EnterMoveNextControl = True
    Me.txtCustomer.Location = New System.Drawing.Point(94, 64)
    Me.txtCustomer.Name = "txtCustomer"
    Me.txtCustomer.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtCustomer.Properties.DisplayMember = "Kode"
    Me.txtCustomer.Properties.NullText = "<Pilih Customer>"
    Me.txtCustomer.Properties.ShowClearButton = False
    Me.txtCustomer.Properties.ShowFooter = False
    Me.txtCustomer.Properties.ValueMember = "Id"
    Me.txtCustomer.Properties.View = Me.SearchLookUpEdit1View
    Me.txtCustomer.Size = New System.Drawing.Size(365, 20)
    Me.txtCustomer.TabIndex = 119
    '
    'SearchLookUpEdit1View
    '
    Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKontakKode, Me.colKontakNama})
    Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
    Me.SearchLookUpEdit1View.OptionsFind.FindDelay = 500
    Me.SearchLookUpEdit1View.OptionsFind.SearchInPreview = True
    Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
    Me.SearchLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colKontakKode, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'colKontakKode
    '
    Me.colKontakKode.Caption = "Kode"
    Me.colKontakKode.FieldName = "Kode"
    Me.colKontakKode.Name = "colKontakKode"
    Me.colKontakKode.Visible = True
    Me.colKontakKode.VisibleIndex = 0
    Me.colKontakKode.Width = 355
    '
    'colKontakNama
    '
    Me.colKontakNama.Caption = "Nama"
    Me.colKontakNama.FieldName = "Nama"
    Me.colKontakNama.Name = "colKontakNama"
    Me.colKontakNama.Visible = True
    Me.colKontakNama.VisibleIndex = 1
    Me.colKontakNama.Width = 723
    '
    'txtNoLOT
    '
    Me.txtNoLOT.Location = New System.Drawing.Point(94, 116)
    Me.txtNoLOT.Name = "txtNoLOT"
    Me.txtNoLOT.Size = New System.Drawing.Size(367, 20)
    Me.txtNoLOT.TabIndex = 115
    '
    'LabelControl5
    '
    Me.LabelControl5.Location = New System.Drawing.Point(9, 93)
    Me.LabelControl5.Name = "LabelControl5"
    Me.LabelControl5.Size = New System.Drawing.Size(30, 13)
    Me.LabelControl5.TabIndex = 120
    Me.LabelControl5.Text = "No PO"
    '
    'LabelControl6
    '
    Me.LabelControl6.Location = New System.Drawing.Point(9, 145)
    Me.LabelControl6.Name = "LabelControl6"
    Me.LabelControl6.Size = New System.Drawing.Size(45, 13)
    Me.LabelControl6.TabIndex = 123
    Me.LabelControl6.Text = "Mill Sheet"
    '
    'txtMillSheet
    '
    Me.txtMillSheet.Location = New System.Drawing.Point(94, 142)
    Me.txtMillSheet.Name = "txtMillSheet"
    Me.txtMillSheet.Size = New System.Drawing.Size(367, 20)
    Me.txtMillSheet.TabIndex = 122
    '
    'LabelControl9
    '
    Me.LabelControl9.Location = New System.Drawing.Point(9, 170)
    Me.LabelControl9.Name = "LabelControl9"
    Me.LabelControl9.Size = New System.Drawing.Size(52, 13)
    Me.LabelControl9.TabIndex = 111
    Me.LabelControl9.Text = "No Part FG"
    '
    'txtBarangFG
    '
    Me.txtBarangFG.EnterMoveNextControl = True
    Me.txtBarangFG.Location = New System.Drawing.Point(94, 167)
    Me.txtBarangFG.Name = "txtBarangFG"
    Me.txtBarangFG.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtBarangFG.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtBarangFG.Properties.DisplayMember = "Kode"
    Me.txtBarangFG.Properties.NullText = "<Pilih No Part Finish Good>"
    Me.txtBarangFG.Properties.ShowClearButton = False
    Me.txtBarangFG.Properties.ShowFooter = False
    Me.txtBarangFG.Properties.ValueMember = "Id"
    Me.txtBarangFG.Properties.View = Me.GridView2
    Me.txtBarangFG.Size = New System.Drawing.Size(365, 20)
    Me.txtBarangFG.TabIndex = 119
    '
    'GridView2
    '
    Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
    Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView2.Name = "GridView2"
    Me.GridView2.OptionsFind.FindDelay = 500
    Me.GridView2.OptionsFind.SearchInPreview = True
    Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView2.OptionsView.ShowGroupPanel = False
    Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'GridColumn3
    '
    Me.GridColumn3.Caption = "Kode"
    Me.GridColumn3.FieldName = "Kode"
    Me.GridColumn3.Name = "GridColumn3"
    Me.GridColumn3.Visible = True
    Me.GridColumn3.VisibleIndex = 0
    Me.GridColumn3.Width = 355
    '
    'GridColumn4
    '
    Me.GridColumn4.Caption = "Nama"
    Me.GridColumn4.FieldName = "Nama"
    Me.GridColumn4.Name = "GridColumn4"
    Me.GridColumn4.Visible = True
    Me.GridColumn4.VisibleIndex = 1
    Me.GridColumn4.Width = 723
    '
    'LabelControl10
    '
    Me.LabelControl10.Location = New System.Drawing.Point(9, 196)
    Me.LabelControl10.Name = "LabelControl10"
    Me.LabelControl10.Size = New System.Drawing.Size(54, 13)
    Me.LabelControl10.TabIndex = 120
    Me.LabelControl10.Text = "No Part RM"
    '
    'txtBarangRM
    '
    Me.txtBarangRM.EnterMoveNextControl = True
    Me.txtBarangRM.Location = New System.Drawing.Point(94, 193)
    Me.txtBarangRM.Name = "txtBarangRM"
    Me.txtBarangRM.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    Me.txtBarangRM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.txtBarangRM.Properties.DisplayMember = "Kode"
    Me.txtBarangRM.Properties.NullText = "<Pilih No Part Raw Material>"
    Me.txtBarangRM.Properties.ShowClearButton = False
    Me.txtBarangRM.Properties.ShowFooter = False
    Me.txtBarangRM.Properties.ValueMember = "Id"
    Me.txtBarangRM.Properties.View = Me.GridView3
    Me.txtBarangRM.Size = New System.Drawing.Size(365, 20)
    Me.txtBarangRM.TabIndex = 121
    '
    'GridView3
    '
    Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6})
    Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView3.Name = "GridView3"
    Me.GridView3.OptionsFind.FindDelay = 500
    Me.GridView3.OptionsFind.SearchInPreview = True
    Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView3.OptionsView.ShowGroupPanel = False
    Me.GridView3.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn5, DevExpress.Data.ColumnSortOrder.Ascending)})
    '
    'GridColumn5
    '
    Me.GridColumn5.Caption = "Kode"
    Me.GridColumn5.FieldName = "Kode"
    Me.GridColumn5.Name = "GridColumn5"
    Me.GridColumn5.Visible = True
    Me.GridColumn5.VisibleIndex = 0
    Me.GridColumn5.Width = 355
    '
    'GridColumn6
    '
    Me.GridColumn6.Caption = "Nama"
    Me.GridColumn6.FieldName = "Nama"
    Me.GridColumn6.Name = "GridColumn6"
    Me.GridColumn6.Visible = True
    Me.GridColumn6.VisibleIndex = 1
    Me.GridColumn6.Width = 723
    '
    'txtNoPO
    '
    Me.txtNoPO.Location = New System.Drawing.Point(94, 90)
    Me.txtNoPO.Name = "txtNoPO"
    Me.txtNoPO.Size = New System.Drawing.Size(367, 20)
    Me.txtNoPO.TabIndex = 124
    '
    'RF_FusohRekapDempyou
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(474, 286)
    Me.Controls.Add(Me.txtNoPO)
    Me.Controls.Add(Me.LabelControl6)
    Me.Controls.Add(Me.txtMillSheet)
    Me.Controls.Add(Me.txtBarangRM)
    Me.Controls.Add(Me.LabelControl10)
    Me.Controls.Add(Me.txtBarangFG)
    Me.Controls.Add(Me.LabelControl5)
    Me.Controls.Add(Me.txtCustomer)
    Me.Controls.Add(Me.LabelControl8)
    Me.Controls.Add(Me.LabelControl7)
    Me.Controls.Add(Me.txtTgl2)
    Me.Controls.Add(Me.txtTgl1)
    Me.Controls.Add(Me.LabelControl9)
    Me.Controls.Add(Me.LabelControl4)
    Me.Controls.Add(Me.LabelControl3)
    Me.Controls.Add(Me.LabelControl2)
    Me.Controls.Add(Me.LabelControl1)
    Me.Controls.Add(Me.txtNoBukti1)
    Me.Controls.Add(Me.txtNoBukti2)
    Me.Controls.Add(Me.txtNoLOT)
    Me.Name = "RF_FusohRekapDempyou"
    Me.Text = "Filter Laporan"
    Me.Controls.SetChildIndex(Me.txtNoLOT, 0)
    Me.Controls.SetChildIndex(Me.txtNoBukti2, 0)
    Me.Controls.SetChildIndex(Me.txtNoBukti1, 0)
    Me.Controls.SetChildIndex(Me.LabelControl1, 0)
    Me.Controls.SetChildIndex(Me.LabelControl2, 0)
    Me.Controls.SetChildIndex(Me.LabelControl3, 0)
    Me.Controls.SetChildIndex(Me.LabelControl4, 0)
    Me.Controls.SetChildIndex(Me.LabelControl9, 0)
    Me.Controls.SetChildIndex(Me.txtTgl1, 0)
    Me.Controls.SetChildIndex(Me.txtTgl2, 0)
    Me.Controls.SetChildIndex(Me.LabelControl7, 0)
    Me.Controls.SetChildIndex(Me.LabelControl8, 0)
    Me.Controls.SetChildIndex(Me.txtCustomer, 0)
    Me.Controls.SetChildIndex(Me.LabelControl5, 0)
    Me.Controls.SetChildIndex(Me.txtBarangFG, 0)
    Me.Controls.SetChildIndex(Me.LabelControl10, 0)
    Me.Controls.SetChildIndex(Me.txtBarangRM, 0)
    Me.Controls.SetChildIndex(Me.txtMillSheet, 0)
    Me.Controls.SetChildIndex(Me.LabelControl6, 0)
    Me.Controls.SetChildIndex(Me.txtNoPO, 0)
    CType(Me._sesi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtTgl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoBukti1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoBukti2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoLOT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMillSheet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBarangFG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtBarangRM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNoPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtTgl2 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents txtTgl1 As DevExpress.XtraEditors.DateEdit
  Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtNoBukti1 As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents txtNoBukti2 As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtCustomer As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colKontakKode As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKontakNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtNoLOT As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtMillSheet As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtBarangFG As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtBarangRM As DevExpress.XtraEditors.SearchLookUpEdit
  Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents txtNoPO As DevExpress.XtraEditors.TextEdit
End Class
