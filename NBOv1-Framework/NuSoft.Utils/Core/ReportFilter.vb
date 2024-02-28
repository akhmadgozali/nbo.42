Namespace NuSoft.Core.Win.Forms
  Public MustInherit Class ReportFilter
    Inherits DevExpress.XtraEditors.XtraForm

    Protected Friend _parameters As New List(Of DevExpress.XtraReports.Parameters.Parameter)
    Protected Friend _dataSource As Object
    Protected Friend _isRightToExport As Boolean
    Protected Friend _isRightToPrint As Boolean

    ReadOnly Property DataSource As Object
      Get
        Return _dataSource
      End Get
    End Property
    ReadOnly Property Parameters As List(Of DevExpress.XtraReports.Parameters.Parameter)
      Get
        Return _parameters
      End Get
    End Property
    ReadOnly Property IsRightToExport As Boolean
      Get
        Return _isRightToExport
      End Get
    End Property
    ReadOnly Property IsRightToPrint As Boolean
      Get
        Return _isRightToPrint
      End Get
    End Property

    Property NamaDatabase As String
    Property ReportId As Integer
    Property UseDbSystem As Boolean
    Property LayoutReportTerpisah As Boolean

    Private Sub Me_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
      If Not e.Control Then
        If e.KeyCode = Windows.Forms.Keys.Enter Then
          Me.ProcessTabKey(Not e.Shift)
          e.Handled = True
        End If
      End If
    End Sub
    Protected Friend Sub AddParameter(Name As String, Value As Object)
      AddParameter(Name, Value, GetType(Object))
    End Sub
    Protected Friend Sub AddParameter(Name As String, Value As Object, Type As Type)
      AddParameter(Name, Value, Type, False)
    End Sub
    Protected Friend Sub AddParameter(Name As String, Value As Object, Type As Type, Visible As Boolean)
      Dim parameter As New DevExpress.XtraReports.Parameters.Parameter
      parameter.Name = Name
      parameter.Type = Type
      parameter.Value = Value
      parameter.Visible = Visible
      _parameters.Add(parameter)
    End Sub
  End Class
End Namespace