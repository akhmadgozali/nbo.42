Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent

Public Class UI_FusohBreakdownWIP
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
	End Sub
	Overrides Sub FirstLoad()
		session = Data.DbClient.GetXPOSession(NamaDatabase)

		txtFTanggalAwal.DateTime = New Date(Now.Year, 1, 1)
		txtFTanggalAkhir.DateTime = New Date(Now.Year, Now.Month, Now.Day)
	End Sub
	Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
		If txtFTanggalAwal.EditValue Is Nothing Then
			XtraMessageBox.Show("Masukkan tanggal awal filter data", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtFTanggalAwal.Focus()
			Return
		End If
		If txtFTanggalAkhir.EditValue Is Nothing Then
			XtraMessageBox.Show("Masukkan tanggal akhir filter data", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtFTanggalAkhir.Focus()
			Return
		End If

		Using splashManager As New DevExpress.XtraSplashScreen.SplashScreenManager(Nothing, GetType(Core.Win.Forms.WaitForm), True, True)
			splashManager.ShowWaitForm()
			splashManager.SetWaitFormCaption("Silahkan Tunggu")
			splashManager.SetWaitFormDescription("Loading data ...")

			Try
				Dim wipList = New XPQuery(Of Fusoh_StokDetail)(session).Where(Function(w) (w.Main.Sumber.Id = SumberDataJenis.CW Or w.Main.Sumber.Id = SumberDataJenis.AM) AndAlso w.Main.Tanggal.Date >= txtFTanggalAwal.DateTime AndAlso w.Main.Tanggal.Date <= txtFTanggalAkhir.DateTime).ToList
        'Main.OrderProduksi.Kode
        'a = wipList(9).Main.OrderProduksi.SODetail.Barang.Nama

        xGrid.DataSource = wipList
			Catch ex As Exception
				Throw New Exception(ex.Message, ex.InnerException)
			Finally
				If splashManager.IsSplashFormVisible Then splashManager.CloseWaitForm()
			End Try
		End Using
	End Sub

	Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
		Core.Win.Component.XtraGrid.ExportExcel(xGrid, session, "Breakdown WIP")
	End Sub
End Class