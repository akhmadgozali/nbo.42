Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Public Class UI_KontakDialog
  Private instance As Persistent.Kontak
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
  End Sub
  Overrides Sub LoadBeforeInitialize()
    txtJenisKelamin.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eJenisKelamin))
    txtLevelPenjualan.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eLevelPenjualan))

    txtKaryawanPembelian.Properties.DataSource = New XPCollection(Of Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
    txtKaryawanPenjualan.Properties.DataSource = New XPCollection(Of Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
    txtTerminPembelian.Properties.DataSource = New XPCollection(Of Persistent.Termin)(session)
    txtTerminPenjualan.Properties.DataSource = New XPCollection(Of Persistent.Termin)(session)
    txtBank.Properties.DataSource = New XPCollection(Of Persistent.Bank)(session)

    txtKota.Properties.DataSource = New XPCollection(Of NuSoft.NPO.FixedData.Kota)(session)
    txtProvinsi.Properties.DataSource = New XPCollection(Of NuSoft.NPO.FixedData.Propinsi)(session)

    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("masterKontakdialog.xml")) = True Then
      lytMasterKontak.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("masterkontakdialog.xml"))
    End If
  End Sub
  Public Overrides Sub LoadAfterInitialize()
    repoTipe.Items.Clear()
    repoTipe.Items.Add(Persistent.eTipeAlamat.Kantor)
    repoTipe.Items.Add(Persistent.eTipeAlamat.Gudang)
    txtKategori.Properties.DataSource = New DevExpress.Xpo.XPCollection(Of Persistent.TipeKontak)(session)


    txtJenisKelamin.EditValue = Persistent.eJenisKelamin.Pria
    txtLevelPenjualan.EditValue = Persistent.eLevelPenjualan.Level1

    If Tipe = InputType.Tambah Then
      Me.Text = "Kontak: Tambah"
      instance = New Persistent.Kontak(session)
      txtBatasHutang.EditValue = 0
      txtBatasPiutang.EditValue = 0
      txtAktif.Checked = True
      txtKategori.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtKategori)
    Else
      instance = session.GetObjectByKey(Of Persistent.Kontak)(CType(IdToEdit, Int64))
      txtKategori.EditValue = instance.TipeKontak
      txtAktif.Checked = instance.Aktif
      txtKode.EditValue = instance.Kode
      txtNama.EditValue = instance.Nama
      txtJenisKelamin.EditValue = instance.JenisKelamin
      txtTglLahir.DateTime = instance.TglLahir
      txtAlamat.EditValue = instance.Alamat
      txtKota.EditValue = instance.Kota
      txtProvinsi.EditValue = instance.Propinsi
      txtKodePos.EditValue = instance.KodePos
      txtEmail.EditValue = instance.Email
      txtTelepon.EditValue = instance.Telepon
      txtFax.EditValue = instance.Fax
      txtHp1.EditValue = instance.HP1
      txtHp2.EditValue = instance.HP2
      txtKeterangan.EditValue = instance.Keterangan

      txtBatasPembelian.EditValue = instance.BatasPembelian
      txtTerminPembelian.EditValue = instance.TerminPembelian
      txtKaryawanPembelian.EditValue = instance.KaryawanPembelian
      txtBatasHutang.EditValue = instance.BatasHutang

      txtBatasPenjualan.EditValue = instance.BatasPenjualan
      txtTerminPenjualan.EditValue = instance.TerminPenjualan
      txtKaryawanPenjualan.EditValue = instance.KaryawanPenjualan
      txtBatasPiutang.EditValue = instance.BatasPiutang
      txtLevelPenjualan.EditValue = instance.LevelPenjualan

      txtNPKP.EditValue = instance.NPKP
      txtNPWP.EditValue = instance.NPWP
      txtNPWPAlamat.EditValue = instance.NPWPAlamat

      txtBank.EditValue = instance.Bank
      txtNoBank.EditValue = instance.NoBank
      txtTglKontrak.EditValue = instance.TglKontrak

      txtCustom1.EditValue = instance.Custom1
      txtCustom2.EditValue = instance.Custom2
      txtCustom3.EditValue = instance.Custom3
      txtCustom4.EditValue = instance.Custom4
      txtCustom5.EditValue = instance.Custom5
      txtCustom6.EditValue = instance.Custom6
      txtCustom7.EditValue = instance.Custom7
      txtCustom8.EditValue = instance.Custom8
      txtCustom9.EditValue = instance.Custom9
      txtCustom10.EditValue = instance.Custom10

      Me.Text = "Kontak: Edit - " & instance.Kode
    End If
    xGridAlamat.DataSource = instance.KontakAlamat
    xGridCP.DataSource = instance.KontakPerson
  End Sub
  Public Overrides Sub SimpanData()
    Try
      If Not txtKategori.EditValue Is Nothing Then
        instance.TipeKontak = CType(txtKategori.EditValue, Persistent.TipeKontak)
      End If
      instance.Kode = txtKode.Text
      instance.Aktif = txtAktif.Checked
      instance.Nama = txtNama.Text
      instance.JenisKelamin = CType(txtJenisKelamin.EditValue, Persistent.eJenisKelamin)
      instance.TglLahir = txtTglLahir.DateTime
      instance.Alamat = txtAlamat.Text
      instance.Kota = CType(txtKota.EditValue, NuSoft.NPO.FixedData.Kota)
      instance.Propinsi = CType(txtProvinsi.EditValue, NuSoft.NPO.FixedData.Propinsi)
      instance.KodePos = txtKodePos.Text
      instance.Email = txtEmail.Text
      instance.Telepon = txtTelepon.Text
      instance.Fax = txtFax.Text
      instance.HP1 = txtHp1.Text
      instance.HP2 = txtHp2.Text
      instance.Keterangan = txtKeterangan.Text

      instance.BatasPembelian = CDbl(txtBatasPembelian.EditValue)
      instance.TerminPembelian = CType(txtTerminPembelian.EditValue, Persistent.Termin)
      instance.KaryawanPembelian = CType(txtKaryawanPembelian.EditValue, Persistent.Kontak)
      instance.BatasHutang = CDbl(txtBatasHutang.EditValue)
      instance.BatasPenjualan = CDbl(txtBatasPenjualan.EditValue)
      instance.TerminPenjualan = CType(txtTerminPenjualan.EditValue, Persistent.Termin)
      instance.KaryawanPenjualan = CType(txtKaryawanPenjualan.EditValue, Persistent.Kontak)
      instance.BatasPiutang = CDbl(txtBatasPiutang.EditValue)
      instance.LevelPenjualan = CType(txtLevelPenjualan.EditValue, Persistent.eLevelPenjualan)

      instance.Bank = CType(txtBank.EditValue, Persistent.Bank)
      instance.NoBank = txtNoBank.Text
      instance.TglKontrak = txtTglKontrak.DateTime
      instance.NPKP = txtNPKP.Text
      instance.NPWP = txtNPWP.Text
      instance.NPWPAlamat = txtNPWPAlamat.Text

      instance.Custom1 = txtCustom1.Text
      instance.Custom2 = txtCustom2.Text
      instance.Custom3 = txtCustom3.Text
      instance.Custom4 = txtCustom4.Text
      instance.Custom5 = txtCustom5.Text
      instance.Custom6 = txtCustom6.Text
      instance.Custom7 = txtCustom7.Text
      instance.Custom8 = txtCustom8.Text
      instance.Custom9 = txtCustom9.Text
      instance.Custom10 = txtCustom10.Text

      instance.Save()
      session.CommitChanges()

    Catch ex As Utils.Exception
      Throw New Utils.Exception(ex)
    Catch ex As Exception
      If ex.Message.Contains("Duplicate entry") Then
        Throw New Utils.Exception("Kode yang anda masukkan sudah terdaftar.", 0, "Silahkan ganti kode kontak dengan yang lain.", "Kontak")
      Else
        Throw New Exception(ex.Message, ex.InnerException)
      End If
    End Try
  End Sub
  Public Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1, -2
        tabKontakDialog.SelectedTabPage = tabKontakDialogProfile
        txtKode.Focus()
      Case -3
        tabKontakDialog.SelectedTabPage = tabKontakDialogProfile
        txtNama.Focus()
      Case -4
        tabKontakDialog.SelectedTabPage = tabKontakDialogProfile
        txtKategori.Focus()
      Case Else
    End Select
  End Sub

End Class