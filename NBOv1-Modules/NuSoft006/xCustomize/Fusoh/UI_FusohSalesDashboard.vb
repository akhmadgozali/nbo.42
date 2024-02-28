Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views
Imports NuSoft.Core.Win.Forms

Public Class UI_FusohSalesDashboard
	Private Sub widgetView1_QueryControl(sender As Object, e As QueryControlEventArgs) Handles widgetView1.QueryControl
		If (Not String.IsNullOrEmpty(e.Document.ControlTypeName)) Then
			Dim control = TryCast(Activator.CreateInstance(Type.GetType(e.Document.ControlTypeName)), NuSoftUserControl)
			control.NamaDatabase = NamaDatabase
			e.Control = control
		End If
	End Sub

	Private Sub dbFusohDueDate_CustomButtonClick(sender As Object, e As ButtonEventArgs) Handles dbFusohDueDate.CustomButtonClick
		If e.Button.Properties.Caption = "Refresh" Then
			Dim ctl = CType(dbFusohDueDate.Control, DB_FusohDueDate)
			ctl.RefreshDataSource()
		End If
	End Sub
	Private Sub dbFusohCustomersSales_CustomButtonClick(sender As Object, e As ButtonEventArgs) Handles dbFusohCustomersSales.CustomButtonClick
		If e.Button.Properties.Caption = "Refresh" Then
			Dim ctl = CType(dbFusohCustomersSales.Control, DB_FusohCustomersSales)
			ctl.RefreshDataSource()
		End If
	End Sub
	Private Sub dbFusohPerMonthSales_CustomButtonClick(sender As Object, e As ButtonEventArgs) Handles dbFusohPerMonthSales.CustomButtonClick
		If e.Button.Properties.Caption = "Refresh" Then
			Dim ctl = CType(dbFusohPerMonthSales.Control, DB_FusohPerMonthSales)
			ctl.RefreshDataSource()
		End If
	End Sub
End Class