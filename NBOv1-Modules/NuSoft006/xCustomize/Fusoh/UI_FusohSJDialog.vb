Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors

Friend Class UI_FusohSJDialog
	Private instance As Persistent.Fusoh_SuratJalan
	Private isShown As Boolean
	Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
	Private editAssign As Boolean = False
	Private defaultRegional As NPO.Modules.ModSys.Regional
	Private setting As NuSoft001.Logic.FinaSetting
	Private sumber As Persistent.SumberDataCollection
	Private salesSetting As Logic.SalesSetting
	'Private xDataProduksi As List(Of Persistent.Fusoh_SuratJalanDetail)
	Private dataProduksi As List(Of Persistent.FusohVwProduksi)
	Private editedSJ As List(Of Persistent.Fusoh_SuratJalanDetail)

	Sub New()
		InitializeComponent()
		NoDropIdentityMap = True
	End Sub
	Overrides Sub LoadBeforeInitialize()
		setting = New NuSoft001.Logic.FinaSetting(session)
		salesSetting = New Logic.SalesSetting(session)
		BindingDataSource()
		sumber = New Persistent.SumberDataCollection(session)
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SJTransaksi.xml")) = True Then
			lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SJTransaksi.xml"))
		End If
		If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SJTransaksiGrid.xml")) = True Then
			xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SJTransaksiGrid.xml"))
		End If
	End Sub
	Overrides Sub InitializeData()
		MyBase.InitializeData()
		session.ReloadChangedObjects()
		If Tipe = InputType.Tambah Then
			instance = New Persistent.Fusoh_SuratJalan(session)
			xGrid.DataSource = Nothing
			LoadDefault()
			ChangeCode()
			txtKontak.Focus()
			xGrid.DataSource = instance.Detail
		Else
			editAssign = True
			xGrid.DataSource = Nothing
			instance = session.GetObjectByKey(Of Persistent.Fusoh_SuratJalan)(Convert.ToInt64(IdToEdit))
			txtNoTransaksi.Text = instance.Kode
			txtTanggal.EditValue = instance.Tanggal
			txtKontak.EditValue = instance.Pelanggan
			txtRegional.EditValue = instance.Regional
			txtStatus.EditValue = instance.StatusTransaksi

			txtJenisKendaraan.Text = instance.JenisKendaraan
			txtNamaDriver.Text = instance.Supir
			txtNoKendaraan.Text = instance.NoKendaraan
			txtUraian.Text = instance.Catatan
			txtOtomatisProduksi.Checked = instance.SJOtomatisProduksi

			xGrid.DataSource = instance.Detail
			editAssign = False
			txtKontak.Properties.ReadOnly = True

			''====== update sisa qty => 02022020
			'Dim q = instance.Detail.ToList.GroupBy(Function(g) New With {Key .ProduksiDetail = g.ProduksiDetail, .SODetail = g.SODetail}) _
			'	.Select(Function(s) New With {.De = s.Key.ProduksiDetail, .So = s.Key.SODetail, .jml = s.Sum(Function(f) f.Qty)}).ToList

			'For i = 0 To q.Count - 1
			'	Dim item = q(i)
			'	Dim jmlProduksi = item.De.QtyProduksi
			'	Dim pemakaian = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session).Where(Function(w) w.ProduksiDetail Is item.De).Sum(Function(s) s.Qty)
			'	Dim sisa = (jmlProduksi - pemakaian) + item.jml
			'	Dim datax = instance.Detail.Where(Function(w) w.ProduksiDetail Is item.De AndAlso w.SODetail Is item.So)
			'	For Each x In datax
			'		x.SisaQty = sisa
			'	Next
			'Next
			''====== 02022020

			'=============================
			editedSJ = instance.Detail.ToList()
			For Each item In instance.Detail
				item.SisaQty = GetSisaQtySO(item.SODetail)
			Next
			LoadDataProduksi(instance.Detail.GroupBy(Function(g) g.Barang.Kode).Select(Function(s) s.Key).ToList, True)
			'=============================
		End If
		SetNomor()
	End Sub
	Overrides Sub LoadAfterInitialize()
		SetFormat()
		If Tipe = InputType.Tambah Then
			Me.Text = "Pengiriman Barang [SJ]: Tambah Data"
		Else
			Me.Text = "Pengiriman Barang [SJ]: Edit Data " & instance.Kode
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
	'Overrides Sub SimpanData()
	'	If (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
	'		Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", 0, "", "Simpan Transaksi")
	'		Exit Sub
	'	End If

	'	'===== cek qty tidak boleh lebih dari sisa AM dan sisa stok '=> 02022020
	'	For i = 0 To instance.Detail.Count - 1
	'		If instance.Detail(i).Qty > instance.Detail(i).SisaQty Then
	'			Throw New Utils.Exception("Jumlah qty barang " & instance.Detail(i).Barang.Kode & " melebihi jumlah sisa produksi.", -99, "", "Simpan Transaksi")
	'		End If
	'	Next
	'	'===== 02022020


	'	'===== cek pembagian qty pallet
	'	'Dim q = instance.Detail.ToList.GroupBy(Function(g) New With {Key .SODetail = g.SODetail, .POLine = g.SODetail.POLine, .ProduksiDetail = g.ProduksiDetail, .SODID = g.SODetail.Id}) _
	'	'.Select(Function(s) New With {.De = s.Key.ProduksiDetail, .So = s.Key.SODetail, .jml = s.Sum(Function(f) f.Qty), .SisaQty = s.Average(Function(a) a.SisaQty)}).ToList

	'	Dim q = From z In instance.Detail
	'					Group z By POLine = z.SODetail.POLine, SODetail = z.SODetail, ProduksiDetail = z.ProduksiDetail
	'					Into g = Group
	'					Select New With {
	'						.De = ProduksiDetail,
	'						.So = SODetail,
	'						.PoLine = POLine,
	'						.Jml = g.Sum(Function(s) s.Qty),
	'						.SisaQty = g.Average(Function(a) a.SisaQty)
	'					}

	'   'MsgBox(q.Count)
	'   For i = 0 To q.Count - 1
	'     'If q(i).De.QtyProduksi < q(i).jml Then
	'     '	Throw New Utils.Exception("Jumlah qty barang " & q(i).De.Barang.Kode & " untuk nomor lot " & q(i).De.Main.DempyouLot & " melebihi jumlah produksi.", -99, "", "Simpan Transaksi")
	'     'End If
	'     'MsgBox("Jumlah qty barang " & q(i).De.Barang.Kode & " (" & q(i).jml & ") untuk nomor produksi " & q(i).De.Main.Kode & " nomor lot " & q(i).De.Main.DempyouLot & " melebihi pesanannya (" & q(i).SisaQty & ").")

	'     If q(i).SisaQty < q(i).jml Then '=> 02022020
	'       'Throw New Utils.Exception("Jumlah qty barang " & q(i).De.Barang.Kode & " (" & q(i).jml & ") untuk nomor lot " & q(i).De.Main.DempyouLot & " melebihi sisa produksi (" & q(i).SisaQty & ").", -99, "", "Simpan Transaksi")
	'       'Throw New Utils.Exception("Jumlah qty barang " & q(i).De.Barang.Kode & " (" & q(i).jml & ") untuk nomor lot : " & q(i).De.Main.DempyouLot & ", SO : " & q(i).So.Main.Kode & ", PO Line : " & q(i).So.POLine & " melebihi pesanannya (" & q(i).SisaQty & ")." & vbCrLf &
	'       '                           "Qty Pesanan : " & q(i).SisaQty & vbCrLf &
	'       '                           "Qty Sisa SO : " & q(i).jml, -99, "", "Simpan Transaksi")
	'       Throw New Utils.Exception("Qty kirim melebihi pemesanan. #" & i & vbCrLf & vbCrLf &
	'                                  "NO SO : " & q(i).So.Main.Kode & ", PO Line : " & q(i).So.POLine & vbCrLf &
	'                                  "Kode ITEM : " & q(i).De.Barang.Kode & vbCrLf &
	'                                  "NO LOT : " & q(i).De.Main.DempyouLot & vbCrLf &
	'                                  "Qty Pesanan (SO) : " & q(i).SisaQty & vbCrLf &
	'                                  "Qty Kirim : " & q(i).jml, -99, "", "Simpan Transaksi")
	'     End If
	'   Next
	'   'cek terakhir.. jika stock minus maka tidak bisa
	'   Dim zz = From z In instance.Detail
	'            Group z By Barang = z.Barang
	'            Into g = Group
	'            Select New With {
	'            .Barang = Barang,
	'            .Qty = g.Sum(Function(s) s.Qty)
	'            }

	'   For i = 0 To zz.Count - 1
	'     Dim zzStock As New XPCollection(Of Persistent.Fusoh_SuratJalanDetail)(session, New GroupOperator(GroupOperator.And, New BinaryOperator("Barang.Id", zz(i).Barang.Id, BinaryOperatorType.Equal), New BinaryOperator("Main.Id", instance.Id, BinaryOperatorType.NotEqual)))
	'     Dim pstock As Double = zzStock.Sum(Function(n) (n.QtyProduksi - n.Qty))
	'     If zz(i).Qty > pStock Then
	'       Throw New Utils.Exception("Kode item : " & zz(i).Barang.Kode & " melebihi stock yang ada di gudang.", -99, "", "Simpan Transaksi")
	'     End If
	'   Next


	'   Try
	'		'======= Simpan Main
	'		If Not txtKontak.EditValue Is Nothing Then
	'			instance.Pelanggan = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
	'		Else
	'			instance.Pelanggan = Nothing
	'		End If
	'		instance.Tanggal = txtTanggal.DateTime
	'		instance.Kode = txtNoTransaksi.Text
	'		instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
	'		instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)

	'		instance.JenisKendaraan = txtJenisKendaraan.Text
	'		instance.Supir = txtNamaDriver.Text
	'		instance.NoKendaraan = txtNoKendaraan.Text
	'		instance.Catatan = txtUraian.Text

	'		instance.Gudang = instance.Detail(0).Gudang

	'		'======= update hpp keluar
	'		For Each detail In instance.Detail
	'       detail.Harga = detail.ProduksiDetail.Harga
	'       detail.TotalHPP = detail.ProduksiDetail.Harga * detail.Qty
	'		Next

	'     '======= update status produksi
	'     'Dim produksi = instance.Detail.GroupBy(Function(g) g.ProduksiDetail.Main).Select(Function(s) s.Key)
	'     'For i = 0 To produksi.Count - 1
	'     '	Dim item = produksi(i)
	'     '	Dim xQtyProduksi As Double = item.TotalQtyProduksi
	'     '     Dim xQtySJSdh As Double = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session).Where(Function(w) w.Main.Sumber.Id = Persistent.SumberDataJenis.FD AndAlso w.ProduksiDetail.Main Is item).Sum(Function(s) s.Qty)
	'     '     Dim xQtySJBlm As Double = instance.Detail.Where(Function(w) w.ProduksiDetail.Main Is item).Sum(Function(s) s.Qty)

	'     '	If (xQtySJBlm + xQtySJSdh) < xQtyProduksi Then
	'     '		item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
	'     '	Else
	'     '		item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
	'     '	End If
	'     'Next

	'     '======= update SO
	'     '   Dim so = instance.Detail.GroupBy(Function(g) g.SODetail.Main).Select(Function(s) s.Key)
	'     'For i = 0 To so.Count - 1
	'     '	Dim item = so(i)
	'     '	Dim xQtySO As Double = item.TotalQty
	'     '	Dim xQtySJSdh As Double = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session).Where(Function(w) w.Main.Sumber.Id = Persistent.SumberDataJenis.FD AndAlso w.SODetail.Main Is item).Sum(Function(s) s.Qty)
	'     '	Dim xQtySJBlm As Double = instance.Detail.Where(Function(w) w.SODetail.Main Is item).Sum(Function(s) s.Qty)

	'     '	If (xQtySJBlm + xQtySJSdh) < xQtySO Then
	'     '		item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
	'     '	Else
	'     '		item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
	'     '	End If
	'     'Next

	'     '======= Simpan instance
	'     session.CommitChanges()
	'	Catch ex As Utils.Exception
	'		Throw New Utils.Exception(ex)
	'	Catch ex As Exception
	'		If ex.Message.Contains("Duplicate entry") Then
	'			instance.Kode = instance.Number.GetNewNumber.Kode
	'			session.CommitChanges()
	'		Else
	'			Throw New Exception(ex.Message, ex.InnerException)
	'		End If
	'	End Try

	'   Dim frm As New RF_FusohVoucher(Persistent.SumberDataJenis.FD)
	'   frm.txtNoBukti1.EditValue = instance.Kode

	'	Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
	'	Dim reportCode As String = ""
	'	reportCode = MainClass.GetReport(MainClass.reportName.zFusohVoucherSJ)
	'	message = String.Format(message, "Surat Jalan")

	'	Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, salesSetting.PreviewSave)
	'End Sub
	Overrides Sub SimpanData()
		If (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
			Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", 0, "", "Simpan Transaksi")
			Exit Sub
		End If
    ''======= Cek Periode
    If NuSoft001.Persistent.Periode.CheckLockedPeriod(session, txtTanggal.DateTime) Then
      Throw New Utils.Exception("Periode sudah ditutup." & vbCrLf & "Hubungi accounting untuk membuka periode", -4, "", "Simpan Transaksi")
      Exit Sub
    End If
    ''======= Cek Sebelum Awal Periode
    If NuSoft001.Persistent.Periode.CheckBeforeBeginningPeriod(session, txtTanggal.DateTime) Then
      Throw New Utils.Exception("Tanggal transaksi sebelum awal periode" & vbCrLf & "Hubungi accounting untuk membuka periode", -4, "", "Simpan Transaksi")
      Exit Sub
    End If



    '========== cek data kosong
    For Each det In instance.Detail
			If det.ProduksiDetail Is Nothing Then
				Throw New Utils.Exception("Masukkan produksi", -99, "", "Simpan Transaksi")
				Exit Sub
			End If
			If det.Qty <= 0 Then
				Throw New Utils.Exception("Masukkan qty kirim", -99, "", "Simpan Transaksi")
				Exit Sub
			End If
			det.Gudang = det.ProduksiDetail.Gudang
		Next

		'=========== cek sisa SO
		Dim listSO = instance.Detail.GroupBy(Function(g) g.SODetail).Select(Function(s) New With {.SODetail = s.Key, .SisaQty = s.Average(Function(a) a.SisaQty), .Qty = s.Sum(Function(k) k.Qty)})
		If txtOtomatisProduksi.Checked Then listSO = instance.Detail.GroupBy(Function(g) g.SODetail).Select(Function(s) New With {.SODetail = s.Key, .SisaQty = s.Sum(Function(a) a.SisaQty), .Qty = s.Sum(Function(k) k.Qty)})
		For Each so In listSO
			If so.Qty > so.SisaQty Then
				Throw New Utils.Exception("Qty kirim melebihi pemesanan." & vbCrLf & vbCrLf &
																	 "NO SO : " & so.SODetail.Main.Kode & ", PO Line : " & so.SODetail.POLine & vbCrLf &
																	 "Kode ITEM : " & so.SODetail.Barang.Kode & vbCrLf &
																	 "Qty Pesanan (SO) : " & so.SisaQty & vbCrLf &
																	 "Qty Kirim : " & so.Qty, -99, "", "Simpan Transaksi")
        'Exit Sub
      End If
		Next
    txtCheckStock.Text = ""
    '=========== cek sisa di produksi
    Dim listProduksi = instance.Detail.GroupBy(Function(g) g.ProduksiDetail).Select(Function(s) New With {.Produksi = s.Key, .Qty = s.Sum(Function(k) k.Qty)})
		For Each prod In listProduksi
      Dim sisaProduksi = dataProduksi.Where(Function(f) f.Id Is prod.Produksi).Sum(Function(s) s.QtySisa)
      txtCheckStock.Text = txtCheckStock.Text & "nomor produksi : " & prod.Produksi.Main.Kode & " -->QtySJ : " & prod.Qty & "> QtyProduksi" & sisaProduksi & vbCrLf
      If prod.Qty > sisaProduksi Then
				Throw New Utils.Exception("Qty kirim melebihi sisa produksi." & vbCrLf & vbCrLf &
																	 "Kode ITEM : " & prod.Produksi.Barang.Kode & vbCrLf &
																	 "No. Produksi : " & prod.Produksi.Main.Kode & vbCrLf &
																	 "Qty Sisa Produksi : " & (sisaProduksi) & vbCrLf &
																	 "Qty Kirim : " & prod.Qty, -99, "", "Simpan Transaksi")
        'Exit Sub
        'Else 'update data produksi
        '	Dim found = dataProduksi.Find(Function(f) f.Id Is prod.Produksi)
        '	If Not (found Is Nothing) Then
        '		found.QtyKirim += prod.Qty
        '	End If
      End If
		Next

		Try
			'======= Simpan Main
			If Not txtKontak.EditValue Is Nothing Then
				instance.Pelanggan = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
			Else
				instance.Pelanggan = Nothing
			End If
			instance.Tanggal = txtTanggal.DateTime
			instance.Kode = txtNoTransaksi.Text
			instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
			instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)

			instance.JenisKendaraan = txtJenisKendaraan.Text
			instance.Supir = txtNamaDriver.Text
			instance.NoKendaraan = txtNoKendaraan.Text
			instance.Catatan = txtUraian.Text

			instance.Gudang = instance.Detail(0).Gudang
			instance.SJOtomatisProduksi = txtOtomatisProduksi.Checked

			'======= update hpp keluar
			For Each detail In instance.Detail
				detail.Harga = detail.ProduksiDetail.Harga
				detail.TotalHPP = detail.ProduksiDetail.Harga * detail.Qty
			Next

      ''======= update status produksi
      'Dim produksi = instance.Detail.GroupBy(Function(g) g.ProduksiDetail.Main).Select(Function(s) s.Key)
      'For i = 0 To produksi.Count - 1
      '  Dim item = produksi(i)
      '  Dim xQtyProduksi As Double = item.TotalQtyProduksi
      '  Dim xQtySJSdh As Double = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session).Where(Function(w) w.Main.Sumber.Id = Persistent.SumberDataJenis.FD AndAlso w.ProduksiDetail.Main Is item).Sum(Function(s) s.Qty)
      '  Dim xQtySJBlm As Double = instance.Detail.Where(Function(w) w.ProduksiDetail.Main Is item).Sum(Function(s) s.Qty)

      '  If (xQtySJBlm + xQtySJSdh) < xQtyProduksi Then
      '    item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
      '  Else
      '    item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
      '  End If
      'Next

      '======= update SO
      Dim so = instance.Detail.GroupBy(Function(g) g.SODetail.Main).Select(Function(s) s.Key)
      For i = 0 To so.Count - 1
        Dim item = so(i)
        Dim xQtySO As Double = item.TotalQty
        Dim xQtySJSdh As Double = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session).Where(Function(w) w.Main.Sumber.Id = Persistent.SumberDataJenis.FD AndAlso w.SODetail.Main Is item).Sum(Function(s) s.Qty)
        Dim xQtySJBlm As Double = instance.Detail.Where(Function(w) w.SODetail.Main Is item).Sum(Function(s) s.Qty)

        If (xQtySJBlm + xQtySJSdh) < xQtySO Then
          item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
        Else
          item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
        End If
      Next

      For Each prod In listProduksi 'update data produksi
        Dim found = dataProduksi.Find(Function(f) f.Id Is prod.Produksi)
        If Not (found Is Nothing) Then
          found.QtyKirim += prod.Qty
        End If
      Next

      '======= Simpan instance
      session.CommitChanges()
		Catch ex As Utils.Exception
			Throw New Utils.Exception(ex)
		Catch ex As Exception
			If ex.Message.Contains("Duplicate entry") Then
				'instance.Kode = instance.Number.GetNewNumber.Kode
				'session.CommitChanges()
				Throw New Utils.Exception("Kode '" & instance.Kode & "' sudah pernah diinput." & vbCrLf & "Mohon masukkan kode lain.", 0)
			Else
				Throw New Exception(ex.Message, ex.InnerException)
			End If
		End Try

    '======= Simple log
    Try
      If Tipe = InputType.Tambah Then
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Pengiriman Barang [SJ] -> " & instance.Kode)
      Else
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Pengiriman Barang [SJ] -> " & instance.Kode)
      End If
      session.CommitChanges()
    Catch ex As Exception
    End Try

    Dim frm As New RF_FusohVoucher(Persistent.SumberDataJenis.FD)
		frm.txtNoBukti1.EditValue = instance.Kode

		Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
		Dim reportCode As String = ""
		reportCode = MainClass.GetReport(MainClass.reportName.zFusohVoucherSJ)
		message = String.Format(message, "Surat Jalan")

		Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, salesSetting.PreviewSave)
	End Sub

	Overrides Sub ErrorSimpan(ex As Utils.Exception)
		ex.ShowWinMessageBox()
		Select Case ex.ErrorNumber
			Case 0 : txtNoTransaksi.Focus()
			Case -1 : txtRegional.Focus()
			Case -2 : txtTanggal.Focus()
			Case -3 : txtKontak.Focus()
			Case -5 : txtNamaDriver.Focus()
			Case -6 : txtNoKendaraan.Focus()
			Case -7 : txtJenisKendaraan.Focus()
			Case -98 : txtStatus.Focus()
			Case -99 : xGrid.Focus()
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
		'txtNoTransaksi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
		'txtNoTransaksi.Properties.Mask.EditMask = nomor.Mask
		txtNoTransaksi.Text = nomor.Kode
	End Sub
	Private Sub BindingDataSource()
		If salesSetting.FilterKontak = True Then
			txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Id", salesSetting.TipeKontak, BinaryOperatorType.Equal))
		Else
			txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
		End If
		txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
		txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
	End Sub
	Private Sub SetFormat()
		colSisaQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colSisaQty.DisplayFormat.FormatString = setting.NumericFormatString
		colSisaQty.SummaryItem.DisplayFormat = setting.NumericFormatString
		colQtyPalletHidden.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colQtyPalletHidden.DisplayFormat.FormatString = setting.NumericFormatToString
		colQtyPalletHidden.SummaryItem.DisplayFormat = setting.NumericFormatString
		colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colQty.DisplayFormat.FormatString = setting.NumericFormatToString
		colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
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
		txtUraian.EditValue = salesSetting.UraianDO
	End Sub
	Private Sub SetNomor()
		instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.FD)
		'instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
		instance.Number = New Logic.NumberClass(session) With {.FormatNomor = "[S][Y2]-[X4]"}
	End Sub
	Private Sub DisableControl()
		txtKontak.Enabled = False
		txtTanggal.Enabled = False
		txtNoTransaksi.Enabled = False
		txtRegional.Enabled = False
		txtStatus.Enabled = False

		txtJenisKendaraan.Enabled = False
		txtNoKendaraan.Enabled = False
		txtNamaDriver.Enabled = False
		txtUraian.Enabled = False
		txtOtomatisProduksi.Enabled = False

		xGridView.OptionsBehavior.Editable = False
		xGridView.OptionsBehavior.ReadOnly = True
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
			''Dim dataAM = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session).Where(Function(w) w.Barang Is barang AndAlso (w.Main.Sumber.Id = Persistent.SumberDataJenis.AM OrElse w.Main.Sumber.Id = Persistent.SumberDataJenis.BS)).ToList()
			''where Barang.Customer = e.NewValue And (Main.Sumber = Persistent.SumberDataJenis.AM Or Main.Sumber = Persistent.SumberDataJenis.BS)
			'xDataProduksi = New List(Of Persistent.Fusoh_SuratJalanDetail)
			'Dim dataAM = New XPCollection(Of Persistent.Fusoh_SuratJalanDetail)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Barang.Customer.Id", CType(e.NewValue, NuSoft001.Persistent.Kontak), BinaryOperatorType.Equal)))
			'For Each am In dataAM
			'  Dim sumKeluar = am.ProduksiCollection.Sum(Function(s) s.Qty)
			'  am.SisaQty = am.QtyProduksi - sumKeluar
			'  If (am.SisaQty > 0) Then
			'    If sumKeluar = 0 Then
			'      am.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
			'      xDataProduksi.Add(am)
			'    ElseIf am.QtyProduksi > sumKeluar Then
			'      am.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
			'      xDataProduksi.Add(am)
			'    Else
			'      am.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
			'    End If
			'  End If
			'Next
		End If
		'	'lblKontakNama.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Nama
		'	'isikan data detailnya
		'	txtPhoneNumber.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Telepon
		'	txtDebitLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasPiutang)
		'	txtCreditLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasHutang)

		'	Dim xpTransaksi As New XPCollection(Of Persistent.Fusoh_SuratJalan)(session, New BinaryOperator("Pelanggan", CType(e.NewValue, NuSoft001.Persistent.Kontak), BinaryOperatorType.Equal))
		'	xGHistory.DataSource = xpTransaksi

		'	If Tipe = InputType.Tambah Then
		'		For i = instance.Detail.Count - 1 To 0 Step -1
		'			instance.Detail(i).Delete()
		'		Next

		'		Dim blmProses = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session) _
		'		.Where(Function(w) w.Main.Sumber.Id = Persistent.SumberDataJenis.AM AndAlso w.Main.Pelanggan Is e.NewValue AndAlso
		'		(w.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting OrElse
		'		w.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress) AndAlso w.QtyProduksi > 0).ToList

		'		For i = 0 To blmProses.Count - 1
		'			Dim item = New Persistent.Fusoh_SuratJalanDetail(session)
		'			item.Main = instance
		'			item.ProduksiDetail = blmProses(i)
		'			item.Barang = item.ProduksiDetail.Barang
		'			item.GrossWeight = item.ProduksiDetail.Weight + salesSetting.FusohBeratPallet
		'			item.Gudang = item.ProduksiDetail.Gudang
		'			item.InDiameter = item.ProduksiDetail.InDiameter
		'			item.OutDiameter = item.ProduksiDetail.OutDiameter
		'			item.Thickness = item.ProduksiDetail.Thickness
		'			item.Length = item.ProduksiDetail.Length
		'			item.Weight = item.ProduksiDetail.Weight
		'			item.Qty = item.ProduksiDetail.QtyProduksi
		'			item.Satuan = item.Barang.SatuanD
		'			item.SODetail = session.GetObjectByKey(Of Persistent.Fusoh_OrderPenjualanDetail)(item.ProduksiDetail.Main.OrderProduksi.SODetail.Id)
		'			instance.Detail.Add(item)
		'		Next
		'	End If
		'End If
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
					ChangeCode()
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
	Private Sub Me_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
		isShown = True
	End Sub
	Protected Overrides Sub OnKeyDown(e As System.Windows.Forms.KeyEventArgs)
		'MyBase.OnKeyDown(e)
		'If e.Control AndAlso e.Shift Then
		'	xGrid.Focus()
		'End If
	End Sub
	Private Sub btnRefreshNomor_Click(sender As Object, e As EventArgs) Handles btnRefreshNomor.Click
		ChangeCode()
	End Sub
	Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
		BindingDataSource()
	End Sub

	Private Sub colCommandRepo_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles colCommandRepo.ButtonClick
		Dim row = CType(xGridView.GetFocusedRow, Persistent.Fusoh_SuratJalanDetail)
		If e.Button.Kind = ButtonPredefines.Plus Then
			Dim item = New Persistent.Fusoh_SuratJalanDetail(session)
			item.Main = instance
			item.ProduksiDetail = row.ProduksiDetail
			item.Barang = row.Barang
			item.Gudang = row.Gudang
			item.InDiameter = row.InDiameter
			item.OutDiameter = row.OutDiameter
			item.Thickness = row.Thickness
			item.Length = row.Length
			item.Satuan = row.Satuan
			item.SODetail = row.SODetail
			item.SisaQty = row.SisaQty '= 02022020
			instance.Detail.Add(item)

			Dim xx = instance.Detail.Where(Function(f) f.ProduksiDetail Is row.ProduksiDetail And f.SODetail Is row.SODetail)
			'Dim eachQty = row.ProduksiDetail.QtyProduksi / xx.Count
			Dim eachQty = CInt(Math.Round(row.SisaQty / xx.Count, 0, MidpointRounding.AwayFromZero)) '= 02022020
			Dim runningSum = 0
			Dim i = 1
			For Each det In xx
				If (i = xx.Count) Then
					det.Qty = row.SisaQty - runningSum
				Else
					det.Qty = eachQty
				End If
				det.Weight = NuSoft004.FusohLogic.Item.GetWeight(det.OutDiameter, det.Length, det.Thickness) * det.Qty
				det.GrossWeight = det.Weight + salesSetting.FusohBeratPallet
				runningSum += eachQty
				i += 1
			Next
		ElseIf e.Button.Kind = ButtonPredefines.Minus Then
			'Dim jmlRow = instance.Detail.Where(Function(f) f.ProduksiDetail Is row.ProduksiDetail).Count
			'If jmlRow > 1 Then
			row.Delete()
			instance.Detail.Remove(row)
			'End If
		ElseIf e.Button.Kind = ButtonPredefines.Ellipsis Then 'Fungsi ganti PO LINE
			Dim frm As New UI_FusohSJDialogSODetail
			Dim pQtySisa As Double = 0, pQtySisaPOLineLama As Double = 0
			frm.xBarang = row.Barang
			frm.session = session
			frm.EditedSJ = row
			If (frm.ShowDialog = DialogResult.OK) Then
				Dim selected = frm.Result
				For i = 0 To selected.Count - 1
					pQtySisaPOLineLama = 0
					Dim xyz = selected(i)
					Dim q = instance.Detail.ToList.Where(Function(f) f.SODetail Is xyz).Select(Function(s) New With {.SisaQty = s.SisaQty}).ToList
					If q.Count > 0 Then
						pQtySisaPOLineLama = q(0).SisaQty
					End If
					pQtySisa = row.Qty + pQtySisaPOLineLama

					Dim datax = instance.Detail.Where(Function(w) w.SODetail Is xyz) 'update juga untuk QTYSisa PO Line baris lainnya
					For Each x In datax
						x.SisaQty = pQtySisa
					Next

					row.SODetail = selected(i)
					row.SisaQty = pQtySisa 'tambahkan untuk QTY Sisa Ne, untuk ke PO Line terpilih
				Next
				xGridView.RefreshData()
			End If
		End If
	End Sub

	Private Sub xGridView_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles xGridView.CellValueChanging
		'If e.Column Is colQtyPalletHidden Then
		'	Dim row = CType(xGridView.GetRow(e.RowHandle), Persistent.Fusoh_SuratJalanDetail)
		'	row.Weight = NuSoft004.FusohLogic.Item.GetWeight(row.OutDiameter, row.Length, row.Thickness) * CInt(e.Value)
		'	row.GrossWeight = row.Weight + salesSetting.FusohBeratPallet
		'End If
		If e.Column Is colQty Then
			Dim row = CType(xGridView.GetRow(e.RowHandle), Persistent.Fusoh_SuratJalanDetail)
			row.Weight = NuSoft004.FusohLogic.Item.GetWeight(row.OutDiameter, row.Length, row.Thickness) * CInt(e.Value)
			row.GrossWeight = row.Weight + salesSetting.FusohBeratPallet
		End If
	End Sub
	Private Sub xGridView_ShownEditor(sender As Object, e As EventArgs) Handles xGridView.ShownEditor
		'If (xGridView.FocusedColumn Is colQtyPalletHidden AndAlso xGridView.ActiveEditor.GetType Is GetType(SpinEdit)) Then
		'	Dim edit As SpinEdit = CType(xGridView.ActiveEditor, SpinEdit)
		'	Dim item As Persistent.Fusoh_SuratJalanDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.Fusoh_SuratJalanDetail)

		'	'edit.Properties.MaxValue = item.ProduksiDetail.QtyProduksi
		'	edit.Properties.MaxValue = item.SisaQty
		'End If
		If (xGridView.FocusedColumn Is colQty AndAlso xGridView.ActiveEditor.GetType Is GetType(SpinEdit)) Then
			Dim edit As SpinEdit = CType(xGridView.ActiveEditor, SpinEdit)
			Dim item As Persistent.Fusoh_SuratJalanDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.Fusoh_SuratJalanDetail)
			edit.Properties.MaxValue = item.SisaQty
		ElseIf (xGridView.FocusedColumn Is colProduksi AndAlso xGridView.ActiveEditor.GetType Is GetType(SearchLookUpEdit)) Then
			Dim edit As SearchLookUpEdit = CType(xGridView.ActiveEditor, SearchLookUpEdit)
			Dim item As Persistent.Fusoh_SuratJalanDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.Fusoh_SuratJalanDetail)

			edit.Properties.DataSource = dataProduksi.Where(Function(w) w.KodeItem = item.Barang.Kode AndAlso w.QtySisa > 0).ToList
		End If
	End Sub

	Private Sub txtOtomatisProduksi_CheckedChanged(sender As Object, e As EventArgs) Handles txtOtomatisProduksi.CheckedChanged
		'delete detail yg new
		For i = instance.Detail.Count - 1 To 0 Step -1
			If (session.IsNewObject(instance.Detail(i))) Then
				instance.Detail(i).Delete()
			End If
		Next

		If txtOtomatisProduksi.Checked Then
			btnAmbilDataSO.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
			btnAmbilDataSO2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
			colProduksi.OptionsColumn.AllowEdit = False
		Else
			btnAmbilDataSO.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
			btnAmbilDataSO2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
			colProduksi.OptionsColumn.AllowEdit = True
		End If
	End Sub

	' Private Sub btnAmbilDataSO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAmbilDataSO.ItemClick
	'	If txtKontak.EditValue Is Nothing Then
	'		XtraMessageBox.Show("Pilih customer terlebih dahulu.", "SJ", MessageBoxButtons.OK, MessageBoxIcon.Information)
	'		Exit Sub
	'	End If

	'	Dim frm As New UI_FusohSJDialogSO
	'	frm.Customer = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
	'	frm.session = session
	'	If (frm.ShowDialog = DialogResult.OK) Then
	'		'==== recheck status AM
	'		Dim listProduksi = New List(Of Persistent.Fusoh_SuratJalanDetail)
	'		'Dim dataBarang As New List(Of NuSoft004.Persistent.Fusoh_Barang)
	'		Dim dataBarang = frm.Result.SelectMany(Function(m) m.Detail).GroupBy(Function(g) g.Barang).Select(Function(s) s.Key).ToList
	'     'Dim dataBarang = frm.Result.SelectMany(Function(m) m.Detail).Where(Function(wh) wh.Barang.Kode = "7071112C90M1").GroupBy(Function(g) g.Barang).Select(Function(s) s.Key).ToList
	'     'For Each so In frm.Result
	'     '	For Each detail In so.Detail
	'     '		Dim barang = dataBarang.Find(Function(f) f Is detail.Barang)
	'     '		If barang Is Nothing Then
	'     '			dataBarang.Add(detail.Barang)
	'     '		End If
	'     '	Next
	'     'Next

	'     'MsgBox("Jml Barang ==> " & dataBarang.Count)
	'     For Each barang In dataBarang
	'       'cari AM sesuai data Barang
	'       Dim dataAM = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session).Where(Function(w) w.Barang Is barang AndAlso (w.Main.Sumber.Id = Persistent.SumberDataJenis.AM OrElse w.Main.Sumber.Id = Persistent.SumberDataJenis.BS)).ToList()
	'       'MsgBox("Jml AM ==> " & barang.Kode & " == " & dataAM.Count)
	'       For Each am In dataAM
	'				'cari data keluar/SJ nya
	'				'Dim sj = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session).Where(Function(w) w.ProduksiDetail Is am).ToList()
	'				Dim sumKeluar = am.ProduksiCollection.Sum(Function(s) s.Qty)
	'				am.SisaQty = am.QtyProduksi - sumKeluar
	'				'MsgBox("Sisa Qty ==> " & am.SisaQty & " <==> " & am.Main.Kode & " -- " & am.QtyProduksi & "-" & sumKeluar)
	'				If (am.SisaQty > 0) Then
	'					If sumKeluar = 0 Then
	'						am.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
	'						'MsgBox("Posting ==> " & am.SisaQty)
	'						listProduksi.Add(am)
	'					ElseIf am.QtyProduksi > sumKeluar Then
	'						am.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
	'						'MsgBox("InProgress ==> " & am.SisaQty)
	'						listProduksi.Add(am)
	'					Else
	'						'MsgBox("Finish ==> " & am.SisaQty)
	'						am.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
	'					End If
	'				End If
	'			Next
	'		Next

	'		'Dim listProduksi = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session).Where(Function(m) _
	'		'					(m.Main.Sumber.Id = Persistent.SumberDataJenis.AM OrElse m.Main.Sumber.Id = Persistent.SumberDataJenis.BS) AndAlso
	'		'					(m.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting OrElse
	'		'					 m.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress)).ToList()

	'		Dim selected = frm.Result
	'		For i = 0 To selected.Count - 1
	'			For j = 0 To selected(i).Detail.Count - 1
	'				Dim soDetail = selected(i).Detail(j)
	'				' cari nomor produksi pertama sesuai item + sisa produksi yang belum dikirim
	'				Dim list = listProduksi.Where(Function(m) m.Barang Is soDetail.Barang).OrderBy(Function(n) n.Id).ToList()
	'         Dim qtySO = soDetail.Qty - soDetail.QtyKirim
	'         'MsgBox("Jumlah ==> " & list.Count)
	'         For Each x In list
	'           'Dim pemakaianSebelumnya = instance.Detail.Where(Function(w) w.ProduksiDetail Is x)
	'           Dim sisaQtyAM = x.SisaQty ' - pemakaianSebelumnya.Sum(Function(s) s.Qty)
	'           'Dim pemakaian = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session).Where(Function(m) m.ProduksiDetail Is x).Sum(Function(s) s.Qty)
	'           'Dim sisa = x.QtyProduksi - pemakaian
	'           'MsgBox("QTY SO ==> " & qtySO & " ;SisaQty => " & sisaQtyAM & "/" & x.SisaQty & "; Kode Produksi = " & x.Main.Kode & "; Barang = " & soDetail.Barang.Kode)
	'           If (sisaQtyAM > 0) Then ' sisa > 0) Then
	'						If qtySO > sisaQtyAM Then ' jika sisa produksi lebih sedikit dari SO
	'							Dim item = New Persistent.Fusoh_SuratJalanDetail(session)
	'							item.Main = instance
	'							item.SODetail = selected(i).Detail(j)
	'							item.ProduksiDetail = x
	'							item.Barang = item.ProduksiDetail.Barang
	'							item.GrossWeight = item.ProduksiDetail.Weight + salesSetting.FusohBeratPallet
	'							item.Gudang = item.ProduksiDetail.Gudang
	'							item.InDiameter = item.ProduksiDetail.InDiameter
	'							item.OutDiameter = item.ProduksiDetail.OutDiameter
	'							item.Thickness = item.ProduksiDetail.Thickness
	'							item.Length = item.ProduksiDetail.Length
	'							item.Weight = item.ProduksiDetail.Weight
	'							item.Satuan = item.Barang.SatuanD
	'							item.Qty = sisaQtyAM
	'							item.SisaQty = sisaQtyAM
	'							instance.Detail.Add(item)
	'							qtySO -= sisaQtyAM

	'							'MsgBox("1 ==> " & item.Main.Kode)
	'						Else 'jika sisa produksi lebih besar dari SO
	'							Dim item = New Persistent.Fusoh_SuratJalanDetail(session)
	'							item.Main = instance
	'							item.SODetail = selected(i).Detail(j)
	'							item.ProduksiDetail = x
	'							item.Barang = item.ProduksiDetail.Barang
	'							item.GrossWeight = item.ProduksiDetail.Weight + salesSetting.FusohBeratPallet
	'							item.Gudang = item.ProduksiDetail.Gudang
	'							item.InDiameter = item.ProduksiDetail.InDiameter
	'							item.OutDiameter = item.ProduksiDetail.OutDiameter
	'							item.Thickness = item.ProduksiDetail.Thickness
	'							item.Length = item.ProduksiDetail.Length
	'							item.Weight = item.ProduksiDetail.Weight
	'							item.Satuan = item.Barang.SatuanD
	'							item.Qty = qtySO
	'							item.SisaQty = qtySO
	'							instance.Detail.Add(item)
	'							qtySO -= qtySO

	'							'MsgBox("2 ==> " & item.Main.Kode)
	'						End If
	'						If qtySO = 0 Then
	'							Exit For
	'						End If
	'					End If
	'				Next
	'			Next
	'		Next
	'	End If
	'End Sub
	'Private Sub btnAmbilDataSO2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAmbilDataSO2.ItemClick
	'	If txtKontak.EditValue Is Nothing Then
	'		XtraMessageBox.Show("Pilih customer terlebih dahulu.", "SJ", MessageBoxButtons.OK, MessageBoxIcon.Information)
	'		Exit Sub
	'	End If

	'	Dim frm As New UI_FusohSJDialogSODetail2
	'	frm.Customer = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
	'	frm.session = session
	'	If (frm.ShowDialog = DialogResult.OK) Then
	'		Dim dataSO As List(Of Persistent.Fusoh_OrderPenjualanDetail) = frm.Result

	'		'Dim listProduksi = New List(Of Persistent.Fusoh_SuratJalanDetail)
	'		'Dim dataBarang = dataSO.GroupBy(Function(g) g.Barang).Select(Function(s) s.Key).ToList
	'		'For Each barang In dataBarang
	'		'	'cari AM sesuai data Barang
	'		'	Dim dataAM = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session).Where(Function(w) w.Barang Is barang AndAlso (w.Main.Sumber.Id = Persistent.SumberDataJenis.AM OrElse w.Main.Sumber.Id = Persistent.SumberDataJenis.BS OrElse w.Main.Sumber.Id = Persistent.SumberDataJenis.TS)).ToList()
	'		'	'MsgBox("Jml AM ==> " & barang.Kode & " == " & dataAM.Count)
	'		'	For Each am In dataAM
	'		'		'cari data keluar/SJ nya
	'		'		'Dim sj = New XPQuery(Of Persistent.Fusoh_SuratJalanDetail)(session).Where(Function(w) w.ProduksiDetail Is am).ToList()
	'		'		Dim sumKeluar = am.ProduksiCollection.Sum(Function(s) s.Qty)
	'		'		am.SisaQty = am.QtyProduksi - sumKeluar
	'		'		'MsgBox("Sisa Qty ==> " & am.SisaQty & " <==> " & am.Main.Kode & " -- " & am.QtyProduksi & "-" & sumKeluar)
	'		'		If (am.SisaQty > 0) Then
	'		'			If sumKeluar = 0 Then
	'		'				am.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
	'		'				'MsgBox("Posting ==> " & am.SisaQty)
	'		'				listProduksi.Add(am)
	'		'			ElseIf am.QtyProduksi > sumKeluar Then
	'		'				am.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
	'		'				'MsgBox("InProgress ==> " & am.SisaQty)
	'		'				listProduksi.Add(am)
	'		'			Else
	'		'				'MsgBox("Finish ==> " & am.SisaQty)
	'		'				am.Main.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
	'		'			End If
	'		'		End If
	'		'	Next
	'		'Next

	'		For j = 0 To dataSO.Count - 1
	'			Dim soDetail = dataSO(j)
	'			' cari nomor produksi pertama sesuai item + sisa produksi yang belum dikirim
	'			Dim list = xDataProduksi.Where(Function(m) m.Barang Is soDetail.Barang).OrderBy(Function(n) n.Id).ToList()
	'			Dim qtySO = soDetail.QtySisa
	'			For Each x In list
	'				Dim sisaQtyAM = x.SisaQty ' - pemakaianSebelumnya.Sum(Function(s) s.Qty)
	'				MsgBox("QTY SO ==> " & qtySO & " ;SisaQty => " & sisaQtyAM & "/" & x.SisaQty & "; Kode Produksi = " & x.Main.Kode & "; Barang = " & soDetail.Barang.Kode)
	'				If (sisaQtyAM > 0) Then ' sisa > 0) Then
	'					If qtySO > sisaQtyAM Then ' jika sisa produksi lebih sedikit dari SO
	'						Dim item = New Persistent.Fusoh_SuratJalanDetail(session)
	'						item.Main = instance
	'						item.SODetail = soDetail
	'						item.ProduksiDetail = x
	'						item.Barang = item.ProduksiDetail.Barang
	'						item.GrossWeight = item.ProduksiDetail.Weight + salesSetting.FusohBeratPallet
	'						item.Gudang = item.ProduksiDetail.Gudang
	'						item.InDiameter = item.ProduksiDetail.InDiameter
	'						item.OutDiameter = item.ProduksiDetail.OutDiameter
	'						item.Thickness = item.ProduksiDetail.Thickness
	'						item.Length = item.ProduksiDetail.Length
	'						item.Weight = item.ProduksiDetail.Weight
	'						item.Satuan = item.Barang.SatuanD
	'						item.Qty = sisaQtyAM
	'						item.SisaQty = sisaQtyAM
	'						instance.Detail.Add(item)
	'						qtySO -= sisaQtyAM
	'					Else 'jika sisa produksi lebih besar dari SO
	'						Dim item = New Persistent.Fusoh_SuratJalanDetail(session)
	'						item.Main = instance
	'						item.SODetail = soDetail
	'						item.ProduksiDetail = x
	'						item.Barang = item.ProduksiDetail.Barang
	'						item.GrossWeight = item.ProduksiDetail.Weight + salesSetting.FusohBeratPallet
	'						item.Gudang = item.ProduksiDetail.Gudang
	'						item.InDiameter = item.ProduksiDetail.InDiameter
	'						item.OutDiameter = item.ProduksiDetail.OutDiameter
	'						item.Thickness = item.ProduksiDetail.Thickness
	'						item.Length = item.ProduksiDetail.Length
	'						item.Weight = item.ProduksiDetail.Weight
	'						item.Satuan = item.Barang.SatuanD
	'						item.Qty = qtySO
	'						item.SisaQty = qtySO
	'						instance.Detail.Add(item)
	'						qtySO -= qtySO
	'					End If
	'					If qtySO = 0 Then
	'						Exit For
	'					End If
	'				End If
	'			Next
	'		Next
	'	End If
	'End Sub
	Private Sub btnAmbilDataSO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAmbilDataSO.ItemClick
		If txtKontak.EditValue Is Nothing Then
			XtraMessageBox.Show("Pilih customer terlebih dahulu.", "SJ", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Exit Sub
		End If

		Dim frm As New UI_FusohSJDialogSODetail2
		frm.Customer = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
		frm.session = session
		If (frm.ShowDialog = DialogResult.OK) Then
			Dim dataSO As List(Of Persistent.Fusoh_OrderPenjualanDetail) = frm.Result

			'load sisa produksi yg dibutuhkan
			Dim listBarang = dataSO.Select(Function(s) s.Barang.Kode).ToList
			listBarang.AddRange(instance.Detail.Select(Function(s) s.Barang.Kode))
			LoadDataProduksi(listBarang, False)
			'MsgBox(dataProduksi.Count)

			For j = 0 To dataSO.Count - 1
				Dim soDetail = dataSO(j)
				' cari nomor produksi pertama sesuai item + sisa produksi yang belum dikirim
				Dim list = dataProduksi.Where(Function(m) m.KodeItem = soDetail.Barang.Kode).OrderBy(Function(n) n.Id).ToList()
				'MsgBox("list = " & list.Count)
				Dim qtySO = soDetail.QtySisa
				For Each x In list
					Dim sisaQtyAM = x.QtySisa
					'MsgBox("QTY SO ==> " & qtySO & " ;SisaQty => " & sisaQtyAM & "/" & x.QtySisa & "; Kode Produksi = " & x.Kode & "; Barang = " & soDetail.Barang.Kode)
					If (sisaQtyAM > 0) Then
						If qtySO > sisaQtyAM Then ' jika sisa produksi lebih sedikit dari SO
							Dim item = New Persistent.Fusoh_SuratJalanDetail(session)
							item.Main = instance
							item.SODetail = soDetail
							item.ProduksiDetail = x.Id
							item.Barang = item.ProduksiDetail.Barang
							item.GrossWeight = item.ProduksiDetail.Weight + salesSetting.FusohBeratPallet
							item.Gudang = item.ProduksiDetail.Gudang
							item.InDiameter = item.ProduksiDetail.InDiameter
							item.OutDiameter = item.ProduksiDetail.OutDiameter
							item.Thickness = item.ProduksiDetail.Thickness
							item.Length = item.ProduksiDetail.Length
							item.Weight = item.ProduksiDetail.Weight
							item.Satuan = item.Barang.SatuanD
							item.Qty = sisaQtyAM
							item.SisaQty = sisaQtyAM
							instance.Detail.Add(item)
							qtySO -= sisaQtyAM
						Else 'jika sisa produksi lebih besar dari SO
							Dim item = New Persistent.Fusoh_SuratJalanDetail(session)
							item.Main = instance
							item.SODetail = soDetail
							item.ProduksiDetail = x.Id
							item.Barang = item.ProduksiDetail.Barang
							item.GrossWeight = item.ProduksiDetail.Weight + salesSetting.FusohBeratPallet
							item.Gudang = item.ProduksiDetail.Gudang
							item.InDiameter = item.ProduksiDetail.InDiameter
							item.OutDiameter = item.ProduksiDetail.OutDiameter
							item.Thickness = item.ProduksiDetail.Thickness
							item.Length = item.ProduksiDetail.Length
							item.Weight = item.ProduksiDetail.Weight
							item.Satuan = item.Barang.SatuanD
							item.Qty = qtySO
							item.SisaQty = qtySO
							instance.Detail.Add(item)
							qtySO -= qtySO
						End If
						If qtySO = 0 Then
							Exit For
						End If
					End If
				Next
			Next
		End If
	End Sub
	Private Sub btnAmbilDataSO2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAmbilDataSO2.ItemClick
		If txtKontak.EditValue Is Nothing Then
			XtraMessageBox.Show("Pilih customer terlebih dahulu.", "SJ", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Exit Sub
		End If

		Dim frm As New UI_FusohSJDialogSODetail2
		frm.Customer = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
		frm.session = session
		If (frm.ShowDialog = DialogResult.OK) Then
			Dim dataSO As List(Of Persistent.Fusoh_OrderPenjualanDetail) = frm.Result

			'load sisa produksi yg dibutuhkan
			Dim listBarang = dataSO.Select(Function(s) s.Barang.Kode).ToList
			listBarang.AddRange(instance.Detail.Select(Function(s) s.Barang.Kode))
			LoadDataProduksi(listBarang, False)

			'load data SO
			For Each so In dataSO
				Dim item = New Persistent.Fusoh_SuratJalanDetail(session)
				item.Main = instance
				item.SODetail = so
				item.Barang = item.SODetail.Barang
				item.Satuan = item.Barang.SatuanD
				item.InDiameter = item.SODetail.InDiameter
				item.OutDiameter = item.SODetail.OutDiameter
				item.Thickness = item.SODetail.Thickness
				item.Length = item.SODetail.Length
				item.SisaQty = GetSisaQtySO(so) 'Sisa SO yang belum dikirim

				item.ProduksiDetail = Nothing
				item.Gudang = Nothing
				item.Qty = item.SisaQty
				item.EximDetail = Nothing

				item.Weight = NuSoft004.FusohLogic.Item.GetWeight(item.OutDiameter, item.Length, item.Thickness) * CInt(item.Qty)
				item.GrossWeight = item.Weight + salesSetting.FusohBeratPallet
				instance.Detail.Add(item)
			Next
		End If
	End Sub

	Private Function GetSisaQtySO(SODetail As Persistent.Fusoh_OrderPenjualanDetail) As Double
		Dim qtyJikaEdit As Double = 0
		If Not editedSJ Is Nothing Then qtyJikaEdit = editedSJ.Where(Function(f) f.SODetail Is SODetail).Sum(Function(s) s.Qty)
		Return SODetail.QtySisa + qtyJikaEdit
	End Function
	Private Sub LoadDataProduksi(listBarang As List(Of String), loadEdited As Boolean)
		dataProduksi = New XPQuery(Of Persistent.FusohVwProduksi)(session).Where(Function(w) listBarang.Contains(w.KodeItem)).ToList
		colProduksiRepo.DataSource = dataProduksi
		If Not editedSJ Is Nothing AndAlso loadEdited Then
			Dim editedProduksi = editedSJ.GroupBy(Function(g) g.ProduksiDetail).Select(Function(x) New With {.ProduksiDetail = x.Key, .QtyKirim = x.Sum(Function(s) s.Qty)})
			For Each item In editedProduksi
				Dim found = dataProduksi.Find(Function(f) f.Id Is item.ProduksiDetail)
				If Not found Is Nothing Then
					found.QtyKirim -= item.QtyKirim
				End If
			Next
		End If
	End Sub
End Class