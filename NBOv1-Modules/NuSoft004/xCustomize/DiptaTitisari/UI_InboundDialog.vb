Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraLayout.Utils
Imports System.Reflection
Imports NuSoft.Core.SSystem
Friend Class UI_InboundDialog
  Private instance As Persistent.xDiptaStockMain
  Private isShown As Boolean
  Private xpSettingRegional As XPCollection(Of NuSoft001.Persistent.SettingRegional)
  Private editAssign As Boolean = False
  Private detailToDelete As New List(Of Persistent.xDiptaStockDetail)
  Private defaultRegional As NPO.Modules.ModSys.Regional
  Private setting As NuSoft001.Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Sub New()
    InitializeComponent()
    NoDropIdentityMap = True
    Persistent.xDiptaStockMain.AutoSaveOnEndEdit = False
    Persistent.xDiptaStockDetail.AutoSaveOnEndEdit = False
    NPO.Modules.ModSys.Divisi.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    setting = New NuSoft001.Logic.FinaSetting(session)
    BindingDataSource()
    sumber = New Persistent.SumberDataCollection(session)
    Logic.Umum.xLoadLayoutLyt(lytTransaksi, "PSTransaksi.xml")
    Logic.Umum.xLoadLayoutGrid(xGridView, "PSTransaksiGrid")
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.xDiptaStockMain(session)
      instance.Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
      xGrid.DataSource = Nothing
      LoadDefault()
      ChangeCode()
      txtKontak.Focus()
      xGrid.DataSource = instance.Detail
    Else
      editAssign = True
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.xDiptaStockMain)(Convert.ToInt64(IdToEdit))
      txtUraian.Text = instance.Catatan
      txtTipe.EditValue = instance.TipeTransaksi
      txtKontak.EditValue = instance.KaryawanKirim
      txtTanggal.EditValue = instance.Tanggal
      txtRegional.EditValue = instance.Regional
      txtGudang.EditValue = instance.Gudang
      txtNoTransaksi.Text = instance.Kode
      txtStatus.EditValue = instance.StatusTransaksi

      xGrid.DataSource = From p In instance.Detail Select p Where p.Id <> 0
      instance.Detail.CriteriaString = ""
      xGrid.DataSource = instance.Detail
      editAssign = False
    End If
    SetNomor()
  End Sub
  Overrides Sub LoadAfterInitialize()
    SetFormat()
    If Tipe = InputType.Tambah Then
      Me.Text = "Inbound : Tambah"
    Else
      Me.Text = "Inbound : Edit " & instance.Kode
      If Not instance.StatusTransaksi = NuSoft001.Persistent.StatusTransaksiEnum.Pending Then
        DisableControl()
      End If
      If NuSoft001.Persistent.Periode.CheckLockedPeriod(session, instance.Tanggal) Then
        DisableControl()
      End If
      If NuSoft.Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase).Edit = False Then
        DisableControl()
      End If
    End If
  End Sub
  Overrides Sub SimpanData()
    For i = detailToDelete.Count - 1 To 0 Step -1
      detailToDelete(i).Delete()
    Next

    Try
      '======= Simpan Main
      If Not txtKontak.EditValue Is Nothing Then
        instance.KaryawanKirim = CType(txtKontak.EditValue, NuSoft001.Persistent.Kontak)
      Else
        instance.KaryawanKirim = Nothing
      End If
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.Gudang = CType(txtGudang.EditValue, Persistent.Gudang)
      instance.TipeTransaksi = CType(txtTipe.EditValue, Persistent.TipeTransaksi)
      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      instance.Catatan = txtUraian.Text
      instance.StatusTransaksi = CType(txtStatus.EditValue, NuSoft001.Persistent.StatusTransaksiEnum)
      instance.MataUang = session.GetObjectByKey(Of NuSoft001.Persistent.MataUang)(Convert.ToInt32(setting.MultiMataUangDefault))
      instance.Kurs = 1
      instance.Save()

      'buatkan jurnalnya
      instance.Gl.Sumber = instance.Sumber
      instance.Gl.Tanggal = instance.Tanggal
      instance.Gl.Regional = instance.Regional
      instance.Gl.Kode = instance.Kode
      instance.Gl.ModuleId = NPO.Modules.ModuleId.Inventory
      'instance.Gl.MataUang = CType(txtUang.EditValue, NuSoft001.Persistent.MataUang).Simbol
      instance.Gl.Kurs = 1
      instance.Gl.Kontak = instance.KaryawanKirim
      instance.Gl.KontakNama = txtKontak.Text
      instance.Gl.Uraian = txtUraian.Text

      'Pendapatan (K)    
      Dim i As Byte
      SimpanGL(CType(txtTipe.EditValue, Persistent.TipeTransaksi).CoaPendapatan, 1, 0, instance.TotalNilaiIN)
      i = 2
      'Persediaan (C)
      Dim b = From z In instance.Detail Group z By z.Barang.CoaStock Into Group Select CoaStock, NilaiSstock = Group.Sum(Function(x) x.NilaiIN)
      For Each x In b
        SimpanGL(x.CoaStock, i, x.NilaiSstock, 0)
        i = CByte(i + 1)
      Next
      If instance.Gl.Detail.Count > i Then
        For pi = CInt(i) To instance.Gl.Detail.Count - 1 Step -1
          instance.Gl.Detail(i).Delete()
        Next
      End If

      '======= Simpan instance
      session.CommitChanges()
    Catch ex As Utils.Exception
      Throw New Utils.Exception(ex)
    Catch ex As Exception
      If ex.Message.Contains("Duplicate entry") Then
        instance.Kode = instance.Number.GetNewNumber.Kode
        session.CommitChanges()
      Else
        Throw New Exception(ex.Message, ex.InnerException)
      End If
    End Try
    Dim frm As New RF_DataDataTransaksi(Persistent.SumberDataJenis.PS)
    frm.txtNoBukti1.Text = instance.Kode
    Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & instance.Kode & " ?"
    Dim reportCode As String = ""
    reportCode = MainClass.GetReport(MainClass.reportName.VoucherPenyesuaianStock)
    message = String.Format(message, "Penyesuaian Stock")
    Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
  End Sub
  Private Sub SimpanGL(Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double)
    Dim item As Persistent.GlMainDetail
    If instance.Gl.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
      item = instance.Gl.Detail.Single(Function(m) m.Urutan = Urutan)

      item.Akun = Akun
      item.MataUang = item.Akun.MataUang
      item.Main = instance.Gl
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
      item.Main = instance.Gl
      item.Urutan = Urutan
      item.Debit = Debit
      item.Kredit = Kredit
      item.Kurs = 1
      item.DebitValas = 0
      item.KreditValas = 0
      instance.Gl.Detail.Add(item)
    End If
  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtRegional.Focus()
      Case -3 : txtUraian.Focus()
      Case -4 : txtTanggal.Focus()
      Case -5, -7 : xGrid.Focus()
    End Select
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
    txtNoTransaksi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
    txtNoTransaksi.Properties.Mask.EditMask = nomor.Mask
    txtNoTransaksi.Text = nomor.Kode
  End Sub
  Private Sub BindingDataSource()
    txtKontak.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
    txtRegional.Properties.DataSource = UserInfo.GetUserRegional(session, NamaDatabase)
    txtGudang.Properties.DataSource = New XPCollection(Of Persistent.Gudang)(session)
    txtTipe.Properties.DataSource = New XPCollection(Of Persistent.TipeTransaksi)(session)
    colKodeBarangRepo.DataSource = New XPCollection(Of Persistent.Barang)(session)
    colSatuanRepo.DataSource = New XPCollection(Of Persistent.Satuan)(session)
    colDivisiRepo.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(session)
    txtStatus.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft001.Persistent.StatusTransaksiEnum))
    colLokasiRepo.DataSource = New XPCollection(Of Persistent.xDiptaMasterLOkasi)(session)
  End Sub
  Private Sub SetFormat()
    colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQtyIn.DisplayFormat.FormatString = setting.NumericFormatString
    colQtyIn.SummaryItem.DisplayFormat = setting.NumericFormatString
    colHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHarga.DisplayFormat.FormatString = setting.NumericFormatString
  End Sub
  Private Sub LoadDefault()
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
    instance.Tanggal = txtTanggal.DateTime
    instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
    txtStatus.EditValue = NuSoft001.Persistent.StatusTransaksiEnum.Posting
  End Sub
  Private Sub SetNomor()
    instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.PS)
    instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
  End Sub
  Private Sub DisableControl()
    txtKontak.Properties.ReadOnly = True
    txtTanggal.Properties.ReadOnly = True
    txtNoTransaksi.Properties.ReadOnly = True
    txtRegional.Properties.ReadOnly = True
    txtTipe.Properties.ReadOnly = True
    txtGudang.Properties.ReadOnly = True
    txtUraian.Properties.ReadOnly = True
    xGridView.OptionsBehavior.Editable = False
    AllowSave = False
  End Sub
  Private Sub GantiTanggalTahun()
    Dim str As String = "Edit tanggal dengan tahun berbeda akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"

    If Tipe = InputType.Edit AndAlso isShown Then
      If instance.Tanggal.Year <> CDate(txtTanggal.EditValue).Year Then
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
  End Sub
  Private Sub GantiTanggalBulan()
    Dim str As String = "Edit tanggal dengan bulan dan tahun berbeda akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"

    If Tipe = InputType.Edit AndAlso isShown Then
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
  End Sub

  Private Function GetViewInfo(navBar As NavBarControl) As NavBarViewInfo
    Dim fi As FieldInfo = GetType(NavBarControl).GetField("viewInfo", BindingFlags.NonPublic Or BindingFlags.Instance)
    Return CType(fi.GetValue(navBar), NavBarViewInfo)
  End Function
  Private Function GetGroupPainter(navBar As NavBarControl) As ExplorerBarNavGroupPainter
    Dim fi As FieldInfo = GetType(NavBarControl).GetField("groupPainter", BindingFlags.NonPublic Or BindingFlags.Instance)
    Return CType(fi.GetValue(navBar), ExplorerBarNavGroupPainter)
  End Function
  Private Sub navCatatan_CalcGroupClientHeight(sender As Object, e As NavBarCalcGroupClientHeightEventArgs) Handles navCatatan.CalcGroupClientHeight
    Dim vi As NavBarViewInfo = GetViewInfo(NavBarControl1)
    Dim gi As NavGroupInfoArgs = CType(vi.Groups((vi.Groups.Count - 1)), NavGroupInfoArgs)
    Dim groupPainter As ExplorerBarNavGroupPainter = GetGroupPainter(NavBarControl1)
    'groupPainter.CalcFooterBounds(gi, gi.Bounds)
    Dim delta As Integer = gi.Bounds.Top - vi.Client.Top
    Dim ch As Integer = vi.Client.Height - delta - gi.Bounds.Height - gi.FooterBounds.Height
    e.Height = ch
  End Sub

  Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
    If Not e.NewValue Is Nothing Then
      lblKontakNama.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Nama
      'isikan data detailnya
      txtPhoneNumber.Text = CType(e.NewValue, NuSoft001.Persistent.Kontak).Telepon
      txtDebitLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasPiutang)
      txtCreditLimit.Text = CStr(CType(e.NewValue, NuSoft001.Persistent.Kontak).BatasHutang)

      'Dim xpTransaksi As New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("Id", CType(e.NewValue, NuSoft001.Persistent.Kontak).Id, BinaryOperatorType.Equal))
    End If
  End Sub
  Private Sub txtRegional_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtRegional.EditValueChanging
    Dim str As String = "Edit regional transaksi akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"
    Try
      If Tipe = InputType.Edit AndAlso isShown Then
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
      If Tipe = InputType.Edit AndAlso isShown Then
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

  Private Sub xGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles xGridView.CellValueChanged
    If Not e.Value Is Nothing Then
      If e.Column Is colKodeBarang Then
        Dim row As Persistent.xDiptaStockDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.xDiptaStockDetail)
        If Not row Is Nothing Then
          Dim xbarang As Persistent.Barang = CType(e.Value, Persistent.Barang)
          row.Satuan = xbarang.Satuan
        End If
      End If
    End If
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("PSTransaksiGrid.xml"))
  End Sub
  Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
    Dim row As Persistent.xDiptaStockDetail = CType(xGridView.GetRow(e.RowHandle), Persistent.xDiptaStockDetail)
    row.Barang = Nothing
    'row.QtyIn = 0
    row.Main = instance
    row.Catatan = ""
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.xDiptaStockDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.xDiptaStockDetail)
      xGridView.DeleteRow(xGridView.FocusedRowHandle)
      detailToDelete.Add(Id)
    End If
  End Sub

  Private Sub Me_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
    isShown = True
  End Sub
  Protected Overrides Sub OnKeyDown(e As System.Windows.Forms.KeyEventArgs)
    MyBase.OnKeyDown(e)
    If e.Control AndAlso e.Shift Then
      xGrid.Focus()
    End If
  End Sub
  Private Sub btnRefreshNomor_Click(sender As Object, e As EventArgs) Handles btnRefreshNomor.Click
    ChangeCode()
  End Sub
  Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
    BindingDataSource()
  End Sub
End Class