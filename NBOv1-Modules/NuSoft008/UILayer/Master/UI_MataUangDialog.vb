Friend Class UI_MataUangDialog
    Private instance As Persistent.MataUang
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        AutoCloseOnSave = True
 End Sub
 Public Overrides Sub LoadBeforeInitialize()
  If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("masteruang.xml")) = True Then
   lytMasterUang.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("masteruang.xml"))
  End If
 End Sub


 Public Overrides Sub LoadAfterInitialize()
  Dim setting As New Logic.FinaSetting(session)
  If Tipe = InputType.Tambah Then
   Me.Text = "Uang : Tambah"
   instance = New Persistent.MataUang(session)
  Else
   instance = session.GetObjectByKey(Of Persistent.MataUang)(CType(IdToEdit, Int32))
   txtKode.EditValue = instance.Kode
   txtNama.EditValue = instance.Nama
   txtNegara.EditValue = instance.Negara
   txtSimbol.EditValue = instance.Simbol
   Me.Text = "Uang : Edit - " & instance.Kode
   If instance.Id = setting.MultiMataUangDefault Then
    xGridKursView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
   End If
  End If
  xGridKurs.DataSource = instance.MataUangKurs
  colKursUang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
  colKursUang.DisplayFormat.FormatString = setting.NumericFormatString
  colKursPajak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
  colKursPajak.DisplayFormat.FormatString = setting.NumericFormatString

 End Sub
  Public Overrides Sub SimpanData()
    Try
      instance.Kode = txtKode.Text
      instance.Nama = txtNama.Text
      instance.Negara = txtNegara.Text
      instance.Simbol = txtSimbol.Text
      instance.Save()
      session.CommitChanges()
    Catch ex As Utils.Exception
      Throw New Utils.Exception(ex)
    Catch ex As Exception
      If ex.Message.Contains("Duplicate entry") Then
        Throw New Utils.Exception("Tidak boleh ada data yang double.", 0, "", "Master Uang")
      Else
        Throw New Exception(ex.Message, ex.InnerException)
      End If
    End Try
  End Sub

 Public Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
  ex.ShowWinMessageBox()
  Select Case ex.ErrorNumber
   Case -1, -2 : txtKode.Focus()
   Case -3 : txtNama.Focus()
   Case Else
  End Select
 End Sub
End Class