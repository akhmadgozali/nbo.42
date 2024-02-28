Imports System.ComponentModel
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports NuSoft.NPO.Modules.ModSys

Namespace NuSoft.Core.Modules
  Public Class NumberConst
    Public Const FormatYearLong As String = "[Y4]"
    Public Const FormatYearShort As String = "[Y2]"
    Public Const FormatMonthNumber As String = "[M0]"
    Public Const FormatMonthRomawi As String = "[Mr]"
  End Class
  Public Class NumberResult
    Property Mask As String
    Property Kode As String
  End Class
  Public Class NumberFormat
    Property Format As String
    Property Length As Byte
    Property FieldName As String
    Property FieldId As String
  End Class

  Public MustInherit Class SettingBase
    MustOverride Function ModuleId() As NPO.Modules.ModuleId
    Private _sesi As DevExpress.Xpo.UnitOfWork

    Sub New(ByVal session As DevExpress.Xpo.UnitOfWork)
      _sesi = session
      Load()
    End Sub

    Sub Load()
      Dim data As New DevExpress.Xpo.XPCollection(Of NPO.Modules.ModSys.Setting)(_sesi, DevExpress.Data.Filtering.CriteriaOperator.Parse("Modul=" & NPO.Modules.Helper.GetModuleId(ModuleId())))

      If data.Count > 0 Then
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(Me)
        Dim propName As String

        For Each prop As PropertyDescriptor In properties
          propName = prop.Name
          If Not data.ToList.Find(Function(m) m.Kode = propName) Is Nothing Then
            prop.SetValue(Me, Convert.ChangeType(data.ToList.Find(Function(m) m.Kode = propName).Isi, prop.PropertyType))
          End If
        Next
      End If
    End Sub
    Function Save() As Boolean
      Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(Me)
      Dim obj As NPO.Modules.ModSys.Setting

      Try
        Dim id As Integer = NPO.Modules.Helper.GetModuleId(ModuleId())
        '_sesi.BeginTransaction()
        For Each prop As PropertyDescriptor In properties
          obj = _sesi.FindObject(Of NPO.Modules.ModSys.Setting)(DevExpress.Data.Filtering.CriteriaOperator.Parse(String.Format("Kode='{0}' and Modul={1}", prop.Name, id)))
          If obj Is Nothing Then
            obj = New NPO.Modules.ModSys.Setting(_sesi)
            obj.Modul = id
            obj.Kode = prop.Name
          End If

          If prop.GetValue(Me) Is Nothing Then
            obj.Isi = ""
          Else
            obj.Isi = prop.GetValue(Me).ToString
          End If
          obj.Keterangan = ""
          obj.Save()
        Next
        _sesi.CommitChanges()
        '_sesi.CommitTransaction()
        Return True
      Catch ex As Exception
        '_sesi.RollbackTransaction()
        Throw New Exception(ex.Message, ex.InnerException)
        Return False
      End Try
    End Function
  End Class
  Public MustInherit Class NumberBase
    Private _session As DevExpress.Xpo.UnitOfWork
    Private _result As NumberResult
    Private _mask As String
    Private criteriaName As String
    Private criteriaValue As String

    MustOverride Function RegisterFormat() As List(Of NumberFormat)
    MustOverride Function SequenceFormat() As String

    Sub New(session As DevExpress.Xpo.UnitOfWork)
      _session = session
    End Sub

    Property FormatNomor As String
    Property Instance As TransactionBase
    Property UseGaps As Boolean

    Function FormatCount(format As String) As Integer
      Dim result As Integer = 0

      For i = 1 To 9
        If format.Contains(String.Format(SequenceFormat, i)) Then
          result += i
          format = format.Replace(String.Format(SequenceFormat, i), "")
          Exit For
        End If
      Next
      If format.Contains(NumberConst.FormatYearLong) Then
        result += 4
        format = format.Replace(NumberConst.FormatYearLong, "")
      End If
      If format.Contains(NumberConst.FormatYearShort) Then
        result += 2
        format = format.Replace(NumberConst.FormatYearShort, "")
      End If
      If format.Contains(NumberConst.FormatMonthRomawi) Then
        result += 4
        format = format.Replace(NumberConst.FormatMonthRomawi, "")
      End If
      If format.Contains(NumberConst.FormatMonthNumber) Then
        result += 2
        format = format.Replace(NumberConst.FormatMonthNumber, "")
      End If

      For Each a As NumberFormat In RegisterFormat()
        If format.Contains(a.Format) Then
          result += a.Length
          format = format.Replace(a.Format, "")
        End If
      Next
      result += format.Length

      Return result
    End Function
    Function GetNewNumber() As NumberResult
      If FormatNomor = Nothing Then
        Throw New Exception("Masukkan format nomor terlebih dahulu.")
      End If
      If Instance Is Nothing Then
        Throw New Exception("Set instance terlebih dahulu.")
      End If

      _result = New NumberResult
      ChangeMask(True)
      Dim urutanFieldName As String = GetUrutanPropertyName()

      Dim _count As Integer
      If UseGaps Then
        _count = Data.Helper.GetGapsNumber(_session, _Instance.ClassInfo, urutanFieldName, criteriaName, criteriaValue)
      Else
        _count = Data.Helper.GetNextNumber(_session, _Instance.ClassInfo, urutanFieldName, criteriaName, criteriaValue)
      End If
      Dim _many As Integer = _mask.Replace("\d", "`").Split("`"c).Length - 1
      Dim value As String = _mask.Replace("\d", "`")

      _result.Mask = _mask
      _result.Kode = value.Replace(StrDup(_many, "`"), _count.ToString(StrDup(_many, "0")))

      Return _result
    End Function

    Private Function GetYearMember() As Metadata.XPMemberInfo
      Try
        For i = 0 To _Instance.ClassInfo.Members.Count - 1
          If _Instance.ClassInfo.Members(i).HasAttribute(GetType(NCriteriaAttribute)) Then
            Dim attr As NCriteriaAttribute = CType(_Instance.ClassInfo.Members(i).GetAttributeInfo(GetType(NCriteriaAttribute)), NCriteriaAttribute)

            If attr.Key = NumberConst.FormatYearLong OrElse attr.Key = NumberConst.FormatYearShort Then
              Return _Instance.ClassInfo.Members(i)
            End If
          End If
        Next

        Return Nothing
      Catch ex As Exception
        Return Nothing
      End Try
    End Function
    Private Function GetMonthMember() As Metadata.XPMemberInfo
      Try
        For i = 0 To _Instance.ClassInfo.Members.Count - 1
          If _Instance.ClassInfo.Members(i).HasAttribute(GetType(NCriteriaAttribute)) Then
            Dim attr As NCriteriaAttribute = CType(_Instance.ClassInfo.Members(i).GetAttributeInfo(GetType(NCriteriaAttribute)), NCriteriaAttribute)

            If attr.Key = NumberConst.FormatMonthNumber OrElse attr.Key = NumberConst.FormatMonthRomawi Then
              Return _Instance.ClassInfo.Members(i)
            End If
          End If
        Next

        Return Nothing
      Catch ex As Exception
        Return Nothing
      End Try
    End Function
    Private Function GetOthersMember(key As String) As Metadata.XPMemberInfo
      Try
        For i = 0 To _Instance.ClassInfo.Members.Count - 1
          If _Instance.ClassInfo.Members(i).HasAttribute(GetType(NCriteriaAttribute)) Then
            Dim attr As NCriteriaAttribute = CType(_Instance.ClassInfo.Members(i).GetAttributeInfo(GetType(NCriteriaAttribute)), NCriteriaAttribute)

            If attr.Key = key Then
              Return _Instance.ClassInfo.Members(i)
            End If
          End If
        Next

        Return Nothing
      Catch
        Return Nothing
      End Try
    End Function
    Private Function GetKodeValue() As String
      Try
        For i = 0 To _Instance.ClassInfo.Members.Count - 1
          If _Instance.ClassInfo.Members(i).HasAttribute(GetType(NUniqueAttribute)) Then
            Dim attr As NUniqueAttribute = CType(_Instance.ClassInfo.Members(i).GetAttributeInfo(GetType(NUniqueAttribute)), NUniqueAttribute)

            If attr.Jenis = NUniqueAttribute.JenisAttr.Primary Then
              Return _Instance.ClassInfo.Members(i).GetValue(_Instance).ToString
            End If
          End If
        Next

        Return Nothing
      Catch ex As Exception
        Return Nothing
      End Try
    End Function
    Private Sub ChangeMask(buildCriteria As Boolean)
      Dim member As Metadata.XPMemberInfo
      If buildCriteria Then
        criteriaName = "" : criteriaValue = ""
      End If

      _mask = _FormatNomor
      If _FormatNomor.Contains(NumberConst.FormatYearLong) OrElse _FormatNomor.Contains(NumberConst.FormatYearShort) Then
        member = GetYearMember()
        Dim tahun As Integer = CInt(member.GetValue(Instance))
        If tahun = Nothing Then
          _mask = _mask.Replace(NumberConst.FormatYearLong, "")
          _mask = _mask.Replace(NumberConst.FormatYearShort, "")
        Else
          _mask = _mask.Replace(NumberConst.FormatYearLong, tahun.ToString)
          _mask = _mask.Replace(NumberConst.FormatYearShort, tahun.ToString.Substring(2))

          If buildCriteria Then
            criteriaName &= ";" & member.Name
            criteriaValue &= ";=" & tahun
          End If
        End If
      End If

      If _FormatNomor.Contains(NumberConst.FormatMonthNumber) OrElse _FormatNomor.Contains(NumberConst.FormatMonthRomawi) Then
        member = GetMonthMember()
        Dim bulan As Integer = CInt(member.GetValue(Instance))
        If bulan = Nothing Then
          _mask = _mask.Replace(NumberConst.FormatMonthNumber, "")
          _mask = _mask.Replace(NumberConst.FormatMonthRomawi, "")
        Else
          _mask = _mask.Replace(NumberConst.FormatMonthNumber, bulan.ToString("00"))
          _mask = _mask.Replace(NumberConst.FormatMonthRomawi, Utils.Common.Number.ConvertNumberToRoman(bulan))

          If buildCriteria Then
            criteriaName &= ";" & member.Name
            criteriaValue &= ";=" & bulan
          End If
        End If
      End If

      For Each a As NumberFormat In RegisterFormat()
        If _FormatNomor.Contains(a.Format) Then
          member = GetOthersMember(a.Format)
          Dim value As Object = member.GetValue(Instance)
          If value Is Nothing Then
            _mask = _mask.Replace(a.Format, "")
          Else
            Dim clas As Metadata.XPClassInfo = _session.GetClassInfo(value)
            Dim subMember = clas.FindMember(a.FieldName)
            If subMember Is Nothing Then
              Throw New Exception(String.Format("Tidak ditemukan field {0} pada class {1}", a.FieldName, clas.FullName))
            End If
            _mask = _mask.Replace(a.Format, subMember.GetValue(value).ToString)

            If buildCriteria Then
              Dim subMember1 = clas.FindMember(a.FieldId)
              If subMember1 Is Nothing Then
                Throw New Exception(String.Format("Tidak ditemukan field {0} pada class {1}", a.FieldId, clas.FullName))
              End If

              criteriaName &= ";" & member.Name
              criteriaValue &= ";=" & subMember1.GetValue(value).ToString
            End If
          End If
        End If
      Next

      For i = 1 To 9
        If _mask.Contains(String.Format(SequenceFormat, i)) Then
          _mask = _mask.Replace(String.Format(SequenceFormat, i), Utils.Common.Character.DuplicateString("\d", i))
          Exit For
        End If
      Next

      If buildCriteria AndAlso criteriaName <> "" Then
        criteriaName = criteriaName.Substring(1)
        criteriaValue = criteriaValue.Substring(1)
      End If
    End Sub
    Protected Friend Function AddRegister(Format As String, Length As Byte, FieldName As String, FieldId As String) As NumberFormat
      Dim result As New NumberFormat
      result.Format = Format
      result.Length = Length
      result.FieldName = FieldName
      result.FieldId = FieldId
      Return result
    End Function

    ReadOnly Property Urutan As UShort
      Get
        Try
          ChangeMask(False)
          Dim _maskAlias As String = _mask.Replace("\d", "`")
          Dim firstIndex As Integer = _maskAlias.IndexOf("`")
          Dim lastIndex As Integer = _maskAlias.LastIndexOf("`")

          If firstIndex >= 0 Then
            Return CUShort(GetKodeValue.Substring(firstIndex, (lastIndex - firstIndex) + 1))
          Else
            Return 1
          End If
        Catch ex As Exception
          Return Nothing
        End Try
      End Get
    End Property
    Private Function GetUrutanPropertyName() As String
      For i = 0 To _Instance.ClassInfo.Members.Count - 1
        If _Instance.ClassInfo.Members(i).HasAttribute(GetType(NUniqueAttribute)) Then
          Dim attr As NUniqueAttribute = CType(_Instance.ClassInfo.Members(i).GetAttributeInfo(GetType(NUniqueAttribute)), NUniqueAttribute)
          If attr.Jenis = NUniqueAttribute.JenisAttr.Sequence Then
            Return _Instance.ClassInfo.Members(i).Name
            Exit For
          End If
        End If
      Next

      Return ""
    End Function
  End Class
  <NonPersistent()> Public MustInherit Class TransactionBase
    Inherits NPOBase

    Public Sub New(ByVal session As DevExpress.Xpo.UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As DevExpress.Xpo.UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Public Sub New(ByVal session As DevExpress.Xpo.UnitOfWork, Nomor As NumberBase)
      MyBase.New(session)
      Nomor = Nomor
    End Sub

    <Persistent("p_id"), Key(True)> Private _id As Int64
    <Persistent("u_year"), NCriteria(NumberConst.FormatYearLong), NCriteria(NumberConst.FormatYearShort)> Private _tahun As Integer
    <Persistent("u_month"), NCriteria(NumberConst.FormatMonthNumber), NCriteria(NumberConst.FormatMonthRomawi)> Private _bulan As Integer
    <Persistent("u_sequence"), NUnique(NUniqueAttribute.JenisAttr.Sequence)> Private _urutan As Integer
    Private _kode As String
    Private _tanggal As Date

    <NonPersistent> Private _Number As NumberBase
    <NonPersistent()> Property Number As NumberBase
      Get
        Return _Number
      End Get
      Set(value As NumberBase)
        _Number = value
        _Number.Instance = Me
      End Set
    End Property

    <PersistentAlias("_id")> ReadOnly Property Id As Int64
      Get
        Return Convert.ToInt64(EvaluateAlias("Id"))
      End Get
    End Property
    <PersistentAlias("_tahun")> ReadOnly Property Tahun As Integer
      Get
        Return Convert.ToInt32(EvaluateAlias("Tahun"))
      End Get
    End Property
    <PersistentAlias("concat(GetYear(Tanggal),'-',GetMonth(Tanggal),'-01')")> ReadOnly Property Bulan As Date
      Get
        Return Convert.ToDateTime(EvaluateAlias("Bulan"))
      End Get
    End Property
    <PersistentAlias("_urutan")> ReadOnly Property Urutan As Integer
      Get
        Return Convert.ToInt32(EvaluateAlias("Urutan"))
      End Get
    End Property

    <Persistent("u_code"), Size(30), NUnique(NUniqueAttribute.JenisAttr.Primary)>
    Property Kode As String
      Get
        Return _kode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kode", _kode, value)
      End Set
    End Property
    <Persistent("d_date")>
    Property Tanggal As Date
      Get
        Return _tanggal
      End Get
      Set(value As Date)
        _tahun = value.Year
        _bulan = value.Month
        SetPropertyValue(Of Date)("Tanggal", _tanggal, value)
      End Set
    End Property

    Protected Overrides Sub OnSaving()
      'Try
      If Not Number Is Nothing Then
        If Number.FormatNomor.Contains(NumberConst.FormatYearLong) OrElse Number.FormatNomor.Contains(NumberConst.FormatYearShort) Then
          _tahun = _tanggal.Year
        Else
          _tahun = Nothing
        End If

        If Number.FormatNomor.Contains(NumberConst.FormatMonthNumber) OrElse Number.FormatNomor.Contains(NumberConst.FormatMonthRomawi) Then
          _bulan = _tanggal.Month
        Else
          _bulan = Nothing
        End If

        _urutan = Number.Urutan
      End If

      MyBase.OnSaving()
      'Catch ex As Exception
      '  Throw New Exception("TRANSACTION BASE ==> " & ex.Message, ex.InnerException)
      'End Try
    End Sub
  End Class
End Namespace