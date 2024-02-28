Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Friend Class RF_SaldoARAP
  Private _tipe As Persistent.eTipeARAP
  Sub New(xTipe As Persistent.eTipeARAP)
    ' This call is required by the designer.
    InitializeComponent()
    _tipe = xTipe
    ' Add any initialization after the InitializeComponent() call.
    Me.Text = IIf(_tipe = Persistent.eTipeARAP.Hutang, "Filter Saldo Hutang", "Filter Saldo Piutang").ToString
  End Sub
  Overrides Sub InitializeData()
    txtTgl.DateTime = Now
    Select Case _tipe
      Case Persistent.eTipeARAP.Piutang
        txtAkun.Properties.DataSource = New XPCollection(Of Persistent.Coa)(_sesi, New BinaryOperator("Tipe", Persistent.CoaEnum.eKind.Piutang, BinaryOperatorType.Equal))
      Case Persistent.eTipeARAP.Hutang
        txtAkun.Properties.DataSource = New XPCollection(Of Persistent.Coa)(_sesi, New BinaryOperator("Tipe.Level2", Persistent.CoaEnum.eLevel2.Hutang, BinaryOperatorType.Equal))
      Case Persistent.eTipeARAP.All
        txtAkun.Properties.DataSource = New XPCollection(Of Persistent.Coa)(_sesi, New InOperator("Tipe", {Persistent.CoaEnum.eKind.Piutang, Persistent.CoaEnum.eKind.HutangJangkaPanjang, Persistent.CoaEnum.eKind.HutangJangkaPendek, Persistent.CoaEnum.eKind.HutangLancarLainnya}))
    End Select
    txtKontak.Properties.DataSource = New XPCollection(Of Persistent.Kontak)(_sesi)
  End Sub
  Overrides Sub Filter()
    Dim setting As New NuSoftModSys.LogicLayer.Config(_sesi)
    Dim glSetting As New Logic.FinaSetting(_sesi)
    AddParameter("CompanyName", setting.NamaPerusahaan, GetType(String))
    AddParameter("FormatString", glSetting.NumericFormatString, GetType(String))
    AddParameter("MataUangFungsional", glSetting.MultiMataUangDefault, GetType(Integer))
    AddParameter("Periode", txtTgl.DateTime, GetType(Date))

    _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.GlMainDetail)(_sesi, CreateCriteria)
  End Sub
  Private Sub LaporanSummary()
    Dim result As New List(Of CriteriaOperator), psaldo As Double
    If txtAkun.Text <> "" Then
      result.Add(New BinaryOperator("Akun.Id", CType(txtAkun.EditValue, Persistent.Coa).Id, BinaryOperatorType.Equal))
    End If
    If txtKontak.Text <> "" Then
      result.Add(New BinaryOperator("Main.Kontak.Id", CType(txtKontak.EditValue, Persistent.Kontak).Id, BinaryOperatorType.Equal))
    End If
    Dim pData As New XPCollection(Of Persistent.Report.SaldoARAP)(_sesi, New GroupOperator(GroupOperatorType.And, result))
    For pi = 0 To pData.Count() - 1
      If pData(pi).f_coa.Tipe.Dc = Persistent.CoaEnum.eDc.Debit Then
        psaldo = CDbl(_sesi.ExecuteScalar(String.Format("SELECT coalesce(Sum(d_debit-d_credit),0) FROM m01dmaindetail LEFT JOIN m01cmaingl ON m01dmaindetail.p_id = m01cmaingl.p_id WHERE d_date <= '{0}' AND m01dmaindetail.f_coa={1} AND f_contact={2}", txtTgl.DateTime, pData(pi).f_coa.Id, pData(pi).f_contact.Id)))
      Else
        psaldo = CDbl(_sesi.ExecuteScalar(String.Format("SELECT coalesce(Sum(d_credit-d_debit),0) FROM m01dmaindetail LEFT JOIN m01cmaingl ON m01dmaindetail.p_id = m01cmaingl.p_id WHERE d_date <= '{0}' AND m01dmaindetail.f_coa={1} AND f_contact={2}", txtTgl.DateTime, pData(pi).f_coa.Id, pData(pi).f_contact.Id)))
      End If
      pData(pi).saldo = psaldo
    Next
    _dataSource = pData
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BinaryOperator("Main.Tanggal", txtTgl.DateTime, BinaryOperatorType.LessOrEqual))
    Select Case _tipe
      Case Persistent.eTipeARAP.Piutang, Persistent.eTipeARAP.PiutangCOA
        result.Add(New BinaryOperator("Akun.Tipe", Persistent.CoaEnum.eKind.Piutang, BinaryOperatorType.Equal))
      Case Persistent.eTipeARAP.Hutang, Persistent.eTipeARAP.HutangCOA
        result.Add(New BinaryOperator("Akun.Tipe.Level2", Persistent.CoaEnum.eLevel2.Hutang, BinaryOperatorType.Equal))
      Case Persistent.eTipeARAP.All
        result.Add(New InOperator("Akun.Tipe", {Persistent.CoaEnum.eKind.Piutang, Persistent.CoaEnum.eKind.HutangJangkaPanjang, Persistent.CoaEnum.eKind.HutangJangkaPendek, Persistent.CoaEnum.eKind.HutangLancarLainnya}))
    End Select

    If txtAkun.Text <> "" Then
      result.Add(New BinaryOperator("Akun.Id", CType(txtAkun.EditValue, Persistent.Coa).Id, BinaryOperatorType.Equal))
    End If
    If txtKontak.Text <> "" Then
      result.Add(New BinaryOperator("Main.Kontak.Id", CType(txtKontak.EditValue, Persistent.Kontak).Id, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function
End Class