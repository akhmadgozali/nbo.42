Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports NuSoft.Utils.CustomAttribute

Friend Class RF_SaldoProyekSanding
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


    Me.Text = "Laba Rugi Proyek Sanding"
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

    txtProyek1.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)
    txtProyek2.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)
    txtProyek3.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)
    txtProyek4.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)
    txtProyek5.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)
    txtProyek6.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)
    txtProyek7.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)
    txtProyek8.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)
    txtProyek9.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)
    txtProyek10.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)


    txtProyek10.EditValue = Nothing

    txtSort1.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(eSortBy))
    txtSort2.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(eSortBy))
    txtSort3.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(eSortBy))
    txtSort4.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(eSortBy))

    txtSort1.Properties.ReadOnly = True
    txtSort2.Properties.ReadOnly = True
    txtSort3.Properties.ReadOnly = True
    txtSort4.Properties.ReadOnly = True
    txtLevel.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(eLevel))
    txtLevel.EditValue = eLevel.Level4

    'Dim TahunAwal As Integer = Now.Year - 10, TahunAkhir As Integer = Now.Year + 10
    'For i = TahunAwal To TahunAkhir
    '  txtPeriodeTahun.Properties.Items.Add(i.ToString)
    'Next
    'txtPeriodeTahun.EditValue = Now.Year
  End Sub
  Overrides Sub Filter()
    Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
    Dim m02Setting As New Logic.FinaSetting(_sesi)

    AddParameter("NamaPerusahaan", abcSetting.NamaPerusahaan, GetType(System.String))
    AddParameter("FormatAngka", m02Setting.FormatAngka, GetType(System.String))
    AddParameter("FormatNumeric", m02Setting.NumericFormatString, GetType(System.String))
    AddParameter("CompanyName", abcSetting.NamaPerusahaan, GetType(String))
    AddParameter("Alamat1", abcSetting.Alamat1, GetType(String))
    AddParameter("Alamat2", abcSetting.Alamat2, GetType(String))
    AddParameter("BidangUsaha", abcSetting.BidangUsaha, GetType(String))
    AddParameter("NoFax", abcSetting.NoFax, GetType(String))
    AddParameter("NoTelp", abcSetting.NoTelp, GetType(String))


    AddParameter("Periode", txtPeriodeAwal.DateTime.ToString("dd-MMM-yy") & " s/d " & txtPeriodeAkhir.DateTime.ToString("dd-MMM-yy"), GetType(System.String))
    AddParameter("LevelReport", txtLevel.EditValue, GetType(System.String))

    Select Case _jenis
      Case MainClass.reportName.ProyekLabaRugiSanding
        If Len(txtProyek1.Text) > 0 Then
          AddParameter("Proyek1", txtProyek1.Text, GetType(System.String))
        End If
        If Len(txtProyek2.Text) > 0 Then
          AddParameter("Proyek2", txtProyek2.Text, GetType(System.String))
        End If
        If Len(txtProyek3.Text) > 0 Then
          AddParameter("Proyek3", txtProyek3.Text, GetType(System.String))
        End If
        If Len(txtProyek4.Text) > 0 Then
          AddParameter("Proyek4", txtProyek4.Text, GetType(System.String))
        End If
        If Len(txtProyek5.Text) > 0 Then
          AddParameter("Proyek5", txtProyek5.Text, GetType(System.String))
        End If
        If Len(txtProyek6.Text) > 0 Then
          AddParameter("Proyek6", txtProyek6.Text, GetType(System.String))
        End If
        If Len(txtProyek7.Text) > 0 Then
          AddParameter("Proyek7", txtProyek7.Text, GetType(System.String))
        End If
        If Len(txtProyek8.Text) > 0 Then
          AddParameter("Proyek8", txtProyek8.Text, GetType(System.String))
        End If
        If Len(txtProyek9.Text) > 0 Then
          AddParameter("Proyek9", txtProyek9.Text, GetType(System.String))
        End If
        If Len(txtProyek10.Text) > 0 Then
          AddParameter("Proyek10", txtProyek10.Text, GetType(System.String))
        End If
        LaporanLabaRugiCOASanding()
        Return
    End Select
  End Sub
  Private Sub LaporanLabaRugiCOASanding()
    Dim xpCoa As New XPCollection(Of Persistent.Coa)(_sesi, CriteriaOperator.Parse("not Induk is null"))
    Dim a = From x In xpCoa Select x.Induk Distinct
    Dim pI As Integer
    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.SaldoCOA)(_sesi, New GroupOperator(GroupOperator.And, New NotOperator(New InOperator("Id", a)), New BinaryOperator("Tipe.Level1", CoaEnum.eLevel1.RugiLaba, BinaryOperatorType.Equal)))

    If Len(txtProyek1.Text) > 0 Then
      Dim pDtSaldo As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, FilterData(txtProyek1.Text))
      For pI = 0 To details.Count - 1
        details(pI).m1 = pDtSaldo.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
        details(pI).SaldoAkhir = details(pI).m1 + details(pI).m2 + details(pI).m3 + details(pI).m4 + details(pI).m5 + details(pI).m6 + details(pI).m7 + details(pI).m8 + details(pI).m9 + details(pI).m10 + details(pI).m11 + details(pI).m12
      Next
    End If
    If Len(txtProyek2.Text) > 0 Then
      Dim pDtSaldo As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, FilterData(txtProyek2.Text))
      For pI = 0 To details.Count - 1
        details(pI).m2 = pDtSaldo.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
        details(pI).SaldoAkhir = details(pI).m1 + details(pI).m2 + details(pI).m3 + details(pI).m4 + details(pI).m5 + details(pI).m6 + details(pI).m7 + details(pI).m8 + details(pI).m9 + details(pI).m10 + details(pI).m11 + details(pI).m12
      Next
    End If
    If Len(txtProyek3.Text) > 0 Then
      Dim pDtSaldo As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, FilterData(txtProyek3.Text))
      For pI = 0 To details.Count - 1
        details(pI).m3 = pDtSaldo.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
        details(pI).SaldoAkhir = details(pI).m1 + details(pI).m2 + details(pI).m3 + details(pI).m4 + details(pI).m5 + details(pI).m6 + details(pI).m7 + details(pI).m8 + details(pI).m9 + details(pI).m10 + details(pI).m11 + details(pI).m12
      Next
    End If
    If Len(txtProyek4.Text) > 0 Then
      Dim pDtSaldo As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, FilterData(txtProyek4.Text))
      For pI = 0 To details.Count - 1
        details(pI).m4 = pDtSaldo.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
        details(pI).SaldoAkhir = details(pI).m1 + details(pI).m2 + details(pI).m3 + details(pI).m4 + details(pI).m5 + details(pI).m6 + details(pI).m7 + details(pI).m8 + details(pI).m9 + details(pI).m10 + details(pI).m11 + details(pI).m12
      Next
    End If
    If Len(txtProyek5.Text) > 0 Then
      Dim pDtSaldo As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, FilterData(txtProyek5.Text))
      For pI = 0 To details.Count - 1
        details(pI).m5 = pDtSaldo.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
        details(pI).SaldoAkhir = details(pI).m1 + details(pI).m2 + details(pI).m3 + details(pI).m4 + details(pI).m5 + details(pI).m6 + details(pI).m7 + details(pI).m8 + details(pI).m9 + details(pI).m10 + details(pI).m11 + details(pI).m12
      Next
    End If
    If Len(txtProyek6.Text) > 0 Then
      Dim pDtSaldo As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, FilterData(txtProyek6.Text))
      For pI = 0 To details.Count - 1
        details(pI).m6 = pDtSaldo.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
        details(pI).SaldoAkhir = details(pI).m1 + details(pI).m2 + details(pI).m3 + details(pI).m4 + details(pI).m5 + details(pI).m6 + details(pI).m7 + details(pI).m8 + details(pI).m9 + details(pI).m10 + details(pI).m11 + details(pI).m12
      Next
    End If
    If Len(txtProyek7.Text) > 0 Then
      Dim pDtSaldo As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, FilterData(txtProyek7.Text))
      For pI = 0 To details.Count - 1
        details(pI).m7 = pDtSaldo.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
        details(pI).SaldoAkhir = details(pI).m1 + details(pI).m2 + details(pI).m3 + details(pI).m4 + details(pI).m5 + details(pI).m6 + details(pI).m7 + details(pI).m8 + details(pI).m9 + details(pI).m10 + details(pI).m11 + details(pI).m12
      Next
    End If
    If Len(txtProyek8.Text) > 0 Then
      Dim pDtSaldo As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, FilterData(txtProyek8.Text))
      For pI = 0 To details.Count - 1
        details(pI).m8 = pDtSaldo.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
        details(pI).SaldoAkhir = details(pI).m1 + details(pI).m2 + details(pI).m3 + details(pI).m4 + details(pI).m5 + details(pI).m6 + details(pI).m7 + details(pI).m8 + details(pI).m9 + details(pI).m10 + details(pI).m11 + details(pI).m12
      Next
    End If
    If Len(txtProyek9.Text) > 0 Then
      Dim pDtSaldo As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, FilterData(txtProyek9.Text))
      For pI = 0 To details.Count - 1
        details(pI).m9 = pDtSaldo.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
        details(pI).SaldoAkhir = details(pI).m1 + details(pI).m2 + details(pI).m3 + details(pI).m4 + details(pI).m5 + details(pI).m6 + details(pI).m7 + details(pI).m8 + details(pI).m9 + details(pI).m10 + details(pI).m11 + details(pI).m12
      Next
    End If
    If Len(txtProyek10.Text) > 0 Then
      Dim pDtSaldo As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, FilterData(txtProyek10.Text))
      For pI = 0 To details.Count - 1
        details(pI).m10 = pDtSaldo.Where(Function(m) m.AkunDetail.Id = details(pI).Id).Sum(Function(n) n.Kredit - n.Debit)
        details(pI).SaldoAkhir = details(pI).m1 + details(pI).m2 + details(pI).m3 + details(pI).m4 + details(pI).m5 + details(pI).m6 + details(pI).m7 + details(pI).m8 + details(pI).m9 + details(pI).m10 + details(pI).m11 + details(pI).m12
      Next
    End If

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
  Private Function FilterData(ByVal xProyek As String) As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    result.Add(New BinaryOperator("Proyek.Kode", xProyek, BinaryOperatorType.Equal))
    result.Add(New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))

    Return GroupOperator.And(result)
  End Function


  Private Sub txtProyek1_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtProyek1.KeyDown, txtProyek2.KeyDown, txtProyek3.KeyDown, txtProyek4.KeyDown, txtProyek5.KeyDown, txtProyek6.KeyDown, txtProyek7.KeyDown, txtProyek8.KeyDown, txtProyek9.KeyDown, txtProyek10.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      CType(sender, DevExpress.XtraEditors.LookUpEdit).EditValue = Nothing
    End If
  End Sub
End Class