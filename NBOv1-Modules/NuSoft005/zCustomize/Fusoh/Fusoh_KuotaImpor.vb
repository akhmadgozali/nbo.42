Imports DevExpress.Xpo
Imports NuSoft.NPO

Namespace Persistent
	<Persistent("m05kuotaimpor")> Friend Class Fusoh_KuotaImpor
		Inherits NPOBase

		Public Sub New(ByVal session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
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
    Private _noperijinan As String
    Private _tglmulaiberlaku As Date

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
    <Persistent("d_noperijinan")> Property NoPerijinan As String
      Get
        Return _noperijinan
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("NoPerijinan", _noperijinan, value)
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
    <Persistent("d_tglmulaiberlaku")> Property TanggalMulaiBerlaku As Date
      Get
        Return _tglmulaiberlaku
      End Get
      Set(value As Date)
        SetPropertyValue(Of Date)("TanggalMulaiBerlaku", _tglmulaiberlaku, value)
      End Set
    End Property
		<PersistentAlias("Invoice.Sum(WeightManual)")> ReadOnly Property VolumeTerpakai As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("VolumeTerpakai"))
			End Get
		End Property
		<PersistentAlias("Volume - VolumeTerpakai")> ReadOnly Property SisaVolume As Double
			Get
				Return Convert.ToDouble(EvaluateAlias("SisaVolume"))
			End Get
		End Property
		<Association("fusoh_kuotaimpor_podetail"), Aggregated> ReadOnly Property PO As XPCollection(Of Fusoh_OrderPembelianDetail)
			Get
				Return GetCollection(Of Fusoh_OrderPembelianDetail)("PO")
			End Get
		End Property
		<Association("fusoh_kuotaimpor_invoicedetail"), Aggregated> ReadOnly Property Invoice As XPCollection(Of Fusoh_PenerimaanInvoiceDetail)
			Get
				Return GetCollection(Of Fusoh_PenerimaanInvoiceDetail)("Invoice")
			End Get
		End Property

		Private Function CheckData() As Boolean
			Dim source As String = "Kuota Impor"
			If IsDeleted Then
				Return True
			End If

			If String.IsNullOrEmpty(_kodeHS) Then
				Throw New Utils.Exception("Masukkan kode HS", -1, "", source)
				Return False
			End If
			If String.IsNullOrEmpty(_noLampiran) Then
				Throw New Utils.Exception("Masukkan no lampiran", -2, "", source)
				Return False
			End If
			If _volume = Nothing Then
				Throw New Utils.Exception("Masukkan volume", -3, "", source)
				Return False
			End If
			If _satuan Is Nothing Then
				Throw New Utils.Exception("Masukkan satuan", -4, "", source)
				Return False
			End If
			If _harga = Nothing Then
				Throw New Utils.Exception("Masukkan harga", -5, "", source)
				Return False
			End If
			If _mataUang Is Nothing Then
				Throw New Utils.Exception("Masukkan mata uang", -6, "", source)
				Return False
			End If
			If String.IsNullOrEmpty(_negara) Then
				Throw New Utils.Exception("Masukkan negara", -7, "", source)
				Return False
			End If
			If String.IsNullOrEmpty(_pelabuhan) Then
				Throw New Utils.Exception("Masukkan pelabuhan", -8, "", source)
				Return False
			End If
			If _expired = Nothing Then
				Throw New Utils.Exception("Masukkan tanggal expired", -9, "", source)
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