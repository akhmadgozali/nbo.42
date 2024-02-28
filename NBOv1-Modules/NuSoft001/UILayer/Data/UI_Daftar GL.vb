Imports DevExpress.Data.Filtering
Friend Class UI_DaftarGL
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    showFilter = True
    showChart = False
    UseDbSystem = False
    'xpCol.CriteriaString = String.Format("[Main.Tahun]={0} AND Month([Main.Bulan])={1}", Now.Year, Now.Month)
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
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
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("Daftar GL.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("Daftar GL.xml"))
    End If
  End Sub
  Public Overrides Function GetFilterForm() As Core.Win.Forms.InputFilter
    Return New Core.Win.Forms.YearMonthFilter("[Main.Tahun]", "Month([Main.Bulan])")
  End Function
  'Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
  '  xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("Daftar GL.xml"))
  'End Sub
  Private Sub btnSaveLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveLayout.ItemClick
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("Daftar GL.xml"))
  End Sub
  Private Sub cmdTampilkan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdTampilkan.ItemClick
    If Not xGridView.GetFocusedRowCellDisplayText(colNoBukti) Is Nothing Then
      Dim xGLMain As Persistent.GlMain = session.FindObject(Of Persistent.GlMain)(New BinaryOperator("Kode", xGridView.GetFocusedRowCellDisplayText(colNoBukti), BinaryOperatorType.Equal))
      Dim pJenisTransaksi As JenisTransaksiGL, pKodeMenu As String
      If Not xGLMain Is Nothing Then
        Select Case xGLMain.Sumber.Id
          Case Persistent.SumberDataJenis.KM : pJenisTransaksi = JenisTransaksiGL.KasMasuk : pKodeMenu = "0101.02.02"
          Case Persistent.SumberDataJenis.KK : pJenisTransaksi = JenisTransaksiGL.KasKeluar : pKodeMenu = "0101.02.03"
          Case Persistent.SumberDataJenis.BM : pJenisTransaksi = JenisTransaksiGL.BankMasuk : pKodeMenu = "0101.02.04"
          Case Persistent.SumberDataJenis.BK : pJenisTransaksi = JenisTransaksiGL.BankKeluar : pKodeMenu = "0101.02.05"
          Case Persistent.SumberDataJenis.JU : pJenisTransaksi = JenisTransaksiGL.JurnalUmum : pKodeMenu = "0101.03.01"
          Case Persistent.SumberDataJenis.JA : pJenisTransaksi = JenisTransaksiGL.JurnalAdjusment : pKodeMenu = "0101.03.02"
          Case Else
            MsgBox("Data " & xGLMain.Sumber.Keterangan & " tidak dapat ditampilkan.")
            Exit Sub
        End Select
        Dim j As New UI_TransaksiGL(pJenisTransaksi)
        j.CallInputDialog(pKodeMenu, xGLMain.Id, session)
      End If
    End If
  End Sub
End Class