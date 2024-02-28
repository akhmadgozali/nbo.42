Public Class UI_zShipment
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    NeedDelete = True
    NeedInsert = True
    UseDbSystem = False
    Persistent.zShipment.AutoSaveOnEndEdit = False
  End Sub
End Class