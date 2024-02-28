Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Public Class pjp_DaftarGLDetail
  Dim _filter As CriteriaOperator
  Dim _caption As String
  Sub New(xFilter As CriteriaOperator, xCaption As String)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _filter = xFilter
    Me.Text = "Daftar GL"
    _caption = xCaption
  End Sub
  Overrides Sub FirstLoad()
    LoadLayout()
  End Sub
  Sub LoadLayout()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("DataGLDetailGrid.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("DataGLDetailGrid.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("DataGLDetailVoucher.xml")) = True Then
      xGridVoucherView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("DataGLDetailVoucher.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("DataGLDetail.xml")) = True Then
      lytControl.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("DataGLDetail.xml"))
    End If
    Dim setting As New Logic.FinaSetting(session)
    colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDebit.DisplayFormat.FormatString = setting.NumericFormatString
    colDebit.SummaryItem.DisplayFormat = setting.NumericFormatString
    colDebitValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDebitValas.DisplayFormat.FormatString = setting.NumericFormatString
    colDebitValas.SummaryItem.DisplayFormat = setting.NumericFormatString
    colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKurs.DisplayFormat.FormatString = setting.NumericFormatString
    colKredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKredit.DisplayFormat.FormatString = setting.NumericFormatString
    colKredit.SummaryItem.DisplayFormat = setting.NumericFormatString
    colKreditValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKreditValas.DisplayFormat.FormatString = setting.NumericFormatString
    colKreditValas.SummaryItem.DisplayFormat = setting.NumericFormatString

    vColDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    vColDebit.DisplayFormat.FormatString = setting.NumericFormatString
    vColDebit.SummaryItem.DisplayFormat = setting.NumericFormatString
    vColDebitValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    vColDebitValas.DisplayFormat.FormatString = setting.NumericFormatString
    vColDebitValas.SummaryItem.DisplayFormat = setting.NumericFormatString
    vColKredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    vColKredit.DisplayFormat.FormatString = setting.NumericFormatString
    vColKredit.SummaryItem.DisplayFormat = setting.NumericFormatString
    vColKreditValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    vColKreditValas.DisplayFormat.FormatString = setting.NumericFormatString
    vColKreditValas.SummaryItem.DisplayFormat = setting.NumericFormatString
    Me.lyGroupData.Text = _caption
  End Sub
  Sub TampilkanData()
    Dim xData As New DevExpress.Xpo.XPCollection(Of Persistent.GlMainDetail)(session, _filter)
    xGrid.DataSource = xData
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("DataGLDetailGrid.xml"))
  End Sub
  Private Sub xGridVoucherView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridVoucherView.ColumnWidthChanged
    xGridVoucherView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("DataGLDetailVoucher.xml"))
  End Sub
  Private Sub btnTampilkan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTampilkan.ItemClick
    If Not xGridView.GetFocusedRowCellDisplayText(colKode) Is Nothing Then
      Dim xGLMain As Persistent.GlMain = session.FindObject(Of Persistent.GlMain)(New BinaryOperator("Kode", xGridView.GetFocusedRowCellDisplayText(colKode), BinaryOperatorType.Equal))
      Dim pJenisTransaksi As JenisTransaksiGL, pKodeMenu As String
      If Not xGLMain Is Nothing Then
        Select Case xGLMain.Sumber.Id
          Case Persistent.SumberDataJenis.KM : pJenisTransaksi = JenisTransaksiGL.KasMasuk : pKodeMenu = "0101.89"
          Case Persistent.SumberDataJenis.KK : pJenisTransaksi = JenisTransaksiGL.KasKeluar : pKodeMenu = "0101.88"
          Case Persistent.SumberDataJenis.JU : pJenisTransaksi = JenisTransaksiGL.JurnalUmum : pKodeMenu = "0101.87"
          Case Persistent.SumberDataJenis.JA : pJenisTransaksi = JenisTransaksiGL.JurnalAdjusment : pKodeMenu = "0101.86"
          Case Else
            MsgBox("Data " & xGLMain.Sumber.Keterangan & " tidak dapat ditampilkan")
            Exit Sub
        End Select
        Dim j As New pjp_TransaksiGL(pJenisTransaksi)
        j.CallInputDialog(pKodeMenu, xGLMain.Id, session)
      End If
    End If
  End Sub
  Private Sub xGrid_DoubleClick(sender As Object, e As EventArgs) Handles xGrid.DoubleClick
    If Not xGrid.DataSource Is Nothing Then
      If Not xGridView.FocusedRowHandle = Nothing Then
        Dim xNoTransaksi As String = xGridView.GetFocusedRowCellDisplayText(colKode)
        xGridVoucher.DataSource = New XPCollection(Of Persistent.GlMainDetail)(session, New BinaryOperator("Main.Kode", xNoTransaksi, BinaryOperatorType.Equal))
        xGridVoucherView.OptionsBehavior.ReadOnly = True
        xGridVoucherView.OptionsBehavior.Editable = False
        lyGroupVoucher.Text = "Jurnal Voucher : " & xNoTransaksi
      End If
    End If
  End Sub
  Private Sub btnCetak_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCetak.ItemClick
    xGridView.ShowPrintPreview()
  End Sub
  Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
    Core.Win.Component.XtraGrid.ExportExcel(xGrid, session, "Export Excell")
  End Sub
End Class