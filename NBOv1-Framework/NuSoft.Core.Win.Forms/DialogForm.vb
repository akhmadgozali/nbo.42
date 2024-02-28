Namespace NuSoft.Core.Win.Forms
  Public Class DialogForm
    Property Btn2IsClosedButton As Boolean
    Property AutoCloseOnSave As Boolean
    Property session As DevExpress.Xpo.UnitOfWork

    Overridable Sub Btn1Click()

    End Sub
    Overridable Sub ErrorBtn1Click(ByVal ex As Utils.Exception)
      ex.ShowWinExceptionBox()
    End Sub
    Overridable Sub Btn2Click()

    End Sub
    Overridable Sub InitializeData()

    End Sub
    Overridable Sub InitializeUsedComponent()

    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      InitializeUsedComponent()
      InitializeData()
    End Sub

    Private Sub btn1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn1.Click
      Try
        Btn1Click()
        If AutoCloseOnSave Then
          Me.DialogResult = Windows.Forms.DialogResult.OK
          Me.Close()
        Else
          InitializeData()
        End If
      Catch ex As Utils.Exception
        ErrorBtn1Click(ex)
      End Try
    End Sub
    Private Sub btn2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn2.Click
      If Btn2IsClosedButton Then
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
      Else
        Btn2Click()
      End If
    End Sub
    Protected Friend Function GetSession() As DevExpress.Xpo.UnitOfWork
      If session Is Nothing Then
        session = New DevExpress.Xpo.UnitOfWork
      End If
      If Not session.IsConnected Then
        If UseDbSystem Then
          session = Data.DbSystem.GetXPOSession
        Else
          session = Data.DbClient.GetXPOSession(NamaDatabase)
        End If
      End If

      Return session
    End Function
	End Class
End Namespace