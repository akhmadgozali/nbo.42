Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports NuSoft.Utils.CustomAttribute
Namespace Logic
  Friend Class Umum
    Shared Sub SaveLog(mSession As UnitOfWork, mTipe As Persistent.TipeLOG, mKomputer As String, mKeterangan As String)
      Dim xDataLog As New Persistent.zLOG(mSession)
      Dim data As New XPCollection(Of Persistent.zLOG)(mSession)
      xDataLog.Id = 0
      xDataLog.Komputer = mKomputer
      xDataLog.Keterangan = mKeterangan
      xDataLog.TipeLOG = mTipe
      data.Add(xDataLog)
    End Sub

    Shared Function xLokasiLayout(xNamaFile As String) As String
      Dim xLokasi As String
      xLokasi = Replace(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase), "\Modules", "\layout\m06\")
      xLokasi = Replace(xLokasi, "file:\", "")
      xLokasi = xLokasi & xNamaFile
      Return xLokasi
    End Function
    Shared Function xLokasiStruk(xNamaFile As String) As String
      Dim xLokasi As String
      xLokasi = Replace(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase), "\Modules", "\Struk")
      xLokasi = Replace(xLokasi, "file:\", "")
      xLokasi = xLokasi & xNamaFile
      Return xLokasi
    End Function

    Shared Sub xHistoryData(xForm As Object, xSession As DevExpress.Xpo.UnitOfWork, Tipe As UI_CekData.TipeTransaksi, xNoBukti As String)
      Dim xHistory As New UI_CekData(UI_CekData.TipeForm.Dialog)
      xHistory.session = xSession
      xHistory.MenuId = xForm.MenuId
      xHistory.NamaDatabase = xForm.NamaDatabase
      xHistory.txtTipe.EditValue = Tipe
      xHistory.txtNoTransaksi.EditValue = xNoBukti
      xHistory.btnCari_Click(xHistory.btnCari, Nothing)
      xHistory.ShowDialog()
    End Sub
    Shared Sub xLoadLayout(xObject As Object, xNamaFile As String)
      If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout(xNamaFile)) = True Then
        xObject.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout(xNamaFile))
      End If
    End Sub
  End Class
  Public Class SalesSetting
    Inherits Core.Modules.SettingBase

    Property MultiSO As Boolean
    Property FilterKontak As Boolean
    Property TipeKontak As Integer
    Property TipeHPP As Integer
    Property AutoSearchKontak As Integer
    Property PreviewSave As Boolean
    Property KaryawanDefault As Integer
    Property UraianSQ As String
    Property UraianSO As String
    Property UraianDP As String
    Property UraianDO As String
    Property UraianIV As String
    Property UraianCP As String
    Property UraianRN As String
    Property UraianSR As String
    Property UraianBR As String
    Property UraianQS As String
		Property UraianRetur As String
		Property UraianRAB As String
		Property CoaPPN As Integer
    Property CoaPPH As Integer
    Property CoaBiayaLain As Integer
    Property CoaBiayaPembulatan As Integer
    Property CoaAdminBank As Integer
    Property CoaPendapatan As Integer
		Property CoaLabaSelisihKurs As Integer
		Property CoaRugiSelisihKurs As Integer
		Property CoaCustom1 As Integer
		Property CoaCustom2 As Integer
    Property CoaCustom3 As Integer
    Property CoaCustom4 As Integer
    Property CoaCustom5 As Integer
    Property OpenPriceInvoice As Boolean
    Property OpenTaxIV As Boolean
		Property OpenPriceIV As Boolean
		Property POSCOACash As Integer
		Property POSCOADebit As Integer
    Property POSCOACredit As Integer
    Property POSPelanggan As Integer
    Property POSPajak As Integer
    Property POSAddRowGrid As Boolean
    Property POSCoaPendapatan As Integer
    Property POSBarangCombo As Integer
    Property POSServerStruk As String
    Property GudangDefault As Integer
		Property FusohBeratPallet As Integer
    Property DiskonCustomer As Integer
    Property AutoUraian As Boolean

    Property SetingARRegional As Boolean

    Sub New(session As DevExpress.Xpo.UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Overrides Function ModuleId() As NPO.Modules.ModuleId
      Return MainClass.GetModuleId
    End Function
  End Class
	Public Class SanYu
		Public Sub showDataPenjualan(xMenuID As Integer, xNamaDatabase As String, session As UnitOfWork, xIDPenerimaan As Int64)
			Dim frm As New UI_SanyuDataStock(xIDPenerimaan)
			frm.MenuId = xMenuID
			frm.NamaDatabase = xNamaDatabase
			frm.session = session
			frm.ShowDialog()
		End Sub
	End Class
End Namespace
