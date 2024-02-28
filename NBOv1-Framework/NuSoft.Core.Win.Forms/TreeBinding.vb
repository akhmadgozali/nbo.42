Namespace NuSoft.Core.Win.Forms
  Public Class TreeBinding
    Private prive As NPO.NonPersistent.MenuPrivileges

    Overridable Sub RefreshData()
      xpCol.Reload()
    End Sub
    Overridable Sub SaveData()
      Try
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
      xTree.OptionsBehavior.Editable = prive.Edit
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
      Core.Win.Component.XtraTreeList.ExportExcel(xTree, session, Me.Text)
    End Sub
    Private Sub barMenuPrint_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuPrint.ItemClick
      Core.Win.Component.XtraTreeList.PrintPreview(xTree, session, Me.Text)
    End Sub

    Private Sub xpCol_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpCol.ResolveSession
      If Not session.IsConnected Then
        If UseDbSystem Then
          session = Data.DbSystem.GetXPOSession
        Else
          session = Data.DbClient.GetXPOSession(NamaDatabase)
        End If
      End If
      e.Session = session
    End Sub
  End Class
End Namespace