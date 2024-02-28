Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Friend Class RF_RekapPPN
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeData()
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
    Dim xx As New XPCollection(Of NuSoft005.Persistent.ViewInvoicePPN)
    'xx = NuSoft005.Logic.Purchase.GetInvoicePPN(_sesi, txtTgl1.DateTime)
    'xx(0).
    'Select Case _jenis
    '  Case Persistent.SumberDataJenis.SQ
    '    _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.PenawaranDetail)(_sesi, CreateCriteria)
    '  Case Persistent.SumberDataJenis.SO
    '    _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.OrderPenjualanDetail)(_sesi, CreateCriteria)
    '  Case Persistent.SumberDataJenis.DP
    '    _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.DPPenjualan)(_sesi, CreateCriteria)
    '  Case Persistent.SumberDataJenis.IV
    '    _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.InvoicePenjualanDetail)(_sesi, CreateCriteria)
    '  Case Persistent.SumberDataJenis.CP
    '    _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.InvoicePenjualanDetail)(_sesi, CreateCriteria)
    '  Case Persistent.SumberDataJenis.RN
    '    _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.PenerimaanReturPenjualan)(_sesi, CreateCriteria)
    '  Case Persistent.SumberDataJenis.SJ, Persistent.SumberDataJenis.QS
    '    _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.PengirimanBarangDetail)(_sesi, CreateCriteria)
    'End Select
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    'Dim format As String = "%{0}%"

    'result.Add(New BinaryOperator("Main.Sumber", New Persistent.SumberDataCollection(_sesi).GetObject(_jenis), BinaryOperatorType.Equal))
    'If Not txtNoBukti1.EditValue = Nothing Then
    '  If txtNoBukti2.EditValue = Nothing Then
    '    result.Add(New BinaryOperator("Main.Kode", String.Format(format, txtNoBukti1.EditValue), BinaryOperatorType.Like))
    '  Else
    '    result.Add(New BetweenOperator("Main.Kode", txtNoBukti1.EditValue, txtNoBukti2.EditValue))
    '  End If
    'End If
    'If Not txtTgl1.EditValue Is Nothing Then
    '  If txtTgl2.EditValue Is Nothing Then
    '    result.Add(New BinaryOperator("Main.Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
    '  Else
    '    result.Add(New BetweenOperator("Main.Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
    '  End If
    'End If
    'If txtKontak.Text <> "" Then
    '  result.Add(New BinaryOperator("Main.Pelanggan", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
    'End If
    'If txtKeterangan.Text <> "" Then
    '  result.Add(New BinaryOperator("Main.Uraian", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
    'End If

    Return GroupOperator.And(result)
  End Function
End Class