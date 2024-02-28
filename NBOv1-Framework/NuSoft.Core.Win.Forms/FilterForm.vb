Namespace NuSoft.Core.Win.Forms
  Public Class FilterForm
    Protected Friend _sesi As New DevExpress.Xpo.UnitOfWork
    Private prive As NPO.NonPersistent.ReportPrivileges

    Overridable Sub InitializeData()

    End Sub
    Overridable Sub Filter()

    End Sub

    Private Sub btn1_Click(sender As Object, e As System.EventArgs) Handles btn1.Click
      Try
        AddParameter("UserX", Core.SSystem.UserInfo.GetUserModified, GetType(System.String))

        Filter()
        Me.DialogResult = Windows.Forms.DialogResult.OK
      Catch ex As Utils.Exception
        ex.ShowWinMessageBox()
      End Try
    End Sub
    Private Sub btn2_Click(sender As Object, e As System.EventArgs) Handles btn2.Click
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Me_Load(sender As Object, e As System.EventArgs) Handles Me.Load
      MeLoad()
    End Sub
    Sub MeLoad()
      If NamaDatabase <> "" AndAlso Not _sesi.IsConnected Then
        _sesi = Data.DbClient.GetXPOSession(NamaDatabase)
      End If

      If DesignMode Then
        prive = New NPO.NonPersistent.ReportPrivileges With {.Buka = True, .Cetak = True, .Eksport = True}
      Else
        If Not LayoutReportTerpisah Then
          ReportId = CInt(ReportId.ToString.Substring(2))
        End If
        prive = Core.SSystem.User.GetPrivilegesReport(ReportId, NamaDatabase)
      End If
      _isRightToExport = prive.Eksport
      _isRightToPrint = prive.Cetak

      InitializeData()
    End Sub
  End Class
End Namespace