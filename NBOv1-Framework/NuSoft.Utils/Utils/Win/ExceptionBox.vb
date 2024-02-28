Namespace NuSoft.Utils.Win
  Friend Class ExceptionBox
    Sub New(ByVal ex As Exception)
      ' This call is required by the designer.
      InitializeComponent()
      ' Add any initialization after the InitializeComponent() call.
      txtNomor.EditValue = ex.ErrorNumber
      txtPesan.EditValue = ex.ErrorMessage
      txtSolusi.EditValue = ex.ErrorSolution
      txtSumber.EditValue = ex.ErrorSource
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub btnCopy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCopy.Click
      Dim formatClipboard As String = "Nomor : {0}" & vbCrLf & "Pesan : {1}" & vbCrLf & "Solusi : {2}" & vbCrLf & "Sumber : {3}"
      System.Windows.Forms.Clipboard.Clear()
      System.Windows.Forms.Clipboard.SetText(String.Format(formatClipboard, txtNomor.Text, txtPesan.Text, txtSolusi.Text, txtSumber.Text), Windows.Forms.TextDataFormat.Text)
    End Sub
  End Class
End Namespace