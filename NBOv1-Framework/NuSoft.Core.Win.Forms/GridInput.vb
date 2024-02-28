Namespace NuSoft.Core.Win.Forms
  Public Class GridInput
    Private prive As NPO.NonPersistent.MenuPrivileges
    Private deletedObject As New List(Of Object)
    Protected Friend KeyField As String
    Protected Friend useFeedbackSource As Boolean
    Protected Friend baseView As DevExpress.XtraGrid.Views.Base.BaseView = xGridView
    Protected Friend allowAdd As Boolean = True
    Protected Friend allowEdit As Boolean = True
    Protected Friend allowDelete As Boolean = True
    Protected Friend useMDIforDialog As Boolean = False
    Protected Friend showFilter As Boolean
    Protected Friend ActivateToolTip As Boolean
    Protected Friend fixCriteria As String

    Sub New()
      ' This call is required by the designer.
      InitializeComponent()
      ' Add any initialization after the InitializeComponent() call.
      barMan.SetPopupContextMenu(xGrid, popMenu)
    End Sub
    Overridable Sub GridViewRowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs)

    End Sub
    Overridable Sub GridViewRowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)

    End Sub
    Overridable Sub GridViewCustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs)

    End Sub
    Overridable Sub GridViewRowLoaded(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowEventArgs)

    End Sub
    Overridable Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)

    End Sub
    Overridable Sub RefreshData()
			If Not useFeedbackSource Then
				session.Disconnect()
				xpCol.Reload()
			Else
				ifSource.Refresh()
      End If
    End Sub
    Overridable Sub FirstLoad()

    End Sub
    Overridable Function GetDialogForm() As InputBase
      Return Nothing
    End Function
    Overridable Function GetFilterForm() As InputFilter
      Return New YearMonthFilter("Tahun", "Bulan")
    End Function
    Overridable Function HapusData(ByVal selectedData As List(Of GridDeletedData)) As Boolean
      Return False
    End Function
    Overridable Function GetKeteranganHapus(ByVal selectedRows As Integer()) As List(Of GridDeletedData)
      Return Nothing
    End Function
    Overridable Function GetToolTipContent(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByVal info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
      Return ""
    End Function
    Overridable Function GetToolTipTitle(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByVal info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As String
      Return ""
    End Function
    Protected Friend Sub TambahData()
      Dim frm As InputBase = GetDialogForm()

      frm.NamaDatabase = NamaDatabase
      frm.MenuId = MenuId
      frm.Tipe = InputBase.InputType.Tambah

      If useMDIforDialog Then
        frm.session = Data.DbClient.GetXPOSession(NamaDatabase)
        frm.OwnerMDI = Me
        frm.ShowMDI()
      Else
        frm.session = session
        frm.Owner = Me
        frm.ShowDialog()
        RefreshData()
      End If
    End Sub
    Protected Friend Sub EditData()
      If baseView.RowCount < 1 Then
        Exit Sub
      End If

      Dim idToEdit As Object = Nothing

      If TypeOf (baseView) Is DevExpress.XtraGrid.Views.Grid.GridView Then
        Dim viewGrid As DevExpress.XtraGrid.Views.Grid.GridView = CType(baseView, DevExpress.XtraGrid.Views.Grid.GridView)
        If viewGrid.IsGroupRow(viewGrid.FocusedRowHandle) OrElse viewGrid.IsAsyncInProgress OrElse Not viewGrid.IsRowLoaded(viewGrid.FocusedRowHandle) Then
          Exit Sub
        End If
        idToEdit = viewGrid.GetFocusedRowCellDisplayText(KeyField)
      ElseIf TypeOf (baseView) Is DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView Then
        Dim viewGrid As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = CType(baseView, DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)
        If viewGrid.IsGroupRow(viewGrid.FocusedRowHandle) OrElse viewGrid.IsAsyncInProgress OrElse Not viewGrid.IsRowLoaded(viewGrid.FocusedRowHandle) Then
          Exit Sub
        End If
        idToEdit = viewGrid.GetFocusedRowCellDisplayText(KeyField)
      End If

      If Not idToEdit Is Nothing Then
        Dim frm As InputBase = GetDialogForm()
        frm.NamaDatabase = NamaDatabase
        frm.MenuId = MenuId
        frm.session = session
        frm.IdToEdit = idToEdit
        frm.Tipe = InputBase.InputType.Edit

        If useMDIforDialog Then
          frm.OwnerMDI = Me
          frm.ShowMDI()
        Else
          frm.Owner = Me
          frm.ShowDialog()
          RefreshData()
        End If
      End If
    End Sub
    Protected Friend Sub HapusData()
      Dim xText As String = String.Format("Apakah anda ingin menghapus {0} ?", Me.Text)
      Dim x As Integer() = Nothing

      If baseView.RowCount < 1 Then
        Exit Sub
      End If

      If TypeOf (baseView) Is DevExpress.XtraGrid.Views.Grid.GridView Then
        Dim viewGrid As DevExpress.XtraGrid.Views.Grid.GridView = CType(baseView, DevExpress.XtraGrid.Views.Grid.GridView)
        If viewGrid.IsGroupRow(viewGrid.FocusedRowHandle) Then
          Exit Sub
        End If
        x = viewGrid.GetSelectedRows
      ElseIf TypeOf (baseView) Is DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView Then
        Dim viewGrid As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView = CType(baseView, DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)
        If viewGrid.IsGroupRow(viewGrid.FocusedRowHandle) Then
          Exit Sub
        End If
        x = viewGrid.GetSelectedRows
      End If

      Dim note As List(Of GridDeletedData) = GetKeteranganHapus(x)
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

      If ActivateToolTip Then
        AddHandler toolTip.GetActiveObjectInfo, AddressOf toolTipJurnal_GetActiveObjectInfo
      End If

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
      Core.Win.Component.XtraGrid.ExportExcel(xGrid, session, Me.Text)
    End Sub
    Private Sub barMenuPrint_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuPrint.ItemClick
      Core.Win.Component.XtraGrid.PrintPreview(xGrid, session, Me.Text)
    End Sub
    Private Sub barMenuFilter_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuFilter.ItemClick
      Dim frm As InputFilter = GetFilterForm()
      Dim fix As String = ""
      Dim criteria As String = ""

      If fixCriteria <> "" Then
        fix = fixCriteria & " And "
        If useFeedbackSource Then
          criteria = ifSource.FixedFilterString.Replace(fix, "")
        Else
          criteria = xpCol.CriteriaString.Replace(fix, "")
        End If
      Else
        If useFeedbackSource Then
          criteria = ifSource.FixedFilterString
        Else
          criteria = xpCol.CriteriaString
        End If
      End If

      frm.CriteriaString = criteria
      If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
        SetCriteria(frm.CriteriaString)
      End If
    End Sub
    Private Sub xGrid_DoubleClick(sender As Object, e As System.EventArgs) Handles xGrid.DoubleClick
      If allowEdit Then
        EditData()
      End If
    End Sub
    Private Sub xGridView_ColumnFilterChanged(sender As Object, e As System.EventArgs) Handles xGridView.ColumnFilterChanged
      xGridView.ExpandAllGroups()
    End Sub
    Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
      GridViewColumnWidthChanged(sender, e)
    End Sub
    Private Sub xGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles xGridView.CustomColumnDisplayText
      GridViewCustomColumnDisplayText(sender, e)
    End Sub
    Private Sub xGridView_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles xGridView.RowCellStyle
      GridViewRowCellStyle(sender, e)
    End Sub
    Private Sub xGridView_RowLoaded(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowEventArgs) Handles xGridView.RowLoaded
      GridViewRowLoaded(sender, e)
    End Sub
    Private Sub xGridView_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles xGridView.RowStyle
      GridViewRowStyle(sender, e)
    End Sub

    Private Sub xpCol_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpCol.ResolveSession
      If Not useFeedbackSource Then
				e.Session = GetSession()
      End If
    End Sub
    Private Sub ifSource_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles ifSource.ResolveSession
      If useFeedbackSource Then
				e.Session = GetSession()
      End If
    End Sub

    Private Sub toolTipJurnal_GetActiveObjectInfo(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs)
      If e.Info Is Nothing AndAlso e.SelectedControl Is xGrid Then
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(xGrid.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = view.CalcHitInfo(e.ControlMousePosition)
        If info.InRow AndAlso Not view.IsGroupRow(info.RowHandle) Then
          Dim cellKey As String = info.RowHandle.ToString()
          Dim a As New DevExpress.Utils.ToolTipControlInfo
          Dim s As New DevExpress.Utils.SuperToolTip
          Dim i As New DevExpress.Utils.ToolTipItem
          Dim content As String = GetToolTipContent(view, info)

          If content = "" Then
            Exit Sub
          End If
          i.Font = New Drawing.Font("Courier New", 8.5, Drawing.FontStyle.Regular)
          i.Text = content

          s.Items.Add(i)
          s.Items.AddSeparator()
          s.Items.AddTitle(GetToolTipTitle(view, info))
          s.MaxWidth = 50000

          a.Object = cellKey
          a.SuperTip = s
          e.Info = a
        End If
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

    Protected Friend Function GetSession() As DevExpress.Xpo.UnitOfWork
      If Not session.IsConnected Then
        If UseDbSystem Then
          session = Data.DbSystem.GetXPOSession
        Else
          session = Data.DbClient.GetXPOSession(NamaDatabase)
        End If
      End If

      Return session
    End Function
    Protected Friend Sub SetCriteria(criteria As String)

      Dim criteriaX As String
      If fixCriteria <> "" Then
        criteriaX = fixCriteria & " And " & criteria
      Else
        criteriaX = criteria
      End If
      If useFeedbackSource Then
        ifSource.FixedFilterString = criteriaX
      Else
        xpCol.CriteriaString = criteriaX
      End If
    End Sub

    Private Sub barMan_QueryShowPopupMenu(sender As Object, e As DevExpress.XtraBars.QueryShowPopupMenuEventArgs) Handles barMan.QueryShowPopupMenu
      If (TypeOf (e.Control) Is DevExpress.XtraGrid.GridControl) Then
        Dim grid As DevExpress.XtraGrid.GridControl = CType(e.Control, DevExpress.XtraGrid.GridControl)
        'Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(grid.KeyboardFocusView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(grid.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = view.CalcHitInfo(grid.PointToClient(e.Position))
        e.Cancel = info.InColumnPanel Or info.InGroupPanel
      End If
    End Sub

    Public Sub CallInputDialog(menuCode As String, ValueId As Object, psession As DevExpress.Xpo.UnitOfWork)
      If psession Is Nothing Then
        Throw New Exception("Masukkan session.")
      End If
      If ValueId Is Nothing Then
        Throw New Exception("Masukkan value.")
      End If
      If menuCode = Nothing Then
        Throw New Exception("Masukkan kode menu.")
      End If

      Dim x = Core.SSystem.User.GetPrivilegesMenu(menuCode, psession.Connection.Database)
      If x.Buka AndAlso x.Edit Then
        Dim frm As InputBase = GetDialogForm()
        frm.NamaDatabase = psession.Connection.Database
        'frm.MenuId = MenuId
        frm.session = psession
        frm.IdToEdit = ValueId
        frm.Tipe = InputBase.InputType.Edit

        If useMDIforDialog Then
          frm.OwnerMDI = Me
          frm.ShowMDI()
        Else
          frm.Owner = Me
          frm.ShowDialog()
          RefreshData()
        End If
      End If
    End Sub
  End Class

  Public Structure GridDeletedData
    Public Row As Integer
    Public Data As String
  End Structure
End Namespace