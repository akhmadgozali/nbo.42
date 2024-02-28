Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports NuSoft.Utils.CustomAttribute

Friend Class RF_CashFlowMesitech
  Private _jenis As MainClass.reportName
  Private Enum eLevel
    <EnumDescription("Level 1")> Level1
    <EnumDescription("Level 2")> Level2
    <EnumDescription("Level 3")> Level3
    <EnumDescription("Level 4")> Level4
  End Enum
  Sub New(jenis As MainClass.reportName)
    ' This call is required by the designer.
    InitializeComponent()
    _jenis = jenis
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeData()
    txtPeriodeAwal.DateTime = New Date(Now.Year, Now.Month, 1)
    Dim xAkhirBulan As New Date(Now.Year, Now.Month, 1)
    txtPeriodeAkhir.DateTime = xAkhirBulan.AddMonths(1).AddDays(-(xAkhirBulan.AddMonths(1).Day))

    txtProyek.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)
    txtSubProyek.Properties.DataSource = New XPCollection(Of Persistent.ProyekSub)(_sesi)
    txtDivisi.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(_sesi)

    txtLevel.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(eLevel))
    txtLevel.EditValue = eLevel.Level4

    If _jenis = MainClass.reportName.zCashFlowTahunan Then
      txtPeriodeAwal.DateTime = New Date(Now.Year, 1, 1)
      txtPeriodeAkhir.DateTime = New Date(Now.Year, 12, 31)
    End If
    If _jenis = MainClass.reportName.zCashFlowDetail Then
      txtLevel.Properties.ReadOnly = True
      chkSaldoNol.Properties.ReadOnly = True
    End If
  End Sub
  Overrides Sub Filter()
    Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
    ' Dim a As Modules.nusoftModSys.
    Dim m02Setting As New Logic.FinaSetting(_sesi)
    If Not txtDivisi.EditValue Is Nothing Then
      If Not txtProyek.EditValue Is Nothing Then
        Throw New Utils.Exception("Silahkan pilih salah satu data. Proyek atau Divisi.", 0, "", "Laporan")
        Exit Sub
      End If
    End If

    AddParameter("NamaPerusahaan", abcSetting.NamaPerusahaan, GetType(System.String))

    AddParameter("FormatAngka", m02Setting.FormatAngka, GetType(System.String))
    AddParameter("FormatNumeric", m02Setting.NumericFormatString, GetType(System.String))
    AddParameter("NamaPerusahaanX", abcSetting.NamaPerusahaan, GetType(String))
    AddParameter("Alamat1", abcSetting.Alamat1, GetType(String))
    AddParameter("Alamat2", abcSetting.Alamat2, GetType(String))
    AddParameter("BidangUsaha", abcSetting.BidangUsaha, GetType(String))
    AddParameter("NoFax", abcSetting.NoFax, GetType(String))
    AddParameter("NoTelp", abcSetting.NoTelp, GetType(String))

    AddParameter("Periode", "Periode : " & txtPeriodeAwal.DateTime.ToString("dd-MMM-yyyy") & " s/d " & txtPeriodeAkhir.DateTime.ToString("dd-MMM-yyyy"), GetType(String))
    AddParameter("LevelReport", txtLevel.EditValue, GetType(System.String))
    If Not txtProyek.EditValue Is Nothing Then
      AddParameter("xAPP", "0", GetType(String))
      If Not txtSubProyek.EditValue Is Nothing Then
        AddParameter("Proyek", CType(txtProyek.EditValue, Proyek).Kode, GetType(String))
        AddParameter("SubProyek", CType(txtSubProyek.EditValue, ProyekSub).Kode, GetType(String))
        AddParameter("Divisi", "", GetType(String))
      Else
        AddParameter("Proyek", CType(txtProyek.EditValue, Proyek).Kode, GetType(String))
        AddParameter("SubProyek", "", GetType(String))
        AddParameter("Divisi", "", GetType(String))
      End If
    Else
      If Not txtDivisi.EditValue Is Nothing Then
        AddParameter("xAPP", "0", GetType(String))
        AddParameter("Proyek", "", GetType(String))
        AddParameter("SubProyek", "", GetType(String))
        AddParameter("Divisi", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Kode, GetType(String))
      Else
        AddParameter("xAPP", "1", GetType(String))
        AddParameter("Proyek", "", GetType(String))
        AddParameter("SubProyek", "", GetType(String))
        AddParameter("Divisi", "", GetType(String))
      End If
    End If

    Select Case _jenis
      Case MainClass.reportName.zCashFlowSummary
        LaporanCashFlowDetails()
        Return
      Case MainClass.reportName.zCashFlowDetail
        LaporanCashFlowDetails()
        Return
      Case MainClass.reportName.zCashFlowTahunan
        LaporanCashFlowTahunan()
        Return
      Case Else
        Return
    End Select
  End Sub
  Private Sub DeleteCombo_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs)
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      CType(sender, DevExpress.XtraEditors.LookUpEdit).EditValue = Nothing
    End If
  End Sub

  Private Sub LaporanCashFlowDetails()
    Dim details As New XPCollection(Of xMesitechCashFlowD)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal), New BinaryOperator("Id", 0, BinaryOperatorType.Equal)))

    Using splashManager As New DevExpress.XtraSplashScreen.SplashScreenManager(Nothing, GetType(Core.Win.Forms.WaitForm), True, True)
      splashManager.ShowWaitForm()
      splashManager.SetWaitFormCaption("Silahkan Tunggu")
      splashManager.SetWaitFormDescription("Proses Hitung Saldo ...")


      'insertkan untuk data IN nya
      Dim xCF As New XPCollection(Of xMesitechCashFlowG)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal), New BinaryOperator("Asign", "+", BinaryOperatorType.Equal)))
      Dim xCoa As New List(Of Persistent.Coa)
      Dim SaldoAppIn As Double = 0, SaldoAppOut As Double = 0

      For pi = 0 To xCF.Count - 1
        'Dim xdtSetting As New XPCollection(Of CustomReportDetail)(_sesi, New BinaryOperator("Main.Id", xCF(pi).Id, BinaryOperatorType.Equal))
        Dim xdtSetting As New XPCollection(Of Coa)(_sesi, New BinaryOperator("ReportCashFlowIN.Id", xCF(pi).Id, BinaryOperatorType.Equal))

        xCoa.Clear()
        If xdtSetting.Count > 0 Then
          For pj = 0 To xdtSetting.Count - 1
            xCoa.Add(xdtSetting(pj))
          Next

          Dim xDtTransaksi As New XPCollection(Of xMesitechViewCashFlow)(_sesi, CreateCriteria(xCoa.ToList, xCF(pi).Asign))
          For pj = 0 To xDtTransaksi.Count - 1
            Dim Item As New xMesitechCashFlowD(_sesi)
            Item.Id = 0
            Item.Tipe = xCF(pi).Tipe
            Item.Urutan = xCF(pi).Urutan
            Item.Nama = xCF(pi).Nama
            Item.Asign = xCF(pi).Asign

            Item.COA = xDtTransaksi(pj).coalawan
            Item.Debit = xDtTransaksi(pj).debit
            Item.Kredit = xDtTransaksi(pj).credit
            Item.NoTransaksi = xDtTransaksi(pj).NoTransaksi
            Item.Tanggal = xDtTransaksi(pj).Tanggal
            Item.Uraian = xDtTransaksi(pj).Uraian

            Item.Level = xDtTransaksi(pj).coalawan.Level
            Item.Level1 = xDtTransaksi(pj).coalawan.Level1
            Item.Level2 = xDtTransaksi(pj).coalawan.Level2
            Item.Level3 = xDtTransaksi(pj).coalawan.Level3
            Item.Level4 = xDtTransaksi(pj).coalawan.Level4

            If Not xDtTransaksi(pj).Id.Divisi Is Nothing Then Item.Divisi = xDtTransaksi(pj).Id.Divisi.Kode
            If Not xDtTransaksi(pj).Id.Proyek Is Nothing Then Item.Project = xDtTransaksi(pj).Id.Proyek.Kode
            If Not xDtTransaksi(pj).Id.ProyekSub Is Nothing Then Item.ProjectSub = xDtTransaksi(pj).Id.ProyekSub.Kode
            Item.Keterangan = "CF IN"

            details.Add(Item)
          Next


          'tambahkan data kosong nya
          If chkSaldoNol.Checked = True Then
            If xDtTransaksi.Count = 0 Then
              If xCoa.Count > 0 Then
                Dim Item As New xMesitechCashFlowD(_sesi)
                Item.Id = 0
                Item.Tipe = xCF(pi).Tipe
                Item.Urutan = xCF(pi).Urutan
                Item.Nama = xCF(pi).Nama
                Item.Asign = xCF(pi).Asign
                Item.COA = xCoa.Item(0)

                Item.Level = xCoa.Item(0).Level
                Item.Level1 = xCoa.Item(0).Level1
                Item.Level2 = xCoa.Item(0).Level2
                Item.Level3 = xCoa.Item(0).Level3
                Item.Level4 = xCoa.Item(0).Level4

                Item.Debit = 0
                Item.Kredit = 0
                Item.NoTransaksi = "Kosong"
                Item.Tanggal = txtPeriodeAwal.DateTime
                Item.Keterangan = "Saldo Kosong"
                details.Add(Item)
              End If
            End If
          End If

        End If
      Next
      '=====================SALDO OUT=======================================
      'insert saldo out 1
      Dim xCF2 As New XPCollection(Of xMesitechCashFlowG)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal), New BinaryOperator("Asign", "-", BinaryOperatorType.Equal)))
      Dim xCoa2 As New List(Of Persistent.Coa)

      For pi = 0 To xCF2.Count - 1
        Dim xdtSetting2 As New XPCollection(Of Coa)(_sesi, New BinaryOperator("ReportCashFlowOut.Id", xCF2(pi).Id, BinaryOperatorType.Equal))
        If xdtSetting2.Count > 0 Then
          xCoa2.Clear()
          For pj = 0 To xdtSetting2.Count - 1
            xCoa2.Add(xdtSetting2(pj))
          Next

          Dim xDtTransaksi As New XPCollection(Of xMesitechViewCashFlow)(_sesi, CreateCriteria2(xCoa2.ToList))
          For pj = 0 To xDtTransaksi.Count - 1
            Dim Item As New xMesitechCashFlowD(_sesi)
            Item.Id = 0
            Item.Tipe = xCF2(pi).Tipe
            Item.Urutan = xCF2(pi).Urutan
            Item.Nama = xCF2(pi).Nama
            Item.Asign = xCF2(pi).Asign

            Item.COA = xDtTransaksi(pj).coalawan
            Item.Debit = xDtTransaksi(pj).debit
            Item.Kredit = xDtTransaksi(pj).credit
            Item.NoTransaksi = xDtTransaksi(pj).NoTransaksi
            Item.Tanggal = xDtTransaksi(pj).Tanggal
            Item.Uraian = xDtTransaksi(pj).Uraian

            Item.Level = xDtTransaksi(pj).coalawan.Level
            Item.Level1 = xDtTransaksi(pj).coalawan.Level1
            Item.Level2 = xDtTransaksi(pj).coalawan.Level2
            Item.Level3 = xDtTransaksi(pj).coalawan.Level3
            Item.Level4 = xDtTransaksi(pj).coalawan.Level4

            If Not xDtTransaksi(pj).Id.Divisi Is Nothing Then Item.Divisi = xDtTransaksi(pj).Id.Divisi.Kode
            If Not xDtTransaksi(pj).Id.Proyek Is Nothing Then Item.Project = xDtTransaksi(pj).Id.Proyek.Kode
            If Not xDtTransaksi(pj).Id.ProyekSub Is Nothing Then Item.ProjectSub = xDtTransaksi(pj).Id.ProyekSub.Kode

            Item.Keterangan = "CF Out 1"
            details.Add(Item)
          Next

          'tambahkan data kosong nya
          If chkSaldoNol.Checked = True Then
            If xDtTransaksi.Count = 0 Then
              If xCoa.Count > 0 Then
                Dim Item As New xMesitechCashFlowD(_sesi)
                Item.Id = 0
                Item.Tipe = xCF2(pi).Tipe
                Item.Urutan = xCF2(pi).Urutan
                Item.Nama = xCF2(pi).Nama
                Item.Asign = xCF2(pi).Asign
                Item.COA = xCoa2.Item(0)
                Item.Level = xCoa2.Item(0).Level
                Item.Level1 = xCoa2.Item(0).Level1
                Item.Level2 = xCoa2.Item(0).Level2
                Item.Level3 = xCoa2.Item(0).Level3
                Item.Level4 = xCoa2.Item(0).Level4
                Item.Debit = 0
                Item.Kredit = 0
                Item.NoTransaksi = "Kosong"
                Item.Tanggal = txtPeriodeAwal.DateTime
                Item.Keterangan = "Saldo Kosong"
                details.Add(Item)
              End If
            End If
          End If
        End If
      Next
      'insert saldo out 2
      Dim xdtMain As New List(Of Persistent.xMesitechGLMain)
      For pi = 0 To xCF2.Count - 1
        'Dim xdtSetting As New XPCollection(Of CustomReportDetail)(_sesi, New BinaryOperator("Main.Id", xCF2(pi).Id, BinaryOperatorType.Equal))
        Dim xdtSetting As New XPCollection(Of Coa)(_sesi, New BinaryOperator("ReportCashFlowOut.Id", xCF2(pi).Id, BinaryOperatorType.Equal))
        If xdtSetting.Count > 0 Then
          xCoa2.Clear()
          For pj = 0 To xdtSetting.Count - 1
            xCoa2.Add(xdtSetting(pj))
          Next

          Dim xDataCashFlow As New XPCollection(Of xMesitechViewCashFlow)(_sesi, CreateCriteria3())
          xdtMain.Clear()
          For pj = 0 To xDataCashFlow.Count - 1
            xdtMain.Add(xDataCashFlow(pj).main)
          Next
          Dim xDtTransaksi As New XPCollection(Of xMesitechGlDetail)(_sesi, CreateCriteriaDetail(xCoa2.ToList, xdtMain))
          For pj = 0 To xDtTransaksi.Count - 1
            Dim Item As New xMesitechCashFlowD(_sesi)
            Item.Id = 0
            Item.Tipe = xCF2(pi).Tipe
            Item.Urutan = xCF2(pi).Urutan
            Item.Nama = xCF2(pi).Nama
            Item.Asign = xCF2(pi).Asign

            Item.COA = xDtTransaksi(pj).Akun
            Item.Debit = xDtTransaksi(pj).Debit
            Item.Kredit = xDtTransaksi(pj).Kredit
            Item.NoTransaksi = xDtTransaksi(pj).Main.Kode
            Item.Tanggal = xDtTransaksi(pj).Main.Tanggal
            Item.Uraian = xDtTransaksi(pj).Keterangan

            Item.Level = xDtTransaksi(pj).Akun.Level
            Item.Level1 = xDtTransaksi(pj).Akun.Level1
            Item.Level2 = xDtTransaksi(pj).Akun.Level2
            Item.Level3 = xDtTransaksi(pj).Akun.Level3
            Item.Level4 = xDtTransaksi(pj).Akun.Level4

            If Not xDtTransaksi(pj).Divisi Is Nothing Then Item.Divisi = xDtTransaksi(pj).Divisi.Kode
            If Not xDtTransaksi(pj).Proyek Is Nothing Then Item.Project = xDtTransaksi(pj).Proyek.Kode
            If Not xDtTransaksi(pj).ProyekSub Is Nothing Then Item.ProjectSub = xDtTransaksi(pj).ProyekSub.Kode

            Item.Keterangan = "CF Out 2"

            details.Add(Item)
          Next
        End If
      Next
      splashManager.CloseWaitForm()
    End Using
    _dataSource = details
  End Sub
  Private Function CreateCriteria(xcoa As List(Of Coa), xAsign As String) As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))
    If Not xcoa Is Nothing Then
      result.Add(New InOperator("coalawan", xcoa))
    End If
    If xAsign = "+" Then
      result.Add(New BinaryOperator("debit", 0, BinaryOperatorType.Greater))
    ElseIf xAsign = "-" Then
      result.Add(New BinaryOperator("credit", 0, BinaryOperatorType.Greater))
    End If
    If Not txtProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.Proyek.Id", CType(txtProyek.EditValue, Persistent.Proyek).Id, BinaryOperatorType.Equal))
    End If
    If Not txtSubProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.ProyekSub.Id", CType(txtSubProyek.EditValue, Persistent.ProyekSub).Id, BinaryOperatorType.Equal))
    End If
    If Not txtDivisi.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.Divisi.Id", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Id, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function

  Private Function CreateCriteria2(xcoa As List(Of Coa)) As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))
    result.Add(New BinaryOperator("type", "-", BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("JmlKredit2", 0, BinaryOperatorType.Greater))

    If Not xcoa Is Nothing Then
      result.Add(New InOperator("coalawan", xcoa))
    End If

    If Not txtProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.Proyek.Id", CType(txtProyek.EditValue, Persistent.Proyek).Id, BinaryOperatorType.Equal))
    End If
    If Not txtSubProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.ProyekSub.Id", CType(txtSubProyek.EditValue, Persistent.ProyekSub).Id, BinaryOperatorType.Equal))
    End If
    If Not txtDivisi.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.Divisi.Id", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Id, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Function CreateCriteria3() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BetweenOperator("Tanggal", txtPeriodeAwal.DateTime, txtPeriodeAkhir.DateTime))
    result.Add(New BinaryOperator("type", "-", BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("JmlKredit2", 0, BinaryOperatorType.Equal))

    If Not txtProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.Proyek.Id", CType(txtProyek.EditValue, Persistent.Proyek).Id, BinaryOperatorType.Equal))
    End If
    If Not txtSubProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.ProyekSub.Id", CType(txtSubProyek.EditValue, Persistent.ProyekSub).Id, BinaryOperatorType.Equal))
    End If
    If Not txtDivisi.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Id.Divisi.Id", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Id, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Function CreateCriteriaDetail(xcoa As List(Of Coa), xdtMain As List(Of xMesitechGLMain)) As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"
    result.Add(New BinaryOperator("Debit", 0, BinaryOperatorType.Greater))
    If Not xcoa Is Nothing Then
      result.Add(New InOperator("Akun", xcoa))
    End If
    If Not xdtMain Is Nothing Then
      result.Add(New InOperator("Main", xdtMain))
    End If
    If Not txtProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Proyek.Id", CType(txtProyek.EditValue, Persistent.Proyek).Id, BinaryOperatorType.Equal))
    End If
    If Not txtSubProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("ProyekSub.Id", CType(txtSubProyek.EditValue, Persistent.ProyekSub).Id, BinaryOperatorType.Equal))
    End If
    If Not txtDivisi.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Divisi.Id", CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi).Id, BinaryOperatorType.Equal))
    End If
    Return GroupOperator.And(result)
  End Function


  Private Sub LaporanCashFlowTahunan()
    Dim details As New XPCollection(Of xMesitechCashFlowD)(_sesi, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal))

    Dim xDataCF As New XPCollection(Of xMesitechCashFlowD)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal), New BinaryOperator("Id", 0, BinaryOperatorType.Equal)))
    Using splashManager As New DevExpress.XtraSplashScreen.SplashScreenManager(Nothing, GetType(Core.Win.Forms.WaitForm), True, True)
      splashManager.ShowWaitForm()
      splashManager.SetWaitFormCaption("Silahkan Tunggu")
      splashManager.SetWaitFormDescription("Proses Hitung Saldo ...")


      'insertkan untuk data IN nya
      Dim xCF As New XPCollection(Of xMesitechCashFlowG)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal), New BinaryOperator("Asign", "+", BinaryOperatorType.Equal)))
      Dim xCoa As New List(Of Persistent.Coa)
      Dim SaldoAppIn As Double = 0, SaldoAppOut As Double = 0

      For pi = 0 To xCF.Count - 1
        'Dim xdtSetting As New XPCollection(Of CustomReportDetail)(_sesi, New BinaryOperator("Main.Id", xCF(pi).Id, BinaryOperatorType.Equal))
        Dim xdtSetting As New XPCollection(Of Coa)(_sesi, New BinaryOperator("ReportCashFlowIN.Id", xCF(pi).Id, BinaryOperatorType.Equal))
        xCoa.Clear()
        For pj = 0 To xdtSetting.Count - 1
          xCoa.Add(xdtSetting(pj))
        Next

        Dim xDtTransaksi As New XPCollection(Of xMesitechViewCashFlow)(_sesi, CreateCriteria(xCoa.ToList, xCF(pi).Asign))
        For pj = 0 To xDtTransaksi.Count - 1
          Dim Item As New xMesitechCashFlowD(_sesi)
          Item.Id = 0
          Item.Tipe = xCF(pi).Tipe
          Item.Urutan = xCF(pi).Urutan
          Item.Nama = xCF(pi).Nama
          Item.Asign = xCF(pi).Asign

          Item.COA = xDtTransaksi(pj).coalawan
          Item.Debit = xDtTransaksi(pj).debit
          Item.Kredit = xDtTransaksi(pj).credit
          Item.NoTransaksi = xDtTransaksi(pj).NoTransaksi
          Item.Tanggal = xDtTransaksi(pj).Tanggal

          Item.Level = xDtTransaksi(pj).coalawan.Level
          Item.Level1 = xDtTransaksi(pj).coalawan.Level1
          Item.Level2 = xDtTransaksi(pj).coalawan.Level2
          Item.Level3 = xDtTransaksi(pj).coalawan.Level3
          Item.Level4 = xDtTransaksi(pj).coalawan.Level4

          If Not xDtTransaksi(pj).Id.Divisi Is Nothing Then Item.Divisi = xDtTransaksi(pj).Id.Divisi.Kode
          If Not xDtTransaksi(pj).Id.Proyek Is Nothing Then Item.Project = xDtTransaksi(pj).Id.Proyek.Kode
          If Not xDtTransaksi(pj).Id.ProyekSub Is Nothing Then Item.ProjectSub = xDtTransaksi(pj).Id.ProyekSub.Kode
          Item.Keterangan = "Penerimaan"

          xDataCF.Add(Item)
        Next
      Next

      '=====================SALDO OUT=======================================
      'insert saldo out 1
      Dim xCF2 As New XPCollection(Of xMesitechCashFlowG)(_sesi, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal), New BinaryOperator("Asign", "-", BinaryOperatorType.Equal)))
      Dim xCoa2 As New List(Of Persistent.Coa)

      For pi = 0 To xCF2.Count - 1
        'Dim xdtSetting2 As New XPCollection(Of CustomReportDetail)(_sesi, New BinaryOperator("Main.Id", xCF2(pi).Id, BinaryOperatorType.Equal))
        Dim xdtSetting2 As New XPCollection(Of Coa)(_sesi, New BinaryOperator("ReportCashFlowOut.Id", xCF2(pi).Id, BinaryOperatorType.Equal))
        xCoa2.Clear()
        For pj = 0 To xdtSetting2.Count - 1
          xCoa2.Add(xdtSetting2(pj))
        Next

        Dim xDtTransaksi As New XPCollection(Of xMesitechViewCashFlow)(_sesi, CreateCriteria2(xCoa2.ToList))
        For pj = 0 To xDtTransaksi.Count - 1
          Dim Item As New xMesitechCashFlowD(_sesi)
          Item.Id = 0
          Item.Tipe = xCF2(pi).Tipe
          Item.Urutan = xCF2(pi).Urutan
          Item.Nama = xCF2(pi).Nama
          Item.Asign = xCF2(pi).Asign

          Item.COA = xDtTransaksi(pj).coalawan
          Item.Debit = xDtTransaksi(pj).debit
          Item.Kredit = xDtTransaksi(pj).credit
          Item.NoTransaksi = xDtTransaksi(pj).NoTransaksi
          Item.Tanggal = xDtTransaksi(pj).Tanggal

          Item.Level = xDtTransaksi(pj).coalawan.Level
          Item.Level1 = xDtTransaksi(pj).coalawan.Level1
          Item.Level2 = xDtTransaksi(pj).coalawan.Level2
          Item.Level3 = xDtTransaksi(pj).coalawan.Level3
          Item.Level4 = xDtTransaksi(pj).coalawan.Level4

          If Not xDtTransaksi(pj).Id.Divisi Is Nothing Then Item.Divisi = xDtTransaksi(pj).Id.Divisi.Kode
          If Not xDtTransaksi(pj).Id.Proyek Is Nothing Then Item.Project = xDtTransaksi(pj).Id.Proyek.Kode
          If Not xDtTransaksi(pj).Id.ProyekSub Is Nothing Then Item.ProjectSub = xDtTransaksi(pj).Id.ProyekSub.Kode

          Item.Keterangan = "Pengeluaran tipe 1"
          xDataCF.Add(Item)
        Next

      Next
      'insert saldo out 2
      Dim xdtMain As New List(Of Persistent.xMesitechGLMain)
      For pi = 0 To xCF2.Count - 1
        'Dim xdtSetting As New XPCollection(Of CustomReportDetail)(_sesi, New BinaryOperator("Main.Id", xCF2(pi).Id, BinaryOperatorType.Equal))
        Dim xdtSetting As New XPCollection(Of Coa)(_sesi, New BinaryOperator("ReportCashFlowOut.Id", xCF2(pi).Id, BinaryOperatorType.Equal))
        xCoa2.Clear()
        For pj = 0 To xdtSetting.Count - 1
          xCoa2.Add(xdtSetting(pj))
        Next

        Dim xDataCashFlow As New XPCollection(Of xMesitechViewCashFlow)(_sesi, CreateCriteria3())
        xdtMain.Clear()
        For pj = 0 To xDataCashFlow.Count - 1
          xdtMain.Add(xDataCashFlow(pj).main)
        Next
        Dim xDtTransaksi As New XPCollection(Of xMesitechGlDetail)(_sesi, CreateCriteriaDetail(xCoa2.ToList, xdtMain))

        For pj = 0 To xDtTransaksi.Count - 1
          Dim Item As New xMesitechCashFlowD(_sesi)
          Item.Id = 0
          Item.Tipe = xCF2(pi).Tipe
          Item.Urutan = xCF2(pi).Urutan
          Item.Nama = xCF2(pi).Nama
          Item.Asign = xCF2(pi).Asign

          Item.COA = xDtTransaksi(pj).Akun
          Item.Debit = xDtTransaksi(pj).Debit
          Item.Kredit = xDtTransaksi(pj).Kredit
          Item.NoTransaksi = xDtTransaksi(pj).Main.Kode
          Item.Tanggal = xDtTransaksi(pj).Main.Tanggal

          Item.Level = xDtTransaksi(pj).Akun.Level
          Item.Level1 = xDtTransaksi(pj).Akun.Level1
          Item.Level2 = xDtTransaksi(pj).Akun.Level2
          Item.Level3 = xDtTransaksi(pj).Akun.Level3
          Item.Level4 = xDtTransaksi(pj).Akun.Level4

          If Not xDtTransaksi(pj).Divisi Is Nothing Then Item.Divisi = xDtTransaksi(pj).Divisi.Kode
          If Not xDtTransaksi(pj).Proyek Is Nothing Then Item.Project = xDtTransaksi(pj).Proyek.Kode
          If Not xDtTransaksi(pj).ProyekSub Is Nothing Then Item.ProjectSub = xDtTransaksi(pj).ProyekSub.Kode

          Item.Keterangan = "Pengeluaran tipe 2"

          xDataCF.Add(Item)
        Next
      Next


      Dim pk As Integer, xItem As Persistent.xMesitechCashFlowD
      Dim xCFG As New XPCollection(Of Persistent.xMesitechCashFlowG)(_sesi, New BinaryOperator("Tipe", CustomReportTipe.CashFlow, BinaryOperatorType.Equal))
      For pI = 0 To xCFG.Count - 1
        'ambilkan datane dari coa IN
        Dim xDtCOACFIN As New XPCollection(Of Coa)(_sesi, New BinaryOperator("ReportCashFlowIN.Id", xCFG(pI).Id, BinaryOperatorType.Equal))
        For pk = 0 To xDtCOACFIN.Count - 1
          xItem = New Persistent.xMesitechCashFlowD(_sesi)
          xItem.Asign = xCFG(pI).Asign
          xItem.Tipe = xCFG(pI).Tipe
          xItem.Urutan = xCFG(pI).Urutan
          xItem.Nama = xCFG(pI).Nama
          xItem.COA = xDtCOACFIN(pk)
          xItem.Level = xDtCOACFIN(pk).Level
          xItem.Level1 = xDtCOACFIN(pk).Level1
          xItem.Level2 = xDtCOACFIN(pk).Level2
          xItem.Level3 = xDtCOACFIN(pk).Level3
          xItem.Level4 = xDtCOACFIN(pk).Level4

          xItem.m1 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFIN(pk).Id And m.Asign = "+" And Month(m.Tanggal) = 1).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m2 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFIN(pk).Id And m.Asign = "+" And Month(m.Tanggal) = 2).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m3 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFIN(pk).Id And m.Asign = "+" And Month(m.Tanggal) = 3).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m4 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFIN(pk).Id And m.Asign = "+" And Month(m.Tanggal) = 4).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m5 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFIN(pk).Id And m.Asign = "+" And Month(m.Tanggal) = 5).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m6 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFIN(pk).Id And m.Asign = "+" And Month(m.Tanggal) = 6).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m7 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFIN(pk).Id And m.Asign = "+" And Month(m.Tanggal) = 7).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m8 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFIN(pk).Id And m.Asign = "+" And Month(m.Tanggal) = 8).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m9 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFIN(pk).Id And m.Asign = "+" And Month(m.Tanggal) = 9).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m10 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFIN(pk).Id And m.Asign = "+" And Month(m.Tanggal) = 10).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m11 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFIN(pk).Id And m.Asign = "+" And Month(m.Tanggal) = 11).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m12 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFIN(pk).Id And m.Asign = "+" And Month(m.Tanggal) = 12).Sum(Function(n) n.Debit + n.Kredit)
          xItem.Debit = xItem.m1 + xItem.m2 + xItem.m3 + xItem.m4 + xItem.m5 + xItem.m6 + xItem.m7 + xItem.m8 + xItem.m9 + xItem.m10 + xItem.m11 + xItem.m12
          details.Add(xItem)
        Next

        ''ambilkan datane dari coa Out
        Dim xDtCOACFOUT As New XPCollection(Of Coa)(_sesi, New BinaryOperator("ReportCashFlowOut.Id", xCFG(pI).Id, BinaryOperatorType.Equal))
        For pk = 0 To xDtCOACFOUT.Count - 1
          xItem = New Persistent.xMesitechCashFlowD(_sesi)
          xItem.Asign = xCFG(pI).Asign
          xItem.Tipe = xCFG(pI).Tipe
          xItem.Urutan = xCFG(pI).Urutan
          xItem.Nama = xCFG(pI).Nama
          xItem.COA = xDtCOACFOUT(pk)
          xItem.Level = xDtCOACFOUT(pk).Level
          xItem.Level1 = xDtCOACFOUT(pk).Level1
          xItem.Level2 = xDtCOACFOUT(pk).Level2
          xItem.Level3 = xDtCOACFOUT(pk).Level3
          xItem.Level4 = xDtCOACFOUT(pk).Level4
          xItem.m1 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFOUT(pk).Id And m.Asign = "-" And Month(m.Tanggal) = 1).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m2 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFOUT(pk).Id And m.Asign = "-" And Month(m.Tanggal) = 2).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m3 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFOUT(pk).Id And m.Asign = "-" And Month(m.Tanggal) = 3).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m4 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFOUT(pk).Id And m.Asign = "-" And Month(m.Tanggal) = 4).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m5 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFOUT(pk).Id And m.Asign = "-" And Month(m.Tanggal) = 5).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m6 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFOUT(pk).Id And m.Asign = "-" And Month(m.Tanggal) = 6).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m7 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFOUT(pk).Id And m.Asign = "-" And Month(m.Tanggal) = 7).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m8 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFOUT(pk).Id And m.Asign = "-" And Month(m.Tanggal) = 8).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m9 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFOUT(pk).Id And m.Asign = "-" And Month(m.Tanggal) = 9).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m10 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFOUT(pk).Id And m.Asign = "-" And Month(m.Tanggal) = 10).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m11 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFOUT(pk).Id And m.Asign = "-" And Month(m.Tanggal) = 11).Sum(Function(n) n.Debit + n.Kredit)
          xItem.m12 = xDataCF.Where(Function(m) m.COA.Id = xDtCOACFOUT(pk).Id And m.Asign = "-" And Month(m.Tanggal) = 12).Sum(Function(n) n.Debit + n.Kredit)
          xItem.Debit = xItem.m1 + xItem.m2 + xItem.m3 + xItem.m4 + xItem.m5 + xItem.m6 + xItem.m7 + xItem.m8 + xItem.m9 + xItem.m10 + xItem.m11 + xItem.m12
          details.Add(xItem)
        Next
      Next

      splashManager.CloseWaitForm()
    End Using
    '_dataSource = details
    If chkSaldoNol.Checked = True Then
      _dataSource = details
    Else
      If details.Where(Function(x) x.Debit <> 0).Count > 0 Then
        _dataSource = details.Where(Function(x) x.Debit <> 0)
      Else
        _dataSource = details
      End If
    End If
  End Sub
End Class