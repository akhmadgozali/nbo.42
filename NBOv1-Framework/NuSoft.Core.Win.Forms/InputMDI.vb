Namespace NuSoft.Core.Win.Forms
  Public Class InputMDI
    Private _allowSave As Boolean
    Property AllowSave As Boolean
      Get
        Return _allowSave
      End Get
      Set(value As Boolean)
        _allowSave = value
        barMenuSave.Enabled = value
      End Set
    End Property

    Private Sub Me_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
      Quit()
      If refreshMode Then
        RefreshDataOnOwner()
      End If
    End Sub
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      LoadBeforeInitialize()
      InitializeData()
      LoadAfterInitialize()
    End Sub

    Private Sub barMenuSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuSave.ItemClick
      Try
        SimpanData()
        refreshMode = True
        If AutoCloseOnSave Then
          Me.Close()
        Else
          If Tipe = InputType.Edit Then
            Me.Close()
          Else
            InitializeData()
            RefreshDataOnOwner()
          End If
        End If
      Catch ex As Utils.Exception
        ErrorSimpan(ex)
      End Try
    End Sub
    Private Sub barMenuCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barMenuCancel.ItemClick
      If Tipe = InputType.Tambah Then
        InitializeData()
      Else
        Me.Close()
      End If
    End Sub
    Private Sub RefreshDataOnOwner()
      If TypeOf (OwnerMDI) Is NuSoft.Core.Win.Forms.GridInput Then
        CType(OwnerMDI, NuSoft.Core.Win.Forms.GridInput).RefreshData()
      ElseIf TypeOf (OwnerMDI) Is NuSoft.Core.Win.Forms.TreeInput Then
        CType(OwnerMDI, NuSoft.Core.Win.Forms.TreeInput).RefreshData()
      End If
    End Sub
  End Class
End Namespace