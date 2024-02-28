Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports NuSoft.Utils.CustomAttribute

Friend Class RF_CashFlowMesitechx
  Private _jenis As MainClass.reportName
  Private Enum eLevel
    <EnumDescription("Level 1")> Level1
    <EnumDescription("Level 2")> Level2
    <EnumDescription("Level 3")> Level3
    <EnumDescription("Level 4")> Level4
  End Enum
  Sub New(jenis As MainClass.reportName)
    ' This call is required by the designer.
    InitializeComponent()
    _jenis = jenis
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeData()
    txtPeriodeAwal.DateTime = New Date(Now.Year, Now.Month, 1)
    Dim xAkhirBulan As New Date(Now.Year, Now.Month, 1)
    txtPeriodeAkhir.DateTime = xAkhirBulan.AddMonths(1).AddDays(-(xAkhirBulan.AddMonths(1).Day))

    txtProyek.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)
    txtSubProyek.Properties.DataSource = New XPCollection(Of Persistent.ProyekSub)(_sesi)
    txtDivisi.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(_sesi)

    txtLevel.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(eLevel))
    txtLevel.EditValue = eLevel.Level4

    If _jenis = MainClass.reportName.zCashFlowTahunan Then
      txtPeriodeAwal.DateTime = New Date(Now.Year, 1, 1)
      txtPeriodeAkhir.DateTime = New Date(Now.Year, 12, 1)
    End If
    If _jenis = MainClass.reportName.zCashFlowDetail Then
      txtLevel.Properties.ReadOnly = True
      chkSaldoNol.Properties.ReadOnly = True
    End If
  End Sub
  Overrides Sub Filter()
    Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
    ' Dim a As Modules.nusoftModSys.
    Dim m02Setting As New Logic.FinaSetting(_sesi)
    If Not txtDivisi.EditValue Is Nothing Then
      If Not txtProyek.EditValue Is Nothing Then
        Throw New Utils.Exception("Silahkan pilih salah satu data. Proyek atau Divisi.", 0, "", "Laporan")
        Exit Sub
      End If
    End If

    AddParameter("NamaPerusahaan", abcSetting.NamaPerusahaan, GetType(System.String))

    AddParameter("FormatAngka", m02Setting.FormatAngka, GetType(System.String))
    AddParameter("FormatNumeric", m02Setting.NumericFormatString, GetType(System.String))
    AddParameter("NamaPerusahaanX", abcSetting.NamaPerusahaan, GetType(String))
    AddParameter("Alamat1", abcSetting.Alamat1, GetType(String))
    AddParameter("Alamat2", abcSetting.Alamat2, GetType(String))
    AddParameter("BidangUsaha", abcSetting.BidangUsaha, GetType(String))
    AddParameter("NoFax", abcSetting.NoFax, GetType(String))
    AddParameter("NoTelp", abcSetting.NoTelp, GetType(String))

    AddParameter("Periode", "Periode : " & txtPeriodeAwal.DateTime.ToString("dd-MMM-yyyy") & " s/d " & txtPeriodeAkhir.DateTime.ToString("dd-MMM-yyyy"), GetType(String))
    AddParameter("LevelReport", txtLevel.EditValue, GetType(System.String))


    Select Case _jenis
      Case MainClass.reportName.zCashFlowSummary
        LaporanCashFlowDetails()
        Return
      Case MainClass.reportName.zCashFlowDetail
        LaporanCashFlowDetails()
        Return
      Case MainClass.reportName.zCashFlowTahunan
        LaporanCashFlowTahunan()
        Return
      Case Else
        Return
    End Select
  End Sub
  Private Sub LaporanCashFlowSummary()
    Dim details As New XPCollection(Of xMesitechCashFlowD)(_sesi, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal))
    Dim xSaldo As Double
    Dim xCoa As New List(Of Persistent.Coa)
    Dim SaldoAppIn As Double = 0, SaldoAppOut As Double = 0
    Using splashManager As New DevExpress.XtraSplashScreen.SplashScreenManager(Nothing, GetType(Core.Win.Forms.WaitForm), True, True)
      splashManager.ShowWaitForm()
      splashManager.SetWaitFormCaption("Silahkan Tunggu")
      splashManager.SetWaitFormDescription("Proses Hitung Saldo ...")

      'Cash Flow IN
      Dim xDtTransaksi As New XPCollection(Of xMesitechViewCashFlow)(_sesi, CreateCriteriaIN())
      Dim xTipe As String, pI As Integer
      For pI = 0 To details.Count - 1
        xSaldo = 0
        xTipe = details(pI).Asign.ToString
        If xTipe = "+" Then
          xSaldo = xDtTransaksi.Where(Function(m) m.coalawan.Id = details(pI).COA.Id And m.type = xTipe).Sum(Function(n) n.credit + n.debit)
          If details(pI).Urutan = 4 Then
            SaldoAppIn = xSaldo
          End If
          If details(pI).Urutan = 19 Then
            SaldoAppOut = xSaldo
          End If
          details(pI).Debit = xSaldo
        End If
      Next

      'Cash Flow Out
      Dim xDtTransaksiOut As New XPCollection(Of xMesitechViewCashFlow)(_sesi, CreateCriteriaOut(False))
      Dim xTipeOut As String, pJ As Integer
      For pJ = 0 To details.Count - 1
        xSaldo = 0
        xTipeOut = details(pJ).Asign.ToString
        If xTipeOut = "-" Then
          xSaldo = xDtTransaksiOut.Where(Function(m) m.coalawan.Id = details(pJ).COA.Id And m.type = xTipeOut).Sum(Function(n) n.credit + n.debit)
          If details(pJ).Urutan = 4 Then
            SaldoAppIn = xSaldo
          End If
          If details(pJ).Urutan = 19 Then
            SaldoAppOut = xSaldo
          End If
          details(pJ).Debit = xSaldo
        End If
      Next

      Dim xDtTransaksiOut2 As New XPCollection(Of xMesitechViewCashFlow)(_sesi, CreateCriteriaOut(True)) 'tampilkan untuk saldo lawannya.
      Dim pK As Integer, pL As Integer
      For pK = 0 To xDtTransaksiOut2.Count - 1
        Dim xdtGL As New XPCollection(Of xMesitechGlDetail)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Main.Id", xDtTransaksiOut2(pK).Id, BinaryOperatorType.Equal), New BinaryOperator("Debit", 0, BinaryOperatorType.Greater)))
        If xdtGL.Count > 0 Then
          For pL = 0 To xdtGL.Count - 1
            Dim Item As xMesitechCashFlowD
            If details.ToList.Exists(Function(m) m.Asign = "-" And m.COA.Id = xdtGL(pL).Akun.Id) Then
              Item = details.Single(Function(m) m.Asign = "-" And m.COA.Id = xdtGL(pL).Akun.Id)
              Item.Debit = Item.Debit + xdtGL(pL).Debit
            End If
          Next
        End If
      Next

      AddParameter("SaldoAPPIN", (SaldoAppIn * -1), GetType(Double))
      AddParameter("SaldoAPPOut", (SaldoAppOut * -1), GetType(Double))

      splashManager.CloseWaitForm()
    End Using

    If chkSaldoNol.Checked = True Then
      _dataSource = details
    Else
      If details.Where(Function(x) x.Debit <> 0).Count > 0 Then
        _dataSource = details.Where(Function(x) x.Debit <> 0)
      Else
        _dataSource = details
      End If
    End If
  End Sub
  Private Sub LaporanCashFlowSummaryOK()
    Dim details As New XPCollection(Of xMesitechCashFlowD)(_sesi, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal))
    Dim xSaldo As Double
    Dim xCoa As New List(Of Persistent.Coa)
    Dim SaldoAppIn As Double = 0, SaldoAppOut As Double = 0
    Using splashManager As New DevExpress.XtraSplashScreen.SplashScreenManager(Nothing, GetType(Core.Win.Forms.WaitForm), True, True)
      splashManager.ShowWaitForm()
      splashManager.SetWaitFormCaption("Silahkan Tunggu")
      splashManager.SetWaitFormDescription("Proses Hitung Saldo ...")
      'xFunction = "select f02_getbeginningbalance({0},'{1}','{2}',{3},{4},{5})"
      'If txtDivisi.EditValue Is Nothing AndAlso txtProyek.EditValue Is Nothing Then
      '  'all f01_getsaldoCFIN(COA Integer(11), PeriodeAwal Date, PeriodeAkhir Date, Divisi Integer(11), Proyek Integer(11), ProyekSub Integer(11))
      '  'xFunction = "select f02_getbeginningbalance({0},'{1}','{2}',{3},{4},{5})"
      '  'Dim xxSaldo As Double = CDbl(_sesi.ExecuteScalar(String.Format(xFunction, 0, txtPeriodeAkhir.DateTime.ToString("yyyy-MM-dd"))))
      'ElseIf txtDivisi.EditValue Is Nothing AndAlso Not txtProyek.EditValue Is Nothing Then
      '  'divisi kosong,proyek ada
      'Else
      '  'divisi ada, proyek kosong
      'End If

      '### Cara 1
      'For pI = 0 To details.Count - 1
      '  Dim xDtTransaksi As New XPCollection(Of xMesitechViewCashFlow)(_sesi, CreateCriteria(xCoa.ToList, details(pI).Asign))
      '  xSaldo = 0
      '  xCoa.Clear()
      '  xCoa.Add(details(pI).COA)
      '  xSaldo = xDtTransaksi.Sum(Function(x) x.debit + x.credit)
      '  If details(pI).Urutan = 4 Then
      '    SaldoAppIn = xSaldo
      '  End If
      '  If details(pI).Urutan = 19 Then
      '    SaldoAppOut = xSaldo
      '  End If
      '  details(pI).Debit = xSaldo
      'Next
      'AddParameter("SaldoAPPIN", (SaldoAppIn * -1), GetType(Double))
      'AddParameter("SaldoAPPOut", (SaldoAppOut * -1), GetType(Double))
      '### Cara 2
      Dim xDtTransaksi As New XPCollection(Of xMesitechViewCashFlow)(_sesi, CreateCriteria2())
      Dim xTipe As String, pI As Integer
      For pI = 0 To details.Count - 1
        xSaldo = 0
        xTipe = details(pI).Asign.ToString

        xSaldo = xDtTransaksi.Where(Function(m) m.coalawan.Id = details(pI).COA.Id And m.type = xTipe).Sum(Function(n) n.credit + n.debit)
        If details(pI).Urutan = 4 Then
          SaldoAppIn = xSaldo
        End If
        If details(pI).Urutan = 19 Then
          SaldoAppOut = xSaldo
        End If
        details(pI).Debit = xSaldo
      Next

      AddParameter("SaldoAPPIN", (SaldoAppIn * -1), GetType(Double))
      AddParameter("SaldoAPPOut", (SaldoAppOut * -1), GetType(Double))

      splashManager.CloseWaitForm()
    End Using

    If chkSaldoNol.Checked = True Then
      _dataSource = details
    Else
      If details.Where(Function(x) x.Debit <> 0).Count > 0 Then
        _dataSource = details.Where(Function(x) x.Debit <> 0)
      Else
        _dataSource = details
      End If
    End If
  End Sub
  Private Sub LaporanCashFlowSummaryx()
    Dim details As New XPCollection(Of xMesitechCashFlowG)(_sesi, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal))
    Dim xSaldo As Double
    Dim xCoa As New List(Of Persistent.Coa)
    Dim SaldoAppIn As Double = 0, SaldoAppOut As Double = 0
    Using splashManager As New DevExpress.XtraSplashScreen.SplashScreenManager(Nothing, GetType(Core.Win.Forms.WaitForm), True, True)
      splashManager.ShowWaitForm()
      splashManager.SetWaitFormCaption("Silahkan Tunggu")
      splashManager.SetWaitFormDescription("Proses Hitung Saldo ...")

      For pI = 0 To details.Count - 1
        xSaldo = 0
        Dim xdtSetting As New XPCollection(Of CustomReportDetail)(_sesi, New BinaryOperator("Main.Id", details(pI).Id, BinaryOperatorType.Equal))
        xCoa.Clear()
        For pj = 0 To xdtSetting.Count - 1
          xCoa.Add(xdtSetting(pj).Akun)
        Next
        Dim xDtTransaksi As New XPCollection(Of xMesitechViewCashFlow)(_sesi, CreateCriteria(xCoa.ToList, details(pI).Asign))
        'ambilkan saldonya
        xSaldo = xDtTransaksi.Sum(Function(x) x.debit + x.credit)
        If details(pI).Urutan = 4 Then
          SaldoAppIn = xSaldo
        End If
        If details(pI).Urutan = 19 Then
          SaldoAppOut = xSaldo
        End If
        details(pI).Saldo = xSaldo
      Next
      AddParameter("SaldoAPPIN", (SaldoAppIn * -1), GetType(Double))
      AddParameter("SaldoAPPOut", (SaldoAppOut * -1), GetType(Double))

      splashManager.CloseWaitForm()
    End Using

    If chkSaldoNol.Checked = True Then
      _dataSource = details
    Else
      _dataSource = details.Where(Function(x) x.Saldo <> 0)
    End If
  End Sub
  Private Function CreateCriteria(xcoa As List(Of Coa), xAsign As String) As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))
    If Not xcoa Is Nothing Then
      result.Add(New InOperator("coalawan", xcoa))
    End If
    If xAsign = "+" Then
      result.Add(New BinaryOperator("debit", 0, BinaryOperatorType.Greater))
    ElseIf xAsign = "-" Then
      result.Add(New BinaryOperator("credit", 0, BinaryOperatorType.Greater))
    End If
    If Not txtProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.Proyek.Id", CType(txtProyek.EditValue, Persistent.Proyek).Id, BinaryOperatorType.Equal))
    End If
    If Not txtSubProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.ProyekSub.Id", CType(txtSubProyek.EditValue, Persistent.ProyekSub).Id, BinaryOperatorType.Equal))
    End If
    If Not txtDivisi.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.Divisi.Id", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Id, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Sub LaporanCashFlowDetails()
    Dim details As New XPCollection(Of xMesitechCashFlowD)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal), New BinaryOperator("Id", 0, BinaryOperatorType.Equal)))

    Dim xCF As New XPCollection(Of xMesitechCashFlowG)(_sesi, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal))
    Dim xCoa As New List(Of Persistent.Coa)
    Dim SaldoAppIn As Double = 0, SaldoAppOut As Double = 0

    Using splashManager As New DevExpress.XtraSplashScreen.SplashScreenManager(Nothing, GetType(Core.Win.Forms.WaitForm), True, True)
      splashManager.ShowWaitForm()
      splashManager.SetWaitFormCaption("Silahkan Tunggu")
      splashManager.SetWaitFormDescription("Proses Hitung Saldo ...")

      For pi = 0 To xCF.Count - 1
        Dim xdtSetting As New XPCollection(Of CustomReportDetail)(_sesi, New BinaryOperator("Main.Id", xCF(pi).Id, BinaryOperatorType.Equal))
        xCoa.Clear()
        For pj = 0 To xdtSetting.Count - 1
          xCoa.Add(xdtSetting(pj).Akun)
        Next

        Dim xDtTransaksi As New XPCollection(Of xMesitechViewCashFlow)(_sesi, CreateCriteria(xCoa.ToList, xCF(pi).Asign))
        For pj = 0 To xDtTransaksi.Count - 1
          Dim Item As New xMesitechCashFlowD(_sesi)
          Item.Id = 0
          Item.Tipe = xCF(pi).Tipe
          Item.Urutan = xCF(pi).Urutan
          Item.Nama = xCF(pi).Nama
          Item.Asign = xCF(pi).Asign

          Item.COA = xDtTransaksi(pj).coalawan
          Item.Debit = xDtTransaksi(pj).debit
          Item.Kredit = xDtTransaksi(pj).credit
          Item.NoTransaksi = xDtTransaksi(pj).NoTransaksi
          Item.Tanggal = xDtTransaksi(pj).Tanggal

          Item.Level = xDtTransaksi(pj).coalawan.Level
          Item.Level1 = xDtTransaksi(pj).coalawan.Level1
          Item.Level2 = xDtTransaksi(pj).coalawan.Level2
          Item.Level3 = xDtTransaksi(pj).coalawan.Level3
          Item.Level4 = xDtTransaksi(pj).coalawan.Level4

          If Not xDtTransaksi(pj).Id.Divisi Is Nothing Then Item.Divisi = xDtTransaksi(pj).Id.Divisi.Nama
          If Not xDtTransaksi(pj).Id.Proyek Is Nothing Then Item.Project = xDtTransaksi(pj).Id.Proyek.Nama
          If Not xDtTransaksi(pj).Id.ProyekSub Is Nothing Then Item.ProjectSub = xDtTransaksi(pj).Id.ProyekSub.Nama

          details.Add(Item)
        Next
        Dim xSaldo As Double = xDtTransaksi.Sum(Function(x) x.credit + x.debit)
        If xCF(pi).Urutan = 4 Then
          SaldoAppIn = xSaldo
        End If
        If xCF(pi).Urutan = 19 Then
          SaldoAppOut = xSaldo
        End If


        'tambahkan data kosong nya
        If chkSaldoNol.Checked = True Then
          If xDtTransaksi.Count = 0 Then
            If xCoa.Count > 0 Then
              Dim Item As New xMesitechCashFlowD(_sesi)
              Item.Id = 0
              Item.Tipe = xCF(pi).Tipe
              Item.Urutan = xCF(pi).Urutan
              Item.Nama = xCF(pi).Nama
              Item.Asign = xCF(pi).Asign
              Item.COA = xCoa.Item(0)

              Item.Debit = 0
              Item.Kredit = 0
              Item.NoTransaksi = "Kosong"
              Item.Tanggal = txtPeriodeAwal.DateTime
              details.Add(Item)
            End If
          End If
        End If
      Next
      AddParameter("SaldoAPPIN", (SaldoAppIn * -1), GetType(Double))
      AddParameter("SaldoAPPOut", (SaldoAppOut * -1), GetType(Double))

      splashManager.CloseWaitForm()
    End Using
    _dataSource = details
  End Sub
  Private Sub DeleteCombo_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs)
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      CType(sender, DevExpress.XtraEditors.LookUpEdit).EditValue = Nothing
    End If
  End Sub

  Private Sub LaporanCashFlowTahunan()
    Dim details As New XPCollection(Of xMesitechCashFlowD)(_sesi, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal))
    'Dim xSaldo As Double
    Dim xCoa As New List(Of Persistent.Coa)
    Dim SaldoAppIn As Double = 0, SaldoAppOut As Double = 0
    Using splashManager As New DevExpress.XtraSplashScreen.SplashScreenManager(Nothing, GetType(Core.Win.Forms.WaitForm), True, True)
      splashManager.ShowWaitForm()
      splashManager.SetWaitFormCaption("Silahkan Tunggu")
      splashManager.SetWaitFormDescription("Proses Hitung Saldo ...")

      Dim xDtTransaksi As New XPCollection(Of xMesitechViewCashFlow)(_sesi, CreateCriteria2())
      Dim xTipe As String, pI As Integer
      For pI = 0 To details.Count - 1
        xTipe = details(pI).Asign.ToString
        'xSaldo = xDtTransaksi.Sum(Function(x) x.debit + x.credit)
        details(pI).m1 = xDtTransaksi.Where(Function(m) m.coalawan.Id = details(pI).COA.Id And m.type = xTipe And m.Bulan = 1).Sum(Function(n) n.credit + n.debit)
        details(pI).m2 = xDtTransaksi.Where(Function(m) m.coalawan.Id = details(pI).COA.Id And m.type = xTipe And m.Bulan = 2).Sum(Function(n) n.credit + n.debit)
        details(pI).m3 = xDtTransaksi.Where(Function(m) m.coalawan.Id = details(pI).COA.Id And m.type = xTipe And m.Bulan = 3).Sum(Function(n) n.credit + n.debit)
        details(pI).m4 = xDtTransaksi.Where(Function(m) m.coalawan.Id = details(pI).COA.Id And m.type = xTipe And m.Bulan = 4).Sum(Function(n) n.credit + n.debit)
        details(pI).m5 = xDtTransaksi.Where(Function(m) m.coalawan.Id = details(pI).COA.Id And m.type = xTipe And m.Bulan = 5).Sum(Function(n) n.credit + n.debit)
        details(pI).m6 = xDtTransaksi.Where(Function(m) m.coalawan.Id = details(pI).COA.Id And m.type = xTipe And m.Bulan = 6).Sum(Function(n) n.credit + n.debit)
        details(pI).m7 = xDtTransaksi.Where(Function(m) m.coalawan.Id = details(pI).COA.Id And m.type = xTipe And m.Bulan = 7).Sum(Function(n) n.credit + n.debit)
        details(pI).m8 = xDtTransaksi.Where(Function(m) m.coalawan.Id = details(pI).COA.Id And m.type = xTipe And m.Bulan = 8).Sum(Function(n) n.credit + n.debit)
        details(pI).m9 = xDtTransaksi.Where(Function(m) m.coalawan.Id = details(pI).COA.Id And m.type = xTipe And m.Bulan = 9).Sum(Function(n) n.credit + n.debit)
        details(pI).m10 = xDtTransaksi.Where(Function(m) m.coalawan.Id = details(pI).COA.Id And m.type = xTipe And m.Bulan = 10).Sum(Function(n) n.credit + n.debit)
        details(pI).m11 = xDtTransaksi.Where(Function(m) m.coalawan.Id = details(pI).COA.Id And m.type = xTipe And m.Bulan = 11).Sum(Function(n) n.credit + n.debit)
        details(pI).m12 = xDtTransaksi.Where(Function(m) m.coalawan.Id = details(pI).COA.Id And m.type = xTipe And m.Bulan = 12).Sum(Function(n) n.credit + n.debit)
        details(pI).Debit = details(pI).m1 + details(pI).m2 + details(pI).m3 + details(pI).m4 + details(pI).m5 + details(pI).m6 + details(pI).m7 + details(pI).m8 + details(pI).m9 + details(pI).m10 + details(pI).m11 + details(pI).m12
      Next
      AddParameter("SaldoAPPIN", (SaldoAppIn * -1), GetType(Double))
      AddParameter("SaldoAPPOut", (SaldoAppOut * -1), GetType(Double))

      splashManager.CloseWaitForm()
    End Using

    If chkSaldoNol.Checked = True Then
      _dataSource = details
    Else
      If details.Where(Function(x) x.Debit <> 0).Count > 0 Then
        _dataSource = details.Where(Function(x) x.Debit <> 0)
      Else
        _dataSource = details
      End If
    End If
  End Sub
  Private Function CreateCriteria2() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))
    If Not txtProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.Proyek.Id", CType(txtProyek.EditValue, Persistent.Proyek).Id, BinaryOperatorType.Equal))
    End If
    If Not txtSubProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.ProyekSub.Id", CType(txtSubProyek.EditValue, Persistent.ProyekSub).Id, BinaryOperatorType.Equal))
    End If
    If Not txtDivisi.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.Divisi.Id", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Id, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function

  Private Function CreateCriteriaIN() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))
    result.Add(New BinaryOperator("type", "+", BinaryOperatorType.Equal))
    If Not txtProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.Proyek.Id", CType(txtProyek.EditValue, Persistent.Proyek).Id, BinaryOperatorType.Equal))
    End If
    If Not txtSubProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.ProyekSub.Id", CType(txtSubProyek.EditValue, Persistent.ProyekSub).Id, BinaryOperatorType.Equal))
    End If
    If Not txtDivisi.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.Divisi.Id", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Id, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Function CreateCriteriaOut(TampilkanLawan As Boolean) As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If TampilkanLawan = True Then
      result.Add(New BinaryOperator("JmlKredit", 1, BinaryOperatorType.Equal))
    Else
      result.Add(New BinaryOperator("JmlKredit", 1, BinaryOperatorType.Greater))
    End If

    result.Add(New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))
    result.Add(New BinaryOperator("type", "-", BinaryOperatorType.Equal))

    If Not txtProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.Proyek.Id", CType(txtProyek.EditValue, Persistent.Proyek).Id, BinaryOperatorType.Equal))
    End If
    If Not txtSubProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.ProyekSub.Id", CType(txtSubProyek.EditValue, Persistent.ProyekSub).Id, BinaryOperatorType.Equal))
    End If
    If Not txtDivisi.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.Divisi.Id", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Id, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function

End Class