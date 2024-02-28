Friend Class UI_TutupBuku
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    baseView = xGridView
    KeyField = "Id"
    allowDelete = False
    useMDIforDialog = False
    useFeedbackSource = True
    ActivateToolTip = False
    UseDbSystem = False
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_TutupBukuDialog
  End Function
End Class