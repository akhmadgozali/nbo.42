Public Class UI_ProyekLokasi
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    NeedDelete = True
    NeedInsert = True
    UseDbSystem = False
    Persistent.ProyekLokasi.AutoSaveOnEndEdit = False
  End Sub
End Class