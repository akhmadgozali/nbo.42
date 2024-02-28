<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohCekSerial
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohCekSerial))
		Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
		Me.xGrid = New DevExpress.XtraGrid.GridControl()
		Me.xGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colButton = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSerialRepo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
		Me.colSerial = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colMillSheet = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.ColLength = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLengthIN = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLengthOut = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colWeight = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colWeightIn = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colWeightOut = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.ifSource = New DevExpress.Xpo.XPInstantFeedbackSource(Me.components)
		Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
		Me.Bar3 = New DevExpress.XtraBars.Bar()
		Me.btnExport = New DevExpress.XtraBars.BarButtonItem()
		Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colSerialRepo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'xGrid
		'
		Me.xGrid.Dock = System.Windows.Forms.DockStyle.Fill
		Me.xGrid.Location = New System.Drawing.Point(0, 0)
		Me.xGrid.MainView = Me.xGridView
		Me.xGrid.Name = "xGrid"
		Me.xGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colSerialRepo})
		Me.xGrid.Size = New System.Drawing.Size(860, 348)
		Me.xGrid.TabIndex = 0
		Me.xGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.xGridView})
		'
		'xGridView
		'
		Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colButton, Me.colSerial, Me.colMillSheet, Me.ColLength, Me.colLengthIN, Me.colLengthOut, Me.colWeight, Me.colWeightIn, Me.colWeightOut})
		Me.xGridView.GridControl = Me.xGrid
		Me.xGridView.Name = "xGridView"
		Me.xGridView.OptionsDetail.EnableMasterViewMode = False
		Me.xGridView.OptionsView.ShowFooter = True
		Me.xGridView.OptionsView.ShowGroupPanel = False
		'
		'colButton
		'
		Me.colButton.AppearanceHeader.Options.UseTextOptions = True
		Me.colButton.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
		Me.colButton.ColumnEdit = Me.colSerialRepo
		Me.colButton.Name = "colButton"
		Me.colButton.OptionsColumn.AllowMove = False
		Me.colButton.OptionsColumn.AllowShowHide = False
		Me.colButton.OptionsColumn.AllowSize = False
		Me.colButton.OptionsColumn.FixedWidth = True
		Me.colButton.Visible = True
		Me.colButton.VisibleIndex = 0
		Me.colButton.Width = 25
		'
		'colSerialRepo
		'
		Me.colSerialRepo.AutoHeight = False
		Me.colSerialRepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("colSerialRepo.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
		Me.colSerialRepo.Name = "colSerialRepo"
		Me.colSerialRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
		'
		'colSerial
		'
		Me.colSerial.Caption = "Serial"
		Me.colSerial.FieldName = "Serial"
		Me.colSerial.Name = "colSerial"
		Me.colSerial.OptionsColumn.ReadOnly = True
		Me.colSerial.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Serial", "{0:n0}")})
		Me.colSerial.Visible = True
		Me.colSerial.VisibleIndex = 1
		Me.colSerial.Width = 161
		'
		'colMillSheet
		'
		Me.colMillSheet.Caption = "MillSheet"
		Me.colMillSheet.FieldName = "MillSheet"
		Me.colMillSheet.Name = "colMillSheet"
		Me.colMillSheet.OptionsColumn.AllowEdit = False
		Me.colMillSheet.OptionsColumn.ReadOnly = True
		Me.colMillSheet.Visible = True
		Me.colMillSheet.VisibleIndex = 2
		Me.colMillSheet.Width = 161
		'
		'ColLength
		'
		Me.ColLength.Caption = "Length"
		Me.ColLength.DisplayFormat.FormatString = "n0"
		Me.ColLength.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.ColLength.FieldName = "Length"
		Me.ColLength.Name = "ColLength"
		Me.ColLength.OptionsColumn.AllowEdit = False
		Me.ColLength.OptionsColumn.ReadOnly = True
		Me.ColLength.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Length", "{0:n0}")})
		Me.ColLength.Visible = True
		Me.ColLength.VisibleIndex = 3
		Me.ColLength.Width = 161
		'
		'colLengthIN
		'
		Me.colLengthIN.Caption = "Length In"
		Me.colLengthIN.DisplayFormat.FormatString = "n0"
		Me.colLengthIN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colLengthIN.FieldName = "LengthIn"
		Me.colLengthIN.Name = "colLengthIN"
		Me.colLengthIN.OptionsColumn.AllowEdit = False
		Me.colLengthIN.OptionsColumn.ReadOnly = True
		Me.colLengthIN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LengthIn", "{0:n0}")})
		Me.colLengthIN.Visible = True
		Me.colLengthIN.VisibleIndex = 4
		Me.colLengthIN.Width = 161
		'
		'colLengthOut
		'
		Me.colLengthOut.Caption = "Length Out"
		Me.colLengthOut.DisplayFormat.FormatString = "n0"
		Me.colLengthOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colLengthOut.FieldName = "LengthOut"
		Me.colLengthOut.Name = "colLengthOut"
		Me.colLengthOut.OptionsColumn.AllowEdit = False
		Me.colLengthOut.OptionsColumn.ReadOnly = True
		Me.colLengthOut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LengthOut", "{0:n0}")})
		Me.colLengthOut.Visible = True
		Me.colLengthOut.VisibleIndex = 5
		Me.colLengthOut.Width = 168
		'
		'colWeight
		'
		Me.colWeight.Caption = "Weight"
		Me.colWeight.FieldName = "Weight"
		Me.colWeight.Name = "colWeight"
		'
		'colWeightIn
		'
		Me.colWeightIn.Caption = "W IN"
		Me.colWeightIn.DisplayFormat.FormatString = "n2"
		Me.colWeightIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colWeightIn.FieldName = "WeightIN"
		Me.colWeightIn.Name = "colWeightIn"
		Me.colWeightIn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colWeightIn.Visible = True
		Me.colWeightIn.VisibleIndex = 6
		'
		'colWeightOut
		'
		Me.colWeightOut.Caption = "W Out"
		Me.colWeightOut.DisplayFormat.FormatString = "n2"
		Me.colWeightOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colWeightOut.FieldName = "WeightOut"
		Me.colWeightOut.Name = "colWeightOut"
		Me.colWeightOut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
		Me.colWeightOut.Visible = True
		Me.colWeightOut.VisibleIndex = 7
		'
		'ifSource
		'
		Me.ifSource.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Fusoh_StokSerial)
		'
		'BarManager1
		'
		Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
		Me.BarManager1.DockControls.Add(Me.barDockControlTop)
		Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
		Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
		Me.BarManager1.DockControls.Add(Me.barDockControlRight)
		Me.BarManager1.Form = Me
		Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExport})
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
		Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
		Me.Bar3.OptionsBar.AllowQuickCustomization = False
		Me.Bar3.OptionsBar.DrawDragBorder = False
		Me.Bar3.OptionsBar.UseWholeRow = True
		Me.Bar3.Text = "Status bar"
		'
		'btnExport
		'
		Me.btnExport.Caption = "Export"
		Me.btnExport.Glyph = CType(resources.GetObject("btnExport.Glyph"), System.Drawing.Image)
		Me.btnExport.Id = 0
		Me.btnExport.LargeGlyph = CType(resources.GetObject("btnExport.LargeGlyph"), System.Drawing.Image)
		Me.btnExport.Name = "btnExport"
		'
		'barDockControlTop
		'
		Me.barDockControlTop.CausesValidation = False
		Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
		Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
		Me.barDockControlTop.Size = New System.Drawing.Size(860, 0)
		'
		'barDockControlBottom
		'
		Me.barDockControlBottom.CausesValidation = False
		Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.barDockControlBottom.Location = New System.Drawing.Point(0, 348)
		Me.barDockControlBottom.Size = New System.Drawing.Size(860, 27)
		'
		'barDockControlLeft
		'
		Me.barDockControlLeft.CausesValidation = False
		Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
		Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
		Me.barDockControlLeft.Size = New System.Drawing.Size(0, 348)
		'
		'barDockControlRight
		'
		Me.barDockControlRight.CausesValidation = False
		Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
		Me.barDockControlRight.Location = New System.Drawing.Point(860, 0)
		Me.barDockControlRight.Size = New System.Drawing.Size(0, 348)
		'
		'UI_FusohCekSerial
		'
		Me.AllowMdiBar = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(860, 375)
		Me.Controls.Add(Me.xGrid)
		Me.Controls.Add(Me.barDockControlLeft)
		Me.Controls.Add(Me.barDockControlRight)
		Me.Controls.Add(Me.barDockControlBottom)
		Me.Controls.Add(Me.barDockControlTop)
		Me.IsMdiContainer = True
		Me.MinimizeBox = False
		Me.Name = "UI_FusohCekSerial"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Stock Serial (Imei)"
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colSerialRepo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents xGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents xGridView As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents ifSource As DevExpress.Xpo.XPInstantFeedbackSource
  Friend WithEvents colSerial As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colMillSheet As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents ColLength As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLengthIN As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colLengthOut As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSerialRepo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
  Friend WithEvents colButton As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeight As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeightIn As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colWeightOut As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
  Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
  Friend WithEvents btnExport As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
