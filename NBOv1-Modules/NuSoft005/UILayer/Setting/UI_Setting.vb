Public Class UI_Setting
  Private item As Logic.PurchaseSetting
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeUsedComponent()
    GetSession()
    item = New Logic.PurchaseSetting(session)
    txtAuto.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.AutoSearchKontak))
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("Setting.xml")) = True Then
      lytSetting.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("Setting.xml"))
    End If
    txtSettingCOAHutang.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.eTipeHutangInvoice))
  End Sub
  Overrides Sub InitializeData()
    txtFilterKontak.Checked = item.FilterKontak
    txtTipeKontak.EditValue = item.TipeKontak
    txtMultiPO.Checked = item.MultiPO
    txtAuto.EditValue = CType(item.AutoSearchKontak, Persistent.AutoSearchKontak)
    chkPreview.Checked = item.PreviewReport
    txtGudang.EditValue = item.GudangDefault
    txtCoaHutangSementara.EditValue = item.CoaHutangSementara
    txtCoaPPN.EditValue = item.CoaPPN
    txtCoaPPH.EditValue = item.CoaPPH
    txtCoaBiaya.EditValue = item.CoaBiayaLain
    txtCoaPembulatan.EditValue = item.CoaBiayaPembulatan
    txtCoaAdmin.EditValue = item.CoaAdminBank
		txtCoaPendapatan.EditValue = item.CoaPendapatan
		txtSelisihRI.EditValue = item.CoaSelisihRI
		txtRQ.EditValue = item.UraianRQ
    txtPO.EditValue = item.UraianPO
    txtDP.EditValue = item.UraianAP
    txtGR.EditValue = item.UraianGR
    txtRI.EditValue = item.UraianRI
    txtVP.EditValue = item.UraianVP
    txtSettingCOAHutang.EditValue = CType(item.SettingCoaHutang, Persistent.eTipeHutangInvoice)
    txtApprovePO.Checked = item.ApprovalPO
		txtBM.EditValue = item.PajakBM
		chkEditRI.EditValue = item.EditHargaRI
		chkAPRegional.Checked = item.SetingAPRegional
  End Sub
  Private Sub xp_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpColTipeKontak.ResolveSession, xpCOA.ResolveSession, xpUang.ResolveSession, xpRegional.ResolveSession, xpGudang.ResolveSession, xpPajak.ResolveSession
    e.Session = GetSession()
  End Sub
  Overrides Sub Btn1Click()
    item.FilterKontak = txtFilterKontak.Checked
    item.TipeKontak = txtTipeKontak.EditValue
    item.MultiPO = txtMultiPO.Checked
    item.AutoSearchKontak = txtAuto.EditValue
    item.PreviewReport = chkPreview.Checked
    item.GudangDefault = txtGudang.EditValue
    item.CoaHutangSementara = txtCoaHutangSementara.EditValue
    item.CoaPPN = txtCoaPPN.EditValue
    item.CoaPPH = txtCoaPPH.EditValue
    item.CoaBiayaLain = txtCoaBiaya.EditValue
    item.CoaBiayaPembulatan = txtCoaPembulatan.EditValue
    item.CoaAdminBank = txtCoaAdmin.EditValue
		item.CoaPendapatan = txtCoaPendapatan.EditValue
		item.CoaSelisihRI = txtSelisihRI.EditValue
		item.UraianRQ = txtRQ.EditValue
    item.UraianPO = txtPO.EditValue
    item.UraianAP = txtDP.EditValue
    item.UraianGR = txtGR.EditValue
    item.UraianRI = txtRI.EditValue
    item.UraianVP = txtVP.EditValue
    item.SetingAPRegional = chkAPRegional.Checked
    item.SettingCoaHutang = txtSettingCOAHutang.EditValue
    item.ApprovalPO = txtApprovePO.Checked
		item.PajakBM = txtBM.EditValue
		item.EditHargaRI = chkEditRI.EditValue
		item.Save()
    session.Save(xpUang)
    session.Save(xpRegional)
    session.CommitChanges()
    Utils.Win.MessageBox.Show("Data sudah tersimpan.", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
  End Sub
  Overrides Sub ErrorBtn1Click(ByVal ex As Utils.Exception)
    MyBase.ErrorBtn1Click(ex)
  End Sub
End Class