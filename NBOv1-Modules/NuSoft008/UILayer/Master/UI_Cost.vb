Friend Class UI_Cost
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    NeedDelete = True
    NeedInsert = True
    UseDbSystem = False
    Persistent.Pajak.AutoSaveOnEndEdit = False
  End Sub
  Private Sub xpCOA_ResolveSession(sender As Object, e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpCOA.ResolveSession
    e.Session = GetSession()
  End Sub
End Class