Imports DevExpress.Data.Filtering

Friend Class RF_NeracaSaldo
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
    AddParameter("FormatAngka", m02Setting.FormatAngka, GetType(System.String))
    AddParameter("FormatNumeric", m02Setting.NumericFormatString, GetType(System.String))

    Dim coa As DevExpress.Xpo.XPCollection(Of Persistent.Coa) = Logic.Coa.GetCoa(_sesi, True)
    coa.Criteria = CriteriaOperator.And(coa.Criteria, CreateCriteria())
    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.BukuBesar)(_sesi, YearMonthCriteria)

    'Dim getKM As Persistent.SumberDataJenis = Persistent.SumberDataJenis(_sesi, Persistent.SumberDataJenis.KM)
    'Dim getKK As Persistent.SumberData = Persistent.SumberData.GetSumberData(_sesi, Persistent.SumberData.SumberDataJenis.KK)
    'Dim getBM As Persistent.SumberData = Persistent.SumberData.GetSumberData(_sesi, Persistent.SumberData.SumberDataJenis.BM)
    'Dim getBK As Persistent.SumberData = Persistent.SumberData.GetSumberData(_sesi, Persistent.SumberData.SumberDataJenis.BK)
    'Dim getJM As Persistent.SumberData = Persistent.SumberData.GetSumberData(_sesi, Persistent.SumberData.SumberDataJenis.JM)

    For i = 0 To coa.Count - 1
      Dim akunId As Integer = coa(i).Id
      Dim saldo As Double = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, akunId, New Date(CInt(txtPeriodeTahun.Text), txtPeriodeBulan.SelectedIndex + 1, 1).ToString("yyyy-MM-dd"))))

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
    result.Add(New BinaryOperator("Bulan", txtPeriodeBulan.SelectedIndex + 1, BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("Tahun", txtPeriodeTahun.Text, BinaryOperatorType.Equal))
    If Not txtAkun1.EditValue Is Nothing Then
      If txtAkun2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("AkunDetail.Kode", String.Format(format, txtAkun1.Text), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("AkunDetail.Kode", txtAkun1.Text, txtAkun2.Text))
      End If
    End If

    Return GroupOperator.And(result)
  End Function
End Class