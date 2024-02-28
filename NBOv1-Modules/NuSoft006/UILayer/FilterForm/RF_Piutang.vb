Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports NuSoft.Core.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Global_Services

Friend Class RF_Piutang
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
    txtRegional.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Regional)(_sesi)
    txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
    txtKontak.EditValue = Nothing
    txtMataUang.EditValue = Nothing

    txtJabatan.EditValue = "Manager Accounting"
    txtTanggal.DateTime = Now
    If ReportId.ToString = "6302" Or ReportId.ToString = "6303" Then
      lytTanggal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
    Else
      lytTanggal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End If
  End Sub
  Overrides Sub Filter()
    If txtTanggal.DateTime = Nothing Then
      Throw New Utils.Exception("Masukkan tanggal", -1)
    End If

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
    If Not txtRegional.EditValue Is Nothing Then
      AddParameter("Regional", CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Nama, GetType(String))
    End If

    Select Case ReportId.ToString
      Case "6302"
        Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
          Try
            splashManager.ShowWaitForm()
            splashManager.SetWaitFormCaption("Silahkan Tunggu")
            splashManager.SetWaitFormDescription("Filter data piutang ...")

            _dataSource = InvoicePenjualan_Services.GetRincianPiutang(_sesi, txtTanggal.DateTime, txtRegional.EditValue, txtKontak.EditValue, txtMataUang.EditValue, chkSaldoNOL.Checked)
          Catch ex As Utils.Exception
            Throw New Utils.Exception(ex)
          Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
          Finally
            splashManager.CloseWaitForm()
          End Try
        End Using
      Case "6303"
        Dim xData As New XPCollection(Of Persistent.ViewInvoice)(_sesi, CreateCriteriaMain)
        Dim xPembayaran As New XPCollection(Of Persistent.PembayaranPiutangDetail)(_sesi, CreateCriteriaPembayaran)
        For pi = 0 To xPembayaran.Count - 1
          Dim item As New Persistent.ViewInvoice(_sesi)
          item.NoInvoice = xPembayaran(pi).NoInvoice
          item.Pembayaran = xPembayaran(pi)
          item.NilaiBayarCash = xPembayaran(pi).NilaiBayarCash
          item.Urutan = 0
          xData.Add(item)
        Next
        If chkSaldoNOL.Checked = False Then
          _dataSource = xData
        Else
          _dataSource = xData
        End If
      Case "6305"
        _dataSource = New XPCollection(Of Persistent.ViewInvoiceUmur)(_sesi, CreateCriteria)
      Case Else
        _dataSource = New XPCollection(Of Persistent.ViewInvoice)(_sesi, CreateCriteria)
    End Select
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If Not txtMataUang.EditValue Is Nothing Then
      result.Add(New BinaryOperator("NoInvoice.Uang.Id", CType(txtMataUang.EditValue, NuSoft001.Persistent.MataUang).Id, BinaryOperatorType.Equal))
    End If

    Return GroupOperator.And(result)
  End Function

  Private Function CreateCriteriaMain() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)

    result.Add(New BinaryOperator("NoInvoice.Tanggal", txtTanggal.DateTime, BinaryOperatorType.LessOrEqual))

    If Not txtRegional.EditValue Is Nothing Then
      result.Add(New BinaryOperator("NoInvoice.Regional.Id", CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, BinaryOperatorType.Equal))
    End If

    Return GroupOperator.And(result)
  End Function
  Private Function CreateCriteriaPembayaran() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BinaryOperator("Main.Tanggal", txtTanggal.DateTime, BinaryOperatorType.LessOrEqual))
    If Not txtRegional.EditValue Is Nothing Then
      result.Add(New BinaryOperator("NoInvoice.Regional.Id", CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Id, BinaryOperatorType.Equal))
    End If

    Return GroupOperator.And(result)
  End Function

  Private Sub txtMataUang_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMataUang.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtMataUang.EditValue = Nothing
    End If
  End Sub
End Class