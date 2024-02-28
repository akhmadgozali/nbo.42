Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Friend Class RF_FusohRekapQuotaImport
	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
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

		_dataSource = New XPCollection(Of Persistent.Fusoh_KuotaImpor)(_sesi, CreateCriteria)
	End Sub
	Private Function CreateCriteria() As CriteriaOperator
		Dim result As New List(Of CriteriaOperator)
		Dim format As String = "%{0}%"

		If Not txtTgl1.EditValue Is Nothing Then
			If txtTgl2.EditValue Is Nothing Then
				result.Add(New BinaryOperator("Expired", txtTgl1.DateTime, BinaryOperatorType.Equal))
			Else
				result.Add(New BetweenOperator("Expired", txtTgl1.DateTime, txtTgl2.DateTime))
			End If
		End If
		If txtPelabuhan.Text <> "" Then
			result.Add(New BinaryOperator("Pelabuhan", String.Format(format, txtPelabuhan.Text), BinaryOperatorType.Like))
		End If
		If txtKodeHS.Text <> "" Then
			result.Add(New BinaryOperator("KodeHS", String.Format(format, txtKodeHS.Text), BinaryOperatorType.Like))
		End If
		If txtNoLampiran.Text <> "" Then
			result.Add(New BinaryOperator("NoLampiran", String.Format(format, txtNoLampiran.Text), BinaryOperatorType.Like))
		End If
		If txtKeterangan.Text <> "" Then
			result.Add(New BinaryOperator("Keterangan", String.Format(format, txtKeterangan.Text), BinaryOperatorType.Like))
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