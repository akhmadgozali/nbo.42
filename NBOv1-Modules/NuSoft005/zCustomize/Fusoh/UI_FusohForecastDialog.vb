Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraGrid.Views.Base
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft005.Service

Public Class UI_FusohForecastDialog
	Private obj As Fusoh_Forecast_Model
	Private editAssign As Boolean

	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		AutoCloseOnSave = True
	End Sub
	Overrides Sub LoadBeforeInitialize()
		txtCustomer.Properties.DataSource = New XPCollection(Of Kontak)(session, New BinaryOperator("TipeKontak.Nama", "Pelanggan", BinaryOperatorType.Equal))
	End Sub
	Overrides Sub InitializeData()
		If Tipe = InputType.Tambah Then
			obj = New Fusoh_Forecast_Model
			Me.Text = "Forecast: Tambah"
			txtTanggal.DateTime = Now
			txtCustomer.EditValue = Nothing
			txtKeterangan.Text = ""
			ResetData()
		Else
			editAssign = True
			Dim instance = session.GetObjectByKey(Of Fusoh_Forecast)(CInt(IdToEdit))
			obj = Fusoh_Forecast_Service.GetItem(instance)
			txtFinishGood.Properties.DataSource = New XPQuery(Of Fusoh_Barang)(session) _
				.Where(Function(w) w.Aktif AndAlso w.TipeBarang = TipeBarang.BahanJadi AndAlso w.Customer Is obj.Customer).ToList
			txtMaterial.Properties.DataSource = New XPQuery(Of Fusoh_Barang)(session) _
				.Where(Function(w) w.Aktif AndAlso w.TipeBarang = TipeBarang.BahanBaku AndAlso w.Customer Is obj.Customer).ToList

			txtTanggal.DateTime = obj.Tanggal
			txtCustomer.EditValue = obj.Customer
			txtKeterangan.Text = instance.Keterangan
			layGroup.Text = obj.Customer.Nama
			txtFinishGood.EditValue = obj.BahanJadi
			txtFGNama.Text = obj.BahanJadi.NamaPart
			txtFGSize.Text = String.Format("{0} x {1} x {2} ({3} kg)", obj.BahanJadi.OutDiameter.ToString("n0"), obj.BahanJadi.Thickness.ToString("n0"), obj.BahanJadi.Length.ToString("n0"), NuSoft004.FusohLogic.Item.GetWeight(obj.BahanJadi.OutDiameter, obj.BahanJadi.Length, obj.BahanJadi.Thickness).ToString("n2"))
			txtFGQty.Value = obj.StokAwalBahanJadi
			txtMaterial.EditValue = obj.BahanBaku
			txtMNama.Text = obj.BahanBaku.Nama
			txtMSize.Text = String.Format("{0} x {1} x {2} ({3} kg)", obj.BahanBaku.OutDiameter.ToString("n0"), obj.BahanBaku.Thickness.ToString("n0"), obj.BahanBaku.Length.ToString("n0"), NuSoft004.FusohLogic.Item.GetWeight(obj.BahanBaku.OutDiameter, obj.BahanBaku.Length, obj.BahanBaku.Thickness).ToString("n2"))
			txtMQty.Value = obj.StokAwalBahanBaku
			txtLotPerBatang.Value = obj.LotPerBatang
			txtStokAwal.Value = (obj.StokAwalBahanBaku * obj.LotPerBatang) + obj.StokAwalBahanJadi
			Me.Text = "Forecast : Edit"
			editAssign = False
		End If

		xGrid.DataSource = obj.Detail
	End Sub
	Overrides Sub SimpanData()
		Dim instance As Fusoh_Forecast
		Dim service As Fusoh_Forecast_Service
		If Tipe = InputType.Tambah Then
			instance = New Fusoh_Forecast(session)
			service = New Fusoh_Forecast_Service(session)
		Else
			instance = session.GetObjectByKey(Of Fusoh_Forecast)(CInt(IdToEdit))
			service = New Fusoh_Forecast_Service(session, session.GetObjectByKey(Of Fusoh_Forecast)(CInt(IdToEdit)))
		End If
		instance.Tanggal = obj.Tanggal
		instance.Customer = obj.Customer
		instance.BahanBaku = obj.BahanBaku
		instance.BahanJadi = obj.BahanJadi
		instance.StokAwalBahanBaku = obj.StokAwalBahanBaku
		instance.StokAwalBahanJadi = obj.StokAwalBahanJadi
		instance.LotPerBatang = obj.LotPerBatang
		instance.Keterangan = txtKeterangan.Text
		instance.DetailForSave = obj.Detail
		service.Save(instance)
	End Sub
	Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case -1 : txtCustomer.Focus()
			Case -2 : txtTanggal.Focus()
			Case -3 : txtFinishGood.Focus()
			Case -4 : txtMaterial.Focus()
			Case -5 : txtLotPerBatang.Focus()
			Case Else
		End Select
	End Sub

	Private Sub SetDataSource(IsFromTanggalAndBahan As Boolean)
		If editAssign Then Return

		xGrid.DataSource = Nothing

		If IsFromTanggalAndBahan Then
			Fusoh_Forecast_Service.SetDataByTanggalAndBahan(session, obj)
			txtLotPerBatang.Value = obj.LotPerBatang
		Else
			Fusoh_Forecast_Service.SetDetailData(obj)
		End If
		txtFGQty.Value = obj.StokAwalBahanJadi
		txtMQty.Value = obj.StokAwalBahanBaku
		txtStokAwal.Value = (obj.StokAwalBahanBaku * obj.LotPerBatang) + obj.StokAwalBahanJadi

		xGrid.DataSource = obj.Detail
	End Sub
	Private Sub ResetData()
		layGroup.Text = " "
		txtFinishGood.EditValue = Nothing
		txtFGNama.Text = ""
		txtFGSize.Text = ""
		txtFGQty.Value = 0
		txtMaterial.EditValue = Nothing
		txtMNama.Text = ""
		txtMSize.Text = ""
		txtMQty.Value = 0
		txtLotPerBatang.Value = 0
		txtStokAwal.Value = 0
	End Sub

	Private Sub txtCustomer_EditValueChanged(sender As Object, e As EventArgs) Handles txtCustomer.EditValueChanged
		If editAssign Then Return
		If obj Is Nothing Then Return

		If Not txtCustomer.EditValue Is Nothing Then
			ResetData()
			obj.Customer = CType(txtCustomer.EditValue, Kontak)
			txtFinishGood.Properties.DataSource = New XPQuery(Of Fusoh_Barang)(session) _
				.Where(Function(w) w.Aktif AndAlso w.TipeBarang = TipeBarang.BahanJadi AndAlso w.Customer Is obj.Customer).ToList
			txtMaterial.Properties.DataSource = New XPQuery(Of Fusoh_Barang)(session) _
				.Where(Function(w) w.Aktif AndAlso w.TipeBarang = TipeBarang.BahanBaku AndAlso w.Customer Is obj.Customer).ToList
			layGroup.Text = obj.Customer.Nama
		End If
	End Sub
	Private Sub txtFinishGood_EditValueChanged(sender As Object, e As EventArgs) Handles txtFinishGood.EditValueChanged
		If editAssign Then Return
		If obj Is Nothing Then Return

		If Not txtFinishGood.EditValue Is Nothing Then
			Dim item = CType(txtFinishGood.EditValue, Fusoh_Barang)
			txtFGNama.Text = item.NamaPart
			txtFGSize.Text = String.Format("{0} x {1} x {2} ({3} kg)", item.OutDiameter.ToString("n0"), item.Thickness.ToString("n0"), item.Length.ToString("n0"), NuSoft004.FusohLogic.Item.GetWeight(item.OutDiameter, item.Length, item.Thickness).ToString("n2"))
			obj.BahanJadi = item
			SetDataSource(True)
		End If
	End Sub
	Private Sub txtMaterial_EditValueChanged(sender As Object, e As EventArgs) Handles txtMaterial.EditValueChanged
		If editAssign Then Return
		If obj Is Nothing Then Return

		If Not txtMaterial.EditValue Is Nothing Then
			Dim item = CType(txtMaterial.EditValue, Fusoh_Barang)
			txtMNama.Text = item.Nama
			txtMSize.Text = String.Format("{0} x {1} x {2} ({3} kg)", item.OutDiameter.ToString("n0"), item.Thickness.ToString("n0"), item.Length.ToString("n0"), NuSoft004.FusohLogic.Item.GetWeight(item.OutDiameter, item.Length, item.Thickness).ToString("n2"))
			obj.BahanBaku = item
			SetDataSource(True)
		End If
	End Sub
	Private Sub txtTanggal_DateTimeChanged(sender As Object, e As EventArgs) Handles txtTanggal.DateTimeChanged
		If editAssign Then Return
		If obj Is Nothing Then Return

		obj.Tanggal = txtTanggal.DateTime
		SetDataSource(True)
	End Sub
	Private Sub txtLotPerBatang_EditValueChanged(sender As Object, e As EventArgs) Handles txtLotPerBatang.EditValueChanged
		If editAssign Then Return
		If obj Is Nothing Then Return

		obj.LotPerBatang = txtLotPerBatang.Value
		SetDataSource(False)
	End Sub
	Private Sub xGridView_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles xGridView.CellValueChanged
		If e.Column Is colIncomingBatang OrElse e.Column Is colDelivery Then
			SetDataSource(False)
		End If
	End Sub
End Class