Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem

Public Class UI_FusohPembayaran
	Private toStringFormat As String
	Dim setting As NuSoft001.Logic.FinaSetting

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
		setting = New NuSoft001.Logic.FinaSetting(session)
		Dim CreateCriteria As CriteriaOperator
		toStringFormat = setting.NumericFormatToString
		colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colTotal.DisplayFormat.FormatString = setting.NumericFormatString
		colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString
		CreateCriteria = GroupOperator.And(New BinaryOperator("Sumber", Persistent.SumberDataJenis.VP, BinaryOperatorType.Equal), New InOperator("Regional", UserInfo.GetUserRegional(session, NamaDatabase)))
		ifSource.FixedFilterCriteria = CreateCriteria
		btnClosing.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
		btnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
		btnUnposting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("VPData.xml")) = True Then
			xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("VPData.xml"))
		End If
	End Sub
	Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
		Return New UI_FusohPembayaranDialog
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
		Dim item As Persistent.Fusoh_PembayaranHutang, pPending As Integer
		Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
		Dim dtInvoice As New List(Of Persistent.Fusoh_PenerimaanInvoice)
    Dim kodeDelete = ""

    pPending = 0
		For i = 0 To selectedData.Count - 1
			If Not xGridView.IsGroupRow(selectedData(i).Row) Then
				proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
				item = CType(proxy.OriginalRow, Persistent.Fusoh_PembayaranHutang)
				If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
					For j = 0 To item.Detail.Count - 1
						dtInvoice.Add(item.Detail(j).NoInvoice)
					Next
          'Dim zdtGL As Persistent.GlMain = session.FindObject(Of Persistent.GlMain)(New BinaryOperator("Id", item.Gl.Id, BinaryOperatorType.Equal))
          'If Not zdtGL Is Nothing Then
          '	zdtGL.Delete()
          'End If
          kodeDelete &= ", " & item.Kode
          item.Delete()
        Else
					pPending += 1
				End If
			End If
		Next
		session.CommitChanges()
    '======= Simple log
    Try
      If kodeDelete <> "" Then
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Hapus, "Data Pembayaran Hutang [VP] ->" & kodeDelete.Substring(1))
        session.CommitChanges()
      End If
    Catch ex As Exception
    End Try

    ''update status transaksi IV
    Dim mustUpdate As Boolean = True 'False
		For i = dtInvoice.Count - 1 To 0 Step -1
			'If dtInvoice(i).NoExim Is Nothing Then
			'	mustUpdate = True
			'ElseIf dtInvoice(I).NoExim.PO.DariDomestik Then
			'	mustUpdate = True
			'End If

			If mustUpdate Then
				Dim inv = dtInvoice(i)
				Dim dataBayar = New XPQuery(Of Persistent.Fusoh_PembayaranHutangDetail)(session).Where(Function(w) w.NoInvoice Is inv)
				If dataBayar.Count > 0 Then
					dtInvoice(i).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
				Else
					dtInvoice(i).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
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
		Dim item As Persistent.Fusoh_PembayaranHutang
		Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
		Dim result As String = ""
		Dim xSpace As String, NoInvoice As String, Tanggal As String, Jumlah As String ', Harga As String
		Dim num As Integer, xKeterangan As String, xJumlah As String

		Try
			proxy = CType(view.GetRow(info.RowHandle), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
			item = CType(proxy.OriginalRow, Persistent.Fusoh_PembayaranHutang)

			Dim a = From p In item.Detail

			For i = 0 To a.Count - 1
				NoInvoice = a(i).NoInvoice.Kode
				Tanggal = a(i).NoInvoice.Tanggal.ToShortDateString
				Jumlah = a(i).NilaiBayar.ToString(toStringFormat)
				num = (NoInvoice.Length + Tanggal.Length + Jumlah.Length + 3)
				If num >= 80 Then
					xSpace = " "
				Else
					xSpace = Space(80 - num)
				End If

				result += NoInvoice & " (" & Tanggal & ")" & xSpace & Jumlah
				If i <> a.Count - 1 Then
					result += vbCrLf
				End If
			Next
			result += vbCrLf
			result += vbCrLf

			xKeterangan = "Total Trans : "
			xJumlah = item.Detail.Sum(Function(m) m.NilaiBayar).ToString(toStringFormat)
			num = (xKeterangan.Length + xJumlah.Length)
			xSpace = Space(80 - num)
			result += xKeterangan & xSpace & xJumlah & vbCrLf
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
			If Utils.Win.MessageBox.Show(xText, "Update Status " & Me.Text, "", Utils.Win.MessageBox.Button.YaTidak, Utils.Win.MessageBox.Icon.Pertanyaan) = Utils.Win.MessageBox.DialogResult.Ya Then
				setstatus(note, e.Item.Tag)
				RefreshData()
			End If
		End If
	End Sub
	Sub setstatus(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData), xTipe As String)
		Dim item As Persistent.Fusoh_PembayaranHutang, xGagal As Integer, xMessage As String
		Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
		xGagal = 0
		xMessage = ""
    Dim kodeStatus = ""

    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.Fusoh_PembayaranHutang)
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
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Pembayaran Hutang [VP] " & xTipe & " ->" & kodeStatus.Substring(1))
        session.CommitChanges()
      End If
    Catch ex As Exception
    End Try

    If xGagal > 0 Then
      Utils.Win.MessageBox.Show(xMessage.ToString, "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
  End Sub
	Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
		xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("VPData.xml"))
	End Sub

  Private Sub btnShowLog_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowLog.ItemClick
    If xGridView.IsDataRow(xGridView.FocusedRowHandle) Then
      Dim frm As New Log_FusohData
      frm.session = session
      frm.TipeData = Persistent.SumberDataJenis.VP
      Dim proxy = CType(xGridView.GetFocusedRow(), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      Dim item = CType(proxy.OriginalRow, Persistent.Fusoh_PembayaranHutang)
      frm.Kode = item.Kode
      frm.ShowDialog()
    End If
  End Sub
End Class