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
      xDataLog.Komputer = mKomputer
      xDataLog.Keterangan = mKeterangan
      xDataLog.TipeLOG = mTipe
      data.Add(xDataLog)
    End Sub
    Shared Function xLokasiLayout(xNamaFile As String) As String
      Dim xLokasi As String
      xLokasi = Replace(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase), "\Modules", "\layout\m04\")
      xLokasi = Replace(xLokasi, "file:\", "")
      'Dim dir = xLokasi
      xLokasi = xLokasi & xNamaFile
      'If My.Computer.FileSystem.FileExists(xLokasi) = False Then
      '	If My.Computer.FileSystem.DirectoryExists(dir) = False Then
      '		My.Computer.FileSystem.CreateDirectory(dir)
      '	End If
      '	My.Computer.FileSystem.WriteAllText(xLokasi, "", False)
      'End If
      Return xLokasi
    End Function
    Shared Sub xSaveLayoutGrid(xGrid As DevExpress.XtraGrid.Views.Grid.GridView, xNamaFile As String)
      If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout(xNamaFile)) = True Then
        ' xGrid.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("cekstock.xml"))
        xGrid.SaveLayoutToXml(Logic.Umum.xLokasiLayout(xNamaFile))
      End If
    End Sub
    Shared Sub xLoadLayoutGrid(xObject As DevExpress.XtraGrid.Views.Grid.GridView, xNamaFile As String)
      If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout(xNamaFile)) = True Then
        xObject.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout(xNamaFile))
      End If
    End Sub
    Shared Sub xLoadLayoutLyt(xObject As DevExpress.XtraLayout.LayoutControl, xNamaFile As String)
      If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout(xNamaFile)) = True Then
        xObject.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout(xNamaFile))
      End If
    End Sub

    Shared Function GetBeginningBalanceSPName() As String
      Return My.Resources.FunctionBeginningBalance
    End Function
  End Class
  Public Class InventorySetting
    Inherits Core.Modules.SettingBase

    Property PreviewSave As Boolean
    Property LockProduksi As Boolean
    Property UraianPermintaan As String
    Property UraianMutasi As String
    Property UraianPenyesuaian As String
    Property UraianStockOpname As String
    Property UraianProduksi As String
		Property UraianPemakaianBarang As String
		Property SettingCOAAll As Boolean
		Property KunciSettingCOA As Boolean
		Property Gudang1 As Integer
    Property Gudang2 As Integer
    Property GudangProduksi As Integer
    Sub New(session As DevExpress.Xpo.UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Overrides Function ModuleId() As NPO.Modules.ModuleId
      Return MainClass.GetModuleId
    End Function
  End Class
  Public Class ItemSetting
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
  Friend Class Permintaan
    Shared Function GetPermintaan(sesi As Session, ParamArray xStatus() As NuSoft001.Persistent.StatusTransaksiEnum) As XPCollection(Of Persistent.PermintaanStock)
      Dim criteria As CriteriaOperator = New BinaryOperator("Jenis", Persistent.eJenisPermintaan.PermintaanMutasi)
      If xStatus.GetUpperBound(0) >= 0 Then
        criteria = CriteriaOperator.And(criteria, New InOperator("StatusTransaksi", xStatus))
      End If

      Return New XPCollection(Of Persistent.PermintaanStock)(sesi, criteria)
    End Function
  End Class

  Friend Class xSQLFunction
    Shared Function GetBeginningBalanceSPName() As String
      Return "select f04_getbeginningbalance({0},{1},'{2}',{3})"
    End Function
  End Class

  Public Class Stock
    Public Sub showDataStock(xMenuID As Integer, xNamaDatabase As String, session As UnitOfWork, xIDItem As Int64)
      Dim frm As New UI_DataStock(xIDItem)
      frm.MenuId = xMenuID
      frm.NamaDatabase = xNamaDatabase
      frm.session = session
      frm.ShowDialog()
    End Sub
  End Class
  Public Class SanYu
    Public Sub showDataProduksi(xMenuID As Integer, xNamaDatabase As String, session As UnitOfWork, xIDPenerimaan As Int64)
      Dim frm As New UI_SanyuDataStock(xIDPenerimaan)
      frm.MenuId = xMenuID
      frm.NamaDatabase = xNamaDatabase
      frm.session = session
      frm.ShowDialog()
    End Sub
  End Class
End Namespace