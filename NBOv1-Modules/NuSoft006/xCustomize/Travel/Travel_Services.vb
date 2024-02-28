Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports NuSoft.NPO
Imports NuSoft.NPO.Modules.ModSys
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Logic
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Logic
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Travel.Persistent

Namespace Travel.Services
	Friend Class TravelDownPaymentServices
		Public Shared Function GetNomor(session As UnitOfWork, setting As FinaSetting, tanggal As Date, regional As Regional) As String
			Dim mask = TravelNomorServices.GetGeneralMaskNomor(setting.FormatNomor, tanggal, regional, SumberDataJenis.DP)
			Return TravelNomorServices.GetNomorGeneral(Of Travel_DownPayment)(session, mask, NameOf(Travel_DownPayment.Kode), True)
		End Function
		Public Shared Sub SetGL(item As Travel_DownPayment, finaSetting As FinaSetting, salesSetting As SalesSetting)
			If item.Gl Is Nothing Then item.Gl = New GlMain(item.Session)

			'buatkan jurnalnya
			Dim sumber = New SumberDataCollection(item.Session)

			item.Gl.Sumber = sumber.GetObject(SumberDataJenis.DP)
			item.Gl.Tanggal = item.Tanggal
			item.Gl.Regional = item.Regional
			item.Gl.Kode = item.Kode
			item.Gl.ModuleId = NPO.Modules.ModuleId.Sales
			item.Gl.MataUang = item.Uang.Simbol
			item.Gl.Kurs = item.Kurs
			item.Gl.Kontak = item.Pelanggan
			item.Gl.KontakNama = item.Pelanggan.Nama
			item.Gl.Uraian = item.Uraian

			Dim i As Byte = 1
			'Kas/Bank (D)
			TravelGLServices.SimpanGL(item.Gl, finaSetting, item.AkunKasBank, i, item.NominalKurs, 0, item.Nominal, 0, item.Kurs, Nothing, Nothing, String.Empty)
			'Pendapatan Diterima dimuka (K)
			i += 1
			TravelGLServices.SimpanGL(item.Gl, finaSetting, item.Uang.UMPenjualan, i, 0, item.NominalKurs, 0, item.Nominal, item.Kurs, Nothing, Nothing, String.Empty)
		End Sub
	End Class
	Friend Class TravelInvoiceServices
		Public Shared Sub SetGL(item As Travel_Invoice, finaSetting As FinaSetting, salesSetting As SalesSetting)
			If item.Gl Is Nothing Then item.Gl = New GlMain(item.Session)

			'buatkan jurnalnya
			item.Gl.Sumber = item.Sumber
			item.Gl.Tanggal = item.Tanggal
			item.Gl.Regional = item.Regional
			item.Gl.Kode = item.Kode
			item.Gl.ModuleId = NPO.Modules.ModuleId.Sales
			item.Gl.MataUang = item.Uang.Simbol
			item.Gl.Kurs = item.Kurs
			item.Gl.Kontak = item.Pelanggan
			item.Gl.KontakNama = item.Pelanggan.Nama
			item.Gl.Uraian = item.Uraian

			Dim xCoaPiutang As NuSoft001.Persistent.Coa
			Dim pRegional = item.Session.GetObjectByKey(Of xRegional)(item.Regional.Id)
			If salesSetting.SetingARRegional = False Then
				xCoaPiutang = item.Uang.PiutangDagang
			Else
				xCoaPiutang = item.Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(pRegional.CoaAR))
			End If

			Dim i As Byte = 1
			'Piutang Dagang  (D) 
			TravelGLServices.SimpanGL(item.Gl, finaSetting, xCoaPiutang, i, item.TotalKurs, 0, item.Total, 0, item.Kurs, Nothing, Nothing, String.Empty)

			'DP (D)
			If item.NominalDP > 0 Then
				Dim DPAwalKurs = item.TravelOrder.DaftarDownPayment.Sum(Function(s) s.NominalKurs)
				Dim DPinInvoice = item.NominalDP * item.Kurs
				Dim selisih = DPinInvoice - DPAwalKurs

				Dim a = From z In item.TravelOrder.DaftarDownPayment Group z By z.Uang.UMPenjualan Into Group Select UMPenjualan, Nominal = Group.Sum(Function(x) x.Nominal), NominalKurs = Group.Sum(Function(x) x.NominalKurs)
				For Each x In a
					i += 1
					TravelGLServices.SimpanGL(item.Gl, finaSetting, x.UMPenjualan, i, x.NominalKurs, 0, x.Nominal, 0, x.NominalKurs / x.Nominal, Nothing, Nothing, String.Empty)
				Next

				'jika ada selisih kurs dari DP
				If selisih <> 0 Then
					i += 1
					If selisih < 0 Then 'laba selisih kurs [K]
						Dim akunLabaKurs = item.Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaLabaSelisihKurs))
						TravelGLServices.SimpanGL(item.Gl, finaSetting, akunLabaKurs, i, 0, Math.Abs(selisih), 0, 0, 0, Nothing, Nothing, String.Empty)
					Else                'rugi selisih kurs [D]
						Dim akunRugiKurs = item.Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaRugiSelisihKurs))
						TravelGLServices.SimpanGL(item.Gl, finaSetting, akunRugiKurs, i, Math.Abs(selisih), 0, 0, 0, 0, Nothing, Nothing, String.Empty)
					End If
				End If
			End If

			'Pendapatan (K) -> ambilkan dari seting coa master
			Dim b = From z In item.Detail Group z By z.Barang.CoaIncome, z.Proyek Into Group Select Proyek, CoaIncome, SubTotal = Group.Sum(Function(x) x.SubTotal), SubTotalKurs = Group.Sum(Function(x) x.SubTotal * item.Kurs)
			For Each x In b
				i = i + 1
				TravelGLServices.SimpanGL(item.Gl, finaSetting, x.CoaIncome, i, 0, x.SubTotalKurs, 0, x.SubTotal, item.Kurs, Nothing, x.Proyek, String.Empty)
			Next
		End Sub
	End Class
	Friend Class TravelPembayaranServices
		Public Shared Sub SetGL(item As Travel_PembayaranInvoice, finaSetting As FinaSetting, salesSetting As SalesSetting)
			If item.Gl Is Nothing Then item.Gl = New GlMain(item.Session)

			'buatkan jurnalnya
			item.Gl.Sumber = item.Sumber
			item.Gl.Tanggal = item.Tanggal
			item.Gl.Regional = item.Regional
			item.Gl.Kode = item.Kode
			item.Gl.ModuleId = NPO.Modules.ModuleId.Sales
			item.Gl.MataUang = item.coakasbank.MataUang.Simbol
			item.Gl.Kurs = item.Kurs
			item.Gl.Kontak = item.Pelanggan
			item.Gl.KontakNama = item.Pelanggan.Nama
			item.Gl.Uraian = item.Uraian

			Dim i As Byte = 1
			'Kas/Bank (D)
			'Biaya Admin(D)
			'PPH(D)
			'Pembulatan(K / D)
			'Pendapatan(K)
			'Piutang(K)
			'Kas/Bank  (D) 

			i = 1 'Kas/Bank (D)
			TravelGLServices.SimpanGL(item.Gl, finaSetting, item.coakasbank, i, item.Total, 0, item.TotalValas, 0, item.Kurs, Nothing, Nothing, String.Empty)

			If item.TotalAdminBank > 0 Then 'Biaya Admin Bank (D)
				i += 1
				Dim akunAdminBank = item.Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaAdminBank))
				TravelGLServices.SimpanGL(item.Gl, finaSetting, akunAdminBank, i, item.TotalAdminBank * item.Kurs, 0, item.TotalAdminBank, 0, item.Kurs, Nothing, Nothing, String.Empty)
			End If
			If item.TotalPPH > 0 Then 'PPH 23(D)
				i += 1
				Dim akunPPh = item.Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaPPH))
				TravelGLServices.SimpanGL(item.Gl, finaSetting, akunPPh, i, item.TotalPPH * item.Kurs, 0, item.TotalPPH, 0, item.Kurs, Nothing, Nothing, String.Empty)
			End If
			If item.TotalPembulatan > 0 Then 'Pembulatan (D/K)
				i += 1
				Dim akunPembulatan = item.Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaBiayaPembulatan))
				TravelGLServices.SimpanGL(item.Gl, finaSetting, akunPembulatan, i, 0, item.TotalPembulatan * item.Kurs, 0, item.TotalPembulatan, item.Kurs, Nothing, Nothing, String.Empty)
			ElseIf item.TotalPembulatan < 0 Then
				i += 1
				Dim akunPembulatan = item.Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaBiayaPembulatan))
				TravelGLServices.SimpanGL(item.Gl, finaSetting, akunPembulatan, i, item.TotalPembulatan * item.Kurs, 0, item.TotalPembulatan, 0, item.Kurs, Nothing, Nothing, String.Empty)
			End If
			If item.TotalDiscount > 0 Then 'Pendapatan (K)
				i += 1
				Dim akunPendapatanLain = item.Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaPendapatan))
				TravelGLServices.SimpanGL(item.Gl, finaSetting, akunPendapatanLain, i, 0, item.TotalDiscount * item.Kurs, 0, item.TotalDiscount, item.Kurs, Nothing, Nothing, String.Empty)
			End If

      'Piutang (K)
      Dim a = From z In item.Detail Group z By z.NoInvoice.Uang.PiutangDagang Into Group
              Select PiutangDagang,
              BayarKursInvoice = Group.Sum(Function(x) x.NilaiBayarCash * x.NoInvoice.Kurs),
              BayarKurs = Group.Sum(Function(x) x.NilaiBayarCash * x.Kurs),
              Bayar = Group.Sum(Function(x) x.NilaiBayarCash)
      For Each x In a
        i += 1
        'Piutang ikut kurs awal
        TravelGLServices.SimpanGL(item.Gl, finaSetting, x.PiutangDagang, i, 0, x.BayarKursInvoice, 0, x.Bayar, x.BayarKursInvoice / x.Bayar, Nothing, Nothing, String.Empty)
        'cek selisih kurs
        Dim selisih = x.BayarKurs - x.BayarKursInvoice
        'MsgBox("Nilai Invoice : " & x.BayarKursInvoice & " --> Nilai Pembayaran : " & x.BayarKurs)
        If selisih > 0 Then 'laba selisih kurs [K]
          i += 1
          Dim akunLabaSelisihKurs = item.Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaLabaSelisihKurs))
          TravelGLServices.SimpanGL(item.Gl, finaSetting, akunLabaSelisihKurs, i, 0, selisih, 0, 0, 0, Nothing, Nothing, String.Empty)
        ElseIf selisih < 0 Then 'rugi selisih kurs [D]
          i += 1
          Dim akunRugiSelisihKurs = item.Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaRugiSelisihKurs))
          TravelGLServices.SimpanGL(item.Gl, finaSetting, akunRugiSelisihKurs, i, Math.Abs(selisih), 0, 0, 0, 0, Nothing, Nothing, String.Empty)
        End If
      Next

      If item.Gl.Detail.Count > i Then
        For pi = i To item.Gl.Detail.Count - 1 Step -1
          item.Gl.Detail(i).Delete()
        Next
      End If

    End Sub
	End Class
	Friend Class TravelRefundServices
		Public Shared Sub SetGL(item As Travel_PembayaranInvoice, finaSetting As FinaSetting, salesSetting As SalesSetting)
			If item.Gl Is Nothing Then item.Gl = New GlMain(item.Session)

			'buatkan jurnalnya
			item.Gl.Sumber = item.Sumber
			item.Gl.Tanggal = item.Tanggal
			item.Gl.Regional = item.Regional
			item.Gl.Kode = item.Kode
			item.Gl.ModuleId = NPO.Modules.ModuleId.Sales
			item.Gl.MataUang = item.coakasbank.MataUang.Simbol
			item.Gl.Kurs = item.Kurs
			item.Gl.Kontak = item.Pelanggan
			item.Gl.KontakNama = item.Pelanggan.Nama
			item.Gl.Uraian = item.Uraian

			Dim i As Byte = 0
			'Retur (D) 
			'Kas/Bank (K)

			'Retur (D) => kurs pake pada saat invoice
			Dim hitungRetur As New List(Of PembagianRetur)
			For Each x In item.Detail
				Dim grouping = x.NoInvoice.Detail.GroupBy(Function(g) New With {g.Barang.CoaReturnIn, g.Proyek}) _
					.Select(Function(s) New With {.CoaRetur = s.Key.CoaReturnIn, .Proyek = s.Key.Proyek, .SubTotal = s.Sum(Function(y) y.SubTotal)})
				For Each z In grouping
					Dim prosentase = z.SubTotal / x.NoInvoice.SubTotal
					hitungRetur.Add(New PembagianRetur() With {.Akun = z.CoaRetur, .Proyek = z.Proyek, .Kurs = x.NoInvoice.Kurs, .Total = prosentase * x.NilaiBayarRetur})
				Next
			Next

			For Each x In hitungRetur
				i += 1
				TravelGLServices.SimpanGL(item.Gl, finaSetting, x.Akun, i, x.Total * x.Kurs, 0, x.Total, 0, x.Kurs, Nothing, x.Proyek, String.Empty)
			Next

			'Selisih Kurs (D/K)
			Dim selisih = hitungRetur.Sum(Function(s) s.Total * s.Kurs) - item.Total
			If selisih > 0 Then 'laba selisih kurs [K]
				i += 1
				Dim akunLabaSelisihKurs = item.Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaLabaSelisihKurs))
				TravelGLServices.SimpanGL(item.Gl, finaSetting, akunLabaSelisihKurs, i, 0, selisih, 0, 0, 0, Nothing, Nothing, String.Empty)
			ElseIf selisih < 0 Then 'rugi selisih kurs [D]
				i += 1
				Dim akunRugiSelisihKurs = item.Session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(salesSetting.CoaRugiSelisihKurs))
				TravelGLServices.SimpanGL(item.Gl, finaSetting, akunRugiSelisihKurs, i, Math.Abs(selisih), 0, 0, 0, 0, Nothing, Nothing, String.Empty)
			End If

			'Kas/Bank (K)
			i += 1
			TravelGLServices.SimpanGL(item.Gl, finaSetting, item.coakasbank, i, 0, item.Total, 0, item.TotalValas, item.Kurs, Nothing, Nothing, String.Empty)
		End Sub
		Private Structure PembagianRetur
			Property Akun As NuSoft001.Persistent.Coa
			Property Proyek As NuSoft001.Persistent.Proyek
			Property Total As Double
			Property Kurs As Double
		End Structure
	End Class
	Friend Class TravelNomorServices
		Public Const KodeFormatTahun4 As String = "[Y4]"
		Public Const KodeFormatTahun2 As String = "[Y2]"
		Public Const KodeFormatBulan0 As String = "[M0]"
		Public Const KodeFormatBulanRomawi As String = "[Mr]"
		Public Const KodeFormatRegional As String = "[R]"
		Public Const KodeFormatSumber As String = "[S]"
		Public Const KodeFormatAngka As String = "[X{0}]"
		Public Const MaskAngka As String = "\\d"
		Public Const SpecialMaskDot As String = "\\."
		Public Const SpecialFormatDot As String = "."

		Public Shared Function CountSameString(source As String, separator As String) As Integer
			Dim d = source.Split(New String() {separator}, StringSplitOptions.None)
			Return d.GetUpperBound(0)
		End Function
		Public Shared Function GetGeneralMaskNomor(format As String, tanggal As Date, regional As Regional, sumber As SumberDataJenis) As String
			If (format.Contains(KodeFormatTahun2)) Then format = format.Replace(KodeFormatTahun2, tanggal.ToString("yy"))
			If (format.Contains(KodeFormatTahun4)) Then format = format.Replace(KodeFormatTahun4, tanggal.ToString("yyyy"))
			If (format.Contains(KodeFormatBulan0)) Then format = format.Replace(KodeFormatBulan0, tanggal.ToString("MM"))
			If (format.Contains(KodeFormatBulanRomawi)) Then format = format.Replace(KodeFormatBulanRomawi, Utils.Common.Number.ConvertNumberToRoman(Integer.Parse(tanggal.ToString("MM"))))
			If (format.Contains(KodeFormatRegional)) Then format = format.Replace(KodeFormatRegional, regional.Kode)
			If (format.Contains(KodeFormatSumber)) Then format = format.Replace(KodeFormatSumber, sumber.ToString)
			If (format.Contains(SpecialFormatDot)) Then format = format.Replace(SpecialFormatDot, SpecialMaskDot)

			For i = 1 To 9
				If (format.Contains(String.Format(KodeFormatAngka, i))) Then
					format = format.Replace(String.Format(KodeFormatAngka, i), Utils.Common.Character.DuplicateString(MaskAngka, i))
					Exit For
				End If
			Next

			Return format
		End Function
		Public Shared Function GetNomorGeneral(Of T)(session As UnitOfWork, maskNomor As String, namaField As String, berurutan As Boolean) As String
			Dim banyakDigit As Integer = CountSameString(maskNomor, MaskAngka)
			Dim formatDigit As String = Utils.Common.Character.DuplicateString(MaskAngka, banyakDigit)
			Dim formatCriteria As String = maskNomor.Replace(formatDigit, "")
			maskNomor = RemoveSpecialMask(maskNomor)

			'	// lihat posisi urutan
			Dim posisiNomor = maskNomor.IndexOf(formatDigit)
			Dim criteria As CriteriaOperator
			If (posisiNomor = 0) Then '// nomornya diawal
				criteria = New FunctionOperator(FunctionOperatorType.EndsWith, New OperandProperty(namaField), New OperandValue(formatCriteria))
			ElseIf (maskNomor.Length = posisiNomor + formatDigit.Length) Then '// nomornya di akhir
				criteria = New FunctionOperator(FunctionOperatorType.StartsWith, New OperandProperty(namaField), New OperandValue(formatCriteria))
			Else '// nomornya ditengah
				Dim filterAwal = maskNomor.Substring(0, posisiNomor)
				Dim filterAkhir = maskNomor.Substring(posisiNomor + formatDigit.Length)
				criteria = New GroupOperator(GroupOperatorType.And,
					New FunctionOperator(FunctionOperatorType.StartsWith, New OperandProperty(namaField), New OperandValue(filterAwal)),
					New FunctionOperator(FunctionOperatorType.EndsWith, New OperandProperty(namaField), New OperandValue(filterAkhir)))
			End If

			Dim sort = New SortProperty(namaField, SortingDirection.Descending)
			Dim dataTerakhir = New XPCollection(Of T)(session, criteria, sort)
			dataTerakhir.DisplayableProperties = namaField

			If dataTerakhir.Count < 1 Then
				Return CombineNomor(maskNomor, banyakDigit, 1)
			Else
				Dim x = CType(CType(dataTerakhir(0), Object), NPOBase)
				Dim angkaTerakhir = Integer.Parse(x.ClassInfo.GetMember(namaField).GetValue(x).ToString().Substring(posisiNomor, banyakDigit).Replace("_", "0"))
				If berurutan Then
					Return CombineNomor(maskNomor, banyakDigit, angkaTerakhir + 1)
				Else
					'// list angka
					Dim listData = New List(Of Integer)
					For Each zz In dataTerakhir
						Dim xx = CType(CType(zz, Object), NPOBase)
						listData.Add(Integer.Parse(xx.ClassInfo.GetMember(namaField).GetValue(zz).ToString().Substring(posisiNomor, banyakDigit)))
					Next
					Dim vale = Enumerable.Range(1, angkaTerakhir).Except(listData).ToList()
					If (vale.Count > 0) Then
						Return CombineNomor(maskNomor, banyakDigit, vale(0))
					Else
						Return CombineNomor(maskNomor, banyakDigit, angkaTerakhir + 1)
					End If
				End If
			End If
		End Function

		Private Shared Function RemoveSpecialMask(maskNomor As String) As String
			maskNomor = maskNomor.Replace(SpecialMaskDot, SpecialFormatDot)
			Return maskNomor
		End Function
		Private Shared Function CombineNomor(mask As String, xcount As Integer, value As Integer) As String
			Dim formatInt = New String("0", xcount)
			Dim ookk = Utils.Common.Character.DuplicateString(MaskAngka, xcount)

			Return mask.Replace(ookk, value.ToString(formatInt))
		End Function
	End Class

	Friend Class TravelGLServices
		Public Shared Sub SimpanGL(main As GlMain, finaSetting As FinaSetting, Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, DebitValas As Double, KreditValas As Double, Kurs As Double, Divisi As Divisi, Proyek As NuSoft001.Persistent.Proyek, Catatan As String)
			Dim item As GlMainDetail = main.Detail.ToList.Find(Function(f) f.Urutan = Urutan)
			If item Is Nothing Then
				item = New GlMainDetail(main.Session)
				item.Main = main
				item.Urutan = Urutan
				main.Detail.Add(item)
			End If

			item.Akun = Akun
			item.MataUang = item.Akun.MataUang
			item.Debit = Debit
			item.Kredit = Kredit
			If Akun.MataUang.Id = finaSetting.MultiMataUangDefault Then
				item.DebitValas = 0
				item.KreditValas = 0
				item.Kurs = 1
			Else
				item.DebitValas = DebitValas
				item.KreditValas = KreditValas
				item.Kurs = Kurs
			End If
			item.Divisi = Divisi
			item.Proyek = Proyek
			item.Keterangan = Catatan
		End Sub
	End Class
	Friend Class TravelFormServices
		Shared Sub xHistoryData(xForm As Object, xSession As UnitOfWork, Tipe As UI_TravelCekData.TipeTransaksi, xNoBukti As String)
			Dim xHistory As New UI_TravelCekData(UI_TravelCekData.TipeForm.Dialog)
			xHistory.session = xSession
			xHistory.MenuId = xForm.MenuId
			xHistory.NamaDatabase = xForm.NamaDatabase
			xHistory.txtTipe.EditValue = Tipe
			xHistory.txtNoTransaksi.EditValue = xNoBukti
			xHistory.btnCari_Click(xHistory.btnCari, Nothing)
			xHistory.ShowDialog()
		End Sub
	End Class
End Namespace