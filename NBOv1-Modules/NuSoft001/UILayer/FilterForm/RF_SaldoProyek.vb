Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Friend Class RF_SaldoProyek
  Private _jenis As MainClass.reportName
  Sub New(jenis As MainClass.reportName)
    ' This call is required by the designer.
    InitializeComponent()
    _jenis = jenis
    lytAkun1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    lytAkun2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    Select Case _jenis
      Case MainClass.reportName.ProyekLabaRugiCustom
        Me.Text = "Laba Rugi Proyek"
      Case MainClass.reportName.ProyekLabaRugiCOA
        Me.Text = "Laba Rugi Proyek"
      Case MainClass.reportName.ProyekBukuBesar
        Me.Text = "Buku Besar Proyek"
        lytAkun1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lytAkun2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
      Case MainClass.reportName.ProyekSaldo
        Me.Text = "Saldo Proyek"
    End Select
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeData()
    txtPeriodeAwal.DateTime = New Date(Now.Year, Now.Month, 1)
    Dim xAkhirBulan As New Date(Now.Year, Now.Month, 1)

    txtPeriodeAkhir.DateTime = xAkhirBulan.AddMonths(1).AddDays(-(xAkhirBulan.AddMonths(1).Day))
    'txtPeriodeAkhir.Properties.MinValue = txtPeriodeAwal.DateTime
    'txtPeriodeAwal.Properties.MaxValue = txtPeriodeAkhir.DateTime

    txtAkun1.Properties.DataSource = Logic.Coa.GetCoa(_sesi, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.PendapatanLainLain, Persistent.CoaEnum.eKind.BiayaLainLain, CoaEnum.eKind.Kas, CoaEnum.eKind.Bank, CoaEnum.eKind.Piutang, CoaEnum.eKind.AktivaLancarLainnya, CoaEnum.eKind.AkumulasiPenyusutan, CoaEnum.eKind.AktivaLancarLainnya, CoaEnum.eKind.Persediaan, CoaEnum.eKind.HutangJangkaPendek, CoaEnum.eKind.HutangJangkaPanjang, CoaEnum.eKind.HutangLancarLainnya, CoaEnum.eKind.Modal})
    txtAkun2.Properties.DataSource = Logic.Coa.GetCoa(_sesi, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.PendapatanLainLain, Persistent.CoaEnum.eKind.BiayaLainLain, CoaEnum.eKind.Kas, CoaEnum.eKind.Bank, CoaEnum.eKind.Piutang, CoaEnum.eKind.AktivaLancarLainnya, CoaEnum.eKind.AkumulasiPenyusutan, CoaEnum.eKind.AktivaLancarLainnya, CoaEnum.eKind.Persediaan, CoaEnum.eKind.HutangJangkaPendek, CoaEnum.eKind.HutangJangkaPanjang, CoaEnum.eKind.HutangLancarLainnya, CoaEnum.eKind.Modal})

    txtProyek.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)
    txtSubProyek.Properties.DataSource = New XPCollection(Of Persistent.ProyekSub)(_sesi)
    txtDivisi.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(_sesi)
  End Sub
  Overrides Sub Filter()
    Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
    Dim m02Setting As New Logic.FinaSetting(_sesi)
    'If txtProyek.EditValue Is Nothing And txtDivisi.EditValue Is Nothing Then
    '  Throw New Utils.Exception("Silahkan pilih proyek atau divisi.", 0, "", "Laporan")
    '  Exit Sub
    'End If
    'If Not txtProyek.EditValue Is Nothing Then
    '  If txtSubProyek.EditValue Is Nothing Then
    '    Throw New Utils.Exception("Silahkan pilih sub proyek.", 0, "", "Laporan")
    '    Exit Sub
    '  End If
    'End If


    AddParameter("NamaPerusahaan", abcSetting.NamaPerusahaan, GetType(System.String))
    AddParameter("FormatAngka", m02Setting.FormatAngka, GetType(System.String))
    AddParameter("FormatNumeric", m02Setting.NumericFormatString, GetType(System.String))
    AddParameter("CompanyName", abcSetting.NamaPerusahaan, GetType(String))
    AddParameter("Alamat1", abcSetting.Alamat1, GetType(String))
    AddParameter("Alamat2", abcSetting.Alamat2, GetType(String))
    AddParameter("BidangUsaha", abcSetting.BidangUsaha, GetType(String))
    AddParameter("NoFax", abcSetting.NoFax, GetType(String))
    AddParameter("NoTelp", abcSetting.NoTelp, GetType(String))
    If Not txtProyek.EditValue Is Nothing Then
      AddParameter("ProyekCode", CType(txtProyek.EditValue, Proyek).Kode, GetType(String))
      AddParameter("ProyekName", CType(txtProyek.EditValue, Proyek).Nama, GetType(String))
      If Not txtSubProyek.EditValue Is Nothing Then
        AddParameter("SubProyekCode", CType(txtSubProyek.EditValue, ProyekSub).Kode, GetType(String))
        AddParameter("SubProyekName", CType(txtSubProyek.EditValue, ProyekSub).Nama, GetType(String))
      End If
    Else
      AddParameter("ProyekCode", "All", GetType(String))
      AddParameter("ProyekName", "All", GetType(String))
      AddParameter("SubProyekCode", "All", GetType(String))
      AddParameter("SubProyekName", "All", GetType(String))
    End If
    If Not txtDivisi.EditValue Is Nothing Then
      AddParameter("DivisiCode", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Kode, GetType(String))
    Else
      AddParameter("DivisiCode", "All", GetType(String))
    End If

    AddParameter("Periode", txtPeriodeAwal.DateTime.ToString("dd-MMM-yy") & " s/d " & txtPeriodeAkhir.DateTime.ToString("dd-MMM-yy"), GetType(System.String))
    Select Case _jenis
      Case MainClass.reportName.ProyekLabaRugiCOA
        LaporanLabaRugiCOA()
        Return
      Case MainClass.reportName.ProyekBukuBesar
        LaporanBukuBesar()
        Return
      Case MainClass.reportName.ProyekSaldo
        LaporanSaldoProyek()
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
  Private Sub LaporanBukuBesar()
    Dim coa As DevExpress.Xpo.XPCollection(Of Persistent.Coa) = Logic.Coa.GetCoa(_sesi, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.PendapatanLainLain, Persistent.CoaEnum.eKind.BiayaLainLain})
    coa.Criteria = CriteriaOperator.And(coa.Criteria, CreateCriteria())

    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.xMesitechBukuBesar)(_sesi, FilterDataBukuBesar)
    For i = 0 To coa.Count - 1
      Dim akunId As Integer = coa(i).Id
      Dim saldo As Double = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, akunId, txtPeriodeAwal.DateTime.ToString("yyyy-MM-dd"))))

      If details.ToList.Exists(Function(m) m.AkunDetail.Id = akunId) Then
        Dim ok = details.ToList.Where(Function(c) c.AkunDetail.Id = akunId)
        For Each x In ok
          x.SaldoAwal = saldo
        Next
      Else
        If chkSaldoNol.Checked = True Then
          Dim item As New Persistent.xMesitechBukuBesar(_sesi)
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
    If Not txtSubProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("ProyekSub.Id", CType(txtSubProyek.EditValue, Persistent.ProyekSub).Id, BinaryOperatorType.Equal))
    End If
    result.Add(New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))
    If Not txtProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Proyek.Id", CType(txtProyek.EditValue, Persistent.Proyek).Id, BinaryOperatorType.Equal))
    Else
      result.Add(New BinaryOperator("Proyek.Id", 0, BinaryOperatorType.Greater))
    End If
    If Not txtDivisi.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Divisi.Id", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Id, BinaryOperatorType.Equal))
    End If
    'result.Add(New BinaryOperator("AkunDetail.Tipe.Level1", Persistent.CoaEnum.eLevel1.RugiLaba, BinaryOperatorType.Equal))
    Return GroupOperator.And(result)
  End Function
  Private Sub LaporanSaldoProyek()
    Dim xpCoa As New XPCollection(Of Persistent.Coa)(_sesi, CriteriaOperator.Parse("not Induk is null"))
    Dim a = From x In xpCoa Select x.Induk Distinct

    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.SaldoCOA)(_sesi, New GroupOperator(GroupOperator.And, New NotOperator(New InOperator("Id", a))))
    Dim pSaldoCOA As New DevExpress.Xpo.XPCollection(Of Persistent.xMesitechBukuBesar)(_sesi, FilterSaldo)

    Dim pI As Integer
    For pI = 0 To details.Count - 1
      Dim saldo As Double
      If Not txtSubProyek.EditValue Is Nothing Then
        saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, details(pI).Id, txtPeriodeAwal.DateTime.ToString("yyyy-MM-dd"), CType(txtProyek.EditValue, Persistent.Proyek).Id, CType(txtSubProyek.EditValue, Persistent.ProyekSub).Id)))
      Else
        If Not txtProyek.EditValue Is Nothing Then
          saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, details(pI).Id, txtPeriodeAwal.DateTime.ToString("yyyy-MM-dd"), CType(txtProyek.EditValue, Persistent.Proyek).Id, 0)))
        Else
          saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, details(pI).Id, txtPeriodeAwal.DateTime.ToString("yyyy-MM-dd"), 0, 0)))
        End If
      End If
      details(pI).SaldoAwal = saldo
      details(pI).MutasiDebit = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Debit)
      details(pI).MutasiKredit = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit)
    Next
    _dataSource = details
  End Sub
  Private Function FilterSaldo() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    result.Add(New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))
    If Not txtProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Proyek.Id", CType(txtProyek.EditValue, Persistent.Proyek).Id, BinaryOperatorType.Equal))
    End If
    If Not txtSubProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("ProyekSub.Id", CType(txtSubProyek.EditValue, Persistent.ProyekSub).Id, BinaryOperatorType.Equal))
    End If
    If Not txtDivisi.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Divisi.Id", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Id, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Sub txtPeriodeAwal_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPeriodeAwal.EditValueChanging
    'txtPeriodeAkhir.Properties.MinValue = CDate(e.NewValue)
  End Sub
  Private Sub txtPeriodeAkhir_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPeriodeAkhir.EditValueChanging
    'txtPeriodeAwal.Properties.MaxValue = CDate(e.NewValue)
  End Sub
  Private Sub txtProyek_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtProyek.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtProyek.EditValue = Nothing
    End If
  End Sub
  Private Sub txtSubProyek_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtSubProyek.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtSubProyek.EditValue = Nothing
    End If
  End Sub
  Private Sub txtDivisi_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtDivisi.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtDivisi.EditValue = Nothing
    End If
  End Sub
End Class