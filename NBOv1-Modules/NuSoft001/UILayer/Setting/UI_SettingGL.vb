Friend Class UI_SettingGL
  Private item As Logic.FinaSetting
  Private xpSumber As Persistent.SumberDataCollection
  Private number As Logic.NumberClass

  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Persistent.SettingRegional.AutoSaveOnEndEdit = False
    Persistent.Coa.AutoSaveOnEndEdit = False
    AutoCloseOnSave = True
    Btn2IsClosedButton = True
  End Sub
  Overrides Sub InitializeUsedComponent()
    GetSession()
    EnsureDataInRegional()
    FillMonth()
    txtAkunSelisihKurs.Properties.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.PendapatanLainLain})
    colKasAkunRepo.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.Kas})
    txtSaldoAwal.Properties.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.Modal})
    xpSumber = New Persistent.SumberDataCollection(session)
    xSumber.DataSource = xpSumber

    item = New Logic.FinaSetting(session)
    number = New Logic.NumberClass(session)

    If Logic.GL.isAnyTransaction(session) Then
      txtPeriodeBulan.Enabled = False
      txtPeriodeTahun.Enabled = False
      txtDigitAngka.Enabled = False
      txtTampilkanDivisi.Enabled = False
      txtMultiMataUang.Enabled = False
      txtMataUangLokal.Enabled = False
      txtAkunSelisihKurs.Enabled = False
      txtFormat.Enabled = False
      xSumber.Enabled = False
      txtSaldoAwal.Enabled = False
    End If
  End Sub
  Overrides Sub InitializeData()
    txtPeriodeBulan.SelectedIndex = item.AwalPeriodeBulan - 1
    txtPeriodeTahun.EditValue = item.AwalPeriodeTahun
    txtDigitAngka.EditValue = item.FormatDigit
    txtTampilkanDivisi.Checked = item.MultiDivisi
    txtTampilkanProyek.Checked = item.MultiProyek
    txtMultiMataUang.Checked = item.MultiMataUangPakai
    txtMataUangLokal.EditValue = item.MultiMataUangDefault
    txtAkunSelisihKurs.EditValue = item.MultiMataUangAkunKurs
    txtFormat.EditValue = item.FormatNomor
    chkCoaKasBankJU.Checked = item.CoaKasBankPadaJU

    txtBKM.EditValue = item.UraianKM
    txtBKK.EditValue = item.UraianKK
    txtBBM.EditValue = item.UraianBM
    txtBBK.EditValue = item.UraianBK
    txtJU.EditValue = item.UraianJU
    txtJA.EditValue = item.UraianJA
    txtGM.EditValue = item.UraianGM
    txtGK.EditValue = item.UraianGK
    txtPD.EditValue = item.UraianPD
    txtSA.EditValue = item.UraianSA

    txtPrepaymentReff1.EditValue = item.PrePaymentReffNo1
    txtPrepaymentReff2.EditValue = item.PrePaymentReffNo2

    txtMultiMataUang_CheckedChanged(Me, Nothing)
    txtFormatHitung.Text = number.FormatCount(txtFormat.Text).ToString  '  .Logic.NumberClass.HitungFormatSetting(txtFormat.Text)

    txtSaldoAwal.EditValue = item.PenampungSaldoAwal
  End Sub
  Overrides Sub Btn1Click()
    Dim x As Boolean = False
    For i = 1 To 9
      If txtFormat.Text.Contains("[X" & i & "]") Then
        x = True
        Exit For
      End If
    Next
    If Not x Then
      Utils.Win.MessageBox.Show("Masukkan format urutan.", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      txtFormat.Focus()
      txtFormat.SelectAll()
      Exit Sub
    End If

    item.AwalPeriodeBulan = txtPeriodeBulan.SelectedIndex + 1
    item.AwalPeriodeTahun = CInt(txtPeriodeTahun.EditValue)
    item.FormatDigit = CInt(txtDigitAngka.EditValue)
    item.MultiDivisi = txtTampilkanDivisi.Checked
    item.MultiProyek = txtTampilkanProyek.Checked
    item.MultiMataUangPakai = txtMultiMataUang.Checked
    item.MultiMataUangDefault = CInt(txtMataUangLokal.EditValue)
    item.MultiMataUangAkunKurs = CInt(txtAkunSelisihKurs.EditValue)
    item.FormatNomor = CStr(txtFormat.EditValue)
    item.PenampungSaldoAwal = CInt(txtSaldoAwal.EditValue)
    item.CoaKasBankPadaJU = chkCoaKasBankJU.Checked

    item.UraianKM = txtBKM.EditValue.ToString
    item.UraianKK = txtBKK.EditValue.ToString
    item.UraianBM = txtBBM.EditValue.ToString
    item.UraianBK = txtBBK.EditValue.ToString
    item.UraianJU = txtJU.EditValue.ToString
    item.UraianJA = txtJA.EditValue.ToString
    item.UraianSA = txtSA.EditValue.ToString
    item.UraianGM = txtGM.EditValue.ToString
    item.UraianGK = txtGK.EditValue.ToString
    item.UraianPD = txtPD.EditValue.ToString

    item.PrePaymentReffNo1 = txtPrepaymentReff1.EditValue.ToString
    item.PrePaymentReffNo2 = txtPrepaymentReff2.EditValue.ToString

    item.Save()
    session.Save(xpRegional)
    session.Save(xpSumber)
    session.CommitChanges()
    Utils.Win.MessageBox.Show("Data sudah tersimpan.", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
  End Sub
  Overrides Sub ErrorBtn1Click(ByVal ex As Utils.Exception)
    MyBase.ErrorBtn1Click(ex)
  End Sub

  Private Sub FillMonth()
    txtPeriodeBulan.Properties.Items.Clear()
    For i = 1 To 12
      txtPeriodeBulan.Properties.Items.Add(MonthName(i))
    Next
  End Sub
  Private Sub EnsureDataInRegional()
    Dim xpReg As New DevExpress.Xpo.XPCollection(Of NPO.Modules.ModSys.Regional)(session)
    For i = 0 To xpReg.Count - 1
      If session.GetObjectByKey(Of Persistent.SettingRegional)(xpReg(i).Id) Is Nothing Then
        Dim item As New Persistent.SettingRegional(session) With {.Regional = xpReg(i)}
        item.Save()
      End If
    Next
  End Sub
  Private Sub xp_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpRegional.ResolveSession, xpMataUang.ResolveSession
    e.Session = GetSession()
  End Sub

  Private Sub txtMultiMataUang_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMultiMataUang.CheckedChanged
    txtMataUangLokal.Enabled = txtMultiMataUang.Checked
    txtAkunSelisihKurs.Enabled = txtMultiMataUang.Checked
  End Sub
  Private Sub txtFormat_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtFormat.EditValueChanging
    txtFormatHitung.Text = number.FormatCount(e.NewValue.ToString).ToString 'Logic.NumberClass.HitungFormatSetting(e.NewValue.ToString)
  End Sub

  Private Function IsAkunAnTransactional(akun As Persistent.Coa) As Boolean
    Return CType(session.Evaluate(Of Persistent.GlMain)(DevExpress.Data.Filtering.CriteriaOperator.Parse("Count()"), New DevExpress.Data.Filtering.BinaryOperator("Akun", akun, DevExpress.Data.Filtering.BinaryOperatorType.Equal)), Int64) > 0
  End Function
End Class