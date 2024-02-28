Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute

Namespace Persistent
	' <Persistent("m04cstockmain")> Friend Class Fusoh_StockMain
	'   Inherits TransactionMain

	'   Public Sub New(ByVal session As UnitOfWork)
	'     MyBase.New(session)
	'   End Sub
	'   Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
	'     MyBase.New(session, classInfo)
	'   End Sub

	'   Private _vendor As NuSoft001.Persistent.Kontak
	'   Private _gudang As NuSoft004.Persistent.Gudang
	'   Private _uraian As String
	'   Private _status As NuSoft001.Persistent.StatusTransaksiEnum
	'   Private _kontakperson As String
	'   Private _bagpembelian As NuSoft001.Persistent.Kontak
	'   Private _divisi As NPO.Modules.ModSys.Divisi
	'   Private _gudang2 As NuSoft004.Persistent.Gudang
	'   'Private _idExim As Fusoh_Exim
	'   Private _uang As NuSoft001.Persistent.MataUang
	'   Private _kurs As Double
	'   Private _gl As GlMain

	'   <Persistent("f_contact")> Property Vendor As NuSoft001.Persistent.Kontak
	'     Get
	'       Return _vendor
	'     End Get
	'     Set(value As NuSoft001.Persistent.Kontak)
	'       SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Vendor", _vendor, value)
	'     End Set
	'   End Property
	'   <Persistent("f_warehouse")> Property Gudang As NuSoft004.Persistent.Gudang
	'     Get
	'       Return _gudang
	'     End Get
	'     Set(value As NuSoft004.Persistent.Gudang)
	'       SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang", _gudang, value)
	'     End Set
	'   End Property
	'   <Persistent("d_remarks")> Property Uraian As String
	'     Get
	'       Return _uraian
	'     End Get
	'     Set(value As String)
	'       SetPropertyValue(Of String)("Uraian", _uraian, value)
	'     End Set
	'   End Property
	'   <Persistent("d_status")> Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
	'     Get
	'       Return _status
	'     End Get
	'     Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
	'       SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
	'     End Set
	'   End Property
	'   <Persistent("d_person")> Property KontakPerson As String
	'     Get
	'       Return _kontakperson
	'     End Get
	'     Set(value As String)
	'       SetPropertyValue(Of String)("KontakPerson", _kontakperson, value)
	'     End Set
	'   End Property
	'   <Persistent("f_employee")> Property Karyawan As NuSoft001.Persistent.Kontak
	'     Get
	'       Return _bagpembelian
	'     End Get
	'     Set(value As NuSoft001.Persistent.Kontak)
	'       SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _bagpembelian, value)
	'     End Set
	'   End Property
	'   <Persistent("f_divisi")> Property Divisi As NPO.Modules.ModSys.Divisi
	'     Get
	'       Return _divisi
	'     End Get
	'     Set(value As NPO.Modules.ModSys.Divisi)
	'       SetPropertyValue(Of NPO.Modules.ModSys.Divisi)("Catatan", _divisi, value)
	'     End Set
	'   End Property
	'   <Persistent("f_warehouse2")> Property Gudang2 As NuSoft004.Persistent.Gudang
	'     Get
	'       Return _gudang2
	'     End Get
	'     Set(value As NuSoft004.Persistent.Gudang)
	'       SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang2", _gudang2, value)
	'     End Set
	'   End Property
	'   '<Persistent("f_ideximm")> Property Exim As Fusoh_Exim
	'   '  Get
	'   '    Return _idExim
	'   '  End Get
	'   '  Set(value As Fusoh_Exim)
	'   '    SetPropertyValue(Of Fusoh_Exim)("Exim", _idExim, value)
	'   '  End Set
	'   'End Property
	'   <Persistent("f_currency")> Property MataUang As NuSoft001.Persistent.MataUang
	'     Get
	'       Return _uang
	'     End Get
	'     Set(value As NuSoft001.Persistent.MataUang)
	'       SetPropertyValue(Of NuSoft001.Persistent.MataUang)("MataUang", _uang, value)
	'     End Set
	'   End Property
	'   <Persistent("d_kurs")> Property Kurs As Double
	'     Get
	'       Return _kurs
	'     End Get
	'     Set(value As Double)
	'       SetPropertyValue(Of Double)("Kurs", _kurs, value)
	'     End Set
	'   End Property
	'   <Persistent("f_gl")> Property Gl As GlMain
	'     Get
	'       Return _gl
	'     End Get
	'     Set(value As GlMain)
	'       SetPropertyValue(Of GlMain)("Gl", _gl, value)
	'     End Set
	'   End Property

	'   <Association("fk_fusoh_penerimaan_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_StockDetail)
	'     Get
	'       Return GetCollection(Of Fusoh_StockDetail)("Detail")
	'     End Get
	'   End Property
	'   <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
	'     Get
	'       Return Convert.ToDouble(EvaluateAlias("TotalQty"))
	'     End Get
	'   End Property

	'   Private Function CheckData() As Boolean
	'     Dim source As String = "Penerimaan Barang [GR]"
	'     If IsDeleted Then
	'       Return True
	'     End If
	'     If Regional Is Nothing Then
	'       Throw New Utils.Exception("Masukkan regional", -1, "", source)
	'       Return False
	'     End If
	'     If Tanggal = Nothing Then
	'       Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
	'       Return False
	'     End If
	'     If Vendor Is Nothing Then
	'       Throw New Utils.Exception("Masukkan Vendor", -4, "", source)
	'       Return False
	'     End If
	'     If Gudang Is Nothing Then
	'       Throw New Utils.Exception("Masukkan gudang", -5, "", source)
	'       Return False
	'     End If
	'     If Karyawan Is Nothing Then
	'       Throw New Utils.Exception("Masukkan karyawan penerima barang", -6, "", source)
	'       Return False
	'     End If
	'     If Session.IsNewObject(Me) Then
	'       If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
	'         Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -7, "", source)
	'         Return False
	'       End If
	'     End If
	'     Return True
	'   End Function
	'   Protected Overrides Sub OnSaving()
	'     For i = 0 To Detail.Count - 1
	'       Detail(i).Gudang = _gudang
	'     Next
	'     If Not CheckData() Then
	'       Return
	'     End If
	'     If Kode = Nothing Then
	'       Kode = Number.GetNewNumber.Kode
	'     End If
	'     MyBase.OnSaving()
	'   End Sub
	' End Class
	'<Persistent("m04dstockdetail")> Friend Class Fusoh_StockDetail
	'	Inherits NPOBase

	'	Public Sub New(ByVal session As UnitOfWork)
	'		MyBase.New(session)
	'	End Sub
	'	Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
	'		MyBase.New(session, classInfo)
	'	End Sub

	'	Private _id As Int64
	'	Private _main As Fusoh_StockMain
	'	Private _item As NuSoft004.Persistent.Fusoh_Barang
	'	Private _gudang As NuSoft004.Persistent.Gudang
	'	Private _catatan As String
	'	Private _satuan As NuSoft004.Persistent.Satuan
	'	Private _qtyin As Double
	'	Private _qtyout As Double
	'	Private _harga As Double
	'	Private _outDiameter As Decimal
	'	Private _inDiameter As Decimal
	'	Private _thickness As Decimal
	'	Private _length As Decimal
	'	Private _weight As Decimal
	'	'Private _eximDetail As Fusoh_EximDetail

	'	<Persistent("primary_main"), Key(True)> Property Id As Int64
	'		Get
	'			Return _id
	'		End Get
	'		Set(value As Int64)
	'			SetPropertyValue(Of Int64)("Id", _id, value)
	'		End Set
	'	End Property
	'	<Persistent("p_id"), Association("fk_fusoh_penerimaan_detail")> Property Main As Fusoh_StockMain
	'		Get
	'			Return _main
	'		End Get
	'		Set(value As Fusoh_StockMain)
	'			SetPropertyValue(Of Fusoh_StockMain)("Main", _main, value)
	'		End Set
	'	End Property
	'	<Persistent("f_item")> Property Barang As NuSoft004.Persistent.Fusoh_Barang
	'		Get
	'			Return _item
	'		End Get
	'		Set(value As NuSoft004.Persistent.Fusoh_Barang)
	'			SetPropertyValue(Of NuSoft004.Persistent.Fusoh_Barang)("Barang", _item, value)
	'		End Set
	'	End Property
	'	<Persistent("f_warehouse")> Property Gudang As NuSoft004.Persistent.Gudang
	'		Get
	'			Return _gudang
	'		End Get
	'		Set(value As NuSoft004.Persistent.Gudang)
	'			SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang", _gudang, value)
	'		End Set
	'	End Property
	'	<Persistent("d_remarks")> Property Catatan As String
	'		Get
	'			Return _catatan
	'		End Get
	'		Set(value As String)
	'			SetPropertyValue(Of String)("Catatan", _catatan, value)
	'		End Set
	'	End Property
	'	<Persistent("f_uom")> Property Satuan As NuSoft004.Persistent.Satuan
	'		Get
	'			Return _satuan
	'		End Get
	'		Set(value As NuSoft004.Persistent.Satuan)
	'			SetPropertyValue(Of NuSoft004.Persistent.Satuan)("Satuan", _satuan, value)
	'		End Set
	'	End Property
	'	<Persistent("d_qtyin")> Property QtyIN As Double
	'		Get
	'			Return _qtyin
	'		End Get
	'		Set(value As Double)
	'			SetPropertyValue(Of Double)("QtyIN", _qtyin, value)
	'		End Set
	'	End Property
	'	<Persistent("d_qtyout")> Property QtyOut As Double
	'		Get
	'			Return _qtyout
	'		End Get
	'		Set(value As Double)
	'			SetPropertyValue(Of Double)("QtyOut", _qtyout, value)
	'		End Set
	'	End Property
	'	<Persistent("d_price")> Property Harga As Double
	'		Get
	'			Return _harga
	'		End Get
	'		Set(value As Double)
	'			SetPropertyValue(Of Double)("Harga", _harga, value)
	'		End Set
	'	End Property
	'	<Persistent("d_od")> Property OutDiameter As Decimal
	'		Get
	'			Return _outDiameter
	'		End Get
	'		Set(value As Decimal)
	'			SetPropertyValue(Of Decimal)("OutDiameter", _outDiameter, value)
	'		End Set
	'	End Property
	'	<Persistent("d_id")> Property InDiameter As Decimal
	'		Get
	'			Return _inDiameter
	'		End Get
	'		Set(value As Decimal)
	'			SetPropertyValue(Of Decimal)("InDiameter", _inDiameter, value)
	'		End Set
	'	End Property
	'	<Persistent("d_tickness")> Property Thickness As Decimal
	'		Get
	'			Return _thickness
	'		End Get
	'		Set(value As Decimal)
	'			SetPropertyValue(Of Decimal)("Thickness", _thickness, value)
	'		End Set
	'	End Property
	'	<Persistent("d_length")> Property Length As Decimal
	'		Get
	'			Return _length
	'		End Get
	'		Set(value As Decimal)
	'			SetPropertyValue(Of Decimal)("Length", _length, value)
	'		End Set
	'	End Property
	'	<Persistent("d_weight")> Property Weight As Decimal
	'		Get
	'			Return _weight
	'		End Get
	'		Set(value As Decimal)
	'			SetPropertyValue(Of Decimal)("Weight", _weight, value)
	'		End Set
	'	End Property
	'	'<Persistent("f_ideximmd")> Property EximDetail As Fusoh_EximDetail
	'	'  Get
	'	'    Return _eximDetail
	'	'  End Get
	'	'  Set(value As Fusoh_EximDetail)
	'	'    SetPropertyValue(Of Fusoh_EximDetail)("EximDetail", _eximDetail, value)
	'	'  End Set
	'	'End Property

	'	<Association("fk_fusoh_penerimaan_detail_serial"), Aggregated> ReadOnly Property DetailSerial As XPCollection(Of Fusoh_StockDetailSerial)
	'		Get
	'			Return GetCollection(Of Fusoh_StockDetailSerial)("DetailSerial")
	'		End Get
	'	End Property
	'	<Association("fk_fusohstock_detail_hpp_out"), Aggregated> ReadOnly Property DetailHPPOut As XPCollection(Of Fusoh_HPP)
	'		Get
	'			Return GetCollection(Of Fusoh_HPP)("DetailHPPOut")
	'		End Get
	'	End Property
	'	<Association("fk_fusohstock_detail_hpp_in")> ReadOnly Property DetailHPPIn As XPCollection(Of Fusoh_HPP)
	'		Get
	'			Return GetCollection(Of Fusoh_HPP)("DetailHPPIn")
	'		End Get
	'	End Property

	'	'total length
	'	<PersistentAlias("DetailSerial.Sum(LengthIn-LengthOut)")> ReadOnly Property TotalLength As Double
	'		Get
	'			Return Convert.ToDouble(EvaluateAlias("TotalLength"))
	'		End Get
	'	End Property

	'	Property DetailSerial_Temp As List(Of Fusoh_StockDetailSerial_Temp)

	'	Private Function CheckData() As Boolean
	'		Dim source As String = "Penerimaan Barang [GR]"
	'		If IsDeleted Then
	'			Return True
	'		End If
	'		If _main Is Nothing AndAlso Not IsDeleted Then
	'			Throw New Utils.Exception("Masukkan data utama permintaan penawaran", -99, "", source)
	'			Return False
	'		End If
	'		If _gudang Is Nothing AndAlso Not IsDeleted Then
	'			Throw New Utils.Exception("Masukkan kode gudang", -99, "", source)
	'			Return False
	'		End If
	'		If _item Is Nothing Then
	'			Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
	'			Return False
	'		End If
	'		If _satuan Is Nothing Then
	'			Throw New Utils.Exception("Masukkan satuan barang", -99, "", source)
	'			Return False
	'		End If
	'		Return True
	'	End Function
	'	Protected Overrides Sub OnSaving()
	'		If Not CheckData() Then
	'			Return
	'		End If
	'		MyBase.OnSaving()
	'	End Sub
	'End Class
	'<Persistent("m04estockdetailserial")> Friend Class Fusoh_StockDetailSerial
	'	Inherits NPOBase

	'	Public Sub New(ByVal session As UnitOfWork)
	'		MyBase.New(session)
	'	End Sub
	'	Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
	'		MyBase.New(session, classInfo)
	'	End Sub

	'	Private _id As Int64
	'	Private _detail As Fusoh_StockDetail
	'	Private _serial As String
	'	Private _millSheet As String
	'	Private _lengthin As Double
	'	Private _lengthout As Double

	'	<Persistent("primary_main"), Key(True)> Property Id As Int64
	'		Get
	'			Return _id
	'		End Get
	'		Set(value As Int64)
	'			SetPropertyValue(Of Int64)("Id", _id, value)
	'		End Set
	'	End Property
	'	<Persistent("p_id"), Association("fk_fusoh_penerimaan_detail_serial")> Property DetailMain As Fusoh_StockDetail
	'		Get
	'			Return _detail
	'		End Get
	'		Set(value As Fusoh_StockDetail)
	'			SetPropertyValue(Of Fusoh_StockDetail)("DetailMain", _detail, value)
	'		End Set
	'	End Property
	'	<Persistent("d_serial")> Property Serial As String
	'		Get
	'			Return _serial
	'		End Get
	'		Set(value As String)
	'			SetPropertyValue(Of String)("Serial", _serial, value)
	'		End Set
	'	End Property
	'	<Persistent("d_millsheet")> Property MillSheet As String
	'		Get
	'			Return _millSheet
	'		End Get
	'		Set(value As String)
	'			SetPropertyValue(Of String)("MillSheet", _millSheet, value)
	'		End Set
	'	End Property
	'	<Persistent("d_length_in")> Property LengthIn As Double
	'		Get
	'			Return _lengthin
	'		End Get
	'		Set(value As Double)
	'			SetPropertyValue(Of Double)("LengthIn", _lengthin, value)
	'		End Set
	'	End Property
	'	<Persistent("d_length_out")> Property LengthOut As Double
	'		Get
	'			Return _lengthout
	'		End Get
	'		Set(value As Double)
	'			SetPropertyValue(Of Double)("LengthOut", _lengthout, value)
	'		End Set
	'	End Property

	'	Private Function CheckData() As Boolean
	'		Dim source As String = "Penerimaan Barang [GR]"
	'		If IsDeleted Then
	'			Return True
	'		End If

	'		If _detail Is Nothing AndAlso Not IsDeleted Then
	'			Throw New Utils.Exception("Masukkan data utama permintaan penawaran", -99, "", source)
	'			Return False
	'		End If
	'		If _serial = Nothing Then
	'			Throw New Utils.Exception("Masukkan data serial", -99, "", source)
	'			Return False
	'		End If

	'		Return True
	'	End Function
	'	Protected Overrides Sub OnSaving()
	'		If Not CheckData() Then
	'			Return
	'		End If
	'		MyBase.OnSaving()
	'	End Sub
	'End Class

	<Persistent("m04cstockmain")> Friend Class Fusoh_StockAdjustment
		Inherits TransactionMain

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _gudang As NuSoft004.Persistent.Gudang
		Private _uraian As String
		Private _status As NuSoft001.Persistent.StatusTransaksiEnum

		<Persistent("f_warehouse")> Property Gudang As NuSoft004.Persistent.Gudang
			Get
				Return _gudang
			End Get
			Set(value As NuSoft004.Persistent.Gudang)
				SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang", _gudang, value)
			End Set
		End Property
		<Persistent("d_remarks")> Property Uraian As String
			Get
				Return _uraian
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Uraian", _uraian, value)
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

		<Association("fk_fusoh_adjustment_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_StockAdjustmentDetail)
			Get
				Return GetCollection(Of Fusoh_StockAdjustmentDetail)("Detail")
			End Get
		End Property

		Private Function CheckData() As Boolean
			Dim source As String = "Adjustment Stok"
			If IsDeleted Then
				Return True
			End If
			If Regional Is Nothing Then
				Throw New Utils.Exception("Masukkan regional", -1, "", source)
				Return False
			End If
			If Tanggal = Nothing Then
				Throw New Utils.Exception("Masukkan tanggal", -2, "", source)
				Return False
			End If
			If Gudang Is Nothing Then
				Throw New Utils.Exception("Masukkan gudang", -3, "", source)
				Return False
			End If
			If Session.IsNewObject(Me) Then
				If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
					Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -4, "", source)
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

		<PersistentAlias("Detail.Max(BarangInKode)")> ReadOnly Property BarangInKode As String
			Get
				Return Convert.ToString(EvaluateAlias("BarangInKode"))
			End Get
		End Property
		<PersistentAlias("Detail.Max(BarangOutKode)")> ReadOnly Property BarangOutKode As String
			Get
				Return Convert.ToString(EvaluateAlias("BarangOutKode"))
			End Get
		End Property
		<PersistentAlias("Detail.Max(NoLot)")> ReadOnly Property NomorLot As String
			Get
				Return Convert.ToString(EvaluateAlias("NomorLot"))
			End Get
		End Property
		<PersistentAlias("Detail.Max(NoProduksi)")> ReadOnly Property NomorProduksi As String
			Get
				Return Convert.ToString(EvaluateAlias("NomorProduksi"))
			End Get
		End Property
	End Class
	<Persistent("m04dstockdetail")> Friend Class Fusoh_StockAdjustmentDetail
		Inherits NPOBase

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _id As Int64
		Private _main As Fusoh_StockAdjustment
		Private _item As Fusoh_Barang
		Private _gudang As Gudang
		Private _satuan As Satuan
		Private _qtyin As Double
		Private _qtyout As Double
		Private _harga As Double
		Private _outDiameter As Decimal
		Private _inDiameter As Decimal
		Private _thickness As Decimal
		Private _length As Decimal
		Private _weight As Decimal
		Private _catatan As String
		Private _TotalHPP As Decimal
		Private _produksiDetail As Fusoh_StokDetail

		<Persistent("primary_main"), Key(True)> Property Id As Int64
			Get
				Return _id
			End Get
			Set(value As Int64)
				SetPropertyValue(Of Int64)("Id", _id, value)
			End Set
		End Property
		<Persistent("p_id"), Association("fk_fusoh_adjustment_detail")> Property Main As Fusoh_StockAdjustment
			Get
				Return _main
			End Get
			Set(value As Fusoh_StockAdjustment)
				SetPropertyValue(Of Fusoh_StockAdjustment)("Main", _main, value)
			End Set
		End Property
		<Persistent("f_item")> Property Barang As NuSoft004.Persistent.Fusoh_Barang
			Get
				Return _item
			End Get
			Set(value As NuSoft004.Persistent.Fusoh_Barang)
				SetPropertyValue(Of NuSoft004.Persistent.Fusoh_Barang)("Barang", _item, value)
			End Set
		End Property
		<Persistent("f_warehouse")> Property Gudang As NuSoft004.Persistent.Gudang
			Get
				Return _gudang
			End Get
			Set(value As NuSoft004.Persistent.Gudang)
				SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang", _gudang, value)
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
		<Persistent("d_qtyin")> Property QtyIN As Double
			Get
				Return _qtyin
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("QtyIN", _qtyin, value)
			End Set
		End Property
		<Persistent("d_qtyout")> Property QtyOut As Double
			Get
				Return _qtyout
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("QtyOut", _qtyout, value)
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
		<Persistent("d_od")> Property OutDiameter As Decimal
			Get
				Return _outDiameter
			End Get
			Set(value As Decimal)
				SetPropertyValue(Of Decimal)("OutDiameter", _outDiameter, value)
			End Set
		End Property
		<Persistent("d_id")> Property InDiameter As Decimal
			Get
				Return _inDiameter
			End Get
			Set(value As Decimal)
				SetPropertyValue(Of Decimal)("InDiameter", _inDiameter, value)
			End Set
		End Property
		<Persistent("d_tickness")> Property Thickness As Decimal
			Get
				Return _thickness
			End Get
			Set(value As Decimal)
				SetPropertyValue(Of Decimal)("Thickness", _thickness, value)
			End Set
		End Property
		<Persistent("d_length")> Property Length As Decimal
			Get
				Return _length
			End Get
			Set(value As Decimal)
				SetPropertyValue(Of Decimal)("Length", _length, value)
			End Set
		End Property
		<Persistent("d_weight")> Property Weight As Decimal
			Get
				Return _weight
			End Get
			Set(value As Decimal)
				SetPropertyValue(Of Decimal)("Weight", _weight, value)
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
		<Persistent("d_hpp")> Property TotalHPP As Decimal
			Get
				Return _TotalHPP
			End Get
			Set(value As Decimal)
				SetPropertyValue(Of Decimal)("TotalHPP", _TotalHPP, value)
			End Set
		End Property
		<Persistent("f_idproduksid")> Property ProduksiDetail As Fusoh_StokDetail
			Get
				Return _produksiDetail
			End Get
			Set(value As Fusoh_StokDetail)
				SetPropertyValue(Of Fusoh_StokDetail)("ProduksiDetail", _produksiDetail, value)
			End Set
		End Property
		<Association("fk_fusoh_adjustment_detail_serial"), Aggregated> ReadOnly Property Serial As XPCollection(Of Fusoh_StockAdjustmentDetailSerial)
			Get
				Return GetCollection(Of Fusoh_StockAdjustmentDetailSerial)("Serial")
			End Get
		End Property

		<PersistentAlias("Iif(QtyIN > 0, Barang.Kode, '')")> ReadOnly Property BarangInKode As String
			Get
				Return Convert.ToString(EvaluateAlias("BarangInKode"))
			End Get
		End Property
		<PersistentAlias("Iif(QtyOut > 0, Barang.Kode, '')")> ReadOnly Property BarangOutKode As String
			Get
				Return Convert.ToString(EvaluateAlias("BarangOutKode"))
			End Get
		End Property
		<PersistentAlias("Iif(QtyOut > 0, ProduksiDetail.Main.DempyouLot, '')")> ReadOnly Property NoLot As String
			Get
				Return Convert.ToString(EvaluateAlias("NoLot"))
			End Get
		End Property
		<PersistentAlias("Iif(QtyOut > 0, ProduksiDetail.Main.Kode, '')")> ReadOnly Property NoProduksi As String
			Get
				Return Convert.ToString(EvaluateAlias("NoProduksi"))
			End Get
		End Property

		<PersistentAlias("Main.Kode"), NUnique(NUniqueAttribute.JenisAttr.LogKode)> ReadOnly Property UniqueData As String
			Get
				Return Convert.ToString(EvaluateAlias("UniqueData"))
			End Get
		End Property
		<PersistentAlias("Main.Id"), NUnique(NUniqueAttribute.JenisAttr.LogId)> ReadOnly Property UniqueId As String
			Get
				Return Convert.ToString(EvaluateAlias("UniqueId"))
			End Get
		End Property

		Private Function CheckData() As Boolean
			Dim source As String = "Adjustment Stok"
			If IsDeleted Then
				Return True
			End If
			If _main Is Nothing AndAlso Not IsDeleted Then
				Throw New Utils.Exception("Masukkan data utama", -99, "", source)
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
			If _satuan Is Nothing Then
				Throw New Utils.Exception("Masukkan satuan barang", -99, "", source)
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

		<NonPersistent> Property SisaStok As Double
		<NonPersistent> Property SerialTemp As List(Of Fusoh_StockDetailSerial_Temp)
	End Class
	<Persistent("m04estockdetailserial")> Friend Class Fusoh_StockAdjustmentDetailSerial
		Inherits NPOBase

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _id As Int64
		Private _detail As Fusoh_StockAdjustmentDetail
		Private _serial As String
		Private _millSheet As String
		Private _lengthin As Double
		Private _lengthout As Double

		<Persistent("primary_main"), Key(True)> Property Id As Int64
			Get
				Return _id
			End Get
			Set(value As Int64)
				SetPropertyValue(Of Int64)("Id", _id, value)
			End Set
		End Property
		<Persistent("p_id"), Association("fk_fusoh_adjustment_detail_serial")> Property DetailMain As Fusoh_StockAdjustmentDetail
			Get
				Return _detail
			End Get
			Set(value As Fusoh_StockAdjustmentDetail)
				SetPropertyValue(Of Fusoh_StockAdjustmentDetail)("DetailMain", _detail, value)
			End Set
		End Property
		<Persistent("d_serial")> Property Serial As String
			Get
				Return _serial
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Serial", _serial, value)
			End Set
		End Property
		<Persistent("d_millsheet")> Property MillSheet As String
			Get
				Return _millSheet
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("MillSheet", _millSheet, value)
			End Set
		End Property
		<Persistent("d_length_in")> Property LengthIn As Double
			Get
				Return _lengthin
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("LengthIn", _lengthin, value)
			End Set
		End Property
		<Persistent("d_length_out")> Property LengthOut As Double
			Get
				Return _lengthout
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("LengthOut", _lengthout, value)
			End Set
		End Property

		<PersistentAlias("DetailMain.Main.Kode"), NUnique(NUniqueAttribute.JenisAttr.LogKode)> ReadOnly Property UniqueData As String
			Get
				Return Convert.ToString(EvaluateAlias("UniqueData"))
			End Get
		End Property
		<PersistentAlias("DetailMain.Main.Id"), NUnique(NUniqueAttribute.JenisAttr.LogId)> ReadOnly Property UniqueId As String
			Get
				Return Convert.ToString(EvaluateAlias("UniqueId"))
			End Get
		End Property

		Private Function CheckData() As Boolean
			Dim source As String = "Adjustment Stok"
			If IsDeleted Then
				Return True
			End If

			If _detail Is Nothing AndAlso Not IsDeleted Then
				Throw New Utils.Exception("Masukkan data utama", -99, "", source)
				Return False
			End If
			If _serial = Nothing Then
				Throw New Utils.Exception("Masukkan data serial", -99, "", source)
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

	''===========================================================================================================
	'<Persistent("m04estockhpp")> Friend Class Fusoh_HPP
	'	Inherits NPOBase

	'	Public Sub New(ByVal session As UnitOfWork)
	'		MyBase.New(session)
	'	End Sub
	'	Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
	'		MyBase.New(session, classInfo)
	'	End Sub

	'	Private _id As Int64
	'	Private _detailOut As Fusoh_StockDetail
	'	Private _detailIn As Fusoh_StockDetail
	'	Private _qty As Double

	'	<Persistent("p_id"), Key(True)> Property Id As Int64
	'		Get
	'			Return _id
	'		End Get
	'		Set(value As Int64)
	'			SetPropertyValue(Of Int64)("Id", _id, value)
	'		End Set
	'	End Property
	'	<Persistent("f_idout"), Association("fk_fusohstock_detail_hpp_out")> Property DetailOut As Fusoh_StockDetail
	'		Get
	'			Return _detailOut
	'		End Get
	'		Set(value As Fusoh_StockDetail)
	'			SetPropertyValue(Of Fusoh_StockDetail)("DetailOut", _detailOut, value)
	'		End Set
	'	End Property
	'	<Persistent("f_idin"), Association("fk_fusohstock_detail_hpp_in")> Property DetailIn As Fusoh_StockDetail
	'		Get
	'			Return _detailIn
	'		End Get
	'		Set(value As Fusoh_StockDetail)
	'			SetPropertyValue(Of Fusoh_StockDetail)("DetailIn", _detailIn, value)
	'		End Set
	'	End Property
	'	<Persistent("d_qty")> Property Qty As Double
	'		Get
	'			Return _qty
	'		End Get
	'		Set(value As Double)
	'			SetPropertyValue(Of Double)("Qty", _qty, value)
	'		End Set
	'	End Property

	'	<PersistentAlias("Qty * (DetailIn.Harga * DetailIn.Main.Kurs)")> ReadOnly Property NilaiHPP As Double
	'		Get
	'			Return Convert.ToDouble(EvaluateAlias("NilaiHPP"))
	'		End Get
	'	End Property

	'	Private Function CheckData() As Boolean
	'		Dim source As String = "HPP"
	'		If _detailOut Is Nothing AndAlso Not IsDeleted Then
	'			Throw New Utils.Exception("Masukkan data detail stock", -99, "", source)
	'			Return False
	'		End If
	'		If Qty = 0 Then
	'			Throw New Utils.Exception("Masukkan Qty Barang", -99, "", source)
	'			Return False
	'		End If
	'		Return True
	'	End Function
	'	Protected Overrides Sub OnSaving()
	'		If Not CheckData() Then
	'			Return
	'		End If
	'		MyBase.OnSaving()
	'	End Sub
	'End Class

	'Friend Class Fusoh_StockDetailSerial_Temp
	'	Property Id As Int64
	'	Property DetailMain As Fusoh_StockDetail
	'	Property Serial As String
	'	Property MillSheet As String
	'	Property LengthIn As Double
	'	Property State As Short '0 = tidak terpilih, 1 = terpilih, 2 = terpakai
	'End Class

	<NonPersistent> Friend Class NonViewStockWIPDetail
		Inherits XPLiteObject

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub

		<Key> Property SOId As UInteger
		Property KodeBarang As String
		Property NamaBarang As String
		Property QtyMasuk As Decimal
		Property QtyKeluar As Decimal
		Property QtySaldoAwal As Decimal
		Property QtyMutasiIN As Decimal
		Property QtyMutasiOut As Decimal
		Property QtySaldoAkhir As Decimal
		Property AmountIN As Decimal
		Property AmountOUT As Decimal
		Property AmountSaldoAwal As Decimal
		Property AmountMutasiIN As Decimal
		Property AmountMutasiOut As Decimal
		Property AmountSaldoAkhir As Decimal
		Property d_od As Decimal
		Property d_id As Decimal
		Property d_ticknes As Decimal
		Property d_length As Decimal
	End Class
End Namespace