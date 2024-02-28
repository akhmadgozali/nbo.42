Imports NuSoft.Core.SSystem

Public Class UI_FusohBarang
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
    Return New UI_FusohBarangDialog
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
    Dim kodeDelete = ""

    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        Dim item = CType(xGridView.GetRow(selectedData(i).Row), Persistent.Fusoh_Barang)
        kodeDelete &= ", " & item.Kode
        item.Delete()
      End If
    Next
    session.CommitChanges()

    '======= Simple log
    Try
      If kodeDelete <> "" Then
        DatabaseLog.SaveSimpleLog(session, NPO.DatabaseLog.Action.Hapus, "Data Barang ->" & kodeDelete.Substring(1))
        session.CommitChanges()
      End If
    Catch ex As Exception
    End Try
    Return True
  End Function
  Public Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("masteritem.xml"))
  End Sub

  Private Sub btnReset_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReset.ItemClick
    Dim xBarang As New DevExpress.Xpo.XPCollection(Of Persistent.Fusoh_Barang)(session)
    For i = 0 To xBarang.Count - 1
      If xBarang(i).OutDiameter > 0 And xBarang(i).InDiameter > 0 And xBarang(i).Length > 0 And xBarang(i).Thickness > 0 Then
        xBarang(i).Weight = FusohLogic.Item.GetWeight(xBarang(i).OutDiameter, xBarang(i).Length, xBarang(i).Thickness)
      End If
    Next
    session.CommitChanges()
    MsgBox("Proses selesai")
  End Sub
End Class