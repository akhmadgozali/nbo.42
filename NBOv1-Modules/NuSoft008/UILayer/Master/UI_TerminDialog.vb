Public Class UI_TerminDialog
  Private instance As Persistent.Termin
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("mastertermin.xml")) = True Then
      lytMasterTermin.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("mastertermin.xml"))
    End If
  End Sub
  Overrides Sub InitializeData()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.Termin(session)
    End If
    MyBase.InitializeData()
  End Sub
  Overrides Sub LoadAfterInitialize()
    If Tipe = InputType.Tambah Then
      Me.Text = "Termin: Tambah"
      txtTempo.EditValue = 0
      txtDenda.EditValue = 0
      txtDendaP.EditValue = 0
      txtDisc.EditValue = 0
      txtDiscP.EditValue = 0
    Else
      instance = session.GetObjectByKey(Of Persistent.Termin)(CType(IdToEdit, Int32))
      txtKode.EditValue = instance.Kode
      txtTempo.EditValue = instance.Tempo
      txtDenda.EditValue = instance.PenaltiesDay
      txtDendaP.EditValue = instance.PenaltiesPersen
      txtDisc.EditValue = instance.DiscDay
      txtDiscP.EditValue = instance.DiscPersen
      Me.Text = "Termin : Edit - " & instance.Kode
    End If
  End Sub
  Overrides Sub SimpanData()
    instance.Kode = txtKode.Text
    instance.Tempo = CType(txtTempo.EditValue, Int16)
    instance.DiscDay = CType(txtDisc.EditValue, Int16)
    instance.DiscPersen = CType(txtDiscP.EditValue, Double)
    instance.PenaltiesDay = CType(txtDenda.EditValue, Int16)
    instance.PenaltiesPersen = CType(txtDendaP.EditValue, Double)
    instance.Save()
    session.CommitChanges()
  End Sub
  Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtKode.Focus()
      Case Else
    End Select
  End Sub
End Class