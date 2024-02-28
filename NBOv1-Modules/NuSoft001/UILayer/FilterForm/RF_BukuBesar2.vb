Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Friend Class RF_BukuBesar2
  Public Enum TipeReportBukuBesar
    BukuBesar = 1
    BukuBesarValas = 2
    BukuBesarBank = 3
    DaftarKasBank = 4
  End Enum
  Private _tipe As TipeReportBukuBesar
  Dim setting As Logic.FinaSetting
  Sub New(ByVal TipeReport As TipeReportBukuBesar)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _tipe = TipeReport
    Select Case _tipe
      Case TipeReportBukuBesar.BukuBesar : Me.Text = "Filter Buku Besar"
      Case TipeReportBukuBesar.BukuBesarValas : Me.Text = "Filter Buku Besar Valas"
      Case TipeReportBukuBesar.BukuBesarBank : Me.Text = "Filter Buku Pembantu Bank"
      Case TipeReportBukuBesar.DaftarKasBank : Me.Text = "Filter Data Kas Bank"
    End Select

    If _tipe = TipeReportBukuBesar.DaftarKasBank Then
      lytKodeAkun1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
      lytKodeAkun2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
      lytMutasi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
      lytKasBank.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
      lytDivisi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
    Else
      lytKodeAkun1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
      lytKodeAkun2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
      lytMutasi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
      lytKasBank.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
      lytDivisi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End If
  End Sub
  Overrides Sub InitializeData()
    txtTgl1.DateTime = New Date(Now.Year, Now.Month, 1)
    Dim xAkhirBulan As New Date(Now.Year, Now.Month, 1)
    txtTgl2.DateTime = xAkhirBulan.AddMonths(1).AddDays(-(xAkhirBulan.AddMonths(1).Day))

    txtTgl2.Properties.MinValue = txtTgl1.DateTime
    txtTgl1.Properties.MaxValue = txtTgl2.DateTime
    setting = New Logic.FinaSetting(_sesi)
    txtAkun1.Properties.DataSource = Logic.Coa.GetCoa(_sesi, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.AktivaLancarLainnya, Persistent.CoaEnum.eKind.AktivaTetap, Persistent.CoaEnum.eKind.AkumulasiPenyusutan, Persistent.CoaEnum.eKind.BiayaLainLain, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.HutangJangkaPanjang, Persistent.CoaEnum.eKind.HutangJangkaPendek, Persistent.CoaEnum.eKind.HutangLancarLainnya, Persistent.CoaEnum.eKind.Modal, Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.PendapatanLainLain, Persistent.CoaEnum.eKind.Persediaan, Persistent.CoaEnum.eKind.Piutang, Persistent.CoaEnum.eKind.Bank, Persistent.CoaEnum.eKind.Kas, Persistent.CoaEnum.eKind.Pajak})
    txtAkun2.Properties.DataSource = Logic.Coa.GetCoa(_sesi, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.AktivaLancarLainnya, Persistent.CoaEnum.eKind.AktivaTetap, Persistent.CoaEnum.eKind.AkumulasiPenyusutan, Persistent.CoaEnum.eKind.BiayaLainLain, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.HutangJangkaPanjang, Persistent.CoaEnum.eKind.HutangJangkaPendek, Persistent.CoaEnum.eKind.HutangLancarLainnya, Persistent.CoaEnum.eKind.Modal, Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.PendapatanLainLain, Persistent.CoaEnum.eKind.Persediaan, Persistent.CoaEnum.eKind.Piutang, Persistent.CoaEnum.eKind.Bank, Persistent.CoaEnum.eKind.Kas, Persistent.CoaEnum.eKind.Pajak})

    txtCoaKasBank.Properties.DataSource = Logic.Coa.GetCoa(_sesi, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.Kas, Persistent.CoaEnum.eKind.Bank})
    txtDivisi.Properties.DataSource = New DevExpress.Xpo.XPCollection(Of NPO.Modules.ModSys.Divisi)(_sesi)
    txtKontak.Properties.DataSource = New DevExpress.Xpo.XPCollection(Of Persistent.Kontak)(_sesi)
    txtRegional.Properties.DataSource = New XPCollection(Of NuSoft.NPO.Modules.ModSys.Regional)(_sesi)
  End Sub
  Overrides Sub Filter()
    If txtTgl1.EditValue Is Nothing Or txtTgl2.EditValue Is Nothing Then
      Utils.Win.MessageBox.Show("Masukkan periode dengan benar", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      Return
    End If
    If _tipe = TipeReportBukuBesar.DaftarKasBank AndAlso txtCoaKasBank.EditValue Is Nothing Then
      Utils.Win.MessageBox.Show("Silahkan pilih coa kas/bank yang ingin ditampilkan", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      Return
    End If
    If _tipe = TipeReportBukuBesar.DaftarKasBank Then
      If txtDivisi.EditValue Is Nothing Then
        Utils.Win.MessageBox.Show("Silahkan pilih coa divisi yang akan ditampilkan", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
        Return
      End If
    End If


    Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
    Dim m02Setting As New Logic.FinaSetting(_sesi)

    AddParameter("PeriodeAwal", txtTgl1.DateTime.ToString("dd-MMM-yyyy"), GetType(System.String))
    AddParameter("PeriodeAkhir", txtTgl2.DateTime.ToString("dd-MMM-yyyy"), GetType(System.String))
    AddParameter("NamaPerusahaan", abcSetting.NamaPerusahaan, GetType(System.String))
    AddParameter("CompanyName", abcSetting.NamaPerusahaan, GetType(String))
    AddParameter("Alamat1", abcSetting.Alamat1, GetType(String))
    AddParameter("Alamat2", abcSetting.Alamat2, GetType(String))
    AddParameter("BidangUsaha", abcSetting.BidangUsaha, GetType(String))
    AddParameter("NoFax", abcSetting.NoFax, GetType(String))
    AddParameter("NoTelp", abcSetting.NoTelp, GetType(String))

    AddParameter("FormatAngka", m02Setting.FormatAngka, GetType(System.String))
    AddParameter("FormatNumeric", m02Setting.NumericFormatString, GetType(System.String))

    If txtRegional.EditValue Is Nothing Then
      AddParameter("Regional ", "All", GetType(System.String))
    Else
      AddParameter("Regional ", CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Nama, GetType(System.String))
    End If


    Select Case _tipe
      Case TipeReportBukuBesar.BukuBesar : CreateBukuBesar()
      Case TipeReportBukuBesar.BukuBesarValas : CreateBukuBesarValas()
      Case TipeReportBukuBesar.BukuBesarBank : CreateBukuBesarBank()
      Case TipeReportBukuBesar.DaftarKasBank : CreateDataKasBank()
    End Select
  End Sub
  Private Sub CreateBukuBesar()
    Dim coa As DevExpress.Xpo.XPCollection(Of Persistent.Coa) = Logic.Coa.GetCoa(_sesi, True)
    coa.Criteria = CriteriaOperator.And(coa.Criteria, CreateCriteria())

    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, YearMonthCriteria)

    For i = 0 To coa.Count - 1
      Dim akunId As Integer = coa(i).Id
      'Dim saldo As Double = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, akunId, txtTgl1.DateTime.ToString("yyyy-MM-dd"))))
      Dim saldo As Double = 0 '= CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, akunId, txtTgl1.DateTime.ToString("yyyy-MM-dd"))))
			If Not txtRegional.EditValue Is Nothing Then
				saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPNameRegional, CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, akunId, txtTgl1.DateTime.ToString("yyyy-MM-dd"))))
			Else
				If txtKontak.EditValue Is Nothing Then
          saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, akunId, txtTgl1.DateTime.ToString("yyyy-MM-dd"))))
        Else
          saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPNameContact, akunId, txtTgl1.DateTime.ToString("yyyy-MM-dd"), CType(txtKontak.EditValue, Persistent.Kontak).Id)))
        End If
      End If

      If details.ToList.Exists(Function(m) m.AkunDetail.Id = akunId) Then
        Dim ok = details.ToList.Where(Function(c) c.AkunDetail.Id = akunId)
        For Each x In ok
          x.SaldoAwal = saldo
        Next
      Else
        If chkKosong.Checked = True Then
          Dim item As New Persistent.Report.BukuBesar(_sesi)
          item.AkunDetail = coa(i)
          item.AkunMain = Nothing
          item.Debit = 0
          item.Id = akunId
          item.Keterangan = ""
          item.Kredit = 0
          item.NoBukti = "Saldo Awal"
          item.SaldoAwal = saldo
          item.SumberData = Nothing
          item.Tanggal = CType(txtTgl1.DateTime, Date)
          item.Urutan = 0
          details.Add(item)
        End If
      End If
    Next

    _dataSource = details
  End Sub
  Private Sub CreateBukuBesarValas()
    Dim coa As New DevExpress.Xpo.XPCollection(Of Persistent.Coa)(_sesi, CreateCriteria)


    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, YearMonthCriteria)

    'MsgBox(coa.Criteria.ToString())
    'MsgBox(details.Criteria.ToString())
    For i = 0 To coa.Count - 1
      Dim akunId As Integer = coa(i).Id
      Dim saldo As Double = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceValas, akunId, txtTgl1.DateTime.ToString("yyyy-MM-dd"))))

      If details.ToList.Exists(Function(m) m.AkunDetail.Id = akunId) Then
        Dim ok = details.ToList.Where(Function(c) c.AkunDetail.Id = akunId)
        For Each x In ok
          x.SaldoAwal = saldo
        Next
      Else
        Dim item As New Persistent.Report.BukuBesar(_sesi)
        item.Id = akunId
        item.AkunDetail = coa(i)
        item.AkunMain = Nothing
        item.DebitValas = 0
        item.KreditValas = 0
        item.Keterangan = "Saldo Awal"
        item.NoBukti = "Saldo Awal"
        item.SaldoAwal = saldo
        item.SumberData = Nothing
        item.Tanggal = CType(txtTgl1.DateTime, Date)
        item.Urutan = 0
        details.Add(item)
      End If
    Next

    _dataSource = details
  End Sub
  Private Sub CreateBukuBesarBank()
    Dim coa As DevExpress.Xpo.XPCollection(Of Persistent.Coa) = Logic.Coa.GetCoa(_sesi, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Kas, Persistent.CoaEnum.eKind.Bank})
    coa.Criteria = CriteriaOperator.And(coa.Criteria, CreateCriteria())

    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesarPembantuBank)(_sesi, YearMonthCriteriaBank)

    For i = 0 To coa.Count - 1
      Dim akunId As Integer = coa(i).Id
      Dim saldo As Double = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, akunId, txtTgl1.DateTime.ToString("yyyy-MM-dd"))))

      If details.ToList.Exists(Function(m) m.AkunDetail.Id = akunId) Then
        Dim ok = details.ToList.Where(Function(c) c.AkunDetail.Id = akunId)
        For Each x In ok
          x.SaldoAwal = saldo
        Next
      Else
        Dim item As New Persistent.Report.BukuBesarPembantuBank(_sesi)
        item.Id = akunId
        item.AkunDetail = coa(i)
        item.AkunMain = coa(i)
        item.DebitValas = 0
        item.KreditValas = 0
        item.Keterangan = "Saldo Awal"
        item.NoBukti = "Saldo Awal"
        item.SaldoAwal = saldo
        item.SumberData = Nothing
        item.Tanggal = CType(txtTgl1.DateTime, Date)
        item.Urutan = 0
        details.Add(item)
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
    If _tipe = TipeReportBukuBesar.BukuBesarValas Then
      result.Add(New BinaryOperator("MataUang.Id", setting.MultiMataUangDefault, BinaryOperatorType.NotEqual))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Function YearMonthCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If Not Core.SSystem.UserInfo.GetUserDivision Is Nothing Then
      Dim right = From a In Core.SSystem.UserInfo.GetUserDivision Where a.Buka = True Select a.Divisi
      result.Add(New InOperator("AkunDetail.Divisi", right.ToList))
    End If
    If Not txtTgl1.EditValue Is Nothing Then
      result.Add(New BetweenOperator("Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
    End If
    If Not txtAkun1.EditValue Is Nothing Then
      If txtAkun2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("AkunDetail.Kode", String.Format(format, txtAkun1.Text), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("AkunDetail.Kode", txtAkun1.Text, txtAkun2.Text))
      End If
    End If
    If _tipe = TipeReportBukuBesar.BukuBesarValas Then
      result.Add(New BinaryOperator("AkunDetail.MataUang.Id", setting.MultiMataUangDefault, BinaryOperatorType.NotEqual))
    End If
    If Not txtKontak.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Kontak.Id", CType(txtKontak.EditValue, Persistent.Kontak).Id, BinaryOperatorType.Equal))
    End If
    If Not txtRegional.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Regional.Id", CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Function YearMonthCriteriaBank() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If Not Core.SSystem.UserInfo.GetUserDivision Is Nothing Then
      Dim right = From a In Core.SSystem.UserInfo.GetUserDivision Where a.Buka = True Select a.Divisi
      result.Add(New InOperator("AkunDetail.Divisi", right.ToList))
    End If
    If Not txtTgl1.EditValue Is Nothing Then
      result.Add(New BetweenOperator("Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
    End If
    If Not txtAkun1.EditValue Is Nothing Then
      If txtAkun2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("AkunMain.Kode", String.Format(format, txtAkun1.Text), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("AkunMain.Kode", txtAkun1.Text, txtAkun2.Text))
      End If
    End If
    'akun main tipenya kas
    result.Add(New InOperator("AkunMain.Tipe.Id", New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Kas, NuSoft001.Persistent.CoaEnum.eKind.Bank}))
    Return GroupOperator.And(result)
  End Function
  Private Sub txtTgl1_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTgl1.EditValueChanging
    txtTgl2.Properties.MinValue = CDate(e.NewValue)
  End Sub
  Private Sub txtTgl2_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTgl2.EditValueChanging
    txtTgl1.Properties.MaxValue = CDate(e.NewValue)
  End Sub

  Private Sub CreateDataKasBank()
    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.GlMainDetail)(_sesi, createCriteriaDataKasBank)
    _dataSource = details
  End Sub
  Private Function createCriteriaDataKasBank() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BinaryOperator("Divisi.Id", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Id, BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("Debit", 0, BinaryOperatorType.Greater))
    result.Add(New BinaryOperator("Urutan", 0, BinaryOperatorType.Greater))
    result.Add(New BinaryOperator("Main.fCOA.Id", CType(txtCoaKasBank.EditValue, Persistent.Coa).Id, BinaryOperatorType.Equal))
    result.Add(New BetweenOperator("Main.Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
    Return GroupOperator.And(result)
  End Function

  Private Sub txtAkun2_EditValueChanged(sender As Object, e As EventArgs) Handles txtAkun2.EditValueChanged

  End Sub
End Class