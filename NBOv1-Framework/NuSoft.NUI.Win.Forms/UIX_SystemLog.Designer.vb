<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIX_SystemLog
  Inherits Core.Win.Forms.GridInput

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
    Me.colJenis = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUser = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colAktivitas = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUserAgent = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUserHostAddress = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colUserHostName = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xGrid
    '
    Me.xGrid.DataSource = Me.ifSource
    Me.xGrid.Size = New System.Drawing.Size(765, 374)
    '
    'xGridView
    '
    Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTanggal, Me.colUser, Me.colJenis, Me.colAktivitas, Me.colUserAgent, Me.colUserHostAddress, Me.colUserHostName, Me.colBulan, Me.colTahun})
    StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
    StyleFormatCondition1.Appearance.Options.UseBackColor = True
    StyleFormatCondition1.ApplyToRow = True
    StyleFormatCondition1.Column = Me.colJenis
    StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
    StyleFormatCondition1.Expression = "Error"
    StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
    StyleFormatCondition2.Appearance.Options.UseBackColor = True
    StyleFormatCondition2.Column = Me.colJenis
    StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
    StyleFormatCondition2.Expression = "Warning"
    Me.xGridView.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
    Me.xGridView.GroupCount = 2
    Me.xGridView.OptionsBehavior.Editable = False
    Me.xGridView.OptionsDetail.EnableMasterViewMode = False
    Me.xGridView.OptionsSelection.MultiSelect = True
    Me.xGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTahun, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBulan, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTanggal, DevExpress.Data.ColumnSortOrder.Descending)})
    '
    'ifSource
    '
    Me.ifSource.ObjectType = GetType(NuSoft.NPO.SSystem.SystemLog)
    '
    'colJenis
    '
    Me.colJenis.FieldName = "Jenis"
    Me.colJenis.Name = "colJenis"
    Me.colJenis.Visible = True
    Me.colJenis.VisibleIndex = 2
    '
    'colId
    '
    Me.colId.FieldName = "Id"
    Me.colId.Name = "colId"
    Me.colId.Visible = True
    Me.colId.VisibleIndex = 0
    '
    'colTanggal
    '
    Me.colTanggal.DisplayFormat.FormatString = "G"
    Me.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.colTanggal.FieldName = "Tanggal"
    Me.colTanggal.Name = "colTanggal"
    Me.colTanggal.Visible = True
    Me.colTanggal.VisibleIndex = 0
    '
    'colUser
    '
    Me.colUser.FieldName = "User"
    Me.colUser.Name = "colUser"
    Me.colUser.Visible = True
    Me.colUser.VisibleIndex = 1
    '
    'colAktivitas
    '
    Me.colAktivitas.FieldName = "Aktivitas"
    Me.colAktivitas.Name = "colAktivitas"
    Me.colAktivitas.Visible = True
    Me.colAktivitas.VisibleIndex = 3
    '
    'colUserAgent
    '
    Me.colUserAgent.FieldName = "UserAgent"
    Me.colUserAgent.Name = "colUserAgent"
    Me.colUserAgent.Visible = True
    Me.colUserAgent.VisibleIndex = 4
    '
    'colUserHostAddress
    '
    Me.colUserHostAddress.FieldName = "UserHostAddress"
    Me.colUserHostAddress.Name = "colUserHostAddress"
    Me.colUserHostAddress.Visible = True
    Me.colUserHostAddress.VisibleIndex = 5
    '
    'colUserHostName
    '
    Me.colUserHostName.FieldName = "UserHostName"
    Me.colUserHostName.Name = "colUserHostName"
    Me.colUserHostName.Visible = True
    Me.colUserHostName.VisibleIndex = 6
    '
    'colBulan
    '
    Me.colBulan.DisplayFormat.FormatString = "MMMM"
    Me.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colBulan.FieldName = "Bulan"
    Me.colBulan.GroupFormat.FormatString = "MMMM"
    Me.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
    Me.colBulan.Name = "colBulan"
    Me.colBulan.OptionsColumn.ReadOnly = True
    Me.colBulan.Visible = True
    Me.colBulan.VisibleIndex = 7
    '
    'colTahun
    '
    Me.colTahun.Caption = "Tahun"
    Me.colTahun.FieldName = "Tanggal"
    Me.colTahun.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateYear
    Me.colTahun.Name = "colTahun"
    Me.colTahun.Visible = True
    Me.colTahun.VisibleIndex = 8
    '
    'UIX_SystemLog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(765, 401)
    Me.Name = "UIX_SystemLog"
    Me.Text = "System Log"
    Me.xpCol = Me.xpCol
    CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUser As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colJenis As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colAktivitas As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUserAgent As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUserHostAddress As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colUserHostName As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
End Class
