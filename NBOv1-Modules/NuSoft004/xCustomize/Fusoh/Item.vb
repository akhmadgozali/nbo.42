Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent
Imports NuSoft.Utils.CustomAttribute

Namespace FusohLogic
  Public Class Item
    Public Shared Function GetWeight(outDiameter As Decimal, length As Decimal, thick As Decimal) As Decimal
      Dim result As Double
      If thick > 0 Then
        result = ((outDiameter - thick) * thick * 0.02466)
      Else
        result = ((outDiameter * outDiameter) * 0.00617)
      End If

      Select Case result
        Case Is < 1 : result = CDec(Math.Round(result, 3))
        Case 1 To 9 : result = CDec(Math.Round(result, 2))
        Case 10 To 99 : result = CDec(Math.Round(result, 1))
        Case Else : result = CDec(Math.Round(result, 0))
      End Select

      Return CDec((result * length) / 1000)
    End Function
    Public Shared Function GetRemainStock(session As UnitOfWork, item As Persistent.Barang) As Double
      Dim stok = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Barang Is item)
      Return stok.Sum(Function(s) s.QtyIn) - stok.Sum(Function(s) s.QtyOut)
    End Function
    Public Shared Function GetRemainLengthSerial(session As UnitOfWork, item As Persistent.Barang, serial As String) As Double
      Dim serialx = New XPQuery(Of Persistent.Fusoh_StokSerial)(session).Where(Function(w) w.DetailMain.Barang Is item AndAlso w.Serial = serial)
      Return serialx.Sum(Function(s) s.LengthIn) - serialx.Sum(Function(s) s.LengthOut)
    End Function

    Public Shared Function GetRemainStock(session As UnitOfWork, item As Persistent.Fusoh_Barang) As Double
      Dim stok = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Barang Is item)
      Return stok.Sum(Function(s) s.QtyIn) - stok.Sum(Function(s) s.QtyOut)
    End Function
    Public Shared Function GetRemainLengthSerial(session As UnitOfWork, item As Persistent.Fusoh_Barang, serial As String) As Double
      Dim serialx = New XPQuery(Of Persistent.Fusoh_StokSerial)(session).Where(Function(w) w.DetailMain.Barang Is item AndAlso w.Serial = serial)
      Return serialx.Sum(Function(s) s.LengthIn) - serialx.Sum(Function(s) s.LengthOut)
    End Function

    Public Shared Function GetSerialData(session As UnitOfWork) As List(Of NonPersistent.Fusoh_DataSerial)
      Dim sss = New XPCollection(Of Persistent.Fusoh_StokSerial)(session) _
        .GroupBy(Function(g) g.Serial)

      Dim x = (From z In sss Select New NonPersistent.Fusoh_DataSerial _
              With {.Id = z.FirstOrDefault.Id, .LengthIn = z.Sum(Function(s) s.LengthIn), .LengthOut = z.Sum(Function(s) s.LengthOut),
                    .MillSheet = z.FirstOrDefault.MillSheet, .Serial = z.Key, .Barang = z.FirstOrDefault.DetailMain.Barang}).ToList

      '===== kurangi serial yang ada di order produksi
      Dim order = New XPQuery(Of Persistent.Fusoh_OrderProduksiBahanBaku)(session)
      For i = 0 To x.Count - 1
        Dim xo = x(i)
        Dim o = order.Where(Function(w) w.Barang Is xo.Barang AndAlso w.Serial = xo.Serial).Sum(Function(s) s.Length)
        xo.LengthOut += o
      Next

      Return x
    End Function
    Public Shared Function GetSerialData(session As UnitOfWork, item As Persistent.Fusoh_Barang) As List(Of NonPersistent.Fusoh_DataSerial)

      Dim sss = New XPCollection(Of Persistent.Fusoh_StokSerial)(session).Where(Function(w) w.DetailMain.Barang Is item) _
        .GroupBy(Function(g) g.Serial)

      Dim x = (From z In sss Select New NonPersistent.Fusoh_DataSerial _
                      With {.Id = z.FirstOrDefault.Id,
                               .LengthIn = z.Sum(Function(s) s.LengthIn),
                               .LengthOut = z.Sum(Function(s) s.LengthOut),
                               .MillSheet = z.FirstOrDefault.MillSheet,
                               .Serial = z.Key,
                               .Barang = item,
                               .Weight = z.Average(Function(s) s.DetailMain.Weight),
                               .Qty = z.Sum(Function(s) s.Qty),
                               .TanggalDatang = z.Min(Function(s) s.DetailMain.Main.Tanggal)
                        }).ToList


      '===== kurangi serial yang ada di order produksi YANG BELUM DIPRODUKSI
      'Dim orderSdhDiProduksi = New XPQuery(Of Fusoh_StokMain)(session).Where(Function(w) Not w.OrderProduksi Is Nothing).GroupBy(Function(g) g.OrderProduksi).Select(Function(s) s.Key).ToList
      'Dim orderItem = New XPQuery(Of Fusoh_OrderProduksiBahanBaku)(session).Where(Function(w) w.Barang Is item AndAlso Not orderSdhDiProduksi.Contains(w.Main))


      '==== edit jali 14-Jan-2021
      'Serial = SN masuk masuk - SN keluar - sisa dempyou .. dempyou bisa diproduksi sebagian
      'Dim orderSdhDiProduksi = New XPQuery(Of Fusoh_StokMain)(session).Where(Function(w) Not w.OrderProduksi Is Nothing).GroupBy(Function(g) g.OrderProduksi).Select(Function(s) s.Key).ToList
      'Dim orderItem = New XPQuery(Of Fusoh_OrderProduksiBahanBaku)(session).Where(Function(w) w.Barang Is item AndAlso Not orderSdhDiProduksi.Contains(w.Main))

      '==== edit sbm 03-Mar-2021
      Dim orderItem = New XPQuery(Of Fusoh_OrderProduksiBahanBaku)(session).Where(Function(w) w.Barang Is item)
      Dim DataProduksi As New XPCollection(Of Persistent.Fusoh_StokSerial)(session, New GroupOperator(GroupOperator.And, New BinaryOperator("DetailMain.Barang.Kode", item.Kode, BinaryOperatorType.Equal), New InOperator("DetailMain.Main.Sumber", {Persistent.SumberDataJenis.AM, Persistent.SumberDataJenis.CW})))

      For i = 0 To x.Count - 1
        Dim xo = x(i)
        Dim o = orderItem.Where(Function(w) w.Serial = xo.Serial).Sum(Function(s) s.Length)
        Dim loProduksi = DataProduksi.Where(Function(w) w.Serial = xo.Serial).Sum(Function(s) s.LengthOut)

        'xo.LengthOut += o

        '==== edit sbm 03-Mar-2021
        '==== Tambahkan Length SN yang belum diproduksi tp didempyou dikurangi Length SN yang sudah diproduksi
        If o <> 0 Then
          xo.LengthOut += (o - loProduksi) '==== end edit jali 14-Maret-2022 ================
          'xo.LengthOut += (o - xo.LengthOut)
        End If
      Next

      Return x
    End Function

    Public Shared Function GetScrapData(session As UnitOfWork) As List(Of NonPersistent.Fusoh_DataSerial)
      Dim scrap = New XPQuery(Of Fusoh_StokSerial)(session).Where(Function(w) w.Scrap) _
        .GroupBy(Function(g) New With {g.DetailMain.Barang, g.Serial}).ToList
      Dim x As New List(Of NonPersistent.Fusoh_DataSerial)

      For Each item In scrap
        Dim serial = New XPQuery(Of Fusoh_StokSerial)(session).Where(Function(w) w.DetailMain.Barang Is item.Key.Barang AndAlso w.Serial = item.Key.Serial) _
        .GroupBy(Function(g) g.Serial).ToList _
        .Select(Function(s) New NonPersistent.Fusoh_DataSerial With {
          .Id = s.FirstOrDefault.Id,
          .LengthIn = s.Sum(Function(e) e.LengthIn),
          .LengthOut = s.Sum(Function(e) e.LengthOut),
          .MillSheet = s.FirstOrDefault.MillSheet,
          .Serial = s.Key,
          .Barang = s.Min(Function(e) e.DetailMain.Barang),
          .Weight = s.Average(Function(e) e.DetailMain.Weight),
          .Qty = s.Sum(Function(e) e.Qty),
          .TanggalDatang = s.Min(Function(e) e.DetailMain.Main.Tanggal)
        }).ToList

        x.AddRange(serial)
      Next

      Return x
    End Function
  End Class

  Public Class HPP
    Public Shared Function CheckDempyou(session As UnitOfWork, xIDSO As Long) As Boolean
      'Dim xDempyou = New XPQuery(Of Fusoh_StokSerial)(Session) _
      '        .Where(Function(w) w.DetailMain.Barang Is Item.Key AndAlso Item.Value.Contains(w.Serial) AndAlso w.LengthOut > 0) _
      '        .GroupBy(Function(g) g.DetailMain.Main).Select(Function(s) s.Key).ToList
      'Dim xdtDempyou As New XPCollection(Of Fusoh_OrderProduksi(session)
      Dim xDempyou = New XPQuery(Of Fusoh_OrderProduksi)(session).Where(Function(w) w.SODetail.Main.Id = xIDSO).ToList
      Return xDempyou.Count > 0
    End Function

    Public Shared Sub HitungUlangHPPDariSerial(session As UnitOfWork, data As List(Of KeyValuePair(Of Fusoh_Barang, List(Of String))))
      '====== cari produksi (qty keluar)
      Try
        If data.Count > 0 Then
          For Each item In data
            Dim amSerial = New XPQuery(Of Fusoh_StokSerial)(session) _
              .Where(Function(w) w.DetailMain.Barang Is item.Key AndAlso item.Value.Contains(w.Serial) AndAlso w.LengthOut > 0) _
              .GroupBy(Function(g) g.DetailMain.Main).Select(Function(s) s.Key).ToList

            For Each prod In amSerial
              HitungHPPDariProduksi(prod, False)
            Next
          Next
        End If
      Catch ex As Exception
        Throw New Exception(ex.Message, ex.InnerException)
      End Try
    End Sub
    'Public Shared Sub HitungUlangHPPDariSerial(session As UnitOfWork, data As List(Of KeyValuePair(Of Fusoh_Barang, String)))
    '	'====== cari produksi (qty keluar)
    '	Try
    '		For Each item In data
    '			Dim amSerial = New XPQuery(Of Fusoh_StokSerial)(session) _
    '				.Where(Function(w) w.DetailMain.Barang Is item.Key AndAlso w.Serial = item.Value AndAlso w.LengthOut > 0) _
    '				.GroupBy(Function(g) g.DetailMain.Main).Select(Function(s) s.Key).ToList

    '			For Each prod In amSerial
    '				HitungHPPDariProduksi(prod, False)
    '			Next
    '		Next
    '	Catch ex As Exception
    '		Throw New Exception(ex.Message, ex.InnerException)
    '	End Try
    'End Sub
    Friend Shared Function GetHPPBahanBakuPerQty(session As UnitOfWork, EximDetailId As Long) As Double
      '==== Jika saldo awal ambil harga dari harga saldo awal
      Dim detInvoice = New XPQuery(Of Fusoh_PenerimaanInvoiceDetail)(session) _
            .Where(Function(w) w.EximDetail.Id = EximDetailId).SingleOrDefault

      If (Not detInvoice Is Nothing) Then
        Dim hargaBeli = (detInvoice.DPP / detInvoice.Qty) * detInvoice.Main.Kurs
        Dim totalCostSheet = detInvoice.Main.TotalCost
        Dim totalWeight = detInvoice.Main.NoExim.TotalWeight
        'Dim biayaCost = (totalCostSheet / totalWeight) * detInvoice.EximDetail.Weight
        Dim biayaCost = detInvoice.TotalPembelianIDR

        Return (biayaCost / detInvoice.Qty)
      Else
        Return 0
      End If

    End Function
    Public Shared Sub HitungHPPDariProduksi(session As UnitOfWork, IdProduksi As Long, autoCommit As Boolean)
      Dim prod = session.GetObjectByKey(Of Fusoh_StokMain)(IdProduksi)
      HitungHPPDariProduksi(prod, autoCommit)
    End Sub
    Friend Shared Function HitungHPPDariProduksi(produksiAM As Fusoh_StokMain, autoCommit As Boolean) As String
      Try
        '===== hitung hpp keluar
        'Dim hppKeluar = produksiAM.Detail.Where(Function(w) w.QtyOut > 0)
        Dim hppKeluar = produksiAM.Detail.Where(Function(w) w.TotalLengthOut > 0 OrElse (w.Barang.TipeBarang = TipeBarang.BahanWIP AndAlso w.QtyOut > 0))
        Dim totalHPPKeluar As Double = 0
        Dim xJali As String

        xJali = "No Transaksi : " & produksiAM.Kode & vbCrLf
        For Each detail In hppKeluar
          xJali = xJali & "Kode Part : " & detail.Barang.Kode & " --> " & detail.QtyOut.ToString("n2") & " Serial : " & detail.Serial.Count & vbCrLf
          Dim totalHPPPerItem As Double = 0
          For Each serial In detail.Serial '===== hitung per serial
            '===== cari penerimaan
            Dim grSerial = New XPQuery(Of Fusoh_StokSerial)(produksiAM.Session) _
              .Where(Function(w) w.DetailMain.Barang Is serial.DetailMain.Barang _
              AndAlso w.Serial = serial.Serial AndAlso w.LengthIn > 0) _
              .ToList.Take(1).SingleOrDefault

						If Not grSerial Is Nothing Then
              Dim hppPerQty As Double = 0
              '===== cari hpp per qty
              If (grSerial.DetailMain.EximDetail Is Nothing) Then
                xJali = xJali & "Ambilkan dari Exim : " & grSerial.DetailMain.Main.Kode & vbCrLf
                hppPerQty = grSerial.DetailMain.Harga
              Else
                '=== ambil dari invoice
                xJali = xJali & "Ambilkan dari IV Pembelian : exim ID = " & grSerial.DetailMain.EximDetail.Id & vbCrLf
                xJali = xJali & "Nilai : " & GetHPPBahanBakuPerQtyStr(produksiAM.Session, grSerial.DetailMain.EximDetail.Id) & vbCrLf
                hppPerQty = GetHPPBahanBakuPerQty(produksiAM.Session, grSerial.DetailMain.EximDetail.Id)
              End If

              '===== hpp per length serial
              If (grSerial.DetailMain.Length = 0) Then
                totalHPPPerItem += 0
              Else
                xJali = xJali & "SN No : " & grSerial.Serial & " : " & ((hppPerQty / grSerial.LengthIn) * serial.LengthOut).ToString("n2") & "=(" & hppPerQty.ToString("n2") & " / " & grSerial.LengthIn.ToString("n2") & ") * " & serial.LengthOut.ToString & vbCrLf
                totalHPPPerItem += (hppPerQty / grSerial.LengthIn) * serial.LengthOut
              End If
            End If
          Next
          If detail.Barang.TipeBarang = TipeBarang.BahanWIP Then
            If Not produksiAM.CuttingWIP Is Nothing Then
              Dim harga = produksiAM.CuttingWIP.Detail.Where(Function(w) w.QtyIn > 0).Sum(Function(s) s.Harga)
              detail.Harga = harga
              totalHPPPerItem = harga * detail.QtyOut
							xJali = xJali & "++ No ProduksiAM : " & produksiAM.CuttingWIP.Kode & "-->" & totalHPPPerItem & "(" & harga & " * " & detail.QtyOut & ")" & vbCrLf
						End If
					ElseIf detail.QtyOut > 0 Then
            detail.Harga = totalHPPPerItem / detail.QtyOut
          End If
          detail.TotalHPP = totalHPPPerItem
          totalHPPKeluar += totalHPPPerItem
          xJali = xJali & "---------Total HPP : " & totalHPPPerItem.ToString("n2") & "-->" & detail.QtyOut.ToString("n2") & vbCrLf
        Next

        '===== hitung hpp masuk
        Dim hppMasuk = produksiAM.Detail.Where(Function(w) w.QtyIn > 0)
        xJali = xJali & "Totalnya adalah : " & totalHPPKeluar.ToString("n2") & vbCrLf & "akan dibagikan ke total qty " & hppMasuk.Sum(Function(s) s.QtyIn).ToString("n2") & vbCrLf
        Dim totalHPPMasukPerQty As Double = totalHPPKeluar / hppMasuk.Sum(Function(s) s.QtyIn)

        'jika dari CW, edit harga di AM
        If produksiAM.Sumber.Id = SumberDataJenis.CW Then
          'update harga bahan WIP (masuk) di CW
          For Each detail In hppMasuk
            'MsgBox("1 = " & detail.Main.Kode & ", id " & detail.Id)
            detail.Harga = totalHPPMasukPerQty
          Next

          Dim AM = produksiAM.Session.FindObject(Of Fusoh_StokMain)(New BinaryOperator("CuttingWIP", produksiAM.Id, BinaryOperatorType.Equal))
          If Not AM Is Nothing Then
            'update harga bahan WIP (keluar) di AM
            Dim AMKeluar = AM.Detail.Where(Function(w) w.QtyOut > 0)
            For Each detail In AMKeluar
              detail.Harga = totalHPPMasukPerQty
              detail.TotalHPP = totalHPPMasukPerQty * detail.QtyOut
            Next
            'set hpp masuk dari AM
            hppMasuk = AM.Detail.Where(Function(w) w.QtyIn > 0)
          End If
        End If

        'hppMasuk dari AM
        For Each detail In hppMasuk
          'MsgBox("2 = " & detail.Main.Kode & ", id " & detail.Id)
          'update harga bahan jadi AM
          detail.Harga = totalHPPMasukPerQty
          'nah, carikan untuk pengirimannya SJ ini, dan lakukan edit harga
          Dim xSJ As New XPCollection(Of Fusoh_StokDetail)(produksiAM.Session, New BinaryOperator("ProduksiDetail.Id", detail.Id, BinaryOperatorType.Equal))
          For pK = 0 To xSJ.Count - 1
            xSJ(pK).Harga = totalHPPMasukPerQty
            xSJ(pK).TotalHPP = totalHPPMasukPerQty * xSJ(pK).QtyOut
          Next
        Next

        '===== commit
        If autoCommit Then
          produksiAM.Session.CommitChanges()
        End If
        Return xJali
      Catch ex As Exception
        Throw New Exception(ex.Message, ex.InnerException)
      End Try
    End Function
    Private Shared Function GetHPPBahanBakuPerQtyStr(session As UnitOfWork, EximDetailId As Long) As String
      '==== Jika saldo awal ambil harga dari harga saldo awal
      Dim detInvoice = New XPQuery(Of Fusoh_PenerimaanInvoiceDetail)(session) _
          .Where(Function(w) w.EximDetail.Id = EximDetailId).SingleOrDefault

      If (Not detInvoice Is Nothing) Then
        'Dim hargaBeli = (detInvoice.DPP / detInvoice.Qty) * detInvoice.Main.Kurs
        'Dim totalCostSheet = detInvoice.Main.TotalCost
        'Dim totalWeight = detInvoice.Main.NoExim.TotalWeight
        'Dim biayaCost = (totalCostSheet / totalWeight) * detInvoice.EximDetail.Weight

        '==jali 15-juli
        Dim hargaBeli = (detInvoice.DPP / detInvoice.Qty) * detInvoice.Main.Kurs
        Dim totalCostSheet = detInvoice.Main.TotalCost
        Dim totalWeight = detInvoice.Main.NoExim.TotalWeight
        Dim biayaCost = detInvoice.TotalPembelianIDR

				' MsgBox("NIlainya adalah : " & hargaBeli + (biayaCost / detInvoice.Qty) & "-->" & hargaBeli & "+ (" & biayaCost & "/" & detInvoice.Qty & ")")
				' MsgBox("NIlainya adalah : " & (biayaCost / detInvoice.Qty) & "-->(" & biayaCost & "/" & detInvoice.Qty & ")")

				Return detInvoice.Main.Kode & " : " & (biayaCost / detInvoice.Qty).ToString & " --> " & biayaCost.ToString("n2") & "/" & detInvoice.Qty.ToString & vbCrLf &
							 "TotalPembelian : " & detInvoice.TotalIDR.ToString & " + " & detInvoice.TotalCostIDR.ToString & vbCrLf &
							 "TotalCostIDR :" & detInvoice.TotalCostBukanImportDutyIDR.ToString & " + " & detInvoice.TotalCostImportDutyIDR.ToString & vbCrLf &
							 "TotalCostBukanImportDutyIDR :" & detInvoice.Id & "(" & detInvoice.Weight & " / " & detInvoice.Main.TotalWeight & ") * " & detInvoice.Main.TotalCostBukanImportDutyIDR
			Else
        Return "0"
      End If
    End Function
  End Class

  Public Class FusohWIPSetting
    Inherits Core.Modules.SettingBase

    Property BarangWIP As Int64
    Property TanggalMulaiWIP As DateTime
    Sub New(session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Overrides Function ModuleId() As NPO.Modules.ModuleId
      Return MainClass.GetModuleId
    End Function
  End Class
End Namespace

Namespace Persistent
  'Public Enum Fusoh_MaterialProses
  '  <EnumDescription("Cutting")> Cutting
  '  <EnumDescription("Cutting & Processing")> CuttingProcessing
  '<EnumDescription("Cutting & QT & Processing")> CuttingQTProcessing

  '<EnumDescription("Cutting, Champer")> CuttingCamper

  '<EnumDescription("Cutting, Process, No Drill")> CuttingProsesNoDrill
  '<EnumDescription("Cutting, Process, Drill")> CuttingProsesDrill

  '<EnumDescription("Cutting, HT, Processing")> CuttingHTProses
  '  <EnumDescription("Cutting, Processing, HT")> CuttingProsesHT
  '  <EnumDescription("Cutting, Processing, HT, Processing")> CuttingProsesHTProses
  'End Enum

  <Persistent("m04bitem")>
  Public Class Fusoh_Barang
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Protected Overrides Sub OnSaving()
      If CheckData() Then
        MyBase.OnSaving()
      End If
    End Sub
    Private Function CheckData() As Boolean
      Const sumber As String = "Master Item"
      If _Kode = Nothing Then
        Throw New Utils.Exception("Masukkan kode barang", -1, "", sumber)
        Return False
      End If
      If _Nama Is Nothing Then
        Throw New Utils.Exception("Masukkan nama barang", -2, "", sumber)
        Return False
      End If
      If _UOM Is Nothing Then
        Throw New Utils.Exception("Masukkan satuan", -3, "", sumber)
        Return False
      End If
      If _UOMD Is Nothing Then
        Throw New Utils.Exception("Masukkan satuan dasar", -4, "", sumber)
        Return False
      End If
      If _Currrency Is Nothing Then
        Throw New Utils.Exception("Masukkan mata uang", -5, "", sumber)
        Return False
      End If
      If _CoaStock Is Nothing Then
        Throw New Utils.Exception("Masukkan nomor coa untuk Persediaan", -7, "", sumber)
        Return False
      End If
      If _CoaIncome Is Nothing Then
        Throw New Utils.Exception("Masukkan nomor coa untuk Pendapatan", -8, "", sumber)
        Return False
      End If
      If _CoaCost Is Nothing Then
        Throw New Utils.Exception("Masukkan nomor coa untuk Biaya [HPP]", -9, "", sumber)
        Return False
      End If
      If _PajakIn Is Nothing Then
        Throw New Utils.Exception("Masukkan Pajak Masukan", -10, "", sumber)
        Return False
      End If
      If _PajakOut Is Nothing Then
        Throw New Utils.Exception("Masukkan Pajak Keluaran", -11, "", sumber)
        Return False
      End If
      If _outDiameter = 0 Then
        Throw New Utils.Exception("Masukkan Out Diameter", -12, "", sumber)
        Return False
      End If
      If _inDiameter = 0 Then
        Throw New Utils.Exception("Masukkan In Diameter", -13, "", sumber)
        Return False
      End If
      'If _thickness = 0 Then
      '	Throw New Utils.Exception("Masukkan Thickness", -13, "", sumber)
      '	Return False
      'End If
      If _length = 0 Then
        Throw New Utils.Exception("Masukkan Length", -14, "", sumber)
        Return False
      End If

      Return True
    End Function

    <Indexed("Kode", Unique:=True)>
    Private _Id As Int64
    Private _Kode As String
    Private _Nama As String
    Private _Jenis As JenisBarang
    Private _Tipe As TipeBarang
    Private _UOM As Satuan
    Private _UOMD As Satuan
    Private _Currrency As NuSoft001.Persistent.MataUang
    Private _Currency2 As NPO.Modules.ModSys.Divisi
    Private _HargaBeli As Double
    Private _HargaJual1 As Double
    Private _HargaJual2 As Double
    Private _HargaJual3 As Double
    Private _HargaJual4 As Double
    Private _HargaJual5 As Double
    Private _PajakIn As Pajak
    Private _PajakOut As Pajak
    Private _CoaIncome As NuSoft001.Persistent.Coa
    Private _CoaCost As NuSoft001.Persistent.Coa
    Private _CoaStock As NuSoft001.Persistent.Coa
    Private _CoaDiscIn As NuSoft001.Persistent.Coa
    Private _CoaDiscOut As NuSoft001.Persistent.Coa
    Private _CoaReturIn As NuSoft001.Persistent.Coa
    Private _CoaReturOut As NuSoft001.Persistent.Coa
    Private _StockMax As Double
    Private _StockMin As Double
    Private _StockCurrent As Double
    Private _active As Boolean
    Private _stockorder As Double
    Private _kategori As Kategori
    Private _subkategori As SubKategori
    Private _merk As Merk
    Private _note As String
    Private _custom1 As String
    Private _custom2 As String
    Private _custom3 As String
    Private _custom4 As String
    Private _custom5 As String
    Private _custom6 As String
    Private _custom7 As String
    Private _custom8 As String
    Private _custom9 As String
    Private _custom10 As String
    Private _outDiameter As Decimal
    Private _inDiameter As Decimal
    Private _thickness As Decimal
    Private _length As Decimal
    Private _weight As Decimal
    Private _customer As Kontak
    Private _gambar As Byte()
    Private _materialProses As Fusoh_ProcessCutting 'Fusoh_MaterialProses
    Private _odCutting As Decimal
    Private _idCutting As Decimal
    Private _thicknessCutting As Decimal
    Private _lengthCutting As Decimal
    Private _namaPart As String
    Private _kenaImportDuty As Boolean
    Private _BarangTitipan As Boolean

    <Persistent("p_id"), Key(True)> Property Id As Int64
      Get
        Return _Id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _Id, value)
      End Set
    End Property
    <Persistent("u_code")> Property Kode As String
      Get
        Return _Kode
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kode", _Kode, value)
      End Set
    End Property
    <Persistent("d_name")> Property Nama As String
      Get
        Return _Nama
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Nama", _Nama, value)
      End Set
    End Property
    <Persistent("f_uom")> Property Satuan As Satuan
      Get
        Return _UOM
      End Get
      Set(value As Satuan)
        SetPropertyValue(Of Satuan)("Satuan", _UOM, value)
      End Set
    End Property
    <Persistent("f_uomd")> Property SatuanD As Satuan
      Get
        Return _UOMD
      End Get
      Set(value As Satuan)
        SetPropertyValue(Of Satuan)("SatuanD", _UOMD, value)
      End Set
    End Property
    <Persistent("d_jenis")> Property Jenis As JenisBarang
      Get
        Return _Jenis
      End Get
      Set(value As JenisBarang)
        SetPropertyValue(Of JenisBarang)("Jenis", _Jenis, value)
      End Set
    End Property
    <Persistent("d_tipe")> Property TipeBarang As TipeBarang
      Get
        Return _Tipe
      End Get
      Set(value As TipeBarang)
        SetPropertyValue(Of TipeBarang)("Jenis", _Tipe, value)
      End Set
    End Property
    <Persistent("f_curency")> Property Uang As NuSoft001.Persistent.MataUang
      Get
        Return _Currrency
      End Get
      Set(value As NuSoft001.Persistent.MataUang)
        SetPropertyValue(Of NuSoft001.Persistent.MataUang)("Uang", _Currrency, value)
      End Set
    End Property
    <Persistent("d_pricelastpurchase")> Property LastPurchase As Double
      Get
        Return _HargaBeli
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("LastPurchase", _HargaBeli, value)
      End Set
    End Property
    <Persistent("d_priceselling1")> Property HargaJual1 As Double
      Get
        Return _HargaJual1
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaJual1", _HargaJual1, value)
      End Set
    End Property
    <Persistent("d_priceselling2")> Property HargaJual2 As Double
      Get
        Return _HargaJual2
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaJual2", _HargaJual2, value)
      End Set
    End Property
    <Persistent("d_priceselling3")> Property HargaJual3 As Double
      Get
        Return _HargaJual3
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaJual3", _HargaJual3, value)
      End Set
    End Property
    <Persistent("d_priceselling4")> Property HargaJual4 As Double
      Get
        Return _HargaJual4
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaJual4", _HargaJual4, value)
      End Set
    End Property
    <Persistent("d_priceselling5")> Property HargaJual5 As Double
      Get
        Return _HargaJual5
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaJual5", _HargaJual5, value)
      End Set
    End Property
    <Persistent("f_taxin")> Property PajakIN As Pajak
      Get
        Return _PajakIn
      End Get
      Set(value As Pajak)
        SetPropertyValue(Of Pajak)("PajakIN", _PajakIn, value)
      End Set
    End Property
    <Persistent("f_taxout")> Property PajakOUT As Pajak
      Get
        Return _PajakOut
      End Get
      Set(value As Pajak)
        SetPropertyValue(Of Pajak)("PajakOUT", _PajakOut, value)
      End Set
    End Property
    <Persistent("f_coaincome")> Property CoaIncome As NuSoft001.Persistent.Coa
      Get
        Return _CoaIncome
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaIncome", _CoaIncome, value)
      End Set
    End Property
    <Persistent("f_coacost")> Property CoaCost As NuSoft001.Persistent.Coa
      Get
        Return _CoaCost
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaCost", _CoaCost, value)
      End Set
    End Property
    <Persistent("f_coastock")> Property CoaStock As NuSoft001.Persistent.Coa
      Get
        Return _CoaStock
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaStock", _CoaStock, value)
      End Set
    End Property
    <Persistent("f_coadiscincome")> Property CoaDiscIncome As NuSoft001.Persistent.Coa
      Get
        Return _CoaDiscIn
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaDiscIncome", _CoaDiscIn, value)
      End Set
    End Property
    <Persistent("f_coadisccost")> Property CoaDiscOut As NuSoft001.Persistent.Coa
      Get
        Return _CoaDiscOut
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaDiscOut", _CoaDiscOut, value)
      End Set
    End Property
    <Persistent("f_coareturnincome")> Property CoaReturnIn As NuSoft001.Persistent.Coa
      Get
        Return _CoaReturIn
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaReturnIn", _CoaReturIn, value)
      End Set
    End Property
    <Persistent("f_coareturncost")> Property CoaReturnOut As NuSoft001.Persistent.Coa
      Get
        Return _CoaReturOut
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaReturnOut", _CoaReturOut, value)
      End Set
    End Property
    <Persistent("d_stockmax")> Property StockMax As Double
      Get
        Return _StockMax
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("StockMax", _StockMax, value)
      End Set
    End Property
    <Persistent("d_stockmin")> Property StockMin As Double
      Get
        Return _StockMin
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("StockMin", _StockMin, value)
      End Set
    End Property
    <Persistent("d_stockcurrent")> Property StockCurrent As Double
      Get
        Return _StockCurrent
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("StockCurrent", _StockCurrent, value)
      End Set
    End Property
    <Persistent("d_aktif")> Property Aktif As Boolean
      Get
        Return _active
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Aktif", _active, value)
      End Set
    End Property
    <Persistent("d_titipan")> Property BatangTitipan As Boolean
      Get
        Return _BarangTitipan
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("BatangTitipan", _BarangTitipan, value)
      End Set
    End Property
    <Persistent("d_stokreorder")> Property StockOrder As Double
      Get
        Return _stockorder
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("StockOrder", _stockorder, value)
      End Set
    End Property
    <Persistent("f_kategori")> Property Kategori As Kategori
      Get
        Return _kategori
      End Get
      Set(value As Kategori)
        SetPropertyValue(Of Kategori)("Kategori", _kategori, value)
      End Set
    End Property
    <Persistent("f_subkategori")> Property SubKategori As SubKategori
      Get
        Return _subkategori
      End Get
      Set(value As SubKategori)
        SetPropertyValue(Of SubKategori)("SubKategori", _subkategori, value)
      End Set
    End Property
    <Persistent("f_merk")> Property Merk As Merk
      Get
        Return _merk
      End Get
      Set(value As Merk)
        SetPropertyValue(Of Merk)("Merk", _merk, value)
      End Set
    End Property
    <Persistent("d_note")> Property Note As String
      Get
        Return _note
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Note", _note, value)
      End Set
    End Property
    <Persistent("d_custom1")> Property Custom1 As String
      Get
        Return _custom1
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("HargaJual5", _custom1, value)
      End Set
    End Property
    <Persistent("d_custom2")> Property Custom2 As String
      Get
        Return _custom2
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom2", _custom2, value)
      End Set
    End Property
    <Persistent("d_custom3")> Property Custom3 As String
      Get
        Return _custom3
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom3", _custom3, value)
      End Set
    End Property
    <Persistent("d_custom4")> Property Custom4 As String
      Get
        Return _custom4
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom4", _custom4, value)
      End Set
    End Property
    <Persistent("d_custom5")> Property Custom5 As String
      Get
        Return _custom5
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom5", _custom5, value)
      End Set
    End Property
    <Persistent("d_custom6")> Property Custom6 As String
      Get
        Return _custom6
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom6", _custom6, value)
      End Set
    End Property
    <Persistent("d_custom7")> Property Custom7 As String
      Get
        Return _custom7
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom7", _custom7, value)
      End Set
    End Property
    <Persistent("d_custom8")> Property Custom8 As String
      Get
        Return _custom8
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom8", _custom8, value)
      End Set
    End Property
    <Persistent("d_custom9")> Property Custom9 As String
      Get
        Return _custom9
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom9", _custom9, value)
      End Set
    End Property
    <Persistent("d_custom10")> Property Custom10 As String
      Get
        Return _custom10
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom10", _custom10, value)
      End Set
    End Property
    <Persistent("d_od")> Property OutDiameter As Decimal
      Get
        Return _outDiameter
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("OutDiameter", _outDiameter, value)
      End Set
    End Property
    <Persistent("d_id")> Property InDiameter As Decimal
      Get
        Return _inDiameter
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("InDiameter", _inDiameter, value)
      End Set
    End Property
    <Persistent("d_ticknes")> Property Thickness As Decimal
      Get
        Return _thickness
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Thickness", _thickness, value)
      End Set
    End Property
    <Persistent("d_length")> Property Length As Decimal
      Get
        Return _length
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Length", _length, value)
      End Set
    End Property
    <Persistent("d_weight")> Property Weight As Decimal
      Get
        Return _weight
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Weight", _weight, value)
      End Set
    End Property
    <Persistent("f_customer")> Property Customer As Kontak
      Get
        Return _customer
      End Get
      Set(value As Kontak)
        SetPropertyValue(Of Kontak)("Customer", _customer, value)
      End Set
    End Property
    <Persistent("d_picture")> Property Gambar As Byte()
      Get
        Return _gambar
      End Get
      Set(ByVal value As Byte())
        SetPropertyValue(Of Byte())("Blob", _gambar, value)
      End Set
    End Property
    <NonPersistent()> Property Image As System.Drawing.Image
      Get
        If Gambar Is Nothing Then
          Return Nothing
        Else
          Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream(_gambar)
          Dim returnImage As System.Drawing.Image = Drawing.Image.FromStream(ms)
          Return returnImage
        End If
      End Get
      Set(ByVal value As System.Drawing.Image)
        Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream()
        'Dim frt As System.Drawing.Imaging.ImageFormat
        'frt = System.Drawing.Imaging.ImageFormat.Gif
        value.Save(ms, value.RawFormat)
        Gambar = ms.ToArray
      End Set
    End Property

    '<PersistentAlias("concat('OD=', OutDiameter,'; ID=', InDiameter,'; T=',Thickness,'; L=', Length)")> ReadOnly Property Spesifikasi As String
    '	Get
    '		Return EvaluateAlias("Spesifikasi").ToString
    '	End Get
    'End Property

    <Persistent("d_materialproses")> Property MaterialProses As Fusoh_ProcessCutting
      Get
        Return _materialProses
      End Get
      Set(value As Fusoh_ProcessCutting)
        SetPropertyValue(Of Fusoh_ProcessCutting)("MaterialProses", _materialProses, value)
      End Set
    End Property
    <Persistent("d_odcutting")> Property ODCutting As Decimal
      Get
        Return _odCutting
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("ODCutting", _odCutting, value)
      End Set
    End Property
    <Persistent("d_idcutting")> Property IDCutting As Decimal
      Get
        Return _idCutting
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("IDCutting", _idCutting, value)
      End Set
    End Property
    <Persistent("d_thicknesscutting")> Property ThicknessCutting As Decimal
      Get
        Return _thicknessCutting
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("ThicknessCutting", _thicknessCutting, value)
      End Set
    End Property
    <Persistent("d_lengthcutting")> Property LengthCutting As Decimal
      Get
        Return _lengthCutting
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("LengthCutting", _lengthCutting, value)
      End Set
    End Property
    <Persistent("d_namapart")> Property NamaPart As String
      Get
        Return _namaPart
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NamaPart", _namaPart, value)
      End Set
    End Property
    <Persistent("d_isimportduty")> Property KenaImportDuty As Boolean
      Get
        Return _kenaImportDuty
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("KenaImportDuty", _kenaImportDuty, value)
      End Set
    End Property
    <NonPersistent()> ReadOnly Property SizeLengkap As String
      Get
        Return Length.ToString & " x " & OutDiameter.ToString
      End Get
    End Property
    <NonPersistent()> ReadOnly Property FGSize As String
      Get
        Return Nama + " " + OutDiameter.ToString("n0") + "x" + Thickness.ToString("n1") & "x" & Length.ToString("n1")
      End Get
    End Property

    <Association("fk_fusoh_item_location"), Aggregated> ReadOnly Property ItemLocation As XPCollection(Of Fusoh_BarangLokasi)
      Get
        Return GetCollection(Of Fusoh_BarangLokasi)("ItemLocation")
      End Get
    End Property
    <Association("fk_fusoh_item_penyusun"), Aggregated> ReadOnly Property ItemPenyusun As XPCollection(Of Fusoh_BarangAssembly)
      Get
        Return GetCollection(Of Fusoh_BarangAssembly)("ItemPenyusun")
      End Get
    End Property
  End Class
  <Persistent("m04citemlocation")>
  Public Class Fusoh_BarangLokasi
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _barang As Fusoh_Barang
    Private _gudang As Gudang
    Private _lokasi As String
    <Persistent("primary_main"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_fusoh_item_location")> Property Barang As Fusoh_Barang
      Get
        Return _barang
      End Get
      Set(value As Fusoh_Barang)
        SetPropertyValue(Of Fusoh_Barang)("Barang", _barang, value)
      End Set
    End Property
    <Persistent("f_warehouse")> Property Gudang As Gudang
      Get
        Return _gudang
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("Telepon", _gudang, value)
      End Set
    End Property
    <Persistent("d_location"), Size(50)> Property Lokasi As String
      Get
        Return _lokasi
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Lokasi", _lokasi, value)
      End Set
    End Property
  End Class
  <Persistent("m04citemassembly")>
  Public Class Fusoh_BarangAssembly
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _barang As Fusoh_Barang
    Private _barangpenyusun As Fusoh_Barang
    Private _qty As Double
    Private _satuan As Satuan
    Private _catatan As String
    <Persistent("p_id"), Key(True)> Property Id As Int32
      Get
        Return _id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("Id", _id, value)
      End Set
    End Property
    <Persistent("f_item"), Association("fk_fusoh_item_penyusun")> Property Barang As Fusoh_Barang
      Get
        Return _barang
      End Get
      Set(value As Fusoh_Barang)
        SetPropertyValue(Of Fusoh_Barang)("Barang", _barang, value)
      End Set
    End Property
    <Persistent("f_itemconstituent")> Property BarangPenyusun As Fusoh_Barang
      Get
        Return _barangpenyusun
      End Get
      Set(value As Fusoh_Barang)
        SetPropertyValue(Of Fusoh_Barang)("BarangPenyusun", _barangpenyusun, value)
      End Set
    End Property

    <Persistent("f_uom")> Property Satuan As Satuan
      Get
        Return _satuan
      End Get
      Set(value As Satuan)
        SetPropertyValue(Of Satuan)("Satuan", _satuan, value)
      End Set
    End Property
    <Persistent("d_qty")> Property Qty As Double
      Get
        Return _qty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qty, value)
      End Set
    End Property
    <Persistent("d_remarks"), Size(50)> Property Catatan As String
      Get
        Return _catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _catatan, value)
      End Set
    End Property
  End Class

  <Persistent("m04cstockmain")> Friend Class Fusoh_StokMain
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _pelanggan As NuSoft001.Persistent.Kontak
    Private _gudang As Gudang
    Private _uraian As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _kontakperson As String
    Private _karyawan As NuSoft001.Persistent.Kontak
    Private _gudang2 As Gudang
    Private _orderProduksi As Fusoh_OrderProduksi
    Private _so As Fusoh_OrderPenjualan
    Private _cuttingWIP As Fusoh_StokMain
    Private _dempyouLot As String
    Private _kurs As Double
    Private _cuttingMesin As Fusoh_Mesin
    Private _cuttingShift As Integer
    Private _cuttingProcess As Fusoh_ProcessCutting

    <Persistent("f_contact")> Property Pelanggan As NuSoft001.Persistent.Kontak
      Get
        Return _pelanggan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _pelanggan, value)
      End Set
    End Property
    <Persistent("f_warehouse")> Property Gudang As NuSoft004.Persistent.Gudang
      Get
        Return _gudang
      End Get
      Set(value As NuSoft004.Persistent.Gudang)
        SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang", _gudang, value)
      End Set
    End Property
    <Persistent("d_remarks")> Property Catatan As String
      Get
        Return _uraian
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Uraian", _uraian, value)
      End Set
    End Property
    <Persistent("d_status")> Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
      End Set
    End Property
    <Persistent("d_person")> Property KontakPerson As String
      Get
        Return _kontakperson
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("KontakPerson", _kontakperson, value)
      End Set
    End Property
    <Persistent("f_employee")> Property Karyawan As NuSoft001.Persistent.Kontak
      Get
        Return _karyawan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _karyawan, value)
      End Set
    End Property
    <Persistent("d_kurs")> Property Kurs As Double
      Get
        Return _kurs
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Kurs", _kurs, value)
      End Set
    End Property
    <Persistent("f_warehouse2")> Property Gudang2 As Gudang
      Get
        Return _gudang2
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("Gudang2", _gudang2, value)
      End Set
    End Property
    <Persistent("f_iddempyou")> Property OrderProduksi As Fusoh_OrderProduksi
      Get
        Return _orderProduksi
      End Get
      Set(value As Fusoh_OrderProduksi)
        SetPropertyValue(Of Fusoh_OrderProduksi)("OrderProduksi", _orderProduksi, value)
      End Set
    End Property
    '<Persistent("p_id"), Association("fk_orderproduksi_bahanbaku")> Property Main As Fusoh_OrderProduksi
    '  Get
    '    Return _main
    '  End Get
    '  Set(value As Fusoh_OrderProduksi)
    '    SetPropertyValue(Of Fusoh_OrderProduksi)("Main", _main, value)
    '  End Set
    'End Property
    <Persistent("f_idcuttingwip"), Association("fk_fusohstokmain_produksi")> Property CuttingWIP As Fusoh_StokMain
      Get
        Return _cuttingWIP
      End Get
      Set(value As Fusoh_StokMain)
        SetPropertyValue(Of Fusoh_StokMain)("CuttingWIP", _cuttingWIP, value)
      End Set
    End Property

    Property CuttingMesin As Fusoh_Mesin
      Get
        Return _cuttingMesin
      End Get
      Set(value As Fusoh_Mesin)
        SetPropertyValue(Of Fusoh_Mesin)("CuttingMesin", _cuttingMesin, value)
      End Set
    End Property
    Property CuttingShift As Integer
      Get
        Return _cuttingShift
      End Get
      Set(value As Integer)
        SetPropertyValue(Of Integer)("CuttingShift", _cuttingShift, value)
      End Set
    End Property
    Property CuttingProcess As Fusoh_ProcessCutting
      Get
        Return _cuttingProcess
      End Get
      Set(value As Fusoh_ProcessCutting)
        SetPropertyValue(Of Fusoh_ProcessCutting)("CuttingProcess", _cuttingProcess, value)
      End Set
    End Property

    <Persistent("f_idso")> Property SO As Fusoh_OrderPenjualan
      Get
        Return _so
      End Get
      Set(value As Fusoh_OrderPenjualan)
        SetPropertyValue(Of Fusoh_OrderPenjualan)("SO", _so, value)
      End Set
    End Property
    <Persistent("d_dempyoulot")> Property DempyouLot As String
      Get
        Return _dempyouLot
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("DempyouLot", _dempyouLot, value)
      End Set
    End Property

    <Association("fk_fusohstokmain_fusohstokdetail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_StokDetail)
      Get
        Return GetCollection(Of Fusoh_StokDetail)("Detail")
      End Get
    End Property
    <Association("fk_fusohstokmain_produksi"), Aggregated> ReadOnly Property DetailProduksi As XPCollection(Of Fusoh_StokMain)
      Get
        Return GetCollection(Of Fusoh_StokMain)("DetailProduksi")
      End Get
    End Property
    <Association("fk_04ddailyprocess_cuttingwip")> ReadOnly Property DailyProcess As XPCollection(Of Fusoh_DailyProcess)
      Get
        Return GetCollection(Of Fusoh_DailyProcess)("DailyProcess")
      End Get
    End Property
    <Association("fk_04ddailyprocess_produksi")> ReadOnly Property DailyProcessProduksi As XPCollection(Of Fusoh_DailyProcess)
      Get
        Return GetCollection(Of Fusoh_DailyProcess)("DailyProcessProduksi")
      End Get
    End Property

    <PersistentAlias("Detail.Sum(QtyIn)")> ReadOnly Property TotalQtyIn As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQtyIn"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(QtyOut)")> ReadOnly Property TotalQtyOut As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQtyOut"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(TotalLengthOut)")> ReadOnly Property TotalLength As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalLength"))
      End Get
    End Property

    <PersistentAlias("[Detail][[QtyIn] > 0].Single()")> ReadOnly Property ProduksiBahanJadi As Fusoh_StokDetail
      Get
        Return CType(EvaluateAlias("ProduksiBahanJadi"), Fusoh_StokDetail)
      End Get
    End Property

    <NonPersistent()> ReadOnly Property TSBahanBaku As Fusoh_Barang
      Get
        Dim xDt = Detail.ToList.Find(Function(f) f.QtyOut > 0)
        Return xDt.Barang
      End Get
    End Property
    <NonPersistent()> ReadOnly Property TSBarangJadi As Fusoh_Barang
      Get
        Dim xDt = Detail.ToList.Find(Function(f) f.QtyIn > 0)
        Return xDt.Barang
      End Get
    End Property
    <NonPersistent()> ReadOnly Property TSBahanBakuQty As Double
      Get
        Dim xDt = Detail.ToList.Find(Function(f) f.QtyOut > 0)
        Return xDt.QtyOut
      End Get
    End Property
    <NonPersistent()> ReadOnly Property TSBarangJadiQty As Double
      Get
        Dim xDt = Detail.ToList.Find(Function(f) f.QtyIn > 0)
        Return xDt.QtyIn
      End Get
    End Property
    '<PersistentAlias("Detail.Max(ProduksiDetail)")> ReadOnly Property ProduksiDetail As Fusoh_StokDetail
    '  Get
    '    Return EvaluateAlias("ProduksiDetail")
    '  End Get
    'End Property
    <NonPersistent()> ReadOnly Property ProduksiDetail As Fusoh_StokDetail
      Get
        Return Detail(0).ProduksiDetail
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Produksi [AM]"
      If IsDeleted Then
        Return True
      End If
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -2, "", source)
        Return False
      End If
      If Pelanggan Is Nothing AndAlso Sumber.Id <> SumberDataJenis.BS Then
        Throw New Utils.Exception("Masukkan pelangan", -3, "", source)
        Return False
      End If
      If Gudang Is Nothing Then
        Throw New Utils.Exception("Masukkan gudang", -4, "", source)
        Return False
      End If
      If OrderProduksi Is Nothing AndAlso Sumber.Id = SumberDataJenis.AM Then
        Throw New Utils.Exception("Masukkan order produksi", -5, "", source)
        Return False
      End If
      If SO Is Nothing AndAlso Sumber.Id = SumberDataJenis.AM Then
        Throw New Utils.Exception("Masukkan sales order", -5, "", source)
        Return False
      End If
      If TotalLength = 0 AndAlso Sumber.Id = SumberDataJenis.AM AndAlso CuttingWIP Is Nothing Then
        Throw New Utils.Exception("Total length yang anda masukkan 0. Silahkan benahi data anda", -5, "", source)
        Return False
      End If
      If Session.IsNewObject(Me) Then
        If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
          Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -6, "", source)
          Return False
        End If
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      For i = 0 To Detail.Count - 1
        Detail(i).Gudang = _gudang
      Next
      If Not CheckData() Then
        Return
      End If
      If Kode = Nothing Then
        Kode = Number.GetNewNumber.Kode
      End If
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m04dstockdetail")> Friend Class Fusoh_StokDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_StokMain
    Private _gudang As Gudang
    Private _item As Fusoh_Barang
    Private _satuan As Satuan
    Private _qtyIn As Double
    Private _qtyOut As Double
    Private _harga As Double
    Private _outDiameter As Decimal
    Private _inDiameter As Decimal
    Private _thickness As Decimal
    Private _length As Decimal
    Private _weight As Decimal
    Private _catatan As String
    Private _soDetail As Fusoh_OrderPenjualanDetail
    Private _eximDetail As Fusoh_EximDetail
    Private _TotalHPP As Double
    Private _produksiDetail As Fusoh_StokDetail

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_fusohstokmain_fusohstokdetail")> Property Main As Fusoh_StokMain
      Get
        Return _main
      End Get
      Set(value As Fusoh_StokMain)
        SetPropertyValue(Of Fusoh_StokMain)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_warehouse")> Property Gudang As Gudang
      Get
        Return _gudang
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("Gudang", _gudang, value)
      End Set
    End Property
    <Persistent("f_item")> Property Barang As Fusoh_Barang
      Get
        Return _item
      End Get
      Set(value As Fusoh_Barang)
        SetPropertyValue(Of Fusoh_Barang)("Barang", _item, value)
      End Set
    End Property
    <Persistent("f_uom")> Property Satuan As Satuan
      Get
        Return _satuan
      End Get
      Set(value As Satuan)
        SetPropertyValue(Of Satuan)("Satuan", _satuan, value)
      End Set
    End Property
    <Persistent("d_qtyin")> Property QtyIn As Double
      Get
        Return _qtyIn
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("QtyIn", _qtyIn, value)
      End Set
    End Property
    <Persistent("d_qtyout")> Property QtyOut As Double
      Get
        Return _qtyOut
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("QtyOut", _qtyOut, value)
      End Set
    End Property
    <Persistent("d_price")> Property Harga As Double
      Get
        Return _harga
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Harga", _harga, value)
      End Set
    End Property
    <Persistent("d_od")> Property OutDiameter As Decimal
      Get
        Return _outDiameter
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("OutDiameter", _outDiameter, value)
      End Set
    End Property
    <Persistent("d_id")> Property InDiameter As Decimal
      Get
        Return _inDiameter
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("InDiameter", _inDiameter, value)
      End Set
    End Property
    <Persistent("d_tickness")> Property Thickness As Decimal
      Get
        Return _thickness
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Thickness", _thickness, value)
      End Set
    End Property
    <Persistent("d_length")> Property Length As Decimal
      Get
        Return _length
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Length", _length, value)
      End Set
    End Property
    <Persistent("d_weight")> Property Weight As Decimal
      Get
        Return _weight
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("Weight", _weight, value)
      End Set
    End Property
    <PersistentAlias("iif(QtyOut = 0,Weight,Weight * -1)")> ReadOnly Property WeightX As Double '
      Get
        Return Convert.ToDouble(EvaluateAlias("WeightX"))
      End Get
    End Property
    <Persistent("d_remarks")> Property Catatan As String
      Get
        Return _catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _catatan, value)
      End Set
    End Property
    <Persistent("d_hpp")> Property TotalHPP As Double
      Get
        Return _TotalHPP
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("TotalHPP", _TotalHPP, value)
      End Set
    End Property
    ReadOnly Property NilaiBarang As Double
      Get
        Return ((QtyIn * Harga) * Main.Kurs) - TotalHPP
      End Get
    End Property

    <Persistent("f_idsod")> Property SODetail As Fusoh_OrderPenjualanDetail
      Get
        Return _soDetail
      End Get
      Set(value As Fusoh_OrderPenjualanDetail)
        SetPropertyValue(Of Fusoh_OrderPenjualanDetail)("SODetail", _soDetail, value)
      End Set
    End Property
    <Persistent("f_ideximmd")> Property EximDetail As Fusoh_EximDetail
      Get
        Return _eximDetail
      End Get
      Set(value As Fusoh_EximDetail)
        SetPropertyValue(Of Fusoh_EximDetail)("EximDetail", _eximDetail, value)
      End Set
    End Property
    <Persistent("f_idproduksid")> Property ProduksiDetail As Fusoh_StokDetail
      Get
        Return _produksiDetail
      End Get
      Set(value As Fusoh_StokDetail)
        SetPropertyValue(Of Fusoh_StokDetail)("ProduksiDetail", _produksiDetail, value)
      End Set
    End Property
    <PersistentAlias("ProduksiDetail.Sum(QtyOut)")> ReadOnly Property TotalKirim As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalKirim"))
      End Get
    End Property
    <Association("FusohStokDetail_FusohStokSerial"), Aggregated> ReadOnly Property Serial As XPCollection(Of Fusoh_StokSerial)
      Get
        Return GetCollection(Of Fusoh_StokSerial)("Serial")
      End Get
    End Property

    <PersistentAlias("Serial.Sum(LengthIn)")> ReadOnly Property TotalLengthIn As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalLengthIn"))
      End Get
    End Property
    <PersistentAlias("Serial.Sum(LengthOut)")> ReadOnly Property TotalLengthOut As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalLengthOut"))
      End Get
    End Property
    <PersistentAlias("Serial.Sum(LengthIn-LengthOut)")> ReadOnly Property TotalLength As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalLength"))
      End Get
    End Property
    <PersistentAlias("Serial.Sum(WeightIN)")> ReadOnly Property SerialWeightIN As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SerialWeightIN"))
      End Get
    End Property
    <PersistentAlias("Serial.Sum(WeightOUT)")> ReadOnly Property SerialWeightOut As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SerialWeightOut"))
      End Get
    End Property
    <PersistentAlias("Serial.Sum(Qty)")> ReadOnly Property SerialQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SerialQty"))
      End Get
    End Property
    <PersistentAlias("Serial.Sum(NilaiHPPSN)")> ReadOnly Property NilaiHPPSN As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiHPPSN"))
      End Get
    End Property
    <NonPersistent()> ReadOnly Property NOLOT As String
      Get
        If _produksiDetail Is Nothing Then
          Return Main.DempyouLot
        Else
          Return ProduksiDetail.Main.DempyouLot
        End If '(DetailDP.Sum(Function(m) m.NilaiDP) * Kurs) - DetailDP.Sum(Function(m) m.NilaiDP * m.DP.Kurs)
        'Return Main.DempyouLot
      End Get
    End Property
    <NonPersistent()> ReadOnly Property NOProduksi As String
      Get
        If _produksiDetail Is Nothing Then
          Return ""
        Else
          Return ProduksiDetail.Main.Kode
        End If
      End Get
    End Property

    <PersistentAlias("Main.Kode"), NUnique(NUniqueAttribute.JenisAttr.LogKode)> ReadOnly Property UniqueData As String
      Get
        Return Convert.ToString(EvaluateAlias("UniqueData"))
      End Get
    End Property
    <PersistentAlias("Main.Id"), NUnique(NUniqueAttribute.JenisAttr.LogId)> ReadOnly Property UniqueId As String
      Get
        Return Convert.ToString(EvaluateAlias("UniqueId"))
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Produksi [AM]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama permintaan penawaran", -99, "", source)
        Return False
      End If
      If _gudang Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan kode gudang", -99, "", source)
        Return False
      End If
      If _item Is Nothing Then
        Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
        Return False
      End If
      If _satuan Is Nothing Then
        Throw New Utils.Exception("Masukkan satuan barang", -99, "", source)
        Return False
      End If
      If _soDetail Is Nothing AndAlso _main.Sumber.Id = Persistent.SumberDataJenis.AM Then
        Throw New Utils.Exception("Masukkan sales order detail", -99, "", source)
        Return False
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      MyBase.OnSaving()
    End Sub

    <NonPersistent> Property SerialTemp As List(Of Fusoh_StockDetailSerial_Temp)
  End Class

  'ALTER TABLE fusoh456_db1.m04estockdetailserial ADD d_qty DECIMAL(18,4) UNSIGNED NOT NULL DEFAULT '0' AFTER d_length_out;
  '-- ---------------------------------------------------
  '-- initialize data utk d_qty jika sdh habis dipakai --
  '-- ---------------------------------------------------
  'CREATE TEMPORARY TABLE IF NOT EXISTS update_fusohserial AS 
  '(select max(x2.primary_main) as id from (select * from m04estockdetailserial) as x2 where x2.d_serial in 
  '(select x3.d_serial from (select * from m04estockdetailserial) as x3 group by x3.d_serial having sum(x3.d_length_in - x3.d_length_out) = 0)
  'And x2.d_length_out > 0 group by x2.d_serial);
  'update m04estockdetailserial x1 Set x1.d_qty=1 where x1.primary_main In (Select id from update_fusohserial);
  <Persistent("m04estockdetailserial")> Friend Class Fusoh_StokSerial
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _detail As Fusoh_StokDetail
    Private _millSheet As String
    Private _serial As String
    Private _lengthIn As Double
    Private _lengthOut As Double
    Private _qty As Double
    Private _scrap As Boolean
    Private _hargaSerialMM As Double

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("FusohStokDetail_FusohStokSerial")> Property DetailMain As Fusoh_StokDetail
      Get
        Return _detail
      End Get
      Set(value As Fusoh_StokDetail)
        SetPropertyValue(Of Fusoh_StokDetail)("DetailMain", _detail, value)
      End Set
    End Property
    <Persistent("d_millsheet")> Property MillSheet As String
      Get
        Return _millSheet
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("MillSheet", _millSheet, value)
      End Set
    End Property
    <Persistent("d_serial")> Property Serial As String
      Get
        Return _serial
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Serial", _serial, value)
      End Set
    End Property
    <Persistent("d_length_in")> Property LengthIn As Double
      Get
        Return _lengthIn
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("LengthIn", _lengthIn, value)
      End Set
    End Property
    <Persistent("d_length_out")> Property LengthOut As Double
      Get
        Return _lengthOut
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("LengthOut", _lengthOut, value)
      End Set
    End Property
    <Persistent("d_qty")> Property Qty As Double
      Get
        Return _qty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qty, value)
      End Set
    End Property
    <Persistent("d_harga")> Property HargaPerMM As Double
      Get
        Return _hargaSerialMM
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("HargaPerMM", _hargaSerialMM, value)
      End Set
    End Property
    <Persistent("d_scrap")> Property Scrap As Boolean
      Get
        Return _scrap
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Scrap", _scrap, value)
      End Set
    End Property

    <PersistentAlias("LengthIn - LengthOut")> ReadOnly Property SisaLength As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SisaLength"))
      End Get
    End Property
    <PersistentAlias("LengthOut * HargaPerMM")> ReadOnly Property NilaiHPPSN As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiHPPSN"))
      End Get
    End Property
    <PersistentAlias("LengthIn * HargaPerMM")> ReadOnly Property NilaiIN As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("NilaiIN"))
      End Get
    End Property
    '<PersistentAlias("iif(LengthIn = 0 , 0 , (DetailMain.Barang.Weight * (LengthIn / DetailMain.Barang.Length)))")> ReadOnly Property WeightIN As Double
    '	Get
    '		Return Convert.ToDouble(EvaluateAlias("WeightIN")) '(DetailMain.Barang.Weight * (x.LengthIn / x.DetailMain.Barang.Length))
    '	End Get
    'End Property
    <PersistentAlias("iif(LengthIn = 0 , 0 , (DetailMain.Barang.Weight * (LengthIn / DetailMain.Barang.Length)))")> ReadOnly Property WeightIN As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("WeightIN")) '(DetailMain.Barang.Weight * (x.LengthIn / x.DetailMain.Barang.Length))
      End Get
    End Property
    <PersistentAlias("iif(LengthOut = 0 , 0 , (DetailMain.Barang.Weight * (LengthOut / DetailMain.Barang.Length)))")> ReadOnly Property WeightOUT As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("WeightOUT"))
      End Get
    End Property
    <PersistentAlias("DetailMain.Harga")> ReadOnly Property HargaSerial As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("HargaSerial"))
      End Get
    End Property

    <PersistentAlias("DetailMain.Main.Kode"), NUnique(NUniqueAttribute.JenisAttr.LogKode)> ReadOnly Property UniqueData As String
      Get
        Return Convert.ToString(EvaluateAlias("UniqueData"))
      End Get
    End Property
    <PersistentAlias("DetailMain.Main.Id"), NUnique(NUniqueAttribute.JenisAttr.LogId)> ReadOnly Property UniqueId As String
      Get
        Return Convert.ToString(EvaluateAlias("UniqueId"))
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Produksi [AM]"
      If IsDeleted Then
        Return True
      End If

      If _detail Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama produksi detail", -99, "", source)
        Return False
      End If
      If _serial = Nothing Then
        Throw New Utils.Exception("Masukkan data serial", -99, "", source)
        Return False
      End If

      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m04vwproduksi")> Friend Class FusohVwProduksi
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As Int64
    Property Kode As String
    Property KodeItem As String
    Property NamaItem As String
    Property Tanggal As Date
    Property LOT As String
    Property QtyIN As Double
    Property QtyKirim As Double
		<PersistentAlias("QtyIN - QtyKirim")> ReadOnly Property QtySisa As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("QtySisa"))
			End Get
		End Property
		Property StockDetail As Fusoh_StokDetail
	End Class

  <Persistent("vwzfusohcekserialdempyou")> Friend Class FusohVwSNDempyou
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As Int64
    Property NoBukti As String
    Property ItemId As Persistent.Fusoh_Barang
    Property Qty As Double
    Property Serial As String
    Property IDDempyou As Int64
    Property SerialDempyou As Double
  End Class
  <Persistent("vwzfusohcekserialqty")> Friend Class FusohVwSNQty
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As Int64
    Property NoBukti As String
    Property ItemId As Int64
    Property ItemKode As String
    Property QtyBarang As Double
    Property QtySerial As Double
    ReadOnly Property Selisih As Double
      Get
        Return QtyBarang - QtySerial
      End Get
    End Property
  End Class
  <Persistent("vwzfusohserialover")> Friend Class FusohVwSNOver
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As Int64
    Property Barang As Fusoh_Barang
    Property SN As String
    Property Qty As Double
  End Class
  <Persistent("vwzfusohserialoverlength")> Friend Class FusohVwSNOverLength
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Key()> Property Id As Int64
    Property Item As Fusoh_Barang
    Property Serial As String
    Property Length As Double
  End Class

  Friend Class Fusoh_StockDetailSerial_Temp
    Property Id As Int64
    Property DetailMain As Fusoh_StockAdjustmentDetail
    Property Serial As String
    Property MillSheet As String
    Property LengthIn As Double
    Property State As Short '0 = tidak terpilih, 1 = terpilih, 2 = terpakai
  End Class
End Namespace

Namespace NonPersistent
  Public Class Fusoh_DataSerial
    Property Id As Int64
    Property Barang As Persistent.Fusoh_Barang
    Property MillSheet As String
    Property Serial As String
    Property LengthIn As Double
    Property LengthOut As Double
    Property Weight As Double
    Property Qty As Double
    Property TanggalDatang As Date
    Property OtomatisLength As Integer

    ReadOnly Property SisaLength As Double
      Get
        Return LengthIn - LengthOut
      End Get
    End Property
  End Class
  Public Class Fusoh_Produksi_BahanBaku_Temp
    Property Id As Int64
    Property Barang As Persistent.Fusoh_Barang
    Property Millsheet As String
    Property Serial As String
    Property SNLength As Decimal
    Property SNQty As Double
    Property Length As Double
    Property Qty As Double
    Property Catatan As String
    Property HargaSN As Double
    Property NoPembelian As String
    Property LengthBeli As Double
    Property NilaiHPP As Double
    Property Scrap As Boolean
  End Class
End Namespace