Public Class UI_Setting
	Private item As Logic.SalesSetting

	Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeUsedComponent()
    GetSession()
    item = New Logic.SalesSetting(session)
    txtTipeHPP.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.TipeHPP))
    txtPOSPajak.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft005.Persistent.eTipePajak))
    txtPOSGudang.Properties.DataSource = New DevExpress.Xpo.XPCollection(Of NuSoft004.Persistent.Gudang)(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("Setting.xml")) = True Then
      lytSetting.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("Setting.xml"))
    End If
  End Sub
  Overrides Sub InitializeData()
    txtFilterKontak.Checked = item.FilterKontak
    txtTipeKontak.EditValue = item.TipeKontak
    txtPOSGudang.EditValue = item.GudangDefault
    txtMultiSO.Checked = item.MultiSO
    txtTipeHPP.EditValue = CType(item.TipeHPP, Persistent.TipeHPP)
    txtPreview.Checked = item.PreviewSave
    txtSQ.EditValue = item.UraianSQ
    txtSO.EditValue = item.UraianSO
    txtDP.EditValue = item.UraianDP
    txtDO.EditValue = item.UraianDO
    txtIV.EditValue = item.UraianIV
    txtCP.EditValue = item.UraianCP
    txtRAB.EditValue = item.UraianRAB
    txtPenerimaanRetur.EditValue = item.UraianRN
    txtReturPenjualan.EditValue = item.UraianSR
    txtSaldoAwal.EditValue = item.UraianBR
    txtPOS.EditValue = item.UraianQS
		txtUraianRetur.Text = item.UraianRetur
		chkOpenInvoice.Checked = item.OpenPriceInvoice
		chkLockTaxIV.Checked = item.OpenTaxIV
		chkEditIV.Checked = item.OpenPriceIV

		txtCoaPPN.EditValue = item.CoaPPN
    txtCoaPPH.EditValue = item.CoaPPH
    txtCoaBiaya.EditValue = item.CoaBiayaLain
    txtCoaPembulatan.EditValue = item.CoaBiayaPembulatan
    txtCoaAdmin.EditValue = item.CoaAdminBank
    txtCoaPendapatan.EditValue = item.CoaPendapatan
		txtCoaLabaSelisihKurs.EditValue = item.CoaLabaSelisihKurs
		txtCoaRugiSelisihKurs.EditValue = item.CoaRugiSelisihKurs
		txtCoaCustom1.EditValue = item.CoaCustom1
		txtCoaCustom2.EditValue = item.CoaCustom2
    txtCoaCustom3.EditValue = item.CoaCustom3
    txtCoaCustom4.EditValue = item.CoaCustom4
    txtCoaCustom5.EditValue = item.CoaCustom5

    txtCoaPosCash.EditValue = item.POSCOACash
    txtCoaPosDebit.EditValue = item.POSCOADebit
    txtCoaPosKredit.EditValue = item.POSCOACredit
    txtPOSKontak.EditValue = item.POSPelanggan
    txtPOSPajak.EditValue = CType(item.POSPajak, NuSoft005.Persistent.eTipePajak)
    txtPosAddRow.Checked = item.POSAddRowGrid
    chkKodeCombo.Checked = item.POSBarangCombo
    txtCoaPosPendapatan.EditValue = item.POSCoaPendapatan
    txtServerStruk.Text = item.POSServerStruk

    chkSetingRegional.Checked = item.SetingARRegional
    txtBeratPallet.Value = item.FusohBeratPallet
    txtDisc.EditValue = item.DiskonCustomer
    chkAutoUraian.Checked = item.AutoUraian
  End Sub
  Private Sub xp_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpTipeKontak.ResolveSession, xpUang.ResolveSession, xpCOA.ResolveSession, xpKontak.ResolveSession, xpRegional.ResolveSession
    e.Session = GetSession()
  End Sub
  Overrides Sub Btn1Click()
    item.FilterKontak = txtFilterKontak.Checked
    item.TipeKontak = txtTipeKontak.EditValue
    item.GudangDefault = txtPOSGudang.EditValue
    item.KaryawanDefault = txtKaryawanDefault.EditValue
    item.MultiSO = txtMultiSO.Checked
    item.TipeHPP = txtTipeHPP.EditValue
    item.PreviewSave = txtPreview.Checked
    item.OpenPriceInvoice = chkOpenInvoice.Checked
		item.OpenTaxIV = chkLockTaxIV.Checked
		item.OpenPriceIV = chkEditIV.Checked
		item.UraianSQ = txtSQ.EditValue
    item.UraianSO = txtSO.EditValue
    item.UraianDP = txtDP.EditValue
    item.UraianDO = txtDO.EditValue
    item.UraianIV = txtIV.EditValue
    item.UraianCP = txtCP.EditValue
    item.UraianRN = txtPenerimaanRetur.EditValue
    item.UraianSR = txtReturPenjualan.EditValue
    item.UraianBR = txtSaldoAwal.EditValue
    item.UraianQS = txtPOS.EditValue
    item.UraianRAB = txtRAB.EditValue
		item.UraianRetur = txtUraianRetur.Text
		item.CoaPPN = txtCoaPPN.EditValue
		item.CoaPPH = txtCoaPPH.EditValue
    item.CoaBiayaLain = txtCoaBiaya.EditValue
    item.CoaBiayaPembulatan = txtCoaPembulatan.EditValue
    item.CoaAdminBank = txtCoaAdmin.EditValue
    item.CoaPendapatan = txtCoaPendapatan.EditValue
		item.CoaLabaSelisihKurs = txtCoaLabaSelisihKurs.EditValue
		item.CoaRugiSelisihKurs = txtCoaRugiSelisihKurs.EditValue
		item.CoaCustom1 = txtCoaCustom1.EditValue
		item.CoaCustom2 = txtCoaCustom2.EditValue
    item.CoaCustom3 = txtCoaCustom3.EditValue
    item.CoaCustom4 = txtCoaCustom4.EditValue
    item.CoaCustom5 = txtCoaCustom5.EditValue

    item.POSCOACash = txtCoaPosCash.EditValue
    item.POSCOADebit = txtCoaPosDebit.EditValue
    item.POSCOACredit = txtCoaPosKredit.EditValue
    item.POSPelanggan = txtPOSKontak.EditValue
    item.POSPajak = txtPOSPajak.EditValue
    item.POSAddRowGrid = txtPosAddRow.Checked
    item.POSCoaPendapatan = txtCoaPosPendapatan.EditValue
    item.POSBarangCombo = chkKodeCombo.Checked
    item.POSServerStruk = txtServerStruk.Text

    item.SetingARRegional = chkSetingRegional.Checked
    item.FusohBeratPallet = txtBeratPallet.Value
    item.DiskonCustomer = txtDisc.EditValue
    item.AutoUraian = chkAutoUraian.Checked

    item.Save()
		session.Save(xpUang)
		'session.Save(xpRegional)
		session.CommitChanges()
    Utils.Win.MessageBox.Show("Data sudah tersimpan.", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
  End Sub
  Overrides Sub ErrorBtn1Click(ByVal ex As Utils.Exception)
    MyBase.ErrorBtn1Click(ex)
  End Sub
End Class