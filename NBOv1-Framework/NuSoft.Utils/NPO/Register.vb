Namespace NuSoft.NPO
  Public Class NPOFunction
    Shared Sub Register()
      DevExpress.Data.Filtering.CriteriaOperator.RegisterCustomFunction(New NPO.CustomFunction.MonthNameFunction)
      DevExpress.Data.Filtering.CriteriaOperator.RegisterCustomFunction(New NPO.CustomFunction.MonthFunction)
      DevExpress.Data.Filtering.CriteriaOperator.RegisterCustomFunction(New NPO.CustomFunction.YearFunction)
      DevExpress.Data.Filtering.CriteriaOperator.RegisterCustomFunction(New NPO.CustomFunction.TerbilangFunction)
      DevExpress.Data.Filtering.CriteriaOperator.RegisterCustomFunction(New NPO.CustomFunction.TerbilangEnglishFunction)
    End Sub
  End Class
End Namespace