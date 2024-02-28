Imports DevExpress.Xpo
Public Class viewfixxeddata

End Class
Namespace SyBiru.SPO.Modules.viewfixeddata
    <Persistent("dtaprovince")> Public Class Propinsi
        Inherits SPOBase

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
            MyBase.New(session, classInfo)
        End Sub

        <Persistent("p_id"), Key()> Property Id As UInt16
        <Persistent("u_code")> Property Kode As String
        <Persistent("d_note")> Property Keterangan As String
    End Class

    <Persistent("dtbdistrict")> Public Class Kota
        Inherits SPOBase

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

    <Persistent("dtcsubdistrict")> Public Class Kecamatan
        Inherits SPOBase

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
            MyBase.New(session, classInfo)
        End Sub

        <Persistent("p_id"), Key()> Property Id As UInt32
        <Persistent("f_district")> Property Kota As Kota
        <Persistent("u_code")> Property Kode As String
        <Persistent("d_note")> Property Keterangan As String
    End Class

    <Persistent("dtdvillage")> Public Class Kelurahan
        Inherits SPOBase

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
            MyBase.New(session, classInfo)
        End Sub

        <Persistent("p_id"), Key()> Property Id As UInt32
        <Persistent("f_subdistrict")> Property Kecamatan As Kecamatan
        <Persistent("u_code")> Property Kode As String
        <Persistent("d_note")> Property Keterangan As String
    End Class
End Namespace