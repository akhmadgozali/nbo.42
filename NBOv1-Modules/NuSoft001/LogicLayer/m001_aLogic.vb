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
    'Shared Sub xLoadLayout(xObject As Object, xNamaFile As String)
    '  If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout(xNamaFile)) = True Then
    '    'lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("DPTransaksi.xml"))
    '    xObject.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout(xNamaFile))
    '  End If
    'End Sub
  End Class
  Public Class Voucher
    Public Sub showVoucher(xForm As Core.Win.Forms.GridInput, session As UnitOfWork, xNoTransaksi As String)
      Dim frm As New UI_JurnalVoucher(xNoTransaksi)
      frm.MenuId = xForm.MenuId
      frm.NamaDatabase = xForm.NamaDatabase
      frm.session = session
      frm.ShowDialog()
    End Sub
  End Class
End Namespace