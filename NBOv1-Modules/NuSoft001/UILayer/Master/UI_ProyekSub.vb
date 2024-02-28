Public Class UI_ProyekSub
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    NeedDelete = True
    NeedInsert = True
    UseDbSystem = False
    Persistent.ProyekSub.AutoSaveOnEndEdit = False
  End Sub
End Class