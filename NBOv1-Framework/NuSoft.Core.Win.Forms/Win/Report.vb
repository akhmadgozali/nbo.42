Namespace NuSoft.Core.Win
  Public Class Report
    Shared Function DirectExecuteReport(frm As NuSoft.Core.Win.Forms.FilterForm, namaDatabase As String, reportCode As String, message As String) As Boolean
      Return DirectExecuteReport(frm, namaDatabase, reportCode, message)
    End Function
    Shared Function DirectExecuteReport(frm As NuSoft.Core.Win.Forms.FilterForm, namaDatabase As String, reportCode As String, message As String, Preview As Boolean) As Boolean
      Const title As String = "Cetak Laporan"
      Try
        Dim sesi As DevExpress.Xpo.Session = Data.DbSystem.GetXPOSession
        Dim lap As NPO.SSystem.Laporan = sesi.FindObject(Of NPO.SSystem.Laporan)(DevExpress.Data.Filtering.CriteriaOperator.Parse("Kode = '" & reportCode & "'"))

        frm.NamaDatabase = namaDatabase
        frm.ReportId = lap.Id
        frm.LayoutReportTerpisah = True

        If message <> "" AndAlso Utils.Win.MessageBox.Show(message, title, "", Utils.Win.MessageBox.Button.YaTidak, Utils.Win.MessageBox.Icon.Pertanyaan) = Utils.Win.MessageBox.DialogResult.Tidak Then
          Return False
        End If

        frm.MeLoad()
        If Not frm.IsRightToPrint Then
          Utils.Win.MessageBox.Show("Maaf, anda tidak berhak untuk mencetak laporan ini.", title, "Hubungi administrator untuk mengaktifkan fitur ini", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
          Return False
        End If
        frm.Filter()

        Dim reportFile As String = lap.NamaFile
        Dim filePath As String = String.Format("{0}\Report\{1}", My.Application.Info.DirectoryPath, reportFile)
        Using FrmReport As New NUI.Win.Report.UI_Viewer
          FrmReport.FileName = filePath
          FrmReport.dataSource = frm.DataSource
          FrmReport.Parameters = frm.Parameters
          FrmReport.OpenReport(frm.IsRightToExport, frm.IsRightToPrint)
          If Preview Then
            FrmReport.ShowDialog()
          Else
            FrmReport.Print()
          End If
        End Using

        Return True
      Catch ex As Exception
        Throw New Utils.Exception(ex.Message)
        Return False
      End Try
    End Function
  End Class
End Namespace