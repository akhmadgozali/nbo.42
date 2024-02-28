Imports DevExpress.Data.Filtering
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent

Friend Class RF_DaftarHarian
  Private _jenis As JenisTransaksiGL

  'Sub New(jenisTransaksi As JenisTransaksiGL)
  '  ' This call is required by the designer.
  '  InitializeComponent()
  '  ' Add any initialization after the InitializeComponent() call.
  '  _jenis = jenisTransaksi
  '  Select Case jenisTransaksi
  '    Case JenisTransaksiGL.Kas
  '      Me.Text = "Filter Laporan - Daftar Kas"
  '      LabelControl5.Text = "Akun Kas"
  '    Case JenisTransaksiGL.Bank
  '      Me.Text = "Filter Laporan - Daftar Bank"
  '      LabelControl5.Text = "Akun Bank"
  '    Case Else
  '      Me.Text = "Filter Laporan - Daftar Jurnal Memorial"

  '      LabelControl3.Visible = False
  '      LabelControl5.Visible = False
  '      txtAkun1.Visible = False
  '      txtAkun2.Visible = False
  '      Me.Height = Me.Height + (txtAkun1.Location.Y - txtKeterangan.Location.Y)
  '      LabelControl6.Location = LabelControl5.Location
  '      txtKeterangan.Location = txtAkun1.Location
  '  End Select
  'End Sub
  'Overrides Sub InitializeData()
  '  txtTgl1.DateTime = Now
  '  txtTgl2.DateTime = Now
  'End Sub

  'Overrides Sub Filter()
  '  If txtTgl1.DateTime = Nothing OrElse txtTgl2.DateTime = Nothing Then
  '    Utils.Win.MessageBox.Show("Masukkan tanggal", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
  '    Return
  '  End If

  '  Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
  '  Dim m02Setting As New Persistent.m02GLSetting(_sesi)

  '  AddParameter("Tgl1", txtTgl1.DateTime, GetType(System.DateTime))
  '  AddParameter("Tgl2", txtTgl2.DateTime, GetType(System.DateTime))
  '  AddParameter("NamaPerusahaan", abcSetting.NamaPerusahaan, GetType(System.String))
  '  AddParameter("FormatAngka", m02Setting.FormatAngka, GetType(System.String))
  '  AddParameter("FormatNumeric", m02Setting.NumericFormatString, GetType(System.String))

  '  Dim details As New DevExpress.Xpo.XPCollection(Of persistent.Report.BukuBesar)(_sesi, CreateCriteria)
  '  If _jenis <> JenisTransaksiGL.JurnalMemorial Then
  '    Dim z = From x In details Select x.AkunMain.Id Distinct
  '    For i = 0 To z.Count
  '      If Not z(i) = Nothing Then
  '        Dim akun As Integer = z(i)
  '        Dim saldo As Double = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, z(i), txtTgl1.DateTime.ToString("yyyy-MM-dd"))))

  '        Dim ok = details.ToList.Where(Function(c) c.AkunMain.Id = akun)
  '        For Each x In ok
  '          x.SaldoAwal = saldo
  '        Next
  '      End If
  '    Next
  '  End If

  '  _dataSource = details
  'End Sub
  'Private Function CreateCriteria() As CriteriaOperator
  '  Dim result As New List(Of CriteriaOperator)
  '  Dim format As String = "%{0}%"

  '  Select Case _jenis
  '    Case JenisTransaksiGL.Kas
  '      result.Add(New InOperator("SumberData", New Persistent.SumberDataJenis() {Persistent.SumberDataJenis.KK, Persistent.SumberDataJenis.KM}))
  '      result.Add(New BinaryOperator("Urutan", 0, BinaryOperatorType.NotEqual))
  '    Case JenisTransaksiGL.Bank
  '      result.Add(New InOperator("SumberData", New Persistent.SumberDataJenis() {Persistent.SumberDataJenis.BK, Persistent.SumberDataJenis.BM}))
  '      result.Add(New BinaryOperator("Urutan", 0, BinaryOperatorType.NotEqual))
  '    Case Else
  '      result.Add(New BinaryOperator("SumberData", Persistent.SumberDataJenis.JU, BinaryOperatorType.Equal))
  '  End Select

  '  If Core.SSystem.UserInfo.GetUserLevel = 0 Then
  '    result.Add(New BinaryOperator("Ext", True, BinaryOperatorType.Equal))
  '  End If
  '  If Not txtNoBukti1.Text = Nothing Then
  '    If txtNoBukti2.Text = Nothing Then
  '      result.Add(New BinaryOperator("NoBukti", String.Format(format, txtNoBukti1.Text), BinaryOperatorType.Like))
  '    Else
  '      result.Add(New BetweenOperator("NoBukti", txtNoBukti1.Text, txtNoBukti2.Text))
  '    End If
  '  End If
  '  If Not txtTgl1.EditValue Is Nothing Then
  '    If txtTgl2.EditValue Is Nothing Then
  '      result.Add(New BinaryOperator("Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
  '    Else
  '      result.Add(New BetweenOperator("Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
  '    End If
  '  End If
  '  If _jenis <> JenisTransaksiGL.JurnalMemorial Then
  '    If Not txtAkun1.EditValue Is Nothing Then
  '      If txtAkun2.EditValue Is Nothing Then
  '        result.Add(New BinaryOperator("AkunMain", String.Format(format, txtAkun1.Text), BinaryOperatorType.Like))
  '      Else
  '        result.Add(New BetweenOperator("AkunMain", txtAkun1.Text, txtAkun2.Text))
  '      End If
  '    End If
  '  End If
  '  If txtKeterangan.Text <> "" Then
  '    result.Add(New BinaryOperator("Keterangan", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
  '  End If

  '  Return GroupOperator.And(result)
  'End Function
End Class