Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem
Friend Class UI_RevaluasiValasDialog
  Private instance As Persistent.RevaluasiValas
  Private mataUangDefault As Integer
  Private isShown As Boolean
  Private detailToDelete As New List(Of Persistent.RevalCoa)
  Private setting As Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Persistent.PengajuanDana.AutoSaveOnEndEdit = False
    Persistent.PengajuanDanaDetail.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("RVTransaksi.xml")) = True Then
      lytRv.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("RVTransaksi.xml"))
    End If
    txtAkun.Properties.DataSource = Logic.Coa.GetCoa(session, True, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.BiayaLainLain, Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.PendapatanLainLain})
    txtKontak.Properties.DataSource = New DevExpress.Xpo.XPCollection(Of Persistent.Kontak)(session)
    txtRegional.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Regional)(session)
    setting = New Logic.FinaSetting(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("RVTransaksiGridDetail.xml")) = True Then
      xGridDetailView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("RVTransaksiGridDetail.xml"))
    End If
  End Sub
  Overrides Sub InitializeData()
    Dim xConfig As New Logic.FinaSetting(session)
    If Tipe = InputType.Tambah Then
      instance = New Persistent.RevaluasiValas(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}

      MyBase.InitializeData()
      xGridCoa.DataSource = Nothing
      xGridUang.DataSource = Nothing

      'isikan untuk uangnya
      Dim xDataUang As New DevExpress.Xpo.XPCollection(Of Persistent.MataUang)(session)
      Dim data As Persistent.RevalUang
      If Not xDataUang Is Nothing Then
        For i = 0 To xDataUang.Count - 1
          If Not xDataUang(i).Id = xConfig.MultiMataUangDefault Then
            data = New Persistent.RevalUang(session)
            data.Uang = xDataUang(i)
            instance.Uang.Add(data)
          End If
        Next
      End If
      'isikan untuk coanya
      Dim xDataCoa As New DevExpress.Xpo.XPCollection(Of Persistent.Coa)(session, New BinaryOperator("MataUang.Id", xConfig.MultiMataUangDefault, BinaryOperatorType.NotEqual))
      Dim datac As Persistent.RevalCoa
      If Not xDataUang Is Nothing Then
        For i = 0 To xDataCoa.Count - 1
          datac = New Persistent.RevalCoa(session)
          datac.Coa = xDataCoa(i)
          instance.Coa.Add(datac)
        Next
      End If

      If Not txtTanggal.EditValue Is Nothing Then
        instance.Tanggal = txtTanggal.DateTime
      Else
        txtTanggal.DateTime = Now
      End If
      Dim defaultRegional As NPO.Modules.ModSys.Regional
      defaultRegional = UserInfo.GetDefaultRegional(session)
      If Not defaultRegional Is Nothing Then
        txtRegional.EditValue = defaultRegional
      Else
        txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
      End If

      instance.Akun = CType(txtAkun.EditValue, Persistent.Coa)
      txtAkun.EditValue = setting.MultiMataUangAkunKurs

      xGridCoa.DataSource = instance.Coa
      xGridUang.DataSource = instance.Uang
      Me.Text = "Revaluasi Valuta Asing: Tambah"
    Else
      xGridCoa.DataSource = Nothing
      xGridUang.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.RevaluasiValas)(Convert.ToInt64(IdToEdit))
      txtKontak.EditValue = instance.Kontak
      txtTanggal.EditValue = instance.Tanggal
      txtRegional.EditValue = instance.Regional
      txtAkun.EditValue = instance.CoaSelisihKurs
      xGridCoa.DataSource = instance.Coa
      xGridUang.DataSource = instance.Uang
      xGridDetail.DataSource = instance.Detail
      EnableVisibleSaveButton(False, False)
      Me.Text = "Revaluasi Valuta Asing: Edit - " & instance.Kode
    End If
  End Sub
  Overrides Sub LoadAfterInitialize()
    Dim setting As New Logic.FinaSetting(session)

    colKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKurs.DisplayFormat.FormatString = setting.NumericFormatToString

    colNilaiValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiValas.DisplayFormat.FormatString = setting.NumericFormatToString
    colNilaiFungsional.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiFungsional.DisplayFormat.FormatString = setting.NumericFormatToString
    colNilaiKurs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiKurs.DisplayFormat.FormatString = setting.NumericFormatToString
    colNilaiSelisih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiSelisih.DisplayFormat.FormatString = setting.NumericFormatToString
  End Sub
  Overrides Sub SimpanData()
    Try
      Dim saldo As Double, saldovalas As Double
      sumber = New Persistent.SumberDataCollection(session)
      instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.RV)
      instance.Tanggal = txtTanggal.DateTime
      instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      instance.Kode = instance.Number.GetNewNumber.Kode
      instance.Akun = CType(txtAkun.EditValue, Persistent.Coa)
      instance.CoaSelisihKurs = CType(txtAkun.EditValue, Persistent.Coa)
      instance.Kontak = CType(txtKontak.EditValue, Persistent.Kontak)
      'buatkan detail nya 
      Dim xTanggal As Date, data As Persistent.RevalDetail
      xTanggal = txtTanggal.DateTime.AddDays(1)
      For pI = 0 To instance.Coa.Count - 1
        'jika piutang dan hutang, maka diseting sebagai per kontak
        saldo = 0 : saldovalas = 0
        If instance.Coa(pI).Coa.Tipe.Id = Persistent.CoaEnum.eKind.Piutang Or instance.Coa(pI).Coa.Tipe.Id = Persistent.CoaEnum.eKind.HutangJangkaPanjang Or instance.Coa(pI).Coa.Tipe.Id = Persistent.CoaEnum.eKind.HutangJangkaPendek Or instance.Coa(pI).Coa.Tipe.Id = Persistent.CoaEnum.eKind.HutangLancarLainnya Then
          'carikan saldo perkontaknya
          Dim xData As New XPCollection(Of Persistent.GlMainDetail)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Main.Tanggal", xTanggal, BinaryOperatorType.Less), New BinaryOperator("Akun.Id", instance.Coa(pI).Coa.Id, BinaryOperatorType.Equal)))
          If instance.Coa(pI).Coa.Tipe.Dc = Persistent.CoaEnum.eDc.Debit Then
            Dim c = From z In xData Group z By z.Main.Kontak Into Group Select Kontak, xSaldo = Group.Sum(Function(x) (x.Debit - x.Kredit)), xSaldoValas = Group.Sum(Function(x) (x.DebitValas - x.KreditValas)) Where xSaldo > 0 Or xSaldoValas > 0
            For pJ = 0 To c.Count - 1
              If c(pJ).xSaldo > 0 Or c(pJ).xSaldoValas > 0 Then
                data = New Persistent.RevalDetail(session)
                data.Main = instance
                data.Coa = instance.Coa(pI).Coa
                data.NilaiKurs = getKurs(instance.Coa(pI).Coa.MataUang.Id)
                data.NilaiValas = c(pJ).xSaldoValas
                data.NilaiFungsional = c(pJ).xSaldo
                data.Kontak = c(pJ).Kontak
                instance.Detail.Add(data)
              End If
            Next
          Else
            Dim d = From z In xData Group z By z.Main.Kontak Into Group Select Kontak, xSaldo = Group.Sum(Function(x) (x.Debit - x.Kredit)), xSaldoValas = Group.Sum(Function(x) (x.DebitValas - x.KreditValas)) Where xSaldo > 0 Or xSaldoValas > 0
            For pJ = 0 To d.Count - 1
              If d(pJ).xSaldoValas > 0 Or d(pJ).xSaldo > 0 Then
                data = New Persistent.RevalDetail(session)
                data.Main = instance
                data.Coa = instance.Coa(pI).Coa
                data.NilaiKurs = getKurs(instance.Coa(pI).Coa.MataUang.Id)
                data.NilaiValas = d(pJ).xSaldoValas
                data.NilaiFungsional = d(pJ).xSaldo
                data.Kontak = d(pJ).Kontak
                instance.Detail.Add(data)
              End If
            Next
          End If
        Else
          saldo = CDbl(session.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceSPName, instance.Coa(pI).Coa.Id, xTanggal.ToString("yyyy-MM-dd"))))
          saldovalas = CDbl(session.ExecuteScalar(String.Format(Logic.GL.GetBeginningBalanceValas, instance.Coa(pI).Coa.Id, xTanggal.ToString("yyyy-MM-dd"))))
          If saldo > 0 Or saldovalas > 0 Then
            data = New Persistent.RevalDetail(session)
            data.Main = instance
            data.Coa = instance.Coa(pI).Coa
            data.NilaiKurs = getKurs(instance.Coa(pI).Coa.MataUang.Id)
            data.NilaiValas = saldovalas
            data.NilaiFungsional = saldo
            data.Kontak = CType(txtKontak.EditValue, Persistent.Kontak)
            instance.Detail.Add(data)
          End If
        End If
      Next
      'buatkan jurnal nya
      Dim i As Byte = 1
      For pI = 0 To instance.Detail.Count - 1
        instance.Detail(pI).Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
        instance.Detail(pI).Gl.Sumber = instance.Sumber
        instance.Detail(pI).Gl.Regional = instance.Regional
        instance.Detail(pI).Gl.Tanggal = instance.Tanggal
        instance.Detail(pI).Gl.Kontak = instance.Detail(pI).Kontak
        instance.Detail(pI).Gl.Uraian = "Revaluasi Valuta Asing"


        If instance.Detail(pI).Coa.Tipe.Dc = Persistent.CoaEnum.eDc.Debit Then
          'jika minus maka rugi, jika plus maka untung
          If instance.Detail(pI).NilaiSelisih < 0 Then
            SimpanGL(pI, instance.Detail(pI).Coa, i, 0, Math.Abs(instance.Detail(pI).NilaiSelisih)) : i = CByte(i + 1) 'coa bersangkutan
            SimpanGL(pI, CType(txtAkun.EditValue, Persistent.Coa), i, Math.Abs(instance.Detail(pI).NilaiSelisih), 0) : i = CByte(i + 1) 'laba selisih kurs
          Else
            SimpanGL(pI, instance.Detail(pI).Coa, i, instance.Detail(pI).NilaiSelisih, 0) : i = CByte(i + 1) 'coa bersangkutan
            SimpanGL(pI, CType(txtAkun.EditValue, Persistent.Coa), i, 0, instance.Detail(pI).NilaiSelisih) : i = CByte(i + 1) 'laba selisih kurs
          End If
        Else
          If instance.Detail(pI).NilaiSelisih < 0 Then
            SimpanGL(pI, instance.Detail(pI).Coa, i, Math.Abs(instance.Detail(pI).NilaiSelisih), 0) : i = CByte(i + 1) 'coa bersangkutan
            SimpanGL(pI, CType(txtAkun.EditValue, Persistent.Coa), i, 0, Math.Abs(instance.Detail(pI).NilaiSelisih)) : i = CByte(i + 1) 'laba selisih kurs
          Else
            SimpanGL(pI, instance.Detail(pI).Coa, i, 0, instance.Detail(pI).NilaiSelisih) : i = CByte(i + 1) 'coa bersangkutan
            SimpanGL(pI, CType(txtAkun.EditValue, Persistent.Coa), i, instance.Detail(pI).NilaiSelisih, 0) : i = CByte(i + 1) 'laba selisih kurs
          End If
        End If
        '======= Simpan instance
        session.CommitChanges()
      Next
      Throw New Utils.Exception("Sukses. Transaksi telah tersimpan", 0, "", "Simpan Transaksi")
      Me.Close()
    Catch ex As Utils.Exception
      Throw New Utils.Exception(ex)
    Catch ex As Exception
      Throw New Exception(ex.Message, ex.InnerException)
    End Try
  End Sub
  Private Sub SimpanGL(UrutanDetail As Integer, Akun As NuSoft001.Persistent.Coa, Urutan As Byte, Debit As Double, Kredit As Double)
    Dim item As Persistent.GlMainDetail
    item = New Persistent.GlMainDetail(session)

    item.Akun = Akun
    item.MataUang = item.Akun.MataUang
    item.Main = instance.Detail(UrutanDetail).Gl
    item.Urutan = Urutan
    item.Debit = Debit
    item.Kredit = Kredit
    item.Kurs = 1
    item.DebitValas = 0
    item.KreditValas = 0
    instance.Detail(UrutanDetail).Gl.Detail.Add(item)
  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
  End Sub
  Private Sub Me_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    isShown = True
  End Sub
  Private Sub xGridCoa_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridCoa.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.RevalCoa = CType(xGridCoaView.GetRow(xGridCoaView.FocusedRowHandle), Persistent.RevalCoa)
      xGridCoaView.DeleteRow(xGridCoaView.FocusedRowHandle)
      detailToDelete.Add(Id)
    End If
  End Sub
  Private Function getKurs(ByVal xID As Integer) As Double
    If instance.Uang.ToList.Exists(Function(m) m.Uang.Id = xID) Then
      getKurs = instance.Uang.Single(Function(m) m.Uang.Id = xID).Kurs
    Else
      getKurs = 1
    End If
  End Function
  Private Sub xGridDetailView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridDetailView.ColumnWidthChanged
    xGridDetailView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("RVTransaksiGridDetail.xml"))
  End Sub
End Class