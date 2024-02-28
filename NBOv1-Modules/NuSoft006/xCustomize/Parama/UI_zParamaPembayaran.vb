Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem
Public Class UI_zParamaPembayaran
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
    toStringFormat = setting.NumericFormatToString
    colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotal.DisplayFormat.FormatString = setting.NumericFormatString
    colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString
    ifSource.FixedFilterCriteria = New DevExpress.Data.Filtering.InOperator("Regional", UserInfo.GetUserRegional(session, NamaDatabase))
    btnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnUnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("CPData.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("CPData.xml"))
    End If
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_zParamaPembayaranDialog
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
    Dim item As Persistent.zParamaPembayaranPiutang, pPending As Integer
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim dtIV As New List(Of Persistent.zParamaInvoicePenjualan)

    pPending = 0
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.zParamaPembayaranPiutang)
        For j = 0 To item.Detail.Count - 1
          dtIV.Add(item.Detail(j).NoInvoice)
        Next
        Dim zdtGL As Persistent.GlMain = session.FindObject(Of Persistent.GlMain)(New BinaryOperator("Id", item.Gl.Id, BinaryOperatorType.Equal))
        If Not zdtGL Is Nothing Then
          zdtGL.Delete()
        End If
        'MsgBox("delete untuk " & item.Kode & " --> " & item.Id)
        item.Delete()
      End If
    Next
    session.CommitChanges()
    'update status transaksi IV
    For i = dtIV.Count - 1 To 0 Step -1
      Dim xpIV As New XPCollection(Of Persistent.zParamaInvoicePenjualan)(session, New BinaryOperator("Id", dtIV(i).Id, BinaryOperatorType.Equal))
      If xpIV.Count > 0 Then
        dtIV(i).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
      Else
        dtIV(i).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
      End If
    Next
    session.CommitChanges()
    Return True
  End Function
  'Overrides Function GetToolTipContent(view As DevExpress.XtraGrid.Views.Grid.GridView, info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
  '  Dim item As Persistent.zParamaPembayaranPiutang
  '  Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
  '  Dim result As String = ""
  '  Dim xSpace As String, NoInvoice As String, Tanggal As String, Jumlah As String ', Harga As String
  '  Dim num As Integer, xKeterangan As String, xJumlah As String

  '  Try
  '    proxy = CType(view.GetRow(info.RowHandle), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
  '    item = CType(proxy.OriginalRow, Persistent.zParamaPembayaranPiutang)

  '    Dim a = From p In item.Detail

  '    For i = 0 To a.Count - 1
  '      NoInvoice = a(i).NoInvoice.Kode
  '      Tanggal = a(i).NoInvoice.Tanggal.ToString
  '      Jumlah = a(i).NilaiBayar.ToString(toStringFormat)
  '      num = (NoInvoice.Length + Tanggal.Length + Jumlah.Length + 3)
  '      If num >= 80 Then
  '        xSpace = " "
  '      Else
  '        xSpace = Space(80 - num)
  '      End If

  '      result += NoInvoice & " (" & Tanggal & ")" & xSpace & Jumlah
  '      If i <> a.Count - 1 Then
  '        result += vbCrLf
  '      End If
  '    Next
  '    result += vbCrLf
  '    result += vbCrLf

  '    xKeterangan = "Total Trans : "
  '    xJumlah = item.Detail.Sum(Function(m) m.NilaiBayar).ToString(toStringFormat)
  '    num = (xKeterangan.Length + xJumlah.Length)
  '    xSpace = Space(80 - num)
  '    result += xKeterangan & xSpace & xJumlah & vbCrLf
  '    Return result
  '  Catch ex As Exception
  '    Return ""
  '  End Try
  'End Function
  'Overrides Function GetToolTipTitle(view As DevExpress.XtraGrid.Views.Grid.GridView, info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
  '  Return view.GetRowCellDisplayText(info.RowHandle, colKode)
  'End Function
  Private Sub btnCetak_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCetak.ItemClick
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
      Dim item As Persistent.zParamaPembayaranPiutang
      Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

      proxy = CType(xGridView.GetRow(note(0).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      item = CType(proxy.OriginalRow, Persistent.zParamaPembayaranPiutang)

      Dim frm As New RF_zDataDataTransaksiParama(Persistent.SumberDataJenis.CP)
      Dim salesSetting As New Logic.SalesSetting(session)
      frm.txtNoBukti1.EditValue = item.Kode

      Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & item.Kode & " ?"
      Dim reportCode As String = ""
      reportCode = MainClass.GetReport(MainClass.reportName.zVoucherParamaCP)
      message = String.Format(message, "Penerimaan Pembayaran Piutang")
      Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, salesSetting.PreviewSave)
    End If
  End Sub
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("CPData.xml"))
  End Sub
End Class