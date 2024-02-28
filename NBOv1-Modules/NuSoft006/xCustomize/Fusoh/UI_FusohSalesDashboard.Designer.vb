<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UI_FusohSalesDashboard
	Inherits Core.Win.Forms.BlankForm

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI_FusohSalesDashboard))
		Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
		Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
		Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
		Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
		Me.widgetView1 = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView(Me.components)
		Me.ColumnDefinition1 = New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition()
		Me.ColumnDefinition2 = New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition()
		Me.ColumnDefinition3 = New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition()
		Me.dbFusohDueDate = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
		Me.dbFusohPerMonthSales = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
		Me.dbFusohCustomersSales = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
		Me.RowDefinition1 = New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition()
		Me.RowDefinition2 = New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition()
		CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.widgetView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ColumnDefinition1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ColumnDefinition2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ColumnDefinition3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dbFusohDueDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dbFusohPerMonthSales, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dbFusohCustomersSales, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RowDefinition1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RowDefinition2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'documentManager1
		'
		Me.documentManager1.ContainerControl = Me
		Me.documentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.[False]
		Me.documentManager1.View = Me.widgetView1
		Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.widgetView1})
		'
		'widgetView1
		'
		Me.widgetView1.Columns.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition() {Me.ColumnDefinition1, Me.ColumnDefinition2, Me.ColumnDefinition3})
		Me.widgetView1.DocumentProperties.AllowClose = False
		Me.widgetView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.dbFusohDueDate, Me.dbFusohPerMonthSales, Me.dbFusohCustomersSales})
		Me.widgetView1.DocumentSpacing = 5
		Me.widgetView1.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.TableLayout
		Me.widgetView1.Rows.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition() {Me.RowDefinition1, Me.RowDefinition2})
		'
		'dbFusohDueDate
		'
		Me.dbFusohDueDate.Caption = "Due Date Delivery"
		Me.dbFusohDueDate.ColumnSpan = 3
		Me.dbFusohDueDate.ControlName = "DB_FusohDueDate"
		Me.dbFusohDueDate.ControlTypeName = "NuSoft.NUI.Win.Forms.Modules.NuSoft006.DB_FusohDueDate"
		Me.dbFusohDueDate.CustomHeaderButtons.AddRange(New DevExpress.XtraBars.Docking2010.IButton() {New DevExpress.XtraBars.Docking.CustomHeaderButton("Refresh", CType(resources.GetObject("dbFusohDueDate.CustomHeaderButtons"), System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.HorizontalImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", False, -1, True, Nothing, True, False, True, SerializableAppearanceObject1, Nothing, Nothing, -1)})
		'
		'dbFusohPerMonthSales
		'
		Me.dbFusohPerMonthSales.Caption = "Per Month - YTD Sales"
		Me.dbFusohPerMonthSales.ColumnIndex = 1
		Me.dbFusohPerMonthSales.ColumnSpan = 2
		Me.dbFusohPerMonthSales.ControlName = "DB_FusohPerMonthSales"
		Me.dbFusohPerMonthSales.ControlTypeName = "NuSoft.NUI.Win.Forms.Modules.NuSoft006.DB_FusohPerMonthSales"
		Me.dbFusohPerMonthSales.CustomHeaderButtons.AddRange(New DevExpress.XtraBars.Docking2010.IButton() {New DevExpress.XtraBars.Docking.CustomHeaderButton("Refresh", CType(resources.GetObject("dbFusohPerMonthSales.CustomHeaderButtons"), System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.HorizontalImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", False, -1, True, Nothing, True, False, True, SerializableAppearanceObject2, Nothing, Nothing, -1)})
		Me.dbFusohPerMonthSales.RowIndex = 1
		'
		'dbFusohCustomersSales
		'
		Me.dbFusohCustomersSales.Caption = "Top 5 Customers - YTD Sales"
		Me.dbFusohCustomersSales.ControlName = "DB_FusohCustomersSales"
		Me.dbFusohCustomersSales.ControlTypeName = "NuSoft.NUI.Win.Forms.Modules.NuSoft006.DB_FusohCustomersSales"
		Me.dbFusohCustomersSales.CustomHeaderButtons.AddRange(New DevExpress.XtraBars.Docking2010.IButton() {New DevExpress.XtraBars.Docking.CustomHeaderButton("Refresh", CType(resources.GetObject("dbFusohCustomersSales.CustomHeaderButtons"), System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.HorizontalImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", False, -1, True, Nothing, True, False, True, SerializableAppearanceObject3, Nothing, Nothing, -1)})
		Me.dbFusohCustomersSales.RowIndex = 1
		'
		'UI_FusohSalesDashboard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Name = "UI_FusohSalesDashboard"
		Me.Text = "Sales Dashboard"
		CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.widgetView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ColumnDefinition1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ColumnDefinition2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ColumnDefinition3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dbFusohDueDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dbFusohPerMonthSales, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dbFusohCustomersSales, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RowDefinition1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RowDefinition2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Private WithEvents documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
	Private WithEvents widgetView1 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView
	Friend WithEvents ColumnDefinition1 As DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition
	Friend WithEvents ColumnDefinition2 As DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition
	Friend WithEvents ColumnDefinition3 As DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition
	Friend WithEvents dbFusohDueDate As DevExpress.XtraBars.Docking2010.Views.Widget.Document
	Friend WithEvents dbFusohPerMonthSales As DevExpress.XtraBars.Docking2010.Views.Widget.Document
	Friend WithEvents dbFusohCustomersSales As DevExpress.XtraBars.Docking2010.Views.Widget.Document
	Friend WithEvents RowDefinition1 As DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition
	Friend WithEvents RowDefinition2 As DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition
End Class
