Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Public Class UI_ZLog
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    showChart = False
    showFilter = False
    useFeedbackSource = True
  End Sub
  Overrides Sub FirstLoad()
    GetSession()
    Dim xData As New XPCollection(Of Persistent.zLOG)(session)
    xGrid.DataSource = xData
  End Sub
  Overrides Sub RefreshData()
    Dim xData As New XPCollection(Of Persistent.zLOG)(session)
    xGrid.DataSource = xData
  End Sub
End Class