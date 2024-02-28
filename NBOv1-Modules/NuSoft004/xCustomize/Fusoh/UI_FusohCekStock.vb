Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraPivotGrid
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Imports NuSoft.Core.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent

Public Class UI_FusohCekStock
	Private setting As NuSoft001.Logic.FinaSetting
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
	End Sub
	Overrides Sub FirstLoad()
		session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
		setting = New NuSoft001.Logic.FinaSetting(session)
		colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colQtyIn.DisplayFormat.FormatString = setting.NumericFormatString
		colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colQtyOut.DisplayFormat.FormatString = setting.NumericFormatString
		colStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		colStock.DisplayFormat.FormatString = setting.NumericFormatString
		colDempyou.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDempyou.DisplayFormat.FormatString = setting.NumericFormatString
    colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colAmount.DisplayFormat.FormatString = setting.NumericFormatString

    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("cekstock.xml")) = True Then
			'xGridStockView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("cekstock.xml"))
		End If
	End Sub
  Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
    Dim DataLokasi As New DevExpress.Xpo.XPCollection(Of Persistent.BarangLokasi)(session, getCriteria)

    Dim DataTransaksi As New XPCollection(Of Persistent.Fusoh_StokDetail)(session, getCriteria)

    xGridStock.DataSource = Nothing
    session.DropIdentityMap()

    Dim b = (From z In DataTransaksi Group z By z.Barang Into Group
             Select New DataSourceItem With {
               .Barang = Barang,
               .QtyIn = Group.Sum(Function(x) x.QtyIn),
               .QtyOut = Group.Sum(Function(x) x.QtyOut),
               .Stock = Group.Sum(Function(x) x.QtyIn - x.QtyOut),
               .TotalLength = Group.Sum(Function(x) x.TotalLength),
               .TotalHPP = Group.Sum(Function(x) x.NilaiBarang)
            }).ToList


    '==== start edit sbm 03-Apr-2021 ================

    '''''  Dim orderSdhDiProduksi = New XPQuery(Of Fusoh_StokMain)(session).Where(Function(w) Not w.OrderProduksi Is Nothing).GroupBy(Function(g) g.OrderProduksi).Select(Function(s) s.Key).ToList
    '''''Dim orderItem = New XPQuery(Of Fusoh_OrderProduksiBahanBaku)(session).Where(Function(w) Not orderSdhDiProduksi.Contains(w.Main))
    '''''For i = 0 To b.Count - 1
    '''''	'Dim xo = x(i)
    '''''	'Dim o = orderItem.Where(Function(w) w.Serial = xo.Serial).Sum(Function(s) s.Length)
    '''''	'xo.LengthOut += o
    '''''	Dim dd = b(i)
    '''''	Dim dempyou = orderItem.Where(Function(w) w.Barang Is dd.Barang)
    '''''	dd.Dempyou = dempyou.Sum(Function(s) s.Qty)
    '''''	'MsgBox(dempyou)
    '''''	dd.Stock -= dd.Dempyou
    '''''	dd.TotalLength -= dempyou.Sum(Function(s) s.Length)
    '''''Next
    If chkDempyou.Checked = True Then
      For Each tr In b
        Dim qtyDempyou = 0
        Dim lengthDempyou As Double = 0

        Dim orderItem = New XPQuery(Of Fusoh_OrderProduksiBahanBaku)(session).Where(Function(w) w.Barang Is tr.Barang)
        Dim serialItem = New XPQuery(Of Fusoh_StokSerial)(session).Where(Function(w) w.DetailMain.Barang Is tr.Barang) _
          .GroupBy(Function(g) g.Serial).Select(Function(s) New With {.Serial = s.Key, .LengthOut = s.Sum(Function(d) d.LengthOut)}).ToList

        For i = 0 To serialItem.Count - 1
          Dim xo = serialItem(i)

          Dim o = orderItem.Where(Function(w) w.Serial = xo.Serial)
          Dim oLength = o.Sum(Function(s) s.Length)
          Dim oQty = o.Sum(Function(s) s.Qty)

          lengthDempyou += (oLength - xo.LengthOut)
          If (xo.LengthOut < oLength) Then
            '                                       5470             5420
            'MsgBox("Serial :" & xo.Serial & "-->" & oLength & "<>" & xo.LengthOut)
            qtyDempyou += oQty
          End If
        Next

        tr.Dempyou = qtyDempyou
        tr.Stock -= tr.Dempyou
        tr.TotalLength -= lengthDempyou
      Next
    End If


    '==== end edit sbm 03-Apr-2021 ================

    'MsgBox(b.Sum(Function(s) s.Dempyou))

    xGridStock.DataSource = b

    'cmdHistory.Glyph.Save("c:\temp\history.png")
    'xGridStockView.Editable = True
    xGridStockView.OptionsBehavior.Editable = True
    xGridStockView.OptionsBehavior.ReadOnly = False
  End Sub
  Private Function getCriteria() As CriteriaOperator
		Dim result As New List(Of CriteriaOperator)
		Dim format As String = "%{0}%"
		If Not txtKode.EditValue Is Nothing Then
			result.Add(New BinaryOperator("Barang.Kode", String.Format(format, txtKode.EditValue), BinaryOperatorType.Like))
		End If
		If Not txtNama.EditValue Is Nothing Then
			result.Add(New BinaryOperator("Barang.Nama", String.Format(format, txtNama.EditValue), BinaryOperatorType.Like))
		End If
		Return GroupOperator.And(result)
	End Function

	Private Sub xGridStockView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridStockView.ColumnWidthChanged
		Dim file As String = Logic.Umum.xLokasiLayout("cekstock.xml")
		If System.IO.File.Exists(file) Then
			xGridStockView.SaveLayoutToXml(file)
		End If
	End Sub
	Private Sub btnCetakData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCetakData.ItemClick
		printGrid(xGridStock)
	End Sub
	Private Sub cmdHistory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdHistory.ItemClick
		If Not xGridStockView.DataSource Is Nothing Then
			Dim KodeBarang As String = xGridStockView.GetFocusedRowCellDisplayText(colKode)
			Dim frm As New UI_FusohCekStockHistory(KodeBarang, session)
			frm.session = session
			frm.MenuId = Me.MenuId
			frm.NamaDatabase = Me.NamaDatabase
			frm.ShowDialog()
		End If
	End Sub
	Private Sub btnHistoryHPP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHistoryHPP.ItemClick
		'If Not xGridStockView.DataSource Is Nothing Then
		'  Dim KodeBarang As String = xGridStockView.GetFocusedRowCellDisplayText(colKode)
		'  Dim KodeGudang As String = xGridStockView.GetFocusedRowCellDisplayText(colGudangKode)
		'  Dim frm As New UI_CekStockHPP(KodeBarang, KodeGudang, Session)
		'  frm.session = Session
		'  frm.MenuId = Me.MenuId
		'  frm.NamaDatabase = Me.NamaDatabase
		'  frm.ShowDialog()
		'End If
	End Sub
	Private Sub btnCekSerial_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCekSerial.ItemClick
		If Not xGridStockView.DataSource Is Nothing Then
			Dim KodeBarang As String = xGridStockView.GetFocusedRowCellDisplayText(colKode)
			Dim frm As New UI_FusohCekSerial(KodeBarang, session)
			frm.session = session
			frm.MenuId = Me.MenuId
			frm.NamaDatabase = Me.NamaDatabase
			frm.ShowDialog()
		End If
	End Sub
  Public Class DataSourceItem
    Property Barang As Fusoh_Barang
    Property QtyIn As Double
    Property QtyOut As Double
    Property Stock As Double
    Property TotalLength As Double
    Property Dempyou As Double
    Property TotalHPP As Double
  End Class
  Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
    NuSoft.Core.Win.Component.XtraGrid.ExportExcel(xGridStock, session, "Data Stock")
  End Sub
  Private Sub btnCekHPPSerial_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCekHPPSerial.ItemClick
    If Not xGridStockView.DataSource Is Nothing Then
      Dim KodeBarang As String = xGridStockView.GetFocusedRowCellDisplayText(colKode)
      Dim frm As New UI_FusohCekStockHPPSerial(KodeBarang, session)
      frm.session = session
      frm.MenuId = Me.MenuId
      frm.NamaDatabase = Me.NamaDatabase
      frm.ShowDialog()
    End If
  End Sub
  Private Sub btnResetHargaSerial_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetHargaSerial.ItemClick
    If Not xGridStockView.DataSource Is Nothing Then
      Dim KodeBarang As String = xGridStockView.GetFocusedRowCellDisplayText(colKode)
      Dim xSerialIN As Persistent.Fusoh_StokSerial
      Dim xpDataSerial As New XPCollection(Of Persistent.Fusoh_StokSerial)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("DetailMain.Barang.Kode", KodeBarang, BinaryOperatorType.Equal), New BinaryOperator("LengthIn", 0, BinaryOperatorType.Greater)))
      Dim xJali As String = ""
      For pi = 0 To xpDataSerial.Count - 1
        xjali = xjali & vbCrLf & ("SN : " & xpDataSerial(pi).Serial & "-->" & (xpDataSerial(pi).DetailMain.Harga / xpDataSerial(pi).DetailMain.QtyIn) / xpDataSerial(pi).LengthIn & "==>(" & xpDataSerial(pi).DetailMain.Harga & "/ " & xpDataSerial(pi).DetailMain.QtyIn & ") / " & xpDataSerial(pi).LengthIn)
        xpDataSerial(pi).HargaPerMM = (xpDataSerial(pi).DetailMain.Harga) / xpDataSerial(pi).LengthIn
      Next
      MsgBox(xJali)
      Dim xpDataSerialOut As New XPCollection(Of Persistent.Fusoh_StokSerial)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("DetailMain.Barang.Kode", KodeBarang, BinaryOperatorType.Equal), New BinaryOperator("LengthOut", 0, BinaryOperatorType.Greater)))
      For px = 0 To xpDataSerialOut.Count - 1
        Dim xyzItem = xpDataSerialOut(px)
        xSerialIN = xpDataSerial.Single(Function(m) m.Serial = xyzItem.Serial) ' xpDataSerialOut(px).Serial)
        xyzItem.HargaPerMM = xSerialIN.HargaPerMM 'xpDataSerialOut(px).HargaPerMM = xSerialIN.HargaPerMM ' (xpDataSerial(pi).DetailMain.Harga / xpDataSerial(pi).DetailMain.QtyIn) / xpDataSerial(pi).LengthIn
      Next
      session.CommitTransaction()
      MsgBox("Proses selesai.")
    End If
  End Sub
End Class