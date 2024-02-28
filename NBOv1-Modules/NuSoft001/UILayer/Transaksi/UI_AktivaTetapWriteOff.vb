Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Friend Class UI_AktivaTetapWriteOff
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
    Persistent.AktivaTransaksiMain.AutoSaveOnEndEdit = False
    Persistent.AktivaTransaksiDetail.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    txtKontak.Properties.DataSource = New XPCollection(Of Persistent.Kontak)(session, New BinaryOperator("Aktif", True))
    txtRegional.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Regional)(session)
    colKodeAssetRepo.DataSource = New XPCollection(Of Persistent.AktivaTetap)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Pembelian", True), New BinaryOperator("QtySisa", 0, BinaryOperatorType.Greater)))
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("AktivaTetapPenjualan.xml")) = True Then
      lytPembelian.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("AktivaTetapPenjualan.xml"))
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
      txtKontakNama.Text = ""
      txtRegionalNama.Text = ""
      txtTanggal.DateTime = Now
      If Not txtRegional.EditValue Is Nothing Then
        instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      Else
        txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
      End If
      instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.FA)
      ChangeCode()
      txtUraian.EditValue = "Write Off Aktiva Tetap"
      xGrid.DataSource = instance.Detail
      Me.Text = "Write Off Aktiva Tetap: Tambah"
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
      Me.Text = "Write Off Aktiva Tetap: Edit - " & instance.Kode
    End If
  End Sub
  Overrides Sub LoadAfterInitialize()
    Dim setting As New Logic.FinaSetting(session)
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatToString
    colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
    colNilaiMasuk.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiMasuk.DisplayFormat.FormatString = setting.NumericFormatToString
    colNilaiMasuk.SummaryItem.DisplayFormat = setting.NumericFormatString
    mataUangDefault = setting.MultiMataUangDefault
  End Sub
  Overrides Sub SimpanData()
    If Logic.GL.isAnyTransactionAsset(session, txtTanggal.DateTime) Then
      Throw New Utils.Exception("Sudah ada transaksi diatas tanggal ini. Sistem tidak dapat melanjutkan.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If

    Try
      Dim pUrutan As Integer = 1, pI As Integer

      For i = detailToDelete.Count - 1 To 0 Step -1
        detailToDelete(i).Delete()
      Next

      If Not txtKontak.EditValue Is Nothing Then
        instance.Kontak = CType(txtKontak.EditValue, Persistent.Kontak)
      End If
      instance.Tanggal = txtTanggal.DateTime
      instance.Tipe = Persistent.eTipeTransaksiAsset.WriteOff
      instance.Kode = txtNoTransaksi.Text
      If Not txtRegional.EditValue Is Nothing Then
        instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      End If
      instance.Uraian = txtUraian.Text
      For pI = 0 To instance.Detail.Count - 1
        instance.Detail(pI).Asset.Dispose = True
        instance.Detail(pI).Asset.QtyOut = instance.Detail(pI).Asset.QtyOut + instance.Detail(pI).Qty
      Next
      'create jurnal terlebih dahulu
      instance.GL = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
      instance.GL.Sumber = instance.Sumber
      instance.GL.Regional = instance.Regional
      instance.GL.Tanggal = instance.Tanggal
      instance.GL.Kontak = instance.Kontak
      instance.GL.Uraian = "Write Off Aktiva Tetap"

      'Biaya Write Off/LabaRugi Penjualan (D) senilai nilai buku
      Dim c = From z In instance.Detail Group z By z.Asset.Kelompok.COAWriteOff Into Group Select COA = COAWriteOff, xNilai = Group.Sum(Function(x) ((x.NilaiBuku + x.Asset.NilaiResidu) * x.Qty))
      For pI = 0 To c.Count - 1
        SimpanGL(c(pI).COA, CByte(pI + 1), c(pI).xNilai, 0, 1, 0, 0)
      Next
      pUrutan = c.Count + 1

      'Akum Depresiasi (D) senilai akum depresiasi
      Dim d = From z In instance.Detail Group z By z.Asset.Kelompok.COAAkumulasiDepr Into Group Select COA = COAAkumulasiDepr, xNilai = Group.Sum(Function(x) ((x.Asset.Harga - (x.Asset.NilaiResidu + x.NilaiBuku)) * x.Qty))
      For pI = 0 To d.Count - 1
        SimpanGL(d(pI).COA, CByte(pUrutan + pI), d(pI).xNilai, 0, 1, 0, 0)
      Next
      pUrutan = c.Count + d.Count + 2


      'Aktiva Tetap (K) senilai harga beli
      Dim e = From z In instance.Detail Group z By z.Asset.Kelompok.COAAsset Into Group Select COA = COAAsset, xNilai = Group.Sum(Function(x) ((x.Asset.Harga) * x.Qty))
      For pI = 0 To e.Count - 1
        SimpanGL(e(pI).COA, CByte(pUrutan + pI), 0, e(pI).xNilai, 1, 0, 0)
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
    Dim nomor As Core.Modules.NumberResult = instance.Number.GetNewNumber
    txtNoTransaksi.Text = nomor.Kode
  End Sub
  Private Sub Me_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    isShown = True
  End Sub
  Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
    If e.NewValue Is Nothing Then
      txtKontakNama.Text = ""
    Else
      Dim item As Persistent.Kontak = CType(e.NewValue, Persistent.Kontak)
      txtKontakNama.Text = item.Nama
    End If
  End Sub
  Private Sub txtRegional_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtRegional.EditValueChanging
    If e.NewValue Is Nothing Then
      txtRegionalNama.Text = ""
    Else
      Dim item As NPO.Modules.ModSys.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
      txtRegionalNama.Text = item.Nama
    End If

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
        End If
      ElseIf Tipe = InputType.Tambah Then
        instance.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
        ChangeCode()
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
  Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    If Not e.Value Is Nothing Then
      Dim row As Persistent.AktivaTransaksiDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.AktivaTransaksiDetail)
      If e.Column Is colKodeAsset Then
        If Not row Is Nothing Then
          Dim xAsset As Persistent.AktivaTetap = CType(e.Value, Persistent.AktivaTetap)
          Dim xNilaiBuku As Double = session.GetObjectByKey(Of NuSoft001.Persistent.viewAktivaTetap)(Convert.ToInt64(xAsset.Id)).d_bookvalue
          If xNilaiBuku > 0 Then xNilaiBuku = xNilaiBuku / (xAsset.Qty - xAsset.QtyOut)
          row.Qty = xAsset.Qty - xAsset.QtyOut
          row.NilaiKeluar = xNilaiBuku
          row.NilaiBuku = xNilaiBuku
        End If
      End If
    End If
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.AktivaTransaksiDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.AktivaTransaksiDetail)
    row.Asset = Nothing
    row.Qty = 1
    row.Main = instance
    row.Keterangan = ""
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.AktivaTransaksiDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.AktivaTransaksiDetail)
      xGridView.DeleteRow(xGridView.FocusedRowHandle)
      detailToDelete.Add(Id)
    End If
  End Sub
End Class