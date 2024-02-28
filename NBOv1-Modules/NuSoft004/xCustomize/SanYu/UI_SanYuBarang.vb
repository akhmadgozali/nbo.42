Public Class UI_SanYuBarang
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    baseView = xGridView
    KeyField = "Id"
  End Sub
  Public Overrides Sub FirstLoad()
    Dim settingitem As Logic.ItemSetting
    Dim setting As New NuSoft001.Logic.FinaSetting(GetSession)
    settingitem = New Logic.ItemSetting(GetSession)

    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("masteritem.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("masteritem.xml"))
    End If
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_SanYuBarangDialog
  End Function
  Public Overrides Function GetKeteranganHapus(selectedRows() As Integer) As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
    Dim result As New List(Of Core.Win.Forms.GridDeletedData)
    Dim item As Core.Win.Forms.GridDeletedData

    For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
      If Not xGridView.IsGroupRow(selectedRows(i)) Then
        item = New Core.Win.Forms.GridDeletedData
        item.Row = selectedRows(i)
        item.Data = String.Format("{0} - {1}", xGridView.GetRowCellValue(selectedRows(i), "Kode"), xGridView.GetRowCellValue(selectedRows(i), "Nama"))
        result.Add(item)
      End If
    Next
    Return result
  End Function
  Public Overrides Function HapusData(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)) As Boolean
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        CType(xGridView.GetRow(selectedData(i).Row), Persistent.SanYu_Barang).Delete()
      End If
    Next
    session.CommitChanges()
    Return True
  End Function
  Public Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("masteritem.xml"))
  End Sub
  Private Sub btnImporExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImporExcel.ItemClick
    Dim frm As New UI_SanyuBarangImpor()
    Dim xMasterItem As New DevExpress.Xpo.XPCollection(Of Persistent.SanYu_Barang)(session)
    Dim data As Persistent.SanYu_Barang
    frm.session = session
    If frm.ShowDialog = DialogResult.OK Then
      Dim settingitem As New Logic.ItemSetting(session)
      Dim xAkunPersediaan As NuSoft001.Persistent.Coa = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunPersediaan))
      Dim xAkunPendapatan As NuSoft001.Persistent.Coa = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunPendapatan))
      Dim xAkunHPP As NuSoft001.Persistent.Coa = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunHPP))
      Dim xAkunDiscPenjualan As NuSoft001.Persistent.Coa = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunDiscPenjualan))
      Dim xAkunDiscPembelian As NuSoft001.Persistent.Coa = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunDiscPembelian))
      Dim xAkunReturPenjualan As NuSoft001.Persistent.Coa = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunReturPenjualan))
      Dim xAkunReturPembelian As NuSoft001.Persistent.Coa = session.GetObjectByKey(Of NuSoft001.Persistent.Coa)(Convert.ToInt32(settingitem.AkunReturPembelian))
      Dim xPajakIN As Persistent.Pajak = session.GetObjectByKey(Of Persistent.Pajak)(Convert.ToInt32(settingitem.PajakIN))
      Dim xPajakOut As Persistent.Pajak = session.GetObjectByKey(Of Persistent.Pajak)(Convert.ToInt32(settingitem.PajakOut))
      Dim xMataUang As New DevExpress.Xpo.XPCollection(Of NuSoft001.Persistent.MataUang)(session)



      For Each det In frm.SanyuBarangImpor
        data = New Persistent.SanYu_Barang(session)
        data.Kode = det.Kode
        data.Nama = det.Nama
        data.Kategori = det.Kategori
        data.Jenis = det.Jenis
        data.TipeBarang = det.Tipe
        data.Satuan = det.Satuan
        data.Thickness = det.Tebal
        data.InDiameter = det.Lebar
        data.Length = det.Panjang
        data.KITE = det.FasilitasKite
        data.Uang = xMataUang(0)
        data.CoaStock = xAkunPersediaan
        data.CoaIncome = xAkunPendapatan
        data.CoaCost = xAkunHPP
        data.CoaDiscIncome = xAkunDiscPenjualan
        data.CoaDiscOut = xAkunDiscPembelian
        data.CoaReturnIn = xAkunReturPenjualan
        data.CoaReturnOut = xAkunReturPembelian
        data.PajakIN = xPajakIN
        data.PajakOUT = xPajakOut
        data.OutDiameter = 1
        xMasterItem.Add(data)
      Next
    End If
    session.CommitTransaction()
  End Sub
  'Private Sub btnReset_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReset.ItemClick
  '  Dim xBarang As New DevExpress.Xpo.XPCollection(Of Persistent.SanYu_Barang)(session)
  '  For i = 0 To xBarang.Count - 1
  '    If xBarang(i).OutDiameter > 0 And xBarang(i).InDiameter > 0 And xBarang(i).Length > 0 And xBarang(i).Thickness > 0 Then
  '      xBarang(i).Weight = FusohLogic.Item.GetWeight(xBarang(i).OutDiameter, xBarang(i).Length, xBarang(i).Thickness)
  '    End If
  '  Next
  '  session.CommitChanges()
  '  MsgBox("Proses selesai")
  'End Sub
End Class