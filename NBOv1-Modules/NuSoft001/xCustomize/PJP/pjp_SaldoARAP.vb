Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Public Class pjp_SaldoARAP
  Private _tipe As Persistent.eTipeARAP
  Sub New(xTipe As Persistent.eTipeARAP)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _tipe = xTipe
    If xTipe = Persistent.eTipeARAP.Piutang Then
      If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SaldoPiutangGrid.xml")) = True Then
        xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SaldoPiutangGrid.xml"))
      End If
    Else
      If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SaldoHutangGrid.xml")) = True Then
        xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SaldoHutangGrid.xml"))
      End If
    End If
  End Sub
  Overrides Sub FirstLoad()
    session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
    Dim a As New Logic.FinaSetting(session)
    colJumlah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colJumlah.DisplayFormat.FormatString = a.NumericFormatString
    colBayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colBayar.DisplayFormat.FormatString = a.NumericFormatString
    coLSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    coLSaldo.DisplayFormat.FormatString = a.NumericFormatString
    colJumlahValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colJumlahValas.DisplayFormat.FormatString = a.NumericFormatString
    colBayarValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colBayarValas.DisplayFormat.FormatString = a.NumericFormatString
    colSaldoValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colSaldoValas.DisplayFormat.FormatString = a.NumericFormatString
    If _tipe = Persistent.eTipeARAP.Piutang Then
      Dim xdtSetup As New XPCollection(Of Persistent.SetupARAP)(session)
      Dim xData As New XPCollection(Of Persistent.Report.SaldoARAP)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("f_coa.Tipe.Level2", Persistent.CoaEnum.eLevel2.Aktiva, BinaryOperatorType.Equal), New NotOperator(New InOperator("f_coa", xdtSetup.ToList.Select(Function(m) m.COA)))))

      If xData.Count > 0 Then
        Dim b = From z In xData Group z By z.f_contact, z.f_coa.MataUang Into Group Select Kode = f_contact.Kode, Nama = f_contact.Nama, Uang = MataUang.Kode, Jumlah = Group.Sum(Function(x) x.jumlah), Bayar = Group.Sum(Function(x) x.bayar), Saldo = Group.Sum(Function(x) (x.jumlah - x.bayar)), JumlahValas = Group.Sum(Function(x) x.jumlahvalas), BayarValas = Group.Sum(Function(x) x.bayarvalas), SaldoValas = Group.Sum(Function(x) (x.jumlahvalas - x.bayarvalas)) Order By Kode
        xGrid.DataSource = b
        xGridView.ActiveFilterString = "Not [Saldo] In ('0')"

        Dim c = From z In xData Group z By z.f_contact Into Group Select Kode = f_contact.Kode, Nama = f_contact.Nama, Saldo = Group.Sum(Function(x) (x.jumlah - x.bayar)) Where Saldo > 0 Order By Saldo Descending

        Dim series2 As DevExpress.XtraCharts.Series = nChart.Series("Series1")
        series2.DataSource = c
        series2.ArgumentDataMember = "Kode"
        series2.ValueDataMembers.AddRange({"Saldo"})
        series2.TopNOptions.Enabled = True
        series2.TopNOptions.Mode = DevExpress.XtraCharts.TopNMode.Count
        series2.TopNOptions.Count = 10
        nChart.Titles(0).Text = "Top 10 Saldo Piutang (" & session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(a.MultiMataUangDefault)).Kode.ToString & ")"
        nChart.RefreshData()
      End If

      xGridView.ViewCaption = "Saldo Piutang"
      Me.Text = "Saldo Piutang"
    Else
      Dim xdtSetup As New XPCollection(Of Persistent.SetupARAP)(session)
      Dim xData As New XPCollection(Of Persistent.Report.SaldoARAP)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("f_coa.Tipe.Level2", Persistent.CoaEnum.eLevel2.Hutang, BinaryOperatorType.Equal), New NotOperator(New InOperator("f_coa", xdtSetup.ToList.Select(Function(m) m.COA)))))
      If xData.Count > 0 Then
        Dim b = From z In xData Group z By z.f_contact, z.f_coa.MataUang Into Group Select Kode = f_contact.Kode, Nama = f_contact.Nama, Uang = MataUang.Kode, Jumlah = Group.Sum(Function(x) x.jumlah), Bayar = Group.Sum(Function(x) x.bayar), Saldo = Group.Sum(Function(x) (x.jumlah - x.bayar)), JumlahValas = Group.Sum(Function(x) x.jumlahvalas), BayarValas = Group.Sum(Function(x) x.bayarvalas), SaldoValas = Group.Sum(Function(x) (x.jumlahvalas - x.bayarvalas)) Order By Kode
        xGrid.DataSource = b
        xGridView.ActiveFilterString = "Not [Saldo] In ('0')"
        Dim c = From z In xData Group z By z.f_contact Into Group Select Kode = f_contact.Kode, Nama = f_contact.Nama, Saldo = Group.Sum(Function(x) (x.jumlah - x.bayar)) Where Saldo > 0 Order By Saldo Descending

        Dim series2 As DevExpress.XtraCharts.Series = nChart.Series("Series1")
        series2.DataSource = c
        series2.ArgumentDataMember = "Kode"
        series2.ValueDataMembers.AddRange({"Saldo"})
        series2.TopNOptions.Enabled = True
        series2.TopNOptions.Mode = DevExpress.XtraCharts.TopNMode.Count
        series2.TopNOptions.Count = 10
        nChart.Titles(0).Text = "Top 10 Saldo Hutang (" & session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(a.MultiMataUangDefault)).Kode.ToString & ")"
        nChart.RefreshData()
      End If
      xGridView.ViewCaption = "Saldo Hutang"
      Me.Text = "Saldo Hutang"
    End If
  End Sub
  Private Function CreateCriteriaDetail(xKodeKontak As String, xMataUang As String) As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Select Case _tipe
      Case Persistent.eTipeARAP.Piutang, Persistent.eTipeARAP.PiutangCOA
        result.Add(New BinaryOperator("Akun.Tipe", Persistent.CoaEnum.eKind.Piutang, BinaryOperatorType.Equal))
      Case Persistent.eTipeARAP.Hutang, Persistent.eTipeARAP.HutangCOA
        result.Add(New BinaryOperator("Akun.Tipe.Level2", Persistent.CoaEnum.eLevel2.Hutang, BinaryOperatorType.Equal))
      Case Persistent.eTipeARAP.All
        result.Add(New InOperator("Akun.Tipe", {Persistent.CoaEnum.eKind.Piutang, Persistent.CoaEnum.eKind.HutangJangkaPanjang, Persistent.CoaEnum.eKind.HutangJangkaPendek, Persistent.CoaEnum.eKind.HutangLancarLainnya}))
    End Select
    result.Add(New BinaryOperator("Main.Kontak.Kode", xKodeKontak, BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("Akun.MataUang.Kode", xMataUang, BinaryOperatorType.Equal))
    Return GroupOperator.And(result)
  End Function
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    If _tipe = Persistent.eTipeARAP.Piutang Then
      xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("SaldoPiutangGrid.xml"))
    Else
      xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("SaldoHutangGrid.xml"))
    End If
  End Sub
  Private Sub btnDetail_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetail.ItemClick
    If Not xGridView.GetFocusedRowCellDisplayText(colKode) Is Nothing Then
      Dim xKode As String = xGridView.GetFocusedRowCellDisplayText(colKode)
      Dim xUang As String = xGridView.GetFocusedRowCellDisplayText(colUang)
      Dim xFilter As CriteriaOperator
      Dim xCaption As String
      Select Case _tipe
        Case Persistent.eTipeARAP.Piutang
          xCaption = "Detail Saldo Piutang : " & xKode & " [" & xUang & "]"
        Case Persistent.eTipeARAP.Hutang
          xCaption = "Detail Saldo Hutang : " & xKode & " [" & xUang & "]"
        Case Else
          xCaption = "Detail GL : " & xKode & " [" & xUang & "]"
      End Select
      xFilter = CreateCriteriaDetail(xKode, xUang)
      Dim a As New pjp_DaftarGLDetail(xFilter, xCaption)
      a.MenuId = Me.MenuId
      a.session = Me.session
      a.NamaDatabase = Me.NamaDatabase
      a.TampilkanData()
      a.ShowMDI()
    End If
  End Sub
  Private Sub btnSetup_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSetup.ItemClick
    Dim a As New UI_SaldoARAPSetup
    a.session = Me.session
    a.ShowDialog()
  End Sub
End Class