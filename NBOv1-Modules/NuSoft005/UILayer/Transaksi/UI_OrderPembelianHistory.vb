Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute
Public Class UI_OrderPembelianHistory
	Dim _xNoTransaksi As String
	Sub New(xNomorTransaksi As String)
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		_xNoTransaksi = xNomorTransaksi
	End Sub
	Overrides Sub FirstLoad()
		Me.session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
		'txtTipe.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(TipeTransaksi))
	End Sub



End Class