Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Public Class UI_NishiCekStockCase
  Private setting As NuSoft001.Logic.FinaSetting, pPelanggan As NuSoft001.Persistent.Kontak
  Private detailSource As List(Of NonPersistent.Fusoh_Produksi_BahanBaku_Temp)
  Private instance As Persistent.Fusoh_StokMain
  Sub New(zPelanggan As NuSoft001.Persistent.Kontak, xSession As DevExpress.Xpo.UnitOfWork)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    session = xSession
    pPelanggan = zPelanggan
  End Sub
  Overrides Sub FirstLoad()
    setting = New NuSoft001.Logic.FinaSetting(session)
    Dim DataTransaksi As New XPCollection(Of Persistent.NishiStockDetail)(session, New BinaryOperator("Main.Pelanggan.Id", pPelanggan.Id, BinaryOperatorType.Equal))
    'MsgBox("count : " & DataTransaksi.Count)
    Dim b = From z In DataTransaksi Group z By z.Spek_CaseID Into Group Select id = Group.Max(Function(x) x.Id), Spek_CaseID, QtyIn = Group.Sum(Function(x) x.QtyIn), QtyOut = Group.Sum(Function(x) x.QtyOut), Stock = Group.Sum(Function(x) x.QtyIn - x.QtyOut), Kubikasi = Group.Average(Function(x) x.QtyIn2)

    Dim xSource = (From z In b Select New HistoryStock With {
        .Id = z.id,
        .CaseID = z.Spek_CaseID,
        .QtyIn = z.QtyIn,
        .QtyOut = z.QtyOut,
        .Sisa = z.Stock,
        .KubikasiIn = z.Kubikasi
    }).ToList

    xGrid.DataSource = xSource
  End Sub
  Public Class HistoryStock
    Property Id As Long
    Property CaseID As String
    Property QtyIn As Double
    Property QtyOut As Double
    Property Sisa As Double
    Property KubikasiIn As Double
    ReadOnly Property SisaKubikasi As Double
      Get
        Dim mSisaKubikasi As Double = 0
        If Sisa > 0 Then
          mSisaKubikasi = KubikasiIn
        Else
          mSisaKubikasi = 0
        End If
        Return mSisaKubikasi
      End Get
    End Property
  End Class
End Class