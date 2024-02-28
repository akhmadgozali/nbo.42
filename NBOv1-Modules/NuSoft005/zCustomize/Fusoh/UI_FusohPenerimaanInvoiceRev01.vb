﻿Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraBars

Public Class UI_FusohPenerimaanInvoiceRev01
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
    Dim Setting As New NuSoft001.Logic.FinaSetting(GetSession)
    Dim CreateCriteria As CriteriaOperator
    toStringFormat = Setting.NumericFormatToString
    colTotalRp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotalRp.DisplayFormat.FormatString = Setting.NumericFormatString
		colTotalRp.SummaryItem.DisplayFormat = Setting.NumericFormatString
		Dim listSumber = New List(Of Persistent.SumberDataJenis)
		listSumber.Add(Persistent.SumberDataJenis.RI)
		listSumber.Add(Persistent.SumberDataJenis.IMV)

		'CreateCriteria = GroupOperator.And(New InOperator("Main.Sumber", listSumber), New InOperator("Regional", UserInfo.GetUserRegional(session, NamaDatabase)))
		'MsgBox("Filter:" & CreateCriteria.ToString)
		CreateCriteria = GroupOperator.Or(New BinaryOperator("Sumber", Persistent.SumberDataJenis.RI, BinaryOperatorType.Equal), New BinaryOperator("Sumber", Persistent.SumberDataJenis.IMV, BinaryOperatorType.Equal))
		ifSource.FixedFilterCriteria = CreateCriteria
		btnClosing.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnUnposting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("RIData.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("RIData.xml"))
    End If
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_FusohPenerimaanInvoiceDialogRev01
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
    Dim item As Persistent.Fusoh_PenerimaanInvoice, pPending As Integer
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim kodeDelete = ""
    Dim listPO = New List(Of Persistent.Fusoh_OrderPembelian)
    Dim kodeLocked = ""

    pPending = 0
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.Fusoh_PenerimaanInvoice)

        Try
          Fusoh_Logic.Periode.CekTanggalLocked(session, item.Tanggal)
        Catch ex As Exception
          kodeLocked &= ", " & item.Kode
          Continue For
        End Try

        If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
          kodeDelete &= ", " & item.Kode

          If item.Vendor.KontakDomestik Then
            If item.NoExim Is Nothing Then
              If Not item.NoOrder Is Nothing Then
                '=============== update status po
                Dim xpRI = New XPQuery(Of Persistent.Fusoh_PenerimaanInvoice)(session).Where(Function(w) w.NoOrder Is item.NoOrder AndAlso Not w Is item)
                If xpRI.Count > 0 Then
                  item.NoOrder.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
                Else
                  item.NoOrder.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
                End If
              End If
            Else
              Dim xpRI = New XPQuery(Of Persistent.Fusoh_PenerimaanInvoice)(session).Where(Function(w) w.NoExim Is item.NoExim AndAlso Not w Is item)
              Dim status As NuSoft001.Persistent.StatusTransaksiEnum
              If xpRI.Count > 0 Then
                status = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
              Else
                status = NuSoft001.Persistent.StatusTransaksiEnum.Posting
              End If

              Dim findAll = New XPQuery(Of Persistent.Fusoh_PenerimaanBarang)(session).Where(Function(w) w.Exim Is item.NoExim)
              For Each x In findAll
                x.StatusTransaksi = status
              Next
            End If
          Else
            listPO.AddRange(Service_Fusoh.Service_FusohInvoice.GetDaftarPODariInvoice(item))
          End If

          item.Delete()
        Else
          pPending += 1
        End If
      End If
    Next
    session.CommitChanges()

    '======= Update status PO NON DOMESTIK
    If listPO.Count > 0 Then
      Service_Fusoh.Service_FusohPO.ResetStatusPO(session, listPO.GroupBy(Function(g) g).Select(Function(s) s.Key).ToList)
    End If

    '======= Simple log
    Try
      If kodeDelete <> "" Then
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Hapus, "Data Penerimaan Invoice [RI] ->" & kodeDelete.Substring(1))
        session.CommitChanges()
      End If
    Catch ex As Exception
    End Try

    If pPending > 0 Then
      Utils.Win.MessageBox.Show("Transaksi selain status pending tidak dapat dihapus.", "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
    If kodeLocked <> "" Then
      Utils.Win.MessageBox.Show("Transaksi tidak dapat dihapus karena periode nya sudah terkunci." & vbCrLf & kodeLocked.Substring(2), "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If

    Return True
  End Function

  Overrides Function GetToolTipContent(view As DevExpress.XtraGrid.Views.Grid.GridView, info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
    Dim item As Persistent.Fusoh_PenerimaanInvoice
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim result As String = ""
    Dim xSpace As String, KodeBarang As String, NamaBarang As String, Qty As String ', Harga As String
    Dim num As Integer

    Try
      proxy = CType(view.GetRow(info.RowHandle), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      item = CType(proxy.OriginalRow, Persistent.Fusoh_PenerimaanInvoice)

      Dim a = From p In item.Detail

      For i = 0 To a.Count - 1
        KodeBarang = a(i).Barang.Kode
        NamaBarang = a(i).Barang.Nama
        Qty = a(i).Qty.ToString(toStringFormat) & " (" & a(i).Satuan.Kode & ")"
        num = (KodeBarang.Length + NamaBarang.Length + Qty.Length + 3)
        If num >= 80 Then
          xSpace = " "
        Else
          xSpace = Space(80 - num)
        End If

        result += KodeBarang & " (" & NamaBarang & ")" & xSpace & Qty
        If i <> a.Count - 1 Then
          result += vbCrLf
        End If
      Next
      result += vbCrLf
      result += vbCrLf

      Return result
    Catch ex As Exception
      Return ""
    End Try
  End Function
  Overrides Function GetToolTipTitle(view As DevExpress.XtraGrid.Views.Grid.GridView, info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
    Return view.GetRowCellDisplayText(info.RowHandle, colKode)
  End Function
  Private Sub btnPosting_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPosting.ItemClick, btnUnposting.ItemClick, btnClosing.ItemClick
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
      If Global.NuSoft.Utils.Win.MessageBox.Show(xText, "Update Status " & Me.Text, "", Global.NuSoft.Utils.Win.MessageBox.Button.YaTidak, Global.NuSoft.Utils.Win.MessageBox.Icon.Pertanyaan) = Global.NuSoft.Utils.Win.MessageBox.DialogResult.Ya Then
        setstatus(note, e.Item.Tag)
        RefreshData()
      End If
    End If
  End Sub
  Sub setstatus(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData), xTipe As String)
    Dim item As Persistent.Fusoh_PenerimaanInvoice, xGagal As Integer, xMessage As String
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    xGagal = 0
    xMessage = ""
    Dim kodeStatus = ""
    Dim kodeLocked = ""

    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.Fusoh_PenerimaanInvoice)

        Try
          Fusoh_Logic.Periode.CekTanggalLocked(session, item.Tanggal)
        Catch ex As Exception
          kodeLocked &= ", " & item.Kode
          Continue For
        End Try

        If xTipe = "memposting" Then
          xMessage = "Hanya transaksi pending yang bisa dirubah statusnya menjadi posting."
          If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
            kodeStatus &= ", " & item.Kode
            item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
          Else
            xGagal += 1
          End If
        ElseIf xTipe = "mengunposting" Then
          xMessage = "Hanya transaksi posting yang bisa dirubah statusnya menjadi pending."
          If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting Then
            kodeStatus &= ", " & item.Kode
            item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending
          Else
            xGagal += 1
          End If
        ElseIf xTipe = "mengclosing" Then
          xMessage = "Transaksi yang sudah selesai tidak dapat diclose."
          If Not item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish Or item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Rejected Then
            kodeStatus &= ", " & item.Kode
            item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Closed
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
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Penerimaan Invoice [RI] " & xTipe & " ->" & kodeStatus.Substring(1))
        session.CommitChanges()
      End If
    Catch ex As Exception
    End Try

    If xGagal > 0 Then
      Utils.Win.MessageBox.Show(xMessage.ToString, "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
    If kodeLocked <> "" Then
      Utils.Win.MessageBox.Show("Proses tidak bisa dilakukan karena periode nya sudah terkunci." & vbCrLf & kodeLocked.Substring(2), "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
  End Sub
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("RIData.xml"))
  End Sub

  Private Sub barCetakCostSheet_ItemClick(sender As Object, e As ItemClickEventArgs) Handles barCetakCostSheet.ItemClick
    If xGridView.IsGroupRow(xGridView.FocusedRowHandle) Then Exit Sub
    If xGridView.IsFilterRow(xGridView.FocusedRowHandle) Then Exit Sub

    Dim item As Persistent.Fusoh_PenerimaanInvoice
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

    proxy = CType(xGridView.GetFocusedRow, ReadonlyThreadSafeProxyForObjectFromAnotherThread)
    item = CType(proxy.OriginalRow, Persistent.Fusoh_PenerimaanInvoice)

    Dim frm As New RF_FusohVoucherBaru(MainClass.reportName.zFusohVoucherCostSheetActualRate)
    frm.txtNoBukti1.EditValue = item.Kode

    Dim message As String = "Apakah anda ingin mencetak cost sheet dengan nomor " & item.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.zFusohVoucherCostSheetActualRate)

    Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
  End Sub

  Private Sub btnCekHistory_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCekHistory.ItemClick
    Dim xNoTransaksi As String = xGridView.GetFocusedRowCellDisplayText(colKode)
    If Not xNoTransaksi Is Nothing Then
      Fusoh_Logic.Umum.xHistoryData(Me, session, UI_FusohCekData.TipeTransaksi.RI, xNoTransaksi)
    End If
  End Sub

  Private Sub btnShowLog_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnShowLog.ItemClick
    If xGridView.IsDataRow(xGridView.FocusedRowHandle) Then
      Dim frm As New Log_FusohData
      frm.session = session
      frm.TipeData = Persistent.SumberDataJenis.RI
      Dim proxy = CType(xGridView.GetFocusedRow(), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      Dim item = CType(proxy.OriginalRow, Persistent.Fusoh_PenerimaanInvoice)
      frm.Kode = item.Kode
      frm.ShowDialog()
    End If
  End Sub
	Private Sub btnResetWeight_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnResetWeight.ItemClick
		Dim xDataInvoiceDetail As New XPCollection(Of Persistent.Fusoh_PenerimaanInvoiceDetail)(session, New BinaryOperator("WeightManual", BinaryOperatorType.Equal, 0))
		For pi = 0 To xDataInvoiceDetail.Count - 1
			xDataInvoiceDetail(pi).WeightManual = xDataInvoiceDetail(pi).Weight
		Next
		session.CommitChanges()
		MsgBox("Sukses.")
	End Sub
End Class