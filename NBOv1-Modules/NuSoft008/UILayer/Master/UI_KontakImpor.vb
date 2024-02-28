Imports System.IO
Imports System.Data.OleDb
Imports System.Data
Public Class UI_KontakImpor
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub
  Shared Function OpenFile(ByVal fileName As String) As Object
    Dim fullFileName = fileName 'String.Format("{0}\{1}", Directory.GetCurrentDirectory(), fileName)
    If (Not File.Exists(fullFileName)) Then
      System.Windows.Forms.MessageBox.Show("File not found")
      Return Nothing
    End If
    Dim connectionString As String = String.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fullFileName)
    Dim adapter = New OleDbDataAdapter("select * from [Sheet1$]", connectionString)
    Dim ds = New DataSet()
    Dim tableName As String = "excelData"
    adapter.Fill(ds, tableName)
    Dim data As DataTable = ds.Tables(tableName)
    Return data
  End Function

  Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
    'xGrid.DataSource = OpenFile("C:\masterkontak.xls")
    SpreadsheetControl1.LoadDocument("C:\masterkontak.xls")

  End Sub
End Class