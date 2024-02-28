Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports NuSoft.Utils.CustomAttribute

Friend Class RF_Invoice
  Private _jenis As MainClass.reportName
  Private Enum eSortBy
    <EnumDescription("Tanggal")> Tgl
    <EnumDescription("No Bukti")> NoBukti
    <EnumDescription("Kode Coa")> KodeCOA
    <EnumDescription("Kode Kontak")> KodeKontak
    <EnumDescription("Divisi")> Divisi
    <EnumDescription("Proyek")> Proyek
    <EnumDescription("Sub Proyek")> ProyekSub
    <EnumDescription("Uraian")> Uraian
  End Enum
  Private Enum eLevel
    <EnumDescription("Level 1")> Level1
    <EnumDescription("Level 2")> Level2
    <EnumDescription("Level 3")> Level3
    <EnumDescription("Level 4")> Level4
  End Enum
  Sub New(jenis As MainClass.reportName)
    ' This call is required by the designer.
    InitializeComponent()
    _jenis = jenis

    Me.Text = "Laba Piutang Usaha"
 
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeData()
    txtPeriodeAwal.DateTime = New Date(Now.Year, Now.Month, 1)
    Dim xAkhirBulan As New Date(Now.Year, Now.Month, 1)

    txtPeriodeAkhir.DateTime = xAkhirBulan.AddMonths(1).AddDays(-(xAkhirBulan.AddMonths(1).Day))
    'txtPeriodeAkhir.Properties.MinValue = txtPeriodeAwal.DateTime
    'txtPeriodeAwal.Properties.MaxValue = txtPeriodeAkhir.DateTime
    txtProyek.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)
  End Sub
  Overrides Sub Filter()
    Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
    Dim m02Setting As New Logic.FinaSetting(_sesi)


    AddParameter("NamaPerusahaan", abcSetting.NamaPerusahaan, GetType(System.String))
    AddParameter("FormatAngka", m02Setting.FormatAngka, GetType(System.String))
    AddParameter("FormatNumeric", m02Setting.NumericFormatString, GetType(System.String))
    AddParameter("CompanyName", abcSetting.NamaPerusahaan, GetType(String))
    AddParameter("Alamat1", abcSetting.Alamat1, GetType(String))
    AddParameter("Alamat2", abcSetting.Alamat2, GetType(String))
    AddParameter("BidangUsaha", abcSetting.BidangUsaha, GetType(String))
    AddParameter("NoFax", abcSetting.NoFax, GetType(String))
    AddParameter("NoTelp", abcSetting.NoTelp, GetType(String))



    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.xMesitechViewInvoice)(_sesi, FilterData())
    For pi = 0 To details.Count - 1
      'Dim xMemo As New DevExpress.Xpo.XPCollection(Of Persistent.xMesitechGlDetail)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Main.Sumber", Persistent.SumberDataJenis.JM, BinaryOperatorType.Equal), New BinaryOperator("Invoice.Id", details(pi).Id.Id, BinaryOperatorType.Equal)))
      'If xMemo.Count > 0 Then
      '  details(pi).nodokmemo = xMemo(0).Main.Kode
      '  details(pi).tgldokmemo = xMemo(0).Main.Tanggal
      '  details(pi).kodeproject = xMemo(0).Proyek.Kode
      '  details(pi).namaproject = xMemo(0).Proyek.Nama
      'End If

      Dim xBankAR As New DevExpress.Xpo.XPCollection(Of Persistent.xMesitechGlDetail)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Main.Sumber", Persistent.SumberDataJenis.BA, BinaryOperatorType.Equal), New BinaryOperator("Invoice.Nomor", details(pi).noinvoice, BinaryOperatorType.Equal)))
      If xBankAR.Count > 0 Then
        details(pi).vbdeskripsi = xBankAR(0).Main.Uraian
        details(pi).vbnodok = xBankAR(0).Main.Kode
        details(pi).vbtgl = xBankAR(0).Main.Tanggal
        details(pi).vbmutasidebit = xBankAR(0).InvoiceDBMutasi
        details(pi).vbmutasikredit = xBankAR(0).InvoiceCRMutasi
        details(pi).vbmutasiditerima = xBankAR(0).InvoiceBersihDibayar
      End If
    Next

    _dataSource = details
  End Sub
  Private Function FilterData() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    result.Add(New BetweenOperator("tgldokmemo", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))
    If Len(txtProyek.EditValue) > 0 Then
      result.Add(New BinaryOperator("kodeproject", txtProyek.Text, BinaryOperatorType.Equal))
    End If
    If Len(txtNoMemo.EditValue) > 0 Then
      result.Add(New BinaryOperator("nodokmemo", txtNoMemo.Text, BinaryOperatorType.Like))
    End If
    Return GroupOperator.And(result)
  End Function

End Class