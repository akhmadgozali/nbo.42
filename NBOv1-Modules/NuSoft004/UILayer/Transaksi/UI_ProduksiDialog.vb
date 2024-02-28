Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraNavBar.ViewInfo
Imports NuSoft.Core.SSystem
Imports System.ComponentModel
Imports System.Reflection

Friend Class UI_ProduksiDialog
	Private instance As Persistent.StockMain
	Private isShown As Boolean
	Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
	Private editAssign As Boolean = False
	'Private detailToDelete As New List(Of Persistent.StockDetail)
	'Private detailToDeleteCoa As New List(Of Persistent.StockCost)
	Private defaultRegional As NPO.Modules.ModSys.Regional
	Private setting As NuSoft001.Logic.FinaSetting
	Private settinginventory As Logic.InventorySetting
	Private sumber As Persistent.SumberDataCollection

	Private listBahanBaku As BindingList(Of Persistent.StockDetailToSave)
	Private listCost As BindingList(Of Persistent.StockCostToSave)
	Private listBahanJadi As BindingList(Of Persistent.StockDetailToSave)

	Sub New()
		InitializeComponent()
		NoDropIdentityMap = True
		Persistent.StockMain.AutoSaveOnEndEdit = False
		Persistent.GlMain.AutoSaveOnEndEdit = False
		Persistent.StockDetail.AutoSaveOnEndEdit = False
		Persistent.StockCost.AutoSaveOnEndEdit = False
		NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
	End Sub
	Overrides Sub LoadBeforeInitialize()
		setting = New NuSoft001.Logic.FinaSetting(session)
		settinginventory = New Logic.InventorySetting(session)
		BindingDataSource()
		sumber = New Persistent.SumberDataCollection(session)
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("AMTransaksi.xml")) = True Then
			lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("AMTransaksi.xml"))
		End If
	End Sub
	Overrides Sub InitializeData()
		MyBase.InitializeData()
		session.ReloadChangedObjects()

		listBahanBaku = New BindingList(Of Persistent.StockDetailToSave)
		listBahanJadi = New BindingList(Of Persistent.StockDetailToSave)
		listCost = New BindingList(Of Persistent.StockCostToSave)
		If Tipe = InputType.Tambah Then
			instance = New Persistent.StockMain(session)
			instance.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
			'xGridBahanBaku.DataSource = Nothing
			'xGridCost.DataSource = Nothing
			'xGridBahanJadi.DataSource = Nothing
			LoadDefault()
			ChangeCode()
			txtKontak.Focus()
			'xGridBahanBaku.DataSource = instance.Detail
			'xGridCost.DataSource = instance.Cost
			'xGridBahanJadi.DataSource = instance.Detail
		Else
			editAssign = True
			'xGridBahanBaku.DataSource = Nothing
			'xGridCost.DataSource = Nothing
			'xGridBahanJadi.DataSource = Nothing
			instance = session.GetObjectByKey(Of Persistent.StockMain)(Convert.ToInt64(IdToEdit))
			txtUraian.Text = instance.Catatan
			txtNoTransaksi.Text = instance.Kode
			txtTanggal.EditValue = instance.Tanggal
			txtRegional.EditValue = instance.Regional
			txtGudang.EditValue = instance.Gudang
			txtGudangTujuan.EditValue = instance.Gudang2
			txtKontak.EditValue = instance.KaryawanKirim
			txtStatus.EditValue = instance.StatusTransaksi

			'xGrid.DataSource = From p In instance.Detail Select p Where p.QtyOut <> 0
			'xGridCost.DataSource = instance.Cost
			'xGridBahanJadi.DataSource = From p In instance.Detail Select p Where p.QtyIn <> 0

			Dim xBaku = instance.Detail.Where(Function(w) w.QtyOut <> 0)
			Dim xJadi = instance.Detail.Where(Function(w) w.QtyIn <> 0)
			For Each x In xBaku
				listBahanBaku.Add(New Persistent.StockDetailToSave() With {
					.Id = x.Id,
					.Barang = x.Barang,
					.Satuan = x.Satuan,
					.QtyIn = x.QtyIn,
					.QtyOut = x.QtyOut,
					.HargaIn = x.HargaIn,
					.Gudang = x.Gudang,
					.Gudang2 = x.Gudang2,
					.PermintaanBarang = x.PermintaanBarang,
					.PersentaseHPP = x.PersentaseHPP,
					.Catatan = x.Catatan,
					.Divisi = x.Divisi,
					.Proyek = x.Proyek
				})
			Next
			For Each x In xJadi
				listBahanJadi.Add(New Persistent.StockDetailToSave() With {
					.Id = x.Id,
					.Barang = x.Barang,
					.Satuan = x.Satuan,
					.QtyIn = x.QtyIn,
					.QtyOut = x.QtyOut,
					.HargaIn = x.HargaIn,
					.Gudang = x.Gudang,
					.Gudang2 = x.Gudang2,
					.PermintaanBarang = x.PermintaanBarang,
					.PersentaseHPP = x.PersentaseHPP,
					.Catatan = x.Catatan,
					.Divisi = x.Divisi,
					.Proyek = x.Proyek
				})
			Next
			For Each x In instance.Cost
				listCost.Add(New Persistent.StockCostToSave() With {
					.Id = x.Id,
					.Cost = x.Cost,
					.Jumlah = x.Jumlah,
					.Catatan = x.Catatan
				})
			Next

			editAssign = False
		End If
		'xGridView.ActiveFilterString = "[QtyOut]>0"
		'xGridBahanJadiView.ActiveFilterString = "[QtyIn]>0"

		xGridBahanBaku.DataSource = listBahanBaku
		xGridCost.DataSource = listCost
		xGridBahanJadi.DataSource = listBahanJadi

		SetNomor()
	End Sub
	Overrides Sub LoadAfterInitialize()
		'SetFormat()
		If Tipe = InputType.Tambah Then
			Me.Text = "Produksi : Tambah Data"
		Else
			Me.Text = "Produksi : Edit Data # " & instance.Kode
			If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
				DisableControl()
			End If
			If NuSoft001.Persistent.Periode.CheckLockedPeriod(session, instance.Tanggal) Then
				DisableControl()
			End If
			If NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit = False Then
				DisableControl()
			End If
		End If
	End Sub
	Overrides Sub SimpanData()
		If txtKontak.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan nama karyawan.", 0, "", "Simpan Transaksi")
			Exit Sub
		End If
		If txtGudang.EditValue Is Nothing Then
			Throw New Utils.Exception("Masukkan gudang sumber.", 0, "", "Simpan Transaksi")
			Exit Sub
		End If
		If txtGudangTujuan Is Nothing Then
			Throw New Utils.Exception("Masukkan gudang tujuan.", 0, "", "Simpan Transaksi")
			Exit Sub
		End If

		'For i = detailToDelete.Count - 1 To 0 Step -1
		'	detailToDelete(i).Delete()
		'Next

		Try
			'======= Simpan Main
			instance.Tanggal = txtTanggal.DateTime
			instance.Kode = txtNoTransaksi.Text
			instance.KaryawanKirim = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
			instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
			instance.Gudang = CType(txtGudang.EditValue, Persistent.Gudang)
			instance.Gudang2 = CType(txtGudang.EditValue, Persistent.Gudang)
			instance.Catatan = txtUraian.Text
			instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
			instance.MataUang = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
			instance.Kurs = 1

			' ==== set detail baku, cost, jadi
			Dim xBaku = listBahanBaku.ToList
			Dim xJadi = listBahanJadi.ToList
			Dim xCost = listCost.ToList

			' ==== ==== hapus detail baku, jadi, cost
			For x = instance.Detail.Count - 1 To 0 Step -1
				Dim xItem = instance.Detail(x)
				Dim foundBaku = xBaku.Find(Function(f) f.Id = xItem.Id)
				Dim foundJadi = xJadi.Find(Function(f) f.Id = xItem.Id)
				If foundBaku Is Nothing AndAlso foundJadi Is Nothing Then
					xItem.Delete()
				End If
			Next
			For x = instance.Cost.Count - 1 To 0 Step -1
				Dim xItem = instance.Cost(x)
				Dim foundCost = xCost.Find(Function(f) f.Id = xItem.Id)
				If foundCost Is Nothing Then
					xItem.Delete()
				End If
			Next
			' ==== ==== insert / update detail baku, jadi, cost
			For Each x In xBaku
				Dim found = instance.Detail.ToList.Find(Function(f) f.Id = x.Id)
				If x.Id = Nothing OrElse found Is Nothing Then
					found = New Persistent.StockDetail(session) With {.Main = instance}
					instance.Detail.Add(found)
				End If
				found.Barang = x.Barang
				found.Satuan = x.Satuan
				found.QtyIn = x.QtyIn
				found.QtyOut = x.QtyOut
				found.HargaIn = x.HargaIn
				found.Gudang = x.Gudang
				found.Gudang2 = x.Gudang2
				found.PermintaanBarang = x.PermintaanBarang
				found.PersentaseHPP = x.PersentaseHPP
				found.Catatan = x.Catatan
				found.Divisi = x.Divisi
				found.Proyek = x.Proyek
			Next
			For Each x In xJadi
				Dim found = instance.Detail.ToList.Find(Function(f) f.Id = x.Id)
				If x.Id = Nothing OrElse found Is Nothing Then
					found = New Persistent.StockDetail(session) With {.Main = instance}
					instance.Detail.Add(found)
				End If
				found.Barang = x.Barang
				found.Satuan = x.Satuan
				found.QtyIn = x.QtyIn
				found.QtyOut = x.QtyOut
				found.HargaIn = x.HargaIn
				found.Gudang = x.Gudang
				found.Gudang2 = x.Gudang2
				found.PermintaanBarang = x.PermintaanBarang
				found.PersentaseHPP = x.PersentaseHPP
				found.Catatan = x.Catatan
				found.Divisi = x.Divisi
				found.Proyek = x.Proyek
			Next
			For Each x In xCost
				Dim found = instance.Cost.ToList.Find(Function(f) f.Id = x.Id)
				If x.Id = Nothing OrElse found Is Nothing Then
					found = New Persistent.StockCost(session) With {.Main = instance}
					instance.Cost.Add(found)
				End If
				found.Cost = x.Cost
				found.Jumlah = x.Jumlah
				found.Catatan = x.Catatan
			Next

			'buatkan HPPnya dulu
			Dim data As Persistent.StockDetailHPPReff
			For pI = 0 To instance.Detail.Count - 1
				If instance.Detail(pI).QtyOut > 0 Then
					instance.Detail(pI).Gudang = CType(txtGudang.EditValue, Persistent.Gudang)
					Dim pQTY As Double
					pQTY = instance.Detail(pI).QtyOut
					Dim xDataHPP As New XPCollection(Of Persistent.vwHPP)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("f_item.Id", instance.Detail(pI).Barang.Id, BinaryOperatorType.Equal), New BinaryOperator("d_available", 0, BinaryOperatorType.Greater), New BinaryOperator("f_warehouse.Id", instance.Detail(pI).Gudang.Id, BinaryOperatorType.Equal)))
					For pJ = 0 To xDataHPP.Count - 1
						data = New Persistent.StockDetailHPPReff(session)
						data.DetailIN = xDataHPP(pJ).Id
						If pQTY > xDataHPP(pJ).d_available Then
							pQTY = pQTY - xDataHPP(pJ).d_available
							data.Qty = xDataHPP(pJ).d_available
						Else
							data.Qty = pQTY
							pQTY = 0
						End If
						instance.Detail(pI).HPPReff.Add(data)
						If pQTY = 0 Then
							Exit For
						End If
					Next
				End If
			Next

			'seting harganya dari hpp keluar menjadi hpp masuk
			Dim xTotalHPP As Double = instance.Detail.Sum(Function(m) m.NilaiHPP) + instance.Cost.Sum(Function(m) m.Jumlah)
			For pI = 0 To instance.Detail.Count - 1
				If instance.Detail(pI).QtyIn > 0 Then
					instance.Detail(pI).Gudang = CType(txtGudangTujuan.EditValue, Persistent.Gudang)
					instance.Detail(pI).HargaIn = ((instance.Detail(pI).PersentaseHPP / 100 * xTotalHPP) / instance.Detail(pI).QtyIn)
				End If
			Next
			'instance.Save()

			'jurnalnya
			instance.Gl.Sumber = instance.Sumber
			instance.Gl.Tanggal = instance.Tanggal
			instance.Gl.Regional = instance.Regional
			instance.Gl.Kode = instance.Kode
			instance.Gl.ModuleId = NPO.Modules.ModuleId.Inventory
			'instance.Gl.MataUang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Simbol
			instance.Gl.Kurs = 1
			instance.Gl.Kontak = instance.KaryawanKirim
			instance.Gl.KontakNama = txtKontak.Text
			instance.Gl.Uraian = txtUraian.Text

			'biaya (cost)
			Dim i As Byte = 1
			Dim a = From z In instance.Cost Group z By z.Cost.CoaCost Into Group Select CoaCost, nilai = Group.Sum(Function(x) x.Jumlah)
			For Each x In a
				SimpanGL(x.CoaCost, i, 0, x.nilai)
				i = CByte(i + 1)
			Next
			'persediaan keluar (hpp)
			'Dim b = From z In instance.Detail Group z By z.Barang.CoaStock, z.QtyOut Into Group Select QtyOut, CoaStock, NilaiHPP = Group.Sum(Function(x) x.NilaiHPP) Where QtyOut > 0
			Dim b = From z In instance.Detail Group z By z.Barang.CoaStock Into Group Select CoaStock, NilaiHPP = Group.Sum(Function(x) x.NilaiHPP)
			For Each y In b
				If y.NilaiHPP > 0 Then
					SimpanGL(y.CoaStock, i, 0, y.NilaiHPP)
					i = CByte(i + 1)
				End If
			Next
			'persediaan bahan jadi
			'Dim c = From z In instance.Detail Group z By z.Barang.CoaStock, z.QtyIn Into Group Select QtyIn, CoaStock, NilaiStock = Group.Sum(Function(x) x.NilaiIN) Where QtyIn > 0
			Dim c = From z In instance.Detail Group z By z.Barang.CoaStock Into Group Select CoaStock, NilaiStock = Group.Sum(Function(x) x.NilaiIN)
			For Each v In c
				If v.NilaiStock > 0 Then
					SimpanGL(v.CoaStock, i, v.NilaiStock, 0)
					i = CByte(i + 1)
				End If
			Next

			''check jurnal
			'Dim msg As String = ""
			'For z = 0 To instance.Gl.Detail.Count - 1
			'	Dim xyz = instance.Gl.Detail(z)
			'	msg &= String.Format("Akun : {0}, Debit : {1}, Kredit : {2}" & vbCrLf, xyz.Akun.Nama, xyz.Debit.ToString("n0"), xyz.Kredit.ToString("n0"))
			'Next
			'msg &= "Total Debet : " & instance.Gl.Detail.Sum(Function(s) s.Debit).ToString("n0")
			'msg &= ", Total Kredit : " & instance.Gl.Detail.Sum(Function(s) s.Kredit).ToString("n0")
			'msg &= ", var i : " & i

			'MsgBox(msg)

			If instance.Gl.Detail.Count > i Then
				For pi = CInt(i) To instance.Gl.Detail.Count - 1 Step -1
					instance.Gl.Detail(i).Delete()
				Next
			End If
			'======= Simpan instance
			session.CommitChanges()
		Catch ex As Utils.Exception
			Throw New Utils.Exception(ex)
		Catch ex As Exception
			If ex.Message.Contains("Duplicate entry") Then
				instance.Kode = instance.Number.GetNewNumber.Kode
				session.CommitChanges()
			Else
				Throw New Exception(ex.Message, ex.InnerException)
			End If
		End Try
		Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.AM)
		frm.txtNoBukti1.Text = instance.Kode
		Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
		Dim reportCode As String = ""
		reportCode = MainClass.GetReport(MainClass.reportName.VoucherProduksi)
		message = String.Format(message, "Produksi (Assembly)")
		Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
	End Sub
	Private Sub SimpanGL(Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double)
		Dim item As Persistent.GlMainDetail
		If instance.Gl.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
			item = instance.Gl.Detail.Single(Function(m) m.Urutan = Urutan)

			item.Akun = Akun
			item.MataUang = item.Akun.MataUang
			item.Main = instance.Gl
			item.Urutan = Urutan
			item.Debit = Debit
			item.Kredit = Kredit
			item.Kurs = 1
			item.DebitValas = 0
			item.KreditValas = 0
		Else
			item = New Persistent.GlMainDetail(session)

			item.Akun = Akun
			item.MataUang = item.Akun.MataUang
			item.Main = instance.Gl
			item.Urutan = Urutan
			item.Debit = Debit
			item.Kredit = Kredit
			item.Kurs = 1
			item.DebitValas = 0
			item.KreditValas = 0
			instance.Gl.Detail.Add(item)
		End If
	End Sub
	Overrides Sub ErrorSimpan(ex As Utils.Exception)
		'======== hapus yg add new 
		For a = instance.Detail.Count - 1 To 0 Step -1
			Dim ax = instance.Detail(a)
			ax.Delete()
		Next
		For a = instance.Cost.Count - 1 To 0 Step -1
			Dim ax = instance.Cost(a)
			ax.Delete()
		Next

		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case -1 : txtRegional.Focus()
			Case -3 : txtUraian.Focus()
			Case -4 : txtTanggal.Focus()
			Case -5, -7 : xGridBahanBaku.Focus()
		End Select
	End Sub

	Private Sub ChangeCode()
		If txtTanggal.EditValue Is Nothing OrElse instance.Tanggal = Nothing Then
			Return
		End If
		If setting.FormatNomor.Contains(NuSoft001.My.Resources.FormatRegional) AndAlso (txtRegional.EditValue Is Nothing OrElse instance.Regional Is Nothing) Then
			Return
		End If
		If setting.FormatNomor.Contains(NuSoft001.My.Resources.FormatSumber) AndAlso instance.Sumber Is Nothing Then
			Return
		End If

		Dim nomor As Core.Modules.NumberResult = instance.Number.GetNewNumber
		txtNoTransaksi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
		txtNoTransaksi.Properties.Mask.EditMask = nomor.Mask
		txtNoTransaksi.Text = nomor.Kode
	End Sub
	Private Sub BindingDataSource()
		txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
		txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
		txtGudang.Properties.DataSource = New XPCollection(Of Persistent.Gudang)(session)
		txtGudangTujuan.Properties.DataSource = New XPCollection(Of Persistent.Gudang)(session)
		colKodeBarangRepo.DataSource = New XPCollection(Of Persistent.Barang)(session)
		colSatuanRepo.DataSource = New XPCollection(Of Persistent.Satuan)(session)
		colKodeCostRepo.DataSource = New XPCollection(Of Persistent.BiayaLain)(session)
		colKodeBarangBJRepo.DataSource = New XPCollection(Of Persistent.Barang)(session)
		colSatuanBJRepo.DataSource = New XPCollection(Of Persistent.Satuan)(session)
		txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
		'txtKodeBarang.Properties.DataSource = New XPCollection(Of Persistent.Barang)(session)
		txtKodeBarang.Properties.DataSource = New XPQuery(Of Persistent.Barang)(session).Where(Function(w) w.Jenis = Persistent.JenisBarang.Assembly).ToList()
	End Sub
	Private Sub SetFormat()
		colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colQty.DisplayFormat.FormatString = setting.NumericFormatString
		colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
		colJumlah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colJumlah.DisplayFormat.FormatString = setting.NumericFormatString
		colJumlah.SummaryItem.DisplayFormat = setting.NumericFormatString
		colQtyBJ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colQtyBJ.DisplayFormat.FormatString = setting.NumericFormatString
		colQtyBJ.SummaryItem.DisplayFormat = setting.NumericFormatString
		colHPPBJ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colHPPBJ.DisplayFormat.FormatString = setting.NumericFormatString
		colHPPBJ.SummaryItem.DisplayFormat = setting.NumericFormatString
		txtQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
		txtQty.Properties.Mask.EditMask = setting.NumericFormatToString
		txtQty.Properties.Mask.UseMaskAsDisplayFormat = True
	End Sub
	Private Sub LoadDefault()
		If xpSettingRegional Is Nothing Then
			xpSettingRegional = New XPCollection(Of NuSoft001.Persistent.SettingRegional)(session)
		End If
		defaultRegional = UserInfo.GetDefaultRegional(session)
		txtTanggal.EditValue = Now
		If Not defaultRegional Is Nothing Then
			txtRegional.EditValue = defaultRegional
		Else
			txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
		End If
		instance.Tanggal = txtTanggal.DateTime
		instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
		txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
		txtUraian.EditValue = settinginventory.UraianProduksi
		txtQty.EditValue = 1.0

		'ambilkan data default gudang
		txtGudang.EditValue = session.GetObjectByKey(Of Persistent.Gudang)(Convert.ToInt32(settinginventory.Gudang1))
		txtGudangTujuan.EditValue = session.GetObjectByKey(Of Persistent.Gudang)(Convert.ToInt32(settinginventory.Gudang2))
	End Sub
	Private Sub SetNomor()
		instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.AM)
		instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
	End Sub
	Private Sub DisableControl()
		txtKontak.Enabled = False
		txtTanggal.Enabled = False
		txtNoTransaksi.Enabled = False
		txtRegional.Enabled = False
		txtUraian.Enabled = False
		txtGudang.Enabled = False
		xGridBahanBakuView.OptionsBehavior.Editable = False
		xGridCostView.OptionsBehavior.Editable = False
		xGridBahanJadiView.OptionsBehavior.Editable = False
		AllowSave = False
	End Sub
	Private Sub GantiTanggalTahun()
		Dim str As String = "Edit tanggal dengan tahun berbeda akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"

		If Tipe = InputType.Edit AndAlso isShown Then
			If instance.Tanggal.Year <> CDate(txtTanggal.EditValue).Year Then
				If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Tanggal", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
					instance.Tanggal = txtTanggal.DateTime
					ChangeCode()
				Else
					txtTanggal.EditValue = instance.Tanggal
				End If
			Else
				instance.Tanggal = txtTanggal.DateTime
				ChangeCode()
			End If
		ElseIf Tipe = InputType.Tambah Then
			instance.Tanggal = txtTanggal.DateTime
			ChangeCode()
		End If
	End Sub
	Private Sub GantiTanggalBulan()
		Dim str As String = "Edit tanggal dengan bulan dan tahun berbeda akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"

		If Tipe = InputType.Edit AndAlso isShown Then
			If instance.Tanggal.Month <> CDate(txtTanggal.EditValue).Month OrElse instance.Tanggal.Year <> CDate(txtTanggal.EditValue).Year Then
				If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Tanggal", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
					instance.Tanggal = txtTanggal.DateTime
					ChangeCode()
				Else
					txtTanggal.EditValue = instance.Tanggal
				End If
			Else
				instance.Tanggal = txtTanggal.DateTime
				ChangeCode()
			End If
		ElseIf Tipe = InputType.Tambah Then
			instance.Tanggal = txtTanggal.DateTime
			ChangeCode()
		End If
	End Sub

	Private Function GetViewInfo(navBar As NavBarControl) As NavBarViewInfo
		Dim fi As FieldInfo = GetType(NavBarControl).GetField("viewInfo", BindingFlags.NonPublic Or BindingFlags.Instance)
		Return CType(fi.GetValue(navBar), NavBarViewInfo)
	End Function
	Private Function GetGroupPainter(navBar As NavBarControl) As ExplorerBarNavGroupPainter
		Dim fi As FieldInfo = GetType(NavBarControl).GetField("groupPainter", BindingFlags.NonPublic Or BindingFlags.Instance)
		Return CType(fi.GetValue(navBar), ExplorerBarNavGroupPainter)
	End Function
	Private Sub navCatatan_CalcGroupClientHeight(sender As Object, e As NavBarCalcGroupClientHeightEventArgs) Handles navCatatan.CalcGroupClientHeight
		Dim vi As NavBarViewInfo = GetViewInfo(NavBarControl1)
		Dim gi As NavGroupInfoArgs = CType(vi.Groups((vi.Groups.Count - 1)), NavGroupInfoArgs)
		Dim groupPainter As ExplorerBarNavGroupPainter = GetGroupPainter(NavBarControl1)
		'groupPainter.CalcFooterBounds(gi, gi.Bounds)
		Dim delta As Integer = gi.Bounds.Top - vi.Client.Top
		Dim ch As Integer = vi.Client.Height - delta - gi.Bounds.Height - gi.FooterBounds.Height
		e.Height = ch
	End Sub

	Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
		If Not e.NewValue Is Nothing Then
			lblKontakNama.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Nama
			'isikan data detailnya
			txtPhoneNumber.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Telepon
			txtDebitLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasPiutang)
			txtCreditLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasHutang)

			'Dim xpTransaksi As New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("Id", CType(e.NewValue, NuSoft001.Persistent.Kontak).Id, BinaryOperatorType.Equal))
		End If
	End Sub
	Private Sub txtRegional_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtRegional.EditValueChanging
		Dim str As String = "Edit regional transaksi akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"
		Try
			If Tipe = InputType.Edit AndAlso isShown Then
				If Not instance.Regional Is e.NewValue Then
					If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Regional", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
						instance.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
						ChangeCode()
					Else
						e.Cancel = True
					End If
				Else
					instance.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
					ChangeCode()
				End If
			ElseIf Tipe = InputType.Tambah Then
				instance.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
				ChangeCode()
			End If
		Catch ex As Exception
			If ex.Message.Contains("Object reference not set to an instance") Then
			Else
				DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Ganti Regional", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
			End If
		End Try
	End Sub
	Private Sub txtTanggal_DateTimeChanged(sender As Object, e As EventArgs) Handles txtTanggal.DateTimeChanged
		Dim str As String = "Edit tanggal dengan bulan dan tahun berbeda akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"
		Try
			If Tipe = InputType.Edit AndAlso isShown Then
        If instance.Tanggal.Month <> CDate(txtTanggal.EditValue).Month OrElse instance.Tanggal.Year <> CDate(txtTanggal.EditValue).Year Then
          If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Tanggal", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            instance.Tanggal = txtTanggal.DateTime
            ChangeCode()
          Else
            txtTanggal.EditValue = instance.Tanggal
          End If
        Else
          instance.Tanggal = txtTanggal.DateTime
        End If
      ElseIf Tipe = InputType.Tambah Then
				instance.Tanggal = txtTanggal.DateTime
				ChangeCode()
			End If
		Catch ex As Exception
			If ex.Message.Contains("Object reference not set to an instance") Then
			Else
				DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Me.Text, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
			End If
		End Try
	End Sub

	Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridBahanBakuView.CellValueChanged
		If Not e.Value Is Nothing Then
			If e.Column Is colKodeBarang Then
				Dim row As Persistent.StockDetailToSave = CType(xGridBahanBakuView.GetRow(e.RowHandle), Persistent.StockDetailToSave)
				If Not row Is Nothing Then
					Dim xbarang As Persistent.Barang = CType(e.Value, Persistent.Barang)
					row.Satuan = xbarang.Satuan
				End If
			End If
		End If
	End Sub
	Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridBahanBakuView.InitNewRow
		Dim row As Persistent.StockDetailToSave = CType(xGridBahanBakuView.GetRow(e.RowHandle), Persistent.StockDetailToSave)
		row.Barang = Nothing
		row.QtyOut = 1
		'row.Main = instance
		row.Catatan = ""
	End Sub
	Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridBahanBakuView.KeyDown
		If e.KeyCode = Windows.Forms.Keys.Delete Then
			Dim Id As Persistent.StockDetailToSave = CType(xGridBahanBakuView.GetRow(xGridBahanBakuView.FocusedRowHandle), Persistent.StockDetailToSave)
			xGridBahanBakuView.DeleteRow(xGridBahanBakuView.FocusedRowHandle)
			listBahanBaku.Remove(Id)
		End If
	End Sub

	Private Sub GridBahanJadi_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridBahanJadiView.CellValueChanged
		If Not e.Value Is Nothing Then
			If e.Column Is colKodeBarangBJ Then
				Dim row As Persistent.StockDetailToSave = CType(xGridBahanJadiView.GetRow(e.RowHandle), Persistent.StockDetailToSave)
				If Not row Is Nothing Then
					Dim xbarang As Persistent.Barang = CType(e.Value, Persistent.Barang)
					row.Satuan = xbarang.Satuan
				End If
			End If
		End If
	End Sub
	Private Sub GridBahanJadi_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridBahanJadiView.InitNewRow
		Dim row As Persistent.StockDetailToSave = CType(xGridBahanJadiView.GetRow(e.RowHandle), Persistent.StockDetailToSave)
		row.Barang = Nothing
		row.QtyIn = 1
		row.PersentaseHPP = 100
		'row.Main = instance
		row.Catatan = ""
	End Sub
	Private Sub GridBahanJadi_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles xGridBahanJadiView.KeyDown
		If e.KeyCode = Windows.Forms.Keys.Delete Then
			Dim Id As Persistent.StockDetailToSave = CType(xGridBahanJadiView.GetRow(xGridBahanJadiView.FocusedRowHandle), Persistent.StockDetailToSave)
			xGridBahanJadiView.DeleteRow(xGridBahanJadiView.FocusedRowHandle)
			listBahanJadi.Remove(Id)
		End If
	End Sub

	Private Sub GridCost_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridCostView.InitNewRow
		Dim row As Persistent.StockCostToSave = CType(xGridCostView.GetRow(e.RowHandle), Persistent.StockCostToSave)
		row.Cost = Nothing
		row.Jumlah = 0
		'row.Main = instance
		row.Catatan = ""
	End Sub
	Private Sub GridCost_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles xGridCostView.KeyDown
		If e.KeyCode = Windows.Forms.Keys.Delete Then
			Dim Id As Persistent.StockCostToSave = CType(xGridCostView.GetRow(xGridCostView.FocusedRowHandle), Persistent.StockCostToSave)
			xGridCostView.DeleteRow(xGridCostView.FocusedRowHandle)
			listCost.Remove(Id)
		End If
	End Sub

	Private Sub Me_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
		isShown = True
	End Sub
	Protected Overrides Sub OnKeyDown(e As System.Windows.Forms.KeyEventArgs)
		MyBase.OnKeyDown(e)
		If e.Control AndAlso e.Shift Then
			xGridBahanBaku.Focus()
		End If
	End Sub
	Private Sub btnRefreshNomor_Click(sender As Object, e As EventArgs) Handles btnRefreshNomor.Click
		ChangeCode()
	End Sub
	Private Sub btnTemplate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTemplate.ItemClick
		Dim xform As New UI_ProduksiDialogTemplate
		xform.MenuId = MenuId
		xform.NamaDatabase = NamaDatabase
		xform.session = session
		xform.Owner = Me
		xform.ShowDialog()
	End Sub
	Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
		BindingDataSource()
	End Sub
	Friend Sub InitTemplate(xItem As Persistent.Barang, ByVal xJumlah As Double)
		listBahanBaku = New BindingList(Of Persistent.StockDetailToSave)
		listBahanJadi = New BindingList(Of Persistent.StockDetailToSave)

		Dim xDtDetail As Persistent.StockDetailToSave
		'bahan jadi
		xDtDetail = New Persistent.StockDetailToSave
		xDtDetail.Barang = xItem
		xDtDetail.Satuan = xDtDetail.Barang.Satuan
		If xJumlah = 1 Then
			If xItem.HargaJual5 > 1 Then
				xDtDetail.QtyIn = xItem.HargaJual5
			Else
				xDtDetail.QtyIn = xJumlah
			End If
		Else
			xDtDetail.QtyIn = xJumlah
		End If
		xDtDetail.Catatan = ""
		xDtDetail.PersentaseHPP = 100
		listBahanJadi.Add(xDtDetail)

		'bahan penyusun
		For pi = 0 To xItem.ItemPenyusun.Count - 1
			xDtDetail = New Persistent.StockDetailToSave
			xDtDetail.Barang = xItem.ItemPenyusun(pi).BarangPenyusun
			xDtDetail.Satuan = xDtDetail.Barang.Satuan
			xDtDetail.QtyOut = xItem.ItemPenyusun(pi).Qty * xJumlah
			xDtDetail.Catatan = ""
			listBahanBaku.Add(xDtDetail)
		Next

		xGridBahanBaku.DataSource = listBahanBaku
		xGridBahanJadi.DataSource = listBahanJadi
	End Sub
	Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
		InitTemplate(CType(txtKodeBarang.EditValue, Persistent.Barang), CDbl(txtQty.EditValue))
	End Sub
End Class