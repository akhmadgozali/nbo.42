Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Windows.Forms

Public Class UI_FusohDataProduksiSJ
  Private setting As NuSoft001.Logic.FinaSetting, pIDProduksi As Int64, pKodeBarang As String, pNoProduksi As String
  Private _dataSource As List(Of Persistent.Fusoh_StokDetail)

  Sub New(zID As Int64, xSession As DevExpress.Xpo.UnitOfWork, zKodeBarang As String, zNoProduksi As String)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    session = xSession
    pIDProduksi = zID
    pKodeBarang = zKodeBarang
    pNoProduksi = zNoProduksi
    Me.Text = "Data SJ --> " & zKodeBarang
  End Sub
  Overrides Sub FirstLoad()
    setting = New NuSoft001.Logic.FinaSetting(session)
    'xGrid.DataSource = New XPCollection(Of Persistent.Fusoh_StokDetail)(session, New GroupOperator(GroupOperator.And, New BinaryOperator("Barang.Kode", pKodeBarang, BinaryOperatorType.Equal), New BinaryOperator("QtyOut", 0, BinaryOperatorType.Greater)))

    'xGridView.ActiveFilterCriteria = New BinaryOperator("ProduksiDetail.Main.Kode", pNoProduksi, BinaryOperatorType.Equal)

    ''isikan kode produksinya
    'colKodeProduksiRepo.DataSource = New XPCollection(Of Persistent.Fusoh_StokDetail)(session, New GroupOperator(GroupOperator.And, New BinaryOperator("Barang.Kode", pKodeBarang, BinaryOperatorType.Equal), New BinaryOperator("QtyIn", 0, BinaryOperatorType.Greater)))

    _dataSource = New XPQuery(Of Persistent.Fusoh_StokDetail)(session).Where(Function(f) f.Barang.Kode = pKodeBarang AndAlso f.QtyOut > 0 AndAlso f.ProduksiDetail.Main.Kode = pNoProduksi).ToList()
    Dim produksiYgAda = _dataSource.Select(Function(s) s.ProduksiDetail).ToList()
    Dim dataProduksiYgBelumNol = New XPQuery(Of Persistent.FusohVwProduksi)(session).Where(Function(f) f.KodeItem = pKodeBarang).Select(Function(s) s.Id).ToList()
    If (Not dataProduksiYgBelumNol.Contains(pIDProduksi)) Then dataProduksiYgBelumNol.Add(pIDProduksi) 'Tambah existing produksi jika belum ada

    colKodeProduksiRepo.DataSource = New XPQuery(Of Persistent.Fusoh_StokDetail)(session) _
      .Where(Function(f) dataProduksiYgBelumNol.Contains(f.Id)).ToList()

    xGrid.DataSource = _dataSource
  End Sub
  Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
    session.CommitTransaction()
    Me.DialogResult = DialogResult.OK
  End Sub
  Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
    session.RollbackTransaction()
    Me.DialogResult = DialogResult.Cancel
  End Sub
  Private Sub btnDuplicate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDuplicate.ItemClick
    Dim Data As Persistent.Fusoh_StokDetail = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.Fusoh_StokDetail)
    Dim xDetail As New Persistent.Fusoh_StokDetail(session)
    xDetail.Main = Data.Main
    xDetail.Gudang = Data.Gudang
    xDetail.Barang = Data.Barang
    xDetail.Satuan = Data.Satuan
    xDetail.Harga = Data.Harga
    xDetail.InDiameter = Data.InDiameter
    xDetail.OutDiameter = Data.OutDiameter
    xDetail.Thickness = Data.Thickness
    xDetail.Length = Data.Length
    xDetail.Weight = Data.Weight
    xDetail.QtyOut = 1
    xDetail.ProduksiDetail = Data.ProduksiDetail
    xDetail.SODetail = Data.SODetail
    xDetail.Catatan = "Split AM"

    xGrid.BeginUpdate()
    _dataSource.Add(xDetail)
    xGrid.RefreshDataSource()
    xGrid.EndUpdate()
  End Sub
End Class