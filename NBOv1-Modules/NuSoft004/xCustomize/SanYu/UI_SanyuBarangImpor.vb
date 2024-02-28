Imports System.ComponentModel
Imports DevExpress.Xpo
Imports DevExpress.XtraGrid.Views.Base
Imports NuSoft.Utils
Friend Class UI_SanyuBarangImpor
  Property SanyuBarangImpor As List(Of Persistent.SanYu_BarangImporTemp)
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
    Btn2IsClosedButton = True
  End Sub
  Public Overrides Sub InitializeData()
    colSatuanRepo.DataSource = New XPCollection(Of NuSoft004.Persistent.Satuan)(session)
    colJenisRepo.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.JenisBarang))
    colTipeRepo.DataSource = Utils.Helper.EnumDescription.ToList(GetType(Persistent.TipeBarang))
    colKategoriRepo.DataSource = New XPCollection(Of Persistent.Kategori)(session)
  End Sub
  Public Overrides Sub ErrorBtn1Click(ex As Exception)
    MsgBox(ex.Message)
  End Sub
  Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
    Dim namaFile = Utils.Win.File.ShowOpenFileDialog("Buka file CSV", "CSV Files|*.csv", "")
    If Not String.IsNullOrEmpty(namaFile) Then
      txtNamaFile.Text = namaFile
      If IO.File.Exists(namaFile) Then
        SanyuBarangImpor = New List(Of Persistent.SanYu_BarangImporTemp)

        Using MyReader As New FileIO.TextFieldParser(namaFile)
          MyReader.TextFieldType = FileIO.FieldType.Delimited
          'MyReader.SetDelimiters(";")
          MyReader.SetDelimiters(txtPemisah.Text)
          Dim currentRow As String()
          While Not MyReader.EndOfData
            Try
              currentRow = MyReader.ReadFields()
              'PO Line;Part No;Material;OD;ID;T;L;Qty;Price;Catatan
              If Len(currentRow(0)) > 0 Then
                Dim item As New Persistent.SanYu_BarangImporTemp
                item.Kode = currentRow(0)
                item.Nama = currentRow(1)
                item.sKategori = CInt(currentRow(2))
                item.sJenis = CInt(currentRow(3))
                item.sTipe = CInt(currentRow(4))
                item.sSatuan = CInt(currentRow(5))
                item.Tebal = CDec(currentRow(6))
                item.Lebar = CDec(currentRow(7))
                item.Panjang = CDec(currentRow(8))
                item.FasilitasKite = CBool(currentRow(9))
                'item.sJenis = session.GetObjectByKey(Of Persistent.JenisBarang)(Convert.ToInt32(currentRow(3)))
                'item.sTipe = session.GetObjectByKey(Of Persistent.TipeBarang)(Convert.ToInt32(currentRow(4)))
                item.Kategori = session.GetObjectByKey(Of Persistent.Kategori)(item.sKategori)
                item.Satuan = session.GetObjectByKey(Of Persistent.Satuan)(item.sSatuan)
                SanyuBarangImpor.Add(item)
              End If
            Catch ex As FileIO.MalformedLineException
              MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
            Catch ex As Exception
              MsgBox(ex.Message)
            Catch ex As InvalidCastException

            End Try
          End While
        End Using
        xGrid.DataSource = SanyuBarangImpor
      End If
    End If
  End Sub
End Class