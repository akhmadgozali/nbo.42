Imports DevExpress.Data.Filtering
Friend Class pjp_FilterPerProses
  Dim setting As Logic.FinaSetting
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeData()
    txtPeriodeAwal.DateTime = New Date(Now.Year, Now.Month, 1)
    txtPeriodeAkhir.DateTime = txtPeriodeAwal.DateTime.AddMonths(1).AddDays(-(txtPeriodeAwal.DateTime.AddMonths(1).Day))

    txtProses.Properties.DataSource = New DevExpress.Xpo.XPCollection(Of Persistent.xProsesTKI)(_sesi)
    txtTki.Properties.DataSource = New DevExpress.Xpo.XPCollection(Of Persistent.xPJPTKI)(_sesi)
    txtNegara.Properties.DataSource = New DevExpress.Xpo.XPCollection(Of Persistent.xPJPTKINegara)(_sesi)
  End Sub
  Overrides Sub Filter()

    Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
    Dim m02Setting As New Logic.FinaSetting(_sesi)

    AddParameter("NamaPerusahaan", abcSetting.NamaPerusahaan, GetType(System.String))
    AddParameter("CompanyName", abcSetting.NamaPerusahaan, GetType(String))
    AddParameter("Alamat1", abcSetting.Alamat1, GetType(String))
    AddParameter("Alamat2", abcSetting.Alamat2, GetType(String))
    AddParameter("BidangUsaha", abcSetting.BidangUsaha, GetType(String))
    AddParameter("NoFax", abcSetting.NoFax, GetType(String))
    AddParameter("NoTelp", abcSetting.NoTelp, GetType(String))

    AddParameter("FormatAngka", m02Setting.FormatAngka, GetType(System.String))
    AddParameter("FormatNumeric", m02Setting.NumericFormatString, GetType(System.String))

    AddParameter("PeriodeAwal", txtPeriodeAwal.DateTime.ToString("dd-MMM-yyyy"), GetType(System.String))
    AddParameter("PeriodeAkhir", txtPeriodeAkhir.DateTime.ToString("dd-MMM-yyyy"), GetType(System.String))


    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.xPJPGlTKI)(_sesi, createCriteria)
    _dataSource = details
  End Sub
  Private Function createCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If Not txtPeriodeAwal.EditValue Is Nothing Then
      If Not txtPeriodeAkhir.EditValue Is Nothing Then
        result.Add(New BetweenOperator("Main.Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))
      Else
        result.Add(New BinaryOperator("Main.Tanggal", txtPeriodeAwal.DateTime, BinaryOperatorType.Equal))
      End If
    End If
    If Not txtNegara.EditValue Is Nothing Then
      result.Add(New BinaryOperator("TKI.Negara.id", CType(txtNegara.EditValue, Persistent.xPJPTKINegara).Id, BinaryOperatorType.Equal))
    End If
    If Not txtProses.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Main.ProsesTKI.Id", CType(txtProses.EditValue, Persistent.xProsesTKI).Id, BinaryOperatorType.Equal))
    End If
    If Not txtTki.EditValue Is Nothing Then
      result.Add(New BinaryOperator("TKI.Id", CType(txtTki.EditValue, Persistent.xPJPTKI).Id, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Sub txtProses_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtProses.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtProses.EditValue = Nothing
    End If
  End Sub
  Private Sub txtTki_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtTKI.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtTKI.EditValue = Nothing
    End If
  End Sub
  Private Sub txtNegara_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtNegara.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtNegara.EditValue = Nothing
    End If
  End Sub
End Class