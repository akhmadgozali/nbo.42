Namespace NuSoft.Core.Win.Forms
  Public Class BlankForm
    Private prive As NPO.NonPersistent.MenuPrivileges

    ReadOnly Property PrivilegesAdd As Boolean
      Get
        Return prive.Tambah
      End Get
    End Property
    ReadOnly Property PrivilegesEdit As Boolean
      Get
        Return prive.Edit
      End Get
    End Property
    ReadOnly Property PrivilegesDelete As Boolean
      Get
        Return prive.Hapus
      End Get
    End Property
    ReadOnly Property PrivilegesExport As Boolean
      Get
        Return prive.Eksport
      End Get
    End Property
    ReadOnly Property PrivilegesPrint As Boolean
      Get
        Return prive.Cetak
      End Get
    End Property

    Overridable Sub FirstLoad()

    End Sub
    Overridable Sub SetPrivileges()

    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      If DesignMode Then
        prive = New NPO.NonPersistent.MenuPrivileges With {.Buka = True, .Tambah = True, .Edit = True, .Hapus = True, .Eksport = True, .Cetak = True}
      Else
        prive = Core.SSystem.User.GetPrivilegesMenu(MenuId, NamaDatabase)
      End If

      SetPrivileges()
      FirstLoad()
    End Sub

    Protected Friend Sub exportToExcel(grid As DevExpress.XtraGrid.GridControl)
      Core.Win.Component.XtraGrid.ExportExcel(grid, session, Me.Text)
    End Sub
    Protected Friend Sub printGrid(grid As DevExpress.XtraGrid.GridControl)
      Core.Win.Component.XtraGrid.PrintPreview(grid, session, Me.Text)
    End Sub

    Sub ShowMDI()
      NUI.Win.Connector.OpenFormInMDI(Me)
    End Sub
  End Class
End Namespace