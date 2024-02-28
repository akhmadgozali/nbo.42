Imports DevExpress.Xpo

Namespace NuSoft.NPO.SSystem
  <Persistent("keypages")> _
  Public Class Key
    Inherits XPLiteObject

    Public Sub New()

    End Sub
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("unique_form"), Key()> Property Unique As String
  End Class
End Namespace