Imports System.Windows.Forms

Namespace NuSoft.NUI.Win
	Public Class Connector
		Shared Property SUIMainClass As Object

		Shared Function GetModuleSmallImages(ByVal fileName As String) As Drawing.Image
			Return CType(Core.Win.Assembly.InvokeMemberClass(fileName, "MainClass", "GetSmallImage", Nothing), Drawing.Image)
		End Function
		Shared Function GetModuleLargeImages(ByVal fileName As String) As Drawing.Image
			Return CType(Core.Win.Assembly.InvokeMemberClass(fileName, "MainClass", "GetLargeImage", Nothing), Drawing.Image)
		End Function
		Shared Function GetForms(ByVal fileName As String, ByVal menuCode As String) As Core.Win.Forms.NuSoftForm
			Return CType(Core.Win.Assembly.InvokeMemberClass(fileName, "MainClass", "GetForm", New String() {menuCode}), Core.Win.Forms.NuSoftForm)
		End Function
		Shared Function GetReportFilter(ByVal fileName As String, ByVal reportCode As String) As Core.Win.Forms.ReportFilter
			Return CType(Core.Win.Assembly.InvokeMemberClass(fileName, "MainClass", "GetReportFilter", New String() {reportCode}), Core.Win.Forms.ReportFilter)
		End Function
		Shared Function GetModuleId(ByVal fileName As String) As NPO.Modules.ModuleId
			Return CType(Core.Win.Assembly.InvokeMemberClass(fileName, "MainClass", "GetModuleId", Nothing), NPO.Modules.ModuleId)
		End Function
		Shared Function GetDashboard(ByVal fileName As String, ByVal dashboardId As Integer) As UserControl
			Dim ctl = Core.Win.Assembly.InvokeMemberClass(fileName, "MainClass", "GetDashboard", New Object() {dashboardId})

			If ctl Is Nothing Then Return Nothing
			Return CType(ctl, UserControl)
		End Function

		Shared Sub OpenFormInMDI(form As Core.Win.Forms.NuSoftForm)
			Try
				Dim xtype As Type = SUIMainClass.GetType
				xtype.InvokeMember("OpenFormInMDI", Reflection.BindingFlags.Default Or Reflection.BindingFlags.InvokeMethod, Nothing, SUIMainClass, New Core.Win.Forms.NuSoftForm() {form})
			Catch ex As Exception
				Throw New Exception(ex.Message, ex.InnerException)
			End Try
		End Sub
	End Class
End Namespace