Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Friend Class RF_FusohVoucherBaru
	Private _kodeReport As MainClass.reportName
	Sub New(reportCode As MainClass.reportName)
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		_kodeReport = reportCode
		Select Case _kodeReport
			Case MainClass.reportName.zFusohVoucherCostSheetActualRate
				Me.Text = "Filter Laporan - Cost Sheet"

		End Select
	End Sub
	Overrides Sub InitializeData()
		Dim listSumber = New List(Of Persistent.SumberDataJenis)
		listSumber.Add(Persistent.SumberDataJenis.IMV)
		listSumber.Add(Persistent.SumberDataJenis.RI)
		Select Case _kodeReport
			Case MainClass.reportName.zFusohVoucherCostSheetActualRate
				txtNoBukti1.Properties.DataSource = New XPCollection(Of Persistent.Fusoh_PenerimaanInvoice)(_sesi, New InOperator("Sumber", listSumber))
				txtNoBukti2.Properties.DataSource = New XPCollection(Of Persistent.Fusoh_PenerimaanInvoice)(_sesi, New InOperator("Sumber", listSumber))
		End Select
	End Sub
	Overrides Sub Filter()
		Dim setting As New NuSoftModSys.LogicLayer.Config(_sesi)
		Dim glSetting As New NuSoft001.Logic.FinaSetting(_sesi)
		AddParameter("CompanyName", setting.NamaPerusahaan, GetType(String))
		AddParameter("Alamat1", setting.Alamat1, GetType(String))
		AddParameter("Alamat2", setting.Alamat2, GetType(String))
		AddParameter("BidangUsaha", setting.BidangUsaha, GetType(String))
		AddParameter("NoFax", setting.NoFax, GetType(String))
		AddParameter("NoTelp", setting.NoTelp, GetType(String))
		AddParameter("FormatString", glSetting.NumericFormatString, GetType(String))
		Select Case _kodeReport
			Case MainClass.reportName.zFusohVoucherCostSheetActualRate
				_dataSource = New XPCollection(Of Persistent.Fusoh_PenerimaanInvoice)(_sesi, CreateCriteriaMain)
		End Select
	End Sub
	Private Function CreateCriteriaMain() As CriteriaOperator
		Dim result As New List(Of CriteriaOperator)
		Dim format As String = "%{0}%"
		Dim listSumber = New List(Of Persistent.SumberDataJenis)
		listSumber.Add(Persistent.SumberDataJenis.IMV)
		listSumber.Add(Persistent.SumberDataJenis.RI)

		Select Case _kodeReport
			Case MainClass.reportName.zFusohVoucherCostSheetActualRate
				result.Add(New InOperator("Sumber", listSumber))
		End Select

		If Not txtNoBukti1.EditValue = Nothing Then
			If txtNoBukti2.EditValue = Nothing Then
				result.Add(New BinaryOperator("Kode", String.Format(format, txtNoBukti1.EditValue), BinaryOperatorType.Like))
			Else
				result.Add(New BetweenOperator("Kode", txtNoBukti1.EditValue, txtNoBukti2.EditValue))
			End If
		End If
		If Not txtTgl1.EditValue Is Nothing Then
			If txtTgl2.EditValue Is Nothing Then
				result.Add(New BinaryOperator("Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
			Else
				result.Add(New BetweenOperator("Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
			End If
		End If
		If txtKontak.Text <> "" Then
			result.Add(New BinaryOperator("Vendor", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
		End If
		If txtKeterangan.Text <> "" Then
			result.Add(New BinaryOperator("Catatan", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
		End If

		Return GroupOperator.And(result)
	End Function
	Private Function CreateCriteriaDetail() As CriteriaOperator
		Dim result As New List(Of CriteriaOperator)
		Dim format As String = "%{0}%"

		Select Case _kodeReport
			Case MainClass.reportName.zFusohVoucherCostSheetActualRate
				result.Add(New BinaryOperator("Main.Sumber", New Persistent.SumberDataCollection(_sesi).GetObject(Persistent.SumberDataJenis.RI), BinaryOperatorType.Equal))
		End Select
		If Not txtNoBukti1.EditValue = Nothing Then
			If txtNoBukti2.EditValue = Nothing Then
				result.Add(New BinaryOperator("Main.Kode", String.Format(format, txtNoBukti1.EditValue), BinaryOperatorType.Like))
			Else
				result.Add(New BetweenOperator("Main.Kode", txtNoBukti1.EditValue, txtNoBukti2.EditValue))
			End If
		End If
		If Not txtTgl1.EditValue Is Nothing Then
			If txtTgl2.EditValue Is Nothing Then
				result.Add(New BinaryOperator("Main.Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
			Else
				result.Add(New BetweenOperator("Main.Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
			End If
		End If
		If txtKontak.Text <> "" Then
			result.Add(New BinaryOperator("Main.Vendor", String.Format(format, txtKontak.Text), BinaryOperatorType.Like))
		End If
		If txtKeterangan.Text <> "" Then
			result.Add(New BinaryOperator("Main.Catatan", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
		End If

		Return GroupOperator.And(result)
	End Function
	Private Sub txtTgl1_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTgl1.EditValueChanging
		txtTgl2.Properties.MinValue = CDate(e.NewValue)
	End Sub
	Private Sub txtTgl2_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTgl2.EditValueChanging
		txtTgl1.Properties.MaxValue = CDate(e.NewValue)
	End Sub
End Class