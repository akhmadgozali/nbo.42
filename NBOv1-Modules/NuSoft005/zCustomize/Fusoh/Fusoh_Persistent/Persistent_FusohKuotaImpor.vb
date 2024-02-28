Imports DevExpress.Xpo
Imports NuSoft.NPO

Namespace Persistent_Fusoh
	<Persistent("m05kuotaimpor")> Friend Class Persistent_FusohKuotaImpor
		Inherits NPOBase

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _id As Int32
		Private _kodeHS As String
		Private _keterangan As String
		Private _noLampiran As String
		Private _volume As Decimal
		Private _satuan As NuSoft004.Persistent.Satuan
		Private _harga As Decimal
		Private _mataUang As NuSoft001.Persistent.MataUang
		Private _negara As String
		Private _pelabuhan As String
		Private _expired As Date

		<Persistent("p_id"), Key(True)> Property Id As Int32
			Get
				Return _id
			End Get
			Set(value As Int32)
				SetPropertyValue(Of Int32)("Id", _id, value)
			End Set
		End Property
		<Persistent("d_codehs")> Property KodeHS As String
			Get
				Return _kodeHS
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("KodeHS", _kodeHS, value)
			End Set
		End Property
		<Persistent("d_description")> Property Keterangan As String
			Get
				Return _keterangan
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Keterangan", _keterangan, value)
			End Set
		End Property
		<Persistent("d_nolampiran")> Property NoLampiran As String
			Get
				Return _noLampiran
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("NoLampiran", _noLampiran, value)
			End Set
		End Property
		<Persistent("d_volume")> Property Volume As Decimal
			Get
				Return _volume
			End Get
			Set(value As Decimal)
				SetPropertyValue(Of Decimal)("Volume", _volume, value)
			End Set
		End Property
		<Persistent("f_satuan")> Property Satuan As NuSoft004.Persistent.Satuan
			Get
				Return _satuan
			End Get
			Set(value As NuSoft004.Persistent.Satuan)
				SetPropertyValue(Of NuSoft004.Persistent.Satuan)("Satuan", _satuan, value)
			End Set
		End Property
		<Persistent("d_harga")> Property Harga As Decimal
			Get
				Return _harga
			End Get
			Set(value As Decimal)
				SetPropertyValue(Of Decimal)("Harga", _harga, value)
			End Set
		End Property
		<Persistent("f_matauang")> Property MataUang As NuSoft001.Persistent.MataUang
			Get
				Return _mataUang
			End Get
			Set(value As NuSoft001.Persistent.MataUang)
				SetPropertyValue(Of NuSoft001.Persistent.MataUang)("MataUang", _mataUang, value)
			End Set
		End Property
		<Persistent("d_negara")> Property Negara As String
			Get
				Return _negara
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Negara", _negara, value)
			End Set
		End Property
		<Persistent("d_pelabuhan")> Property Pelabuhan As String
			Get
				Return _pelabuhan
			End Get
			Set(value As String)
				SetPropertyValue(Of String)("Pelabuhan", _pelabuhan, value)
			End Set
		End Property
		<Persistent("d_expired")> Property Expired As Date
			Get
				Return _expired
			End Get
			Set(value As Date)
				SetPropertyValue(Of Date)("Expired", _expired, value)
			End Set
		End Property

		<PersistentAlias("PO.Sum(Weight)")> ReadOnly Property VolumeTerpakai As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("VolumeTerpakai"))
			End Get
		End Property
		<PersistentAlias("Volume - VolumeTerpakai")> ReadOnly Property SisaVolume As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("SisaVolume"))
			End Get
		End Property
		<Association("Persistent_FusohKuotaImpor_PODetail"), Aggregated> ReadOnly Property PO As XPCollection(Of Persistent_FusohOrderPembelianDetail)
			Get
				Return GetCollection(Of Persistent_FusohOrderPembelianDetail)("PO")
			End Get
		End Property
	End Class
End Namespace