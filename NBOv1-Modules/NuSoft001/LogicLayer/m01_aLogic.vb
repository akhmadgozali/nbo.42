Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace Logic
  Friend Class Umum
    Shared Function xLokasiLayout(xNamaFile As String) As String
      Dim xLokasi As String
      xLokasi = Replace(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase), "\Modules", "\layout\m01\")
      xLokasi = Replace(xLokasi, "file:\", "")
      xLokasi = xLokasi & xNamaFile
      Return xLokasi
    End Function
  End Class
  Public Class Voucher
    Public Sub showVoucher(session As UnitOfWork, xNoTransaksi As String)
      Dim frm As New UI_JurnalVoucher
      frm.session = session
      frm.ShowDialog()
    End Sub
  End Class
End Namespace