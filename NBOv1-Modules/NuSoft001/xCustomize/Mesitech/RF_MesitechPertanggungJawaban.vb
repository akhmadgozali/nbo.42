Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports NuSoft.Utils.CustomAttribute
Public Class RF_MesitechPertanggungJawaban
  Private details As XPCollection(Of xMesitechCashFlowD)
  Private Enum eLevel
    <EnumDescription("Level 1")> Level1
    <EnumDescription("Level 2")> Level2
    <EnumDescription("Level 3")> Level3
    <EnumDescription("Level 4")> Level4
  End Enum
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeData()
    txtPeriodeAwal.DateTime = New Date(Now.Year, Now.Month, 1)
    Dim xAkhirBulan As New Date(Now.Year, Now.Month, 1)
    txtPeriodeAkhir.DateTime = xAkhirBulan.AddMonths(1).AddDays(-(xAkhirBulan.AddMonths(1).Day))

    txtProyek.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)
    txtSubProyek.Properties.DataSource = New XPCollection(Of Persistent.ProyekSub)(_sesi)

    txtLevel.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(eLevel))
    txtLevel.EditValue = eLevel.Level4

    treeAkun.DataSource = Logic.Coa.GetCoa(_sesi, False, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.Kas, Persistent.CoaEnum.eKind.Bank})

    'txtPeriodeAwal.DateTime = New Date(2016, 3, 1)
    'txtPeriodeAkhir.DateTime = New Date(2016, 3, 31)
  End Sub
  Overrides Sub Filter()
    Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)



    Dim m02Setting As New Logic.FinaSetting(_sesi)
    If txtProyek.EditValue Is Nothing Then
      Throw New Utils.Exception("Silahkan pilih Proyek.", 0, "", "Laporan")
      Exit Sub
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
    AddParameter("PeriodeAwal", txtPeriodeAwal.DateTime.ToString("dd-MMM-yyyy"), GetType(String))
    AddParameter("PeriodeAkhir", txtPeriodeAkhir.DateTime.ToString("dd-MMM-yyyy"), GetType(String))
    AddParameter("Proyek", CType(txtProyek.EditValue, Proyek).Nama, GetType(String))

    'TestingDATA()
    '_dataSource = details

    LaporanCashFlow()
    Return
  End Sub
  Private Sub LaporanCashFlow()
    details = New XPCollection(Of xMesitechCashFlowD)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal), New BinaryOperator("Id", 0, BinaryOperatorType.Equal)))
    Dim xDataCF As New XPCollection(Of xMesitechCashFlowD)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal), New BinaryOperator("Id", 0, BinaryOperatorType.Equal)))
    Using splashManager As New DevExpress.XtraSplashScreen.SplashScreenManager(Nothing, GetType(Core.Win.Forms.WaitForm), True, True)
      splashManager.ShowWaitForm()
      splashManager.SetWaitFormCaption("Silahkan Tunggu")
      splashManager.SetWaitFormDescription("Proses Hitung Saldo ...")
      'insertkan untuk data IN nya
      Dim xCF As New XPCollection(Of xMesitechCashFlowG)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal), New BinaryOperator("Asign", "+", BinaryOperatorType.Equal)))
      Dim xCoa As New List(Of Persistent.Coa)
      Dim SaldoAppIn As Double = 0, SaldoAppOut As Double = 0

      For pi = 0 To xCF.Count - 1
        'Dim xdtSetting As New XPCollection(Of CustomReportDetail)(_sesi, New BinaryOperator("Main.Id", xCF(pi).Id, BinaryOperatorType.Equal))
        Dim xdtSetting As New XPCollection(Of Coa)(_sesi, New BinaryOperator("ReportCashFlowIN.Id", xCF(pi).Id, BinaryOperatorType.Equal))
        xCoa.Clear()
        For pj = 0 To xdtSetting.Count - 1
          xCoa.Add(xdtSetting(pj))
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

          If Not xDtTransaksi(pj).Id.Divisi Is Nothing Then Item.Divisi = xDtTransaksi(pj).Id.Divisi.Kode
          If Not xDtTransaksi(pj).Id.Proyek Is Nothing Then Item.Project = xDtTransaksi(pj).Id.Proyek.Kode
          If Not xDtTransaksi(pj).Id.ProyekSub Is Nothing Then Item.ProjectSub = xDtTransaksi(pj).Id.ProyekSub.Kode
          Item.Keterangan = "Penerimaan"

          xDataCF.Add(Item)
        Next
      Next

      '=====================SALDO OUT=======================================
      'insert saldo out 1
      Dim xCF2 As New XPCollection(Of xMesitechCashFlowG)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal), New BinaryOperator("Asign", "-", BinaryOperatorType.Equal)))
      Dim xCoa2 As New List(Of Persistent.Coa)

      For pi = 0 To xCF2.Count - 1
        'Dim xdtSetting2 As New XPCollection(Of CustomReportDetail)(_sesi, New BinaryOperator("Main.Id", xCF2(pi).Id, BinaryOperatorType.Equal))
        Dim xdtSetting2 As New XPCollection(Of Coa)(_sesi, New BinaryOperator("ReportCashFlowOut.Id", xCF2(pi).Id, BinaryOperatorType.Equal))
        xCoa2.Clear()
        For pj = 0 To xdtSetting2.Count - 1
          xCoa2.Add(xdtSetting2(pj))
        Next

        Dim xDtTransaksi As New XPCollection(Of xMesitechViewCashFlow)(_sesi, CreateCriteria2(xCoa2.ToList))
        For pj = 0 To xDtTransaksi.Count - 1
          Dim Item As New xMesitechCashFlowD(_sesi)
          Item.Id = 0
          Item.Tipe = xCF2(pi).Tipe
          Item.Urutan = xCF2(pi).Urutan
          Item.Nama = xCF2(pi).Nama
          Item.Asign = xCF2(pi).Asign

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

          If Not xDtTransaksi(pj).Id.Divisi Is Nothing Then Item.Divisi = xDtTransaksi(pj).Id.Divisi.Kode
          If Not xDtTransaksi(pj).Id.Proyek Is Nothing Then Item.Project = xDtTransaksi(pj).Id.Proyek.Kode
          If Not xDtTransaksi(pj).Id.ProyekSub Is Nothing Then Item.ProjectSub = xDtTransaksi(pj).Id.ProyekSub.Kode

          Item.Keterangan = "Pengeluaran tipe 1"
          xDataCF.Add(Item)
        Next

      Next
      'insert saldo out 2
      Dim xdtMain As New List(Of Persistent.xMesitechGLMain)
      For pi = 0 To xCF2.Count - 1
        'Dim xdtSetting As New XPCollection(Of CustomReportDetail)(_sesi, New BinaryOperator("Main.Id", xCF2(pi).Id, BinaryOperatorType.Equal))
        Dim xdtSetting As New XPCollection(Of Coa)(_sesi, New BinaryOperator("ReportCashFlowOut.Id", xCF2(pi).Id, BinaryOperatorType.Equal))
        xCoa2.Clear()
        For pj = 0 To xdtSetting.Count - 1
          xCoa2.Add(xdtSetting(pj))
        Next

        Dim xDataCashFlow As New XPCollection(Of xMesitechViewCashFlow)(_sesi, CreateCriteria3())
        xdtMain.Clear()
        For pj = 0 To xDataCashFlow.Count - 1
          xdtMain.Add(xDataCashFlow(pj).main)
        Next
        Dim xDtTransaksi As New XPCollection(Of xMesitechGlDetail)(_sesi, CreateCriteriaDetail(xCoa2.ToList, xdtMain))

        For pj = 0 To xDtTransaksi.Count - 1
          Dim Item As New xMesitechCashFlowD(_sesi)
          Item.Id = 0
          Item.Tipe = xCF2(pi).Tipe
          Item.Urutan = xCF2(pi).Urutan
          Item.Nama = xCF2(pi).Nama
          Item.Asign = xCF2(pi).Asign

          Item.COA = xDtTransaksi(pj).Akun
          Item.Debit = xDtTransaksi(pj).Debit
          Item.Kredit = xDtTransaksi(pj).Kredit
          Item.NoTransaksi = xDtTransaksi(pj).Main.Kode
          Item.Tanggal = xDtTransaksi(pj).Main.Tanggal

          Item.Level = xDtTransaksi(pj).Akun.Level
          Item.Level1 = xDtTransaksi(pj).Akun.Level1
          Item.Level2 = xDtTransaksi(pj).Akun.Level2
          Item.Level3 = xDtTransaksi(pj).Akun.Level3
          Item.Level4 = xDtTransaksi(pj).Akun.Level4

          If Not xDtTransaksi(pj).Divisi Is Nothing Then Item.Divisi = xDtTransaksi(pj).Divisi.Kode
          If Not xDtTransaksi(pj).Proyek Is Nothing Then Item.Project = xDtTransaksi(pj).Proyek.Kode
          If Not xDtTransaksi(pj).ProyekSub Is Nothing Then Item.ProjectSub = xDtTransaksi(pj).ProyekSub.Kode

          Item.Keterangan = "Pengeluaran tipe 2"

          xDataCF.Add(Item)
        Next
      Next

      Dim jI As Integer, jJ As Integer
      'saldo awal
      AddCB(True)

      'AddDataCF(10, "Saldo Awal", "+", 58410237, 0, "0. Saldo Awal")
      'AddDataCF(18, "Saldo Awal", "+", 58223497, 0, "0. Saldo Awal")

      'ambilkan Group Cash Flow IN 
      Dim xCFGIn As New XPCollection(Of Persistent.xMesitechCashFlowG)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal), New BinaryOperator("Asign", "+", BinaryOperatorType.Equal)))
      For jI = 0 To xCFGIn.Count - 1
        'ambilkan seting COAnya
        Dim xCFD As New XPCollection(Of Persistent.Coa)(_sesi, New BinaryOperator("ReportCashFlowIN.Id", xCFGIn(jI).Id, BinaryOperatorType.Equal))
        For jJ = 0 To xCFD.Count - 1
          Dim saldoIn As Double = xDataCF.Where(Function(m) m.COA.Id = xCFD(jJ).Id And m.Asign = xCFGIn(jI).Asign).Sum(Function(n) n.Debit + n.Kredit)
          AddDataCF(xCFD(jJ).Id, xCFGIn(jI).Nama, xCFGIn(jI).Asign, saldoIn, 0, "1. Penerimaan")
        Next
      Next
      'ambilkan Group Cash Flow Out 
      Dim xCFGOut As New XPCollection(Of Persistent.xMesitechCashFlowG)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal), New BinaryOperator("Asign", "-", BinaryOperatorType.Equal)))
      For jI = 0 To xCFGOut.Count - 1
        'ambilkan seting COAnya
        Dim xCFD As New XPCollection(Of Persistent.Coa)(_sesi, New BinaryOperator("ReportCashFlowOut.Id", xCFGOut(jI).Id, BinaryOperatorType.Equal))
        For jJ = 0 To xCFD.Count - 1
          Dim saldoOut As Double = xDataCF.Where(Function(m) m.COA.Id = xCFD(jJ).Id And m.Asign = xCFGOut(jI).Asign).Sum(Function(n) n.Debit + n.Kredit)
          AddDataCF(xCFD(jJ).Id, xCFGOut(jI).Nama, xCFGOut(jI).Asign, 0, saldoOut, "2. Pengeluaran")
        Next
      Next

      'saldo akhir
      AddCB(False)
      'AddDataCF(10, "Saldo Akhir", "+", 88491495, 0, "3. Saldo Akhir")
      'AddDataCF(18, "Saldo Akhir", "+", 92256004, 0, "3. Saldo Akhir")


      splashManager.CloseWaitForm()
    End Using

    '_dataSource = xDataCF

    If chkSaldoNol.Checked = True Then
      _dataSource = details
    Else
      If details.Where(Function(x) x.m1 <> 0).Count > 0 Then
        _dataSource = details.Where(Function(x) x.m1 <> 0)
      Else
        _dataSource = details
      End If
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
    Return GroupOperator.And(result)
  End Function

  Private Function CreateCriteria2(xcoa As List(Of Coa)) As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))
    result.Add(New BinaryOperator("type", "-", BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("JmlKredit2", 0, BinaryOperatorType.Greater))

    If Not xcoa Is Nothing Then
      result.Add(New InOperator("coalawan", xcoa))
    End If

    If Not txtProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.Proyek.Id", CType(txtProyek.EditValue, Persistent.Proyek).Id, BinaryOperatorType.Equal))
    End If
    If Not txtSubProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.ProyekSub.Id", CType(txtSubProyek.EditValue, Persistent.ProyekSub).Id, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Function CreateCriteria3() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))
    result.Add(New BinaryOperator("type", "-", BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("JmlKredit2", 0, BinaryOperatorType.Equal))

    If Not txtProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.Proyek.Id", CType(txtProyek.EditValue, Persistent.Proyek).Id, BinaryOperatorType.Equal))
    End If
    If Not txtSubProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.ProyekSub.Id", CType(txtSubProyek.EditValue, Persistent.ProyekSub).Id, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Function CreateCriteriaDetail(xcoa As List(Of Coa), xdtMain As List(Of xMesitechGLMain)) As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"
    result.Add(New BinaryOperator("Debit", 0, BinaryOperatorType.Greater))
    If Not xcoa Is Nothing Then
      result.Add(New InOperator("Akun", xcoa))
    End If
    If Not xdtMain Is Nothing Then
      result.Add(New InOperator("Main", xdtMain))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Sub AddDataCF(xIDCOA As Integer, xNamaCF As String, xAsign As String, debit As Double, credit As Double, xKeterangan As String)
    Dim Item As New xMesitechCashFlowD(_sesi)
    Dim xCOA As Persistent.Coa

    xCOA = _sesi.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(xIDCOA))
    Item.Id = 0
    Item.Tipe = 1
    Item.Urutan = 1
    Item.Nama = xNamaCF
    Item.Asign = xAsign

    Item.COA = xCOA
    Item.Debit = debit
    Item.Kredit = credit
    Item.m1 = debit + credit
    Item.NoTransaksi = "xNomor"
    Item.Tanggal = txtPeriodeAwal.DateTime

    Item.Level = xCOA.Level
    Item.Level1 = xCOA.Level1
    Item.Level2 = xCOA.Level2
    Item.Level3 = xCOA.Level3
    Item.Level4 = xCOA.Level4

    Item.Keterangan = xKeterangan
    details.Add(Item)
  End Sub
  Private Sub AddCB(xSaldoAwal As Boolean)
    Dim coa As Persistent.Coa, xDataKasBank As New List(Of Persistent.Coa)
    Dim op As GetCheckedNodesOperation = New GetCheckedNodesOperation()
    treeAkun.NodesIterator.DoOperation(op)
    If op.CheckedNodes.Count = 0 Then
      Dim xCOA As XPCollection(Of Coa) = Logic.Coa.GetCoa(_sesi, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.Kas, CoaEnum.eKind.Bank})
      For pi = 0 To xCOA.Count - 1
        xDataKasBank.Add(xCOA(pi))
      Next
    Else
      For i = 0 To op.CheckedNodes.Count - 1
        coa = CType(op.CheckedNodes(i)("This"), Persistent.Coa)
        If Logic.Coa.IsDetail(_sesi, coa) Then
          xDataKasBank.Add(coa)
        End If
      Next
    End If

    Dim xTanggal As Date
    If xSaldoAwal = True Then
      xTanggal = txtPeriodeAwal.DateTime
    Else
      xTanggal = txtPeriodeAkhir.DateTime.AddDays(1)
    End If
    Dim pSaldo As Double = 0
    For pi = 0 To xDataKasBank.Count - 1
      'If Not txtProyek.EditValue Is Nothing Then
      '  If txtSubProyek.EditValue Is Nothing Then 'ambil saldo per proyek
      '    pSaldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPNameProject, xDataKasBank(pi).Id, xTanggal.ToString("yyyy-MM-dd"), CType(txtProyek.EditValue, Persistent.Proyek).Id, 0)))
      '  Else 'ambil saldo per proyek per sub proyek
      '    pSaldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPNameProject, xDataKasBank(pi).Id, xTanggal.ToString("yyyy-MM-dd"), CType(txtProyek.EditValue, Persistent.Proyek).Id, CType(txtSubProyek.EditValue, Persistent.ProyekSub).Id)))
      '  End If
      'End If
      pSaldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, xDataKasBank(pi).Id, xTanggal.ToString("yyyy-MM-dd"))))

      If xSaldoAwal = True Then
        AddDataCF(xDataKasBank(pi).Id, "Saldo Awal", "+", pSaldo, 0, "0. Saldo Awal")
      Else
        AddDataCF(xDataKasBank(pi).Id, "Saldo Akhir", "+", pSaldo, 0, "3. Saldo Akhir")
      End If
    Next
  End Sub

  '===testing add data
  Private Sub TestingDATA()
    details = New XPCollection(Of xMesitechCashFlowD)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal), New BinaryOperator("Id", 0, BinaryOperatorType.Equal)))

    'saldo awal 
    AddDataCF(10, "Saldo Awal", "+", 58410237, 0, "0. Saldo Awal")
    AddDataCF(18, "Saldo Awal", "+", 58223497, 0, "0. Saldo Awal")

    'penerimaan 
    AddDataCF(272, "Penerimaan", "+", 1856613322, 0, "1. Penerimaan")
    AddDataCF(282, "Penerimaan", "+", 0, 0, "1. Penerimaan")

    'pengeluaran
    AddDataCF(403, "1 Biaya Ymh dibayar", "-", 0, 0, "2. Pengeluaran")
    AddDataCF(404, "1 Biaya Ymh dibayar", "-", 0, 1399432449, "2. Pengeluaran") ' 1399432449 

    AddDataCF(523, "2 Biaya Cash/bank", "-", 0, 7002300, "2. Pengeluaran") ' 7002300 
    AddDataCF(599, "2 Biaya Cash/bank", "-", 0, 8505000, "2. Pengeluaran") '8505000:
    AddDataCF(607, "2 Biaya Cash/bank", "-", 0, 2520000, "2. Pengeluaran") '2520000:
    AddDataCF(626, "2 Biaya Cash/bank", "-", 0, 6990000, "2. Pengeluaran") '6990000:
    AddDataCF(632, "2 Biaya Cash/bank", "-", 0, 2900000, "2. Pengeluaran") '2900000:
    AddDataCF(652, "2 Biaya Cash/bank", "-", 0, 20000000, "2. Pengeluaran") '20000000:
    AddDataCF(703, "2 Biaya Cash/bank", "-", 0, 1050400, "2. Pengeluaran") '1050400:
    AddDataCF(706, "2 Biaya Cash/bank", "-", 0, 30500, "2. Pengeluaran") '30500:
    AddDataCF(726, "2 Biaya Cash/bank", "-", 0, 13760000, "2. Pengeluaran") '13760000:
    AddDataCF(730, "2 Biaya Cash/bank", "-", 0, 2832000, "2. Pengeluaran") '2832000:
    AddDataCF(732, "2 Biaya Cash/bank", "-", 0, 4071250, "2. Pengeluaran") '4071250:
    AddDataCF(734, "2 Biaya Cash/bank", "-", 0, 21663761, "2. Pengeluaran") '21663761:
    AddDataCF(737, "2 Biaya Cash/bank", "-", 0, 9354180, "2. Pengeluaran") '9354180:
    AddDataCF(740, "2 Biaya Cash/bank", "-", 0, 4285000, "2. Pengeluaran") '4285000:
    AddDataCF(741, "2 Biaya Cash/bank", "-", 0, 8852469, "2. Pengeluaran") '8852469:
    AddDataCF(745, "2 Biaya Cash/bank", "-", 0, 8248509, "2. Pengeluaran") '8248509:
    AddDataCF(753, "2 Biaya Cash/bank", "-", 0, 2684596, "2. Pengeluaran") '2684596:
    AddDataCF(754, "2 Biaya Cash/bank", "-", 0, 30000000, "2. Pengeluaran") '30000000:
    AddDataCF(763, "2 Biaya Cash/bank", "-", 0, 1000000, "2. Pengeluaran") '1000000:
    AddDataCF(766, "2 Biaya Cash/bank", "-", 0, 35279000, "2. Pengeluaran") '35279000:
    AddDataCF(767, "2 Biaya Cash/bank", "-", 0, 6955000, "2. Pengeluaran") '6955000:
    AddDataCF(776, "2 Biaya Cash/bank", "-", 0, 825000, "2. Pengeluaran") '825000:
    AddDataCF(252, "3 Asset Tetap", "-", 0, 3740000, "2. Pengeluaran") '3740000:
    AddDataCF(384, "4 Lain-Lain", "-", 0, 190518143, "2. Pengeluaran") '190518143:


    'saldo akhir
    AddDataCF(10, "Saldo Akhir", "+", 88491495, 0, "3. Saldo Akhir")
    AddDataCF(18, "Saldo Akhir", "+", 92256004, 0, "3. Saldo Akhir")
  End Sub
End Class