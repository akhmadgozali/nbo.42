Friend Class UI_ModulesList
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    UseDbSystem = True
    NeedDelete = True
    NeedInsert = True
    NPO.SSystem.Modul.AutoSaveOnEndEdit = False
  End Sub
End Class