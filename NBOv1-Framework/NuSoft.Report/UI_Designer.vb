Public Class UI_Designer
  Const skinMask As String = "Skin : "

  Sub New()
    DevExpress.UserSkins.BonusSkins.Register()
    DevExpress.Skins.SkinManager.EnableFormSkins()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Me.Icon = My.Resources.NusoftIcon
    Me.Text = String.Format("{0}.{1}", My.Application.Info.AssemblyName, MyClass.Name)

    initSkins()
  End Sub
  Private Sub initSkins()
    XrDesignBarManager1.ForceInitialize()
    For Each cnt As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
      Dim item As DevExpress.XtraBars.BarButtonItem = New DevExpress.XtraBars.BarButtonItem(XrDesignBarManager1, skinMask & cnt.SkinName)
      BarSubItemSkin.AddItem(item)
      AddHandler item.ItemClick, AddressOf OnSkinClick
    Next cnt

    BarSubItemSkin.Caption = skinMask & DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName
  End Sub
  Private Sub OnSkinClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    Dim skinName As String = e.Item.Caption.Replace(skinMask, "")
    DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinName)
    XrDesignBarManager1.GetController.PaintStyleName = "Skin"
    BarSubItemSkin.Caption = e.Item.Caption
    BarSubItemSkin.Hint = BarSubItemSkin.Caption
    BarSubItemSkin.ImageIndex = -1

    My.Settings.SkinName = skinName
    My.Settings.Save()
  End Sub

  Public Sub CreateNewReport()
    xrDesignMdiController1.CreateNewReport()
  End Sub
  Public Sub OpenReport(ByVal newReport As DevExpress.XtraReports.UI.XtraReport)
    xrDesignMdiController1.OpenReport(newReport)
  End Sub
  Public ReadOnly Property ActiveXRDesignPanel() As DevExpress.XtraReports.UserDesigner.XRDesignPanel
    Get
      Return XrDesignMdiController1.ActiveDesignPanel
    End Get
  End Property
End Class
