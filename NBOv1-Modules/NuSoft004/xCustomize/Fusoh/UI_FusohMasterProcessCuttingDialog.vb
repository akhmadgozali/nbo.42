Friend Class UI_FusohMasterProcessCuttingDialog
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		AutoCloseOnSave = False
	End Sub
	Public Overrides Sub InitializeData()
		If Tipe = InputType.Tambah Then
			Me.Text = "Process Cutting: Tambah"
			txtKode.Text = String.Empty
			txtNama.Text = String.Empty
			txtDefaultFG.SelectedIndex = 0
			txtKeterangan.Text = String.Empty
		Else
			Dim editedData = session.GetObjectByKey(Of Persistent.Fusoh_ProcessCutting)(CType(IdToEdit, Integer))
			txtKode.Text = editedData.Kode
			txtNama.Text = editedData.Nama
			txtDefaultFG.SelectedIndex = editedData.DefaultFG
			txtKeterangan.Text = editedData.Keterangan
			Me.Text = "Process Cutting: Edit - " & editedData.Kode
		End If
	End Sub
	Public Overrides Sub SimpanData()
		Dim item As Persistent.Fusoh_ProcessCutting
		Dim originalData As Persistent.Fusoh_ProcessCutting = Nothing

		If Tipe = InputType.Tambah Then
			item = New Persistent.Fusoh_ProcessCutting(session)
		Else
			item = session.GetObjectByKey(Of Persistent.Fusoh_ProcessCutting)(CType(IdToEdit, Integer))
			originalData = CType(item.Clone(), Persistent.Fusoh_ProcessCutting)
		End If
		item.Kode = txtKode.Text
		item.Nama = txtNama.Text
		item.DefaultFG = txtDefaultFG.SelectedIndex
		item.Keterangan = txtKeterangan.Text
		Services.MasterProcessCuttingService.SaveData(session, item, originalData)
	End Sub

	Public Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case -1 : txtKode.Focus()
			Case -2 : txtNama.Focus()
			Case Else
		End Select
	End Sub
End Class