Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem
Public Class UI_AktivaTetapTransaksi
  Private toStringFormat As String
  Sub New()
    InitializeComponent()

    baseView = xGridView
    KeyField = "Id"
    useMDIforDialog = True
    useFeedbackSource = True
    ActivateToolTip = True
    UseDbSystem = False
    allowAdd = False
    allowEdit = False
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_AktivaTetapPenyusutan
  End Function
  Overrides Function GetKeteranganHapus(selectedRows() As Integer) As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
    Dim result As New List(Of Core.Win.Forms.GridDeletedData)
    Dim item As Core.Win.Forms.GridDeletedData

    For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
      If Not xGridView.IsGroupRow(selectedRows(i)) Then
        item = New Core.Win.Forms.GridDeletedData
        item.Row = selectedRows(i)
        item.Data = xGridView.GetRowCellValue(selectedRows(i), "Kode").ToString
        result.Add(item)
      End If
    Next
    Return result
  End Function
  Overrides Function HapusData(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)) As Boolean
    Dim item As Persistent.AktivaTransaksiMain, pPending As Integer
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

    pPending = 0
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.AktivaTransaksiMain)
        If item.Tipe = Persistent.eTipeTransaksiAsset.SaldoAwal OrElse item.Tipe = Persistent.eTipeTransaksiAsset.Pembelian Then
          For pI = 0 To item.Detail.Count - 1
            item.Detail(pI).Asset.Pembelian = False
          Next
        End If
        If item.Tipe = Persistent.eTipeTransaksiAsset.WriteOff Then
          For pi = 0 To item.Detail.Count - 1
            item.Detail(pi).Asset.QtyOut = item.Detail(pi).Asset.QtyOut - item.Detail(pi).Qty
            item.Detail(pi).Asset.Dispose = False
          Next
        End If
        Dim zdtGL As Persistent.GlMain = session.FindObject(Of Persistent.GlMain)(New BinaryOperator("Id", item.GL.Id, BinaryOperatorType.Equal))
        If Not zdtGL Is Nothing Then
          zdtGL.Delete()
        End If
        item.Delete()
      End If
    Next
    session.CommitChanges()
    Return True
  End Function


End Class