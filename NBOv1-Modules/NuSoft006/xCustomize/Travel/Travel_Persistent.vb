Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NPO.Modules.ModSys
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Travel.Persistent

Namespace Travel.Persistent
	<Persistent("m06dmainorder")> Friend Class Travel_Order
		Inherits TransactionMain

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _customer As NuSoft001.Persistent.Kontak
		Private _kontakperson As String
		Private _kontakalamat As NuSoft001.Persistent.KontakAlamat
		Private _tglberlaku As Date
		Private _bagpenjualan As NuSoft001.Persistent.Kontak
		Private _termin As NuSoft005.Persistent.Termin
		Private _uang As NuSoft001.Persistent.MataUang
		Private _uraian As String
		Private _catatan As String
		Private _status As NuSoft001.Persistent.StatusTransaksiEnum
		Private _othercost As Double
		Private _reffnumber As String
		Private _custom1 As String
		Private _custom2 As String
		Private _custom3 As String
		Private _custom4 As String
		Private _custom5 As String

		<Persistent("f_customer")> Property Pelanggan As NuSoft001.Persistent.Kontak
			Get
				Return _customer
			End Get
			Set(value As NuSoft001.Persistent.Kontak)
				SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _customer, value)
			End Set
		End Property
		<Persistent("d_contact")> Property KontakPerson As String
			Get
				Return _kontakperson
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("KontakPerson", _kontakperson, value)
			End Set
		End Property
		<Persistent("f_address")> Property KontakAlamat As NuSoft001.Persistent.KontakAlamat
			Get
				Return _kontakalamat
			End Get
			Set(value As NuSoft001.Persistent.KontakAlamat)
				SetPropertyValue(Of NuSoft001.Persistent.KontakAlamat)("KontakAlamat", _kontakalamat, value)
			End Set
		End Property
		<Persistent("d_efectivedate")> Property TanggalBerlaku As Date
			Get
				Return _tglberlaku
			End Get
			Set(value As Date)
				SetPropertyValue(Of String)("TanggalBerlaku", _tglberlaku, value)
			End Set
		End Property
		<Persistent("f_employee")> Property BagPenjualan As NuSoft001.Persistent.Kontak
			Get
				Return _bagpenjualan
			End Get
			Set(value As NuSoft001.Persistent.Kontak)
				SetPropertyValue(Of NuSoft001.Persistent.Kontak)("BagPenjualan", _bagpenjualan, value)
			End Set
		End Property
		<Persistent("f_termin")> Property Termin As NuSoft005.Persistent.Termin
			Get
				Return _termin
			End Get
			Set(value As NuSoft005.Persistent.Termin)
				SetPropertyValue(Of NuSoft005.Persistent.Termin)("Termin", _termin, value)
			End Set
		End Property
		<Persistent("f_currency")> Property Uang As NuSoft001.Persistent.MataUang
			Get
				Return _uang
			End Get
			Set(value As NuSoft001.Persistent.MataUang)
				SetPropertyValue(Of NuSoft001.Persistent.MataUang)("Uang", _uang, value)
			End Set
		End Property
		<Persistent("d_description")> Property Uraian As String
			Get
				Return _uraian
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Uraian", _uraian, value)
			End Set
		End Property
		<Persistent("d_remarks")> Property Catatan As String
			Get
				Return _catatan
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Catatan", _catatan, value)
			End Set
		End Property

		<Persistent("d_reffnumber")> Property ReffNumber As String
			Get
				Return _reffnumber
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("ReffNumber", _reffnumber, value)
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
		<Persistent("d_othercost")> Property BiayaLain As Double
			Get
				Return _othercost
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("BiayaLain", _othercost, value)
			End Set
		End Property

		<Persistent("d_custom1")> Property Custom1 As String
			Get
				Return _custom1
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Custom1", _custom1, value)
			End Set
		End Property
		<Persistent("d_custom2")> Property Custom2 As String
			Get
				Return _custom2
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Custom2", _custom2, value)
			End Set
		End Property
		<Persistent("d_custom3")> Property Custom3 As String
			Get
				Return _custom3
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Custom3", _custom3, value)
			End Set
		End Property
		<Persistent("d_custom4")> Property Custom4 As String
			Get
				Return _custom4
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Custom4", _custom4, value)
			End Set
		End Property
		<Persistent("d_custom5")> Property Custom5 As String
			Get
				Return _custom5
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Custom5", _custom5, value)
			End Set
		End Property

		<PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("TotalQty"))
			End Get
		End Property
		<PersistentAlias("Detail.Sum(SubTotal)")> ReadOnly Property SubTotal As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("SubTotal"))
			End Get
		End Property
		<PersistentAlias("SubTotal")> ReadOnly Property Total As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("Total"))
			End Get
		End Property
		<PersistentAlias("Terbilang(Total)")> ReadOnly Property Terbilang As String
			Get
				Return Convert.ToString(EvaluateAlias("Terbilang"))
			End Get
		End Property
		<PersistentAlias("TerbilangEnglish(Total)")> ReadOnly Property TerbilangEnglish As String
			Get
				Return Convert.ToString(EvaluateAlias("TerbilangEnglish"))
			End Get
		End Property
		<PersistentAlias("Terbilang(Total,Uang.Nama)")> ReadOnly Property TerbilangMataUang As String
			Get
				Return Convert.ToString(EvaluateAlias("TerbilangMataUang"))
			End Get
		End Property

		'Posting
		'DP
		'Invoice
		'Outstanding
		'Lunas
		'Refund
		<PersistentAlias("Iif(DaftarInvoice.Count > 0,Iif(DaftarInvoice.Sum(TotalRefund) > 0,'Refund',Iif(DaftarInvoice.Sum(TotalPembayaran) <= 0,'Invoice',Iif(DaftarInvoice.Sum(TotalPembayaran) < DaftarInvoice.Sum(Total),'Outstanding','Lunas'))),Iif(DaftarDownPayment.Count > 0,'DP','Posting'))")> ReadOnly Property AutoStatus As String
			Get
				Return Convert.ToString(EvaluateAlias("AutoStatus"))
			End Get
		End Property

		<Association("fk_Travel_Order_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Travel_OrderDetail)
			Get
				Return GetCollection(Of Travel_OrderDetail)("Detail")
			End Get
		End Property
		<Association("fk_Travel_Order_DownPayment")> ReadOnly Property DaftarDownPayment As XPCollection(Of Travel_DownPayment)
			Get
				Return GetCollection(Of Travel_DownPayment)("DaftarDownPayment")
			End Get
		End Property
		<Association("fk_Travel_Order_Invoice")> ReadOnly Property DaftarInvoice As XPCollection(Of Travel_Invoice)
			Get
				Return GetCollection(Of Travel_Invoice)("DaftarInvoice")
			End Get
		End Property
	End Class
	<Persistent("m06edetailorder")> Friend Class Travel_OrderDetail
		Inherits NPOBase

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _id As Int64
		Private _main As Travel_Order
		Private _item As NuSoft004.Persistent.Barang
		Private _qty As Double
		Private _satuan As NuSoft004.Persistent.Satuan
		Private _harga As Double
		Private _disc As Double
		Private _discp As Double
		Private _divisi As NPO.Modules.ModSys.Divisi
		Private _proyek As NuSoft001.Persistent.Proyek
		Private _catatan As String

		<Persistent("primary_main"), Key(True)> Property Id As Int64
			Get
				Return _id
			End Get
			Set(value As Int64)
				SetPropertyValue(Of Int64)("Id", _id, value)
			End Set
		End Property
		<Persistent("p_id"), Association("fk_Travel_Order_detail")> Property Main As Travel_Order
			Get
				Return _main
			End Get
			Set(value As Travel_Order)
				SetPropertyValue(Of Travel_Order)("Main", _main, value)
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
		<Persistent("d_price")> Property Harga As Double
			Get
				Return _harga
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("Harga", _harga, value)
			End Set
		End Property
		<Persistent("d_disc")> Property Discount As Double
			Get
				Return _disc
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("Discount", _disc, value)
			End Set
		End Property
		<Persistent("d_discp")> Property DiscountPersen As Double
			Get
				Return _discp
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("DiscountPersen", _discp, value)
			End Set
		End Property
		<Persistent("d_remarks")> Property Catatan As String
			Get
				Return _catatan
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Catatan", _catatan, value)
			End Set
		End Property
		<Persistent("f_division")> Property Divisi As NPO.Modules.ModSys.Divisi
			Get
				Return _divisi
			End Get
			Set(value As NPO.Modules.ModSys.Divisi)
				SetPropertyValue(Of NPO.Modules.ModSys.Divisi)("Divisi", _divisi, value)
			End Set
		End Property
		<Persistent("f_project")> Property Proyek As NuSoft001.Persistent.Proyek
			Get
				Return _proyek
			End Get
			Set(value As NuSoft001.Persistent.Proyek)
				SetPropertyValue(Of NuSoft001.Persistent.Proyek)("Proyek", _proyek, value)
			End Set
		End Property

		<PersistentAlias("(Qty*Harga) - Discount")> ReadOnly Property SubTotal As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("SubTotal"))
			End Get
		End Property
		<PersistentAlias("SubTotal")> ReadOnly Property Total As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("Total"))
			End Get
		End Property
	End Class

	<Persistent("m06edownpayment")> Friend Class Travel_DownPayment
		Inherits NPOBase

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _id As Int64
		Private _regional As Regional
		Private _kode As String
		Private _pelanggan As NuSoft001.Persistent.Kontak
		Private _travelorder As Travel_Order
		Private _tanggal As Date
		Private _akunKasBank As NuSoft001.Persistent.Coa
		Private _uang As NuSoft001.Persistent.MataUang
		Private _kurs As Double
		Private _nominal As Double
		Private _uraian As String
		Private _gl As GlMain

		<Key(True)> Property Id As Int64
			Get
				Return _id
			End Get
			Set(value As Int64)
				SetPropertyValue(Of Int64)("Id", _id, value)
			End Set
		End Property
		Property Regional As Regional
			Get
				Return _regional
			End Get
			Set(value As Regional)
				SetPropertyValue(Of Regional)("Regional", _regional, value)
			End Set
		End Property
		Property Kode As String
			Get
				Return _kode
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Kode", _kode, value)
			End Set
		End Property
		Property Pelanggan As NuSoft001.Persistent.Kontak
			Get
				Return _pelanggan
			End Get
			Set(value As NuSoft001.Persistent.Kontak)
				SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _pelanggan, value)
			End Set
		End Property
		<Association("fk_Travel_Order_DownPayment")> Property TravelOrder As Travel_Order
			Get
				Return _travelorder
			End Get
			Set(value As Travel_Order)
				SetPropertyValue(Of Travel_Order)("TravelOrder", _travelorder, value)
			End Set
		End Property
		Property Tanggal As Date
			Get
				Return _tanggal
			End Get
			Set(value As Date)
				SetPropertyValue(Of Date)("Tanggal", _tanggal, value)
			End Set
		End Property
		Property AkunKasBank As NuSoft001.Persistent.Coa
			Get
				Return _akunKasBank
			End Get
			Set(value As NuSoft001.Persistent.Coa)
				SetPropertyValue(Of NuSoft001.Persistent.Coa)("AkunKasBank", _akunKasBank, value)
			End Set
		End Property
		Property Uang As NuSoft001.Persistent.MataUang
			Get
				Return _uang
			End Get
			Set(value As NuSoft001.Persistent.MataUang)
				SetPropertyValue(Of NuSoft001.Persistent.MataUang)("Uang", _uang, value)
			End Set
		End Property
		Property Kurs As Double
			Get
				Return _kurs
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("Kurs", _kurs, value)
			End Set
		End Property
		Property Nominal As Double
			Get
				Return _nominal
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("Nominal", _nominal, value)
			End Set
		End Property
		Property Uraian As String
			Get
				Return _uraian
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Uraian", _uraian, value)
			End Set
		End Property

		Property Gl As GlMain
			Get
				Return _gl
			End Get
			Set(value As GlMain)
				SetPropertyValue(Of GlMain)("Gl", _gl, value)
			End Set
		End Property

		<PersistentAlias("GetYear(Tanggal)")> Public ReadOnly Property Tahun As Integer
			Get
				Return Convert.ToInt32(EvaluateAlias("Tahun"))
			End Get
		End Property
		<PersistentAlias("concat(GetYear(Tanggal),'-',GetMonth(Tanggal),'-01')")> Public ReadOnly Property Bulan As Date
			Get
				Return Convert.ToDateTime(EvaluateAlias("Bulan"))
			End Get
		End Property
		<PersistentAlias("Nominal * Kurs")> Public ReadOnly Property NominalKurs As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("NominalKurs"))
			End Get
		End Property

		'Posting
		'Invoice
		<PersistentAlias("Iif(TravelOrder.DaftarInvoice.Count > 0,'Invoice','Posting')")> ReadOnly Property AutoStatus As String
			Get
				Return Convert.ToString(EvaluateAlias("AutoStatus"))
			End Get
		End Property

		'<Association("fk_Travel_DP_Invoice")> ReadOnly Property DaftarInvoice As XPCollection(Of Travel_InvoiceDownPayment)
		'	Get
		'		Return GetCollection(Of Travel_InvoiceDownPayment)("DaftarInvoice")
		'	End Get
		'End Property
	End Class

	<Persistent("m06emaininvoice")> Friend Class Travel_Invoice
		Inherits TransactionMain

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _pelanggan As NuSoft001.Persistent.Kontak
		Private _alamat As NuSoft001.Persistent.KontakAlamat
		Private _kontakperson As String
		Private _jatuhTempo As Date
		Private _termin As NuSoft005.Persistent.Termin
		Private _uang As NuSoft001.Persistent.MataUang
		Private _kurs As Double
		Private _tipeinvoice As eTipeInvoicePenjualan
		Private _travelOrder As Travel_Order
		Private _uraian As String
		Private _catatan As String
		Private _bagPenjualan As NuSoft001.Persistent.Kontak
		'Private _disc As Double
		'Private _othercost As Double
		Private _nominalDP As Double
		Private _status As NuSoft001.Persistent.StatusTransaksiEnum
		Private _gl As GlMain

		<Persistent("f_customer")> Property Pelanggan As NuSoft001.Persistent.Kontak
			Get
				Return _pelanggan
			End Get
			Set(value As NuSoft001.Persistent.Kontak)
				SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _pelanggan, value)
			End Set
		End Property
		<Persistent("f_address")> Property KontakAlamat As NuSoft001.Persistent.KontakAlamat
			Get
				Return _alamat
			End Get
			Set(value As NuSoft001.Persistent.KontakAlamat)
				SetPropertyValue(Of NuSoft001.Persistent.KontakAlamat)("KontakAlamat", _alamat, value)
			End Set
		End Property
		<Persistent("d_contact")> Property KontakPerson As String
			Get
				Return _kontakperson
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("KontakPerson", _kontakperson, value)
			End Set
		End Property
		<Persistent("d_duedate")> Property JatuhTempo As Date
			Get
				Return _jatuhTempo
			End Get
			Set(value As Date)
				SetPropertyValue(Of Date)("JatuhTempo", _jatuhTempo, value)
			End Set
		End Property
		<Persistent("f_termin")> Property Termin As NuSoft005.Persistent.Termin
			Get
				Return _termin
			End Get
			Set(value As NuSoft005.Persistent.Termin)
				SetPropertyValue(Of NuSoft005.Persistent.Termin)("Termin", _termin, value)
			End Set
		End Property
		<Persistent("f_currency")> Property Uang As NuSoft001.Persistent.MataUang
			Get
				Return _uang
			End Get
			Set(value As NuSoft001.Persistent.MataUang)
				SetPropertyValue(Of NuSoft001.Persistent.MataUang)("Uang", _uang, value)
			End Set
		End Property
		<Persistent("d_kurs")> Property Kurs As Double
			Get
				Return _kurs
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("Kurs", _kurs, value)
			End Set
		End Property
		<Persistent("d_tipeinvoice")> Property TipeInvoice As eTipeInvoicePenjualan
			Get
				Return _tipeinvoice
			End Get
			Set(value As eTipeInvoicePenjualan)
				SetPropertyValue(Of eTipeInvoicePenjualan)("TipeInvoice", _tipeinvoice, value)
			End Set
		End Property
		<Persistent("f_idorder"), Association("fk_Travel_Order_Invoice")> Property TravelOrder As Travel_Order
			Get
				Return _travelOrder
			End Get
			Set(value As Travel_Order)
				SetPropertyValue(Of Travel_Order)("TravelOrder", _travelOrder, value)
			End Set
		End Property
		<Persistent("d_note")> Property Uraian As String
			Get
				Return _uraian
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Uraian", _uraian, value)
			End Set
		End Property
		<Persistent("d_remarks")> Property Catatan As String
			Get
				Return _catatan
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Catatan", _catatan, value)
			End Set
		End Property
		<Persistent("f_employee")> Property BagPenjualan As NuSoft001.Persistent.Kontak
			Get
				Return _bagPenjualan
			End Get
			Set(value As NuSoft001.Persistent.Kontak)
				SetPropertyValue(Of NuSoft001.Persistent.Kontak)("BagPenjualan", _bagPenjualan, value)
			End Set
		End Property
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
		<Persistent("d_dpnominal")> Property NominalDP As Double
			Get
				Return _nominalDP
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("NominalDP", _nominalDP, value)
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
		<Persistent("f_gl")> Property Gl As GlMain
			Get
				Return _gl
			End Get
			Set(value As GlMain)
				SetPropertyValue(Of GlMain)("Gl", _gl, value)
			End Set
		End Property

		<PersistentAlias("Detail.Sum(FOC)")> ReadOnly Property FOC As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("FOC"))
			End Get
		End Property
		<PersistentAlias("Detail.Sum(SubTotal)")> ReadOnly Property SubTotal As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("SubTotal"))
			End Get
		End Property
		<PersistentAlias("Detail.Sum(Discount)")> ReadOnly Property TotalDiscount As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("TotalDiscount"))
			End Get
		End Property
		'<PersistentAlias("DetailDP.Sum(Nominal)")> ReadOnly Property NilaiDP As Double
		'	Get
		'		Return Convert.ToDouble(EvaluateAlias("NilaiDP"))
		'	End Get
		'End Property
		<PersistentAlias("(SubTotal - NominalDP)")> ReadOnly Property Total As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("Total"))
			End Get
		End Property
		<PersistentAlias("SubTotal * Kurs")> ReadOnly Property SubTotalKurs As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("SubTotalKurs"))
			End Get
		End Property
		<PersistentAlias("Total * Kurs")> ReadOnly Property TotalKurs As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("TotalKurs"))
			End Get
		End Property

		<PersistentAlias("Terbilang(Total)")> ReadOnly Property Terbilang As String
			Get
				Return Convert.ToString(EvaluateAlias("Terbilang"))
			End Get
		End Property
		<PersistentAlias("Terbilang(Total,Uang.Nama)")> ReadOnly Property TerbilangMataUang As String
			Get
				Return Convert.ToString(EvaluateAlias("TerbilangMataUang"))
			End Get
		End Property

		<PersistentAlias("Pembayaran.Sum(NilaiBayar)")> ReadOnly Property TotalPembayaran As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("TotalPembayaran"))
			End Get
		End Property
		<PersistentAlias("Pembayaran.Sum(NilaiBayarRetur)")> ReadOnly Property TotalRefund As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("TotalRefund"))
			End Get
		End Property

		<PersistentAlias("Total - IsNull(TotalPembayaran,0)")> ReadOnly Property SisaPiutang As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("SisaPiutang"))
			End Get
		End Property
		<PersistentAlias("IsNull(TotalPembayaran,0) - IsNull(TotalRefund,0)")> ReadOnly Property SisaRefund As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("SisaRefund"))
			End Get
		End Property

		'Posting
		'Outstanding
		'Lunas
		'Refund
		<PersistentAlias("Iif(TotalRefund > 0,'Refund',Iif(TotalPembayaran <= 0,'Posting',Iif(TotalPembayaran < Total,'Outstanding','Lunas')))")> ReadOnly Property AutoStatus As String
			Get
				Return Convert.ToString(EvaluateAlias("AutoStatus"))
			End Get
		End Property

		<Association("fk_travelinvoice_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Travel_InvoiceDetail)
			Get
				Return GetCollection(Of Travel_InvoiceDetail)("Detail")
			End Get
		End Property
		'<Association("fk_travelinvoice_downpayment"), Aggregated> ReadOnly Property DetailDP As XPCollection(Of Travel_InvoiceDownPayment)
		'	Get
		'		Return GetCollection(Of Travel_InvoiceDownPayment)("DetailDP")
		'	End Get
		'End Property
		<Association("fk_travel_pembayaran_invoice"), Aggregated> ReadOnly Property Pembayaran As XPCollection(Of Travel_PembayaranInvoiceDetail)
			Get
				Return GetCollection(Of Travel_PembayaranInvoiceDetail)("Pembayaran")
			End Get
		End Property
	End Class
	<Persistent("m06fdetailinvoice")> Friend Class Travel_InvoiceDetail
		Inherits NPOBase

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _id As Int64
		Private _main As Travel_Invoice
		Private _item As NuSoft004.Persistent.Barang
		Private _qty As Double
		Private _satuan As NuSoft004.Persistent.Satuan
		Private _harga As Double
		Private _disc As Double
		Private _discp As Double
		Private _FOC As Double
		Private _divisi As NPO.Modules.ModSys.Divisi
		Private _proyek As NuSoft001.Persistent.Proyek
		Private _catatan As String

		<Persistent("primary_main"), Key(True)> Property Id As Int64
			Get
				Return _id
			End Get
			Set(value As Int64)
				SetPropertyValue(Of Int64)("Id", _id, value)
			End Set
		End Property
		<Persistent("p_id"), Association("fk_travelinvoice_detail")>
		Property Main As Travel_Invoice
			Get
				Return _main
			End Get
			Set(value As Travel_Invoice)
				SetPropertyValue(Of Travel_Invoice)("Main", _main, value)
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
		<Persistent("d_price")> Property Harga As Double
			Get
				Return _harga
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("Harga", _harga, value)
			End Set
		End Property
		<Persistent("d_disc")> Property Discount As Double
			Get
				Return _disc
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("Discount", _disc, value)
			End Set
		End Property
		<Persistent("d_discp")> Property DiscountPersen As Double
			Get
				Return _discp
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("DiscountPersen", _discp, value)
			End Set
		End Property
		<Persistent("d_foc")> Property FOC As Double
			Get
				Return _FOC
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("FOC", _FOC, value)
			End Set
		End Property
		<Persistent("f_division")> Property Divisi As NPO.Modules.ModSys.Divisi
			Get
				Return _divisi
			End Get
			Set(value As NPO.Modules.ModSys.Divisi)
				SetPropertyValue(Of NPO.Modules.ModSys.Divisi)("Divisi", _divisi, value)
			End Set
		End Property
		<Persistent("f_project")> Property Proyek As NuSoft001.Persistent.Proyek
			Get
				Return _proyek
			End Get
			Set(value As NuSoft001.Persistent.Proyek)
				SetPropertyValue(Of NuSoft001.Persistent.Proyek)("Proyek", _proyek, value)
			End Set
		End Property
		<Persistent("d_remarks")> Property Catatan As String
			Get
				Return _catatan
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Catatan", _catatan, value)
			End Set
		End Property

		<PersistentAlias("(Qty * Harga) - Discount - FOC")> ReadOnly Property SubTotal As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("SubTotal"))
			End Get
		End Property
	End Class

	<Persistent("m06fmainpayment")> Friend Class Travel_PembayaranInvoice
		Inherits TransactionMain

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _customer As NuSoft001.Persistent.Kontak
		Private _uraian As String
		Private _pembayaranpajak As Boolean
		Private _coakasbank As NuSoft001.Persistent.Coa
		Private _kurs As Double
		Private _total As Double
		Private _totalvalas As Double
		Private _totaladminbank As Double
		Private _totaldiscount As Double
		Private _totalpembulatan As Double
		Private _totalpph As Double
		Private _nomorpph As String
		Private _tipepembayaran As BankCaraBayar
		Private _nomorpembayaran As String
		Private _nomorbank As String
		Private _tgltempo As Date
		Private _gl As GlMain
		Private _status As NuSoft001.Persistent.StatusTransaksiEnum

		<Persistent("f_customer")>
		Property Pelanggan As NuSoft001.Persistent.Kontak
			Get
				Return _customer
			End Get
			Set(value As NuSoft001.Persistent.Kontak)
				SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _customer, value)
			End Set
		End Property
		<Persistent("d_taxpayment")>
		Property PembayaranPajak As Boolean
			Get
				Return _pembayaranpajak
			End Get
			Set(value As Boolean)
				SetPropertyValue(Of Boolean)("PembayaranPajak", _pembayaranpajak, value)
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
		<Persistent("f_coa")>
		Property coakasbank As NuSoft001.Persistent.Coa
			Get
				Return _coakasbank
			End Get
			Set(value As NuSoft001.Persistent.Coa)
				SetPropertyValue(Of NuSoft001.Persistent.Coa)("coakasbank", _coakasbank, value)
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
		<Persistent("d_value")>
		Property Total As Double
			Get
				Return _total
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("Total", _total, value)
			End Set
		End Property
		<Persistent("d_valuevalas")>
		Property TotalValas As Double
			Get
				Return _totalvalas
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("TotalValas", _totalvalas, value)
			End Set
		End Property
		<Persistent("d_bankadmin")>
		Property TotalAdminBank As Double
			Get
				Return _totaladminbank
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("TotalAdminBank", _totaladminbank, value)
			End Set
		End Property
		<Persistent("d_discount")>
		Property TotalDiscount As Double
			Get
				Return _totaldiscount
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("TotalDiscount", _totaldiscount, value)
			End Set
		End Property
		<Persistent("d_rounding")>
		Property TotalPembulatan As Double
			Get
				Return _totalpembulatan
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("TotalPembulatan", _totalpembulatan, value)
			End Set
		End Property
		<Persistent("d_pphvalue")>
		Property TotalPPH As Double
			Get
				Return _totalpph
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("TotalPPH", _totalpph, value)
			End Set
		End Property
		<Persistent("d_pphnumber")>
		Property NomorPPH As String
			Get
				Return _nomorpph
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("NomorPPH", _nomorpph, value)
			End Set
		End Property
		<Persistent("d_typepayment")>
		Property BankCaraBayar As BankCaraBayar
			Get
				Return _tipepembayaran
			End Get
			Set(value As BankCaraBayar)
				SetPropertyValue(Of BankCaraBayar)("BankCaraBayar", _tipepembayaran, value)
			End Set
		End Property
		<Persistent("d_numberpayment")>
		Property BankNoPembayaran As String
			Get
				Return _nomorpembayaran
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("BankNoPembayaran", _nomorpembayaran, value)
			End Set
		End Property
		<Persistent("d_bankaccountnumber")>
		Property BankAccount As String
			Get
				Return _nomorbank
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("BankAccount", _nomorbank, value)
			End Set
		End Property
		<Persistent("d_tempo")>
		Property Tempo As Date
			Get
				Return _tgltempo
			End Get
			Set(value As Date)
				SetPropertyValue(Of Date)("Tempo", _tgltempo, value)
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
		<Persistent("f_gl")> Property Gl As GlMain
			Get
				Return _gl
			End Get
			Set(value As GlMain)
				SetPropertyValue(Of GlMain)("Gl", _gl, value)
			End Set
		End Property

		<Association("fk_travel_pembayaran_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Travel_PembayaranInvoiceDetail)
			Get
				Return GetCollection(Of Travel_PembayaranInvoiceDetail)("Detail")
			End Get
		End Property
	End Class
	<Persistent("m06gdetailpayment")> Friend Class Travel_PembayaranInvoiceDetail
		Inherits NPOBase

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _id As Int64
		Private _main As Travel_PembayaranInvoice
		Private _idinvoice As Travel_Invoice
		Private _urutan As Byte
		Private _amount As Double
		Private _kurs As Double
		Private _amountcash As Double
		Private _amountreturn As Double
		Private _catatan As String

		<Persistent("primary_main"), Key(True)> Property Id As Int64
			Get
				Return _id
			End Get
			Set(value As Int64)
				SetPropertyValue(Of Int64)("Id", _id, value)
			End Set
		End Property
		<Persistent("p_id"), Association("fk_travel_pembayaran_detail")> Property Main As Travel_PembayaranInvoice
			Get
				Return _main
			End Get
			Set(value As Travel_PembayaranInvoice)
				SetPropertyValue(Of Travel_PembayaranInvoice)("Main", _main, value)
			End Set
		End Property
		<Persistent("p_idinvoice"), Association("fk_travel_pembayaran_invoice")> Property NoInvoice As Travel_Invoice
			Get
				Return _idinvoice
			End Get
			Set(value As Travel_Invoice)
				SetPropertyValue(Of Travel_Invoice)("NoInvoice", _idinvoice, value)
			End Set
		End Property
		<Persistent("d_urutan")> Property Urutan As Byte
			Get
				Return _urutan
			End Get
			Set(value As Byte)
				SetPropertyValue(Of Byte)("Urutan", _urutan, value)
			End Set
		End Property
		<Persistent("d_amount")> Property NilaiBayar As Double
			Get
				Return _amount
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("NilaiBayar", _amount, value)
			End Set
		End Property
		<Persistent("d_kurspayment")> Property Kurs As Double
			Get
				Return _kurs
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("Kurs", _kurs, value)
			End Set
		End Property
		<Persistent("d_amountcash")> Property NilaiBayarCash As Double
			Get
				Return _amountcash
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("NilaiBayarCash", _amountcash, value)
			End Set
		End Property
		<Persistent("d_amountreturn")> Property NilaiBayarRetur As Double
			Get
				Return _amountreturn
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("NilaiBayarRetur", _amountreturn, value)
			End Set
		End Property
		<Persistent("d_remarks")> Property Catatan As String
			Get
				Return _catatan
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Catatan", _catatan, value)
			End Set
		End Property
		<PersistentAlias("NilaiBayar * Kurs")> ReadOnly Property NilaiBayarKurs As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("NilaiBayarKurs"))
			End Get
		End Property
		<PersistentAlias("NilaiBayarCash * Kurs")> ReadOnly Property NilaiBayarCashKurs As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("NilaiBayarCashKurs"))
			End Get
		End Property
		<PersistentAlias("NilaiBayarRetur * Kurs")> ReadOnly Property NilaiBayarReturKurs As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("NilaiBayarReturKurs"))
			End Get
		End Property
		<PersistentAlias("NoInvoice.AutoStatus")> ReadOnly Property InvoiceStatus As String
			Get
				Return Convert.ToString(EvaluateAlias("InvoiceStatus"))
			End Get
		End Property
	End Class
End Namespace

Namespace Travel.NonPersistent
	Friend Class Travel_DaftarPembayaran
		Property Invoice As Travel_Invoice
		Property Terbayar As Double
		ReadOnly Property SisaPiutang As Double
			Get
				Return Invoice.Total - Terbayar
			End Get
		End Property
		ReadOnly Property SisaRefund As Double
			Get
				Return Invoice.TotalPembayaran - Terbayar
			End Get
		End Property

		Property KursBayar As Double
		Property JumlahBayarValas As Double
		Property JumlahBayar As Double
		Property Catatan As String
	End Class
End Namespace