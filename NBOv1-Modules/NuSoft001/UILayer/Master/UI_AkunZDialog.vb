Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Friend Class UI_AkunZDialog
  Private instance As Persistent.Coa
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    txtTipeAkun.Properties.DataSource = New Persistent.CoaLevelCollection(session)
    txtCFIN.Properties.DataSource = New XPCollection(Of Persistent.CustomReportMain)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Tipe", Persistent.CustomReportTipe.CashFlow, BinaryOperatorType.Equal), New BinaryOperator("CashFlowTanda", Persistent.CustomReportTandaCashFlow.Plus, BinaryOperatorType.Equal)))
    txtCFOut.Properties.DataSource = New XPCollection(Of Persistent.CustomReportMain)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Tipe", Persistent.CustomReportTipe.CashFlow, BinaryOperatorType.Equal), New BinaryOperator("CashFlowTanda", Persistent.CustomReportTandaCashFlow.Minus, BinaryOperatorType.Equal)))
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("masterAkunzDialog.xml")) = True Then
      lytMasterAkun.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("masterAkunzDialog.xml"))
    End If
  End Sub
  Overrides Sub InitializeData()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.Coa(session)
    End If

    xpAkun.Reload()
    MyBase.InitializeData()
    txtTipeAkun.EditValue = txtTipeAkun.Properties.GetDataSourceValue("This", 0)
    txtAktif.Checked = True
    txtCFGabung.Checked = True
    txtAkunIntegrasi.Checked = False
  End Sub
  Overrides Sub LoadAfterInitialize()
    If Tipe = InputType.Tambah Then
      Me.Text = "Akun: Tambah"
    Else
      instance = session.GetObjectByKey(Of Persistent.Coa)(CType(IdToEdit, Int32))
      txtTipeAkun.EditValue = instance.Tipe
      txtAktif.Checked = instance.Aktif
      txtKode.EditValue = instance.Kode
      txtNama.EditValue = instance.Nama
      txtCFPlus.EditValue = instance.NamaCashFlowTambah
      txtCFMinus.EditValue = instance.NamaCashFlowMinus
      txtSubAkun.EditValue = instance.Induk
      txtMataUang.EditValue = instance.MataUang
      txtBank.EditValue = instance.Bank
      txtDivisi.EditValue = instance.Divisi
      txtCFGabung.EditValue = instance.GabungCashFlow
      txtAkunIntegrasi.EditValue = instance.AkunIntegrasi
      txtFormat.EditValue = instance.Format
      txtKeterangan.EditValue = instance.Keterangan
      txtLevelCoa1.EditValue = instance.Level1
      txtLevelCoa2.EditValue = instance.Level2
      txtLevelCoa3.EditValue = instance.Level3
      txtLevelCoa4.EditValue = instance.Level4
      txtCFIN.EditValue = instance.ReportCashFlowIN
      txtCFOut.EditValue = instance.ReportCashFlowOut

      Me.Text = "Akun: Edit - " & instance.Kode
    End If
  End Sub
  Overrides Sub SimpanData()
    instance.Tipe = CType(txtTipeAkun.EditValue, Persistent.CoaLevel)
    instance.Aktif = txtAktif.Checked
    instance.Kode = txtKode.Text
    instance.Nama = txtNama.Text
    instance.NamaCashFlowTambah = txtCFPlus.Text
    instance.NamaCashFlowMinus = txtCFMinus.Text
    instance.Induk = CType(txtSubAkun.EditValue, Persistent.Coa)
    instance.MataUang = CType(txtMataUang.EditValue, Persistent.MataUang)
    instance.Bank = CType(txtBank.EditValue, Persistent.Bank)
    instance.Divisi = CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi)
    instance.GabungCashFlow = txtCFGabung.Checked
    instance.AkunIntegrasi = txtAkunIntegrasi.Checked
    instance.Format = txtFormat.Text
    instance.Keterangan = txtKeterangan.Text

    'leveling
    instance.Level1 = CType(txtLevelCoa1.EditValue, Persistent.Coa)
    instance.Level2 = CType(txtLevelCoa2.EditValue, Persistent.Coa)
    instance.Level3 = CType(txtLevelCoa3.EditValue, Persistent.Coa)
    instance.Level4 = CType(txtLevelCoa4.EditValue, Persistent.Coa)
    Dim mLevel As Int16 = 0
    If Not txtLevelCoa4.EditValue Is Nothing Then
      mLevel = 4
    Else
      If Not txtLevelCoa3.EditValue Is Nothing Then
        mLevel = 3
      Else
        If Not txtLevelCoa2.EditValue Is Nothing Then
          mLevel = 2
        Else
          If Not txtLevelCoa1.EditValue Is Nothing Then
            mLevel = 1
          Else
            mLevel = 0
          End If
        End If
      End If
    End If
    instance.Level = mLevel
    instance.ReportCashFlowIN = CType(txtCFIN.EditValue, Persistent.CustomReportMain)
    instance.ReportCashFlowOut = CType(txtCFOut.EditValue, Persistent.CustomReportMain)

    instance.Save()
    session.CommitChanges()

    Dim xxCF As New XPCollection(Of Persistent.CustomReportDetail)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Akun.Id", instance.Id, BinaryOperatorType.Equal)))
    For i = xxCF.Count - 1 To 0 Step -1
      xxCF(i).Delete()
    Next
    session.CommitChanges()

    'MsgBox("OKE sampe sini")
    ''simpan untuk seting cashflownya
    'Dim xCF As New XPCollection(Of Persistent.CustomReportDetail)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Akun.Id", instance.Id, BinaryOperatorType.Equal), New BinaryOperator("Main.CashFlowTanda", Persistent.CustomReportTandaCashFlow.Plus, BinaryOperatorType.Equal)))
    'If xCF.Count = 0 Then
    '  Dim item As Persistent.CustomReportDetail
    '  MsgBox("Mrene lho")
    '  item = New Persistent.CustomReportDetail(session)
    '  item.Main = CType(txtCFIN.EditValue, Persistent.CustomReportMain)
    '  item.Akun = instance
    '  xCF.Add(item)
    'Else
    '  MsgBox("iki update asline)")
    '  xCF(0).Main = CType(txtCFIN.EditValue, Persistent.CustomReportMain)
    '  xCF(0).Save()
    'End If

    'session.CommitChanges()


    'Dim xCF As New XPCollection(Of Persistent.CustomReportDetail)(session, New BinaryOperator("Akun.Id", instance.Id, BinaryOperatorType.Equal))
    'For pI = xCF.Count - 1 To 0 Step -1
    '  xCF(pI).Delete()
    'Next
    'session.CommitChanges()


    'Dim xCF2 As New XPCollection(Of Persistent.CustomReportDetail)(session)
    'Dim item As Persistent.CustomReportDetail
    'item = New Persistent.CustomReportDetail(session)

    'item.Main = CType(txtCFIN.EditValue, Persistent.CustomReportMain)
    'item.Akun = instance
    'xCF2.Add(item)

    'item = New Persistent.CustomReportDetail(session)
    'item.Main = CType(txtCFOut.EditValue, Persistent.CustomReportMain)
    'item.Akun = instance
    'xCF2.Add(item)

    'session.CommitChanges()
  End Sub

  Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtKode.Focus()
      Case -2 : txtNama.Focus()
      Case -3 : txtMataUang.Focus()
      Case -4 : txtBank.Focus()
      Case -5 : txtFormat.Focus()
      Case Else
    End Select
  End Sub

  Private Sub xp_ResolveSession(sender As Object, e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpAkun.ResolveSession, xpBank.ResolveSession, xpMataUang.ResolveSession, xpDivisi.ResolveSession
    e.Session = session
  End Sub
  Private Sub txtTipeAkun_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTipeAkun.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Select Case CType(e.NewValue, Persistent.CoaLevel).Parameter
        Case Persistent.CoaEnum.eParameter.Kas : txtBank.Enabled = False : txtDivisi.Enabled = False : txtFormat.Enabled = True
        Case Persistent.CoaEnum.eParameter.Bank : txtBank.Enabled = True : txtDivisi.Enabled = False : txtFormat.Enabled = True
        Case Else
          txtBank.Enabled = False
          txtDivisi.Enabled = CType(e.NewValue, Persistent.CoaLevel).Level1 = Persistent.CoaEnum.eLevel1.RugiLaba
          txtFormat.Text = "" : txtFormat.Enabled = False
      End Select
    End If
  End Sub
  Private Sub txtSubAkun_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSubAkun.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtSubAkun.EditValue = Nothing
    End If
  End Sub
  Private Sub txtLevelCoa1_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtLevelCoa1.EditValueChanging, txtLevelCoa2.EditValueChanging, txtLevelCoa3.EditValueChanging, txtLevelCoa4.EditValueChanging
    If Not e.NewValue Is Nothing Then
      If sender Is txtLevelCoa1 Then txtNamaCoa1.Text = CType(e.NewValue, Persistent.Coa).Nama
      If sender Is txtLevelCoa2 Then txtNamaCoa2.Text = CType(e.NewValue, Persistent.Coa).Nama
      If sender Is txtLevelCoa3 Then txtNamaCoa3.Text = CType(e.NewValue, Persistent.Coa).Nama
      If sender Is txtLevelCoa4 Then txtNamaCoa4.Text = CType(e.NewValue, Persistent.Coa).Nama
    End If
  End Sub
End Class