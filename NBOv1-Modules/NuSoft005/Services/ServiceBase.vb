Imports DevExpress.Xpo

Friend MustInherit Class ServiceBase(Of T As NPO.NPOBase)
	Protected Friend uow As UnitOfWork
	Protected Friend _dataOriginalEdit As T

	Protected Friend Sub New(connection As UnitOfWork)
		Me.New(connection, Nothing)
	End Sub
	Protected Friend Sub New(connection As UnitOfWork, dataOriginalEdit As T)
		uow = connection
		If (dataOriginalEdit Is Nothing) Then
			_dataOriginalEdit = Nothing
		Else
			_dataOriginalEdit = CType(dataOriginalEdit.Clone(), T)
		End If
	End Sub

	Protected Friend MustOverride Function CheckBeforeSave(ByVal obj As T) As Boolean
	Protected Friend MustOverride Function CheckBeforeDelete(ByVal obj As T) As Boolean

	Protected Friend Overridable Sub SaveAction(ByVal obj As T)
	End Sub
	Protected Friend Overridable Sub BeforeDeleteAction(ByVal obj As T)
	End Sub
	Protected Friend Overridable Sub AfterDeleteAction(ByVal obj As T)
	End Sub
	Protected Friend Overridable Sub BeforeDeleteCommit(ByVal objs As List(Of T))
	End Sub
	Protected Friend Overridable Sub AfterDeleteCommit()
	End Sub
	Protected Friend Overridable Sub AfterSaveCommit(ByVal obj As T)
	End Sub

	Protected Friend Function Delete(obj As T) As Boolean
		Try
			If (Not CheckBeforeDelete(obj)) Then Return False
			BeforeDeleteAction(obj)
			obj.Delete()
			AfterDeleteAction(obj)
			Return True
		Catch ex As Exception
			Throw New Exception(ex.Message, ex.InnerException)
		End Try
	End Function
	Protected Friend Function Delete(objs As List(Of T)) As Boolean
		Try
			Dim errorMessage = ""
			Dim anySuccess As Boolean = False
			BeforeDeleteCommit(objs)
			For Each obj As T In objs
				Try
					Delete(obj)
					anySuccess = True
				Catch ex As Exception
					errorMessage &= ex.Message & vbCrLf
				End Try
			Next

			If (anySuccess) Then uow.CommitChanges()
			AfterDeleteCommit()
			If (Not String.IsNullOrEmpty(errorMessage)) Then Throw New Exception(errorMessage)

			Return True
		Catch ex As Exception
				Throw New Exception(ex.Message, ex.InnerException)
		End Try
	End Function
	Protected Friend Function Save(obj As T) As Boolean
		Try
			If (CheckBeforeSave(obj)) Then
				SaveAction(obj)
				uow.CommitChanges()
				AfterSaveCommit(obj)
				Return True
			Else
				uow.RollbackTransaction()
				Return False
			End If
		Catch ex As Utils.Exception
			uow.RollbackTransaction()
			Throw New Utils.Exception(ex.Message, ex.ErrorNumber)
		Catch ex As Exception
			Throw New Exception(ex.Message, ex.InnerException)
		End Try
	End Function
End Class
