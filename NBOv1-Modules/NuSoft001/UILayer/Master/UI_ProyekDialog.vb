Friend Class UI_ProyekDialog
  Private instance As Persistent.Proyek
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
 End Sub
 Public Overrides Sub LoadBeforeInitialize()
  If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("masterproyek.xml")) = True Then
   lytMasterProyek.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("masterproyek.xml"))
  End If
 End Sub
  Public Overrides Sub LoadAfterInitialize()
    txtCustomer.Properties.DataSource = New DevExpress.Xpo.XPCollection(Of Persistent.Kontak)(session)

    If Tipe = InputType.Tambah Then
      Me.Text = "Proyek : Tambah"
      instance = New Persistent.Proyek(session)
    Else
      instance = session.GetObjectByKey(Of Persistent.Proyek)(CType(IdToEdit, Int32))
      txtKode.EditValue = instance.Kode
      txtNama.EditValue = instance.Nama
      txtCustomer.EditValue = instance.Customer
      txtNoKontrak.EditValue = instance.NoKontrak
      txtTglMulai.EditValue = instance.TglAwal
      txtTglSelesai.EditValue = instance.TglAkhir
      txtCustom1.EditValue = instance.Custom1
      txtCustom2.EditValue = instance.Custom2
      txtCustom3.EditValue = instance.Custom3
      txtCustom4.EditValue = instance.Custom4
      txtCustom5.EditValue = instance.Custom5
      Me.Text = "Proyek : Edit - " & instance.Kode
    End If
  End Sub
  Public Overrides Sub SimpanData()
    instance.Kode = txtKode.Text
    instance.Nama = txtNama.Text
    instance.Customer = CType(txtCustomer.EditValue, Persistent.Kontak)
    instance.NoKontrak = txtNoKontrak.Text
    instance.TglAwal = txtTglMulai.DateTime
    instance.TglAkhir = txtTglSelesai.DateTime
    instance.Custom1 = txtCustom1.Text
    instance.Custom2 = txtCustom2.Text
    instance.Custom3 = txtCustom3.Text
    instance.Custom4 = txtCustom4.Text
    instance.Custom5 = txtCustom5.Text
    instance.Save()
    session.CommitChanges()
  End Sub

  Public Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1, -2 : txtKode.Focus()
      Case -3 : txtNama.Focus()
      Case Else
    End Select
  End Sub

 Private Sub txtTglMulai_EditValueChanged(sender As Object, e As EventArgs) Handles txtTglMulai.EditValueChanged
  txtTglSelesai.Properties.MinValue = CDate(txtTglMulai.EditValue)
 End Sub

 Private Sub txtTglSelesai_EditValueChanged(sender As Object, e As EventArgs) Handles txtTglSelesai.EditValueChanged
  txtTglMulai.Properties.MaxValue = CDate(txtTglSelesai.EditValue)
 End Sub
End Class