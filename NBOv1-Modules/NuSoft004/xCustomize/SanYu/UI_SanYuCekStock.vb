Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraPivotGrid
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Imports NuSoft.Core.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent

Public Class UI_SanYuCekStock
  Private setting As NuSoft001.Logic.FinaSetting
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub FirstLoad()
    session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
    setting = New NuSoft001.Logic.FinaSetting(session)
    colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQtyIn.DisplayFormat.FormatString = setting.NumericFormatString
    colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQtyOut.DisplayFormat.FormatString = setting.NumericFormatString
    colStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colStock.DisplayFormat.FormatString = setting.NumericFormatString
    lyLokasi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("cekstock.xml")) = True Then
      'xGridStockView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("cekstock.xml"))
    End If
  End Sub
  Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
    Dim DataTransaksi As New XPCollection(Of Persistent.SanYu_StokDetail)(session, getCriteria)

    xGridStock.DataSource = Nothing
    session.DropIdentityMap()

    Dim b = From z In DataTransaksi Group z By z.Barang, z.Gudang Into Group Select Barang, Gudang, QtyIn = Group.Sum(Function(x) x.QtyIn), QtyOut = Group.Sum(Function(x) x.QtyOut), Stock = Group.Sum(Function(x) x.QtyIn - x.QtyOut)
    xGridStock.DataSource = b
  End Sub
  Private Function getCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"
    If Not txtKode.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Barang.Kode", String.Format(format, txtKode.EditValue), BinaryOperatorType.Like))
    End If
    If Not txtNama.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Barang.Nama", String.Format(format, txtNama.EditValue), BinaryOperatorType.Like))
    End If
    Return GroupOperator.And(result)
  End Function

  Private Sub xGridStockView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridStockView.ColumnWidthChanged
    Dim file As String = Logic.Umum.xLokasiLayout("cekstock.xml")
    If System.IO.File.Exists(file) Then
      xGridStockView.SaveLayoutToXml(file)
    End If
  End Sub
  Private Sub btnCetakData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCetakData.ItemClick
    printGrid(xGridStock)
  End Sub
  Private Sub cmdHistory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdHistory.ItemClick
    If Not xGridStockView.DataSource Is Nothing Then
      Dim KodeBarang As String = xGridStockView.GetFocusedRowCellDisplayText(colKode)
      Dim frm As New UI_SanyuCekStockHistory(KodeBarang, session)
      frm.session = session
      frm.MenuId = Me.MenuId
      frm.NamaDatabase = Me.NamaDatabase
      frm.ShowDialog()
    End If
  End Sub
End Class