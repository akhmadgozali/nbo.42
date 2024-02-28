Imports DevExpress.Xpo
Imports NuSoft.Core.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent

Namespace Services
  Public Class Fusoh_UpdateStatus
    Public Shared Sub UpdateStatusDempyou(dempyou As Persistent.Fusoh_OrderProduksi)
      If dempyou.QtyCutting > 0 Then 'Jika ada proses cutting [WIP]
        If dempyou.QtyCutting < dempyou.Qty Then
          dempyou.StatusTransaksi = StatusTransaksiEnum.InProgress
        Else
          dempyou.StatusTransaksi = StatusTransaksiEnum.Finish
        End If
      ElseIf dempyou.QtyProduksi > 0 Then 'Jika tidak melewati cutting [WIP]
        If dempyou.QtyProduksi < dempyou.Qty Then
          dempyou.StatusTransaksi = StatusTransaksiEnum.InProgress
        Else
          dempyou.StatusTransaksi = StatusTransaksiEnum.Finish
        End If
      Else
        dempyou.StatusTransaksi = StatusTransaksiEnum.Posting
      End If
    End Sub
    Friend Shared Sub UpdateStatusDempyou(session As UnitOfWork, cuttingWIP As Persistent.Fusoh_StokMain, newEntryQtyCutting As Double)
      Dim xQtyDempyou As Double = cuttingWIP.OrderProduksi.Qty
      Dim xQtyCutting As Double = New XPQuery(Of Persistent.Fusoh_StokDetail)(session) _
        .Where(Function(w) w.Main.OrderProduksi Is cuttingWIP.OrderProduksi AndAlso Not w.Main Is cuttingWIP) _
        .Sum(Function(s) s.QtyIn) + newEntryQtyCutting

      If xQtyCutting <= 0 Then
        cuttingWIP.OrderProduksi.StatusTransaksi = StatusTransaksiEnum.Posting
      ElseIf xQtyCutting < xQtyDempyou Then
        cuttingWIP.OrderProduksi.StatusTransaksi = StatusTransaksiEnum.InProgress
      Else
        cuttingWIP.OrderProduksi.StatusTransaksi = StatusTransaksiEnum.Finish
      End If
    End Sub
    Friend Shared Sub UpdateStatusDempyouDariProduksi(session As UnitOfWork, produksi As Persistent.Fusoh_StokMain, newEntryQtyProduksi As Double)
      '==== jika dari cutting wip abaikan
      If Not produksi.CuttingWIP Is Nothing Then Return
      If produksi.OrderProduksi Is Nothing Then Return

      Dim xQtyDempyou As Double = produksi.OrderProduksi.Qty
      Dim xQtyCutting As Double = New XPQuery(Of Persistent.Fusoh_StokDetail)(session) _
        .Where(Function(w) w.Main.OrderProduksi Is produksi.OrderProduksi AndAlso Not w.Main Is produksi) _
        .Sum(Function(s) s.QtyIn) + newEntryQtyProduksi

      If xQtyCutting <= 0 Then
        produksi.OrderProduksi.StatusTransaksi = StatusTransaksiEnum.Posting
      ElseIf xQtyCutting < xQtyDempyou Then
        produksi.OrderProduksi.StatusTransaksi = StatusTransaksiEnum.InProgress
      Else
        produksi.OrderProduksi.StatusTransaksi = StatusTransaksiEnum.Finish
      End If
    End Sub
    Friend Shared Sub ClosingDempyou(session As UnitOfWork, item As Persistent.Fusoh_OrderProduksi)
      ' samakan qty finish good dempyou dengan yang di produksi
      item.Qty = item.QtyCutting

      ' cek produksi
      Dim produksi = New XPQuery(Of Persistent.Fusoh_StokSerial)(session) _
      .Where(Function(w) w.DetailMain.Main.OrderProduksi Is item AndAlso w.LengthOut > 0) _
      .GroupBy(Function(g) g.Serial).Select(Function(s) New With {.Serial = s.Key, .LengthOut = s.Sum(Function(x) x.LengthOut)}) _
      .ToList

      ' samakan bahan baku dempyou dengan yang diproduksi
      ' =================================================
      ' hapus yang tidak ada di produksi / update length out dengan produksi
      For i = item.BahanBaku.Count - 1 To 0 Step -1
        Dim bahanBaku = item.BahanBaku(i)
        Dim found = produksi.Find(Function(f) f.Serial = bahanBaku.Serial)
        If found Is Nothing Then
          bahanBaku.Delete()
        Else
          bahanBaku.Length = CDec(found.LengthOut)
        End If
      Next
    End Sub

    Friend Shared Sub UpdateStatusCuttingWIP(session As UnitOfWork, dailyProcess As Persistent.Fusoh_DailyProcess, newEntryQtyFinishGood As Double)
      Dim xQtyCuttingWIP As Double = dailyProcess.CuttingWIP.TotalQtyIn
      Dim xQtyDailyProcess As Double = New XPQuery(Of Persistent.Fusoh_DailyProcess)(session) _
        .Where(Function(w) w.CuttingWIP Is dailyProcess.CuttingWIP AndAlso Not w Is dailyProcess) _
        .Sum(Function(s) s.QtyFinishGood) + newEntryQtyFinishGood

      If xQtyDailyProcess <= 0 Then
        dailyProcess.CuttingWIP.StatusTransaksi = StatusTransaksiEnum.Posting
      ElseIf xQtyDailyProcess < xQtyCuttingWIP Then
        dailyProcess.CuttingWIP.StatusTransaksi = StatusTransaksiEnum.InProgress
      Else
        dailyProcess.CuttingWIP.StatusTransaksi = StatusTransaksiEnum.Finish
      End If
    End Sub
    Friend Shared Sub UpdateStatusCuttingWIP(session As UnitOfWork, cuttingWIP As Persistent.Fusoh_StokMain)
      Dim xQtyCuttingWIP As Double = cuttingWIP.TotalQtyIn
      Dim xQtyDailyProcess As Double = New XPQuery(Of Persistent.Fusoh_DailyProcess)(session) _
        .Where(Function(w) w.CuttingWIP Is cuttingWIP) _
        .Sum(Function(s) s.QtyFinishGood)

      If xQtyDailyProcess <= 0 Then
        cuttingWIP.StatusTransaksi = StatusTransaksiEnum.Posting
      ElseIf xQtyDailyProcess < xQtyCuttingWIP Then
        cuttingWIP.StatusTransaksi = StatusTransaksiEnum.InProgress
      Else
        cuttingWIP.StatusTransaksi = StatusTransaksiEnum.Finish
      End If
    End Sub
  End Class

  Friend Class MasterProcessCuttingService
    Private Shared Sub CheckBeforeDelete(session As UnitOfWork, item As Persistent.Fusoh_ProcessCutting)
      Dim countCutting = New XPQuery(Of Persistent.Fusoh_DailyProcess)(session).Where(Function(w) w.ProcessCutting Is item).Count
      If (countCutting > 0) Then Throw New Exception("Proses cutting '" & item.Nama & "' tidak bisa dihapus, karena sudah dipakai di Cutting [WIP]")
    End Sub
    Shared Sub DeleteData(session As UnitOfWork, listItem As List(Of Persistent.Fusoh_ProcessCutting))
      Dim errorMessage As String = String.Empty
      Dim kodeDelete = ""

      For Each item In listItem
        Try
          CheckBeforeDelete(session, item)
          kodeDelete &= ", " & item.Kode
          item.Delete()
        Catch ex As Exception
          errorMessage &= vbCrLf & item.Id & " - " & item.Nama
        End Try
      Next
      session.CommitChanges()
      '======= Simple log
      Try
        If kodeDelete <> "" Then
          DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Hapus, "Data Process Cutting ->" & kodeDelete.Substring(1))
          session.CommitChanges()
        End If
      Catch ex As Exception
      End Try

      If errorMessage <> String.Empty Then
        Throw New Utils.Exception("Ada beberapa data yang tidak bisa dihapus, karena sudah dipakai di menu Cutting [WIP]" & errorMessage)
      End If
    End Sub

    Private Shared Sub CheckBeforeSave(session As UnitOfWork, item As Persistent.Fusoh_ProcessCutting, originalData As Persistent.Fusoh_ProcessCutting)
      If item.Kode = String.Empty Then Throw New Utils.Exception("Masukkan kode", -1)
      If item.Nama = String.Empty Then Throw New Utils.Exception("Masukkan nama", -2)

      'check Kode
      If Not originalData Is Nothing AndAlso item.Kode = originalData.Kode Then GoTo checkNama
      Dim countKode = New XPQuery(Of Persistent.Fusoh_ProcessCutting)(session).Where(Function(w) w.Kode = item.Kode).Count
      If countKode > 0 Then Throw New Utils.Exception("Kode '" & item.Kode & "' sudah ada yang memakai, silahkan ganti dengan yg lain", -1)

      'check Nama
