Imports DevExpress.Data.Filtering

Friend Class RF_NeracaSaldo
  Overrides Sub InitializeData()
    txtPeriodeAwal.DateTime = New Date(Now.Year, Now.Month, 1)
    Dim xAkhirBulan As New Date(Now.Year, Now.Month, 1)
    txtPeriodeAkhir.DateTime = xAkhirBulan.AddMonths(1).AddDays(-(xAkhirBulan.AddMonths(1).Day))

    txtPeriodeAkhir.Properties.MinValue = txtPeriodeAwal.DateTime
    txtPeriodeAwal.Properties.MaxValue = txtPeriodeAkhir.DateTime
  End Sub

  Overrides Sub Filter()
    Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
    Dim m02Setting As New Logic.FinaSetting(_sesi)

    AddParameter("PeriodeAwal", txtPeriodeAwal.DateTime.ToString("dd-MMM-yy"), GetType(System.String))
    AddParameter("PeriodeAkhir", txtPeriodeAkhir.DateTime.ToString("dd-MMM-yy"), GetType(System.String))
    AddParameter("NamaPerusahaan", abcSetting.NamaPerusahaan, GetType(System.String))
    AddParameter("CompanyName", abcSetting.NamaPerusahaan, GetType(String))
    AddParameter("Alamat1", abcSetting.Alamat1, GetType(String))
    AddParameter("Alamat2", abcSetting.Alamat2, GetType(String))
    AddParameter("BidangUsaha", abcSetting.BidangUsaha, GetType(String))
    AddParameter("NoFax", abcSetting.NoFax, GetType(String))
    AddParameter("NoTelp", abcSetting.NoTelp, GetType(String))
    AddParameter("FormatAngka", m02Setting.FormatAngka, GetType(System.String))
    AddParameter("FormatNumeric", m02Setting.NumericFormatString, GetType(System.String))

    Dim coa As DevExpress.Xpo.XPCollection(Of Persistent.Coa) = Logic.Coa.GetCoa(_sesi, True)
    coa.Criteria = CriteriaOperator.And(coa.Criteria, CreateCriteria())
    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, YearMonthCriteria)

    For i = 0 To coa.Count - 1
      Dim akunId As Integer = coa(i).Id
      Dim saldo As Double = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, akunId, txtPeriodeAwal.DateTime.ToString("yyyy-MM-dd"))))

      coa(i).SaldoAwal = saldo
      coa(i).KasDebit = details.Where(Function(m) m.AkunDetail.Id = akunId AndAlso (m.SumberData.Id = Persistent.SumberDataJenis.KM Or m.SumberData.Id = Persistent.SumberDataJenis.KK)).Sum(Function(n) n.Debit)
      coa(i).KasKredit = details.Where(Function(m) m.AkunDetail.Id = akunId AndAlso (m.SumberData.Id = Persistent.SumberDataJenis.KM Or m.SumberData.Id = Persistent.SumberDataJenis.KK)).Sum(Function(n) n.Kredit)
      coa(i).BankDebit = details.Where(Function(m) m.AkunDetail.Id = akunId AndAlso (m.SumberData.Id = Persistent.SumberDataJenis.BM Or m.SumberData.Id = Persistent.SumberDataJenis.BK)).Sum(Function(n) n.Debit)
      coa(i).BankKredit = details.Where(Function(m) m.AkunDetail.Id = akunId AndAlso (m.SumberData.Id = Persistent.SumberDataJenis.BM Or m.SumberData.Id = Persistent.SumberDataJenis.BK)).Sum(Function(n) n.Kredit)
      coa(i).JMDebit = details.Where(Function(m) m.AkunDetail.Id = akunId AndAlso (m.SumberData.Id <> Persistent.SumberDataJenis.KM Or m.SumberData.Id <> Persistent.SumberDataJenis.BM Or m.SumberData.Id <> Persistent.SumberDataJenis.KK Or m.SumberData.Id <> Persistent.SumberDataJenis.BK)).Sum(Function(n) n.Debit)
      coa(i).JMKredit = details.Where(Function(m) m.AkunDetail.Id = akunId AndAlso (m.SumberData.Id <> Persistent.SumberDataJenis.KM Or m.SumberData.Id <> Persistent.SumberDataJenis.BM Or m.SumberData.Id <> Persistent.SumberDataJenis.KK Or m.SumberData.Id <> Persistent.SumberDataJenis.BK)).Sum(Function(n) n.Kredit)
    Next

    _dataSource = coa
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If Not txtAkun1.EditValue Is Nothing Then
      If txtAkun2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Kode", String.Format(format, txtAkun1.Text), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("Kode", txtAkun1.Text, txtAkun2.Text))
      End If
    End If

    Return GroupOperator.And(result)
  End Function
  Private Function YearMonthCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If Core.SSystem.UserInfo.GetUserLevel = 0 Then
      result.Add(New BinaryOperator("Ext", True, BinaryOperatorType.Equal))
    End If
    result.Add(New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))
    If Not txtAkun1.EditValue Is Nothing Then
      If txtAkun2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("AkunDetail.Kode", String.Format(format, txtAkun1.Text), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("AkunDetail.Kode", txtAkun1.Text, txtAkun2.Text))
      End If
    End If

    Return GroupOperator.And(result)
  End Function
  Private Sub txtPeriodeAwal_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPeriodeAwal.EditValueChanging
    txtPeriodeAkhir.Properties.MinValue = CDate(e.NewValue)
  End Sub
  Private Sub txtPeriodeAkhir_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPeriodeAkhir.EditValueChanging
    txtPeriodeAwal.Properties.MaxValue = CDate(e.NewValue)
  End Sub
End Class