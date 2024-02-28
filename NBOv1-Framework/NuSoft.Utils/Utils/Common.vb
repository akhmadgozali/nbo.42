Namespace NuSoft.Utils.Common
  Public Class Number
    Shared Function ConvertNumberToRoman(ByVal Value As Integer) As String
      Dim intVal(0 To 12) As Integer, strVal(0 To 12) As String
      Dim result As String = ""

      intVal(0) = 1 : strVal(0) = "I"
      intVal(1) = 4 : strVal(1) = "IV"
      intVal(2) = 5 : strVal(2) = "V"
      intVal(3) = 9 : strVal(3) = "IX"
      intVal(4) = 10 : strVal(4) = "X"
      intVal(5) = 40 : strVal(5) = "XL"
      intVal(6) = 50 : strVal(6) = "L"
      intVal(7) = 90 : strVal(7) = "XC"
      intVal(8) = 100 : strVal(8) = "C"
      intVal(9) = 400 : strVal(9) = "CD"
      intVal(10) = 500 : strVal(10) = "D"
      intVal(11) = 900 : strVal(11) = "CM"
      intVal(12) = 1000 : strVal(12) = "M"

      If Value = 0 Then
        Return "0"
        Exit Function
      End If

      For i = 12 To 0 Step -1
        Do
          If Value >= intVal(i) Then
            result = result & "" & strVal(i)
            Value = Value - intVal(i)
          End If
        Loop Until Value < intVal(i)
      Next i

      Return result
    End Function
  End Class
  Public Class Character
    Shared Function DuplicateString(ByVal source As String, ByVal n As Integer) As String
      Dim result As String = ""

      For i = 1 To n
        result &= source
      Next

      Return result
    End Function
    Shared Function Terbilang(Saldo As Double, Optional NamaMataUang As String = "") As String
      Const NamaSen As String = "Sen"
      Dim nilai As String() = Saldo.ToString.Split(CChar(My.Application.Culture.NumberFormat.CurrencyDecimalSeparator))
      Dim result As String = ProsesTerbilang(CDbl(nilai(0))) & " " & NamaMataUang

      If nilai.GetUpperBound(0) > 0 Then
        result += " " + ProsesTerbilang(CDbl(nilai(1))) & " " & NamaSen
      End If

      result = result.Replace("   ", " ")
      result = result.Replace("  ", " ")
      Return My.Application.Culture.TextInfo.ToTitleCase(result.Trim)
      'Return StrConv(result.Trim, VbStrConv.ProperCase)
    End Function
    Private Shared Function ProsesTerbilang(Nilai As Double) As String
      Dim bilangan As String() = {"", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan", "sepuluh", "sebelas"}

      If Nilai < 12 Then
        Return " " & bilangan(CInt(Nilai))
      ElseIf Nilai < 20 Then
        Return ProsesTerbilang(Nilai - 10) & " belas"
      ElseIf Nilai < 100 Then
        Return (ProsesTerbilang(CLng(Nilai) \ 10) & " puluh") + ProsesTerbilang(Nilai Mod 10)
      ElseIf Nilai < 200 Then
        Return " seratus" & ProsesTerbilang(Nilai - 100)
      ElseIf Nilai < 1000 Then
        Return (ProsesTerbilang(CLng(Nilai) \ 100) & " ratus") + ProsesTerbilang(Nilai Mod 100)
      ElseIf Nilai < 2000 Then
        Return " seribu" & ProsesTerbilang(Nilai - 1000)
      ElseIf Nilai < 1000000 Then
        Return (ProsesTerbilang(CLng(Nilai) \ 1000) & " ribu") + ProsesTerbilang(Nilai Mod 1000)
      ElseIf Nilai < 1000000000 Then
        Return (ProsesTerbilang(CLng(Nilai) \ 1000000) & " juta") + ProsesTerbilang(Nilai Mod 1000000)
      ElseIf Nilai < 1000000000000 Then
        Return (ProsesTerbilang(CLng(Nilai) \ 1000000000) & " milyar") + ProsesTerbilang(Nilai Mod 1000000000)
      ElseIf Nilai < 1000000000000000 Then
        Return (ProsesTerbilang(CLng(Nilai) \ 1000000000000000) & " trilyun") + ProsesTerbilang(Nilai Mod 1000000000000)
      Else
        Return ""
      End If
    End Function

    Public Shared Function TerbilangEnglish(ByVal Saldo As Double) As String
      Dim Temp As String
      Dim Dollars As String = "", Cents As String = ""
      Dim DecimalPlace, Count As Integer
      Dim Place(9) As String
      Dim Numb As String
      Place(2) = " Thousand " : Place(3) = " Million " : Place(4) = " Billion " : Place(5) = " Trillion "
      ' Convert Numb to a string, trimming extra spaces.
      Numb = Trim(Str(Saldo))
      ' Find decimal place.
      DecimalPlace = InStr(Numb, ".")
      ' If we find decimal place...
      If DecimalPlace > 0 Then
        ' Convert cents
        Temp = Left(Mid(Numb, DecimalPlace + 1) & "00", 2)
        Cents = ConvertTens(Temp)
        ' Strip off cents from remainder to convert.
        Numb = Trim(Left(Numb, DecimalPlace - 1))
      End If
      Count = 1
      Do While Numb <> ""
        ' Convert last 3 digits of Numb to English dollars.
        Temp = ConvertHundreds(Right(Numb, 3))
        If Temp <> "" Then Dollars = Temp & Place(Count) & Dollars
        If Len(Numb) > 3 Then
          ' Remove last 3 converted digits from Numb.
          Numb = Left(Numb, Len(Numb) - 3)
        Else
          Numb = ""
        End If
        Count = Count + 1
      Loop

      ' Clean up dollars.
      Select Case Dollars
        Case "" : Dollars = "No "
        Case "One" : Dollars = "One"
        Case Else : Dollars = Dollars & ""
      End Select

      ' Clean up cents.
      Select Case Cents
        Case "" : Cents = ""
        Case "One" : Cents = " And One Cent"
        Case Else : Cents = " And Cents " & Cents & ""
      End Select
      Return Dollars & Cents
    End Function
    Private Shared Function ConvertHundreds(ByVal MyNumber As String) As String
      Dim Result As String = ""
      ' Exit if there is nothing to convert.
      If Val(MyNumber) = 0 Then Return "" 'Exit Function
      ' Append leading zeros to number.
      MyNumber = Right("000" & MyNumber, 3)
      ' Do we have a hundreds place digit to convert?
      If Left(MyNumber, 1) <> "0" Then
        Result = ConvertDigit(Left(MyNumber, 1)) & " Hundred "
      End If
      ' Do we have a tens place digit to convert?
      If Mid(MyNumber, 2, 1) <> "0" Then
        Result = Result & ConvertTens(Mid(MyNumber, 2))
      Else
        ' If not, then convert the ones place digit.
        Result = Result & ConvertDigit(Mid(MyNumber, 3))
      End If
      Return Trim(Result)
    End Function
    Private Shared Function ConvertTens(ByVal MyTens As String) As String
      Dim Result As String = ""
      ' Is value between 10 and 19?
      If Val(Left(MyTens, 1)) = 1 Then
        Select Case Val(MyTens)
          Case 10 : Result = "Ten"
          Case 11 : Result = "Eleven"
          Case 12 : Result = "Twelve"
          Case 13 : Result = "Thirteen"
          Case 14 : Result = "Fourteen"
          Case 15 : Result = "Fifteen"
          Case 16 : Result = "Sixteen"
          Case 17 : Result = "Seventeen"
          Case 18 : Result = "Eighteen"
          Case 19 : Result = "Nineteen"
          Case Else
        End Select
      Else
        ' .. otherwise it's between 20 and 99.
        Select Case Val(Left(MyTens, 1))
          Case 2 : Result = "Twenty "
          Case 3 : Result = "Thirty "
          Case 4 : Result = "Forty "
          Case 5 : Result = "Fifty "
          Case 6 : Result = "Sixty "
          Case 7 : Result = "Seventy "
          Case 8 : Result = "Eighty "
          Case 9 : Result = "Ninety "
          Case Else
        End Select
        ' Convert ones place digit.
        Result = Result & ConvertDigit(Right(MyTens, 1))
      End If
      ConvertTens = Result
    End Function
    Private Shared Function ConvertDigit(ByVal MyDigit As String) As String
      Select Case Val(MyDigit)
        Case 1 : ConvertDigit = "One"
        Case 2 : ConvertDigit = "Two"
        Case 3 : ConvertDigit = "Three"
        Case 4 : ConvertDigit = "Four"
        Case 5 : ConvertDigit = "Five"
        Case 6 : ConvertDigit = "Six"
        Case 7 : ConvertDigit = "Seven"
        Case 8 : ConvertDigit = "Eight"
        Case 9 : ConvertDigit = "Nine"
        Case Else : ConvertDigit = ""
      End Select
    End Function

    Shared Function CenterText(maxLength As Integer, text As String) As String
      Dim x As Integer = CInt(text.Length / 2)
      Dim y As Integer = CInt(maxLength / 2)

      If y > x Then
        Return Space(y - x) & text
      Else
        Return text
      End If
    End Function
  End Class
  Public Class DateTime
    Shared Function GetLastDateInMonth(year As Integer, month As Integer) As Date
      Return New Date(year, month, Date.DaysInMonth(year, month))
    End Function
    Shared Function GetLastDateInPreviousMonth(year As Integer, month As Integer) As Date
      Dim prevMonth As Integer
      Dim prevYear As Integer

      If month = 1 Then
        prevMonth = 12
        prevYear = year - 1
      Else
        prevMonth = month - 1
        prevYear = year
      End If

      Return GetLastDateInMonth(prevYear, prevMonth)
    End Function
  End Class
  Public Class Resources
    Shared Function SaveFile(FilePath As String, ByVal Resource As Byte()) As Boolean
      Try
        Dim FByte() As Byte = Resource
        My.Computer.FileSystem.WriteAllBytes(FilePath, FByte, True)
        Return True
      Catch ex As Exception
        Return False
      End Try
    End Function
  End Class
End Namespace