Public Class UI_Kategori
 Sub New()
  ' This call is required by the designer.
  InitializeComponent()
  ' Add any initialization after the InitializeComponent() call.
  NeedDelete = True
  NeedInsert = True
  UseDbSystem = False
  Persistent.Kategori.AutoSaveOnEndEdit = False
 End Sub
End Class