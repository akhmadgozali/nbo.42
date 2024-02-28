Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute

Namespace Persistent
	Friend Enum eVehicle
		<EnumDescription("Patra Niaga")> Niaga1
		<EnumDescription("Patra Niaga")> Niaga2
		<EnumDescription("Patra Niaga")> Niaga3
		<EnumDescription("Patra Niaga")> Niaga4
		<EnumDescription("Sumber Untung")> Untung1
		<EnumDescription("Sumber Untung")> Untung2
		<EnumDescription("Sumber Untung")> Untung3
		<EnumDescription("Sumber Untung")> Untung4
		<EnumDescription("Sumber Untung")> Untung5
	End Enum
	Friend Enum eOrderType
		Planned
	End Enum
	Friend Enum eOrderStatus
		Fully_Scheduled
	End Enum

	<Persistent("m06cmainquotation")> Friend Class Tm_Penawaran
		Inherits TransactionMain

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _pelanggan As NuSoft001.Persistent.Kontak
		Private _status As NuSoft001.Persistent.StatusTransaksiEnum
		Private _orderType As eOrderType '_fob As NuSoft005.Persistent.eTipeFOB
		Private _orderStatus As eOrderStatus '_pajak As NuSoft005.Persistent.eTipePajak
		Private _orderStart As Date '_tglberlaku As Date
		Private _remarks As String '_catatan As String
		Private _description As String '_leadtime As String
		Private _orderEnd As Date

		'Private _alamat As NuSoft001.Persistent.KontakAlamat
		'Private _kontakperson As String
		'Private _tipe As NuSoft004.Persistent.TipeTransaksi
		'Private _salesman As NuSoft001.Persistent.Kontak
		'Private _via As NuSoft005.Persistent.Via
		'Private _termin As NuSoft005.Persistent.Termin
		'Private _uang As NuSoft001.Persistent.MataUang
		'Private _disc As Double
		'Private _othercost As Double

		<Persistent("f_customer")> Property Pelanggan As NuSoft001.Persistent.Kontak
			Get
				Return _pelanggan
			End Get
			Set(value As NuSoft001.Persistent.Kontak)
				SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _pelanggan, value)
			End Set
		End Property
		<Persistent("d_status")> Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
			Get
				Return _status
			End Get
			Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
				SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
			End Set
		End Property
		<Persistent("d_fob")> Property OrderType As eOrderType
			Get
				Return _orderType
			End Get
			Set(value As eOrderType)
				SetPropertyValue(Of eOrderType)("OrderType", _orderType, value)
			End Set
		End Property
		<Persistent("d_taxtype")> Property OrderStatus As eOrderStatus
			Get
				Return _orderStatus
			End Get
			Set(value As eOrderStatus)
				SetPropertyValue(Of eOrderStatus)("OrderStatus", _orderStatus, value)
			End Set
		End Property
		<Persistent("d_efectivedate")> Property OrderStart As Date
			Get
				Return _orderStart
			End Get
			Set(value As Date)
				SetPropertyValue(Of Date)("OrderStart", _orderStart, value)
			End Set
		End Property
		<Persistent("d_remarks")> Property Remarks As String
			Get
				Return _remarks
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Remarks", _remarks, value)
			End Set
		End Property
		<Persistent("d_leadtime")> Property Description As String
			Get
				Return _description
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Description", _description, value)
			End Set
		End Property
		<Persistent("d_efectivedate2")> Property OrderEnd As Date
			Get
				Return _orderEnd
			End Get
			Set(value As Date)
				SetPropertyValue(Of Date)("OrderEnd", _orderEnd, value)
			End Set
		End Property

		'<Persistent("f_address")> Property Alamat As NuSoft001.Persistent.KontakAlamat
		'	Get
		'		Return _alamat
		'	End Get
		'	Set(value As NuSoft001.Persistent.KontakAlamat)
		'		SetPropertyValue(Of NuSoft001.Persistent.KontakAlamat)("Alamat", _alamat, value)
		'	End Set
		'End Property
		'<Persistent("d_contact")> Property KontakPerson As String
		'	Get
		'		Return _kontakperson
		'	End Get
		'	Set(value As String)
		'		SetPropertyValue(Of String)("KontakPerson", _kontakperson, value)
		'	End Set
		'End Property
		'<Persistent("f_jenis")> Property TipeTransaksi As NuSoft004.Persistent.TipeTransaksi
		'	Get
		'		Return _tipe
		'	End Get
		'	Set(value As NuSoft004.Persistent.TipeTransaksi)
		'		SetPropertyValue(Of NuSoft004.Persistent.TipeTransaksi)("TipeTransaksi", _tipe, value)
		'	End Set
		'End Property
		'<Persistent("f_employee")> Property Salesman As NuSoft001.Persistent.Kontak
		'	Get
		'		Return _salesman
		'	End Get
		'	Set(value As NuSoft001.Persistent.Kontak)
		'		SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Salesman", _salesman, value)
		'	End Set
		'End Property
		'<Persistent("f_via")> Property Via As NuSoft005.Persistent.Via
		'	Get
		'		Return _via
		'	End Get
		'	Set(value As NuSoft005.Persistent.Via)
		'		SetPropertyValue(Of NuSoft005.Persistent.Via)("Via", _via, value)
		'	End Set
		'End Property
		'<Persistent("f_termin")> Property Termin As NuSoft005.Persistent.Termin
		'	Get
		'		Return _termin
		'	End Get
		'	Set(value As NuSoft005.Persistent.Termin)
		'		SetPropertyValue(Of NuSoft005.Persistent.Termin)("Termin", _termin, value)
		'	End Set
		'End Property
		'<Persistent("f_currency")> Property Uang As NuSoft001.Persistent.MataUang
		'	Get
		'		Return _uang
		'	End Get
		'	Set(value As NuSoft001.Persistent.MataUang)
		'		SetPropertyValue(Of NuSoft001.Persistent.MataUang)("Uang", _uang, value)
		'	End Set
		'End Property
		'<Persistent("d_disc")> Property Discount As Double
		'	Get
		'		Return _disc
		'	End Get
		'	Set(value As Double)
		'		SetPropertyValue(Of Double)("Discount", _disc, value)
		'	End Set
		'End Property
		'<Persistent("d_othercost")> Property BiayaLain As Double
		'	Get
		'		Return _othercost
		'	End Get
		'	Set(value As Double)
		'		SetPropertyValue(Of Double)("BiayaLain", _othercost, value)
		'	End Set
		'End Property

		<PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("TotalQty"))
			End Get
		End Property
		<PersistentAlias("Detail.Sum(OrderDetail.Count())")> ReadOnly Property TotalShipment As Integer
			Get
				Return Convert.ToDouble(EvaluateAlias("TotalShipment"))
			End Get
		End Property
		'<PersistentAlias("Detail.Sum(DPP)")> ReadOnly Property SubTotal As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("SubTotal"))
		'	End Get
		'End Property
		'<PersistentAlias("Detail.Sum(PPNv)")> ReadOnly Property PPN As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("PPN"))
		'	End Get
		'End Property
		'<PersistentAlias("Detail.Sum(PPHv)")> ReadOnly Property PPH As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("PPH"))
		'	End Get
		'End Property
		'<PersistentAlias("(SubTotal + PPN - PPH)")> ReadOnly Property Total As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("Total"))
		'	End Get
		'End Property
		'<PersistentAlias("Terbilang(Total)")> ReadOnly Property Terbilang As String
		'	Get
		'		Return Convert.ToString(EvaluateAlias("Terbilang"))
		'	End Get
		'End Property
		'<PersistentAlias("Terbilang(Total,Uang.Nama)")> ReadOnly Property TerbilangMataUang As String
		'	Get
		'		Return Convert.ToString(EvaluateAlias("TerbilangMataUang"))
		'	End Get
		'End Property

		<Association("fk_tm_penawaran_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Tm_PenawaranDetail)
			Get
				Return GetCollection(Of Tm_PenawaranDetail)("Detail")
			End Get
		End Property
		Private Function CheckData() As Boolean
			Dim source As String = "Order"
			If Regional Is Nothing Then
				Throw New Utils.Exception("Masukkan regional", -1, "", source)
				Return False
			End If
			If Tanggal = Nothing Then
				Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
				Return False
			End If
			If Pelanggan Is Nothing Then
				Throw New Utils.Exception("Masukkan Pelanggan", -4, "", source)
				Return False
			End If
			'If Uang Is Nothing Then
			'	Throw New Utils.Exception("Masukkan mata uang", -6, "", source)
			'End If
			'If TipeTransaksi Is Nothing Then
			'	Throw New Utils.Exception("Masukkan tipe transaksi", -7, "", source)
			'End If
			If Session.IsNewObject(Me) Then
				If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
					Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -8, "", source)
					Return False
				End If
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
	<Persistent("m06ddetailquotation")> Friend Class Tm_PenawaranDetail
		Inherits NPOBase

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _id As Int64
		Private _main As Tm_Penawaran
		Private _item As NuSoft004.Persistent.Barang
		Private _qty As Double
		Private _satuan As NuSoft004.Persistent.Satuan
		'Private _harga As Double
		'Private _ppn As NuSoft004.Persistent.Pajak
		'Private _ppnp As Double
		'Private _pph As NuSoft004.Persistent.Pajak
		'Private _pphp As Double
		'Private _disc As Double
		'Private _discp As Double
		'Private _divisi As NPO.Modules.ModSys.Divisi
		Private _catatan As String

		<Persistent("primary_main"), Key(True)> Property Id As Int64
			Get
				Return _id
			End Get
			Set(value As Int64)
				SetPropertyValue(Of Int64)("Id", _id, value)
			End Set
		End Property
		<Persistent("p_id"), Association("fk_tm_penawaran_detail")> Property Main As Tm_Penawaran
			Get
				Return _main
			End Get
			Set(value As Tm_Penawaran)
				SetPropertyValue(Of Tm_Penawaran)("Main", _main, value)
			End Set
		End Property
		<Persistent("f_item")> Property Barang As NuSoft004.Persistent.Barang
			Get
				Return _item
			End Get
			Set(value As NuSoft004.Persistent.Barang)
				SetPropertyValue(Of NuSoft004.Persistent.Barang)("Barang", _item, value)
			End Set
		End Property
		<Persistent("f_uom")> Property Satuan As NuSoft004.Persistent.Satuan
			Get
				Return _satuan
			End Get
			Set(value As NuSoft004.Persistent.Satuan)
				SetPropertyValue(Of NuSoft004.Persistent.Satuan)("Satuan", _satuan, value)
			End Set
		End Property
		<Persistent("d_qty")> Property Qty As Double
			Get
				Return _qty
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("Qty", _qty, value)
			End Set
		End Property
		'<Persistent("d_price")>
		'Property Harga As Double
		'	Get
		'		Return _harga
		'	End Get
		'	Set(value As Double)
		'		SetPropertyValue(Of Double)("Harga", _harga, value)
		'	End Set
		'End Property
		'<Persistent("d_disc")>
		'Property Discount As Double
		'	Get
		'		Return _disc
		'	End Get
		'	Set(value As Double)
		'		SetPropertyValue(Of Double)("Discount", _disc, value)
		'	End Set
		'End Property
		'<Persistent("d_discp")>
		'Property DiscountPersen As Double
		'	Get
		'		Return _discp
		'	End Get
		'	Set(value As Double)
		'		SetPropertyValue(Of Double)("DiscountPersen", _discp, value)
		'	End Set
		'End Property
		'<Persistent("f_taxin")>
		'Property PPN As NuSoft004.Persistent.Pajak
		'	Get
		'		Return _ppn
		'	End Get
		'	Set(value As NuSoft004.Persistent.Pajak)
		'		SetPropertyValue(Of NuSoft004.Persistent.Pajak)("PPN", _ppn, value)
		'	End Set
		'End Property
		'<Persistent("d_taxinp")>
		'Property PPNp As Double
		'	Get
		'		Return _ppnp
		'	End Get
		'	Set(value As Double)
		'		SetPropertyValue(Of Double)("PPNp", _ppnp, value)
		'	End Set
		'End Property
		'<Persistent("f_taxout")>
		'Property PPH As NuSoft004.Persistent.Pajak
		'	Get
		'		Return _pph
		'	End Get
		'	Set(value As NuSoft004.Persistent.Pajak)
		'		SetPropertyValue(Of NuSoft004.Persistent.Pajak)("PPN", _pph, value)
		'	End Set
		'End Property
		'<Persistent("d_taxoutp")>
		'Property PPHp As Double
		'	Get
		'		Return _pphp
		'	End Get
		'	Set(value As Double)
		'		SetPropertyValue(Of Double)("PPHp", _pphp, value)
		'	End Set
		'End Property
		'<Persistent("f_division")>
		'Property Divisi As NPO.Modules.ModSys.Divisi
		'	Get
		'		Return _divisi
		'	End Get
		'	Set(value As NPO.Modules.ModSys.Divisi)
		'		SetPropertyValue(Of NPO.Modules.ModSys.Divisi)("Catatan", _divisi, value)
		'	End Set
		'End Property
		<Persistent("d_remarks")> Property Catatan As String
			Get
				Return _catatan
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Catatan", _catatan, value)
			End Set
		End Property

		'<PersistentAlias("iif(Main.TipePajak = 0,0,PPNp / 100 * DPP)")> ReadOnly Property PPNv As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("PPNv"))
		'	End Get
		'End Property
		'<PersistentAlias("iif(Main.TipePajak = 0,0,PPHp / 100 * DPP)")> ReadOnly Property PPHv As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("PPHv"))
		'	End Get
		'End Property
		'<PersistentAlias("Qty * Harga")> ReadOnly Property SubTotal As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("SubTotal"))
		'	End Get
		'End Property
		'<PersistentAlias("iif(Main.TipePajak = 1,((Qty * Harga) + PPNv - PPHv), Qty * Harga)")> ReadOnly Property Total As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("Total"))
		'	End Get
		'End Property
		'<PersistentAlias("iif(Main.TipePajak = 2,(Qty * Harga) - ((PPNp - PPHp) / (100 + (PPNp - PPHp)) * (Qty * Harga)),Qty * Harga)")> ReadOnly Property DPP As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("DPP"))
		'	End Get
		'End Property
		<Association("fk_tm_penawaran_detail_order")> ReadOnly Property OrderDetail As XPCollection(Of Tm_OrderPenjualanDetail)
			Get
				Return GetCollection(Of Tm_OrderPenjualanDetail)("OrderDetail")
			End Get
		End Property

		<PersistentAlias("OrderDetail.Sum(Qty)")> ReadOnly Property LoadedQty As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("LoadedQty"))
			End Get
		End Property
		<PersistentAlias("Qty - OrderDetail.Sum(Qty)")> ReadOnly Property RemainingQty As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("RemainingQty"))
			End Get
		End Property
		<PersistentAlias("Main.Kode")> ReadOnly Property Kode As String
			Get
				Return EvaluateAlias("Kode").ToString
			End Get
		End Property


		Private Function CheckData() As Boolean
			Dim source As String = "Order"
			If IsDeleted Then
				Return True
			End If
			If _main Is Nothing AndAlso Not IsDeleted Then
				Throw New Utils.Exception("Masukkan data utama permintaan penawaran", -99, "", source)
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

	<Persistent("m06dmainorder")> Friend Class Tm_OrderPenjualan
		Inherits TransactionMain

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _vehicle As String  '_kontakperson As String
		Private _carrierCompany As String '_leadtime As String
		Private _shipmentUOM As String '_custom1 As String
		Private _shipmentCreatedFrom As String  '_custom2 As String
		Private _description As String '_uraian As String
		Private _driver As String '_custom3 As String
		Private _shipmentStatus As String '_custom4 As String
		Private _shipmentSequence As String '_custom5 As String
		Private _priorityShipment As Boolean '_fob As NuSoft005.Persistent.eTipeFOB
		Private _status As NuSoft001.Persistent.StatusTransaksiEnum
		Private _remarks As String '_catatan As String

		'Private _customer As NuSoft001.Persistent.Kontak
		'Private _kontakalamat As NuSoft001.Persistent.KontakAlamat
		'Private _tipe As NuSoft004.Persistent.TipeTransaksi
		'Private _tglberlaku As Date
		'Private _bagpembelian As NuSoft001.Persistent.Kontak
		'Private _via As NuSoft005.Persistent.Via
		'Private _termin As NuSoft005.Persistent.Termin
		'Private _uang As NuSoft001.Persistent.MataUang
		'Private _pajak As NuSoft005.Persistent.eTipePajak
		'Private _othercost As Double
		'Private _reffnumber As String
		'Private _nopenawaran As Persistent.Penawaran

		<Persistent("d_contact")> Property Vehicle As String
			Get
				Return _vehicle
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Vehicle", _vehicle, value)
			End Set
		End Property
		<Persistent("d_leadtime")> Property CarrierCompany As String
			Get
				Return _carrierCompany
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("CarrierCompany", _carrierCompany, value)
			End Set
		End Property
		<Persistent("d_fob")> Property PriorityShipment As Boolean
			Get
				Return _priorityShipment
			End Get
			Set(value As Boolean)
				SetPropertyValue(Of Boolean)("PriorityShipment", _priorityShipment, value)
			End Set
		End Property
		<Persistent("d_description")> Property Description As String
			Get
				Return _description
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Description", _description, value)
			End Set
		End Property
		<Persistent("d_remarks")> Property Remarks As String
			Get
				Return _remarks
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Remarks", _remarks, value)
			End Set
		End Property
		<Persistent("d_status")> Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
			Get
				Return _status
			End Get
			Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
				SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
			End Set
		End Property
		<Persistent("d_custom1")> Property ShipmentUOM As String
			Get
				Return _shipmentUOM
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("ShipmentUOM", _shipmentUOM, value)
			End Set
		End Property
		<Persistent("d_custom2")> Property ShipmentCreatedFrom As String
			Get
				Return _shipmentCreatedFrom
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("ShipmentCreatedFrom", _shipmentCreatedFrom, value)
			End Set
		End Property
		<Persistent("d_custom3")> Property Driver As String
			Get
				Return _driver
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Driver", _driver, value)
			End Set
		End Property
		<Persistent("d_custom4")> Property ShipmentStatus As String
			Get
				Return _shipmentStatus
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("ShipmentStatus", _shipmentStatus, value)
			End Set
		End Property
		<Persistent("d_custom5")> Property ShipmentSequence As String
			Get
				Return _shipmentSequence
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("ShipmentSequence", _shipmentSequence, value)
			End Set
		End Property

		'<Persistent("f_customer")>
		'Property Pelanggan As NuSoft001.Persistent.Kontak
		'	Get
		'		Return _customer
		'	End Get
		'	Set(value As NuSoft001.Persistent.Kontak)
		'		SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _customer, value)
		'	End Set
		'End Property
		'<Persistent("f_address")>
		'Property KontakAlamat As NuSoft001.Persistent.KontakAlamat
		'	Get
		'		Return _kontakalamat
		'	End Get
		'	Set(value As NuSoft001.Persistent.KontakAlamat)
		'		SetPropertyValue(Of NuSoft001.Persistent.KontakAlamat)("KontakAlamat", _kontakalamat, value)
		'	End Set
		'End Property
		'<Persistent("f_jenis")>
		'Property TipeTransaksi As NuSoft004.Persistent.TipeTransaksi
		'	Get
		'		Return _tipe
		'	End Get
		'	Set(value As NuSoft004.Persistent.TipeTransaksi)
		'		SetPropertyValue(Of NuSoft004.Persistent.TipeTransaksi)("TipeTransaksi", _tipe, value)
		'	End Set
		'End Property
		'<Persistent("d_efectivedate")>
		'Property TanggalBerlaku As Date
		'	Get
		'		Return _tglberlaku
		'	End Get
		'	Set(value As Date)
		'		SetPropertyValue(Of String)("TanggalBerlaku", _tglberlaku, value)
		'	End Set
		'End Property
		'<Persistent("f_employee")>
		'Property Karyawan As NuSoft001.Persistent.Kontak
		'	Get
		'		Return _bagpembelian
		'	End Get
		'	Set(value As NuSoft001.Persistent.Kontak)
		'		SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _bagpembelian, value)
		'	End Set
		'End Property
		'<Persistent("f_via")>
		'Property Via As NuSoft005.Persistent.Via
		'	Get
		'		Return _via
		'	End Get
		'	Set(value As NuSoft005.Persistent.Via)
		'		SetPropertyValue(Of NuSoft005.Persistent.Via)("Via", _via, value)
		'	End Set
		'End Property
		'<Persistent("f_termin")>
		'Property Termin As NuSoft005.Persistent.Termin
		'	Get
		'		Return _termin
		'	End Get
		'	Set(value As NuSoft005.Persistent.Termin)
		'		SetPropertyValue(Of NuSoft005.Persistent.Termin)("Termin", _termin, value)
		'	End Set
		'End Property
		'<Persistent("f_currency")>
		'Property Uang As NuSoft001.Persistent.MataUang
		'	Get
		'		Return _uang
		'	End Get
		'	Set(value As NuSoft001.Persistent.MataUang)
		'		SetPropertyValue(Of NuSoft001.Persistent.MataUang)("Uang", _uang, value)
		'	End Set
		'End Property
		'<Persistent("d_taxtype")>
		'Property TipePajak As NuSoft005.Persistent.eTipePajak
		'	Get
		'		Return _pajak
		'	End Get
		'	Set(value As NuSoft005.Persistent.eTipePajak)
		'		SetPropertyValue(Of NuSoft005.Persistent.eTipePajak)("Pajak", _pajak, value)
		'	End Set
		'End Property
		'<Persistent("d_reffnumber")>
		'Property ReffNumber As String
		'	Get
		'		Return _reffnumber
		'	End Get
		'	Set(value As String)
		'		SetPropertyValue(Of String)("ReffNumber", _reffnumber, value)
		'	End Set
		'End Property
		'<Persistent("d_othercost")>
		'Property BiayaLain As Double
		'	Get
		'		Return _othercost
		'	End Get
		'	Set(value As Double)
		'		SetPropertyValue(Of Double)("BiayaLain", _othercost, value)
		'	End Set
		'End Property
		'<Persistent("f_idquotation")>
		'Property NoPenawaran As Persistent.Penawaran
		'	Get
		'		Return _nopenawaran
		'	End Get
		'	Set(value As Persistent.Penawaran)
		'		SetPropertyValue(Of Persistent.Penawaran)("NoPenawaran", _nopenawaran, value)
		'	End Set
		'End Property

		<PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("TotalQty"))
			End Get
		End Property
		'<PersistentAlias("Detail.Sum(DPP)")> ReadOnly Property SubTotal As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("SubTotal"))
		'	End Get
		'End Property
		'<PersistentAlias("Detail.Sum(PPNv)")> ReadOnly Property PPN As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("PPN"))
		'	End Get
		'End Property
		'<PersistentAlias("Detail.Sum(PPHv)")> ReadOnly Property PPH As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("PPH"))
		'	End Get
		'End Property
		'<PersistentAlias("(SubTotal + PPN - PPH)")> ReadOnly Property Total As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("Total"))
		'	End Get
		'End Property
		'<PersistentAlias("Terbilang(Total)")> ReadOnly Property Terbilang As String
		'	Get
		'		Return Convert.ToString(EvaluateAlias("Terbilang"))
		'	End Get
		'End Property
		'<PersistentAlias("TerbilangEnglish(Total)")> ReadOnly Property TerbilangEnglish As String
		'	Get
		'		Return Convert.ToString(EvaluateAlias("TerbilangEnglish"))
		'	End Get
		'End Property
		'<PersistentAlias("Terbilang(Total,Uang.Nama)")> ReadOnly Property TerbilangMataUang As String
		'	Get
		'		Return Convert.ToString(EvaluateAlias("TerbilangMataUang"))
		'	End Get
		'End Property

		<Association("fk_tm_order_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Tm_OrderPenjualanDetail)
			Get
				Return GetCollection(Of Tm_OrderPenjualanDetail)("Detail")
			End Get
		End Property

		Private Function CheckData() As Boolean
			Dim source As String = "Shipment by Product"
			If Regional Is Nothing Then
				Throw New Utils.Exception("Masukkan regional", -1, "", source)
				Return False
			End If
			If Tanggal = Nothing Then
				Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
				Return False
			End If
			'If Pelanggan Is Nothing Then
			'	Throw New Utils.Exception("Masukkan Vendor", -4, "", source)
			'	Return False
			'End If
			'If Uang Is Nothing Then
			'	Throw New Utils.Exception("Masukkan mata uang", -6, "", source)
			'End If
			If Session.IsNewObject(Me) Then
				If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
					Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -7, "", source)
					Return False
				End If
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
	<Persistent("m06edetailorder")> Friend Class Tm_OrderPenjualanDetail
		Inherits NPOBase

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _id As Int64
		Private _main As Tm_OrderPenjualan
		Private _idpenawaran As Tm_PenawaranDetail
		Private _qty As Double
		Private _destination As String '_catatan As String
		'Private _item As NuSoft004.Persistent.Barang
		'Private _satuan As NuSoft004.Persistent.Satuan
		'Private _harga As Double
		'Private _ppn As NuSoft004.Persistent.Pajak
		'Private _ppnp As Double
		'Private _pph As NuSoft004.Persistent.Pajak
		'Private _pphp As Double
		'Private _disc As Double
		'Private _discp As Double
		'Private _readystock As Double
		'Private _divisi As NPO.Modules.ModSys.Divisi
		'Private _proyek As NuSoft001.Persistent.Proyek

		<Persistent("primary_main"), Key(True)> Property Id As Int64
			Get
				Return _id
			End Get
			Set(value As Int64)
				SetPropertyValue(Of Int64)("Id", _id, value)
			End Set
		End Property
		<Persistent("p_id"), Association("fk_tm_order_detail")> Property Main As Tm_OrderPenjualan
			Get
				Return _main
			End Get
			Set(value As Tm_OrderPenjualan)
				SetPropertyValue(Of Tm_OrderPenjualan)("Main", _main, value)
			End Set
		End Property
		<Persistent("f_idquotation"), Association("fk_tm_penawaran_detail_order")> Property PenawaranDetail As Tm_PenawaranDetail
			Get
				Return _idpenawaran
			End Get
			Set(value As Tm_PenawaranDetail)
				SetPropertyValue(Of Tm_PenawaranDetail)("PenawaranDetail", _idpenawaran, value)
			End Set
		End Property
		<Persistent("d_qty")> Property Qty As Double
			Get
				Return _qty
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("Qty", _qty, value)
			End Set
		End Property
		<Persistent("d_remarks")> Property Destination As String
			Get
				Return _destination
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Destination", _destination, value)
			End Set
		End Property

		'<Persistent("f_item")> Property Barang As NuSoft004.Persistent.Barang
		'	Get
		'		Return _item
		'	End Get
		'	Set(value As NuSoft004.Persistent.Barang)
		'		SetPropertyValue(Of NuSoft004.Persistent.Barang)("Barang", _item, value)
		'	End Set
		'End Property
		'<Persistent("f_uom")>
		'Property Satuan As NuSoft004.Persistent.Satuan
		'	Get
		'		Return _satuan
		'	End Get
		'	Set(value As NuSoft004.Persistent.Satuan)
		'		SetPropertyValue(Of NuSoft004.Persistent.Satuan)("Satuan", _satuan, value)
		'	End Set
		'End Property
		'<Persistent("d_price")>
		'Property Harga As Double
		'	Get
		'		Return _harga
		'	End Get
		'	Set(value As Double)
		'		SetPropertyValue(Of Double)("Harga", _harga, value)
		'	End Set
		'End Property
		'<Persistent("d_disc")>
		'Property Discount As Double
		'	Get
		'		Return _disc
		'	End Get
		'	Set(value As Double)
		'		SetPropertyValue(Of Double)("Discount", _disc, value)
		'	End Set
		'End Property
		'<Persistent("d_discp")>
		'Property DiscountPersen As Double
		'	Get
		'		Return _discp
		'	End Get
		'	Set(value As Double)
		'		SetPropertyValue(Of Double)("DiscountPersen", _discp, value)
		'	End Set
		'End Property
		'<Persistent("f_taxin")>
		'Property PPN As NuSoft004.Persistent.Pajak
		'	Get
		'		Return _ppn
		'	End Get
		'	Set(value As NuSoft004.Persistent.Pajak)
		'		SetPropertyValue(Of NuSoft004.Persistent.Pajak)("PPN", _ppn, value)
		'	End Set
		'End Property
		'<Persistent("d_taxinp")>
		'Property PPNp As Double
		'	Get
		'		Return _ppnp
		'	End Get
		'	Set(value As Double)
		'		SetPropertyValue(Of Double)("PPNp", _ppnp, value)
		'	End Set
		'End Property
		'<Persistent("f_taxout")>
		'Property PPH As NuSoft004.Persistent.Pajak
		'	Get
		'		Return _pph
		'	End Get
		'	Set(value As NuSoft004.Persistent.Pajak)
		'		SetPropertyValue(Of NuSoft004.Persistent.Pajak)("PPN", _pph, value)
		'	End Set
		'End Property
		'<Persistent("d_taxoutp")>
		'Property PPHp As Double
		'	Get
		'		Return _pphp
		'	End Get
		'	Set(value As Double)
		'		SetPropertyValue(Of Double)("PPHp", _pphp, value)
		'	End Set
		'End Property
		'<Persistent("f_division")>
		'Property Divisi As NPO.Modules.ModSys.Divisi
		'	Get
		'		Return _divisi
		'	End Get
		'	Set(value As NPO.Modules.ModSys.Divisi)
		'		SetPropertyValue(Of NPO.Modules.ModSys.Divisi)("Divisi", _divisi, value)
		'	End Set
		'End Property
		'<Persistent("f_project")>
		'Property Proyek As NuSoft001.Persistent.Proyek
		'	Get
		'		Return _proyek
		'	End Get
		'	Set(value As NuSoft001.Persistent.Proyek)
		'		SetPropertyValue(Of NuSoft001.Persistent.Proyek)("Proyek", _proyek, value)
		'	End Set
		'End Property
		'<PersistentAlias("iif(Main.TipePajak = 0,0,PPNp / 100 * DPP)")> ReadOnly Property PPNv As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("PPNv"))
		'	End Get
		'End Property
		'<PersistentAlias("iif(Main.TipePajak = 0,0,PPHp / 100 * DPP)")> ReadOnly Property PPHv As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("PPHv"))
		'	End Get
		'End Property
		'<PersistentAlias("(Qty*Harga) - Discount")> ReadOnly Property SubTotal As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("SubTotal"))
		'	End Get
		'End Property
		'<PersistentAlias("iif(Main.TipePajak = 1,((SubTotal) + PPNv - PPHv), SubTotal)")> ReadOnly Property Total As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("Total"))
		'	End Get
		'End Property
		'<PersistentAlias("iif(Main.TipePajak = 2,(SubTotal) - ((PPNp - PPHp) / (100 + (PPNp - PPHp)) * (SubTotal)),SubTotal)")> ReadOnly Property DPP As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("DPP"))
		'	End Get
		'End Property
		'<Persistent("f_idquotation")>

		Private Function CheckData() As Boolean
			Dim source As String = "Shipment by Product"
			If IsDeleted Then
				Return True
			End If
			If _main Is Nothing AndAlso Not IsDeleted Then
				Throw New Utils.Exception("Masukkan data utama order penjualan", -99, "", source)
				Return False
			End If
			If _idpenawaran Is Nothing Then
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