Friend Class UI_TutupBukuDialogOld
  Private sesi As New DevExpress.Xpo.UnitOfWork
  Private bulan, tahun As Integer
	Private xp As DevExpress.Xpo.XPCollection(Of Persistent.Periode)

  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
    Btn2IsClosedButton = True
  End Sub
  Overrides Sub InitializeData()
    GetSesi()
		xp = New DevExpress.Xpo.XPCollection(Of Persistent.Periode)(sesi)
    xp.Sorting.Add(New DevExpress.Xpo.SortProperty("Id", DevExpress.Xpo.DB.SortingDirection.Descending))

    Dim setting As New Logic.FinaSetting(sesi)
    If xp.Count > 0 Then
      If xp(0).Bulan = 12 Then
        bulan = 1
        tahun = xp(0).Tahun + 1
      Else
        bulan = xp(0).Bulan + 1
        tahun = xp(0).Tahun
      End If
    Else
      bulan = setting.AwalPeriodeBulan
      tahun = setting.AwalPeriodeTahun
    End If

    txtBulanIni.Text = MonthName(bulan) & " " & tahun
    If bulan = 12 Then
      txtBulanNext.Text = MonthName(1) & " " & tahun + 1
    Else
      txtBulanNext.Text = MonthName(bulan + 1) & " " & tahun
    End If
  End Sub
  Overrides Sub Btn1Click()
    Try
			Dim item As Persistent.Periode
      If xp.ToList.Exists(Function(m) m.Tahun = tahun AndAlso m.Bulan = bulan) Then
        item = xp.Single(Function(m) m.Tahun = tahun AndAlso m.Bulan = bulan)
      Else
				item = New Persistent.Periode(sesi)
        item.Bulan = bulan
        item.Tahun = tahun
      End If
      item.Kunci = True
      item.Save()

      'If bulan = 12 Then
      '  Dim frm As New Exp_Process_SaldoLaba(sesi, tahun)
      '  frm.Proses(False)
      'End If

      Utils.Win.MessageBox.Show("Proses tutup buku selesai.", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
    Catch ex As Exception
      DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Me.Text, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub GetSesi()
    If Not sesi.IsConnected Then
      sesi = Data.DbClient.GetXPOSession(NamaDatabase)
    End If
  End Sub
End Class