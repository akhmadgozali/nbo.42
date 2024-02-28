Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraPivotGrid
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Imports NuSoft.Core.SSystem
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors
Imports System.Windows.Forms

Public Class UI_NishiCekStock
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
    txtPelanggan.Properties.DataSource = New XPCollection(Of NuSoft001.Persistent.Kontak)(session)
    txtJenis.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(NuSoft004.Persistent.NishiTipeBarangJO))
    settingitem = New Logic.ItemSetting(session)

    txtJenis.EditValue = NuSoft004.Persistent.NishiTipeBarangJO.Coil
    setLayout(NuSoft004.Persistent.NishiTipeBarangJO.Coil)
  End Sub
  Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
    Dim DataTransaksi As New XPCollection(Of Persistent.NishiStockDetail)(session, getCriteria)

    xGridCoil.DataSource = Nothing
    xGridSteel.DataSource = Nothing

    'MsgBox("Record : " & DataTransaksi.Count & "-->" & getCriteria.ToString)

    If CType(txtJenis.EditValue, Persistent.NishiTipeBarangJO) = Persistent.NishiTipeBarangJO.Coil Then
      xGridCoil.DataSource = DataTransaksi
      xGridCoilView.ActiveFilterString = "[QtySisa]>0"
    Else
      xGridSteel.DataSource = DataTransaksi
      xGridSteelView.ActiveFilterString = "[QtySisa]>0"
    End If
    'cmdHistory.Glyph.Save("c:\temp\history.png")
  End Sub
  Private Function getCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"
    If Not txtPelanggan.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Main.Pelanggan.Id", CType(txtPelanggan.EditValue, NuSoft001.Persistent.Kontak).Id, BinaryOperatorType.Equal))
    End If
    result.Add(New BinaryOperator("Main.JobOrder.TipeBarangJO", CType(txtJenis.EditValue, Persistent.NishiTipeBarangJO), BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("Main.Sumber", Persistent.SumberDataJenis.GR, BinaryOperatorType.Equal))
    Return GroupOperator.And(result)
  End Function
  Private Sub xGridStockView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridCoilView.ColumnWidthChanged
    Logic.Umum.xSaveLayoutGrid(xGridCoilView, "CekStockCoil.xml")
  End Sub
  Private Sub xGridSteelView_ColumnWidthChanged(sender As Object, e As ColumnEventArgs) Handles xGridSteelView.ColumnWidthChanged
    Logic.Umum.xSaveLayoutGrid(xGridCoilView, "CekStockSteel.xml")
  End Sub
  Private Sub btnCetakData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCetakData.ItemClick
    printGrid(xGridCoil)
  End Sub
  Private Sub setLayout(Jenis As NuSoft004.Persistent.NishiTipeBarangJO)
    If Jenis = Persistent.NishiTipeBarangJO.Steel Then
      lytSteel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
      lytCoil.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
      lytStockCase.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
      btnStockCase.Visible = True
    Else
      lytSteel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
      lytCoil.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
      lytStockCase.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
      btnStockCase.Visible = False
    End If
  End Sub
  Private Sub txtJenis_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtJenis.EditValueChanging
    setLayout(CType(e.NewValue, Persistent.NishiTipeBarangJO))
  End Sub
  Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
    If CType(txtJenis.EditValue, Persistent.NishiTipeBarangJO) = Persistent.NishiTipeBarangJO.Steel Then
      NuSoft.Core.Win.Component.XtraGrid.ExportExcel(xGridSteel, session, "Data Stock Steel")
    Else
      NuSoft.Core.Win.Component.XtraGrid.ExportExcel(xGridCoil, session, "Data Stock Steel")
    End If
  End Sub
  Private Sub btnStockCase_Click(sender As Object, e As EventArgs) Handles btnStockCase.Click
    If Not xGridSteelView.DataSource Is Nothing Then
      If txtPelanggan.EditValue Is Nothing Then
        XtraMessageBox.Show("Pilih customer terlebih dahulu.", "Stock Case", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
      End If
      'Dim KodeBarang As String = xGridStockView.GetFocusedRowCellDisplayText(colKode)
      Dim frm As New UI_NishiCekStockCase(CType(txtPelanggan.EditValue, NuSoft001.Persistent.Kontak), session)
      frm.session = session
      frm.MenuId = Me.MenuId
      frm.NamaDatabase = Me.NamaDatabase
      frm.ShowDialog()

    End If
  End Sub

  Private Sub txtJenis_EditValueChanged(sender As Object, e As EventArgs) Handles txtJenis.EditValueChanged

  End Sub
End Class