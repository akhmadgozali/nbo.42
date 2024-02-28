Imports DevExpress.Xpo

Namespace NuSoft.NPO
  <Persistent("datalog_amain")> _
  Public Class DatabaseLog
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
      Tambah
      Edit
      Hapus
      Ekspor
      Cetak
    End Enum

    <Persistent("p_id"), Key(True)> Property Id As Int64
    <Persistent("d_date")> Property Tanggal As DateTime
    <Persistent("d_user")> Property User As String
    <Persistent("d_kind")> Property Jenis As Action
    <Persistent("d_activity")> Property Aktivitas As String
    <Persistent("d_useragent")> Property UserAgent As String
    <Persistent("d_userhostaddress")> Property UserHostAddress As String
    <Persistent("d_userhostname")> Property UserHostName As String
    <Persistent("d_tablename")> Property TableName As String
    <Persistent("d_rowid")> Property RowId As String
    <Persistent("d_uniquedata")> Property UniqueData As String
    Property UniqueId As String

    <PersistentAlias("Concat(Year(Tanggal),'-',Month(Tanggal),'-01')")> ReadOnly Property Bulan As Date
      Get
        Return Convert.ToDateTime(EvaluateAlias("Bulan"))
      End Get
    End Property
    <PersistentAlias("Year(Tanggal)")> ReadOnly Property Tahun As Integer
      Get
        Return Convert.ToInt32(EvaluateAlias("Tahun"))
      End Get
    End Property

    <Association("database_log")> _
    Public ReadOnly Property Detail() As XPCollection(Of DatabaseLogDetail)
      Get
        Return GetCollection(Of DatabaseLogDetail)("Detail")
      End Get
    End Property
  End Class
  <Persistent("datalog_bdetail")> _
  Public Class DatabaseLogDetail
    Inherits XPLiteObject

    Public Sub New()

    End Sub
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("p_id"), Key(True)> Property Id As Int64
    <Persistent("f_main"), Association("database_log")> Property Main As DatabaseLog
    <Persistent("property_name")> Property NamaProperty As String
    <Persistent("value_old")> Property ValueLama As String
    <Persistent("value_new")> Property ValueBaru As String
  End Class

  Public Structure DatabaseLogDetailChange
    Public PropertyName As String
    Public PrevValue As String
    Public Value As String
  End Structure

  Public Class SimpleLog
    Inherits XPLiteObject

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Key(True)> Property Id As Long
    Property Tanggal As DateTime
    Property User As String
    Property Jenis As DatabaseLog.Action
    Property Aktivitas As String
    Property UserAgent As String
    Property UserHostAddress As String
    Property UserHostName As String

    <PersistentAlias("Concat(Year(Tanggal),'-',Month(Tanggal),'-01')")> ReadOnly Property Bulan As Date
      Get
        Return Convert.ToDateTime(EvaluateAlias("Bulan"))
      End Get
    End Property
  End Class
End Namespace