Namespace NuSoft.Core.Win.Forms
  Public Class YearMonthFilter
    Private _yearField, _monthField As String

    Sub New(YearField As String, MonthField As String)
      ' This call is required by the designer.
      InitializeComponent()
      ' Add any initialization after the InitializeComponent() call.
      txtBulan.Properties.Items.Clear()
      For i = 0 To 11
        txtBulan.Properties.Items.Add(MonthName(i + 1))
      Next
      txtTahun.Properties.Items.Clear()
      For i = Now.Year - 10 To Now.Year + 10
        txtTahun.Properties.Items.Add(i)
      Next

      _yearField = YearField
      _monthField = MonthField

      If _monthField = Nothing Then
        LabelControl2.Visible = False
        txtBulan.Visible = False

        Me.Height = Me.Height - txtBulan.Height
        Me.Width = Me.Width - (txtBulan.Width - txtTahun.Width)
      End If
    End Sub

    Public Overrides Sub ExtractCriteria()
      Dim temp As String() = Split(CriteriaString, "And")
      If temp.GetUpperBound(0) >= 0 Then
        txtTahun.EditValue = temp(0).Replace(String.Format("{0} = ", _yearField), "")
      End If
      If temp.GetUpperBound(0) >= 1 Then
        txtBulan.SelectedIndex = CInt(temp(1).Replace(String.Format("{0} = ", _monthField), "")) - 1
      End If
    End Sub
    Public Overrides Function BuildCriteria() As String
      Return BuildCriteria(CInt(txtTahun.EditValue), txtBulan.SelectedIndex + 1)
    End Function
    Public Overloads Function BuildCriteria(yearValue As Integer, monthValue As Integer) As String
      Const format2 As String = "And {0}={1}"
      Dim result As String = String.Format("{0}={1} ", _yearField, yearValue)

      If Not _monthField = Nothing Then
        result &= String.Format(format2, _monthField, monthValue)
      End If

      Return result
    End Function
  End Class
End Namespace