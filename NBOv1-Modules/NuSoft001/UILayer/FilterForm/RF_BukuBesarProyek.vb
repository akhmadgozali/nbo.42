Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Friend Class RF_BukuBesarProyek
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
    txtProyek.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)
    txtProyek.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtProyek)
  End Sub

  Overrides Sub Filter()
    If txtPeriodeTahun.EditValue Is Nothing Then
      Utils.Win.MessageBox.Show("Masukkan periode", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      Return
    End If

    Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
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

    Dim coa As DevExpress.Xpo.XPCollection(Of Persistent.Coa) = Logic.Coa.GetCoa(_sesi, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.PendapatanLainLain, Persistent.CoaEnum.eKind.BiayaLainLain})
    coa.Criteria = CriteriaOperator.And(coa.Criteria, CreateCriteria())


    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, YearMonthCriteria)

    For i = 0 To coa.Count - 1
      Dim akunId As Integer = coa(i).Id
      'cek dulu apakah ada transaksi dibulan ini
      Dim xData As New XPCollection(Of Persistent.Report.BukuBesar)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Bulan", txtPeriodeBulan.SelectedIndex + 1, BinaryOperatorType.Equal), New BinaryOperator("Tahun", txtPeriodeTahun.Text, BinaryOperatorType.Equal), New BinaryOperator("AkunDetail.Id", akunId, BinaryOperatorType.Equal), New BinaryOperator("Proyek.Id", CType(txtProyek.EditValue, Persistent.Proyek).Id, BinaryOperatorType.Equal)))
      If xData.Count > 0 Or chkTransaksiKosong.Checked = True Then
        Dim saldo As Double = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPNameProject, akunId, New Date(CInt(txtPeriodeTahun.Text), txtPeriodeBulan.SelectedIndex + 1, 1).ToString("yyyy-MM-dd"), CType(txtProyek.EditValue, Persistent.Proyek).Id)))
        If details.ToList.Exists(Function(m) m.AkunDetail.Id = akunId) Then
          Dim ok = details.ToList.Where(Function(c) c.AkunDetail.Id = akunId)
          For Each x In ok
            x.SaldoAwal = saldo
          Next
        Else
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
          item.Tanggal = New Date(CInt(txtPeriodeTahun.Text), txtPeriodeBulan.SelectedIndex + 1, 1)
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

    'result.Add(New BinaryOperator("Tipe.Level1", Persistent.CoaEnum.eLevel1.RugiLaba, BinaryOperatorType.Equal))

    Return GroupOperator.And(result)
  End Function
  Private Function YearMonthCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If Not Core.SSystem.UserInfo.GetUserDivision Is Nothing Then
      Dim right = From a In Core.SSystem.UserInfo.GetUserDivision Where a.Buka = True Select a.Divisi
      result.Add(New InOperator("AkunDetail.Divisi", right.ToList))
    End If
    result.Add(New BinaryOperator("Bulan", txtPeriodeBulan.SelectedIndex + 1, BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("Tahun", txtPeriodeTahun.Text, BinaryOperatorType.Equal))
    If Not txtAkun1.EditValue Is Nothing Then
      If txtAkun2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("AkunDetail.Kode", String.Format(format, txtAkun1.Text), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("AkunDetail.Kode", txtAkun1.Text, txtAkun2.Text))
      End If
    End If
    result.Add(New BinaryOperator("Proyek.Id", CType(txtProyek.EditValue, Persistent.Proyek).Id, BinaryOperatorType.Equal))
    Return GroupOperator.And(result)
  End Function
End Class