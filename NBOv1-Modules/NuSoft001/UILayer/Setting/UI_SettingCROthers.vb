Friend Class UI_SettingCROthers
  Private xTipe As Persistent.CustomReportTipe

  Overrides Sub GridInitNewRow(e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
    xGridView.SetRowCellValue(e.RowHandle, "Kode", xGridView.RowCount + 1)
    xGridView.SetRowCellValue(e.RowHandle, "Urutan", xGridView.RowCount + 1)
    xGridView.SetRowCellValue(e.RowHandle, "Tipe", xTipe)
    xGridView.SetRowCellValue(e.RowHandle, "CashFlowTanda", persistent.CustomReportTandaCashFlow.Plus)
  End Sub

  Sub New(Tipe As Persistent.CustomReportTipe)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    NeedDelete = True
    NeedInsert = True
    UseDbSystem = False
    persistent.CustomReportMain.AutoSaveOnEndEdit = False
    persistent.CustomReportDetail.AutoSaveOnEndEdit = False

    xTipe = Tipe
    SetTitle(xTipe.ToString)
    colCashFlowTanda.Visible = (xTipe = persistent.CustomReportTipe.CashFlow)
    xpCol.CriteriaString = "Tipe=" & xTipe

    colLevelRepo.Items.Clear()
    colLevelRepo.Items.Add(persistent.CustomReportLevel.HEADER.ToString)
    colLevelRepo.Items.Add(persistent.CustomReportLevel.DETAIL.ToString)
    colLevelRepo.Items.Add(persistent.CustomReportLevel.SUBTOTAL.ToString)
    colLevelRepo.Items.Add(persistent.CustomReportLevel.TOTAL.ToString)

    If xTipe = persistent.CustomReportTipe.CashFlow Then
      colLevelRepo.Items.Add(persistent.CustomReportLevel.SALDOAWAL.ToString)
      colLevelRepo.Items.Add(persistent.CustomReportLevel.SALDOAKHIR.ToString)
      colLevelRepo.Items.Add(persistent.CustomReportLevel.SALDOKHUSUS.ToString)
      colCashFlowTanda.VisibleIndex = 3
    ElseIf xTipe = persistent.CustomReportTipe.LabaRugi Then
      colCashFlowTanda.VisibleIndex = 3
    End If
  End Sub

  Private Sub SetTitle(Title As String)
    lbl.Text = Title
    Me.Text = "Setting " & Title
  End Sub
  Private Sub btnUp_Click(sender As System.Object, e As System.EventArgs) Handles btnUp.Click
    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = xGridView
    view.GridControl.Focus()
    Dim index As Integer = view.FocusedRowHandle
    If index <= 0 Then
      Return
    End If

    Dim obj1 As persistent.CustomReportMain = CType(view.GetRow(index), persistent.CustomReportMain)
    Dim obj2 As persistent.CustomReportMain = CType(view.GetRow(index - 1), persistent.CustomReportMain)
    Dim val1 As Short = obj1.Urutan
    Dim val2 As Short = obj2.Urutan
    obj1.Urutan = val2
    obj2.Urutan = val1

    view.FocusedRowHandle = index - 1
  End Sub
  Private Sub btnDown_Click(sender As Object, e As System.EventArgs) Handles btnDown.Click
    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = xGridView
    view.GridControl.Focus()
    Dim index As Integer = view.FocusedRowHandle
    If index >= view.DataRowCount - 1 Then
      Return
    End If

    Dim obj1 As persistent.CustomReportMain = CType(view.GetRow(index), persistent.CustomReportMain)
    Dim obj2 As persistent.CustomReportMain = CType(view.GetRow(index + 1), persistent.CustomReportMain)
    Dim val1 As Short = obj1.Urutan
    Dim val2 As Short = obj2.Urutan
    obj1.Urutan = val2
    obj2.Urutan = val1

    view.FocusedRowHandle = index + 1
  End Sub

  Private Sub colNamaRepo_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles colNamaRepo.ButtonClick
    Dim item As persistent.CustomReportMain = CType(xGridView.GetFocusedRow, persistent.CustomReportMain)
    Dim exceptItem As persistent.CustomReportMain = Nothing
    Dim exceptCoa As New List(Of persistent.Coa)

    If xGridView.IsNewItemRow(xGridView.FocusedRowHandle) Then
      Return
    End If
    If item.Level = persistent.CustomReportLevel.DETAIL OrElse item.Level = persistent.CustomReportLevel.DETAIL OrElse item.Level = persistent.CustomReportLevel.SALDOAKHIR OrElse item.Level = persistent.CustomReportLevel.SALDOAWAL OrElse item.Level = persistent.CustomReportLevel.SALDOKHUSUS Then
      Using frm As New UI_SettingCRAkun() With {.session = session}
        frm.IdToEdit = item
        frm.Tipe = Core.Win.Forms.InputBase.InputType.Edit
        frm.TipeCR = xTipe

        For i = 0 To xpCol.Count - 1
          exceptItem = CType(xpCol(i), persistent.CustomReportMain)
          If Not exceptItem Is item Then
            If exceptItem.Level = item.Level Then
              For j = 0 To exceptItem.Detail.Count - 1
                exceptCoa.Add(exceptItem.Detail(j).Akun)
              Next
            End If
          End If
        Next

        frm.NotShowCoa = exceptCoa
        'frm.Data = CType(xGrid.DataSource, DevExpress.Xpo.XPCollection(Of persistent.CustomReportMain))
        frm.ShowDialog()
      End Using
    End If
  End Sub
End Class