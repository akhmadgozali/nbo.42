Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls
Imports NuSoft.Core.SSystem
Imports NuSoft.Utils

Public Class UI_FusohDailyProsesWIPDialog
	Private instance As Persistent.Fusoh_DailyProcess
	Private dsCuttingWIP As List(Of Persistent.Fusoh_StokMain)

	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		AutoCloseOnSave = False
	End Sub

	Overrides Sub LoadBeforeInitialize()
		txtMesin.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_Mesin)(session)
		txtProcess.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_ProcessCutting)(session)
	End Sub
	Overrides Sub InitializeData()
		If Tipe = InputType.Tambah Then
			instance = New Persistent.Fusoh_DailyProcess(session)
			Me.Text = "Daily Proses : Tambah"
			SetCustomerWIPDataSource(Nothing)
			SetInfoCutting(Nothing)
			txtCustomer.EditValue = Nothing
			txtWIP.EditValue = Nothing
			txtTanggal.DateTime = Now
			txtProcess.EditValue = Nothing
			txtMesin.EditValue = Nothing
			txtShift.Value = 1
			txtQtyOP1.Value = 0
			txtQtyOP2.Value = 0
			txtQtyOP3.Value = 0
			txtQtyOP4.Value = 0
			txtQtyOP5.Value = 0
			txtQtyFG.Value = 0
			txtJamKerja.Value = 0
			txtCutting.Value = 0
			txtFG.Value = 0
			txtNG.Value = 0
			txtStopline.Value = 0
			txtKeterangan.Text = ""
		Else
			instance = session.GetObjectByKey(Of Persistent.Fusoh_DailyProcess)(CType(IdToEdit, Long))
			Me.Text = "Daily Proses : Edit - " & instance.CuttingWIP.Kode

			SetCustomerWIPDataSource(instance)
			SetInfoCutting(instance.CuttingWIP)
			txtCustomer.EditValue = instance.CuttingWIP.Pelanggan
			txtWIP.EditValue = instance.CuttingWIP
			txtTanggal.DateTime = instance.Tanggal
			txtProcess.EditValue = instance.ProcessCutting
			txtMesin.EditValue = instance.Mesin
			txtShift.Value = instance.Shift
			txtQtyOP1.Value = instance.QtyOP1
			txtQtyOP2.Value = instance.QtyOP2
			txtQtyOP3.Value = instance.QtyOP3
			txtQtyOP4.Value = instance.QtyOP4
			txtQtyOP5.Value = instance.QtyOP5
			txtQtyFG.Value = instance.QtyFinishGood
			txtJamKerja.Value = instance.JamKerja
			txtCutting.Value = instance.QtyCutting
			txtFG.Value = instance.QtyFG
			txtNG.Value = instance.QtyNG
			txtStopline.Value = instance.WaktuStopLine
			txtKeterangan.Text = instance.Keterangan
		End If
	End Sub
	Overrides Sub LoadAfterInitialize()
		If Tipe = InputType.Edit Then
			If Not instance.Produksi Is Nothing Then
        'DisableControl()
      End If
			If User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit = False Then
				DisableControl()
			End If
		End If
	End Sub
	Private Sub DisableControl()
		txtCustomer.Properties.ReadOnly = True
		txtWIP.Properties.ReadOnly = True
		txtTanggal.Properties.ReadOnly = True
		txtProcess.Properties.ReadOnly = True
		txtMesin.Properties.ReadOnly = True
		txtShift.Properties.ReadOnly = True
		txtQtyOP1.Properties.ReadOnly = True
		txtQtyOP2.Properties.ReadOnly = True
		txtQtyOP3.Properties.ReadOnly = True
		txtQtyOP4.Properties.ReadOnly = True
		txtQtyOP5.Properties.ReadOnly = True
		txtQtyFG.Properties.ReadOnly = True
		txtJamKerja.Properties.ReadOnly = True
		txtCutting.Properties.ReadOnly = True
		txtFG.Properties.ReadOnly = True
		txtNG.Properties.ReadOnly = True
		txtStopline.Properties.ReadOnly = True
		txtKeterangan.Properties.ReadOnly = True

		EnableVisibleSaveButton(False, True)
	End Sub

	Overrides Sub SimpanData()
		If Not txtWIP.EditValue Is Nothing Then instance.CuttingWIP = CType(txtWIP.EditValue, Persistent.Fusoh_StokMain)
		If Not txtMesin.EditValue Is Nothing Then instance.Mesin = CType(txtMesin.EditValue, Persistent.Fusoh_Mesin)
		If Not txtProcess.EditValue Is Nothing Then instance.ProcessCutting = CType(txtProcess.EditValue, Persistent.Fusoh_ProcessCutting)
		instance.Tanggal = txtTanggal.DateTime
		instance.Shift = CInt(txtShift.Value)
		instance.QtyOP1 = CInt(txtQtyOP1.Text)
		instance.QtyOP2 = CInt(txtQtyOP2.Text)
		instance.QtyOP3 = CInt(txtQtyOP3.Text)
		instance.QtyOP4 = CInt(txtQtyOP4.Text)
		instance.QtyOP5 = CInt(txtQtyOP5.Text)
		instance.QtyFinishGood = CInt(txtQtyFG.Value)
		instance.JamKerja = CInt(txtJamKerja.Value)
		instance.QtyCutting = CInt(txtCutting.Value)
		instance.QtyFG = CInt(txtFG.Value)
		instance.QtyNG = CInt(txtNG.Value)
		instance.WaktuStopLine = CInt(txtStopline.Value)
		instance.Keterangan = txtKeterangan.Text

		Services.TransaksiDailyProcess.SaveData(session, instance)
	End Sub
	Public Overrides Sub ErrorSimpan(ex As Exception)
		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case 1 : txtWIP.Focus()
			Case 2 : txtTanggal.Focus()
			Case 3 : txtMesin.Focus()
			Case 4 : txtProcess.Focus()
			Case 5 : txtQtyFG.Focus()
		End Select
	End Sub

	Private Sub SetCustomerWIPDataSource(editedData As Persistent.Fusoh_DailyProcess)
		dsCuttingWIP = Services.TransaksiDailyProcess.GetCuttingWIPSource(session, editedData)
		txtCustomer.Properties.DataSource = dsCuttingWIP.GroupBy(Function(g) g.Pelanggan).Select(Function(s) s.Key).ToList
	End Sub
	Private Sub SetInfoCutting(dt As Persistent.Fusoh_StokMain)
		If dt Is Nothing Then
			txtCuttingKodeDempyou.Text = ""
			txtCuttingPartNumber.Text = ""
			txtCuttingFGSize.Text = ""
			txtCuttingNomorLot.Text = ""
			txtCuttingQtyDempyou.Value = 0
			txtCuttingQty.Value = 0
      txtCuttingStok.Value = 0
      txtPDO.Text = ""
    Else
      txtCuttingKodeDempyou.Text = dt.OrderProduksi.Kode
      txtPDO.Text = dt.OrderProduksi.NomorPDO
      txtCuttingPartNumber.Text = dt.OrderProduksi.SODetail.Barang.Kode
			txtCuttingFGSize.Text = dt.OrderProduksi.SODetail.Barang.FGSize
			txtCuttingNomorLot.Text = dt.DempyouLot
			txtCuttingQtyDempyou.Value = CDec(dt.OrderProduksi.Qty)
			txtCuttingQty.Value = CDec(dt.TotalQtyIn)
			txtCuttingStok.Value = CDec(FusohLogic.Item.GetRemainStock(session, dt.OrderProduksi.SODetail.Barang))
		End If
	End Sub

	Private Sub txtCustomer_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtCustomer.EditValueChanging
		If (e.NewValue Is Nothing) Then
			txtWIP.EditValue = Nothing
			txtWIP.Properties.DataSource = Nothing
		Else
			txtWIP.Properties.DataSource = dsCuttingWIP.Where(Function(w) w.Pelanggan Is e.NewValue).ToList()
		End If
	End Sub
	Private Sub txtWIP_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtWIP.EditValueChanging
		If (e.NewValue Is Nothing) Then
			xGridHistory.DataSource = Nothing
			SetInfoCutting(Nothing)
		Else
			Dim dt = CType(e.NewValue, Persistent.Fusoh_StokMain)
			SetInfoCutting(dt)
			txtProcess.EditValue = dt.OrderProduksi.SODetail.Barang.MaterialProses

			If Tipe = InputType.Tambah Then
				xGridHistory.DataSource = New XPQuery(Of Persistent.Fusoh_DailyProcess)(session).Where(Function(w) w.CuttingWIP Is dt).ToList().OrderBy(Function(o) o.Tanggal).ToList()
			Else
				xGridHistory.DataSource = New XPQuery(Of Persistent.Fusoh_DailyProcess)(session).Where(Function(w) w.CuttingWIP Is dt AndAlso Not w Is instance).ToList().OrderBy(Function(o) o.Tanggal).ToList()
			End If
		End If
	End Sub
End Class
