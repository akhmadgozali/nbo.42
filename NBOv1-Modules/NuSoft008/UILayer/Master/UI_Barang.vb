Public Class UI_Barang
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
    colCustom1.Caption = settingitem.CustomItem1
    colCustom2.Caption = settingitem.CustomItem2
    colCustom3.Caption = settingitem.CustomItem3
    colCustom4.Caption = settingitem.CustomItem4
    colCustom5.Caption = settingitem.CustomItem5

    colHargaBeli.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHargaBeli.DisplayFormat.FormatString = setting.NumericFormatString
    colHargaJual1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHargaJual1.DisplayFormat.FormatString = setting.NumericFormatString
    colHargaJual2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHargaJual2.DisplayFormat.FormatString = setting.NumericFormatString
    colHargaJual3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHargaJual3.DisplayFormat.FormatString = setting.NumericFormatString
    colHargaJual4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHargaJual4.DisplayFormat.FormatString = setting.NumericFormatString
    colHargaJual5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colHargaJual5.DisplayFormat.FormatString = setting.NumericFormatString
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("masteritem.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("masteritem.xml"))
    End If
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_BarangDialog
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
        CType(xGridView.GetRow(selectedData(i).Row), Persistent.Barang).Delete()
      End If
    Next
    session.CommitChanges()
    Return True
  End Function
  Public Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("masteritem.xml"))
  End Sub
End Class