checkNama:
      If Not originalData Is Nothing AndAlso item.Nama = originalData.Nama Then Return
      Dim countNama = New XPQuery(Of Persistent.Fusoh_ProcessCutting)(session).Where(Function(w) w.Nama = item.Nama).Count
      If countNama > 0 Then Throw New Utils.Exception("Nama '" & item.Nama & "' sudah ada yang memakai, silahkan ganti dengan yg lain", -2)
    End Sub
    Shared Sub SaveData(session As UnitOfWork, item As Persistent.Fusoh_ProcessCutting, originalData As Persistent.Fusoh_ProcessCutting)
      Try
        CheckBeforeSave(session, item, originalData)
        If originalData Is Nothing Then
          DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Process Cutting -> " & item.Kode)
        Else
          DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Process Cutting -> " & item.Kode)
        End If
        session.CommitChanges()
      Catch ex As Utils.Exception
        session.RollbackTransaction()
        Throw New Utils.Exception(ex.Message, ex.ErrorNumber)
      End Try
    End Sub
  End Class

  Friend Class TransaksiCuttingWIPService
    Private Shared Sub CheckBeforeDelete(session As UnitOfWork, item As Persistent.Fusoh_StokMain)
      If item.StatusTransaksi <> NuSoft001.Persistent.StatusTransaksiEnum.Pending Then Throw New Exception("Cutting WIP '" & item.Kode & "' tidak bisa dihapus")
    End Sub
    Shared Sub DeleteData(session As UnitOfWork, listItem As List(Of Persistent.Fusoh_StokMain))
      Dim errorMessage As String = String.Empty
      Dim kodeDelete = ""

      For Each item In listItem
        Try
          CheckBeforeDelete(session, item)

          ''update status dempyou
          'Dim xpProduksi = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.Id <> item.Id AndAlso w.Main.OrderProduksi Is item.OrderProduksi AndAlso Not w.Main Is item)
          'If xpProduksi.Count = 0 Then
          '	item.OrderProduksi.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
          'Else
          '	item.OrderProduksi.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
          'End If
          Fusoh_UpdateStatus.UpdateStatusDempyou(session, item, item.TotalQtyIn * -1)

          kodeDelete &= ", " & item.Kode
          item.Delete()
        Catch ex As Exception
          errorMessage &= vbCrLf & item.Kode
        End Try
      Next
      session.CommitChanges()
      '======= Simple log
      Try
        If kodeDelete <> "" Then
          DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Hapus, "Data Cutting WIP ->" & kodeDelete.Substring(1))
          session.CommitChanges()
        End If
      Catch ex As Exception
      End Try

      If errorMessage <> String.Empty Then
        Throw New Utils.Exception("Transaksi selain status pending tidak dapat dihapus." & errorMessage)
      End If
    End Sub

    Shared Function GetDetailSource(instance As Persistent.Fusoh_StokMain, listSerialDiProses As List(Of Persistent.Fusoh_StokDetail)) As List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
      Dim result As New List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
      For Each det In instance.Detail
        If det.QtyIn = 0 Then
          For Each serial In det.Serial
            Dim item As New NonPersistent.Fusoh_Produksi_BahanBaku_Temp
            item.Barang = det.Barang
            item.Catatan = det.Catatan
            item.Id = det.Id
            item.Millsheet = serial.MillSheet
            item.Serial = serial.Serial
            Dim xSerial = listSerialDiProses.FindAll(Function(m) m.Barang Is item.Barang).SelectMany(Function(m) m.Serial).ToList.FindAll(Function(f) f.Serial = item.Serial)
            Dim xOrder = instance.OrderProduksi.BahanBaku.ToList.Find(Function(w) w.Barang Is item.Barang AndAlso w.Serial = item.Serial)
            item.SNLength = CDec(xOrder.Length - xSerial.Sum(Function(s) s.LengthOut))
            item.Length = CDec(serial.LengthOut)
            item.Qty = CInt(IIf(item.SNLength = item.Length, 1, 0))
            item.Scrap = serial.Scrap
            result.Add(item)
          Next
        End If
      Next
      Return result
    End Function
    Shared Sub CheckStokInDetailSource(session As UnitOfWork, instance As Persistent.Fusoh_StokMain, listDetail As List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp))
      Dim errorStok As String = ""
      For i = 0 To listDetail.Count - 1
        Dim bahan = listDetail(i)
        Dim stokSaatIni = New XPQuery(Of Persistent.Fusoh_StokSerial)(session) _
          .Where(Function(n) n.DetailMain.Barang Is bahan.Barang AndAlso n.Serial = bahan.Serial AndAlso Not n.DetailMain.Main Is instance) _
          .Sum(Function(s) s.LengthIn - s.LengthOut)

        If bahan.Length > stokSaatIni Then
          errorStok &= vbCrLf & String.Format("{0}-{1} ({2}) ==> {3}, tersedia {4}", bahan.Barang.Kode, bahan.Barang.Nama, bahan.Serial, bahan.Length, stokSaatIni)
        End If
      Next
      If errorStok <> "" Then
        Throw New Utils.Exception("Ada beberapa bahan yang kekurangan stok :" & errorStok, -99)
      End If
    End Sub

    Private Shared Sub CheckBeforeSave(session As UnitOfWork, item As Persistent.Fusoh_StokMain, originalData As Persistent.Fusoh_StokMain, mesin As Persistent.Fusoh_Mesin, processCutting As Persistent.Fusoh_ProcessCutting, QtyCutting As Integer, bahanWIP As Persistent.Fusoh_Barang)
      If item.Regional Is Nothing Then Throw New Utils.Exception("Masukkan regional", -1)
      If item.Tanggal = Nothing Then Throw New Utils.Exception("Masukkan tanggal", -2)
      If item.Pelanggan Is Nothing Then Throw New Utils.Exception("Masukkan pelangan", -3)
      If item.OrderProduksi Is Nothing Then Throw New Utils.Exception("Masukkan order produksi (dempyou)", -4)
      'If item.TotalLength = 0 Then Throw New Utils.Exception("Total length bahan baku berjumlah '0'. Silahkan benahi data bahan baku", -5)
      If session.IsNewObject(item) Then
        If (Not item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
          Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -6)
        End If
      End If
      If mesin Is Nothing Then Throw New Utils.Exception("Masukkan mesin cutting", -7)
      If processCutting Is Nothing Then Throw New Utils.Exception("Masukkan process cutting", -8)
      If QtyCutting = Nothing Then Throw New Utils.Exception("Masukkan qty cutting", -9)
      If bahanWIP Is Nothing Then Throw New Utils.Exception("Setting bahan WIP belum dimasukkan", -99)

      'check Kode
      If Not originalData Is Nothing AndAlso item.Kode = originalData.Kode Then Return
      Dim countKode = New XPQuery(Of Persistent.Fusoh_StokMain)(session).Where(Function(w) w.Kode = item.Kode).Count
      If countKode > 0 Then Throw New Utils.Exception("Kode '" & item.Kode & "' sudah ada yang memakai, silahkan ganti dengan yg lain", -2)
    End Sub
    Shared Sub SaveData(session As UnitOfWork, item As Persistent.Fusoh_StokMain, originalData As Persistent.Fusoh_StokMain, mesin As Persistent.Fusoh_Mesin, shift As Integer, processCutting As Persistent.Fusoh_ProcessCutting, QtyCutting As Integer, detailSource As List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp))
      Try
        Dim settingWIP = New FusohLogic.FusohWIPSetting(session)
        Dim bahanWIP = session.GetObjectByKey(Of Persistent.Fusoh_Barang)(settingWIP.BarangWIP)

        CheckBeforeSave(session, item, originalData, mesin, processCutting, QtyCutting, bahanWIP)

        item.Gudang = item.OrderProduksi.Gudang
        item.SO = item.OrderProduksi.SODetail.Main
        '' ====== DAILY PROCESS
        'Dim dailyProcess As Persistent.Fusoh_DailyProcess = Nothing
        'If item.DailyProcess.Count > 0 Then
        '	dailyProcess = item.DailyProcess(0)
        'End If
        'If dailyProcess Is Nothing Then dailyProcess = New Persistent.Fusoh_DailyProcess(session) With {.CuttingWIP = item}
        'dailyProcess.Mesin = mesin
        'dailyProcess.Shift = shift
        'dailyProcess.ProcessCutting = processCutting
        'If session.IsNewObject(dailyProcess) Then
        '	Select Case processCutting.DefaultFG
        '		Case 1 : dailyProcess.QtyOP1 = QtyCutting
        '		Case 2 : dailyProcess.QtyOP2 = QtyCutting
        '		Case 3 : dailyProcess.QtyOP3 = QtyCutting
        '		Case 4 : dailyProcess.QtyOP4 = QtyCutting
        '		Case 5 : dailyProcess.QtyOP5 = QtyCutting
        '	End Select
        '	dailyProcess.QtyFinishGood = QtyCutting
        'End If
        item.CuttingMesin = mesin
        item.CuttingShift = shift
        item.CuttingProcess = processCutting
        'MsgBox("Cutting Proses pas simpan :" & processCutting.Nama)

        ' ====== BAHAN WIP
        Dim itemBarangWIP = item.Detail.ToList.Find(Function(f) f.QtyIn <> 0)
        If itemBarangWIP Is Nothing Then
          itemBarangWIP = New Persistent.Fusoh_StokDetail(session)
          itemBarangWIP.Main = item
          itemBarangWIP.Barang = bahanWIP
          item.Detail.Add(itemBarangWIP)
        End If
        itemBarangWIP.Gudang = item.OrderProduksi.Gudang
        itemBarangWIP.QtyIn = QtyCutting
        itemBarangWIP.QtyOut = 0
        itemBarangWIP.OutDiameter = item.OrderProduksi.SODetail.OutDiameter
        itemBarangWIP.InDiameter = item.OrderProduksi.SODetail.InDiameter
        itemBarangWIP.Thickness = item.OrderProduksi.SODetail.Thickness
        itemBarangWIP.Length = item.OrderProduksi.SODetail.Length
        itemBarangWIP.Weight = item.OrderProduksi.Weight
        itemBarangWIP.Satuan = item.OrderProduksi.SODetail.Barang.SatuanD
        itemBarangWIP.SODetail = item.OrderProduksi.SODetail
        ' ====== BAHAN BAKU
        Dim bahanBaku = item.Detail.Where(Function(f) f.QtyIn = 0)
        Dim itemDetail = detailSource.GroupBy(Function(g) g.Barang).Select(Function(s) s.Key).ToList
        For i = bahanBaku.Count - 1 To 0 Step -1
          Dim baku = bahanBaku(i)
          Dim found = itemDetail.Find(Function(f) f Is baku.Barang)
          If found Is Nothing Then
            baku.Delete()
            item.Detail.Remove(baku)
          End If
        Next

        For i = 0 To detailSource.Count - 1
          Dim bahan = detailSource(i)
          Dim found = item.Detail.ToList.Find(Function(f) f.Barang Is bahan.Barang)
          If found Is Nothing Then
            found = New Persistent.Fusoh_StokDetail(session)
            found.Main = item
            found.Barang = bahan.Barang
            found.Gudang = item.OrderProduksi.Gudang
            found.QtyIn = 0
            found.Satuan = bahan.Barang.SatuanD
            found.SODetail = item.OrderProduksi.SODetail
            item.Detail.Add(found)
          End If
          found.OutDiameter = found.Barang.OutDiameter
          found.InDiameter = found.Barang.InDiameter
          found.Thickness = found.Barang.Thickness
          found.Length = found.Barang.Length
          found.Weight = FusohLogic.Item.GetWeight(found.OutDiameter, found.Length, found.Thickness)
          found.QtyOut = detailSource.Where(Function(w) w.Barang Is bahan.Barang).Sum(Function(s) s.Qty)

          '===== serial
          Dim serial = found.Serial.ToList.Find(Function(f) f.Serial = bahan.Serial)
          If serial Is Nothing Then
            serial = New Persistent.Fusoh_StokSerial(session)
            serial.DetailMain = found
            serial.Serial = bahan.Serial
            found.Serial.Add(serial)
          End If
          serial.Scrap = bahan.Scrap
          serial.MillSheet = bahan.Millsheet
          serial.LengthIn = 0
          serial.LengthOut = bahan.Length
          serial.Qty = bahan.Qty
        Next

        '======= update hpp
        FusohLogic.HPP.HitungHPPDariProduksi(item, False)

        ''======= update status dempyou
        'If Not item.OrderProduksi Is Nothing Then
        '	Dim xQtyDempyou As Double = item.OrderProduksi.Qty
        '	Dim xQtyCutting As Double = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.OrderProduksi Is item.OrderProduksi AndAlso Not w.Main Is item).Sum(Function(s) s.QtyIn) + QtyCutting
        '	If xQtyCutting < xQtyDempyou Then
        '		item.OrderProduksi.StatusTransaksi = StatusTransaksiEnum.InProgress
        '	Else
        '		item.OrderProduksi.StatusTransaksi = StatusTransaksiEnum.Finish
        '	End If
        'End If
        Fusoh_UpdateStatus.UpdateStatusDempyou(session, item, QtyCutting)

        If originalData Is Nothing Then
          DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Cutting WIP -> " & item.Kode)
        Else
          DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Cutting WIP -> " & item.Kode)
        End If

        session.CommitChanges()
      Catch ex As Utils.Exception
        session.RollbackTransaction()
        Throw New Utils.Exception(ex.Message, ex.ErrorNumber)
      End Try
    End Sub
  End Class

  Friend Class TransaksiDailyProcess
    Private Shared Sub CheckBeforeDelete(session As UnitOfWork, item As Persistent.Fusoh_DailyProcess)
      'If item.CuttingWIP.StatusTransaksi <> StatusTransaksiEnum.Pending _
      '	AndAlso item.CuttingWIP.StatusTransaksi <> StatusTransaksiEnum.Posting Then _
      '	Throw New Exception("Daily Process utk cutting WIP '" & item.CuttingWIP.Kode & "' tidak bisa dihapus." & vbCrLf & "Karena status Cutting [WIP] bukan Pending / Posting")
      If Not item.Produksi Is Nothing Then _
        Throw New Exception("Daily Process utk cutting WIP '" & item.CuttingWIP.Kode & "' tidak bisa dihapus." & vbCrLf & "Karena sudah diproduksi")
    End Sub
    Shared Sub DeleteData(session As UnitOfWork, listItem As List(Of Persistent.Fusoh_DailyProcess))
      Dim errorMessage As String = String.Empty
      Dim kodeDelete = ""

      For Each item In listItem
        Try
          CheckBeforeDelete(session, item)
          Fusoh_UpdateStatus.UpdateStatusCuttingWIP(session, item, item.QtyFinishGood * -1)
          kodeDelete &= ", " & item.CuttingWIP.Kode
          item.Delete()
        Catch ex As Exception
          errorMessage &= vbCrLf & item.CuttingWIP.Kode
        End Try
      Next
      session.CommitChanges()
      '======= Simple log
      Try
        If kodeDelete <> "" Then
          DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Hapus, "Data Daily Process WIP ->" & kodeDelete.Substring(1))
          session.CommitChanges()
        End If
      Catch ex As Exception
      End Try

      If errorMessage <> String.Empty Then
        Throw New Utils.Exception("Daily Process yang sudah diproduksi tidak dapat dihapus." & errorMessage)
      End If
    End Sub

    Shared Function GetCuttingWIPSource(session As UnitOfWork, editedData As Persistent.Fusoh_DailyProcess) As List(Of Persistent.Fusoh_StokMain)
      Dim result = New XPQuery(Of Persistent.Fusoh_StokMain)(session).Where(Function(w) w.Sumber.Id = Persistent.SumberDataJenis.CW AndAlso
                                  (w.StatusTransaksi = StatusTransaksiEnum.Pending Or w.StatusTransaksi = StatusTransaksiEnum.Posting _
                                   Or w.StatusTransaksi = StatusTransaksiEnum.InProgress)).ToList()
      'result = result.Where(Function(w) w.TotalQtyIn > w.DailyProcess.Sum(Function(s) s.QtyFinishGood) AndAlso w.DetailProduksi.Count <= 0).ToList()
      result = result.Where(Function(w) w.TotalQtyIn > w.DailyProcess.Sum(Function(s) s.QtyFinishGood)).ToList()
      If (Not editedData Is Nothing) Then result.Add(editedData.CuttingWIP)
      Return result
    End Function

    Private Shared Sub CheckBeforeSave(session As UnitOfWork, item As Persistent.Fusoh_DailyProcess)
      If item.CuttingWIP Is Nothing Then Throw New Utils.Exception("Masukkan nomor cutting [WIP]", -1)
      If item.Tanggal = Nothing Then Throw New Utils.Exception("Masukkan tanggal", -2)
      If item.Mesin Is Nothing Then Throw New Utils.Exception("Masukkan mesin", -3)
      If item.ProcessCutting Is Nothing Then Throw New Utils.Exception("Masukkan process cutting", -4)

      'check seluruh jumlah FG
      Dim jmlFGCutting = item.CuttingWIP.TotalQtyIn
      Dim jmlFGProcess = item.CuttingWIP.DailyProcess.Where(Function(w) Not w Is item).Sum(Function(s) s.QtyFinishGood)
      Dim sisaDaily = jmlFGCutting - jmlFGProcess
      If (item.QtyFinishGood > sisaDaily) Then Throw New Utils.Exception("Qty finish good yang anda masukkan melebihi qty cutting [WIP]" & vbCrLf & "Jml Qty Cutting [WIP] : " & jmlFGCutting & vbCrLf & "Jml Qty Daily Process : " & jmlFGProcess & vbCrLf & "Sisa qty Daily Process : " & sisaDaily, -5)
    End Sub
    Shared Sub SaveData(session As UnitOfWork, item As Persistent.Fusoh_DailyProcess)
      Try
        CheckBeforeSave(session, item)
        Fusoh_UpdateStatus.UpdateStatusCuttingWIP(session, item, item.QtyFinishGood)
        If session.IsNewObject(item) Then
          DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Daily Process WIP -> " & item.CuttingWIP.Kode)
        Else
          DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Daily Process WIP -> " & item.CuttingWIP.Kode)
        End If
        session.CommitChanges()
      Catch ex As Utils.Exception
        session.RollbackTransaction()
        Throw New Utils.Exception(ex.Message, ex.ErrorNumber)
      End Try
    End Sub
  End Class

  Friend Class TransaksiProduksi
    Private Shared Sub CheckBeforeDelete(item As Persistent.Fusoh_StokMain)
      If item.StatusTransaksi <> StatusTransaksiEnum.Pending Then Throw New Exception("Produksi '" & item.Kode & "' tidak bisa dihapus")
    End Sub
    Shared Sub DeleteData(session As UnitOfWork, listItem As List(Of Persistent.Fusoh_StokMain))
      Dim errorMessage As String = String.Empty
      Dim kodeDelete = ""
      For Each item In listItem
        Try
          CheckBeforeDelete(item)
          For i = item.DailyProcessProduksi.Count - 1 To 0 Step -1
            item.DailyProcessProduksi(i).Produksi = Nothing
          Next
          Fusoh_UpdateStatus.UpdateStatusDempyouDariProduksi(session, item, item.TotalQtyIn * -1)

          kodeDelete &= ", " & item.Kode
          item.Delete()
        Catch ex As Exception
          errorMessage &= vbCrLf & item.Kode & " -> " & ex.Message
        End Try
      Next
      session.CommitChanges()
      '======= Simple log
      Try
        If kodeDelete <> "" Then
          DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Hapus, "Data Produksi ->" & kodeDelete.Substring(1))
          session.CommitChanges()
        End If
      Catch ex As Exception
      End Try

      If errorMessage <> String.Empty Then
        Throw New Utils.Exception("Transaksi selain status pending tidak dapat dihapus." & errorMessage)
      End If
    End Sub

    Shared Function GetDempyouData(session As UnitOfWork, pelanggan As Kontak, editedData As Persistent.Fusoh_StokMain) As List(Of NonPersistent.Fusoh_DempyouInProduksi)
      Dim result As New List(Of NonPersistent.Fusoh_DempyouInProduksi)
      If editedData Is Nothing Then
        Dim settingWIP As New FusohLogic.FusohWIPSetting(session)
        If settingWIP.TanggalMulaiWIP = Nothing Then
          Throw New Exception("Tanggal mulai alur WIP belum ada di Setting WIP")
        Else
          Dim listDempyouLama = New XPQuery(Of Persistent.Fusoh_OrderProduksi)(session) _
            .Where(Function(m) m.Pelanggan Is pelanggan AndAlso
            (m.StatusTransaksi = StatusTransaksiEnum.InProgress _
            OrElse m.StatusTransaksi = StatusTransaksiEnum.Posting) _
            AndAlso m.Tanggal < settingWIP.TanggalMulaiWIP).ToList
          'Dim dataCutting = New XPQuery(Of Persistent.Fusoh_StokMain)(session) _
          '	.Where(Function(w) w.Sumber.Id = Persistent.SumberDataJenis.CW AndAlso
          '	w.Pelanggan Is pelanggan AndAlso
          '	(w.StatusTransaksi = StatusTransaksiEnum.InProgress _
          '	OrElse w.StatusTransaksi = StatusTransaksiEnum.Posting)).ToList
          Dim dailyProcessList = New XPQuery(Of Persistent.Fusoh_DailyProcess)(session) _
            .Where(Function(w) w.Produksi Is Nothing AndAlso w.CuttingWIP.Pelanggan Is pelanggan).ToList() _
            .GroupBy(Function(g) g.CuttingWIP) _
            .Select(Function(s) New With {.CuttingWIP = s.Key, .dailyList = s.Select(Function(x) x).ToList}).ToList()

          result.AddRange(listDempyouLama.Select(Function(s) _
              New NonPersistent.Fusoh_DempyouInProduksi() With {.Id = s.Id, .Dempyou = s, .CuttingWIP = Nothing, .DailyProcessList = Nothing}))
          'result.AddRange(dataCutting.Select(Function(s) _
          '		New NonPersistent.Fusoh_DempyouInProduksi() With {.Id = s.Id, .Dempyou = s.OrderProduksi, .CuttingWIP = s}))
          result.AddRange(dailyProcessList.Select(Function(s) _
              New NonPersistent.Fusoh_DempyouInProduksi() With {.Id = s.CuttingWIP.Id, .Dempyou = s.CuttingWIP.OrderProduksi, .CuttingWIP = s.CuttingWIP, .DailyProcessList = s.dailyList}))
        End If
      Else
        If editedData.CuttingWIP Is Nothing Then
          result.Add(New NonPersistent.Fusoh_DempyouInProduksi() With {.Id = editedData.OrderProduksi.Id, .Dempyou = editedData.OrderProduksi, .CuttingWIP = Nothing, .DailyProcessList = Nothing})
        Else
          result.Add(New NonPersistent.Fusoh_DempyouInProduksi() With {.Id = editedData.CuttingWIP.Id, .Dempyou = editedData.OrderProduksi, .CuttingWIP = editedData.CuttingWIP, .DailyProcessList = editedData.DailyProcessProduksi.ToList})
        End If
      End If
      Return result
    End Function
  End Class
End Namespace
