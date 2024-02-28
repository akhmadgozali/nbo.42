Namespace NuSoft.Core.Win.Component
  Public Class XtraPivotGrid
    Shared Sub ExportExcel(ByVal pvGrid As DevExpress.XtraPivotGrid.PivotGridControl, sesi As DevExpress.Xpo.Session, ByVal title As String)
      Dim fileName As String = Utils.Win.File.ShowSaveFileDialog("Expor ke Microsoft Excel", "Microsoft Excel (*.xls)|*.xls")
      If fileName <> "" Then
        pvGrid.ExportToXls(fileName)
        Core.SSystem.DatabaseLog.SaveSimpleLog(sesi, NPO.DatabaseLog.Action.Ekspor, String.Format("Eksport {0} ke {1}", title, fileName))
        Utils.Win.File.OpenFile(fileName, "Export Excel")
      End If
    End Sub
    Shared Sub ExportPdf(ByVal pvGrid As DevExpress.XtraPivotGrid.PivotGridControl, sesi As DevExpress.Xpo.Session, ByVal title As String)
      Dim fileName As String = Utils.Win.File.ShowSaveFileDialog("Ekspor ke PDF", "Pdf Documents (*.pdf)|*.pdf")
      If fileName <> "" Then
        pvGrid.ExportToPdf(fileName)
        Core.SSystem.DatabaseLog.SaveSimpleLog(sesi, NPO.DatabaseLog.Action.Ekspor, String.Format("Eksport {0} ke {1}", title, fileName))
        Utils.Win.File.OpenFile(fileName, "Export PDF")
      End If
    End Sub
    Shared Sub PrintPreview(ByVal pvGrid As DevExpress.XtraPivotGrid.PivotGridControl, sesi As DevExpress.Xpo.Session, ByVal title As String)
      Dim currentCursor As Windows.Forms.Cursor = Windows.Forms.Cursor.Current
      Windows.Forms.Cursor.Current = Windows.Forms.Cursors.WaitCursor
      If pvGrid.IsPrintingAvailable Then
        pvGrid.ShowPrintPreview()
        Core.SSystem.DatabaseLog.SaveSimpleLog(sesi, NPO.DatabaseLog.Action.Cetak, "Preview " & title)
      Else
        Utils.Win.MessageBox.Show("XtraPrinting Library tidak ditemukan.", "Print Preview", "Pastikan file DevExpress.Printing.v11.2.Core.dll ada di folder SyBiru", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      End If
      Windows.Forms.Cursor.Current = currentCursor
    End Sub
  End Class
End Namespace