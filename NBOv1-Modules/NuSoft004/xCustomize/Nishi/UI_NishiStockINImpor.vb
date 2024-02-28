Imports System.ComponentModel
Imports DevExpress.Xpo
Imports DevExpress.XtraGrid.Views.Base
Imports NuSoft.Utils
Friend Class UI_NishiStockINImpor
  Property NishiStockDetailImpor As List(Of Persistent.NishiStockDetailImpor)
  Property _jenisbarang As Persistent.NishiTipeBarangJO
  Sub New(xJenisBarang As Persistent.NishiTipeBarangJO)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
    Btn2IsClosedButton = True
    _jenisbarang = xJenisBarang
  End Sub
  Public Overrides Sub InitializeData()
    If _jenisbarang = Persistent.NishiTipeBarangJO.Coil Then
      colIsi.Visible = False
      colSpekCaseID.Caption = "Specification"
      colSizeCaseno.Caption = "Size"
      colInspectionPartno.Caption = "Inspection No"
      colWeightNett.Visible = True
      colWeightNett.VisibleIndex = 4
      colWeightGross.Visible = True
      colWeightGross.VisibleIndex = 5
      colKubikasi.Visible = False
      colPartName.Visible = False
    Else
      colIsi.Visible = True
      colIsi.VisibleIndex = 0
      colSpekCaseID.Caption = "Case Id"
      colSpekCaseID.VisibleIndex = 1
      colSizeCaseno.Caption = "Case No"
      colSizeCaseno.VisibleIndex = 2
      colInspectionPartno.Caption = "Parts Number"
      colInspectionPartno.VisibleIndex = 3
      colPartName.Visible = True
      colPartName.VisibleIndex = 4
      colWeightNett.Visible = False
      colWeightGross.Visible = False
      colTruckIN.VisibleIndex = 5
      colQty.VisibleIndex = 6
      colKubikasi.Visible = True
      colKubikasi.VisibleIndex = 7
      colRemark.VisibleIndex = 8
    End If
  End Sub
  Public Overrides Sub ErrorBtn1Click(ex As Exception)
    MsgBox(ex.Message)
  End Sub
  Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
    Dim namaFile = Utils.Win.File.ShowOpenFileDialog("Buka file CSV", "CSV Files|*.csv", "")
    If Not String.IsNullOrEmpty(namaFile) Then
      txtNamaFile.Text = namaFile
      If IO.File.Exists(namaFile) Then
        NishiStockDetailImpor = New List(Of Persistent.NishiStockDetailImpor)

        Using MyReader As New FileIO.TextFieldParser(namaFile)
          MyReader.TextFieldType = FileIO.FieldType.Delimited
          'MyReader.SetDelimiters(";")
          MyReader.SetDelimiters(txtPemisah.Text)
          Dim currentRow As String()
          While Not MyReader.EndOfData
            Try
              currentRow = MyReader.ReadFields()
              'PO Line;Part No;Material;OD;ID;T;L;Qty;Price;Catatan
              Dim item As New Persistent.NishiStockDetailImpor
              item.Port = currentRow(0)
              item.Isi = currentRow(1)
              item.Spek_CaseID = currentRow(2)
              item.Size_CaseNo = currentRow(3)
              item.Inspection_PartNo = currentRow(4)
              item.PartName = currentRow(5)
              item.WeightNett = CDbl(currentRow(6))
              item.WeightGross = CDbl(currentRow(7))
              item.TruckIn = currentRow(8)
              item.Qty = CDbl(currentRow(9))
              item.Remark = currentRow(10)
              item.QtyKubikasi = CDbl(currentRow(11))
              item.AsalNegara = currentRow(12)
              item.NoInvoice = currentRow(13)
              NishiStockDetailImpor.Add(item)
            Catch ex As FileIO.MalformedLineException
              MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
            Catch ex As Exception
              MsgBox(ex.Message)
            Catch ex As InvalidCastException

            End Try
          End While
        End Using
        xGrid.DataSource = NishiStockDetailImpor
      End If
    End If
  End Sub

End Class