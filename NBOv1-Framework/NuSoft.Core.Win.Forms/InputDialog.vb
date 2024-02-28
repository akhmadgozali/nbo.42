Namespace NuSoft.Core.Win.Forms
  Public Class InputDialog
    Sub EnableVisibleSaveButton(ByVal Enable As Boolean, ByVal Visible As Boolean)
      btn1.Enabled = Enable
      btn1.Visible = Visible
    End Sub

    Private Sub Me_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
      btn2_Click(Me, Nothing)
    End Sub
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      LoadBeforeInitialize()
      InitializeData()
      LoadAfterInitialize()
    End Sub

    Private Sub btn1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn1.Click
      Try
        SimpanData()
        If AutoCloseOnSave Then
          refreshMode = True
          Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
          If Tipe = InputType.Edit Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
          Else
            refreshMode = True
            InitializeData()
          End If
        End If
      Catch ex As Utils.Exception
        ErrorSimpan(ex)
      End Try
    End Sub
    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
      Quit()
      If refreshMode Then
        Me.DialogResult = Windows.Forms.DialogResult.OK
      Else
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
      End If
    End Sub
  End Class
End Namespace