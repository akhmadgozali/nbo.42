Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent

Namespace Fusoh_Logic
	Friend Class Umum
		Shared Sub xHistoryData(xForm As Object, xSession As DevExpress.Xpo.UnitOfWork, Tipe As UI_FusohCekData.TipeTransaksi, xNoBukti As String)
			Dim xHistory As New UI_FusohCekData(UI_FusohCekData.TipeForm.Dialog)
			xHistory.session = xSession
			xHistory.MenuId = xForm.MenuId
			xHistory.NamaDatabase = xForm.NamaDatabase
			xHistory.txtTipe.EditValue = Tipe
			xHistory.txtNoTransaksi.EditValue = xNoBukti
			xHistory.btnCari_Click(xHistory.btnCari, Nothing)
			xHistory.ShowDialog()
		End Sub
	End Class

	Friend Class InvoicePenjualan
		'Shared Sub UpdateStatusSuratJalan(session As UnitOfWork, invoice As Fusoh_InvoicePenjualan, commitChanges As Boolean)
		'	Dim listSuratJalan = invoice.Detail.GroupBy(Function(g) g.SuratJalanDetail.Main).Select(Function(s) s.Key).ToList

		'	For Each sj In listSuratJalan
		'		'=== cek jumlah surat jalan detail di invoice detail
		'		Dim jmlInvDetail = New XPQuery(Of Fusoh_InvoicePenjualanDetail)(session).Where(Function(w) Not w.SuratJalanDetail Is Nothing AndAlso w.SuratJalanDetail.Main Is sj).Count

		'		If jmlInvDetail <= 0 Then
		'			sj.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
		'		ElseIf jmlInvDetail >= sj.Detail.Sum(Function(s) s.Qty) Then 'ElseIf jmlInvDetail >= sj.Detail.Count Then
		'			sj.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
		'		Else
		'			sj.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
		'		End If
		'	Next

		'	If commitChanges Then session.CommitChanges()
		'End Sub
		Shared Sub UpdateStatusSuratJalan(session As UnitOfWork, SJ As Fusoh_SuratJalan, commitChanges As Boolean)
			Dim jmlInvDetail = New XPQuery(Of Fusoh_InvoicePenjualanDetail)(session).Where(Function(w) Not w.SuratJalanDetail Is Nothing AndAlso w.SuratJalanDetail.Main Is SJ).Sum(Function(x) x.Qty)
			Dim jmlSJDetail = SJ.TotalQty

			If jmlInvDetail <= 0 Then
				SJ.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
			ElseIf jmlInvDetail >= jmlSJDetail Then 'ElseIf jmlInvDetail >= sj.Detail.Count Then
				SJ.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
			Else
				SJ.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
			End If

			If commitChanges Then session.CommitChanges()
		End Sub

	End Class
End Namespace
