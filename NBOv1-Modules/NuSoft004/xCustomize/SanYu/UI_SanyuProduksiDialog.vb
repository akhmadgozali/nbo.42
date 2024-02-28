Imports DevExpress.Xpo
Imports NuSoft.Core.SSystem
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraGrid.Views.Base

Public Class UI_SanyuProduksiDialog
  Private instance As Persistent.SanYu_ProduksiMain
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private settingInventory As Logic.InventorySetting
  Private sumber As Persistent.SumberDataCollection
  Private editAssign As Boolean = False
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    'If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("BSTransaksi.xml")) = True Then
    '  lytTransaksiSA.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("BSTransaksi.xml"))
    'End If
    sumber = New Persistent.SumberDataCollection(session)
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
    txtNoRencanaProduksi.Properties.DataSource = New XPCollection(Of Persistent.SanYu_RencanaProduksiDetail)(session)
    txtProses.Properties.DataSource = New XPCollection(Of Persistent.SanYu_ProsesProduksi)(session)
    'txtProses.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtProses)

    colKodeBarangRepo.DataSource = New XPCollection(Of Persistent.SanYu_Barang)(session, New BinaryOperator("TipeBarang", NuSoft004.Persistent.TipeBarang.BahanPembantu, BinaryOperatorType.Equal))
    txtKodeWaste.Properties.DataSource = New XPCollection(Of Persistent.SanYu_Barang)(session, New BinaryOperator("TipeBarang", NuSoft004.Persistent.TipeBarang.BahanWaste, BinaryOperatorType.Equal))
    txtTanggal.EditValue = Now
    defaultRegional = UserInfo.GetDefaultRegional(session)
    If Not defaultRegional Is Nothing Then
      txtRegional.EditValue = defaultRegional
    Else
      txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
    End If
    lytgWaste.Enabled = False
  End Sub
  Overrides Sub InitializeData()
    setting = New NuSoft001.Logic.FinaSetting(session)
    settingInventory = New Logic.InventorySetting(session)
    editAssign = True
    If Tipe = InputType.Tambah Then
      Me.Text = "Produksi : Tambah"
      instance = New Persistent.SanYu_ProduksiMain(session)
      xGridDetail.DataSource = Nothing
      xGridBahanPembantu.DataSource = Nothing
      txtTanggal.EditValue = Now
      instance.Tanggal = txtTanggal.DateTime
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      ChangeCode()
      txtQty.EditValue = 0.0
      txtBahanBakuQty.EditValue = 0
      txtBahanBakuTonase.EditValue = 0
      txtBahanJadiQty.EditValue = 0
      txtBahanJadiTonase.EditValue = 0
      txtWasteQty.EditValue = 0
      txtWasteTonase.EditValue = 0
      txtPembantuQty.EditValue = 0
      txtPembantuTonase.EditValue = 0
      txtBatch.Text = ""
      LoadDefault()
      xGridDetail.DataSource = instance.Detail
      xGridBahanPembantu.DataSource = instance.Pembantu
    Else
      instance = session.GetObjectByKey(Of Persistent.SanYu_ProduksiMain)(CType(IdToEdit, Int64))
      xGridDetail.DataSource = Nothing
      xGridBahanPembantu.DataSource = Nothing
      txtTanggal.EditValue = instance.Tanggal
      txtNoTransaksi.EditValue = instance.Kode
      txtRegional.EditValue = instance.Regional
      txtProses.EditValue = instance.Proses
      txtNoRencanaProduksi.EditValue = instance.RencanaProduksi
      txtNoPO.Text = instance.RencanaProduksi.Main.OrderPenjualan.Kode
      txtQtyPO.Text = instance.RencanaProduksi.OrderPenjualan.Qty.ToString("n2") & " " & instance.RencanaProduksi.OrderPenjualan.JenisPenjualan
      txtBahanBaku.Text = instance.ItemBaku.Nama
      txtBarangJadi.Text = instance.ItemJadi.Nama
      txtNoSebelumnya.EditValue = instance.ProduksiSebelumnya





      txtKodeWaste.EditValue = instance.ItemWaste

      txtBahanBakuQty.EditValue = instance.BahanBakuM3
      txtBahanBakuTonase.EditValue = instance.BahanBakuTonase
      txtBahanJadiQty.EditValue = instance.BahanJadiM3
      txtBahanJadiTonase.EditValue = instance.BahanJadiTonase
      txtWasteQty.EditValue = instance.BahanWasteM3
      txtWasteTonase.EditValue = instance.BahanWasteTonase
      txtPembantuQty.EditValue = instance.BahanPembantuM3
      txtPembantuTonase.EditValue = instance.BahanJadiTonase
      txtBatch.EditValue = instance.BatchNo

      xGridDetail.DataSource = instance.Detail
      xGridBahanPembantu.DataSource = instance.Pembantu
      Me.Text = "Produksi Edit - " & instance.Kode
    End If
    editAssign = False
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    txtQty.Properties.Mask.EditMask = setting.NumericFormatToString
  End Sub
  Overrides Sub SimpanData()
    If txtProses.EditValue Is Nothing Then
      Throw New Utils.Exception("Silahkan pilih kode proses produksi.", 0, "", "Simpan Transaksi")
      Exit Sub
    End If
    If CType(txtProses.EditValue, Persistent.SanYu_ProsesProduksi).Finish = True Then
      If txtKodeWaste.EditValue Is Nothing Then
        Throw New Utils.Exception("Silahkan pilih kode barang waste.", 0, "", "Simpan Transaksi")
        Exit Sub
      End If
    End If


    If Tipe = InputType.Tambah Then
      ChangeCode()
    End If
    instance.Kode = CType(txtNoTransaksi.EditValue, String)
    instance.Tanggal = CType(txtTanggal.EditValue, Date)
    instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
    instance.RencanaProduksi = CType(txtNoRencanaProduksi.EditValue, Persistent.SanYu_RencanaProduksiDetail)
    instance.Proses = CType(txtProses.EditValue, Persistent.SanYu_ProsesProduksi)
    instance.Pelanggan = instance.RencanaProduksi.Main.Pelanggan
    instance.ItemJadi = instance.RencanaProduksi.Barang
    instance.ItemBaku = instance.RencanaProduksi.BahanBaku
    instance.OrderPenjualan = instance.RencanaProduksi.OrderPenjualan
    instance.ItemWaste = CType(txtKodeWaste.EditValue, Persistent.SanYu_Barang)

    instance.BahanBakuM3 = CType(txtBahanBakuQty.EditValue, Double)
    instance.BahanBakuTonase = CType(txtBahanBakuTonase.EditValue, Double)
    instance.BahanJadiM3 = CType(txtBahanJadiQty.EditValue, Double)
    instance.BahanJadiTonase = CType(txtBahanJadiTonase.EditValue, Double)
    instance.BahanWasteM3 = CType(txtWasteQty.EditValue, Double)
    instance.BahanWasteTonase = CType(txtWasteTonase.EditValue, Double)
    instance.BahanPembantuM3 = CType(txtPembantuQty.EditValue, Double)
    instance.BahanJadiTonase = CType(txtPembantuTonase.EditValue, Double)
    instance.BatchNo = txtBatch.Text
    If Not txtNoSebelumnya.EditValue Is Nothing Then
      instance.ProduksiSebelumnya = CType(txtNoSebelumnya.EditValue, Persistent.SanYu_ProduksiMain)
    End If
    If CType(txtProses.EditValue, Persistent.SanYu_ProsesProduksi).Mutasi = True Then
      'simpanMutasi()
    Else
      simpanProsesProduksi()
      If CType(txtProses.EditValue, Persistent.SanYu_ProsesProduksi).Finish = True Then
        simpanHasilProduksi()
      End If
    End If
    instance.Save()
    If Tipe = InputType.Tambah Then
      Logic.Umum.SaveLog(session, Persistent.TipeLOG.Add, "Admin", "Produksi: Tambah " & instance.Kode)
    Else
      Logic.Umum.SaveLog(session, Persistent.TipeLOG.Edit, "Admin", "Produksi: Edit " & instance.Kode)
    End If
    session.CommitChanges()
  End Sub
  'Sub simpanMutasi()
  '  If instance.StockProses Is Nothing Then
  '    instance.StockProses = New Persistent.SanYu_StokMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
  '  End If
  '  instance.StockProses.Sumber = instance.Sumber
  '  instance.StockProses.Regional = instance.Regional
  '  instance.StockProses.Tanggal = instance.Tanggal
  '  instance.StockProses.Kode = instance.Kode & "-M"
  '  instance.StockProses.Pelanggan = instance.OrderPenjualan.Main.Pelanggan
  '  instance.StockProses.Gudang = session.GetObjectByKey(Of Persistent.Gudang)(Convert.ToInt32(settingInventory.GudangProduksi))
  '  Dim pUrutan As Byte = 0
  '  For pi = 0 To instance.Detail.Count - 1
  '    pUrutan = CByte(pUrutan + 1)
  '    SimpanStockMutasi(instance.ItemBaku, session.GetObjectByKey(Of Persistent.Gudang)(Convert.ToInt32(settingInventory.Gudang1)), pUrutan, 0, instance.Detail(pi).Qty, 0)
  '    pUrutan = CByte(pUrutan + 1)
  '    SimpanStockMutasi(instance.ItemBaku, session.GetObjectByKey(Of Persistent.Gudang)(Convert.ToInt32(settingInventory.GudangProduksi)), pUrutan, instance.Detail(pi).Qty, 0, 0)
  '  Next

  '  For pi = 0 To instance.Pembantu.Count - 1
  '    pUrutan = CByte(pUrutan + 1)
  '    SimpanStockMutasi(instance.Pembantu(pi).Barang, session.GetObjectByKey(Of Persistent.Gudang)(Convert.ToInt32(settingInventory.Gudang1)), pUrutan, 0, instance.Pembantu(pi).Qty, 0)
  '    pUrutan = CByte(pUrutan + 1)
  '    SimpanStockMutasi(instance.Pembantu(pi).Barang, session.GetObjectByKey(Of Persistent.Gudang)(Convert.ToInt32(settingInventory.GudangProduksi)), pUrutan, instance.Pembantu(pi).Qty, 0, 0)
  '  Next

  '  Dim zTotalStockDetail As Integer = ((instance.Detail.Count) + (instance.Pembantu.Count))
  '  If instance.StockProses.Detail.Count - 1 > zTotalStockDetail Then
  '    For zi = instance.StockProses.Detail.Count - 1 To zTotalStockDetail Step -1
  '      instance.StockProses.Detail(zi).Delete()
  '    Next
  '  End If
  'End Sub
  Private Sub SimpanStockMutasi(Barang As NuSoft004.Persistent.SanYu_Barang, xGudang As Persistent.Gudang, Urutan As Byte, qtyin As Double, qtyout As Double, tonase As Double)
    Dim pData As Persistent.SanYu_StokDetail
    If instance.StockProses.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
      pData = instance.StockProses.Detail.Single(Function(m) m.Urutan = Urutan)
      pData.Gudang = xGudang
      pData.Urutan = Urutan
      pData.Barang = Barang
      pData.Satuan = Barang.Satuan
      pData.QtyIn = qtyin
      pData.QtyOut = qtyout
      pData.Tonase = tonase
      pData.TotalHPP = 500000

    Else
      pData = New Persistent.SanYu_StokDetail(session)
      pData.Gudang = xGudang
      pData.Urutan = Urutan
      pData.Barang = Barang
      pData.Satuan = Barang.Satuan
      pData.QtyIn = qtyin
      pData.QtyOut = qtyout
      pData.Tonase = tonase
      pData.TotalHPP = 500000
      instance.StockProses.Detail.Add(pData)
    End If
  End Sub
  Sub simpanProsesProduksi()
    If instance.Pembantu.Count > 0 Then
      MsgBox("Proses pengurangan bahan pembantu")
      If instance.StockProses Is Nothing Then
        instance.StockProses = New Persistent.SanYu_StokMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
      End If
      instance.StockProses.Sumber = instance.Sumber
      instance.StockProses.Regional = instance.Regional
      instance.StockProses.Tanggal = instance.Tanggal
      instance.StockProses.Kode = instance.Kode & "-P"
      instance.StockProses.Pelanggan = instance.OrderPenjualan.Main.Pelanggan
      instance.StockProses.Gudang = session.GetObjectByKey(Of Persistent.Gudang)(Convert.ToInt32(settingInventory.GudangProduksi))
      Dim pData As Persistent.SanYu_StokDetail
      For pi = 0 To instance.Pembantu.Count - 1
        pData = New Persistent.SanYu_StokDetail(session)
        pData.Urutan = CByte(pi + 1)
        pData.Barang = instance.Pembantu(pi).Barang
        pData.Satuan = instance.Pembantu(pi).Satuan
        pData.QtyOut = instance.Pembantu(pi).Qty
        instance.StockProses.Detail.Add(pData)
      Next
      For zi = instance.StockProses.Detail.Count - 1 To instance.Pembantu.Count Step -1
        instance.StockProses.Detail(zi).Delete()
      Next
    End If
  End Sub
  Sub simpanHasilProduksi()
    If instance.StockHasil Is Nothing Then
      instance.StockHasil = New Persistent.SanYu_StokMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
    End If
    If instance.StockHasil.Gl Is Nothing Then
      instance.StockHasil.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
      instance.StockHasil.Gl.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
    End If
    instance.StockHasil.Sumber = instance.Sumber
    instance.StockHasil.Regional = instance.Regional
    instance.StockHasil.Tanggal = instance.Tanggal
    instance.StockHasil.Kode = instance.Kode & "-F"
    instance.StockHasil.Pelanggan = instance.OrderPenjualan.Main.Pelanggan
    instance.StockHasil.Gudang = session.GetObjectByKey(Of Persistent.Gudang)(Convert.ToInt32(settingInventory.GudangProduksi))
    instance.StockHasil.BatchNo = instance.BatchNo
    Dim pUrutan As Byte
    'item jadi
    pUrutan = 1
    SimpanStockProduksi(instance.ItemJadi, pUrutan, instance.RencanaProduksi.Qty, 0, instance.BahanJadiTonase)

    'item bahan baku (kurangi dari gudang produksi)
    Dim xDataProduksi As New XPCollection(Of Persistent.SanYu_ProduksiDetail)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Main.RencanaProduksi.Id", instance.RencanaProduksi.Id, BinaryOperatorType.Equal), New BinaryOperator("xN", True, BinaryOperatorType.Equal)))
    For pI = 0 To xDataProduksi.Count - 1
      pUrutan = CByte(pUrutan + 1)
      SimpanStockProduksi(xDataProduksi(pI).Pembelian.Barang, pUrutan, 0, xDataProduksi(pI).Qty, xDataProduksi(pI).Tonase)
    Next
    'hapus yang diaatas ini
    For zi = instance.StockHasil.Detail.Count - 1 To CInt(pUrutan) Step -1
      instance.StockHasil.Detail(zi).Delete()
    Next


    'simpan GL nya
    'buatkan jurnalnya
    instance.StockHasil.Gl.Sumber = instance.Sumber
    instance.StockHasil.Gl.Kode = instance.Kode
    instance.StockHasil.Gl.Tanggal = instance.Tanggal
    instance.StockHasil.Gl.Regional = instance.Regional
    instance.StockHasil.Gl.Kode = instance.Kode
    instance.StockHasil.Gl.ModuleId = NPO.Modules.ModuleId.Inventory
    '    instance.StockProses.Gl.MataUang = instance.m
    instance.StockHasil.Gl.Kurs = 1
    instance.StockHasil.Gl.Kontak = instance.RencanaProduksi.Main.Pelanggan
    instance.StockHasil.Gl.KontakNama = instance.RencanaProduksi.Main.Pelanggan.Nama
    instance.StockHasil.Gl.Uraian = "Produksi"
    Dim i As Byte = 1
    SimpanGLProduksi(instance.ItemBaku.CoaStock, 1, 0, 1000000)
    SimpanGLProduksi(instance.ItemJadi.CoaStock, 2, 1000000, 0)

  End Sub
  Private Sub SimpanGLProduksi(Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double)
    Dim item As Persistent.GlMainDetail
    If instance.StockHasil.Gl.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
      item = instance.StockHasil.Gl.Detail.Single(Function(m) m.Urutan = Urutan)
      item.Akun = Akun
      item.MataUang = item.Akun.MataUang
      item.Main = instance.StockHasil.Gl
      item.Urutan = Urutan
      item.Debit = Debit
      item.Kredit = Kredit
      item.Kurs = 1
      item.DebitValas = 0
      item.KreditValas = 0
    Else
      item = New Persistent.GlMainDetail(session)
      item.Akun = Akun
      item.MataUang = item.Akun.MataUang
      item.Main = instance.StockHasil.Gl
      item.Urutan = Urutan
      item.Debit = Debit
      item.Kredit = Kredit
      item.Kurs = 1
      item.DebitValas = 0
      item.KreditValas = 0
      instance.StockHasil.Gl.Detail.Add(item)
    End If
  End Sub
  Private Sub SimpanStockProduksi(Barang As NuSoft004.Persistent.SanYu_Barang, Urutan As Byte, qtyin As Double, qtyout As Double, tonase As Double)
    Dim pData As Persistent.SanYu_StokDetail
    If instance.StockHasil.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
      pData = instance.StockHasil.Detail.Single(Function(m) m.Urutan = Urutan)
      pData.Urutan = Urutan
      pData.Barang = Barang
      pData.Satuan = Barang.Satuan
      pData.QtyIn = qtyin
      pData.QtyOut = qtyout
      pData.Tonase = tonase
      pData.TotalHPP = 500000

    Else
      pData = New Persistent.SanYu_StokDetail(session)
      pData.Gudang = session.GetObjectByKey(Of Persistent.Gudang)(Convert.ToInt32(settingInventory.GudangProduksi))
      pData.Urutan = Urutan
      pData.Barang = Barang
      pData.Satuan = Barang.Satuan
      pData.QtyIn = qtyin
      pData.QtyOut = qtyout
      pData.Tonase = tonase
      pData.TotalHPP = 500000
      instance.StockHasil.Detail.Add(pData)
    End If
  End Sub
  Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtBarangJadi.Focus()
      Case -2 : txtNoRencanaProduksi.Focus()
      Case -3 : txtQty.Focus()
      Case Else
    End Select
  End Sub
  Sub LoadDefault()
    If xpSettingRegional Is Nothing Then
      xpSettingRegional = New XPCollection(Of NuSoft001.Persistent.SettingRegional)(session)
    End If
    defaultRegional = UserInfo.GetDefaultRegional(session)
    txtTanggal.EditValue = Now
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
          ChangeCode()
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
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.AM)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub txtNoRencanaProduksi_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtNoRencanaProduksi.EditValueChanging
    txtBarangJadi.EditValue = CType(e.NewValue, Persistent.SanYu_RencanaProduksiDetail).Barang
    txtBahanBaku.EditValue = CType(e.NewValue, Persistent.SanYu_RencanaProduksiDetail).BahanBaku
    txtQty.EditValue = CType(e.NewValue, Persistent.SanYu_RencanaProduksiDetail).Qty
    txtPelanggan.Text = CType(e.NewValue, Persistent.SanYu_RencanaProduksiDetail).Main.OrderPenjualan.Pelanggan.Nama
    txtNoPO.Text = CType(e.NewValue, Persistent.SanYu_RencanaProduksiDetail).Main.OrderPenjualan.NomorPO
    txtQtyPO.Text = CType(e.NewValue, Persistent.SanYu_RencanaProduksiDetail).OrderPenjualan.Qty.ToString("n2") & " " & CType(e.NewValue, Persistent.SanYu_RencanaProduksiDetail).OrderPenjualan.JenisPenjualan

    txtBarangJadi.Text = CType(e.NewValue, Persistent.SanYu_RencanaProduksiDetail).Barang.Nama.ToString
    txtBahanBaku.Text = CType(e.NewValue, Persistent.SanYu_RencanaProduksiDetail).BahanBaku.Nama.ToString

    colBakuNoPembelianRepo.DataSource = New XPCollection(Of Persistent.SanYu_StokDetail)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Barang", CType(e.NewValue, Persistent.SanYu_RencanaProduksiDetail).BahanBaku, BinaryOperatorType.Equal), New BinaryOperator("QtyIn", 0, BinaryOperatorType.Greater)))

    'inputkan proses sebelumnya
    txtNoSebelumnya.Properties.DataSource = New XPCollection(Of Persistent.SanYu_ProduksiMain)(session, New BinaryOperator("RencanaProduksi", CType(e.NewValue, Persistent.SanYu_RencanaProduksiDetail), BinaryOperatorType.Equal))
  End Sub
  Private Sub xGridDetailView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridDetailView.InitNewRow
    Dim row As Persistent.SanYu_ProduksiDetail = CType(xGridDetailView.GetRow(e.RowHandle), Persistent.SanYu_ProduksiDetail)
    row.Main = instance
    row.Pembelian = Nothing
    row.Panjang = 0
    row.Lebar = 0
    row.Tebal = CType(txtNoRencanaProduksi.EditValue, Persistent.SanYu_RencanaProduksiDetail).BahanBaku.Thickness
    row.Qty = 0
    row.xN = True
    'row.Qty2 = CType(txtNoRencanaProduksi.EditValue, Persistent.SanYu_RencanaProduksiDetail).QtyBaku
  End Sub
  Private Sub xGridDetailView_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles xGridDetailView.CellValueChanged
    If Not e.Value Is Nothing Then
      Dim row As Persistent.SanYu_ProduksiDetail = CType(xGridDetailView.GetRow(e.RowHandle), Persistent.SanYu_ProduksiDetail)
      If e.Column Is colKodeBarang Then

      End If
      If e.Column Is colP Then
        row.Qty = (CDbl(e.Value) * row.Lebar * row.Tebal * row.QtyPcs) / 1000000000
      End If
      If e.Column Is colL Then
        row.Qty = (row.Panjang * CDbl(e.Value) * row.Tebal * row.QtyPcs) / 1000000000
      End If
      If e.Column Is colT Then
        row.Qty = (row.Panjang * row.Lebar * CDbl(e.Value) * row.QtyPcs) / 1000000000
      End If
      If e.Column Is colBakuQty2 Then
        row.Qty = (row.Panjang * row.Lebar * row.Tebal * CDbl(e.Value)) / 1000000000
      End If
      If Not e.Column Is colTonase Then
        row.Tonase = row.TonaseP
      End If
    End If
  End Sub
  Private Sub xGridBahanPembantuView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridBahanPembantuView.CellValueChanged
    If Not e.Value Is Nothing Then
      Dim row As Persistent.SanYu_ProduksiPembantu = CType(xGridBahanPembantuView.GetRow(e.RowHandle), Persistent.SanYu_ProduksiPembantu)
      If e.Column Is colKodeBarang Then
        row.Satuan = row.Barang.Satuan
        row.Pembelian = Nothing
      End If
    End If
  End Sub
  Private Sub xGridBahanPembantuView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridBahanPembantuView.InitNewRow
    Dim row As Persistent.SanYu_ProduksiPembantu = CType(xGridBahanPembantuView.GetRow(e.RowHandle), Persistent.SanYu_ProduksiPembantu)
    row.Main = instance
    row.Barang = Nothing
    row.Pembelian = Nothing
    row.Qty = 0
    row.Keterangan = ""
    row.xN = True
  End Sub
  Private Sub colNoPembelianRepo_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles colPembelianRepo.ButtonClick
    Dim row As Persistent.SanYu_ProduksiPembantu = CType(xGridBahanPembantuView.GetRow(xGridBahanPembantuView.FocusedRowHandle), Persistent.SanYu_ProduksiPembantu)
    Dim frm As New UI_SanyuProduksiGR
    frm.session = session
    frm.instance = row
    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
      If frm.GRResult.Count > 0 Then row.Pembelian = frm.GRResult(0)
    End If
  End Sub
  Private Sub txtNoSebelumnya_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtNoSebelumnya.EditValueChanging
    If editAssign = False Then
      Dim xNoSebelum As Persistent.SanYu_ProduksiMain = CType(e.NewValue, Persistent.SanYu_ProduksiMain)
      Dim data As Persistent.SanYu_ProduksiDetail
      For i = 0 To xNoSebelum.Detail.Count - 1
        data = New Persistent.SanYu_ProduksiDetail(session)
        data.Pembelian = xNoSebelum.Detail(i).Pembelian
        data.Ukuran = xNoSebelum.Detail(i).Ukuran
        data.Panjang = xNoSebelum.Detail(i).Panjang
        data.Lebar = xNoSebelum.Detail(i).Lebar
        data.Tebal = xNoSebelum.Detail(i).Tebal
        data.Qty = xNoSebelum.Detail(i).Qty
        data.QtyPcs = xNoSebelum.Detail(i).QtyPcs
        data.xN = False
        instance.Detail.Add(data)
      Next
    End If
  End Sub
  Private Sub txtProses_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtProses.EditValueChanging
    If CType(e.NewValue, Persistent.SanYu_ProsesProduksi).Finish = True Then
      lytgWaste.Enabled = True
    End If
  End Sub
  Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
    HitungWaste()
  End Sub
  Private Sub HitungWaste()
    Dim xBahanBaku As New XPCollection(Of Persistent.SanYu_ProduksiDetail)(session, New GroupOperator(GroupOperator.And, New BinaryOperator("Main.RencanaProduksi.Id", CType(txtNoRencanaProduksi.EditValue, Persistent.SanYu_RencanaProduksiDetail).Id, BinaryOperatorType.Equal), New BinaryOperator("xN", True, BinaryOperatorType.Equal)))

    txtBahanBakuQty.EditValue = xBahanBaku.Sum(Function(x) x.Qty)
    txtBahanJadiQty.EditValue = instance.Detail.Sum(Function(x) x.Qty)
    txtWasteQty.EditValue = CType(txtBahanBakuQty.EditValue, Double) - CType(txtBahanJadiQty.EditValue, Double)

    txtBahanBakuTonase.EditValue = xBahanBaku.Sum(Function(x) x.Tonase)
    txtBahanJadiTonase.EditValue = instance.Detail.Sum(Function(x) x.Tonase)
    txtWasteTonase.EditValue = CType(txtBahanBakuTonase.EditValue, Double) - CType(txtBahanJadiTonase.EditValue, Double)
  End Sub
End Class