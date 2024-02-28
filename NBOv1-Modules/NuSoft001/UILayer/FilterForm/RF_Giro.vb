Imports DevExpress.Data.Filtering
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent

Friend Class RF_Giro
  Overrides Sub Filter()
    Dim setting As New NuSoftModSys.LogicLayer.Config(_sesi)
    Dim glSetting As New Logic.FinaSetting(_sesi)
    AddParameter("CompanyName", setting.NamaPerusahaan, GetType(String))
    AddParameter("FormatString", glSetting.NumericFormatString, GetType(String))

    _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.ViewGiro)(_sesi)
  End Sub
End Class