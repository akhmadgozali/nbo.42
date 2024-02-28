Public Class UI_Setting
  Private item As Logic.InventorySetting
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeUsedComponent()
    GetSession()
    item = New Logic.InventorySetting(session)
  End Sub
  Overrides Sub InitializeData()
    txtLockProduksi.Checked = item.LockProduksi
    txtPermintaan.EditValue = item.UraianPermintaan
    txtMutasi.EditValue = item.UraianMutasi
    txtPenyesuaian.EditValue = item.UraianPenyesuaian
    txtStockOpname.EditValue = item.UraianStockOpname
    txtProduksi.EditValue = item.UraianProduksi
		txtPemakaianBarang.EditValue = item.UraianPemakaianBarang
		chkPreview.Checked = item.PreviewSave
		chkOpenCOAAll.Checked = item.SettingCOAAll
		chkLockSettingCOA.Checked = item.KunciSettingCOA
		txtGudang1.EditValue = item.Gudang1
    txtGudang2.EditValue = item.Gudang2
    txtGudangProduksi.EditValue = item.GudangProduksi
  End Sub
  Private Sub xp_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpColTipeKontak.ResolveSession, xpCOA.ResolveSession, xpUang.ResolveSession, xpPajak.ResolveSession, xpGudang.ResolveSession
    e.Session = GetSession()
  End Sub
  Overrides Sub Btn1Click()
    item.LockProduksi = txtLockProduksi.Checked
    item.UraianPermintaan = txtPermintaan.Text
    item.UraianMutasi = txtMutasi.Text
    item.UraianPenyesuaian = txtPenyesuaian.Text
    item.UraianStockOpname = txtStockOpname.Text
    item.UraianProduksi = txtProduksi.Text
		item.UraianPemakaianBarang = txtPemakaianBarang.Text
		item.PreviewSave = chkPreview.Checked
		item.SettingCOAAll = chkOpenCOAAll.Checked
		item.KunciSettingCOA = chkLockSettingCOA.Checked

		item.Gudang1 = CInt(txtGudang1.EditValue)
    item.Gudang2 = CInt(txtGudang2.EditValue)
    item.GudangProduksi = CInt(txtGudangProduksi.EditValue)
    item.Save()
    session.Save(xpUang)
    session.CommitChanges()
    Utils.Win.MessageBox.Show("Data sudah tersimpan.", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
  End Sub
  Overrides Sub ErrorBtn1Click(ByVal ex As Utils.Exception)
    MyBase.ErrorBtn1Click(ex)
  End Sub
End Class