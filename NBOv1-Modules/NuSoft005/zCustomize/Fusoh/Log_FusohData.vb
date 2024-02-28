Imports DevExpress.Xpo
Imports NuSoft.NPO
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent

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
        If TipeData = SumberDataJenis.EX Then
          colTabel.UnboundExpression = "Iif([TableName] == 'm05edetailexim', 'Detail' , 'Main')"
          RefreshDataEX()
        ElseIf TipeData = SumberDataJenis.PO Then
          colTabel.UnboundExpression = "Iif([TableName] == 'm05ddetailorder', 'Detail' , 'Main')"
          RefreshDataPO()
        ElseIf TipeData = SumberDataJenis.CS Then
          colTabel.UnboundExpression = "Iif([TableName] == 'm05ddetailinvoicereceipt', 'Detail' , 'Main')"
          RefreshDataCS()
        ElseIf TipeData = SumberDataJenis.RI Then
          colTabel.UnboundExpression = "Iif([TableName] == 'm05ddetailinvoicereceipt', 'Detail' , 'Main')"
          RefreshDataRI()
        ElseIf TipeData = SumberDataJenis.GR Then
          colTabel.UnboundExpression = "Iif([TableName] == 'm04dstockdetail', 'Detail' , 'Main')"
          RefreshDataGR()
        ElseIf TipeData = SumberDataJenis.VP Then
          colTabel.UnboundExpression = "Iif([TableName] == 'm05ddetailpayment', 'Detail' , 'Main')"
          RefreshDataVP()
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

  Private Sub RefreshDataEX()
    Dim Item = New XPQuery(Of Fusoh_Exim)(session).Where(Function(w) w.Kode = txtKode.Text).ToList()
    If Item.Count > 0 Then
      Dim rowId = Item(0).Id.ToString
      Dim tabelName = New List(Of String)
      tabelName.Add(Item(0).ClassInfo.TableName)
      If (Item(0).Detail.Count > 0) Then tabelName.Add(Item(0).Detail(0).ClassInfo.TableName)
      FillGrid(tabelName, rowId)
    End If
  End Sub
  Private Sub RefreshDataPO()
    Dim Item = New XPQuery(Of Fusoh_OrderPembelian)(session).Where(Function(w) w.Kode = txtKode.Text).ToList()
    If Item.Count > 0 Then
      Dim rowId = Item(0).Id.ToString
      Dim tabelName = New List(Of String)
      tabelName.Add(Item(0).ClassInfo.TableName)
      If (Item(0).Detail.Count > 0) Then tabelName.Add(Item(0).Detail(0).ClassInfo.TableName)
      FillGrid(tabelName, rowId)
    End If
  End Sub
  Private Sub RefreshDataCS()
    Dim Item = New XPQuery(Of Fusoh_PenerimaanInvoice)(session).Where(Function(w) w.Kode = txtKode.Text).ToList()
    If Item.Count > 0 Then
      Dim rowId = Item(0).Id.ToString
      Dim tabelName = New List(Of String)
      tabelName.Add(Item(0).ClassInfo.TableName)
      If (Item(0).Detail.Count > 0) Then tabelName.Add(Item(0).Detail(0).ClassInfo.TableName)
      FillGrid(tabelName, rowId)
    End If
  End Sub
  Private Sub RefreshDataRI()
    Dim Item = New XPQuery(Of Fusoh_PenerimaanInvoice)(session).Where(Function(w) w.Kode = txtKode.Text).ToList()
    If Item.Count > 0 Then
      Dim rowId = Item(0).Id.ToString
      Dim tabelName = New List(Of String)
      tabelName.Add(Item(0).ClassInfo.TableName)
      If (Item(0).Detail.Count > 0) Then tabelName.Add(Item(0).Detail(0).ClassInfo.TableName)
      FillGrid(tabelName, rowId)
    End If
  End Sub
  Private Sub RefreshDataGR()
    Dim Item = New XPQuery(Of Fusoh_PenerimaanBarang)(session).Where(Function(w) w.Kode = txtKode.Text).ToList()
    If Item.Count > 0 Then
      Dim rowId = Item(0).Id.ToString
      Dim tabelName = New List(Of String)
      tabelName.Add(Item(0).ClassInfo.TableName)
      If (Item(0).Detail.Count > 0) Then tabelName.Add(Item(0).Detail(0).ClassInfo.TableName)
      FillGrid(tabelName, rowId)
    End If
  End Sub
  Private Sub RefreshDataVP()
    Dim Item = New XPQuery(Of Fusoh_PembayaranHutang)(session).Where(Function(w) w.Kode = txtKode.Text).ToList()
    If Item.Count > 0 Then
      Dim rowId = Item(0).Id.ToString
      Dim tabelName = New List(Of String)
      tabelName.Add(Item(0).ClassInfo.TableName)
      If (Item(0).Detail.Count > 0) Then tabelName.Add(Item(0).Detail(0).ClassInfo.TableName)
      FillGrid(tabelName, rowId)
    End If
  End Sub
End Class