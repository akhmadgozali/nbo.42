Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent_Fusoh

Namespace Service_Fusoh
	Friend Class Service_FusohExim
		Inherits ServiceBase(Of Persistent_FusohExim)

		Protected Friend Sub New(connection As UnitOfWork)
			MyBase.New(connection)
		End Sub
		Protected Friend Sub New(connection As UnitOfWork, dataOriginalEdit As Persistent_FusohExim)
			MyBase.New(connection, dataOriginalEdit)
		End Sub

		Protected Friend Overrides Function CheckBeforeDelete(obj As Persistent_FusohExim) As Boolean
			CheckIsInUse(uow, obj)
			Return True
		End Function
		Protected Friend Overrides Function CheckBeforeSave(obj As Persistent_FusohExim) As Boolean
			Dim statusLolos = New List(Of NuSoft001.Persistent.StatusTransaksiEnum)
			statusLolos.Add(NuSoft001.Persistent.StatusTransaksiEnum.Pending)
			statusLolos.Add(NuSoft001.Persistent.StatusTransaksiEnum.Posting)
			statusLolos.Add(NuSoft001.Persistent.StatusTransaksiEnum.ReqApprove)

			If Not statusLolos.Contains(obj.StatusTransaksi) Then
				Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", 0)
				Return False
			End If
			If obj.Regional Is Nothing Then
				Throw New Utils.Exception("Masukkan regional", -1)
				Return False
			End If
			If obj.Tanggal = Nothing Then
				Throw New Utils.Exception("Masukkan tanggal", -2)
				Return False
			End If
			If obj.Vendor Is Nothing Then
				Throw New Utils.Exception("Masukkan Vendor", -3)
				Return False
			End If
			If obj.PO Is Nothing Then
				Throw New Utils.Exception("Masukkan PO", -4, "")
				Return False
			End If
			If uow.IsNewObject(obj) AndAlso (Not obj.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending) AndAlso (Not obj.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting) Then
				Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", -5)
				Return False
			End If

			For Each det In obj.DetailForSave
				If det.PODetail Is Nothing Then
					Throw New Utils.Exception("Masukkan po detail", -99)
					Return False
				End If
				If det.Barang Is Nothing Then
					Throw New Utils.Exception("Masukkan kode barang", -99)
					Return False
				End If
				If det.Qty = 0 Then
					Throw New Utils.Exception("Masukkan qty", -99)
					Return False
				End If

				For Each ser In det.SerialForSave
					If ser.Serial = Nothing Then
						Throw New Utils.Exception("Masukkan nomor serial", -99)
						Return False
					End If
				Next
			Next

			If (Not uow.IsNewObject(obj) AndAlso _dataOriginalEdit.Kode = obj.Kode) Then Return True
			If (Not String.IsNullOrEmpty(obj.Kode) AndAlso Not uow.FindObject(Of Persistent_FusohExim)(New BinaryOperator(NameOf(Persistent_FusohExim.Kode), obj.Kode, BinaryOperatorType.Equal)) Is Nothing) Then
				Throw New Utils.Exception("Kode pembayaran sudah ada yang memakai.\r\nSilahkan ganti dengan kode yang lain", -6)
			End If
			Return True
		End Function

		Protected Friend Overrides Sub BeforeDeleteAction(obj As Persistent_FusohExim)
			obj.PO.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
		End Sub
		Protected Friend Overrides Sub SaveAction(obj As Persistent_FusohExim)
			Dim sumber = New Persistent.SumberDataCollection(uow)
			Dim setting = New NuSoft001.Logic.FinaSetting(uow)

			obj.Sumber = sumber.GetObject(Persistent.SumberDataJenis.EX)
			obj.Number = New Logic.NumberClass(uow) With {.FormatNomor = setting.FormatNomor}
			If (String.IsNullOrEmpty(obj.Kode)) Then
				obj.Kode = obj.Number.GetNewNumber.Kode
			End If

			'==== set selesai di PO
			obj.PO.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish

			' Delete detail
			For i = obj.Detail.Count - 1 To 0 Step -1
				Dim detail = obj.Detail(i)
				Dim find = obj.DetailForSave.Find(Function(f) f.PODetail Is detail.PODetail)
				If (find Is Nothing) Then
					obj.Detail.Remove(detail)
					detail.Delete()
				Else
					'Delete detail serial
					For j = detail.Detail.Count - 1 To 0 Step -1
						Dim ser = detail.Detail(j)
						Dim foundSerial = find.SerialForSave.Find(Function(o) o.Serial = ser.Serial)
						If (foundSerial Is Nothing) Then
							detail.Detail.Remove(ser)
							ser.Delete()
						End If
					Next
				End If
			Next

			' Insert Update
			For Each detail In obj.DetailForSave
				Dim find = obj.Detail.ToList().Find(Function(f) f.PODetail Is detail.PODetail)
				If (find Is Nothing) Then find = New Persistent_FusohEximDetail(uow) With {.Main = obj, .PODetail = detail.PODetail}
				find.Barang = detail.Barang
				find.Satuan = detail.Satuan
				find.Qty = detail.Qty
				find.OutDiameter = detail.OutDiameter
				find.InDiameter = detail.InDiameter
				find.Thickness = detail.Thickness
				find.Length = detail.Length
				find.Weight = detail.Weight
				find.Catatan = detail.Catatan

				'Insert Update Serial
				For Each ser In detail.SerialForSave
					Dim foundSerial = find.Detail.ToList().Find(Function(o) o.Serial = ser.Serial)
					If (foundSerial Is Nothing) Then foundSerial = New Persistent_FusohEximDetailSerial(uow) With {.Main = find, .Serial = ser.Serial}
					foundSerial.Barang = find.Barang
					foundSerial.MillSheet = ser.MillSheet
					foundSerial.LengthIn = ser.LengthIn
				Next
			Next
		End Sub

		Friend Shared Function GetItem(session As UnitOfWork, obj As Persistent_FusohExim) As Persistent_FusohExim
			Dim temp As New List(Of Persistent_FusohEximDetail_ForSave)
			For Each detail In obj.Detail
				Dim item = New Persistent_FusohEximDetail_ForSave() With {
					.Id = detail.Id,
					.PODetail = detail.PODetail,
					.Barang = detail.Barang,
					.Satuan = detail.Satuan,
					.Qty = detail.Qty,
					.OutDiameter = detail.OutDiameter,
					.InDiameter = detail.InDiameter,
					.Thickness = detail.Thickness,
					.Length = detail.Length,
					.Weight = detail.Weight,
					.Catatan = detail.Catatan
				}
				For Each ser In detail.Detail
					item.SerialForSave = New List(Of Persistent_FusohEximDetailSerial_ForSave)
					item.SerialForSave.Add(New Persistent_FusohEximDetailSerial_ForSave() With {
						.Id = ser.Id,
						.Barang = ser.Barang,
						.Serial = ser.Serial,
						.LengthIn = ser.LengthIn,
						.MillSheet = ser.MillSheet
					})
				Next
				temp.Add(item)
			Next

			obj.DetailForSave = temp
			Return obj
		End Function
		Friend Shared Sub CheckIsInUse(session As UnitOfWork, obj As Persistent_FusohExim)
			If Not obj.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
				Throw New Utils.Exception(String.Format("Data exim {0} tidak bisa dihapus, karena sudah status transaksi bukan pending.", obj.Kode), -2)
			End If
			If NuSoft001.Persistent.Periode.CheckLockedPeriod(session, obj.Tanggal) Then
				Throw New Utils.Exception(String.Format("Data exim {0} tidak bisa dihapus, karena periode akuntansi sudah ditutup.", obj.Kode), -2)
			End If
			If (Not session.FindObject(Of Persistent_FusohInvoicePembelian)(New BinaryOperator(NameOf(Persistent_FusohInvoicePembelian.NoExim), obj, BinaryOperatorType.Equal)) Is Nothing) Then
				Throw New Utils.Exception(String.Format("Data exim {0} tidak bisa dihapus, karena sudah masuk di invoice pembelian.", obj.Kode), -2)
			End If
		End Sub
	End Class
End Namespace