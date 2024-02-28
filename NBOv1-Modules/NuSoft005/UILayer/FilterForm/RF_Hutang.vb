Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports System.Windows.Forms
Imports NuSoft.Utils.CustomAttribute
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft005.Global_Services

Friend Class RF_Hutang
  Public Enum TipeDataHutang
    <EnumDescription("Kartu Hutang")> KartuHutang = 0
    <EnumDescription("Daftar Hutang")> DaftarHutang = 1
    <EnumDescription("Umur Hutang")> UmurHutang = 2
  End Enum
  Private glSetting As NuSoft001.Logic.FinaSetting
  Private _tipedata As TipeDataHutang

  Sub New(xTipe As TipeDataHutang)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _tipedata = xTipe
    txtTampilkanSaldoNol.Checked = False
    If _tipedata = TipeDataHutang.KartuHutang Then
      txtTanggal.Properties.ReadOnly = False
      txtTampilkanSaldoNolLay.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
    Else
      txtTanggal.Properties.ReadOnly = True
      txtTampilkanSaldoNolLay.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End If
  End Sub
  Overrides Sub InitializeData()
    Dim purchaseSetting As Logic.PurchaseSetting = New Logic.PurchaseSetting(_sesi)
    If purchaseSetting.FilterKontak = True Then
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(_sesi, New BinaryOperator("TipeKontak.Id", purchaseSetting.TipeKontak, BinaryOperatorType.Equal))
    Else
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(_sesi)
    End If
    txtMataUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(_sesi)
    glSetting = New NuSoft001.Logic.FinaSetting(_sesi)
    txtTanggal.DateTime = Now
    txtRegional.Properties.DataSource = New XPCollection(Of NuSoft.NPO.Modules.ModSys.Regional)(_sesi)
    txtRegional.EditValue = NuSoft.Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
    txtKontak.EditValue = Nothing
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
    AddParameter("Periode", Format(txtTanggal.DateTime, "dd-MMMM-yyyy").ToString, GetType(String))
    If Not txtRegional.EditValue Is Nothing Then
      AddParameter("Regional", CType(txtRegional.EditValue, NuSoft.NPO.Modules.ModSys.Regional).Nama, GetType(String))
    End If

    Select Case _tipedata
      Case TipeDataHutang.KartuHutang
        'Dim xData As New XPCollection(Of Persistent.ViewInvoice)(_sesi, CreateCriteriaInvoice)
        'Dim xPembayaran As New XPCollection(Of Persistent.PembayaranHutangDetail)(_sesi, CreateCriteriaPembayaran)
        'For pi = 0 To xPembayaran.Count - 1
        '  Dim item As New Persistent.ViewInvoice(_sesi)
        '  item.NoInvoice = xPembayaran(pi).NoInvoice
        '  item.Pembayaran = xPembayaran(pi)
        '  item.NilaiBayarCash = xPembayaran(pi).NilaiBayarCash
        '  item.Urutan = 0
        '  xData.Add(item)
        'Next
        '_dataSource = xData

        Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
          Try
            splashManager.ShowWaitForm()
            splashManager.SetWaitFormCaption("Silahkan Tunggu")
            splashManager.SetWaitFormDescription("Filter data hutang ...")

            _dataSource = PenerimaanInvoice_Services.GetRincianHutang(_sesi, txtTanggal.DateTime, txtRegional.EditValue, txtKontak.EditValue, txtMataUang.EditValue, txtTampilkanSaldoNol.Checked)
          Catch ex As Utils.Exception
            Throw New Utils.Exception(ex)
          Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
          Finally
            splashManager.CloseWaitForm()
          End Try
        End Using
      Case TipeDataHutang.UmurHutang
        _dataSource = New XPCollection(Of ViewInvoiceUmur)(_sesi, CreateCriteria)
      Case Else
        _dataSource = New XPCollection(Of ViewInvoice)(_sesi, CreateCriteria)
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
  Private Sub txtMataUang_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMataUang.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtMataUang.EditValue = Nothing
    End If
  End Sub
  Private Function CreateCriteriaInvoice() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

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
End Class