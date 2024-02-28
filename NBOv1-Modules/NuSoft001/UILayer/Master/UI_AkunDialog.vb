Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Friend Class UI_AkunDialog
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
    txtCFOUT.Properties.DataSource = New XPCollection(Of Persistent.CustomReportMain)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Tipe", Persistent.CustomReportTipe.CashFlow, BinaryOperatorType.Equal), New BinaryOperator("CashFlowTanda", Persistent.CustomReportTandaCashFlow.Minus, BinaryOperatorType.Equal)))
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("masterCoaDialog.xml")) = True Then
      lytMasterAkun.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("masterCoaDialog.xml"))
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
      txtCFIN.EditValue = instance.ReportCashFlowIN
      txtCFOUT.EditValue = instance.ReportCashFlowOut

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
    instance.ReportCashFlowIN = CType(txtCFIN.EditValue, Persistent.CustomReportMain)
    instance.ReportCashFlowOut = CType(txtCFOUT.EditValue, Persistent.CustomReportMain)

    instance.Save()
    session.CommitChanges()
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
  Private Sub txtSubAkun_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtSubAkun.EditValue = Nothing
    End If
  End Sub
End Class