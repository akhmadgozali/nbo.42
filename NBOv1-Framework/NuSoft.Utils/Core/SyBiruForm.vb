Namespace NuSoft.Core.Win.Forms
  Public Class NuSoftForm
    Inherits DevExpress.XtraEditors.XtraForm

    Property NamaDatabase As String
    Property MenuId As Integer
    Property UseDbSystem As Boolean

    Private Sub Me_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
      If Not e.Control Then
        If e.KeyCode = Windows.Forms.Keys.Enter Then
          Me.ProcessTabKey(Not e.Shift)
          e.Handled = True
        End If
      End If
    End Sub
  End Class
End Namespace