Public Class UI_TipeTransaksiDialog
  Private instance As Persistent.TipeTransaksi
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("masterTipeTransaksi.xml")) = True Then
      lytMaster.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("masterTipeTransaksi.xml"))
    End If
  End Sub
  Overrides Sub InitializeData()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.TipeTransaksi(session)
    End If
    txtAkunPendapatan.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
		txtAkunHPP.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan, NuSoft001.Persistent.CoaEnum.eKind.BiayaOperasional})
		MyBase.InitializeData()
  End Sub
  Overrides Sub LoadAfterInitialize()
    If Tipe = InputType.Tambah Then
      Me.Text = "Tipe Transaksi: Tambah"
    Else
      instance = session.GetObjectByKey(Of Persistent.TipeTransaksi)(CType(IdToEdit, Int32))
      txtKode.EditValue = instance.Kode
      txtAkunPendapatan.EditValue = instance.CoaPendapatan
      txtAkunHPP.EditValue = instance.CoaCost
      Me.Text = "Tipe Transaksi : Edit - " & instance.Kode
    End If
  End Sub
  Overrides Sub SimpanData()
    instance.Kode = txtKode.Text
    instance.CoaPendapatan = CType(txtAkunPendapatan.EditValue, NuSoft001.Persistent.Coa)
    instance.CoaCost = CType(txtAkunHPP.EditValue, NuSoft001.Persistent.Coa)
    instance.Save()
    session.CommitChanges()
  End Sub
  Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtKode.Focus()
      Case -2 : txtAkunPendapatan.Focus()
      Case -3 : txtAkunHPP.Focus()
      Case Else
    End Select
  End Sub
  Private Sub xp_ResolveSession(sender As Object, e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpAkun.ResolveSession
    e.Session = session
  End Sub
  Private Sub txtAkunPendapatan_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtAkunPendapatan.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtAkunPendapatan.EditValue = Nothing
    End If
  End Sub
  Private Sub txtAkunHPP_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtAkunHPP.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtAkunHPP.EditValue = Nothing
    End If
  End Sub
End Class