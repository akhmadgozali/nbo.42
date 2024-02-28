Friend Class UI_CompanyProfile
	Private item As LogicLayer.Config

  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Btn2IsClosedButton = True
    AutoCloseOnSave = True
  End Sub
  Overrides Sub InitializeData()
		item = New LogicLayer.Config(GetSession)
		xProp.SelectedObject = item
    xProp.BestFit()
  End Sub
  Overrides Sub Btn1Click()
    Try
      item.Save()
			Utils.Win.MessageBox.Show("Data sudah tersimpan.", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
      Me.Close()
    Catch ex As Exception
      Utils.Win.MessageBox.Show(ex.Message)
    End Try
  End Sub

End Class