Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace Logic
  Friend Class Umum
    Shared Sub SaveLog(mSession As Session, mTipe As Persistent.TipeLOG, mKomputer As String, mKeterangan As String)
      Dim xDataLog As New Persistent.zLOG(mSession)
      Dim data As New XPCollection(Of Persistent.zLOG)(mSession)
      xDataLog.Komputer = mKomputer
      xDataLog.Keterangan = mKeterangan
      xDataLog.TipeLOG = mTipe
      data.Add(xDataLog)
    End Sub

    Shared Function xLokasiLayout(xNamaFile As String) As String
      Dim xLokasi As String
      xLokasi = Replace(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase), "\Modules", "\layout\m05\")
      xLokasi = Replace(xLokasi, "file:\", "")
      xLokasi = xLokasi & xNamaFile
      Return xLokasi
    End Function
    Shared Sub xLoadLayout(xObject As Object, xNamaFile As String)
      If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout(xNamaFile)) = True Then
        xObject.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout(xNamaFile))
      End If
    End Sub
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
  End Class
  Friend Class PurchaseSetting
    Inherits Core.Modules.SettingBase

    Property MultiPO As Boolean
    Property FilterKontak As Boolean
    Property TipeKontak As Integer
    Property AutoSearchKontak As Integer
    Property PreviewReport As Boolean
    Property CoaHutangSementara As Integer
    Property CoaPPN As Integer
    Property CoaPPH As Integer
    Property CoaBiayaLain As Integer
    Property CoaBiayaPembulatan As Integer
    Property CoaAdminBank As Integer
		Property CoaPendapatan As Integer
		Property CoaSelisihRI As Integer
		Property UraianRQ As String
    Property UraianPO As String
    Property UraianAP As String
    Property UraianGR As String
    Property UraianRI As String
    Property UraianVP As String
    Property SetingAPRegional As Boolean
    Property GudangDefault As Integer
    Property SettingCoaHutang As Integer
    Property ApprovalPO As Boolean
		Property PajakBM As Integer
		Property EditHargaRI As Boolean
		Sub New(session As DevExpress.Xpo.UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Overrides Function ModuleId() As NPO.Modules.ModuleId
      Return MainClass.GetModuleId
    End Function
  End Class
  Friend Class Permintaan
    Shared Function GetPermintaan(sesi As Session, ParamArray xStatus() As NuSoft001.Persistent.StatusTransaksiEnum) As XPCollection(Of NuSoft005.Persistent.PermintaanStock)
      Dim criteria As CriteriaOperator = New BinaryOperator("Jenis", NuSoft004.Persistent.eJenisPermintaan.PermintaanPembelian)
      If xStatus.GetUpperBound(0) >= 0 Then
        criteria = CriteriaOperator.And(criteria, New InOperator("StatusTransaksi", xStatus))
      End If
      Return New XPCollection(Of NuSoft005.Persistent.PermintaanStock)(sesi, criteria)
    End Function
  End Class
  Public Class Purchase
    Shared Function GetInvoicePPN(sesi As Session, xPeriode1 As Date, xPeriode2 As Date) As XPCollection(Of Persistent.ViewInvoicePPN)
      Dim xData As New XPCollection(Of NuSoft005.Persistent.ViewInvoicePPN)(sesi, New BetweenOperator("Tanggal", xPeriode1, xPeriode2))
      For pi = 0 To xData.Count - 1
        Dim xInvoice As Persistent.PenerimaanInvoice = sesi.GetObjectByKey(Of Persistent.PenerimaanInvoice)(xData(pi).Id)
        xData(pi).DPP = xInvoice.SubTotal
        xData(pi).NilaiPajak = xInvoice.PPN
      Next
      Return xData
    End Function
  End Class
End Namespace