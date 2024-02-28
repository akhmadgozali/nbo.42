Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Public Class UI_SaldoAwalDialog
  Private instance As Persistent.GlMain
  Private mataUangDefault As Integer
  Private isShown As Boolean
  Private detailToDelete As New List(Of Persistent.GlMainDetail)
  Private setting As Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Private editAsign As Boolean = False
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Persistent.GlMain.AutoSaveOnEndEdit = False
    Persistent.GlMainDetail.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("SaldoAwalTransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("SaldoAwalTransaksi.xml"))
    End If
    txtKontak.Properties.DataSource = New XPCollection(Of Persistent.Kontak)(session, New BinaryOperator("Aktif", True))
    txtCOA.Properties.DataSource = Logic.Coa.GetCoa(session, True)
    txtRegional.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Regional)(session)
    setting = New Logic.FinaSetting(session)
    sumber = New Persistent.SumberDataCollection(session)
  End Sub
  Overrides Sub InitializeData()
    editAsign = True
    If Tipe = InputType.Tambah Then
      instance = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
      MyBase.InitializeData()
      txtKontak.EditValue = Nothing
      txtCOA.EditValue = Nothing
      txtNilai.EditValue = 0.0
      txtKurs.EditValue = 1.0
      txtNilaiValas.EditValue = 0.0
      txtUraian.EditValue = "Saldo Awal COA"
      instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.SA)
      instance.Akun = Nothing
      txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      ChangeCode()
      Me.Text = "Saldo Awal Neraca: Tambah"
    Else
      'editAssign = True
      instance = session.GetObjectByKey(Of Persistent.GlMain)(Convert.ToInt64(IdToEdit))
      instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
      txtRegional.EditValue = instance.Regional
      txtNoTransaksi.EditValue = instance.Kode
      txtKontak.EditValue = instance.Kontak
      txtTanggal.EditValue = instance.Tanggal
      txtUraian.EditValue = instance.Uraian
      txtCOA.EditValue = instance.fCOA
      txtNilai.EditValue = instance.Saldo
      txtUang.EditValue = instance.fCOA.MataUang.Kode
      txtKurs.EditValue = instance.Kurs
      txtNilaiValas.EditValue = instance.SaldoValas
      Me.Text = "Saldo Awal Neraca: Edit"
    End If
    editAsign = False
  End Sub
  Overrides Sub LoadAfterInitialize()
    txtNilai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilai.Properties.Mask.EditMask = "n2"
    txtNilaiValas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilaiValas.Properties.Mask.EditMask = setting.NumericFormatToString
    txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtKurs.Properties.Mask.EditMask = setting.NumericFormatToString
  End Sub
  Overrides Sub SimpanData()
    Try
      If Not txtKontak.EditValue Is Nothing Then
        instance.Kontak = CType(txtKontak.EditValue, Persistent.Kontak)
      End If
      instance.ModuleId = NPO.Modules.ModuleId.Fina
      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      instance.Uraian = txtUraian.Text
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.Akun = CType(txtCOA.EditValue, Persistent.Coa)
      instance.Kurs = CType(txtKurs.EditValue, Double)
      instance.MataUang = CType(txtCOA.EditValue, Persistent.Coa).MataUang.Kode

      If CType(txtCOA.EditValue, Persistent.Coa).Tipe.Dc = Persistent.CoaEnum.eDc.Debit Then
        SimpanJurnal(0, CType(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(setting.PenampungSaldoAwal)), Persistent.Coa), 0, CType(txtNilai.EditValue, Double), 1, 0, 0)
        SimpanJurnal(1, CType(txtCOA.EditValue, Persistent.Coa), CType(txtNilai.EditValue, Double), 0, CType(txtKurs.EditValue, Double), CType(txtNilaiValas.EditValue, Double), 0)
      Else
        SimpanJurnal(0, CType(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(setting.PenampungSaldoAwal)), Persistent.Coa), CType(txtNilai.EditValue, Double), 0, 1, 0, 0)
        SimpanJurnal(1, CType(txtCOA.EditValue, Persistent.Coa), 0, CType(txtNilai.EditValue, Double), CType(txtKurs.EditValue, Double), 0, CType(txtNilaiValas.EditValue, Double))
      End If

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
  End Sub
  Private Sub ChangeCode()
    Dim xTglSA As Date = New Date(setting.AwalPeriodeTahun, setting.AwalPeriodeBulan, 1)
    txtTanggal.DateTime = xTglSA 'xTglSA.AddDays(-1) 'New Date(setting.AwalPeriodeTahun, setting.AwalPeriodeBulan, 1)
    instance.Tanggal = txtTanggal.DateTime

    Dim nomor As Core.Modules.NumberResult = instance.Number.GetNewNumber
    txtNoTransaksi.Text = nomor.Kode
  End Sub
  Private Sub txtCOA_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtCOA.EditValueChanging
    If Not e.NewValue Is Nothing Then
      editAsign = True
      txtUang.EditValue = CType(e.NewValue, Persistent.Coa).MataUang.Kode
      If CType(e.NewValue, Persistent.Coa).MataUang.Id = setting.MultiMataUangDefault Then
        txtKurs.EditValue = 1
        txtNilai.EditValue = 0.0
        txtNilaiValas.EditValue = 0.0
        txtKurs.Properties.ReadOnly = True
        txtNilaiValas.Properties.ReadOnly = True
      Else
        txtKurs.EditValue = Logic.Kurs.getKursBank(session, CType(e.NewValue, Persistent.Coa).MataUang, txtTanggal.DateTime)
        txtNilai.EditValue = 0.0
        txtNilaiValas.EditValue = 0.0
        txtKurs.Properties.ReadOnly = False
        txtNilaiValas.Properties.ReadOnly = True
      End If
      editAsign = False
    End If
  End Sub
  Private Sub SimpanJurnal(ByVal pUrutan As Byte, pAkun As Persistent.Coa, pDebit As Double, pKredit As Double, pKurs As Double, pDebitValas As Double, pKreditValas As Double)
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
  Private Sub txtNilai_EditValueChanged(sender As Object, e As EventArgs) Handles txtNilai.EditValueChanged, txtKurs.EditValueChanged
    If editAsign = False Then
      If CType(txtCOA.EditValue, Persistent.Coa).MataUang.Id = setting.MultiMataUangDefault Then
        txtNilaiValas.EditValue = 0.0
      Else
        txtNilaiValas.EditValue = CDbl(txtNilai.EditValue) / CDbl(txtKurs.EditValue)
      End If
    End If
  End Sub
  Private Sub txtNilaiValas_EditValueChanged(sender As Object, e As EventArgs) Handles txtNilaiValas.EditValueChanged
    If editAsign = False Then
      txtNilai.EditValue = CDbl(txtNilaiValas.EditValue) * CDbl(txtKurs.EditValue)
    End If
  End Sub

  Private Sub txtRegional_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtRegional.EditValueChanging
    Dim str As String = "Edit regional transaksi akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"
    Try
      If Tipe = InputType.Edit AndAlso isShown AndAlso setting.FormatNomor.Contains(My.Resources.FormatRegional) Then
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
      ElseIf Tipe = InputType.Tambah AndAlso setting.FormatNomor.Contains(My.Resources.FormatRegional) Then
        instance.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
        ChangeCode()
      End If

    Catch ex As Exception
      If ex.Message.Contains("Object reference not set to an instance") Then
      ElseIf ex.Message.Contains("Value cannot be null") Then
      Else
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Ganti Regional", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
      End If
    End Try
  End Sub
End Class