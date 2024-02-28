Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Controls
Imports NuSoft.Core.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent

Public Class UI_FusohDailyProsesWIP
  Sub New()
    InitializeComponent()
    baseView = xGridView
    KeyField = "Id"
    useMDIforDialog = False
    useFeedbackSource = True
    ActivateToolTip = False
    UseDbSystem = False
    'allowAdd = False
    'allowDelete = False

    colJamKerja.Caption = "Jam" & vbCrLf & "Kerja"
    colQtyDempyou.Caption = "Qty" & vbCrLf & "Dempyou"
    colQtyOP1.Caption = "Qty" & vbCrLf & "OP 1"
    colQtyOP2.Caption = "Qty" & vbCrLf & "OP 2"
    colQtyOP3.Caption = "Qty" & vbCrLf & "OP 3"
    colQtyOP4.Caption = "Qty" & vbCrLf & "OP 4"
    colQtyOP5.Caption = "Qty" & vbCrLf & "OP 5"
    colQtyFinishGood.Caption = "Finish" & vbCrLf & "Good"
    colWaktuStopLine.Caption = "Waktu" & vbCrLf & "Stopline"
		colProduksi.Caption = "Kode" & vbCrLf & "Produksi"
	End Sub
  Overrides Sub FirstLoad()
    GetSession()
    btnUpdate.Visibility = BarItemVisibility.Never
    btnClosing.Enabled = False
    btnPosting.Enabled = User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnUnposting.Enabled = User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_FusohDailyProsesWIPDialog
  End Function

  Overrides Function GetKeteranganHapus(selectedRows() As Integer) As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
    Dim result As New List(Of Core.Win.Forms.GridDeletedData)
    Dim item As Core.Win.Forms.GridDeletedData

    For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
      If Not xGridView.IsGroupRow(selectedRows(i)) Then
        item = New Core.Win.Forms.GridDeletedData
        item.Row = selectedRows(i)
        item.Data = xGridView.GetRowCellValue(selectedRows(i), "CuttingWIP.Kode").ToString
        result.Add(item)
      End If
    Next
    Return result
  End Function
  Public Overrides Function HapusData(selectedData As List(Of Core.Win.Forms.GridDeletedData)) As Boolean
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim listDeleteData As New List(Of Fusoh_DailyProcess)

    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        listDeleteData.Add(CType(proxy.OriginalRow, Fusoh_DailyProcess))
      End If
    Next

    Try
      Services.TransaksiDailyProcess.DeleteData(session, listDeleteData)
    Catch ex As Exception
      Utils.Win.MessageBox.Show(ex.Message, "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End Try
    Return True
  End Function

  Private Sub btnPosting_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnPosting.ItemClick, btnUnposting.ItemClick, btnClosing.ItemClick
    Dim xText As String = String.Format("Apakah anda ingin {0} {1} ?", e.Item.Tag, Me.Text)
    Dim x As Integer() = Nothing
    If allowEdit = False Then
      Utils.Win.MessageBox.Show("Anda tidak mendapatkan hak akses untuk merubah transaksi", "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
      Exit Sub
    End If

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

    For i = 0 To note.Count - 1
      xText &= vbCrLf & note(i).Data
    Next

    If Len(xText) > 0 Then
      If Utils.Win.MessageBox.Show(xText, "Update Status " & Me.Text, "", Utils.Win.MessageBox.Button.YaTidak, Utils.Win.MessageBox.Icon.Pertanyaan) = Utils.Win.MessageBox.DialogResult.Ya Then
        SetStatus(note, e.Item.Tag.ToString)
        RefreshData()
      End If
    End If
  End Sub
  Sub SetStatus(selectedData As List(Of Core.Win.Forms.GridDeletedData), xTipe As String)
    Dim item As Fusoh_DailyProcess, xGagal As Integer, xMessage As String
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    xGagal = 0
    xMessage = ""
    Dim kodeStatus = ""

    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Fusoh_DailyProcess)
        If xTipe = "memposting" Then
          xMessage = "Hanya transaksi pending yang bisa dirubah statusnya menjadi posting."
          If item.CuttingWIP.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
            kodeStatus &= ", " & item.CuttingWIP.Kode
            item.CuttingWIP.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
          Else
            xGagal += 1
          End If
        ElseIf xTipe = "mengunposting" Then
          xMessage = "Hanya transaksi posting yang bisa dirubah statusnya menjadi pending."
          If item.CuttingWIP.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting Then
            kodeStatus &= ", " & item.CuttingWIP.Kode
            item.CuttingWIP.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending
          Else
            xGagal += 1
          End If
        ElseIf xTipe = "mengclosing" Then
          xMessage = "Transaksi yang sudah selesai tidak dapat diclose."
          If Not item.CuttingWIP.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish Or item.CuttingWIP.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Rejected Then
            kodeStatus &= ", " & item.CuttingWIP.Kode
            item.CuttingWIP.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Closed
          Else
            xGagal += 1
          End If
        End If
      End If
    Next
    session.CommitChanges()
    '======= Simple log
    Try
      If kodeStatus <> "" Then
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Daily Process WIP " & xTipe & " ->" & kodeStatus.Substring(1))
        session.CommitChanges()
      End If
    Catch ex As Exception
    End Try

    If xGagal > 0 Then
      Utils.Win.MessageBox.Show(xMessage.ToString, "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
  End Sub

	Private Sub btnCekStock_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCekStock.ItemClick
    If Not xGridView.DataSource Is Nothing Then
      Dim xID As Long = CType(xGridView.GetFocusedRowCellDisplayText(colId), Long)
      Dim xDP As Persistent.Fusoh_DailyProcess = session.GetObjectByKey(Of Persistent.Fusoh_DailyProcess)(Convert.ToInt64(xID))
      'dt.OrderProduksi.SODetail.Barang.Kode
      Dim DataTransaksi As New XPCollection(Of Persistent.Fusoh_StokDetail)(session, New BinaryOperator("Barang.Kode", xDP.CuttingWIP.OrderProduksi.SODetail.Barang.Kode, BinaryOperatorType.Equal))
      Dim Stock As Double = DataTransaksi.Sum(Function(f) f.QtyIn - f.QtyOut)

      MsgBox("Stock FG [" & xDP.CuttingWIP.OrderProduksi.SODetail.Barang.Kode & "] : " & Stock)
    End If

  End Sub
End Class