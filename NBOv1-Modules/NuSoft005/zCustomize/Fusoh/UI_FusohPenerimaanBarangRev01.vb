Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Xpo
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraBars

Public Class UI_FusohPenerimaanBarangRev01
  Private toStringFormat As String
  Private setting As NuSoft001.Logic.FinaSetting

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
    'ooooo
    GetSession()
    Dim setting As New NuSoft001.Logic.FinaSetting(session)
    'Dim CreateCriteria As CriteriaOperator
    toStringFormat = setting.NumericFormatToString
    'CreateCriteria = GroupOperator.And(New BinaryOperator("Sumber", Persistent.SumberDataJenis.GR, BinaryOperatorType.Equal), New InOperator("Regional", UserInfo.GetUserRegional(session, NamaDatabase)))
    'ifSource.FixedFilterCriteria = CreateCriteria
    btnClosing.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnUnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("GRData.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("GRData.xml"))
    End If
    btnResetJurnal.Enabled = allowEdit
    btnResetJurnal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_FusohPenerimaanBarangDialogRev01
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
    Dim item As Persistent.Fusoh_PenerimaanBarang, pPending As Integer, data As Persistent.Fusoh_PenerimaanBarangView
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim dipakeDempyou As String = ""
    Dim kodeDelete = ""

    Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
      Try
        splashManager.ShowWaitForm()
        splashManager.SetWaitFormCaption("Silahkan Tunggu")
        splashManager.SetWaitFormDescription("Hapus data penerimaan barang ...")

        pPending = 0
        For i = 0 To selectedData.Count - 1
          If Not xGridView.IsGroupRow(selectedData(i).Row) Then
            proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
            data = CType(proxy.OriginalRow, Persistent.Fusoh_PenerimaanBarangView)
            If data.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
              item = session.GetObjectByKey(Of Persistent.Fusoh_PenerimaanBarang)(data.Id)

              '=== cek pemakaian serial
              For Each detail In item.Detail
                Dim daftarSerial = detail.DetailSerial.Select(Function(s) s.Serial).ToList
                Dim dempyou = New XPQuery(Of NuSoft004.Persistent.Fusoh_OrderProduksiBahanBaku)(session) _
                  .Where(Function(w) w.Barang Is detail.Barang AndAlso daftarSerial.Contains(w.Serial)).ToList
                If (dempyou.Count > 0) Then
                  dipakeDempyou &= vbCrLf & detail.Main.Kode & " => " & dempyou(0).Main.Kode
                  GoTo breaking
                End If
              Next

              Dim xpGR = New XPQuery(Of Persistent.Fusoh_PenerimaanBarang)(session).Where(Function(w) w.Exim Is item.Exim AndAlso Not w Is item)
              If xpGR.Count > 0 Then
                item.Exim.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
              Else
                item.Exim.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
              End If

              kodeDelete &= ", " & item.Kode
              item.Delete()
            Else
              pPending += 1
            End If
          End If
breaking:
        Next
        session.CommitChanges()
      Catch ex As Exception
        Throw New Exception(ex.Message, ex.InnerException)
      Finally
        splashManager.CloseWaitForm()
      End Try

      '======= Simple log
      Try
        If kodeDelete <> "" Then
          DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Hapus, "Data Penerimaan Barang [GR] ->" & kodeDelete.Substring(1))
          session.CommitChanges()
        End If
      Catch ex As Exception
      End Try
    End Using

    If pPending > 0 Then
      Utils.Win.MessageBox.Show("Transaksi selain status pending tidak dapat dihapus.", "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
    If Not String.IsNullOrEmpty(dipakeDempyou) Then
      Utils.Win.MessageBox.Show("Transaksi ini tidak dapat dihapus karena serial nya sudah diproses." & dipakeDempyou, "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
    Return True
  End Function

  Overrides Function GetToolTipContent(view As DevExpress.XtraGrid.Views.Grid.GridView, info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
    Dim item As Persistent.Fusoh_PenerimaanBarangView
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim result As String = ""
    Dim xSpace As String, KodeBarang As String, NamaBarang As String, Qty As String ', Harga As String
    Dim num As Integer

    Try
      proxy = CType(view.GetRow(info.RowHandle), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      item = CType(proxy.OriginalRow, Persistent.Fusoh_PenerimaanBarangView)
      Dim data = session.GetObjectByKey(Of Persistent.Fusoh_PenerimaanBarang)(item.Id)

      Dim a = From p In data.Detail

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

      'xKeterangan = "SubTotal"
      'xJumlah = item.SubTotal.ToString(toStringFormat)
      'num = (xKeterangan.Length + xJumlah.Length)
      'xSpace = Space(80 - num)
      'result += xKeterangan & xSpace & xJumlah & vbCrLf
      'If item.PPN <> 0 Then
      '  xKeterangan = "PPN"
      '  xJumlah = item.PPN.ToString(toStringFormat)
      '  num = (xKeterangan.Length + xJumlah.Length)
      '  xSpace = Space(80 - num)
      '  result += xKeterangan & xSpace & xJumlah & vbCrLf
      'End If

      'If item.PPH <> 0 Then
      '  xKeterangan = "PPH"
      '  xJumlah = item.PPH.ToString(toStringFormat)
      '  num = (xKeterangan.Length + xJumlah.Length)
      '  xSpace = Space(80 - num)
      '  result += xKeterangan & xSpace & xJumlah & vbCrLf
      'End If
      'xKeterangan = "Total Transaksi"
      'xJumlah = item.Total.ToString(toStringFormat)
      'num = (xKeterangan.Length + xJumlah.Length)
      'xSpace = Space(80 - num)
      'result += xKeterangan & xSpace & xJumlah & vbCrLf

      Return result
    Catch ex As Exception
      Return ""
    End Try
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
    Dim item As Persistent.Fusoh_PenerimaanBarang, xGagal As Integer, xMessage As String
    Dim data As Persistent.Fusoh_PenerimaanBarangView
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    xGagal = 0
    xMessage = ""
    Dim kodeStatus = ""

    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        data = CType(proxy.OriginalRow, Persistent.Fusoh_PenerimaanBarangView)
        item = session.GetObjectByKey(Of Persistent.Fusoh_PenerimaanBarang)(data.Id)
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
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Penerimaan Barang [GR] " & xTipe & " ->" & kodeStatus.Substring(1))
        session.CommitChanges()
      End If
    Catch ex As Exception
    End Try

    If xGagal > 0 Then
      Utils.Win.MessageBox.Show(xMessage.ToString, "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
  End Sub
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("GRData.xml"))
  End Sub
  Private Sub btnResetJurnal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetJurnal.ItemClick
    'If MsgBox("Apakah anda ingin membuat ulang semua jurnal penerimaan barang?", vbYesNo, "Konfirmasi") = vbYes Then
    '	Dim settingpurchase As New Logic.PurchaseSetting(session)

    '	Dim xdtPenerimaanBarang As New XPCollection(Of Persistent.Fusoh_PenerimaanBarang)(session)
    '	For pi = 0 To xdtPenerimaanBarang.Count - 1
    '		'xdtPenerimaanBarang(pi).Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
    '		xdtPenerimaanBarang(pi).Gl.Sumber = xdtPenerimaanBarang(pi).Sumber
    '		xdtPenerimaanBarang(pi).Gl.Tanggal = xdtPenerimaanBarang(pi).Tanggal
    '		xdtPenerimaanBarang(pi).Gl.Regional = xdtPenerimaanBarang(pi).Regional
    '		xdtPenerimaanBarang(pi).Gl.Kode = xdtPenerimaanBarang(pi).Kode
    '		xdtPenerimaanBarang(pi).Gl.ModuleId = NPO.Modules.ModuleId.Purchase
    '		xdtPenerimaanBarang(pi).Gl.MataUang = xdtPenerimaanBarang(pi).Exim.PO.Uang.Simbol
    '		xdtPenerimaanBarang(pi).Gl.Kurs = xdtPenerimaanBarang(pi).Kurs
    '		xdtPenerimaanBarang(pi).Gl.Kontak = xdtPenerimaanBarang(pi).Vendor
    '		xdtPenerimaanBarang(pi).Gl.KontakNama = xdtPenerimaanBarang(pi).Vendor.Nama
    '		xdtPenerimaanBarang(pi).Gl.Uraian = xdtPenerimaanBarang(pi).Uraian

    '		For zi = xdtPenerimaanBarang(pi).Gl.Detail.Count - 1 To 0 Step -1
    '			xdtPenerimaanBarang(pi).Gl.Detail(zi).Delete()
    '		Next

    '		Dim i As Byte = 1
    '		'Persediaan (D)    looping dari setingan master coa
    '		Dim a = From z In xdtPenerimaanBarang(pi).Detail Where z.Barang.Jenis = NuSoft004.Persistent.JenisBarang.Persediaan Or z.Barang.Jenis = NuSoft004.Persistent.JenisBarang.Assembly Group z By z.Barang.CoaStock, z.OrderDetail.Proyek Into Group Select Proyek, CoaStock, SubTotal = Group.Sum(Function(x) x.SubTotal * x.Main.Kurs)
    '		For Each x In a
    '			SimpanGL(xdtPenerimaanBarang(pi), x.CoaStock, i, x.SubTotal, 0, x.Proyek)
    '			i = i + 1
    '		Next

    '		'langsung jadikan biaya ketika jasa
    '		Dim b = From z In xdtPenerimaanBarang(pi).Detail Where z.Barang.Jenis = NuSoft004.Persistent.JenisBarang.Jasa Group z By z.Barang.CoaCost, z.OrderDetail.Proyek Into Group Select CoaCost, Proyek, SubTotal = Group.Sum(Function(x) x.SubTotal * x.Main.Kurs)
    '		For Each x In b
    '			SimpanGL(xdtPenerimaanBarang(pi), x.CoaCost, i, x.SubTotal, 0, x.Proyek)
    '			i = i + 1
    '		Next

    '		i = i + 1


    '		'Hutang Sementara (C)
    '		SimpanGL(xdtPenerimaanBarang(pi), session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingpurchase.CoaHutangSementara)), i + 1, 0, xdtPenerimaanBarang(pi).Detail.Sum(Function(m) m.SubTotal * m.Main.Kurs))

    '	Next
    '	session.CommitChanges()
    '	Utils.Win.MessageBox.Show("Proses Selesai", "Update GL", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)

    'End If
  End Sub
  'Private Sub SimpanGL(instance As Persistent.PenerimaanBarang, Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, Optional Proyek As NuSoft001.Persistent.Proyek = Nothing)
  '	Dim item As Persistent.GlMainDetail
  '	If instance.Gl.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
  '		item = instance.Gl.Detail.Single(Function(m) m.Urutan = Urutan)
  '	Else
  '		item = New Persistent.GlMainDetail(session)

  '		item.Akun = Akun
  '		item.MataUang = item.Akun.MataUang
  '		item.Main = instance.Gl
  '		item.Urutan = Urutan
  '		item.Debit = Debit
  '		item.Kredit = Kredit
  '		item.Kurs = 1
  '		item.DebitValas = 0
  '		item.KreditValas = 0
  '		item.Proyek = Proyek
  '		instance.Gl.Detail.Add(item)
  '	End If
  'End Sub

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
      Dim item As Persistent.Fusoh_PenerimaanBarangView
      Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

      proxy = CType(xGridView.GetRow(note(0).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      item = CType(proxy.OriginalRow, Persistent.Fusoh_PenerimaanBarangView)

			Dim frm As New RF_FusohVoucher(Persistent.SumberDataJenis.CSIM, MainClass.reportName.zFusohVoucherGRN)
			frm.txtNoBukti1.EditValue = item.Kode

      Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & item.Kode & " ?"
      Dim reportCode As String = ""
      message = String.Format(message, "Penerimaan Barang [GRN]")
      reportCode = MainClass.GetReport(MainClass.reportName.zFusohVoucherGRN)

      Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
    End If
  End Sub

  Private Sub btnCekHistoryData_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCekHistoryData.ItemClick
    Dim xNoTransaksi As String = xGridView.GetFocusedRowCellDisplayText(colKode)
    If Not xNoTransaksi Is Nothing Then
      Fusoh_Logic.Umum.xHistoryData(Me, session, UI_FusohCekData.TipeTransaksi.GR, xNoTransaksi)
    End If
  End Sub
  Private Sub btnHistoryDempyou_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnHistoryDempyou.ItemClick
    Dim xNoTransaksi As String = xGridView.GetFocusedRowCellDisplayText(colKode)
    If Not xNoTransaksi Is Nothing Then
      Fusoh_Logic.Umum.xHistoryDempyou(Me, session, xNoTransaksi)
    End If
  End Sub

  Private Sub btnShowLog_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnShowLog.ItemClick
    If xGridView.IsDataRow(xGridView.FocusedRowHandle) Then
      'Dim item As Persistent.Fusoh_PenerimaanBarangView
      'Dim item = CType(proxy.OriginalRow, Persistent.Fusoh_PenerimaanBarang)


      Dim frm As New Log_FusohData
      frm.session = session
			Dim proxy = CType(xGridView.GetFocusedRow(), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
			Dim item = CType(proxy.OriginalRow, Persistent.Fusoh_PenerimaanBarangView)
			frm.TipeData = Persistent.SumberDataJenis.GR
			frm.Kode = item.Kode
			frm.ShowDialog()
    End If
  End Sub
End Class