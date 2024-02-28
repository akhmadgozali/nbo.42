Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent

Friend Class RF_SaldoCOAGlobal
  Private _jenis As MainClass.reportName
  Sub New(jenis As MainClass.reportName)
    ' This call is required by the designer.
    InitializeComponent()
    _jenis = jenis
    Select Case _jenis
      Case MainClass.reportName.FNNeracaTahunan, MainClass.reportName.FNNeracaTahunanStandar
        Me.Text = "Filter Laporan - Neraca"
        lytNeraca.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        txtPeriodeBulan.Properties.ReadOnly = True
      Case MainClass.reportName.FNLabaRugiTahunanx, MainClass.reportName.FNLabaRugiTahunanStandar
        Me.Text = "Filter Laporan - Laba Rugi"
        lytNeraca.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lytLR.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtPeriodeBulan.Properties.ReadOnly = True
        lytRegional.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

      Case MainClass.reportName.FNNeracaGlobal
        Me.Text = "Filter Laporan - Neraca"
        lytNeraca.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
      Case MainClass.reportName.FNLabaRugiGlobal
        Me.Text = "Filter Laporan - Laba Rugi"
        lytLR.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lytPeriode1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lytPeriode11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lytPeriode2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lytPeriode22.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
    End Select
    txtTipeNeraca.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.TipeReportNeraca))
    txtTipeNeraca.EditValue = Persistent.TipeReportNeraca.xGlobal
    txtTipeLR.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.TipeReportLabaRugi))
    txtTipeLR.EditValue = Persistent.TipeReportLabaRugi.xGlobal
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

    txtRegional.Properties.DataSource = New XPCollection(Of NuSoft.NPO.Modules.ModSys.Regional)(_sesi)
    txtDivisi.Properties.DataSource = New XPCollection(Of NuSoft.NPO.Modules.ModSys.Divisi)(_sesi)
    txtProyek.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)

    txtDivisi.EditValue = NuSoft.Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtDivisi)
    txtProyek.EditValue = NuSoft.Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtProyek)
  End Sub
  Overrides Sub Filter()
    If txtPeriodeTahun.EditValue Is Nothing Then
      Utils.Win.MessageBox.Show("Masukkan periode", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      Exit Sub
    End If
    If _jenis = MainClass.reportName.FNNeracaGlobal Then
      If CType(txtTipeNeraca.EditValue, Persistent.TipeReportNeraca) = TipeReportNeraca.xRegional AndAlso txtRegional.EditValue Is Nothing Then
        Throw New Utils.Exception("Silahkan pilih regional terlebih dahulu.", 0, "", "Filter Report")
        Exit Sub
      End If
    End If
    If _jenis = MainClass.reportName.FNLabaRugiGlobal Then
      If CType(txtTipeLR.EditValue, Persistent.TipeReportLabaRugi) = TipeReportLabaRugi.xRegional AndAlso txtRegional.EditValue Is Nothing Then
        Throw New Utils.Exception("Silahkan pilih regional terlebih dahulu.", 0, "", "Filter Report")
        Exit Sub
      End If
      If CType(txtTipeLR.EditValue, Persistent.TipeReportLabaRugi) = TipeReportLabaRugi.xDivisi AndAlso txtDivisi.EditValue Is Nothing Then
        Throw New Utils.Exception("Silahkan pilih divisi terlebih dahulu.", 0, "", "Filter Report")
        Exit Sub
      End If
      If CType(txtTipeLR.EditValue, Persistent.TipeReportLabaRugi) = TipeReportLabaRugi.xProyek AndAlso txtProyek.EditValue Is Nothing Then
        Throw New Utils.Exception("Silahkan pilih proyek terlebih dahulu.", 0, "", "Filter Report")
        Exit Sub
      End If
    End If

    Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
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
      Case MainClass.reportName.FNNeracaGlobal
        AddParameter("Periode", txtPeriodeBulan.Text.ToUpper & " " & txtPeriodeTahun.Text, GetType(System.String))
        If CType(txtTipeNeraca.EditValue, Persistent.TipeReportNeraca) = TipeReportNeraca.xGlobal Then
          AddParameter("Keterangan", "", GetType(String))
        Else
          AddParameter("Keterangan", "Regional : " & CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Nama, GetType(String))
        End If
        LaporanNeraca()
        Return
      Case MainClass.reportName.FNLabaRugiGlobal
        'AddParameter("Periode", txtPeriodeBulan.Text.ToUpper & " " & txtPeriodeTahun.Text, GetType(System.String))
        AddParameter("Periode", txtPeriodeAwal.DateTime.ToString("dd-MMM-yy") & " s/d " & txtPeriodeAkhir.DateTime.ToString("dd-MMM-yy"), GetType(System.String))
        Select Case CType(txtTipeLR.EditValue, Persistent.TipeReportLabaRugi)
          Case TipeReportLabaRugi.xGlobal
            AddParameter("Keterangan", "", GetType(String))
          Case TipeReportLabaRugi.xRegional
            AddParameter("Keterangan", "Regional : " & CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Nama, GetType(String))
          Case TipeReportLabaRugi.xDivisi
            AddParameter("Keterangan", "Divisi : " & CType(txtDivisi.EditValue, NuSoft.NPO.Modules.ModSys.Divisi).Nama, GetType(String))
          Case TipeReportLabaRugi.xProyek
            AddParameter("Keterangan", "Proyek : " & CType(txtProyek.EditValue, Persistent.Proyek).Nama, GetType(String))
        End Select
        LaporanLabaRugi()
        Return
      Case MainClass.reportName.FNNeracaTahunan
        AddParameter("Periode", txtPeriodeTahun.Text, GetType(System.String))
        If CType(txtTipeNeraca.EditValue, Persistent.TipeReportNeraca) = TipeReportNeraca.xGlobal Then
          AddParameter("Keterangan", "", GetType(String))
        Else
          AddParameter("Keterangan", "Regional : " & CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Nama, GetType(String))
        End If
        LaporanNeracaTahunan()
        Return
      Case MainClass.reportName.FNLabaRugiTahunanx
        AddParameter("Periode", txtPeriodeTahun.Text, GetType(System.String))
        Select Case CType(txtTipeLR.EditValue, Persistent.TipeReportLabaRugi)
          Case TipeReportLabaRugi.xGlobal
            AddParameter("Keterangan", "", GetType(String))
          Case TipeReportLabaRugi.xRegional
            AddParameter("Keterangan", "Regional : " & CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Nama, GetType(String))
          Case TipeReportLabaRugi.xDivisi
            AddParameter("Keterangan", "Divisi : " & CType(txtDivisi.EditValue, NuSoft.NPO.Modules.ModSys.Divisi).Nama, GetType(String))
          Case TipeReportLabaRugi.xProyek
            AddParameter("Keterangan", "Proyek : " & CType(txtProyek.EditValue, Persistent.Proyek).Nama, GetType(String))
        End Select
        LaporanLabaRugiTahunan()
        Return
      Case MainClass.reportName.FNNeracaTahunanStandar
        AddParameter("Periode", txtPeriodeTahun.Text, GetType(System.String))
        If CType(txtTipeNeraca.EditValue, Persistent.TipeReportNeraca) = TipeReportNeraca.xGlobal Then
          AddParameter("Keterangan", "", GetType(String))
        Else
          AddParameter("Keterangan", "Regional : " & CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Nama, GetType(String))
        End If
        LaporanNeracaTahunans()
        Return
      Case MainClass.reportName.FNLabaRugiTahunanStandar
        AddParameter("Periode", txtPeriodeTahun.Text, GetType(System.String))
        Select Case CType(txtTipeLR.EditValue, Persistent.TipeReportLabaRugi)
          Case TipeReportLabaRugi.xGlobal
            AddParameter("Keterangan", "", GetType(String))
          Case TipeReportLabaRugi.xRegional
            AddParameter("Keterangan", "Regional : " & CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Nama, GetType(String))
          Case TipeReportLabaRugi.xDivisi
            AddParameter("Keterangan", "Divisi : " & CType(txtDivisi.EditValue, NuSoft.NPO.Modules.ModSys.Divisi).Nama, GetType(String))
          Case TipeReportLabaRugi.xProyek
            AddParameter("Keterangan", "Proyek : " & CType(txtProyek.EditValue, Persistent.Proyek).Nama, GetType(String))
        End Select
        LaporanLabaRugiTahunans()
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
      Dim saldo As Double = 0
      If CType(txtTipeNeraca.EditValue, Persistent.TipeReportNeraca) = TipeReportNeraca.xGlobal Then
        saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.ToString("yyyy-MM-dd"))))
      Else
        saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.ToString("yyyy-MM-dd"))))
      End If
      details(pI).SaldoAkhir = saldo
    Next
    If chkSaldoNol.Checked = True Then
      _dataSource = details
    Else
      _dataSource = details.Where(Function(m) m.SaldoAkhir <> 0)
    End If
  End Sub
  Private Sub LaporanLabaRugix()
    Dim xpCoa As New XPCollection(Of Persistent.Coa)(_sesi, CriteriaOperator.Parse("not Induk is null"))
    Dim a = From x In xpCoa Select x.Induk Distinct

    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.SaldoCOA)(_sesi, New GroupOperator(GroupOperator.And, New NotOperator(New InOperator("Id", a)), New BinaryOperator("Tipe.Level1", CoaEnum.eLevel1.RugiLaba, BinaryOperatorType.Equal)))
    Dim pTanggal As Date
    pTanggal = New Date(CInt(txtPeriodeTahun.Text), txtPeriodeBulan.SelectedIndex + 1, 1) 'ketemu 01/februari/2014
    pTanggal = pTanggal.AddMonths(1) 'ketemu 01 maret 2014
    pTanggal = pTanggal.AddDays(-1) 'ketemu 28 februari 2014

    For pI = 0 To details.Count - 1
      Dim saldo As Double = 0
      Select Case CType(txtTipeLR.EditValue, Persistent.TipeReportLabaRugi)
        Case TipeReportLabaRugi.xGlobal
          saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.ToString("yyyy-MM-dd"))))
        Case TipeReportLabaRugi.xRegional
          saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.ToString("yyyy-MM-dd"))))
        Case TipeReportLabaRugi.xDivisi
          saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoDivisi, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Divisi).Id, pTanggal.ToString("yyyy-MM-dd"))))
        Case TipeReportLabaRugi.xProyek
          saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoProyek, details(pI).Id, CType(txtRegional.EditValue, Persistent.Proyek).Id, pTanggal.ToString("yyyy-MM-dd"))))
      End Select
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

    Dim pI As Integer
    Dim pSaldoCOA As DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar) = Nothing

    Select Case CType(txtTipeLR.EditValue, Persistent.TipeReportLabaRugi)
      Case TipeReportLabaRugi.xRegional
        pSaldoCOA = New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, New GroupOperator(GroupOperator.And, New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime), New BinaryOperator("Regional", CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional), BinaryOperatorType.Equal)))
      Case TipeReportLabaRugi.xDivisi
        pSaldoCOA = New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, New GroupOperator(GroupOperator.And, New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime), New BinaryOperator("Divisi", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi), BinaryOperatorType.Equal)))
      Case TipeReportLabaRugi.xProyek
        pSaldoCOA = New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, New GroupOperator(GroupOperator.And, New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime), New BinaryOperator("Proyek", CType(txtProyek.EditValue, Persistent.Proyek), BinaryOperatorType.Equal)))
      Case Else 'global
        pSaldoCOA = New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))
    End Select


    For pI = 0 To details.Count - 1
      details(pI).SaldoAkhir = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
    Next

    If chkSaldoNol.Checked = True Then
      _dataSource = details
    Else
      _dataSource = details.Where(Function(m) m.SaldoAkhir <> 0)
    End If

  End Sub
  Private Sub txtPeriodeAwal_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPeriodeAwal.EditValueChanging
    txtPeriodeAkhir.Properties.MinValue = CDate(e.NewValue)
  End Sub
  Private Sub txtPeriodeAkhir_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPeriodeAkhir.EditValueChanging
    txtPeriodeAwal.Properties.MaxValue = CDate(e.NewValue)
  End Sub
  Private Sub txtTipeNeraca_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTipeNeraca.EditValueChanging
    If CType(e.NewValue, Persistent.TipeReportNeraca) = TipeReportNeraca.xGlobal Then
      lytRegional.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
      If _jenis = MainClass.reportName.FNLabaRugiTahunanStandar Then
        lytRegional.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
      End If
    Else
      lytRegional.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
    End If
  End Sub
  Private Sub txtTipeLR_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTipeLR.EditValueChanging
    lytRegional.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    lytDivisi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    lytProyek.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    Select Case CType(e.NewValue, Persistent.TipeReportLabaRugi)
      Case TipeReportLabaRugi.xGlobal
      Case TipeReportLabaRugi.xRegional : lytRegional.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
      Case TipeReportLabaRugi.xDivisi : lytDivisi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
      Case TipeReportLabaRugi.xProyek : lytProyek.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
    End Select

    If _jenis = MainClass.reportName.FNLabaRugiTahunanStandar Then
      lytRegional.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
    End If
  End Sub
  Private Sub txtRegional_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtRegional.ButtonClick
    If e.Button.Kind = ButtonPredefines.Delete Then
      txtRegional.EditValue = Nothing
    End If
  End Sub

  Private Sub LaporanNeracaTahunan()
    Dim xpCoa As New XPCollection(Of Persistent.Coa)(_sesi, CriteriaOperator.Parse("not Induk is null"))
    Dim a = From x In xpCoa Select x.Induk Distinct

    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.SaldoCOA)(_sesi, New GroupOperator(GroupOperator.And, New NotOperator(New InOperator("Id", a)), New BinaryOperator("Tipe.Level1", CoaEnum.eLevel1.Neraca, BinaryOperatorType.Equal)))
    Dim pTanggal As Date
    pTanggal = New Date(CInt(txtPeriodeTahun.Text), 3, 31) 'ketemu 01/februari/2014

    For pI = 0 To details.Count - 1
      'Dim saldo As Double = 0
      'If CType(txtTipeNeraca.EditValue, Persistent.TipeReportNeraca) = TipeReportNeraca.xGlobal Then
      '  saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.ToString("yyyy-MM-dd"))))
      'Else
      '  saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.ToString("yyyy-MM-dd"))))
      'End If
      'details(pI).SaldoAkhir = saldo

      If CType(txtTipeNeraca.EditValue, Persistent.TipeReportNeraca) = TipeReportNeraca.xGlobal Then
        details(pI).m1 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(1).ToString("yyyy-MM-dd"))))
        details(pI).m2 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(2).ToString("yyyy-MM-dd"))))
        details(pI).m3 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(3).ToString("yyyy-MM-dd"))))
        details(pI).m4 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(4).ToString("yyyy-MM-dd"))))
        details(pI).m5 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(5).ToString("yyyy-MM-dd"))))
        details(pI).m6 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(6).ToString("yyyy-MM-dd"))))
        details(pI).m7 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(7).ToString("yyyy-MM-dd"))))
        details(pI).m8 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(8).ToString("yyyy-MM-dd"))))
        details(pI).m9 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(9).ToString("yyyy-MM-dd"))))
        details(pI).m10 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(10).ToString("yyyy-MM-dd"))))
        details(pI).m11 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(11).ToString("yyyy-MM-dd"))))
        details(pI).m12 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(12).ToString("yyyy-MM-dd"))))
      Else
        details(pI).m1 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(1).ToString("yyyy-MM-dd"))))
        details(pI).m2 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(2).ToString("yyyy-MM-dd"))))
        details(pI).m3 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(3).ToString("yyyy-MM-dd"))))
        details(pI).m4 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(4).ToString("yyyy-MM-dd"))))
        details(pI).m5 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(5).ToString("yyyy-MM-dd"))))
        details(pI).m6 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(6).ToString("yyyy-MM-dd"))))
        details(pI).m7 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(7).ToString("yyyy-MM-dd"))))
        details(pI).m8 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(8).ToString("yyyy-MM-dd"))))
        details(pI).m9 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(9).ToString("yyyy-MM-dd"))))
        details(pI).m10 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(10).ToString("yyyy-MM-dd"))))
        details(pI).m11 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(11).ToString("yyyy-MM-dd"))))
        details(pI).m12 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(12).ToString("yyyy-MM-dd"))))
      End If
    Next
    'If chkSaldoNol.Checked = True Then
    _dataSource = details
    'Else
    '_dataSource = details.Where(Function(m) m.SaldoAkhir <> 0)
    'End If
  End Sub
  Private Sub LaporanLabaRugiTahunan()
    Dim xpCoa As New XPCollection(Of Persistent.Coa)(_sesi, CriteriaOperator.Parse("not Induk is null"))
    Dim a = From x In xpCoa Select x.Induk Distinct
    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.SaldoCOA)(_sesi, New GroupOperator(GroupOperator.And, New NotOperator(New InOperator("Id", a)), New BinaryOperator("Tipe.Level1", CoaEnum.eLevel1.RugiLaba, BinaryOperatorType.Equal)))

    Dim pTanggal As Date
    pTanggal = New Date(CInt(txtPeriodeTahun.Text), 3, 31) 'ketemu 01/februari/2014
    For pI = 0 To details.Count - 1
      details(pI).m1 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(1).ToString("yyyy-MM-dd"))))
      details(pI).m2 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(2).ToString("yyyy-MM-dd"))))
      details(pI).m3 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(3).ToString("yyyy-MM-dd"))))
      details(pI).m4 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(4).ToString("yyyy-MM-dd"))))
      details(pI).m5 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(5).ToString("yyyy-MM-dd"))))
      details(pI).m6 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(6).ToString("yyyy-MM-dd"))))
      details(pI).m7 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(7).ToString("yyyy-MM-dd"))))
      details(pI).m8 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(8).ToString("yyyy-MM-dd"))))
      details(pI).m9 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(9).ToString("yyyy-MM-dd"))))
      details(pI).m10 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(10).ToString("yyyy-MM-dd"))))
      details(pI).m11 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(11).ToString("yyyy-MM-dd"))))
      details(pI).m12 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(12).ToString("yyyy-MM-dd"))))
      If details(pI).Tipe.Level2 = CoaEnum.eLevel2.Biaya Then
        details(pI).m1 = details(pI).m1 * -1
        details(pI).m2 = details(pI).m2 * -1
        details(pI).m3 = details(pI).m3 * -1
        details(pI).m4 = details(pI).m4 * -1
        details(pI).m5 = details(pI).m5 * -1
        details(pI).m6 = details(pI).m6 * -1
        details(pI).m7 = details(pI).m7 * -1
        details(pI).m8 = details(pI).m8 * -1
        details(pI).m9 = details(pI).m9 * -1
        details(pI).m10 = details(pI).m10 * -1
        details(pI).m11 = details(pI).m11 * -1
        details(pI).m12 = details(pI).m12 * -1
      End If
    Next

    _dataSource = details
  End Sub

  Private Sub LaporanNeracaTahunans()
    Dim xpCoa As New XPCollection(Of Persistent.Coa)(_sesi, CriteriaOperator.Parse("not Induk is null"))
    Dim a = From x In xpCoa Select x.Induk Distinct

    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.SaldoCOA)(_sesi, New GroupOperator(GroupOperator.And, New NotOperator(New InOperator("Id", a)), New BinaryOperator("Tipe.Level1", CoaEnum.eLevel1.Neraca, BinaryOperatorType.Equal)))
    Dim pTanggal As Date
    pTanggal = New Date(CInt(txtPeriodeTahun.Text), 1, 31) 'ketemu 25/Januari/2014

    For pI = 0 To details.Count - 1
      If CType(txtTipeNeraca.EditValue, Persistent.TipeReportNeraca) = TipeReportNeraca.xGlobal Then
        details(pI).m1 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(0).ToString("yyyy-MM-dd"))))
        details(pI).m2 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(1).ToString("yyyy-MM-dd"))))
        details(pI).m3 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(2).ToString("yyyy-MM-dd"))))
        details(pI).m4 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(3).ToString("yyyy-MM-dd"))))
        details(pI).m5 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(4).ToString("yyyy-MM-dd"))))
        details(pI).m6 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(5).ToString("yyyy-MM-dd"))))
        details(pI).m7 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(6).ToString("yyyy-MM-dd"))))
        details(pI).m8 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(7).ToString("yyyy-MM-dd"))))
        details(pI).m9 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(8).ToString("yyyy-MM-dd"))))
        details(pI).m10 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(9).ToString("yyyy-MM-dd"))))
        details(pI).m11 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(10).ToString("yyyy-MM-dd"))))
        details(pI).m12 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(11).ToString("yyyy-MM-dd"))))
      Else
        details(pI).m1 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(0).ToString("yyyy-MM-dd"))))
        details(pI).m2 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(1).ToString("yyyy-MM-dd"))))
        details(pI).m3 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(2).ToString("yyyy-MM-dd"))))
        details(pI).m4 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(3).ToString("yyyy-MM-dd"))))
        details(pI).m5 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(4).ToString("yyyy-MM-dd"))))
        details(pI).m6 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(5).ToString("yyyy-MM-dd"))))
        details(pI).m7 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(6).ToString("yyyy-MM-dd"))))
        details(pI).m8 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(7).ToString("yyyy-MM-dd"))))
        details(pI).m9 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(8).ToString("yyyy-MM-dd"))))
        details(pI).m10 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(9).ToString("yyyy-MM-dd"))))
        details(pI).m11 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(10).ToString("yyyy-MM-dd"))))
        details(pI).m12 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, pTanggal.AddMonths(11).ToString("yyyy-MM-dd"))))
      End If
    Next
    'If chkSaldoNol.Checked = True Then
    _dataSource = details
    'Else
    '_dataSource = details.Where(Function(m) m.SaldoAkhir <> 0)
    'End If
  End Sub
  Private Sub LaporanLabaRugiTahunans()
    Dim xpCoa As New XPCollection(Of Persistent.Coa)(_sesi, CriteriaOperator.Parse("not Induk is null"))
    Dim a = From x In xpCoa Select x.Induk Distinct
    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.SaldoCOA)(_sesi, New GroupOperator(GroupOperator.And, New NotOperator(New InOperator("Id", a)), New BinaryOperator("Tipe.Level1", CoaEnum.eLevel1.RugiLaba, BinaryOperatorType.Equal)))

    Dim pTanggal As Date
    pTanggal = New Date(CInt(txtPeriodeTahun.Text), 1, 31) 'ketemu 25/januari/2014
    For pI = 0 To details.Count - 1
      If txtRegional.EditValue IsNot Nothing Then
        Dim itemRegional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
        details(pI).m1 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, itemRegional.Id, pTanggal.AddMonths(0).ToString("yyyy-MM-dd"))))
        details(pI).m2 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, itemRegional.Id, pTanggal.AddMonths(1).ToString("yyyy-MM-dd"))))
        details(pI).m3 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, itemRegional.Id, pTanggal.AddMonths(2).ToString("yyyy-MM-dd"))))
        details(pI).m4 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, itemRegional.Id, pTanggal.AddMonths(3).ToString("yyyy-MM-dd"))))
        details(pI).m5 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, itemRegional.Id, pTanggal.AddMonths(4).ToString("yyyy-MM-dd"))))
        details(pI).m6 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, itemRegional.Id, pTanggal.AddMonths(5).ToString("yyyy-MM-dd"))))
        details(pI).m7 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, itemRegional.Id, pTanggal.AddMonths(6).ToString("yyyy-MM-dd"))))
        details(pI).m8 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, itemRegional.Id, pTanggal.AddMonths(7).ToString("yyyy-MM-dd"))))
        details(pI).m9 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, itemRegional.Id, pTanggal.AddMonths(8).ToString("yyyy-MM-dd"))))
        details(pI).m10 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, itemRegional.Id, pTanggal.AddMonths(9).ToString("yyyy-MM-dd"))))
        details(pI).m11 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, itemRegional.Id, pTanggal.AddMonths(10).ToString("yyyy-MM-dd"))))
        details(pI).m12 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldoRegional, details(pI).Id, itemRegional.Id, pTanggal.AddMonths(11).ToString("yyyy-MM-dd"))))
      Else
        details(pI).m1 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(0).ToString("yyyy-MM-dd"))))
        details(pI).m2 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(1).ToString("yyyy-MM-dd"))))
        details(pI).m3 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(2).ToString("yyyy-MM-dd"))))
        details(pI).m4 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(3).ToString("yyyy-MM-dd"))))
        details(pI).m5 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(4).ToString("yyyy-MM-dd"))))
        details(pI).m6 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(5).ToString("yyyy-MM-dd"))))
        details(pI).m7 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(6).ToString("yyyy-MM-dd"))))
        details(pI).m8 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(7).ToString("yyyy-MM-dd"))))
        details(pI).m9 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(8).ToString("yyyy-MM-dd"))))
        details(pI).m10 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(9).ToString("yyyy-MM-dd"))))
        details(pI).m11 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(10).ToString("yyyy-MM-dd"))))
        details(pI).m12 = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.AddMonths(11).ToString("yyyy-MM-dd"))))
      End If
      If details(pI).Tipe.Level2 = CoaEnum.eLevel2.Biaya Then
        details(pI).m1 = details(pI).m1 * -1
        details(pI).m2 = details(pI).m2 * -1
        details(pI).m3 = details(pI).m3 * -1
        details(pI).m4 = details(pI).m4 * -1
        details(pI).m5 = details(pI).m5 * -1
        details(pI).m6 = details(pI).m6 * -1
        details(pI).m7 = details(pI).m7 * -1
        details(pI).m8 = details(pI).m8 * -1
        details(pI).m9 = details(pI).m9 * -1
        details(pI).m10 = details(pI).m10 * -1
        details(pI).m11 = details(pI).m11 * -1
        details(pI).m12 = details(pI).m12 * -1
      End If
    Next

    _dataSource = details
  End Sub
End Class