Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent

Friend Class UI_FusohPenerimaanInvoiceDialogRev01AddItem
  Property Data As Fusoh_PenerimaanInvoiceDetail

  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
  End Sub

  Public Overrides Sub InitializeUsedComponent()
    Dim setting = New NuSoft001.Logic.FinaSetting(session)
    txtKodeBarang.Properties.DataSource = New XPQuery(Of NuSoft004.Persistent.Fusoh_Barang)(session).Where(Function(w) w.TipeBarang = NuSoft004.Persistent.TipeBarang.BahanBaku And w.Aktif = True).ToList
    txtSatuan.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Satuan)(session)
    txtPajakIN.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Pajak)(session)
    txtPajakOut.Properties.DataSource = New XPCollection(Of NuSoft004.Persistent.Pajak)(session)

    'txtWeight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    'txtWeight.Properties.DisplayFormat.FormatString = "n2"
    txtQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    txtQty.Properties.DisplayFormat.FormatString = setting.NumericFormatString
    txtHarga.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    txtHarga.Properties.DisplayFormat.FormatString = setting.NumericFormatString

    txtQty.Properties.MinValue = 0
    txtQty.Properties.MaxValue = Integer.MaxValue
  End Sub
  Public Overrides Sub InitializeData()
    If Data Is Nothing Then
      txtQty.Value = 0
      txtHarga.Value = 0
    Else
      txtKodeBarang.EditValue = Data.Barang
      txtQty.Value = Data.Qty
      txtHarga.Value = Data.Harga
      txtSatuan.EditValue = Data.Satuan
      txtPajakIN.EditValue = Data.PPN
      txtPajakOut.EditValue = Data.PPH
      txtCatatan.Text = Data.Catatan
    End If
  End Sub

  Private Sub txtKodeBarang_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtKodeBarang.EditValueChanging
    If Not e.NewValue Is Nothing Then
      Dim barang = CType(e.NewValue, NuSoft004.Persistent.Fusoh_Barang)
      txtNamaBarang.Text = barang.Nama
      txtOD.Value = barang.OutDiameter
      txtID.Value = barang.InDiameter
      txtL.Value = barang.Length
      txtT.Value = barang.Thickness
      txtSatuan.EditValue = barang.Satuan
      txtHarga.Value = barang.LastPurchase
      txtPajakIN.EditValue = barang.PajakIN
      txtPajakOut.EditValue = barang.PajakOUT
      UpdateWeight()
    End If
  End Sub
  Private Sub txtQty_ValueChanged(sender As Object, e As EventArgs) Handles txtQty.ValueChanged, txtL.ValueChanged
    UpdateWeight()
  End Sub

  Private Sub UpdateWeight()
    If txtQty.Value = 0 Then
      txtWeight.Value = 0
    Else
      txtWeight.Value = NuSoft004.FusohLogic.Item.GetWeight(txtOD.Value, txtL.Value, txtT.Value) * txtQty.Value
    End If
  End Sub

  Public Overrides Sub Btn1Click()
    If txtKodeBarang.EditValue Is Nothing Then Throw New Utils.Exception("Masukkan part no.", -1)
    If txtQty.Value <= 0 Then Throw New Utils.Exception("Masukkan qty.", -2)
    If txtHarga.Value <= 0 Then Throw New Utils.Exception("Masukkan harga.", -3)
    If txtSatuan.EditValue Is Nothing Then Throw New Utils.Exception("Masukkan satuan.", -4)
    If txtPajakIN.EditValue Is Nothing Then Throw New Utils.Exception("Masukkan pajak ppn.", -5)
    If txtPajakOut.EditValue Is Nothing Then Throw New Utils.Exception("Masukkan pajak pph.", -6)

    If Data Is Nothing Then Data = New Fusoh_PenerimaanInvoiceDetail(session)
    Data.Barang = CType(txtKodeBarang.EditValue, NuSoft004.Persistent.Fusoh_Barang)
    Data.OutDiameter = txtOD.Value
    Data.InDiameter = txtID.Value
    Data.Length = txtL.Value
    Data.Thickness = txtT.Value
    Data.Qty = txtQty.Value
    Data.Satuan = CType(txtSatuan.EditValue, NuSoft004.Persistent.Satuan)
    Data.Harga = txtHarga.Value
    Data.DiscountPersen = 0
    Data.Discount = 0
    Data.PPN = CType(txtPajakIN.EditValue, NuSoft004.Persistent.Pajak)
    Data.PPNp = Data.PPN.NilaiPajak
    Data.PPH = CType(txtPajakOut.EditValue, NuSoft004.Persistent.Pajak)
    Data.PPHp = Data.PPH.NilaiPajak
    Data.Catatan = txtCatatan.Text
    Data.KenaImportDuty = Data.Barang.KenaImportDuty
    Data.WeightManual = txtWeight.Value
    Data.HargaKG = Data.Harga / (Data.WeightManual / Data.Qty)
  End Sub
  Public Overrides Sub ErrorBtn1Click(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -1 : txtKodeBarang.Focus()
      Case -2 : txtQty.Focus()
      Case -3 : txtHarga.Focus()
      Case -4 : txtSatuan.Focus()
      Case -5 : txtPajakIN.Focus()
      Case -6 : txtPajakOut.Focus()
    End Select
  End Sub
End Class