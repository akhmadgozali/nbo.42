Namespace NuSoft.Core.Win.Forms
  Public Class InputBase
    Friend refreshMode As Boolean

    Enum InputType
      Tambah
      Edit
    End Enum
    Property Tipe As InputType
    Property IdToEdit As Object
    Property AutoCloseOnSave As Boolean
    Property NoDropIdentityMap As Boolean
    Property OwnerMDI As NuSoftForm

    Overridable Sub SimpanData()

    End Sub
    Overridable Sub ErrorSimpan(ByVal ex As Utils.Exception)
      ex.ShowWinExceptionBox()
    End Sub
    Overridable Sub LoadBeforeInitialize()

    End Sub
    Overridable Sub LoadAfterInitialize()

    End Sub
    Overridable Sub InitializeData()
      For Each ctl As Windows.Forms.Control In Me.Controls
        EnumerateControls(ctl)
      Next
    End Sub
    Overridable Sub Quit()
      If Not NoDropIdentityMap Then
        session.DropIdentityMap()
      End If
    End Sub

    Private Sub EnumerateControls(ctrl As System.Windows.Forms.Control)
      If TypeOf ctrl Is DevExpress.XtraEditors.TextEdit Then
        CType(ctrl, DevExpress.XtraEditors.TextEdit).EditValue = Nothing
      ElseIf TypeOf ctrl Is DevExpress.XtraEditors.LookUpEdit Then
        CType(ctrl, DevExpress.XtraEditors.LookUpEdit).EditValue = Nothing
      ElseIf TypeOf ctrl Is DevExpress.XtraEditors.CheckEdit Then
        CType(ctrl, DevExpress.XtraEditors.CheckEdit).Checked = False
      End If

      If ctrl.Controls.Count > 0 Then
        For Each control As System.Windows.Forms.Control In ctrl.Controls
          EnumerateControls(control)
        Next
      End If
    End Sub

    Sub ShowMDI()
      NUI.Win.Connector.OpenFormInMDI(Me)
    End Sub
  End Class
End Namespace