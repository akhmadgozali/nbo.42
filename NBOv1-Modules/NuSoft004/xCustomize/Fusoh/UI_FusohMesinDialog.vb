Imports NuSoft.Core.SSystem

Friend Class UI_FusohMesinDialog
  Private instance As Persistent.Fusoh_Mesin

  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = False
  End Sub
  Public Overrides Sub InitializeData()
    If Tipe = InputType.Tambah Then
      Me.Text = "Mesin: Tambah"
      instance = New Persistent.Fusoh_Mesin(session)
      txtKode.Text = ""
      txtNama.Text = ""
    Else
      instance = session.GetObjectByKey(Of Persistent.Fusoh_Mesin)(CType(IdToEdit, Int32))
      txtKode.EditValue = instance.Kode
      txtNama.EditValue = instance.Nama
      Me.Text = "Item: Edit - " & instance.Kode
    End If
  End Sub
  Public Overrides Sub SimpanData()
    instance.Kode = txtKode.Text
    instance.Nama = txtNama.Text
    instance.Save()
    session.CommitChanges()

    '======= Simple log
    Try
      If Tipe = InputType.Tambah Then
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Mesin -> " & instance.Kode)
      Else
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Mesin -> " & instance.Kode)
      End If
      session.CommitChanges()
    Catch ex As Exception
    End Try
  End Sub

  Public Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtKode.Focus()
      Case -2 : txtNama.Focus()
      Case Else
    End Select
  End Sub
End Class