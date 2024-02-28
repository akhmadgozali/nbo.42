Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Friend Class UI_PengajuanDanaDialog2
  Private instance As Persistent.PengajuanDana
  Private mataUangDefault As Integer
  Private editAsign As Boolean = True
  Private detailToDelete As New List(Of Persistent.PengajuanDanaDetail)
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
    txtAkun.Properties.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.Bank, Persistent.CoaEnum.eKind.Kas})
    colDivisiRepo.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(session)
    colKodeAkunRepo.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.AktivaLancarLainnya, Persistent.CoaEnum.eKind.AktivaTetap, Persistent.CoaEnum.eKind.AkumulasiPenyusutan, Persistent.CoaEnum.eKind.BiayaLainLain, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.HutangJangkaPanjang, Persistent.CoaEnum.eKind.HutangJangkaPendek, Persistent.CoaEnum.eKind.HutangLancarLainnya, Persistent.CoaEnum.eKind.Modal, Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.PendapatanLainLain, Persistent.CoaEnum.eKind.Persediaan, Persistent.CoaEnum.eKind.Piutang})
    colProyekRepo.DataSource = New XPCollection(Of Persistent.Proyek)(session)
    sumber = New Persistent.SumberDataCollection(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("PDTransaksi.xml")) = True Then
      lytPengajuanDana.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("PDTransaksi.xml"))
    End If
  End Sub
  Overrides Sub InitializeData()
    editAsign = True
    setting = New Logic.FinaSetting(session)
    If Tipe = InputType.Tambah Then
      instance = New Persistent.PengajuanDana(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}

      MyBase.InitializeData()
      xGrid.DataSource = Nothing
      txtKontak.EditValue = Nothing
      txtKontakNama.Text = ""
      txtRegionalNama.Text = ""
      txtAkunNama.Text = ""
      txtTanggal.DateTime = Now
      If Not txtRegional.EditValue Is Nothing Then
        instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      Else
        txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
      End If
      txtAkun.EditValue = instance.fCOA
      ChangeCode()

      xGrid.DataSource = instance.Detail
      Me.Text = "Pengajuan Dana: Tambah"
    Else
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.PengajuanDana)(Convert.ToInt64(IdToEdit))
      instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
      txtKontak.EditValue = instance.Kontak
      txtTanggal.EditValue = instance.Tanggal
      txtNoTransaksi.Text = instance.Kode
      txtRegional.EditValue = instance.Regional
      txtAkun.EditValue = instance.fCOA
      txtJatuhTempo.EditValue = instance.JatuhTempo
      txtUraian.EditValue = instance.Keterangan

      xGrid.DataSource = instance.Detail
      Me.Text = "Pengajuan Dana: Edit - " & instance.Kode
    End If
    editAsign = False
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    Dim setting As New Logic.FinaSetting(session)

    colJumlah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colJumlah.DisplayFormat.FormatString = setting.NumericFormatToString
    colJumlah.SummaryItem.DisplayFormat = setting.NumericFormatString
    'colValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'colValas.DisplayFormat.FormatString = setting.NumericFormatToString
    'colValas.SummaryItem.DisplayFormat = setting.NumericFormatString
    colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKurs.DisplayFormat.FormatString = setting.NumericFormatToString

    colDivisi.Visible = setting.MultiDivisi
    colKurs.Visible = setting.MultiMataUangPakai
    'colValas.Visible = setting.MultiMataUangPakai
    mataUangDefault = setting.MultiMataUangDefault
  End Sub
  Overrides Sub SimpanData()
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
        instance.fREG = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      End If
      If Not txtAkun.EditValue Is Nothing Then
        instance.Akun = CType(txtAkun.EditValue, Persistent.Coa)
      End If
      instance.fCOA = CType(txtAkun.EditValue, Persistent.Coa)
      instance.JatuhTempo = txtJatuhTempo.DateTime
      instance.Keterangan = txtUraian.Text
      instance.Save()

      '======= Simpan instance
      session.CommitChanges()
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
  Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
    If e.NewValue Is Nothing Then
      txtKontakNama.Text = ""
    Else
      Dim item As Persistent.Kontak = CType(e.NewValue, Persistent.Kontak)
      txtKontakNama.Text = item.Nama
    End If
  End Sub
  Private Sub txtAkun_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtAkun.EditValueChanging
    If e.NewValue Is Nothing Then
      txtAkunNama.Text = ""
    Else
      Dim item As Persistent.Coa = CType(e.NewValue, Persistent.Coa)
      txtAkunNama.Text = item.Nama
    End If

    Dim str As String = "Edit akun transaksi akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"
    Try
      If Tipe = InputType.Edit AndAlso editAsign = False Then
        If Not instance.Akun Is e.NewValue Then
          If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Akun", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            instance.Akun = CType(e.NewValue, Persistent.Coa)
            ChangeCode()
          Else
            e.Cancel = True
          End If
        Else
          instance.Akun = CType(e.NewValue, Persistent.Coa)
          ChangeCode()
        End If
      ElseIf Tipe = InputType.Tambah Then
        instance.Akun = CType(e.NewValue, Persistent.Coa)
        ChangeCode()
      End If
    Catch ex As Exception
      If ex.Message.Contains("Object reference not set to an instance") Then
      Else
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Ganti Akun", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
      End If
    End Try
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
      If Tipe = InputType.Edit AndAlso editAsign = False Then
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
      If Tipe = InputType.Edit AndAlso editAsign = False Then
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
  Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    If Not e.Value Is Nothing Then
      If e.Column Is colKodeAkun Then
        Dim row As Persistent.PengajuanDanaDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.PengajuanDanaDetail)
        If Not row Is Nothing Then
          Dim xCoa As Persistent.Coa = CType(e.Value, Persistent.Coa)
          row.Divisi = xCoa.Divisi
          row.MataUang = xCoa.MataUang
          row.Kurs = Logic.Kurs.getKursBank(session, row.MataUang, txtTanggal.DateTime)
        End If
      End If
    End If
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.PengajuanDanaDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.PengajuanDanaDetail)
    row.Akun = Nothing
    row.Jumlah = 0
    row.Keterangan = ""
    row.Kurs = 1
    row.Main = instance
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.PengajuanDanaDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.PengajuanDanaDetail)
      xGridView.DeleteRow(xGridView.FocusedRowHandle)
      detailToDelete.Add(Id)
    End If
  End Sub

  Private Sub ChangeCode()
    If txtTanggal.EditValue Is Nothing OrElse instance.Tanggal = Nothing Then
      Return
    End If
    If setting.FormatNomor.Contains(NuSoft001.My.Resources.FormatRegional) AndAlso (txtRegional.EditValue Is Nothing OrElse instance.Regional Is Nothing) Then
      Return
    End If
    If setting.FormatNomor.Contains(NuSoft001.My.Resources.FormatSumber) AndAlso instance.Sumber Is Nothing Then
      Return
    End If

    Dim nomor As Core.Modules.NumberResult = instance.Number.GetNewNumber
    txtNoTransaksi.Text = nomor.Kode
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.PD)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub txtRefreshNomor_Click(sender As Object, e As EventArgs) Handles txtRefreshNomor.Click
    ChangeCode()
  End Sub
End Class