Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports NuSoft.Utils.CustomAttribute
Namespace Fusoh_Logic
  Friend Class Umum
    Public Const ImportDutyCustom As String = "ImportDuty"
    'Shared Sub xHistoryData(xForm As Object, xSession As DevExpress.Xpo.UnitOfWork, Tipe As UI_FusohCekData.TipeTransaksi, xNoBukti As String)
    '  Dim xHistory As New UI_FusohCekData(UI_FusohCekData.TipeForm.Dialog)
    '  xHistory.session = xSession
    '  xHistory.MenuId = xForm.MenuId
    '  xHistory.NamaDatabase = xForm.NamaDatabase
    '  xHistory.txtTipe.EditValue = Tipe
    '  xHistory.txtNoTransaksi.EditValue = xNoBukti
    '  xHistory.btnCari_Click(xHistory.btnCari, Nothing)
    '  xHistory.ShowDialog()
    'End Sub
  End Class
End Namespace

Namespace Persistent
  <Persistent("m05atermin")>
  Friend Class Termin
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _kode As String
    Private _tempo As Int16
    Private _discount As Int16
    Private _discountp As Double
    Private _penalties As Int16
    Private _penaltiesp As Double

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
    <Persistent("d_tempo")> Property Tempo As Int16
      Get
        Return _tempo
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("Tempo", _tempo, value)
      End Set
    End Property
    <Persistent("d_discount")> Property DiscDay As Int16
      Get
        Return _discount
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("DiscDay", _discount, value)
      End Set
    End Property
    <Persistent("d_discountp")> Property DiscPersen As Double
      Get
        Return _discountp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DiscPersen", _discountp, value)
      End Set
    End Property
    <Persistent("d_penalties")> Property PenaltiesDay As Int16
      Get
        Return _penalties
      End Get
      Set(value As Int16)
        SetPropertyValue(Of Int16)("PenaltiesDay", _penalties, value)
      End Set
    End Property
    <Persistent("d_penaltiesp")> Property PenaltiesPersen As Double
      Get
        Return _discountp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("PenaltiesPersen", _discountp, value)
      End Set
    End Property
  End Class
  '<Persistent("m05avia")>
  'Public Class Via
  '	Inherits NPOBase
  '	Public Sub New(ByVal session As UnitOfWork)
  '		MyBase.New(session)
  '	End Sub
  '	Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
  '		MyBase.New(session, classInfo)
  '	End Sub
  '	<Indexed("Kode", Unique:=True)>
  '	Private _id As Int32
  '	Private _kode As String
  '	<Persistent("p_id"), Key(True)> Property Id As Int32
  '		Get
  '			Return _id
  '		End Get
  '		Set(value As Int32)
  '			SetPropertyValue(Of Int32)("Id", _id, value)
  '		End Set
  '	End Property
  '	<Persistent("u_code"), Size(25)> Property Kode As String
  '		Get
  '			Return _kode
  '		End Get
  '		Set(value As String)
  '			SetPropertyValue(Of String)("Kode", _kode, value)
  '		End Set
  '	End Property
  'End Class

  ''======= ENUM
  'Public Enum eTipeFOB
  '	<EnumDescription("Origin")> Origin
  '	<EnumDescription("Destination")> Destination
  'End Enum
  Friend Enum eTipePajak
    <EnumDescription("Tanpa Pajak")> TanpaPajak
    <EnumDescription("Harga Belum Termasuk Pajak")> HargaBelumTermasuk
    <EnumDescription("Harga Sudah Termasuk Pajak")> HargaSudahTermasuk
  End Enum
  'Public Enum eJenisPajak
  '	<EnumDescription("Harga Jual")> HargaJual
  '	<EnumDescription("Penggantian")> Penggantian
  '	<EnumDescription("Harga Jual Dan Penggantian")> HargaJualPenggantian
  '	<EnumDescription("Uang Muka")> UangMuka
  '	<EnumDescription("Termin")> Termin
  'End Enum
  'Public Enum eTipeInvoicePembelian
  '	<EnumDescription("Pakai PO")> PakaiPO
  '	<EnumDescription("Tanpa PO")> TanpaPO
  'End Enum
  'Public Enum eTipeHutangInvoice
  '	<EnumDescription("Mata Uang")> Uang = 0
  '	<EnumDescription("Regional")> Regional = 1
  '	<EnumDescription("Kontak")> Kontak = 2
  '	<EnumDescription("Manual")> Manual = 3
  'End Enum

  '<Persistent("m04cstockmain")> Friend Class Fusoh_PenerimaanBarang
  '	Inherits TransactionMain

  '	Public Sub New(ByVal session As UnitOfWork)
  '		MyBase.New(session)
  '	End Sub
  '	Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
  '		MyBase.New(session, classInfo)
  '	End Sub

  '	Private _vendor As NuSoft001.Persistent.Kontak
  '	Private _gudang As NuSoft004.Persistent.Gudang
  '	Private _uraian As String
  '	Private _status As NuSoft001.Persistent.StatusTransaksiEnum
  '	Private _kontakperson As String
  '	Private _bagpembelian As NuSoft001.Persistent.Kontak
  '	Private _divisi As NPO.Modules.ModSys.Divisi
  '	Private _gudang2 As NuSoft004.Persistent.Gudang
  '	'Private _idExim As Fusoh_Exim
  '	Private _uang As NuSoft001.Persistent.MataUang
  '	Private _kurs As Double
  '	Private _gl As GlMain

  '	<Persistent("f_contact")> Property Vendor As NuSoft001.Persistent.Kontak
  '		Get
  '			Return _vendor
  '		End Get
  '		Set(value As NuSoft001.Persistent.Kontak)
  '			SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Vendor", _vendor, value)
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
  '	<Persistent("d_remarks")> Property Uraian As String
  '		Get
  '			Return _uraian
  '		End Get
  '		Set(value As String)
  '			SetPropertyValue(Of String)("Uraian", _uraian, value)
  '		End Set
  '	End Property
  '	<Persistent("d_status")> Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
  '		Get
  '			Return _status
  '		End Get
  '		Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
  '			SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
  '		End Set
  '	End Property
  '	<Persistent("d_person")> Property KontakPerson As String
  '		Get
  '			Return _kontakperson
  '		End Get
  '		Set(value As String)
  '			SetPropertyValue(Of String)("KontakPerson", _kontakperson, value)
  '		End Set
  '	End Property
  '	<Persistent("f_employee")> Property Karyawan As NuSoft001.Persistent.Kontak
  '		Get
  '			Return _bagpembelian
  '		End Get
  '		Set(value As NuSoft001.Persistent.Kontak)
  '			SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _bagpembelian, value)
  '		End Set
  '	End Property
  '	<Persistent("f_divisi")> Property Divisi As NPO.Modules.ModSys.Divisi
  '		Get
  '			Return _divisi
  '		End Get
  '		Set(value As NPO.Modules.ModSys.Divisi)
  '			SetPropertyValue(Of NPO.Modules.ModSys.Divisi)("Catatan", _divisi, value)
  '		End Set
  '	End Property
  '	<Persistent("f_warehouse2")> Property Gudang2 As NuSoft004.Persistent.Gudang
  '		Get
  '			Return _gudang2
  '		End Get
  '		Set(value As NuSoft004.Persistent.Gudang)
  '			SetPropertyValue(Of NuSoft004.Persistent.Gudang)("Gudang2", _gudang2, value)
  '		End Set
  '	End Property
  '	'<Persistent("f_ideximm")> Property Exim As Fusoh_Exim
  '	'	Get
  '	'		Return _idExim
  '	'	End Get
  '	'	Set(value As Fusoh_Exim)
  '	'		SetPropertyValue(Of Fusoh_Exim)("Exim", _idExim, value)
  '	'	End Set
  '	'End Property
  '	<Persistent("f_currency")> Property MataUang As NuSoft001.Persistent.MataUang
  '		Get
  '			Return _uang
  '		End Get
  '		Set(value As NuSoft001.Persistent.MataUang)
  '			SetPropertyValue(Of NuSoft001.Persistent.MataUang)("MataUang", _uang, value)
  '		End Set
  '	End Property
  '	<Persistent("d_kurs")> Property Kurs As Double
  '		Get
  '			Return _kurs
  '		End Get
  '		Set(value As Double)
  '			SetPropertyValue(Of Double)("Kurs", _kurs, value)
  '		End Set
  '	End Property
  '	<Persistent("f_gl")> Property Gl As GlMain
  '		Get
  '			Return _gl
  '		End Get
  '		Set(value As GlMain)
  '			SetPropertyValue(Of GlMain)("Gl", _gl, value)
  '		End Set
  '	End Property

  '	<Association("fk_fusoh_penerimaan_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_PenerimaanBarangDetail)
  '		Get
  '			Return GetCollection(Of Fusoh_PenerimaanBarangDetail)("Detail")
  '		End Get
  '	End Property
  '	<PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
  '		Get
  '			Return Convert.ToDouble(EvaluateAlias("TotalQty"))
  '		End Get
  '	End Property

  '	Private Function CheckData() As Boolean
  '		Dim source As String = "Penerimaan Barang [GR]"
  '		If IsDeleted Then
  '			Return True
  '		End If
  '		If Regional Is Nothing Then
  '			Throw New Utils.Exception("Masukkan regional", -1, "", source)
  '			Return False
  '		End If
  '		If Tanggal = Nothing Then
  '			Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
  '			Return False
  '		End If
  '		If Vendor Is Nothing Then
  '			Throw New Utils.Exception("Masukkan Vendor", -4, "", source)
  '			Return False
  '		End If
  '		If Gudang Is Nothing Then
  '			Throw New Utils.Exception("Masukkan gudang", -5, "", source)
  '			Return False
  '		End If
  '		If Karyawan Is Nothing Then
  '			Throw New Utils.Exception("Masukkan karyawan penerima barang", -6, "", source)
  '			Return False
  '		End If
  '		If Detail.Sum(Function(m) m.Qty) = 0 Then
  '			Throw New Utils.Exception("Masukkan nilai qty", -99, "", source)
  '		End If
  '		If Session.IsNewObject(Me) Then
  '			If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
  '				Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -7, "", source)
  '				Return False
  '			End If
  '		End If
  '		Return True
  '	End Function
  '	Protected Overrides Sub OnSaving()
  '		For i = 0 To Detail.Count - 1
  '			Detail(i).Gudang = _gudang
  '		Next
  '		If Not CheckData() Then
  '			Return
  '		End If
  '		If Kode = Nothing Then
  '			Kode = Number.GetNewNumber.Kode
  '		End If
  '		MyBase.OnSaving()
  '	End Sub
  'End Class
  '<Persistent("m04dstockdetail")> Friend Class Fusoh_PenerimaanBarangDetail
  '	Inherits NPOBase

  '	Public Sub New(ByVal session As UnitOfWork)
  '		MyBase.New(session)
  '	End Sub
  '	Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
  '		MyBase.New(session, classInfo)
  '	End Sub

  '	Private _id As Int64
  '	Private _main As Fusoh_PenerimaanBarang
  '	Private _item As NuSoft004.Persistent.Barang
  '	Private _gudang As NuSoft004.Persistent.Gudang
  '	Private _catatan As String
  '	Private _satuan As NuSoft004.Persistent.Satuan
  '	Private _qty As Double
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
  '	<Persistent("p_id"), Association("fk_fusoh_penerimaan_detail")> Property Main As Fusoh_PenerimaanBarang
  '		Get
  '			Return _main
  '		End Get
  '		Set(value As Fusoh_PenerimaanBarang)
  '			SetPropertyValue(Of Fusoh_PenerimaanBarang)("Main", _main, value)
  '		End Set
  '	End Property
  '	<Persistent("f_item")> Property Barang As NuSoft004.Persistent.Barang
  '		Get
  '			Return _item
  '		End Get
  '		Set(value As NuSoft004.Persistent.Barang)
  '			SetPropertyValue(Of NuSoft004.Persistent.Barang)("Barang", _item, value)
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
  '	<Persistent("d_qtyin")> Property Qty As Double
  '		Get
  '			Return _qty
  '		End Get
  '		Set(value As Double)
  '			SetPropertyValue(Of Double)("Qty", _qty, value)
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
  '	'	Get
  '	'		Return _eximDetail
  '	'	End Get
  '	'	Set(value As Fusoh_EximDetail)
  '	'		SetPropertyValue(Of Fusoh_EximDetail)("EximDetail", _eximDetail, value)
  '	'	End Set
  '	'End Property

  '	<Association("fk_fusoh_penerimaan_detail_serial"), Aggregated> ReadOnly Property DetailSerial As XPCollection(Of Fusoh_PenerimaanBarangDetailSerial)
  '		Get
  '			Return GetCollection(Of Fusoh_PenerimaanBarangDetailSerial)("DetailSerial")
  '		End Get
  '	End Property

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
  '		If _qty = Nothing AndAlso Not IsDeleted Then
  '			Throw New Utils.Exception("Masukkan qty", -99, "", source)
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
  '<Persistent("m04estockdetailserial")> Public Class Fusoh_PenerimaanBarangDetailSerial
  '	Inherits NPOBase

  '	Public Sub New(ByVal session As UnitOfWork)
  '		MyBase.New(session)
  '	End Sub
  '	Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
  '		MyBase.New(session, classInfo)
  '	End Sub

  '	Private _id As Int64
  '	Private _detail As Fusoh_PenerimaanBarangDetail
  '	Private _serial As String
  '	Private _millSheet As String
  '	Private _length As Double

  '	<Persistent("primary_main"), Key(True)> Property Id As Int64
  '		Get
  '			Return _id
  '		End Get
  '		Set(value As Int64)
  '			SetPropertyValue(Of Int64)("Id", _id, value)
  '		End Set
  '	End Property
  '	<Persistent("p_id"), Association("fk_fusoh_penerimaan_detail_serial")> Property DetailMain As Fusoh_PenerimaanBarangDetail
  '		Get
  '			Return _detail
  '		End Get
  '		Set(value As Fusoh_PenerimaanBarangDetail)
  '			SetPropertyValue(Of Fusoh_PenerimaanBarangDetail)("DetailMain", _detail, value)
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
  '			Return _length
  '		End Get
  '		Set(value As Double)
  '			SetPropertyValue(Of Double)("Length", _length, value)
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

  Friend Enum eTipeFOB
    <EnumDescription("Origin")> Origin
    <EnumDescription("Destination")> Destination
  End Enum
  Friend Enum eJenisPajak
    <EnumDescription("Harga Jual")> HargaJual
    <EnumDescription("Penggantian")> Penggantian
    <EnumDescription("Harga Jual Dan Penggantian")> HargaJualPenggantian
    <EnumDescription("Uang Muka")> UangMuka
    <EnumDescription("Termin")> Termin
  End Enum
  Friend Enum eTipeInvoicePembelian
    <EnumDescription("Pakai PO")> PakaiPO
    <EnumDescription("Tanpa PO")> TanpaPO
  End Enum
  Friend Enum eTipeHutangInvoice
    <EnumDescription("Mata Uang")> Uang = 0
    <EnumDescription("Regional")> Regional = 1
    <EnumDescription("Kontak")> Kontak = 2
    <EnumDescription("Manual")> Manual = 3
  End Enum

  <Persistent("m05cmainorder")>
  Friend Class Fusoh_OrderPembelian
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _tipe As NuSoft004.Persistent.TipeTransaksi
    'Private _nopenawaran As Penawaran
    'Private _nopermintaan As PermintaanStock
    Private _vendor As NuSoft001.Persistent.Kontak
    Private _kontakperson As String
    Private _kontakalamat As NuSoft001.Persistent.KontakAlamat
    Private _alamat As String
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _fob As eTipeFOB
    Private _leadtime As String
    Private _termin As Termin
    'Private _via As Via
    Private _tglberlaku As Date
    Private _pajak As eTipePajak
    Private _catatan As String
    Private _bagpembelian As NuSoft001.Persistent.Kontak
    Private _gudang As NuSoft004.Persistent.Gudang
    Private _disc As Double
    Private _othercost As Double
    Private _uraian As String
    Private _reffnumber As String
    Private _custom1 As String
    Private _custom2 As String
    Private _custom3 As String
    Private _custom4 As String
    Private _custom5 As String
    Private _custom6 As String
    Private _custom7 As String
    Private _custom8 As String
    Private _custom9 As String
    Private _custom10 As String
    Private _dariDomestik As Boolean

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
    Property Tipe As NuSoft004.Persistent.TipeTransaksi
      Get
        Return _tipe
      End Get
      Set(value As NuSoft004.Persistent.TipeTransaksi)
        SetPropertyValue(Of NuSoft004.Persistent.TipeTransaksi)("Tipe", _tipe, value)
      End Set
    End Property
    <Persistent("f_vendor")>
    Property Vendor As NuSoft001.Persistent.Kontak
      Get
        Return _vendor
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Vendor", _vendor, value)
      End Set
    End Property
    <Persistent("d_contact")>
    Property KontakPerson As String
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
        SetPropertyValue(Of NuSoft001.Persistent.KontakAlamat)("Alamat", _kontakalamat, value)
      End Set
    End Property
    <Persistent("d_address")> Property Alamat As String
      Get
        Return _alamat
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Alamat", _alamat, value)
      End Set
    End Property
    <Persistent("f_currency")>
    Property Uang As NuSoft001.Persistent.MataUang
      Get
        Return _uang
      End Get
      Set(value As NuSoft001.Persistent.MataUang)
        SetPropertyValue(Of NuSoft001.Persistent.MataUang)("Uang", _uang, value)
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
    <Persistent("d_fob")>
    Property FOB As eTipeFOB
      Get
        Return _fob
      End Get
      Set(value As eTipeFOB)
        SetPropertyValue(Of eTipeFOB)("FOB", _fob, value)
      End Set
    End Property
    <Persistent("d_leadtime")>
    Property LeadTime As String
      Get
        Return _leadtime
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("LeadTime", _leadtime, value)
      End Set
    End Property
    <Persistent("f_termin")>
    Property Termin As Persistent.Termin
      Get
        Return _termin
      End Get
      Set(value As Persistent.Termin)
        SetPropertyValue(Of Persistent.Termin)("Termin", _termin, value)
      End Set
    End Property
    '<Persistent("f_via")>
    'Property Via As Persistent.Via
    '	Get
    '		Return _via
    '	End Get
    '	Set(value As Persistent.Via)
    '		SetPropertyValue(Of Persistent.Via)("Via", _via, value)
    '	End Set
    'End Property
    <Persistent("d_efectivedate")>
    Property TanggalBerlaku As Date
      Get
        Return _tglberlaku
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalBerlaku", _tglberlaku, value)
      End Set
    End Property
    <Persistent("d_taxtype")>
    Property TipePajak As eTipePajak
      Get
        Return _pajak
      End Get
      Set(value As eTipePajak)
        SetPropertyValue(Of eTipePajak)("Pajak", _pajak, value)
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
    <Persistent("f_employee")>
    Property Karyawan As NuSoft001.Persistent.Kontak
      Get
        Return _bagpembelian
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _bagpembelian, value)
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
    <Persistent("d_disc")>
    Property Discount As Double
      Get
        Return _disc
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Discount", _disc, value)
      End Set
    End Property
    <Persistent("d_othercost")>
    Property BiayaLain As Double
      Get
        Return _othercost
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BiayaLain", _othercost, value)
      End Set
    End Property
    <Persistent("d_description")>
    Property Uraian As String
      Get
        Return _uraian
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Uraian", _uraian, value)
      End Set
    End Property
    <Persistent("d_reffnumber")>
    Property ReffNo As String
      Get
        Return _reffnumber
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("ReffNo", _reffnumber, value)
      End Set
    End Property
    <Persistent("d_custom1")>
    Property Custom1 As String
      Get
        Return _custom1
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom1", _custom1, value)
      End Set
    End Property
    <Persistent("d_custom2")>
    Property Custom2 As String
      Get
        Return _custom2
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom2", _custom2, value)
      End Set
    End Property
    <Persistent("d_custom3")>
    Property Custom3 As String
      Get
        Return _custom3
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom3", _custom3, value)
      End Set
    End Property
    <Persistent("d_custom4")>
    Property Custom4 As String
      Get
        Return _custom4
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom4", _custom4, value)
      End Set
    End Property
    <Persistent("d_custom5")>
    Property Custom5 As String
      Get
        Return _custom5
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom5", _custom5, value)
      End Set
    End Property
    <Persistent("d_custom6")>
    Property Custom6 As String
      Get
        Return _custom6
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom6", _custom6, value)
      End Set
    End Property
    <Persistent("d_custom7")>
    Property Custom7 As String
      Get
        Return _custom7
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom7", _custom7, value)
      End Set
    End Property
    <Persistent("d_custom8")>
    Property Custom8 As String
      Get
        Return _custom8
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom8", _custom8, value)
      End Set
    End Property
    <Persistent("d_custom9")>
    Property Custom9 As String
      Get
        Return _custom9
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom9", _custom9, value)
      End Set
    End Property
    <Persistent("d_custom10")>
    Property Custom10 As String
      Get
        Return _custom10
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Custom10", _custom10, value)
      End Set
    End Property
    <Persistent("d_fromdomestic")> Property DariDomestik As Boolean
      Get
        Return _dariDomestik
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("DariDomestik", _dariDomestik, value)
      End Set
    End Property

    '<Persistent("d_remarksapp")>
    'Property CatatanApprove As String
    '	Get
    '		Return _catatanapp
    '	End Get
    '	Set(value As String)
    '		SetPropertyValue(Of String)("CatatanApprove", _catatanapp, value)
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

    <Association("fusoh_fk_order_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_OrderPembelianDetail)
      Get
        Return GetCollection(Of Fusoh_OrderPembelianDetail)("Detail")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQty"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(DPP)")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(PPNv)")> ReadOnly Property PPN As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPN"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(PPHv)")> ReadOnly Property PPH As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPH"))
      End Get
    End Property
    <PersistentAlias("(SubTotal + PPN - PPH)")> ReadOnly Property Total As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
    End Property
    <NonPersistent()> ReadOnly Property Terbilang As String
      Get
        Return Utils.Common.Character.Terbilang(Total)
      End Get
    End Property
    '<PersistentAlias("Terbilang(Total)")> ReadOnly Property Terbilang As String
    '  Get
    '    Return Convert.ToString(EvaluateAlias("Terbilang"))
    '  End Get
    'End Property
    '<PersistentAlias("TerbilangEnglish(Total)")> ReadOnly Property TerbilangEnglish As String
    '  Get
    '    Return Convert.ToString(EvaluateAlias("TerbilangEnglish"))
    '  End Get
    'End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Order Pembelian [PO]"
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
      If Uang Is Nothing Then
        Throw New Utils.Exception("Masukkan mata uang", -6, "", source)
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
      If Not CheckData() Then
        Return
      End If
      If Kode = Nothing Then
        Kode = Number.GetNewNumber.Kode
      End If
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m05ddetailorder")>
  Friend Class Fusoh_OrderPembelianDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_OrderPembelian
    Private _item As NuSoft004.Persistent.Fusoh_Barang
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _qty As Double
    Private _outDiameter As Decimal
    Private _inDiameter As Decimal
    Private _thickness As Decimal
    Private _length As Decimal
    Private _weight As Decimal
    Private _harga As Double
    Private _ppn As NuSoft004.Persistent.Pajak
    Private _ppnp As Double
    Private _pph As NuSoft004.Persistent.Pajak
    Private _pphp As Double
    Private _catatan As String
    'Private _kuotaImpor As Fusoh_KuotaImpor

    <Persistent("primary_main"), Key(True)>
    Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fusoh_fk_order_detail")>
    Property Main As Fusoh_OrderPembelian
      Get
        Return _main
      End Get
      Set(value As Fusoh_OrderPembelian)
        SetPropertyValue(Of Fusoh_OrderPembelian)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_item")>
    Property Barang As NuSoft004.Persistent.Fusoh_Barang
      Get
        Return _item
      End Get
      Set(value As NuSoft004.Persistent.Fusoh_Barang)
        SetPropertyValue(Of NuSoft004.Persistent.Fusoh_Barang)("Barang", _item, value)
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
    <Persistent("d_qty")>
    Property Qty As Double
      Get
        Return _qty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _qty, value)
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
    <Persistent("d_price")>
    Property Harga As Double
      Get
        Return _harga
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Harga", _harga, value)
      End Set
    End Property
    <Persistent("f_taxin")>
    Property PPN As NuSoft004.Persistent.Pajak
      Get
        Return _ppn
      End Get
      Set(value As NuSoft004.Persistent.Pajak)
        SetPropertyValue(Of NuSoft004.Persistent.Pajak)("PPN", _ppn, value)
      End Set
    End Property
    <Persistent("d_taxinp")>
    Property PPNp As Double
      Get
        Return _ppnp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("PPNp", _ppnp, value)
      End Set
    End Property
    <Persistent("f_taxout")>
    Property PPH As NuSoft004.Persistent.Pajak
      Get
        Return _pph
      End Get
      Set(value As NuSoft004.Persistent.Pajak)
        SetPropertyValue(Of NuSoft004.Persistent.Pajak)("PPN", _pph, value)
      End Set
    End Property
    <Persistent("d_taxoutp")>
    Property PPHp As Double
      Get
        Return _pphp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("PPHp", _pphp, value)
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
    '<Persistent("f_kuotaimpor"), Association("fusoh_kuotaimpor_podetail")>
    'Property KuotaImpor As Fusoh_KuotaImpor
    '	Get
    '		Return _kuotaImpor
    '	End Get
    '	Set(value As Fusoh_KuotaImpor)
    '		SetPropertyValue(Of Fusoh_KuotaImpor)("KuotaImpor", _kuotaImpor, value)
    '	End Set
    'End Property

    <PersistentAlias("iif(Main.TipePajak = 0,0,PPNp / 100 * DPP)")> ReadOnly Property PPNv As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPNv"))
      End Get
    End Property
    <PersistentAlias("iif(Main.TipePajak = 0,0,PPHp / 100 * DPP)")> ReadOnly Property PPHv As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPHv"))
      End Get
    End Property
    <PersistentAlias("Qty * Harga")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property

    <PersistentAlias("iif(Main.TipePajak = 1,((SubTotal) + PPNv - PPHv), SubTotal)")> ReadOnly Property Total As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
    End Property
    <PersistentAlias("iif(Main.TipePajak = 2,(SubTotal) - ((PPNp - PPHp) / (100 + (PPNp - PPHp)) * (SubTotal)),SubTotal)")> ReadOnly Property DPP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("DPP"))
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
      Dim source As String = "Order Pembelian [PO]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama order pembelian", -99, "", source)
        Return False
      End If
      If _item Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
        Return False
      End If
      If _qty = Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan qty", -99, "", source)
        Return False
      End If
      'If Not _kuotaImpor Is Nothing Then
      '	If _kuotaImpor.SisaVolume < 0 Then
      '		Throw New Utils.Exception("Sisa volume kuota impor " & _kuotaImpor.KodeHS & " habis.", -99, "", source)
      '		Return False
      '	End If
      'End If
      Return True
    End Function

    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      MyBase.OnSaving()
    End Sub
  End Class

  <Persistent("m05dmainexim")> Friend Class Fusoh_Exim
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _vendor As NuSoft001.Persistent.Kontak
    Private _po As Fusoh_OrderPembelian

    <Persistent("d_status")> Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _status, value)
      End Set
    End Property
    <Persistent("f_vendor")> Property Vendor As NuSoft001.Persistent.Kontak
      Get
        Return _vendor
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Vendor", _vendor, value)
      End Set
    End Property
    <Persistent("f_po")> Property PO As Fusoh_OrderPembelian
      Get
        Return _po
      End Get
      Set(value As Fusoh_OrderPembelian)
        SetPropertyValue(Of Fusoh_OrderPembelian)("PO", _po, value)
      End Set
    End Property

    <Association("fusoh_fk_exim_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_EximDetail)
      Get
        Return GetCollection(Of Fusoh_EximDetail)("Detail")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQty"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Weight)")> ReadOnly Property TotalWeight As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalWeight"))
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Exim [EX]"
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
      If Vendor Is Nothing Then
        Throw New Utils.Exception("Masukkan Vendor", -3, "", source)
        Return False
      End If
      If PO Is Nothing Then
        Throw New Utils.Exception("Masukkan PO", -4, "", source)
        Return False
      End If
      If Session.IsNewObject(Me) Then
        If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
          Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -5, "", source)
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
  <Persistent("m05edetailexim")> Friend Class Fusoh_EximDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_Exim
    Private _poDetail As Fusoh_OrderPembelianDetail
    Private _item As NuSoft004.Persistent.Fusoh_Barang
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _qty As Double
    Private _outDiameter As Decimal
    Private _inDiameter As Decimal
    Private _thickness As Decimal
    Private _length As Decimal
    Private _weight As Decimal
    Private _catatan As String

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fusoh_fk_exim_detail")>
    Property Main As Fusoh_Exim
      Get
        Return _main
      End Get
      Set(value As Fusoh_Exim)
        SetPropertyValue(Of Fusoh_Exim)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_pod")> Property PODetail As Fusoh_OrderPembelianDetail
      Get
        Return _poDetail
      End Get
      Set(value As Fusoh_OrderPembelianDetail)
        SetPropertyValue(Of Fusoh_OrderPembelianDetail)("PODetail", _poDetail, value)
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

    <Association("fusoh_fk_exim_detailserial"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_EximDetailSerial)
      Get
        Return GetCollection(Of Fusoh_EximDetailSerial)("Detail")
      End Get
    End Property
    '<NonPersistent> Property SerialTemp As List(Of Fusoh_EximDetailSerial_Temp)
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
      Dim source As String = "Exim [EX]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama order pembelian", -99, "", source)
        Return False
      End If
      If _poDetail Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan po detail", -99, "", source)
        Return False
      End If
      If _item Is Nothing AndAlso Not IsDeleted Then
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
  <Persistent("m05fdetaileximserial")> Friend Class Fusoh_EximDetailSerial
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_EximDetail
    Private _item As NuSoft004.Persistent.Fusoh_Barang
    Private _serial As String
    Private _millSheet As String
    Private _lengthIn As Decimal

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fusoh_fk_exim_detailserial")> Property Main As Fusoh_EximDetail
      Get
        Return _main
      End Get
      Set(value As Fusoh_EximDetail)
        SetPropertyValue(Of Fusoh_EximDetail)("Main", _main, value)
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
    <Persistent("d_length_in")> Property LengthIn As Decimal
      Get
        Return _lengthIn
      End Get
      Set(value As Decimal)
        SetPropertyValue(Of Decimal)("LengthIn", _lengthIn, value)
      End Set
    End Property

    <PersistentAlias("Main.Main.Kode"), NUnique(NUniqueAttribute.JenisAttr.LogKode)> ReadOnly Property UniqueData As String
      Get
        Return Convert.ToString(EvaluateAlias("UniqueData"))
      End Get
    End Property
    <PersistentAlias("Main.Main.Id"), NUnique(NUniqueAttribute.JenisAttr.LogId)> ReadOnly Property UniqueId As String
      Get
        Return Convert.ToString(EvaluateAlias("UniqueId"))
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Exim [EX]"
      If IsDeleted Then
        Return True
      End If
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama order pembelian", -99, "", source)
        Return False
      End If
      If _item Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan kode barang", -99, "", source)
        Return False
      End If
      If _serial = Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan nomor serial", -99, "", source)
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

  <Persistent("m05cmaininvoicereceipt")> Friend Class Fusoh_PenerimaanInvoice
    Inherits TransactionMain

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _vendor As NuSoft001.Persistent.Kontak
    Private _kontakperson As String
    Private _tipe As eTipeInvoicePembelian
    Private _tglberlaku As Date
    Private _arriveddate As Date
    Private _bldate As Date
    Private _termin As Termin
    Private _uang As NuSoft001.Persistent.MataUang
    Private _kurs As Double
    Private _jenispajak As eJenisPajak
    Private _pajak As eTipePajak
    Private _catatan As String
    Private _status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _karyawan As NuSoft001.Persistent.Kontak
    Private _disc As Double
    Private _othercost As Double
    Private _nosnppn As String
    Private _nosnpph As String
    Private _noorder As Fusoh_OrderPembelian
    Private _noexim As Fusoh_Exim
    Private _noparent As Fusoh_PenerimaanInvoice
    Private _nilaisaldoawal As Double
    Private _noreffvendor As String
    Private _jenisCostSheet As String

    <Persistent("f_vendor")>
    Property Vendor As NuSoft001.Persistent.Kontak
      Get
        Return _vendor
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Vendor", _vendor, value)
      End Set
    End Property
    <Persistent("d_contact")>
    Property KontakPerson As String
      Get
        Return _kontakperson
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("KontakPerson", _kontakperson, value)
      End Set
    End Property
    <Persistent("d_tipe")>
    Property TipeTransaksi As Persistent.eTipeInvoicePembelian
      Get
        Return _tipe
      End Get
      Set(value As Persistent.eTipeInvoicePembelian)
        SetPropertyValue(Of Persistent.eTipeInvoicePembelian)("TipeTransaksi", _tipe, value)
      End Set
    End Property
    <Persistent("d_duedate")>
    Property TanggalBerlaku As Date
      Get
        Return _tglberlaku
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalBerlaku", _tglberlaku, value)
      End Set
    End Property
    <Persistent("d_arriveddate")> Property ArrivedDate As Date
      Get
        Return _arriveddate
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("ArrivedDate", _arriveddate, value)
      End Set
    End Property
    <Persistent("d_bldate")> Property BLDate As Date
      Get
        Return _bldate
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("BLDate", _bldate, value)
      End Set
    End Property
    <Persistent("f_termin")>
    Property Termin As Persistent.Termin
      Get
        Return _termin
      End Get
      Set(value As Persistent.Termin)
        SetPropertyValue(Of Persistent.Termin)("Termin", _termin, value)
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
    <Persistent("f_currency")>
    Property Uang As NuSoft001.Persistent.MataUang
      Get
        Return _uang
      End Get
      Set(value As NuSoft001.Persistent.MataUang)
        SetPropertyValue(Of NuSoft001.Persistent.MataUang)("Uang", _uang, value)
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
    <Persistent("d_taxcaption")>
    Property JenisPajak As eJenisPajak
      Get
        Return _jenispajak
      End Get
      Set(value As eJenisPajak)
        SetPropertyValue(Of eJenisPajak)("JenisPajak", _jenispajak, value)
      End Set
    End Property
    <Persistent("d_taxtype")>
    Property TipePajak As eTipePajak
      Get
        Return _pajak
      End Get
      Set(value As eTipePajak)
        SetPropertyValue(Of eTipePajak)("TipePajak", _pajak, value)
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
    <Persistent("d_disc")>
    Property Discount As Double
      Get
        Return _disc
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Discount", _disc, value)
      End Set
    End Property
    <Persistent("d_othercost")>
    Property BiayaLain As Double
      Get
        Return _othercost
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BiayaLain", _othercost, value)
      End Set
    End Property

    <Persistent("d_taxsnppn")> Property NoSNPPN As String
      Get
        Return _nosnppn
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoSNPPN", _nosnppn, value)
      End Set
    End Property
    <Persistent("d_taxsnpph")> Property NoSNPPh As String
      Get
        Return _nosnpph
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoSNPPh", _nosnpph, value)
      End Set
    End Property
    <Persistent("d_externalnumber")> Property NoReffVendor As String
      Get
        Return _noreffvendor
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoReffVendor", _noreffvendor, value)
      End Set
    End Property

    <Persistent("p_idorder")> Property NoOrder As Fusoh_OrderPembelian
      Get
        Return _noorder
      End Get
      Set(value As Fusoh_OrderPembelian)
        SetPropertyValue(Of Fusoh_OrderPembelian)("NoOrder", _noorder, value)
      End Set
    End Property
    <Persistent("p_idexim")> Property NoExim As Fusoh_Exim
      Get
        Return _noexim
      End Get
      Set(value As Fusoh_Exim)
        SetPropertyValue(Of Fusoh_Exim)("NoExim", _noexim, value)
      End Set
    End Property
    <Persistent("p_idparent"), Association("fk_fusoh_invoice_detail_cost")> Property IndukInvoice As Fusoh_PenerimaanInvoice
      Get
        Return _noparent
      End Get
      Set(value As Fusoh_PenerimaanInvoice)
        SetPropertyValue(Of Fusoh_PenerimaanInvoice)("IndukInvoice", _noparent, value)
      End Set
    End Property

    'property untuk saldo awal hutang
    <Persistent("d_bbvalue")> Property NilaiSaldoAwal As Double
      Get
        Return _nilaisaldoawal
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiSaldoAwal", _nilaisaldoawal, value)
      End Set
    End Property

    <Association("fk_fusoh_invoice_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of Fusoh_PenerimaanInvoiceDetail)
      Get
        Return GetCollection(Of Fusoh_PenerimaanInvoiceDetail)("Detail")
      End Get
    End Property
    <Association("fk_fusoh_invoice_detail_cost"), Aggregated> ReadOnly Property DetailCost As XPCollection(Of Fusoh_PenerimaanInvoice)
      Get
        Return GetCollection(Of Fusoh_PenerimaanInvoice)("DetailCost")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(DPP)")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(PPNv)")> ReadOnly Property PPN As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPN"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(PPHv)")> ReadOnly Property PPH As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPH"))
      End Get
    End Property
    ''<PersistentAlias("(SubTotal + PPN - PPH)")> ReadOnly Property Total As Double
    ''	Get
    ''		Return Convert.ToDouble(EvaluateAlias("Total"))
    ''	End Get
    ''End Property
    ''<PersistentAlias("(SubTotal + PPN - PPH) * Kurs")> ReadOnly Property TotalIDR As Double
    ''	Get
    ''		Return Convert.ToDouble(EvaluateAlias("TotalIDR"))
    ''	End Get
    ''End Property
    <PersistentAlias("Detail.Sum(Total)")> ReadOnly Property Total As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(TotalIDR)")> ReadOnly Property TotalIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalIDR"))
      End Get
    End Property

    <PersistentAlias("Detail.Sum(Weight)")> ReadOnly Property TotalWeight As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalWeight"))
      End Get
    End Property

    <PersistentAlias("DetailCost.Sum(Total)")> ReadOnly Property TotalCost As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalCost"))
      End Get
    End Property
    <PersistentAlias("DetailCost.Sum(TotalIDR)")> ReadOnly Property TotalCostIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalCostIDR"))
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

    <PersistentAlias("Detail.Sum(Qty)")> ReadOnly Property TotalQty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalQty"))
      End Get
    End Property

    <PersistentAlias("Total + TotalCost")> ReadOnly Property TotalPembelian As Double
      Get
        'Return Total + TotalCost
        Return Convert.ToDouble(EvaluateAlias("TotalPembelian"))
      End Get
    End Property
    <PersistentAlias("TotalIDR + TotalCostIDR")> ReadOnly Property TotalPembelianIDR As Double
      Get
        'Return Total + TotalCost
        Return Convert.ToDouble(EvaluateAlias("TotalPembelianIDR"))
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Penerimaan Invoice [RI]"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -2, "", source)
        Return False
      End If
      If Vendor Is Nothing Then
        Throw New Utils.Exception("Masukkan Vendor", -3, "", source)
        Return False
      End If
      If Uang Is Nothing Then
        Throw New Utils.Exception("Masukkan mata uang", -4, "", source)
      End If
      If TipeTransaksi = eTipeInvoicePembelian.PakaiPO AndAlso NoOrder Is Nothing Then
        Throw New Utils.Exception("Masukkan PO", -5, "", source)
      End If
      If String.IsNullOrEmpty(NoReffVendor) Then
        Throw New Utils.Exception("Masukkan nomor invoice dari vendor", -6, "", source)
      End If
      'If Not Detail.Count > 0 Then
      '	Throw New Utils.Exception("Masukkan detail invoice", -99, "", source)
      'End If

      'If Uang.Id <> Uang.HutangDagang.MataUang.Id Then
      '	Throw New Utils.Exception("Mata uang untuk coa [Hutang Dagang] tidak sama dengan mata uang transaksi", -7, "", source)
      'End If
      If Session.IsNewObject(Me) Then
        If (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
          Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -98, "", source)
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


    '==================== pemisahan import duty dan bukan
    <PersistentAlias("Detail.Sum(TotalBukanImportDuty)")> ReadOnly Property TotalBukanImportDuty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalBukanImportDuty"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(TotalBukanImportDutyIDR)")> ReadOnly Property TotalBukanImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalBukanImportDutyIDR"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(TotalImportDuty)")> ReadOnly Property TotalImportDuty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalImportDuty"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(TotalImportDutyIDR)")> ReadOnly Property TotalImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalImportDutyIDR"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(TotalKenaImportDuty)")> ReadOnly Property TotalKenaImportDuty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalKenaImportDuty"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(TotalKenaImportDutyIDR)")> ReadOnly Property TotalKenaImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalKenaImportDutyIDR"))
      End Get
    End Property

    <PersistentAlias("DetailCost.Sum(TotalBukanImportDuty)")> ReadOnly Property TotalCostBukanImportDuty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalCostBukanImportDuty"))
      End Get
    End Property
    <PersistentAlias("DetailCost.Sum(TotalBukanImportDutyIDR)")> ReadOnly Property TotalCostBukanImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalCostBukanImportDutyIDR"))
      End Get
    End Property
    <PersistentAlias("DetailCost.Sum(TotalImportDuty)")> ReadOnly Property TotalCostImportDuty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalCostImportDuty"))
      End Get
    End Property
    <PersistentAlias("DetailCost.Sum(TotalImportDutyIDR)")> ReadOnly Property TotalCostImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalCostImportDutyIDR"))
      End Get
    End Property
  End Class
  <Persistent("m05ddetailinvoicereceipt")> Friend Class Fusoh_PenerimaanInvoiceDetail
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int64
    Private _main As Fusoh_PenerimaanInvoice
    Private _item As NuSoft004.Persistent.Fusoh_Barang
    Private _qty As Double
    Private _satuan As NuSoft004.Persistent.Satuan
    Private _harga As Double
    Private _ppn As NuSoft004.Persistent.Pajak
    Private _ppnp As Double
    Private _pph As NuSoft004.Persistent.Pajak
    Private _pphp As Double
    Private _disc As Double
    Private _discp As Double
    Private _catatan As String
    Private _idpo As Fusoh_OrderPembelianDetail
    Private _idexim As Fusoh_EximDetail
    Private _kenaImportDuty As Boolean
    Private _totalCostImportDuty As Double

    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_fusoh_invoice_detail")> Property Main As Fusoh_PenerimaanInvoice
      Get
        Return _main
      End Get
      Set(value As Fusoh_PenerimaanInvoice)
        SetPropertyValue(Of Fusoh_PenerimaanInvoice)("Main", _main, value)
      End Set
    End Property
    <Persistent("f_item")>
    Property Barang As NuSoft004.Persistent.Fusoh_Barang
      Get
        Return _item
      End Get
      Set(value As NuSoft004.Persistent.Fusoh_Barang)
        SetPropertyValue(Of NuSoft004.Persistent.Fusoh_Barang)("Barang", _item, value)
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
    <Persistent("d_qty")>
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
    <Persistent("d_disc")>
    Property Discount As Double
      Get
        Return _disc
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Discount", _disc, value)
      End Set
    End Property
    <Persistent("d_discp")>
    Property DiscountPersen As Double
      Get
        Return _discp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DiscountPersen", _discp, value)
      End Set
    End Property
    <Persistent("f_taxin")>
    Property PPN As NuSoft004.Persistent.Pajak
      Get
        Return _ppn
      End Get
      Set(value As NuSoft004.Persistent.Pajak)
        SetPropertyValue(Of NuSoft004.Persistent.Pajak)("PPN", _ppn, value)
      End Set
    End Property
    <Persistent("d_taxinp")>
    Property PPNp As Double
      Get
        Return _ppnp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("PPNp", _ppnp, value)
      End Set
    End Property
    <Persistent("f_taxout")>
    Property PPH As NuSoft004.Persistent.Pajak
      Get
        Return _pph
      End Get
      Set(value As NuSoft004.Persistent.Pajak)
        SetPropertyValue(Of NuSoft004.Persistent.Pajak)("PPN", _pph, value)
      End Set
    End Property
    <Persistent("d_taxoutp")>
    Property PPHp As Double
      Get
        Return _pphp
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("PPHp", _pphp, value)
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
    <Persistent("f_idpo")> Property PODetail As Fusoh_OrderPembelianDetail
      Get
        Return _idpo
      End Get
      Set(value As Fusoh_OrderPembelianDetail)
        SetPropertyValue(Of Fusoh_OrderPembelianDetail)("PODetail", _idpo, value)
      End Set
    End Property
    <Persistent("f_idexim")> Property EximDetail As Fusoh_EximDetail
      Get
        Return _idexim
      End Get
      Set(value As Fusoh_EximDetail)
        SetPropertyValue(Of Fusoh_EximDetail)("EximDetail", _idexim, value)
      End Set
    End Property
    <Persistent("d_isimportduty")> Property KenaImportDuty As Boolean
      Get
        Return _kenaImportDuty
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("KenaImportDuty", _kenaImportDuty, value)
      End Set
    End Property

    <PersistentAlias("iif(Main.TipePajak = 0,0,PPNp / 100 * DPP)")> ReadOnly Property PPNv As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPNv"))
      End Get
    End Property
    <PersistentAlias("iif(Main.TipePajak = 0,0,PPHp / 100 * DPP)")> ReadOnly Property PPHv As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("PPHv"))
      End Get
    End Property
    <PersistentAlias("(Qty * Harga)-(Qty * Discount)")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property
    <PersistentAlias("iif(Main.TipePajak = 1,((SubTotal) + PPNv - PPHv), SubTotal)")> ReadOnly Property Total As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
    End Property
    <PersistentAlias("Total * Main.Kurs")> ReadOnly Property TotalIDR As Double
      Get
        'Return Total * Main.Kurs
        Return Convert.ToDouble(EvaluateAlias("TotalIDR"))
      End Get
    End Property
    <PersistentAlias("iif(Main.TipePajak = 2,(SubTotal) - ((PPNp - PPHp) / (100 + (PPNp - PPHp)) * (SubTotal)),SubTotal)")> ReadOnly Property DPP As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("DPP"))
      End Get
    End Property
    <PersistentAlias("Harga * Main.Kurs")> ReadOnly Property HargaIDR As Double
      Get
        'Return Harga * Main.Kurs
        Return Convert.ToDouble(EvaluateAlias("HargaIDR"))
      End Get
    End Property

    <PersistentAlias("EximDetail.Weight")> ReadOnly Property Weight As Decimal
      Get
        Return Convert.ToDecimal(EvaluateAlias("Weight"))
      End Get
    End Property

    <PersistentAlias("TotalCostBukanImportDuty + TotalCostImportDuty")> ReadOnly Property TotalCost As Double
      Get
        'Return (Total / Main.Total) * Main.TotalCost
        Return Convert.ToDouble(EvaluateAlias("TotalCost"))
      End Get
    End Property
    <PersistentAlias("TotalCostBukanImportDutyIDR + TotalCostImportDutyIDR")> ReadOnly Property TotalCostIDR As Double
      Get
        'Return (Total / Main.TotalIDR) * Main.TotalCostIDR
        Return Convert.ToDouble(EvaluateAlias("TotalCostIDR"))
      End Get
    End Property
    <PersistentAlias("Total + TotalCost")> ReadOnly Property TotalPembelian As Double
      Get
        'Return Total + TotalCost
        Return Convert.ToDouble(EvaluateAlias("TotalPembelian"))
      End Get
    End Property
    <PersistentAlias("TotalIDR + TotalCostIDR")> ReadOnly Property TotalPembelianIDR As Double
      Get
        'Return TotalIDR + TotalCostIDR
        Return Convert.ToDouble(EvaluateAlias("TotalPembelianIDR"))
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.FullName
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama Penerimaan Invoice", -99, "", source)
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

    '==================== pemisahan import duty dan bukan
    '=============== cost sheet detail
    <PersistentAlias("iif(Barang.Custom1='" & Fusoh_Logic.Umum.ImportDutyCustom & "',0,iif(Main.TipePajak = 1,((SubTotal) + PPNv - PPHv), SubTotal))")> ReadOnly Property TotalBukanImportDuty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalBukanImportDuty"))
      End Get
    End Property
    <PersistentAlias("TotalBukanImportDuty * Main.Kurs")> ReadOnly Property TotalBukanImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalBukanImportDutyIDR"))
      End Get
    End Property
    <PersistentAlias("iif(Barang.Custom1='" & Fusoh_Logic.Umum.ImportDutyCustom & "',iif(Main.TipePajak = 1,((SubTotal) + PPNv - PPHv), SubTotal),0)")> ReadOnly Property TotalImportDuty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalImportDuty"))
      End Get
    End Property
    <PersistentAlias("TotalImportDuty * Main.Kurs")> ReadOnly Property TotalImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalImportDutyIDR"))
      End Get
    End Property

    '----------- Invoice Weight
    '<PersistentAlias("iif(KenaImportDuty,Total,0)")> ReadOnly Property TotalKenaImportDuty As Double
    '<PersistentAlias("iif(KenaImportDuty,Weight,0)")> ReadOnly Property TotalKenaImportDuty As Double
    <PersistentAlias("iif(TotalCostImportDuty > 0,Weight,0)")> ReadOnly Property TotalKenaImportDuty As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalKenaImportDuty"))
      End Get
    End Property
    '<PersistentAlias("iif(KenaImportDuty,TotalIDR,0)")> ReadOnly Property TotalKenaImportDutyIDR As Double
    '<PersistentAlias("iif(KenaImportDuty,Weight,0)")> ReadOnly Property TotalKenaImportDutyIDR As Double
    <PersistentAlias("iif(TotalCostImportDuty > 0,Weight,0)")> ReadOnly Property TotalKenaImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalKenaImportDutyIDR"))
      End Get
    End Property
    '<PersistentAlias("(Total / Main.Total) * Main.TotalCostBukanImportDuty")> ReadOnly Property TotalCostBukanImportDuty As Double
    <PersistentAlias("(Weight / Main.TotalWeight) * Main.TotalCostBukanImportDuty")> ReadOnly Property TotalCostBukanImportDuty As Double
      Get
        'Return (Total / Main.Total) * Main.TotalCostBukanImportDuty
        Return Convert.ToDouble(EvaluateAlias("TotalCostBukanImportDuty"))
      End Get
    End Property
    '<PersistentAlias("(TotalIDR / Main.TotalIDR) * Main.TotalCostBukanImportDutyIDR")> ReadOnly Property TotalCostBukanImportDutyIDR As Double
    <PersistentAlias("(Weight / Main.TotalWeight) * Main.TotalCostBukanImportDutyIDR")> ReadOnly Property TotalCostBukanImportDutyIDR As Double
      Get
        'Return (Total / Main.TotalIDR) * Main.TotalCostBukanImportDutyIDR
        Return Convert.ToDouble(EvaluateAlias("TotalCostBukanImportDutyIDR"))
      End Get
    End Property
    '<PersistentAlias("iif(KenaImportDuty,(TotalKenaImportDuty / Main.TotalKenaImportDuty) * Main.TotalCostImportDuty,0)")> ReadOnly Property TotalCostImportDuty As Double
    '	Get
    '		'Return (Total / Main.Total) * Main.TotalCostImportDuty
    '		Return Convert.ToDouble(EvaluateAlias("TotalCostImportDuty"))
    '	End Get
    'End Property
    '<PersistentAlias("iif(KenaImportDuty,(TotalKenaImportDutyIDR / Main.TotalKenaImportDutyIDR) * Main.TotalCostImportDutyIDR,0)")> ReadOnly Property TotalCostImportDutyIDR As Double
    '	Get
    '		'Return (Total / Main.TotalIDR) * Main.TotalCostImportDutyIDR
    '		Return Convert.ToDouble(EvaluateAlias("TotalCostImportDutyIDR"))
    '	End Get
    'End Property
    <Persistent("TotalCostImportDuty")> Property TotalCostImportDuty As Double
      Get
        Return _totalCostImportDuty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("TotalCostImportDuty", _totalCostImportDuty, value)
      End Set
    End Property
    <PersistentAlias("TotalCostImportDuty * Main.Kurs")> ReadOnly Property TotalCostImportDutyIDR As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalCostImportDutyIDR"))
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
  End Class
End Namespace