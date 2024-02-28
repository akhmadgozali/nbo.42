Public Class UI_FusohMesin
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    NeedDelete = True
    NeedInsert = True
    UseDbSystem = False
    Persistent.Fusoh_Mesin.AutoSaveOnEndEdit = False
  End Sub

End Class