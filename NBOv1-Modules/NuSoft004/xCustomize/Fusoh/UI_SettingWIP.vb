Imports DevExpress.Xpo

Public Class UI_SettingWIP
	Private item As FusohLogic.FusohWIPSetting
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		AutoCloseOnSave = True
	End Sub
	Overrides Sub InitializeUsedComponent()
		GetSession()
		txtBarangWIP.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_Barang)(session).Where(Function(w) w.TipeBarang = Persistent.TipeBarang.BahanWIP AndAlso w.Aktif).ToList()
	End Sub
	Overrides Sub InitializeData()
		item = New FusohLogic.FusohWIPSetting(session)
		txtTanggalMulai.DateTime = item.TanggalMulaiWIP
		txtBarangWIP.EditValue = item.BarangWIP
	End Sub
	Overrides Sub Btn1Click()
		item.BarangWIP = CInt(txtBarangWIP.EditValue)
		item.TanggalMulaiWIP = txtTanggalMulai.DateTime
		item.Save()
		session.CommitChanges()
		Utils.Win.MessageBox.Show("Data sudah tersimpan.", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
	End Sub
	Overrides Sub ErrorBtn1Click(ByVal ex As Utils.Exception)
		MyBase.ErrorBtn1Click(ex)
	End Sub
End Class