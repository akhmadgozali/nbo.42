Namespace NuSoft.Core.Win.Component
  Public Class XtraChart
    Enum ExportKind
      Html
      Mht
      Pdf
      Xls
      Image
    End Enum
    Shared Sub PrintPreview(ByVal dxChart As DevExpress.XtraCharts.ChartControl, sesi As DevExpress.Xpo.Session, ByVal title As String)
      Dim currentCursor As Windows.Forms.Cursor = Windows.Forms.Cursor.Current
      Windows.Forms.Cursor.Current = Windows.Forms.Cursors.WaitCursor
      If dxChart.IsPrintingAvailable Then
        dxChart.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Zoom
        dxChart.ShowPrintPreview()
        Core.SSystem.DatabaseLog.SaveSimpleLog(sesi, NPO.DatabaseLog.Action.Cetak, title)
      Else
        Utils.Win.MessageBox.Show("XtraPrinting Library tidak ditemukan.", "Print Preview", "Pastikan file DevExpress.Printing.v11.2.Core.dll ada di folder SyBiru", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      End If
      Windows.Forms.Cursor.Current = currentCursor
    End Sub
    Shared Sub Export(kind As ExportKind, ByVal dxChart As DevExpress.XtraCharts.ChartControl, sesi As DevExpress.Xpo.Session, ByVal title As String)
      Export(kind, dxChart, sesi, title, Nothing)
    End Sub
    Shared Sub Export(kind As ExportKind, ByVal dxChart As DevExpress.XtraCharts.ChartControl, sesi As DevExpress.Xpo.Session, ByVal title As String, ByVal imageFormat As System.Drawing.Imaging.ImageFormat)
      Dim exportTitle, exportFilter As String
      Select Case kind
        Case ExportKind.Html : exportTitle = "HTML Document" : exportFilter = "HTML Documents (*.htm; *.html)|*.htm; *.html"
        Case ExportKind.Mht : exportTitle = "MHT Document" : exportFilter = "MHT Documents (*.mht)|*.mht"
        Case ExportKind.Pdf : exportTitle = "PDF Document" : exportFilter = "PDF Documents (*.pdf)|*.pdf"
        Case ExportKind.Xls : exportTitle = "XLS Document" : exportFilter = "XLS Documents (*.xls)|*.xls"
        Case ExportKind.Image
          Dim codecInfo As System.Drawing.Imaging.ImageCodecInfo = Utils.Image.FindImageCodec(imageFormat)
          If codecInfo Is Nothing Then
            Return
          End If
          exportTitle = String.Format("{0} image", codecInfo.FormatDescription)
          exportFilter = String.Format("{0} ({1})|{1}", exportTitle, codecInfo.FilenameExtension)
        Case Else : exportTitle = "" : exportFilter = ""
      End Select

      Dim fileName As String = Utils.Win.File.ShowSaveFileDialog(exportTitle, exportFilter)
      If fileName <> "" Then
        Dim currentCursor As Windows.Forms.Cursor = Windows.Forms.Cursor.Current
        Windows.Forms.Cursor.Current = Windows.Forms.Cursors.WaitCursor
        Select Case kind
          Case ExportKind.Html : dxChart.ExportToHtml(fileName)
          Case ExportKind.Mht : dxChart.ExportToMht(fileName)
          Case ExportKind.Pdf : dxChart.ExportToPdf(fileName)
          Case ExportKind.Xls : dxChart.ExportToXls(fileName)
          Case ExportKind.Image : dxChart.ExportToImage(fileName, imageFormat)
        End Select
        Windows.Forms.Cursor.Current = currentCursor
        Core.SSystem.DatabaseLog.SaveSimpleLog(sesi, NPO.DatabaseLog.Action.Ekspor, String.Format("Eksport {0} ke {1}", title, fileName))
        Utils.Win.File.OpenFile(fileName, "Export Chart")
      End If
    End Sub
    Shared Sub ShowWizard(dxChart As DevExpress.XtraCharts.ChartControl)
      Dim chartWizard_Renamed As DevExpress.XtraCharts.Wizard.ChartWizard = New DevExpress.XtraCharts.Wizard.ChartWizard(dxChart)
      chartWizard_Renamed.ShowDialog()
    End Sub
  End Class
End Namespace