Friend Class zWoojin_Brankas
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    NeedDelete = True
    NeedInsert = True
    UseDbSystem = False
    Persistent.zWoojinBrankas.AutoSaveOnEndEdit = False
  End Sub
  Public Overrides Sub FirstLoad()
    'load setingan default kolom
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("woojinbrankas.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("woojinbrankas.xml"))
    End If
    'Me.session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
    Dim zSeting As New Logic.FinaSetting(NuSoft.Data.DbClient.GetXPOSession(NamaDatabase))
    colN1.Caption = zSeting.zWoojinBrankas1
    colN2.Caption = zSeting.zWoojinBrankas2
    colN3.Caption = zSeting.zWoojinBrankas3
    colN4.Caption = zSeting.zWoojinBrankas4
    colN5.Caption = zSeting.zWoojinBrankas5
    colN6.Caption = zSeting.zWoojinBrankas6
    colN7.Caption = zSeting.zWoojinBrankas7
    colN8.Caption = zSeting.zWoojinBrankas8
    colN9.Caption = zSeting.zWoojinBrankas9
    colN10.Caption = zSeting.zWoojinBrankas10
    colN11.Caption = zSeting.zWoojinBrankas11
    colN12.Caption = zSeting.zWoojinBrankas12
    colN13.Caption = zSeting.zWoojinBrankas13
    colN14.Caption = zSeting.zWoojinBrankas14
    colN15.Caption = zSeting.zWoojinBrankas15
    colN16.Caption = zSeting.zWoojinBrankas16
    colN17.Caption = zSeting.zWoojinBrankas17
    colN18.Caption = zSeting.zWoojinBrankas18
    colN19.Caption = zSeting.zWoojinBrankas19
    colN20.Caption = zSeting.zWoojinBrankas20
    colN21.Caption = zSeting.zWoojinBrankas21
    colN22.Caption = zSeting.zWoojinBrankas22
    colN23.Caption = zSeting.zWoojinBrankas23
    colN24.Caption = zSeting.zWoojinBrankas24
    colN25.Caption = zSeting.zWoojinBrankas25
  End Sub
  'Overrides Sub xGridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
  '  xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("woojinbrankas.xml"))
  'End Sub

  Private Sub btnSaveLayout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveLayout.ItemClick
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("woojinbrankas.xml"))
  End Sub
End Class