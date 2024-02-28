Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Data.Filtering

Public Class UI_zParamaIV
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
    GetSession()
    Setting = New NuSoft001.Logic.FinaSetting(session)
    toStringFormat = Setting.NumericFormatToString
    colTotalValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotalValas.DisplayFormat.FormatString = Setting.NumericFormatString
    colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKurs.DisplayFormat.FormatString = Setting.NumericFormatString
    colTotalRp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotalRp.DisplayFormat.FormatString = Setting.NumericFormatString
    colTotalRp.SummaryItem.DisplayFormat = Setting.NumericFormatString
    Dim iList As New List(Of Persistent.SumberDataJenis)
    iList.Add(Persistent.SumberDataJenis.IV)
    ifSource.FixedFilterCriteria = New DevExpress.Data.Filtering.InOperator("Sumber", iList)
    btnUpdate.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("IVData.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("IVData.xml"))
    End If
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_zParamaIVDialog
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
    Dim item As Persistent.zParamaInvoicePenjualan, pPending As Integer
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

    pPending = 0
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.zParamaInvoicePenjualan)
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
    Dim item As Persistent.zParamaInvoicePenjualan
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim result As String = ""
    Dim xSpace As String, KodeBarang As String ', Harga As String
    Dim num As Integer, xKeterangan As String, xJumlah As String

    Try
      proxy = CType(view.GetRow(info.RowHandle), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      item = CType(proxy.OriginalRow, Persistent.zParamaInvoicePenjualan)

      Dim a = From p In item.Detail

      For i = 0 To a.Count - 1
        KodeBarang = a(i).Description
        num = (KodeBarang.Length + 3)
        If num >= 80 Then
          xSpace = " "
        Else
          xSpace = Space(80 - num)
        End If

        result += KodeBarang
        If i <> a.Count - 1 Then
          result += vbCrLf
        End If
      Next
      result += vbCrLf
      result += vbCrLf

      xKeterangan = "SubTotal"
      xJumlah = item.SubTotal.ToString(toStringFormat)
      num = (xKeterangan.Length + xJumlah.Length)
      xSpace = Space(80 - num)
      result += xKeterangan & xSpace & xJumlah & vbCrLf
      If item.PPN <> 0 Then
        xKeterangan = "PPN"
        xJumlah = item.PPN.ToString(toStringFormat)
        num = (xKeterangan.Length + xJumlah.Length)
        xSpace = Space(80 - num)
        result += xKeterangan & xSpace & xJumlah & vbCrLf
      End If

      xKeterangan = "Total Transaksi"
      xJumlah = item.Total.ToString(toStringFormat)
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
    Dim item As Persistent.zParamaInvoicePenjualan, xGagal As Integer, xMessage As String
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    xGagal = 0
    xMessage = ""
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.zParamaInvoicePenjualan)
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

  Private Sub btnVoucher1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVoucher1.ItemClick, btnVoucher2.ItemClick, btnVoucher3.ItemClick, btnVoucher4.ItemClick, btnVoucher5.ItemClick
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
      Dim item As Persistent.zParamaInvoicePenjualan
      Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

      proxy = CType(xGridView.GetRow(note(0).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      item = CType(proxy.OriginalRow, Persistent.zParamaInvoicePenjualan)

      Dim frm As New RF_zDataDataTransaksiParama(Persistent.SumberDataJenis.IV)
      Dim salesSetting As New Logic.SalesSetting(session)
      frm.txtNoBukti1.EditValue = item.Kode

      Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & item.Kode & " ?"
      Dim reportCode As String = ""
      message = String.Format(message, "Invoice Penjualan")
      Select Case e.Item.Caption
        Case "Invoice #1" : reportCode = MainClass.GetReport(MainClass.reportName.zVoucherParamaIV1)
        Case "Invoice #2" : reportCode = MainClass.GetReport(MainClass.reportName.zVoucherParamaIV2)
        Case "Invoice #3" : reportCode = MainClass.GetReport(MainClass.reportName.zVoucherParamaIV3)
        Case "Invoice #4" : reportCode = MainClass.GetReport(MainClass.reportName.zVoucherParamaIV4)
        Case "Faktur Pajak" : reportCode = MainClass.GetReport(MainClass.reportName.zVoucherParamaPajak)
        Case Else : reportCode = MainClass.GetReport(MainClass.reportName.VoucherFP)
      End Select

      Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, salesSetting.PreviewSave)
    End If
  End Sub
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("IVData.xml"))
  End Sub
  Private Sub btnVoucher_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVoucher.ItemClick
    Dim xNomor As String = xGridView.GetFocusedRowCellDisplayText(colNoGL)
    Dim a As New NuSoft001.Logic.Voucher
    a.showVoucher(Me, session, xNomor)
  End Sub
  Private Sub cmdResetUlangJurnal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdResetUlangJurnal.ItemClick
    Dim salesSetting As New Logic.SalesSetting(session)
    If MsgBox("Apakah anda yakin ingin mereset ulang jurnal invoice?", vbYesNo, "Konfirmasi") = MsgBoxResult.Yes Then
      Dim xInvoice As New DevExpress.Xpo.XPCollection(Of Persistent.zParamaInvoicePenjualan)(session)
      For pi = 0 To xInvoice.Count - 1
        xInvoice(pi).Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
        xInvoice(pi).Gl.Sumber = xInvoice(pi).Sumber
        xInvoice(pi).Gl.Tanggal = xInvoice(pi).Tanggal
        xInvoice(pi).Gl.Regional = xInvoice(pi).Regional
        xInvoice(pi).Gl.Kode = xInvoice(pi).Kode
        xInvoice(pi).Gl.ModuleId = NPO.Modules.ModuleId.Purchase
        xInvoice(pi).Gl.MataUang = xInvoice(pi).Uang.Simbol
        xInvoice(pi).Gl.Kurs = xInvoice(pi).Kurs
        xInvoice(pi).Gl.Kontak = xInvoice(pi).Pelanggan
        xInvoice(pi).Gl.KontakNama = xInvoice(pi).Pelanggan.Nama
        xInvoice(pi).Gl.Uraian = xInvoice(pi).Catatan

        Dim i As Byte = 0
        SimpanGL(xInvoice(pi), xInvoice(pi).Uang.PiutangDagang, i, xInvoice(pi).Total * xInvoice(pi).Kurs, 0, xInvoice(pi).Total, 0)
        i = i + 1
        If xInvoice(pi).PPN > 0 Then      'PPN (K)
          SimpanGL(xInvoice(pi), session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaPPN)), i, 0, xInvoice(pi).PPN * xInvoice(pi).Kurs, 0, 0)
          i = i + 1
        End If
        'Pendapatan (K) 
        SimpanGL(xInvoice(pi), session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaPendapatan)), i, 0, xInvoice(pi).SubTotal * xInvoice(pi).Kurs, 0, 0)
        i = i + 1
      Next
      session.CommitChanges()
      Utils.Win.MessageBox.Show("Proses Selesai", "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
  End Sub
  Private Sub btnCreateJurnal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateJurnal.ItemClick
    Dim xNomor As String = xGridView.GetFocusedRowCellDisplayText(colNoGL)
    If MsgBox("Apakah anda yakin ingin mereset ulang jurnal invoice [" & xNomor & "]?", vbYesNo, "Konfirmasi") = MsgBoxResult.Yes Then
      Dim xInvoice As Persistent.zParamaInvoicePenjualan = session.FindObject(Of Persistent.zParamaInvoicePenjualan)(New BinaryOperator("Kode", xNomor, BinaryOperatorType.Equal))
      If Not xInvoice Is Nothing Then
        'MsgBox("Totalnya : " & xInvoice.Total.ToString("n2"))
        Dim salesSetting As New Logic.SalesSetting(session)
        'Piutang Dagang  (D) 
        Dim i As Byte = 0
        SimpanGL(xInvoice, xInvoice.Uang.PiutangDagang, i, xInvoice.Total * xInvoice.Kurs, 0, xInvoice.Total, 0)
        i = i + 1
        If xInvoice.PPN > 0 Then      'PPN (K)
          SimpanGL(xInvoice, session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaPPN)), i, 0, xInvoice.PPN * xInvoice.Kurs, 0, 0)
          i = i + 1
        End If
        'Pendapatan (K) -> ambilkan dari seting tipe transaksi
        SimpanGL(xInvoice, session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaPendapatan)), i, 0, xInvoice.SubTotal * xInvoice.Kurs, 0, 0)
        i = i + 1
        If xInvoice.Gl.Detail.Count > i Then
          Dim pI As Integer
          For pI = i To xInvoice.Gl.Detail.Count - 1 Step -1
            'MsgBox("Delete untuk :" & pI)
            xInvoice.Gl.Detail(pI).Delete()
          Next
        End If
        session.CommitChanges()
        Utils.Win.MessageBox.Show("Proses Selesai", "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
      End If
    End If
  End Sub
  Private Sub SimpanGL(instance As Persistent.zParamaInvoicePenjualan, Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, DebitValas As Double, KreditValas As Double, Optional Catatan As String = "")
    Dim item As Persistent.GlMainDetail
    If instance.Gl.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
      item = instance.Gl.Detail.Single(Function(m) m.Urutan = Urutan)
      item.Akun = Akun
      item.MataUang = item.Akun.MataUang
      item.Main = instance.Gl
      item.Urutan = Urutan
      item.Debit = Debit
      item.Kredit = Kredit
      item.Keterangan = Catatan
      If Akun.MataUang.Id = setting.MultiMataUangDefault Then
        item.DebitValas = 0
        item.KreditValas = 0
        item.Kurs = 1
      Else
        item.DebitValas = DebitValas
        item.KreditValas = KreditValas
        item.Kurs = instance.Kurs
      End If
    Else
      item = New Persistent.GlMainDetail(session)
      item.Akun = Akun
      item.MataUang = item.Akun.MataUang
      item.Main = instance.Gl
      item.Urutan = Urutan
      item.Debit = Debit
      item.Kredit = Kredit
      item.Keterangan = Catatan
      If Akun.MataUang.Id = setting.MultiMataUangDefault Then
        item.DebitValas = 0
        item.KreditValas = 0
        item.Kurs = 1
      Else
        item.DebitValas = DebitValas
        item.KreditValas = KreditValas
        item.Kurs = instance.Kurs
      End If
      instance.Gl.Detail.Add(item)
    End If
  End Sub
End Class