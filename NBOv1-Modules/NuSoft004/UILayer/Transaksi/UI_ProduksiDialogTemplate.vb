Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Public Class UI_ProduksiDialogTemplate
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Btn2IsClosedButton = True
    AutoCloseOnSave = True
  End Sub
  Overrides Sub InitializeData()
    txtBarang.Properties.DataSource = New XPCollection(Of Persistent.Barang)(session)
    txtSatuan.Properties.DataSource = New XPCollection(Of Persistent.Satuan)(session)
    txtQty.EditValue = 1
  End Sub
  Overrides Sub Btn1Click()
    'Me.Owner.InitTemplate(ctype(txtBarang.EditValue,persistent.barang), txtQty.EditValue)
    CType(Owner, UI_ProduksiDialog).InitTemplate(CType(txtBarang.EditValue, Persistent.Barang), CDbl(txtQty.EditValue))
  End Sub
  Private Sub txtBarang_EditValueChanged(sender As Object, e As EventArgs) Handles txtBarang.EditValueChanged
    txtSatuan.EditValue = CType(txtBarang.EditValue, Persistent.Barang).Satuan
  End Sub
End Class