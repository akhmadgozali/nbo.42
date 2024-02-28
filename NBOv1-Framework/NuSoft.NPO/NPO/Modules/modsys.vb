Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace NuSoft.NPO.Modules.ModSys
	<Persistent("a_division")> Public Class Divisi
		Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

		Private _id As UInt16
		<Persistent("p_id"), Key()> Property Id As UInt16
			Get
				Return _id
			End Get
			Set(ByVal value As UInt16)
				SetPropertyValue(Of UInt16)("Id", _id, value)
			End Set
		End Property
		Private _kode As String
		<Persistent("u_code")> Property Kode As String
			Get
				Return _kode
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Kode", _kode, value)
			End Set
		End Property
    Private _nama As String
    <Persistent("d_name")> Property Nama As String
      Get
        Return _nama
      End Get
      Set(ByVal value As String)
        SetPropertyValue(Of String)("Nama", _nama, value)
      End Set
    End Property
  End Class

	<Persistent("a_regional")> Public Class Regional
		Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

		Private _id As UInt16
		Private _kode As String
		Private _nama As String
		Private _alamat As String
		Private _kota As String
		Private _propinsi As String
		Private _kodePos As String
		Private _keterangan As String

		<Persistent("p_id"), Key()> Property Id As UInt16
			Get
				Return _id
			End Get
			Set(value As UInt16)
				SetPropertyValue(Of UInt16)("Id", _id, value)
			End Set
		End Property
		<Persistent("u_code"), Size(3)> Property Kode As String
			Get
				Return _kode
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Kode", _kode, value)
			End Set
		End Property
		<Persistent("d_name")> Property Nama As String
			Get
				Return _nama
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Nama", _nama, value)
			End Set
		End Property
		<Persistent("d_address")> Property Alamat As String
			Get
				Return _alamat
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Alamat", _alamat, value)
			End Set
		End Property
		<Persistent("d_city")> Property Kota As String
			Get
				Return _kota
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Kota", _kota, value)
			End Set
		End Property
		<Persistent("d_province")> Property Propinsi As String
			Get
				Return _propinsi
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Propinsi", _propinsi, value)
			End Set
		End Property
		<Persistent("d_postal")> Property KodePos As String
			Get
				Return _kodePos
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("KodePos", _kodePos, value)
			End Set
		End Property
		<Persistent("d_note")> Property Keterangan As String
			Get
				Return _keterangan
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Keterangan", _keterangan, value)
			End Set
		End Property
	End Class

	<Persistent("a_setting")> Public Class Setting
		Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

		Private _id As Int32
		Private _modul As Integer
		Private _kode As String
		Private _isi As String
		Private _keterangan As String

		<Persistent("p_id"), Key(True)> Property Id As Int32
			Get
				Return _id
			End Get
			Set(value As Int32)
				SetPropertyValue(Of Int32)("Id", _id, value)
			End Set
		End Property
		<Persistent("u_module")> Property Modul As Integer
			Get
				Return _modul
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)("Modul", _modul, value)
			End Set
		End Property
		<Persistent("u_code")> Property Kode As String
			Get
				Return _kode
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Kode", _kode, value)
			End Set
		End Property
		<Persistent("d_value")> Property Isi As String
			Get
				Return _isi
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Isi", _isi, value)
			End Set
		End Property
		<Persistent("d_note")> Property Keterangan As String
			Get
				Return _keterangan
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Keterangan", _keterangan, value)
			End Set
		End Property
	End Class

  <Persistent("a_source")> Public Class SumberData
    Inherits XPLiteObject

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Persistent("p_id"), Key(True)> Property Id As Int32
    <Persistent("u_code"), Size(3)> Property Kode As String
    <Persistent("d_note")> Property Keterangan As String
    <Persistent("x_module")> Property ModuleId As NPO.Modules.ModuleId
  End Class
  Public MustInherit Class SumberDataCollection(Of T)
    Implements IList

    Public MustOverride Function ModuleId() As NPO.Modules.ModuleId
    Property session As DevExpress.Xpo.UnitOfWork

    Public Sub New(ByVal session As UnitOfWork)
      Me.session = session
    End Sub
    Protected ReadOnly Property Objects As IList
      Get
        Return CreateObjects()
      End Get
    End Property

    Public Shared Function GetEnum([object] As SumberData) As T
      For Each intVal In [Enum].GetValues(GetType(T))
        If intVal.ToString = [object].Kode Then
          Return CType(intVal, T)
        End If
      Next
    End Function

    Private Function CreateObjects() As IList
      Dim intVal As T
      Dim result As New List(Of SumberData)

      If CheckT() Then
        For Each intVal In [Enum].GetValues(GetType(T))
          result.Add(GetObject(intVal))
        Next

        Return result
      Else
        Return Nothing
      End If
    End Function
    Private Function CheckT() As Boolean
      If Not GetType(T).IsEnum Then
        Throw New Exception("T bukan tipe Enum")
      End If

      Return True
    End Function
    Private Function GetItem(data As T) As SumberData
      Return session.FindObject(Of SumberData)(New GroupOperator(GroupOperatorType.And, New BinaryOperator("Kode", data.ToString, BinaryOperatorType.Equal), New BinaryOperator("ModuleId", ModuleId, BinaryOperatorType.Equal)))
    End Function
    Public Function GetObject([enum] As T) As SumberData
      Dim result As SumberData = GetItem([enum])

      If result Is Nothing Then
        result = New SumberData(session)
        result.Kode = [enum].ToString
        result.Keterangan = Utils.Helper.EnumDescription.GetDescription([enum])
        result.ModuleId = ModuleId()
        session.CommitChanges()
      End If
      Return result
    End Function

    Public Function Add(value As Object) As Integer Implements System.Collections.IList.Add
      Return Objects.Add(value)
    End Function
    Public Sub Clear() Implements System.Collections.IList.Clear
      Objects.Clear()
    End Sub
    Public Function Contains(value As Object) As Boolean Implements System.Collections.IList.Contains
      Return Objects.Contains(value)
    End Function
    Public Sub CopyTo(array As System.Array, index As Integer) Implements System.Collections.IList.CopyTo
      Objects.CopyTo(array, index)
    End Sub
    Public ReadOnly Property Count As Integer Implements System.Collections.IList.Count
      Get
        Return Objects.Count
      End Get
    End Property
    Public Function IndexOf(value As Object) As Integer Implements System.Collections.IList.IndexOf
      Return Objects.IndexOf(value)
    End Function
    Public Sub Insert(index As Integer, value As Object) Implements System.Collections.IList.Insert
      Objects.Insert(index, value)
    End Sub
    Public ReadOnly Property IsFixedSize As Boolean Implements System.Collections.IList.IsFixedSize
      Get
        Return Objects.IsFixedSize
      End Get
    End Property
    Public ReadOnly Property IsReadOnly As Boolean Implements System.Collections.IList.IsReadOnly
      Get
        Return Objects.IsReadOnly
      End Get
    End Property
    Public ReadOnly Property IsSynchronized As Boolean Implements System.Collections.IList.IsSynchronized
      Get
        Return Objects.IsSynchronized
      End Get
    End Property
    Default Public Property Item(index As Integer) As Object Implements System.Collections.IList.Item
      Get
        Return Objects.Item(index)
      End Get
      Set(value As Object)
        Objects(index) = value
      End Set
    End Property
    Public ReadOnly Property SyncRoot As Object Implements System.Collections.IList.SyncRoot
      Get
        Return Objects.SyncRoot
      End Get
    End Property
    Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
      Return Objects.GetEnumerator
    End Function
    Public Sub Remove(value As Object) Implements System.Collections.IList.Remove
      Objects.Remove(value)
    End Sub
    Public Sub RemoveAt(index As Integer) Implements System.Collections.IList.RemoveAt
      Objects.RemoveAt(index)
    End Sub
  End Class
End Namespace