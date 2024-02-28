Public Class UI_SanYuSetting
  Private item As Logic.SalesSetting
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeUsedComponent()
    GetSession()
    item = New Logic.SalesSetting(session)
  End Sub
  Overrides Sub InitializeData()
    colJenisPenjualanRepo.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eSanYuJenisPenjualan))
  End Sub
  Private Sub xp_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpKontak.ResolveSession
    e.Session = GetSession()
  End Sub
  Overrides Sub Btn1Click()

    session.Save(xpKontak)
    session.CommitChanges()
    Utils.Win.MessageBox.Show("Data sudah tersimpan.", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
  End Sub
  Overrides Sub ErrorBtn1Click(ByVal ex As Utils.Exception)
    MyBase.ErrorBtn1Click(ex)
  End Sub
End Class