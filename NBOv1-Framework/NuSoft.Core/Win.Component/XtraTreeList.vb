Namespace NuSoft.Core.Win.Component
  Public Class XtraTreeList
    Shared Sub ExportExcel(ByVal dxTree As DevExpress.XtraTreeList.TreeList, sesi As DevExpress.Xpo.Session, ByVal title As String)
      Dim fileName As String = Utils.Win.File.ShowSaveFileDialog("Expor ke Microsoft Excel", "Microsoft Excel (*.xls)|*.xls")
      If fileName <> "" Then
        dxTree.ExportToXls(fileName)
        Core.SSystem.DatabaseLog.SaveSimpleLog(sesi, NPO.DatabaseLog.Action.Ekspor, String.Format("Eksport {0} ke {1}", title, fileName))
        Utils.Win.File.OpenFile(fileName, "Export Excel")
      End If
    End Sub
    Shared Sub ExportPdf(ByVal dxTree As DevExpress.XtraTreeList.TreeList, sesi As DevExpress.Xpo.Session, ByVal title As String)
      Dim fileName As String = Utils.Win.File.ShowSaveFileDialog("Ekspor ke PDF", "Pdf Documents (*.pdf)|*.pdf")
      If fileName <> "" Then
        dxTree.ExportToPdf(fileName)
        Core.SSystem.DatabaseLog.SaveSimpleLog(sesi, NPO.DatabaseLog.Action.Ekspor, String.Format("Eksport {0} ke {1}", title, fileName))
        Utils.Win.File.OpenFile(fileName, "Export PDF")
      End If
    End Sub
    Shared Sub PrintPreview(ByVal dxTree As DevExpress.XtraTreeList.TreeList, sesi As DevExpress.Xpo.Session, ByVal title As String)
      Dim currentCursor As Windows.Forms.Cursor = Windows.Forms.Cursor.Current
      Windows.Forms.Cursor.Current = Windows.Forms.Cursors.WaitCursor
      If dxTree.IsPrintingAvailable Then
        dxTree.ShowPrintPreview()
        Core.SSystem.DatabaseLog.SaveSimpleLog(sesi, NPO.DatabaseLog.Action.Cetak, title)
      Else
        Utils.Win.MessageBox.Show("XtraPrinting Library tidak ditemukan.", "Print Preview", "Pastikan file DevExpress.Printing.v11.2.Core.dll ada di folder SyBiru", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      End If
      Windows.Forms.Cursor.Current = currentCursor
    End Sub
  End Class
End Namespace