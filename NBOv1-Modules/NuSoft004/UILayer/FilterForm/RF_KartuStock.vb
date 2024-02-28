Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Public Class RF_KartuStock
  Overrides Sub InitializeData()
    Dim period = New DevExpress.Xpo.XPCollection(Of NuSoft001.Persistent.Periode)(_sesi)
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
    txtKodeBarang.Properties.DataSource = New XPCollection(Of Persistent.Barang)(_sesi)
  End Sub
  Overrides Sub Filter()
    If txtPeriodeTahun.EditValue Is Nothing Then
      Utils.Win.MessageBox.Show("Masukkan periode", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      Return
    End If

    Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
    Dim m02Setting As New NuSoft001.Logic.FinaSetting(_sesi)

    AddParameter("Periode", txtPeriodeBulan.Text.ToUpper & " " & txtPeriodeTahun.Text, GetType(System.String))
    AddParameter("NamaPerusahaan", abcSetting.NamaPerusahaan, GetType(System.String))
    AddParameter("FormatAngka", m02Setting.FormatAngka, GetType(System.String))
    AddParameter("FormatNumeric", m02Setting.NumericFormatString, GetType(System.String))

    'Using splashManager As New DevExpress.XtraSplashScreen.SplashScreenManager(Nothing, GetType(Core.Win.Forms.WaitForm), True, True)
    '  splashManager.ShowWaitForm()
    '  splashManager.SetWaitFormCaption("Silahkan Tunggu")
    '  splashManager.SetWaitFormDescription("Proses Hitung Saldo ...")
    MsgBox("OKE 1")
    Dim barang As New DevExpress.Xpo.XPCollection(Of Persistent.Barang)
    barang.Criteria = CriteriaOperator.And(barang.Criteria, CreateCriteria())

    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.KartuStock)(_sesi, YearMonthCriteria)

    MsgBox("OKE2")
    'For i = 0 To barang.Count - 1
    '  Dim barangID As Int64 = barang(i).Id
    '  Dim saldo As Double = CDbl(_sesi.ExecuteScalar(String.Format(Logic.Umum.GetBeginningBalanceSPName, barangID, New Date(CInt(txtPeriodeTahun.Text), txtPeriodeBulan.SelectedIndex + 1, 1).ToString("yyyy-MM-dd"))))
    '  'Dim saldo As Double = 0

    '  If details.ToList.Exists(Function(m) m.Barang.Id = barangID) Then
    '    Dim ok = details.ToList.Where(Function(c) c.Barang.Id = barangID)
    '    For Each x In ok
    '      x.SaldoAwal = saldo
    '    Next
    '  Else
    '    Dim item As New Persistent.Report.KartuStock(_sesi)
    '    item.Barang = barang(i)
    '    item.Masuk = 0
    '    item.Keluar = 0
    '    item.SaldoAwal = saldo
    '    item.Keterangan = ""
    '    item.NoBukti = "Saldo Awal"
    '    item.SumberData = Nothing
    '    item.Tanggal = New Date(CInt(txtPeriodeTahun.Text), txtPeriodeBulan.SelectedIndex + 1, 1)
    '    details.Add(item)
    '  End If
    'Next
    MsgBox("OKE3")
    '  splashManager.CloseWaitForm()
    'End Using

    _dataSource = details

  End Sub
  Private Function YearMonthCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

  result.Add(New BinaryOperator("Bulan", txtPeriodeBulan.SelectedIndex + 1, BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("Tahun", txtPeriodeTahun.Text, BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("Barang", CType(txtKodeBarang.EditValue, Persistent.Barang), BinaryOperatorType.Equal))
    Return GroupOperator.And(result)
  End Function
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If Not txtKodeBarang.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Kode", txtKodeBarang.Text, BinaryOperatorType.Equal))
    End If

    Return GroupOperator.And(result)
  End Function
End Class