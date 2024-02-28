Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Metadata

Namespace NuSoft.NPO
	<DevExpress.Xpo.NonPersistent()>
	Public MustInherit Class NPOBase
		Inherits DevExpress.Xpo.XPLiteObject

		Protected Friend _session As UnitOfWork
		Private changes As New List(Of DatabaseLogDetailChange)()
		Private isNewObj As Boolean

		Public Sub New(ByVal session As DevExpress.Xpo.UnitOfWork)
			MyBase.New(session)
			_session = session
		End Sub
		Public Sub New(ByVal session As DevExpress.Xpo.UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
			_session = session
		End Sub

		Protected Overrides Sub OnChanged(ByVal propertyName As String, ByVal oldValue As Object, ByVal newValue As Object)
			MyBase.OnChanged(propertyName, oldValue, newValue)

			Dim change As New DatabaseLogDetailChange() With {.PropertyName = propertyName}
			If oldValue Is Nothing Then
				change.PrevValue = "<NULL>"
			Else
				change.PrevValue = oldValue.ToString()
			End If
			If newValue Is Nothing Then
				change.Value = "<NULL>"
			Else
				change.Value = newValue.ToString()
			End If
			If changes Is Nothing Then changes = New List(Of DatabaseLogDetailChange)
			changes.Add(change)
		End Sub

		Private Sub UpdateLog(action As DatabaseLog.Action, activity As String)
			Dim tableName As String = ClassInfo.TableName
			Dim rowId As String = Session.GetKeyValue(Me).ToString 'ClassInfo.GetId(Me).ToString
      Dim uniqueData As String = ""
      Dim uniqueId As String = ""
      Dim fieldName As String = ""

      For i = 0 To ClassInfo.Members.Count - 1
        fieldName &= ClassInfo.Members(i).Name & vbCrLf
        If ClassInfo.Members(i).HasAttribute(GetType(NAttribute.NUniqueAttribute)) Then
          Dim attr As NAttribute.NUniqueAttribute = CType(ClassInfo.Members(i).GetAttributeInfo(GetType(NAttribute.NUniqueAttribute)), NAttribute.NUniqueAttribute)

          If attr.Jenis = NAttribute.NUniqueAttribute.JenisAttr.LogKode Or attr.Jenis = NAttribute.NUniqueAttribute.JenisAttr.Primary Then
            uniqueData &= ";" & GetMemberValue(ClassInfo.Members(i).Name).ToString
          End If

          If attr.Jenis = NAttribute.NUniqueAttribute.JenisAttr.LogId Then
            uniqueId &= ";" & GetMemberValue(ClassInfo.Members(i).Name).ToString
          End If
        End If
      Next
      'If tableName = "m06ddetailquotation" Then
      '  Throw New Exception("Field : " & fieldName)
      'End If

      If uniqueData <> "" Then uniqueData = uniqueData.Substring(1)
      If uniqueId <> "" Then uniqueId = uniqueId.Substring(1)

      Core.SSystem.DatabaseLog.Save(Session, action, activity, tableName, rowId, uniqueData, uniqueId, changes)
    End Sub

		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
			isNewObj = True
			Dim member As XPMemberInfo = ClassInfo.Members.ToList().Find(Function(m) m.IsKey)
			If Not member Is Nothing Then
				Dim num = member.GetValue(Me)
				If Not num Is Nothing Then
					If TypeOf num Is Integer Then
						'Throw New Exception("MyBase.Session Nothing = " & (MyBase.Session Is Nothing) & "; This.Session Nothing = " & (Session Is Nothing))
						Dim current = Convert.ToInt32(MyBase.Session.Evaluate(ClassInfo, CriteriaOperator.Parse("Max(" + member.Name + ")"), Nothing))
						'Throw New Exception("Current = " & current)
						member.SetValue(Me, current + 1)
					ElseIf TypeOf num Is Int64 Then
						Dim current = Convert.ToInt64(MyBase.Session.Evaluate(ClassInfo, CriteriaOperator.Parse("Max(" + member.Name + ")"), Nothing))
						member.SetValue(Me, current + 1)
					ElseIf TypeOf num Is UInt64 Then
						member.SetValue(Me, Data.Helper.GetUUIDShort(MyBase.Session))
					End If
				End If
			End If
		End Sub
		Protected Overrides Sub EndEdit()
			If Session.IsNewObject(Me) Then
				created_date = Data.Helper.GetTimeStamp(Session)
				created_user = Core.SSystem.UserInfo.GetUserModified
			End If
			last_date = Data.Helper.GetTimeStamp(Session)
			last_modified = Core.SSystem.UserInfo.GetUserModified
			MyBase.EndEdit()
		End Sub
		Protected Overrides Sub OnSaving()
			'Try
			If CheckKode() Then
				If Session.IsNewObject(Me) Then
					created_date = Data.Helper.GetTimeStamp(Session)
					created_user = Core.SSystem.UserInfo.GetUserModified
				End If
				last_date = Data.Helper.GetTimeStamp(Session)
				last_modified = Core.SSystem.UserInfo.GetUserModified
				MyBase.OnSaving()
				'If Session.IsNewObject(Me) Then
				'	UpdateLog(DatabaseLog.Action.Tambah, "Tambah Data: " & ClassInfo.TableName)
				'Else
				'	UpdateLog(DatabaseLog.Action.Edit, "Edit Data: " & ClassInfo.TableName)
				'End If
			End If
			'Catch ex As Exception
			'  Throw New Exception("NPO BASE ==> " & ex.Message, ex.InnerException)
			'End Try
		End Sub
		Protected Overrides Sub OnSaved()
			MyBase.OnSaved()
			If isNewObj Then
				UpdateLog(DatabaseLog.Action.Tambah, "Tambah Data: " & ClassInfo.TableName)
			Else
				UpdateLog(DatabaseLog.Action.Edit, "Edit Data: " & ClassInfo.TableName)
			End If
			Session.CommitChanges()
		End Sub
		Protected Overrides Sub OnDeleting()
			MyBase.OnDeleting()
			UpdateLog(DatabaseLog.Action.Hapus, "Hapus Data: " & ClassInfo.TableName)
		End Sub
		Private Function CheckKode() As Boolean
			'Try

			'Dim codeField = New List(Of System.Collections.Specialized.StringCollection)
			Dim codeField = New List(Of String)

			For i = 0 To ClassInfo.Members.Count - 1
				If ClassInfo.Members(i).HasAttribute(GetType(NAttribute.NUniqueAttribute)) Then
					Dim attr As NAttribute.NUniqueAttribute = CType(ClassInfo.Members(i).GetAttributeInfo(GetType(NAttribute.NUniqueAttribute)), NAttribute.NUniqueAttribute)
					If attr.Jenis = NAttribute.NUniqueAttribute.JenisAttr.Primary Then
						codeField.Add(ClassInfo.Members(i).Name)
					End If
				End If
			Next

			'=======================================
			' 1. Cek Update atau insert
			' 2. Jika update ambil data sebelumnya
			' 3. Compare data previous and present
			' 4. Compare data dengan database
			'=======================================

			For i = 0 To codeField.Count - 1
				'MsgBox("codeField i ==> " & codeField(i))
				If IsUniqueDataExist(codeField(i)) Then
					Dim data As String = ""
					'For j = 0 To codeField(i).Count - 1
					'MsgBox("codeField ij ==> " & codeField(i)(j))
					'data &= ";" & GetMemberValue(codeField(i)(j)).ToString
					'Next
					data &= ";" & GetMemberValue(codeField(i)).ToString

					Throw New Utils.Exception("Kode '" & data.Substring(1) & "' yang anda masukkan telah ada di database.", -999, "Ganti kode yang anda masukkan", "Cek Kode")
					Return False
				End If
			Next

			Return True
			'Catch ex As Exception
			'  Throw New Exception("Check Kode ==> " & ex.Message, ex.InnerException)
			'End Try
		End Function
		Private Function IsUniqueDataExist(field As String) As Boolean
			Try

				If Not Session.IsNewObject(Me) Then
					Dim detail As New List(Of DatabaseLogDetailChange)
					Dim anyChanges As Boolean = False

					detail = changes.FindAll(Function(m) m.PropertyName = field)
					If detail.Count > 0 Then
						If detail(0).PrevValue <> detail(detail.Count - 1).Value Then
							anyChanges = True
						End If
					End If

					If Not anyChanges Then
						Return False
					End If
				End If

				Dim xData As Object = GetMemberValue(field)
				'MsgBox(Session.FindObject(ClassInfo, GetCriteria(field, xData)).ToString)
				Return Not Session.FindObject(ClassInfo, New BinaryOperator(field, xData, BinaryOperatorType.Equal)) Is Nothing 'GetCriteria(field, xData)) Is Nothing
			Catch ex As Exception
				Throw New Exception("IsUniqueDataExist 1 ==> " & ex.Message, ex.InnerException)
			End Try
		End Function
		Private Function IsUniqueDataExist(field As System.Collections.Specialized.StringCollection) As Boolean
			Try

				If Not Session.IsNewObject(Me) Then
					Dim xField As String
					Dim detail As New List(Of DatabaseLogDetailChange)
					Dim anyChanges As Boolean = False

					For i = 0 To field.Count - 1
						xField = field(i)

						detail = changes.FindAll(Function(m) m.PropertyName = xField)
						If detail.Count > 0 Then
							If detail(0).PrevValue <> detail(detail.Count - 1).Value Then
								anyChanges = True
								Exit For
							End If
						End If
					Next

					If Not anyChanges Then
						Return False
					End If
				End If

				Dim xData As New List(Of Object)
				For i = 0 To field.Count - 1
					xData.Add(GetMemberValue(field(i)))
				Next

				'MsgBox(Session.FindObject(ClassInfo, GetCriteria(field, xData)).ToString)
				Return Not Session.FindObject(ClassInfo, GetCriteria(field, xData)) Is Nothing
			Catch ex As Exception
				Throw New Exception("IsUniqueDataExist 2 ==> " & ex.Message, ex.InnerException)
			End Try
		End Function

		Private Function IsUniqueDataExist___Old(field As System.Collections.Specialized.StringCollection) As Boolean
			Dim result As Boolean = False
			Dim detail As New List(Of DatabaseLogDetailChange)
			Dim xField As String
			Dim xData As New List(Of Object)

			For i = 0 To field.Count - 1
				xField = field(i)
				detail = changes.FindAll(Function(m) m.PropertyName = xField)
				If detail.Count > 0 Then
					If detail(0).PrevValue = detail(detail.Count - 1).Value Then
						xData.Insert(i, detail(0).PrevValue)
					Else
						xData.Insert(i, detail(detail.Count - 1).Value)
						result = True
					End If
				Else
					xData.Insert(i, GetPropertyValue(xField))
				End If
			Next

			If result Then
				Return Not Session.FindObject(ClassInfo, GetCriteria(field, xData)) Is Nothing
			Else
				Return False
			End If
		End Function
		Private Function GetCriteria(field As System.Collections.Specialized.StringCollection, data As List(Of Object)) As CriteriaOperator
			Dim result As New List(Of CriteriaOperator)

			For i = 0 To field.Count - 1
				result.Add(New BinaryOperator(field(i), data(i), BinaryOperatorType.Equal))
			Next

			Return GroupOperator.And(result)
		End Function

		Public Property created_date() As DateTime
		Public Property created_user() As String
		Public Property last_date() As DateTime
		Public Property last_modified() As String

		Overloads ReadOnly Property Session As UnitOfWork
			Get
				Return _session
			End Get
		End Property
		Public Function Clone() As Object
			Return Me.MemberwiseClone()
		End Function
	End Class

	Public MustInherit Class NPOCollection
		Implements IList

		Property session As DevExpress.Xpo.Session

		Public Sub New(ByVal session As Session)
			Me.session = session
		End Sub

		Protected Friend MustOverride Function CreateObjects() As IList
		Protected ReadOnly Property Objects As IList
			Get
				Return CreateObjects()
			End Get
		End Property

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

	Namespace NAttribute
		<AttributeUsage(AttributeTargets.Property Or AttributeTargets.Field, AllowMultiple:=True)>
		Public Class NUniqueAttribute
			Inherits Attribute

			Enum JenisAttr
				Primary
				Sequence
				LogKode
        LogId
      End Enum

      Private _jenis As JenisAttr

			Public Sub New(ByVal value As JenisAttr)
				_jenis = value
			End Sub
			Public ReadOnly Property Jenis() As JenisAttr
				Get
					Return _jenis
				End Get
			End Property
		End Class
		<AttributeUsage(AttributeTargets.Property Or AttributeTargets.Field, AllowMultiple:=True)>
		Public Class NCriteriaAttribute
			Inherits Attribute

			Private _key As String

			Public Sub New(ByVal key As String)
				_key = key
			End Sub
			Public ReadOnly Property Key() As String
				Get
					Return _key
				End Get
			End Property
		End Class
	End Namespace
End Namespace