Friend Class Frm_Setting
  Private isLoad As Boolean = False
  Private crc As New Utils.CRC32

  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Me.Icon = My.Resources.NusoftIcon
    xTree.DataSource = New Object()
  End Sub
  Private Sub xTree_NodesReloaded(ByVal sender As Object, ByVal e As System.EventArgs) Handles xTree.NodesReloaded
    If Not xTree.IsLoading Then
      Dim dataTable As DataTable = Setting.CreateTable()

      For i = 0 To xTree.Nodes.Count - 1
        xTree.Nodes(i).Checked = True
      Next

      If My.Computer.FileSystem.FileExists(Setting.GetSettingFile) Then
        dataTable.ReadXml(Setting.GetSettingFile)
        For i = 0 To dataTable.Rows.Count - 1
          If Not CBool(dataTable.Rows(i)("Active")) Then
            Dim treeNode As DevExpress.XtraTreeList.Nodes.TreeListNode = xTree.FindNodeByFieldValue("Name", dataTable.Rows(i)("FileName"))
            If Not treeNode Is Nothing Then
              treeNode.Checked = False
            End If
          End If
        Next
      End If
    End If
  End Sub
  Private Sub xTree_VirtualTreeGetCellValue(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.VirtualTreeGetCellValueInfo) Handles xTree.VirtualTreeGetCellValue
    Dim di As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(CStr(e.Node))
    If e.Column Is treeFileName Then
      e.CellData = di.Name
    ElseIf e.Column Is treeCRC Then
      Dim f As System.IO.FileStream = New System.IO.FileStream(di.FullName, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read, 8192)
      e.CellData = String.Format("{0:X8}", crc.GetCrc32(f))
      f.Close()
    End If
  End Sub
  Private Sub xTree_VirtualTreeGetChildNodes(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.VirtualTreeGetChildNodesInfo) Handles xTree.VirtualTreeGetChildNodes
    Try
      If Not isLoad Then
        Dim path As String = My.Application.Info.DirectoryPath & "\Report"
        If System.IO.Directory.Exists(path) Then
          Dim files As String() = System.IO.Directory.GetFiles(path)
          e.Children = files
        Else
          e.Children = New Object() {}
        End If
        isLoad = True
      End If
    Catch
      e.Children = New Object() {}
    End Try
  End Sub
  Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
    Dim newTable As DataTable = Setting.CreateTable()
    Dim newRow As DataRow

    For i = 0 To xTree.Nodes.Count - 1
      newRow = newTable.NewRow
      newRow("FileName") = xTree.Nodes(i)("Name").ToString
      newRow("Active") = xTree.Nodes(i).Checked
      newTable.Rows.Add(newRow)
    Next

    newTable.WriteXml(Setting.GetSettingFile)
    Me.Close()
  End Sub

  Private Sub btnCekUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCekUpdate.Click
    Dim frm As New Frm_Proses
    frm.ShowIcon = False
    frm.ShowDialog()
    'Process.Start("SyBiru.Sync.Exe", "-foreground").WaitForExit()
  End Sub
End Class
