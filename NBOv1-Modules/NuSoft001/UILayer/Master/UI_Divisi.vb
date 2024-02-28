Friend Class UI_Divisi
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    NeedDelete = True
    NeedInsert = True
    UseDbSystem = False
    NuSoft.NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
    'Persistent.Bank.AutoSaveOnEndEdit = False
  End Sub
End Class