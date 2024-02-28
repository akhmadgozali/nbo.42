Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class UI_BukuBesar
  Private setting As Logic.FinaSetting
  Private details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)

  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub FirstLoad()
    session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
    txtCOA.Properties.DataSource = Logic.Coa.GetCoa(session, True)
    txtRegional.Properties.DataSource = Core.SSystem.UserInfo.GetUserRegional(session, session.Connection.Database)
    setting = New Logic.FinaSetting(session)

    Dim period = New DevExpress.Xpo.XPCollection(Of Persistent.Periode)(session)
    txtBulan.Properties.Items.Clear()
    For i = 1 To 12
      txtBulan.Properties.Items.Add(MonthName(i))
    Next

    Dim z = From a In period Order By a.Id Descending Select a.Bulan, a.Tahun Take 1

    If z.Count > 0 Then
      If z(0).Bulan = 12 Then
        txtBulan.SelectedIndex = 0
        txtTahun.EditValue = z(0).Tahun + 1
      Else
        txtBulan.SelectedIndex = z(0).Bulan
        txtTahun.EditValue = z(0).Tahun
      End If
    Else
      txtBulan.SelectedIndex = Now.Month - 1
      txtTahun.EditValue = Now.Year
    End If

    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("BukuBesar.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("BukuBesar.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("BukuBesarVoucher.xml")) = True Then
      xGridVoucherView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("BukuBesarVoucher.xml"))
    End If
    SetFormat()

    txtRegional.DeselectAll()
    txtRegional.SelectAll()
  End Sub
  Private Sub cmdTampilkan_Click(sender As Object, e As EventArgs) Handles cmdTampilkan.Click
    If txtCOA.EditValue Is Nothing Then
      MsgBox("Silahkan pilih nomor COA", vbOKOnly, "Konfirmasi")
      Return
    End If
    If txtRegional.EditValue Is Nothing OrElse String.IsNullOrEmpty(txtRegional.EditValue.ToString) Then
      MsgBox("Silahkan pilih regional", vbOKOnly, "Konfirmasi")
      Return
    End If

    lyGroupJurnalVoucher.Text = "Jurnal Voucher : -"

    'isikan databasenya
    Dim SaldoAwal As Double, xSaldo As Double = 0, SaldoAwalValas As Double, xSaldoValas As Double
    Dim sortCollection As SortingCollection = New SortingCollection()
    sortCollection.Add(New SortProperty("Tanggal", DB.SortingDirection.Ascending))
    sortCollection.Add(New SortProperty("Id", DB.SortingDirection.Ascending))

    xGrid.DataSource = Nothing
    xGridVoucher.DataSource = Nothing
    txtCOA.Properties.DataSource = Nothing
    details = Nothing

    session.DropIdentityMap()

    txtCOA.Properties.DataSource = Logic.Coa.GetCoa(session, True)

    Dim akun = session.GetObjectByKey(Of Persistent.Coa)(txtCOA.EditValue)
    xGrid.DataSource = Nothing
    details = Nothing

    'details = New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(session, YearMonthCriteria, New SortProperty("Tanggal", DevExpress.Xpo.DB.SortingDirection.Ascending))
    details = New XPCollection(Of Persistent.Report.BukuBesar)(session)
    details.Criteria = YearMonthCriteria()
    details.Sorting = sortCollection
    details.Reload()

    Dim item As New Persistent.Report.BukuBesar(session)

    Using splashManager As New DevExpress.XtraSplashScreen.SplashScreenManager(Nothing, GetType(Core.Win.Forms.WaitForm), True, True)
      splashManager.ShowWaitForm()
      splashManager.SetWaitFormCaption("Silahkan Tunggu")
      splashManager.SetWaitFormDescription("Proses Hitung Saldo ...")

      SaldoAwal = CDbl(session.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, akun.Id, New Date(CInt(txtTahun.Text), txtBulan.SelectedIndex + 1, 1).ToString("yyyy-MM-dd"))))
      SaldoAwalValas = 0
      xSaldoValas = 0

      item.AkunDetail = akun
      item.AkunMain = Nothing
      item.Id = 0
      item.Keterangan = "Saldo Awal"
      item.NoBukti = ""
      item.SaldoAwal = 0
      item.SumberData = Nothing
      item.Tanggal = New Date(CInt(txtTahun.Text), txtBulan.SelectedIndex + 1, 1)
      item.Urutan = 0
      item.Debit = 0
      item.Kredit = 0
      item.SaldoAwal = SaldoAwal
      If akun.MataUang.Id <> setting.MultiMataUangDefault Then
        SaldoAwalValas = CDbl(session.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceValas, akun.Id, New Date(CInt(txtTahun.Text), txtBulan.SelectedIndex + 1, 1).ToString("yyyy-MM-dd"))))
        item.SaldoAwalValas = SaldoAwalValas
      End If
      details.Add(item)

      xSaldo = SaldoAwal
      xSaldoValas = SaldoAwalValas
      For i = 1 To details.Count - 1
        If akun.Tipe.Dc = Persistent.CoaEnum.eDc.Debit Then
          xSaldo = xSaldo + (details(i).Debit - details(i).Kredit)
        Else
          xSaldo = xSaldo + (details(i).Kredit - details(i).Debit)
        End If
        details(i).SaldoAwal = xSaldo
        If akun.MataUang.Id <> setting.MultiMataUangDefault Then
          If akun.Tipe.Dc = Persistent.CoaEnum.eDc.Debit Then
            xSaldoValas = xSaldoValas + (details(i).DebitValas - details(i).KreditValas)
          Else
            xSaldoValas = xSaldoValas + (details(i).KreditValas - details(i).DebitValas)
          End If
          details(i).SaldoAwalValas = xSaldoValas
        End If
      Next

      xGrid.DataSource = details

      lbSaldoAwal.Text = String.Format(setting.NumericFormatString, SaldoAwal)
      lbDebit.Text = String.Format(setting.NumericFormatString, colDebit.SummaryItem.SummaryValue)
      lbKredit.Text = String.Format(setting.NumericFormatString, colKredit.SummaryItem.SummaryValue)
      lbSaldoAkhir.Text = String.Format(setting.NumericFormatString, xSaldo)

      splashManager.CloseWaitForm()

      xGridView.RefreshData()
    End Using
  End Sub
  Private Function YearMonthCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"
    Dim akun = session.GetObjectByKey(Of Persistent.Coa)(txtCOA.EditValue)
    If Not Core.SSystem.UserInfo.GetUserDivision Is Nothing Then
      Dim right = From a In Core.SSystem.UserInfo.GetUserDivision Where a.Buka = True Select a.Divisi
      result.Add(New InOperator("AkunDetail.Divisi", right.ToList))
    End If
    result.Add(New BinaryOperator("Bulan", txtBulan.SelectedIndex + 1, BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("Tahun", txtTahun.Text, BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("AkunDetail.Id", akun.Id, BinaryOperatorType.Equal))

    Dim regValue = txtRegional.EditValue.ToString
    Dim regional = regValue.Split(","c)
    result.Add(New InOperator("Regional.Id", regional))

    Return GroupOperator.And(result)
  End Function
  Private Sub txtCOA_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtCOA.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Dim akun = session.GetObjectByKey(Of Persistent.Coa)(e.NewValue)

      gcSaldo.Text = akun.Nama
      If akun.MataUang.Id = setting.MultiMataUangDefault Then
        colKurs.Visible = False
        colDebitValas.Visible = False
        colKreditValas.Visible = False
      Else
        colKurs.Visible = True
        colDebitValas.Visible = True
        colKreditValas.Visible = True
      End If
      lbSaldoAwal.Text = String.Format(setting.NumericFormatString, 0)
      lbDebit.Text = String.Format(setting.NumericFormatString, 0)
      lbKredit.Text = String.Format(setting.NumericFormatString, 0)
      lbSaldoAkhir.Text = String.Format(setting.NumericFormatString, 0)
      xGrid.DataSource = Nothing
    End If
  End Sub
  Private Sub SetFormat()
    colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDebit.DisplayFormat.FormatString = setting.NumericFormatString
    colKredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKredit.DisplayFormat.FormatString = setting.NumericFormatString
    colDebitValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDebitValas.DisplayFormat.FormatString = setting.NumericFormatString
    colKreditValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKreditValas.DisplayFormat.FormatString = setting.NumericFormatString
    colDebit.SummaryItem.DisplayFormat = setting.NumericFormatString
    colKredit.SummaryItem.DisplayFormat = setting.NumericFormatString
    colDebitValas.SummaryItem.DisplayFormat = setting.NumericFormatString
    colKreditValas.SummaryItem.DisplayFormat = setting.NumericFormatString
    colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colSaldo.DisplayFormat.FormatString = setting.NumericFormatString
    colSaldoValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colSaldoValas.DisplayFormat.FormatString = setting.NumericFormatString
    colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKurs.DisplayFormat.FormatString = setting.NumericFormatString

    vColDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    vColDebit.DisplayFormat.FormatString = setting.NumericFormatString
    vColDebit.SummaryItem.DisplayFormat = setting.NumericFormatString
    vColKredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    vColKredit.DisplayFormat.FormatString = setting.NumericFormatString
    vColKredit.SummaryItem.DisplayFormat = setting.NumericFormatString
    vColDebitValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    vColDebitValas.DisplayFormat.FormatString = setting.NumericFormatString
    vColDebitValas.SummaryItem.DisplayFormat = setting.NumericFormatString
    vColKreditValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    vColKreditValas.DisplayFormat.FormatString = setting.NumericFormatString
    vColKreditValas.SummaryItem.DisplayFormat = setting.NumericFormatString
  End Sub
  Private Sub btnEkspor_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEkspor.ItemClick
    exportToExcel(xGrid)
  End Sub
  Private Sub btnCetak_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCetak.ItemClick
    printGrid(xGrid)
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("BukuBesar.xml"))
  End Sub
  Private Sub btnVoucher_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVoucher.ItemClick
    If Not xGrid.DataSource Is Nothing Then
      If Not xGridView.FocusedRowHandle = Nothing Then
        Dim xNoTransaksi As String = xGridView.GetFocusedRowCellDisplayText(colNoBukti)
        xGridVoucher.DataSource = New XPCollection(Of Persistent.GlMainDetail)(session, New BinaryOperator("Main.Kode", xNoTransaksi, BinaryOperatorType.Equal))
        xGridVoucherView.OptionsBehavior.ReadOnly = True
        xGridVoucherView.OptionsBehavior.Editable = False
        lyGroupJurnalVoucher.Text = "Jurnal Voucher : " & xNoTransaksi
      End If
    End If
  End Sub
  Private Sub btnTampilkanTransaksi_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTampilkanTransaksi.ItemClick
    If Not xGridView.GetFocusedRowCellDisplayText(colNoBukti) Is Nothing Then
      Dim xGLMain As Persistent.GlMain = session.FindObject(Of Persistent.GlMain)(New BinaryOperator("Kode", xGridView.GetFocusedRowCellDisplayText(colNoBukti), BinaryOperatorType.Equal))
      Dim pJenisTransaksi As JenisTransaksiGL, pKodeMenu As String
      If Not xGLMain Is Nothing Then
        Select Case xGLMain.Sumber.Id
          Case Persistent.SumberDataJenis.KM : pJenisTransaksi = JenisTransaksiGL.KasMasuk : pKodeMenu = "0101.02.02"
          Case Persistent.SumberDataJenis.KK : pJenisTransaksi = JenisTransaksiGL.KasKeluar : pKodeMenu = "0101.02.03"
          Case Persistent.SumberDataJenis.BM : pJenisTransaksi = JenisTransaksiGL.BankMasuk : pKodeMenu = "0101.02.04"
          Case Persistent.SumberDataJenis.BK : pJenisTransaksi = JenisTransaksiGL.BankKeluar : pKodeMenu = "0101.02.05"
          Case Persistent.SumberDataJenis.JU : pJenisTransaksi = JenisTransaksiGL.JurnalUmum : pKodeMenu = "0101.03.01"
          Case Persistent.SumberDataJenis.JA : pJenisTransaksi = JenisTransaksiGL.JurnalAdjusment : pKodeMenu = "0101.03.02"
          Case Else
            MsgBox("Data " & xGLMain.Sumber.Keterangan & " tidak dapat ditampilkan")
            Exit Sub
        End Select
        Dim j As New UI_TransaksiGL(pJenisTransaksi)
        j.CallInputDialog(pKodeMenu, xGLMain.Id, session)
      End If
    End If
  End Sub
  Private Sub xGridVoucherView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridVoucherView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("BukuBesarVoucher.xml"))
  End Sub
  Private Sub xGrid_DoubleClick(sender As Object, e As System.EventArgs) Handles xGrid.DoubleClick
    btnVoucher_ItemClick(btnVoucher, Nothing)
  End Sub
End Class