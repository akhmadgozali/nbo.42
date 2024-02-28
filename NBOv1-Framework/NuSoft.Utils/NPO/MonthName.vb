Imports DevExpress.Data.Filtering

Namespace NuSoft.NPO.CustomFunction
  Public Class MonthNameFunction
    Implements ICustomFunctionOperatorFormattable

    Public Function Evaluate(ParamArray operands() As Object) As Object Implements DevExpress.Data.Filtering.ICustomFunctionOperator.Evaluate
      If operands.GetUpperBound(0) > 0 Then
        Return MonthName(CInt(operands(0)), CBool(operands(1)))
      Else
        Return MonthName(CInt(operands(0)))
      End If
    End Function
    Public ReadOnly Property Name As String Implements DevExpress.Data.Filtering.ICustomFunctionOperator.Name
      Get
        Return "MonthName"
      End Get
    End Property
    Public Function ResultType(ParamArray operands() As System.Type) As System.Type Implements DevExpress.Data.Filtering.ICustomFunctionOperator.ResultType
      Return GetType(String)
    End Function
    Public Function Format(providerType As System.Type, ParamArray operands() As String) As String Implements DevExpress.Data.Filtering.ICustomFunctionOperatorFormattable.Format
      '' This example implements the function for MS Access databases only. 
      'If providerType Is GetType(AccessConnectionProvider) Then
      '  Return String.Format("datepart(""m"", {0})", operands(0))
      'End If
      'Throw New NotSupportedException(String.Concat( _
      '"This provider is not supported: ", providerType.Name))
      If operands.GetUpperBound(0) > 0 Then
        Return String.Format("MonthName({0},{1})", operands(0), operands(1))
      Else
        Return String.Format("MonthName({0})", operands(0))
      End If
    End Function
    Public Shared Function MonthName(ByVal month As Integer, Optional abbreviate As Boolean = False) As String
      Return Microsoft.VisualBasic.DateAndTime.MonthName(month, abbreviate)
    End Function
  End Class
End Namespace