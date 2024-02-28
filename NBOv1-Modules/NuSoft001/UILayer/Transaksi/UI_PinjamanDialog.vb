Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Friend Class UI_PinjamanDialog
  Private instance As Persistent.Pinjaman
  Private isShown As Boolean
  Private setting As Logic.FinaSetting

  Overrides Sub LoadBeforeInitialize()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("LATransaksi.xml")) = True Then
      lytLa.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("LATransaksi.xml"))
    End If
    txtKontak.Properties.DataSource = New XPCollection(Of Persistent.Kontak)(session, New BinaryOperator("Aktif", True))
    txtRegional.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Regional)(session)
    txtMataUang.Properties.DataSource = New XPCollection(Of Persistent.MataUang)(session)
    setting = New Logic.FinaSetting(session)
  End Sub
  Overrides Sub InitializeData()
    session.ReloadChangedObjects()
    If Tipe = InputType.Tambah Then
      instance = New Persistent.Pinjaman(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}

      MyBase.InitializeData()
      txtKontak.EditValue = Nothing
      txtKontakNama.Text = ""
      txtRegionalNama.Text = ""
      If Not txtTanggal.EditValue Is Nothing Then
        instance.Tanggal = txtTanggal.DateTime
      Else
        txtTanggal.DateTime = Now
      End If
      If Not txtRegional.EditValue Is Nothing Then
        instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      Else
        txtRegional.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
      End If
      txtMataUang.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtMataUang)
      txtBiaya.EditValue = 0.0
      txtNilaiHutang.EditValue = 0
      txtTermin.EditValue = 0
      ChangeCode()
      Me.Text = "Loan Administration: Tambah"
    Else
      xGrid.DataSource = Nothing
      instance = session.GetObjectByKey(Of Persistent.Pinjaman)(Convert.ToInt64(IdToEdit))
      instance.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}
      txtKontak.EditValue = instance.Kontak
      txtTanggal.EditValue = instance.Tanggal
      txtNoTransaksi.Text = instance.Kode
      txtRegional.EditValue = instance.Regional
      txtUraian.EditValue = instance.Keterangan
      txtMataUang.EditValue = instance.MataUang
      txtTanggalAwal.EditValue = instance.TanggalAwal
      txtNilaiHutang.EditValue = instance.JumlahPinjaman
      txtTermin.EditValue = instance.Termin
      txtBiaya.EditValue = instance.Biaya
      Me.Text = "Loan Administration: Edit - " & instance.Kode
    End If
    xGrid.DataSource = instance.Detail
  End Sub
  Overrides Sub LoadAfterInitialize()
  End Sub
  Overrides Sub SimpanData()
    Try
      HitungCicilan(CDec(txtNilaiHutang.EditValue), CInt(txtTermin.EditValue), CDec(txtBiaya.EditValue))

      If Not txtKontak.EditValue Is Nothing Then
        instance.Kontak = CType(txtKontak.EditValue, Persistent.Kontak)
      End If
      instance.Tanggal = txtTanggal.DateTime
      instance.Kode = txtNoTransaksi.Text
      If Not txtRegional.EditValue Is Nothing Then
        instance.Regional = CType(txtRegional.EditValue, NPO.Modules.ModSys.Regional)
      End If
      instance.Keterangan = txtUraian.Text
      If Not txtMataUang.EditValue Is Nothing Then
        instance.MataUang = CType(txtMataUang.EditValue, Persistent.MataUang)
      End If
      instance.TanggalAwal = txtTanggalAwal.DateTime
      instance.JumlahPinjaman = CDec(txtNilaiHutang.EditValue)
      instance.Termin = CShort(txtTermin.EditValue)
      instance.Biaya = CDec(txtBiaya.EditValue)

      '======= Simpan instance
      session.CommitChanges()
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
      Case -5 : txtMataUang.Focus()
      Case -6 : txtNilaiHutang.Focus()
      Case -7 : txtTermin.Focus()
      Case -8 : txtBiaya.Focus()
      Case -9 : txtTanggalAwal.Focus()
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
    instance.Akun = Nothing

    Dim nomor As Core.Modules.NumberResult = instance.Number.GetNewNumber
    'txtNoTransaksi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
    'txtNoTransaksi.Properties.Mask.EditMask = nomor.Mask
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
  Private Sub txtMataUang_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtMataUang.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Dim item As Persistent.MataUang = CType(e.NewValue, Persistent.MataUang)
      Dim eMask As String = item.Simbol & " {0:" & setting.NumericFormatToString & "}"

      Dim info As Globalization.CultureInfo = CType(My.Application.Culture.Clone, Globalization.CultureInfo)   'New Globalization.CultureInfo("en-GB") 'CType(txtNilai.Properties.Mask.Culture.Clone, Globalization.CultureInfo)
      info.NumberFormat.CurrencySymbol = item.Simbol & " "
      txtNilaiHutang.Properties.Mask.Culture = info
      txtNilaiHutang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
      txtNilaiHutang.Properties.Mask.EditMask = "c" & setting.FormatDigit
      txtNilaiHutang.Properties.Mask.UseMaskAsDisplayFormat = True
      colPokok.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
      colPokok.DisplayFormat.FormatString = eMask
      colPokok.SummaryItem.DisplayFormat = eMask
      colBiaya.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
      colBiaya.DisplayFormat.FormatString = eMask
      colBiaya.SummaryItem.DisplayFormat = eMask
      colSisa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
      colSisa.DisplayFormat.FormatString = eMask
      colCicilan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
      colCicilan.DisplayFormat.FormatString = eMask
      colCicilan.SummaryItem.DisplayFormat = eMask
    End If
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
        txtTanggalAwal.EditValue = txtTanggal.DateTime
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
  Private Sub txtRefreshNomor_Click(sender As Object, e As EventArgs) Handles txtRefreshNomor.Click
    ChangeCode()
  End Sub

  Private Sub HitungCicilan(Hutang As Decimal, Termin As Integer, Biaya As Decimal)
    Using splashManager As New DevExpress.XtraSplashScreen.SplashScreenManager(Nothing, GetType(Core.Win.Forms.WaitForm), True, True)
      splashManager.ShowWaitForm()
      splashManager.SetWaitFormCaption("Silahkan Tunggu")
      splashManager.SetWaitFormDescription("Proses Hitung Cicilan ...")

      For i = instance.Detail.Count - 1 To 0 Step -1
        instance.Detail(i).Delete()
      Next
      MsgBox("OKCOY :" & Hutang.ToString("n2") & " ~ " & Termin.ToString("n2") & " ~ " & Biaya.ToString("n2"))
      If Hutang = Nothing OrElse Termin = Nothing OrElse Biaya = Nothing Then
        splashManager.CloseWaitForm()
        Exit Sub
      End If
      Dim item As Persistent.PinjamanDetail
      Dim pokokCicilan As Decimal = Hutang / Termin
      Dim biayaCicilan As Decimal = pokokCicilan * (Biaya / 100)
      Dim sisa As Decimal = Hutang

      For i = 1 To Termin
        item = New Persistent.PinjamanDetail(session)
        item.Urutan = CShort(i)
        item.JatuhTempo = txtTanggalAwal.DateTime.AddMonths(i)
        item.Pokok = pokokCicilan
        item.Biaya = biayaCicilan
        sisa -= pokokCicilan
        item.Sisa = sisa
        instance.Detail.Add(item)
      Next

      splashManager.CloseWaitForm()
    End Using
  End Sub

  Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
    HitungCicilan(CDec(txtNilaiHutang.EditValue), CInt(txtTermin.EditValue), CDec(txtBiaya.EditValue))
  End Sub
End Class