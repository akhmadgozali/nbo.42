Imports DevExpress.Data.Filtering

Namespace NuSoft.NPO.CustomFunction
  Public Class YearFunction
    Implements ICustomFunctionOperatorFormattable

    Public Function Evaluate(ParamArray operands() As Object) As Object Implements DevExpress.Data.Filtering.ICustomFunctionOperator.Evaluate
      Return Year(CDate(operands(0)))
    End Function
    Public ReadOnly Property Name As String Implements DevExpress.Data.Filtering.ICustomFunctionOperator.Name
      Get
        Return "Year"
      End Get
    End Property
    Public Function ResultType(ParamArray operands() As System.Type) As System.Type Implements DevExpress.Data.Filtering.ICustomFunctionOperator.ResultType
      Return GetType(Integer)
    End Function
    Public Function Format(providerType As System.Type, ParamArray operands() As String) As String Implements DevExpress.Data.Filtering.ICustomFunctionOperatorFormattable.Format
      '' This example implements the function for MS Access databases only. 
      'If providerType Is GetType(AccessConnectionProvider) Then
      '  Return String.Format("datepart(""m"", {0})", operands(0))
      'End If
      'Throw New NotSupportedException(String.Concat( _
      '"This provider is not supported: ", providerType.Name))
      Return String.Format("Year({0})", operands(0))
    End Function
    Public Shared Function Month(ByVal dateValue As Date) As Integer
      Return Microsoft.VisualBasic.DateAndTime.Year(dateValue)
    End Function
  End Class
End Namespace