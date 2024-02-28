Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Imports NuSoft.Utils.CustomAttribute

Friend Class RF_MesitechTransaksi
  Private _jenis As Persistent.SumberDataJenis
  Private _reportname As MainClass.reportName
  Private _all As Boolean
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
  Sub New(jenisTransaksi As SumberData, xReportName As MainClass.reportName)
    Me.New(Persistent.SumberDataCollection.GetEnum(jenisTransaksi), xReportName)
  End Sub
  Sub New(jenisTransaksi As Persistent.SumberDataJenis, xReportName As MainClass.reportName, Optional ByVal TampilkanSemua As Boolean = False)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _jenis = jenisTransaksi
    _all = TampilkanSemua
    _reportname = xReportName
    Select Case _jenis
      Case Persistent.SumberDataJenis.KM
        Me.Text = "Filter Bukti Kas"
      Case Persistent.SumberDataJenis.BM
        Me.Text = "Filter Bukti Bank"
      Case Persistent.SumberDataJenis.JU
        Me.Text = "Filter Jurnal Memo"
      Case Persistent.SumberDataJenis.PA
        Me.Text = "Filter APP"
    End Select
  End Sub
  Overrides Sub InitializeData()
    If _all = True Then
      txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.GlMain)(_sesi)
      txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.GlMain)(_sesi)
    Else
      txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.GlMain)(_sesi, New BinaryOperator("Sumber", _jenis, BinaryOperatorType.Equal))
      txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.GlMain)(_sesi, New BinaryOperator("Sumber", _jenis, BinaryOperatorType.Equal))
    End If
    txtSort1.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(eSortBy))
    txtSort2.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(eSortBy))
    txtSort3.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(eSortBy))
    txtSort4.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(eSortBy))
    txtSort1.EditValue = eSortBy.Tgl
    txtSort2.EditValue = eSortBy.NoBukti
    txtProyek.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)
    txtDivisi.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(_sesi)
    txtCoa.Properties.DataSource = Logic.Coa.GetCoa(_sesi, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.AktivaLancarLainnya, Persistent.CoaEnum.eKind.AktivaTetap, Persistent.CoaEnum.eKind.AkumulasiPenyusutan, Persistent.CoaEnum.eKind.BiayaLainLain, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.HutangJangkaPanjang, Persistent.CoaEnum.eKind.HutangJangkaPendek, Persistent.CoaEnum.eKind.HutangLancarLainnya, Persistent.CoaEnum.eKind.Modal, Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.PendapatanLainLain, Persistent.CoaEnum.eKind.Persediaan, Persistent.CoaEnum.eKind.Piutang, Persistent.CoaEnum.eKind.Bank, Persistent.CoaEnum.eKind.Kas, Persistent.CoaEnum.eKind.LabaDitahan})
  End Sub
  Overrides Sub Filter()
    Dim setting As New NuSoftModSys.LogicLayer.Config(_sesi)
    Dim glSetting As New Logic.FinaSetting(_sesi)
    AddParameter("CompanyName", setting.NamaPerusahaan, GetType(String))
    AddParameter("FormatString", glSetting.NumericFormatString, GetType(String))
    AddParameter("Periode1", txtTgl1.DateTime, GetType(Date))
    AddParameter("Periode2", txtTgl2.DateTime, GetType(Date))
    If _reportname = MainClass.reportName.APPRekap Or _reportname = MainClass.reportName.APPRekapBayar Or _reportname = MainClass.reportName.APPRekapTerbit Then
      _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.xMesitechViewGL)(_sesi, CreateCriteria, CreateSortBy.ToArray)
    Else
      _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.xMesitechGlDetail)(_sesi, CreateCriteria, CreateSortBy.ToArray)
    End If
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If _all = False Then
      result.Add(New BinaryOperator("Main.Sumber", New Persistent.SumberDataCollection(_sesi).GetObject(_jenis), BinaryOperatorType.Equal))
    End If

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
      result.Add(New BinaryOperator("Main.Kontak.Nama", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
    End If
    If txtKeterangan.Text <> "" Then
      result.Add(New BinaryOperator("Main.Uraian", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
    End If

    If Len(txtCoa.EditValue) > 0 Then
      If _reportname = MainClass.reportName.APPRekap Or _reportname = MainClass.reportName.APPRekapBayar Or _reportname = MainClass.reportName.APPRekapTerbit Then
        result.Add(New BinaryOperator("AccountAplied.Kode", txtCoa.Text, BinaryOperatorType.Like))
      Else
        result.Add(New BinaryOperator("Akun.Kode", txtCoa.Text, BinaryOperatorType.Like))
      End If
    End If
    If Len(txtProyek.EditValue) > 0 Then
      result.Add(New BinaryOperator("Proyek.Kode", txtProyek.Text, BinaryOperatorType.Like))
    End If
    If Len(txtDivisi.EditValue) > 0 Then
      result.Add(New BinaryOperator("Divisi.Kode", txtDivisi.Text, BinaryOperatorType.Like))
    End If

    Return GroupOperator.And(result)
  End Function
  Private Function CreateSortBy() As List(Of SortProperty)
    Dim result As New List(Of SortProperty)

    If Not txtSort1.EditValue Is Nothing Then
      result.Add(New SortProperty(GetFieldName(CType(txtSort1.EditValue, eSortBy)), DB.SortingDirection.Ascending))
    End If
    If Not txtSort2.EditValue Is Nothing Then
      result.Add(New SortProperty(GetFieldName(CType(txtSort2.EditValue, eSortBy)), DB.SortingDirection.Ascending))
    End If
    If Not txtSort3.EditValue Is Nothing Then
      result.Add(New SortProperty(GetFieldName(CType(txtSort3.EditValue, eSortBy)), DB.SortingDirection.Ascending))
    End If
    If Not txtSort4.EditValue Is Nothing Then
      result.Add(New SortProperty(GetFieldName(CType(txtSort4.EditValue, eSortBy)), DB.SortingDirection.Ascending))
    End If

    Return result
  End Function
  Private Function GetFieldName(ByVal xJenis As eSortBy) As String
    Dim result As String
    If _reportname = MainClass.reportName.APPRekap Or _reportname = MainClass.reportName.APPRekapBayar Or _reportname = MainClass.reportName.APPRekapTerbit Then
      Select Case xJenis
        Case eSortBy.Tgl : result = "Main.Tanggal"
        Case eSortBy.NoBukti : result = "Main.Kode"
        Case eSortBy.KodeCOA : result = "KodeCOA"
        Case eSortBy.KodeKontak : result = "Main.Kontak.Kode"
        Case eSortBy.Divisi : result = "Divisi.Kode"
        Case eSortBy.Proyek : result = "Proyek.Kode"
        Case eSortBy.ProyekSub : result = "ProyekSub.Kode"
        Case eSortBy.Uraian : result = "Main.Uraian"
        Case Else : result = "Main.Tanggal"
      End Select
    Else
      Select Case xJenis
        Case eSortBy.Tgl : result = "Main.Tanggal"
        Case eSortBy.NoBukti : result = "Main.Kode"
        Case eSortBy.KodeCOA : result = "Coa.Kode"
        Case eSortBy.KodeKontak : result = "Main.Kontak.Kode"
        Case eSortBy.Divisi : result = "Divisi.Kode"
        Case eSortBy.Proyek : result = "Proyek.Kode"
        Case eSortBy.ProyekSub : result = "ProyekSub.Kode"
        Case eSortBy.Uraian : result = "Main.Uraian"
        Case Else : result = "Main.Tanggal"
      End Select
    End If

    Return result
  End Function
  Private Sub txtSort1_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtSort1.KeyDown, txtSort2.KeyDown, txtSort3.KeyDown, txtSort4.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      CType(sender, DevExpress.XtraEditors.LookUpEdit).EditValue = Nothing
    End If
  End Sub
End Class