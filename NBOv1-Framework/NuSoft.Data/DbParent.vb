Namespace NuSoft.Data
  Public MustInherit Class DbParent
    Implements IDisposable

    Private disposedValue As Boolean ' To detect redundant calls
    Protected Friend Shared ReadOnly cryptDes As New Utils.Cryptograph.DES()
    'server=localhost;User Id=nusoft_user;port=48384;database=nusoft_system;
    'Protected Friend Const formatString As String = "Server={0}; User ID={1}; Password={2}; Port={3}; Database={4};Ssl Mode=Required;Integrated Security=True;"
    'Protected Friend Const formatString As String = "Server={0}; User ID={1}; Password={2}; Port={3}; Database={4};Integrated Security=True;"
    Protected Friend Const formatString As String = "Server={0}; User ID={1}; Password={2}; Port={3}; Database={4};"
    Protected Friend Shared format1 As String = My.Resources.format1
    Protected Friend Shared format2 As String = My.Resources.format2
    Protected Friend Shared format3 As String = My.Resources.format3
    Protected Friend Shared format4 As String = My.Resources.format4
    Protected Friend Shared format5 As String = My.Resources.format5
    Protected Friend Shared format6 As String = My.Resources.format6
    Protected Friend Shared format7 As String = My.Resources.format7

#Region "IDisposable Support"
    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
      If Not disposedValue Then
        If disposing Then
          ' TODO: dispose managed state (managed objects).
          cryptDes.Dispose()
        End If

        ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
        ' TODO: set large fields to null.
      End If
      disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
      ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
      Dispose(True)
      GC.SuppressFinalize(Me)
    End Sub
#End Region
  End Class
End Namespace