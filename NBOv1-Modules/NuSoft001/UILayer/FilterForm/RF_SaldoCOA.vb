Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent

Friend Class RF_SaldoCOA
  Private _jenis As Persistent.CustomReportTipe
  Sub New(jenis As Persistent.CustomReportTipe)
    ' This call is required by the designer.
    InitializeComponent()
    _jenis = jenis
    lytPeriode2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    lytPeriode22.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    layRegional.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    Select Case _jenis
      Case Persistent.CustomReportTipe.NeracaCOA
        Me.Text = "Filter Laporan - Neraca"
      Case Persistent.CustomReportTipe.LabaRugiCOA
        Me.Text = "Filter Laporan - Laba Rugi"
      Case Persistent.CustomReportTipe.NeracaSaldoCOA, CustomReportTipe.LabaRugiCOASummary
        If jenis = CustomReportTipe.LabaRugiCOASummary Then
          Me.Text = "Filter Laporan - Laba Rugi Summary"
          layRegional.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
          Me.Text = "Filter Laporan - Neraca Saldo"
        End If
        lytPeriode1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lytPeriode11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lytPeriode2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lytPeriode22.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
    End Select
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeData()
    Dim period = New DevExpress.Xpo.XPCollection(Of Persistent.Periode)(_sesi)
    txtPeriodeBulan.Properties.Items.Clear()
    For i = 1 To 12
      txtPeriodeBulan.Properties.Items.Add(MonthName(i))
    Next

    Dim z = From a In period Order By a.Id Descending Select a.Bulan, a.Tahun Take 1

    If z.Count > 0 Then
      If z(0).Bulan = 12 Then
        txtPeriodeBulan.SelectedIndex = 0
        txtPeriodeTahun.EditValue = z(0).Tahun + 1
      Else
        txtPeriodeBulan.SelectedIndex = z(0).Bulan
        txtPeriodeTahun.EditValue = z(0).Tahun
      End If
    Else
      txtPeriodeBulan.SelectedIndex = Now.Month - 1
      txtPeriodeTahun.EditValue = Now.Year
    End If

    txtPeriodeAwal.DateTime = New Date(Now.Year, Now.Month, 1)
    Dim xAkhirBulan As New Date(Now.Year, Now.Month, 1)

    txtPeriodeAkhir.DateTime = xAkhirBulan.AddMonths(1).AddDays(-(xAkhirBulan.AddMonths(1).Day))
    txtPeriodeAkhir.Properties.MinValue = txtPeriodeAwal.DateTime
    txtPeriodeAwal.Properties.MaxValue = txtPeriodeAkhir.DateTime

    txtRegional.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Regional)(_sesi)
  End Sub
  Overrides Sub Filter()
    If txtPeriodeTahun.EditValue Is Nothing Then
      Utils.Win.MessageBox.Show("Masukkan periode", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      Return
    End If

    Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
    ' Dim a As Modules.nusoftModSys.
    Dim m02Setting As New Logic.FinaSetting(_sesi)
    Dim reg = String.Empty

    If txtRegional.EditValue IsNot Nothing Then
      reg = txtRegional.Text
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
    AddParameter("Regional", reg, GetType(String))

    Select Case _jenis
      Case Persistent.CustomReportTipe.NeracaCOA
        AddParameter("Periode", txtPeriodeBulan.Text.ToUpper & " " & txtPeriodeTahun.Text, GetType(System.String))
        LaporanNeraca()
        Return
      Case Persistent.CustomReportTipe.LabaRugiCOA
        AddParameter("Periode", txtPeriodeBulan.Text.ToUpper & " " & txtPeriodeTahun.Text, GetType(System.String))
        LaporanLabaRugi()
        Return
      Case Persistent.CustomReportTipe.LabaRugiCOASummary
        AddParameter("Periode", txtPeriodeAwal.DateTime.ToString("dd-MMM-yy") & " s/d " & txtPeriodeAkhir.DateTime.ToString("dd-MMM-yy"), GetType(System.String))
        LaporanLabaRugiSummary()
        Return
      Case Persistent.CustomReportTipe.NeracaSaldoCOA
        AddParameter("Periode", txtPeriodeAwal.DateTime.ToString("dd-MMM-yy") & " s/d " & txtPeriodeAkhir.DateTime.ToString("dd-MMM-yy"), GetType(System.String))
        LaporanNeracaSaldo()
        Return
    End Select
  End Sub
  Private Function CreateCriteria(Optional BulanInTriwulan As Integer = 1, Optional IsSaldoKhusus As Boolean = False) As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If Core.SSystem.UserInfo.GetUserLevel = 0 Then
      result.Add(New BinaryOperator("Ext", True, BinaryOperatorType.Equal))
    End If
    result.Add(New BinaryOperator("Bulan", txtPeriodeBulan.SelectedIndex + BulanInTriwulan, BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("Tahun", txtPeriodeTahun.Text, BinaryOperatorType.Equal))

    Return GroupOperator.And(result)
  End Function
  Private Sub LaporanNeraca()
    Dim xpCoa As New XPCollection(Of Persistent.Coa)(_sesi, CriteriaOperator.Parse("not Induk is null"))
    Dim a = From x In xpCoa Select x.Induk Distinct

    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.SaldoCOA)(_sesi, New GroupOperator(GroupOperator.And, New NotOperator(New InOperator("Id", a)), New BinaryOperator("Tipe.Level1", CoaEnum.eLevel1.Neraca, BinaryOperatorType.Equal)))
    Dim pTanggal As Date
    pTanggal = New Date(CInt(txtPeriodeTahun.Text), txtPeriodeBulan.SelectedIndex + 1, 1) 'ketemu 01/februari/2014
    pTanggal = pTanggal.AddMonths(1) 'ketemu 01 maret 2014
    pTanggal = pTanggal.AddDays(-1) 'ketemu 28 februari 2014

    For pI = 0 To details.Count - 1
      Dim saldo As Double = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.ToString("yyyy-MM-dd"))))
      details(pI).SaldoAkhir = saldo
    Next
    If chkSaldoNol.Checked = True Then
      _dataSource = details
    Else
      _dataSource = details.Where(Function(m) m.SaldoAkhir <> 0)
    End If
  End Sub
  Private Sub LaporanLabaRugi()
    Dim xpCoa As New XPCollection(Of Persistent.Coa)(_sesi, CriteriaOperator.Parse("not Induk is null"))
    Dim a = From x In xpCoa Select x.Induk Distinct

    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.SaldoCOA)(_sesi, New GroupOperator(GroupOperator.And, New NotOperator(New InOperator("Id", a)), New BinaryOperator("Tipe.Level1", CoaEnum.eLevel1.RugiLaba, BinaryOperatorType.Equal)))
    Dim pTanggal As Date
    pTanggal = New Date(CInt(txtPeriodeTahun.Text), txtPeriodeBulan.SelectedIndex + 1, 1) 'ketemu 01/februari/2014
    pTanggal = pTanggal.AddMonths(1) 'ketemu 01 maret 2014
    pTanggal = pTanggal.AddDays(-1) 'ketemu 28 februari 2014

    For pI = 0 To details.Count - 1
      Dim saldo As Double = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.ToString("yyyy-MM-dd"))))
      details(pI).SaldoAkhir = saldo
    Next

    If chkSaldoNol.Checked = True Then
      _dataSource = details
    Else
      _dataSource = details.Where(Function(m) m.SaldoAkhir <> 0)
    End If
  End Sub
  Private Sub LaporanLabaRugiSummary()
    Dim xpCoa As New XPCollection(Of Persistent.Coa)(_sesi, CriteriaOperator.Parse("not Induk is null"))
    Dim a = From x In xpCoa Select x.Induk Distinct
    Dim pI As Integer
    Dim details As New XPCollection(Of Report.SaldoCOA)(_sesi, New GroupOperator(GroupOperator.And, New NotOperator(New InOperator("Id", a)), New BinaryOperator("Tipe.Level1", CoaEnum.eLevel1.RugiLaba, BinaryOperatorType.Equal)))
    Dim pSaldoCOA = New XPCollection(Of Report.BukuBesar)(_sesi, New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime)).ToList

    If txtRegional.EditValue IsNot Nothing Then
      pSaldoCOA = pSaldoCOA.Where(Function(w) w.Regional Is CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)).ToList
    End If

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
  Private Sub LaporanNeracaSaldo()
    Dim xpCoa As New XPCollection(Of Persistent.Coa)(_sesi, CriteriaOperator.Parse("not Induk is null"))
    Dim a = From x In xpCoa Select x.Induk Distinct

    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.SaldoCOA)(_sesi, New GroupOperator(GroupOperator.And, New NotOperator(New InOperator("Id", a))))
    Dim pSaldoCOA As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))

    Dim pI As Integer
    For pI = 0 To details.Count - 1
      Dim saldo As Double = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, details(pI).Id, txtPeriodeAwal.DateTime.ToString("yyyy-MM-dd"))))
      details(pI).SaldoAwal = saldo
      details(pI).MutasiDebit = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Debit)
      details(pI).MutasiKredit = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit)
    Next
    ' _dataSource = details
    If chkSaldoNol.Checked = True Then
      _dataSource = details
    Else
      If details.Where(Function(m) m.SaldoAkhir <> 0 And m.MutasiDebit <> 0 And m.MutasiKredit <> 0).Count > 0 Then
        _dataSource = details.Where(Function(m) m.SaldoAkhir <> 0 And m.MutasiDebit <> 0 And m.MutasiKredit <> 0)
      Else
        _dataSource = details
      End If
    End If
  End Sub

  Private Sub txtPeriodeAwal_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPeriodeAwal.EditValueChanging
    txtPeriodeAkhir.Properties.MinValue = CDate(e.NewValue)
  End Sub
  Private Sub txtPeriodeAkhir_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPeriodeAkhir.EditValueChanging
    txtPeriodeAwal.Properties.MaxValue = CDate(e.NewValue)
  End Sub

  Private Sub txtRegional_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtRegional.ButtonClick
    If e.Button.Kind = ButtonPredefines.Delete Then
      txtRegional.EditValue = Nothing
    End If
  End Sub
End Class