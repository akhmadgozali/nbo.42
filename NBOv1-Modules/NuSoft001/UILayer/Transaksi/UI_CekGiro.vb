Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Friend Class UI_CekGiro
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    xChart = nChart
    showChart = True
    showFilter = False
    useFeedbackSource = True
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
    Dim a As New Logic.FinaSetting(session)
    colNilai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilai.DisplayFormat.FormatString = a.NumericFormatString
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("Giro.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("Giro.xml"))
    End If
    isiData(0)
  End Sub
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("Giro.xml"))
  End Sub
  Private Sub isiData(xTipe As Int16)
    Dim xDataGiro As New XPCollection(Of Persistent.ViewGiro)(session, New BinaryOperator("Tipe", xTipe, BinaryOperatorType.Equal))
    xGrid.DataSource = xDataGiro
    If xDataGiro.Count > 0 Then xGridView.ActiveFilterString = "[Status]=false"


    Dim xDataGrafik As New XPCollection(Of Persistent.ViewGiro)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Tipe", xTipe, BinaryOperatorType.Equal), New BinaryOperator("Status", 0, BinaryOperatorType.Equal)))
    nChart.DataSource = xDataGrafik
    xGridView.ViewCaption = If(xTipe = 0, "Data Giro Masuk", "Data Giro Keluar")
  End Sub
  Private Sub btnCairkanGiro_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCairkanGiro.ItemClick
    If Not xGridView.GetFocusedRowCellDisplayText(colID) Is Nothing Then
      Dim xID As Int64 = CLng(xGridView.GetFocusedRowCellDisplayText(colID))
      Dim xData As Persistent.ViewGiro = session.FindObject(Of Persistent.ViewGiro)(New BinaryOperator("Id", xID, BinaryOperatorType.Equal))
      If Not xData Is Nothing Then
        If xData.Status = True Then
          Throw New Utils.Exception("Data tidak ditemukan.", 0, "", "Pencarian GL")
          Exit Sub
        Else
          Dim a As New UI_CekGiroDialog(xData.Tipe, xID)
          a.session = Me.session
          a.Tipe = Core.Win.Forms.InputBase.InputType.Tambah
          a.ShowDialog()
          ifSource.Refresh()
        End If
      End If
    End If
  End Sub
  Private Sub btnFilter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGM.ItemClick, btnGK.ItemClick
    If e.Item Is btnGM Then
      'xGridView.ActiveFilterString = "[Status]=false and [Tipe]='Masuk'"
      isiData(0)
    End If
    If e.Item Is btnGK Then
      'xGridView.ActiveFilterString = "[Status]=false and [Tipe]='Keluar'"
      isiData(1)
    End If
  End Sub
End Class