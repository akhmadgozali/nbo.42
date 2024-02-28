Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls

Friend Class UI_NishiBarangDialog
  Private instance As Persistent.Nishi_Barang
  Private settingitem As Logic.ItemSetting

  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
  End Sub
  Overrides Sub LoadBeforeInitialize()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("masterItemDialog.xml")) = True Then
      lytMaster.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("masterItemDialog.xml"))
    End If
  End Sub
  Public Overrides Sub LoadAfterInitialize()
    BindingDataSource()
    settingitem = New Logic.ItemSetting(Session)
    If Tipe = InputType.Tambah Then
      Me.Text = "Item: Tambah"
      instance = New Persistent.Nishi_Barang(session)
      txtHargaBeli.EditValue = 0.0
      txtHargaJual1.EditValue = 0.0
      txtHargaJual2.EditValue = 0.0
      txtHargaJual3.EditValue = 0.0
      txtHargaJual4.EditValue = 0.0
      txtHargaJual5.EditValue = 0.0
      txtAktif.Checked = True
      txtNamaPart.Text = ""

      txtAkunPersediaan.EditValue = Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunPersediaan))
      txtAkunPendapatan.EditValue = Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunPendapatan))
      txtAkunHPP.EditValue = Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunHPP))
      txtAkunDiscPenjualan.EditValue = Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunDiscPenjualan))
      txtAkunDiscPembelian.EditValue = Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunDiscPembelian))
      txtAkunReturPenjualan.EditValue = Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunReturPenjualan))
      txtAkunReturPembelian.EditValue = Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunReturPembelian))
      txtPajakIn.EditValue = Session.GetObjectByKey(Of Persistent.Pajak)(Convert.ToInt32(settingitem.PajakIN))
      txtPajakOut.EditValue = Session.GetObjectByKey(Of Persistent.Pajak)(Convert.ToInt32(settingitem.PajakOut))
      txtTipe.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtTipe)
      txtJenis.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtJenis)
      txtMaterialProses.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtMaterialProses)
      txtUang.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtUang)
      txtSatuan.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtSatuan)
      txtSatuanDasar.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtSatuanDasar)
    Else
      instance = session.GetObjectByKey(Of Persistent.Nishi_Barang)(CType(IdToEdit, Int64))
      txtAktif.EditValue = instance.Aktif
      txtKode.EditValue = instance.Kode
      txtNama.EditValue = instance.Nama
      txtJenis.EditValue = instance.Jenis
      txtTipe.EditValue = instance.TipeBarang
      txtSatuan.EditValue = instance.Satuan
      txtSatuanDasar.EditValue = instance.SatuanD
      txtUang.EditValue = instance.Uang
      txtHargaBeli.EditValue = instance.LastPurchase
      txtHargaJual1.EditValue = instance.HargaJual1
      txtHargaJual2.EditValue = instance.HargaJual2
      txtHargaJual3.EditValue = instance.HargaJual3
      txtHargaJual4.EditValue = instance.HargaJual4
      txtHargaJual5.EditValue = instance.HargaJual5
      txtAkunPersediaan.EditValue = instance.CoaStock
      txtAkunPendapatan.EditValue = instance.CoaIncome
      txtAkunHPP.EditValue = instance.CoaCost
      txtAkunDiscPenjualan.EditValue = instance.CoaDiscIncome
      txtAkunDiscPembelian.EditValue = instance.CoaDiscOut
      txtAkunReturPenjualan.EditValue = instance.CoaReturnIn
      txtAkunReturPembelian.EditValue = instance.CoaReturnOut
      txtPajakIn.EditValue = instance.PajakIN
      txtPajakOut.EditValue = instance.PajakOUT

      txtKategori.EditValue = instance.Kategori
      txtSubKategori.EditValue = instance.SubKategori
      txtMerk.EditValue = instance.Merk
      txtNote.EditValue = instance.Note
      Me.Text = "Item: Edit - " & instance.Kode
    End If
  End Sub
  Public Overrides Sub SimpanData()
    instance.Kode = txtKode.Text
    instance.Aktif = txtAktif.Checked
    instance.Nama = txtNama.Text
    instance.Jenis = CType(txtJenis.EditValue, Persistent.JenisBarang)
    instance.TipeBarang = CType(txtTipe.EditValue, Persistent.TipeBarang)
    instance.Satuan = CType(txtSatuan.EditValue, Persistent.Satuan)
    instance.SatuanD = CType(txtSatuanDasar.EditValue, Persistent.Satuan)
    instance.Uang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang)
    instance.LastPurchase = CType(txtHargaBeli.EditValue, Double)
    instance.HargaJual1 = CType(txtHargaJual1.EditValue, Double)
    instance.HargaJual2 = CType(txtHargaJual2.EditValue, Double)
    instance.HargaJual3 = CType(txtHargaJual3.EditValue, Double)
    instance.HargaJual4 = CType(txtHargaJual4.EditValue, Double)
    instance.HargaJual5 = CType(txtHargaJual5.EditValue, Double)

    instance.CoaStock = CType(txtAkunPersediaan.EditValue, NuSoft001.Persistent.Coa)
    instance.CoaIncome = CType(txtAkunPendapatan.EditValue, NuSoft001.Persistent.Coa)
    instance.CoaCost = CType(txtAkunHPP.EditValue, NuSoft001.Persistent.Coa)
    instance.CoaDiscIncome = CType(txtAkunDiscPenjualan.EditValue, NuSoft001.Persistent.Coa)
    instance.CoaDiscOut = CType(txtAkunDiscPembelian.EditValue, NuSoft001.Persistent.Coa)
    instance.CoaReturnIn = CType(txtAkunReturPenjualan.EditValue, NuSoft001.Persistent.Coa)
    instance.CoaReturnOut = CType(txtAkunReturPembelian.EditValue, NuSoft001.Persistent.Coa)
    instance.PajakIN = CType(txtPajakIn.EditValue, Persistent.Pajak)
    instance.PajakOUT = CType(txtPajakOut.EditValue, Persistent.Pajak)

    instance.Kategori = CType(txtKategori.EditValue, Persistent.Kategori)
    instance.SubKategori = CType(txtSubKategori.EditValue, Persistent.SubKategori)
    instance.Merk = CType(txtMerk.EditValue, Persistent.Merk)
    instance.Note = txtNote.Text


    instance.Save()
    Session.CommitChanges()
  End Sub

  Public Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
    ex.ShowWinMessageBox()
    tabBarangDialog.SelectedTabPage = tabBarangDialogGeneral
    Select Case ex.ErrorNumber
      Case -1, -2 : txtKode.Focus()
      Case -3 : txtNama.Focus()
      Case Else
    End Select
  End Sub
  Private Sub BindingDataSource()
    Dim xCOA As DevExpress.Xpo.XPCollection(Of NuSoft001.Persistent.Coa)
    Dim settinginventory As New Logic.InventorySetting(Session)
    txtSatuan.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Satuan)(Session)
    txtSatuanDasar.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Satuan)(Session)
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(Session)
    'txtCustomer.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(Session, New BinaryOperator("TipeKontak.Id", 2, BinaryOperatorType.Equal))

    xCOA = NuSoft001.Logic.Coa.GetCoa(Session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Kas, NuSoft001.Persistent.CoaEnum.eKind.Bank, NuSoft001.Persistent.CoaEnum.eKind.Persediaan, NuSoft001.Persistent.CoaEnum.eKind.Piutang, NuSoft001.Persistent.CoaEnum.eKind.AktivaLancarLainnya, NuSoft001.Persistent.CoaEnum.eKind.AktivaTetap, NuSoft001.Persistent.CoaEnum.eKind.AkumulasiPenyusutan, NuSoft001.Persistent.CoaEnum.eKind.HutangJangkaPanjang, NuSoft001.Persistent.CoaEnum.eKind.HutangJangkaPendek, NuSoft001.Persistent.CoaEnum.eKind.HutangLancarLainnya, NuSoft001.Persistent.CoaEnum.eKind.Modal, NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.PendapatanLainLain, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan, NuSoft001.Persistent.CoaEnum.eKind.BiayaOperasional, NuSoft001.Persistent.CoaEnum.eKind.BiayaLainLain})

    If settinginventory.SettingCOAAll = True Then
      txtAkunPersediaan.Properties.DataSource = xCOA
      txtAkunPendapatan.Properties.DataSource = xCOA
      txtAkunHPP.Properties.DataSource = xCOA
      txtAkunDiscPenjualan.Properties.DataSource = xCOA
      txtAkunDiscPembelian.Properties.DataSource = xCOA
      txtAkunReturPenjualan.Properties.DataSource = xCOA
      txtAkunReturPembelian.Properties.DataSource = xCOA
    Else
      txtAkunPersediaan.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(Session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Persediaan})
      txtAkunPendapatan.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(Session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan})
      txtAkunHPP.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(Session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
      txtAkunDiscPenjualan.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(Session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
      txtAkunDiscPembelian.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(Session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
      txtAkunReturPenjualan.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(Session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
      txtAkunReturPembelian.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(Session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
    End If
    txtPajakIn.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Pajak)(Session)
    txtPajakOut.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Pajak)(Session)
    txtJenis.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.JenisBarang))
    txtTipe.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.TipeBarang))
		txtMaterialProses.Properties.DataSource = New XPQuery(Of Persistent.Fusoh_ProcessCutting)(session) 'Utils.Helper.EnumDescription.ToList(GetType(Persistent.Fusoh_MaterialProses))
		txtKategori.Properties.DataSource = New XPCollection(Of Persistent.Kategori)(Session)
    txtSubKategori.Properties.DataSource = New XPCollection(Of Persistent.SubKategori)(Session)
    txtMerk.Properties.DataSource = New XPCollection(Of Persistent.Merk)(Session)
  End Sub
  'Private Sub txtTipe_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtTipe.EditValueChanging
  '  If Not e.NewValue Is Nothing Then
  '    Dim value = CType(e.NewValue, Persistent.TipeBarang)
  '    If value = Persistent.TipeBarang.BahanJadi Or value = Persistent.TipeBarang.BahanBaku Then
  '      txtCustomer.Enabled = True
  '    Else
  '      txtCustomer.Enabled = False
  '      txtCustomer.EditValue = Nothing
  '    End If
  '  End If
  'End Sub
End Class