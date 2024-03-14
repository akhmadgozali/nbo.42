Imports DevExpress.Xpo

Friend Class UI_BarangDialog
  Private instance As Persistent.Barang
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
    settingitem = New Logic.ItemSetting(session)
    If Tipe = InputType.Tambah Then
      Me.Text = "Item: Tambah"
      instance = New Persistent.Barang(session)
      txtHargaBeli.EditValue = 0.0
      txtHargaJual1.EditValue = 0.0
      txtHargaJual2.EditValue = 0.0
      txtHargaJual3.EditValue = 0.0
      txtHargaJual4.EditValue = 0.0
      txtHargaJual5.EditValue = 0.0
      txtStockMax.EditValue = 0.0
      txtStockMin.EditValue = 0.0
      txtFeeAgen.EditValue = 0.0
      txtOD.EditValue = 0.0
      txtID.EditValue = 0.0
      txtLength.EditValue = 0.0
      txtThickness.EditValue = 0.0
      txtBarcode.Text = ""
      txtAktif.Checked = True

      txtAkunPersediaan.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunPersediaan))
      txtAkunPendapatan.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunPendapatan))
      txtAkunHPP.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunHPP))
      txtAkunDiscPenjualan.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunDiscPenjualan))
      txtAkunDiscPembelian.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunDiscPembelian))
      txtAkunReturPenjualan.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunReturPenjualan))
      txtAkunReturPembelian.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunReturPembelian))
      txtPajakIn.EditValue = session.GetObjectByKey(Of Persistent.Pajak)(Convert.ToInt32(settingitem.PajakIN))
      txtPajakOut.EditValue = session.GetObjectByKey(Of Persistent.Pajak)(Convert.ToInt32(settingitem.PajakOut))
      txtTipe.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtTipe)
      txtJenis.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtJenis)
      txtUang.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtUang)

      Dim dsSatuan = CType(txtSatuan.Properties.DataSource, XPCollection(Of NuSoft004.Persistent.Satuan))
			If dsSatuan.Count > 0 Then
				txtSatuan.EditValue = dsSatuan(0) 'Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtSatuan)
				txtSatuanDasar.EditValue = dsSatuan(0) 'Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtSatuanDasar)
			End If

			txtQtyBahanJadi.EditValue = 0.0
		Else
      instance = session.GetObjectByKey(Of Persistent.Barang)(CType(IdToEdit, Int64))
      txtAktif.EditValue = instance.Aktif
      txtKode.EditValue = instance.Kode
      txtNama.EditValue = instance.Nama
      txtJenis.EditValue = instance.Jenis
      txtTipe.EditValue = instance.TipeBarang
      txtSatuan.EditValue = instance.Satuan
      txtSatuanDasar.EditValue = instance.SatuanD
			txtUang.EditValue = instance.Uang
			txtFeeAgen.EditValue = instance.FeeAgen
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

      txtStockMax.EditValue = instance.StockMax
      txtStockMin.EditValue = instance.StockMin
      txtKategori.EditValue = instance.Kategori
      txtSubKategori.EditValue = instance.SubKategori
      txtMerk.EditValue = instance.Merk
      txtNote.EditValue = instance.Note

      txtCustom1.Text = instance.Custom1
      txtCustom2.Text = instance.Custom2
      txtCustom3.Text = instance.Custom3
      txtCustom4.Text = instance.Custom4
      txtCustom5.Text = instance.Custom5
      txtCustom6.Text = instance.Custom6
      txtCustom7.Text = instance.Custom7
      txtCustom8.Text = instance.Custom8
      txtCustom9.Text = instance.Custom9
			txtCustom10.Text = instance.Custom10
			txtKodeBahanJadi.EditValue = instance.BahanJadiBarang
			txtQtyBahanJadi.EditValue = instance.BahanJadiQty

			'txtOD.Value = instance.OutDiameter
			'txtID.Value = instance.InDiameter
			'txtThickness.Value = instance.Thickness
			'txtLength.Value = instance.Length
			txtBarcode.Text = instance.Custom1

			Me.Text = "Item: Edit - " & instance.Kode
    End If
    xGridLokasi.DataSource = instance.ItemLocation
    xGridPenyusun.DataSource = instance.ItemPenyusun
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
		instance.FeeAgen = CType(txtFeeAgen.EditValue, Double)

		instance.CoaStock = CType(txtAkunPersediaan.EditValue, NuSoft001.Persistent.Coa)
    instance.CoaIncome = CType(txtAkunPendapatan.EditValue, NuSoft001.Persistent.Coa)
    instance.CoaCost = CType(txtAkunHPP.EditValue, NuSoft001.Persistent.Coa)
    instance.CoaDiscIncome = CType(txtAkunDiscPenjualan.EditValue, NuSoft001.Persistent.Coa)
    instance.CoaDiscOut = CType(txtAkunDiscPembelian.EditValue, NuSoft001.Persistent.Coa)
    instance.CoaReturnIn = CType(txtAkunReturPenjualan.EditValue, NuSoft001.Persistent.Coa)
    instance.CoaReturnOut = CType(txtAkunReturPembelian.EditValue, NuSoft001.Persistent.Coa)
    instance.PajakIN = CType(txtPajakIn.EditValue, Persistent.Pajak)
    instance.PajakOUT = CType(txtPajakOut.EditValue, Persistent.Pajak)

    instance.StockMax = CType(txtStockMax.EditValue, Double)
    instance.StockMin = CType(txtStockMin.EditValue, Double)
    instance.Kategori = CType(txtKategori.EditValue, Persistent.Kategori)
    instance.SubKategori = CType(txtSubKategori.EditValue, Persistent.SubKategori)
    instance.Merk = CType(txtMerk.EditValue, Persistent.Merk)
    instance.Note = txtNote.Text

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

		'instance.OutDiameter = txtOD.Value
		'instance.InDiameter = txtID.Value
		'instance.Thickness = txtThickness.Value
		'instance.Length = txtLength.Value
		instance.Custom1 = txtBarcode.Text

		instance.BahanJadiBarang = CType(txtKodeBahanJadi.EditValue, Persistent.Barang)
		instance.BahanJadiQty = CType(txtQtyBahanJadi.EditValue, Double)
		instance.Save()
		session.CommitChanges()
  End Sub

  Public Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1, -2 : txtKode.Focus()
      Case -3 : txtNama.Focus()
        'Case -4 : txtKategori.Focus()
      Case Else
    End Select
    tabBarangDialog.SelectedTabPage = tabBarangDialogGeneral
  End Sub
  Private Sub BindingDataSource()
    Dim xCOA As DevExpress.Xpo.XPCollection(Of NuSoft001.Persistent.Coa)
    Dim settinginventory As New Logic.InventorySetting(session)
    txtSatuan.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Satuan)(session)
    txtSatuanDasar.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Satuan)(session)
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)

    xCOA = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Kas, NuSoft001.Persistent.CoaEnum.eKind.Bank, NuSoft001.Persistent.CoaEnum.eKind.Persediaan, NuSoft001.Persistent.CoaEnum.eKind.Piutang, NuSoft001.Persistent.CoaEnum.eKind.AktivaLancarLainnya, NuSoft001.Persistent.CoaEnum.eKind.AktivaTetap, NuSoft001.Persistent.CoaEnum.eKind.AkumulasiPenyusutan, NuSoft001.Persistent.CoaEnum.eKind.HutangJangkaPanjang, NuSoft001.Persistent.CoaEnum.eKind.HutangJangkaPendek, NuSoft001.Persistent.CoaEnum.eKind.HutangLancarLainnya, NuSoft001.Persistent.CoaEnum.eKind.Modal, NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.PendapatanLainLain, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan, NuSoft001.Persistent.CoaEnum.eKind.BiayaOperasional, NuSoft001.Persistent.CoaEnum.eKind.BiayaLainLain})

    If settinginventory.SettingCOAAll = True Then
      txtAkunPersediaan.Properties.DataSource = xCOA
      txtAkunPendapatan.Properties.DataSource = xCOA
      txtAkunHPP.Properties.DataSource = xCOA
      txtAkunDiscPenjualan.Properties.DataSource = xCOA
      txtAkunDiscPembelian.Properties.DataSource = xCOA
      txtAkunReturPenjualan.Properties.DataSource = xCOA
      txtAkunReturPembelian.Properties.DataSource = xCOA
    Else
      txtAkunPersediaan.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Persediaan})
      txtAkunPendapatan.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan})
      txtAkunHPP.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
      txtAkunDiscPenjualan.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
      txtAkunDiscPembelian.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
      txtAkunReturPenjualan.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
      txtAkunReturPembelian.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
    End If
    txtPajakIn.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Pajak)(session)
    txtPajakOut.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Pajak)(session)
    txtJenis.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.JenisBarang))
    txtTipe.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.TipeBarang))
    txtKategori.Properties.DataSource = New XPCollection(Of Persistent.Kategori)(session)
    txtSubKategori.Properties.DataSource = New XPCollection(Of Persistent.SubKategori)(session)
    txtMerk.Properties.DataSource = New XPCollection(Of Persistent.Merk)(session)

    colGudangRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Gudang)(session)
		colKodeBarangRepo.DataSource = New XPCollection(Of Persistent.Barang)(session)
		txtKodeBahanJadi.Properties.DataSource = New XPCollection(Of Persistent.Barang)(session)
		colSatuanRepo.DataSource = New XPCollection(Of Persistent.Satuan)(session)
		If settinginventory.KunciSettingCOA = True Then
			lytSettingAkuntansi.Enabled = False
		End If
	End Sub
  Private Sub xGridPenyusunView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridPenyusunView.CellValueChanged
    If Not e.Value Is Nothing Then
      Dim row As Persistent.BarangAssembly = CType(xGridPenyusunView.GetRow(e.RowHandle), Persistent.BarangAssembly)
      If e.Column Is colKodeBarang Then
        If Not row Is Nothing Then
          Dim xbarang As NuSoft004.Persistent.Barang = CType(e.Value, NuSoft004.Persistent.Barang)
          Dim xHarga As Double = 0
          row.Satuan = xbarang.Satuan
        End If
      End If
    End If
  End Sub
  Private Sub xGridPenyusunView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridPenyusunView.InitNewRow
    Dim row As Persistent.BarangAssembly = CType(xGridPenyusunView.GetRow(e.RowHandle), Persistent.BarangAssembly)
    row.BarangPenyusun = Nothing
    row.Qty = 1
    row.Barang = instance
    row.Catatan = ""
  End Sub
End Class