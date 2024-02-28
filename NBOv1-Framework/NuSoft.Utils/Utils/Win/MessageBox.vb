Namespace NuSoft.Utils.Win
  Public Class MessageBox
    Public Shadows Enum Icon
      Peringatan
      Pertanyaan
      Informasi
    End Enum
    Public Enum Button
      OK
      OKBatal
      YaTidak
    End Enum
    Public Shadows Enum DialogResult
      OK
      Batal
      Ya
      Tidak
    End Enum

    Private result As DialogResult

    Public Overloads Shared Function Show(ByVal message As String) As DialogResult
      Return Show(message, "", "", Button.OK, Icon.Peringatan)
    End Function
    Public Overloads Shared Function Show(ByVal message As String, ByVal title As String) As DialogResult
      Return Show(message, title, "", Button.OK, Icon.Peringatan)
    End Function
    Public Overloads Shared Function Show(ByVal message As String, ByVal title As String, ByVal solution As String) As DialogResult
      Return Show(message, title, solution, Button.OK, Icon.Peringatan)
    End Function
    Public Overloads Shared Function Show(ByVal message As String, ByVal title As String, ByVal solution As String, ByVal button As Button) As DialogResult
      Return Show(message, title, solution, button, Icon.Peringatan)
    End Function
    Public Overloads Shared Function Show(ByVal message As String, ByVal title As String, ByVal solution As String, ByVal button As Button, ByVal icon As Icon) As DialogResult
      Dim frm As New MessageBox()
      'frm.setTitle(title)
      'frm.setMessage(message)
      'frm.setSolution(solution)
      'frm.setIcon(icon)
      'frm.setButton(button)
      'frm.FormResize()
      'Return frm.ShowDialog
      Dim xMessage As String
      If solution = "" Then
        xMessage = message
      Else
        xMessage = message & vbCrLf & "Solusi : " & solution
      End If
      Dim xButton As Windows.Forms.MessageBoxButtons
      Select Case button
        Case MessageBox.Button.OK : xButton = Windows.Forms.MessageBoxButtons.OK
        Case MessageBox.Button.OKBatal : xButton = Windows.Forms.MessageBoxButtons.OKCancel
        Case MessageBox.Button.YaTidak : xButton = Windows.Forms.MessageBoxButtons.YesNo
      End Select
      Dim xIcon As Windows.Forms.MessageBoxIcon
      Select Case icon
        Case MessageBox.Icon.Informasi : xIcon = Windows.Forms.MessageBoxIcon.Information
        Case MessageBox.Icon.Peringatan : xIcon = Windows.Forms.MessageBoxIcon.Warning
        Case MessageBox.Icon.Pertanyaan : xIcon = Windows.Forms.MessageBoxIcon.Question
      End Select
      Select Case DevExpress.XtraEditors.XtraMessageBox.Show(xMessage, title, xButton, xIcon)
        Case Windows.Forms.DialogResult.Yes : Return DialogResult.Ya
        Case Windows.Forms.DialogResult.No : Return DialogResult.Tidak
        Case Windows.Forms.DialogResult.Cancel : Return DialogResult.Batal
        Case Else : Return DialogResult.OK
      End Select
    End Function

    Friend Sub New()
      ' This call is required by the designer.
      InitializeComponent()
      ' Add any initialization after the InitializeComponent() call.
      lblSolution.Visible = False
      btn2.Visible = False
    End Sub
    Friend Sub setTitle(ByVal title As String)
      Me.Text = title
    End Sub
    Friend Sub setMessage(ByVal message As String)
      Dim x As Integer = x_icon.Location.X + x_icon.Size.Width + 20
      Dim y As Integer = x_icon.Location.Y
      lbl.Text = message
      lbl.Location = New System.Drawing.Point(x, y)
      lbl.Visible = True
    End Sub
    Friend Sub setSolution(ByVal solution As String)
      If solution <> "" Then
        Dim x As Integer = lbl.Location.X
        Dim y As Integer = x_icon.Location.Y + lbl.Height + 3
        lblSolution.Text = "Solusi: " & solution
        lblSolution.Location = New System.Drawing.Point(x, y)
        lblSolution.Visible = True
      End If
    End Sub
    Friend Sub setIcon(ByVal ico As MessageBox.Icon)
      Select Case ico
        Case MessageBox.Icon.Peringatan : x_icon.Image = imageCol.Images(0)
        Case MessageBox.Icon.Informasi : x_icon.Image = imageCol.Images(2)
        Case Else : x_icon.Image = imageCol.Images(1)
      End Select
    End Sub
    Friend Sub setButton(ByVal button As MessageBox.Button)
      Select Case button
        Case MessageBox.Button.OKBatal : buttonText("OK", "Batal")
        Case MessageBox.Button.YaTidak : buttonText("Ya", "Tidak")
        Case Else : buttonText("OK", "")
      End Select
    End Sub
    Friend Sub buttonText(ByVal btn1Text As String, ByVal btn2Text As String)
      btn1.Text = btn1Text
      btn2.Text = btn2Text
      btn1.Visible = btn1.Text <> ""
      btn2.Visible = btn2.Text <> ""

      Dim x, y As Integer
      x = lbl.Location.X
      y = lblSolution.Location.Y + lblSolution.Height + 8
      btn1.Location = New Drawing.Point(x, y)
      btn2.Location = New Drawing.Point(x + btn1.Width + 16, y)
    End Sub
    Friend Sub FormResize()
      Dim width As Integer
      Dim height As Integer

      If lbl.Width > lblSolution.Width Then
        width = lbl.Location.X + lbl.Size.Width + 24
      Else
        width = lblSolution.Location.X + lblSolution.Size.Width + 24
      End If
      If lbl.Height > x_icon.Height Then
        btn1.Location = New Drawing.Point(btn1.Location.X, lbl.Location.Y + lbl.Height + 8)
        btn2.Location = New Drawing.Point(btn2.Location.X, lbl.Location.Y + lbl.Height + 8)
        height = lbl.Location.Y + lbl.Height + btn1.Height + 48
      Else
        If (btn1.Location.Y + btn1.Height) > (x_icon.Location.Y + x_icon.Height) Then
          height = btn1.Location.Y + btn1.Height + 44 '32 Title height, 12 space bottom
        Else
          height = (x_icon.Location.Y * 2) + x_icon.Height + 32
        End If
      End If
      Me.Size = New Drawing.Size(width, height)
    End Sub
    Overloads Function ShowDialog() As DialogResult
      MyBase.ShowDialog()
      Return result
    End Function

    Private Sub btn1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn1.Click
      Select Case btn1.Text
        Case "Ya" : result = MessageBox.DialogResult.Ya
        Case Else : result = MessageBox.DialogResult.OK
      End Select
      Me.Close()
    End Sub
    Private Sub btn2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn2.Click
      Select Case btn2.Text
        Case "Tidak" : result = MessageBox.DialogResult.Tidak
        Case Else : result = MessageBox.DialogResult.Batal
      End Select
      Me.Close()
    End Sub
  End Class
End Namespace