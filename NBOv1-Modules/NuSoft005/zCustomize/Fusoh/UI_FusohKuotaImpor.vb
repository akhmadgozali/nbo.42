Imports DevExpress.Xpo
Imports NuSoft.Core.SSystem

Public Class UI_FusohKuotaImpor
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    baseView = xGridView
		KeyField = "Id"
		xGridView.OptionsDetail.EnableMasterViewMode = True
	End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_FusohKuotaImporDialog
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
    Dim terpakai = New XPQuery(Of Persistent.Fusoh_OrderPembelianDetail)(session).Where(Function(w) Not w.KuotaImpor Is Nothing).GroupBy(Function(g) g.KuotaImpor).Select(Function(s) s.Key).ToList
    Dim notDeleted As String = String.Empty
    Dim kodeDelete = ""

    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        Dim instance = CType(xGridView.GetRow(selectedData(i).Row), Persistent.Fusoh_KuotaImpor)
        If terpakai.Find(Function(f) f Is instance) Is Nothing Then
          kodeDelete &= ", " & instance.KodeHS
          instance.Delete()
        Else
          notDeleted &= vbCrLf & instance.KodeHS
        End If
      End If
    Next

    session.CommitChanges()
    '======= Simple log
    Try
      If kodeDelete <> "" Then
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Hapus, "Data Kuota Impor ->" & kodeDelete.Substring(1))
        session.CommitChanges()
      End If
    Catch ex As Exception
    End Try

    If Not String.IsNullOrEmpty(notDeleted) Then
      Utils.Win.MessageBox.Show("Kuota impor tidak bisa dihapus karena sudah terpakai di order pembelian." & notDeleted, "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
    Return True
  End Function
End Class