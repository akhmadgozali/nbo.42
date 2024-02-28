Imports DevExpress.Xpo
Imports NuSoft.NPO

Namespace Persistent
	<Persistent("m04cstockmain")>
	Friend Class PenerimaanBarang
		Inherits Persistent.TransactionMain

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _id As Int32
		Private _vendor As NuSoft001.Persistent.Kontak
		Private _idorder As Persistent.OrderPembelian
		Private _kontakperson As String
		Private _gudang As NuSoft004.Persistent.Gudang
		Private _alamat As String
		Private _bagpembelian As NuSoft001.Persistent.Kontak
		Private _nokendaraan As String
		Private _nosj As String
		Private _supir As String
		Private _uang As NuSoft001.Persistent.MataUang
		Private _kurs As Double
		Private _uraian As String
		Private _status As NuSoft001.Persistent.StatusTransaksiEnum
		Private _tipe As NuSoft004.Persistent.TipeTransaksi
		Private _gl As Persistent.GlMain

		<Persistent("f_contact")>
		Property Vendor As NuSoft001.Persistent.Kontak
			Get
				Return _vendor
			End Get
			Set(value As NuSoft001.Persistent.Kontak)
				SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Vendor", _vendor, value)
			End Set
		End Property
		<Persistent("d_person")>
		Property KontakPerson As String
			Get
				Return _kontakperson
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("KontakPerson", _kontakperson, value)
			End Set
		End Property
		<Persistent("f_warehouse")>
		Property Gudang As NuSoft004.Persistent.Gudang
			Get
				Return _gudang
			End Get
			Set(value As NuSoft004.Persistent.Gudang)
				SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang", _gudang, value)
			End Set
		End Property
		<Persistent("f_employee")>
		Property Karyawan As NuSoft001.Persistent.Kontak
			Get
				Return _bagpembelian
			End Get
			Set(value As NuSoft001.Persistent.Kontak)
				SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _bagpembelian, value)
			End Set
		End Property
		<Persistent("d_address")>
		Property Alamat As String
			Get
				Return _alamat
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Alamat", _alamat, value)
			End Set
		End Property
		<Persistent("d_nodocument")>
		Property NoSJ As String
			Get
				Return _nosj
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("NoSJ", _nosj, value)
			End Set
		End Property
		<Persistent("d_driver")>
		Property Supir As String
			Get
				Return _supir
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Supir", _supir, value)
			End Set
		End Property
		<Persistent("d_novehicle")>
		Property NoKendaraan As String
			Get
				Return _nokendaraan
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("NoKendaraan", _nokendaraan, value)
			End Set
		End Property
		<Persistent("d_kurs")>
		Property Kurs As Double
			Get
				Return _kurs
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("Kurs", _kurs, value)
			End Set
		End Property
		<Persistent("f_currency")>
		Property MataUang As NuSoft001.Persistent.MataUang
			Get
				Return _uang
			End Get
			Set(value As NuSoft001.Persistent.MataUang)
				SetPropertyValue(Of NuSoft001.Persistent.MataUang)("MataUang", _uang, value)
			End Set
		End Property
    <Persistent("f_idpo"), Association("fk_OrderPembelian_PenerimaanBarang")>
    Property NoOrder As Persistent.OrderPembelian
			Get
				Return _idorder
			End Get
			Set(value As Persistent.OrderPembelian)
				SetPropertyValue(Of Persistent.OrderPembelian)("NoOrder", _idorder, value)
			End Set
		End Property
		<Persistent("d_remarks")>
		Property Uraian As String
			Get
				Return _uraian
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Uraian", _uraian, value)
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
		<Persistent("f_type")>
		Property TipeTransaksi As NuSoft004.Persistent.TipeTransaksi
			Get
				Return _tipe
			End Get
			Set(value As NuSoft004.Persistent.TipeTransaksi)
				SetPropertyValue(Of NuSoft004.Persistent.TipeTransaksi)("TipeTransaksi", _tipe, value)
			End Set
		End Property
		<Persistent("f_gl")> Property Gl As GlMain
			Get
				Return _gl
			End Get
			Set(value As GlMain)
				SetPropertyValue(Of GlMain)("Gl", _gl, value)
			End Set
		End Property

		<Association("fk_penerimaan_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of PenerimaanBarangDetail)
			Get
				Return GetCollection(Of PenerimaanBarangDetail)("Detail")
			End Get
		End Property
		<PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("TotalQty"))
			End Get
		End Property
		<PersistentAlias("Detail.Sum(SubTotal)")> ReadOnly Property TotalTransaksi As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("TotalTransaksi"))
			End Get
		End Property

		Private Function CheckData() As Boolean
			Dim source As String = "Penerimaan Barang [GR]"
			If IsDeleted Then
				Return True
			End If
			If Regional Is Nothing Then
				Throw New Utils.Exception("Masukkan regional", -1, "", source)
				Return False
			End If
			If Tanggal = Nothing Then
				Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
				Return False
			End If
			If Vendor Is Nothing Then
				Throw New Utils.Exception("Masukkan Vendor", -4, "", source)
				Return False
			End If
			If Gudang Is Nothing Then
				Throw New Utils.Exception("Masukkan gudang", -5, "", source)
				Return False
			End If
			If Karyawan Is Nothing Then
				Throw New Utils.Exception("Masukkan karyawan penerima barang", -6, "", source)
				Return False
			End If
			If Detail.Sum(Function(m) m.Qty) = 0 Then
				Throw New Utils.Exception("Masukkan nilai qty", -7, "", source)
			End If
			If Session.IsNewObject(Me) Then
				If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
					Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -7, "", source)
					Return False
				End If
			End If
			Return True
		End Function
		Protected Overrides Sub OnSaving()
			For i = 0 To Detail.Count - 1
				Detail(i).Gudang = _gudang
			Next
			If Not CheckData() Then
				Return
			End If
			If Kode = Nothing Then
				Kode = Number.GetNewNumber.Kode
			End If
			MyBase.OnSaving()
		End Sub
	End Class

	<Persistent("m04dstockdetail")>
	Friend Class PenerimaanBarangDetail
		Inherits NPOBase

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _id As Int64
		Private _main As Persistent.PenerimaanBarang
		Private _gudang As NuSoft004.Persistent.Gudang
		Private _item As NuSoft004.Persistent.Barang
		Private _qty As Double
		Private _satuan As NuSoft004.Persistent.Satuan
		Private _harga As Double
		Private _divisi As NPO.Modules.ModSys.Divisi
		Private _idpermintaan As Persistent.PermintaanStockDetail
		Private _idpo As Persistent.OrderPembelianDetail
		Private _catatan As String

		<Persistent("primary_main"), Key(True)>
		Property Id As Int64
			Get
				Return _id
			End Get
			Set(value As Int64)
				SetPropertyValue(Of Int64)("Id", _id, value)
			End Set
		End Property
		<Persistent("p_id"), Association("fk_penerimaan_detail")>
		Property Main As PenerimaanBarang
			Get
				Return _main
			End Get
			Set(value As PenerimaanBarang)
				SetPropertyValue(Of PenerimaanBarang)("Main", _main, value)
			End Set
		End Property
		<Persistent("f_warehouse")>
		Property Gudang As NuSoft004.Persistent.Gudang
			Get
				Return _gudang
			End Get
			Set(value As NuSoft004.Persistent.Gudang)
				SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang", _gudang, value)
			End Set
		End Property
		<Persistent("f_item")>
		Property Barang As NuSoft004.Persistent.Barang
			Get
				Return _item
			End Get
			Set(value As NuSoft004.Persistent.Barang)
				SetPropertyValue(Of NuSoft004.Persistent.Barang)("Barang", _item, value)
			End Set
		End Property
		<Persistent("f_uom")>
		Property Satuan As NuSoft004.Persistent.Satuan
			Get
				Return _satuan
			End Get
			Set(value As NuSoft004.Persistent.Satuan)
				SetPropertyValue(Of NuSoft004.Persistent.Satuan)("Satuan", _satuan, value)
			End Set
		End Property
		<Persistent("d_qtyin")>
		Property Qty As Double
			Get
				Return _qty
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("Qty", _qty, value)
			End Set
		End Property
		<Persistent("d_price")>
		Property Harga As Double
			Get
				Return _harga
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("Harga", _harga, value)
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
    <Persistent("f_idpod"), Association("fk_OrderPembelianDetail_PenerimaanBarangDetail")>
    Property OrderDetail As Persistent.OrderPembelianDetail
			Get
				Return _idpo
			End Get
			Set(value As Persistent.OrderPembelianDetail)
				SetPropertyValue(Of Persistent.OrderPembelianDetail)("PermintaanDetail", _idpo, value)
			End Set
		End Property
		<PersistentAlias("(Qty * Harga)")> ReadOnly Property SubTotal As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("SubTotal"))
			End Get
		End Property

    <Association("fk_penerimaan_detail_serial"), Aggregated> ReadOnly Property DetailSerial As XPCollection(Of PenerimaanBarangDetailSerial)
      Get
        Return GetCollection(Of PenerimaanBarangDetailSerial)("DetailSerial")
      End Get
    End Property

    Private Function CheckData() As Boolean
			Dim source As String = "Penerimaan Barang [GR]"
			If IsDeleted Then
				Return True
			End If
			If _main Is Nothing AndAlso Not IsDeleted Then
				Throw New Utils.Exception("Masukkan data utama permintaan penawaran", -99, "", source)
				Return False
			End If
			If _gudang Is Nothing AndAlso Not IsDeleted Then
				Throw New Utils.Exception("Masukkan kode gudang", -99, "", source)
				Return False
			End If
			If _item Is Nothing Then
				Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
				Return False
			End If
			If _qty = Nothing AndAlso Not IsDeleted Then
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

  <Persistent("m04dstockdetailserial")>
  Friend Class PenerimaanBarangDetailSerial
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _detail As Persistent.PenerimaanBarangDetail
    Private _serial As String
    Private _length As Double

    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_penerimaan_detail_serial")>
    Property DetailMain As PenerimaanBarangDetail
      Get
        Return _detail
      End Get
      Set(value As PenerimaanBarangDetail)
        SetPropertyValue(Of PenerimaanBarangDetail)("DetailMain", _detail, value)
      End Set
    End Property
    <Persistent("d_length")>
    Property Length As Double
      Get
        Return _length
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Length", _length, value)
      End Set
    End Property
    <Persistent("d_noserial")>
    Property Serial As String
      Get
        Return _serial
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Serial", _serial, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Penerimaan Barang [GR]"
      If IsDeleted Then
        Return True
      End If

      If _detail Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama permintaan penawaran", -99, "", source)
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