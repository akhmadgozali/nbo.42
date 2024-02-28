Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Imports NuSoft.Core.SSystem

Friend Class zRexxaRF_Piutang
  Private glSetting As NuSoft001.Logic.FinaSetting
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeData()
    Dim salesSetting As Logic.SalesSetting = New Logic.SalesSetting(_sesi)
    If salesSetting.FilterKontak = True Then
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(_sesi, New BinaryOperator("TipeKontak.Id", salesSetting.TipeKontak, BinaryOperatorType.Equal))
    Else
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(_sesi)
    End If
    txtMataUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(_sesi)
    glSetting = New NuSoft001.Logic.FinaSetting(_sesi)
    Dim defaultRegional As NPO.Modules.ModSys.Regional
    defaultRegional = UserInfo.GetDefaultRegional(_sesi)
    If Not defaultRegional Is Nothing Then
      Dim reg As NuSoft001.Persistent.SettingRegional = _sesi.GetObjectByKey(Of NuSoft001.Persistent.SettingRegional)(defaultRegional.Id)
      If Not reg Is Nothing Then
        txtPenandatangan.EditValue = reg.Akunting
      End If
    End If
    txtJabatan.EditValue = "Manager Accounting"
    txtTanggal.DateTime = Now
    If ReportId.ToString = "6302" Or ReportId.ToString = "6303" Then
      lytTanggal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
    Else
      lytTanggal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End If
  End Sub
  Overrides Sub Filter()
    Dim setting As New NuSoftModSys.LogicLayer.Config(_sesi)
    AddParameter("CompanyName", setting.NamaPerusahaan, GetType(String))
    AddParameter("Alamat1", setting.Alamat1, GetType(String))
    AddParameter("Alamat2", setting.Alamat2, GetType(String))
    AddParameter("BidangUsaha", setting.BidangUsaha, GetType(String))
    AddParameter("NoFax", setting.NoFax, GetType(String))
    AddParameter("NoTelp", setting.NoTelp, GetType(String))
    AddParameter("FormatString", glSetting.NumericFormatString, GetType(String))
    AddParameter("Penandatangan", txtPenandatangan.EditValue, GetType(String))
    AddParameter("Jabatan", txtJabatan.EditValue, GetType(String))
    AddParameter("Periode", Format(txtTanggal.DateTime, "dd-MMMM-yyyy").ToString, GetType(String))
    Select Case ReportId.ToString
      Case "6302", "6303"
        Dim xData As New XPCollection(Of Persistent.zRexaViewInvoice)(_sesi, New BinaryOperator("NoInvoice.Tanggal", txtTanggal.DateTime, BinaryOperatorType.LessOrEqual))
        Dim xPembayaran As New XPCollection(Of Persistent.zRexaPembayaranPiutangDetail)(_sesi, New BinaryOperator("Main.Tanggal", txtTanggal.DateTime, BinaryOperatorType.LessOrEqual))
        For pi = 0 To xPembayaran.Count - 1
          Dim item As New Persistent.zRexaViewInvoice(_sesi)
          item.NoInvoice = xPembayaran(pi).NoInvoice
          item.Pembayaran = xPembayaran(pi)
          item.NilaiBayarCash = xPembayaran(pi).NilaiBayarCash
          item.Urutan = 0
          xData.Add(item)
        Next
        _dataSource = xData
      Case "6305"
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.zRexaViewInvoiceUmur)(_sesi, CreateCriteria)
      Case Else
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.zRexaViewInvoice)(_sesi, CreateCriteria)
    End Select
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If Not txtMataUang.EditValue Is Nothing Then
      result.Add(New BinaryOperator("NoInvoice.Uang.Id", CType(txtMataUang.EditValue, NuSoft001.Persistent.MataUang).Id, BinaryOperatorType.Equal))
    End If
    If Not txtKontak.EditValue Is Nothing Then
      result.Add(New BinaryOperator("NoInvoice.Pelanggan.Id", CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak).Id, BinaryOperatorType.Equal))
    End If

    Return GroupOperator.And(result)
  End Function
  Private Sub txtMataUang_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMataUang.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtMataUang.EditValue = Nothing
    End If
  End Sub
End Class