﻿Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem
Public Class UI_PemakaianStock
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
    Dim setting As New NuSoft001.Logic.FinaSetting(session)
    Dim CreateCriteria As CriteriaOperator
    CreateCriteria = GroupOperator.And(New BinaryOperator("Sumber", Persistent.SumberDataJenis.CS, BinaryOperatorType.Equal), New InOperator("Regional", UserInfo.GetUserRegional(session, NamaDatabase)))
    ifSource.FixedFilterCriteria = CreateCriteria
    colTotalHPP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotalHPP.DisplayFormat.FormatString = setting.NumericFormatString
    colTotalHPP.SummaryItem.DisplayFormat = setting.NumericFormatString
    toStringFormat = setting.NumericFormatToString
    btnClosing.Enabled = False
    btnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnUnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("CSData.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("CSData.xml"))
    End If

  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_PemakaianStockDialog
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
    Dim item As Persistent.StockMain, pPending As Integer
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

    pPending = 0
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.StockMain)
        If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
          Dim zdtGL As Persistent.GlMain = session.FindObject(Of Persistent.GlMain)(New BinaryOperator("Id", item.Gl.Id, BinaryOperatorType.Equal))
          If Not zdtGL Is Nothing Then
            zdtGL.Delete()
          End If
          item.Delete()
        Else
          pPending += 1
        End If
      End If
    Next
    session.CommitChanges()
    If pPending > 0 Then
      Utils.Win.MessageBox.Show("Transaksi selain status pending tidak dapat dihapus.", "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
    Return True
  End Function
  Overrides Function GetToolTipContent(view As DevExpress.XtraGrid.Views.Grid.GridView, info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
    Dim item As Persistent.StockMain
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim result As String = ""
    Dim xSpace As String, KodeBarang As String, NamaBarang As String, Qty As String ', Harga As String
    Dim num As Integer

    Try
      proxy = CType(view.GetRow(info.RowHandle), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      item = CType(proxy.OriginalRow, Persistent.StockMain)

      Dim a = From p In item.Detail

      For i = 0 To a.Count - 1
        KodeBarang = a(i).Barang.Kode
        NamaBarang = a(i).Barang.Nama
        Qty = a(i).QtyIn.ToString(toStringFormat) & " (" & a(i).Satuan.Kode & ")"
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
    Return view.GetRowCellDisplayText(info.RowHandle, colCode)
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
      If Utils.Win.MessageBox.Show(xText, "Update Status " & Me.Text, "", Utils.Win.MessageBox.Button.YaTidak, Utils.Win.MessageBox.Icon.Pertanyaan) = Utils.Win.MessageBox.DialogResult.Ya Then
        setstatus(note, e.Item.Tag.ToString)
        RefreshData()
      End If
    End If
  End Sub
  Sub setstatus(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData), xTipe As String)
    Dim item As Persistent.StockMain, xGagal As Integer, xMessage As String
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    xGagal = 0
    xMessage = ""
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.StockMain)
        If xTipe = "memposting" Then
          xMessage = "Hanya transaksi pending yang bisa dirubah statusnya menjadi posting."
          If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
            item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
          Else
            xGagal += 1
          End If
        ElseIf xTipe = "mengunposting" Then
          xMessage = "Hanya transaksi posting yang bisa dirubah statusnya menjadi pending."
          If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting Then
            item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending
          Else
            xGagal += 1
          End If
        ElseIf xTipe = "mengclosing" Then
          xMessage = "Transaksi yang sudah selesai tidak dapat diclose."
          If Not item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish Or item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Rejected Then
            item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Closed
          Else
            xGagal += 1
          End If
        End If
      End If
    Next
    session.CommitChanges()
    If xGagal > 0 Then
      Utils.Win.MessageBox.Show(xMessage.ToString, "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
  End Sub
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("CSData.xml"))
  End Sub
  Private Sub btnCetakVoucher_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCetakVoucher.ItemClick
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
      Dim item As Persistent.StockMain
      Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

      proxy = CType(xGridView.GetRow(note(0).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      item = CType(proxy.OriginalRow, Persistent.StockMain)

      Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.CS)
      frm.txtNoBukti1.EditValue = item.Kode

      Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & item.Kode & " ?"
      Dim reportCode As String = ""
      message = String.Format(message, "Pemakaian Barang")
      reportCode = MainClass.GetReport(MainClass.reportName.VoucherPemakaianBarang)

      Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
    End If
  End Sub
End Class