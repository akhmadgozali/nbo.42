Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraPivotGrid
Imports NuSoft.NPO
Imports NuSoft.NPO.SSystem
Imports NuSoft.Core.SSystem
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent
Public Class UI_FusohCekData
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
  End Sub
  Overrides Sub FirstLoad()
    session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
  End Sub
  Private Sub btnCekData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCekData.ItemClick
    Using splashManager As New DevExpress.XtraSplashScreen.SplashScreenManager(Nothing, GetType(Core.Win.Forms.WaitForm), True, True)
      splashManager.ShowWaitForm()
      splashManager.SetWaitFormCaption("Silahkan Tunggu")
      splashManager.SetWaitFormDescription("Proses pengecekan data ...")

      GridSNDempyou.DataSource = New XPCollection(Of Persistent.FusohVwSNDempyou)(session, New BinaryOperator("SerialDempyou", 0, BinaryOperatorType.Equal))
      gridSNQty.DataSource = New XPCollection(Of Persistent.FusohVwSNQty)(session, New BinaryOperator("Selisih", 0, BinaryOperatorType.NotEqual))
      gridAMSJ.DataSource = New XPCollection(Of Persistent.FusohVwProduksi)(session, New BinaryOperator("QtySisa", 0, BinaryOperatorType.Less))
      gridSNOver.DataSource = New XPCollection(Of Persistent.FusohVwSNOver)(session)
      gridSNOverLength.DataSource = New XPCollection(Of Persistent.FusohVwSNOverLength)(session)

      'aa
      Dim DataTransaksi As New XPCollection(Of Persistent.Fusoh_StokDetail)(session)
      Dim b = (From z In DataTransaksi Group z By z.Barang Into Group
               Select New DataSourceItem With {
                 .Barang = Barang,
                 .QtyIn = Group.Sum(Function(x) x.QtyIn),
                 .QtyOut = Group.Sum(Function(x) x.QtyOut),
                 .Stock = Group.Sum(Function(x) x.QtyIn - x.QtyOut),
                 .TotalLength = Group.Sum(Function(x) x.TotalLength),
                 .TotalHPP = Group.Sum(Function(x) x.NilaiBarang)
              }).ToList

      gridAmount.DataSource = b.Where(Function(m) m.Stock = 0 And m.TotalHPP <> 0)
      gridAmountView.ActiveFilterString = "[TotalHPP]>1 or [TotalHPP]<-1"
      'MsgBox("Proses Selesai.")
    End Using
  End Sub
  Public Class DataSourceItem
    Property Barang As Fusoh_Barang
    Property QtyIn As Double
    Property QtyOut As Double
    Property Stock As Double
    Property TotalLength As Double
    Property Dempyou As Double
    Property TotalHPP As Double
  End Class
End Class