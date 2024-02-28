Public Class Frm_Proses
  Private WithEvents cls As New FTPUpdate
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Me.Icon = My.Resources.NusoftIcon
  End Sub
  Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
    BackgroundWorker1.RunWorkerAsync()
  End Sub
  Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    cls.StartProcess(True)
  End Sub
  Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
    'Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub VisibleBar(ByVal GoingCheck As Boolean)
    PB.Visible = Not GoingCheck
    MB.Visible = GoingCheck
  End Sub

  Private Sub cls_Preparing(ByVal progress As String) Handles cls.Preparing
    VisibleBar(True)
    lbl.Text = progress
  End Sub
  Private Sub cls_StartDownload(ByVal JmlFile As Integer) Handles cls.StartDownload
    VisibleBar(False)
    PB.Properties.Maximum = JmlFile
    PB.Properties.Minimum = 0
  End Sub
  Private Sub cls_Progress(ByVal progress As String, ByVal Prosentase As Integer) Handles cls.Progress
    lbl.Text = progress
    PB.Text = Prosentase.ToString
  End Sub
  Private Sub cls_Selesai() Handles cls.Selesai
    Me.DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub
End Class