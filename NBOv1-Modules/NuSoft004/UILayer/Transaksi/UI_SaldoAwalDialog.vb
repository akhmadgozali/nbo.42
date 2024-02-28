Imports DevExpress.Xpo
Imports NuSoft.Core.SSystem
Imports DevExpress.Data.Filtering

Public Class UI_SaldoAwalDialog
  Private instance As Persistent.StockMain
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("BSTransaksi.xml")) = True Then
      lytTransaksiSA.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("BSTransaksi.xml"))
    End If
    sumber = New Persistent.SumberDataCollection(session)
    txtBarang.Properties.DataSource = New XPCollection(Of Persistent.Barang)(session)
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
    txtSatuan.Properties.DataSource = New XPCollection(Of Persistent.Satuan)(session)
    txtGudang.Properties.DataSource = New XPCollection(Of Persistent.Gudang)(session)
    txtGudang.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtGudang)
    txtKaryawan.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
    defaultRegional = UserInfo.GetDefaultRegional(session)
    If Not defaultRegional Is Nothing Then
      txtRegional.EditValue = defaultRegional
    Else
      txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
    End If
  End Sub
  Overrides Sub InitializeData()
    setting = New NuSoft001.Logic.FinaSetting(session)
    If Tipe = InputType.Tambah Then
      Me.Text = "Saldo Awal: Tambah"
      instance = New Persistent.StockMain(session)
      instance.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
      txtTanggal.EditValue = Now
      instance.Tanggal = txtTanggal.DateTime
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      ChangeCode()
      txtHarga.EditValue = 0.0
      txtQty.EditValue = 0.0
      LoadDefault()
    Else
      instance = session.GetObjectByKey(Of Persistent.StockMain)(CType(IdToEdit, Int64))
      txtTanggal.EditValue = instance.Tanggal
      txtNoTransaksi.EditValue = instance.Kode
      txtRegional.EditValue = instance.Regional
      txtGudang.EditValue = instance.Gudang
      txtBarang.EditValue = instance.Detail(0).Barang
      txtQty.EditValue = instance.Detail(0).QtyIn
      txtSatuan.EditValue = instance.Detail(0).Satuan
      txtHarga.EditValue = instance.Detail(0).HargaIn
      txtKaryawan.EditValue = instance.KaryawanKirim
      Me.Text = "Saldo Awal Edit - " & instance.Kode
      'cek dulu apakah sudah ada HPPnya, jika sudah ada maka dilock
      Dim xHPP As New XPCollection(Of Persistent.StockDetailHPPReff)(session, New BinaryOperator("DetailIN.Id", instance.Detail(0).Id, BinaryOperatorType.Equal))
      If xHPP.Count > 0 Then
        EnableVisibleSaveButton(False, False)
      End If
    End If
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    txtQty.Properties.Mask.EditMask = setting.NumericFormatToString
    txtHarga.Properties.Mask.EditMask = setting.NumericFormatToString
  End Sub
  Overrides Sub SimpanData()
    If Tipe = InputType.Tambah Then
      ChangeCode()
      For pi = 0 To instance.Detail.Count - 1
        instance.Detail(pi).Delete()
      Next
    End If
    Dim MataUangDefault As NuSoft001.Persistent.MataUang, zNilai As Double
    MataUangDefault = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
    instance.Kode = CType(txtNoTransaksi.EditValue, String)
    instance.Tanggal = CType(txtTanggal.EditValue, Date)
    instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
    instance.Gudang = CType(txtGudang.EditValue, Persistent.Gudang)
    instance.KaryawanKirim = CType(txtKaryawan.EditValue, NuSoft001.Persistent.Kontak)
    instance.MataUang = MataUangDefault
    instance.Kurs = 1
    instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Posting
    If Tipe = InputType.Tambah Then
      Dim zData As Persistent.StockDetail
      zData = New Persistent.StockDetail(session)
      zData.Main = instance
      zData.Barang = CType(txtBarang.EditValue, Persistent.Barang)
      zData.QtyIn = CType(txtQty.EditValue, Double)
      zData.Satuan = CType(txtSatuan.EditValue, Persistent.Satuan)
      zData.HargaIn = CType(txtHarga.EditValue, Double)
      instance.Detail.Add(zData)
    Else
      instance.Detail(0).Barang = CType(txtBarang.EditValue, Persistent.Barang)
      instance.Detail(0).QtyIn = CType(txtQty.EditValue, Double)
      instance.Detail(0).Satuan = CType(txtSatuan.EditValue, Persistent.Satuan)
      instance.Detail(0).HargaIn = CType(txtHarga.EditValue, Double)
    End If
    zNilai = instance.Detail(0).QtyIn * instance.Detail(0).HargaIn
    '==== jurnalnya
    instance.Gl.Sumber = instance.Sumber
    instance.Gl.Tanggal = instance.Tanggal
    instance.Gl.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
    instance.Gl.Kode = instance.Kode
    instance.Gl.ModuleId = NPO.Modules.ModuleId.Purchase
    instance.Gl.MataUang = MataUangDefault.Simbol
    instance.Gl.Kurs = 1
    instance.Gl.Kontak = CType(txtKaryawan.EditValue, NuSoft001.Persistent.Kontak)
    instance.Gl.KontakNama = CType(txtKaryawan.EditValue, NuSoft001.Persistent.Kontak).Nama
    instance.Gl.Uraian = "Saldo Awal Persediaan"
    SimpanGL(CType(txtBarang.EditValue, Persistent.Barang).CoaStock, 1, zNilai, 0, 0, 0)
    SimpanGL(session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(setting.PenampungSaldoAwal)), 2, 0, zNilai, 0, 0, "")

    instance.Save()
    session.CommitChanges()
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
      item.DebitValas = 0
      item.KreditValas = 0
      item.Kurs = 1
    Else
      item = New Persistent.GlMainDetail(session)

      item.Akun = Akun
      item.MataUang = item.Akun.MataUang
      item.Main = instance.Gl
      item.Urutan = Urutan
      item.Debit = Debit
      item.Kredit = Kredit
      item.Keterangan = Catatan
      item.DebitValas = 0
      item.KreditValas = 0
      item.Kurs = 1
      instance.Gl.Detail.Add(item)
    End If
  End Sub
  Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtBarang.Focus()
      Case -2 : txtGudang.Focus()
      Case -3 : txtQty.Focus()
      Case Else
    End Select
  End Sub
  Private Sub txtGudang_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtGudang.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtGudang.EditValue = Nothing
    End If
  End Sub
  Private Sub txtBarang_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtBarang.EditValueChanging
    If Not e.NewValue Is Nothing Then
      txtSatuan.EditValue = CType(e.NewValue, Persistent.Barang).Satuan
      txtHarga.EditValue = CType(e.NewValue, Persistent.Barang).LastPurchase
    End If
  End Sub
  Private Sub txtBarang_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBarang.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtBarang.EditValue = Nothing
    End If
  End Sub
  Sub LoadDefault()
    If xpSettingRegional Is Nothing Then
      xpSettingRegional = New XPCollection(Of NuSoft001.Persistent.SettingRegional)(session)
    End If
    defaultRegional = UserInfo.GetDefaultRegional(session)
    txtTanggal.EditValue = New Date(setting.AwalPeriodeTahun, setting.AwalPeriodeBulan, 1)
    If Not defaultRegional Is Nothing Then
      txtRegional.EditValue = defaultRegional
    Else
      txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
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
  Private Sub txtRegional_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtRegional.EditValueChanging
    Dim str As String = "Edit regional transaksi akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"
    Try
      If Tipe = InputType.Edit Then
        If Not instance.Regional Is e.NewValue Then
          If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Regional", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            instance.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
            ChangeCode()
          Else
            e.Cancel = True
          End If
        Else
          instance.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
          ChangeCode()
        End If
      ElseIf Tipe = InputType.Tambah Then
        instance.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
        ChangeCode()
      End If
    Catch ex As Exception
      If ex.Message.Contains("Object reference not set to an instance") Then
      Else
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Ganti Regional", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
      End If
    End Try
  End Sub
  Private Sub txtTanggal_DateTimeChanged(sender As Object, e As EventArgs) Handles txtTanggal.DateTimeChanged
    Dim str As String = "Edit tanggal dengan bulan dan tahun berbeda akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"
    Try
      If Tipe = InputType.Edit Then
        If instance.Tanggal.Month <> CDate(txtTanggal.EditValue).Month OrElse instance.Tanggal.Year <> CDate(txtTanggal.EditValue).Year Then
          If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Tanggal", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            instance.Tanggal = txtTanggal.DateTime
            ChangeCode()
          Else
            txtTanggal.EditValue = instance.Tanggal
          End If
        Else
          instance.Tanggal = txtTanggal.DateTime
        End If
      ElseIf Tipe = InputType.Tambah Then
        instance.Tanggal = txtTanggal.DateTime
        ChangeCode()
      End If
    Catch ex As Exception
      If ex.Message.Contains("Object reference not set to an instance") Then
      Else
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Me.Text, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
      End If
    End Try
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.BS)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
End Class