Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Public Class UI_SanYuOrderPenjualanHistory
  Private setting As NuSoft001.Logic.FinaSetting, pKode As String
  Sub New(zKode As String, xSession As DevExpress.Xpo.UnitOfWork)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    session = xSession
    pKode = zKode
  End Sub
  Overrides Sub FirstLoad()
    Dim DataTransaksi As New XPCollection(Of Persistent.SanYu_OrderPenjualanDetail)(session, New BinaryOperator("Main.Kode", pKode, BinaryOperatorType.Equal))
    xGrid.DataSource = DataTransaksi
  End Sub

End Class