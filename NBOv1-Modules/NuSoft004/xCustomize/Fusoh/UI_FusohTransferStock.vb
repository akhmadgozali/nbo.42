Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports NuSoft.Core.SSystem

Public Class UI_FusohTransferStock
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    baseView = xGridView
    KeyField = "Id"
    useMDIforDialog = True
    useFeedbackSource = True
    ActivateToolTip = True
    UseDbSystem = False
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
    Dim setting As New NuSoft001.Logic.FinaSetting(session)
    Dim CreateCriteria As CriteriaOperator
    CreateCriteria = GroupOperator.And(New BinaryOperator("Sumber", Persistent.SumberDataJenis.TS, BinaryOperatorType.Equal))
    ifSource.FixedFilterCriteria = CreateCriteria
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("TSData.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("TSData.xml"))
    End If
    'colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colQtyIn.DisplayFormat.FormatString = setting.NumericFormatString
    'colHargaIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colHargaIn.DisplayFormat.FormatString = setting.NumericFormatString
    'colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colTotal.DisplayFormat.FormatString = setting.NumericFormatString
    'colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_FusohTransferStockDialog
  End Function
  Public Overrides Function GetKeteranganHapus(selectedRows() As Integer) As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
    Dim result As New List(Of Core.Win.Forms.GridDeletedData)
    Dim item As Core.Win.Forms.GridDeletedData

    For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
      If Not xGridView.IsGroupRow(selectedRows(i)) Then
        item = New Core.Win.Forms.GridDeletedData
        item.Row = selectedRows(i)
        item.Data = String.Format("{0} - {1}", xGridView.GetRowCellValue(selectedRows(i), "Barang.Kode"), xGridView.GetRowCellValue(selectedRows(i), "Barang.Nama"))
        result.Add(item)
      End If
    Next
    Return result
  End Function
  Public Overrides Function HapusData(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)) As Boolean
    Dim item As Persistent.Fusoh_StokMain, pPending As Integer
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim kodeDelete = ""

    pPending = 0
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.Fusoh_StokMain)

        kodeDelete &= ", " & item.Kode
        item.Delete()
      End If
    Next
    session.CommitChanges()
    '======= Simple log
    Try
      If kodeDelete <> "" Then
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Hapus, "Data Transfer Finish Goods ->" & kodeDelete.Substring(1))
        session.CommitChanges()
      End If
    Catch ex As Exception
    End Try

    If pPending > 0 Then
      Utils.Win.MessageBox.Show("Ada beberapa stok awal yang tidak bisa dihapus, dikarenakan sudah terpakai.", "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
    Return True
  End Function
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("BSData.xml"))
  End Sub
  Private Sub btnReset_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReset.ItemClick
    Dim xDataTS As New XPCollection(Of Persistent.Fusoh_StokMain)(session, New BinaryOperator("Sumber", Persistent.SumberDataJenis.TS, BinaryOperatorType.Equal))
    'Dim xDataTS As New XPCollection(Of Persistent.Fusoh_StokMain)(session, New BinaryOperator("Kode", "JKT-TS20060007", BinaryOperatorType.Equal))
    Dim xJali As String = ""
    For pI = 0 To xDataTS.Count - 1
      'MsgBox("No Transaksi :" & xDataTS(pI).Kode )
      'reset nilai TS nya
      xDataTS(pI).Detail(0).Harga = xDataTS(pI).Detail(0).ProduksiDetail.Harga
      xDataTS(pI).Detail(0).TotalHPP = xDataTS(pI).Detail(0).ProduksiDetail.Harga * xDataTS(pI).Detail(0).QtyOut

      xDataTS(pI).Detail(1).Harga = xDataTS(pI).Detail(0).ProduksiDetail.Harga
      xJali = xJali & "Harga TS : " & xDataTS(pI).Detail(0).ProduksiDetail.Harga.ToString("n2") & vbCrLf
      'reset nilai SJ nya..
      Dim xSJ As New XPCollection(Of Persistent.Fusoh_StokDetail)(Me.session, New BinaryOperator("ProduksiDetail.Id", xDataTS(pI).Detail(1).Id, BinaryOperatorType.Equal))
      For pK = 0 To xSJ.Count - 1
        xSJ(pK).Harga = xDataTS(pI).Detail(1).Harga
        xSJ(pK).TotalHPP = xDataTS(pI).Detail(1).Harga * xSJ(pK).QtyOut
        xJali = xJali & "Reset SJ : " & xSJ(pK).Main.Kode & " --> " & xDataTS(pI).Detail(1).Harga.ToString("n2") & vbCrLf
      Next
    Next
    session.CommitTransaction()
    MsgBox("Proses Selesai.")
    'MsgBox(xJali.ToString)
  End Sub
End Class