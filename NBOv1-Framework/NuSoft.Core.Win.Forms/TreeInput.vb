Namespace NuSoft.Core.Win.Forms
  Public Class TreeInput
    Private prive As NPO.NonPersistent.MenuPrivileges
    Private deletedObject As New List(Of Object)
    Protected Friend KeyField As String
    Protected Friend useFeedbackSource As Boolean
    Protected Friend allowAdd As Boolean = True
    Protected Friend allowEdit As Boolean = True
    Protected Friend allowDelete As Boolean = True
    Protected Friend showFilter As Boolean

    Sub New()
      ' This call is required by the designer.
      InitializeComponent()
      ' Add any initialization after the InitializeComponent() call.
      barMan.SetPopupContextMenu(xTree, popMenu)
    End Sub
    Overridable Sub RefreshData()
      If Not useFeedbackSource Then
        xpCol.Reload()
      Else
        ifSource.Refresh()
      End If
    End Sub
    Overridable Sub FirstLoad()

    End Sub
    Overridable Function GetDialogForm() As InputDialog
      Return Nothing
    End Function
    Overridable Function GetFilterForm() As InputFilter
      Return New YearMonthFilter("Tahun", "Bulan")
    End Function
    Overridable Function HapusData(ByVal selectedRows As List(Of TreeDeletedData)) As Boolean
      Return False
    End Function
    Overridable Function GetKeteranganHapus(ByVal selectedRows As DevExpress.XtraTreeList.TreeListMultiSelection) As List(Of TreeDeletedData)
      Return Nothing
    End Function
    Protected Friend Sub TambahData()
      Using frm As InputDialog = GetDialogForm()
        frm.NamaDatabase = NamaDatabase
        frm.MenuId = MenuId
        frm.session = session
        frm.Tipe = InputBase.InputType.Tambah
        'If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
        frm.ShowDialog()
        RefreshData()
        'End If
      End Using
    End Sub
    Protected Friend Sub EditData()
      If xTree.AllNodesCount < 1 Then
        Exit Sub
      End If

      If Not xTree.Selection(0)(KeyField) Is Nothing Then
        Using frm As InputDialog = GetDialogForm()
          frm.NamaDatabase = NamaDatabase
          frm.MenuId = MenuId
          frm.session = session
          frm.IdToEdit = xTree.Selection(0)(KeyField)
          frm.Tipe = InputBase.InputType.Edit
          'If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
          frm.ShowDialog()
          RefreshData()
          'End If
        End Using
      End If
    End Sub
    Protected Friend Sub HapusData()
      Dim xText As String = String.Format("Apakah anda ingin menghapus {0} ?", Me.Text)
      Dim x As DevExpress.XtraTreeList.TreeListMultiSelection = Nothing

      If xTree.AllNodesCount < 1 Then
        Exit Sub
      End If

      x = xTree.Selection
      Dim note As List(Of TreeDeletedData) = GetKeteranganHapus(x)
      If note Is Nothing Then
        Utils.Win.MessageBox.Show("Masukkan keterangan data yang akan dihapus", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
        Exit Sub
      End If

      For i = 0 To note.Count - 1
        xText &= vbCrLf & note(i).Data
      Next
      If Utils.Win.MessageBox.Show(xText, "Hapus " & Me.Text, "", Utils.Win.MessageBox.Button.YaTidak, Utils.Win.MessageBox.Icon.Pertanyaan) = Utils.Win.MessageBox.DialogResult.Ya Then
        If HapusData(note) Then
          RefreshData()
        End If
      End If
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      If DesignMode Then
        prive = New NPO.NonPersistent.MenuPrivileges With {.Buka = True, .Tambah = True, .Edit = True, .Hapus = True, .Eksport = True, .Cetak = True}
      Else
        prive = Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase)
      End If
      barMenuAdd.Enabled = prive.Tambah
      barMenuEdit.Enabled = prive.Edit
      barMenuDelete.Enabled = prive.Hapus
      barMenuExcel.Enabled = prive.Eksport
      barMenuPrint.Enabled = prive.Cetak

      popMenuTambah.Enabled = prive.Tambah
      popMenuEdit.Enabled = prive.Edit
      popMenuHapus.Enabled = prive.Hapus
      popMenuEksport.Enabled = prive.Eksport
      popMenuCetak.Enabled = prive.Cetak

      If Not allowAdd Then
        barMenuAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
      End If
      If Not allowEdit Then
        barMenuEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
      End If
      If Not allowDelete Then
        barMenuDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
      End If
      If Not showFilter Then
        barMenuFilter.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
      End If

      FirstLoad()
    End Sub

    Private Sub barMenuAdd_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuAdd.ItemClick
      TambahData()
    End Sub
    Private Sub barMenuEdit_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuEdit.ItemClick
      EditData()
    End Sub
    Private Sub barMenuDelete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuDelete.ItemClick
      HapusData()
    End Sub
    Private Sub barMenuRefresh_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuRefresh.ItemClick
      RefreshData()
    End Sub
    Private Sub barMenuExcel_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuExcel.ItemClick
      Core.Win.Component.XtraTreeList.ExportExcel(xTree, session, Me.Text)
    End Sub
    Private Sub barMenuPrint_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuPrint.ItemClick
      Core.Win.Component.XtraTreeList.PrintPreview(xTree, session, Me.Text)
    End Sub
    Private Sub barMenuFilter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuFilter.ItemClick
      Dim frm As InputFilter = GetFilterForm()

      frm.CriteriaString = xpCol.CriteriaString
      If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
        xpCol.CriteriaString = frm.CriteriaString
      End If
    End Sub
    Private Sub xTree_DoubleClick(sender As Object, e As System.EventArgs) Handles xTree.DoubleClick
      If allowEdit Then
        EditData()
      End If
    End Sub

    Private Sub xpCol_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpCol.ResolveSession
      If Not useFeedbackSource Then
        If Not session.IsConnected Then
          If UseDbSystem Then
            session = Data.DbSystem.GetXPOSession
          Else
            session = Data.DbClient.GetXPOSession(NamaDatabase)
          End If
        End If
        e.Session = session
      End If
    End Sub
    Private Sub ifSource_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles ifSource.ResolveSession
      If useFeedbackSource Then
        If Not session.IsConnected Then
          If UseDbSystem Then
            session = Data.DbSystem.GetXPOSession
          Else
            session = Data.DbClient.GetXPOSession(NamaDatabase)
          End If
        End If
        e.Session = session
      End If
    End Sub

    Private Sub popMenuTambah_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles popMenuTambah.ItemClick
      barMenuAdd_ItemClick(sender, e)
    End Sub
    Private Sub popMenuEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles popMenuEdit.ItemClick
      barMenuEdit_ItemClick(sender, e)
    End Sub
    Private Sub popMenuHapus_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles popMenuHapus.ItemClick
      barMenuDelete_ItemClick(sender, e)
    End Sub
    Private Sub popMenuEksport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles popMenuEksport.ItemClick
      barMenuExcel_ItemClick(sender, e)
    End Sub
    Private Sub popMenuCetak_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles popMenuCetak.ItemClick
      barMenuPrint_ItemClick(sender, e)
    End Sub

    Private Sub barMan_QueryShowPopupMenu(sender As Object, e As DevExpress.XtraBars.QueryShowPopupMenuEventArgs) Handles barMan.QueryShowPopupMenu
      If (TypeOf (e.Control) Is DevExpress.XtraTreeList.TreeList) Then
        Dim tree As DevExpress.XtraTreeList.TreeList = CType(e.Control, DevExpress.XtraTreeList.TreeList)
        'Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(grid.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim info = tree.CalcHitInfo(tree.PointToClient(e.Position))
        e.Cancel = info.HitInfoType = DevExpress.XtraTreeList.HitInfoType.Column
      End If
    End Sub
  End Class

  Public Structure TreeDeletedData
    Public Row As DevExpress.XtraTreeList.Nodes.TreeListNode
    Public Data As String
  End Structure
End Namespace