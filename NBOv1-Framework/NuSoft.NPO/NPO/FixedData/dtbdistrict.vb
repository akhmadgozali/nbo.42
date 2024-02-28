Imports DevExpress.Xpo

Namespace NuSoft.NPO.FixedData
  <Persistent("fixed_data.dtbdistrict")> _
  Public Class Kota
    Inherits XPLiteObject

    Public Sub New()

    End Sub
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("p_id"), Key()> Property Id As UInt16
    <Persistent("f_province")> Property Propinsi As Propinsi
    <Persistent("u_code")> Property Kode As String
    <Persistent("d_note")> Property Keterangan As String
  End Class
End Namespace