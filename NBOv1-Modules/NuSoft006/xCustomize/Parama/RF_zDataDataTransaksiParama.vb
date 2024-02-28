﻿Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Friend Class RF_zDataDataTransaksiParama
  Private _jenis As Persistent.SumberDataJenis
  Sub New(jenisTransaksi As SumberData)
    Me.New(Persistent.SumberDataCollection.GetEnum(jenisTransaksi))
  End Sub
  Sub New(jenisTransaksi As Persistent.SumberDataJenis)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _jenis = jenisTransaksi

    Select Case _jenis
      Case Persistent.SumberDataJenis.SO
        Me.Text = "Filter Laporan - Order Penjualan"
      Case Persistent.SumberDataJenis.IV
        Me.Text = "Filter Laporan - Invoice Penjualan"
      Case Persistent.SumberDataJenis.CP
        Me.Text = "Filter Laporan - Penerimaan Pembayaran Penjualan"
    End Select
  End Sub
  Overrides Sub InitializeData()
    Select Case _jenis
      Case Persistent.SumberDataJenis.SO
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.zParamaOrderPenjualan)(_sesi)
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.zParamaOrderPenjualan)(_sesi)
      Case Persistent.SumberDataJenis.IV
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.zParamaInvoicePenjualan)(_sesi)
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.zParamaInvoicePenjualan)(_sesi)
      Case Persistent.SumberDataJenis.CP
        txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.zParamaPembayaranPiutang)(_sesi)
        txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.zParamaPembayaranPiutang)(_sesi)
    End Select
    txtPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eLembarFP))
    txtPajak.EditValue = Persistent.eLembarFP.Lembar1
  End Sub
  Overrides Sub Filter()
    Dim setting As New NuSoftModSys.LogicLayer.Config(_sesi)
    Dim glSetting As New NuSoft001.Logic.FinaSetting(_sesi)
    AddParameter("CompanyName", setting.NamaPerusahaan, GetType(String))
    AddParameter("FormatString", glSetting.NumericFormatString, GetType(String))
    AddParameter("LembarFP", CType(txtPajak.EditValue, Persistent.eLembarFP), GetType(Integer))
    Select Case _jenis
      Case Persistent.SumberDataJenis.SO
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.zParamaOrderPenjualanDetail)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.IV
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.zParamaInvoicePenjualanDetail)(_sesi, CreateCriteria)
      Case Persistent.SumberDataJenis.CP
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.zParamaPembayaranPiutangDetail)(_sesi, CreateCriteria)
    End Select
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BinaryOperator("Main.Sumber", New Persistent.SumberDataCollection(_sesi).GetObject(_jenis), BinaryOperatorType.Equal))
    If Not txtNoBukti1.EditValue = Nothing Then
      If txtNoBukti2.EditValue = Nothing Then
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
      result.Add(New BinaryOperator("Main.Pelanggan.Nama", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
    End If
    If txtKeterangan.Text <> "" Then
      result.Add(New BinaryOperator("Main.Catatan", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
    End If

    Return GroupOperator.And(result)
  End Function
End Class