Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports NuSoft.Utils.CustomAttribute

Friend Class RF_SaldoProyek2
  Private _jenis As MainClass.reportName
  Private Enum eSortBy
    <EnumDescription("Tanggal")> Tgl
    <EnumDescription("No Bukti")> NoBukti
    <EnumDescription("Kode Coa")> KodeCOA
    <EnumDescription("Kode Kontak")> KodeKontak
    <EnumDescription("Divisi")> Divisi
    <EnumDescription("Proyek")> Proyek
    <EnumDescription("Sub Proyek")> ProyekSub
    <EnumDescription("Uraian")> Uraian
  End Enum
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
    lytAkun1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    lytAkun2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    lytLevel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    lytPeriodeTahun.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
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
			Case MainClass.reportName.ProyekDaftar
				Me.Text = "Daftar Proyek"
			Case MainClass.reportName.ProyekLabaRugiCOALevel
				Me.Text = "Laba Rugi Proyek/Divisi"
        lytLevel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
      Case MainClass.reportName.ProyekLabaRugiTahunan
        Me.Text = "Laba Rugi Proyek/Divisi Per Tahun"
        lytLevel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lytPeriodeTahun.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
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
    'txtPeriodeAkhir.Properties.MinValue = txtPeriodeAwal.DateTime
    'txtPeriodeAwal.Properties.MaxValue = txtPeriodeAkhir.DateTime

    txtAkun1.Properties.DataSource = Logic.Coa.GetCoa(_sesi, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.PendapatanLainLain, Persistent.CoaEnum.eKind.BiayaLainLain, CoaEnum.eKind.Kas, CoaEnum.eKind.Bank, CoaEnum.eKind.Piutang, CoaEnum.eKind.AktivaTetap, CoaEnum.eKind.AkumulasiPenyusutan, CoaEnum.eKind.AktivaLancarLainnya, CoaEnum.eKind.Persediaan, CoaEnum.eKind.HutangJangkaPendek, CoaEnum.eKind.HutangJangkaPanjang, CoaEnum.eKind.HutangLancarLainnya, CoaEnum.eKind.Modal})
    txtAkun2.Properties.DataSource = Logic.Coa.GetCoa(_sesi, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.PendapatanLainLain, Persistent.CoaEnum.eKind.BiayaLainLain, CoaEnum.eKind.Kas, CoaEnum.eKind.Bank, CoaEnum.eKind.Piutang, CoaEnum.eKind.AktivaTetap, CoaEnum.eKind.AkumulasiPenyusutan, CoaEnum.eKind.AktivaLancarLainnya, CoaEnum.eKind.Persediaan, CoaEnum.eKind.HutangJangkaPendek, CoaEnum.eKind.HutangJangkaPanjang, CoaEnum.eKind.HutangLancarLainnya, CoaEnum.eKind.Modal})

    txtProyek.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)
    txtSubProyek.Properties.DataSource = New XPCollection(Of Persistent.ProyekSub)(_sesi)
    txtDivisi.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(_sesi)
    txtSort1.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(eSortBy))
    txtSort2.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(eSortBy))
    txtSort3.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(eSortBy))
    txtSort4.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(eSortBy))
    If _jenis = MainClass.reportName.ProyekBukuBesar Then
      txtSort1.EditValue = eSortBy.KodeCOA
      txtSort2.EditValue = eSortBy.Tgl
      txtSort1.Properties.ReadOnly = True
    ElseIf _jenis = MainClass.reportName.GLTransaksiHarianProyek Then
      txtSort1.EditValue = eSortBy.Tgl
      txtSort2.EditValue = eSortBy.NoBukti
      txtSort1.Properties.ReadOnly = True
    Else
      txtSort1.Properties.ReadOnly = True
      txtSort2.Properties.ReadOnly = True
      txtSort3.Properties.ReadOnly = True
      txtSort4.Properties.ReadOnly = True
    End If
    txtLevel.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(eLevel))
    txtLevel.EditValue = eLevel.Level4

		If _jenis = MainClass.reportName.ProyekDaftar Then
			lytPeriodeTahun.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
			lytSubProyek.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
			lytDivisi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
			lytPeriode1.Text = "Tgl Berangkat"
			lytAkun1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
			lytAkun2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
			lytLevel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
		End If


		Dim TahunAwal As Integer = Now.Year - 10, TahunAkhir As Integer = Now.Year + 10
    For i = TahunAwal To TahunAkhir
      txtPeriodeTahun.Properties.Items.Add(i.ToString)
    Next
    txtPeriodeTahun.EditValue = Now.Year
  End Sub
	Overrides Sub Filter()
		Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
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
			Else
				AddParameter("SubProyekCode", "All", GetType(String))
				AddParameter("SubProyekName", "All", GetType(String))
			End If
		Else
			AddParameter("ProyekCode", "All", GetType(String))
			AddParameter("ProyekName", "All", GetType(String))
			AddParameter("SubProyekCode", "All", GetType(String))
			AddParameter("SubProyekName", "All", GetType(String))
		End If
		If Not txtDivisi.EditValue Is Nothing Then
			AddParameter("DivisiCode", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Nama, GetType(String))
		Else
			AddParameter("DivisiCode", "All", GetType(String))
		End If

		AddParameter("Periode", txtPeriodeAwal.DateTime.ToString("dd-MMM-yy") & " s/d " & txtPeriodeAkhir.DateTime.ToString("dd-MMM-yy"), GetType(System.String))
		AddParameter("LevelReport", txtLevel.EditValue, GetType(System.String))
		AddParameter("PeriodeTahun", txtPeriodeTahun.EditValue, GetType(System.String))
		'jenis report : 0=all, 1=perproyek, 2=perproyek per sub, 3= perdivisi


		Select Case _jenis
			Case MainClass.reportName.ProyekLabaRugiCOA, MainClass.reportName.ProyekLabaRugiCOALevel
				LaporanLabaRugiCOA()
				Return
			Case MainClass.reportName.ProyekLabaRugiTahunan
				LaporanLabaRugiCOATahunan()
				Return
			Case MainClass.reportName.ProyekBukuBesar
				LaporanBukuBesar()
				Return
			Case MainClass.reportName.ProyekDaftar
				LaporanDaftarProyek()
				Return
			Case MainClass.reportName.ProyekSaldo
				LaporanSaldoProyek()
				Return
			Case MainClass.reportName.GLTransaksiHarianProyek
				LaporanDaftarTransaksi()
				Return
			Case MainClass.reportName.ProyekLabaRugiSanding
				LaporanLabaRugiCOASanding()
				Return
		End Select
	End Sub
	Private Sub LaporanDaftarProyek()
		Dim Details = New XPCollection(Of ViewProyek)(_sesi)
		_dataSource = Details
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
    result.Add(New BinaryOperator("Tahun", txtPeriodeTahun.Text, BinaryOperatorType.Equal))

    If Not Core.SSystem.UserInfo.GetUserDivision Is Nothing Then
      Dim right = From a In Core.SSystem.UserInfo.GetUserDivision Where a.Buka = True Select a.Divisi
      result.Add(New InOperator("AkunDetail.Divisi", right.ToList))
    End If
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
    'Dim pSaldoCOA As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, FilterDataBulanan(1))
    'For pI = 0 To details.Count - 1
    '  Select Case pJ
    '    Case 1 : details(pI).m1 = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)

    '  End Select
    'Next
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

    Dim pSaldoAwal As Double = 0
    Dim pMutasi As Double = 0

    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.xMesitechBukuBesar)(_sesi, FilterDataBukuBesar, CreateSortBy.ToArray)
    'MsgBox("Coanya : " & coa.Count & "-->" & CreateCriteria().ToString)
    For i = 0 To coa.Count - 1
      Dim akunId As Integer = coa(i).Id
      Dim saldo As Double = 0
      If Not txtDivisi.EditValue Is Nothing Then      'jika divisi ada isinya, maka ambil saldo perdivisi
        saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPNameDivisi, akunId, txtPeriodeAwal.DateTime.ToString("yyyy-MM-dd"), CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Id)))
      End If
      If Not txtProyek.EditValue Is Nothing Then
        If txtSubProyek.EditValue Is Nothing Then 'ambil saldo per proyek
          saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPNameProject, akunId, txtPeriodeAwal.DateTime.ToString("yyyy-MM-dd"), CType(txtProyek.EditValue, Persistent.Proyek).Id, 0)))
        Else 'ambil saldo per proyek per sub proyek
          saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPNameProject, akunId, txtPeriodeAwal.DateTime.ToString("yyyy-MM-dd"), CType(txtProyek.EditValue, Persistent.Proyek).Id, CType(txtSubProyek.EditValue, Persistent.ProyekSub).Id)))
        End If
      End If
      If txtDivisi.EditValue Is Nothing AndAlso txtProyek.EditValue Is Nothing Then      'jika kosong semua maka diambilkan saldo per coa
        saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, akunId, txtPeriodeAwal.DateTime.ToString("yyyy-MM-dd"))))
      End If
      pSaldoAwal = pSaldoAwal + saldo
      'MsgBox("Saldo awalnya : " & saldo.ToString("n2"))

      If details.ToList.Exists(Function(m) m.AkunDetail.Id = akunId) Then
        Dim ok = details.ToList.Where(Function(c) c.AkunDetail.Id = akunId)
        For Each x In ok
          x.SaldoAwal = saldo
        Next
        'Dim item As New Persistent.xMesitechBukuBesar(_sesi)
        'item.AkunDetail = coa(i)
        'item.AkunMain = Nothing
        'item.Id = akunId
        'item.Keterangan = ""
        'If coa(i).Tipe.Dc = CoaEnum.eDc.Debit Then
        '  item.Debit = saldo
        '  item.Kredit = 0
        'Else
        '  item.Debit = 0
        '  item.Kredit = saldo
        'End If
        'item.NoBukti = ""
        ''item.SaldoAwal = saldo
        'item.SumberData = Nothing
        'item.Tanggal = txtPeriodeAwal.DateTime
        'item.Urutan = 0
        'details.Add(item)
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
          'If coa(i).Tipe.Dc = CoaEnum.eDc.Debit Then
          '  item.Debit = saldo
          '  item.Kredit = 0
          'Else
          '  item.Debit = 0
          '  item.Kredit = saldo
          'End If
          item.SumberData = Nothing
          item.Tanggal = txtPeriodeAwal.DateTime
          item.Urutan = 0
          details.Add(item)
        End If
      End If
    Next
    AddParameter("zSaldoAWal", pSaldoAwal, GetType(Double))

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
    'result.Add(New BinaryOperator("Tipe.Level1", Persistent.CoaEnum.eLevel1.RugiLaba, BinaryOperatorType.Equal))
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
  Private Function CreateSortBy() As List(Of SortProperty)
    Dim result As New List(Of SortProperty)

    If Not txtSort1.EditValue Is Nothing Then
      result.Add(New SortProperty(GetFieldName(CType(txtSort1.EditValue, eSortBy)), DB.SortingDirection.Ascending))
    End If
    If Not txtSort2.EditValue Is Nothing Then
      result.Add(New SortProperty(GetFieldName(CType(txtSort2.EditValue, eSortBy)), DB.SortingDirection.Ascending))
    End If
    If Not txtSort3.EditValue Is Nothing Then
      result.Add(New SortProperty(GetFieldName(CType(txtSort3.EditValue, eSortBy)), DB.SortingDirection.Ascending))
    End If
    If Not txtSort4.EditValue Is Nothing Then
      result.Add(New SortProperty(GetFieldName(CType(txtSort4.EditValue, eSortBy)), DB.SortingDirection.Ascending))
    End If

    Return result
  End Function
  Private Function GetFieldName(ByVal xJenis As eSortBy) As String
    Dim result As String
    Select Case xJenis
      Case eSortBy.Tgl : result = "Tanggal"
      Case eSortBy.NoBukti : result = "NoBukti"
      Case eSortBy.KodeCOA : result = "AkunDetail.Kode"
      Case eSortBy.KodeKontak : result = "Kontak.Kode"
      Case eSortBy.Divisi : result = "Divisi.Kode"
      Case eSortBy.Proyek : result = "Proyek.Kode"
      Case eSortBy.ProyekSub : result = "ProyekSub.Kode"
      Case eSortBy.Uraian : result = "Keterangan"
      Case Else : result = "Tanggal"
    End Select
    Return result
  End Function
  Private Sub LaporanSaldoProyek()
    Dim xpCoa As New XPCollection(Of Persistent.Coa)(_sesi, CriteriaOperator.Parse("not Induk is null"))
    Dim a = From x In xpCoa Select x.Induk Distinct

    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.SaldoCOA)(_sesi, New GroupOperator(GroupOperator.And, New NotOperator(New InOperator("Id", a))))
    Dim pSaldoCOA As New DevExpress.Xpo.XPCollection(Of Persistent.xMesitechBukuBesar)(_sesi, FilterSaldo)

    Dim pI As Integer
    For pI = 0 To details.Count - 1
      Dim saldo As Double
      If Not txtDivisi.EditValue Is Nothing Then
        saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPNameDivisi, details(pI).Id, txtPeriodeAwal.DateTime.ToString("yyyy-MM-dd"), CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Id)))
      End If
      If Not txtProyek.EditValue Is Nothing Then
        If txtSubProyek.EditValue Is Nothing Then
          'ambil saldo per proyek
          saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPNameProject, details(pI).Id, txtPeriodeAwal.DateTime.ToString("yyyy-MM-dd"), CType(txtProyek.EditValue, Persistent.Proyek).Id, 0)))
        Else
          'ambil saldo per proyek per sub proyek
          saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPNameProject, details(pI).Id, txtPeriodeAwal.DateTime.ToString("yyyy-MM-dd"), CType(txtProyek.EditValue, Persistent.Proyek).Id, CType(txtSubProyek.EditValue, Persistent.ProyekSub).Id)))
        End If
      End If
      'jika kosong semua maka diambilkan saldo per coa
      If txtDivisi.EditValue Is Nothing AndAlso txtProyek.EditValue Is Nothing Then
        saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, details(pI).Id, txtPeriodeAwal.DateTime.ToString("yyyy-MM-dd"))))
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
  Private Sub txtPeriodeAwal_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs)
    'txtPeriodeAkhir.Properties.MinValue = CDate(e.NewValue)
  End Sub
  Private Sub txtPeriodeAkhir_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPeriodeAkhir.EditValueChanging
    'txtPeriodeAwal.Properties.MaxValue = CDate(e.NewValue)
  End Sub
  Private Sub txtProyek_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs)
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtProyek.EditValue = Nothing
    End If
  End Sub
  Private Sub txtSubProyek_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs)
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtSubProyek.EditValue = Nothing
    End If
  End Sub
  Private Sub txtDivisi_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs)
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtDivisi.EditValue = Nothing
    End If
  End Sub
  Private Sub txtSort1_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtSort1.KeyDown, txtSort2.KeyDown, txtSort3.KeyDown, txtSort4.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      CType(sender, DevExpress.XtraEditors.LookUpEdit).EditValue = Nothing
    End If
  End Sub

  Private Sub LaporanDaftarTransaksi()
    'MsgBox("Filter : " & CreateCriteriaGL.ToString & "--> Sort : " & CreateSortByGL.ToString)
    _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.xMesitechGlDetail)(_sesi, CreateCriteriaGL, CreateSortByGL.ToArray)
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
  Private Function CreateSortByGL() As List(Of SortProperty)
    Dim result As New List(Of SortProperty)

    If Not txtSort1.EditValue Is Nothing Then
      result.Add(New SortProperty(GetFieldNameGL(CType(txtSort1.EditValue, eSortBy)), DB.SortingDirection.Ascending))
    End If
    If Not txtSort2.EditValue Is Nothing Then
      result.Add(New SortProperty(GetFieldNameGL(CType(txtSort2.EditValue, eSortBy)), DB.SortingDirection.Ascending))
    End If
    If Not txtSort3.EditValue Is Nothing Then
      result.Add(New SortProperty(GetFieldNameGL(CType(txtSort3.EditValue, eSortBy)), DB.SortingDirection.Ascending))
    End If
    If Not txtSort4.EditValue Is Nothing Then
      result.Add(New SortProperty(GetFieldNameGL(CType(txtSort4.EditValue, eSortBy)), DB.SortingDirection.Ascending))
    End If

    Return result
  End Function
  Private Function GetFieldNameGL(ByVal xJenis As eSortBy) As String
    Dim result As String
    Select Case xJenis
      Case eSortBy.Tgl : result = "Main.Tanggal"
      Case eSortBy.NoBukti : result = "Main.Kode"
      Case eSortBy.KodeCOA : result = "Akun.Kode"
      Case eSortBy.KodeKontak : result = "Main.Kontak.Kode"
      Case eSortBy.Uraian : result = "Main.Uraian"
      Case Else : result = "Main.Tanggal"
    End Select
    Return result
  End Function

  Private Sub LaporanLabaRugiCOASanding()
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
    'Dim pSaldoCOA As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, FilterDataBulanan(1))
    'For pI = 0 To details.Count - 1
    '  Select Case pJ
    '    Case 1 : details(pI).m1 = pSaldoCOA.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)

    '  End Select
    'Next
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

End Class