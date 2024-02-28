Public Class x_Setting
  Private x As Core.SSystem.FrameworkSetting
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Btn2IsClosedButton = True
    AutoCloseOnSave = True
    UseDbSystem = True
  End Sub
  Public Overrides Sub InitializeData()
    GetSession()  'Data.DbSystem.GetXPOSession
    Me.Icon = My.Resources.NusoftIcon
    x = New Core.SSystem.FrameworkSetting(session)
    txtCheck.Checked = x.LayoutLaporanTerpisah
  End Sub
  Public Overrides Sub Btn1Click()
    x.LayoutLaporanTerpisah = txtCheck.Checked
    x.Save()
    Utils.Win.MessageBox.Show("Setting Framework berhasil disimpan", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
  End Sub
  Public Overrides Sub ErrorBtn1Click(ex As Utils.Exception)
    ex.ShowWinMessageBox()
  End Sub
End Class