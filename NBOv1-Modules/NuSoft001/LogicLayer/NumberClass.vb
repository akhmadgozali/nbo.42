Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports NuSoft.NUI.Win.Forms.Modules.NuSoftModSys
Imports NuSoft.Utils.CustomAttribute

Namespace Logic
  'Public Class NumberClass
  '  Private _sesi As DevExpress.Xpo.Session
  '  Private _mask As String
  '  Private _sumber As Persistent.SumberDataJenis
  '  Private criteriaName As String
  '  Private criteriaValue As String
  '  Private settingFormatNomor As String

  '  ReadOnly Property Mask As String
  '    Get
  '      Return _mask
  '    End Get
  '  End Property
  '  ReadOnly Property NomorBaru As String
  '    Get
  '      ChangeMask()
  '      ExtractCriteria()
  '      Dim urutanFieldName As String = GetUrutanPropertyName()

  '      Dim _count As Integer = Data.Helper.GetGapsNumber(_sesi, _Instance.ClassInfo, urutanFieldName, criteriaName, criteriaValue)
  '      Dim _many As Integer = _mask.Replace("\d", "`").Split("`"c).Length - 1
  '      Dim value As String = _mask.Replace("\d", "`")

  '      Return value.Replace(StrDup(_many, "`"), _count.ToString(StrDup(_many, "0")))
  '    End Get
  '  End Property
  '  ReadOnly Property Urutan As UShort
  '    Get
  '      Try
  '        ChangeMask()
  '        Dim _maskAlias As String = _mask.Replace("\d", "`")
  '        Dim firstIndex As Integer = _maskAlias.IndexOf("`")
  '        Dim lastIndex As Integer = _maskAlias.LastIndexOf("`")

  '        If firstIndex >= 0 Then
  '          Return CUShort(GetKodeValue.Substring(firstIndex, (lastIndex - firstIndex) + 1))
  '        Else
  '          Return 1
  '        End If
  '      Catch ex As Exception
  '        Return Nothing
  '      End Try
  '    End Get
  '  End Property
  '  ReadOnly Property FormatNomor As String
  '    Get
  '      Return settingFormatNomor
  '    End Get
  '  End Property
  '  ReadOnly Property Sumber As Persistent.SumberDataJenis
  '    Get
  '      Return _sumber
  '    End Get
  '  End Property
  '  Property Instance As Persistent.TransactionMain

  '  Sub New(session As DevExpress.Xpo.UnitOfWork, sumber As Persistent.SumberDataJenis)
  '    Dim setting As New FinaSetting(session)

  '    _sesi = session
  '    _sumber = sumber
  '    settingFormatNomor = setting.FormatNomor
  '  End Sub

  '  Private Sub ChangeMask()
  '    Dim tahun As Integer = GetTahunValue()
  '    Dim bulan As Integer = GetBulanValue()
  '    Dim akun As Persistent.Coa = GetAkunValue()
  '    Dim regional As NPO.Modules.ModSys.Regional = GetRegionalValue()
  '    Dim sumber As Persistent.SumberDataJenis = GetSumberValue()

  '    _mask = settingFormatNomor
  '    If tahun = Nothing Then
  '      _mask = _mask.Replace(My.Resources.FormatTahun4, "")
  '      _mask = _mask.Replace(My.Resources.FormatTahun2, "")
  '    Else
  '      _mask = _mask.Replace(My.Resources.FormatTahun4, tahun.ToString)
  '      _mask = _mask.Replace(My.Resources.FormatTahun2, tahun.ToString.Substring(2))
  '    End If
  '    If bulan = Nothing Then
  '      _mask = _mask.Replace(My.Resources.FormatBulan0, "")
  '      _mask = _mask.Replace(My.Resources.FormatBulanR, "")
  '    Else
  '      _mask = _mask.Replace(My.Resources.FormatBulan0, bulan.ToString("00"))
  '      _mask = _mask.Replace(My.Resources.FormatBulanR, Utils.Common.Number.ConvertNumberToRoman(bulan))
  '    End If

  '    If akun Is Nothing Then
  '      _mask = _mask.Replace(My.Resources.FormatAkun, "")
  '    Else
  '      _mask = _mask.Replace(My.Resources.FormatAkun, akun.Format)
  '    End If
  '    If regional Is Nothing Then
  '      _mask = _mask.Replace(My.Resources.FormatRegional, "")
  '    Else
  '      _mask = _mask.Replace(My.Resources.FormatRegional, regional.Kode)
  '    End If
  '    If sumber = Nothing Then
  '      _mask = _mask.Replace(My.Resources.FormatSumber, "")
  '    Else
  '      _mask = _mask.Replace(My.Resources.FormatSumber, _sesi.GetObjectByKey(Of Persistent.SumberData)(CType(sumber, Int16)).Kode)
  '    End If

  '    For i = 1 To 9
  '      If _mask.Contains("[X" & i & "]") Then
  '        _mask = _mask.Replace("[X" & i & "]", Utils.Common.Character.DuplicateString("\d", i))
  '        Exit For
  '      End If
  '    Next
  '  End Sub
  '  Private Function GetUrutanPropertyName() As String
  '    For i = 0 To _Instance.ClassInfo.Members.Count - 1
  '      If _Instance.ClassInfo.Members(i).HasAttribute(GetType(NUniqueAttribute)) Then
  '        Dim attr As NUniqueAttribute = CType(_Instance.ClassInfo.Members(i).GetAttributeInfo(GetType(NUniqueAttribute)), NUniqueAttribute)
  '        If attr.Jenis = NUniqueAttribute.JenisAttr.Sequence Then
  '          Return _Instance.ClassInfo.Members(i).Name
  '          Exit For
  '        End If
  '      End If
  '    Next

  '    Return ""
  '  End Function
  '  Private Sub ExtractCriteria()
  '    criteriaName = "" : criteriaValue = ""
  '    For i = 0 To _Instance.ClassInfo.Members.Count - 1
  '      If _Instance.ClassInfo.Members(i).HasAttribute(GetType(NCriteriaAttribute)) Then
  '        Dim attr As NCriteriaAttribute = CType(_Instance.ClassInfo.Members(i).GetAttributeInfo(GetType(NCriteriaAttribute)), NCriteriaAttribute)

  '        If settingFormatNomor.Contains(My.Resources.FormatTahun2) OrElse settingFormatNomor.Contains(My.Resources.FormatTahun4) Then
  '          If attr.Key = My.Resources.FormatTahun2 OrElse attr.Key = My.Resources.FormatTahun4 Then
  '            criteriaName &= ";" & _Instance.ClassInfo.Members(i).Name
  '            criteriaValue &= ";=" & _Instance.ClassInfo.Members(i).GetValue(_Instance).ToString
  '          End If
  '        End If
  '        If settingFormatNomor.Contains(My.Resources.FormatBulan0) OrElse settingFormatNomor.Contains(My.Resources.FormatBulanR) Then
  '          If attr.Key = My.Resources.FormatBulan0 OrElse attr.Key = My.Resources.FormatBulanR Then
  '            criteriaName &= ";" & _Instance.ClassInfo.Members(i).Name
  '            criteriaValue &= ";=" & _Instance.ClassInfo.Members(i).GetValue(_Instance).ToString
  '          End If
  '        End If
  '        If settingFormatNomor.Contains(My.Resources.FormatAkun) Then
  '          If attr.Key = My.Resources.FormatAkun Then
  '            If Not _Instance.ClassInfo.Members(i).GetValue(_Instance) Is Nothing Then
  '              criteriaName &= ";" & _Instance.ClassInfo.Members(i).Name
  '              criteriaValue &= ";=" & CType(_Instance.ClassInfo.Members(i).GetValue(_Instance), Persistent.Coa).Id
  '            End If
  '          End If
  '        End If
  '        If settingFormatNomor.Contains(My.Resources.FormatRegional) Then
  '          If attr.Key = My.Resources.FormatRegional Then
  '            criteriaName &= ";" & _Instance.ClassInfo.Members(i).Name
  '            criteriaValue &= ";=" & CType(_Instance.ClassInfo.Members(i).GetValue(_Instance), NPO.Modules.ModSys.Regional).Id
  '          End If
  '        End If
  '        If settingFormatNomor.Contains(My.Resources.FormatSumber) Then
  '          If attr.Key = My.Resources.FormatSumber Then
  '            criteriaName &= ";" & _Instance.ClassInfo.Members(i).Name
  '            criteriaValue &= ";=" & CType(_Instance.ClassInfo.Members(i).GetValue(_Instance), Persistent.SumberDataJenis)
  '          End If
  '        End If
  '      End If
  '    Next
  '    If criteriaName <> "" Then
  '      criteriaName = criteriaName.Substring(1)
  '      criteriaValue = criteriaValue.Substring(1)
  '    End If
  '  End Sub

  '  Private Function GetAkunValue() As Persistent.Coa
  '    Try
  '      For i = 0 To _Instance.ClassInfo.Members.Count - 1
  '        If _Instance.ClassInfo.Members(i).HasAttribute(GetType(NCriteriaAttribute)) Then
  '          Dim attr As NCriteriaAttribute = CType(_Instance.ClassInfo.Members(i).GetAttributeInfo(GetType(NCriteriaAttribute)), NCriteriaAttribute)

  '          If attr.Key = My.Resources.FormatAkun Then
  '            Return CType(_Instance.ClassInfo.Members(i).GetValue(_Instance), Persistent.Coa)
  '          End If
  '        End If
  '      Next

  '      Return Nothing
  '    Catch
  '      Return Nothing
  '    End Try
  '  End Function
  '  Private Function GetRegionalValue() As NPO.Modules.ModSys.Regional
  '    Try
  '      For i = 0 To _Instance.ClassInfo.Members.Count - 1
  '        If _Instance.ClassInfo.Members(i).HasAttribute(GetType(NCriteriaAttribute)) Then
  '          Dim attr As NCriteriaAttribute = CType(_Instance.ClassInfo.Members(i).GetAttributeInfo(GetType(NCriteriaAttribute)), NCriteriaAttribute)

  '          If attr.Key = My.Resources.FormatRegional Then
  '            Return CType(_Instance.ClassInfo.Members(i).GetValue(_Instance), NPO.Modules.ModSys.Regional)
  '          End If
  '        End If
  '      Next

  '      Return Nothing
  '    Catch
  '      Return Nothing
  '    End Try
  '  End Function
  '  Private Function GetSumberValue() As Persistent.SumberDataJenis
  '    Try
  '      For i = 0 To _Instance.ClassInfo.Members.Count - 1
  '        If _Instance.ClassInfo.Members(i).HasAttribute(GetType(NCriteriaAttribute)) Then
  '          Dim attr As NCriteriaAttribute = CType(_Instance.ClassInfo.Members(i).GetAttributeInfo(GetType(NCriteriaAttribute)), NCriteriaAttribute)

  '          If attr.Key = My.Resources.FormatSumber Then
  '            Return CType(_Instance.ClassInfo.Members(i).GetValue(_Instance), Persistent.SumberDataJenis)
  '          End If
  '        End If
  '      Next

  '      Return Nothing
  '    Catch
  '      Return Nothing
  '    End Try
  '  End Function
  '  Private Function GetTahunValue() As Integer
  '    Try
  '      For i = 0 To _Instance.ClassInfo.Members.Count - 1
  '        If _Instance.ClassInfo.Members(i).HasAttribute(GetType(NCriteriaAttribute)) Then
  '          Dim attr As NCriteriaAttribute = CType(_Instance.ClassInfo.Members(i).GetAttributeInfo(GetType(NCriteriaAttribute)), NCriteriaAttribute)

  '          If attr.Key = My.Resources.FormatTahun2 OrElse attr.Key = My.Resources.FormatTahun4 Then
  '            Return CInt(_Instance.ClassInfo.Members(i).GetValue(_Instance))
  '          End If
  '        End If
  '      Next

  '      Return Nothing
  '    Catch
  '      Return Nothing
  '    End Try
  '  End Function
  '  Private Function GetBulanValue() As Integer
  '    Try
  '      For i = 0 To _Instance.ClassInfo.Members.Count - 1
  '        If _Instance.ClassInfo.Members(i).HasAttribute(GetType(NCriteriaAttribute)) Then
  '          Dim attr As NCriteriaAttribute = CType(_Instance.ClassInfo.Members(i).GetAttributeInfo(GetType(NCriteriaAttribute)), NCriteriaAttribute)

  '          If attr.Key = My.Resources.FormatBulan0 OrElse attr.Key = My.Resources.FormatBulanR Then
  '            Return CInt(_Instance.ClassInfo.Members(i).GetValue(_Instance))
  '          End If
  '        End If
  '      Next

  '      Return Nothing
  '    Catch
  '      Return Nothing
  '    End Try
  '  End Function
  '  Private Function GetKodeValue() As String
  '    Try
  '      For i = 0 To _Instance.ClassInfo.Members.Count - 1
  '        If _Instance.ClassInfo.Members(i).HasAttribute(GetType(NUniqueAttribute)) Then
  '          Dim attr As NUniqueAttribute = CType(_Instance.ClassInfo.Members(i).GetAttributeInfo(GetType(NUniqueAttribute)), NUniqueAttribute)

  '          If attr.Jenis = NUniqueAttribute.JenisAttr.Primary Then
  '            Return _Instance.ClassInfo.Members(i).GetValue(_Instance).ToString
  '          End If
  '        End If
  '      Next

  '      Return Nothing
  '    Catch ex As Exception
  '      Return Nothing
  '    End Try
  '  End Function

  '  Shared Function HitungFormatSetting(format As String) As String
  '    Dim result As Integer = 0

  '    For i = 1 To 9
  '      If format.Contains(String.Format("[X{0}]", i)) Then
  '        result += i
  '        format = format.Replace(String.Format("[X{0}]", i), "")
  '        Exit For
  '      End If
  '    Next
  '    If format.Contains(My.Resources.FormatTahun2) Then
  '      result += 2
  '      format = format.Replace(My.Resources.FormatTahun2, "")
  '    End If
  '    If format.Contains(My.Resources.FormatTahun4) Then
  '      result += 4
  '      format = format.Replace(My.Resources.FormatTahun4, "")
  '    End If
  '    If format.Contains(My.Resources.FormatBulanR) Then
  '      result += 4
  '      format = format.Replace(My.Resources.FormatBulanR, "")
  '    End If
  '    If format.Contains(My.Resources.FormatBulan0) Then
  '      result += 2
  '      format = format.Replace(My.Resources.FormatBulan0, "")
  '    End If
  '    If format.Contains(My.Resources.FormatAkun) Then
  '      result += 2
  '      format = format.Replace(My.Resources.FormatAkun, "")
  '    End If
  '    If format.Contains(My.Resources.FormatSumber) Then
  '      result += 2
  '      format = format.Replace(My.Resources.FormatSumber, "")
  '    End If
  '    If format.Contains(My.Resources.FormatRegional) Then
  '      result += 3
  '      format = format.Replace(My.Resources.FormatRegional, "")
  '    End If
  '    result += format.Length

  '    Return result.ToString
  '  End Function
  'End Class
  Friend Class NumberConst
    Public Const FormatSumber As String = "[S]"
    Public Const FormatAkun As String = "[A]"
    Public Const FormatRegional As String = "[R]"
  End Class
  Friend Class NumberClass
    Inherits Core.Modules.NumberBase

    Sub New(session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Overrides Function RegisterFormat() As List(Of Core.Modules.NumberFormat)
      Dim result As New List(Of Core.Modules.NumberFormat)
      result.Add(AddRegister("[S]", 2, "Kode", "Id"))
      result.Add(AddRegister("[A]", 2, "Format", "Id"))
      result.Add(AddRegister("[R]", 3, "Kode", "Id"))
      Return result
    End Function
    Public Overrides Function SequenceFormat() As String
      Return "[X{0}]"
    End Function
  End Class
End Namespace

Namespace Persistent
  Enum SumberDataJenis
    <EnumDescription("Kas Masuk")> KM = 1
    <EnumDescription("Kas Keluar")> KK = 2
    <EnumDescription("Bank Masuk")> BM = 3
    <EnumDescription("Bank Keluar")> BK = 4
    <EnumDescription("Jurnal Umum")> JU = 5
    <EnumDescription("Jurnal Adjustment")> JA = 6
    <EnumDescription("Loan Administration")> LA = 7
    <EnumDescription("Revaluasi Valas")> RV = 8
    <EnumDescription("Saldo Awal")> SA = 9
    <EnumDescription("Pengajuan Dana")> PD = 10
  End Enum
  Friend Class SumberDataCollection
    Inherits NPO.Modules.ModSys.SumberDataCollection(Of SumberDataJenis)

    Sub New(session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Overrides Function ModuleId() As NPO.Modules.ModuleId
      Return NPO.Modules.ModuleId.Fina
    End Function
  End Class
  <NonPersistent()> Friend MustInherit Class TransactionMain
    Inherits Core.Modules.TransactionBase

    Public Sub New(ByVal session As DevExpress.Xpo.UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As DevExpress.Xpo.UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Public Sub New(ByVal session As DevExpress.Xpo.UnitOfWork, Nomor As Core.Modules.NumberBase)
      MyBase.New(session, Nomor)
    End Sub

    Private _ucoa As Coa
    Private _usrc As NPO.Modules.ModSys.SumberData
    Private _ureg As NPO.Modules.ModSys.Regional

    <Persistent("u_coa"), NCriteria(Logic.NumberConst.FormatAkun)>
    Property Akun As Coa
      Get
        Return _ucoa
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("Akun", _ucoa, value)
      End Set
    End Property
    <Persistent("u_source"), NCriteria(Logic.NumberConst.FormatSumber)>
    Property Sumber As NPO.Modules.ModSys.SumberData
      Get
        Return _usrc
      End Get
      Set(value As NPO.Modules.ModSys.SumberData)
        SetPropertyValue(Of NPO.Modules.ModSys.SumberData)("Sumber", _usrc, value)
      End Set
    End Property
    <Persistent("u_regional"), NCriteria(Logic.NumberConst.FormatRegional)>
    Property Regional As NPO.Modules.ModSys.Regional
      Get
        Return _ureg
      End Get
      Set(value As NPO.Modules.ModSys.Regional)
        SetPropertyValue(Of NPO.Modules.ModSys.Regional)("Regional", _ureg, value)
      End Set
    End Property

    Protected Overrides Sub OnSaving()
      If Not Number.FormatNomor.Contains(Logic.NumberConst.FormatAkun) Then
        _ucoa = Nothing
      End If
      If Not Number.FormatNomor.Contains(Logic.NumberConst.FormatSumber) Then
        _usrc = Nothing
      End If
      If Not Number.FormatNomor.Contains(Logic.NumberConst.FormatRegional) Then
        _ureg = Nothing
      End If

      MyBase.OnSaving()
    End Sub
  End Class

  '<NonPersistent()> Public MustInherit Class TransactionMain
  '  Inherits NPOBase

  '  Public Sub New(ByVal session As DevExpress.Xpo.UnitOfWork)
  '    MyBase.New(session)
  '  End Sub
  '  Public Sub New(ByVal session As DevExpress.Xpo.UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
  '    MyBase.New(session, classInfo)
  '  End Sub
  '  Public Sub New(ByVal session As DevExpress.Xpo.UnitOfWork, Nomor As Logic.NumberClass)
  '    MyBase.New(session)
  '    Nomor = Nomor
  '  End Sub

  '  <Persistent("p_id"), Key(True)> Private _id As Int64
  '  <Persistent("u_year"), NCriteria("[Y2]"), NCriteria("[Y4]")> Private _tahun As Integer
  '  <Persistent("u_month"), NCriteria("[M0]"), NCriteria("[Mr]")> Private _bulan As Integer
  '  <Persistent("u_sequence"), NUnique(NUniqueAttribute.JenisAttr.Sequence)> Private _urutan As Integer
  '  Private _ucoa As Coa
  '  Private _usrc As SumberDataJenis
  '  Private _ureg As NPO.Modules.ModSys.Regional
  '  Private _kode As String
  '  Private _tanggal As Date

  '  <NonPersistent> Private _nomor As Logic.NumberClass
  '  <NonPersistent()> Property Nomor As Logic.NumberClass
  '    Get
  '      Return _nomor
  '    End Get
  '    Set(value As Logic.NumberClass)
  '      _nomor = value
  '      _nomor.Instance = Me
  '      Sumber = Nomor.Sumber
  '    End Set
  '  End Property

  '  <PersistentAlias("_id")> ReadOnly Property Id As Int64
  '    Get
  '      Return Convert.ToInt64(EvaluateAlias("Id"))
  '    End Get
  '  End Property
  '  <PersistentAlias("_tahun")> ReadOnly Property Tahun As Integer
  '    Get
  '      Return Convert.ToInt32(EvaluateAlias("Tahun"))
  '    End Get
  '  End Property
  '  <PersistentAlias("concat(GetYear(Tanggal),'-',GetMonth(Tanggal),'-01')")> ReadOnly Property Bulan As Date
  '    Get
  '      Return Convert.ToDateTime(EvaluateAlias("Bulan"))
  '    End Get
  '  End Property
  '  <PersistentAlias("_urutan")> ReadOnly Property Urutan As Integer
  '    Get
  '      Return Convert.ToInt32(EvaluateAlias("Urutan"))
  '    End Get
  '  End Property

  '  <Persistent("u_coa"), NCriteria("[A]")>
  '  Property Akun As Coa
  '    Get
  '      Return _ucoa
  '    End Get
  '    Set(value As Coa)
  '      SetPropertyValue(Of Coa)("Akun", _ucoa, value)
  '    End Set
  '  End Property
  '  <Persistent("u_source"), NCriteria("[S]")>
  '  Property Sumber As SumberDataJenis
  '    Get
  '      Return _usrc
  '    End Get
  '    Set(value As SumberDataJenis)
  '      SetPropertyValue(Of SumberDataJenis)("Sumber", _usrc, value)
  '    End Set
  '  End Property
  '  <Persistent("u_regional"), NCriteria("[R]")>
  '  Property Regional As NPO.Modules.ModSys.Regional
  '    Get
  '      Return _ureg
  '    End Get
  '    Set(value As NPO.Modules.ModSys.Regional)
  '      SetPropertyValue(Of NPO.Modules.ModSys.Regional)("Regional", _ureg, value)
  '    End Set
  '  End Property
  '  <Persistent("u_code"), Size(30), NUnique(NUniqueAttribute.JenisAttr.Primary)>
  '  Property Kode As String
  '    Get
  '      Return _kode
  '    End Get
  '    Set(value As String)
  '      SetPropertyValue(Of String)("Kode", _kode, value)
  '    End Set
  '  End Property
  '  <Persistent("d_date")>
  '  Property Tanggal As Date
  '    Get
  '      Return _tanggal
  '    End Get
  '    Set(value As Date)
  '      _tahun = value.Year
  '      _bulan = value.Month
  '      SetPropertyValue(Of Date)("Tanggal", _tanggal, value)
  '    End Set
  '  End Property

  '  Protected Overrides Sub OnSaving()
  '    If Nomor.FormatNomor.Contains(My.Resources.FormatTahun2) OrElse Nomor.FormatNomor.Contains(My.Resources.FormatTahun4) Then
  '      _tahun = _tanggal.Year
  '    Else
  '      _tahun = Nothing
  '    End If
  '    If Nomor.FormatNomor.Contains(My.Resources.FormatBulan0) OrElse Nomor.FormatNomor.Contains(My.Resources.FormatBulanR) Then
  '      _bulan = _tanggal.Month
  '    Else
  '      _bulan = Nothing
  '    End If
  '    If Not Nomor.FormatNomor.Contains(My.Resources.FormatAkun) Then
  '      _ucoa = Nothing
  '    End If
  '    If Not Nomor.FormatNomor.Contains(My.Resources.FormatSumber) Then
  '      _usrc = Nothing
  '    End If
  '    If Not Nomor.FormatNomor.Contains(My.Resources.FormatRegional) Then
  '      _ureg = Nothing
  '    End If
  '    _urutan = Nomor.Urutan

  '    MyBase.OnSaving()
  '  End Sub
  'End Class
  'Public Class EnumCollection(Of T)
  '  Property Id As T
  '  Property Nama As String
  'End Class
End Namespace