Imports System.Reflection

Namespace NuSoft.Utils.CustomAttribute
  <AttributeUsage(AttributeTargets.Enum Or AttributeTargets.Field, AllowMultiple:=False)> _
  Public NotInheritable Class EnumDescription
    Inherits Attribute

    Private _description As String
    ReadOnly Property Description As String
      Get
        Return _description
      End Get
    End Property

    Public Sub New(description As String)
      MyBase.New()
      _description = description
    End Sub
  End Class
End Namespace
Namespace NuSoft.Utils.Helper
  Public NotInheritable Class EnumDescription
    Private Sub New()
    End Sub

    Public Shared Function GetDescription(value As Object) As String
      Return GetDescription(DirectCast(value, [Enum]))
    End Function
    Public Shared Function GetDescription(value As [Enum]) As String
      If value Is Nothing Then
        Throw New ArgumentNullException("value")
      End If

      Dim description As String = value.ToString()
      Dim fieldInfo As FieldInfo = value.[GetType]().GetField(description)
      Dim attributes As CustomAttribute.EnumDescription() = DirectCast(fieldInfo.GetCustomAttributes(GetType(CustomAttribute.EnumDescription), False), CustomAttribute.EnumDescription())

      If attributes IsNot Nothing AndAlso attributes.Length > 0 Then
        description = attributes(0).Description
      End If
      Return description
    End Function
    Public Shared Function ToList(type As Type) As IList
      If type Is Nothing Then
        Throw New ArgumentNullException("type")
      End If

      Dim list As New ArrayList()
      Dim enumValues As Array = [Enum].GetValues(type)

      For Each value As [Enum] In enumValues
        list.Add(New KeyValuePair(Of [Enum], String)(value, GetDescription(value)))
      Next

      Return list
    End Function
  End Class
End Namespace