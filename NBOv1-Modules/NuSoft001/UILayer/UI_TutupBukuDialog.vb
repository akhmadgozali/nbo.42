Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent

Public Class UI_TutupBukuDialog
	Private periode As DateTime

	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		AutoCloseOnSave = True
	End Sub
	Overrides Sub InitializeData()
		If Tipe = InputType.Tambah Then
			periode = GetCurrentPeriode()
			txtPeriode.Text = periode.ToString("MMMM yyyy")
			txtTutupPeriode.Checked = True
		Else
			Dim instance = session.GetObjectByKey(Of Periode)(Convert.ToInt32(IdToEdit))
			periode = New DateTime(instance.Tahun, instance.Bulan, 1)
			txtPeriode.Text = periode.ToString("MMMM yyyy")
			txtTutupPeriode.Checked = instance.Kunci
		End If
	End Sub
	Overrides Sub SimpanData()
		Dim ins As Periode
		If Tipe = InputType.Tambah Then
			ins = New Periode(session) With {.Tahun = periode.Year, .Bulan = periode.Month}
		Else
			ins = session.GetObjectByKey(Of Periode)(Convert.ToInt32(IdToEdit))
		End If
		ins.Kunci = txtTutupPeriode.Checked
		session.CommitChanges()
	End Sub

	Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
		ex.ShowWinMessageBox()
	End Sub

	Private Function GetCurrentPeriode() As Date
		Dim Data = New XPQuery(Of Periode)(session).OrderByDescending(Function(o) o.Tahun).OrderByDescending(Function(o) o.Bulan).ToList()
		If Data.Count <= 0 Then
			Dim setting = New Logic.FinaSetting(session)
			If (setting.AwalPeriodeTahun = 0 OrElse setting.AwalPeriodeBulan = 0) Then
				MsgBox("Periode Awal belum disetting", MsgBoxStyle.Critical, Text)
				Return Nothing
			End If
			Return New DateTime(setting.AwalPeriodeTahun, setting.AwalPeriodeBulan, 1)
		Else
			Return New DateTime(Data(0).Tahun, Data(0).Bulan, 1).AddMonths(1)
		End If
	End Function
End Class
