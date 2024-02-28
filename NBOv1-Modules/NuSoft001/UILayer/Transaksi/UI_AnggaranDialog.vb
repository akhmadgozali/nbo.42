Imports DevExpress.Xpo
Public Class UI_AnggaranDialog
  Private instance As Persistent.Anggaran
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
  End Sub
  Public Overrides Sub LoadAfterInitialize()
    'repoTipe.Items.Clear()
    'repoTipe.Items.Add(Persistent.eTipeAlamat.Kantor)
    'repoTipe.Items.Add(Persistent.eTipeAlamat.Gudang)
    'txtKategori.Properties.DataSource = New DevExpress.Xpo.XPCollection(Of Persistent.TipeKontak)(session)

    'If Tipe = InputType.Tambah Then
    '  Me.Text = "Kontak: Tambah"
    '  instance = New Persistent.Kontak(session)
    '  txtBatasHutang.EditValue = 0
    '  txtBatasPiutang.EditValue = 0
    'Else
    '  instance = session.GetObjectByKey(Of Persistent.Kontak)(CType(IdToEdit, Int64))
    '  txtKode.EditValue = instance.Kode
    '  txtAktif.Checked = instance.Aktif
    '  txtNama.EditValue = instance.Nama
    '  txtKeterangan.EditValue = instance.Keterangan
    '  txtNPWP.EditValue = instance.NPWP
    '  txtNPWPAlamat.EditValue = instance.NPWPAlamat
    '  txtBatasHutang.EditValue = instance.BatasHutang
    '  txtBatasPiutang.EditValue = instance.BatasPiutang
    '  Me.Text = "Kontak: Edit - " & instance.Kode
    'End If
    'xGridAlamat.DataSource = instance.KontakAlamat
    'xGridCP.DataSource = instance.KontakPerson
  End Sub
  Public Overrides Sub SimpanData()
    'If Not txtKategori.EditValue Is Nothing Then
    '  instance.TipeKontak = CType(txtKategori.EditValue, Persistent.TipeKontak)
    'End If
    'instance.Kode = txtKode.Text
    'instance.Aktif = txtAktif.Checked
    'instance.Nama = txtNama.Text
    'instance.Keterangan = txtKeterangan.Text
    'instance.NPWP = txtNPWP.Text
    'instance.NPWPAlamat = txtNPWPAlamat.Text
    'instance.BatasHutang = CDbl(txtBatasHutang.EditValue)
    'instance.BatasPiutang = CDbl(txtBatasPiutang.EditValue)
    'instance.Save()
    'session.CommitChanges()
    If Tipe = InputType.Tambah Then
      Dim xJali As New XPCollection(Of Persistent.Anggaran)(session)
      Dim xCOA As New XPCollection(Of Persistent.Coa)(session)
      Dim data As Persistent.Anggaran
      For i = 0 To xCOA.Count - 1
        data = New Persistent.Anggaran(session)
        data.Akun = xCOA(i)
        xJali.Add(data)
      Next
      'xJali.commitchanges()

      MsgBox("Tambah coy")
    Else
      MsgBox("Edit Coy")
    End If
  End Sub
  Public Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
    ex.ShowWinMessageBox()
    'Select Case ex.ErrorNumber
    '  Case -1, -2 : txtKode.Focus()
    '  Case -3 : txtNama.Focus()
    '  Case -4 : txtKategori.Focus()
    '  Case Else
    'End Select
  End Sub
End Class