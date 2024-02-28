Namespace NuSoft.Core.Win.Forms
  Public Class InputFilter
    Property CriteriaString As String

    Overridable Function BuildCriteria() As String
      Return Nothing
    End Function
    Overridable Sub ExtractCriteria()

    End Sub

    Private Sub Me_Load(sender As Object, e As System.EventArgs) Handles Me.Load
      ExtractCriteria()
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As System.EventArgs) Handles btnBatal.Click
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub btnFilter_Click(sender As Object, e As System.EventArgs) Handles btnFilter.Click
      CriteriaString = BuildCriteria()
      Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
  End Class
End Namespace