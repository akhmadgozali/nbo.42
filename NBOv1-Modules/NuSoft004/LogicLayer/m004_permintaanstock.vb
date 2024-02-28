Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports DevExpress.XtraCharts.Native
Namespace Persistent
  <Persistent("m04cmainrequest")>
  Friend Class PermintaanStock
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
    Private _jenis As Persistent.eJenisPermintaan
  Private _karyawan As NuSoft001.Persistent.Kontak
    Private _gudang As Gudang
    Private _departemen As NPO.Modules.ModSys.Divisi
    Private _catatan As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    <Persistent("f_type")>
    Property Jenis As Persistent.eJenisPermintaan
      Get
        Return _jenis
      End Get
      Set(value As Persistent.eJenisPermintaan)
        SetPropertyValue(Of Persistent.eJenisPermintaan)("Jenis", _jenis, value)
      End Set
    End Property
    <Persistent("f_employee")>
    Property Karyawan As NuSoft001.Persistent.Kontak
      Get
        Return _karyawan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _karyawan, value)
      End Set
    End Property
    <Persistent("f_warehouse")>
    Property Gudang As Gudang
      Get
        Return _gudang
      End Get
      Set(value As Gudang)
        SetPropertyValue(Of Gudang)("Gudang", _gudang, value)
      End Set
    End Property
    <Persistent("f_division")>
    Property Divisi As NPO.Modules.ModSys.Divisi
      Get
        Return _departemen
      End Get
      Set(value As NPO.Modules.ModSys.Divisi)
        SetPropertyValue(Of NPO.Modules.ModSys.Divisi)("Divisi", _departemen, value)
      End Set
    End Property
    <Persistent("d_remarks")>
    Property Catatan As String
      Get
        Return _catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _catatan, value)
      End Set
    End Property
    <Persistent("d_status")>
    Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
      End Set
    End Property
		<PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("TotalQty"))
			End Get
		End Property
		<Association("fk_permintaan_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of PermintaanStockDetail)
			Get
				Return GetCollection(Of PermintaanStockDetail)("Detail")
			End Get
		End Property
		Private Function CheckData() As Boolean
			Dim source As String = "Permintaan Barang"
			If Regional Is Nothing Then
				Throw New Utils.Exception("Masukkan regional", -1, "", source)
				Return False
			End If
			If Tanggal = Nothing Then
				Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
				Return False
			End If
			If Karyawan Is Nothing Then
				Throw New Utils.Exception("Masukkan karyawan", -4, "", source)
				Return False
			End If
			If Gudang Is Nothing Then
				Throw New Utils.Exception("Masukkan gudang", -5, "", source)
				Return False
			End If
			If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
				Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -6, "", source)
				Return False
			End If
			Return True
		End Function
		Protected Overrides Sub OnSaving()
			If Not CheckData() Then
				Return
			End If
			If Kode = Nothing Then
				Kode = Number.GetNewNumber.Kode
			End If
			MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m04ddetailrequest")>
  Friend Class PermintaanStockDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.PermintaanStock
    Private _item As Barang
    Private _qty As Double
    Private _satuan As Satuan
    Private _catatan As String
    Private _divisi As NPO.Modules.ModSys.Divisi
    Private _proyek As NuSoft001.Persistent.Proyek
    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_permintaan_detail")>
    Property Main As PermintaanStock
      Get
        Return _main
      End Get
      Set(value As PermintaanStock)
        SetPropertyValue(Of PermintaanStock)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_item")>
    Property Barang As Barang
      Get
        Return _item
      End Get
      Set(value As Barang)
        SetPropertyValue(Of Barang)("Barang", _item, value)
      End Set
    End Property
    <Persistent("f_uom")>
    Property Satuan As Satuan
      Get
        Return _satuan
      End Get
      Set(value As Satuan)
        SetPropertyValue(Of Satuan)("Satuan", _satuan, value)
      End Set
    End Property
    <Persistent("d_qty")>
    Property Qty As Double
      Get
        Return _qty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qty, value)
      End Set
    End Property
    <Persistent("d_remarks")>
    Property Catatan As String
      Get
        Return _catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _catatan, value)
      End Set
    End Property
    <Persistent("f_division")>
    Property Divisi As NPO.Modules.ModSys.Divisi
      Get
        Return _divisi
      End Get
      Set(value As NPO.Modules.ModSys.Divisi)
        SetPropertyValue(Of NPO.Modules.ModSys.Divisi)("Catatan", _divisi, value)
      End Set
    End Property
    <Persistent("f_proyek")>
    Property Proyek As NuSoft001.Persistent.Proyek
      Get
        Return _proyek
      End Get
      Set(value As NuSoft001.Persistent.Proyek)
        SetPropertyValue(Of NuSoft001.Persistent.Proyek)("Proyek", _proyek, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.FullName
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama permintaan stock", -99, "", source)
        Return False
      End If
      If _item Is Nothing Then
        Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
        Return False
      End If
      If _qty = Nothing Then
        Throw New Utils.Exception("Masukkan qty", -99, "", source)
        Return False
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      MyBase.OnSaving()
    End Sub
  End Class
End Namespace