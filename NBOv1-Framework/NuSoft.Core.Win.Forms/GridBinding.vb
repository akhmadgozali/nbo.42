Namespace NuSoft.Core.Win.Forms
  Public Class GridBinding
    Protected Friend prive As NPO.NonPersistent.MenuPrivileges
    Private deletedObject As New List(Of Object)

    Property NeedDelete() As Boolean
    Property NeedInsert() As Boolean

    Overridable Sub GridInitNewRow(e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)

    End Sub
    Overridable Sub RefreshData()
      xpCol.Reload()
    End Sub
    Overridable Sub SaveData()
      Try
        session.Delete(deletedObject)
        session.Save(xpCol)
        session.CommitChanges()
        Utils.Win.MessageBox.Show("Data berhasil disimpan", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Informasi)
      Catch ex As Exception
        'DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Me.Text, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        Utils.Win.MessageBox.Show(ex.Message, Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      End Try
    End Sub
    Overridable Sub FirstLoad()

    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      If DesignMode Then
        prive = New NPO.NonPersistent.MenuPrivileges With {.Buka = True, .Tambah = True, .Edit = True, .Hapus = True, .Eksport = True, .Cetak = True}
      Else
        prive = Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase)
      End If
      If NeedInsert() Then
        If prive.Tambah Then
          xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Else
          xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        End If
      Else
        xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
      End If
      xGridView.OptionsBehavior.Editable = prive.Edit
      If NeedDelete() Then
        AddHandler xGrid.ProcessGridKey, AddressOf xGrid_ProcessGridKey
      Else
        barText.Caption = ""
      End If
      barMenuExcel.Enabled = prive.Eksport
      barMenuPrint.Enabled = prive.Cetak

      FirstLoad()
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
      Core.Win.Component.XtraGrid.ExportExcel(xGrid, session, Me.Text)
    End Sub
    Private Sub barMenuPrint_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuPrint.ItemClick
      Core.Win.Component.XtraGrid.PrintPreview(xGrid, session, Me.Text)
    End Sub

    Private Sub xGrid_ProcessGridKey(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
      If e.KeyCode = Windows.Forms.Keys.Delete AndAlso e.Control Then
        If prive.Hapus Then
          If xGridView.FocusedRowHandle >= 0 Then
            xGridView.DeleteRow(xGridView.FocusedRowHandle)
          End If
        Else
          DevExpress.XtraEditors.XtraMessageBox.Show("Anda tidak dapat menghapus data ini.", "Hapus " & Me.Text, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
        End If
      End If
    End Sub
    Private Sub xGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles xGridView.InitNewRow
      GridInitNewRow(e)
    End Sub

    Private Sub xpCol_CollectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpo.XPCollectionChangedEventArgs) Handles xpCol.CollectionChanged
      If e.CollectionChangedType = DevExpress.Xpo.XPCollectionChangedType.AfterRemove Then
        deletedObject.Add(e.ChangedObject)
      End If
    End Sub
    Private Sub xpCol_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpCol.ResolveSession
      e.Session = GetSession()
    End Sub

    Protected Friend Function GetSession() As DevExpress.Xpo.Session
      If Not session.IsConnected Then
        If UseDbSystem Then
          session = Data.DbSystem.GetXPOSession
        Else
          session = Data.DbClient.GetXPOSession(NamaDatabase)
        End If
      End If

      Return session
    End Function
  End Class
End Namespace