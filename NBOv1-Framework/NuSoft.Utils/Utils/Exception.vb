Namespace NuSoft.Utils
  Public Class Exception
    Inherits System.Exception

    Property ErrorNumber As Integer
    Property ErrorMessage As String
    Property ErrorSolution As String
    Property ErrorSource As String

    Public Sub New()
      Me.New("")
    End Sub
    Public Sub New(ByVal message As String)
      Me.New(message, 0)
    End Sub
    Public Sub New(ByVal message As String, ByVal number As Integer)
      Me.New(message, number, "")
    End Sub
    Public Sub New(ByVal message As String, ByVal number As Integer, ByVal solution As String)
      Me.New(message, number, solution, "")
    End Sub
    Public Sub New(ByVal message As String, ByVal number As Integer, ByVal solution As String, ByVal source As String)
      MyBase.New(message)
      ErrorNumber = number : ErrorMessage = message
      ErrorSolution = solution : ErrorSource = source
    End Sub
    Public Sub New(ByVal message As String, ByVal innerException As System.Exception)
      MyBase.New(message, innerException)
      ErrorNumber = 0 : ErrorMessage = message
      ErrorSolution = "" : ErrorSource = ""
    End Sub
    Public Sub New(ex As Exception)
      Me.New(ex.Message, ex.ErrorNumber, ex.ErrorSolution, ex.ErrorSource)
    End Sub
    Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
      MyBase.New(info, context)
      ErrorNumber = 0 : ErrorMessage = ""
      ErrorSolution = "" : ErrorSource = ""
    End Sub

    Sub ShowWinExceptionBox()
      Using frm As New Win.ExceptionBox(Me)
        frm.ShowDialog()
      End Using
    End Sub
    Sub ShowWinMessageBox()
      Win.MessageBox.Show(ErrorMessage, ErrorSource, ErrorSolution, Win.MessageBox.Button.OK, Win.MessageBox.Icon.Peringatan)
    End Sub
  End Class
End Namespace