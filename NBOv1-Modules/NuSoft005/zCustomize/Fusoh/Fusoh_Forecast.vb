Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent

Namespace Persistent
	<Persistent("m05cforecast")> Friend Class Fusoh_Forecast
		Inherits NPOBase

		Public Sub New(session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(session As UnitOfWork, classInfo As Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _id As Integer
		Private _tanggal As Date
		Private _customer As Kontak
		Private _bahanJadi As Fusoh_Barang
		Private _bahanBaku As Fusoh_Barang
		Private _lotPerBatang As Double
		Private _stokAwalBahanJadi As Double
		Private _stokAwalBahanBaku As Double
		Private _keterangan As String
		Private _bln01Incoming As Double
		Private _bln01Delivery As Double
		Private _bln02Incoming As Double
		Private _bln02Delivery As Double
		Private _bln03Incoming As Double
		Private _bln03Delivery As Double
		Private _bln04Incoming As Double
		Private _bln04Delivery As Double
		Private _bln05Incoming As Double
		Private _bln05Delivery As Double
		Private _bln06Incoming As Double
		Private _bln06Delivery As Double
		Private _bln07Incoming As Double
		Private _bln07Delivery As Double
		Private _bln08Incoming As Double
		Private _bln08Delivery As Double
		Private _bln09Incoming As Double
		Private _bln09Delivery As Double

		<Key> Property Id As Integer
			Get
				Return _id
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)(NameOf(Id), _id, value)
			End Set
		End Property
		Property Tanggal As Date
			Get
				Return _tanggal
			End Get
			Set(value As Date)
				SetPropertyValue(Of Date)(NameOf(Tanggal), _tanggal, value)
			End Set
		End Property
		Property Customer As Kontak
			Get
				Return _customer
			End Get
			Set(value As Kontak)
				SetPropertyValue(Of Kontak)(NameOf(Customer), _customer, value)
			End Set
		End Property
		Property BahanJadi As Fusoh_Barang
			Get
				Return _bahanJadi
			End Get
			Set(value As Fusoh_Barang)
				SetPropertyValue(Of Fusoh_Barang)(NameOf(BahanJadi), _bahanJadi, value)
			End Set
		End Property
		Property BahanBaku As Fusoh_Barang
			Get
				Return _bahanBaku
			End Get
			Set(value As Fusoh_Barang)
				SetPropertyValue(Of Fusoh_Barang)(NameOf(BahanBaku), _bahanBaku, value)
			End Set
		End Property
		Property LotPerBatang As Double
			Get
				Return _lotPerBatang
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(LotPerBatang), _lotPerBatang, value)
			End Set
		End Property
		Property StokAwalBahanJadi As Double
			Get
				Return _stokAwalBahanJadi
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(StokAwalBahanJadi), _stokAwalBahanJadi, value)
			End Set
		End Property
		Property StokAwalBahanBaku As Double
			Get
				Return _stokAwalBahanBaku
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(StokAwalBahanBaku), _stokAwalBahanBaku, value)
			End Set
		End Property
		Property Keterangan As String
			Get
				Return _keterangan
			End Get
			Set(value As String)
				SetPropertyValue(Of String)(NameOf(Keterangan), _keterangan, value)
			End Set
		End Property

		' ========== Bln ke 1 ============
		<PersistentAlias(NameOf(StokAwalBahanJadi) & " + (" & NameOf(StokAwalBahanBaku) & " * " & NameOf(LotPerBatang) & ")")> ReadOnly Property Bln01StokAwal As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln01StokAwal)))
			End Get
		End Property
		Property Bln01Incoming As Double
			Get
				Return _bln01Incoming
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Bln01Incoming), _bln01Incoming, value)
			End Set
		End Property
		<PersistentAlias(NameOf(Bln01Incoming) & " * " & NameOf(LotPerBatang))> ReadOnly Property Bln01IncomingPcs As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln01IncomingPcs)))
			End Get
		End Property
		Property Bln01Delivery As Double
			Get
				Return _bln01Delivery
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Bln01Delivery), _bln01Delivery, value)
			End Set
		End Property
		<PersistentAlias(NameOf(Bln01StokAwal) & " + " & NameOf(Bln01IncomingPcs) & " - " & NameOf(Bln01Delivery))> ReadOnly Property Bln01StokAkhir As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln01StokAkhir)))
			End Get
		End Property
		<PersistentAlias(NameOf(Bln01StokAkhir) & " / " & NameOf(Bln02Delivery))> ReadOnly Property Bln01StokRatio As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln01StokRatio)))
			End Get
		End Property

		' ========== Bln ke 2 ============
		<PersistentAlias(NameOf(Bln01StokAkhir))> ReadOnly Property Bln02StokAwal As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln02StokAwal)))
			End Get
		End Property
		Property Bln02Incoming As Double
			Get
				Return _bln02Incoming
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Bln02Incoming), _bln02Incoming, value)
			End Set
		End Property
		<PersistentAlias(NameOf(Bln02Incoming) & " * " & NameOf(LotPerBatang))> ReadOnly Property Bln02IncomingPcs As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln02IncomingPcs)))
			End Get
		End Property
		Property Bln02Delivery As Double
			Get
				Return _bln02Delivery
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Bln02Delivery), _bln02Delivery, value)
			End Set
		End Property
		<PersistentAlias(NameOf(Bln02StokAwal) & " + " & NameOf(Bln02IncomingPcs) & " - " & NameOf(Bln02Delivery))> ReadOnly Property Bln02StokAkhir As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln02StokAkhir)))
			End Get
		End Property
		<PersistentAlias(NameOf(Bln02StokAkhir) & " / " & NameOf(Bln03Delivery))> ReadOnly Property Bln02StokRatio As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln02StokRatio)))
			End Get
		End Property

		' ========== Bln ke 3 ============
		<PersistentAlias(NameOf(Bln02StokAkhir))> ReadOnly Property Bln03StokAwal As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln03StokAwal)))
			End Get
		End Property
		Property Bln03Incoming As Double
			Get
				Return _bln03Incoming
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Bln03Incoming), _bln03Incoming, value)
			End Set
		End Property
		<PersistentAlias(NameOf(Bln03Incoming) & " * " & NameOf(LotPerBatang))> ReadOnly Property Bln03IncomingPcs As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln03IncomingPcs)))
			End Get
		End Property
		Property Bln03Delivery As Double
			Get
				Return _bln03Delivery
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Bln03Delivery), _bln03Delivery, value)
			End Set
		End Property
		<PersistentAlias(NameOf(Bln03StokAwal) & " + " & NameOf(Bln03IncomingPcs) & " - " & NameOf(Bln03Delivery))> ReadOnly Property Bln03StokAkhir As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln03StokAkhir)))
			End Get
		End Property
		<PersistentAlias(NameOf(Bln03StokAkhir) & " / " & NameOf(Bln04Delivery))> ReadOnly Property Bln03StokRatio As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln03StokRatio)))
			End Get
		End Property

		' ========== Bln ke 4 ============
		<PersistentAlias(NameOf(Bln03StokAkhir))> ReadOnly Property Bln04StokAwal As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln04StokAwal)))
			End Get
		End Property
		Property Bln04Incoming As Double
			Get
				Return _bln04Incoming
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Bln04Incoming), _bln04Incoming, value)
			End Set
		End Property
		<PersistentAlias(NameOf(Bln04Incoming) & " * " & NameOf(LotPerBatang))> ReadOnly Property Bln04IncomingPcs As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln04IncomingPcs)))
			End Get
		End Property
		Property Bln04Delivery As Double
			Get
				Return _bln04Delivery
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Bln04Delivery), _bln04Delivery, value)
			End Set
		End Property
		<PersistentAlias(NameOf(Bln04StokAwal) & " + " & NameOf(Bln04IncomingPcs) & " - " & NameOf(Bln04Delivery))> ReadOnly Property Bln04StokAkhir As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln04StokAkhir)))
			End Get
		End Property
		<PersistentAlias(NameOf(Bln04StokAkhir) & " / " & NameOf(Bln05Delivery))> ReadOnly Property Bln04StokRatio As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln04StokRatio)))
			End Get
		End Property

		' ========== Bln ke 5 ============
		<PersistentAlias(NameOf(Bln04StokAkhir))> ReadOnly Property Bln05StokAwal As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln05StokAwal)))
			End Get
		End Property
		Property Bln05Incoming As Double
			Get
				Return _bln05Incoming
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Bln05Incoming), _bln05Incoming, value)
			End Set
		End Property
		<PersistentAlias(NameOf(Bln05Incoming) & " * " & NameOf(LotPerBatang))> ReadOnly Property Bln05IncomingPcs As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln05IncomingPcs)))
			End Get
		End Property
		Property Bln05Delivery As Double
			Get
				Return _bln05Delivery
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Bln05Delivery), _bln05Delivery, value)
			End Set
		End Property
		<PersistentAlias(NameOf(Bln05StokAwal) & " + " & NameOf(Bln05IncomingPcs) & " - " & NameOf(Bln05Delivery))> ReadOnly Property Bln05StokAkhir As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln05StokAkhir)))
			End Get
		End Property
		<PersistentAlias(NameOf(Bln05StokAkhir) & " / " & NameOf(Bln06Delivery))> ReadOnly Property Bln05StokRatio As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln05StokRatio)))
			End Get
		End Property

		' ========== Bln ke 6 ============
		<PersistentAlias(NameOf(Bln05StokAkhir))> ReadOnly Property Bln06StokAwal As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln06StokAwal)))
			End Get
		End Property
		Property Bln06Incoming As Double
			Get
				Return _bln06Incoming
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Bln06Incoming), _bln06Incoming, value)
			End Set
		End Property
		<PersistentAlias(NameOf(Bln06Incoming) & " * " & NameOf(LotPerBatang))> ReadOnly Property Bln06IncomingPcs As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln06IncomingPcs)))
			End Get
		End Property
		Property Bln06Delivery As Double
			Get
				Return _bln06Delivery
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Bln06Delivery), _bln06Delivery, value)
			End Set
		End Property
		<PersistentAlias(NameOf(Bln06StokAwal) & " + " & NameOf(Bln06IncomingPcs) & " - " & NameOf(Bln06Delivery))> ReadOnly Property Bln06StokAkhir As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln06StokAkhir)))
			End Get
		End Property
		<PersistentAlias(NameOf(Bln06StokAkhir) & " / " & NameOf(Bln07Delivery))> ReadOnly Property Bln06StokRatio As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln06StokRatio)))
			End Get
		End Property

		' ========== Bln ke 7 ============
		<PersistentAlias(NameOf(Bln06StokAkhir))> ReadOnly Property Bln07StokAwal As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln07StokAwal)))
			End Get
		End Property
		Property Bln07Incoming As Double
			Get
				Return _bln07Incoming
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Bln07Incoming), _bln07Incoming, value)
			End Set
		End Property
		<PersistentAlias(NameOf(Bln07Incoming) & " * " & NameOf(LotPerBatang))> ReadOnly Property Bln07IncomingPcs As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln07IncomingPcs)))
			End Get
		End Property
		Property Bln07Delivery As Double
			Get
				Return _bln07Delivery
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Bln07Delivery), _bln07Delivery, value)
			End Set
		End Property
		<PersistentAlias(NameOf(Bln07StokAwal) & " + " & NameOf(Bln07IncomingPcs) & " - " & NameOf(Bln07Delivery))> ReadOnly Property Bln07StokAkhir As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln07StokAkhir)))
			End Get
		End Property
		<PersistentAlias(NameOf(Bln07StokAkhir) & " / " & NameOf(Bln08Delivery))> ReadOnly Property Bln07StokRatio As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln07StokRatio)))
			End Get
		End Property

		' ========== Bln ke 8 ============
		<PersistentAlias(NameOf(Bln07StokAkhir))> ReadOnly Property Bln08StokAwal As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln08StokAwal)))
			End Get
		End Property
		Property Bln08Incoming As Double
			Get
				Return _bln08Incoming
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Bln08Incoming), _bln08Incoming, value)
			End Set
		End Property
		<PersistentAlias(NameOf(Bln08Incoming) & " * " & NameOf(LotPerBatang))> ReadOnly Property Bln08IncomingPcs As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln08IncomingPcs)))
			End Get
		End Property
		Property Bln08Delivery As Double
			Get
				Return _bln08Delivery
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Bln08Delivery), _bln08Delivery, value)
			End Set
		End Property
		<PersistentAlias(NameOf(Bln08StokAwal) & " + " & NameOf(Bln08IncomingPcs) & " - " & NameOf(Bln08Delivery))> ReadOnly Property Bln08StokAkhir As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln08StokAkhir)))
			End Get
		End Property
		<PersistentAlias(NameOf(Bln08StokAkhir) & " / " & NameOf(Bln09Delivery))> ReadOnly Property Bln08StokRatio As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln08StokRatio)))
			End Get
		End Property

		' ========== Bln ke 9 ============
		<PersistentAlias(NameOf(Bln08StokAkhir))> ReadOnly Property Bln09StokAwal As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln09StokAwal)))
			End Get
		End Property
		Property Bln09Incoming As Double
			Get
				Return _bln09Incoming
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Bln09Incoming), _bln09Incoming, value)
			End Set
		End Property
		<PersistentAlias(NameOf(Bln09Incoming) & " * " & NameOf(LotPerBatang))> ReadOnly Property Bln09IncomingPcs As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln09IncomingPcs)))
			End Get
		End Property
		Property Bln09Delivery As Double
			Get
				Return _bln09Delivery
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Bln09Delivery), _bln09Delivery, value)
			End Set
		End Property
		<PersistentAlias(NameOf(Bln09StokAwal) & " + " & NameOf(Bln09IncomingPcs) & " - " & NameOf(Bln09Delivery))> ReadOnly Property Bln09StokAkhir As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln09StokAkhir)))
			End Get
		End Property
		<PersistentAlias("0")> ReadOnly Property Bln09StokRatio As Double
			Get
				Return Convert.ToDouble(EvaluateAlias(NameOf(Bln09StokRatio)))
			End Get
		End Property

		<PersistentAlias("GetYear(" & NameOf(Tanggal) & ")")> ReadOnly Property Tahun As Integer
			Get
				Return Convert.ToInt32(EvaluateAlias(NameOf(Tahun)))
			End Get
		End Property
		<PersistentAlias("Concat(GetYear(" & NameOf(Tanggal) & "),'-',GetMonth(" & NameOf(Tanggal) & "),'-01')")> ReadOnly Property Bulan As Date
			Get
				Return Convert.ToDateTime(EvaluateAlias(NameOf(Bulan)))
			End Get
		End Property
		<NonPersistent> Property DetailForSave As List(Of Fusoh_Forecast_Model_Detail)
	End Class

	Friend Class Fusoh_Forecast_Model
		Property Tanggal As Date
		Property Customer As Kontak
		Property BahanJadi As Fusoh_Barang
		Property BahanBaku As Fusoh_Barang
		Property LotPerBatang As Double
		Property StokAwalBahanJadi As Double
		Property StokAwalBahanBaku As Double
		Property Detail As List(Of Fusoh_Forecast_Model_Detail)
	End Class
	Friend Class Fusoh_Forecast_Model_Detail
		Property Main As Fusoh_Forecast_Model
		Property Urutan As Integer
		Property StokAwal As Double
		Property IncomingBatang As Double
		Property Delivery As Double
		Property DeliveryBulanDepan As Double

		ReadOnly Property Bulan As Date
			Get
				Return Main.Tanggal.AddMonths(Urutan)
			End Get
		End Property
		ReadOnly Property IncomingPcs As Double
			Get
				Return Main.LotPerBatang * IncomingBatang
			End Get
		End Property
		ReadOnly Property StokAkhir As Double
			Get
				Return StokAwal + IncomingPcs - Delivery
			End Get
		End Property
		ReadOnly Property StokRatio As Double
			Get
				If DeliveryBulanDepan <> 0 Then
					Return StokAkhir / DeliveryBulanDepan
				Else
					Return 0
				End If
			End Get
		End Property
	End Class
