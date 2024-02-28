Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Friend Class RF_TransaksiJurnal
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub Filter()
    Dim setting As New NuSoftModSys.LogicLayer.Config(_sesi)
    Dim glSetting As New Logic.FinaSetting(_sesi)
    AddParameter("CompanyName", setting.NamaPerusahaan, GetType(String))
    AddParameter("FormatString", glSetting.NumericFormatString, GetType(String))
    _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.GlMainDetail)(_sesi, CreateCriteria)
  End Sub
  Overrides Sub InitializeData()
    txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.GlMain)(_sesi)
    txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.GlMain)(_sesi)
    txtTgl1.DateTime = New Date(Now.Year, Now.Month, 1)
    Dim xAkhirBulan As New Date(Now.Year, Now.Month, 1)
    txtTgl2.DateTime = xAkhirBulan.AddMonths(1).AddDays(-(xAkhirBulan.AddMonths(1).Day))

    'txtTgl2.Properties.MinValue = txtTgl1.DateTime
    'txtTgl1.Properties.MaxValue = txtTgl2.DateTime
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If Not txtNoBukti1.Text = Nothing Then
      If txtNoBukti2.Text = Nothing Then
        result.Add(New BinaryOperator("Main.Kode", txtNoBukti1.Text, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("Main.Kode", txtNoBukti1.Text, txtNoBukti2.Text))
      End If
    End If
    If Not txtTgl1.EditValue Is Nothing Then
      If txtTgl2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Main.Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("Main.Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
      End If
    End If

    If txtAkun.Text <> "" Then
      result.Add(New BinaryOperator("Main.Akun", String.Format(format, txtAkun.Text), BinaryOperatorType.Like))
    End If
    If txtKontak.Text <> "" Then
      result.Add(New BinaryOperator("Main.KontakNama", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
    End If
    If txtKeterangan.Text <> "" Then
      result.Add(New BinaryOperator("Main.Uraian", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
    End If

    Return GroupOperator.And(result)
  End Function
End Class