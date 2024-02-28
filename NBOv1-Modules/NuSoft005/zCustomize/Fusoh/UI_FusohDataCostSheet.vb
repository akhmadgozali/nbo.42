Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute
Public Class UI_FusohDataCostSheet
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Overrides Sub FirstLoad()
        Dim CreateCriteria As CriteriaOperator
        Me.session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
        CreateCriteria = GroupOperator.And(New BinaryOperator("Sumber", Persistent.SumberDataJenis.RI, BinaryOperatorType.Equal))
        XpCollection1.Criteria = CreateCriteria
    End Sub
    Private Sub XpCollection1_ResolveSession(sender As Object, e As ResolveSessionEventArgs) Handles XpCollection1.ResolveSession
        e.Session = session
    End Sub
End Class