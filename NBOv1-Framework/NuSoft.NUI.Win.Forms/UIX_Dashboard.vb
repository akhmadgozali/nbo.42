Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraTabbedMdi

Public Class UIX_Dashboard
	Private systemSession As UnitOfWork
	Private dbSession As UnitOfWork
	Private mdiManager As XtraTabbedMdiManager

	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
	End Sub

	Private Sub GetSession()
		If systemSession Is Nothing OrElse Not systemSession.IsConnected Then
			systemSession = Data.DbSystem.GetXPOSession
		End If

		dbSession = Data.DbClient.GetXPOSession(NamaDatabase)
	End Sub
	Private Sub CreateTabManager()
		' Create an XtraTabbedMdiManager that will manage MDI child windows.
		mdiManager = New XtraTabbedMdiManager(components)
		mdiManager.MdiParent = Me
		'mdiManager.PageAdded += MdiManager_PageAdded;
	End Sub

	Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
		GetSession()
		Dim dashboardId = Core.SSystem.UserInfo.GetDashboardId
		Dim dashboardModul = Core.SSystem.UserInfo.GetDashboardModul.Split(","c)
		Dim modulList = New XPQuery(Of NPO.SSystem.Modul)(systemSession).Where(Function(w) dashboardModul.Contains(w.Id.ToString)).ToList()
		Dim decrypt As New Utils.Cryptograph.Encryption.Hash(Utils.Cryptograph.Encryption.Hash.Provider.CRC32)
		Dim key As New Utils.Cryptograph.Encryption.Data(Core.SSystem.UserInfo.GetUserKey)

		' =========== create tab & load dashboard berdasarkan modul =============
		For Each modul In modulList
			Dim pathFile As String = String.Format("Modules\{0}.dll", modul.Kode)
			If My.Computer.FileSystem.FileExists(pathFile) Then
				Dim x = decrypt.Calculate(New Utils.Cryptograph.Encryption.Data(modul.Id.ToString), key).Hex
				If Convert.ToInt32(Connector.GetModuleId(pathFile)) = Convert.ToInt32(x, 16) Then
					Dim ctl As UserControl
					Dim smallIcon As Drawing.Image
					Try
						ctl = Connector.GetDashboard(pathFile, dashboardId)
					Catch ex As Exception
						ctl = Nothing
					End Try
					Try
						smallIcon = Connector.GetModuleSmallImages(pathFile)
					Catch ex As Exception
						smallIcon = Nothing
					End Try

				End If
			End If
		Next
	End Sub
End Class