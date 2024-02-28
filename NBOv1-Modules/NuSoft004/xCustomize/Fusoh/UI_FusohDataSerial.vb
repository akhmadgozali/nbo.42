Public Class UI_FusohDataSerial
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    NeedDelete = False
    NeedInsert = False
    UseDbSystem = False
    Persistent.Gudang.AutoSaveOnEndEdit = False
  End Sub
End Class