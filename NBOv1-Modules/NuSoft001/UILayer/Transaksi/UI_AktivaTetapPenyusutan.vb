Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Friend Class UI_AktivaTetapPenyusutan
  Private instance As Persistent.AktivaTransaksiMain
  Private mataUangDefault As Integer
  Private isShown As Boolean
  Private detailToDelete As New List(Of Persistent.AktivaTransaksiDetail)
  Private setting As Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Persistent.PengajuanDana.AutoSaveOnEndEdit = False
    Persistent.PengajuanDanaDetail.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    txtKontak.Properties.DataSource = New XPCollection(Of Persistent.Kontak)(session, New BinaryOperator("Aktif", True))
    txtRegional.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Regional)(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("AktivaTetapPenyusutan.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("AktivaTetapPenyusutan.xml"))
    End If
    sumber = New Persistent.SumberDataCollection(session)
  End Sub
  Overrides Sub InitializeData()
    setting = New Logic.FinaSetting(session)
    If Tipe = InputType.Tambah Then
      instance = New Persistent.AktivaTransaksiMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
      MyBase.InitializeData()
      xGrid.DataSource = Nothing
      txtKontak.EditValue = Nothing
      txtTanggal.DateTime = Now.AddMonths(1).AddDays(-(Now.AddMonths(1).Day))
      If Not txtRegional.EditValue Is Nothing Then
        instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      Else
        txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
      End If
      instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.FA)
      ChangeCode()

      'isikan detail yang belum dilakukan pembelian
      'Dim xData As New XPCollection(Of Persistent.AktivaTetap)(session, New BinaryOperator("Pembelian", False, BinaryOperatorType.Equal))
      'Dim xItem As Persistent.AktivaTransaksiDetail
      'For pi = 0 To xData.Count - 1
      '  xItem = New Persistent.AktivaTransaksiDetail(session)
      '  xItem.Asset = xData(pi)
      '  xItem.Tanggal = xData(pi).TanggalBeli
      '  xItem.Qty = xData(pi).QtySisa
      '  xItem.NilaiMasuk = xData(pi).Harga - xData(pi).NilaiResidu
      '  instance.Detail.Add(xItem)
      'Next
      txtUraian.EditValue = "Penyusutan Aktiva Tetap"
      xGrid.DataSource = instance.Detail
      Me.Text = "Penyusutan Aktiva Tetap: Tambah"
    Else
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.AktivaTransaksiMain)(Convert.ToInt64(IdToEdit))
      instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
      txtKontak.EditValue = instance.Kontak
      txtTanggal.EditValue = instance.Tanggal
      txtNoTransaksi.Text = instance.Kode
      txtRegional.EditValue = instance.Regional
      txtUraian.EditValue = instance.Uraian

      xGrid.DataSource = instance.Detail
			Me.Text = "Penyusutan Aktiva Tetap: Edit - " & instance.Kode

			txtRegional.Properties.ReadOnly = True
			txtTanggal.Properties.ReadOnly = True
		End If
  End Sub
  Overrides Sub LoadAfterInitialize()
    Dim setting As New Logic.FinaSetting(session)
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatToString
    colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
    colNilaiKeluar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiKeluar.DisplayFormat.FormatString = setting.NumericFormatToString
    colNilaiKeluar.SummaryItem.DisplayFormat = setting.NumericFormatString
    colPersentase.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colPersentase.DisplayFormat.FormatString = setting.NumericFormatToString
    colPersentase.SummaryItem.DisplayFormat = setting.NumericFormatString
    mataUangDefault = setting.MultiMataUangDefault
  End Sub
  Overrides Sub SimpanData()
    If Logic.GL.isAnyTransactionAsset(session, txtTanggal.DateTime) Then
      Throw New Utils.Exception("Sudah ada transaksi diatas tanggal ini. Sistem tidak dapat melanjutkan.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If

    Try
      For i = detailToDelete.Count - 1 To 0 Step -1
        detailToDelete(i).Delete()
      Next

      If Not txtKontak.EditValue Is Nothing Then
        instance.Kontak = CType(txtKontak.EditValue, Persistent.Kontak)
      End If
      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      If Not txtRegional.EditValue Is Nothing Then
        instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      End If
      instance.Tipe = Persistent.eTipeTransaksiAsset.Penyusutan
      instance.Uraian = txtUraian.Text
      'create jurnal terlebih dahulu
      instance.GL = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
      instance.GL.Sumber = instance.Sumber
      instance.GL.Regional = instance.Regional
      instance.GL.Tanggal = instance.Tanggal
      instance.GL.Kontak = instance.Kontak
      instance.GL.Uraian = instance.Uraian

      Dim pUrutan As Integer = 1, pI As Integer
      Dim c = From z In instance.Detail Group z By z.Asset.Kelompok.COADepresiasi Into Group Select COA = COADepresiasi, xNilai = Group.Sum(Function(x) (x.NilaiKeluar * x.Qty))
      For pI = 0 To c.Count - 1
        SimpanGL(c(pI).COA, CByte(pI + 1), c(pI).xNilai, 0, 1, 0, 0)
      Next
      'akum depresiasi
      pUrutan = c.Count + 1
      Dim d = From z In instance.Detail Group z By z.Asset.Kelompok.COAAkumulasiDepr Into Group Select COA = COAAkumulasiDepr, xNilai = Group.Sum(Function(x) (x.NilaiKeluar * x.Qty))
      For pI = 0 To d.Count - 1
        SimpanGL(d(pI).COA, CByte(pUrutan + pI), 0, d(pI).xNilai, 1, 0, 0)
      Next

      instance.Save()
      '======= Simpan instance
      session.CommitChanges()
      Me.Close()
    Catch ex As Utils.Exception
      Throw New Utils.Exception(ex)
    Catch ex As Exception
      Throw New Exception(ex.Message, ex.InnerException)
    End Try
  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtNoTransaksi.Focus()
      Case -2 : txtTanggal.Focus()
      Case -3 : txtRegional.Focus()
      Case -4 : txtKontak.Focus()
      Case -99 : xGrid.Focus()
    End Select
  End Sub
  Private Sub ChangeCode()
    If txtTanggal.EditValue Is Nothing OrElse instance.Tanggal = Nothing Then
      Return
    End If
    If txtRegional.EditValue Is Nothing OrElse instance.Regional Is Nothing Then
      Return
    End If
    'If txtAkun.EditValue Is Nothing OrElse instance.Akun Is Nothing Then
    '  Return
    'End If
    Dim nomor As Core.Modules.NumberResult = instance.Number.GetNewNumber
    txtNoTransaksi.Text = nomor.Kode
    'MsgBox("OKE COY -->" & nomor.Kode)
  End Sub
  Private Sub Me_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    isShown = True
  End Sub
  Private Sub txtRegional_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtRegional.EditValueChanging
    'If e.NewValue Is Nothing Then
    '  txtRegionalNama.Text = ""
    'Else
    '  Dim item As NPO.Modules.ModSys.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
    '  txtRegionalNama.Text = item.Nama
    'End If

    Dim str As String = "Edit regional transaksi akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"
    Try
      If Tipe = InputType.Edit AndAlso isShown Then
        If Not instance.Regional Is e.NewValue Then
          If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Regional", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            instance.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
            ChangeCode()
          Else
            e.Cancel = True
          End If
        Else
          instance.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
					ChangeCode()
					FillAsset(instance.Tanggal)
				End If
      ElseIf Tipe = InputType.Tambah Then
        instance.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
				ChangeCode()
				FillAsset(instance.Tanggal)
			End If
    Catch ex As Exception
      If ex.Message.Contains("Object reference not set to an instance") Then
      Else
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Ganti Regional", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
      End If
    End Try
  End Sub
  Private Sub txtTanggal_EditValueChanged(sender As Object, e As EventArgs) Handles txtTanggal.EditValueChanged
    Dim str As String = "Edit tanggal dengan bulan dan tahun berbeda akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"
    Try
      If Tipe = InputType.Edit AndAlso isShown Then
        If instance.Tanggal.Month <> CDate(txtTanggal.EditValue).Month OrElse instance.Tanggal.Year <> CDate(txtTanggal.EditValue).Year Then
          If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Tanggal", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            instance.Tanggal = txtTanggal.DateTime
            ChangeCode()
          Else
            txtTanggal.EditValue = instance.Tanggal
          End If
        Else
          instance.Tanggal = txtTanggal.DateTime
          ChangeCode()
        End If
      ElseIf Tipe = InputType.Tambah Then
        instance.Tanggal = txtTanggal.DateTime
        ChangeCode()
        FillAsset(instance.Tanggal)
      End If
    Catch ex As Exception
      If ex.Message.Contains("Object reference not set to an instance") Then
      Else
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Me.Text, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
      End If
    End Try
  End Sub
  Private Sub txtRefreshNomor_Click(sender As Object, e As EventArgs) Handles txtRefreshNomor.Click
    ChangeCode()
  End Sub
  Private Sub SimpanGL(Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, Kurs As Double, DebitValas As Double, KreditValas As Double)
    Dim item As Persistent.GlMainDetail
    item = New Persistent.GlMainDetail(session)

    item.Akun = Akun
    item.MataUang = item.Akun.MataUang
    item.Main = instance.GL
    item.Urutan = Urutan
    item.Debit = Debit
    item.Kredit = Kredit
    item.Kurs = Kurs
    item.DebitValas = DebitValas
    item.KreditValas = KreditValas
    instance.GL.Detail.Add(item)
  End Sub
  Private Sub FillAsset(xTanggal As Date)
    Dim pI As Integer, zdata As Persistent.AktivaTransaksiDetail
    Dim zTanggalAwal As Date, zTanggalAkhir As Date
    For pI = 0 To instance.Detail.Count - 1
      instance.Detail(pI).NilaiKeluar = 0
    Next
    zTanggalAwal = New Date(xTanggal.Year, xTanggal.Month, 1)
    zTanggalAkhir = xTanggal.AddMonths(1).AddDays(-(xTanggal.AddMonths(1).Day))
		'isikan assetnya Dispose
		Dim xData As New XPCollection(Of Persistent.AktivaTetapPenyusutan)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Asset.Regional", instance.Regional, BinaryOperatorType.Equal), New BinaryOperator("Asset.Dispose", False, BinaryOperatorType.Equal), New BinaryOperator("Asset.Pembelian", True, BinaryOperatorType.Equal), New BinaryOperator("TglAwal", zTanggalAkhir, BinaryOperatorType.LessOrEqual), New BinaryOperator("TglAkhir", zTanggalAwal, BinaryOperatorType.GreaterOrEqual)))
		For pI = 0 To xData.Count - 1
      If instance.Detail.ToList.Exists(Function(m) m.Asset.Id = xData(pI).Asset.Id) Then 'jika ada maka dirubah, jika tidak maka ditambah
        zdata = instance.Detail.Single(Function(m) m.Asset.Id = xData(pI).Asset.Id)
        zdata.Asset = xData(pI).Asset
        zdata.Qty = CDbl(xData(pI).Asset.QtySisa)
        zdata.NilaiKeluar = xData(pI).Nilai
      Else
        zdata = New Persistent.AktivaTransaksiDetail(session)
        zdata.Asset = xData(pI).Asset
        zdata.Qty = CDbl(xData(pI).Asset.QtySisa)
        zdata.NilaiKeluar = xData(pI).Nilai
        instance.Detail.Add(zdata)
      End If
    Next


    For pI = instance.Detail.Count - 1 To 0 Step -1
      If instance.Detail(pI).NilaiKeluar = 0 Then
        instance.Detail(pI).Delete()
      End If
    Next
  End Sub
End Class