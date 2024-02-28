Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent

Friend Class Log_FusohData
  Property Kode As String
  Property TipeData As SumberDataJenis

  Overrides Sub FirstLoad()
    txtKode.Text = Kode
    RefreshData()
  End Sub
  Private Sub btnTampilkanData_Click(sender As Object, e As EventArgs) Handles btnTampilkanData.Click
    RefreshData()
  End Sub

  Private Sub RefreshData()
    Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
      Try
        splashManager.ShowWaitForm()
        splashManager.SetWaitFormCaption("Silahkan Tunggu")
        splashManager.SetWaitFormDescription("Mengambil data log ...")

        Text = "Log Data : " & txtKode.Text
        xGrid.DataSource = Nothing
        If TipeData = SumberDataJenis.SQ Then
          colTabel.UnboundExpression = "Iif([TableName] == 'm06ddetailquotation', 'Detail' , 'Main')"
          RefreshDataSQ()
        ElseIf TipeData = SumberDataJenis.SO Then
          colTabel.UnboundExpression = "Iif([TableName] == 'm06edetailorder', 'Detail' , 'Main')"
          RefreshDataSO()
        ElseIf TipeData = SumberDataJenis.IV Then
          colTabel.UnboundExpression = "Iif([TableName] == 'm06fdetailinvoice', 'Detail' , 'Main')"
          RefreshDataINV()
        ElseIf TipeData = SumberDataJenis.SJ Then
          colTabel.UnboundExpression = "Iif([TableName] == 'm04dstockdetail', 'Detail' , 'Main')"
          RefreshDataSJ()
        ElseIf TipeData = SumberDataJenis.CP Then
          colTabel.UnboundExpression = "Iif([TableName] == 'm06gdetailpayment', 'Detail' , 'Main')"
          RefreshDataCP()
        End If
        xGridView.ExpandAllGroups()

        splashManager.CloseWaitForm()
      Catch ex As Exception
        splashManager.CloseWaitForm()
        Throw New Exception(ex.Message, ex.InnerException)
      End Try
    End Using
  End Sub
  Private Sub FillGrid(tabelName As List(Of String), rowId As String)
    Dim dataLog = New XPQuery(Of DatabaseLog)(session).Where(Function(w) tabelName.Contains(w.TableName) AndAlso (w.RowId = rowId OrElse w.UniqueId = rowId OrElse w.UniqueData = txtKode.Text)).ToList
    xGrid.DataSource = dataLog
  End Sub

  Private Sub RefreshDataSQ()
    Dim Item = New XPQuery(Of Fusoh_Penawaran)(session).Where(Function(w) w.Kode = txtKode.Text).ToList()
    If Item.Count > 0 Then
      Dim rowId = Item(0).Id.ToString
      Dim tabelName = New List(Of String)
      tabelName.Add(Item(0).ClassInfo.TableName)
      If (Item(0).Detail.Count > 0) Then tabelName.Add(Item(0).Detail(0).ClassInfo.TableName)
      FillGrid(tabelName, rowId)
    End If
  End Sub
  Private Sub RefreshDataSO()
    Dim Item = New XPQuery(Of Fusoh_OrderPenjualan)(session).Where(Function(w) w.Kode = txtKode.Text).ToList()
    If Item.Count > 0 Then
      Dim rowId = Item(0).Id.ToString
      Dim tabelName = New List(Of String)
      tabelName.Add(Item(0).ClassInfo.TableName)
      If (Item(0).Detail.Count > 0) Then tabelName.Add(Item(0).Detail(0).ClassInfo.TableName)
      FillGrid(tabelName, rowId)
    End If
  End Sub
  Private Sub RefreshDataINV()
    Dim Item = New XPQuery(Of Fusoh_InvoicePenjualan)(session).Where(Function(w) w.Kode = txtKode.Text).ToList()
    If Item.Count > 0 Then
      Dim rowId = Item(0).Id.ToString
      Dim tabelName = New List(Of String)
      tabelName.Add(Item(0).ClassInfo.TableName)
      If (Item(0).Detail.Count > 0) Then tabelName.Add(Item(0).Detail(0).ClassInfo.TableName)
      FillGrid(tabelName, rowId)
    End If
  End Sub
  Private Sub RefreshDataSJ()
    Dim Item = New XPQuery(Of Fusoh_SuratJalan)(session).Where(Function(w) w.Kode = txtKode.Text).ToList()
    If Item.Count > 0 Then
      Dim rowId = Item(0).Id.ToString
      Dim tabelName = New List(Of String)
      tabelName.Add(Item(0).ClassInfo.TableName)
      If (Item(0).Detail.Count > 0) Then tabelName.Add(Item(0).Detail(0).ClassInfo.TableName)
      FillGrid(tabelName, rowId)
    End If
  End Sub
  Private Sub RefreshDataCP()
    Dim Item = New XPQuery(Of Fusoh_PembayaranPiutang)(session).Where(Function(w) w.Kode = txtKode.Text).ToList()
    If Item.Count > 0 Then
      Dim rowId = Item(0).Id.ToString
      Dim tabelName = New List(Of String)
      tabelName.Add(Item(0).ClassInfo.TableName)
      If (Item(0).Detail.Count > 0) Then tabelName.Add(Item(0).Detail(0).ClassInfo.TableName)
      FillGrid(tabelName, rowId)
    End If
  End Sub
End Class