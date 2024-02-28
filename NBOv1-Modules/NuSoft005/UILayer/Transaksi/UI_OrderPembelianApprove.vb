Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem
Public Class UI_OrderPembelianApprove
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
    allowDelete = False
    allowEdit = True
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
    Dim setting As New NuSoft001.Logic.FinaSetting(session)
    toStringFormat = setting.NumericFormatToString
    colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotal.DisplayFormat.FormatString = setting.NumericFormatString
    colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString
    btnClosing.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnUnposting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("PODataApprove.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("PODataApprove.xml"))
    End If
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_OrderPembelianDialog
  End Function
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("PODataApprove.xml"))
  End Sub
  Private Sub cmdApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdApprove.ItemClick
    Dim xID As Int64 = xGridView.GetFocusedRowCellDisplayText(colId)
    Dim a As New UI_OrderPembelianApproveDialog(True, xID)
    a.session = Me.session
    a.ShowDialog()
  End Sub
  Private Sub cmdReject_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdReject.ItemClick
    Dim xID As Int64 = xGridView.GetFocusedRowCellDisplayText(colId)
    Dim a As New UI_OrderPembelianApproveDialog(False, xID)
    a.session = Me.session
    a.ShowDialog()
  End Sub
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
  Private Sub btnCetakApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCetakApprove.ItemClick
    Dim x As Integer() = Nothing

    If baseView.RowCount < 1 Then
      Exit Sub
    End If

    If TypeOf (baseView) Is DevExpress.XtraGrid.Views.Grid.GridView Then
      Dim viewGrid As DevExpress.XtraGrid.Views.Grid.GridView = CType(baseView, DevExpress.XtraGrid.Views.Grid.GridView)
      If viewGrid.IsGroupRow(viewGrid.FocusedRowHandle) Then
        Exit Sub
      End If
      x = viewGrid.GetSelectedRows
    ElseIf TypeOf (baseView) Is DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView Then
      Dim viewGrid As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = CType(baseView, DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)
      If viewGrid.IsGroupRow(viewGrid.FocusedRowHandle) Then
        Exit Sub
      End If
      x = viewGrid.GetSelectedRows
    End If

    Dim note As List(Of NuSoft.Core.Win.Forms.GridDeletedData) = GetKeteranganHapus(x)
    If note Is Nothing Then
      Utils.Win.MessageBox.Show("Masukkan keterangan data yang akan dihapus", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      Exit Sub
    End If

    If note.Count > 0 Then
      Dim item As Persistent.OrderPembelian
      Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

      proxy = CType(xGridView.GetRow(note(0).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      item = CType(proxy.OriginalRow, Persistent.OrderPembelian)

      Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.PO)
      frm.txtNoBukti1.EditValue = item.Kode

      Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & item.Kode & " ?"
      Dim reportCode As String = ""
      message = String.Format(message, "Order Pembelian")
      reportCode = MainClass.GetReport(MainClass.reportName.VoucherOrderPembelianApprove)

      Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
    End If
  End Sub
End Class