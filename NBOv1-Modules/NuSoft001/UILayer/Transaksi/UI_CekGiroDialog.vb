Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Friend Class UI_CekGiroDialog
  Private instance As Persistent.GlMain
  Private mataUangDefault As Integer
  Private editAsign As Boolean = True
  Private detailToDelete As New List(Of Persistent.GlMain)
  Private setting As Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Private xTipeGiro As Persistent.eJenisGiro, xID As Int64
  Private xDataGiro As Persistent.ViewGiro
  Public Sub New(pTipe As Persistent.eJenisGiro, pID As Int64)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Persistent.GlMain.AutoSaveOnEndEdit = False
    Persistent.GlMainDetail.AutoSaveOnEndEdit = False
    xTipeGiro = pTipe
    xID = pID
    AutoCloseOnSave = True
  End Sub
  Overrides Sub LoadBeforeInitialize()
    txtKontak.Properties.DataSource = New XPCollection(Of Persistent.Kontak)(session, New BinaryOperator("Aktif", True))
    txtRegional.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Regional)(session)
    txtCoaBank.Properties.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.Bank})
    txtCOAGiro.Properties.DataSource = Logic.Coa.GetCoa(session, True)
    sumber = New Persistent.SumberDataCollection(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("GiroDialog.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("GiroDialog.xml"))
    End If
    setting = New Logic.FinaSetting(session)
  End Sub
  Overrides Sub InitializeData()
    editAsign = True
    If Tipe = InputType.Tambah Then
      instance = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}

      MyBase.InitializeData()
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
      'isikan data gironya
      xDataGiro = session.FindObject(Of Persistent.ViewGiro)(New BinaryOperator("Id", xID, BinaryOperatorType.Equal))
      'Dim xDataGL As Persistent.GlMain = session.FindObject(Of Persistent.GlMain)(New BinaryOperator("Id", xDataGiro.NoBukti.Id, BinaryOperatorType.Equal))

      If xDataGiro Is Nothing Then
        Throw New Utils.Exception("Data tidak ditemukan.", 0, "", "Pencarian GL")
        EnableVisibleSaveButton(False, False)
        Exit Sub
      Else
        txtKontak.EditValue = xDataGiro.NoBukti.Kontak
        txtCoaBank.EditValue = xDataGiro.NoBukti.fCOA
        txtUangBank.EditValue = CType(txtCoaBank.EditValue, Persistent.Coa).MataUang.Kode

        Dim item As Persistent.GlMainDetail
        item = xDataGiro.NoBukti.Detail.Single(Function(m) m.Urutan = 0)
        txtCOAGiro.EditValue = item.Akun
        txtUangGiro.EditValue = item.MataUang.Kode
        txtNilaiGiro.EditValue = CDbl(item.Debit + item.Kredit)
        txtKursGiro.EditValue = item.Kurs
        txtValasGiro.EditValue = CDbl(item.DebitValas + item.KreditValas)

        txtValasBank.EditValue = CDbl(item.DebitValas + item.KreditValas)
        txtKursBank.EditValue = Logic.Kurs.getKursBank(session, CType(txtCoaBank.EditValue, Persistent.Coa).MataUang, txtTanggal.DateTime)
        If CType(txtCoaBank.EditValue, Persistent.Coa).MataUang.Id = setting.MultiMataUangDefault Then
          txtNilaiBank.EditValue = CDbl(item.Debit + item.Kredit)
          txtKursBank.Properties.ReadOnly = True
        Else
          txtNilaiBank.EditValue = CDbl(txtValasBank.EditValue) * CDbl(txtKursBank.EditValue)
          txtKursBank.Properties.ReadOnly = False
        End If
      End If

      ChangeCode()
      Me.Text = "Giro " & IIf(xTipeGiro = Persistent.eJenisGiro.Masuk, "Masuk", "Keluar").ToString & " : Tambah Data"
    Else
      instance = session.GetObjectByKey(Of Persistent.GlMain)(Convert.ToInt64(IdToEdit))
      instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
      txtKontak.EditValue = instance.Kontak
      txtTanggal.EditValue = instance.Tanggal
      txtNoTransaksi.Text = instance.Kode
      txtRegional.EditValue = instance.Regional
      Me.Text = "Giro : Edit - " & instance.Kode
    End If
    editAsign = False
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    txtNilaiBank.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilaiBank.Properties.Mask.EditMask = setting.NumericFormatToString
    txtKursBank.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtKursBank.Properties.Mask.EditMask = setting.NumericFormatToString
    txtValasBank.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtValasBank.Properties.Mask.EditMask = setting.NumericFormatToString
    txtNilaiGiro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilaiGiro.Properties.Mask.EditMask = setting.NumericFormatToString
    txtKursGiro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtKursGiro.Properties.Mask.EditMask = setting.NumericFormatToString
    txtValasGiro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtValasGiro.Properties.Mask.EditMask = setting.NumericFormatToString
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
      End If
      If Not txtCoaBank.EditValue Is Nothing Then
        instance.Akun = CType(txtCoaBank.EditValue, Persistent.Coa)
      End If
      instance.fCOA = CType(txtCoaBank.EditValue, Persistent.Coa)
      instance.Uraian = txtUraian.Text
      If xTipeGiro = Persistent.eJenisGiro.Masuk Then
        SimpanGL(0, CType(txtCoaBank.EditValue, Persistent.Coa), CDbl(txtNilaiBank.EditValue), 0, CDbl(txtKursBank.EditValue), CDbl(txtValasBank.EditValue), 0)
        SimpanGL(1, CType(txtCOAGiro.EditValue, Persistent.Coa), 0, CDbl(txtNilaiGiro.EditValue), CDbl(txtKursGiro.EditValue), 0, CDbl(txtValasGiro.EditValue))
      Else
        SimpanGL(0, CType(txtCoaBank.EditValue, Persistent.Coa), 0, CDbl(txtNilaiBank.EditValue), CDbl(txtKursBank.EditValue), 0, CDbl(txtValasBank.EditValue))
        SimpanGL(1, CType(txtCOAGiro.EditValue, Persistent.Coa), CDbl(txtNilaiGiro.EditValue), 0, CDbl(txtKursGiro.EditValue), CDbl(txtValasGiro.EditValue), 0)
      End If
      'update dulu untuk giro nya
      Dim xGLGiro As Persistent.GlMain = session.FindObject(Of Persistent.GlMain)(New BinaryOperator("Id", xDataGiro.NoBukti.Id, BinaryOperatorType.Equal))
      xGLGiro.Giro(0).TransaksiCair = instance
      xGLGiro.Giro(0).Status = True

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
    End Select
  End Sub
  Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
    If e.NewValue Is Nothing Then
      lblNamaKontak.Text = ""
    Else
      Dim item As Persistent.Kontak = CType(e.NewValue, Persistent.Kontak)
      lblNamaKontak.Text = item.Nama
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
    If xTipeGiro = Persistent.eJenisGiro.Masuk Then
      instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.GM)
    Else
      instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.GK)
    End If
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub txtRefreshNomor_Click(sender As Object, e As EventArgs) Handles txtRefreshNomor.Click
    ChangeCode()
  End Sub
  Private Sub txtKursBank_EditValueChanged(sender As Object, e As EventArgs) Handles txtKursBank.EditValueChanged
    txtNilaiBank.EditValue = CDbl(txtKursBank.EditValue) * CDbl(txtValasBank.EditValue)
  End Sub
  Private Sub SimpanGL(ByVal pUrutan As Byte, pAkun As Persistent.Coa, pDebit As Double, pKredit As Double, pKurs As Double, pDebitValas As Double, pKreditValas As Double)
    Dim item As Persistent.GlMainDetail
    If instance.Detail.ToList.Exists(Function(m) m.Urutan = pUrutan) Then
      item = instance.Detail.Single(Function(m) m.Urutan = pUrutan)
      item.Akun = pAkun
      item.MataUang = pAkun.MataUang
      item.Main = instance
      item.Debit = pDebit
      item.Kredit = pKredit
      item.Kurs = pKurs
      item.DebitValas = pDebitValas
      item.KreditValas = pKreditValas
      item.Divisi = Nothing
    Else
      item = New Persistent.GlMainDetail(session)
      item.Urutan = pUrutan
      item.Akun = pAkun
      item.MataUang = pAkun.MataUang
      item.Main = instance
      item.Debit = pDebit
      item.Kredit = pKredit
      item.Kurs = pKurs
      item.DebitValas = pDebitValas
      item.KreditValas = pKreditValas
      item.Divisi = Nothing
      instance.Detail.Add(item)
    End If
  End Sub
End Class