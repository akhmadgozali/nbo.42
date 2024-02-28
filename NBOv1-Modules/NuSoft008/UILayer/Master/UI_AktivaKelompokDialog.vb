Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Public Class UI_AktivaKelompokDialog
  Private instance As Persistent.AktivaKelompok
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
  End Sub
  Public Overrides Sub LoadAfterInitialize()
    txtTipe.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.ePenyusutanAsset))
    txtCoaAsset.Properties.DataSource = Logic.Coa.GetCoa(session, True, New NuSoft008.Persistent.CoaEnum.eKind() {NuSoft008.Persistent.CoaEnum.eKind.AktivaTetap})
    txtCoaDepresiasi.Properties.DataSource = Logic.Coa.GetCoa(session, True, New NuSoft008.Persistent.CoaEnum.eKind() {NuSoft008.Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.HargaPokokPenjualan})
    txtCoaAkumDepr.Properties.DataSource = Logic.Coa.GetCoa(session, True, New NuSoft008.Persistent.CoaEnum.eKind() {NuSoft008.Persistent.CoaEnum.eKind.AkumulasiPenyusutan})
    txtCOAWriteOff.Properties.DataSource = Logic.Coa.GetCoa(session, True, New NuSoft008.Persistent.CoaEnum.eKind() {NuSoft008.Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.BiayaLainLain})

    If Tipe = InputType.Tambah Then
      Me.Text = "Kelompok Aktiva : Tambah"
      instance = New Persistent.AktivaKelompok(session)
      txtUmur.EditValue = 0
      txtTipe.EditValue = Persistent.ePenyusutanAsset.GarisLurus
    Else
      instance = session.GetObjectByKey(Of Persistent.AktivaKelompok)(CType(IdToEdit, Int32))
      txtKode.EditValue = instance.Kode
      txtUmur.EditValue = instance.Umur
      txtTipe.EditValue = instance.TipePenyusutan
      txtCoaAsset.EditValue = instance.COAAsset
      txtCoaDepresiasi.EditValue = instance.COADepresiasi
      txtCoaAkumDepr.EditValue = instance.COAAkumulasiDepr
      txtCOAWriteOff.EditValue = instance.COAWriteOff
      Me.Text = "Kelompok Aktiva : Edit - " & instance.Kode
      'cek jika sudah ada master aktivanya, maka tidak boleh diedit untuk umurnya
      Dim xData As New XPCollection(Of Persistent.AktivaTetap)(session, New BinaryOperator("Kelompok.Id", instance.Id, BinaryOperatorType.Equal))
      If xData.Count > 0 Then
        EnableVisibleSaveButton(False, False)
      End If
    End If
  End Sub
  Public Overrides Sub SimpanData()
    instance.Kode = txtKode.Text
    instance.Umur = CType(txtUmur.Text, Integer)
    instance.TipePenyusutan = CType(txtTipe.EditValue, Persistent.ePenyusutanAsset)
    instance.COAAsset = CType(txtCoaAsset.EditValue, Persistent.Coa)
    instance.COADepresiasi = CType(txtCoaDepresiasi.EditValue, Persistent.Coa)
    instance.COAAkumulasiDepr = CType(txtCoaAkumDepr.EditValue, Persistent.Coa)
    instance.COAWriteOff = CType(txtCOAWriteOff.EditValue, Persistent.Coa)
    instance.Save()
    session.CommitChanges()
  End Sub

  Public Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -2 : txtKode.Focus()
      Case -3 : txtKode.Focus()
      Case -4 : txtUmur.Focus()
      Case -5 : txtCoaAsset.Focus()
      Case -6 : txtCoaDepresiasi.Focus()
      Case -7 : txtCoaAkumDepr.Focus()
      Case -8 : txtCOAWriteOff.Focus()
      Case Else
    End Select
  End Sub
End Class