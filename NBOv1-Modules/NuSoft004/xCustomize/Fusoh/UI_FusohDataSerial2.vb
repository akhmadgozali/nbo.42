Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Public Class UI_FusohDataSerial2
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub FirstLoad()
    session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
    txtItem.Properties.DataSource = New XPCollection(Of Persistent.Fusoh_Barang)(session)
  End Sub
  Private Sub cmdFilter_Click(sender As Object, e As EventArgs) Handles cmdFilter.Click
    Dim format As String = "%{0}%"
    If txtItem.EditValue Is Nothing Then
      MsgBox("Silahkan pilih Item", vbOKOnly, "Konfirmasi")
      Return
    End If
    'If txtSerial.Text = "" Then
    '  MsgBox("Silahkan isi nomor serial", vbOKOnly, "Konfirmasi")
    '  Return
    'End If
    Dim DataTransaksi As New XPCollection(Of Persistent.Fusoh_StokSerial)(session, CreateCriteria)

    Dim b = From z In DataTransaksi Group z By z.Serial
                                      Into Group Select Serial, SisaLength = Group.Sum(Function(x) x.LengthIn - x.LengthOut), Qty = Group.Sum(Function(x) x.Qty)

    xGrid.DataSource = New XPCollection(Of Persistent.Fusoh_StokSerial)(session, CreateCriteria)
    gridStockSerial.DataSource = b

    grdDempyou.DataSource = New XPCollection(Of Persistent.Fusoh_OrderProduksiBahanBaku)(session, CreateCriteriaDempyou)


    'Dim xTemp As New XPCollection(Of Persistent.Fusoh_StokSerial)(session, CreateCriteria)
    'xTemp(0).DetailMain.Main.created_date
    'xTemp(0).DetailMain.Main.last_date


    'MsgBox("Tampilkan data")
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BinaryOperator("DetailMain.Barang", CType(txtItem.EditValue, Persistent.Fusoh_Barang), BinaryOperatorType.Equal))

    If txtSerial.Text <> "" Then
      result.Add(New BinaryOperator("Serial", String.Format(format, txtSerial.Text), BinaryOperatorType.Like))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Function CreateCriteriaDempyou() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BinaryOperator("Barang", CType(txtItem.EditValue, Persistent.Fusoh_Barang), BinaryOperatorType.Equal))

    If txtSerial.Text <> "" Then
      result.Add(New BinaryOperator("Serial", String.Format(format, txtSerial.Text), BinaryOperatorType.Like))
    End If
    Return GroupOperator.And(result)
  End Function

  Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
    session.CommitTransaction()
    MsgBox("Simpan sukses")
  End Sub
  Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
    NuSoft.Core.Win.Component.XtraGrid.ExportExcel(xGrid, session, "Data Stock")
  End Sub

	Private Sub btnExport2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport2.ItemClick
		NuSoft.Core.Win.Component.XtraGrid.ExportExcel(gridStockSerial, session, "Data Stock")
	End Sub
End Class