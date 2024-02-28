Imports DevExpress.Data.Filtering

Namespace NuSoft.NPO.CustomFunction
  Public Class TerbilangFunction
    Implements ICustomFunctionOperatorFormattable

    Public Function Evaluate(ParamArray operands() As Object) As Object Implements DevExpress.Data.Filtering.ICustomFunctionOperator.Evaluate
      If operands.GetUpperBound(0) > 0 Then
        Return Terbilang(CDbl(operands(0)), operands(1).ToString)
      Else
        Return Terbilang(CDbl(operands(0)))
      End If
    End Function
    Public ReadOnly Property Name As String Implements DevExpress.Data.Filtering.ICustomFunctionOperator.Name
      Get
        Return "Terbilang"
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
        Return String.Format("Terbilang({0},{1})", operands(0), operands(1))
      Else
        Return String.Format("Terbilang({0})", operands(0))
      End If
    End Function
    Public Shared Function Terbilang(Saldo As Double, Optional NamaMataUang As String = "") As String
      Return Utils.Common.Character.Terbilang(Saldo, NamaMataUang)
    End Function
  End Class
  Public Class TerbilangEnglishFunction
    Implements ICustomFunctionOperatorFormattable

    Public Function Evaluate(ParamArray operands() As Object) As Object Implements DevExpress.Data.Filtering.ICustomFunctionOperator.Evaluate
      Return TerbilangEnglish(CInt(operands(0)))
    End Function
    Public ReadOnly Property Name As String Implements DevExpress.Data.Filtering.ICustomFunctionOperator.Name
      Get
        Return "TerbilangEnglish"
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
      Return String.Format("TerbilangEnglish({0})", operands(0))
    End Function
    Public Shared Function TerbilangEnglish(Saldo As Double, Optional NamaMataUang As String = "") As String
      Return Utils.Common.Character.TerbilangEnglish(Saldo)
    End Function
  End Class
End Namespace

