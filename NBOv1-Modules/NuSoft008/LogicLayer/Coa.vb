Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace Logic
  Public Class Coa
    Shared Function GetCoa(sesi As Session, childOnly As Boolean, ParamArray kind() As Persistent.CoaEnum.eKind) As XPCollection(Of Persistent.Coa)
      Dim criteria As CriteriaOperator = New BinaryOperator("AkunIntegrasi", False) 'CriteriaOperator.Parse("not Id is null")
      If childOnly Then
        Dim xpCoa As New XPCollection(Of Persistent.Coa)(sesi, CriteriaOperator.Parse("not Induk is null"))
        Dim a = From x In xpCoa Select x.Induk Distinct

        criteria = CriteriaOperator.And(criteria, New NotOperator(New InOperator("Id", a)))
      End If
      If kind.GetUpperBound(0) >= 0 Then
        criteria = CriteriaOperator.And(criteria, New InOperator("Tipe", kind))
      End If

      Return New XPCollection(Of Persistent.Coa)(sesi, criteria)
    End Function
    Shared Function IsDetail(sesi As Session, coa As Persistent.Coa) As Boolean
      Return sesi.FindObject(Of Persistent.Coa)(CriteriaOperator.Parse("Induk = " & coa.Id)) Is Nothing
    End Function
  End Class
  Public Class Kontak
    Shared Function GetKontak(sesi As Session, Kategori As Persistent.TipeKontak) As XPCollection(Of Persistent.Kontak)
      Dim xpKontak As New XPCollection(Of Persistent.Kontak)(sesi, CriteriaOperator.Parse("not Induk is null"))
      Dim criteria As CriteriaOperator

      criteria = CriteriaOperator.Parse("not Induk is null") 'CriteriaOperator.And(criteria, New NotOperator(New InOperator("Id", Kategori)))

      Return New XPCollection(Of Persistent.Kontak)(sesi, criteria)
    End Function
  End Class

  Friend Class GL
    'Shared Function isAnyTransaction(sesi As DevExpress.Xpo.Session) As Boolean
    '  Return CType(sesi.Evaluate(Of Persistent.GlMain)(CriteriaOperator.Parse("Count()"), Nothing), Int64) > 0
    'End Function
    Shared Function GetBeginningBalanceSPName() As String
      Return "select f02_getbeginningbalance({0},'{1}')"
    End Function
    Shared Function GetBeginningBalanceSPNameProject() As String
      Return "select f02_getbeginningbalanceproject({0},'{1}',{2})"
    End Function
    Shared Function GetSaldo() As String
      Return "select f02_getsaldo({0},'{1}')"
    End Function
    Shared Function GetMutasi() As String
      Return "select f02_getmutation({0},'{1}',{2})"
    End Function
    Shared Function GetBeginningBalanceValas() As String
      Return "select f02_getbeginningbalancevalas({0},'{1}')"
    End Function
    Shared Function GetSaldoStatistik() As String
      Return "select f01_getsaldostatistik({0},'{1}')"
    End Function
  End Class
End Namespace