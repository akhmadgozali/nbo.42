Imports DevExpress.Xpo

Namespace NuSoft.NPO.Modules.m02
  Public Enum SumberDataJenis
    BK = 0
    BM = 1
    KK = 2
    KM = 3
    JM = 4
    SA = 5
    SK = 6
    SX = 7
    'SL = 8
  End Enum
  <MapInheritance(MapInheritanceType.ParentTable)> Public Class SumberData
    Inherits aba.SumberData(Of SumberDataJenis)

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Public Sub New(ByVal session As Session, jenis As SumberDataJenis)
      MyBase.New(session, jenis)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo, jenis As SumberDataJenis)
      MyBase.New(session, classInfo, jenis)
    End Sub

    Private Shared Function GetName(jenis As SumberDataJenis) As String
      Select Case Jenis
        Case SumberDataJenis.BK : Return "Bank Keluar"
        Case SumberDataJenis.BM : Return "Bank Masuk"
        Case SumberDataJenis.KK : Return "Kas Keluar"
        Case SumberDataJenis.KM : Return "Kas Masuk"
        Case SumberDataJenis.JM : Return "Jurnal Memorial"
        Case SumberDataJenis.SA : Return "Saldo Awal"
        Case SumberDataJenis.SK : Return "Selisih Kurs"
        Case SumberDataJenis.SX : Return "Saldo Awal"
          'Case SumberDataJenis.SL : Return "Saldo Laba"
        Case Else : Return ""
      End Select
    End Function
    Shared Function GetSumberData(session As Session, jenis As SumberDataJenis) As SumberData
      Const moduleId As ModuleId = moduleId.GLKeuangan

      Dim id As Int16 = CShort(ModuleId & Convert.ToInt32(jenis).ToString("00"))
      Dim result As SumberData = session.GetObjectByKey(Of SumberData)(id)

      If result Is Nothing Then
        result = New SumberData(session, jenis)
        result.Id = id
        result.Modul = moduleId
        result.Kode = jenis.ToString
        result.Keterangan = GetName(jenis)
        result.Save()
      Else
        SumberDataJenis.TryParse(result.Kode, True, result.Jenis)
      End If

      Return result
    End Function
  End Class

  Public Enum TipeKontakJenis
    Kontak = 0
  End Enum
  <MapInheritance(MapInheritanceType.ParentTable)> Public Class TipeKontak
    Inherits NPO.Modules.aba.TipeKontak(Of TipeKontakJenis)

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Sub New(ByVal session As DevExpress.Xpo.Session, value As TipeKontakJenis)
      MyBase.New(session, value)
    End Sub
    Sub New(ByVal session As DevExpress.Xpo.Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo, value As TipeKontakJenis)
      MyBase.New(session, classInfo, value)
    End Sub

    Overloads Shared Function GetTipeNama(jenis As TipeKontakJenis) As String
      Select Case jenis
        Case TipeKontakJenis.Kontak : Return "Kontak GL"
        Case Else : Return ""
      End Select
    End Function
    Overloads Shared Function ModuleId() As NPO.Modules.ModuleId
      Return NPO.Modules.ModuleId.GLKeuangan
    End Function
    Shared Function GetTipeKontak(session As Session, jenis As TipeKontakJenis) As TipeKontak
      Dim id As Int16 = CShort(ModuleId() & Convert.ToInt32(jenis).ToString("00"))
      Dim result As TipeKontak = session.GetObjectByKey(Of TipeKontak)(id)

      If result Is Nothing Then
        result = New TipeKontak(session, jenis)
        result.Id = id
        result.Modul = ModuleId()
        result.Kode = CUShort(jenis)
        result.Keterangan = GetTipeNama(jenis)
      Else
        'TipeKontakJenis.TryParse(result.Kod, True, result.Jenis)
      End If

      Return result
    End Function
  End Class
End Namespace