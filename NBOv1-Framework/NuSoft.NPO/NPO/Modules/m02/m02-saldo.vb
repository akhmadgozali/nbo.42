Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo.Metadata

Namespace NuSoft.NPO.Modules.m02
  <NonPersistent()> Public MustInherit Class SaldoBase
    Inherits XPLiteObject

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Protected Overrides Sub OnSaving()
      _id = CInt(_tahun & _akun.Id)
      MyBase.OnSaving()
    End Sub

    <Persistent("p_id"), Key(), Indexed("Akun;Tahun", Unique:=True)> Private _id As Int32
    Private _akun As Coa
    Private _tahun As Integer
    Private _internalSaldoAwal As Double
    Private _internalBulan1 As Double
    Private _internalBulan2 As Double
    Private _internalBulan3 As Double
    Private _internalBulan4 As Double
    Private _internalBulan5 As Double
    Private _internalBulan6 As Double
    Private _internalBulan7 As Double
    Private _internalBulan8 As Double
    Private _internalBulan9 As Double
    Private _internalBulan10 As Double
    Private _internalBulan11 As Double
    Private _internalBulan12 As Double
    Private _eksternalSaldoAwal As Double
    Private _eksternalBulan1 As Double
    Private _eksternalBulan2 As Double
    Private _eksternalBulan3 As Double
    Private _eksternalBulan4 As Double
    Private _eksternalBulan5 As Double
    Private _eksternalBulan6 As Double
    Private _eksternalBulan7 As Double
    Private _eksternalBulan8 As Double
    Private _eksternalBulan9 As Double
    Private _eksternalBulan10 As Double
    Private _eksternalBulan11 As Double
    Private _eksternalBulan12 As Double

    ReadOnly Property Id As Int32
      Get
        Return _id
      End Get
    End Property
    <Persistent("uf_coa")> Property Akun As Coa
      Get
        Return _akun
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("Akun", _akun, value)
      End Set
    End Property
    <Persistent("u_year")> Property Tahun As Integer
      Get
        Return _tahun
      End Get
      Set(value As Integer)
        SetPropertyValue(Of Integer)("Tahun", _tahun, value)
      End Set
    End Property
    <Persistent("d_bb")> Property InternalSaldoAwal As Double
      Get
        Return _internalSaldoAwal
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("InternalSaldoAwal", _internalSaldoAwal, value)
      End Set
    End Property
    <Persistent("d_real1")> Property InternalBulan1 As Double
      Get
        Return _internalBulan1
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("InternalBulan1", _internalBulan1, value)
      End Set
    End Property
    <Persistent("d_real2")> Property InternalBulan2 As Double
      Get
        Return _internalBulan2
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("InternalBulan2", _internalBulan2, value)
      End Set
    End Property
    <Persistent("d_real3")> Property InternalBulan3 As Double
      Get
        Return _internalBulan3
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("InternalBulan3", _internalBulan3, value)
      End Set
    End Property
    <Persistent("d_real4")> Property InternalBulan4 As Double
      Get
        Return _internalBulan4
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("InternalBulan4", _internalBulan4, value)
      End Set
    End Property
    <Persistent("d_real5")> Property InternalBulan5 As Double
      Get
        Return _internalBulan5
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("InternalBulan5", _internalBulan5, value)
      End Set
    End Property
    <Persistent("d_real6")> Property InternalBulan6 As Double
      Get
        Return _internalBulan6
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("InternalBulan6", _internalBulan6, value)
      End Set
    End Property
    <Persistent("d_real7")> Property InternalBulan7 As Double
      Get
        Return _internalBulan7
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("InternalBulan7", _internalBulan7, value)
      End Set
    End Property
    <Persistent("d_real8")> Property InternalBulan8 As Double
      Get
        Return _internalBulan8
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("InternalBulan8", _internalBulan8, value)
      End Set
    End Property
    <Persistent("d_real9")> Property InternalBulan9 As Double
      Get
        Return _internalBulan9
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("InternalBulan9", _internalBulan9, value)
      End Set
    End Property
    <Persistent("d_real10")> Property InternalBulan10 As Double
      Get
        Return _internalBulan10
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("InternalBulan10", _internalBulan10, value)
      End Set
    End Property
    <Persistent("d_real11")> Property InternalBulan11 As Double
      Get
        Return _internalBulan11
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("InternalBulan11", _internalBulan11, value)
      End Set
    End Property
    <Persistent("d_real12")> Property InternalBulan12 As Double
      Get
        Return _internalBulan12
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("InternalBulan12", _internalBulan12, value)
      End Set
    End Property
    ReadOnly Property InternalAkumulasi As Double
      Get
        Return _internalSaldoAwal + _internalBulan1 + _internalBulan2 + _internalBulan3 + _internalBulan4 + _internalBulan5 + _internalBulan6 + _internalBulan7 + _internalBulan8 + _internalBulan9 + _internalBulan10 + _internalBulan11 + _internalBulan12
      End Get
    End Property
    <Persistent("d_bbx")> Property EksternalSaldoAwal As Double
      Get
        Return _eksternalSaldoAwal
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("EksternalSaldoAwal", _eksternalSaldoAwal, value)
      End Set
    End Property
    <Persistent("d_realx1")> Property EksternalBulan1 As Double
      Get
        Return _eksternalBulan1
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("EksternalBulan1", _eksternalBulan1, value)
      End Set
    End Property
    <Persistent("d_realx2")> Property EksternalBulan2 As Double
      Get
        Return _eksternalBulan2
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("EksternalBulan2", _eksternalBulan2, value)
      End Set
    End Property
    <Persistent("d_realx3")> Property EksternalBulan3 As Double
      Get
        Return _eksternalBulan3
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("EksternalBulan3", _eksternalBulan3, value)
      End Set
    End Property
    <Persistent("d_realx4")> Property EksternalBulan4 As Double
      Get
        Return _eksternalBulan4
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("EksternalBulan4", _eksternalBulan4, value)
      End Set
    End Property
    <Persistent("d_realx5")> Property EksternalBulan5 As Double
      Get
        Return _eksternalBulan5
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("EksternalBulan5", _eksternalBulan5, value)
      End Set
    End Property
    <Persistent("d_realx6")> Property EksternalBulan6 As Double
      Get
        Return _eksternalBulan6
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("EksternalBulan6", _eksternalBulan6, value)
      End Set
    End Property
    <Persistent("d_realx7")> Property EksternalBulan7 As Double
      Get
        Return _eksternalBulan7
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("EksternalBulan7", _eksternalBulan7, value)
      End Set
    End Property
    <Persistent("d_realx8")> Property EksternalBulan8 As Double
      Get
        Return _eksternalBulan8
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("EksternalBulan8", _eksternalBulan8, value)
      End Set
    End Property
    <Persistent("d_realx9")> Property EksternalBulan9 As Double
      Get
        Return _eksternalBulan9
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("EksternalBulan9", _eksternalBulan9, value)
      End Set
    End Property
    <Persistent("d_realx10")> Property EksternalBulan10 As Double
      Get
        Return _eksternalBulan10
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("EksternalBulan10", _eksternalBulan10, value)
      End Set
    End Property
    <Persistent("d_realx11")> Property EksternalBulan11 As Double
      Get
        Return _eksternalBulan11
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("EksternalBulan11", _eksternalBulan11, value)
      End Set
    End Property
    <Persistent("d_realx12")> Property EksternalBulan12 As Double
      Get
        Return _eksternalBulan12
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("EksternalBulan12", _eksternalBulan12, value)
      End Set
    End Property
    ReadOnly Property EksternalAkumulasi As Double
      Get
        Return _eksternalSaldoAwal + _eksternalBulan1 + _eksternalBulan2 + _eksternalBulan3 + _eksternalBulan4 + _eksternalBulan5 + _eksternalBulan6 + _eksternalBulan7 + _eksternalBulan8 + _eksternalBulan9 + _eksternalBulan10 + _eksternalBulan11 + _eksternalBulan12
      End Get
    End Property
  End Class

  <Persistent("m02zsaldomain")>
  Public Class SaldoMain
    Inherits SaldoBase

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
  End Class
  <Persistent("m02zsaldokurs")>
  Public Class SaldoKurs
    Inherits SaldoBase

    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
  End Class
End Namespace