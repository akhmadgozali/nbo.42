Namespace NuSoft.Core.Web
  Public Class HierarchicalDataSource(Of T)
    Implements Global.System.Web.UI.IHierarchicalDataSource

    Public Event DataSourceChanged(sender As Object, e As Global.System.EventArgs) Implements Global.System.Web.UI.IHierarchicalDataSource.DataSourceChanged
    Property Session As DevExpress.Xpo.Session
    Property ChildrenFieldName As String
    Property ParentFieldName As String

    Private view As HierarchicalDataSourceView(Of T)

    Public Function GetHierarchicalView(viewPath As String) As Global.System.Web.UI.HierarchicalDataSourceView Implements Global.System.Web.UI.IHierarchicalDataSource.GetHierarchicalView
      If view Is Nothing Then
        view = New HierarchicalDataSourceView(Of T)(Session, viewPath, ParentFieldName, ChildrenFieldName)
      End If

      Return view
    End Function
  End Class

  Public Class HierarchicalDataSourceView(Of T)
    Inherits Global.System.Web.UI.HierarchicalDataSourceView

    Private viewPath As String
    Private session As DevExpress.Xpo.Session
    Private parentField As String
    Private childrenField As String

    Public Sub New(ByVal session As DevExpress.Xpo.Session, ByVal viewPath As String, ByVal parentFieldName As String, ByVal childrenFieldName As String)
      Me.session = session
      Me.viewPath = viewPath
      Me.parentField = parentFieldName
      Me.childrenField = childrenFieldName
    End Sub

    Public Overrides Function [Select]() As Global.System.Web.UI.IHierarchicalEnumerable
      Dim collection As New DevExpress.Xpo.XPCollection(Of T)(session)
      collection.Criteria = New DevExpress.Data.Filtering.NullOperator(New DevExpress.Data.Filtering.OperandProperty(parentField))
      ' without a sotring the order of objects might differ 
      collection.Sorting.Add(New DevExpress.Xpo.SortProperty(session.GetClassInfo(GetType(T)).KeyProperty.Name, DevExpress.Xpo.DB.SortingDirection.Ascending))

      Return New HierarchicalEnumerable(Of T)(collection, parentField, childrenField)
    End Function
  End Class

  Public Class HierarchicalEnumerable(Of T)
    Implements Global.System.Web.UI.IHierarchicalEnumerable

    Private children As DevExpress.Xpo.XPCollection(Of T)
    Private parentField As String
    Private childrenField As String

    Public Sub New(ByVal children As DevExpress.Xpo.XPCollection(Of T), ByVal parentFieldName As String, ByVal childrenFieldName As String)
      Me.children = children
      Me.parentField = parentFieldName
      Me.childrenField = childrenFieldName
    End Sub
    Public Function GetEnumerator() As Global.System.Collections.IEnumerator Implements Global.System.Collections.IEnumerable.GetEnumerator
      Return (TryCast(children, IEnumerable(Of T))).GetEnumerator()
    End Function
    Public Function GetHierarchyData(enumeratedItem As Object) As Global.System.Web.UI.IHierarchyData Implements Global.System.Web.UI.IHierarchicalEnumerable.GetHierarchyData
      Dim obj As New HierarchyData(Of T)(children.Session, CType(enumeratedItem, T), parentField, childrenField)
      Return TryCast(obj, Global.System.Web.UI.IHierarchyData)
    End Function
  End Class

  Public Class HierarchyData(Of T)
    Implements Global.System.Web.UI.IHierarchyData

    Private session As DevExpress.Xpo.Session
    Private obj As T
    Private parentField As String
    Private childrenField As String
    Private classInfo As DevExpress.Xpo.Metadata.XPClassInfo

    Public Sub New(ByVal session As DevExpress.Xpo.Session, ByVal obj As T, ByVal parentFieldName As String, ByVal childrenFieldName As String)
      Me.session = session
      Me.obj = obj
      Me.parentField = parentFieldName
      Me.childrenField = childrenFieldName

      classInfo = session.GetClassInfo(GetType(T))
    End Sub
    Public Function GetChildren() As Global.System.Web.UI.IHierarchicalEnumerable Implements Global.System.Web.UI.IHierarchyData.GetChildren
      Dim memberInfo As DevExpress.Xpo.Metadata.XPMemberInfo = classInfo.GetMember(childrenField)
      Dim children As DevExpress.Xpo.XPCollection(Of T) = CType(memberInfo.GetValue(obj), DevExpress.Xpo.XPCollection(Of T))
      ' without a sotring the order of objects might differ 
      children.Sorting.Add(New DevExpress.Xpo.SortProperty(classInfo.KeyProperty.Name, DevExpress.Xpo.DB.SortingDirection.Ascending))

      Return New HierarchicalEnumerable(Of T)(children, parentField, childrenField)
    End Function
    Public Function GetParent() As Global.System.Web.UI.IHierarchyData Implements Global.System.Web.UI.IHierarchyData.GetParent
      Dim memberInfo As DevExpress.Xpo.Metadata.XPMemberInfo = classInfo.GetMember(parentField)
      Dim parent As T = CType(memberInfo.GetValue(obj), T)

      If parent Is Nothing Then
        Return Nothing
      End If

      Dim hierarchyData As New HierarchyData(Of T)(session, parent, parentField, childrenField)

      Return TryCast(hierarchyData, Global.System.Web.UI.IHierarchyData)
    End Function
    Public ReadOnly Property HasChildren As Boolean Implements Global.System.Web.UI.IHierarchyData.HasChildren
      Get
        Dim memberInfo As DevExpress.Xpo.Metadata.XPMemberInfo = classInfo.GetMember(childrenField)
        Dim children As DevExpress.Xpo.XPCollection(Of T) = CType(memberInfo.GetValue(obj), DevExpress.Xpo.XPCollection(Of T))

        Return (children.Count > 0)
      End Get
    End Property
    Public ReadOnly Property Item As Object Implements Global.System.Web.UI.IHierarchyData.Item
      Get
        Return obj
      End Get
    End Property
    Public ReadOnly Property Path As String Implements Global.System.Web.UI.IHierarchyData.Path
      Get
        Dim key As Object = session.GetKeyValue(obj)
        Return key.ToString()
      End Get
    End Property
    Public ReadOnly Property Type As String Implements Global.System.Web.UI.IHierarchyData.Type
      Get
        Return classInfo.FullName
      End Get
    End Property
  End Class
End Namespace