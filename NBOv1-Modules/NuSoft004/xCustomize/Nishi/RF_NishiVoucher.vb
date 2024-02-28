Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo

Friend Class RF_NishiVoucher
  Private _reportname As MainClass.reportName
  Sub New(xReportName As MainClass.reportName)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _reportname = xReportName
    Me.Text = "Filter Laporan - Voucher Transaksi"
  End Sub
  Overrides Sub InitializeData()
    Select Case _reportname
      Case MainClass.reportName.zNishiVoucherBarangMasukCoil
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.NishiStockMain)(_sesi, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.GR, BinaryOperatorType.Equal))
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.NishiStockMain)(_sesi, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.GR, BinaryOperatorType.Equal))
      Case MainClass.reportName.zNishiVoucherBarangMasukSteel
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.NishiStockMain)(_sesi, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.GR, BinaryOperatorType.Equal))
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.NishiStockMain)(_sesi, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.GR, BinaryOperatorType.Equal))
      Case MainClass.reportName.zNishiVoucherBarangKeluarCoil
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.NishiStockMain)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.SJ, BinaryOperatorType.Equal), New BinaryOperator("TipeBarangJO", Persistent.NishiTipeBarangJO.Coil, BinaryOperatorType.Equal)))
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.NishiStockMain)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.SJ, BinaryOperatorType.Equal), New BinaryOperator("TipeBarangJO", Persistent.NishiTipeBarangJO.Coil, BinaryOperatorType.Equal)))
      Case MainClass.reportName.zNishiVoucherBarangKeluarSteel
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.NishiStockMain)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.SJ, BinaryOperatorType.Equal), New BinaryOperator("TipeBarangJO", Persistent.NishiTipeBarangJO.Steel, BinaryOperatorType.Equal)))
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.NishiStockMain)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.SJ, BinaryOperatorType.Equal), New BinaryOperator("TipeBarangJO", Persistent.NishiTipeBarangJO.Steel, BinaryOperatorType.Equal)))
    End Select
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
      Case MainClass.reportName.zNishiVoucherBarangMasukCoil, MainClass.reportName.zNishiVoucherBarangMasukSteel, MainClass.reportName.zNishiVoucherBarangKeluarCoil, MainClass.reportName.zNishiVoucherBarangKeluarSteel
        _dataSource = New XPCollection(Of Persistent.NishiStockDetail)(_sesi, CreateCriteria)
      'Case MainClass.reportName.zNishiVoucherBarangMasukCoil, MainClass.reportName.zNishiVoucherBarangMasukSteel, MainClass.reportName.zNishiVoucherBarangKeluarCoil, MainClass.reportName.zNishiVoucherBarangKeluarSteel
      '  _dataSource = New XPCollection(Of Persistent.NishiStockMain)(_sesi, CreateCriteria2)
    End Select
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    'jenisnya
    Select Case _reportname
      Case MainClass.reportName.zNishiVoucherBarangMasukCoil
        result.Add(New BinaryOperator("Main.Sumber.Id", Persistent.SumberDataJenis.GR, BinaryOperatorType.Equal))
        result.Add(New BinaryOperator("Main.JobOrder.TipeBarangJO", Persistent.NishiTipeBarangJO.Coil, BinaryOperatorType.Equal))
      Case MainClass.reportName.zNishiVoucherBarangMasukSteel
        result.Add(New BinaryOperator("Main.Sumber.Id", Persistent.SumberDataJenis.GR, BinaryOperatorType.Equal))
        result.Add(New BinaryOperator("Main.JobOrder.TipeBarangJO", Persistent.NishiTipeBarangJO.Steel, BinaryOperatorType.Equal))
      Case MainClass.reportName.zNishiVoucherBarangKeluarCoil
        result.Add(New BinaryOperator("Main.Sumber.Id", Persistent.SumberDataJenis.SJ, BinaryOperatorType.Equal))
        result.Add(New BinaryOperator("Main.TipeBarangJO", Persistent.NishiTipeBarangJO.Coil, BinaryOperatorType.Equal))
      Case MainClass.reportName.zNishiVoucherBarangKeluarSteel
        result.Add(New BinaryOperator("Main.Sumber.Id", Persistent.SumberDataJenis.SJ, BinaryOperatorType.Equal))
        result.Add(New BinaryOperator("Main.TipeBarangJO", Persistent.NishiTipeBarangJO.Steel, BinaryOperatorType.Equal))
    End Select


    If Not txtNoBukti1.EditValue Is Nothing Then
      If txtNoBukti2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Main.Kode", String.Format(format, txtNoBukti1.EditValue), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("Main.Kode", txtNoBukti1.EditValue, txtNoBukti2.EditValue))
      End If
    End If
    If Not txtTgl1.EditValue Is Nothing Then
      If txtTgl2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Main.Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("Main.Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
      End If
    End If
    If txtKontak.Text <> "" Then
      result.Add(New BinaryOperator("Main.Vendor", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
    End If
    If txtKeterangan.Text <> "" Then
      result.Add(New BinaryOperator("Main.Catatan", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
    End If

    Return GroupOperator.And(result)
  End Function
  Private Function CreateCriteria2() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    'jenisnya
    Select Case _reportname
      Case MainClass.reportName.zNishiVoucherBarangMasukCoil
        result.Add(New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.GR, BinaryOperatorType.Equal))
        result.Add(New BinaryOperator("JobOrder.TipeBarangJO", Persistent.NishiTipeBarangJO.Coil, BinaryOperatorType.Equal))
      Case MainClass.reportName.zNishiVoucherBarangMasukSteel
        result.Add(New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.GR, BinaryOperatorType.Equal))
        result.Add(New BinaryOperator("JobOrder.TipeBarangJO", Persistent.NishiTipeBarangJO.Steel, BinaryOperatorType.Equal))
      Case MainClass.reportName.zNishiVoucherBarangKeluarCoil
        result.Add(New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.SJ, BinaryOperatorType.Equal))
        result.Add(New BinaryOperator("TipeBarangJO", Persistent.NishiTipeBarangJO.Coil, BinaryOperatorType.Equal))
      Case MainClass.reportName.zNishiVoucherBarangKeluarSteel
        result.Add(New BinaryOperator("Sumber.Id", Persistent.SumberDataJenis.SJ, BinaryOperatorType.Equal))
        result.Add(New BinaryOperator("TipeBarangJO", Persistent.NishiTipeBarangJO.Steel, BinaryOperatorType.Equal))
    End Select


    If Not txtNoBukti1.EditValue Is Nothing Then
      If txtNoBukti2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Kode", String.Format(format, txtNoBukti1.EditValue), BinaryOperatorType.Like))
      Else
        result.Add(New BetweenOperator("Kode", txtNoBukti1.EditValue, txtNoBukti2.EditValue))
      End If
    End If
    If Not txtTgl1.EditValue Is Nothing Then
      If txtTgl2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
      End If
    End If
    If txtKontak.Text <> "" Then
      result.Add(New BinaryOperator("Vendor", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
    End If
    If txtKeterangan.Text <> "" Then
      result.Add(New BinaryOperator("Catatan", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
    End If

    Return GroupOperator.And(result)
  End Function
  Private Sub txtTgl1_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTgl1.EditValueChanging
    txtTgl2.Properties.MinValue = CDate(e.NewValue)
  End Sub
  Private Sub txtTgl2_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTgl2.EditValueChanging
    txtTgl1.Properties.MaxValue = CDate(e.NewValue)
  End Sub

End Class
