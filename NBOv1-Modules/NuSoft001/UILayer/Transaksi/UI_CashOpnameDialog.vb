Public Class UI_CashOpnameDialog
  Private instance As Persistent.CashOpname
  Private setting As Logic.FinaSetting

  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = False
  End Sub
 Overrides Sub LoadBeforeInitialize()
  If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("COTransaksi.xml")) = True Then
   lytCo.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("COTransaksi.xml"))
  End If
  txtAkun.Properties.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.Kas})
  setting = New Logic.FinaSetting(session)
 End Sub
  Overrides Sub InitializeData()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.CashOpname(session)
    End If

    MyBase.InitializeData()
    txtTanggal.EditValue = Now
    txtAkun.EditValue = txtAkun.Properties.GetDataSourceValue("This", 0)
    txtNilai.EditValue = 0
    txtUser.Text = NuSoft.Core.SSystem.UserInfo.GetUserCode
    txtUserNama.Text = NuSoft.Core.SSystem.UserInfo.GetUserName
  End Sub
  Overrides Sub LoadAfterInitialize()
    If Tipe = InputType.Tambah Then
      Me.Text = "Cash Opname: Tambah"
    Else
      instance = session.GetObjectByKey(Of Persistent.CashOpname)(CType(IdToEdit, Int32))
      txtTanggal.EditValue = instance.Tanggal
      txtUraian.EditValue = instance.Keterangan
      txtAkun.EditValue = instance.Akun
      txtNilai.EditValue = instance.Total
      Me.Text = "Cash Opname: Edit - " & instance.Akun.Kode
    End If
  End Sub
  Overrides Sub SimpanData()
    instance.Tanggal = txtTanggal.DateTime
    If Not txtAkun.EditValue Is Nothing Then
      instance.Akun = CType(txtAkun.EditValue, Persistent.Coa)
    End If
    If Not txtNilai.EditValue Is Nothing Then
      instance.Total = CDbl(txtNilai.EditValue)
    End If
    instance.Keterangan = txtUraian.Text
    session.CommitChanges()
  End Sub

  Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtTanggal.Focus()
      Case -2 : txtAkun.Focus()
      Case -3 : txtNilai.Focus()
      Case Else
    End Select
  End Sub

  Private Sub txtAkun_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtAkun.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Dim item As Persistent.Coa = CType(e.NewValue, Persistent.Coa)
      txtAkunNama.Text = item.Nama
      Dim info As Globalization.CultureInfo = CType(My.Application.Culture.Clone, Globalization.CultureInfo)   'New Globalization.CultureInfo("en-GB") 'CType(txtNilai.Properties.Mask.Culture.Clone, Globalization.CultureInfo)
      info.NumberFormat.CurrencySymbol = item.MataUang.Simbol & " "
      txtNilai.Properties.Mask.Culture = info
      txtNilai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
      txtNilai.Properties.Mask.EditMask = "c" & setting.FormatDigit
    End If
  End Sub
End Class
