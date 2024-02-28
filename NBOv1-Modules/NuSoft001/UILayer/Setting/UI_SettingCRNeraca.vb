Friend Class UI_SettingCRNeraca
  Private deletedObjectA As New List(Of Object)
  Private deletedObjectP As New List(Of Object)
  Private Const OrderFieldName As String = "Urutan"

  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
		persistent.CustomReportMain.AutoSaveOnEndEdit = False
	End Sub
	Overrides Sub SetPrivileges()
		If PrivilegesAdd Then
			xGridViewA.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
			xGridViewP.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
		Else
			xGridViewA.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
			xGridViewP.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
		End If

		xGridViewA.OptionsBehavior.Editable = PrivilegesEdit
		xGridViewP.OptionsBehavior.Editable = PrivilegesEdit

		If PrivilegesDelete Then
			AddHandler xGridA.ProcessGridKey, AddressOf xGrid_ProcessGridKey
			AddHandler xGridP.ProcessGridKey, AddressOf xGrid_ProcessGridKey
		Else
			barText.Caption = ""
		End If

		barMenuExcel.Enabled = PrivilegesExport
		barMenuPrint.Enabled = PrivilegesPrint
	End Sub

	Overridable Sub RefreshData()
		xpAktiva.Reload()
		xpPassiva.Reload()
	End Sub
	Overridable Sub SaveData()
		Try
			session.Delete(deletedObjectA)
			session.Delete(deletedObjectP)
			session.Save(xpAktiva)
			session.Save(xpPassiva)
      session.CommitChanges()
      Utils.Win.MessageBox.Show("Data berhasil disimpan", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
		Catch ex As Exception
			Utils.Win.MessageBox.Show(ex.Message, Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
		End Try
	End Sub

	Private Sub xGrid_ProcessGridKey(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
		If e.KeyCode = Windows.Forms.Keys.Delete AndAlso e.Control Then
			Dim penerima As DevExpress.XtraGrid.GridControl = CType(sender, DevExpress.XtraGrid.GridControl)
			Dim x As DevExpress.XtraGrid.Views.Grid.GridView = Nothing

			If penerima Is xGridA Then
				x = xGridViewA
			End If
			If penerima Is xGridP Then
				x = xGridViewP
			End If

			If PrivilegesDelete Then
				If x.FocusedRowHandle >= 0 Then
					x.DeleteRow(x.FocusedRowHandle)
				End If
			Else
				DevExpress.XtraEditors.XtraMessageBox.Show("Anda tidak dapat menghapus data ini.", "Hapus " & Me.Text, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
			End If
		End If
	End Sub

	Private Sub barMenuRefresh_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuRefresh.ItemClick
		RefreshData()
	End Sub
	Private Sub barMenuSave_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuSave.ItemClick
		SaveData()
	End Sub
	Private Sub barMenuCancel_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuCancel.ItemClick
		Me.Close()
	End Sub
	Private Sub barMenuExcel_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuExcel.ItemClick
		If xGridA.IsFocused Then
			MyBase.exportToExcel(xGridA)
		End If
		If xGridP.IsFocused Then
			MyBase.exportToExcel(xGridP)
		End If
	End Sub
	Private Sub barMenuPrint_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuPrint.ItemClick
		If xGridA.IsFocused Then
			MyBase.printGrid(xGridA)
		End If
		If xGridP.IsFocused Then
			MyBase.printGrid(xGridP)
		End If
	End Sub

	Private Sub xp_CollectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpo.XPCollectionChangedEventArgs) Handles xpAktiva.CollectionChanged, xpPassiva.CollectionChanged
		If e.CollectionChangedType = DevExpress.Xpo.XPCollectionChangedType.AfterRemove Then
			If sender Is xpAktiva Then
				deletedObjectA.Add(e.ChangedObject)
			End If
			If sender Is xpPassiva Then
				deletedObjectP.Add(e.ChangedObject)
			End If
		End If
	End Sub
	Private Sub xp_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpAktiva.ResolveSession, xpPassiva.ResolveSession
		If Not session.IsConnected Then
			session = Data.DbClient.GetXPOSession(NamaDatabase)
		End If
		e.Session = session
	End Sub

	Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridViewA.InitNewRow, xGridViewP.InitNewRow
		Dim penerima As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)

		penerima.SetRowCellValue(e.RowHandle, "Kode", penerima.RowCount + 1)
		penerima.SetRowCellValue(e.RowHandle, "Urutan", penerima.RowCount + 1)
		If penerima Is xGridViewA Then
			penerima.SetRowCellValue(e.RowHandle, "Tipe", persistent.CustomReportTipe.NeracaAktiva)
		End If
		If penerima Is xGridViewP Then
			penerima.SetRowCellValue(e.RowHandle, "Tipe", persistent.CustomReportTipe.NeracaPassiva)
		End If
		penerima.SetRowCellValue(e.RowHandle, "CashFlowTanda", persistent.CustomReportTandaCashFlow.Plus)
	End Sub

	Private Sub btnAUp_Click(sender As System.Object, e As System.EventArgs) Handles btnAUp.Click, btnPUp.Click
		Dim view As DevExpress.XtraGrid.Views.Grid.GridView = xGridViewA
		If CType(sender, DevExpress.XtraEditors.SimpleButton).Name = "btnPUp" Then
			view = xGridViewP
		End If

		view.GridControl.Focus()
		Dim index As Integer = view.FocusedRowHandle
		If index <= 0 Then
			Return
		End If

		Dim obj1 As Persistent.CustomReportMain = CType(view.GetRow(index), Persistent.CustomReportMain)
		Dim obj2 As Persistent.CustomReportMain = CType(view.GetRow(index - 1), Persistent.CustomReportMain)
		Dim val1 As Short = obj1.Urutan
		Dim val2 As Short = obj2.Urutan
		obj1.Urutan = val2
		obj2.Urutan = val1

		view.FocusedRowHandle = index - 1
	End Sub
	Private Sub btnADown_Click(sender As Object, e As System.EventArgs) Handles btnADown.Click, btnPDown.Click
		Dim view As DevExpress.XtraGrid.Views.Grid.GridView = xGridViewA
		If CType(sender, DevExpress.XtraEditors.SimpleButton).Name = "btnPDown" Then
			view = xGridViewP
		End If

		view.GridControl.Focus()
		Dim index As Integer = view.FocusedRowHandle
		If index >= view.DataRowCount - 1 Then
			Return
		End If

		Dim obj1 As Persistent.CustomReportMain = CType(view.GetRow(index), Persistent.CustomReportMain)
		Dim obj2 As Persistent.CustomReportMain = CType(view.GetRow(index + 1), Persistent.CustomReportMain)
		Dim val1 As Short = obj1.Urutan
		Dim val2 As Short = obj2.Urutan
		obj1.Urutan = val2
		obj2.Urutan = val1

		view.FocusedRowHandle = index + 1
	End Sub

	Private Sub colNamaRepo_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles colNamaRepo.ButtonClick
		Dim item As Persistent.CustomReportMain = CType(xGridViewA.GetFocusedRow, Persistent.CustomReportMain)
		Dim exceptItem As Persistent.CustomReportMain = Nothing
		Dim exceptCoa As New List(Of Persistent.Coa)

		If xGridViewA.IsNewItemRow(xGridViewA.FocusedRowHandle) Then
			Return
		End If
		If item.Level = persistent.CustomReportLevel.DETAIL OrElse item.Level = persistent.CustomReportLevel.DETAIL OrElse item.Level = persistent.CustomReportLevel.SALDOAKHIR OrElse item.Level = persistent.CustomReportLevel.SALDOAWAL OrElse item.Level = persistent.CustomReportLevel.SALDOKHUSUS Then
			Using frm As New UI_SettingCRAkun() With {.session = session}
				frm.IdToEdit = item
				frm.Tipe = Core.Win.Forms.InputBase.InputType.Edit
				frm.TipeCR = persistent.CustomReportTipe.NeracaAktiva

				For i = 0 To xpAktiva.Count - 1
					exceptItem = CType(xpAktiva(i), persistent.CustomReportMain)
					If Not exceptItem Is item Then
						If exceptItem.Level = item.Level Then
							For j = 0 To exceptItem.Detail.Count - 1
								exceptCoa.Add(exceptItem.Detail(j).Akun)
							Next
						End If
					End If
				Next

				frm.NotShowCoa = exceptCoa
				frm.ShowDialog()
			End Using
		End If
	End Sub
	Private Sub colPNamaRepo_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles colPNamaRepo.ButtonClick
		Dim item As Persistent.CustomReportMain = CType(xGridViewP.GetFocusedRow, Persistent.CustomReportMain)
		Dim exceptItem As Persistent.CustomReportMain = Nothing
		Dim exceptCoa As New List(Of Persistent.Coa)

		If xGridViewP.IsNewItemRow(xGridViewP.FocusedRowHandle) Then
			Return
		End If
		If item.Level = persistent.CustomReportLevel.DETAIL OrElse item.Level = persistent.CustomReportLevel.DETAIL OrElse item.Level = persistent.CustomReportLevel.SALDOAKHIR OrElse item.Level = persistent.CustomReportLevel.SALDOAWAL OrElse item.Level = persistent.CustomReportLevel.SALDOKHUSUS Then
			Using frm As New UI_SettingCRAkun() With {.session = session}
				frm.IdToEdit = item
				frm.Tipe = Core.Win.Forms.InputBase.InputType.Edit
				frm.TipeCR = persistent.CustomReportTipe.NeracaPassiva

				For i = 0 To xpPassiva.Count - 1
					exceptItem = CType(xpPassiva(i), persistent.CustomReportMain)
					If Not exceptItem Is item Then
						If exceptItem.Level = item.Level Then
							For j = 0 To exceptItem.Detail.Count - 1
								exceptCoa.Add(exceptItem.Detail(j).Akun)
							Next
						End If
					End If
				Next

				frm.NotShowCoa = exceptCoa
				frm.ShowDialog()
			End Using
		End If
	End Sub

  Private Sub xGridP_Click(sender As Object, e As EventArgs) Handles xGridP.Click

  End Sub
End Class