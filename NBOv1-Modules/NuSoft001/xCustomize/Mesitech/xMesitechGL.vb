Imports DevExpress.Data.Async.Helpers
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem
Friend Enum xJenisMesitechGL
  BuktiKas
  BuktiBank
  JurnalMemo
  AppPembayaran
  JurnalMemoAR
  BuktiBankAR
End Enum
Friend Class xMesitechGL
  Private _jenisTransaksi As xJenisMesitechGL
  Private toStringFormat As String
  Sub New(jenisTransaksi As xJenisMesitechGL)
    InitializeComponent()

    baseView = xGridView
    _jenisTransaksi = jenisTransaksi
    KeyField = "Main.Id"
    useMDIforDialog = True
    useFeedbackSource = True
    ActivateToolTip = True
    UseDbSystem = False

    Select Case _jenisTransaksi
      Case xJenisMesitechGL.BuktiKas : Me.Text = "Bukti Kas" : cmdCetakBuktiKas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
      Case xJenisMesitechGL.BuktiBank : Me.Text = "Bukti Bank" : cmdCetakBuktiBank.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
      Case xJenisMesitechGL.JurnalMemo : Me.Text = "Jurnal Memo" : btnJurnalMemo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
      Case xJenisMesitechGL.AppPembayaran : Me.Text = "APP Pembayaran" : cmdCetakBuktiAPP.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
      Case xJenisMesitechGL.JurnalMemoAR : Me.Text = "Jurnal Memo AR" : btnJurnalMemo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
      Case xJenisMesitechGL.BuktiBankAR : Me.Text = "Bukti Bank AR" : cmdCetakBuktiBank.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
    End Select
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
    Dim a As New Logic.FinaSetting(session)
    colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDebit.DisplayFormat.FormatString = a.NumericFormatString
    colKredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKredit.DisplayFormat.FormatString = a.NumericFormatString
    toStringFormat = a.NumericFormatToString
    Dim sumber As New Persistent.SumberDataCollection(session)

    Dim iList As New List(Of SumberData)
    Select Case _jenisTransaksi
      Case xJenisMesitechGL.BuktiKas
        iList.Add(sumber.GetObject(Persistent.SumberDataJenis.KM))
      Case xJenisMesitechGL.BuktiBank
        iList.Add(sumber.GetObject(Persistent.SumberDataJenis.BM))
      Case xJenisMesitechGL.JurnalMemo
        iList.Add(sumber.GetObject(Persistent.SumberDataJenis.JU))
      Case xJenisMesitechGL.AppPembayaran
        iList.Add(sumber.GetObject(Persistent.SumberDataJenis.PA))
      Case xJenisMesitechGL.JurnalMemoAR
        iList.Add(sumber.GetObject(Persistent.SumberDataJenis.JM))
      Case xJenisMesitechGL.BuktiBankAR
        iList.Add(sumber.GetObject(Persistent.SumberDataJenis.BA))
    End Select
    Dim CreateCriteria As CriteriaOperator
    CreateCriteria = GroupOperator.And(New InOperator("Main.Sumber", iList), New InOperator("Main.Regional", UserInfo.GetUserRegional(session, NamaDatabase)))
    ifSource.FixedFilterCriteria = CreateCriteria

    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("xMesitechGLTransaksi.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("xMesitechGLTransaksi.xml"))
    End If
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Select Case _jenisTransaksi
      Case xJenisMesitechGL.BuktiKas : Return New xMesitechBuktiKas
      Case xJenisMesitechGL.BuktiBank : Return New xMesitechBuktiBank
      Case xJenisMesitechGL.JurnalMemo : Return New xMesitechJM
      Case xJenisMesitechGL.AppPembayaran : Return New xMesitechAPP
      Case xJenisMesitechGL.JurnalMemoAR : Return New xMesitechJMAR
      Case xJenisMesitechGL.BuktiBankAR : Return New xMesitechBuktiBankAR
      Case Else : Return New UI_TransaksiKK
    End Select
  End Function
  Overrides Function GetKeteranganHapus(selectedRows() As Integer) As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
    Dim result As New List(Of Core.Win.Forms.GridDeletedData)
    Dim item As Core.Win.Forms.GridDeletedData

    For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
      If Not xGridView.IsGroupRow(selectedRows(i)) Then
        item = New Core.Win.Forms.GridDeletedData
        item.Row = selectedRows(i)
        item.Data = xGridView.GetRowCellValue(selectedRows(i), "Main.Kode").ToString
        result.Add(item)
      End If
    Next
    Return result
  End Function
  Overrides Function HapusData(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)) As Boolean
    Dim item As Persistent.xMesitechGlDetail
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim notDeleted As New List(Of Persistent.xMesitechGlDetail)
    Dim DeleteData As New List(Of Persistent.xMesitechGlDetail)
    Dim notDeletedPeriode As New List(Of Persistent.xMesitechGlDetail)

    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.xMesitechGlDetail)

        If Persistent.Periode.CheckLockedPeriod(session, item.Main.Tanggal) Then
          notDeletedPeriode.Add(item)
        ElseIf item.Main.ModuleId <> MainClass.GetModuleId Then
          notDeleted.Add(item)
        Else
          DeleteData.Add(item)
        End If
      End If
    Next
    If DeleteData.Count > 0 Then
      'delete datanya
      Dim b = From z In DeleteData Group z By z.Main.Id, z.Main.Kode Into Group Select Id, kode
      For Each x In b
        Dim zdtMain As Persistent.GlMain = session.FindObject(Of Persistent.GlMain)(New BinaryOperator("Id", x.Id, BinaryOperatorType.Equal))
        If Not zdtMain Is Nothing Then
          zdtMain.Delete()
        End If
      Next
    End If
    session.CommitChanges()

    If notDeletedPeriode.Count > 0 Then
      Dim text As String = My.Resources.GLDeletedPeriode
      For i = 0 To notDeletedPeriode.Count - 1
        text &= vbCrLf & notDeletedPeriode(i).Main.Kode
      Next
      Utils.Win.MessageBox.Show(text, "Hapus " & Me.Text, My.Resources.GLDeletedPeriodeSolution, Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
    If notDeleted.Count > 0 Then
      Dim text As String = My.Resources.GLDeletedModul
      For i = 0 To notDeleted.Count - 1
        text &= vbCrLf & notDeleted(i).Main.Kode
      Next
      Utils.Win.MessageBox.Show(text, "Hapus " & Me.Text, My.Resources.GLDeletedModulSolution, Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If

    Return True
  End Function
  Overrides Function GetToolTipContent(view As DevExpress.XtraGrid.Views.Grid.GridView, info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
    Dim item As Persistent.xMesitechGLMain
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim result As String = ""
    Dim coaCode As String = "", coaName As String = "", coaAmount As String = "", coaSpace As String = ""
    Dim num As Integer

    Try
      proxy = CType(view.GetRow(info.RowHandle), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      item = CType(proxy.OriginalRow, Persistent.xMesitechGLMain)

      Dim a = From p In item.Detail Select p Where p.Kredit = 0
      Dim b = From p In item.Detail Select p Where p.Debit = 0

      For i = 0 To a.Count - 1
        coaCode = a(i).Akun.Kode
        coaName = a(i).Akun.Nama
        coaAmount = a(i).Debit.ToString(toStringFormat)
        num = (coaCode.Length + coaName.Length + coaAmount.Length + 1)
        If num >= 50 Then
          coaSpace = " "
        Else
          coaSpace = Space(50 - num)
        End If

        result += coaCode & " " & coaName & coaSpace & coaAmount
        If i <> a.Count - 1 Then
          result += vbCrLf
        End If
      Next

      For i = 0 To b.Count - 1
        coaCode = b(i).Akun.Kode
        coaName = b(i).Akun.Nama
        coaAmount = b(i).Kredit.ToString(toStringFormat)
        num = (coaCode.Length + coaName.Length + coaAmount.Length + 1)
        If num >= 50 Then
          coaSpace = " "
        Else
          coaSpace = Space(50 - num)
        End If

        result += vbCrLf & coaCode & " " & coaName & coaSpace & coaAmount
        If i <> b.Count - 1 Then
          result += vbCrLf
        End If
      Next

      Return result
    Catch ex As Exception
      Return ""
    End Try
  End Function
  Overrides Function GetToolTipTitle(view As DevExpress.XtraGrid.Views.Grid.GridView, info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
    Return view.GetRowCellDisplayText(info.RowHandle, colNoBukti)
  End Function
  Private Sub btnCetakVoucher_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnKasMasuk.ItemClick, btnKasKeluar.ItemClick, btnBankMasuk.ItemClick, btnBankKeluar.ItemClick, btnBuktiAPP.ItemClick, btnBuktiAPP2.ItemClick, btnJurnalMemo.ItemClick
    Dim xNomor As String = xGridView.GetFocusedRowCellDisplayText(colNoBukti)
    If Not xNomor Is Nothing Then
      If e.Item.Tag.ToString = "KasMasuk" Or e.Item.Tag.ToString = "KasKeluar" Then
        Dim frm As New RF_MesitechTransaksi(Persistent.SumberDataJenis.KM, MainClass.reportName.BuktiKasMasuk)
        frm.txtNoBukti1.EditValue = xNomor
        Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & xNomor & " ?"
        Dim reportCode As String = ""
        If e.Item.Tag.ToString = "KasMasuk" Then
          reportCode = MainClass.GetReport(MainClass.reportName.zBuktiKasMasuk)
        Else
          reportCode = MainClass.GetReport(MainClass.reportName.zBuktiKasKeluar)
        End If
        message = String.Format(message, "Bukti Kas")
        Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
      End If
      'voucher bank
      If e.Item.Tag.ToString = "BankMasuk" Or e.Item.Tag.ToString = "BankKeluar" Then
        Dim frm As New RF_MesitechTransaksi(Persistent.SumberDataJenis.BM, MainClass.reportName.BuktiKasMasuk)
        frm.txtNoBukti1.EditValue = xNomor
        Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & xNomor & " ?"
        Dim reportCode As String = ""
        If e.Item.Tag.ToString = "BankMasuk" Then
          reportCode = MainClass.GetReport(MainClass.reportName.zBuktiBankMasuk)
        Else
          reportCode = MainClass.GetReport(MainClass.reportName.zBuktiBankKeluar)
        End If
        message = String.Format(message, "Bukti Bank")
        Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
      End If
      'voucher app
      If e.Item.Tag.ToString = "BuktiAPP" Or e.Item.Tag.ToString = "BuktiAPPDropship" Then
        Dim frm As New RF_MesitechTransaksi(Persistent.SumberDataJenis.PA, MainClass.reportName.zBuktiJurnalAPP)
        frm.txtNoBukti1.EditValue = xNomor
        Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & xNomor & " ?"
        Dim reportCode As String = ""
        If e.Item.Tag.ToString = "BuktiAPP" Then
          reportCode = MainClass.GetReport(MainClass.reportName.zBuktiJurnalAPP)
        Else
          reportCode = MainClass.GetReport(MainClass.reportName.zBuktiJUrnalAPPDropship)
        End If
        message = String.Format(message, "Bukti APP")
        Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
      End If
      'voucher jurnal memo
      If e.Item.Tag.ToString = "JurnalMemo" Then
        Dim frm As New RF_MesitechTransaksi(Persistent.SumberDataJenis.JU, MainClass.reportName.BuktiJurnalUmum)
        frm.txtNoBukti1.EditValue = xNomor
        Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & xNomor & " ?"
        Dim reportCode As String = ""
        reportCode = MainClass.GetReport(MainClass.reportName.BuktiJurnalUmum)
        message = String.Format(message, "Bukti Jurnal Memo")
        Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
      End If
    End If
  End Sub
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("xMesitechGLTransaksi.xml"))
  End Sub
  Private Sub btnFilterHariIni_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilterHariIni.ItemClick
    Dim expr1 As CriteriaOperator = New BinaryOperator("Main.Tanggal", Now.Date)
    xGridView.ActiveFilterCriteria = GroupOperator.And(New CriteriaOperator() {expr1})
    'GridView1.ActiveFilterString = "([ProductID] = 1 OR [ProductID] = 3 OR [ProductID] > 10) AND [Discount] = 0"
  End Sub
  Private Sub btnFilterMingguIni_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilterMingguIni.ItemClick
    Dim dayDiff As Integer = Date.Today.DayOfWeek - DayOfWeek.Monday
    Dim tglAwal As Date = Today.AddDays(-dayDiff)
    Dim tglAkhir As Date = tglAwal.AddDays(6)

    Dim expr1 As CriteriaOperator = New BetweenOperator("Main.Tanggal", tglAwal, tglAkhir)
    xGridView.ActiveFilterCriteria = GroupOperator.And(New CriteriaOperator() {expr1})
  End Sub
  Private Sub btnFilterBulanIni_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilterBulanIni.ItemClick
    Dim tglawal As Date = New Date(Now.Year, Now.Month, 1)
    Dim tglAkhir As Date = tglawal.AddMonths(1).AddDays(-(tglawal.AddMonths(1).Day))
    Dim expr1 As CriteriaOperator = New BetweenOperator("Main.Tanggal", tglawal, tglAkhir)
    xGridView.ActiveFilterCriteria = GroupOperator.And(New CriteriaOperator() {expr1})
  End Sub
  Private Sub btnFilterData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilterData.ItemClick
    Dim xform As New xMesitechGLFilter
    xform.MenuId = MenuId
    xform.NamaDatabase = NamaDatabase
    xform.session = session
    xform.Owner = Me
    xform.ShowDialog()
  End Sub
  Friend Sub InitFilter(xFilter As DevExpress.Data.Filtering.CriteriaOperator)
    xGridView.ActiveFilterCriteria = xFilter
  End Sub
End Class