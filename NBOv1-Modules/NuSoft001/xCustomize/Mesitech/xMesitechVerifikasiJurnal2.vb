Public Class xMesitechVerifikasiJurnal2
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    NeedDelete = False
    NeedInsert = False
    UseDbSystem = False
    Persistent.xMesitechGLMain.AutoSaveOnEndEdit = False
  End Sub
  Public Overrides Sub FirstLoad()
    colStatusRepo.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.xMesitechStatusTransaksiEnum))
  End Sub
End Class