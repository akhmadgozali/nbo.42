Imports DevExpress.Data.Async.Helpers
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraGrid.Views.Grid

Friend Enum JenisTransaksiGL
  KasMasuk
  BankMasuk
  KasKeluar
  BankKeluar
  JurnalUmum
  JurnalAdjusment
End Enum

Friend Class UI_TransaksiGL
  Private _jenisTransaksi As JenisTransaksiGL
  Private toStringFormat As String
  Sub New(jenisTransaksi As JenisTransaksiGL)
    InitializeComponent()

    baseView = xGridView
    _jenisTransaksi = jenisTransaksi
    KeyField = "Id"
    useMDIforDialog = True
    useFeedbackSource = True
    ActivateToolTip = True
    UseDbSystem = False

    Select Case _jenisTransaksi
      Case JenisTransaksiGL.KasMasuk : Me.Text = "Kas Masuk"
      Case JenisTransaksiGL.KasKeluar : Me.Text = "Kas Keluar"
      Case JenisTransaksiGL.BankMasuk : Me.Text = "Bank Masuk"
      Case JenisTransaksiGL.BankKeluar : Me.Text = "Bank Keluar"
      Case JenisTransaksiGL.JurnalUmum : Me.Text = "Jurnal Umum"
        colAkun.GroupIndex = -1
        colAkun.Visible = False
      Case JenisTransaksiGL.JurnalAdjusment : Me.Text = "Jurnal Adjusment"
        colAkun.GroupIndex = -1
        colAkun.Visible = False
    End Select
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
    Dim a As New Logic.FinaSetting(session)
    colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colSaldo.DisplayFormat.FormatString = a.NumericFormatString
    toStringFormat = a.NumericFormatToString
    Dim sumber As New Persistent.SumberDataCollection(session)

    Dim iList As New List(Of SumberData)
    Select Case _jenisTransaksi
      Case JenisTransaksiGL.BankMasuk
        iList.Add(sumber.GetObject(Persistent.SumberDataJenis.BM))
      Case JenisTransaksiGL.KasMasuk
        iList.Add(sumber.GetObject(Persistent.SumberDataJenis.KM))
      Case JenisTransaksiGL.BankKeluar
        iList.Add(sumber.GetObject(Persistent.SumberDataJenis.BK))
      Case JenisTransaksiGL.KasKeluar
        iList.Add(sumber.GetObject(Persistent.SumberDataJenis.KK))
      Case JenisTransaksiGL.JurnalUmum
        iList.Add(sumber.GetObject(Persistent.SumberDataJenis.JU))
      Case JenisTransaksiGL.JurnalAdjusment
        iList.Add(sumber.GetObject(Persistent.SumberDataJenis.JA))
    End Select
    Dim CreateCriteria As CriteriaOperator
    CreateCriteria = GroupOperator.And(New InOperator("Sumber", iList), New InOperator("Regional", UserInfo.GetUserRegional(session, NamaDatabase)))
    ifSource.FixedFilterCriteria = CreateCriteria

    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("GLTransaksi.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("GLTransaksi.xml"))
    End If

  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Select Case _jenisTransaksi
      Case JenisTransaksiGL.KasMasuk : Return New UI_TransaksiKM
      Case JenisTransaksiGL.KasKeluar : Return New UI_TransaksiKK
      Case JenisTransaksiGL.BankMasuk : Return New UI_TransaksiBM
      Case JenisTransaksiGL.BankKeluar : Return New UI_TransaksiBK
      Case JenisTransaksiGL.JurnalUmum : Return New UI_TransaksiJU
      Case JenisTransaksiGL.JurnalAdjusment : Return New UI_TransaksiJA
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
        item.Data = xGridView.GetRowCellValue(selectedRows(i), "Kode").ToString
        result.Add(item)
      End If
    Next
    Return result
  End Function
  Overrides Function HapusData(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)) As Boolean
    Dim item As Persistent.GlMain
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim notDeleted As New List(Of Persistent.GlMain)
    Dim notDeletedPeriode As New List(Of Persistent.GlMain)

    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        proxy = CType(xGridView.GetRow(selectedData(i).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
        item = CType(proxy.OriginalRow, Persistent.GlMain)

        If Persistent.Periode.CheckLockedPeriod(session, item.Tanggal) Then
          notDeletedPeriode.Add(item)
        ElseIf item.ModuleId <> MainClass.GetModuleId Then
          notDeleted.Add(item)
        Else
          item.Delete()
        End If
      End If
    Next
    session.CommitChanges()

    If notDeletedPeriode.Count > 0 Then
      Dim text As String = My.Resources.GLDeletedPeriode
      For i = 0 To notDeletedPeriode.Count - 1
        text &= vbCrLf & notDeletedPeriode(i).Kode
      Next
      Utils.Win.MessageBox.Show(text, "Hapus " & Me.Text, My.Resources.GLDeletedPeriodeSolution, Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If
    If notDeleted.Count > 0 Then
      Dim text As String = My.Resources.GLDeletedModul
      For i = 0 To notDeleted.Count - 1
        text &= vbCrLf & notDeleted(i).Kode
      Next
      Utils.Win.MessageBox.Show(text, "Hapus " & Me.Text, My.Resources.GLDeletedModulSolution, Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    End If

    Return True
  End Function
  Overrides Function GetToolTipContent(view As DevExpress.XtraGrid.Views.Grid.GridView, info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
    Dim item As Persistent.GlMain
    Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
    Dim result As String = ""
    Dim coaCode As String = "", coaName As String = "", coaAmount As String = "", coaSpace As String = ""
    Dim num As Integer

    Try
      proxy = CType(view.GetRow(info.RowHandle), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      item = CType(proxy.OriginalRow, Persistent.GlMain)

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
  Private Sub btnCetakVoucher_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCetakVoucher.ItemClick
    Dim x As Integer() = Nothing

    If baseView.RowCount < 1 Then
      Exit Sub
    End If

    If TypeOf (baseView) Is DevExpress.XtraGrid.Views.Grid.GridView Then
      Dim viewGrid As DevExpress.XtraGrid.Views.Grid.GridView = CType(baseView, DevExpress.XtraGrid.Views.Grid.GridView)
      If viewGrid.IsGroupRow(viewGrid.FocusedRowHandle) Then
        Exit Sub
      End If
      x = viewGrid.GetSelectedRows
    ElseIf TypeOf (baseView) Is DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView Then
      Dim viewGrid As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = CType(baseView, DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)
      If viewGrid.IsGroupRow(viewGrid.FocusedRowHandle) Then
        Exit Sub
      End If
      x = viewGrid.GetSelectedRows
    End If

    Dim note As List(Of NuSoft.Core.Win.Forms.GridDeletedData) = GetKeteranganHapus(x)
    If note Is Nothing Then
      Utils.Win.MessageBox.Show("Masukkan keterangan data yang akan dihapus", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      Exit Sub
    End If
    If note.Count > 0 Then
      Dim item As Persistent.GlMain
      Dim proxy As ReadonlyThreadSafeProxyForObjectFromAnotherThread
      Dim xJenis As Persistent.SumberDataJenis
      Dim reportCode As String = ""


      proxy = CType(xGridView.GetRow(note(0).Row), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      item = CType(proxy.OriginalRow, Persistent.GlMain)

      Select Case _jenisTransaksi
        Case JenisTransaksiGL.KasMasuk : xJenis = Persistent.SumberDataJenis.KM : reportCode = MainClass.GetReport(MainClass.reportName.BuktiKasMasuk)
        Case JenisTransaksiGL.KasKeluar : xJenis = Persistent.SumberDataJenis.KK : reportCode = MainClass.GetReport(MainClass.reportName.BuktiKasKeluar)
        Case JenisTransaksiGL.BankMasuk : xJenis = Persistent.SumberDataJenis.BM : reportCode = MainClass.GetReport(MainClass.reportName.BuktiBankMasuk)
        Case JenisTransaksiGL.BankKeluar : xJenis = Persistent.SumberDataJenis.BK : reportCode = MainClass.GetReport(MainClass.reportName.BuktiBankKeluar)
        Case JenisTransaksiGL.JurnalUmum : xJenis = Persistent.SumberDataJenis.JU : reportCode = MainClass.GetReport(MainClass.reportName.BuktiJurnalUmum)
        Case JenisTransaksiGL.JurnalAdjusment : xJenis = Persistent.SumberDataJenis.JA : reportCode = MainClass.GetReport(MainClass.reportName.BuktiJurnalAdjustment)
      End Select

      Dim frm As New RF_BuktiHarian(xJenis, MainClass.reportName.BuktiJurnalVoucher)
      frm.txtNoBukti1.EditValue = item.Kode
      Dim message As String = "Apakah anda ingin mencetak bukti {0} dengan nomor " & item.Kode & " ?"

      message = String.Format(message, "Jurnal Voucher")
      Core.Win.Report.DirectExecuteReport(frm, NamaDatabase, reportCode, message, True)
    End If
  End Sub
  Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("GLTransaksi.xml"))
  End Sub

  Public Overrides Sub GridViewRowStyle(sender As Object, e As RowStyleEventArgs)
    Try
      If xGridView.IsGroupRow(e.RowHandle) Then
        Return
      End If

      Dim proxy = CType(xGridView.GetRow(e.RowHandle), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
      Dim item = CType(proxy.OriginalRow, Persistent.GlMain)

      Select Case item.ModuleId
        Case NPO.Modules.ModuleId.Sales
          e.Appearance.BackColor = System.Drawing.Color.SeaGreen
        Case NPO.Modules.ModuleId.SirkulasiKoran
          e.Appearance.BackColor = System.Drawing.Color.Khaki
        Case NPO.Modules.ModuleId.IklanKoran
          e.Appearance.BackColor = System.Drawing.Color.IndianRed
      End Select
      '  If (xGridView.IsGroupRow(e.RowHandle)) Then Return;

      'PPnKeluaran item = (PPnKeluaran)((ReadonlyThreadSafeProxyForObjectFromAnotherThread)xGridView.GetRow(e.RowHandle)).OriginalRow;
      'Switch(item.ModuleId) {
      '	Case ModuleId.Sales : e.Appearance.BackColor = Color.SeaGreen; break;
      '	Case ModuleId.SirkulasiKoran : e.Appearance.BackColor = Color.Khaki; break;
      '	Case ModuleId.IklanKoran : e.Appearance.BackColor = Color.IndianRed; break;
      '	Default
      '        break;
      '}
    Catch ex As Exception

    End Try
  End Sub

	Private Sub btnHistory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHistory.ItemClick
		If xGridView.IsDataRow(xGridView.FocusedRowHandle) Then
			'Dim frm As New Log_FusohData
			'frm.session = session
			'frm.TipeData = Persistent.SumberDataJenis.SO
			'Dim proxy = CType(xGridView.GetFocusedRow(), ReadonlyThreadSafeProxyForObjectFromAnotherThread)
			'Dim item = CType(proxy.OriginalRow, Persistent.Fusoh_OrderPenjualan)
			'frm.Kode = item.Kode
			'frm.ShowDialog()
		End If
	End Sub
End Class