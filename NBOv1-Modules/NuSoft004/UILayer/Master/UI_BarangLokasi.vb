Imports DevExpress.Xpo

Public Class UI_BarangLokasi
	Private setting As NuSoft001.Logic.FinaSetting, pKode As String
	Sub New(xSession As DevExpress.Xpo.UnitOfWork)
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		session = xSession
	End Sub
	Private Sub btnCetak_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCetak.ItemClick
		NuSoft.Core.Win.Component.XtraGrid.PrintPreview(gridLokasi, session, "Data Lokasi")
	End Sub
	Overrides Sub FirstLoad()
		setting = New NuSoft001.Logic.FinaSetting(session)
	End Sub
	Private Sub XpCollection1_ResolveSession(sender As Object, e As ResolveSessionEventArgs) Handles XpCollection1.ResolveSession
		e.Session = session
	End Sub
End Class