Imports DevExpress.Xpo

Namespace NuSoft.NPO.SSystem
  <Persistent("xyzlog")> _
  Public Class SystemLog
    Inherits XPLiteObject

    Public Sub New()

    End Sub
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Enum Action
      Warning
      [Error]
      Info
    End Enum

    <Persistent("p_id"), Key(True)> Property Id As Int64
    <Persistent("d_date")> Property Tanggal As DateTime
    <Persistent("d_user")> Property User As String
    <Persistent("d_kind")> Property Jenis As Action
    <Persistent("d_activity")> Property Aktivitas As String
    <Persistent("d_useragent")> Property UserAgent As String
    <Persistent("d_userhostaddress")> Property UserHostAddress As String
    <Persistent("d_userhostname")> Property UserHostName As String

    <PersistentAlias("Concat(Year(Tanggal),'-',Month(Tanggal),'-01')")> ReadOnly Property Bulan As Date
      Get
        Return Convert.ToDateTime(EvaluateAlias("Bulan"))
      End Get
    End Property
  End Class
End Namespace