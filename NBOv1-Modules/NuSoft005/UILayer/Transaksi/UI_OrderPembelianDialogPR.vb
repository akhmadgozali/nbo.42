Imports DevExpress.Data.Filtering
Public Class UI_OrderPembelianDialogPR
  Friend itemToEdit As Persistent.OrderPembelian
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
    NoDropIdentityMap = True
  End Sub
  Overrides Sub LoadBeforeInitialize()
    'xGrid.DataSource = New DevExpress.Xpo.XPCollection(Of Persistent.PermintaanStockDetail)(session, New InOperator("StatusTransaksi", New NuSoft001.Persistent.StatusTransaksiEnum() {NuSoft001.Persistent.StatusTransaksiEnum.Posting, NuSoft001.Persistent.StatusTransaksiEnum.InProgress}))
  End Sub
  Overrides Sub SimpanData()
    Dim item As Persistent.OrderPembelianDetail
    If xGridView.SelectedRowsCount = 0 Then
      Throw New Exception("Silahkan pilih data yang ingin diproses")
      Return
    End If
    Dim xID As Int64
    For i = 0 To xGridView.SelectedRowsCount - 1
      If (xGridView.GetSelectedRows()(i) >= 0) Then
        xID = Convert.ToInt64(xGridView.GetRowCellValue(xGridView.GetSelectedRows()(i), "Id").ToString())
        Dim xDataPermintaan As Persistent.PermintaanStockDetail = session.GetObjectByKey(Of Persistent.PermintaanStockDetail)(xID)
        If Not xDataPermintaan Is Nothing Then
          item = New Persistent.OrderPembelianDetail(session)
          item.Main = itemToEdit
          item.Barang = xDataPermintaan.Barang
          item.Qty = xDataPermintaan.Qty
          item.Satuan = xDataPermintaan.Satuan
          item.Harga = xDataPermintaan.Barang.LastPurchase
          item.Discount = 0
          item.PPN = xDataPermintaan.Barang.PajakIN
          item.PPH = xDataPermintaan.Barang.PajakOUT
          item.PPNp = xDataPermintaan.Barang.PajakIN.NilaiPajak
          item.PPHp = xDataPermintaan.Barang.PajakOUT.NilaiPajak
          'MsgBox("jali " & (itemToEdit Is Nothing))
          itemToEdit.Detail.Add(item)
        End If
      End If
    Next
  End Sub
  Private Sub XpCollection1_ResolveSession(sender As Object, e As DevExpress.Xpo.ResolveSessionEventArgs) Handles XpCollection1.ResolveSession
    e.Session = session
  End Sub
End Class