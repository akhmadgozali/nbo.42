Imports DevExpress.Data.Filtering
Friend Class xMesitechDaftarGL
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    showFilter = False
    showChart = False
    UseDbSystem = False
    'xpCol.CriteriaString = String.Format("[Main.Tahun]={0} AND Month([Main.Bulan])={1}", Now.Year, Now.Month)
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("Daftar GL.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("Daftar GL.xml"))
    End If
    Dim a As New Logic.FinaSetting(session)
    colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDebit.DisplayFormat.FormatString = a.NumericFormatString
    colKredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKredit.DisplayFormat.FormatString = a.NumericFormatString
    colDebitValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDebitValas.DisplayFormat.FormatString = a.NumericFormatString
    colKreditValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKreditValas.DisplayFormat.FormatString = a.NumericFormatString
    colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKurs.DisplayFormat.FormatString = a.NumericFormatString
    colDebit.SummaryItem.DisplayFormat = a.NumericFormatString
    colKredit.SummaryItem.DisplayFormat = a.NumericFormatString
  End Sub
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("Daftar GL.xml"))
  End Sub
  Private Sub cmdTampilkan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdTampilkan.ItemClick
    If Not xGridView.GetFocusedRowCellDisplayText(colNoBukti) Is Nothing Then
      Dim xGLMain As Persistent.GlMain = session.FindObject(Of Persistent.GlMain)(New BinaryOperator("Kode", xGridView.GetFocusedRowCellDisplayText(colNoBukti), BinaryOperatorType.Equal))
      Dim pJenisTransaksi As JenisTransaksiGL, pKodeMenu As String
      If Not xGLMain Is Nothing Then
        Select Case xGLMain.Sumber.Id
          Case Persistent.SumberDataJenis.KM : pJenisTransaksi = JenisTransaksiGL.KasMasuk : pKodeMenu = "0101.96"
            Dim j As New xMesitechGL(xJenisMesitechGL.BuktiKas)
            j.CallInputDialog(pKodeMenu, xGLMain.Id, session)
          Case Persistent.SumberDataJenis.BM : pJenisTransaksi = JenisTransaksiGL.BankMasuk : pKodeMenu = "0101.97"
            Dim j As New xMesitechGL(xJenisMesitechGL.BuktiBank)
            j.CallInputDialog(pKodeMenu, xGLMain.Id, session)
          Case Persistent.SumberDataJenis.JU : pJenisTransaksi = JenisTransaksiGL.JurnalUmum : pKodeMenu = "0101.98"
            Dim j As New xMesitechGL(xJenisMesitechGL.JurnalMemo)
            j.CallInputDialog(pKodeMenu, xGLMain.Id, session)
          Case Persistent.SumberDataJenis.PA : pJenisTransaksi = JenisTransaksiGL.JurnalAdjusment : pKodeMenu = "0101.99"
            Dim j As New xMesitechGL(xJenisMesitechGL.AppPembayaran)
            j.CallInputDialog(pKodeMenu, xGLMain.Id, session)
          Case Else
            MsgBox("Data " & xGLMain.Sumber.Keterangan & " tidak dapat ditampilkan.")
            Exit Sub
        End Select
      End If
    End If
  End Sub
  Private Sub btnFilterCustom_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilterCustom.ItemClick
    Dim xform As New xMesitechDaftarGLFilter
    xform.MenuId = MenuId
    xform.NamaDatabase = NamaDatabase
    xform.session = session
    xform.Owner = Me
    xform.ShowDialog()
  End Sub
  Friend Sub InitFilter(xFilter As DevExpress.Data.Filtering.CriteriaOperator)
    xGridView.ActiveFilterCriteria = xFilter
  End Sub
  Private Sub btnFilterHariIni_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilter1.ItemClick, btnFilter2.ItemClick, btnFilter3.ItemClick, btnFilter4.ItemClick, btnFilter5.ItemClick, btnFilter6.ItemClick, btnFilter7.ItemClick, btnPending.ItemClick, btnVerifikasi.ItemClick
    Dim result As New List(Of CriteriaOperator)
    If e.Item.Tag.ToString = "Hari Ini" Then
      result.Add(New BinaryOperator("Main.Tanggal", Now.Date, BinaryOperatorType.Equal))
    End If
    If e.Item.Tag.ToString = "Minggu Ini" Then
      Dim dayDiff As Integer = Date.Today.DayOfWeek - DayOfWeek.Monday
      Dim tglAwal As Date = Today.AddDays(-dayDiff)
      Dim tglAkhir As Date = tglAwal.AddDays(6)
      result.Add(New BetweenOperator("Main.Tanggal", tglAwal, tglAkhir))
    End If
    If e.Item.Tag.ToString = "Bulan Ini" Then
      Dim tglawal As Date = New Date(Now.Year, Now.Month, 1)
      Dim tglAkhir As Date = tglawal.AddMonths(1).AddDays(-(tglawal.AddMonths(1).Day))
      result.Add(New BetweenOperator("Main.Tanggal", tglawal, tglAkhir))
    End If
    If e.Item.Tag.ToString = "Bukti Kas" Then
      result.Add(New BinaryOperator("Main.Sumber.Id", Persistent.SumberDataJenis.KM, BinaryOperatorType.Equal))
    End If
    If e.Item.Tag.ToString = "Bukti Bank" Then
      result.Add(New BinaryOperator("Main.Sumber.Id", Persistent.SumberDataJenis.BM, BinaryOperatorType.Equal))
    End If
    If e.Item.Tag.ToString = "Jurnal Memo" Then
      result.Add(New BinaryOperator("Main.Sumber.Id", Persistent.SumberDataJenis.JU, BinaryOperatorType.Equal))
    End If
    If e.Item.Tag.ToString = "Jurnal APP" Then
      result.Add(New BinaryOperator("Main.Sumber.Id", Persistent.SumberDataJenis.PA, BinaryOperatorType.Equal))
    End If

    If e.Item.Tag.ToString = "Transaksi Pending" Then
      result.Add(New BinaryOperator("Main.Status", Persistent.xMesitechStatusTransaksiEnum.Pending, BinaryOperatorType.Equal))
    End If
    If e.Item.Tag.ToString = "Transaksi Verifikasi" Then
      result.Add(New BinaryOperator("Main.Status", Persistent.xMesitechStatusTransaksiEnum.Verifikasi, BinaryOperatorType.Equal))
    End If

    xGridView.ActiveFilterCriteria = GroupOperator.And(result)
  End Sub
End Class