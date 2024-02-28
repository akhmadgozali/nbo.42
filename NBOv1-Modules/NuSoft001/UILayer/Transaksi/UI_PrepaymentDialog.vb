Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Friend Class UI_PrepaymentDialog
  Private instance As Persistent.PrePaymentMain
  Private mataUangDefault As Integer
  Private editAsign As Boolean = True
  Private detailToDelete As New List(Of Persistent.PrePaymentDetail)
  Private setting As Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
    Persistent.PrePaymentMain.AutoSaveOnEndEdit = False
    Persistent.PrePaymentDetail.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    txtKontak.Properties.DataSource = New XPCollection(Of Persistent.Kontak)(session, New BinaryOperator("Aktif", True))
    txtRegional.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Regional)(session)
    colTypeRepo.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eTipePrepayment))
    colKontakRepo.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
    colUangRepo.DataSource = New XPCollection(Of Persistent.MataUang)(session)
    colType2Repo.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eTipePrepayment2))
    colCoaRepo.DataSource = Logic.Coa.GetCoa(session, True) ' New XPCollection(Of NuSoft001.Persistent.Coa)(session)

    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
    sumber = New Persistent.SumberDataCollection(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("PPTransaksi.xml")) = True Then
      lytPengajuanDana.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("PPTransaksi.xml"))
    End If
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("PPTransaksiGrid.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("PPTransaksiGrid.xml"))
    End If
    setting = New Logic.FinaSetting(session)
    colReffNo.Caption = setting.PrePaymentReffNo1
    colReffNo2.Caption = setting.PrePaymentReffNo2
  End Sub
  Overrides Sub InitializeData()
    editAsign = True
    setting = New Logic.FinaSetting(session)
    If Tipe = InputType.Tambah Then
      instance = New Persistent.PrePaymentMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}

      MyBase.InitializeData()
      xGrid.DataSource = Nothing
      txtKontak.EditValue = Nothing
      txtKontakNama.Text = ""
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
      txtStatus.EditValue = Persistent.StatusTransaksiEnum.Posting
      ChangeCode()

      xGrid.DataSource = instance.Detail
      Me.Text = "Pre Payment: Tambah"
    Else
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.PrePaymentMain)(Convert.ToInt64(IdToEdit))
      instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
      txtKontak.EditValue = instance.Kontak
      txtKontakNama.Text = instance.Kontak.Nama
      txtTanggal.EditValue = instance.Tanggal
      txtNoTransaksi.Text = instance.Kode
      txtRegional.EditValue = instance.Regional
      txtUraian.EditValue = instance.Keterangan
      txtStatus.EditValue = instance.Status

      xGrid.DataSource = instance.Detail
      Me.Text = "Pre Payment: Edit - " & instance.Kode
    End If
    If instance.Status = Persistent.StatusTransaksiEnum.Approved Then
      'lock control
      txtStatus.Properties.ReadOnly = True
      txtNoTransaksi.Properties.ReadOnly = True
      txtKontak.Properties.ReadOnly = True
      txtRegional.Properties.ReadOnly = True
      txtTanggal.Properties.ReadOnly = True
      txtUraian.Properties.ReadOnly = True

      xGridView.OptionsBehavior.ReadOnly = True

    End If
    editAsign = False
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    Dim setting As New Logic.FinaSetting(session)

    colNilai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilai.DisplayFormat.FormatString = setting.NumericFormatToString
    colNilai.SummaryItem.DisplayFormat = setting.NumericFormatString
    mataUangDefault = setting.MultiMataUangDefault

    colPPH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colPPH.DisplayFormat.FormatString = setting.NumericFormatToString
    colPPH.SummaryItem.DisplayFormat = setting.NumericFormatString
    colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotal.DisplayFormat.FormatString = setting.NumericFormatToString
    colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString
  End Sub
  Overrides Sub SimpanData()
    If (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Pending) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.Posting) And (Not CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum) = NuSoft001.Persistent.StatusTransaksiEnum.ReqApprove) Then
      Throw New Utils.Exception("Status transaksi yang diperbolehkan hanya Pending atau Posting.", 0, "", "Simpan Transaksi")
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
        instance.fReg = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      End If
      instance.Keterangan = txtUraian.Text
      instance.Status = CType(txtStatus.EditValue, Persistent.StatusTransaksiEnum)
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
  Private Sub txtRegional_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtRegional.EditValueChanging
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
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("PPTransaksiGrid.xml"))
  End Sub
  'Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
  '  If Not e.Value Is Nothing Then
  '    If e.Column Is colKodeAkun Then
  '      Dim row As Persistent.PengajuanDanaDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.PengajuanDanaDetail)
  '      If Not row Is Nothing Then
  '        Dim xCoa As Persistent.Coa = CType(e.Value, Persistent.Coa)
  '        row.Divisi = xCoa.Divisi
  '        row.MataUang = xCoa.MataUang
  '        row.Kurs = Logic.Kurs.getKursBank(session, row.MataUang, txtTanggal.DateTime)
  '      End If
  '    End If
  '  End If
  'End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.PrePaymentDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.PrePaymentDetail)
    row.Type = Persistent.eTipePrepayment.LainLain
    row.Nilai = 0
    row.NilaiPPh23 = 0
    row.Catatan = ""
    row.MataUang = session.FindObject(Of Persistent.MataUang)(New BinaryOperator("Id", setting.MultiMataUangDefault, BinaryOperatorType.Equal))
    row.Main = instance
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.PrePaymentDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.PrePaymentDetail)
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
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.PP)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub txtRefreshNomor_Click(sender As Object, e As EventArgs) Handles txtRefreshNomor.Click
    ChangeCode()
  End Sub

End Class