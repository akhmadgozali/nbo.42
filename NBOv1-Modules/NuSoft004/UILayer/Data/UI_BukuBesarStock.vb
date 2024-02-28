Public Class UI_BukuBesarStock
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		NeedDelete = False
		NeedInsert = False
		UseDbSystem = False

		Persistent.StockMain.AutoSaveOnEndEdit = False
	End Sub

  Private Sub XpInstantFeedbackSource1_ResolveSession(sender As Object, e As DevExpress.Xpo.ResolveSessionEventArgs) Handles XpInstantFeedbackSource1.ResolveSession
    e.Session = GetSession()
  End Sub
End Class