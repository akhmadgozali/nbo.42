Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Friend Class UI_AktivaTetapSaldoAwal
  Private instance As Persistent.AktivaTransaksiMain
  Private mataUangDefault As Integer
  Private isShown As Boolean
  Private detailToDelete As New List(Of Persistent.AktivaTransaksiDetail)
  Private setting As Logic.FinaSetting
  Private sumber As Persistent.SumberDataCollection
  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Persistent.AktivaTransaksiMain.AutoSaveOnEndEdit = False
    Persistent.AktivaTransaksiDetail.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    txtKontak.Properties.DataSource = New XPCollection(Of Persistent.Kontak)(session, New BinaryOperator("Aktif", True))
    txtRegional.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Regional)(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("AktivaTetapSaldoAwal.xml")) = True Then
      lytPembelian.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("AktivaTetapSaldoAwal.xml"))
    End If
    sumber = New Persistent.SumberDataCollection(session)
    Dim setting As New Logic.FinaSetting(session)
    colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQty.DisplayFormat.FormatString = setting.NumericFormatToString
    colQty.SummaryItem.DisplayFormat = setting.NumericFormatString
    colNilaiMasuk.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilaiMasuk.DisplayFormat.FormatString = setting.NumericFormatToString
    colNilaiMasuk.SummaryItem.DisplayFormat = setting.NumericFormatString
    mataUangDefault = setting.MultiMataUangDefault
  End Sub
  Overrides Sub InitializeData()
    setting = New Logic.FinaSetting(session)
    If Tipe = InputType.Tambah Then
      instance = New Persistent.AktivaTransaksiMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
      MyBase.InitializeData()
      xGrid.DataSource = Nothing
      txtKontak.EditValue = Nothing
      txtKontakNama.Text = ""
      txtRegionalNama.Text = ""
      If Not txtRegional.EditValue Is Nothing Then
        instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      Else
        txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
      End If
      instance.Sumber = sumber.GetObject(Persistent.SumberDataJenis.FA)
      ChangeCode()
      xGrid.DataSource = instance.Detail
      Me.Text = "Saldo Awal Aktiva Tetap: Tambah"
    Else
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.AktivaTransaksiMain)(Convert.ToInt64(IdToEdit))
      instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
      txtKontak.EditValue = instance.Kontak
      txtTanggal.EditValue = instance.Tanggal
      txtNoTransaksi.Text = instance.Kode
      txtRegional.EditValue = instance.Regional
      txtUraian.EditValue = instance.Uraian

      xGrid.DataSource = instance.Detail
      Me.Text = "Saldo Awal Aktiva Tetap: Edit - " & instance.Kode
    End If
  End Sub
  Overrides Sub LoadAfterInitialize()

  End Sub
  Overrides Sub SimpanData()
    Try
      For i = detailToDelete.Count - 1 To 0 Step -1
        detailToDelete(i).Delete()
      Next

      If Not txtKontak.EditValue Is Nothing Then
        instance.Kontak = CType(txtKontak.EditValue, Persistent.Kontak)
      End If
      instance.Tanggal = txtTanggal.DateTime
      instance.Tipe = Persistent.eTipeTransaksiAsset.SaldoAwal
      instance.Kode = txtNoTransaksi.Text
      If Not txtRegional.EditValue Is Nothing Then
        instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      End If
      instance.Uraian = txtUraian.Text
      For pi = 0 To instance.Detail.Count - 1
        instance.Detail(pi).Asset.Pembelian = True
      Next

      instance.Save()
      '======= Simpan instance
      session.CommitChanges()
      Me.Close()
    Catch ex As Utils.Exception
      Throw New Utils.Exception(ex)
    Catch ex As Exception
      Throw New Exception(ex.Message, ex.InnerException)
    End Try
  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtNoTransaksi.Focus()
      Case -2 : txtTanggal.Focus()
      Case -3 : txtRegional.Focus()
      Case -4 : txtKontak.Focus()
      Case -99 : xGrid.Focus()
    End Select
  End Sub
  Private Sub ChangeCode()
    If txtTanggal.EditValue Is Nothing OrElse instance.Tanggal = Nothing Then
      Return
    End If
    If txtRegional.EditValue Is Nothing OrElse instance.Regional Is Nothing Then
      Return
    End If
    Dim nomor As Core.Modules.NumberResult = instance.Number.GetNewNumber
    txtNoTransaksi.Text = nomor.Kode
  End Sub
  Private Sub Me_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    isShown = True
  End Sub
  Private Sub txtKontak_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtKontak.EditValueChanging
    If e.NewValue Is Nothing Then
      txtKontakNama.Text = ""
    Else
      Dim item As Persistent.Kontak = CType(e.NewValue, Persistent.Kontak)
      txtKontakNama.Text = item.Nama
    End If
  End Sub
  Private Sub txtRegional_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtRegional.EditValueChanging
    If e.NewValue Is Nothing Then
      txtRegionalNama.Text = ""
    Else
      Dim item As NPO.Modules.ModSys.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
      txtRegionalNama.Text = item.Nama
    End If

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
  Private Sub txtTanggal_EditValueChanged(sender As Object, e As EventArgs) Handles txtTanggal.EditValueChanged
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
      fillData()
    Catch ex As Exception
      If ex.Message.Contains("Object reference not set to an instance") Then
      Else
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Me.Text, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
      End If
    End Try
  End Sub
  Private Sub txtRefreshNomor_Click(sender As Object, e As EventArgs) Handles txtRefreshNomor.Click
    ChangeCode()
  End Sub
  Private Sub fillData()
    'For pI = 0 To instance.Detail.Count - 1 Step -1
    '  instance.Detail(pI).Delete()
    'Next

    Dim xData As New XPCollection(Of Persistent.AktivaTetap)(session, New GroupOperator(GroupOperator.And, New BinaryOperator("Pembelian", False, BinaryOperatorType.Equal), New BinaryOperator("TanggalBeli", txtTanggal.DateTime, BinaryOperatorType.Less)))
    Dim xItem As Persistent.AktivaTransaksiDetail, xTglBeli As Date, xSelisihBulan As Long
    For pi = 0 To xData.Count - 1
      xTglBeli = xData(pi).TanggalBeli
      If xData(pi).Tgl15 = True Then
        If Day(xTglBeli) > 15 Then
          xTglBeli = DateAdd(DateInterval.Month, 1, xTglBeli)
        End If
      End If

      xSelisihBulan = DateDiff(DateInterval.Month, xTglBeli, txtTanggal.DateTime)

      If xSelisihBulan > xData(pi).Kelompok.Umur Then
        xSelisihBulan = xData(pi).Kelompok.Umur
      End If

      xItem = New Persistent.AktivaTransaksiDetail(session)
      xItem.Asset = xData(pi)
      xItem.Tanggal = xData(pi).TanggalBeli
      xItem.Qty = xData(pi).Qty
      xItem.NilaiMasuk = FindBookValue(xData(pi), xSelisihBulan) / xItem.Qty
      xItem.Keterangan = "Penyusutan : " & xSelisihBulan & " Bulan"
      instance.Detail.Add(xItem)
    Next
  End Sub
  Private Function FindBookValue(xAsset As Persistent.AktivaTetap, xAge As Long) As Double
    Dim xTabel As New XPCollection(Of Persistent.AktivaTetapPenyusutan)(session, New BinaryOperator("Asset.Id", xAsset.Id, BinaryOperatorType.Equal), New SortProperty("Sequence", DevExpress.Xpo.DB.SortingDirection.Descending))
    Dim pAge As Long, pValueAmortitation As Double = 0, pNilaiAsset As Double
    pAge = xAge
    For pJ = 0 To xTabel.Count - 1
      If pAge > xTabel(pJ).Month Then
        pAge = pAge - xTabel(pJ).Month
        pValueAmortitation = pValueAmortitation + ((xTabel(pJ).Month * xTabel(pJ).Nilai) * xAsset.Qty)
      Else
        pValueAmortitation = pValueAmortitation + ((pAge * xTabel(pJ).Nilai) * xAsset.Qty)
        pAge = 0
      End If
      If pAge = 0 Then
        Exit For
      End If
    Next
    pNilaiAsset = xAsset.Qty * (xAsset.Harga - xAsset.NilaiResidu)
    Return pNilaiAsset - (pValueAmortitation)
  End Function
End Class