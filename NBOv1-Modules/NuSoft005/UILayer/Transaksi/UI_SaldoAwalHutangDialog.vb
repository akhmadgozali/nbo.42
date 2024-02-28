Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem
Friend Class UI_SaldoAwalHutangDialog
  Private instance As Persistent.PenerimaanInvoice
  Private settingpurchase As Logic.PurchaseSetting
  Private setting As NuSoft001.Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private editAsign As Boolean = True
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
    NoDropIdentityMap = True
    Persistent.PenerimaanInvoice.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("BPTransaksi.xml")) = True Then
      lytTransaksi.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("BPTransaksi.xml"))
    End If

    settingpurchase = New Logic.PurchaseSetting(session)
    setting = New NuSoft001.Logic.FinaSetting(session)
    defaultRegional = UserInfo.GetDefaultRegional(session)
    sumber = New Persistent.SumberDataCollection(session)
    txtUang.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.MataUang)(session)
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
    If settingpurchase.FilterKontak = True Then
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Id", settingpurchase.TipeKontak, BinaryOperatorType.Equal))
    Else
      txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
    End If
    If Not defaultRegional Is Nothing Then
      txtRegional.EditValue = defaultRegional
    Else
      txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
    End If
    txtTanggal.EditValue = New Date(setting.AwalPeriodeTahun, setting.AwalPeriodeBulan, 1)
  End Sub
  Public Overrides Sub InitializeData()
    editAsign = True
    If Tipe = InputType.Tambah Then
      Me.Text = "Saldo Awal : Tambah"
      instance = New Persistent.PenerimaanInvoice(session)
      instance.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
      instance.Tanggal = txtTanggal.DateTime
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      ChangeCode()
      txtKeterangan.EditValue = "Saldo Awal Hutang"
      txtNilaiHutang.EditValue = 0
      txtKurs.EditValue = 1
      txtValas.EditValue = 0
      txtUang.EditValue = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
      txtValas.Properties.ReadOnly = True
      txtKurs.Properties.ReadOnly = True
      txtKontak.Focus()
    Else
      instance = session.GetObjectByKey(Of Persistent.PenerimaanInvoice)(CType(IdToEdit, Int64))
      txtNoTransaksi.EditValue = instance.Kode
      txtTanggal.EditValue = instance.Tanggal
      txtRegional.EditValue = instance.Regional
      txtKontak.EditValue = instance.Vendor
      txtNamaKontak.Text = instance.Vendor.Nama
      txtKeterangan.EditValue = instance.Catatan
      txtUang.EditValue = instance.Uang
      txtKurs.EditValue = instance.Kurs
      If instance.Uang.Id = setting.MultiMataUangDefault Then
        txtNilaiHutang.EditValue = instance.NilaiSaldoAwal
        txtValas.EditValue = 0
      Else
        txtNilaiHutang.EditValue = instance.NilaiSaldoAwal * instance.Kurs
        txtValas.EditValue = instance.NilaiSaldoAwal
      End If
      Me.Text = "Saldo Awal : Edit - " & instance.Kode
    End If
    editAsign = False
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    txtNilaiHutang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilaiHutang.Properties.Mask.EditMask = setting.NumericFormatToString
    txtKurs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtKurs.Properties.Mask.EditMask = setting.NumericFormatToString
    txtValas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtValas.Properties.Mask.EditMask = setting.NumericFormatToString
  End Sub
  Public Overrides Sub SimpanData()
    instance.Kode = txtNoTransaksi.Text
    instance.Tanggal = txtTanggal.DateTime
    instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
    instance.Vendor = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
    instance.Uang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang)
    instance.Kurs = CType(txtKurs.EditValue, Double)
    If instance.Uang.Id = setting.MultiMataUangDefault Then
      instance.NilaiSaldoAwal = CType(txtNilaiHutang.EditValue, Double)
    Else
      instance.NilaiSaldoAwal = CType(txtValas.EditValue, Double)
    End If
    instance.Catatan = txtKeterangan.Text
    instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
    '==== jurnalnya
    instance.Gl.Sumber = instance.Sumber
    instance.Gl.Tanggal = txtTanggal.EditValue
    instance.Gl.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
    instance.Gl.Kode = instance.Kode
    instance.Gl.ModuleId = NPO.Modules.ModuleId.Purchase
    instance.Gl.MataUang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Simbol
    instance.Gl.Kurs = txtKurs.EditValue
    instance.Gl.Kontak = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
    instance.Gl.KontakNama = txtKontak.Text
    instance.Gl.Uraian = txtKeterangan.Text
    SimpanGL(CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).HutangDagang, 1, 0, CType(txtNilaiHutang.EditValue, Double), 0, CType(txtValas.EditValue, Double))
    SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(setting.PenampungSaldoAwal)), 2, txtNilaiHutang.EditValue, 0, 0, 0, "")
    instance.Save()
    session.CommitChanges()
  End Sub
  Public Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
    ex.ShowWinMessageBox()
  End Sub
  Private Sub SimpanGL(Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double, DebitValas As Double, KreditValas As Double, Optional Catatan As String = "")
    Dim item As Persistent.GlMainDetail
    If instance.Gl.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
      item = instance.Gl.Detail.Single(Function(m) m.Urutan = Urutan)
      item.Akun = Akun
      item.MataUang = item.Akun.MataUang
      item.Main = instance.Gl
      item.Urutan = Urutan
      item.Debit = Debit
      item.Kredit = Kredit
      item.Keterangan = Catatan
      If Akun.MataUang.Id = setting.MultiMataUangDefault Then
        item.DebitValas = 0
        item.KreditValas = 0
        item.Kurs = 1
      Else
        item.DebitValas = DebitValas
        item.KreditValas = KreditValas
        item.Kurs = txtKurs.EditValue
      End If
    Else
      item = New Persistent.GlMainDetail(session)

      item.Akun = Akun
      item.MataUang = item.Akun.MataUang
      item.Main = instance.Gl
      item.Urutan = Urutan
      item.Debit = Debit
      item.Kredit = Kredit
      item.Keterangan = Catatan
      If Akun.MataUang.Id = setting.MultiMataUangDefault Then
        item.DebitValas = 0
        item.KreditValas = 0
        item.Kurs = 1
      Else
        item.DebitValas = DebitValas
        item.KreditValas = KreditValas
        item.Kurs = txtKurs.EditValue
      End If
      instance.Gl.Detail.Add(item)
    End If
  End Sub
  Private Sub txtUang_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtUang.EditValueChanging
    If Not e.NewValue Is Nothing And editAsign = False Then
      If CType(e.NewValue, NuSoft001.Persistent.MataUang).Id = setting.MultiMataUangDefault Then
        txtKurs.EditValue = 1
        txtKurs.Properties.ReadOnly = True
        txtValas.EditValue = 0
        txtValas.Properties.ReadOnly = True
      Else
        txtKurs.EditValue = NuSoft001.Logic.Kurs.getKursBank(session, CType(txtUang.EditValue, NuSoft001.Persistent.MataUang), txtTanggal.DateTime)
        txtValas.EditValue = CDbl(txtNilaiHutang.EditValue) / CDbl(txtKurs.EditValue)
        txtKurs.Properties.ReadOnly = False
        txtValas.Properties.ReadOnly = False
      End If
    End If
  End Sub
  Private Sub txtKurs_EditValueChanged(sender As Object, e As EventArgs) Handles txtKurs.EditValueChanged
    If editAsign = False Then
      txtValas.EditValue = CDbl(txtNilaiHutang.EditValue) / CDbl(txtKurs.EditValue)
    End If
  End Sub
  Private Sub txtNilaiHutang_EditValueChanged(sender As Object, e As EventArgs) Handles txtNilaiHutang.EditValueChanged
    If editAsign = False Then
      If CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Id = setting.MultiMataUangDefault Then
        txtValas.EditValue = 0
      Else
        txtValas.EditValue = CDbl(txtNilaiHutang.EditValue) / CDbl(txtKurs.EditValue)
      End If
    End If
  End Sub
  Private Sub txtValas_EditValueChanged(sender As Object, e As EventArgs) Handles txtValas.EditValueChanged
    If editAsign = False Then
      txtNilaiHutang.EditValue = CDbl(txtValas.EditValue) * CDbl(txtKurs.EditValue)
    End If
  End Sub
  Private Sub ChangeCode()
    If txtTanggal.EditValue Is Nothing OrElse instance.Tanggal = Nothing Then
      Return
    End If
    If setting.FormatNomor.Contains(NuSoft001.My.Resources.FormatRegional) AndAlso (txtRegional.EditValue Is Nothing OrElse instance.Regional Is Nothing) Then
      Return
    End If
    If setting.FormatNomor.Contains(NuSoft001.My.Resources.FormatSumber) AndAlso instance.Sumber Is Nothing Then
      Return
    End If

    Dim nomor As Core.Modules.NumberResult = instance.Number.GetNewNumber
    txtNoTransaksi.Text = nomor.Kode
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.BP)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
    instance.Gl.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
End Class