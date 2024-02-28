Public Class UI_MasterLokasi
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    NeedDelete = True
    NeedInsert = True
    UseDbSystem = False
    Persistent.xDiptaMasterLOkasi.AutoSaveOnEndEdit = False
  End Sub
  Public Overrides Sub FirstLoad()
    colPosisiRepo.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.xePosisi))
  End Sub
End Class