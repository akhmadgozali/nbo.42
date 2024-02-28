Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace Logic
  Friend Class Umum
    Shared Function xLokasiLayout(xNamaFile As String) As String
      Dim xLokasi As String
      xLokasi = Replace(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase), "\Modules", "\layout\m01\")
      xLokasi = Replace(xLokasi, "file:\", "")
      xLokasi = xLokasi & xNamaFile
      Return xLokasi
    End Function
    'Shared Sub xLoadLayout(xObject As Object, xNamaFile As String)
    '  If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout(xNamaFile)) = True Then
    '    'lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("DPTransaksi.xml"))
    '    xObject.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout(xNamaFile))
    '  End If
    'End Sub

    Shared Function GetBeginningBalanceSPName() As String
      Return My.Resources.FunctionBeginningBalance
    End Function
  End Class
  Friend Class InventorySetting
    Inherits Core.Modules.SettingBase

    Property PreviewSave As Boolean
    Property LockProduksi As Boolean
    Property UraianPermintaan As String
    Property UraianMutasi As String
    Property UraianPenyesuaian As String
    Property UraianStockOpname As String
    Property UraianProduksi As String
    Sub New(session As DevExpress.Xpo.UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Overrides Function ModuleId() As NPO.Modules.ModuleId
      Return MainClass.GetModuleId
    End Function
  End Class
  Friend Class ItemSetting
    Inherits Core.Modules.SettingBase
    Property CustomItem1 As String
    Property CustomItem2 As String
    Property CustomItem3 As String
    Property CustomItem4 As String
    Property CustomItem5 As String
    Property AkunPersediaan As Integer
    Property AkunPendapatan As Integer
    Property AkunHPP As Integer
    Property AkunDiscPenjualan As Integer
    Property AkunDiscPembelian As Integer
    Property AkunReturPenjualan As Integer
    Property AkunReturPembelian As Integer
    Property PajakIN As Integer
    Property PajakOut As Integer
    Sub New(session As DevExpress.Xpo.UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Overrides Function ModuleId() As NPO.Modules.ModuleId
      Return MainClass.GetModuleId
    End Function
  End Class
End Namespace