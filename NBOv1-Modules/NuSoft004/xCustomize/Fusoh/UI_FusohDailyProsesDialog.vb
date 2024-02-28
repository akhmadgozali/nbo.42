Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports NuSoft.Utils

Public Class UI_FusohDailyProsesDialog
	Private instance As Persistent.Fusoh_DailyProcess
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		AutoCloseOnSave = False
	End Sub

	Private Sub DempyouChanging(sender As Object, e As ChangingEventArgs) Handles txtDempyou.EditValueChanging
		If e.NewValue Is Nothing Then
			txtNomorLot.Text = ""
			txtPartNumber.Text = ""
			txtFinishGoodSize.Text = ""
			txtProcess.Text = ""
			txtCustomer.Text = ""
			txtQtyDempyou.Text = ""
			txtCutting.Text = ""
		Else
			Dim val = CType(e.NewValue, Persistent.Fusoh_OrderProduksi)
			txtNomorLot.Text = val.NomorLot
			txtPartNumber.Text = val.SODetail.Barang.Kode
			txtFinishGoodSize.Text = String.Format("{0} {1} x {2} x {3}", val.SODetail.Barang.Nama, val.SODetail.Barang.OutDiameter.ToString("n0"), val.SODetail.Barang.Thickness.ToString("n1"), val.SODetail.Barang.Length.ToString("n1"))
			txtProcess.Text = val.MaterialFlow
			txtProcess.Tag = val.SODetail.Barang.MaterialProses
			txtCustomer.Text = val.Pelanggan.Nama
			txtQtyDempyou.Text = val.Qty.ToString("n0")
			txtCutting.Text = val.Cutting.ToString("n2")
		End If
		UpdateQtyFG(txtQtyOP2.Value, txtQtyOP3.Value, CType(txtProcess.Tag, Persistent.Fusoh_ProcessCutting)) 'txtProcess.Text)
	End Sub
	Private Sub QtyOP2Changing(sender As Object, e As ChangingEventArgs) Handles txtQtyOP2.EditValueChanging
		UpdateQtyFG(CDec(e.NewValue), txtQtyOP3.Value, CType(txtProcess.Tag, Persistent.Fusoh_ProcessCutting)) 'txtProcess.Text)
	End Sub
	Private Sub QtyOP3Changing(sender As Object, e As ChangingEventArgs) Handles txtQtyOP3.EditValueChanging
		UpdateQtyFG(txtQtyOP2.Value, CDec(e.NewValue), CType(txtProcess.Tag, Persistent.Fusoh_ProcessCutting)) 'txtProcess.Text)
	End Sub

	Private Sub UpdateQtyFG(OP2 As Decimal, OP3 As Decimal, MaterialFlow As Persistent.Fusoh_ProcessCutting)
		'Dim enum1 = Utils.Helper.EnumDescription.GetDescription(Persistent.Fusoh_MaterialProses.Cutting)
		'Dim enum2 = Utils.Helper.EnumDescription.GetDescription(Persistent.Fusoh_MaterialProses.CuttingProcessing)
		'Dim enum3 = Utils.Helper.EnumDescription.GetDescription(Persistent.Fusoh_MaterialProses.CuttingQTProcessing)

		'If MaterialFlow = enum1 Then
		'	txtQtyFG.Value = OP2
		'ElseIf MaterialFlow = enum2 Then
		'	txtQtyFG.Value = OP3
		'ElseIf MaterialFlow = enum3 Then
		'	txtQtyFG.Value = OP2
		'Else
		'	txtQtyFG.Value = 0
		'End If
		Select Case MaterialFlow.DefaultFG
			Case 2 : txtQtyFG.Value = OP2
			Case 3 : txtQtyFG.Value = OP3
			Case Else : txtQtyFG.Value = 0
		End Select
	End Sub

	Overrides Sub LoadBeforeInitialize()
		txtTanggal.DateTime = Now
		txtMesin.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_Mesin)(session)
	End Sub
	Overrides Sub InitializeData()
		If Tipe = InputType.Tambah Then
			Me.Text = "Daily Process : Tambah"
			instance = New Persistent.Fusoh_DailyProcess(session)
			txtDempyou.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_OrderProduksi)(session).Where(Function(w) w.StatusTransaksi = StatusTransaksiEnum.Posting OrElse w.StatusTransaksi = StatusTransaksiEnum.Pending OrElse w.StatusTransaksi = StatusTransaksiEnum.InProgress).ToList
			txtMesin.EditValue = Nothing
			txtShift.Value = 0
			txtJamKerja.Value = 0
			txtQtyOP1.Value = 0
			txtQtyOP2.Value = 0
			txtQtyOP3.Value = 0
			txtQtyFG.Value = 0
			txtStopline.Value = 0
			txtKeterangan.Text = ""
			txtDempyou.EditValue = Nothing
		Else
			instance = session.GetObjectByKey(Of Persistent.Fusoh_DailyProcess)(CType(IdToEdit, Int64))
			'Me.Text = "Daily Proses : Edit - " & instance.Main.Kode
			'txtDempyou.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_OrderProduksi)(session).Where(Function(w) w.StatusTransaksi = StatusTransaksiEnum.Posting OrElse w.StatusTransaksi = StatusTransaksiEnum.Pending OrElse w.StatusTransaksi = StatusTransaksiEnum.InProgress OrElse w Is instance.Main).ToList
			'txtTanggal.DateTime = instance.Tanggal
			txtMesin.EditValue = instance.Mesin
			txtShift.Value = instance.Shift
			txtJamKerja.Value = instance.JamKerja
			txtQtyOP1.Value = CDec(instance.QtyOP1)
			txtQtyOP2.Value = CDec(instance.QtyOP2)
			txtQtyOP3.Value = CDec(instance.QtyOP3)
			txtQtyFG.Value = CDec(instance.QtyFG)
			'txtStopline.Value = instance.JamOff
			'txtKeterangan.Text = instance.Catatan
			'txtDempyou.EditValue = instance.Main
		End If
	End Sub

	Overrides Sub SimpanData()
		'If txtDempyou.EditValue Is Nothing Then
		'	instance.Main = Nothing
		'Else
		'	instance.Main = CType(txtDempyou.EditValue, Persistent.Fusoh_OrderProduksi)
		'End If
		'instance.Tanggal = txtTanggal.DateTime
		If txtMesin.EditValue Is Nothing Then
			instance.Mesin = Nothing
		Else
			instance.Mesin = CType(txtMesin.EditValue, Persistent.Fusoh_Mesin)
		End If
		instance.Shift = CInt(txtShift.Value)
		instance.JamKerja = CInt(txtJamKerja.Value)
		'instance.QtyOP1 = txtQtyOP1.Value
		'instance.QtyOP2 = txtQtyOP2.Value
		'instance.QtyOP3 = txtQtyOP3.Value
		'instance.QtyFG = txtQtyFG.Value
		'instance.JamOff = CInt(txtStopline.Value)
		'instance.Catatan = txtKeterangan.Text

		instance.Save()
		session.CommitChanges()
	End Sub
	Public Overrides Sub ErrorSimpan(ex As Exception)
		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case -1 : txtDempyou.Focus()
			Case -2 : txtTanggal.Focus()
			Case Else
		End Select
	End Sub
End Class
