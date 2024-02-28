Imports DevExpress.Xpo
Public Class UI_SettingItem
  Private ItemSetting As Logic.ItemSetting
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeUsedComponent()
    Dim xCOA As DevExpress.Xpo.XPCollection(Of NuSoft001.Persistent.Coa)
    GetSession()
    xCOA = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Kas, NuSoft001.Persistent.CoaEnum.eKind.Bank, NuSoft001.Persistent.CoaEnum.eKind.Persediaan, NuSoft001.Persistent.CoaEnum.eKind.Piutang, NuSoft001.Persistent.CoaEnum.eKind.AktivaLancarLainnya, NuSoft001.Persistent.CoaEnum.eKind.AktivaTetap, NuSoft001.Persistent.CoaEnum.eKind.AkumulasiPenyusutan, NuSoft001.Persistent.CoaEnum.eKind.HutangJangkaPanjang, NuSoft001.Persistent.CoaEnum.eKind.HutangJangkaPendek, NuSoft001.Persistent.CoaEnum.eKind.HutangLancarLainnya, NuSoft001.Persistent.CoaEnum.eKind.Modal, NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.PendapatanLainLain, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan, NuSoft001.Persistent.CoaEnum.eKind.BiayaOperasional, NuSoft001.Persistent.CoaEnum.eKind.BiayaLainLain})
    Dim settinginventory As New Logic.InventorySetting(session)

    If settinginventory.SettingCOAAll = True Then
      txtAkunPersediaan.Properties.DataSource = xCOA
      txtAkunPendapatan.Properties.DataSource = xCOA
      txtAkunHPP.Properties.DataSource = xCOA
      txtAkunDiscPenjualan.Properties.DataSource = xCOA
      txtAkunDiscPembelian.Properties.DataSource = xCOA
      txtAkunReturPenjualan.Properties.DataSource = xCOA
      txtAkunReturPembelian.Properties.DataSource = xCOA
    Else
      txtAkunPersediaan.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Persediaan})
      txtAkunPendapatan.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan})
      txtAkunHPP.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
      txtAkunDiscPenjualan.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
      txtAkunDiscPembelian.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
      txtAkunReturPenjualan.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
      txtAkunReturPembelian.Properties.DataSource = NuSoft001.Logic.Coa.GetCoa(session, True, New NuSoft001.Persistent.CoaEnum.eKind() {NuSoft001.Persistent.CoaEnum.eKind.Pendapatan, NuSoft001.Persistent.CoaEnum.eKind.HargaPokokPenjualan})
    End If
    txtPajakIn.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Pajak)(session)
    txtPajakOut.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Pajak)(session)
    ItemSetting = New Logic.ItemSetting(session)
  End Sub
  Overrides Sub InitializeData()
    txtAkunPersediaan.EditValue = ItemSetting.AkunPersediaan
    txtAkunPendapatan.EditValue = ItemSetting.AkunPendapatan
    txtAkunHPP.EditValue = ItemSetting.AkunHPP
    txtAkunDiscPenjualan.EditValue = ItemSetting.AkunDiscPenjualan
    txtAkunDiscPembelian.EditValue = ItemSetting.AkunDiscPembelian
    txtAkunReturPenjualan.EditValue = ItemSetting.AkunReturPenjualan
    txtAkunReturPembelian.EditValue = ItemSetting.AkunReturPembelian
    txtPajakIn.EditValue = ItemSetting.PajakIN
    txtPajakOut.EditValue = ItemSetting.PajakOut

    txtCustom1.EditValue = ItemSetting.CustomItem1
    txtCustom2.EditValue = ItemSetting.CustomItem2
    txtCustom3.EditValue = ItemSetting.CustomItem3
    txtCustom4.EditValue = ItemSetting.CustomItem4
    txtCustom5.EditValue = ItemSetting.CustomItem5
  End Sub
  Overrides Sub Btn1Click()
    ItemSetting.AkunPersediaan = CInt(txtAkunPersediaan.EditValue)
    ItemSetting.AkunPendapatan = CInt(txtAkunPendapatan.EditValue)
    ItemSetting.AkunHPP = CInt(txtAkunHPP.EditValue)
    ItemSetting.AkunDiscPenjualan = CInt(txtAkunDiscPenjualan.EditValue)
    ItemSetting.AkunDiscPembelian = CInt(txtAkunDiscPembelian.EditValue)
    ItemSetting.AkunReturPenjualan = CInt(txtAkunReturPenjualan.EditValue)
    ItemSetting.AkunReturPembelian = CInt(txtAkunReturPembelian.EditValue)
    ItemSetting.PajakIN = CInt(txtPajakIn.EditValue)
    ItemSetting.PajakOut = CInt(txtPajakOut.EditValue)

    ItemSetting.CustomItem1 = txtCustom1.Text
    ItemSetting.CustomItem2 = txtCustom2.Text
    ItemSetting.CustomItem3 = txtCustom3.Text
    ItemSetting.CustomItem4 = txtCustom4.Text
    ItemSetting.CustomItem5 = txtCustom5.Text
    ItemSetting.Save()
    session.CommitChanges()
    Utils.Win.MessageBox.Show("Data sudah tersimpan.", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
  End Sub
  Overrides Sub ErrorBtn1Click(ByVal ex As Utils.Exception)
    MyBase.ErrorBtn1Click(ex)
  End Sub
End Class