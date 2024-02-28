Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem
Public Class zRexaUI_InvoicePenjualan
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
    Dim Setting As New NuSoft001.Logic.FinaSetting(GetSession)
    Dim CreateCriteria As CriteriaOperator
    Setting = New NuSoft001.Logic.FinaSetting(session)
    toStringFormat = Setting.NumericFormatToString
    CreateCriteria = GroupOperator.And(New BinaryOperator("Sumber", Persistent.SumberDataJenis.IV, BinaryOperatorType.Equal), New InOperator("Regional", UserInfo.GetUserRegional(session, NamaDatabase)))
    ifSource.FixedFilterCriteria = CreateCriteria
    btnClosing.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnUnposting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("IVData.xml")) = True Then
      'xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("IVData.xml"))
    End If
    colSaldoGL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colSaldoGL.DisplayFormat.FormatString = Setting.NumericFormatString
    colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotal.DisplayFormat.FormatString = Setting.NumericFormatString
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New zRexaUI_InvoicePenjualanDialog
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
    Dim item As Persistent.zRexaInvoicePenjualan, pPending As Integer
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim dtSO As New List(Of Persistent.zRexaOrderPenjualan)

    pPending = 0
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.zRexaInvoicePenjualan)
        If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
          Dim zdtGL As Persistent.GlMain = session.FindObject(Of Persistent.GlMain)(New BinaryOperator("Id", item.Gl.Id, BinaryOperatorType.Equal))
          If Not zdtGL Is Nothing Then
            zdtGL.Delete()
          End If
          'nomor SO nya
          'Dim a = From z In instance.Detail Group z By z.Barang.CoaCost, z.Proyek Into Group Select CoaCost, Proyek, SubTotal = Group.Sum(Function(x) x.DPP * x.Main.Kurs)
          'For Each x In a
          '  SimpanGL(x.CoaCost, i, x.SubTotal, 0, 0, 0, "", x.Proyek)
          '  i = i + 1
          'Next
          Dim b = From z In item.Detail Where Not z.OrderPenjualan Is Nothing Group z By z.OrderPenjualan Into Group Select OrderPenjualan.Main, SubTotal = Group.Sum(Function(x) x.DPP * x.Main.Kurs)
          For Each p In b
            If Not p.Main Is Nothing Then
              dtSO.Add(p.Main)
            End If
          Next

          item.Delete()
        Else
          pPending += 1
        End If
      End If
    Next
    session.CommitChanges()
    'update status SO
    For i = dtSO.Count - 1 To 0 Step -1
      Dim xpIV As New XPCollection(Of Persistent.zRexaInvoicePenjualanDetail)(session, New BinaryOperator("OrderPenjualan.Main.Id", dtSO(i).Id, BinaryOperatorType.Equal))
      If xpIV.Count > 0 Then
        dtSO(i).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
      Else
        dtSO(i).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
      End If
    Next
    session.CommitChanges()


    If pPending > 0 Then
      Utils.Win.MessageBox.Show("Transaksi selain status pending tidak dapat dihapus.", "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
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
        setstatus(note, e.Item.Tag)
        RefreshData()
      End If
    End If
  End Sub
  Sub setstatus(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData), xTipe As String)
    Dim item As Persistent.zRexaInvoicePenjualan, xGagal As Integer, xMessage As String
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    xGagal = 0
    xMessage = ""
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.zRexaInvoicePenjualan)
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
  Private Sub btnCetak_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCetakVoucher1.ItemClick, btnCetakVoucher2.ItemClick, btnCetakVoucher3.ItemClick, btnInvoiceGedung.ItemClick
    Try
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
        Dim item As Persistent.zRexaInvoicePenjualan
        Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread

        proxy = CType(xGridView.GetRow(note(0).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.zRexaInvoicePenjualan)

        Dim frm As New zRexaRF_DataDataTransaksi(Persistent.SumberDataJenis.IV)
        Dim salesSetting As New Logic.SalesSetting(session)
        frm.txtNoBukti1.EditValue = item.Kode

        Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & item.Kode & " ?"
        Dim reportCode As String = ""
        message = String.Format(message, "Invoice Penjualan")
        Select Case e.Item.Caption
          Case "Voucher Invoice" : reportCode = MainClass.GetReport(MainClass.reportName.zRexxaVoucherInvoice)
          Case "Voucher Invoice Gedung" : reportCode = MainClass.GetReport(MainClass.reportName.zRexxaVoucherInvoiceGedung)
          Case "Faktur Pajak" : reportCode = MainClass.GetReport(MainClass.reportName.VoucherFP)
          Case "Faktur Pajak Valas" : reportCode = MainClass.GetReport(MainClass.reportName.VoucherFPValas)
          Case Else : reportCode = MainClass.GetReport(MainClass.reportName.zRexxaVoucherInvoice)
        End Select
        Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, salesSetting.PreviewSave)
      End If
    Catch ex As Utils.Exception
      Throw New Utils.Exception(ex)
    Catch ex As Exception
      If ex.Message.Contains("File not found") Then
        Throw New Exception("File report tidak ditemukan, silahkan cek seting report", ex.InnerException)
      Else
        Throw New Exception(ex.Message, ex.InnerException)
      End If
    End Try
  End Sub

  Private Sub btnShowVoucher_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowVoucher.ItemClick
    Dim xNomor As String = xGridView.GetFocusedRowCellDisplayText(colKode)
    Dim a As New NuSoft001.Logic.Voucher
    a.showVoucher(Me, session, xNomor)
  End Sub
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("IVData.xml"))
  End Sub
  Private Sub btnPembayaran_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPembayaran.ItemClick
    If Not xGridView.GetFocusedRowCellDisplayText(colId) Is Nothing Then
      Dim a As New UI_InvoicePenjualanHistory(xGridView.GetFocusedRowCellDisplayText(colId))
      a.MenuId = MenuId
      a.NamaDatabase = NamaDatabase
      a.ShowDialog()
    End If
  End Sub

  Private Sub btnResetProyek_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetProyek.ItemClick
    Dim xDtInvoice As New XPCollection(Of Persistent.zRexaInvoicePenjualanDetail)(session)
    For pi = 0 To xDtInvoice.Count - 1
      If Not xDtInvoice(pi).OrderPenjualan Is Nothing Then
        xDtInvoice(pi).Proyek = xDtInvoice(pi).OrderPenjualan.Proyek
      End If
    Next
    session.CommitChanges()


    Utils.Win.MessageBox.Show("Proses Selesai.", "Update Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
  End Sub

  Private Sub btnResetJurnal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetJurnal.ItemClick
    Dim salesSetting As New Logic.SalesSetting(session)
    If MsgBox("Apakah anda ingin mereset seluruh jurnal?", vbYesNo, "Konfirmasi") = MsgBoxResult.Yes Then
      Dim xInvoice As New DevExpress.Xpo.XPCollection(Of Persistent.zRexaInvoicePenjualan)(session)
      For pi = 0 To xInvoice.Count - 1
        MsgBox("OKE : " & xInvoice(pi).Kode)
        xInvoice(pi).Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
        xInvoice(pi).Gl.Sumber = xInvoice(pi).Sumber
        xInvoice(pi).Gl.Tanggal = xInvoice(pi).Tanggal
        xInvoice(pi).Gl.Regional = xInvoice(pi).Regional
        xInvoice(pi).Gl.Kode = xInvoice(pi).Kode
        xInvoice(pi).Gl.ModuleId = NPO.Modules.ModuleId.Sales
        xInvoice(pi).Gl.MataUang = xInvoice(pi).Uang.Simbol
        xInvoice(pi).Gl.Kurs = xInvoice(pi).Kurs
        xInvoice(pi).Gl.Kontak = xInvoice(pi).Pelanggan
        xInvoice(pi).Gl.KontakNama = xInvoice(pi).Pelanggan.Nama
        xInvoice(pi).Gl.Uraian = xInvoice(pi).Catatan
        Dim xCoaPiutang As NuSoft001.Persistent.Coa, pRegional As Persistent.xRegional
        'Piutang Dagang  (D) 
        pRegional = session.GetObjectByKey(Of Persistent.xRegional)(xInvoice(pi).Regional.Id)
        If salesSetting.SetingARRegional = False Then
          xCoaPiutang = xInvoice(pi).Uang.PiutangDagang
        Else
          xCoaPiutang = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(pRegional.CoaAR))
        End If
        Dim i As Byte = 1
        SimpanGL(xInvoice(pi), xCoaPiutang, i, xInvoice(pi).Total * xInvoice(pi).Kurs, 0, xInvoice(pi).Total, 0)
        i = i + 1


        If xInvoice(pi).PPH > 0 Then      'PPH (D)
          SimpanGL(xInvoice(pi), session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaPPH)), i, xInvoice(pi).PPH * xInvoice(pi).Kurs, 0, 0, 0)
          i = i + 1
        End If
        If xInvoice(pi).PPN > 0 Then      'PPN (K)
          SimpanGL(xInvoice(pi), session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaPPN)), i, 0, xInvoice(pi).PPN * xInvoice(pi).Kurs, 0, 0)
          i = i + 1
        End If

        'Pendapatan (K) -> ambilkan dari seting coa master
        Dim b = From z In xInvoice(pi).Detail Group z By z.Barang.CoaIncome, z.Divisi, z.Proyek Into Group Select CoaIncome, SubTotal = Group.Sum(Function(x) x.DPP * x.Main.Kurs), Divisi, Proyek
        For Each x In b
          SimpanGL(xInvoice(pi), x.CoaIncome, i, 0, x.SubTotal, 0, 0, , x.Divisi, x.Proyek)
          i = i + 1
        Next

      Next
      session.CommitChanges()
      Utils.Win.MessageBox.Show("Proses Selesai", "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)

    End If
  End Sub
  Private Sub SimpanGL(instance As Persistent.zRexaInvoicePenjualan, Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, DebitValas As Double, KreditValas As Double, Optional Catatan As String = "", Optional xDivisi As NPO.Modules.ModSys.Divisi = Nothing, Optional xProyek As NuSoft001.Persistent.Proyek = Nothing)
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
      item.Divisi = xDivisi
      item.Proyek = xProyek
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
      item.Divisi = xDivisi
      item.Proyek = xProyek

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