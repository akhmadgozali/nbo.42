﻿Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem
Public Class UI_SanYuPengirimanBarang
  Private toStringFormat As String
  Sub New()
    InitializeComponent()

    baseView = xGridView
    KeyField = "Id"
    useMDIforDialog = True
    useFeedbackSource = True
    ActivateToolTip = True
    UseDbSystem = False
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
    Dim setting As New NuSoft001.Logic.FinaSetting(Session)
    Dim CreateCriteria As CriteriaOperator
    toStringFormat = setting.NumericFormatToString
    CreateCriteria = GroupOperator.And(New BinaryOperator("Sumber", Persistent.SumberDataJenis.SJ, BinaryOperatorType.Equal), New InOperator("Regional", UserInfo.GetUserRegional(Session, NamaDatabase)))
    ifSource.FixedFilterCriteria = CreateCriteria

    btnClosing.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnUnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SJData.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SJData.xml"))
    End If
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_SanYuPengirimanBarangDialog
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
    Dim item As Persistent.SanYu_PengirimanBarang, pPending As Integer
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim dtSO As New List(Of Persistent.SanYu_OrderPenjualan)

    pPending = 0
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.SanYu_PengirimanBarang)
        If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
          dtSO.Add(item.OrderPenjualan)
          Logic.Umum.SaveLog(session, Persistent.TipeLOG.Delete, "Admin", "Pengiriman Penjualan : Hapus " & item.Kode)
          item.Delete()
        Else
          pPending += 1
        End If
      End If
    Next
    Session.CommitChanges()

    'update status transaksi SO
    'For i = dtSO.Count - 1 To 0 Step -1
    '  Dim xpSJ As New XPCollection(Of Persistent.PengirimanBarang)(Session, New BinaryOperator("NoOrder.Id", dtSO(i).Id, BinaryOperatorType.Equal))
    '  If xpSJ.Count > 0 Then
    '    dtSO(i).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
    '  Else
    '    dtSO(i).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
    '  End If
    'Next
    Session.CommitChanges()

    If pPending > 0 Then
      Utils.Win.MessageBox.Show("Transaksi selain status pending tidak dapat dihapus.", "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
    Return True
  End Function
  Overrides Function GetToolTipContent(view As DevExpress.XtraGrid.Views.Grid.GridView, info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
    'Dim item As Persistent.SanYu_PengirimanBarang
    'Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    'Dim result As String = ""
    'Dim xSpace As String, KodeBarang As String, NamaBarang As String, Qty As String ', Harga As String
    'Dim num As Integer

    'Try
    '  proxy = CType(view.GetRow(info.RowHandle), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
    '  item = CType(proxy.OriginalRow, Persistent.SanYu_PengirimanBarang)

    '  Dim a = From p In item.Detail

    '  For i = 0 To a.Count - 1
    '    KodeBarang = a(i).Barang.Kode
    '    NamaBarang = a(i).Barang.Nama
    '    Qty = a(i).Qty.ToString(toStringFormat) & " (" & a(i).Satuan.Kode & ")"
    '    num = (KodeBarang.Length + NamaBarang.Length + Qty.Length + 3)
    '    If num >= 80 Then
    '      xSpace = " "
    '    Else
    '      xSpace = Space(80 - num)
    '    End If

    '    result += KodeBarang & " (" & NamaBarang & ")" & xSpace & Qty
    '    If i <> a.Count - 1 Then
    '      result += vbCrLf
    '    End If
    '  Next
    '  result += vbCrLf
    '  result += vbCrLf

    '  Return result
    'Catch ex As Exception
    '  Return ""
    'End Try
    Return ""
  End Function
  Overrides Function GetToolTipTitle(view As DevExpress.XtraGrid.Views.Grid.GridView, info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
    Return view.GetRowCellDisplayText(info.RowHandle, colKode)
  End Function
  Private Sub btnPosting_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPosting.ItemClick, btnUnPosting.ItemClick, btnClosing.ItemClick
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
        setstatus(note, e.Item.Tag)
        RefreshData()
      End If
    End If
  End Sub
  Sub setstatus(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData), xTipe As String)
    Dim item As Persistent.SanYu_PengirimanBarang, xGagal As Integer, xMessage As String
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    xGagal = 0
    xMessage = ""
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.SanYu_PengirimanBarang)
        If xTipe = "memposting" Then
          xMessage = "Hanya transaksi pending yang bisa dirubah statusnya menjadi posting."
          If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
            Logic.Umum.SaveLog(session, Persistent.TipeLOG.Edit, "Admin", "Pengiriman Penjualan : Posting " & item.Kode)
            item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
          Else
            xGagal += 1
          End If
        ElseIf xTipe = "mengunposting" Then
          xMessage = "Hanya transaksi posting yang bisa dirubah statusnya menjadi pending."
          If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting Then
            Logic.Umum.SaveLog(session, Persistent.TipeLOG.Edit, "Admin", "Pengiriman Penjualan : Pending " & item.Kode)
            item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending
          Else
            xGagal += 1
          End If
        ElseIf xTipe = "mengclosing" Then
          xMessage = "Transaksi yang sudah selesai tidak dapat diclose."
          If Not item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish Or item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Rejected Then
            Logic.Umum.SaveLog(session, Persistent.TipeLOG.Edit, "Admin", "Pengiriman Penjualan : Closing " & item.Kode)
            item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Closed
          Else
            xGagal += 1
          End If
        End If
      End If
    Next
    Session.CommitChanges()
    If xGagal > 0 Then
      Utils.Win.MessageBox.Show(xMessage.ToString, "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
  End Sub
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("SJData.xml"))
  End Sub
  Private Sub btnCetak_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCetak.ItemClick, btnCetak2.ItemClick
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
      Dim item As Persistent.SanYu_PengirimanBarang
      Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

      proxy = CType(xGridView.GetRow(note(0).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      item = CType(proxy.OriginalRow, Persistent.SanYu_PengirimanBarang)

      Dim frm As New RF_SanyuVoucher(Persistent.SumberDataJenis.SJ, MainClass.reportName.zSanyuVoucherPackingList)
      If e.Item.Caption = "Voucher Packing List Detail" Then
        frm = New RF_SanyuVoucher(Persistent.SumberDataJenis.SJ, MainClass.reportName.zSanyuVoucherPackingListDetail)
      Else
        frm = New RF_SanyuVoucher(Persistent.SumberDataJenis.SJ, MainClass.reportName.zSanyuVoucherPackingList)
      End If


      Dim salesSetting As New Logic.SalesSetting(session)
      frm.txtNoBukti1.EditValue = item.Kode

      Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & item.Kode & " ?"
      Dim reportCode As String = ""
      If e.Item.Caption = "Voucher Packing List Detail" Then
        reportCode = MainClass.GetReport(MainClass.reportName.zSanyuVoucherPackingListDetail)
      Else
        reportCode = MainClass.GetReport(MainClass.reportName.zSanyuVoucherPackingList)
      End If
      message = String.Format(message, "Pengiriman Barang")
      Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, salesSetting.PreviewSave)
    End If
  End Sub

  Private Sub btnHistory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHistory.ItemClick
    'Dim xNoTransaksi As String = xGridView.GetFocusedRowCellDisplayText(colKode)
    'If Not xNoTransaksi Is Nothing Then
    '  Logic.Umum.xHistoryData(Me, Session, UI_CekData.TipeTransaksi.SJ, xNoTransaksi)
    'End If
  End Sub
End Class