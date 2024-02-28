<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_MataUangDialog
    Inherits Core.Win.Forms.InputDialog

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
  Me.txtSimbol = New DevExpress.XtraEditors.TextEdit()
  Me.lytMasterUang = New DevExpress.XtraLayout.LayoutControl()
  Me.xGridKurs = New DevExpress.XtraGrid.GridControl()
  Me.xGridKursView = New DevExpress.XtraGrid.Views.Grid.GridView()
  Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
  Me.colKursUang = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.colKursPajak = New DevExpress.XtraGrid.Columns.GridColumn()
  Me.txtKode = New DevExpress.XtraEditors.TextEdit()
  Me.txtNegara = New DevExpress.XtraEditors.TextEdit()
  Me.txtNama = New DevExpress.XtraEditors.TextEdit()
  Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
  Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
  Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
  Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
  CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtSimbol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.lytMasterUang, System.ComponentModel.ISupportInitialize).BeginInit()
  Me.lytMasterUang.SuspendLayout()
  CType(Me.xGridKurs, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.xGridKursView, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtNegara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
  CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
  Me.SuspendLayout()
  '
  'txtSimbol
  '
  Me.txtSimbol.Location = New System.Drawing.Point(62, 96)
  Me.txtSimbol.Name = "txtSimbol"
  Me.txtSimbol.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtSimbol.Size = New System.Drawing.Size(51, 20)
  Me.txtSimbol.StyleController = Me.lytMasterUang
  Me.txtSimbol.TabIndex = 103
  '
  'lytMasterUang
  '
  Me.lytMasterUang.Controls.Add(Me.xGridKurs)
  Me.lytMasterUang.Controls.Add(Me.txtSimbol)
  Me.lytMasterUang.Controls.Add(Me.txtKode)
  Me.lytMasterUang.Controls.Add(Me.txtNegara)
  Me.lytMasterUang.Controls.Add(Me.txtNama)
  Me.lytMasterUang.Dock = System.Windows.Forms.DockStyle.Fill
  Me.lytMasterUang.Location = New System.Drawing.Point(0, 0)
  Me.lytMasterUang.Name = "lytMasterUang"
  Me.lytMasterUang.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(478, 148, 250, 350)
  Me.lytMasterUang.Root = Me.LayoutControlGroup1
  Me.lytMasterUang.Size = New System.Drawing.Size(423, 347)
  Me.lytMasterUang.TabIndex = 109
  Me.lytMasterUang.Text = "LayoutControl1"
  '
  'xGridKurs
  '
  Me.xGridKurs.Location = New System.Drawing.Point(12, 132)
  Me.xGridKurs.MainView = Me.xGridKursView
  Me.xGridKurs.Name = "xGridKurs"
  Me.xGridKurs.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
  Me.xGridKurs.Size = New System.Drawing.Size(399, 203)
  Me.xGridKurs.TabIndex = 108
  Me.xGridKurs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridKursView})
  '
  'xGridKursView
  '
  Me.xGridKursView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTanggal, Me.colKursUang, Me.colKursPajak})
  Me.xGridKursView.GridControl = Me.xGridKurs
  Me.xGridKursView.Name = "xGridKursView"
  Me.xGridKursView.NewItemRowText = "<Tambah Data>"
  Me.xGridKursView.OptionsDetail.EnableMasterViewMode = False
  Me.xGridKursView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
  Me.xGridKursView.OptionsView.ShowGroupPanel = False
  Me.xGridKursView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTanggal, DevExpress.Data.ColumnSortOrder.Descending)})
  '
  'colTanggal
  '
  Me.colTanggal.Caption = "Tanggal"
  Me.colTanggal.ColumnEdit = Me.RepositoryItemDateEdit1
  Me.colTanggal.FieldName = "Tanggal"
  Me.colTanggal.Name = "colTanggal"
  Me.colTanggal.Visible = True
  Me.colTanggal.VisibleIndex = 0
  Me.colTanggal.Width = 110
  '
  'RepositoryItemDateEdit1
  '
  Me.RepositoryItemDateEdit1.AutoHeight = False
  Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
  Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
  '
  'colKursUang
  '
  Me.colKursUang.Caption = "Kurs Mata Uang"
  Me.colKursUang.FieldName = "KursUang"
  Me.colKursUang.Name = "colKursUang"
  Me.colKursUang.Visible = True
  Me.colKursUang.VisibleIndex = 1
  Me.colKursUang.Width = 141
  '
  'colKursPajak
  '
  Me.colKursPajak.Caption = "Kurs Pajak"
  Me.colKursPajak.FieldName = "KursPajak"
  Me.colKursPajak.Name = "colKursPajak"
  Me.colKursPajak.Visible = True
  Me.colKursPajak.VisibleIndex = 2
  Me.colKursPajak.Width = 144
  '
  'txtKode
  '
  Me.txtKode.Location = New System.Drawing.Point(62, 24)
  Me.txtKode.Name = "txtKode"
  Me.txtKode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtKode.Size = New System.Drawing.Size(337, 20)
  Me.txtKode.StyleController = Me.lytMasterUang
  Me.txtKode.TabIndex = 100
  '
  'txtNegara
  '
  Me.txtNegara.Location = New System.Drawing.Point(62, 72)
  Me.txtNegara.Name = "txtNegara"
  Me.txtNegara.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtNegara.Size = New System.Drawing.Size(337, 20)
  Me.txtNegara.StyleController = Me.lytMasterUang
  Me.txtNegara.TabIndex = 102
  '
  'txtNama
  '
  Me.txtNama.Location = New System.Drawing.Point(62, 48)
  Me.txtNama.Name = "txtNama"
  Me.txtNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
  Me.txtNama.Size = New System.Drawing.Size(337, 20)
  Me.txtNama.StyleController = Me.lytMasterUang
  Me.txtNama.TabIndex = 101
  '
  'LayoutControlGroup1
  '
  Me.LayoutControlGroup1.CustomizationFormText = "Root"
  Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
  Me.LayoutControlGroup1.GroupBordersVisible = False
  Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlGroup2})
  Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControlGroup1.Name = "Root"
  Me.LayoutControlGroup1.Size = New System.Drawing.Size(423, 347)
  Me.LayoutControlGroup1.Text = "Root"
  Me.LayoutControlGroup1.TextVisible = False
  '
  'LayoutControlItem5
  '
  Me.LayoutControlItem5.Control = Me.xGridKurs
  Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
  Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 120)
  Me.LayoutControlItem5.Name = "LayoutControlItem5"
  Me.LayoutControlItem5.Size = New System.Drawing.Size(403, 207)
  Me.LayoutControlItem5.Text = "LayoutControlItem5"
  Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
  Me.LayoutControlItem5.TextToControlDistance = 0
  Me.LayoutControlItem5.TextVisible = False
  '
  'LayoutControlGroup2
  '
  Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
  Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1})
  Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
  Me.LayoutControlGroup2.Size = New System.Drawing.Size(403, 120)
  Me.LayoutControlGroup2.Text = "LayoutControlGroup2"
  Me.LayoutControlGroup2.TextVisible = False
  '
  'LayoutControlItem1
  '
  Me.LayoutControlItem1.Control = Me.txtKode
  Me.LayoutControlItem1.CustomizationFormText = "Kode"
  Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
  Me.LayoutControlItem1.Name = "LayoutControlItem1"
  Me.LayoutControlItem1.Size = New System.Drawing.Size(379, 24)
  Me.LayoutControlItem1.Text = "Kode"
  Me.LayoutControlItem1.TextSize = New System.Drawing.Size(35, 13)
  '
  'LayoutControlItem2
  '
  Me.LayoutControlItem2.Control = Me.txtNama
  Me.LayoutControlItem2.CustomizationFormText = "Nama"
  Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
  Me.LayoutControlItem2.Name = "LayoutControlItem2"
  Me.LayoutControlItem2.Size = New System.Drawing.Size(379, 24)
  Me.LayoutControlItem2.Text = "Nama"
  Me.LayoutControlItem2.TextSize = New System.Drawing.Size(35, 13)
  '
  'LayoutControlItem3
  '
  Me.LayoutControlItem3.Control = Me.txtNegara
  Me.LayoutControlItem3.CustomizationFormText = "Negara"
  Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
  Me.LayoutControlItem3.Name = "LayoutControlItem3"
  Me.LayoutControlItem3.Size = New System.Drawing.Size(379, 24)
  Me.LayoutControlItem3.Text = "Negara"
  Me.LayoutControlItem3.TextSize = New System.Drawing.Size(35, 13)
  '
  'LayoutControlItem4
  '
  Me.LayoutControlItem4.Control = Me.txtSimbol
  Me.LayoutControlItem4.CustomizationFormText = "Simbol"
  Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
  Me.LayoutControlItem4.Name = "LayoutControlItem4"
  Me.LayoutControlItem4.Size = New System.Drawing.Size(93, 24)
  Me.LayoutControlItem4.Text = "Simbol"
  Me.LayoutControlItem4.TextSize = New System.Drawing.Size(35, 13)
  '
  'EmptySpaceItem1
  '
  Me.EmptySpaceItem1.AllowHotTrack = False
  Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
  Me.EmptySpaceItem1.Location = New System.Drawing.Point(93, 72)
  Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
  Me.EmptySpaceItem1.Size = New System.Drawing.Size(286, 24)
  Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
  Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
  '
  'UI_MataUangDialog
  '
  Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
  Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
  Me.ClientSize = New System.Drawing.Size(423, 396)
  Me.Controls.Add(Me.lytMasterUang)
  Me.Name = "UI_MataUangDialog"
  Me.Text = "Mata Uang"
  Me.Controls.SetChildIndex(Me.lytMasterUang, 0)
  CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtSimbol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.lytMasterUang, System.ComponentModel.ISupportInitialize).EndInit()
  Me.lytMasterUang.ResumeLayout(False)
  CType(Me.xGridKurs, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.xGridKursView, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtNegara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.txtNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
  CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
  Me.ResumeLayout(False)

 End Sub
 Friend WithEvents txtSimbol As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtNegara As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtNama As DevExpress.XtraEditors.TextEdit
 Friend WithEvents txtKode As DevExpress.XtraEditors.TextEdit
 Friend WithEvents xGridKurs As DevExpress.XtraGrid.GridControl
 Friend WithEvents xGridKursView As DevExpress.XtraGrid.Views.Grid.GridView
 Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents colKursUang As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents colKursPajak As DevExpress.XtraGrid.Columns.GridColumn
 Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
 Friend WithEvents lytMasterUang As DevExpress.XtraLayout.LayoutControl
 Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
 Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
 Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
 Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
