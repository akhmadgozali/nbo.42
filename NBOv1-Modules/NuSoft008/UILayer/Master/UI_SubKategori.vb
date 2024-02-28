Public Class UI_SubKategori
 Sub New()
  ' This call is required by the designer.
  InitializeComponent()
  ' Add any initialization after the InitializeComponent() call.
  NeedDelete = True
  NeedInsert = True
  UseDbSystem = False
  Persistent.SubKategori.AutoSaveOnEndEdit = False
 End Sub
End Class