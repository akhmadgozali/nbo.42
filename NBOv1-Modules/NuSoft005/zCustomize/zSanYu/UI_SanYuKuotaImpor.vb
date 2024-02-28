Imports DevExpress.Xpo

Public Class UI_SanYuKuotaImpor
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    baseView = xGridView
    KeyField = "Id"
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_SanYuKuotaImporDialog
  End Function
  Public Overrides Function GetKeteranganHapus(selectedRows() As Integer) As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
    Dim result As New List(Of Core.Win.Forms.GridDeletedData)
    Dim item As Core.Win.Forms.GridDeletedData

    For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
      If Not xGridView.IsGroupRow(selectedRows(i)) Then
        item = New Core.Win.Forms.GridDeletedData
        item.Row = selectedRows(i)
        item.Data = String.Format("{0}", xGridView.GetRowCellValue(selectedRows(i), "KodeHS"))
        result.Add(item)
      End If
    Next
    Return result
  End Function
  Public Overrides Function HapusData(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)) As Boolean
    Dim terpakai = New XPQuery(Of Persistent.SanYu_OrderPembelianDetail)(session).Where(Function(w) Not w.KuotaImpor Is Nothing).GroupBy(Function(g) g.KuotaImpor).Select(Function(s) s.Key).ToList
    Dim notDeleted As String = String.Empty

    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        Dim instance = CType(xGridView.GetRow(selectedData(i).Row), Persistent.SanYu_KuotaImpor)
        If terpakai.Find(Function(f) f Is instance) Is Nothing Then
          Logic.Umum.SaveLog(session, Persistent.TipeLOG.Delete, "Admin", "Kuota Impor : Hapus " & instance.KodeHS)
          instance.Delete()
        Else
          notDeleted &= vbCrLf & instance.KodeHS
        End If
      End If
    Next

    If Not String.IsNullOrEmpty(notDeleted) Then
      Utils.Win.MessageBox.Show("Kuota impor tidak bisa dihapus karena sudah terpakai di order pembelian." & notDeleted, "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
    session.CommitChanges()
    Return True
  End Function
End Class