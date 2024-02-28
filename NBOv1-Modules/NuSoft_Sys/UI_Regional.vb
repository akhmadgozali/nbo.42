Friend Class UI_Regional
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    UseDbSystem = False
    NeedDelete = True
    NeedInsert = True
		NPO.Modules.ModSys.Regional.AutoSaveOnEndEdit = False
  End Sub
End Class