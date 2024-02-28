Friend Class UI_Divisi
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		UseDbSystem = False
		NeedDelete = True
		NeedInsert = True
		NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
	End Sub
End Class