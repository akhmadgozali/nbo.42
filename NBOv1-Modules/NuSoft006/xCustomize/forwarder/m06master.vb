Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports DevExpress.XtraCharts.Native
Imports NuSoft.Utils.CustomAttribute
Namespace Persistent
  Public Enum zForwarderType
    <EnumDescription("Ice")> Ice = 0
    <EnumDescription("Dry")> Dry = 1
  End Enum
  <Persistent("m06adestination")> _
  Friend Class zDestination
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Indexed("Kode", Unique:=True)>
    Private _p_id As Int32
    Private _u_code As String
    <Persistent("p_id"), Key(True)> Property p_id As Int32
      Get
        Return _p_id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("p_id", _p_id, value)
      End Set
    End Property
    <Persistent("u_code")> Property Kode As String
      Get
        Return _u_code
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kode", _u_code, value)
      End Set
    End Property
  End Class
  <Persistent("m06aproduk")> _
  Friend Class zProduk
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Indexed("Kode", Unique:=True)>
    Private _p_id As Int32
    Private _u_code As String
    <Persistent("p_id"), Key(True)> Property p_id As Int32
      Get
        Return _p_id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("p_id", _p_id, value)
      End Set
    End Property
    <Persistent("u_code")> Property Kode As String
      Get
        Return _u_code
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kode", _u_code, value)
      End Set
    End Property
  End Class
  <Persistent("m06ashipment")> _
  Friend Class zShipment
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    <Indexed("Kode", Unique:=True)>
    Private _p_id As Int32
    Private _u_code As String
    <Persistent("p_id"), Key(True)> Property p_id As Int32
      Get
        Return _p_id
      End Get
      Set(value As Int32)
        SetPropertyValue(Of Int32)("p_id", _p_id, value)
      End Set
    End Property
    <Persistent("u_code")> Property Kode As String
      Get
        Return _u_code
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kode", _u_code, value)
      End Set
    End Property
  End Class

  <Persistent("m06binvoicemain")> _
  Friend Class zForwarderInvoice
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int32
    Private _Status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _Customer As NuSoft001.Persistent.Kontak
    Private _KontakPerson As String
    Private _Alamat As String
    Private _Uraian As String
    Private _Shipment As zShipment
    Private _Tipe As zForwarderType
    Private _Catatan As String
    Private _NoFakturPPN As String
    Private _NilaiDisc As Double
    Private _NilaiPPN As Double
    Private _NilaiPPH As Double
    Private _uang As NuSoft001.Persistent.MataUang
    Private _GL As Persistent.GlMain
    Private _Type As zForwarderType
    Private _IceShipment20 As Double
    Private _IceShipment40 As Double
    Private _IceShipmentTBS As Double
    Private _IceItem As Double
    Private _IceRecooling20 As Double
    Private _IceRecooling40 As Double
    Private _IceMonitoring20 As Double
    Private _IceMonitoring40 As Double
    Private _DryCTNS As Double
    Private _DryTrucking20 As Double
    Private _DryTrucking40 As Double
    Private _DryTruckingLCL As Double
    Private _DryPhytosanitary20 As Double
    Private _DryPhytosanitary40 As Double
    Private _DryJaring20 As Double
    Private _DryJaring40 As Double
    Private _DryCargo As Double
    Private _DryTriplek As Double
    Private _DryLolo As Double
    'Private _mataUang As NuSoft001.Persistent.MataUang
    <Persistent("d_status")> Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _Status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _Status, value)
      End Set
    End Property
    <Persistent("f_customer")> Property Customer As NuSoft001.Persistent.Kontak
      Get
        Return _Customer
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Customer", _Customer, value)
      End Set
    End Property
    <Persistent("d_contact")> Property KontakPerson As String
      Get
        Return _KontakPerson
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("KontakPerson", _KontakPerson, value)
      End Set
    End Property
    <Persistent("d_adress")> Property Alamat As String
      Get
        Return _Alamat
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Alamat", _Alamat, value)
      End Set
    End Property
    <Persistent("d_remarks")> Property Uraian As String
      Get
        Return _Uraian
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Uraian", _Uraian, value)
      End Set
    End Property
    <Persistent("f_shipment")> Property Shipment As zShipment
      Get
        Return _Shipment
      End Get
      Set(value As zShipment)
        SetPropertyValue(Of zShipment)("Shipment", _Shipment, value)
      End Set
    End Property
    <Persistent("d_type")> Property Tipe As zForwarderType
      Get
        Return _Tipe
      End Get
      Set(value As zForwarderType)
        SetPropertyValue(Of zForwarderType)("Tipe", _Tipe, value)
      End Set
    End Property
    <Persistent("d_note")> Property Catatan As String
      Get
        Return _Catatan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Catatan", _Catatan, value)
      End Set
    End Property
    <Persistent("d_ppnno")> Property NoFakturPPN As String
      Get
        Return _NoFakturPPN
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoFakturPPN", _NoFakturPPN, value)
      End Set
    End Property
    <Persistent("d_disc")> Property NilaiDisc As Double
      Get
        Return _NilaiDisc
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiDisc", _NilaiDisc, value)
      End Set
    End Property
    <Persistent("d_ppn")> Property NilaiPPN As Double
      Get
        Return _NilaiPPN
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiPPN", _NilaiPPN, value)
      End Set
    End Property
    <Persistent("d_pph")> Property NilaiPPH As Double
      Get
        Return _NilaiPPH
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiPPH", _NilaiPPH, value)
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
    <Persistent("f_gl")> Property GL As Persistent.GlMain
      Get
        Return _GL
      End Get
      Set(value As Persistent.GlMain)
        SetPropertyValue(Of Persistent.GlMain)("GL", _GL, value)
      End Set
    End Property
    <Persistent("d_nilaishipmentfee20")>
    Property IceShipment20 As Double
      Get
        Return _IceShipment20
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceShipment20", _IceShipment20, value)
      End Set
    End Property
    <Persistent("d_nilaishipmentfee40")>
    Property IceShipment40 As Double
      Get
        Return _IceShipment40
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceShipment40", _IceShipment40, value)
      End Set
    End Property
    <Persistent("d_nilaishipmentfeetbs")>
    Property IceShipmentTBS As Double
      Get
        Return _IceShipmentTBS
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("d_nilaishipmentfeetbs", _IceShipmentTBS, value)
      End Set
    End Property
    <Persistent("d_nilaivhcitem")>
    Property IceItem As Double
      Get
        Return _IceItem
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceItem", _IceItem, value)
      End Set
    End Property
    <Persistent("d_nilairecooling20")>
    Property IceRecooling20 As Double
      Get
        Return _IceRecooling20
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceRecooling20", _IceRecooling20, value)
      End Set
    End Property
    <Persistent("d_nilairecooling40")>
    Property IceRecooling40 As Double
      Get
        Return _IceRecooling40
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceRecooling40", _IceRecooling40, value)
      End Set
    End Property
    <Persistent("d_nilaimonitoring20")>
    Property IceMonitoring20 As Double
      Get
        Return _IceMonitoring20
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceMonitoring20", _IceMonitoring20, value)
      End Set
    End Property
    <Persistent("d_nilaimonitoring40")>
    Property IceMonitoring40 As Double
      Get
        Return _IceMonitoring40
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceMonitoring40", _IceMonitoring40, value)
      End Set
    End Property
    <Persistent("d_nilaictns")>
    Property DryCTNS As Double
      Get
        Return _DryCTNS
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryCTNS", _DryCTNS, value)
      End Set
    End Property
    <Persistent("d_nilaitrucking20")>
    Property DryTrucking20 As Double
      Get
        Return _DryTrucking20
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryTrucking20", _DryTrucking20, value)
      End Set
    End Property
    <Persistent("d_nilaitrucking40")>
    Property DryTrucking40 As Double
      Get
        Return _DryTrucking40
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryTrucking40", _DryTrucking40, value)
      End Set
    End Property
    <Persistent("d_nilaitruckinglcl")>
    Property DryTruckingLCL As Double
      Get
        Return _DryTruckingLCL
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryTruckingLCL", _DryTruckingLCL, value)
      End Set
    End Property
    <Persistent("d_nilaiphytosanitary20")>
    Property DryPhytosanitary20 As Double
      Get
        Return _DryPhytosanitary20
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryPhytosanitary20", _DryPhytosanitary20, value)
      End Set
    End Property
    <Persistent("d_nilaiphytosanitary40")>
    Property DryPhytosanitary40 As Double
      Get
        Return _DryPhytosanitary40
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryPhytosanitary40", _DryPhytosanitary40, value)
      End Set
    End Property
    <Persistent("d_nilaijaring20")>
    Property DryJaring20 As Double
      Get
        Return _DryJaring20
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryJaring20", _DryJaring20, value)
      End Set
    End Property
    <Persistent("d_nilaijaring40")>
    Property DryJaring40 As Double
      Get
        Return _DryJaring40
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryJaring40", _DryJaring40, value)
      End Set
    End Property
    <Persistent("d_nilaicargo")>
    Property DryCargo As Double
      Get
        Return _DryCargo
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryCargo", _DryCargo, value)
      End Set
    End Property
    <Persistent("d_nilaitriplek")>
    Property DryTriplek As Double
      Get
        Return _DryTriplek
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryTriplek", _DryTriplek, value)
      End Set
    End Property
    <Persistent("d_nilailolo")>
    Property DryLolo As Double
      Get
        Return _DryLolo
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryLolo", _DryLolo, value)
      End Set
    End Property
    <Association("fk_invoice_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of zForwarderInvoiceDetail)
      Get
        Return GetCollection(Of zForwarderInvoiceDetail)("Detail")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Total)")> ReadOnly Property SubTotal As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("SubTotal"))
      End Get
    End Property
    <PersistentAlias("(SubTotal - NilaiDisc + NilaiPPN - NilaiPPH)")> ReadOnly Property Total As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
    End Property
    <PersistentAlias("Terbilang(Total)")> ReadOnly Property Terbilang As String
      Get
        Return Convert.ToString(EvaluateAlias("Terbilang"))
      End Get
    End Property
    Private Function CheckData() As Boolean
      Dim source As String = "Invoice Penjualan [IV]"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If Customer Is Nothing Then
        Throw New Utils.Exception("Masukkan Customer", -4, "", source)
        Return False
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
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m06cinvoicedetail")> _
  Friend Class zForwarderInvoiceDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _Id As Int64
    Private _Main As zForwarderInvoice
    Private _InvoiceNo As String
    Private _Destination As zDestination
    Private _Partay As String
    Private _Harga As Double
    Private _CTNS As Double
    Private _Partay20 As Double
    Private _Partay40 As Double
    Private _PartayLCL As Double
    Private _IceShipmentFee20 As Double
    Private _IceShipmentFee40 As Double
    Private _IceShipmentFeeTBS As Double
    Private _IceCustomInspection As Double
    Private _IceCOO As Double
    Private _IceVHCItem As Double
    Private _IceVHCValue As Double
    Private _IceSealFee As Double
    Private _IceRecooling20 As Double
    Private _IceRecooling40 As Double
    Private _IceMonitoring20 As Double
    Private _IceMonitoring40 As Double
    Private _IceNotulPeb As Double
    Private _DryCTNSValue As Double
    Private _DryTrucking20 As Double
    Private _DryTrucking40 As Double
    Private _DryTruckingLCL As Double
    Private _DryCOO As Double
    Private _DryPhytosanitary20 As Double
    Private _DryPhytosanitary40 As Double
    Private _DryJaring20 As Double
    Private _DryJaring40 As Double
    Private _DryCargo As Double
    Private _DryTriplek As Double
    Private _DryMeratus As Double
    Private _DryDocFee As Double
    Private _DrySealFee As Double
    Private _DryServiceCharge As Double
    Private _DryLOLO As Double
    Private _DryNotulPeb As Double
    Private _BiayaLainLain As Double
    Private _stuffing As zForwarderStuffing
    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _Id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _Id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_invoice_detail")> Property Main As zForwarderInvoice
      Get
        Return _Main
      End Get
      Set(value As zForwarderInvoice)
        SetPropertyValue(Of zForwarderInvoice)("Main", _Main, value)
      End Set
    End Property
    <Persistent("d_invoiceno")> Property InvoiceNo As String
      Get
        Return _InvoiceNo
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("InvoiceNo", _InvoiceNo, value)
      End Set
    End Property
    <Persistent("f_destination")> Property Destination As zDestination
      Get
        Return _Destination
      End Get
      Set(value As zDestination)
        SetPropertyValue(Of zDestination)("Destination", _Destination, value)
      End Set
    End Property
    <Persistent("d_ctns")>
    Property CTNS As Double
      Get
        Return _CTNS
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("CTNS", _CTNS, value)
      End Set
    End Property
    <Persistent("d_partay20")>
    Property Partay20 As Double
      Get
        Return _Partay20
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Partay20", _Partay20, value)
      End Set
    End Property
    <Persistent("d_partay40")>
    Property Partay40 As Double
      Get
        Return _Partay40
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Partay40", _Partay40, value)
      End Set
    End Property
    <Persistent("d_partaylcl")>
    Property PartayLCL As Double
      Get
        Return _PartayLCL
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("PartayLCL", _PartayLCL, value)
      End Set
    End Property
    <Persistent("i_shipmentfee20")>
    Property IceShipmentFee20 As Double
      Get
        Return _IceShipmentFee20
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceShipmentFee20", _IceShipmentFee20, value)
      End Set
    End Property
    <Persistent("i_shipmentfee40")>
    Property IceShipmentFee40 As Double
      Get
        Return _IceShipmentFee40
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceShipmentFee40", _IceShipmentFee40, value)
      End Set
    End Property
    <Persistent("i_shipmentfeetbs")>
    Property IceShipmentFeeTBS As Double
      Get
        Return _IceShipmentFeeTBS
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceShipmentFeeTBS", _IceShipmentFeeTBS, value)
      End Set
    End Property
    <Persistent("i_custominspection")>
    Property IceCustomInspection As Double
      Get
        Return _IceCustomInspection
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceCustomInspection", _IceCustomInspection, value)
      End Set
    End Property
    <Persistent("i_coo")>
    Property IceCOO As Double
      Get
        Return _IceCOO
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceCOO", _IceCOO, value)
      End Set
    End Property
    <Persistent("i_vhcitem")>
    Property IceVHCItem As Double
      Get
        Return _IceVHCItem
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceVHCItem", _IceVHCItem, value)
      End Set
    End Property
    <Persistent("i_vhcvalue")>
    Property IceVHCValue As Double
      Get
        Return _IceVHCValue
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceVHCValue", _IceVHCValue, value)
      End Set
    End Property
    <Persistent("i_sealfee")>
    Property IceSealFee As Double
      Get
        Return _IceSealFee
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceSealFee", _IceSealFee, value)
      End Set
    End Property
    <Persistent("i_recooling20")>
    Property IceRecooling20 As Double
      Get
        Return _IceRecooling20
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceRecooling20", _IceRecooling20, value)
      End Set
    End Property
    <Persistent("i_recooling40")>
    Property IceRecooling40 As Double
      Get
        Return _IceRecooling40
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceRecooling40", _IceRecooling40, value)
      End Set
    End Property
    <Persistent("i_monitoring20")>
    Property IceMonitoring20 As Double
      Get
        Return _IceMonitoring20
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceMonitoring20", _IceMonitoring20, value)
      End Set
    End Property
    <Persistent("i_monitoring40")>
    Property IceMonitoring40 As Double
      Get
        Return _IceMonitoring40
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceMonitoring40", _IceMonitoring40, value)
      End Set
    End Property
    <Persistent("i_notulpeb")>
    Property IceNotulPeb As Double
      Get
        Return _IceNotulPeb
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("IceNotulPeb", _IceNotulPeb, value)
      End Set
    End Property
    <Persistent("dr_ctnsvalue")>
    Property DryCTNSValue As Double
      Get
        Return _DryCTNSValue
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryCTNSValue", _DryCTNSValue, value)
      End Set
    End Property
    <Persistent("dr_trucking20")>
    Property DryTrucking20 As Double
      Get
        Return _DryTrucking20
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryTrucking20", _DryTrucking20, value)
      End Set
    End Property
    <Persistent("dr_trucking40")>
    Property DryTrucking40 As Double
      Get
        Return _DryTrucking40
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryTrucking40", _DryTrucking40, value)
      End Set
    End Property
    <Persistent("dr_truckinglcl")>
    Property DryTruckingLCL As Double
      Get
        Return _DryTruckingLCL
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryTruckingLCL", _DryTruckingLCL, value)
      End Set
    End Property
    <Persistent("dr_coo")>
    Property DryCOO As Double
      Get
        Return _DryCOO
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryCOO", _DryCOO, value)
      End Set
    End Property
    <Persistent("dr_phytosanitary20")>
    Property DryPhytosanitary20 As Double
      Get
        Return _DryPhytosanitary20
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryPhytosanitary20", _DryPhytosanitary20, value)
      End Set
    End Property
    <Persistent("dr_phytosanitary40")>
    Property DryPhytosanitary40 As Double
      Get
        Return _DryPhytosanitary40
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryPhytosanitary40", _DryPhytosanitary40, value)
      End Set
    End Property
    <Persistent("dr_jaring20")>
    Property DryJaring20 As Double
      Get
        Return _DryJaring20
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryJaring20", _DryJaring20, value)
      End Set
    End Property
    <Persistent("dr_jaring40")>
    Property DryJaring40 As Double
      Get
        Return _DryJaring40
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryJaring40", _DryJaring40, value)
      End Set
    End Property
    <Persistent("dr_cargo")>
    Property DryCargo As Double
      Get
        Return _DryCargo
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryCargo", _DryCargo, value)
      End Set
    End Property
    <Persistent("dr_triplek")>
    Property DryTriplek As Double
      Get
        Return _DryTriplek
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryTriplek", _DryTriplek, value)
      End Set
    End Property
    <Persistent("dr_meratus")>
    Property DryMeratus As Double
      Get
        Return _DryMeratus
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryMeratus", _DryMeratus, value)
      End Set
    End Property
    <Persistent("dr_docfee")>
    Property DryDocFee As Double
      Get
        Return _DryDocFee
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryDocFee", _DryDocFee, value)
      End Set
    End Property
    <Persistent("dr_sealfee")>
    Property DrySealFee As Double
      Get
        Return _DrySealFee
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DrySealFee", _DrySealFee, value)
      End Set
    End Property
    <Persistent("dr_servicecharge")>
    Property DryServiceCharge As Double
      Get
        Return _DryServiceCharge
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryServiceCharge", _DryServiceCharge, value)
      End Set
    End Property
    <Persistent("dr_lolo")>
    Property DryLOLO As Double
      Get
        Return _DryLOLO
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryLOLO", _DryLOLO, value)
      End Set
    End Property
    <Persistent("dr_notulpeb")>
    Property DryNotulPeb As Double
      Get
        Return _DryNotulPeb
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("DryNotulPeb", _DryNotulPeb, value)
      End Set
    End Property
    <Persistent("d_lainlain")>
    Property BiayaLainLain As Double
      Get
        Return _BiayaLainLain
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("BiayaLainLain", _BiayaLainLain, value)
      End Set
    End Property
    <Persistent("f_stuffing")> Property Stuffing As zForwarderStuffing
      Get
        Return _stuffing
      End Get
      Set(value As zForwarderStuffing)
        SetPropertyValue(Of zForwarderStuffing)("Stuffing", _stuffing, value)
      End Set
    End Property
    <PersistentAlias("IceShipmentFee20 + IceShipmentFee40 + IceShipmentFeeTBS + IceCustomInspection + IceCOO + IceVHCValue + IceSealFee + IceRecooling20 + IceRecooling40 + IceMonitoring20 + IceMonitoring40 + IceNotulPeb + BiayaLainLain")> ReadOnly Property TotalICE As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalICE"))
      End Get
    End Property
    <PersistentAlias("DryCTNSValue + DryTrucking20 + DryTrucking40 + DryTruckingLCL + DryCOO + DryPhytosanitary20 + DryPhytosanitary40 + DryJaring20 + DryJaring40 + DryCargo + DryTriplek + DryMeratus + DryDocFee + DrySealFee + DryServiceCharge + DryLOLO + DryNotulPeb + BiayaLainLain + BiayaLainLain")> ReadOnly Property TotalDRY As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("TotalDRY"))
      End Get
    End Property
    <PersistentAlias("iif(Main.Tipe = 0,TotalICE,TotalDRY)")> ReadOnly Property Total As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Total"))
      End Get
    End Property
    Private Function CheckData() As Boolean
      CheckData = True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      MyBase.OnSaving()
    End Sub
  End Class

  <Persistent("m06cmainpayment")>
  Friend Class zForwarderPembayaranPiutang
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _id As Int32
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
    Property Customer As NuSoft001.Persistent.Kontak
      Get
        Return _customer
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Customer", _customer, value)
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
    <Association("fk_pembayaran_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of zForwarderPembayaranPiutangDetail)
      Get
        Return GetCollection(Of zForwarderPembayaranPiutangDetail)("Detail")
      End Get
    End Property
    <NonPersistent()> ReadOnly Property SelisihKurs As Double
      Get
        Return Detail.Sum(Function(m) m.NilaiBayar * m.Kurs) - Detail.Sum(Function(m) m.NilaiBayar * m.Kurs)
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Pembayaran Piutang [CP]"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If Customer Is Nothing Then
        Throw New Utils.Exception("Masukkan Customer", -4, "", source)
        Return False
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
  <Persistent("m06ddetailpayment")>
  Friend Class zForwarderPembayaranPiutangDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _id As Int64
    Private _main As Persistent.zForwarderPembayaranPiutang
    Private _idinvoice As Persistent.zForwarderInvoice
    Private _urutan As Byte
    Private _amount As Double
    Private _kurs As Double
    Private _amountcash As Double
    Private _amountreturn As Double
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
    <Persistent("p_id"), Association("fk_pembayaran_detail")>
    Property Main As zForwarderPembayaranPiutang
      Get
        Return _main
      End Get
      Set(value As zForwarderPembayaranPiutang)
        SetPropertyValue(Of zForwarderPembayaranPiutang)("Main", _main, value)
      End Set
    End Property
    <Persistent("p_idinvoice")>
    Property NoInvoice As Persistent.zForwarderInvoice
      Get
        Return _idinvoice
      End Get
      Set(value As Persistent.zForwarderInvoice)
        SetPropertyValue(Of Persistent.zForwarderInvoice)("NoInvoice", _idinvoice, value)
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
    <Persistent("d_amount")>
    Property NilaiBayar As Double
      Get
        Return _amount
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiBayar", _amount, value)
      End Set
    End Property
    <Persistent("d_kurspayment")>
    Property Kurs As Double
      Get
        Return _kurs
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Kurs", _kurs, value)
      End Set
    End Property
    <Persistent("d_amountcash")>
    Property NilaiBayarCash As Double
      Get
        Return _amountcash
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiBayarCash", _amountcash, value)
      End Set
    End Property
    <Persistent("d_amountreturn")>
    Property NilaiBayarRetur As Double
      Get
        Return _amountreturn
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("NilaiBayarRetur", _amountreturn, value)
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
    Private Function CheckData() As Boolean
      Dim source As String = ClassInfo.FullName
      If _main Is Nothing AndAlso Not IsDeleted Then
        Throw New Utils.Exception("Masukkan data utama pembayaran hutang", -99, "", source)
        Return False
      End If
      If _idinvoice Is Nothing Then
        Throw New Utils.Exception("Masukkan nomor invoice", -99, "", source)
        Return False
      End If
      If _amountcash = 0 Then
        Throw New Utils.Exception("Masukkan jumlah pembayaran", -99, "", source)
        Return False
      End If
      Return True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      NilaiBayar = NilaiBayarCash + NilaiBayarRetur
      MyBase.OnSaving()
    End Sub
  End Class


  <Persistent("m06bmainstuffing")> _
  Friend Class zForwarderStuffing
    Inherits Persistent.TransactionMain
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(Session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _Id As Int64
    Private _Tanggal As Date
    Private _Status As NuSoft001.Persistent.StatusTransaksiEnum
    Private _Karyawan As NuSoft001.Persistent.Kontak
    Private _Vessel As String
    Private _ETD As Date
    Private _Destination As zDestination
    Private _Party As String
    Private _InvoiceNo As String
    Private _TglStuffing As Date
    Private _coakas As NuSoft001.Persistent.Coa
    Private _jurnalrealisasi As Boolean
    Private _GL As Persistent.GlMain
    Private _GLRealisasi As Persistent.GlMain
    Private _Tipe As zForwarderType
    <Persistent("d_status")>
    Property StatusTransaksi As NuSoft001.Persistent.StatusTransaksiEnum
      Get
        Return _Status
      End Get
      Set(value As NuSoft001.Persistent.StatusTransaksiEnum)
        SetPropertyValue(Of NuSoft001.Persistent.StatusTransaksiEnum)("StatusTransaksi", _Status, value)
      End Set
    End Property
    <Persistent("f_employee")>
    Property Karyawan As NuSoft001.Persistent.Kontak
      Get
        Return _Karyawan
      End Get
      Set(value As NuSoft001.Persistent.Kontak)
        SetPropertyValue(Of NuSoft001.Persistent.Kontak)("Karyawan", _Karyawan, value)
      End Set
    End Property
    <Persistent("f_coakas")>
    Property CoaKas As NuSoft001.Persistent.Coa
      Get
        Return _coakas
      End Get
      Set(value As NuSoft001.Persistent.Coa)
        SetPropertyValue(Of NuSoft001.Persistent.Coa)("CoaKas", _coakas, value)
      End Set
    End Property
    <Persistent("d_vessel")>
    Property Vessel As String
      Get
        Return _Vessel
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Vessel", _Vessel, value)
      End Set
    End Property
    <Persistent("d_ETD")>
    Property ETD As Date
      Get
        Return _ETD
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("ETD", _ETD, value)
      End Set
    End Property
    <Persistent("f_destination")>
    Property Destination As zDestination
      Get
        Return _Destination
      End Get
      Set(value As zDestination)
        SetPropertyValue(Of zDestination)("Destination", _Destination, value)
      End Set
    End Property
    <Persistent("d_party")>
    Property Party As String
      Get
        Return _Party
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Party", _Party, value)
      End Set
    End Property
    <Persistent("d_invoiceno")>
    Property InvoiceNo As String
      Get
        Return _InvoiceNo
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("InvoiceNo", _InvoiceNo, value)
      End Set
    End Property
    <Persistent("d_tglstuffing")>
    Property TglStuffing As Date
      Get
        Return _TglStuffing
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TglStuffing", _TglStuffing, value)
      End Set
    End Property
    <Persistent("d_realisasi")>
    Property JurnalRealisasi As Boolean
      Get
        Return _jurnalrealisasi
      End Get
      Set(value As Boolean)
        SetPropertyValue(Of Boolean)("JurnalRealisasi", _jurnalrealisasi, value)
      End Set
    End Property
    <Persistent("f_gl")>
    Property GL As Persistent.GlMain
      Get
        Return _GL
      End Get
      Set(value As Persistent.GlMain)
        SetPropertyValue(Of Persistent.GlMain)("GL", _GL, value)
      End Set
    End Property
    <Persistent("f_glrealisasi")>
    Property GLRealisasi As Persistent.GlMain
      Get
        Return _GLRealisasi
      End Get
      Set(value As Persistent.GlMain)
        SetPropertyValue(Of Persistent.GlMain)("GLRealisasi", _GLRealisasi, value)
      End Set
    End Property
    <Persistent("d_type")>
    Property Tipe As zForwarderType
      Get
        Return _Tipe
      End Get
      Set(value As zForwarderType)
        SetPropertyValue(Of zForwarderType)("Tipe", _Tipe, value)
      End Set
    End Property
    <Association("fk_invoice_detail"), Aggregated> ReadOnly Property Detail As XPCollection(Of zForwarderStuffingDetail)
      Get
        Return GetCollection(Of zForwarderStuffingDetail)("Detail")
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Anggaran)")> ReadOnly Property Anggaran As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Anggaran"))
      End Get
    End Property
    <PersistentAlias("Detail.Sum(Realisasi)")> ReadOnly Property Realisasi As Double
      Get
        Return Convert.ToDouble(EvaluateAlias("Realisasi"))
      End Get
    End Property

    Private Function CheckData() As Boolean
      Dim source As String = "Invoice Penjualan [IV]"
      If Regional Is Nothing Then
        Throw New Utils.Exception("Masukkan regional", -1, "", source)
        Return False
      End If
      If Tanggal = Nothing Then
        Throw New Utils.Exception("Masukkan tanggal", -3, "", source)
        Return False
      End If
      If Karyawan Is Nothing Then
        Throw New Utils.Exception("Masukkan Customer", -4, "", source)
        Return False
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
      MyBase.OnSaving()
    End Sub
  End Class
  <Persistent("m06cdetailstuffing")> _
  Friend Class zForwarderStuffingDetail
    Inherits NPOBase
    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(Session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub
    Private _Id As Int64
    Private _Main As zForwarderStuffing
    Private _Keterangan As String
    Private _Qty As Double
    Private _Anggaran As Double
    Private _Realisasi As Double
    <Persistent("primary_main"), Key(True)> Property Id As Int64
      Get
        Return _Id
      End Get
      Set(value As Int64)
        SetPropertyValue(Of Int64)("Id", _Id, value)
      End Set
    End Property
    <Persistent("p_id"), Association("fk_invoice_detail")> Property Main As zForwarderStuffing
      Get
        Return _Main
      End Get
      Set(value As zForwarderStuffing)
        SetPropertyValue(Of zForwarderStuffing)("Main", _Main, value)
      End Set
    End Property
    <Persistent("d_keterangan")>
    Property Keterangan As String
      Get
        Return _Keterangan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Keterangan", _Keterangan, value)
      End Set
    End Property
    <Persistent("d_qty")>
    Property Qty As Double
      Get
        Return _Qty
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Qty", _Qty, value)
      End Set
    End Property
    <Persistent("d_anggaran")>
    Property Anggaran As Double
      Get
        Return _Anggaran
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Anggaran", _Anggaran, value)
      End Set
    End Property
    <Persistent("d_realisasi")>
    Property Realisasi As Double
      Get
        Return _Realisasi
      End Get
      Set(value As Double)
        SetPropertyValue(Of Double)("Realisasi", _Realisasi, value)
      End Set
    End Property
    Private Function CheckData() As Boolean
      CheckData = True
    End Function
    Protected Overrides Sub OnSaving()
      If Not CheckData() Then
        Return
      End If
      MyBase.OnSaving()
    End Sub
  End Class
  'query untuk sisa piutang invoice
  <Persistent("m06vwinvoice")> Friend Class zForwarderViewInvoice
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As Session, ByVal classInfo As Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    <Key()> Property NoInvoice As zForwarderInvoice
    Property Urutan As Byte
    Property Terbayar As Double
    Property NilaiBayarCash As Double
    Property Kurs As Double
    Property OK As Boolean
    Property Catatan As String
  End Class
End Namespace