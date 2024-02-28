Imports DevExpress.Data.Filtering

Friend Class UI_Akun
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    KeyField = "Id"
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("mastercoa.xml")) = True Then
      xTree.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("mastercoa.xml"))
    End If
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputDialog
    Return New UI_AkunDialog
  End Function
  Overrides Function GetKeteranganHapus(selectedRows As DevExpress.XtraTreeList.TreeListMultiSelection) As System.Collections.Generic.List(Of Core.Win.Forms.TreeDeletedData)
    Dim result As New System.Collections.Generic.List(Of Core.Win.Forms.TreeDeletedData)
    Dim item As Core.Win.Forms.TreeDeletedData

    For Each i As DevExpress.XtraTreeList.Nodes.TreeListNode In xTree.Selection
      item = New Core.Win.Forms.TreeDeletedData
      item.Row = i
      item.Data = String.Format("{0} - {1}", i("Kode"), i("Nama"))
      result.Add(item)
    Next
    Return result
  End Function
  Overrides Function HapusData(selectedRows As System.Collections.Generic.List(Of Core.Win.Forms.TreeDeletedData)) As Boolean
    Try
      For i = 0 To selectedRows.Count - 1
        CType(xTree.GetDataRecordByNode(selectedRows(i).Row), Persistent.Coa).Delete()
      Next
      session.CommitChanges()
    Catch ex As Utils.Exception
      Throw New Utils.Exception(ex)
    Catch ex As Exception
      If ex.Message.Contains("foreign key constraint") Then
        MsgBox("Data tidak dapat dihapus karena masih terpakai oleh tabel lain.", , "Hapus Data")
        'Throw New Utils.Exception("Data tidak dapat dihapus karena masih terpakai oleh tabel lain.", 0, "", "Hapus")
      Else
        Throw New Exception(ex.Message, ex.InnerException)
      End If
    End Try
    Return True
  End Function
  Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExpand.ItemClick
    xTree.ExpandAll()
  End Sub
  Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCollapse.ItemClick
    xTree.CollapseAll()
  End Sub
  Private Sub btnSaveLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveLayout.ItemClick
    xTree.SaveLayoutToXml(Logic.Umum.xLokasiLayout("mastercoa.xml"))
  End Sub
  Private Sub btnDetail_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetail.ItemClick
    'Dim xKode As String = xTree.FocusedNode.GetDisplayText(colKode)
    'Dim xNama As String = xTree.FocusedNode.GetDisplayText(colNama)
    'Dim xFilter As CriteriaOperator = CreateCriteriaDetail(xKode)
    'Dim a As New UI_DaftarGLDetail(xFilter, "Daftar GL : " & xKode & "(" & xNama & ")")
    'a.session = Me.session
    'a.TampilkanData()
    'a.ShowMDI()
  End Sub
  Private Function CreateCriteriaDetail(xKode As String) As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    result.Add(New BinaryOperator("Akun.Kode", xKode, BinaryOperatorType.Equal))
    Return GroupOperator.And(result)
  End Function
End Class