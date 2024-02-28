Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Imports DevExpress.XtraEditors.Controls
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent

Public Class UI_FusohCekSerial
	Private setting As NuSoft001.Logic.FinaSetting, pKode As String
	Sub New(zKode As String, xSession As DevExpress.Xpo.UnitOfWork)
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		session = xSession
		pKode = zKode

		Text = "Stock Serial (Imei) : " & zKode
	End Sub
	Overrides Sub FirstLoad()
		setting = New NuSoft001.Logic.FinaSetting(session)
		SetFormat()
		'xGridView.OptionsBehavior.Editable = False
		'xGridView.OptionsBehavior.ReadOnly = True
		'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("CekStockHistory.xml")) = True Then
		'  xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("CekStockHistory.xml"))
		'End If
		Dim DataTransaksi As New XPCollection(Of Persistent.Fusoh_StokSerial)(session, New GroupOperator(GroupOperator.And, New BinaryOperator("DetailMain.Barang.Kode", pKode, BinaryOperatorType.Equal)))
    Dim DataProduksi As New XPCollection(Of Persistent.Fusoh_StokSerial)(session, New GroupOperator(GroupOperator.And, New BinaryOperator("DetailMain.Barang.Kode", pKode, BinaryOperatorType.Equal), New BinaryOperator("DetailMain.Main.Sumber", Persistent.SumberDataJenis.AM, BinaryOperatorType.Equal)))
    '''''Dim b = From z In DataTransaksi Group z By z.Serial, z.MillSheet Into Group Select Serial, MillSheet, Weight = Group.Average(Function(x) x.DetailMain.Barang.Weight), WeightIN = Group.Sum(Function(x) x.DetailMain.Barang.Weight * (x.LengthIn / x.DetailMain.Barang.Length)), WeightOut = Group.Sum(Function(x) x.DetailMain.Barang.Weight * (x.LengthOut / x.DetailMain.Barang.Length)), Length = Group.Sum(Function(x) x.LengthIn - x.LengthOut), LengthIn = Group.Sum(Function(x) x.LengthIn), LengthOut = Group.Sum(Function(x) x.LengthOut)

    '==== start edit sbm 03-Apr-2021 ================
    Dim b = DataTransaksi.GroupBy(Function(g) g.Serial) _
			.Select(Function(s) New With {
				.Serial = s.Key,
				.MillSheet = s.Min(Function(x) x.MillSheet),
				.Weight = s.Average(Function(x) x.DetailMain.Barang.Weight),
				.WeightIN = s.Sum(Function(x) x.DetailMain.Barang.Weight * (x.LengthIn / x.DetailMain.Barang.Length)),
				.WeightOut = s.Sum(Function(x) x.DetailMain.Barang.Weight * (x.LengthOut / x.DetailMain.Barang.Length)),
				.Length = s.Sum(Function(x) x.LengthIn - x.LengthOut),
				.LengthIn = s.Sum(Function(x) x.LengthIn),
				.LengthOut = s.Sum(Function(x) x.LengthOut)
		}).ToList

    Dim orderItem = New XPQuery(Of Fusoh_OrderProduksiBahanBaku)(session).Where(Function(w) w.Barang.Kode = pKode)

		For i = 0 To b.Count - 1
			Dim xo = b(i)
			Dim loProduksi = DataProduksi.Where(Function(w) w.Serial = xo.Serial).Sum(Function(s) s.LengthOut)
			Dim o = orderItem.Where(Function(w) w.Serial = xo.Serial).Sum(Function(s) s.Length)

			'xo.LengthOut += (o - loProduksi) '==== end edit jali 14-Maret-2022 ================
			xo.LengthOut += (o - xo.LengthOut)
			xo.Length = xo.LengthIn - xo.LengthOut
		Next

		'==== end edit sbm 03-Apr-2021 ================

		xGrid.DataSource = Nothing
		xGrid.DataSource = b

		'xGridView.ActiveFilterString = "[Barang.Kode]='" & pKode & "' and [Gudang.Kode]='" & pGudang & "'"
	End Sub
	Private Sub SetFormat()
		'colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colQtyIn.DisplayFormat.FormatString = setting.NumericFormatString
		'colQtyIn.SummaryItem.DisplayFormat = setting.NumericFormatString
		'colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colQtyOut.DisplayFormat.FormatString = setting.NumericFormatString
		'colQtyOut.SummaryItem.DisplayFormat = setting.NumericFormatString
		'colStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		'colStock.DisplayFormat.FormatString = setting.NumericFormatString
		'colStock.SummaryItem.DisplayFormat = setting.NumericFormatString
		'colQtyHPPReff.DisplayFormat.FormatString = setting.NumericFormatString
		'colQtyHPPReff.SummaryItem.DisplayFormat = setting.NumericFormatString
	End Sub
	Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
		xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("CekStockHistory.xml"))
	End Sub
	Private Sub ifSource_ResolveSession(sender As Object, e As ResolveSessionEventArgs) Handles ifSource.ResolveSession
		e.Session = session
	End Sub
	Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
		NuSoft.Core.Win.Component.XtraGrid.ExportExcel(xGrid, session, "Data Stock")
	End Sub
	Private Sub colSerialRepo_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles colSerialRepo.ButtonClick
		Dim serial = xGridView.GetFocusedRowCellValue(colSerial).ToString
		Dim frm As New UI_FusohCekSerialHistory(session, pKode, serial)
		frm.MenuId = Me.MenuId
		frm.NamaDatabase = Me.NamaDatabase
		frm.ShowDialog()
	End Sub
End Class