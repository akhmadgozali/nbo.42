Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo

Friend Class RF_SanYuVoucherProduksi
  Private _reportname As MainClass.reportName
  Sub New(xReportName As MainClass.reportName)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _reportname = xReportName
    Me.Text = "Filter Laporan - Rekap Produksi"
  End Sub
  Overrides Sub InitializeData()
    txtPelanggan.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(_sesi, New BinaryOperator("TipeKontak.Nama", "Pelanggan", BinaryOperatorType.Equal))
  End Sub
  Overrides Sub Filter()
    Dim setting As New NuSoftModSys.LogicLayer.Config(_sesi)
    Dim glSetting As New NuSoft001.Logic.FinaSetting(_sesi)
    AddParameter("CompanyName", setting.NamaPerusahaan, GetType(String))
    AddParameter("Alamat1", setting.Alamat1, GetType(String))
    AddParameter("Alamat2", setting.Alamat2, GetType(String))
    AddParameter("BidangUsaha", setting.BidangUsaha, GetType(String))
    AddParameter("NoFax", setting.NoFax, GetType(String))
    AddParameter("NoTelp", setting.NoTelp, GetType(String))
    AddParameter("FormatString", glSetting.NumericFormatString, GetType(String))

    Select Case _reportname
      Case MainClass.reportName.zSanyuVoucherProduksi : _dataSource = New XPCollection(Of Persistent.SanYu_ProduksiDetail)(_sesi, CreateCriteria)
      Case MainClass.reportName.zSanyuTallyCard : _dataSource = New XPCollection(Of Persistent.SanYu_ProduksiDetail)(_sesi, CreateCriteria)
    End Select
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If txtNoBukti.Text Is Nothing Then
      result.Add(New BinaryOperator("Main.Id", txtProses.EditValue, BinaryOperatorType.Like))
    Else
      result.Add(New BinaryOperator("Main.Kode", txtNoBukti.Text, BinaryOperatorType.Equal))
    End If

    Return GroupOperator.And(result)
  End Function
  Private Sub txtPelanggan_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPelanggan.EditValueChanging
    txtNoRencanaProduksi.Properties.DataSource = New XPCollection(Of Persistent.SanYu_RencanaProduksiDetail)(_sesi, New BinaryOperator("Main.Pelanggan", CType(e.NewValue, NuSoft001.Persistent.Kontak), BinaryOperatorType.Equal))
  End Sub
  Private Sub txtNoRencanaProduksi_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtNoRencanaProduksi.EditValueChanging
    txtProses.Properties.DataSource = New XPCollection(Of Persistent.SanYu_ProduksiMain)(_sesi, New BinaryOperator("RencanaProduksi", CType(e.NewValue, Persistent.SanYu_RencanaProduksiDetail), BinaryOperatorType.Equal))
  End Sub
End Class