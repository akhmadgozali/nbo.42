Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports NuSoft.Utils.CustomAttribute

Friend Class RF_Divisi
  Private _jenis As MainClass.reportName
  Sub New(jenis As MainClass.reportName)
    ' This call is required by the designer.
    InitializeComponent()
    _jenis = jenis
    lytAkun1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    lytAkun2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    Select Case _jenis
      Case MainClass.reportName.DivisiLabaRugiCustom
        Me.Text = "Laba Rugi Divisi"
      Case MainClass.reportName.DivisiLabaRugiCOA
        Me.Text = "Laba Rugi Divisi"
      Case MainClass.reportName.DivisiBukuBesar
        Me.Text = "Buku Besar Divisi"
        lytAkun1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lytAkun2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
      Case MainClass.reportName.DivisiSaldo
        Me.Text = "Saldo Divisi"
      Case MainClass.reportName.DivisiLabaRugiCOALevel
        Me.Text = "Laba Rugi Divisi"
      Case MainClass.reportName.DivisiLabaRugiTahunan
        Me.Text = "Laba Rugi Divisi Per Tahun"
        lytPeriode1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lytPeriode2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        'chkSaldoNol.EditValue = True
        'chkSaldoNol.Properties.ReadOnly = True
    End Select
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeData()
    txtPeriodeAwal.DateTime = New Date(Now.Year, Now.Month, 1)
    Dim xAkhirBulan As New Date(Now.Year, Now.Month, 1)

    txtPeriodeAkhir.DateTime = xAkhirBulan.AddMonths(1).AddDays(-(xAkhirBulan.AddMonths(1).Day))

    txtAkun1.Properties.DataSource = Logic.Coa.GetCoa(_sesi, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.PendapatanLainLain, Persistent.CoaEnum.eKind.BiayaLainLain, CoaEnum.eKind.Kas, CoaEnum.eKind.Bank, CoaEnum.eKind.Piutang, CoaEnum.eKind.AktivaTetap, CoaEnum.eKind.AkumulasiPenyusutan, CoaEnum.eKind.AktivaLancarLainnya, CoaEnum.eKind.Persediaan, CoaEnum.eKind.HutangJangkaPendek, CoaEnum.eKind.HutangJangkaPanjang, CoaEnum.eKind.HutangLancarLainnya, CoaEnum.eKind.Modal})
    txtAkun2.Properties.DataSource = Logic.Coa.GetCoa(_sesi, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.PendapatanLainLain, Persistent.CoaEnum.eKind.BiayaLainLain, CoaEnum.eKind.Kas, CoaEnum.eKind.Bank, CoaEnum.eKind.Piutang, CoaEnum.eKind.AktivaTetap, CoaEnum.eKind.AkumulasiPenyusutan, CoaEnum.eKind.AktivaLancarLainnya, CoaEnum.eKind.Persediaan, CoaEnum.eKind.HutangJangkaPendek, CoaEnum.eKind.HutangJangkaPanjang, CoaEnum.eKind.HutangLancarLainnya, CoaEnum.eKind.Modal})

    txtDivisi.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(_sesi)
  End Sub
  Overrides Sub Filter()
    Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
    Dim m02Setting As New Logic.FinaSetting(_sesi)
    If txtDivisi.EditValue Is Nothing Then
      Throw New Utils.Exception("Silahkan pilih divisi.", 0, "", "Laporan")
      Exit Sub
    End If

    AddParameter("NamaPerusahaan", abcSetting.NamaPerusahaan, GetType(System.String))
    AddParameter("FormatAngka", m02Setting.FormatAngka, GetType(System.String))
    AddParameter("FormatNumeric", m02Setting.NumericFormatString, GetType(System.String))
    AddParameter("CompanyName", abcSetting.NamaPerusahaan, GetType(String))
    AddParameter("Alamat1", abcSetting.Alamat1, GetType(String))
    AddParameter("Alamat2", abcSetting.Alamat2, GetType(String))
    AddParameter("BidangUsaha", abcSetting.BidangUsaha, GetType(String))
    AddParameter("NoFax", abcSetting.NoFax, GetType(String))
    AddParameter("NoTelp", abcSetting.NoTelp, GetType(String))
    If Not txtDivisi.EditValue Is Nothing Then
      AddParameter("DivisiCode", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Nama, GetType(String))
    End If

    AddParameter("Periode", txtPeriodeAwal.DateTime.ToString("dd-MMM-yy") & " s/d " & txtPeriodeAkhir.DateTime.ToString("dd-MMM-yy"), GetType(System.String))

    Select Case _jenis
      Case MainClass.reportName.DivisiLabaRugiCOA, MainClass.reportName.DivisiLabaRugiCOALevel
        LaporanLabaRugiCOA()
        Return
      Case MainClass.reportName.DivisiLabaRugiTahunan
        LaporanLabaRugiCOATahunan()
        Return
      Case MainClass.reportName.DivisiBukuBesar
        LaporanBukuBesar()
        Return
      Case MainClass.reportName.DivisiSaldo
        LaporanSaldoDivisi()
        Return
      Case MainClass.reportName.GLTransaksiHarianDivisi
        LaporanDaftarTransaksi()
        Return
    End Select
  End Sub
  Private Sub LaporanLabaRugiCOA()
    Dim xpCoa As New XPCollection(Of Persistent.Coa)(_sesi, CriteriaOperator.Parse("not Induk is null"))
    Dim a = From x In xpCoa Select x.Induk Distinct
    Dim pI As Integer
    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.SaldoCOA)(_sesi, New GroupOperator(GroupOperator.And, New NotOperator(New InOperator("Id", a)), New BinaryOperator("Tipe.Level1", CoaEnum.eLevel1.RugiLaba, BinaryOperatorType.Equal)))
    Dim pSaldoCOA As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, FilterDataBukuBesar)

    For pI = 0 To details.Count - 1
      details(pI).SaldoAkhir = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
    Next
    If chkSaldoNol.Checked = True Then
      _dataSource = details
    Else
      If details.Where(Function(m) m.SaldoAkhir <> 0).Count > 0 Then
        _dataSource = details.Where(Function(m) m.SaldoAkhir <> 0)
      Else
        _dataSource = details
      End If
    End If
  End Sub
  Private Function FilterDataBulanan(ByVal Bulan As Integer) As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)

    result.Add(New BinaryOperator("Bulan", Bulan, BinaryOperatorType.Equal))

    If Not Core.SSystem.UserInfo.GetUserDivision Is Nothing Then
      Dim right = From a In Core.SSystem.UserInfo.GetUserDivision Where a.Buka = True Select a.Divisi
      result.Add(New InOperator("AkunDetail.Divisi", right.ToList))
    End If
    If Not txtDivisi.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Divisi.Id", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Id, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Sub LaporanLabaRugiCOATahunan()
    Dim xpCoa As New XPCollection(Of Persistent.Coa)(_sesi, CriteriaOperator.Parse("not Induk is null"))
    Dim a = From x In xpCoa Select x.Induk Distinct
    Dim pI As Integer, pJ As Integer
    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.SaldoCOA)(_sesi, New GroupOperator(GroupOperator.And, New NotOperator(New InOperator("Id", a)), New BinaryOperator("Tipe.Level1", CoaEnum.eLevel1.RugiLaba, BinaryOperatorType.Equal)))
    Dim pSaldoCOA As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)


    For pJ = 1 To 12
      pSaldoCOA = New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, FilterDataBulanan(pJ))
      For pI = 0 To details.Count - 1
        Select Case pJ
          Case 1 : details(pI).m1 = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
          Case 2 : details(pI).m2 = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
          Case 3 : details(pI).m3 = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
          Case 4 : details(pI).m4 = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
          Case 5 : details(pI).m5 = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
          Case 6 : details(pI).m6 = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
          Case 7 : details(pI).m7 = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
          Case 8 : details(pI).m8 = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
          Case 9 : details(pI).m9 = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
          Case 10 : details(pI).m10 = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
          Case 11 : details(pI).m11 = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
          Case 12 : details(pI).m12 = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
        End Select
        details(pI).SaldoAkhir = details(pI).m1 + details(pI).m2 + details(pI).m3 + details(pI).m4 + details(pI).m5 + details(pI).m6 + details(pI).m7 + details(pI).m8 + details(pI).m9 + details(pI).m10 + details(pI).m11 + details(pI).m12
      Next
    Next
    If chkSaldoNol.Checked = True Then
      _dataSource = details
    Else
      If details.Where(Function(m) m.SaldoAkhir <> 0).Count > 0 Then
        _dataSource = details.Where(Function(m) m.SaldoAkhir <> 0)
      Else
        _dataSource = details
      End If
    End If
  End Sub
  Private Sub LaporanBukuBesar()
    Dim coa As DevExpress.Xpo.XPCollection(Of Persistent.Coa) = Logic.Coa.GetCoa(_sesi, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.PendapatanLainLain, Persistent.CoaEnum.eKind.BiayaLainLain, CoaEnum.eKind.Kas, CoaEnum.eKind.Bank, CoaEnum.eKind.Piutang, CoaEnum.eKind.AktivaTetap, CoaEnum.eKind.AkumulasiPenyusutan, CoaEnum.eKind.AktivaLancarLainnya, CoaEnum.eKind.Persediaan, CoaEnum.eKind.HutangJangkaPendek, CoaEnum.eKind.HutangJangkaPanjang, CoaEnum.eKind.HutangLancarLainnya, CoaEnum.eKind.Modal})
    coa.Criteria = CriteriaOperator.And(coa.Criteria, CreateCriteria())

    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, FilterDataBukuBesar)
    For i = 0 To coa.Count - 1
      Dim akunId As Integer = coa(i).Id
      Dim saldo As Double = 0
      saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPNameDivisi, akunId, txtPeriodeAwal.DateTime.ToString("yyyy-MM-dd"), CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Id)))

      If details.ToList.Exists(Function(m) m.AkunDetail.Id = akunId) Then
        Dim ok = details.ToList.Where(Function(c) c.AkunDetail.Id = akunId)
        For Each x In ok
          x.SaldoAwal = saldo
        Next
      Else
        If chkSaldoNol.Checked = True Then
          Dim item As New Persistent.Report.BukuBesar(_sesi)
          item.AkunDetail = coa(i)
          item.AkunMain = Nothing
          item.Debit = 0
          item.Id = akunId
          item.Keterangan = ""
          item.Kredit = 0
          item.NoBukti = ""
          item.SaldoAwal = saldo
          item.SumberData = Nothing
          item.Tanggal = txtPeriodeAwal.DateTime
          item.Urutan = 0
          details.Add(item)
        End If
      End If
    Next
    _dataSource = details
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"
    If Not Core.SSystem.UserInfo.GetUserDivision Is Nothing Then
      Dim right = From a In Core.SSystem.UserInfo.GetUserDivision Where a.Buka = True Select a.Divisi
      result.Add(New InOperator("Divisi", right.ToList))
    End If
    If Not txtAkun1.EditValue Is Nothing Then
      If txtAkun2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Kode", String.Format(format, txtAkun1.Text), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("Kode", txtAkun1.Text, txtAkun2.Text))
      End If
    End If
    result.Add(New BinaryOperator("Tipe.Level1", Persistent.CoaEnum.eLevel1.RugiLaba, BinaryOperatorType.Equal))
    Return GroupOperator.And(result)
  End Function
  Private Function FilterDataBukuBesar() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)

    If Not Core.SSystem.UserInfo.GetUserDivision Is Nothing Then
      Dim right = From a In Core.SSystem.UserInfo.GetUserDivision Where a.Buka = True Select a.Divisi
      result.Add(New InOperator("AkunDetail.Divisi", right.ToList))
    End If
    If Not txtAkun1.EditValue Is Nothing Then
      If txtAkun2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("AkunDetail.Kode", txtAkun1.Text, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("AkunDetail.Kode", txtAkun1.Text, txtAkun2.Text))
      End If
    End If
    result.Add(New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))
    If Not txtDivisi.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Divisi.Id", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Id, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function

  Private Sub LaporanSaldoDivisi()
    Dim xpCoa As New XPCollection(Of Persistent.Coa)(_sesi, CriteriaOperator.Parse("not Induk is null"))
    Dim a = From x In xpCoa Select x.Induk Distinct

    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.SaldoCOA)(_sesi, New GroupOperator(GroupOperator.And, New NotOperator(New InOperator("Id", a))))
    Dim pSaldoCOA As New DevExpress.Xpo.XPCollection(Of Persistent.xMesitechBukuBesar)(_sesi, FilterSaldo)

    Dim pI As Integer
    For pI = 0 To details.Count - 1
      Dim saldo As Double
      saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPNameDivisi, details(pI).Id, txtPeriodeAwal.DateTime.ToString("yyyy-MM-dd"), CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Id)))
      
      details(pI).SaldoAwal = saldo
      details(pI).MutasiDebit = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Debit)
      details(pI).MutasiKredit = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit)
    Next
    _dataSource = details
  End Sub
  Private Function FilterSaldo() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    result.Add(New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))
    If Not txtDivisi.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Divisi.Id", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Id, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Sub txtDivisi_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs)
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtDivisi.EditValue = Nothing
    End If
  End Sub
  Private Sub LaporanDaftarTransaksi()
    _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.xMesitechGlDetail)(_sesi, CreateCriteriaGL)
  End Sub
  Private Function CreateCriteriaGL() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"
    If Not Core.SSystem.UserInfo.GetUserDivision Is Nothing Then
      Dim right = From a In Core.SSystem.UserInfo.GetUserDivision Where a.Buka = True Select a.Divisi
      result.Add(New InOperator("Divisi", right.ToList))
    End If
    If Not txtPeriodeAwal.EditValue Is Nothing Then
      If txtPeriodeAkhir.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Main.Tanggal", txtPeriodeAwal.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("Main.Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))
      End If
    End If


    If Not txtAkun1.EditValue Is Nothing Then
      If txtAkun2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Akun.Kode", String.Format(format, txtAkun1.Text), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("Akun.Kode", txtAkun1.Text, txtAkun2.Text))
      End If
    End If
    Return GroupOperator.And(result)
  End Function
End Class