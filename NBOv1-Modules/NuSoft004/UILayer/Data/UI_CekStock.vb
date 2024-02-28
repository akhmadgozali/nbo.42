Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraPivotGrid
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Imports NuSoft.Core.SSystem
Public Class UI_CekStock
  Private setting As NuSoft001.Logic.FinaSetting
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub FirstLoad()
    Dim settingitem As Logic.ItemSetting
    session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
    setting = New NuSoft001.Logic.FinaSetting(session)
    colQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQtyIn.DisplayFormat.FormatString = setting.NumericFormatString
    colQtyOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colQtyOut.DisplayFormat.FormatString = setting.NumericFormatString
    colStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colStock.DisplayFormat.FormatString = setting.NumericFormatString
    lyLokasi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    settingitem = New Logic.ItemSetting(session)
    colCustom1.Caption = settingitem.CustomItem1
    colCustom2.Caption = settingitem.CustomItem2
    colCustom3.Caption = settingitem.CustomItem3
    colCustom4.Caption = settingitem.CustomItem4
    colCustom5.Caption = settingitem.CustomItem5

    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("cekstock.xml")) = True Then
      xGridStockView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("cekstock.xml"))
    End If
  End Sub
  Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
    Dim DataLokasi As New DevExpress.Xpo.XPCollection(Of Persistent.BarangLokasi)(session, getCriteria)

    Dim DataTransaksi As New XPCollection(Of Persistent.StockDetail)(session, getCriteria)

    xGridStock.DataSource = Nothing
    session.DropIdentityMap()

    Dim b = From z In DataTransaksi Group z By z.Gudang, z.Barang Into Group Select Barang, Gudang, QtyIn = Group.Sum(Function(x) x.QtyIn), QtyOut = Group.Sum(Function(x) x.QtyOut), Stock = Group.Sum(Function(x) x.QtyIn - x.QtyOut)

    xGridLokasi.DataSource = Nothing
    xGridLokasi.DataSource = DataLokasi

    xGridStock.DataSource = b

    'cmdHistory.Glyph.Save("c:\temp\history.png")

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
  Private Sub CheckEdit1_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles CheckEdit1.EditValueChanging
    If CType(e.NewValue, Boolean) = True Then
      lyLokasi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
    Else
      lyLokasi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End If
  End Sub
  Private Sub xGridStockView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridStockView.ColumnWidthChanged
    xGridStockView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("cekstock.xml"))
  End Sub
  Private Sub btnCetakData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCetakData.ItemClick
    printGrid(xGridStock)
  End Sub
  Private Sub cmdHistory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdHistory.ItemClick
    If Not xGridStockView.DataSource Is Nothing Then
      Dim KodeBarang As String = xGridStockView.GetFocusedRowCellDisplayText(colKode)
      Dim KodeGudang As String = xGridStockView.GetFocusedRowCellDisplayText(colGudangKode)
      Dim frm As New UI_CekStockHistory(KodeBarang, KodeGudang, session)
      frm.session = session
      frm.MenuId = Me.MenuId
      frm.NamaDatabase = Me.NamaDatabase
      frm.ShowDialog()
    End If
  End Sub
  Private Sub btnHistoryHPP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHistoryHPP.ItemClick
    If Not xGridStockView.DataSource Is Nothing Then
      Dim KodeBarang As String = xGridStockView.GetFocusedRowCellDisplayText(colKode)
      Dim KodeGudang As String = xGridStockView.GetFocusedRowCellDisplayText(colGudangKode)
      Dim frm As New UI_CekStockHPP(KodeBarang, KodeGudang, session)
      frm.session = session
      frm.MenuId = Me.MenuId
      frm.NamaDatabase = Me.NamaDatabase
      frm.ShowDialog()
    End If
  End Sub
End Class