Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent
Public Class UI_FusohCekStockHPPSerial
  Private setting As NuSoft001.Logic.FinaSetting, pKode As String
  Private detailSource As List(Of Persistent.Fusoh_StokSerial)
  Private instance As Persistent.Fusoh_StokMain
  Private dataSource As List(Of Fusoh_StockOutSerial)
  Sub New(zKode As String, xSession As DevExpress.Xpo.UnitOfWork)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    session = xSession
    pKode = zKode

    Text = "History Stock : " & zKode
  End Sub
  Overrides Sub FirstLoad()
    setting = New NuSoft001.Logic.FinaSetting(session)
    Dim DataStockIN As New XPCollection(Of Fusoh_StokSerial)(session, getCriteria)
    xGrid.DataSource = DataStockIN

    'ambilkan stock out nya
    Dim DataStockOut As New XPCollection(Of Fusoh_StokSerial)(session, getCriteria2)
    dataSource = New List(Of Fusoh_StockOutSerial)
    For pJ = 0 To DataStockOut.Count - 1
      Dim xItem = New Fusoh_StockOutSerial
      Dim xSN As String = DataStockOut(pJ).Serial
      Dim xDataIN As Fusoh_StokSerial = DataStockIN.Where(Function(w) w.Serial = xSN).SingleOrDefault

			xItem.Row = DataStockOut(pJ)
			xItem.Serial = DataStockOut(pJ).Serial
      xItem.Length = DataStockOut(pJ).LengthOut
      If Not xDataIN Is Nothing Then
        xItem.LengthIN = xDataIN.LengthIn
				xItem.Harga = xDataIN.HargaSerial / xDataIN.LengthIn
				xItem.HargaGR = xDataIN.HargaSerial / xDataIN.LengthIn
				xItem.NoGR = xDataIN.DetailMain.Main.Kode
			Else
				xItem.LengthIN = 0
        xItem.Harga = 0
      End If
      dataSource.Add(xItem)
    Next
    xGridStockOut.DataSource = dataSource
    'Dim b = From z In dataSource Group By z.Row.DetailMain Select DetailMain, HPP = Group.sum(Function(s) s.hpp)

    'Dim xHPP As Double = dataSource.Where(Function(w) w.Row.DetailMain.Id = 14283).Sum(Function(s) s.HPP)
    'MsgBox("HPP untuk : AM-FL21-0540 --> " & xHPP.ToString("n2"))

    Dim xStockOut As New XPCollection(Of Fusoh_StokDetail)(session, getCriteria3)
    For pk = 0 To xStockOut.Count - 1
      Dim xHPPDetail As Double = xStockOut(pk).TotalHPP
      Dim xHPPSN As Double = dataSource.Where(Function(w) w.Row.DetailMain.Id = xStockOut(pk).Id).Sum(Function(s) s.HPP)
      If xHPPDetail.ToString("n2") <> xHPPSN.ToString("n2") Then
        txtSelisih.Text = txtSelisih.Text & xStockOut(pk).Main.Kode & " Detail : " & xHPPDetail.ToString("n2") & "<-->" & xHPPSN.ToString("n2") & vbCrLf
      End If
    Next
  End Sub
  Private Function getCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "{0}"
    result.Add(New BinaryOperator("DetailMain.Barang.Kode", String.Format(format, pKode), BinaryOperatorType.Like))
    result.Add(New BinaryOperator("DetailMain.QtyIn", 0, BinaryOperatorType.Greater))
    Return GroupOperator.And(result)
  End Function

  Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
    NuSoft.Core.Win.Component.XtraGrid.ExportExcel(xGridStockOut, session, "Data Stock")
  End Sub

  Private Function getCriteria2() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "{0}"
    result.Add(New BinaryOperator("DetailMain.Barang.Kode", String.Format(format, pKode), BinaryOperatorType.Like))
    result.Add(New BinaryOperator("LengthOut", 0, BinaryOperatorType.Greater))
    Return GroupOperator.And(result)
  End Function
  Private Function getCriteria3() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "{0}"
    result.Add(New BinaryOperator("Barang.Kode", String.Format(format, pKode), BinaryOperatorType.Like))
    result.Add(New BinaryOperator("QtyOut", 0, BinaryOperatorType.Greater))
    Return GroupOperator.And(result)
  End Function
End Class
Friend Class Fusoh_StockOutSerial
  Public Property Row As Persistent.Fusoh_StokSerial
  Public Property Harga As Double
  Public Property Serial As String
  Public Property Length As Double
	Public Property LengthIN As Double
	Public Property NoGR As String
	Public Property HargaGR As Double
	Public ReadOnly Property HPP As Double
    Get
      Return Length * Harga
    End Get
  End Property
End Class