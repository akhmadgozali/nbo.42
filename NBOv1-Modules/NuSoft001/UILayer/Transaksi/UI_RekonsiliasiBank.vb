Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Public Class UI_RekonsiliasiBank
 Dim setting As Logic.FinaSetting
 Sub New()
  ' This call is required by the designer.
  InitializeComponent()
  ' Add any initialization after the InitializeComponent() call.
  NeedDelete = False
  NeedInsert = False
  UseDbSystem = False
 End Sub
 Overrides Sub FirstLoad()
  'xsession = NuSoft.Data.DbClient.GetXPOSession()
  GetSession()
  setting = New Logic.FinaSetting(session)
  txtSaldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
  txtSaldo.Properties.Mask.EditMask = setting.NumericFormatToString
  colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
  colDebit.DisplayFormat.FormatString = setting.NumericFormatString
  colKredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
  colKredit.DisplayFormat.FormatString = setting.NumericFormatString
  colDebitValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
  colDebitValas.DisplayFormat.FormatString = setting.NumericFormatString
  colKreditValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
  colKreditValas.DisplayFormat.FormatString = setting.NumericFormatString
  colDebit.SummaryItem.DisplayFormat = setting.NumericFormatString
  colKredit.SummaryItem.DisplayFormat = setting.NumericFormatString
  colDebitValas.SummaryItem.DisplayFormat = setting.NumericFormatString
  colKreditValas.SummaryItem.DisplayFormat = setting.NumericFormatString

  txtAkun.Properties.DataSource = Logic.Coa.GetCoa(session, True, Persistent.CoaEnum.eKind.Bank)
  xGridView.OptionsBehavior.Editable = False
  xGridView.OptionsBehavior.ReadOnly = True
  LoadDefault()

 End Sub
 Private Sub LoadDefault()
  txtSaldo.EditValue = 0
  txtAkun.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtAkun)
  If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("RKTransaksi.xml")) = True Then
   LytRekon.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("RKTransaksi.xml"))
  End If
 End Sub
 Private Sub txtAkun_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtAkun.EditValueChanging
  If Not e.NewValue Is Nothing Then
   Dim setting As New Logic.FinaSetting(session)
   lblCoaNama.Text = CType(e.NewValue, Persistent.Coa).Nama
   xGrid.DataSource = Nothing
   HitungSaldo()
   If CType(e.NewValue, Persistent.Coa).MataUang.Id = setting.MultiMataUangDefault Then
    colDebit.Visible = True
    colKredit.Visible = True
    colDebitValas.Visible = False
    colKreditValas.Visible = False
    colDebit.VisibleIndex = 5
    colKredit.VisibleIndex = 6
   Else
    colDebit.Visible = False
    colKredit.Visible = False
    colDebitValas.Visible = True
    colKreditValas.Visible = True
    colDebitValas.VisibleIndex = 5
    colKreditValas.VisibleIndex = 6
   End If
  End If
 End Sub
 Private Sub cmdTampilkan_Click(sender As Object, e As EventArgs) Handles cmdTampilkan.Click
  If txtTanggal.EditValue Is Nothing Then
   MsgBox("Masukkan tanggal terlebih dahulu.")
   Exit Sub
  End If
  xGrid.DataSource = Nothing
  xGrid.DataSource = New XPCollection(Of Persistent.GlMainDetail)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Akun", CType(txtAkun.EditValue, Persistent.Coa), BinaryOperatorType.Equal), New BinaryOperator("Main.Tanggal", txtTanggal.EditValue, BinaryOperatorType.LessOrEqual)))
  xGridView.ActiveFilterString = "[Rekonsiliasi]=false"
  xGridView.OptionsBehavior.ReadOnly = False
  xGridView.OptionsBehavior.Editable = True
  lbSaldoBank.Text = String.Format(setting.NumericFormatString, txtSaldo.Text)
  HitungSaldo()
 End Sub
 Private Sub HitungSaldo()
  lbTotalMasuk.Text = String.Format(setting.NumericFormatString, 0)
  lbTotalKeluar.Text = String.Format(setting.NumericFormatString, 0)

  lbSetoranPerjalanan.Text = String.Format(setting.NumericFormatString, 0)
  lbCekGiro.Text = String.Format(setting.NumericFormatString, 0)


  lbTotalBank.Text = String.Format(setting.NumericFormatString, CDbl(lbSaldoBank.Text) + CDbl(lbSetoranPerjalanan.Text))
  lbTotalGL.Text = String.Format(setting.NumericFormatString, CDbl(lbSaldoGL.Text) + CDbl(lbCekGiro.Text))
  lbSelisih.Text = String.Format(setting.NumericFormatString, CDbl(lbTotalBank.Text) - CDbl(lbTotalGL.Text))
 End Sub
End Class