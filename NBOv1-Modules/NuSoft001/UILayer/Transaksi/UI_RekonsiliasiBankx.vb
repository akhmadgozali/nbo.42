Imports DevExpress.Xpo
Imports NuSoft.NPO
Public Class UI_RekonsiliasiBankx
  Private xsession As UnitOfWork
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub FirstLoad()
    'xsession = NuSoft.Data.DbClient.GetXPOSession()
    'Dim setting As New Logic.FinaSetting(session)
    'txtSaldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    'txtSaldo.Properties.Mask.EditMask = setting.NumericFormatToString
    'txtAkun.Properties.DataSource = Logic.Coa.GetCoa(session, True, Persistent.CoaEnum.eKind.Bank)
  End Sub
  Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
    'MsgBox("isikan datanya coy")

  End Sub
End Class