Imports DevExpress.Data.Filtering
Friend Class pjp_DaftarGL
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    showFilter = False
    showChart = False
    UseDbSystem = False
    'xpCol.CriteriaString = String.Format("[Main.Tahun]={0} AND Month([Main.Bulan])={1}", Now.Year, Now.Month)
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("Daftar GL.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("Daftar GL.xml"))
    End If
    Dim a As New Logic.FinaSetting(session)
    colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDebit.DisplayFormat.FormatString = a.NumericFormatString
    colKredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKredit.DisplayFormat.FormatString = a.NumericFormatString
    colDebitValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDebitValas.DisplayFormat.FormatString = a.NumericFormatString
    colKreditValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKreditValas.DisplayFormat.FormatString = a.NumericFormatString
    colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKurs.DisplayFormat.FormatString = a.NumericFormatString
    colDebit.SummaryItem.DisplayFormat = a.NumericFormatString
    colKredit.SummaryItem.DisplayFormat = a.NumericFormatString
  End Sub
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("Daftar GL.xml"))
  End Sub
  Private Sub cmdTampilkan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdTampilkan.ItemClick
    If Not xGridView.GetFocusedRowCellDisplayText(colNoBukti) Is Nothing Then
      Dim xGLMain As Persistent.GlMain = session.FindObject(Of Persistent.GlMain)(New BinaryOperator("Kode", xGridView.GetFocusedRowCellDisplayText(colNoBukti), BinaryOperatorType.Equal))
      Dim pJenisTransaksi As JenisTransaksiGL, pKodeMenu As String
      If Not xGLMain Is Nothing Then
        Select Case xGLMain.Sumber.Id
          Case Persistent.SumberDataJenis.KM : pJenisTransaksi = JenisTransaksiGL.KasMasuk : pKodeMenu = "0101.89"
          Case Persistent.SumberDataJenis.KK : pJenisTransaksi = JenisTransaksiGL.KasKeluar : pKodeMenu = "0101.88"
          Case Persistent.SumberDataJenis.JU : pJenisTransaksi = JenisTransaksiGL.JurnalUmum : pKodeMenu = "0101.87"
          Case Persistent.SumberDataJenis.JA : pJenisTransaksi = JenisTransaksiGL.JurnalAdjusment : pKodeMenu = "0101.86"
          Case Else
            MsgBox("Data " & xGLMain.Sumber.Keterangan & " tidak dapat ditampilkan.", , "Konfirmasi")
            Exit Sub
        End Select
        Dim j As New pjp_TransaksiGL(pJenisTransaksi)
        j.CallInputDialog(pKodeMenu, xGLMain.Id, session)
      End If
    End If
  End Sub
  Private Sub btnFilterExpert_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilterExpert.ItemClick
    xGridView.ShowFilterEditor(colNoBukti)
  End Sub
  Private Sub btnFilter2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilter2.ItemClick
    Dim result As New List(Of CriteriaOperator)
    If e.Item.Caption.ToString = "Hari Ini" Then
      result.Add(New BinaryOperator("Main.Tanggal", Now.Date, BinaryOperatorType.Equal))
    End If
    If e.Item.Caption.ToString = "Minggu Ini" Then
      Dim dayDiff As Integer = Date.Today.DayOfWeek - DayOfWeek.Monday
      Dim tglAwal As Date = Today.AddDays(-dayDiff)
      Dim tglAkhir As Date = tglAwal.AddDays(6)
      result.Add(New BetweenOperator("Main.Tanggal", tglAwal, tglAkhir))
    End If
    If e.Item.Caption.ToString = "Bulan Ini" Then
      Dim tglawal As Date = New Date(Now.Year, Now.Month, 1)
      Dim tglAkhir As Date = tglawal.AddMonths(1).AddDays(-(tglawal.AddMonths(1).Day))
      result.Add(New BetweenOperator("Main.Tanggal", tglawal, tglAkhir))
    End If
    xGridView.ActiveFilterCriteria = GroupOperator.And(result)
  End Sub
  Private Sub btnFilter1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilter1.ItemClick
    Dim xform As New pjp_DaftarGLFilter
    xform.MenuId = MenuId
    xform.NamaDatabase = NamaDatabase
    xform.session = session
    xform.Owner = Me
    xform.ShowDialog()
  End Sub
  Friend Sub InitFilter(xFilter As DevExpress.Data.Filtering.CriteriaOperator)
    xGridView.ActiveFilterCriteria = xFilter
  End Sub
End Class