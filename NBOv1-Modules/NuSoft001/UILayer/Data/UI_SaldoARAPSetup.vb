Public Class UI_SaldoARAPSetup
  Dim deletedObject As New List(Of Object)
  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub

  Private Sub xpCOA_CollectionChanged(sender As Object, e As DevExpress.Xpo.XPCollectionChangedEventArgs) Handles xpoSetup.CollectionChanged
    If e.CollectionChangedType = DevExpress.Xpo.XPCollectionChangedType.AfterRemove Then
      deletedObject.Add(e.ChangedObject)
    End If
  End Sub
  Private Sub xpo_ResolveSession(sender As Object, e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpoSetup.ResolveSession, xpCOA.ResolveSession
    e.Session = Me.session
  End Sub
  Overrides Sub Btn1Click()
    session.Delete(deletedObject)
    session.CommitChanges()
    Me.Close()
  End Sub
  Overrides Sub Btn2Click()
    session.RollbackTransaction()
    Me.Close()
  End Sub
  Private Sub xGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles xGridView.KeyDown
    If e.KeyCode = Windows.Forms.Keys.Delete Then
      Dim Id As Persistent.SetupARAP = CType(xGridView.GetRow(xGridView.FocusedRowHandle), Persistent.SetupARAP)
      xGridView.DeleteRow(xGridView.FocusedRowHandle)
    End If
  End Sub
End Class