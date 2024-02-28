Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Core.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent

Friend Class UI_PrepaidExpenseDialog
  Private instance As Persistent.PrepaidExpense
  Private mataUangDefault As Integer
	Private isShown As Boolean
	Private editAssign As Boolean = False
	Private sumber As Persistent.SumberDataCollection
  Private setting As Logic.FinaSetting
  Private xpSettingRegional As XPCollection(Of Persistent.SettingRegional)

  Public Sub New()
    InitializeComponent()
    Persistent.PrepaidExpense.AutoSaveOnEndEdit = False
    Persistent.PrepaidDetail.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    sumber = New Persistent.SumberDataCollection(session)
    txtKontak.Properties.DataSource = New XPCollection(Of Persistent.Kontak)(session, New BinaryOperator("Aktif", True))
    txtRegional.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Regional)(session)
    txtDivisi.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(session)
    txtCoaKasBank.Properties.DataSource = Logic.Coa.GetCoa(session, True, New CoaEnum.eKind() {CoaEnum.eKind.Kas, CoaEnum.eKind.Bank})
    txtCoaExpenses.Properties.DataSource = Logic.Coa.GetCoa(session, True, New CoaEnum.eKind() {CoaEnum.eKind.BiayaOperasional})
    txtCoaPrepaid.Properties.DataSource = Logic.Coa.GetCoa(session, True, New CoaEnum.eKind() {CoaEnum.eKind.AktivaLancarLainnya})
    setting = New Logic.FinaSetting(session)
    xpSettingRegional = New XPCollection(Of Persistent.SettingRegional)(session)

    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("PETransaksi.xml")) = True Then
      lytTransaksiPE.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("PETransaksi.xml"))
    End If
  End Sub
  Overrides Sub InitializeData()
		If Tipe = InputType.Tambah Then
			instance = New PrepaidExpense(session)
			instance.Gl = New GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}

			MyBase.InitializeData()

			txtTglMulai.DateTime = Now
			txtTglSelesai.DateTime = Now
			txtNilai.EditValue = 0
			txtUmur.EditValue = 0
			txtNilaiBulan.EditValue = 0
			txtKontak.EditValue = NuSoft.Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtKontak)
			txtRegional.EditValue = NuSoft.Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtRegional)
			txtCoaKasBank.EditValue = NuSoft.Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtCoaKasBank)
			txtCoaPrepaid.EditValue = NuSoft.Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtCoaPrepaid)
			txtCoaExpenses.EditValue = NuSoft.Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtCoaExpenses)
			ChangeCode()
			Me.Text = "Prepaid Expense : Tambah"
		Else
			editAssign = True
			instance = session.GetObjectByKey(Of Persistent.PrepaidExpense)(Convert.ToInt32(IdToEdit))
			txtKontak.EditValue = instance.Gl.Kontak
			txtUraian.EditValue = instance.Gl.Uraian
			txtNilai.EditValue = instance.Nilai
			txtTglMulai.EditValue = instance.TanggalMulai
			txtUmur.EditValue = instance.Umur
			txtDivisi.EditValue = instance.Gl.Detail(0).Divisi
			txtCoaPrepaid.EditValue = instance.CoaPrepaid
			txtCoaExpenses.EditValue = instance.CoaExpense
			txtCoaKasBank.EditValue = instance.CoaKasBank
			txtNoBukti.EditValue = instance.Gl.Kode
			txtRegional.EditValue = instance.Gl.Regional

			'If instance.Detail.Count > 0 Then
			'     If Not instance.Detail(0).Gl Is Nothing Then
			'       DisableControl()
			'     End If
			'   End If
			txtUmur.Properties.ReadOnly = True
			Me.Text = "Prepaid Expense: Edit --> " & instance.Gl.Kode
		End If
		xGrid.DataSource = instance.Detail
		editAssign = False
		SetGrid(CDbl(txtNilai.Text))
	End Sub
  Overrides Sub LoadAfterInitialize()
    Dim setting As New Logic.FinaSetting(session)

    txtNilai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilai.Properties.Mask.EditMask = setting.NumericFormatToString
    txtUmur.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtUmur.Properties.Mask.EditMask = setting.NumericFormatToString
    txtNilaiBulan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilaiBulan.Properties.Mask.EditMask = setting.NumericFormatToString

    colNilai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilai.DisplayFormat.FormatString = setting.NumericFormatString
    colNilai.SummaryItem.DisplayFormat = setting.NumericFormatString
  End Sub

  Overrides Sub SimpanData()
    Try
      instance.Nilai = CDbl(txtNilai.Text)
      instance.TanggalMulai = txtTglMulai.DateTime
      instance.Umur = CShort(txtUmur.Text)
      instance.CoaPrepaid = CType(txtCoaPrepaid.EditValue, Coa)
      instance.CoaExpense = CType(txtCoaExpenses.EditValue, Coa)
      instance.CoaKasBank = CType(txtCoaKasBank.EditValue, Coa)

			'======= Set GL MAIN
			instance.Gl.ModuleId = NPO.Modules.ModuleId.Fina
			instance.Gl.MataUang = instance.CoaKasBank.MataUang.Simbol
      instance.Gl.Kurs = 1
      instance.Gl.Tipe = Persistent.KasBankKeluarTipe.Non
      instance.Gl.Akun = instance.CoaKasBank
      instance.Gl.Kontak = CType(txtKontak.EditValue, Persistent.Kontak)
      instance.Gl.KontakNama = txtKontak.Text
      instance.Gl.Tanggal = txtTglMulai.DateTime
      instance.Gl.Kode = txtNoBukti.Text
      instance.Gl.Uraian = txtUraian.Text
      instance.Gl.CaraBayar = Persistent.BankCaraBayar.Tunai

      SimpanGL(instance.CoaKasBank, 0, 0, instance.Nilai)
			SimpanGL(instance.CoaPrepaid, 1, instance.Nilai, 0)

			'====== set GL penyusutannya
			For pi = 0 To instance.Detail.Count - 1
				If instance.Detail(pi).Gl Is Nothing Then
					instance.Detail(pi).Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
				End If
				instance.Detail(pi).Gl.Sumber = sumber.GetObject(Persistent.SumberDataJenis.AB)
				instance.Detail(pi).Gl.ModuleId = NPO.Modules.ModuleId.Fina
				instance.Detail(pi).Gl.Regional = instance.Gl.Regional
				instance.Detail(pi).Gl.Kontak = CType(txtKontak.EditValue, Persistent.Kontak)
				instance.Detail(pi).Gl.Tanggal = instance.Detail(pi).Tanggal
				instance.Detail(pi).Gl.Uraian = "Amortisasi untuk : " & txtUraian.Text
				SimpanGL2(instance.Detail(pi).Gl, instance.CoaExpense, 0, instance.Detail(pi).Nilai, 0)
				SimpanGL2(instance.Detail(pi).Gl, instance.CoaPrepaid, 1, 0, instance.Detail(pi).Nilai)
			Next

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
      Case -1, -2 : txtNilai.Focus()
      Case -3 : txtTglMulai.Focus()
      Case -4 : txtUmur.Focus()
      Case -5 : txtCoaPrepaid.Focus()
      Case -6 : txtCoaExpenses.Focus()
      Case -7 : txtCoaKasBank.Focus()
      Case -99 : xGrid.Focus()
    End Select
  End Sub
  Private Sub DisableControl()
    EnableVisibleSaveButton(False, False)
  End Sub
  Private Sub txtDivisi_keyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDivisi.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      txtDivisi.EditValue = Nothing
    End If
  End Sub
  Private Sub txtTglMulai_DateTimeChanged(sender As Object, e As EventArgs) Handles txtTglMulai.DateTimeChanged
    Try
      If setting.FormatNomor.Contains(My.Resources.FormatTahun2) OrElse setting.FormatNomor.Contains(My.Resources.FormatTahun4) Then
        If setting.FormatNomor.Contains(My.Resources.FormatBulanR) OrElse setting.FormatNomor.Contains(My.Resources.FormatBulan0) Then
          GantiTanggalBulan()
        Else
          GantiTanggalTahun()
        End If
      End If
    Catch ex As Exception
      If ex.Message.Contains("Object reference not set to an instance") Then
      Else
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Me.Text, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
      End If
    End Try
  End Sub

  Private Sub txtNilai_EditValueChanged(sender As Object, e As EventArgs) Handles txtNilai.EditValueChanged
    If txtNilai.Text <> "" Then
      SetNilaiPerBulan(Nothing, CDbl(txtNilai.Text))
      SetGrid(CDbl(txtNilai.Text))
    End If
  End Sub
  Private Sub txtUmur_EditValueChanged(sender As Object, e As EventArgs) Handles txtUmur.EditValueChanged
    If txtUmur.Text <> "" AndAlso Not txtTglMulai.EditValue Is Nothing Then
      txtTglSelesai.EditValue = CDate(txtTglMulai.EditValue).AddMonths(CInt(txtUmur.Text))
      SetNilaiPerBulan(CInt(txtUmur.Text), Nothing)
      SetGrid(CInt(txtUmur.Text))
    End If
  End Sub

  Private Sub SetTanggalMulai(tanggal As Date)
    txtTglSelesai.EditValue = tanggal.AddMonths(CInt(txtUmur.EditValue))
    SetGrid(tanggal)
  End Sub
  Private Sub SetNilaiPerBulan(Umur As Integer, Nilai As Double)
    If Umur = Nothing Then
      txtNilaiBulan.EditValue = Nilai / CInt(txtUmur.EditValue)
    ElseIf Nilai = Nothing Then
      txtNilaiBulan.EditValue = CDbl(txtNilai.EditValue) / Umur
    End If
  End Sub
  Private Sub SetGrid(tanggalAwal As Date)
    For i = 0 To instance.Detail.Count - 1
      instance.Detail(i).Tanggal = tanggalAwal.AddMonths(i)
    Next
  End Sub
	Private Sub SetGrid(umur As Integer)
		If editAssign = False Then
			If umur > instance.Detail.Count Then
				For i = 0 To umur - 1
					Dim j As Short = CShort(i + 1)
					Dim detail As PrepaidDetail = instance.Detail.ToList.Find(Function(m) m.Urutan = j)
					If detail Is Nothing Then
						detail = New PrepaidDetail(session)
						detail.Urutan = j
						instance.Detail.Add(detail)
					End If
					detail.Nilai = CDbl(txtNilaiBulan.EditValue)
					detail.Tanggal = txtTglMulai.DateTime.AddMonths(i)
				Next
			ElseIf umur < instance.Detail.Count Then
				For i = instance.Detail.Count - 1 To umur Step -1
					instance.Detail(i).Delete()
				Next
			End If
		End If
	End Sub
	Private Sub SetGrid(Nilai As Double)
    For i = 0 To instance.Detail.Count - 1
      instance.Detail(i).Nilai = CDbl(txtNilaiBulan.EditValue)
    Next
  End Sub

  Private Sub txtCoaKasBank_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtCoaKasBank.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Dim item As Coa = CType(e.NewValue, Coa)
      Dim str As String = "Edit CoA akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"
      If Tipe = InputType.Edit AndAlso isShown AndAlso setting.FormatNomor.Contains(My.Resources.FormatAkun) Then
        If Not instance.Gl.Akun Is e.NewValue Then
          If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Akun", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            instance.Gl.Akun = item
            SetSumber(item)
            ChangeCode()
          Else
            e.Cancel = True
          End If
        Else
          instance.Gl.Akun = item
          SetSumber(item)
          ChangeCode()
        End If
      ElseIf Tipe = InputType.Tambah AndAlso (setting.FormatNomor.Contains(My.Resources.FormatAkun) OrElse setting.FormatNomor.Contains(My.Resources.FormatSumber)) Then
        instance.Gl.Akun = item
        SetSumber(item)
        ChangeCode()
      End If
    End If
  End Sub
  Private Sub txtRegional_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtRegional.EditValueChanging
    Dim str As String = "Edit regional transaksi akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"
    Try
      If Tipe = InputType.Edit AndAlso isShown AndAlso setting.FormatNomor.Contains(My.Resources.FormatRegional) Then
        If Not instance.Gl.Regional Is e.NewValue Then
          If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Regional", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            instance.Gl.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
            ChangeCode()
          Else
            e.Cancel = True
          End If
        Else
          instance.Gl.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
          ChangeCode()
        End If
      ElseIf Tipe = InputType.Tambah AndAlso setting.FormatNomor.Contains(My.Resources.FormatRegional) Then
        instance.Gl.Regional = CType(e.NewValue, NPO.Modules.ModSys.Regional)
        ChangeCode()
      End If

      If xpSettingRegional.ToList.Exists(Function(m) m.Regional Is instance.Gl.Regional) Then
        If Not xpSettingRegional.Single(Function(m) m.Regional Is instance.Gl.Regional).AkunKas Is Nothing Then
          txtCoaKasBank.EditValue = xpSettingRegional.Single(Function(m) m.Regional Is instance.Gl.Regional).AkunKas
        End If
      End If
    Catch ex As Exception
      If ex.Message.Contains("Object reference not set to an instance") Then
      ElseIf ex.Message.Contains("Value cannot be null") Then
      Else
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Ganti Regional", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
      End If
    End Try
  End Sub

  Private Sub GantiTanggalTahun()
    Dim str As String = "Edit tanggal dengan tahun berbeda akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"

    If Tipe = InputType.Edit AndAlso isShown Then
      If instance.Gl.Tanggal.Year <> CDate(txtTglMulai.EditValue).Year Then
        If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Tanggal", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
          instance.Gl.Tanggal = txtTglMulai.DateTime
          SetTanggalMulai(txtTglMulai.DateTime)
          ChangeCode()
        Else
          txtTglMulai.EditValue = instance.Gl.Tanggal
        End If
      Else
        instance.Gl.Tanggal = txtTglMulai.DateTime
        SetTanggalMulai(txtTglMulai.DateTime)
        ChangeCode()
      End If
    ElseIf Tipe = InputType.Tambah Then
      instance.Gl.Tanggal = txtTglMulai.DateTime
      SetTanggalMulai(txtTglMulai.DateTime)
      ChangeCode()
    End If
  End Sub
  Private Sub GantiTanggalBulan()
    Dim str As String = "Edit tanggal dengan bulan dan tahun berbeda akan mengganti nomor bukti." & vbCrLf & "Apakah anda ingin meneruskan ?"

    If Tipe = InputType.Edit AndAlso isShown Then
      If instance.Gl.Tanggal.Month <> CDate(txtTglMulai.EditValue).Month OrElse instance.Gl.Tanggal.Year <> CDate(txtTglMulai.EditValue).Year Then
        If DevExpress.XtraEditors.XtraMessageBox.Show(str, "Ganti Tanggal", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
          instance.Gl.Tanggal = txtTglMulai.DateTime
          SetTanggalMulai(txtTglMulai.DateTime)
          ChangeCode()
        Else
          txtTglMulai.EditValue = instance.Gl.Tanggal
        End If
      Else
        instance.Gl.Tanggal = txtTglMulai.DateTime
        SetTanggalMulai(txtTglMulai.DateTime)
        ChangeCode()
      End If
    ElseIf Tipe = InputType.Tambah Then
      instance.Gl.Tanggal = txtTglMulai.DateTime
      SetTanggalMulai(txtTglMulai.DateTime)
      ChangeCode()
    End If
  End Sub
  Private Sub SetSumber(item As Coa)
    If item.Tipe.Parameter = CoaEnum.eParameter.Kas Then
      instance.Gl.Sumber = sumber.GetObject(SumberDataJenis.KK)
    ElseIf item.Tipe.Parameter = CoaEnum.eParameter.Bank Then
      instance.Gl.Sumber = sumber.GetObject(SumberDataJenis.BK)
    End If
  End Sub
  Private Sub ChangeCode()
    If txtTglMulai.EditValue Is Nothing OrElse instance.Gl.Tanggal = Nothing Then
      Return
    End If
    If setting.FormatNomor.Contains(My.Resources.FormatRegional) AndAlso (txtRegional.EditValue Is Nothing OrElse instance.Gl.Regional Is Nothing) Then
      Return
    End If
    If setting.FormatNomor.Contains(My.Resources.FormatAkun) AndAlso (txtCoaKasBank.EditValue Is Nothing OrElse instance.Gl.Akun Is Nothing) Then
      Return
    End If
    If setting.FormatNomor.Contains(My.Resources.FormatSumber) AndAlso instance.Gl.Sumber Is Nothing Then
      Return
    End If

    Dim nomor As Core.Modules.NumberResult = instance.Gl.Number.GetNewNumber
    txtNoBukti.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
    txtNoBukti.Properties.Mask.EditMask = nomor.Mask
    txtNoBukti.Text = nomor.Kode
  End Sub
	Private Sub SimpanGL(Akun As Coa, Urutan As Byte, Debit As Double, Kredit As Double)
		Dim item As Persistent.GlMainDetail
		If instance.Gl.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
			item = instance.Gl.Detail.Single(Function(m) m.Urutan = Urutan)
		Else
			item = New Persistent.GlMainDetail(session)

			item.Akun = Akun
			item.MataUang = item.Akun.MataUang
			item.Main = instance.Gl
			item.Urutan = Urutan
			If Not txtDivisi.EditValue Is Nothing Then
				item.Divisi = CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi)
			End If
			item.Debit = Debit
			item.Kredit = Kredit
			item.Kurs = 1
			item.DebitValas = Debit
			item.KreditValas = Kredit
			instance.Gl.Detail.Add(item)
		End If
	End Sub
	Private Sub SimpanGL2(xGL As GlMain, Akun As Coa, Urutan As Byte, xDebit As Double, xKredit As Double)
		Dim item As Persistent.GlMainDetail
		If xGL.Detail.ToList.Exists(Function(m) m.Urutan = Urutan) Then
			item = xGL.Detail.Single(Function(m) m.Urutan = Urutan)
		Else
			item = New Persistent.GlMainDetail(session)
			xGL.Detail.Add(item)
		End If

		item.Akun = Akun
		item.MataUang = item.Akun.MataUang
		item.Main = xGL
		item.Urutan = Urutan
		If Not txtDivisi.EditValue Is Nothing Then
			item.Divisi = CType(txtDivisi.EditValue, NPO.Modules.ModSys.Divisi)
		End If
		item.Debit = xDebit
		item.Kredit = xKredit
		item.Kurs = 1
	End Sub
End Class