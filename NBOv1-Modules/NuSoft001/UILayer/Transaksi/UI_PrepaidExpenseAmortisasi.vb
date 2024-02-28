Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Public Class UI_PrepaidExpenseAmortisasi
  Sub simpan()
		Try
			Dim setting = New NuSoft001.Logic.FinaSetting(session)
			Dim sumber = New Persistent.SumberDataCollection(session)
			Dim xData As New XPCollection(Of Persistent.PrepaidDetail)(session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
			'txtKaryawan.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session, New BinaryOperator("TipeKontak.Nama", "Karyawan", BinaryOperatorType.Equal))
			pbProses.Properties.Minimum = 0
			pbProses.Properties.Maximum = xData.Count
			pbProses.Position = 0
			'looping master
			For pi = 0 To xData.Count - 1
				xData(pi).Gl = New Persistent.GlMain(session) With {.Number = New Logic.NumberClass(session) With {.FormatNomor = setting.FormatNomor}}
				xData(pi).Gl.Sumber = sumber.GetObject(Persistent.SumberDataJenis.AB)
			Next





			'for i =1
			'bikin jurnalnya
			'next



		Catch ex As Exception

		End Try
  End Sub
End Class