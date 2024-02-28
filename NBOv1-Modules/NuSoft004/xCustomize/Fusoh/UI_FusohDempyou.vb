'Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraBars
Imports DevExpress.XtraSplashScreen
Imports NuSoft.Core.SSystem

Public Class UI_FusohDempyou
  Private toStringFormat As String

  Sub New()
    InitializeComponent()
    baseView = xGridView
    KeyField = "Id"
    useMDIforDialog = True
    useFeedbackSource = False
    ActivateToolTip = True
    UseDbSystem = False
    xGridView.OptionsDetail.EnableMasterViewMode = True
    allowAdd = False
    allowEdit = False
    allowDelete = False
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
    Dim setting As New NuSoft001.Logic.FinaSetting(Session)
    Dim CreateCriteria As CriteriaOperator
    CreateCriteria = GroupOperator.And(New BinaryOperator("Sumber", Persistent.SumberDataJenis.OP, BinaryOperatorType.Equal), New InOperator("Regional", UserInfo.GetUserRegional(Session, NamaDatabase)))
    ifSource.FixedFilterCriteria = CreateCriteria
    toStringFormat = setting.NumericFormatToString
    btnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnUnposting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnClosing.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("OPData.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("OPData.xml"))
    End If
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_FusohOrderProduksiDialog
  End Function
  Overrides Function GetKeteranganHapus(selectedRows() As Integer) As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
    Dim result As New List(Of Core.Win.Forms.GridDeletedData)
    Dim item As Core.Win.Forms.GridDeletedData

    For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
      If xGridView.IsDataRow(selectedRows(i)) Then
        item = New Core.Win.Forms.GridDeletedData
        item.Row = selectedRows(i)
        item.Data = xGridView.GetRowCellValue(selectedRows(i), "Kode").ToString
        result.Add(item)
      End If
    Next
    Return result
  End Function
  Overrides Function HapusData(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)) As Boolean
    Dim item As Persistent.Fusoh_OrderProduksi, pPending As Integer
    'Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim notDeleted As New List(Of Persistent.Fusoh_OrderProduksi)

    pPending = 0
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        'proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        'item = CType(proxy.OriginalRow, Persistent.Fusoh_OrderProduksi)
        item = CType(xGridView.GetRow(selectedData(i).Row), Persistent.Fusoh_OrderProduksi)
        If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
          ''Dim xpDempyou = New XPQuery(Of Persistent.Fusoh_OrderProduksi)(session).Where(Function(w) w.SODetail.Main Is item.SODetail.Main AndAlso Not w Is item)
          ''If xpDempyou.Count = 0 Then
          ''       item.SODetail.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
          ''     Else
          ''       item.SODetail.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
          ''     End If

          If NuSoft001.Persistent.Periode.CheckLockedPeriod(Session, item.Tanggal) Then
            notDeleted.Add(item)
          ElseIf NuSoft001.Persistent.Periode.CheckBeforeBeginningPeriod(Session, item.Tanggal) Then
            notDeleted.Add(item)
          Else
            item.Delete()
          End If
        Else
          pPending += 1
        End If
      End If
    Next
    Session.CommitChanges()
    If pPending > 0 Then
      Utils.Win.MessageBox.Show("Transaksi selain status pending tidak dapat dihapus.", "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
    If notDeleted.Count > 0 Then
      Dim text As String = ""
      For i = 0 To notDeleted.Count - 1
        text &= vbCrLf & notDeleted(i).Kode
      Next
      Utils.Win.MessageBox.Show("Periode yang sudah ditutup tidak dapat dihapus." & vbCrLf & text, "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If

    Return True
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
    Dim item As Persistent.Fusoh_OrderProduksi, xGagal As Integer, xMessage As String
    'Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    xGagal = 0
    xMessage = ""
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        'proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        'item = CType(proxy.OriginalRow, Persistent.Fusoh_OrderProduksi)
        item = CType(xGridView.GetRow(selectedData(i).Row), Persistent.Fusoh_OrderProduksi)
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
          'If Not item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish Or item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Rejected Then
          If Not item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Rejected Then
            item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Closed
            ' ====== cek sisa dempyou yang belum diproduksi ======
            'ClosingDempyou(session, item)
            Services.Fusoh_UpdateStatus.ClosingDempyou(Session, item)
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
  Private Sub btnSaveLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveLayout.ItemClick
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("AMData.xml"))
  End Sub

  Private Sub btnCetakVoucher_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCetakVoucher.ItemClick
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
      Utils.Win.MessageBox.Show("Masukkan keterangan", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      Exit Sub
    End If

    If note.Count > 0 Then
      Dim item As Persistent.Fusoh_OrderProduksi
      'Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

      'proxy = CType(xGridView.GetRow(note(0).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      'item = CType(proxy.OriginalRow, Persistent.Fusoh_OrderProduksi)
      item = CType(xGridView.GetRow(note(0).Row), Persistent.Fusoh_OrderProduksi)


      Dim frm As New RF_FusohVoucher(Persistent.SumberDataJenis.OP)
      Dim xStatusPrinted As Boolean = False
      If MsgBox("Apakah anda ingin merubah status cetak menjadi printed?", vbYesNo, "Konfirmasi") = MsgBoxResult.Yes Then
        xStatusPrinted = True
      End If
      frm.txtNoBukti1.EditValue = item.Kode
      'frm.xSetStatusPrinted = xStatusPrinted

      Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & item.Kode & " ?"
      Dim reportCode As String = ""
      message = String.Format(message, "Order Produksi [Dempyou]")
      reportCode = MainClass.GetReport(MainClass.reportName.zFusohDempyou)

      If Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True) AndAlso xStatusPrinted Then
        item.PrintCounter += 1
        Session.CommitChanges()
      End If
    End If
  End Sub
  Private Sub btnCetakVoucherRequest_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCetakVoucherRequest.ItemClick
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
      Utils.Win.MessageBox.Show("Masukkan keterangan", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      Exit Sub
    End If

    If note.Count > 0 Then
      Dim item As Persistent.Fusoh_OrderProduksi
      'Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

      'proxy = CType(xGridView.GetRow(note(0).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      'item = CType(proxy.OriginalRow, Persistent.Fusoh_OrderProduksi)
      item = CType(xGridView.GetRow(note(0).Row), Persistent.Fusoh_OrderProduksi)

      Dim frm As New RF_FusohVoucher(Persistent.SumberDataJenis.OP)
      frm.txtNoBukti1.EditValue = item.Kode
      Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & item.Kode & " ?"
      Dim xStatusPrinted As Boolean = False
      If MsgBox("Apakah anda ingin merubah status cetak menjadi printed?", vbYesNo, "Konfirmasi") = MsgBoxResult.Yes Then
        xStatusPrinted = True
      End If
      Dim reportCode As String = ""
      message = String.Format(message, "Process Request")
      reportCode = MainClass.GetReport(MainClass.reportName.zFusohProcessRequest)

      'Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
      If Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True) AndAlso xStatusPrinted Then
        item.PrintCounterPR += 1
        Session.CommitChanges()
      End If
    End If
  End Sub

  Private Sub btnResetStatus_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnResetStatus.ItemClick
    If allowEdit = False Then
      Utils.Win.MessageBox.Show("Anda tidak mendapatkan hak akses untuk merubah transaksi", "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
      Exit Sub
    End If
    If xGridView.RowCount < 1 Then
      Exit Sub
    End If

    Dim xText As String = String.Format("Apakah anda ingin mereset status {0} ?", Me.Text)
    Dim x As Integer() = xGridView.GetSelectedRows
    Dim note As List(Of NuSoft.Core.Win.Forms.GridDeletedData) = GetKeteranganHapus(x)
    If note Is Nothing Then
      Utils.Win.MessageBox.Show("Pilih data yang akan direset status nya", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      Exit Sub
    End If

    For i = 0 To note.Count - 1
      xText &= vbCrLf & note(i).Data
    Next

    If Len(xText) > 0 Then
      If Utils.Win.MessageBox.Show(xText, "Reset Status " & Me.Text, "", Utils.Win.MessageBox.Button.YaTidak, Utils.Win.MessageBox.Icon.Pertanyaan) = Utils.Win.MessageBox.DialogResult.Ya Then
        Dim item As Persistent.Fusoh_OrderProduksi
        Using splash As SplashScreenManager = New SplashScreenManager(Me, GetType(x_Wait), True, True)
          Try
            If Not splash.IsSplashFormVisible Then splash.ShowWaitForm()
            splash.SetWaitFormCaption("Reset Status Dempyou")
            splash.SetWaitFormDescription("Proses ...")

            For i = 0 To note.Count - 1
              If xGridView.IsDataRow(note(i).Row) Then
                item = CType(xGridView.GetRow(note(i).Row), Persistent.Fusoh_OrderProduksi)
                splash.SetWaitFormDescription("Proses " & item.Kode & " ...")
                Services.Fusoh_UpdateStatus.UpdateStatusDempyou(item)
              End If
            Next

            splash.SetWaitFormDescription("Apply ke database")
            Session.CommitChanges()
            splash.SetWaitFormDescription("Refresh data")
            RefreshData()
          Catch ex As Exception
            Utils.Win.MessageBox.Show(ex.Message, Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
          Finally
            If splash.IsSplashFormVisible Then splash.CloseWaitForm()
          End Try
        End Using
      End If
    End If

    'If Not xGridView.DataSource Is Nothing Then
    '	'Dim instance As Persistent.Fusoh_OrderProduksi
    '	'instance = session.GetObjectByKey(Of Persistent.Fusoh_OrderProduksi)(Convert.ToInt64(xGridView.GetFocusedRowCellDisplayText(colId)))
    '	'Dim xQtyDempyou As Double = instance.Qty
    '	'Dim xQtyProduksi As Double = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.OrderProduksi.Kode = instance.Kode).Sum(Function(s) s.QtyIn)
    '	'If xQtyProduksi = 0 Then
    '	'	instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
    '	'ElseIf xQtyProduksi >= xQtyDempyou Then
    '	'	instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
    '	'Else
    '	'	instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
    '	'End If
    '	'instance.Save()
    '	Dim focusRow = xGridView.FocusedRowHandle
    '	If (xGridView.IsDataRow(focusRow)) Then
    '		Dim item = CType(xGridView.GetRow(focusRow), Persistent.Fusoh_OrderProduksi)
    '		Services.Fusoh_UpdateStatus.UpdateStatusDempyou(item)
    '		session.CommitChanges()
    '		RefreshData()
    '	End If
    'End If
  End Sub

  'Private Sub ClosingDempyou(session As UnitOfWork, item As Persistent.Fusoh_OrderProduksi)
  '	' samakan qty finish good dempyou dengan yang di produksi
  '	item.Qty = item.QtyProduksi

  '	' cek produksi
  '	Dim produksi = New XPQuery(Of Persistent.Fusoh_StokSerial)(session) _
  '		.Where(Function(w) w.DetailMain.Main.OrderProduksi Is item AndAlso w.LengthOut > 0) _
  '		.GroupBy(Function(g) g.Serial).Select(Function(s) New With {.Serial = s.Key, .LengthOut = s.Sum(Function(x) x.LengthOut)}) _
  '		.ToList

  '	' samakan bahan baku dempyou dengan yang diproduksi
  '	' =================================================
  '	' hapus yang tidak ada di produksi / update length out dengan produksi
  '	For i = item.BahanBaku.Count - 1 To 0 Step -1
  '		Dim bahanBaku = item.BahanBaku(i)
  '		Dim found = produksi.Find(Function(f) f.Serial = bahanBaku.Serial)
  '		If found Is Nothing Then
  '			bahanBaku.Delete()
  '		Else
  '			bahanBaku.Length = CDec(found.LengthOut)
  '		End If
  '	Next
  'End Sub
End Class