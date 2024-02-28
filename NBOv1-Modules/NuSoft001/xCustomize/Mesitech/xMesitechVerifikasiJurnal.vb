Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Public Class xMesitechVerifikasiJurnal
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    'lytTransaksi.RestoreLayoutFromXml()
  End Sub
  Overrides Sub FirstLoad()
    session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
    Dim xData As New XPCollection(Of Persistent.xMesitechGLMain)(session, New BinaryOperator("Status", Persistent.StatusTransaksiEnum.Pending, BinaryOperatorType.Equal))
    gcMain.DataSource = xData
  End Sub
  Private Sub gcMain_DoubleClick(sender As Object, e As EventArgs) Handles gcMain.DoubleClick
    If Not gcMain.DataSource Is Nothing Then
      If Not gcMainView.FocusedRowHandle = Nothing Then
        txtNoBukti.Text = gcMainView.GetFocusedRowCellDisplayText(colKode)
        Dim zdtGL As Persistent.xMesitechGLMain = session.FindObject(Of Persistent.xMesitechGLMain)(New BinaryOperator("Kode", txtNoBukti.Text, BinaryOperatorType.Equal))
        If Not zdtGL Is Nothing Then
          txtTanggal.DateTime = zdtGL.Tanggal
          txtKontak.Text = zdtGL.Kontak.Nama
          txtUraian.Text = zdtGL.Uraian
          gcDetail.DataSource = New XPCollection(Of Persistent.xMesitechGlDetail)(session, New BinaryOperator("Main.Kode", txtNoBukti.Text, BinaryOperatorType.Equal))
        End If
      End If
    End If
  End Sub
  'Private Sub btnVerifikasi_Click(sender As Object, e As EventArgs) Handles btnVerifikasi.Click
  '  Dim zdtGL As Persistent.xMesitechGLMain = session.FindObject(Of Persistent.xMesitechGLMain)(New BinaryOperator("Kode", txtNoBukti.Text, BinaryOperatorType.Equal))
  '  If Not zdtGL Is Nothing Then
  '    zdtGL.Status = Persistent.StatusTransaksiEnum.Posting
  '    zdtGL.Save()
  '    session.CommitChanges()
  '    gcMain.RefreshDataSource()
  '  End If
  'End Sub
End Class