Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls

Friend Class UI_FusohOrderPembelianDialogRevisiLength
  Private _dataSource As List(Of NonPersistent.Fusoh_PORevisiLength)
  Private _data As Persistent.Fusoh_OrderPembelian

  Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		AutoCloseOnSave = True
	End Sub
  Sub LoadingData(data As Persistent.Fusoh_OrderPembelian)
    _data = data
    txtNoPO.Text = data.Kode
    txtTanggalPO.Text = data.Tanggal.ToString("dd MMMM yyyy")
    txtGudang.Text = data.Gudang.Nama
    txtVendor.Text = data.Vendor.Kode & " - " & data.Vendor.Nama
    _dataSource = GetPORevisiLengthData(data)
    xGrid.DataSource = _dataSource

    Try
      Fusoh_Logic.Periode.CekTanggalLocked(session, _data.Tanggal)
    Catch ex As Exception
      xGridView.OptionsBehavior.ReadOnly = True
      btn1.Enabled = False
    End Try
  End Sub

  Private Function GetPORevisiLengthData(po As Persistent.Fusoh_OrderPembelian) As List(Of NonPersistent.Fusoh_PORevisiLength)
		Dim result As New List(Of NonPersistent.Fusoh_PORevisiLength)
		For Each item In po.Detail
			Dim newRevisi = New NonPersistent.Fusoh_PORevisiLength
			newRevisi.PODetail = item
			'get exim
			newRevisi.EximDetail = session.FindObject(Of Persistent.Fusoh_EximDetail)(New BinaryOperator(NameOf(Persistent.Fusoh_EximDetail.PODetail), item, BinaryOperatorType.Equal))
			'get grn
			newRevisi.GRDetail = session.FindObject(Of Persistent.Fusoh_PenerimaanBarangDetail)(New BinaryOperator(NameOf(Persistent.Fusoh_PenerimaanBarangDetail.EximDetail), newRevisi.EximDetail, BinaryOperatorType.Equal))
			If Not newRevisi.GRDetail Is Nothing Then
				'get dempyou
				Dim listSerial = newRevisi.GRDetail.DetailSerial.Select(Function(x) x.Serial).ToList
				newRevisi.Dempyou = New XPQuery(Of Persistent.Fusoh_OrderProduksiBahanBaku)(session).Where(Function(x) x.Barang Is item.Barang AndAlso listSerial.Contains(x.Serial)).GroupBy(Function(x) x.Main).Select(Function(x) x.Key).ToList
				'get produksi
				Dim settingWIP As New NuSoft004.FusohLogic.FusohWIPSetting(session)
				Dim produksi = New XPQuery(Of Persistent.Fusoh_PenerimaanBarang)(session).Where(Function(x) newRevisi.Dempyou.Contains(x.OrderProduksi) AndAlso x.Sumber.Id = Persistent.SumberDataJenis.AM AndAlso x.Tanggal < settingWIP.TanggalMulaiWIP).ToList
				Dim wip = New XPQuery(Of Persistent.Fusoh_PenerimaanBarang)(session).Where(Function(x) newRevisi.Dempyou.Contains(x.OrderProduksi) AndAlso x.Sumber.Id = Persistent.SumberDataJenis.CW AndAlso x.Tanggal >= settingWIP.TanggalMulaiWIP).ToList
				newRevisi.Produksi = produksi
				newRevisi.Produksi.AddRange(wip)
			End If

			result.Add(newRevisi)
		Next

		Return result
	End Function
	Private Sub btnEditRepo_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btnEditRepo.ButtonClick
		If e.Button.Kind = ButtonPredefines.Ellipsis Then
			Dim msg As String = ""
			Dim row = CType(xGridView.GetFocusedRow, NonPersistent.Fusoh_PORevisiLength)
			If xGridView.FocusedColumn Is colDempyou Then
				msg = "Kode Dempyou : "
				For Each item In row.Dempyou
					msg &= vbCrLf & item.Kode
				Next
			ElseIf xGridView.FocusedColumn Is colProduksi Then
				msg = "Kode WIP / Produksi : "
				For Each item In row.Produksi
					msg &= vbCrLf & item.Kode
				Next
			End If

			Dim frm As New UI_FusohMessage
			frm.txtMessage.Text = msg
			frm.ShowDialog()
		End If
	End Sub

	Public Overrides Sub Btn1Click()
    Try
      Fusoh_Logic.Periode.CekTanggalLocked(session, _data.Tanggal)
    Catch ex As Exception
      Throw New Utils.Exception(ex.Message, -4, "", "Simpan Transaksi")
    End Try

    Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
      Try
        splashManager.ShowWaitForm()
        For Each item In _dataSource
          If item.LengthBaru <= 0 Then Continue For

          splashManager.SetWaitFormCaption("Revisi Length " & item.PODetail.Barang.Kode)
          splashManager.SetWaitFormDescription("Revisi PO Detail ...")

          Dim z As New Persistent.Fusoh_OrderPembelianDetailRevisiLength(session)
          z.PODetail = item.PODetail
          z.LengthLama = item.PODetail.Length
          z.LengthBaru = item.LengthBaru
          z.Keterangan = item.Keterangan

          item.PODetail.Length = item.LengthBaru
          Dim weightLama = item.PODetail.Weight
          item.PODetail.Weight = NuSoft004.FusohLogic.Item.GetWeight(item.PODetail.OutDiameter, item.PODetail.Length, item.PODetail.Thickness) * item.PODetail.Qty
          If item.PODetail.WeightManual = Nothing OrElse item.PODetail.WeightManual = 0 OrElse item.PODetail.WeightManual = weightLama Then
            item.PODetail.WeightManual = item.PODetail.Weight
            '==== change harga per kg
            item.PODetail.HargaPerKg = item.PODetail.Harga / (item.PODetail.WeightManual / item.PODetail.Qty)
          End If

          splashManager.SetWaitFormDescription("Revisi Exim Detail ...")
          If Not item.EximDetail Is Nothing Then
            item.EximDetail.Length = item.PODetail.Length
            item.EximDetail.Weight = item.PODetail.Weight
            item.EximDetail.Detail.ToList.ForEach(Sub(x) x.LengthIn = item.PODetail.Length)
          End If

          splashManager.SetWaitFormDescription("Revisi GR Detail ...")
          If Not item.GRDetail Is Nothing Then
            item.GRDetail.Length = item.PODetail.Length
            item.GRDetail.Weight = item.PODetail.Weight
            item.GRDetail.WeightR = item.PODetail.Weight
            item.GRDetail.DetailSerial.ToList.ForEach(Sub(x) x.LengthIn = item.PODetail.Length)
          End If

          splashManager.SetWaitFormDescription("Reset pemakaian serial ...")
          Dim listSerial = item.GRDetail.DetailSerial.Select(Function(x) x.Serial).ToList
          Dim serialProduksiLama = New XPQuery(Of Persistent.Fusoh_PenerimaanBarangDetailSerial)(session).Where(Function(x) x.DetailMain.Barang Is item.PODetail.Barang AndAlso listSerial.Contains(x.Serial) AndAlso x.LengthOut <> 0).ToList
          session.Delete(serialProduksiLama)
          Dim daftarSerialTersedia = item.GRDetail.DetailSerial.ToList.Select(Function(d) New NuSoft004.NonPersistent.Fusoh_DataSerial _
                    With {
                      .Id = d.Id,
                      .LengthIn = d.LengthIn,
                      .LengthOut = 0,
                      .MillSheet = d.MillSheet,
                      .Serial = d.Serial,
                      .Barang = d.DetailMain.Barang,
                      .Weight = d.DetailMain.Weight / d.DetailMain.Qty,
                      .Qty = 0,
                      .TanggalDatang = d.DetailMain.Main.Tanggal
                    }).ToList

          splashManager.SetWaitFormDescription("Revisi Dempyou ...")
          For Each dempyou In item.Dempyou
            'check RM dibutuhkan
            Dim rmDibutuhkan As Double = 0
            Dim cuttingDibutuhkan As Double = dempyou.Cutting
            Dim lebarMataPisau As Double = 3
            If (dempyou.NoCutting) Then lebarMataPisau = 0
            cuttingDibutuhkan += lebarMataPisau
            rmDibutuhkan = cuttingDibutuhkan * dempyou.Qty

            'otomatis pilih serial sesuai dengan length dan rm dibutuhkan
            Dim serialTerpilih As New List(Of NuSoft004.NonPersistent.Fusoh_DataSerial)
            Dim serialTersedia = daftarSerialTersedia.Where(Function(w) w.SisaLength > 0).OrderBy(Function(o) o.Serial).OrderBy(Function(o) o.TanggalDatang).ToList
            For i = 0 To serialTersedia.Count - 1
              Dim selected = serialTersedia(i)
              If selected.SisaLength >= cuttingDibutuhkan Then
                Dim jumlahPotong = CInt(selected.SisaLength / cuttingDibutuhkan)
                selected.OtomatisLength = jumlahPotong * cuttingDibutuhkan
                If rmDibutuhkan >= selected.OtomatisLength Then
                  If selected.OtomatisLength > selected.SisaLength Then
                    selected.OtomatisLength -= cuttingDibutuhkan
                  End If
                  rmDibutuhkan -= selected.OtomatisLength
                Else
                  selected.OtomatisLength = rmDibutuhkan
                  rmDibutuhkan = 0
                End If
                serialTerpilih.Add(selected)
              End If

              If rmDibutuhkan <= 0 Then
                Exit For
              End If
            Next

            'simpan perubahan ke bahan baku dempyou
            Dim SerialResult As New List(Of Persistent.Fusoh_OrderProduksiBahanBaku)
            For Each selected In serialTerpilih
              Dim fi = dempyou.BahanBaku.ToList.Find(Function(f) f.Serial = selected.Serial)
              Dim lengthOut = CDec(IIf(selected.OtomatisLength = 0, selected.SisaLength, selected.OtomatisLength))
              If fi Is Nothing Then
                Dim newItem = New Persistent.Fusoh_OrderProduksiBahanBaku(session) With {
                    .Barang = selected.Barang,
                    .Millsheet = selected.MillSheet,
                    .Main = dempyou,
                    .Length = lengthOut, 'CDec(IIf(selected.OtomatisLength = 0, selected.SisaLength, selected.OtomatisLength)),
                    .SNLength = CDec(selected.SisaLength),
                    .Serial = selected.Serial,
                    .Weight = selected.Weight
                }
                newItem.Qty = CInt(IIf(newItem.SNLength = newItem.Length, 1, 0))
                SerialResult.Add(newItem)
              Else
                fi.Length = lengthOut ' CDec(IIf(selected.OtomatisLength = 0, selected.SisaLength, selected.OtomatisLength))
                fi.SNLength = CDec(selected.SisaLength)
                fi.Qty = CInt(IIf(fi.SNLength = fi.Length, 1, 0))
                SerialResult.Add(fi)
              End If
              selected.LengthOut = lengthOut
            Next

            'hapus yg tidak terpilih
            For i = dempyou.BahanBaku.Count - 1 To 0 Step -1
              Dim o = dempyou.BahanBaku(i)
              If o.Barang Is item.PODetail.Barang Then
                Dim find = SerialResult.Find(Function(f) f.Barang Is o.Barang AndAlso f.Serial = o.Serial)
                If find Is Nothing Then
                  o.Delete()
                  dempyou.BahanBaku.Remove(o)
                End If
              End If
            Next

            'set terpilih
            For i = 0 To SerialResult.Count - 1
              Dim s = SerialResult(i)
              Dim fa = dempyou.BahanBaku.ToList.Find(Function(f) f.Barang Is s.Barang AndAlso f.Serial = s.Serial)
              If fa Is Nothing Then
                dempyou.BahanBaku.Add(s)
              Else
                fa.SNLength = s.SNLength
                fa.Length = s.Length
                fa.Qty = s.Qty
              End If
            Next
          Next

          splashManager.SetWaitFormDescription("Revisi WIP / Produksi ...")
          For Each produksi In item.Produksi
            Dim sdhProses = New XPQuery(Of Persistent.Fusoh_PenerimaanBarangDetail)(session).Where(Function(w) w.Main.OrderProduksi Is produksi.OrderProduksi AndAlso Not w.Main Is produksi).ToList
            'check RM dibutuhkan
            Dim rmDibutuhkan As Double = 0
            Dim cuttingDibutuhkan As Double = produksi.OrderProduksi.Cutting
            Dim lebarMataPisau As Double = 3
            If (produksi.OrderProduksi.NoCutting) Then lebarMataPisau = 0
            cuttingDibutuhkan += lebarMataPisau
            rmDibutuhkan = cuttingDibutuhkan * produksi.Detail.Sum(Function(x) x.Qty) 'Qty In, jumlah yg bahan jadi yg diproduksi

            'proses bahan baku
            Dim detailSource = New List(Of NuSoft004.NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
            For Each det In produksi.OrderProduksi.BahanBaku
              Dim itemTemp As New NuSoft004.NonPersistent.Fusoh_Produksi_BahanBaku_Temp
              itemTemp.Barang = det.Barang
              itemTemp.Catatan = det.Catatan
              itemTemp.Id = det.Id
              itemTemp.Millsheet = det.Millsheet
              itemTemp.Serial = det.Serial
              Dim xSerial = sdhProses.FindAll(Function(m) m.Barang Is itemTemp.Barang).SelectMany(Function(m) m.DetailSerial).ToList.FindAll(Function(f) f.Serial = itemTemp.Serial)
              itemTemp.SNLength = CDec(det.SNLength - xSerial.Sum(Function(s) s.LengthOut))
              itemTemp.SNQty = xSerial.Sum(Function(s) s.Qty)
              Dim sisaLength = CDec(det.Length - xSerial.Sum(Function(s) s.LengthOut))

              Dim jumlahPotong = CInt(sisaLength / cuttingDibutuhkan)
              itemTemp.Length = jumlahPotong * cuttingDibutuhkan
              If rmDibutuhkan >= itemTemp.Length Then
                If itemTemp.Length > sisaLength Then
                  itemTemp.Length -= cuttingDibutuhkan
                End If
                rmDibutuhkan -= itemTemp.Length
              Else
                itemTemp.Length = rmDibutuhkan
                rmDibutuhkan = 0
              End If

              itemTemp.Qty = CInt(IIf(itemTemp.SNLength = itemTemp.Length, 1, 0))
              itemTemp.Scrap = det.Scrap
              If (itemTemp.Length > 0) Then detailSource.Add(itemTemp)
              If rmDibutuhkan <= 0 Then
                Exit For
              End If
            Next

            'simpan perubahan ke database
            Dim bahanBaku = produksi.Detail.Where(Function(f) f.Qty = 0)
            Dim itemDetail = detailSource.GroupBy(Function(g) g.Barang).Select(Function(s) s.Key).ToList
            For i = bahanBaku.Count - 1 To 0 Step -1
              Dim baku = bahanBaku(i)
              Dim found = itemDetail.Find(Function(f) f Is baku.Barang)
              If found Is Nothing Then
                baku.Delete()
                produksi.Detail.Remove(baku)
              Else
              End If
            Next

            For i = 0 To detailSource.Count - 1
              Dim bahan = detailSource(i)
              Dim found = produksi.Detail.ToList.Find(Function(f) f.Barang Is bahan.Barang)
              If found Is Nothing Then
                found = New Persistent.Fusoh_PenerimaanBarangDetail(session)
                found.Main = produksi
                found.Barang = bahan.Barang
                found.Gudang = produksi.OrderProduksi.Gudang
                found.Qty = 0
                found.Satuan = bahan.Barang.SatuanD
                found.SODetail = produksi.OrderProduksi.SODetail
                produksi.Detail.Add(found)
              End If
              found.OutDiameter = found.Barang.OutDiameter
              found.InDiameter = found.Barang.InDiameter
              found.Thickness = found.Barang.Thickness
              found.Length = found.Barang.Length
              found.Weight = NuSoft004.FusohLogic.Item.GetWeight(found.OutDiameter, found.Length, found.Thickness)
              found.QtyOut = detailSource.Where(Function(w) w.Barang Is bahan.Barang).Sum(Function(s) s.Qty)

              found.FromRevisiLength = True
              '===== serial
              Dim serial = found.DetailSerial.ToList.Find(Function(f) f.Serial = bahan.Serial)
              If serial Is Nothing Then
                serial = New Persistent.Fusoh_PenerimaanBarangDetailSerial(session)
                serial.DetailMain = found
                serial.Serial = bahan.Serial
                found.DetailSerial.Add(serial)
              End If
              serial.Scrap = bahan.Scrap
              serial.MillSheet = bahan.Millsheet
              serial.LengthIn = 0
              serial.LengthOut = bahan.Length
              serial.Qty = bahan.Qty
            Next

            '======= update hpp
            NuSoft004.FusohLogic.HPP.HitungHPPDariProduksi(session, produksi.Id, False)
          Next
        Next

        splashManager.SetWaitFormCaption("Silahkan tunggu ")
        splashManager.SetWaitFormDescription("Simpan perubahan ...")
        session.CommitChanges()
      Catch ex As Utils.Exception
        Throw New Utils.Exception(ex)
      Catch ex As Exception
        Throw New Exception(ex.Message, ex.InnerException)
      Finally
        splashManager.CloseWaitForm()
      End Try
    End Using
  End Sub
	Public Overrides Sub ErrorBtn1Click(ex As Utils.Exception)
		ex.ShowWinMessageBox()
	End Sub
End Class