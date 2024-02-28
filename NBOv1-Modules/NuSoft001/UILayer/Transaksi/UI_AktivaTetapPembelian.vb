Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Friend Class UI_AktivaTetapPembelian
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
    txtAkun.Properties.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.Bank, Persistent.CoaEnum.eKind.Kas, Persistent.CoaEnum.eKind.HutangLancarLainnya, Persistent.CoaEnum.eKind.HutangJangkaPanjang, Persistent.CoaEnum.eKind.HutangJangkaPendek, Persistent.CoaEnum.eKind.Modal})
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("AktivaTetapPembelian.xml")) = True Then
      lytPembelian.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("AktivaTetapPembelian.xml"))
    End If
    sumber = New Persistent.SumberDataCollection(session)
    Dim setting As New Logic.FinaSetting(session)
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatToString
    colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
    colNilaiMasuk.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiMasuk.DisplayFormat.FormatString = setting.NumericFormatToString
    colNilaiMasuk.SummaryItem.DisplayFormat = setting.NumericFormatString
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
      If Not txtTanggal.EditValue Is Nothing Then
        instance.Tanggal = txtTanggal.DateTime
      Else
        txtTanggal.DateTime = Now
      End If
      If Not txtRegional.EditValue Is Nothing Then
        instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      Else
        txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
      End If
      instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.FA)
      ChangeCode()

      'isikan detail yang belum dilakukan pembelian
      Dim xData As New XPCollection(Of Persistent.AktivaTetap)(session, New BinaryOperator("Pembelian", False, BinaryOperatorType.Equal))
      Dim xItem As Persistent.AktivaTransaksiDetail
      For pi = 0 To xData.Count - 1
        xItem = New Persistent.AktivaTransaksiDetail(session)
        xItem.Asset = xData(pi)
        xItem.Tanggal = xData(pi).TanggalBeli
        xItem.Qty = xData(pi).Qty
        xItem.NilaiMasuk = xData(pi).Harga - xData(pi).NilaiResidu
        instance.Detail.Add(xItem)
      Next

      xGrid.DataSource = instance.Detail
      Me.Text = "Pembelian Aktiva Tetap: Tambah"
    Else
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.AktivaTransaksiMain)(Convert.ToInt64(IdToEdit))
      instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
      txtKontak.EditValue = instance.Kontak
      txtTanggal.EditValue = instance.Tanggal
      txtNoTransaksi.Text = instance.Kode
      txtRegional.EditValue = instance.Regional
      txtAkun.EditValue = instance.Akun
      txtUraian.EditValue = instance.Uraian
      If instance.GL Is Nothing Then
        chkJurnal.Checked = False
      Else
        chkJurnal.Checked = True
        Dim item As Persistent.GlMainDetail
        item = instance.GL.Detail.Single(Function(m) m.Urutan = 0)
        txtAkun.EditValue = item.Akun
        txtUang.EditValue = item.Akun.MataUang.Kode
        txtKurs.EditValue = item.Kurs
      End If

      xGrid.DataSource = instance.Detail
      Me.Text = "Pembelian Aktiva Tetap: Edit - " & instance.Kode
    End If
  End Sub
  Overrides Sub LoadAfterInitialize()
    Dim setting As New Logic.FinaSetting(session)
    'colJumlah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colJumlah.DisplayFormat.FormatString = setting.NumericFormatToString
    'colJumlah.SummaryItem.DisplayFormat = setting.NumericFormatString
    'colValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colValas.DisplayFormat.FormatString = setting.NumericFormatToString
    'colValas.SummaryItem.DisplayFormat = setting.NumericFormatString
    'colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colKurs.DisplayFormat.FormatString = setting.NumericFormatToString

    'colDivisi.Visible = setting.MultiDivisi
    'colMataUang.Visible = setting.MultiMataUangPakai
    'colKurs.Visible = setting.MultiMataUangPakai
    'colValas.Visible = setting.MultiMataUangPakai
    mataUangDefault = setting.MultiMataUangDefault
  End Sub
  Overrides Sub SimpanData()
    If chkJurnal.Checked = True Then
      If txtAkun.EditValue Is Nothing Then
        Throw New Utils.Exception("Akun Kas/Bank Kosong. Silahkan pilih terlebih dahulu", 0, "", "Simpan Transaksi")
        Exit Sub
      End If
    End If

    Try
      For i = detailToDelete.Count - 1 To 0 Step -1
        detailToDelete(i).Delete()
      Next

      If Not txtKontak.EditValue Is Nothing Then
        instance.Kontak = CType(txtKontak.EditValue, Persistent.Kontak)
      End If
      instance.Tanggal = txtTanggal.DateTime
      instance.Tipe = Persistent.eTipeTransaksiAsset.Pembelian
      instance.Kode = txtNoTransaksi.Text
      If Not txtRegional.EditValue Is Nothing Then
        instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      End If
      If Not txtAkun.EditValue Is Nothing Then
        instance.Akun = CType(txtAkun.EditValue, Persistent.Coa)
      End If
      instance.Uraian = txtUraian.Text
      For pi = 0 To instance.Detail.Count - 1
        instance.Detail(pi).Asset.Pembelian = True
      Next
      'create jurnal terlebih dahulu
      If chkJurnal.Checked = True Then
        instance.GL = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
        instance.GL.Sumber = instance.Sumber
        instance.GL.Regional = instance.Regional
        instance.GL.Tanggal = instance.Tanggal
        instance.GL.Kontak = instance.Kontak
        instance.GL.Uraian = "Pembelian Aktiva Tetap"

        Dim xNilai As Double, xNilaiValas As Double
        xNilai = instance.Detail.Sum(Function(m) m.TotalMasuk)
        xNilaiValas = xNilai / CDbl(txtKurs.EditValue)
        If CType(txtAkun.EditValue, Persistent.Coa).MataUang.Id = setting.MultiMataUangDefault Then
          xNilaiValas = 0
        End If
        SimpanGL(CType(txtAkun.EditValue, Persistent.Coa), 0, 0, xNilai, CDbl(txtKurs.EditValue), 0, xNilaiValas)

        Dim pUrutan As Byte = 1
        Dim d = From z In instance.Detail Group z By z.Asset.Kelompok.COAAsset Into Group Select COA = COAAsset, xNilaiBeli = Group.Sum(Function(x) (x.TotalMasuk))
        For pI = 0 To d.Count - 1
          SimpanGL(d(pI).COA, CByte(pI + 1), d(pI).xNilaiBeli, 0, 1, 0, 0)
        Next
      End If
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
      Case -5 : txtAkun.Focus()
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
  Private Sub txtAkun_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtAkun.EditValueChanging
    If Not e.NewValue Is Nothing Then
      txtUang.Text = CType(e.NewValue, Persistent.Coa).MataUang.Kode
      If setting.MultiMataUangDefault <> CType(e.NewValue, Persistent.Coa).MataUang.Id Then
        txtKurs.Properties.ReadOnly = False
        txtKurs.EditValue = Logic.Kurs.getKursBank(session, CType(e.NewValue, Persistent.Coa).MataUang, txtTanggal.DateTime)
      Else
        txtKurs.EditValue = 1
        txtKurs.Properties.ReadOnly = True
      End If
    End If
  End Sub

  Private Sub xGridView_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.AktivaTransaksiDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.AktivaTransaksiDetail)
      xGridView.DeleteRow(xGridView.FocusedRowHandle)
      detailToDelete.Add(Id)
    End If
  End Sub
End Class