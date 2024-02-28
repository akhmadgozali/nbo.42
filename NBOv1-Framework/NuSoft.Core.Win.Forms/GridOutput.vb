﻿Imports System.Windows.Forms

Namespace NuSoft.Core.Win.Forms
  Public Class GridOutput
    Private prive As NPO.NonPersistent.MenuPrivileges
    Protected Friend useFeedbackSource As Boolean
    Protected Friend showFilter As Boolean
    Protected Friend showChart As Boolean
    Protected Friend ActivateToolTip As Boolean
    Protected Friend xChart As DevExpress.XtraCharts.ChartControl
    Protected Friend fixedCriteriaString As String

    '============== Begin Special for Chart
    Private appearanceName As String
    Private paletteName As String
    '============== End Special for Chart

    Sub New()
      ' This call is required by the designer.
      InitializeComponent()
      ' Add any initialization after the InitializeComponent() call.
      barMan.SetPopupContextMenu(xGrid, popMenu)
    End Sub
    Overridable Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)

    End Sub
    Overridable Sub GridViewRowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs)

    End Sub
    Overridable Sub GridViewRowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)

    End Sub
    Overridable Sub RefreshData()
      If Not useFeedbackSource Then
        xpCol.Reload()
      Else
        ifSource.Refresh()
      End If
    End Sub
    Overridable Sub FirstLoad()

    End Sub
    Overridable Function GetFilterForm() As InputFilter
      Return New YearMonthFilter("Tahun", "Bulan")
    End Function
    Overridable Function GetToolTipContent(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByVal info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
      Return ""
    End Function
    Overridable Function GetToolTipTitle(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByVal info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
      Return ""
    End Function

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      If Not xChart Is Nothing AndAlso Not DesignMode Then
        barMan.SetPopupContextMenu(xChart, chartPopUp)
        CreateExportMenu()
        CreateAppearancesMenu()
        CreatePalettesMenu()
      End If

      If DesignMode Then
        prive = New NPO.NonPersistent.MenuPrivileges With {.Buka = True, .Tambah = True, .Edit = True, .Hapus = True, .Eksport = True, .Cetak = True}
      Else
        prive = Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase)
        'SplitContainerControl1.SplitterPosition = CInt(3 * (Me.Size.Height / 4))
      End If
      popMenuEksport.Enabled = prive.Eksport
      popMenuCetak.Enabled = prive.Cetak
      chartPopUpCetak.Enabled = prive.Cetak
      chartPopUpEkspor.Enabled = prive.Eksport

      If ActivateToolTip Then
        AddHandler toolTip.GetActiveObjectInfo, AddressOf toolTipJurnal_GetActiveObjectInfo
      End If
      If Not showFilter Then
        barMenuFilter.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
      End If
      If Not showChart AndAlso Not DesignMode Then
        barChart.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
      End If

      FirstLoad()
    End Sub

    Private Sub barMenuRefresh_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuRefresh.ItemClick
      RefreshData()
    End Sub
    Private Sub barMenuFilter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuFilter.ItemClick
      Dim frm As InputFilter = GetFilterForm()

      If fixedCriteriaString <> "" Then
        frm.CriteriaString = xpCol.CriteriaString.Replace(" AND " & fixedCriteriaString, "")
      Else
        frm.CriteriaString = xpCol.CriteriaString
      End If
      If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
        If fixedCriteriaString <> "" Then
          xpCol.CriteriaString = frm.CriteriaString & " AND " & fixedCriteriaString
        Else
          xpCol.CriteriaString = frm.CriteriaString
        End If
      End If
    End Sub

    Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
      GridViewColumnWidthChanged(sender, e)
    End Sub
    Private Sub xGridView_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles xGridView.RowCellStyle
      GridViewRowCellStyle(sender, e)
    End Sub
    Private Sub xGridView_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles xGridView.RowStyle
      GridViewRowStyle(sender, e)
    End Sub

    Private Sub xpCol_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpCol.ResolveSession
      If Not useFeedbackSource Then
        e.Session = GetSession()
      End If
    End Sub
    Private Sub ifSource_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles ifSource.ResolveSession
      If useFeedbackSource Then
        e.Session = GetSession()
      End If
    End Sub

    Private Sub toolTipJurnal_GetActiveObjectInfo(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs)
      If e.Info Is Nothing AndAlso e.SelectedControl Is xGrid Then
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(xGrid.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = view.CalcHitInfo(e.ControlMousePosition)
        If info.InRow AndAlso Not view.IsGroupRow(info.RowHandle) Then
          Dim cellKey As String = info.RowHandle.ToString()
          Dim a As New DevExpress.Utils.ToolTipControlInfo
          Dim s As New DevExpress.Utils.SuperToolTip
          Dim i As New DevExpress.Utils.ToolTipItem
          Dim content As String = GetToolTipContent(view, info)

          If content = "" Then
            Exit Sub
          End If
          i.Font = New Drawing.Font("Courier New", 8.5, Drawing.FontStyle.Regular)
          i.Text = content

          s.Items.Add(i)
          s.Items.AddSeparator()
          s.Items.AddTitle(GetToolTipTitle(view, info))
          s.MaxWidth = 50000

          a.Object = cellKey
          a.SuperTip = s
          e.Info = a
        End If
      End If
    End Sub

    Private Sub popMenuEksport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles popMenuEksport.ItemClick
      Core.Win.Component.XtraGrid.ExportExcel(xGrid, session, Me.Text)
    End Sub
    Private Sub popMenuCetak_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles popMenuCetak.ItemClick
      Core.Win.Component.XtraGrid.PrintPreview(xGrid, session, Me.Text)
    End Sub

    Protected Friend Function GetSession() As DevExpress.Xpo.UnitOfWork
      If Not session.IsConnected Then
        If UseDbSystem Then
          session = Data.DbSystem.GetXPOSession
        Else
          session = Data.DbClient.GetXPOSession(NamaDatabase)
        End If
      End If

      Return session
    End Function

    Private Sub barChart_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barChart.ItemClick
      If CBool(barChart.Tag) Then
        SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        barChart.Tag = False
        barChart.Caption = "Tampilkan &Grafik"
      Else
        SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both
        barChart.Tag = True
        barChart.Caption = "Sembunyikan &Grafik"
      End If
    End Sub
    Private Sub chartPopUpCetak_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles chartPopUpCetak.ItemClick
      Core.Win.Component.XtraChart.PrintPreview(xChart, session, Me.Text)
    End Sub
    Private Sub chartPopUpWizard_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles chartPopUpWizard.ItemClick
      Core.Win.Component.XtraChart.ShowWizard(xChart)
    End Sub

    Private Sub CreateExportMenu()
      Dim miExportToPdf As DevExpress.XtraBars.BarItem = New DevExpress.XtraBars.BarButtonItem(barMan, "PDF")
      Dim miExportToHtml As DevExpress.XtraBars.BarItem = New DevExpress.XtraBars.BarButtonItem(barMan, "HTML")
      Dim miExportToMht As DevExpress.XtraBars.BarItem = New DevExpress.XtraBars.BarButtonItem(barMan, "MHT")
      Dim miExportToXls As DevExpress.XtraBars.BarItem = New DevExpress.XtraBars.BarButtonItem(barMan, "XLS")
      Dim miExportToImage As DevExpress.XtraBars.BarSubItem = New DevExpress.XtraBars.BarSubItem(barMan, "Image")

      AddExportImageFormat(miExportToImage, System.Drawing.Imaging.ImageFormat.Bmp)
      AddExportImageFormat(miExportToImage, System.Drawing.Imaging.ImageFormat.Emf)
      AddExportImageFormat(miExportToImage, System.Drawing.Imaging.ImageFormat.Exif)
      AddExportImageFormat(miExportToImage, System.Drawing.Imaging.ImageFormat.Gif)
      AddExportImageFormat(miExportToImage, System.Drawing.Imaging.ImageFormat.Icon)
      AddExportImageFormat(miExportToImage, System.Drawing.Imaging.ImageFormat.Jpeg)
      AddExportImageFormat(miExportToImage, System.Drawing.Imaging.ImageFormat.Png)
      AddExportImageFormat(miExportToImage, System.Drawing.Imaging.ImageFormat.Tiff)
      AddExportImageFormat(miExportToImage, System.Drawing.Imaging.ImageFormat.Wmf)

      chartPopUpEkspor.ItemLinks.AddRange(New DevExpress.XtraBars.BarItem() {miExportToPdf, miExportToHtml, miExportToMht, miExportToXls, miExportToImage})

      AddHandler miExportToHtml.ItemClick, AddressOf ExportToHtml
      AddHandler miExportToMht.ItemClick, AddressOf ExportToMht
      AddHandler miExportToPdf.ItemClick, AddressOf ExportToPdf
      AddHandler miExportToXls.ItemClick, AddressOf ExportToXls
    End Sub
    Private Sub AddExportImageFormat(ByVal biImagesMenuItem As DevExpress.XtraBars.BarSubItem, ByVal format As System.Drawing.Imaging.ImageFormat)
      Dim codecInfo As System.Drawing.Imaging.ImageCodecInfo = Utils.Image.FindImageCodec(format)
      If codecInfo Is Nothing Then
        Return
      End If

      'Dim item As BarExportToImageItem = New BarExportToImageItem(barMan, format, codecInfo)
      Dim item As DevExpress.XtraBars.BarButtonItem = New DevExpress.XtraBars.BarButtonItem(barMan, codecInfo.FormatDescription)
      item.Tag = format
      AddHandler item.ItemClick, AddressOf ExportToImage
      biImagesMenuItem.AddItem(item)
    End Sub
    Private Sub ExportToHtml(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
      Core.Win.Component.XtraChart.Export(Component.XtraChart.ExportKind.Html, xChart, session, Me.Text)
    End Sub
    Private Sub ExportToMht(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
      Core.Win.Component.XtraChart.Export(Component.XtraChart.ExportKind.Mht, xChart, session, Me.Text)
    End Sub
    Private Sub ExportToPdf(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
      Core.Win.Component.XtraChart.Export(Component.XtraChart.ExportKind.Pdf, xChart, session, Me.Text)
    End Sub
    Private Sub ExportToXls(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
      Core.Win.Component.XtraChart.Export(Component.XtraChart.ExportKind.Xls, xChart, session, Me.Text)
    End Sub
    Private Sub ExportToImage(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
      Core.Win.Component.XtraChart.Export(Component.XtraChart.ExportKind.Image, xChart, session, Me.Text, CType(e.Item.Tag, Drawing.Imaging.ImageFormat))
    End Sub

    Private Sub CreateAppearancesMenu()
      Dim appearanceNames As String() = xChart.GetAppearanceNames()
      Dim naturalColorIndex As Integer = 0
      Dim i As Integer = 0
      Do While i < appearanceNames.Length
        Dim miAppearanceName As DevExpress.XtraBars.BarItem = New DevExpress.XtraBars.BarCheckItem(Me.barMan)
        miAppearanceName.Caption = appearanceNames(i)
        If appearanceNames(i) = "Nature Colors" Then
          naturalColorIndex = i
        End If
        AddHandler miAppearanceName.ItemClick, AddressOf miAppearanceName_Click
        chartPopUpAppearance.ItemLinks.Add(miAppearanceName)
        i += 1
      Loop
      If appearanceNames.Length > 0 Then
        Dim item As DevExpress.XtraBars.BarCheckItem = TryCast(chartPopUpAppearance.ItemLinks(naturalColorIndex).Item, DevExpress.XtraBars.BarCheckItem)
        If Not chartPopUpAppearance Is Nothing Then
          miAppearanceName_Click(Me.barMan, New DevExpress.XtraBars.ItemClickEventArgs(item, Nothing))
          item.Checked = True
        End If
      End If
    End Sub
    Private Sub miAppearanceName_Click(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
      Dim item As DevExpress.XtraBars.BarItem = e.Item
      If item Is Nothing Then
        Return
      End If
      SetAppearanceName(item.Caption)
    End Sub
    Private Sub SetAppearanceName(ByVal name As String)
      If (chartPopUpAppearance Is Nothing) Then
        Return
      End If
      appearanceName = name

      Dim paletteName As String = SetAppearanceNameInfo(appearanceName)
      If (paletteName.Length > 0) Then
        Me.paletteName = paletteName
      End If
      UpdateMenu()
    End Sub

    Private Sub CreatePalettesMenu()
      Dim paletteNames As String() = xChart.GetPaletteNames()
      Dim naturalColorIndex As Integer = 0
      Dim i As Integer = 0
      Do While i < paletteNames.Length
        Dim miPaletteName As DevExpress.XtraBars.BarItem = New DevExpress.XtraBars.BarCheckItem(Me.barMan)
        miPaletteName.Caption = paletteNames(i)
        If paletteNames(i) = "Nature Colors" Then
          naturalColorIndex = i
        End If
        AddHandler miPaletteName.ItemClick, AddressOf miPaletteName_Click
        chartPopUpPallette.ItemLinks.Add(miPaletteName)
        i += 1
      Loop
      If paletteNames.Length > 0 Then
        Dim item As DevExpress.XtraBars.BarCheckItem = TryCast(chartPopUpPallette.ItemLinks(naturalColorIndex).Item, DevExpress.XtraBars.BarCheckItem)
        If Not chartPopUpPallette Is Nothing Then
          miPaletteName_Click(Me.barMan, New DevExpress.XtraBars.ItemClickEventArgs(item, Nothing))
          item.Checked = True
        End If
      End If
    End Sub
    Private Sub miPaletteName_Click(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
      Dim item As DevExpress.XtraBars.BarItem = e.Item
      If item Is Nothing Then
        Return
      End If
      SetPaletteName(item.Caption)
    End Sub
    Private Sub SetPaletteName(ByVal name As String)
      If (chartPopUpPallette Is Nothing) Then
        Return
      End If
      paletteName = name
      Dim appearanceName As String = SetPaletteNameInfo(paletteName)
      If (appearanceName.Length > 0) Then
        Me.appearanceName = appearanceName
      End If
      UpdateMenu()
    End Sub
    Public Function SetAppearanceNameInfo(ByVal appearanceName As String) As String
      xChart.AppearanceName = appearanceName
      Return xChart.PaletteName
    End Function
    Public Function SetPaletteNameInfo(ByVal paletteName As String) As String
      xChart.PaletteName = paletteName
      Return xChart.AppearanceName
    End Function

    Public Sub UpdateMenu()
      Dim count As Integer = chartPopUpAppearance.ItemLinks.Count
      Dim i As Integer = 0
      Do While i < count
        Dim item As DevExpress.XtraBars.BarCheckItem = TryCast(chartPopUpAppearance.ItemLinks(i).Item, DevExpress.XtraBars.BarCheckItem)
        If Not item Is Nothing Then
          item.Checked = item.Caption = appearanceName
        End If
        i += 1
      Loop

      If (chartPopUpPallette Is Nothing) Then
        Return
      End If
      count = chartPopUpPallette.ItemLinks.Count
      i = 0
      Do While i < count
        Dim item As DevExpress.XtraBars.BarCheckItem = TryCast(chartPopUpPallette.ItemLinks(i).Item, DevExpress.XtraBars.BarCheckItem)
        If Not item Is Nothing Then
          item.Checked = item.Caption = paletteName
        End If
        i += 1
      Loop
    End Sub

    Private Sub barMan_QueryShowPopupMenu(sender As Object, e As DevExpress.XtraBars.QueryShowPopupMenuEventArgs) Handles barMan.QueryShowPopupMenu
      If (TypeOf (e.Control) Is DevExpress.XtraGrid.GridControl) Then
        Dim grid As DevExpress.XtraGrid.GridControl = CType(e.Control, DevExpress.XtraGrid.GridControl)
        'Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(grid.KeyboardFocusView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(grid.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = view.CalcHitInfo(grid.PointToClient(e.Position))
        e.Cancel = info.InColumnPanel Or info.InGroupPanel
      End If
    End Sub
  End Class
End Namespace