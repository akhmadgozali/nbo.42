Friend Class zWoojin_SettingBrankas
  Private item As Logic.FinaSetting
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
    Btn2IsClosedButton = True
  End Sub
  Overrides Sub InitializeData()
    item = New Logic.FinaSetting(session)
    txtN1.EditValue = item.zWoojinBrankas1
    txtN2.EditValue = item.zWoojinBrankas2
    txtN3.EditValue = item.zWoojinBrankas3
    txtN4.EditValue = item.zWoojinBrankas4
    txtN5.EditValue = item.zWoojinBrankas5
    txtN6.EditValue = item.zWoojinBrankas6
    txtN7.EditValue = item.zWoojinBrankas7
    txtN8.EditValue = item.zWoojinBrankas8
    txtN9.EditValue = item.zWoojinBrankas9
    txtN10.EditValue = item.zWoojinBrankas10
    txtN11.EditValue = item.zWoojinBrankas11
    txtN12.EditValue = item.zWoojinBrankas12
    txtN13.EditValue = item.zWoojinBrankas13
    txtN14.EditValue = item.zWoojinBrankas14
    txtN15.EditValue = item.zWoojinBrankas15
    txtN16.EditValue = item.zWoojinBrankas16
    txtN17.EditValue = item.zWoojinBrankas17
    txtN18.EditValue = item.zWoojinBrankas18
    txtN19.EditValue = item.zWoojinBrankas19
    txtN20.EditValue = item.zWoojinBrankas20
    txtN21.EditValue = item.zWoojinBrankas21
    txtN22.EditValue = item.zWoojinBrankas22
    txtN23.EditValue = item.zWoojinBrankas23
    txtN24.EditValue = item.zWoojinBrankas24
    txtN25.EditValue = item.zWoojinBrankas25
  End Sub
  Overrides Sub Btn1Click()
    item.zWoojinBrankas1 = txtN1.EditValue.ToString
    item.zWoojinBrankas2 = txtN2.EditValue.ToString
    item.zWoojinBrankas3 = txtN3.EditValue.ToString
    item.zWoojinBrankas4 = txtN4.EditValue.ToString
    item.zWoojinBrankas5 = txtN5.EditValue.ToString
    item.zWoojinBrankas6 = txtN6.EditValue.ToString
    item.zWoojinBrankas7 = txtN7.EditValue.ToString
    item.zWoojinBrankas8 = txtN8.EditValue.ToString
    item.zWoojinBrankas9 = txtN9.EditValue.ToString
    item.zWoojinBrankas10 = txtN10.EditValue.ToString
    item.zWoojinBrankas11 = txtN11.EditValue.ToString
    item.zWoojinBrankas12 = txtN12.EditValue.ToString
    item.zWoojinBrankas13 = txtN13.EditValue.ToString
    item.zWoojinBrankas14 = txtN14.EditValue.ToString
    item.zWoojinBrankas15 = txtN15.EditValue.ToString
    item.zWoojinBrankas16 = txtN16.EditValue.ToString
    item.zWoojinBrankas17 = txtN17.EditValue.ToString
    item.zWoojinBrankas18 = txtN18.EditValue.ToString
    item.zWoojinBrankas19 = txtN19.EditValue.ToString
    item.zWoojinBrankas20 = txtN20.EditValue.ToString
    item.zWoojinBrankas21 = txtN21.EditValue.ToString
    item.zWoojinBrankas22 = txtN22.EditValue.ToString
    item.zWoojinBrankas23 = txtN23.EditValue.ToString
    item.zWoojinBrankas24 = txtN24.EditValue.ToString
    item.zWoojinBrankas25 = txtN25.EditValue.ToString
    item.Save()
    session.CommitChanges()
    Utils.Win.MessageBox.Show("Data sudah tersimpan.", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
  End Sub
  Overrides Sub ErrorBtn1Click(ByVal ex As Utils.Exception)
    MyBase.ErrorBtn1Click(ex)
  End Sub

End Class