End Namespace

Namespace Service
	Friend Class Fusoh_Forecast_Service
		Inherits ServiceBase(Of Fusoh_Forecast)

		Protected Friend Sub New(connection As UnitOfWork)
			MyBase.New(connection)
		End Sub
		Protected Friend Sub New(connection As UnitOfWork, dataOriginalEdit As Fusoh_Forecast)
			MyBase.New(connection, dataOriginalEdit)
		End Sub

		Protected Friend Overrides Function CheckBeforeDelete(obj As Fusoh_Forecast) As Boolean
			CheckIsInUse(uow, obj)
			Return True
		End Function
		Protected Friend Overrides Function CheckBeforeSave(obj As Fusoh_Forecast) As Boolean
			If obj.Customer Is Nothing Then
				Throw New Utils.Exception("Masukkan customer", -1)
				Return False
			End If
			If obj.Tanggal = Nothing Then
				Throw New Utils.Exception("Masukkan tanggal", -2)
				Return False
			End If
			If obj.BahanJadi Is Nothing Then
				Throw New Utils.Exception("Masukkan bahan jadi (finish good)", -3)
				Return False
			End If
			If obj.BahanBaku Is Nothing Then
				Throw New Utils.Exception("Masukkan bahan baku (material)", -4, "")
				Return False
			End If
			If obj.LotPerBatang = Nothing Then
				Throw New Utils.Exception("Lot per batang tidak boleh 0", -5, "")
				Return False
			End If

			Return True
		End Function

    Protected Friend Overrides Sub SaveAction(obj As Fusoh_Forecast)
      For Each detail In obj.DetailForSave
        Select Case detail.Urutan
          Case 1
            obj.Bln01Incoming = detail.IncomingBatang
            obj.Bln01Delivery = detail.Delivery
          Case 2
            obj.Bln02Incoming = detail.IncomingBatang
            obj.Bln02Delivery = detail.Delivery
          Case 3
            obj.Bln03Incoming = detail.IncomingBatang
            obj.Bln03Delivery = detail.Delivery
          Case 4
            obj.Bln04Incoming = detail.IncomingBatang
            obj.Bln04Delivery = detail.Delivery
          Case 5
            obj.Bln05Incoming = detail.IncomingBatang
            obj.Bln05Delivery = detail.Delivery
          Case 6
            obj.Bln06Incoming = detail.IncomingBatang
            obj.Bln06Delivery = detail.Delivery
          Case 7
            obj.Bln07Incoming = detail.IncomingBatang
            obj.Bln07Delivery = detail.Delivery
          Case 8
            obj.Bln08Incoming = detail.IncomingBatang
            obj.Bln08Delivery = detail.Delivery
          Case 9
            obj.Bln09Incoming = detail.IncomingBatang
            obj.Bln09Delivery = detail.Delivery
        End Select
      Next

      '======= Simple log
      If _dataOriginalEdit Is Nothing Then
        Core.SSystem.DatabaseLog.SaveSimpleLog(uow, DatabaseLog.Action.Tambah, "Data Forecast -> " & obj.BahanBaku.Kode)
      Else
        Core.SSystem.DatabaseLog.SaveSimpleLog(uow, DatabaseLog.Action.Edit, "Data Forecast -> " & obj.BahanBaku.Kode)
      End If
    End Sub

    Friend Shared Function GetItem(obj As Fusoh_Forecast) As Fusoh_Forecast_Model
			Dim result As New Fusoh_Forecast_Model
			result.Tanggal = obj.Tanggal
			result.Customer = obj.Customer
			result.BahanJadi = obj.BahanJadi
			result.BahanBaku = obj.BahanBaku
			result.LotPerBatang = obj.LotPerBatang
			result.StokAwalBahanJadi = obj.StokAwalBahanJadi
			result.StokAwalBahanBaku = obj.StokAwalBahanBaku
			result.Detail = New List(Of Fusoh_Forecast_Model_Detail)

			For i = 1 To 9
				Dim item = New Fusoh_Forecast_Model_Detail
				item.Main = result
				item.Urutan = i
				item.StokAwal = obj.GetType().GetProperty("Bln" & i.ToString("00") & "StokAwal").GetValue(obj)
				item.IncomingBatang = obj.GetType().GetProperty("Bln" & i.ToString("00") & "Incoming").GetValue(obj)
				item.Delivery = obj.GetType().GetProperty("Bln" & i.ToString("00") & "Delivery").GetValue(obj)
				If i = 9 Then
					item.DeliveryBulanDepan = 0
				Else
					item.DeliveryBulanDepan = obj.GetType().GetProperty("Bln" & (i + 1).ToString("00") & "Delivery").GetValue(obj)
				End If
				result.Detail.Add(item)
			Next

			Return result
		End Function
		Friend Shared Sub CheckIsInUse(session As UnitOfWork, obj As Fusoh_Forecast)
			'If Not obj.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
			'	Throw New Utils.Exception(String.Format("Data exim {0} tidak bisa dihapus, karena sudah status transaksi bukan pending.", obj.Kode), -2)
			'End If
			'If NuSoft001.Persistent.Periode.CheckLockedPeriod(session, obj.Tanggal) Then
			'	Throw New Utils.Exception(String.Format("Data exim {0} tidak bisa dihapus, karena periode akuntansi sudah ditutup.", obj.Kode), -2)
			'End If
			'If (Not session.FindObject(Of Persistent_FusohInvoicePembelian)(New BinaryOperator(NameOf(Persistent_FusohInvoicePembelian.NoExim), obj, BinaryOperatorType.Equal)) Is Nothing) Then
			'	Throw New Utils.Exception(String.Format("Data exim {0} tidak bisa dihapus, karena sudah masuk di invoice pembelian.", obj.Kode), -2)
			'End If
		End Sub

		Friend Shared Sub SetDataByTanggalAndBahan(session As UnitOfWork, obj As Fusoh_Forecast_Model)
			If obj.Tanggal = Nothing Then Return
			If obj.BahanBaku Is Nothing Then Return
			If obj.BahanJadi Is Nothing Then Return

			' get stok bahan jadi
			obj.StokAwalBahanJadi = New XPQuery(Of Fusoh_PenerimaanBarangDetail)(session) _
				.Where(Function(w) w.Barang Is obj.BahanJadi AndAlso w.Main.Tanggal.Date <= obj.Tanggal.Date) _
				.Sum(Function(s) s.Qty - s.QtyOut)
			' get stok bahan baku
			obj.StokAwalBahanBaku = New XPQuery(Of Fusoh_PenerimaanBarangDetail)(session) _
				.Where(Function(w) w.Barang Is obj.BahanBaku AndAlso w.Main.Tanggal.Date <= obj.Tanggal.Date) _
				.Sum(Function(s) s.Qty - s.QtyOut)
			' get history lot per batang
			Dim history = New XPQuery(Of Fusoh_Forecast)(session) _
				.Where(Function(w) w.BahanJadi Is obj.BahanJadi AndAlso w.BahanBaku Is obj.BahanBaku AndAlso w.Tanggal.Date < obj.Tanggal.Date) _
				.SingleOrDefault
			If Not history Is Nothing Then obj.LotPerBatang = history.LotPerBatang

			SetDetailData(obj)
		End Sub
		Friend Shared Sub SetDetailData(obj As Fusoh_Forecast_Model)
			If obj.Detail Is Nothing Then obj.Detail = New List(Of Fusoh_Forecast_Model_Detail)
			For i = 1 To 9
				Dim urutan = i
				Dim item = obj.Detail.Find(Function(f) f.Urutan = urutan)
				If item Is Nothing Then
					item = New Fusoh_Forecast_Model_Detail() With {.Main = obj, .Urutan = urutan}
					obj.Detail.Add(item)
				End If

				' set stok awal
				If i = 1 Then
					item.StokAwal = (obj.StokAwalBahanBaku * obj.LotPerBatang) + obj.StokAwalBahanJadi
				Else
					Dim sebelumnya = obj.Detail.Find(Function(f) f.Urutan = urutan - 1)
					If Not sebelumnya Is Nothing Then item.StokAwal = sebelumnya.StokAkhir
				End If
			Next

			For i = 1 To 9
				Dim urutan = i
				Dim item = obj.Detail.Find(Function(f) f.Urutan = urutan)

				' set delivery bln depan utk stok ratio
				If i = 9 Then
					item.DeliveryBulanDepan = 0
				Else
					Dim blnDepan = obj.Detail.Find(Function(f) f.Urutan = urutan + 1)
					If Not blnDepan Is Nothing Then item.DeliveryBulanDepan = blnDepan.Delivery
				End If
			Next
		End Sub
	End Class
End Namespace