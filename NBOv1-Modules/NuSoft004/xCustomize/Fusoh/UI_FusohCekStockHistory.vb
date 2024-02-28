Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls

Public Class UI_FusohCekStockHistory
  Private setting As NuSoft001.Logic.FinaSetting, pKode As String
  Private detailSource As List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
  Private instance As Persistent.Fusoh_StokMain

  Sub New(zKode As String, xSession As DevExpress.Xpo.UnitOfWork)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    session = xSession
    pKode = zKode

    Text = "History Stock : " & zKode
  End Sub
  Overrides Sub FirstLoad()
    setting = New NuSoft001.Logic.FinaSetting(session)
    SetFormat()
    xGridView.OptionsBehavior.Editable = True
    xGridView.OptionsBehavior.ReadOnly = True
    'xGridView.ActiveFilterString = "[Barang.Kode]='" & pKode & "'"
    Dim DataTransaksi As New XPCollection(Of Fusoh_StokDetail)(session, getCriteria)
    Dim xSource = (From z In DataTransaksi Select New HistorySource With {
            .IdMain = z.Main.Id,
            .Id = z.Id,
            .NoBukti = z.Main.Kode,
            .Tanggal = z.Main.Tanggal,
            .KodeBarang = z.Barang.Kode,
            .NamaBarang = z.Barang.Nama,
            .Satuan = z.Satuan.Kode,
            .QtyIn = z.QtyIn,
            .QtyOut = z.QtyOut,
            .Kurs = z.Main.Kurs,
            .Harga = z.Harga,'IIf(z.QtyIn > 0, (z.Harga * z.Main.Kurs), z.Harga),
            .TotalHPP = z.TotalHPP,
            .Weight = z.Weight,
            .WeightX = (z.TotalLengthOut / z.Length) * z.Weight,
            .SerialWeightIN = z.SerialWeightIN,
            .SerialWeightOut = z.SerialWeightOut,
            .NoLOT = z.NOLOT,
            .NoProduksi = z.NOProduksi,
            .NilaiHPPSN = z.NilaiHPPSN,
            .QtySN = z.SerialQty
        }).ToList

    'Dim orderSdhDiProduksi = New XPQuery(Of Fusoh_StokMain)(session).Where(Function(w) Not w.OrderProduksi Is Nothing).GroupBy(Function(g) g.OrderProduksi).Select(Function(s) s.Key).ToList
    'Dim orderItem = New XPQuery(Of Fusoh_OrderProduksiBahanBaku)(session).Where(Function(w) w.Barang.Kode = pKode AndAlso Not orderSdhDiProduksi.Contains(w.Main))
    'For Each item In orderItem
    '  xSource.Add(New HistorySource With {
    '    .NoBukti = item.Main.Kode,
    '    .Tanggal = item.Main.Tanggal,
    '    .KodeBarang = item.Barang.Kode,
    '    .NamaBarang = item.Barang.Nama,
    '    .QtyIn = 0,
    '    .QtyOut = item.Qty,
    '    .Harga = 0,
    '    .Kurs = 1,
    '    .Satuan = item.Barang.Satuan.Kode,
    '    .TotalHPP = 0
    '  })
    'Next

    Dim dempyouData As New List(Of HistorySource)
    Dim orderItem = New XPQuery(Of Fusoh_OrderProduksiBahanBaku)(session).Where(Function(w) w.Barang.Kode = pKode)
    Dim serialItem = New XPQuery(Of Fusoh_StokSerial)(session).Where(Function(w) w.DetailMain.Barang.Kode = pKode) _
        .GroupBy(Function(g) g.Serial).Select(Function(s) New With {.Serial = s.Key, .LengthOut = s.Sum(Function(d) d.LengthOut)}).ToList

    For i = 0 To serialItem.Count - 1
      Dim xo = serialItem(i)
      Dim o = orderItem.Where(Function(w) w.Serial = xo.Serial)
      Dim oLength = o.Sum(Function(s) s.Length)

      If (xo.LengthOut < oLength) Then
        For Each x In o
          dempyouData.Add(New HistorySource With {
          .NoBukti = x.Main.Kode,
          .Tanggal = x.Main.Tanggal,
          .KodeBarang = x.Barang.Kode,
          .NamaBarang = x.Barang.Nama,
          .QtyIn = 0,
          .QtyOut = x.Qty,
          .Harga = 0,
          .Kurs = 1,
          .Satuan = x.Barang.Satuan.Kode,
          .TotalHPP = 0
        })
        Next
      End If
    Next
    xSource.AddRange(dempyouData.GroupBy(Function(g) g.NoBukti) _
                     .Select(Function(s) New HistorySource With {
                        .NoBukti = s.Key,
                        .Tanggal = s.Min(Function(x) x.Tanggal),
                        .KodeBarang = s.Min(Function(x) x.KodeBarang),
                        .NamaBarang = s.Min(Function(x) x.NamaBarang),
                        .QtyIn = 0,
                        .QtyOut = s.Sum(Function(x) x.QtyOut),
                        .Harga = 0,
                        .Kurs = 1,
                        .Satuan = s.Min(Function(x) x.Satuan),
                        .TotalHPP = 0
                      }).ToList)

    'xGrid.DataSource = Nothing
    xGrid.DataSource = xSource 'xSource.OrderByDescending(Function(o) o.Tanggal).ToList

    Dim b = From z In xSource Group z By z.NoX Into Group Select NoX, Qty = Group.Sum(Function(s) s.QtyIn - s.QtyOut), Amount = Group.Sum(Function(s) s.Total)
    xGridProduksi.DataSource = b

    detailSource = New List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
    xGridSerial.DataSource = detailSource
    chkGabung.Checked = True
  End Sub

  Private Function getCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    'Dim format As String = "%{0}%"
    Dim format As String = "{0}"
    'If Not txtKode.EditValue Is Nothing Then
    '  result.Add(New BinaryOperator("Barang.Kode", String.Format(format, txtKode.EditValue), BinaryOperatorType.Like))
    'End If
    'If Not txtNama.EditValue Is Nothing Then
    '  result.Add(New BinaryOperator("Barang.Nama", String.Format(format, txtNama.EditValue), BinaryOperatorType.Like))
    'End If
    result.Add(New BinaryOperator("Barang.Kode", String.Format(format, pKode), BinaryOperatorType.Like))
    Return GroupOperator.And(result)
  End Function
  Private Sub SetFormat()
    colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQtyIn.DisplayFormat.FormatString = setting.NumericFormatString
    colQtyIn.SummaryItem.DisplayFormat = setting.NumericFormatString
    colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQtyOut.DisplayFormat.FormatString = setting.NumericFormatString
    colQtyOut.SummaryItem.DisplayFormat = setting.NumericFormatString
    colWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colWeight.DisplayFormat.FormatString = setting.NumericFormatString
    colWeight.SummaryItem.DisplayFormat = setting.NumericFormatString
    colWeightIN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colWeightIN.DisplayFormat.FormatString = setting.NumericFormatString
    colWeightIN.SummaryItem.DisplayFormat = setting.NumericFormatString
    colWeightOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colWeightOut.DisplayFormat.FormatString = setting.NumericFormatString
    colWeightOut.SummaryItem.DisplayFormat = setting.NumericFormatString

    colHargaBeli.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHargaBeli.DisplayFormat.FormatString = setting.NumericFormatString
    colHargaBeli.SummaryItem.DisplayFormat = setting.NumericFormatString
    colHPP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHPP.DisplayFormat.FormatString = setting.NumericFormatString
    colHPP.SummaryItem.DisplayFormat = setting.NumericFormatString
  End Sub
  Private Sub colNoBuktiRepo_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles colNoBuktiRepo.ButtonClick
    If Not xGridView.DataSource Is Nothing Then
      Dim xID As Long = CType(xGridView.GetFocusedRowCellDisplayText(colID), Long)
      Dim frm As New UI_FusohCekStockHistorySerial(xID, session, xGridView.GetFocusedRowCellDisplayText(colNoBukti))
      frm.session = session
      frm.MenuId = Me.MenuId
      frm.NamaDatabase = Me.NamaDatabase
      frm.ShowDialog()
    End If
  End Sub

  Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
    NuSoft.Core.Win.Component.XtraGrid.ExportExcel(xGrid, session, "Data Stock")
  End Sub
  Private Sub colQtyOutRepo_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles colQtyOutRepo.ButtonClick
    If Not xGridView.DataSource Is Nothing Then
      Dim xID As Long = CType(xGridView.GetFocusedRowCellDisplayText(colIdMain), Long)
      lblDataSerial.Text = "Data Serial : " & xGridView.GetFocusedRowCellDisplayText(colNoBukti)
      instance = session.GetObjectByKey(Of Persistent.Fusoh_StokMain)(Convert.ToInt64(xID))

      xGridDempyou.DataSource = instance.OrderProduksi.BahanBaku

      If chkGabung.Checked = False Then
        'detailSource = New List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
        detailSource.Clear()
      End If

      'Dim sdhProses = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.OrderProduksi Is instance.OrderProduksi AndAlso Not w.Main Is instance).ToList
      Dim sdhProses = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(w) w.Main.OrderProduksi Is instance.OrderProduksi AndAlso Not w.Main Is instance).ToList


      For Each det In instance.Detail
        If det.QtyIn = 0 Then
          For Each serial In det.Serial
            Dim item As New NonPersistent.Fusoh_Produksi_BahanBaku_Temp
            item.Barang = det.Barang
            item.Catatan = det.Catatan
            item.Id = det.Id
            item.Millsheet = serial.MillSheet
            item.Serial = serial.Serial
            'Dim xSerial = sdhProses.FindAll(Function(m) m.Barang Is item.Barang).SelectMany(Function(m) m.Serial).ToList.FindAll(Function(f) f.Serial = item.Serial)
            'Dim xOrder = instance.OrderProduksi.BahanBaku.ToList.Find(Function(w) w.Barang Is item.Barang AndAlso w.Serial = item.Serial)

            'item.SNLength = CDec(xOrder.SNLength - xSerial.Sum(Function(s) s.LengthOut))
            'item.Length = CDec(serial.LengthOut)
            item.Length = serial.LengthOut
            item.Qty = serial.Qty

            'ambilkan harga HPP
            Dim xPembelian As New XPCollection(Of Fusoh_StokSerial)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("DetailMain.Barang", det.Barang, BinaryOperatorType.Equal), New BinaryOperator("Serial", serial.Serial, BinaryOperatorType.Equal), New BinaryOperator("LengthIn", 0, BinaryOperatorType.Greater)))
            If xPembelian.Count > 0 Then
              item.HargaSN = xPembelian(0).DetailMain.Harga
              item.NoPembelian = xPembelian(0).DetailMain.Main.Kode
              item.LengthBeli = xPembelian(0).DetailMain.Length
              item.NilaiHPP = item.Length * (item.HargaSN / item.Barang.Length)
            End If

            xGridSerial.BeginUpdate()
            detailSource.Add(item)
            xGridSerial.RefreshDataSource()
            xGridSerial.EndUpdate()
          Next
        End If
      Next
      'xGridSerial.DataSource = detailSource
    End If
  End Sub
  Private Sub btnExportGridSerial_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportGridSerial.ItemClick
    NuSoft.Core.Win.Component.XtraGrid.ExportExcel(xGridSerial, session, "Data Stock Serial")
  End Sub
  Private Sub btnShowGridSerial_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowGridSerial.ItemClick
    lblDataSerial.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
    lytSerial.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
    lytSerial2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
    lytSerial3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
  End Sub
  Private Sub btnShowDempyou_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowDempyou.ItemClick
    lytDempyou.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
    lytDempyouGrup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
  End Sub
  Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
    session.CommitTransaction()
    Me.Close()
  End Sub
  Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
    For Each det In instance.Detail
      If det.QtyIn = 0 Then
        For pi = 0 To det.Serial.Count - 1
          instance.OrderProduksi.BahanBaku(pi).Serial = det.Serial(pi).Serial
          instance.OrderProduksi.BahanBaku(pi).Millsheet = det.Serial(pi).MillSheet
        Next
      End If
    Next
  End Sub

  Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProduksi.ItemClick
    layoutProduksi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
  End Sub

  Public Class HistorySource
    Property Id As Long
    Property IdMain As Long
    Property NoBukti As String
    Property Tanggal As Date
    Property KodeBarang As String
    Property NamaBarang As String
    Property Satuan As String
    Property QtyIn As Double
    Property QtyOut As Double
    Property Harga As Double
    Property Kurs As Double
    Property TotalHPP As Double
    Property Weight As Double
    Property WeightX As Double
    Property SerialWeightIN As Double
    Property SerialWeightOut As Double
    Property NoLOT As String
    Property NoProduksi As String
    Property HargaProduksi As Double
    Property NilaiHPPSN As Double
    Property NilaiMasuk As Double
    Property QtySN As Double
    ReadOnly Property Total As Double
      Get
        Return ((QtyIn * Harga) * Kurs) - TotalHPP
      End Get
    End Property
    ReadOnly Property SerialWeight As Double
      Get
        Return SerialWeightIN - SerialWeightOut
      End Get
    End Property
    ReadOnly Property NoX As String
      Get
        If QtyIn > 0 Then
          Return NoBukti
        Else
          Return NoProduksi
        End If
      End Get
    End Property
    ReadOnly Property QtyStock As Double
      Get
        Return QtyIn - QtyOut
      End Get
    End Property
  End Class
End Class