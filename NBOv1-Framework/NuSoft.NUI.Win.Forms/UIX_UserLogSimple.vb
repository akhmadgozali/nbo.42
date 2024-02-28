Friend Class UIX_UserLogSimple
  Private coreSession As New DevExpress.Xpo.UnitOfWork
  'Const toolTipFormat As String = "{0,-20} | {1,-50} | {2,-50}"

  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    allowAdd = False
    allowDelete = False
    allowEdit = False
    ActivateToolTip = False
    KeyField = "Id"
    UseDbSystem = True
    baseView = xGridView
    barMan.StatusBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(BarStaticItem1, True), New DevExpress.XtraBars.LinkPersistInfo(BarEditItem1)})
    xGridView.OptionsDetail.EnableMasterViewMode = True
  End Sub

  'Public Overrides Function GetToolTipTitle(view As DevExpress.XtraGrid.Views.Grid.GridView, info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
  '  'Return String.Format(toolTipFormat, "Kode", "Nilai Lama", "Nilai Baru")
  'End Function
  'Public Overrides Function GetToolTipContent(view As DevExpress.XtraGrid.Views.Grid.GridView, info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
  '  'Dim xpCol As New DevExpress.Xpo.XPCollection(Of NPO.DatabaseLogDetail)(session, DevExpress.Data.Filtering.CriteriaOperator.Parse("Main.Id=" & view.GetRowCellDisplayText(info.RowHandle, KeyField)))
  '  'Dim result As String = ""

  '  'For i = 0 To xpCol.Count - 1
  '  '  result &= String.Format(toolTipFormat, xpCol(i).NamaProperty, xpCol(i).ValueLama, xpCol(i).ValueBaru)
  '  '  If i <> xpCol.Count - 1 Then
  '  '    result &= vbCrLf
  '  '  End If
  '  'Next

  '  'Return result
  'End Function
  Public Overrides Sub FirstLoad()
    SetCoreSession()
    Dim dtDb As New DevExpress.Xpo.XPCollection(Of NPO.SSystem.Database)(coreSession, DevExpress.Data.Filtering.CriteriaOperator.Parse("Aktif=True"))
    Dim listDb As List(Of NPO.SSystem.Database) = dtDb.ToList
    listDb.Add(New NPO.SSystem.Database(coreSession) With {.NamaAlias = "SISTEM", .NamaDatabase = "<SYS>"})

    dbRepo.DataSource = listDb
  End Sub
  Private Sub SetCoreSession()
    If Not coreSession.IsConnected Then
      coreSession = Data.DbSystem.GetXPOSession
    End If
  End Sub

  Private Sub dbRepo_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles dbRepo.EditValueChanging
    xGrid.DataSource = Nothing
    session.Disconnect()
    CType(Me.XpServerCollectionSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    If e.NewValue.ToString = "<SYS>" Then
      session = coreSession
      XpServerCollectionSource1.Session = session
    Else
      session = Data.DbClient.GetXPOSession(e.NewValue.ToString)
      XpServerCollectionSource1.Session = session
    End If
    CType(Me.XpServerCollectionSource1, System.ComponentModel.ISupportInitialize).EndInit()
    XpServerCollectionSource1.Reload()
    xGrid.DataSource = XpServerCollectionSource1
  End Sub

  Private Sub XpServerCollectionSource1_ResolveSession(sender As Object, e As DevExpress.Xpo.ResolveSessionEventArgs) Handles XpServerCollectionSource1.ResolveSession
    e.Session = session
  End Sub
End Class