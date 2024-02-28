Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports NuSoft.Core.SSystem

Public Class UI_FusohKuotaImporDialog
  Private instance As Persistent.Fusoh_KuotaImpor

  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("masterimpor.xml")) = True Then
      lytMasterTermin.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("masterimpor.xml"))
    End If
    txtSatuan.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Satuan)(session)
    txtMataUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
  End Sub
  Overrides Sub InitializeData()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.Fusoh_KuotaImpor(session)
    End If
    MyBase.InitializeData()
  End Sub
  Overrides Sub LoadAfterInitialize()
    If Tipe = InputType.Tambah Then
      Me.Text = "Kuota Impor: Tambah"
      txtNomorHS.Text = ""
      txtNomorLampiran.Text = ""
      txtVolume.EditValue = 0
      txtSatuan.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtSatuan)
      txtMataUang.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtMataUang)
      txtHarga.EditValue = 0
      txtNegara.Text = "Indonesia"
      txtPelabuhan.Text = ""
      txtExpired.DateTime = Now
      txtKeterangan.Text = ""
    Else
      instance = session.GetObjectByKey(Of Persistent.Fusoh_KuotaImpor)(CType(IdToEdit, Int32))
      txtNomorHS.Text = instance.KodeHS
      txtNomorLampiran.Text = instance.NoLampiran
      txtVolume.EditValue = instance.Volume
      txtSatuan.EditValue = instance.Satuan
      txtMataUang.EditValue = instance.MataUang
      txtHarga.EditValue = instance.Harga
      txtNegara.Text = instance.Negara
      txtPelabuhan.Text = instance.Pelabuhan
      txtExpired.DateTime = instance.Expired
      txtKeterangan.Text = instance.Keterangan
      txtNoPerijinan.Text = instance.NoPerijinan
      txtTglMulaiBerlaku.DateTime = instance.TanggalMulaiBerlaku
      Me.Text = "Termin : Edit - " & instance.KodeHS

      Dim existing = New XPQuery(Of Persistent.Fusoh_OrderPembelianDetail)(session).Where(Function(w) w.KuotaImpor Is instance).Count
      If existing > 0 Then
        DisableControl()
      End If
    End If
  End Sub
  Private Sub DisableControl()
    txtNomorHS.Enabled = False
    txtNomorLampiran.Enabled = False
    txtVolume.Enabled = False
    txtSatuan.Enabled = False
    txtMataUang.Enabled = False
    txtHarga.Enabled = False
    txtNegara.Enabled = False
    txtPelabuhan.Enabled = False
    'txtExpired.Enabled = False
    txtKeterangan.Enabled = False
  End Sub
  Overrides Sub SimpanData()
    instance.KodeHS = txtNomorHS.Text
    instance.NoLampiran = txtNomorLampiran.Text
    instance.Volume = txtVolume.Value
    instance.Satuan = If(txtSatuan.EditValue Is Nothing, Nothing, CType(txtSatuan.EditValue, NuSoft004.Persistent.Satuan))
    instance.MataUang = If(txtMataUang.EditValue Is Nothing, Nothing, CType(txtMataUang.EditValue, NuSoft001.Persistent.MataUang))
    instance.Harga = txtHarga.Value
    instance.Negara = txtNegara.Text
    instance.Pelabuhan = txtPelabuhan.Text
    instance.Expired = txtExpired.DateTime
    instance.Keterangan = txtKeterangan.Text
    instance.NoPerijinan = txtNoPerijinan.Text
    instance.TanggalMulaiBerlaku = txtTglMulaiBerlaku.DateTime
    instance.Save()
    session.CommitChanges()
    '======= Simple log
    Try
      If Tipe = InputType.Tambah Then
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Tambah, "Data Kuota Impor -> " & instance.KodeHS)
      Else
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Edit, "Data Kuota Impor -> " & instance.KodeHS)
      End If
      session.CommitChanges()
    Catch ex As Exception
    End Try
  End Sub
  Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtNomorHS.Focus() : txtNomorHS.SelectAll()
      Case -2 : txtNomorLampiran.Focus() : txtNomorLampiran.SelectAll()
      Case -3 : txtVolume.Focus() : txtVolume.SelectAll()
      Case -4 : txtSatuan.Focus() : txtSatuan.SelectAll()
      Case -5 : txtHarga.Focus() : txtHarga.SelectAll()
      Case -6 : txtMataUang.Focus() : txtMataUang.SelectAll()
      Case -7 : txtNegara.Focus() : txtNegara.SelectAll()
      Case -8 : txtPelabuhan.Focus() : txtPelabuhan.SelectAll()
      Case -9 : txtExpired.Focus() : txtExpired.SelectAll()
      Case Else
    End Select
  End Sub

  Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
    'MyBase.OnKeyDown(e)
  End Sub
End Class