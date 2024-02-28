Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute

Namespace NonPersistent
	Friend Class Fusoh_DempyouInProduksi
		Public Property Id As Long
		Public Property Dempyou As Persistent.Fusoh_OrderProduksi
		Public Property CuttingWIP As Persistent.Fusoh_StokMain
		Public Property DailyProcessList As List(Of Persistent.Fusoh_DailyProcess)

		Public ReadOnly Property This As Fusoh_DempyouInProduksi
			Get
				Return Me
			End Get
		End Property
    Public ReadOnly Property QtyDailyProcess As Double
      Get
        If DailyProcessList Is Nothing Then
          Return 0
        Else
          Return DailyProcessList.Sum(Function(x) x.QtyFinishGood)
        End If
      End Get
    End Property
    Public ReadOnly Property TanggalDailyProcess As Date
      Get
        If DailyProcessList Is Nothing Then
          Return Nothing
        Else
          Return DailyProcessList.Max(Function(m) m.Tanggal)
        End If
      End Get
    End Property
  End Class
End Namespace

Namespace Persistent
	<Persistent("m04amesin")>
	Public Class Fusoh_Mesin
		Inherits NPOBase

		Protected Friend changes As New List(Of DatabaseLogDetailChange)()
		Protected Overrides Sub OnChanged(ByVal propertyName As String, ByVal oldValue As Object, ByVal newValue As Object)
			MyBase.OnChanged(propertyName, oldValue, newValue)
			Dim change As New DatabaseLogDetailChange() With {.PropertyName = propertyName}
			If oldValue Is Nothing Then
				change.PrevValue = "<NULL>"
			Else
				change.PrevValue = oldValue.ToString()
			End If
			If newValue Is Nothing Then
				change.Value = "<NULL>"
			Else
				change.Value = newValue.ToString()
			End If
			If changes Is Nothing Then changes = New List(Of DatabaseLogDetailChange)
			changes.Add(change)
		End Sub

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		<Indexed("Kode", Unique:=True)> Private _id As Int32
		Private _kode As String
		Private _nama As String
		<Persistent("p_id"), Key(True)> Property Id As Int32
			Get
				Return _id
			End Get
			Set(value As Int32)
				SetPropertyValue(Of Int32)("Id", _id, value)
			End Set
		End Property
		<Persistent("u_code")> Property Kode As String
			Get
				Return _kode
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Kode", _kode, value)
			End Set
		End Property
		<Persistent("d_name")> Property Nama As String
			Get
				Return _nama
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Nama", _nama, value)
			End Set
		End Property

		Protected Overrides Sub OnSaving()
			If CheckData() Then
				MyBase.OnSaving()
			End If
		End Sub
		Private Function CheckData() As Boolean
			Const sumber As String = "Master Mesin"
			If _kode = Nothing Then
				Throw New Utils.Exception("Masukkan kode mesin", -1, "", sumber)
				Return False
			End If
			If _nama = Nothing Then
				Throw New Utils.Exception("Masukkan nama mesin", -2, "", sumber)
				Return False
			End If

			If Not Session.IsNewObject(Me) Then
				Dim detail As New List(Of DatabaseLogDetailChange)
				Dim anyChanges As Boolean = False

				detail = changes.FindAll(Function(m) m.PropertyName = "Kode")
				If detail.Count > 0 Then
					'Throw New Exception(detail(0).PrevValue & "<>" & detail(detail.Count - 1).Value)
					If detail(0).PrevValue <> detail(detail.Count - 1).Value Then
						anyChanges = True
					End If
				End If

				If Not anyChanges Then
					Return True
				End If
			End If
			If Not Session.FindObject(Of Fusoh_Mesin)(New BinaryOperator("Kode", _kode, BinaryOperatorType.Equal)) Is Nothing Then
				Throw New Utils.Exception("Kode mesin '" & _kode & "' sudah ada. Silahkan masukkan kode mesin yang lain.", -1, "", sumber)
				Return False
			End If

			Return True
		End Function
	End Class
	<Persistent("m04aprocesscutting")> Public Class Fusoh_ProcessCutting
		Inherits NPOBase

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _id As Integer
		Private _kode As String
		Private _nama As String
		Private _defaultFG As Integer
		Private _keterangan As String

		<Key(True)> Property Id As Integer
			Get
				Return _id
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)("Id", _id, value)
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
		Property Nama As String
			Get
				Return _nama
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Nama", _nama, value)
			End Set
		End Property
		Property DefaultFG As Integer
			Get
				Return _defaultFG
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)("DefaultFG", _defaultFG, value)
			End Set
		End Property
		Property Keterangan As String
			Get
				Return _keterangan
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Keterangan", _keterangan, value)
			End Set
		End Property
	End Class

	<Persistent("m04corderproduksi")> Public Class Fusoh_OrderProduksi
		Inherits Persistent.TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _customer As NuSoft001.Persistent.Kontak
		Private _gudang As Gudang
		Private _sodetail As Fusoh_OrderPenjualanDetail
    Private _nomorLot As String
    Private _nomorpdo As String
    Private _nomorDrawing As String
		Private _materialFlow As String
		Private _deliveryDate As String
		Private _catatan As String
		Private _status As NuSoft001.Persistent.StatusTransaksiEnum
		Private _qty As Double
		Private _weight As Decimal
		Private _lengthTolerance As String
		Private _materialCorner As String
		Private _colourCode As String
		Private _cutting As Double
    Private _printCounter As Integer
    Private _printCounterPR As Integer
    Private _targetfinish As String
		Private _noCutting As Boolean
		Private _urgent As Boolean

		<Persistent("f_customer")> Property Pelanggan As NuSoft001.Persistent.Kontak
			Get
				Return _customer
			End Get
			Set(value As NuSoft001.Persistent.Kontak)
				SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _customer, value)
			End Set
		End Property
		<Persistent("f_warehouse")> Property Gudang As Gudang
			Get
				Return _gudang
			End Get
			Set(value As Gudang)
				SetPropertyValue(Of Gudang)("Gudang", _gudang, value)
			End Set
		End Property
		<Persistent("f_sodetail")> Property SODetail As Fusoh_OrderPenjualanDetail
			Get
				Return _sodetail
			End Get
			Set(value As Fusoh_OrderPenjualanDetail)
				SetPropertyValue(Of Fusoh_OrderPenjualanDetail)("SODetail", _sodetail, value)
			End Set
		End Property
		<Persistent("d_nomorlot")> Property NomorLot As String
			Get
				Return _nomorLot
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("NomorLot", _nomorLot, value)
			End Set
		End Property
    <Persistent("d_nomorpdo")> Property NomorPDO As String
      Get
        Return _nomorpdo
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NomorPDO", _nomorpdo, value)
      End Set
    End Property
    <Persistent("d_nodrawing")> Property NomorDrawing As String
      Get
        Return _nomorDrawing
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NomorDrawing", _nomorDrawing, value)
      End Set
    End Property
    <Persistent("d_materialflow")> Property MaterialFlow As String
			Get
				Return _materialFlow
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("MaterialFlow", _materialFlow, value)
			End Set
		End Property
		<Persistent("d_delivery")> Property DeliveryDate As String
			Get
				Return _deliveryDate
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("DeliveryDate", _deliveryDate, value)
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
		<Persistent("d_status")> Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
			Get
				Return _status
			End Get
			Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
				SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
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
		<Persistent("d_weight")> Property Weight As Decimal
			Get
				Return _weight
			End Get
			Set(value As Decimal)
				SetPropertyValue(Of Decimal)("Weight", _weight, value)
			End Set
		End Property
		<Persistent("d_lengthtolerance")> Property LengthTolerance As String
			Get
				Return _lengthTolerance
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("LengthTolerance", _lengthTolerance, value)
			End Set
		End Property
		<Persistent("d_materialcorner")> Property MaterialCorner As String
			Get
				Return _materialCorner
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("MaterialCorner", _materialCorner, value)
			End Set
		End Property
		<Persistent("d_colourcode")> Property ColourCode As String
			Get
				Return _colourCode
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("ColourCode", _colourCode, value)
			End Set
		End Property
		<Persistent("d_cutting")> Property Cutting As Double
			Get
				Return _cutting
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)("Cutting", _cutting, value)
			End Set
		End Property
		<Persistent("PrintCounter")> Property PrintCounter As Integer
			Get
				Return _printCounter
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)("PrintCounter", _printCounter, value)
			End Set
		End Property
    <Persistent("PrintCounterPR")> Property PrintCounterPR As Integer
      Get
        Return _printCounterPR
      End Get
      Set(value As Integer)
        SetPropertyValue(Of Integer)("PrintCounterPR", _printCounterPR, value)
      End Set
    End Property
    <Persistent("d_targetfinish")> Property TargetFinish As String
      Get
        Return _targetfinish
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("TargetFinish", _targetfinish, value)
      End Set
    End Property
    <Persistent("d_nocutting")> Property NoCutting As Boolean
			Get
				Return _noCutting
			End Get
			Set(value As Boolean)
				SetPropertyValue(Of Boolean)("NoCutting", _noCutting, value)
			End Set
		End Property
		<Persistent("d_urgent")> Property Urgent As Boolean
			Get
				Return _urgent
			End Get
			Set(value As Boolean)
				SetPropertyValue(Of Boolean)("Urgent", _urgent, value)
			End Set
		End Property

		<Association("fk_orderproduksi_bahanbaku"), Aggregated> ReadOnly Property BahanBaku As XPCollection(Of Fusoh_OrderProduksiBahanBaku)
			Get
				Return GetCollection(Of Fusoh_OrderProduksiBahanBaku)("BahanBaku")
			End Get
		End Property
		'<Association("fk_orderproduksi_daily"), Aggregated> ReadOnly Property DailyProcces As XPCollection(Of Fusoh_OrderProduksiDaily)
		'	Get
		'		Return GetCollection(Of Fusoh_OrderProduksiDaily)("DailyProcces")
		'	End Get
		'End Property
		<Association("fk_orderproduksi_produksi"), Aggregated> ReadOnly Property Produksi As XPCollection(Of Fusoh_Produksi)
			Get
				Return GetCollection(Of Fusoh_Produksi)("Produksi")
			End Get
		End Property
		<PersistentAlias("Produksi.Sum(QtyProduksi)")> ReadOnly Property QtyProduksi As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("QtyProduksi"))
			End Get
		End Property
    <PersistentAlias("Produksi.Sum(QtyCutting)")> ReadOnly Property QtyCutting As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("QtyCutting"))
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Order Produksi"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -2, "", source)
        Return False
      End If
      If Pelanggan Is Nothing Then
        Throw New Utils.Exception("Masukkan Pelanggan", -3, "", source)
        Return False
      End If
      If Gudang Is Nothing Then
        Throw New Utils.Exception("Masukkan gudang", -4, "", source)
        Return False
      End If
      If SODetail Is Nothing Then
        Throw New Utils.Exception("Masukkan nomor PO Pelanggan", -5, "", source)
        Return False
      End If
      If String.IsNullOrEmpty(NomorLot) Then
        Throw New Utils.Exception("Masukkan nomor lot", -6, "", source)
        Return False
      End If
      'If DeliveryDate = Nothing Then
      '	Throw New Utils.Exception("Masukkan tanggal delivery", -7, "", source)
      '	Return False
      'End If
      ''======= Cek Periode
      'If NuSoft001.Persistent.Periode.CheckLockedPeriod(Session, Tanggal) Then
      '  Throw New Utils.Exception("Periode sudah ditutup", -4, "Hubungi accounting untuk membuka periode", source)
      '  Return False
      'End If
      ''======= Cek Sebelum Awal Periode
      'If NuSoft001.Persistent.Periode.CheckBeforeBeginningPeriod(Session, Tanggal) Then
      '  Throw New Utils.Exception("Tanggal transaksi sebelum awal periode", -4, "Silahkan ganti tanggal transaksi", source)
      '  Return False
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
  <Persistent("m04dorderproduksibaku")> Public Class Fusoh_OrderProduksiBahanBaku
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_OrderProduksi
    Private _item As Fusoh_Barang
    Private _millsheet As String
    Private _serial As String
    Private _snlength As Decimal
    Private _length As Decimal
    Private _qty As Integer
    Private _weight As Double
    Private _catatan As String
    Private _scrap As Boolean

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_orderproduksi_bahanbaku")> Property Main As Fusoh_OrderProduksi
      Get
        Return _main
      End Get
      Set(value As Fusoh_OrderProduksi)
        SetPropertyValue(Of Fusoh_OrderProduksi)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_item")> Property Barang As Fusoh_Barang
      Get
        Return _item
      End Get
      Set(value As Fusoh_Barang)
        SetPropertyValue(Of Fusoh_Barang)("Barang", _item, value)
      End Set
    End Property
    <Persistent("d_millsheet")> Property Millsheet As String
      Get
        Return _millsheet
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Millsheet", _millsheet, value)
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
    <Persistent("d_snlength")> Property SNLength As Decimal
      Get
        Return _snlength
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("SNLength", _snlength, value)
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

    <Persistent("d_qty")> Property Qty As Integer
      Get
        Return _qty
      End Get
      Set(value As Integer)
        SetPropertyValue(Of Integer)("Qty", _qty, value)
      End Set
    End Property
    <Persistent("d_weight")> Property Weight As Double
      Get
        Return _weight
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Weight", _weight, value)
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
    <Persistent("d_scrap")> Property Scrap As Boolean
      Get
        Return _scrap
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("Scrap", _scrap, value)
      End Set
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
      Dim source As String = "Order Produksi - Bahan Baku"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama order produksi", -99, "", source)
        Return False
      End If
      If _item Is Nothing Then
        Throw New Utils.Exception("Masukkan barang", -99, "", source)
        Return False
      End If
      If _serial Is Nothing Then
        Throw New Utils.Exception("Masukkan serial", -99, "", source)
        Return False
      End If
      If _length = Nothing Then
        Throw New Utils.Exception("Masukkan length yang dibutuhkan", -99, "", source)
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

  '<Persistent("m04dorderproduksidaily")> Public Class Fusoh_OrderProduksiDaily
  '	Inherits NPOBase

  '	Public Sub New(ByVal session As UnitOfWork)
  '		MyBase.New(session)
  '	End Sub
  '	Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
  '		MyBase.New(session, classInfo)
  '	End Sub

  '	Private _id As Int64
  '	Private _main As Fusoh_OrderProduksi
  '	Private _tanggal As Date
  '	Private _mesin As Fusoh_Mesin
  '	Private _shift As Integer
  '	Private _jamkerja As Integer
  '	Private _qtyop1 As Double
  '	Private _qtyop2 As Double
  '	Private _qtyop3 As Double
  '	Private _qtyfg As Double
  '	'Private _qtyp1 As Double
  '	'Private _qtyp2 As Double
  '	'Private _qtyp3 As Double
  '	'Private _qtyp4 As Double
  '	'Private _qtyp5 As Double
  '	'Private _qtyp6 As Double
  '	'Private _qtyp7 As Double
  '	Private _waktustop As Integer
  '	Private _catatan As String

  '	<Persistent("primary_main"), Key(True)> Property Id As Int64
  '		Get
  '			Return _id
  '		End Get
  '		Set(value As Int64)
  '			SetPropertyValue(Of Int64)("Id", _id, value)
  '		End Set
  '	End Property
  '	<Persistent("p_id"), Association("fk_orderproduksi_daily")> Property Main As Fusoh_OrderProduksi
  '		Get
  '			Return _main
  '		End Get
  '		Set(value As Fusoh_OrderProduksi)
  '			SetPropertyValue(Of Fusoh_OrderProduksi)("Main", _main, value)
  '		End Set
  '	End Property
  '	<Persistent("d_tanggal")> Property Tanggal As Date
  '		Get
  '			Return _tanggal
  '		End Get
  '		Set(value As Date)
  '			SetPropertyValue(Of Date)("Tanggal", _tanggal, value)
  '		End Set
  '	End Property
  '	<Persistent("f_mesin")> Property Mesin As Fusoh_Mesin
  '		Get
  '			Return _mesin
  '		End Get
  '		Set(value As Fusoh_Mesin)
  '			SetPropertyValue(Of Fusoh_Mesin)("Mesin", _mesin, value)
  '		End Set
  '	End Property
  '	<Persistent("d_shift")> Property Shift As Integer
  '		Get
  '			Return _shift
  '		End Get
  '		Set(value As Integer)
  '			SetPropertyValue(Of Integer)("Shift", _shift, value)
  '		End Set
  '	End Property
  '	<Persistent("d_jamkerja")> Property JamKerja As Integer
  '		Get
  '			Return _jamkerja
  '		End Get
  '		Set(value As Integer)
  '			SetPropertyValue(Of Integer)("JamKerja", _jamkerja, value)
  '		End Set
  '	End Property
  '	<Persistent("d_qtyop1")> Property QtyOP1 As Double
  '		Get
  '			Return _qtyop1
  '		End Get
  '		Set(value As Double)
  '			SetPropertyValue(Of Double)("QtyOP1", _qtyop1, value)
  '		End Set
  '	End Property
  '	<Persistent("d_qtyop2")> Property QtyOP2 As Double
  '		Get
  '			Return _qtyop2
  '		End Get
  '		Set(value As Double)
  '			SetPropertyValue(Of Double)("QtyOP2", _qtyop2, value)
  '		End Set
  '	End Property
  '	<Persistent("d_qtyop3")> Property QtyOP3 As Double
  '		Get
  '			Return _qtyop3
  '		End Get
  '		Set(value As Double)
  '			SetPropertyValue(Of Double)("QtyOP3", _qtyop3, value)
  '		End Set
  '	End Property
  '	<Persistent("d_qtyfg")> Property QtyFG As Double
  '		Get
  '			Return _qtyfg
  '		End Get
  '		Set(value As Double)
  '			SetPropertyValue(Of Double)("QtyFG", _qtyfg, value)
  '		End Set
  '	End Property
  '	'<Persistent("d_qtyp1")> Property QtyP1 As Double
  '	'	Get
  '	'		Return _qtyp1
  '	'	End Get
  '	'	Set(value As Double)
  '	'		SetPropertyValue(Of Double)("QtyP1", _qtyp1, value)
  '	'	End Set
  '	'End Property
  '	'<Persistent("d_qtyp2")> Property QtyP2 As Double
  '	'	Get
  '	'		Return _qtyp2
  '	'	End Get
  '	'	Set(value As Double)
  '	'		SetPropertyValue(Of Double)("QtyP2", _qtyp2, value)
  '	'	End Set
  '	'End Property
  '	'<Persistent("d_qtyp3")> Property QtyP3 As Double
  '	'	Get
  '	'		Return _qtyp3
  '	'	End Get
  '	'	Set(value As Double)
  '	'		SetPropertyValue(Of Double)("QtyP3", _qtyp3, value)
  '	'	End Set
  '	'End Property
  '	'<Persistent("d_qtyp4")> Property QtyP4 As Double
  '	'	Get
  '	'		Return _qtyp4
  '	'	End Get
  '	'	Set(value As Double)
  '	'		SetPropertyValue(Of Double)("QtyP4", _qtyp4, value)
  '	'	End Set
  '	'End Property
  '	'<Persistent("d_qtyp5")> Property QtyP5 As Double
  '	'	Get
  '	'		Return _qtyp5
  '	'	End Get
  '	'	Set(value As Double)
  '	'		SetPropertyValue(Of Double)("QtyP5", _qtyp5, value)
  '	'	End Set
  '	'End Property
  '	'<Persistent("d_qtyp6")> Property QtyP6 As Double
  '	'	Get
  '	'		Return _qtyp6
  '	'	End Get
  '	'	Set(value As Double)
  '	'		SetPropertyValue(Of Double)("QtyP6", _qtyp6, value)
  '	'	End Set
  '	'End Property
  '	'<Persistent("d_qtyp7")> Property QtyP7 As Double
  '	'	Get
  '	'		Return _qtyp7
  '	'	End Get
  '	'	Set(value As Double)
  '	'		SetPropertyValue(Of Double)("QtyP7", _qtyp7, value)
  '	'	End Set
  '	'End Property
  '	<Persistent("d_waktustopline")> Property JamOff As Integer
  '		Get
  '			Return _waktustop
  '		End Get
  '		Set(value As Integer)
  '			SetPropertyValue(Of Integer)("JamOff", _waktustop, value)
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

  '	<PersistentAlias("GetYear(Tanggal)")> Public ReadOnly Property Tahun As Integer
  '		Get
  '			Return CInt(EvaluateAlias("Tahun"))
  '		End Get
  '	End Property
  '	<PersistentAlias("concat(GetYear(Tanggal),'-',GetMonth(Tanggal),'-01')")> Public ReadOnly Property Bulan As Date
  '		Get
  '			Return Convert.ToDateTime(EvaluateAlias("Bulan"))
  '		End Get
  '	End Property

  '	Private Function CheckData() As Boolean
  '		Dim source As String = "Order Produksi - Daily Process"
  '		If IsDeleted Then
  '			Return True
  '		End If
  '		If _main Is Nothing AndAlso Not IsDeleted Then
  '			Throw New Utils.Exception("Masukkan dempyou", -1, "", source)
  '			Return False
  '		End If
  '		If _tanggal = Nothing AndAlso Not IsDeleted Then
  '			Throw New Utils.Exception("Masukkan tanggal", -2, "", source)
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
  <Persistent("m04ddailyprocess")> Friend Class Fusoh_DailyProcess
		Inherits NPOBase

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _id As Long
		Private _cuttingWIP As Fusoh_StokMain
		Private _tanggal As Date
		Private _mesin As Fusoh_Mesin
		Private _shift As Integer
		Private _jamkerja As Integer
		Private _processCutting As Fusoh_ProcessCutting
		Private _qtyCutting As Integer
		Private _qtyFG As Integer
		Private _qtyNG As Integer
		Private _qtyOP1 As Integer
		Private _qtyOP2 As Integer
		Private _qtyOP3 As Integer
		Private _qtyOP4 As Integer
		Private _qtyOP5 As Integer
		Private _qtyFinishGood As Integer
		Private _waktuStopLine As Integer
		Private _keterangan As String
		Private _produksi As Fusoh_StokMain

		<Key(True)> Property Id As Long
			Get
				Return _id
			End Get
			Set(value As Long)
				SetPropertyValue(Of Long)("Id", _id, value)
			End Set
		End Property
		<Association("fk_04ddailyprocess_cuttingwip")> Property CuttingWIP As Fusoh_StokMain
			Get
				Return _cuttingWIP
			End Get
			Set(value As Fusoh_StokMain)
				SetPropertyValue(Of Fusoh_StokMain)("CuttingWIP", _cuttingWIP, value)
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
		Property Mesin As Fusoh_Mesin
			Get
				Return _mesin
			End Get
			Set(value As Fusoh_Mesin)
				SetPropertyValue(Of Fusoh_Mesin)("Mesin", _mesin, value)
			End Set
		End Property
		Property Shift As Integer
			Get
				Return _shift
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)("Shift", _shift, value)
			End Set
		End Property
		Property JamKerja As Integer
			Get
				Return _jamkerja
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)("JamKerja", _jamkerja, value)
			End Set
		End Property
		Property ProcessCutting As Fusoh_ProcessCutting
			Get
				Return _processCutting
			End Get
			Set(value As Fusoh_ProcessCutting)
				SetPropertyValue(Of Fusoh_ProcessCutting)("ProcessCutting", _processCutting, value)
			End Set
		End Property
		Property QtyCutting As Integer
			Get
				Return _qtyCutting
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)("QtyCutting", _qtyCutting, value)
			End Set
		End Property
		Property QtyFG As Integer
			Get
				Return _qtyFG
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)("QtyFG", _qtyFG, value)
			End Set
		End Property
		Property QtyNG As Integer
			Get
				Return _qtyNG
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)("QtyNG", _qtyNG, value)
			End Set
		End Property
		Property QtyOP1 As Integer
			Get
				Return _qtyOP1
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)("QtyOP1", _qtyOP1, value)
			End Set
		End Property
		Property QtyOP2 As Integer
			Get
				Return _qtyOP2
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)("QtyOP2", _qtyOP2, value)
			End Set
		End Property
		Property QtyOP3 As Integer
			Get
				Return _qtyOP3
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)("QtyOP3", _qtyOP3, value)
			End Set
		End Property
		Property QtyOP4 As Integer
			Get
				Return _qtyOP4
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)("QtyOP4", _qtyOP4, value)
			End Set
		End Property
		Property QtyOP5 As Integer
			Get
				Return _qtyOP5
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)("QtyOP5", _qtyOP5, value)
			End Set
		End Property
		Property QtyFinishGood As Integer
			Get
				Return _qtyFinishGood
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)("QtyFinishGood", _qtyFinishGood, value)
			End Set
		End Property
		Property WaktuStopLine As Integer
			Get
				Return _waktuStopLine
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)("WaktuStopLine", _waktuStopLine, value)
			End Set
		End Property
		Property Keterangan As String
			Get
				Return _keterangan
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Keterangan", _keterangan, value)
			End Set
		End Property
		<Association("fk_04ddailyprocess_produksi")> Property Produksi As Fusoh_StokMain
			Get
				Return _produksi
			End Get
			Set(value As Fusoh_StokMain)
				SetPropertyValue(Of Fusoh_StokMain)("Produksi", _produksi, value)
			End Set
		End Property

    <PersistentAlias("CuttingWIP.Kode"), NUnique(NUniqueAttribute.JenisAttr.LogKode)> ReadOnly Property UniqueData As String
      Get
        Return Convert.ToString(EvaluateAlias("UniqueData"))
      End Get
    End Property
    <PersistentAlias("CuttingWIP.Id"), NUnique(NUniqueAttribute.JenisAttr.LogId)> ReadOnly Property UniqueId As String
      Get
        Return Convert.ToString(EvaluateAlias("UniqueId"))
      End Get
    End Property

    <PersistentAlias("GetYear(Tanggal)")> ReadOnly Property Tahun As Integer
			Get
				Return Convert.ToInt32(EvaluateAlias("Tahun"))
			End Get
		End Property
		<PersistentAlias("concat(GetYear(Tanggal),'-',GetMonth(Tanggal),'-01')")> ReadOnly Property Bulan As Date
			Get
				Return Convert.ToDateTime(EvaluateAlias("Bulan"))
			End Get
		End Property
	End Class

	Friend Class DempyouPOLine
		Property This As DempyouPOLine
		Property KodeBarang As String
		Property NamaBarang As String
		Property POLine As String
		Property NoPODetail As String
		Property OutDiameter As Double
		Property InDiameter As Double
		Property Thickness As Double
		Property Length As Double
		Property Qty As Double
		Property SODetail As Fusoh_OrderPenjualanDetail
		'Barang.Kode;Barang.Nama;POLine;OutDiameter;InDiameter;Thickness;Length;This;Qty
		Property LengthCutting As Double
		Property MaterialProses As Fusoh_ProcessCutting 'Fusoh_MaterialProses
	End Class

	<Persistent("m04cstockmain")> Public Class Fusoh_Produksi
		Inherits TransactionMain

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _pelanggan As NuSoft001.Persistent.Kontak
		Private _gudang As Gudang
		Private _uraian As String
		Private _status As NuSoft001.Persistent.StatusTransaksiEnum
		Private _kontakperson As String
		Private _karyawan As NuSoft001.Persistent.Kontak
		Private _gudang2 As Gudang
		Private _orderProduksi As Fusoh_OrderProduksi
		Private _so As Fusoh_OrderPenjualan
		Private _dempyouLot As String
		Private _kurs As Double
		Private _cuttingWIP As Fusoh_Produksi

		<Persistent("f_contact")> Property Pelanggan As NuSoft001.Persistent.Kontak
			Get
				Return _pelanggan
			End Get
			Set(value As NuSoft001.Persistent.Kontak)
				SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Pelanggan", _pelanggan, value)
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
		<Persistent("d_remarks")> Property Catatan As String
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
		<Persistent("d_person")> Property KontakPerson As String
			Get
				Return _kontakperson
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("KontakPerson", _kontakperson, value)
			End Set
		End Property
		<Persistent("f_employee")> Property Karyawan As NuSoft001.Persistent.Kontak
			Get
				Return _karyawan
			End Get
			Set(value As NuSoft001.Persistent.Kontak)
				SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _karyawan, value)
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
		<Persistent("f_warehouse2")> Property Gudang2 As Gudang
			Get
				Return _gudang2
			End Get
			Set(value As Gudang)
				SetPropertyValue(Of Gudang)("Gudang2", _gudang2, value)
			End Set
		End Property
		<Persistent("f_iddempyou"), Association("fk_orderproduksi_produksi")> Property OrderProduksi As Fusoh_OrderProduksi
			Get
				Return _orderProduksi
			End Get
			Set(value As Fusoh_OrderProduksi)
				SetPropertyValue(Of Fusoh_OrderProduksi)("OrderProduksi", _orderProduksi, value)
			End Set
		End Property

		<Association("fk_fusoh_produksi_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_ProduksiDetail)
			Get
				Return GetCollection(Of Fusoh_ProduksiDetail)("Detail")
			End Get
		End Property

		<PersistentAlias("Detail.Sum(QtyIN)")> ReadOnly Property TotalQty As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("TotalQty"))
			End Get
		End Property
		<PersistentAlias("Detail.Sum(QtyOut)")> ReadOnly Property TotalQtyOut As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("TotalQtyOut"))
			End Get
		End Property

		<NonPersistent()> ReadOnly Property QtyProduksi As Double
			Get
				If Sumber.Id = Persistent.SumberDataJenis.AM Then
					Return Detail.Sum(Function(f) f.QtyIN)
				Else
					Return 0
				End If
			End Get
		End Property
		<NonPersistent()> ReadOnly Property QtyCutting As Double
			Get
				If Sumber.Id = Persistent.SumberDataJenis.CW Then
					Return Detail.Sum(Function(f) f.QtyIN)
				Else
					Return 0
				End If
			End Get
		End Property

		'====tambahan
		<Persistent("f_idcuttingwip")> Property CuttingWIP As Fusoh_Produksi
			Get
				Return _cuttingWIP
			End Get
			Set(value As Fusoh_Produksi)
				SetPropertyValue(Of Fusoh_Produksi)("CuttingWIP", _cuttingWIP, value)
			End Set
		End Property


		Private Function CheckData() As Boolean
			Dim source As String = "Produksi [AM]"
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
			If Pelanggan Is Nothing AndAlso Sumber.Id <> SumberDataJenis.BS Then
				Throw New Utils.Exception("Masukkan pelangan", -3, "", source)
				Return False
			End If
			If Gudang Is Nothing Then
				Throw New Utils.Exception("Masukkan gudang", -4, "", source)
				Return False
			End If
			If OrderProduksi Is Nothing AndAlso Sumber.Id = SumberDataJenis.AM Then
				Throw New Utils.Exception("Masukkan order produksi", -5, "", source)
				Return False
			End If
			'======= Cek Periode
			If NuSoft001.Persistent.Periode.CheckLockedPeriod(Session, Tanggal) Then
				Throw New Utils.Exception("Periode sudah ditutup", -4, "Hubungi accounting untuk membuka periode", source)
				Return False
			End If
			'======= Cek Sebelum Awal Periode
			If NuSoft001.Persistent.Periode.CheckBeforeBeginningPeriod(Session, Tanggal) Then
				Throw New Utils.Exception("Tanggal transaksi sebelum awal periode", -4, "Silahkan ganti tanggal transaksi", source)
				Return False
			End If

			If Session.IsNewObject(Me) Then
				If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
					Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -6, "", source)
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
  <Persistent("m04dstockdetail")> Public Class Fusoh_ProduksiDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_Produksi
    Private _item As NuSoft004.Persistent.Fusoh_Barang
    Private _gudang As NuSoft004.Persistent.Gudang
    Private _satuan As NuSoft004.Persistent.Satuan
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

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_fusoh_produksi_detail")> Property Main As Fusoh_Produksi
      Get
        Return _main
      End Get
      Set(value As Fusoh_Produksi)
        SetPropertyValue(Of Fusoh_Produksi)("Main", _main, value)
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
  End Class

	<Persistent("m04vwstocktacking")> Friend Class FusohVwStockTacking
		Inherits XPLiteObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub
		<Key()> Property Id As Int64
		Property NoDempyou As String
		Property Tanggal As Date
		Property Pelanggan As NuSoft001.Persistent.Kontak
		Property NoLOT As String
		Property Qty As Double
		Property Barang As Persistent.Fusoh_Barang
		Property QtyCutting As Double
		Property QtyOP1 As Double
		Property QtyOP2 As Double
		Property QtyOP3 As Double
		Property QtyOP4 As Double
		Property QtyOP5 As Double
		Property QtyFG As Double
	End Class

	Public Class FusohStokTakingNonPersistent
		Property Dempyou As Fusoh_OrderProduksi
		Property TanggalWIP As Date
		Property QtyWIP As Double
		Property QtyCutting As Double
		Property QtyOP1 As Double?
		Property QtyOP2 As Double?
		Property QtyOP3 As Double?
		Property QtyOP4 As Double?
		Property QtyOP5 As Double?
		Property QtyFinishGood As Double
		Property QtyDelivery As Double
	End Class
	Public Class FusohProductionPlanNonPersistent
		Property Dempyou As Fusoh_OrderProduksi
		Property MaterialSize As String
		Property Machine As Fusoh_Mesin
		Property QtyCutting As Double
		Property QtyKampuh As Double
		Property QtyDrill As Double?
		Property QtyFinishGoods As Double
		Property QtyDelivery As Double
    Property QtyAdjust As Double
    Property KetAdjust As String

    ReadOnly Property IsFinish As Boolean
			Get
        If (QtyDelivery + QtyAdjust) >= Dempyou.Qty Then
          Return True
        Else
          Return False
				End If
			End Get
		End Property
		ReadOnly Property Status As String
			Get
				If IsFinish Then
					Return "Selesai"
				Else
					Return "Belum Selesai"
				End If
			End Get
		End Property
	End Class
End Namespace