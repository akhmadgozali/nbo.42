Imports DevExpress.Data.Filtering
Friend Class zWoojin_RFBukuBesar
  Dim setting As Logic.FinaSetting
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeData()
    txtTgl1.DateTime = New Date(Now.Year, Now.Month, 1)
    Dim xAkhirBulan As New Date(Now.Year, Now.Month, 1)
    txtTgl2.DateTime = xAkhirBulan.AddMonths(1).AddDays(-(xAkhirBulan.AddMonths(1).Day))

    txtTgl2.Properties.MinValue = txtTgl1.DateTime
    txtTgl1.Properties.MaxValue = txtTgl2.DateTime
    setting = New Logic.FinaSetting(_sesi)
    txtKontak.Properties.DataSource = New DevExpress.Xpo.XPCollection(Of Persistent.Kontak)(_sesi)
  End Sub
  Overrides Sub Filter()
    If txtTgl1.EditValue Is Nothing Or txtTgl2.EditValue Is Nothing Then
      Utils.Win.MessageBox.Show("Masukkan periode dengan benar", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      Return
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
    Dim xBrankas As New DevExpress.Xpo.XPCollection(Of Persistent.zWoojinBrankas)(_sesi, New BetweenOperator("Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
    If xBrankas.Count > 0 Then
      AddParameter("B1", xBrankas(0).N1.ToString, GetType(String))
      AddParameter("B2", xBrankas(0).N2.ToString, GetType(String))
      AddParameter("B3", xBrankas(0).N3.ToString, GetType(String))
      AddParameter("B4", xBrankas(0).N4.ToString, GetType(String))
      AddParameter("B5", xBrankas(0).N5.ToString, GetType(String))
      AddParameter("B6", xBrankas(0).N6.ToString, GetType(String))
      AddParameter("B7", xBrankas(0).N7.ToString, GetType(String))
      AddParameter("B8", xBrankas(0).N8.ToString, GetType(String))
      AddParameter("B9", xBrankas(0).N9.ToString, GetType(String))
      AddParameter("B10", xBrankas(0).N10.ToString, GetType(String))
      AddParameter("B11", xBrankas(0).N11.ToString, GetType(String))
      AddParameter("B12", xBrankas(0).N12.ToString, GetType(String))
      AddParameter("B13", xBrankas(0).N13.ToString, GetType(String))
      AddParameter("B14", xBrankas(0).N14.ToString, GetType(String))
      AddParameter("B15", xBrankas(0).N15.ToString, GetType(String))
      AddParameter("B16", xBrankas(0).N16.ToString, GetType(String))
      AddParameter("B17", xBrankas(0).N17.ToString, GetType(String))
      AddParameter("B18", xBrankas(0).N18.ToString, GetType(String))
      AddParameter("B19", xBrankas(0).N19.ToString, GetType(String))
      AddParameter("B20", xBrankas(0).N20.ToString, GetType(String))
      AddParameter("B21", xBrankas(0).N21.ToString, GetType(String))
      AddParameter("B22", xBrankas(0).N22.ToString, GetType(String))
      AddParameter("B23", xBrankas(0).N23.ToString, GetType(String))
      AddParameter("B24", xBrankas(0).N24.ToString, GetType(String))
      AddParameter("B25", xBrankas(0).N25.ToString, GetType(String))
    End If

    CreateBukuBesar()
  End Sub
  Private Sub CreateBukuBesar()
    Dim coa As DevExpress.Xpo.XPCollection(Of Persistent.Coa) = Logic.Coa.GetCoa(_sesi, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.Bank, Persistent.CoaEnum.eKind.Kas})
    coa.Criteria = CriteriaOperator.And(coa.Criteria, CreateCriteria())

    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.zWoojinBukuBesar)(_sesi, YearMonthCriteria)

    For i = 0 To coa.Count - 1
      Dim akunId As Integer = coa(i).Id
      'Dim saldo As Double = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, akunId, txtTgl1.DateTime.ToString("yyyy-MM-dd"))))
      Dim saldo As Double = 0 '= CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, akunId, txtTgl1.DateTime.ToString("yyyy-MM-dd"))))
      If txtKontak.EditValue Is Nothing Then
        saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, akunId, txtTgl1.DateTime.ToString("yyyy-MM-dd"))))
      Else
        saldo = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPNameContact, akunId, txtTgl1.DateTime.ToString("yyyy-MM-dd"), CType(txtKontak.EditValue, Persistent.Kontak).Id)))
      End If

      Dim item As New Persistent.zWoojinBukuBesar(_sesi)
      item.AkunDetail = coa(i)
      item.AkunMain = Nothing
      item.Id = akunId
      item.Keterangan = ""
      item.Debit = saldo
      item.Kredit = 0
      item.NoBukti = "Saldo Awal"
      item.Keterangan = "Saldo Awal"
      item.SaldoAwal = saldo
      item.SumberData = Nothing
      item.Tanggal = CType(txtTgl1.DateTime, Date)
      item.Urutan = 0
      item.Tipe = "1. Saldo KasBank"
      details.Add(item)
    Next

    'tambahkan memo
    Dim zMemo As New DevExpress.Xpo.XPCollection(Of Persistent.zWoojinMemo)(_sesi, New BetweenOperator("Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
    For i = 0 To zMemo.Count - 1
      Dim item As New Persistent.zWoojinBukuBesar(_sesi)
      item.AkunDetail = Nothing
      item.AkunMain = Nothing
      item.SumberData = Nothing
      item.Id = Nothing
      item.Keterangan = zMemo(i).Keterangan
      item.Catatan = zMemo(i).Nama
      item.Debit = zMemo(i).Nilai
      item.Kredit = 0
      item.NoBukti = "zMemo"
      item.Tanggal = zMemo(i).Tanggal
      item.Urutan = 0
      item.Tipe = "2. Memo"
      details.Add(item)
    Next

    If zMemo.Count = 0 Then
      Dim item As New Persistent.zWoojinBukuBesar(_sesi)
      item.AkunDetail = Nothing
      item.AkunMain = Nothing
      item.SumberData = Nothing
      item.Id = Nothing
      item.Keterangan = "-"
      item.Catatan = "-"
      item.Debit = 0
      item.Kredit = 0
      item.NoBukti = "zMemo"
      item.Tanggal = txtTgl1.DateTime
      item.Urutan = 0
      item.Tipe = "2. Memo"
      details.Add(item)
    End If

    _dataSource = details
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If Not Core.SSystem.UserInfo.GetUserDivision Is Nothing Then
      Dim right = From a In Core.SSystem.UserInfo.GetUserDivision Where a.Buka = True Select a.Divisi
      result.Add(New InOperator("Divisi", right.ToList))
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
    If Not txtKontak.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Kontak.Id", CType(txtKontak.EditValue, Persistent.Kontak).Id, BinaryOperatorType.Equal))
    End If
    result.Add(New InOperator("AkunDetail.Tipe.Id", New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Kas, NuSoft001.Persistent.CoaEnum.eKind.Bank}))
    Return GroupOperator.And(result)
  End Function
  Private Sub txtTgl1_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTgl1.EditValueChanging
    txtTgl2.Properties.MinValue = CDate(e.NewValue)
  End Sub
  Private Sub txtTgl2_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTgl2.EditValueChanging
    txtTgl1.Properties.MaxValue = CDate(e.NewValue)
  End Sub
End Class