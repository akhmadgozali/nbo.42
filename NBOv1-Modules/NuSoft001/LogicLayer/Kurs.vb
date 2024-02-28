Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace Logic
  Public Class Kurs
    Shared Function SaveKurs(session As UnitOfWork, MataUangDefault As Integer, MataUang As Persistent.MataUang, Tanggal As Date, Kurs As Double) As Boolean
      Try
        If MataUang.Id <> MataUangDefault Then
          Dim criteria As CriteriaOperator = New GroupOperator(GroupOperatorType.And, New BinaryOperator("MataUang", MataUang, BinaryOperatorType.Equal), New BinaryOperator("Tanggal", Tanggal.ToString("yyyy-MM-dd"), BinaryOperatorType.Equal))
          Dim objKurs As Persistent.MataUangKurs = session.FindObject(Of Persistent.MataUangKurs)(criteria)
          If objKurs Is Nothing Then
            objKurs = New Persistent.MataUangKurs(session)
            objKurs.MataUang = MataUang
            objKurs.Tanggal = Tanggal
          End If
          objKurs.KursUang = Kurs
        End If

        Return True
      Catch ex As Exception
        Return False
      End Try
    End Function
    Shared Function SaveKursPajak(session As UnitOfWork, MataUangDefault As Integer, MataUang As Persistent.MataUang, Tanggal As Date, Kurs As Double) As Boolean
      Try
        If MataUang.Id <> MataUangDefault Then
          Dim criteria As CriteriaOperator = New GroupOperator(GroupOperatorType.And, New BinaryOperator("MataUang", MataUang, BinaryOperatorType.Equal), New BinaryOperator("Tanggal", Tanggal.ToString("yyyy-MM-dd"), BinaryOperatorType.Equal))
          Dim objKurs As Persistent.MataUangKurs = session.FindObject(Of Persistent.MataUangKurs)(criteria)
          If objKurs Is Nothing Then
            objKurs = New Persistent.MataUangKurs(session)
            objKurs.MataUang = MataUang
            objKurs.Tanggal = Tanggal
          End If
          objKurs.KursPajak = Kurs
        End If

        Return True
      Catch ex As Exception
        Return False
      End Try
    End Function
    Shared Function getKursPajak(session As UnitOfWork, MataUang As Persistent.MataUang, tanggal As Date) As Double
      Dim xpKurs As New XPCollection(Of Persistent.MataUangKurs)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("MataUang", MataUang, BinaryOperatorType.Equal), New BinaryOperator("Tanggal", tanggal.ToString("yyyy-MM-dd"), BinaryOperatorType.LessOrEqual)), New SortProperty("Tanggal", DevExpress.Xpo.DB.SortingDirection.Descending))

      If xpKurs.Count > 0 Then
        xpKurs.TopReturnedObjects = 1
        Return xpKurs(0).KursPajak
      Else
        Return 1
      End If
    End Function
    Shared Function getKursBank(session As UnitOfWork, MataUang As Persistent.MataUang, tanggal As Date) As Double
      Dim xpKurs As New XPCollection(Of Persistent.MataUangKurs)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("MataUang", MataUang, BinaryOperatorType.Equal), New BinaryOperator("Tanggal", tanggal.ToString("yyyy-MM-dd"), BinaryOperatorType.LessOrEqual)), New SortProperty("Tanggal", DevExpress.Xpo.DB.SortingDirection.Descending))
      If xpKurs.Count > 0 Then
        xpKurs.TopReturnedObjects = 1
        Return xpKurs(0).KursUang
      Else
        Return 1
      End If
    End Function
  End Class
End Namespace