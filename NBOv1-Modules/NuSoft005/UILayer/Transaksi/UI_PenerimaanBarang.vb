Imports DevExpress.Data.Async.Helpers
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem
Public Class UI_PenerimaanBarang
  Private toStringFormat As String
  Private setting As NuSoft001.Logic.FinaSetting
  Sub New()
    InitializeComponent()

    baseView = xGridView
    KeyField = "Id"
    useMDIforDialog = True
    useFeedbackSource = True
    ActivateToolTip = True
    UseDbSystem = False
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
    Dim setting As New NuSoft001.Logic.FinaSetting(session)
    Dim CreateCriteria As CriteriaOperator
    toStringFormat = setting.NumericFormatToString
    CreateCriteria = GroupOperator.And(New BinaryOperator("Sumber", Persistent.SumberDataJenis.GR, BinaryOperatorType.Equal), New InOperator("Regional", UserInfo.GetUserRegional(session, NamaDatabase)))
    ifSource.FixedFilterCriteria = CreateCriteria
    btnClosing.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    btnUnPosting.Enabled = NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("GRData.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("GRData.xml"))
    End If
    btnResetJurnal.Enabled = allowEdit
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_PenerimaanBarangDialogS
  End Function
  Overrides Function GetKeteranganHapus(selectedRows() As Integer) As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
    Dim result As New List(Of Core.Win.Forms.GridDeletedData)
    Dim item As Core.Win.Forms.GridDeletedData

    For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
      If Not xGridView.IsGroupRow(selectedRows(i)) Then
        item = New Core.Win.Forms.GridDeletedData
        item.Row = selectedRows(i)
        item.Data = xGridView.GetRowCellValue(selectedRows(i), "Kode").ToString
        result.Add(item)
      End If
    Next
    Return result
  End Function
  Overrides Function HapusData(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)) As Boolean
    Dim item As Persistent.PenerimaanBarang, pPending As Integer
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim dtPO As New List(Of Persistent.OrderPembelian)
    pPending = 0
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.PenerimaanBarang)
        If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
          dtPO.Add(item.NoOrder)
          Dim zdtGL As Persistent.GlMain = session.FindObject(Of Persistent.GlMain)(New BinaryOperator("Id", item.Gl.Id, BinaryOperatorType.Equal))
          If Not zdtGL Is Nothing Then
            zdtGL.Delete()
          End If
          item.Delete()
        Else
          pPending += 1
        End If
      End If
    Next
    session.CommitChanges()
    'update status transaksi PO
    For i = dtPO.Count - 1 To 0 Step -1
      Dim xpGR As New XPCollection(Of Persistent.PenerimaanBarang)(session, New BinaryOperator("NoOrder.Id", dtPO(i).Id, BinaryOperatorType.Equal))
      If xpGR.Count > 0 Then
        dtPO(i).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.InProgress
      Else
        dtPO(i).StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
      End If
    Next
    session.CommitChanges()
    If pPending > 0 Then
      Utils.Win.MessageBox.Show("Transaksi selain status pending tidak dapat dihapus.", "Hapus Data", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
    Return True
  End Function
  Overrides Function GetToolTipContent(view As DevExpress.XtraGrid.Views.Grid.GridView, info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
    Dim item As Persistent.PenerimaanBarang
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim result As String = ""
    Dim xSpace As String, KodeBarang As String, NamaBarang As String, Qty As String ', Harga As String
    Dim num As Integer

    Try
      proxy = CType(view.GetRow(info.RowHandle), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      item = CType(proxy.OriginalRow, Persistent.PenerimaanBarang)

      Dim a = From p In item.Detail

      For i = 0 To a.Count - 1
        KodeBarang = a(i).Barang.Kode
        NamaBarang = a(i).Barang.Nama
        Qty = a(i).Qty.ToString(toStringFormat) & " (" & a(i).Satuan.Kode & ")"
        num = (KodeBarang.Length + NamaBarang.Length + Qty.Length + 3)
        If num >= 80 Then
          xSpace = " "
        Else
          xSpace = Space(80 - num)
        End If

        result += KodeBarang & " (" & NamaBarang & ")" & xSpace & Qty
        If i <> a.Count - 1 Then
          result += vbCrLf
        End If
      Next
      result += vbCrLf
      result += vbCrLf

      'xKeterangan = "SubTotal"
      'xJumlah = item.SubTotal.ToString(toStringFormat)
      'num = (xKeterangan.Length + xJumlah.Length)
      'xSpace = Space(80 - num)
      'result += xKeterangan & xSpace & xJumlah & vbCrLf
      'If item.PPN <> 0 Then
      '  xKeterangan = "PPN"
      '  xJumlah = item.PPN.ToString(toStringFormat)
      '  num = (xKeterangan.Length + xJumlah.Length)
      '  xSpace = Space(80 - num)
      '  result += xKeterangan & xSpace & xJumlah & vbCrLf
      'End If

      'If item.PPH <> 0 Then
      '  xKeterangan = "PPH"
      '  xJumlah = item.PPH.ToString(toStringFormat)
      '  num = (xKeterangan.Length + xJumlah.Length)
      '  xSpace = Space(80 - num)
      '  result += xKeterangan & xSpace & xJumlah & vbCrLf
      'End If
      'xKeterangan = "Total Transaksi"
      'xJumlah = item.Total.ToString(toStringFormat)
      'num = (xKeterangan.Length + xJumlah.Length)
      'xSpace = Space(80 - num)
      'result += xKeterangan & xSpace & xJumlah & vbCrLf

      Return result
    Catch ex As Exception
      Return ""
    End Try
  End Function
  Overrides Function GetToolTipTitle(view As DevExpress.XtraGrid.Views.Grid.GridView, info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
    Return view.GetRowCellDisplayText(info.RowHandle, colKode)
  End Function
	Private Sub btnPosting_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPosting.ItemClick, btnUnPosting.ItemClick, btnClosing.ItemClick, btnReOpen.ItemClick
		Dim xText As String = String.Format("Apakah anda ingin {0} {1} ?", e.Item.Tag, Me.Text)
		Dim x As Integer() = Nothing
		If allowEdit = False Then
			Utils.Win.MessageBox.Show("Anda tidak mendapatkan hak akses untuk merubah transaksi", "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
			Exit Sub
		End If

		If baseView.RowCount < 1 Then
			Exit Sub
		End If

		If TypeOf (baseView) Is DevExpress.XtraGrid.Views.Grid.GridView Then
			Dim viewGrid As DevExpress.XtraGrid.Views.Grid.GridView = CType(baseView, DevExpress.XtraGrid.Views.Grid.GridView)
			If viewGrid.IsGroupRow(viewGrid.FocusedRowHandle) Then
				Exit Sub
			End If
			x = viewGrid.GetSelectedRows
		ElseIf TypeOf (baseView) Is DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView Then
			Dim viewGrid As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = CType(baseView, DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)
			If viewGrid.IsGroupRow(viewGrid.FocusedRowHandle) Then
				Exit Sub
			End If
			x = viewGrid.GetSelectedRows
		End If

		Dim note As List(Of NuSoft.Core.Win.Forms.GridDeletedData) = GetKeteranganHapus(x)
		If note Is Nothing Then
			Utils.Win.MessageBox.Show("Masukkan keterangan data yang akan dihapus", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
			Exit Sub
		End If

		For i = 0 To note.Count - 1
			xText &= vbCrLf & note(i).Data
		Next

		If Len(xText) > 0 Then
			If Utils.Win.MessageBox.Show(xText, "Update Status " & Me.Text, "", Utils.Win.MessageBox.Button.YaTidak, Utils.Win.MessageBox.Icon.Pertanyaan) = Utils.Win.MessageBox.DialogResult.Ya Then
				setstatus(note, e.Item.Tag)
				RefreshData()
			End If
		End If
	End Sub
	Sub setstatus(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData), xTipe As String)
    Dim item As Persistent.PenerimaanBarang, xGagal As Integer, xMessage As String
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    xGagal = 0
    xMessage = ""
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.PenerimaanBarang)
				If xTipe = "memposting" Then
					xMessage = "Hanya transaksi pending yang bisa dirubah statusnya menjadi posting."
					If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
						item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
					Else
						xGagal += 1
					End If
				ElseIf xTipe = "mengunposting" Then
					xMessage = "Hanya transaksi posting yang bisa dirubah statusnya menjadi pending."
					If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting Then
						item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending
					Else
						xGagal += 1
					End If
				ElseIf xTipe = "mengopen" Then
					xMessage = "Hanya transaksi closing yang bisa dirubah statusnya."
					If item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Closed Then
						'item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending
						'carikan statusnya
						Dim xpRI As New XPCollection(Of Persistent.PenerimaanInvoiceDetail)(session, New BinaryOperator("PenerimaanBarang.Main.Id", item.Id, BinaryOperatorType.Equal))
						If xpRI.Count > 0 Then
							item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish
						Else
							item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
						End If
					Else
						xGagal += 1
					End If
				ElseIf xTipe = "mengclosing" Then
					xMessage = "Transaksi yang sudah selesai tidak dapat diclose."
          If Not item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Finish Or item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Rejected Then
            item.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Closed
          Else
            xGagal += 1
          End If
        End If
      End If
    Next
    session.CommitChanges()
    If xGagal > 0 Then
      Utils.Win.MessageBox.Show(xMessage.ToString, "Update Status", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
  End Sub
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("GRData.xml"))
  End Sub
  Private Sub btnResetJurnal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetJurnal.ItemClick
    If MsgBox("Apakah anda ingin membuat ulang semua jurnal penerimaan barang?", vbYesNo, "Konfirmasi") = vbYes Then
      Dim settingpurchase As New Logic.PurchaseSetting(session)

      Dim xdtPenerimaanBarang As New DevExpress.Xpo.XPCollection(Of Persistent.PenerimaanBarang)(session)
      For pi = 0 To xdtPenerimaanBarang.Count - 1
        'xdtPenerimaanBarang(pi).Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
        xdtPenerimaanBarang(pi).Gl.Sumber = xdtPenerimaanBarang(pi).Sumber
        xdtPenerimaanBarang(pi).Gl.Tanggal = xdtPenerimaanBarang(pi).Tanggal
        xdtPenerimaanBarang(pi).Gl.Regional = xdtPenerimaanBarang(pi).Regional
        xdtPenerimaanBarang(pi).Gl.Kode = xdtPenerimaanBarang(pi).Kode
        xdtPenerimaanBarang(pi).Gl.ModuleId = NPO.Modules.ModuleId.Purchase
        xdtPenerimaanBarang(pi).Gl.MataUang = xdtPenerimaanBarang(pi).NoOrder.Uang.Simbol
        xdtPenerimaanBarang(pi).Gl.Kurs = xdtPenerimaanBarang(pi).Kurs
        xdtPenerimaanBarang(pi).Gl.Kontak = xdtPenerimaanBarang(pi).Vendor
        xdtPenerimaanBarang(pi).Gl.KontakNama = xdtPenerimaanBarang(pi).Vendor.Nama
        xdtPenerimaanBarang(pi).Gl.Uraian = xdtPenerimaanBarang(pi).Uraian

        For zi = xdtPenerimaanBarang(pi).Gl.Detail.Count - 1 To 0 Step -1
          xdtPenerimaanBarang(pi).Gl.Detail(zi).Delete()
        Next

        Dim i As Byte = 1
        'Persediaan (D)    looping dari setingan master coa
        Dim a = From z In xdtPenerimaanBarang(pi).Detail Where z.Barang.Jenis = NuSoft004.Persistent.JenisBarang.Persediaan Or z.Barang.Jenis = NuSoft004.Persistent.JenisBarang.Assembly Group z By z.Barang.CoaStock, z.OrderDetail.Proyek Into Group Select Proyek, CoaStock, SubTotal = Group.Sum(Function(x) x.SubTotal * x.Main.Kurs)
        For Each x In a
          SimpanGL(xdtPenerimaanBarang(pi), x.CoaStock, i, x.SubTotal, 0, x.Proyek)
          i = i + 1
        Next

        'langsung jadikan biaya ketika jasa
        Dim b = From z In xdtPenerimaanBarang(pi).Detail Where z.Barang.Jenis = NuSoft004.Persistent.JenisBarang.Jasa Group z By z.Barang.CoaCost, z.OrderDetail.Proyek Into Group Select CoaCost, Proyek, SubTotal = Group.Sum(Function(x) x.SubTotal * x.Main.Kurs)
        For Each x In b
          SimpanGL(xdtPenerimaanBarang(pi), x.CoaCost, i, x.SubTotal, 0, x.Proyek)
          i = i + 1
        Next

        i = i + 1


        'Hutang Sementara (C)
        SimpanGL(xdtPenerimaanBarang(pi), session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingpurchase.CoaHutangSementara)), i + 1, 0, xdtPenerimaanBarang(pi).Detail.Sum(Function(m) m.SubTotal * m.Main.Kurs))

      Next
      session.CommitChanges()
      Utils.Win.MessageBox.Show("Proses Selesai", "Update GL", "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)

    End If
  End Sub
  Private Sub SimpanGL(instance As Persistent.PenerimaanBarang, Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, Optional Proyek As NuSoft001.Persistent.Proyek = Nothing)
    Dim item As Persistent.GlMainDetail
    If instance.Gl.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
      item = instance.Gl.Detail.Single(Function(m) m.Urutan = Urutan)
    Else
      item = New Persistent.GlMainDetail(session)

      item.Akun = Akun
      item.MataUang = item.Akun.MataUang
      item.Main = instance.Gl
      item.Urutan = Urutan
      item.Debit = Debit
      item.Kredit = Kredit
      item.Kurs = 1
      item.DebitValas = 0
      item.KreditValas = 0
      item.Proyek = Proyek
      instance.Gl.Detail.Add(item)
    End If
  End Sub

End Class