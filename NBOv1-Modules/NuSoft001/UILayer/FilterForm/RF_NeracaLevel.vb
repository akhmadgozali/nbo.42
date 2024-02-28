Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent
Imports NuSoft.Utils.CustomAttribute

Friend Class RF_NeracaLevel
  Private _jenis As Persistent.CustomReportTipe
  Private Enum eLevel
    <EnumDescription("Level 1")> Level1
    <EnumDescription("Level 2")> Level2
    <EnumDescription("Level 3")> Level3
    <EnumDescription("Level 4")> Level4
  End Enum
  Sub New(jenis As Persistent.CustomReportTipe)
    ' This call is required by the designer.
    InitializeComponent()
    _jenis = jenis
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub InitializeData()
    Dim period = New DevExpress.Xpo.XPCollection(Of Persistent.Periode)(_sesi)
    txtPeriodeBulan.Properties.Items.Clear()
    For i = 1 To 12
      txtPeriodeBulan.Properties.Items.Add(MonthName(i))
    Next

    Dim TahunAwal As Integer = Now.Year - 10, TahunAkhir As Integer = Now.Year + 10
    For i = TahunAwal To TahunAkhir
      txtPeriodeTahun.Properties.Items.Add(i.ToString)
    Next

    Dim z = From a In period Order By a.Id Descending Select a.Bulan, a.Tahun Take 1

    If z.Count > 0 Then
      If z(0).Bulan = 12 Then
        txtPeriodeBulan.SelectedIndex = 0
        txtPeriodeTahun.EditValue = z(0).Tahun + 1
      Else
        txtPeriodeBulan.SelectedIndex = z(0).Bulan
        txtPeriodeTahun.EditValue = z(0).Tahun
      End If
    Else
      txtPeriodeBulan.SelectedIndex = Now.Month - 1
      txtPeriodeTahun.EditValue = Now.Year
    End If
    txtLevel.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(eLevel))
    txtLevel.EditValue = eLevel.Level4
  End Sub
  Overrides Sub Filter()
    If txtPeriodeTahun.EditValue Is Nothing Then
      Utils.Win.MessageBox.Show("Masukkan periode", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      Return
    End If

    Dim abcSetting As New Modules.NuSoftModSys.LogicLayer.Config(_sesi)
    ' Dim a As Modules.nusoftModSys.
    Dim m02Setting As New Logic.FinaSetting(_sesi)

    AddParameter("NamaPerusahaan", abcSetting.NamaPerusahaan, GetType(System.String))

    AddParameter("FormatAngka", m02Setting.FormatAngka, GetType(System.String))
    AddParameter("FormatNumeric", m02Setting.NumericFormatString, GetType(System.String))
    AddParameter("CompanyName", abcSetting.NamaPerusahaan, GetType(String))
    AddParameter("Alamat1", abcSetting.Alamat1, GetType(String))
    AddParameter("Alamat2", abcSetting.Alamat2, GetType(String))
    AddParameter("BidangUsaha", abcSetting.BidangUsaha, GetType(String))
    AddParameter("NoFax", abcSetting.NoFax, GetType(String))
    AddParameter("NoTelp", abcSetting.NoTelp, GetType(String))

    AddParameter("LevelReport", txtLevel.EditValue, GetType(System.String))
    AddParameter("Periode", txtPeriodeBulan.Text & " " & txtPeriodeTahun.Text, GetType(System.String))

    Dim xpCoa As New XPCollection(Of Persistent.Coa)(_sesi, CriteriaOperator.Parse("not Induk is null"))
    Dim a = From x In xpCoa Select x.Induk Distinct

    Dim details As New DevExpress.Xpo.XPCollection(Of Persistent.Report.SaldoCOA)(_sesi, New GroupOperator(GroupOperator.And, New NotOperator(New InOperator("Id", a)), New BinaryOperator("Tipe.Level1", CoaEnum.eLevel1.Neraca, BinaryOperatorType.Equal)))
    Dim pTanggal As Date
    pTanggal = New Date(CInt(txtPeriodeTahun.Text), txtPeriodeBulan.SelectedIndex + 1, 1) 'ketemu 01/februari/2014
    pTanggal = pTanggal.AddMonths(1) 'ketemu 01 maret 2014
    pTanggal = pTanggal.AddDays(-1) 'ketemu 28 februari 2014

    For pI = 0 To details.Count - 1
      Dim saldo As Double = CDbl(_sesi.ExecuteScalar(String.Format(Logic.GL.GetSaldo, details(pI).Id, pTanggal.ToString("yyyy-MM-dd"))))
      details(pI).SaldoAkhir = saldo
    Next


    If chkSaldoNol.Checked = True Then
      _dataSource = details
    Else
      _dataSource = details.Where(Function(m) m.SaldoAkhir <> 0)
    End If
  End Sub
  Private Function CreateCriteria(Optional BulanInTriwulan As Integer = 1, Optional IsSaldoKhusus As Boolean = False) As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If Core.SSystem.UserInfo.GetUserLevel = 0 Then
      result.Add(New BinaryOperator("Ext", True, BinaryOperatorType.Equal))
    End If
    result.Add(New BinaryOperator("Bulan", txtPeriodeBulan.SelectedIndex + BulanInTriwulan, BinaryOperatorType.Equal))
    result.Add(New BinaryOperator("Tahun", txtPeriodeTahun.Text, BinaryOperatorType.Equal))

    Return GroupOperator.And(result)
  End Function
End Class