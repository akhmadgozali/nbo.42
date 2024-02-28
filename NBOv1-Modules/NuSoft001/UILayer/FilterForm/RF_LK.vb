Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent

Friend Class RF_LK
  Private _jenis As Persistent.CustomReportTipe
  Private _isLampiran As Boolean
  Private _isTriwulan As Boolean
  Private _isBukuBesar As Boolean

  Sub New(jenis As Persistent.CustomReportTipe, Lampiran As Boolean, Optional Triwulan As Boolean = False, Optional BukuBesar As Boolean = False)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _jenis = jenis
    _isLampiran = Lampiran
    _isTriwulan = Triwulan
    _isBukuBesar = BukuBesar

    Select Case _jenis
      Case Persistent.CustomReportTipe.NeracaAktiva, Persistent.CustomReportTipe.NeracaPassiva
        If Lampiran Then
          Me.Text = "Filter Laporan - Lampiran Neraca" : BentukForm2()
        Else
          Me.Text = "Filter Laporan - Neraca" : BentukForm1()
        End If
      Case Persistent.CustomReportTipe.LabaRugi
        If Lampiran Then
          Me.Text = "Filter Laporan - Lampiran Laba Rugi"
        Else
          Me.Text = "Filter Laporan - Laba Rugi"
        End If
      Case Persistent.CustomReportTipe.HPP
        If Lampiran Then
          Me.Text = "Filter Laporan - Lampiran HPP"
        Else
          Me.Text = "Filter Laporan - HPP"
        End If
      Case Persistent.CustomReportTipe.CashFlow
        If Lampiran Then
          If Triwulan Then
            Me.Text = "Filter Laporan - Lampiran Cash Flow (Triwulan)" : BentukForm3()
          Else
            If BukuBesar Then
              Me.Text = "Filter Laporan - Rincian Cash Flow" : BentukForm1()
            Else
              Me.Text = "Filter Laporan - Lampiran Cash Flow (Bulanan)" : BentukForm1()
            End If
          End If
        Else
          If Triwulan Then
            Me.Text = "Filter Laporan - Cash Flow (Triwulan)" : BentukForm3()
          Else
            Me.Text = "Filter Laporan - Cash Flow (Bulanan)" : BentukForm1()
          End If
        End If
    End Select
  End Sub
  Overrides Sub InitializeData()
    Dim period = New DevExpress.Xpo.XPCollection(Of Persistent.Periode)(_sesi)
    txtPeriodeBulan.Properties.Items.Clear()
    If _isTriwulan Then
      For i = 1 To 4
        txtPeriodeBulan.Properties.Items.Add(i)
      Next
    Else
      For i = 1 To 12
        txtPeriodeBulan.Properties.Items.Add(MonthName(i))
      Next
    End If

    Dim z = From a In period Order By a.Id Descending Select a.Bulan, a.Tahun Take 1

    If _isTriwulan Then
      If z.Count > 0 Then
        If z(0).Bulan = 12 Then
          txtPeriodeBulan.SelectedIndex = 0
          txtPeriodeTahun.EditValue = z(0).Tahun + 1
        Else

          txtPeriodeBulan.SelectedIndex = CInt(Math.Ceiling(z(0).Bulan / 3) - 1)
          txtPeriodeTahun.EditValue = z(0).Tahun
        End If
      Else
        txtPeriodeBulan.SelectedIndex = CInt(Math.Ceiling(Now.Month \ 3) - 1)
        txtPeriodeTahun.EditValue = Now.Year
      End If
    Else
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
    End If
  End Sub
  Private Sub BentukForm1()
    xRadio.Visible = False
    Me.Height = Me.Height - xRadio.Height
  End Sub
  Private Sub BentukForm2()
    xRadio.Properties.Items(0).Description = "Aktiva"
    xRadio.Properties.Items(1).Description = "Passiva"
  End Sub
  Private Sub BentukForm3()
    BentukForm1()
    LabelControl2.Text = "Triwulan"
  End Sub

  Overrides Sub Filter()
    If txtPeriodeTahun.EditValue Is Nothing Then
      Utils.Win.MessageBox.Show("Masukkan periode", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      Return
    End If

    Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
    ' Dim a As Modules.nusoftModSys.
    Dim m02Setting As New Logic.FinaSetting(_sesi)

    AddParameter("Periode", txtPeriodeBulan.Text.ToUpper & " " & txtPeriodeTahun.Text, GetType(System.String))
    AddParameter("NamaPerusahaan", abcSetting.NamaPerusahaan, GetType(System.String))
    AddParameter("CompanyName", abcSetting.NamaPerusahaan, GetType(String))
    AddParameter("Alamat1", abcSetting.Alamat1, GetType(String))
    AddParameter("Alamat2", abcSetting.Alamat2, GetType(String))
    AddParameter("BidangUsaha", abcSetting.BidangUsaha, GetType(String))
    AddParameter("NoFax", abcSetting.NoFax, GetType(String))
    AddParameter("NoTelp", abcSetting.NoTelp, GetType(String))
    AddParameter("FormatAngka", m02Setting.FormatAngka, GetType(System.String))
    AddParameter("FormatNumeric", m02Setting.NumericFormatString, GetType(System.String))

    Select Case _jenis
      Case Persistent.CustomReportTipe.NeracaAktiva, Persistent.CustomReportTipe.NeracaPassiva
        If _isLampiran Then '====== LAPORAN NERACA
          LaporanLampiranNeraca()
          Return
        Else '====== LAPORAN NERACA
          LaporanNeraca()
          Return
        End If
      Case Persistent.CustomReportTipe.LabaRugi, Persistent.CustomReportTipe.HPP
        If _isLampiran Then
          LaporanRugiLabaHPPLampiran()
          Return
        Else
          LaporanRugiLabaHPP()
          Return
        End If
      Case Persistent.CustomReportTipe.CashFlow
        If _isLampiran Then
          If _isBukuBesar Then
            'Rincian Cash Flow"
            BukuBesarCashFlow()
          Else
            LaporanCashFlowLampiran(_isTriwulan)
          End If
        Else
          LaporanCashFlow(_isTriwulan)
        End If
      Case Else
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
    If _jenis = Persistent.CustomReportTipe.CashFlow Then
      If IsSaldoKhusus Then
        result.Add(New InOperator("SumberData", New Persistent.SumberDataJenis() {Persistent.SumberDataJenis.JA, Persistent.SumberDataJenis.JU}))
      Else
        result.Add(New InOperator("SumberData", New Persistent.SumberDataJenis() {Persistent.SumberDataJenis.KM, Persistent.SumberDataJenis.KK, SumberDataJenis.BM, SumberDataJenis.BK}))
      End If
      'If IsSaldoKhusus Then
      '  result.Add(New InOperator("SumberData", New Persistent.SumberDataJenis() {Persistent.SumberData.GetSumberData(_sesi, Persistent.SumberData.SumberDataJenis.JM)}))
      'Else
      '  result.Add(New InOperator("SumberData", New Persistent.SumberDataJenis() {Persistent.SumberData.GetSumberData(_sesi, Persistent.SumberData.SumberDataJenis.KK), Persistent.SumberData.GetSumberData(_sesi, Persistent.SumberData.SumberDataJenis.KM), Persistent.SumberData.GetSumberData(_sesi, Persistent.SumberData.SumberDataJenis.BK), Persistent.SumberData.GetSumberData(_sesi, Persistent.SumberData.SumberDataJenis.BM)}))
      'End If
    End If

    Return GroupOperator.And(result)
  End Function
  Private Function CreateCustom(Tipe As Persistent.CustomReportTipe, PerBulan As Boolean, Optional BulanInTriwulan As Integer = 1) As XPCollection(Of Persistent.Report.LK)
    Dim customs As New DevExpress.Xpo.XPCollection(Of Persistent.Report.LK)(_sesi, New BinaryOperator("Tipe", Tipe, BinaryOperatorType.Equal))
    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, CreateCriteria(BulanInTriwulan))
    Dim detailsKhusus As DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar) = Nothing

    '======== Assign Saldo Awal
    Dim coaDetail = From z In customs Where z.Level = Persistent.CustomReportLevel.DETAIL OrElse z.Level = Persistent.CustomReportLevel.SALDOKHUSUS Order By z.Urutan Select z.Akun Distinct

    If PerBulan Then
      Dim coaSaldoAwalAkhir = From z In customs Where z.Level = Persistent.CustomReportLevel.SALDOAKHIR OrElse z.Level = Persistent.CustomReportLevel.SALDOAWAL Order By z.Urutan Select z.Akun Distinct

      AssignSaldo(coaDetail, details, False, BulanInTriwulan)
      AssignSaldo(coaSaldoAwalAkhir, details, True, BulanInTriwulan)
    Else
      AssignSaldo(coaDetail, details, True, BulanInTriwulan)
    End If

    If Tipe = Persistent.CustomReportTipe.CashFlow Then
      detailsKhusus = New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, CreateCriteria(BulanInTriwulan, True))
    End If

    '======== Assign Saldo Akhir
    Dim subtotal As Double = 0
    Dim total As Double = 0
    customs.Sorting.Add(New SortProperty("Urutan", DB.SortingDirection.Ascending))
    For i = 0 To customs.Count - 1
      Select Case customs(i).Level
        Case Persistent.CustomReportLevel.DETAIL
          If customs(i).Akun Is Nothing Then
            customs(i).Saldo = 0
          Else
            customs(i).Saldo = customs(i).Akun.SaldoAkhir
            CaseDetailSaldo(Tipe, customs(i), subtotal, total)
          End If
        Case Persistent.CustomReportLevel.SALDOAWAL
          customs(i).Saldo = customs(i).Akun.SaldoAwal
        Case Persistent.CustomReportLevel.SALDOKHUSUS
          If Not detailsKhusus Is Nothing Then
            Dim xCoa As Persistent.Coa = customs(i).Akun
            customs(i).Saldo = detailsKhusus.Where(Function(m) m.AkunDetail Is xCoa).Sum(Function(n) n.Debit)
          End If
        Case Persistent.CustomReportLevel.SALDOAKHIR
          customs(i).Saldo = customs(i).Akun.SaldoAkhir
        Case Persistent.CustomReportLevel.SUBTOTAL
          customs(i).Saldo = subtotal
          subtotal = 0
        Case Persistent.CustomReportLevel.TOTAL
          customs(i).Saldo = total
        Case Persistent.CustomReportLevel.HEADER
          customs(i).Saldo = Nothing
          subtotal = 0
      End Select
    Next

    Return customs
  End Function

  Private Sub LaporanNeraca()
    Dim opAktiva As XPCollection(Of Persistent.Report.LK) = CreateCustom(Persistent.CustomReportTipe.NeracaAktiva, False)
    Dim opPassiva As XPCollection(Of Persistent.Report.LK) = CreateCustom(Persistent.CustomReportTipe.NeracaPassiva, False)
    Dim result As New List(Of Persistent.Report.Neraca)

    result = CreateMainLK(opAktiva, False, result)
    result = CreateMainLK(opPassiva, True, result)

    _dataSource = result
  End Sub
  Private Sub LaporanLampiranNeraca()
    Dim original As XPCollection(Of Persistent.Report.LK)

    If CBool(xRadio.EditValue) Then
      AddParameter("Judul", "LAMPIRAN AKTIVA", GetType(System.String))
      original = CreateCustom(Persistent.CustomReportTipe.NeracaAktiva, False)
    Else
      AddParameter("Judul", "LAMPIRAN PASSIVA", GetType(System.String))
      original = CreateCustom(Persistent.CustomReportTipe.NeracaPassiva, False)
    End If
    original.Filter = New GroupOperator(GroupOperatorType.Or, New BinaryOperator("Level", Persistent.CustomReportLevel.DETAIL, BinaryOperatorType.NotEqual), New BinaryOperator("Saldo", 0, BinaryOperatorType.NotEqual))
    _dataSource = original
  End Sub
  Private Sub LaporanRugiLabaHPP()
    Dim original As XPCollection(Of Persistent.Report.LK)

    If CBool(xRadio.EditValue) Then
      If _jenis = Persistent.CustomReportTipe.HPP Then
        AddParameter("Judul", "HPP AKUMULATIF", GetType(System.String))
        original = CreateCustom(Persistent.CustomReportTipe.HPP, False)
      Else
        AddParameter("Judul", "LABA RUGI AKUMULATIF", GetType(System.String))
        original = CreateCustom(Persistent.CustomReportTipe.LabaRugi, False)
      End If
    Else
      If _jenis = Persistent.CustomReportTipe.HPP Then
        AddParameter("Judul", "HPP PER BULAN", GetType(System.String))
        original = CreateCustom(Persistent.CustomReportTipe.HPP, True)
      Else
        AddParameter("Judul", "LABA RUGI PER BULAN", GetType(System.String))
        original = CreateCustom(Persistent.CustomReportTipe.LabaRugi, True)
      End If
    End If

    _dataSource = CreateMainLK(original, True, Nothing)
  End Sub
  Private Sub LaporanRugiLabaHPPLampiran()
    Dim original As XPCollection(Of Persistent.Report.LK)

    If CBool(xRadio.EditValue) Then
      If _jenis = Persistent.CustomReportTipe.HPP Then
        AddParameter("Judul", "LAMPIRAN HPP AKUMULATIF", GetType(System.String))
        original = CreateCustom(Persistent.CustomReportTipe.HPP, False)
      Else
        AddParameter("Judul", "LAMPIRAN LABA RUGI AKUMULATIF", GetType(System.String))
        original = CreateCustom(Persistent.CustomReportTipe.LabaRugi, False)
      End If
    Else
      If _jenis = Persistent.CustomReportTipe.HPP Then
        AddParameter("Judul", "LAMPIRAN HPP PER BULAN", GetType(System.String))
        original = CreateCustom(Persistent.CustomReportTipe.HPP, True)
      Else
        AddParameter("Judul", "LAMPIRAN LABA RUGI PER BULAN", GetType(System.String))
        original = CreateCustom(Persistent.CustomReportTipe.LabaRugi, True)
      End If
    End If

    original.Filter = New GroupOperator(GroupOperatorType.Or, New BinaryOperator("Level", Persistent.CustomReportLevel.DETAIL, BinaryOperatorType.NotEqual), New BinaryOperator("Saldo", 0, BinaryOperatorType.NotEqual))
    _dataSource = original
  End Sub
  Private Sub LaporanCashFlow(Triwulan As Boolean)
    If Triwulan Then
      Dim result As New List(Of Persistent.Report.CashFlow)
      '1,3,5,7
      '0,1,2,3
      '1,4,7,10
      '2,5,8,11
      '3,6,9,12
      Dim x1 As Integer = (txtPeriodeBulan.SelectedIndex * 2) + 1
      Dim x2 As Integer = (txtPeriodeBulan.SelectedIndex * 2) + 2
      Dim x3 As Integer = (txtPeriodeBulan.SelectedIndex * 2) + 3

      AddParameter("Bulan1", MonthName(txtPeriodeBulan.SelectedIndex + x1), GetType(System.String))
      AddParameter("Bulan2", MonthName(txtPeriodeBulan.SelectedIndex + x2), GetType(System.String))
      AddParameter("Bulan3", MonthName(txtPeriodeBulan.SelectedIndex + x3), GetType(System.String))

      result = CreateMainCF(CreateCustom(Persistent.CustomReportTipe.CashFlow, True, x1), result, 1)
      result = CreateMainCF(CreateCustom(Persistent.CustomReportTipe.CashFlow, True, x2), result, 2)
      result = CreateMainCF(CreateCustom(Persistent.CustomReportTipe.CashFlow, True, x3), result, 3)

      _dataSource = result
    Else
      Dim original As XPCollection(Of Persistent.Report.LK)
      original = CreateCustom(Persistent.CustomReportTipe.CashFlow, True)
      _dataSource = CreateMainCF(original, Nothing, 1)
    End If
  End Sub
  Private Sub LaporanCashFlowLampiran(Triwulan As Boolean)
    If Triwulan Then
      Dim result As New List(Of Persistent.Report.LampiranCashFlowTriwulan)

      Dim x1 As Integer = (txtPeriodeBulan.SelectedIndex * 2) + 1
      Dim x2 As Integer = (txtPeriodeBulan.SelectedIndex * 2) + 2
      Dim x3 As Integer = (txtPeriodeBulan.SelectedIndex * 2) + 3

      AddParameter("Bulan1", MonthName(txtPeriodeBulan.SelectedIndex + x1), GetType(System.String))
      AddParameter("Bulan2", MonthName(txtPeriodeBulan.SelectedIndex + x2), GetType(System.String))
      AddParameter("Bulan3", MonthName(txtPeriodeBulan.SelectedIndex + x3), GetType(System.String))

      result = CreateLampiranCF(CreateCustom(Persistent.CustomReportTipe.CashFlow, True, x1), result, 1)
      result = CreateLampiranCF(CreateCustom(Persistent.CustomReportTipe.CashFlow, True, x2), result, 2)
      result = CreateLampiranCF(CreateCustom(Persistent.CustomReportTipe.CashFlow, True, x3), result, 3)

      '=========
      For i = result.Count - 1 To 0 Step -1
        If result(i).JumlahSaldo = 0 Then
          result.Remove(result(i))
        End If
      Next
      _dataSource = result
    Else
      Dim original As XPCollection(Of Persistent.Report.LK)
      original = CreateCustom(Persistent.CustomReportTipe.CashFlow, True)

      original.Filter = CriteriaOperator.And(New BinaryOperator("Level", Persistent.CustomReportLevel.DETAIL, BinaryOperatorType.Equal), New BinaryOperator("Saldo", 0, BinaryOperatorType.NotEqual))
      _dataSource = original
    End If

  End Sub
  Private Sub BukuBesarCashFlow()
    Dim customs As New DevExpress.Xpo.XPCollection(Of Persistent.Report.LK)(_sesi, CriteriaOperator.And(New BinaryOperator("Tipe", Persistent.CustomReportTipe.CashFlow, BinaryOperatorType.Equal), New BinaryOperator("Level", Persistent.CustomReportLevel.DETAIL, BinaryOperatorType.Equal)))
    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, CreateCriteria)
    Dim result As New List(Of Persistent.Report.BukuBesarCashFlow)

    Dim item As Persistent.Report.BukuBesarCashFlow
    Dim akun As Persistent.Coa
    For i = 0 To customs.Count - 1
      akun = customs(i).Akun
      Dim data = From x In details Where x.AkunDetail Is akun Select x

      For j = 0 To data.Count - 1
        item = New Persistent.Report.BukuBesarCashFlow
        item.MainId = customs(i).MainId
        item.Level = customs(i).Level
        item.TandaCF = customs(i).TandaCF
        item.Akun = customs(i).Akun
        If item.TandaCF = Persistent.CustomReportTandaCashFlow.Plus Then
          item.NamaAkun = customs(i).Akun.CFNamaTambah
          item.Nama = "CASH IN " & customs(i).Nama.Trim
        Else
          item.NamaAkun = customs(i).Akun.CFNamaMinus
          item.Nama = "CASH OUT " & customs(i).Nama.Trim
        End If
        item.Tanggal = data(j).Tanggal
        item.NoBukti = data(j).NoBukti
        item.Keterangan = data(j).Keterangan

        If Not item.Akun.GabungCashFlow Then
          If item.TandaCF = Persistent.CustomReportTandaCashFlow.Minus Then
            item.Saldo = data(j).Debit
          Else
            item.Saldo = data(j).Kredit
          End If
        Else
          If item.TandaCF = Persistent.CustomReportTandaCashFlow.Minus Then
            item.Saldo = data(j).Debit - data(j).Kredit
          Else
            item.Saldo = data(j).Kredit - data(j).Debit
          End If
        End If

        If item.Saldo <> 0 Then
          result.Add(item)
        End If
      Next
    Next

    _dataSource = result
  End Sub

  Private Sub CaseDetailSaldo(tipe As Persistent.CustomReportTipe, custom As Persistent.Report.LK, ByRef subtotal As Double, ByRef total As Double)
    Select Case tipe
      Case Persistent.CustomReportTipe.NeracaAktiva
        If custom.Akun.Tipe.Dc = Persistent.CoaEnum.eDc.Debit Then
          subtotal = CDbl(subtotal + custom.Saldo)
          total = CDbl(total + custom.Saldo)
        Else
          subtotal = CDbl(subtotal - custom.Saldo)
          total = CDbl(total - custom.Saldo)
        End If
      Case Persistent.CustomReportTipe.NeracaPassiva
        If custom.Akun.Tipe.Dc = Persistent.CoaEnum.eDc.Debit Then
          subtotal = CDbl(subtotal - custom.Saldo)
          total = CDbl(total - custom.Saldo)
        Else
          subtotal = CDbl(subtotal + custom.Saldo)
          total = CDbl(total + custom.Saldo)
        End If
      Case Persistent.CustomReportTipe.LabaRugi
        If custom.Akun.Tipe.Dc = Persistent.CoaEnum.eDc.Debit Then
          If custom.TandaCF = Persistent.CustomReportTandaCashFlow.Minus Then
            subtotal = CDbl(subtotal + custom.Saldo)
          Else
            subtotal = CDbl(subtotal - custom.Saldo)
          End If
          total = CDbl(total - custom.Saldo)
        Else
          subtotal = CDbl(subtotal + custom.Saldo)
          total = CDbl(total + custom.Saldo)
        End If
      Case Persistent.CustomReportTipe.HPP
        subtotal = CDbl(subtotal + custom.Saldo)
        total = CDbl(total + custom.Saldo)
      Case Persistent.CustomReportTipe.CashFlow
        '======= if gabung cf
        If Not custom.Akun.GabungCashFlow Then
          If custom.TandaCF = Persistent.CustomReportTandaCashFlow.Minus Then
            custom.Saldo = custom.Akun.JMDebit
          Else
            custom.Saldo = custom.Akun.JMKredit
          End If
        Else
          If custom.TandaCF = Persistent.CustomReportTandaCashFlow.Minus Then
            custom.Saldo = custom.Akun.JMDebit - custom.Akun.JMKredit
          Else
            custom.Saldo = custom.Akun.JMKredit - custom.Akun.JMDebit
          End If
        End If

        subtotal = CDbl(subtotal + custom.Saldo)
        If custom.TandaCF = Persistent.CustomReportTandaCashFlow.Minus Then
          total = CDbl(total - custom.Saldo)
        Else
          total = CDbl(total + custom.Saldo)
        End If
    End Select
  End Sub
  Private Sub AssignSaldo(ByRef coa As IEnumerable(Of Coa), details As DevExpress.Xpo.XPCollection(Of Report.BukuBesar), assignSaldoAwal As Boolean, Optional BulanInTriwulan As Integer = 1)
    For i = 0 To coa.Count - 1
      If Not coa(i) Is Nothing Then
        Dim akunId As Integer = coa(i).Id
        Dim xCoa As Coa = coa(i)
        If Not assignSaldoAwal Then
          coa(i).SaldoAwal = 0
        Else
          coa(i).SaldoAwal = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, akunId, New Date(CInt(txtPeriodeTahun.Text), txtPeriodeBulan.SelectedIndex + BulanInTriwulan, 1).ToString("yyyy-MM-dd"))))
        End If
        If details.ToList.Exists(Function(m) m.AkunDetail Is xCoa) Then
          coa(i).JMDebit = details.Where(Function(m) m.AkunDetail Is xCoa).Sum(Function(n) n.Debit)
          coa(i).JMKredit = details.Where(Function(m) m.AkunDetail Is xCoa).Sum(Function(n) n.Kredit)
        Else
          coa(i).JMDebit = 0
          coa(i).JMKredit = 0
        End If
      End If
    Next
  End Sub
  Private Function CreateMainLK(details As XPCollection(Of Report.LK), setToPassiva As Boolean, originals As List(Of Report.Neraca)) As List(Of Report.Neraca)
    If originals Is Nothing Then
      originals = New List(Of Report.Neraca)
    End If

    Dim b = From z In details _
            Group z By z.MainId, z.Nama, z.Level Into Group _
            Select MainId, Nama, Level, Saldo = Group.Sum(Function(k) k.Saldo)

    Dim maiId As Integer
    For i = 0 To b.Count - 1
      Dim item As Report.Neraca
      Dim id As Integer = i
      maiId = b(i).MainId

      If originals.Exists(Function(m) m.Id = id) Then
        item = originals.Single(Function(m) m.Id = id)
      Else
        item = New Report.Neraca
        item.Id = i
        originals.Add(item)
      End If

      If setToPassiva Then
        item.LevelPassiva = b(i).Level
        item.NamaPassiva = b(i).Nama
        If item.LevelPassiva = CustomReportLevel.HEADER Then
          item.SaldoPassiva = Nothing
        ElseIf item.LevelPassiva = CustomReportLevel.DETAIL Then
          Dim debit = From f In details Where f.MainId = maiId AndAlso Not f.Akun Is Nothing AndAlso f.Akun.Tipe.Dc = CoaEnum.eDc.Debit Select f.Saldo * -1
          Dim kredit = From f In details Where f.MainId = maiId AndAlso Not f.Akun Is Nothing AndAlso f.Akun.Tipe.Dc = CoaEnum.eDc.Kredit Select f.Saldo

          item.SaldoPassiva = debit.Sum + kredit.Sum
        Else
          item.SaldoPassiva = b(i).Saldo
        End If
      Else
        item.LevelAktiva = b(i).Level
        item.NamaAktiva = b(i).Nama
        If item.LevelAktiva = CustomReportLevel.HEADER Then
          item.SaldoAktiva = Nothing
        ElseIf item.LevelPassiva = CustomReportLevel.DETAIL Then
          Dim debit = From f In details Where f.MainId = maiId AndAlso Not f.Akun Is Nothing AndAlso f.Akun.Tipe.Dc = CoaEnum.eDc.Debit Select f.Saldo
          Dim kredit = From f In details Where f.MainId = maiId AndAlso Not f.Akun Is Nothing AndAlso f.Akun.Tipe.Dc = CoaEnum.eDc.Kredit Select f.Saldo * -1

          item.SaldoAktiva = debit.Sum + kredit.Sum
        Else
          item.SaldoAktiva = b(i).Saldo
        End If
      End If
    Next

    Return originals
  End Function
  Private Function CreateMainCF(details As XPCollection(Of Report.LK), originals As List(Of Report.CashFlow), setToBulan As Integer) As List(Of Report.CashFlow)
    If originals Is Nothing Then
      originals = New List(Of Report.CashFlow)
    End If

    Dim b = From z In details _
            Group z By z.MainId, z.Nama, z.Level Into Group _
            Select MainId, Nama, Level, Saldo = Group.Sum(Function(k) k.Saldo)

    For i = 0 To b.Count - 1
      Dim item As Report.CashFlow
      Dim id As Integer = i

      If originals.Exists(Function(m) m.Id = id) Then
        item = originals.Single(Function(m) m.Id = id)
      Else
        item = New Report.CashFlow
        item.Id = i
        item.Nama = b(i).Nama
        item.Level = b(i).Level
        originals.Add(item)
      End If

      Select Case setToBulan
        Case 1
          If item.Level = CustomReportLevel.HEADER Then
            item.Saldo1 = Nothing
          Else
            item.Saldo1 = b(i).Saldo
          End If
        Case 2
          If item.Level = CustomReportLevel.HEADER Then
            item.Saldo2 = Nothing
          Else
            item.Saldo2 = b(i).Saldo
          End If
        Case Else
          If item.Level = CustomReportLevel.HEADER Then
            item.Saldo3 = Nothing
          Else
            item.Saldo3 = b(i).Saldo
          End If
      End Select
    Next

    Return originals
  End Function
  Private Function CreateLampiranCF(details As XPCollection(Of Report.LK), originals As List(Of Report.LampiranCashFlowTriwulan), setToBulan As Integer) As List(Of Report.LampiranCashFlowTriwulan)
    If originals Is Nothing Then
      originals = New List(Of Report.LampiranCashFlowTriwulan)
    End If

    For i = 0 To details.Count - 1
      If details(i).Level = CustomReportLevel.DETAIL Then
        Dim item As Report.LampiranCashFlowTriwulan
        Dim id As Int64 = details(i).Id

        If originals.Exists(Function(m) m.Id = id) Then
          item = originals.Single(Function(m) m.Id = id)
        Else
          item = New Report.LampiranCashFlowTriwulan
          item.Id = details(i).Id
          item.MainId = details(i).MainId
          item.Tipe = details(i).Tipe
          item.Urutan = details(i).Urutan
          item.Nama = details(i).Nama
          item.Level = details(i).Level
          item.TandaCF = details(i).TandaCF
          item.Akun = details(i).Akun
          originals.Add(item)
        End If

        Select Case setToBulan
          Case 1
            If item.Level = CustomReportLevel.HEADER Then
              item.Saldo = Nothing
            Else
              item.Saldo = details(i).Saldo
            End If
          Case 2
            If item.Level = CustomReportLevel.HEADER Then
              item.Saldo2 = Nothing
            Else
              item.Saldo2 = details(i).Saldo
            End If
          Case Else
            If item.Level = CustomReportLevel.HEADER Then
              item.Saldo3 = Nothing
            Else
              item.Saldo3 = details(i).Saldo
            End If
        End Select
      End If
    Next

    Return originals
  End Function
End Class