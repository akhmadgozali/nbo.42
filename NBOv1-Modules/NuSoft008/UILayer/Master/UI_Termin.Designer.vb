<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Termin
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
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTempo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscPersen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPenaltiesDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPenaltiesPersen = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xpCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xGrid
        '
        Me.xGrid.DataSource = Me.xpCol
        '
        'xpCol
        '
    Me.xpCol.ObjectType = GetType(Persistent.Termin)
        '
        'xGridView
        '
        Me.xGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colKode, Me.colTempo, Me.colDiscDay, Me.colDiscPersen, Me.colPenaltiesDay, Me.colPenaltiesPersen})
        Me.xGridView.OptionsBehavior.Editable = False
        Me.xGridView.OptionsDetail.EnableMasterViewMode = False
        Me.xGridView.OptionsSelection.MultiSelect = True
        '
        'colId
        '
        Me.colId.Caption = "ID"
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'colKode
        '
        Me.colKode.Caption = "Kode"
        Me.colKode.FieldName = "Kode"
        Me.colKode.Name = "colKode"
        Me.colKode.Visible = True
        Me.colKode.VisibleIndex = 0
        '
        'colTempo
        '
        Me.colTempo.Caption = "Tempo [Day]"
        Me.colTempo.FieldName = "Tempo"
        Me.colTempo.Name = "colTempo"
        Me.colTempo.Visible = True
        Me.colTempo.VisibleIndex = 1
        '
        'colDiscDay
        '
        Me.colDiscDay.Caption = "Disc [Day]"
        Me.colDiscDay.FieldName = "DiscDay"
        Me.colDiscDay.Name = "colDiscDay"
        Me.colDiscDay.Visible = True
        Me.colDiscDay.VisibleIndex = 2
        '
        'colDiscPersen
        '
        Me.colDiscPersen.Caption = "Disc Nilai"
        Me.colDiscPersen.FieldName = "DiscPersen"
        Me.colDiscPersen.Name = "colDiscPersen"
        Me.colDiscPersen.Visible = True
        Me.colDiscPersen.VisibleIndex = 3
        '
        'colPenaltiesDay
        '
        Me.colPenaltiesDay.Caption = "Denda [Day]"
        Me.colPenaltiesDay.FieldName = "PenaltiesDay"
        Me.colPenaltiesDay.Name = "colPenaltiesDay"
        Me.colPenaltiesDay.Visible = True
        Me.colPenaltiesDay.VisibleIndex = 4
        '
        'colPenaltiesPersen
        '
        Me.colPenaltiesPersen.Caption = "Denda Nilai"
        Me.colPenaltiesPersen.FieldName = "PenaltiesPersen"
        Me.colPenaltiesPersen.Name = "colPenaltiesPersen"
        Me.colPenaltiesPersen.Visible = True
        Me.colPenaltiesPersen.VisibleIndex = 5
        '
        'UI_Termin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 395)
        Me.Name = "UI_Termin"
        Me.Text = "Master Data Termin"
        Me.xpCol = Me.xpCol
        CType(Me.xGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xpCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTempo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscPersen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPenaltiesDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPenaltiesPersen As DevExpress.XtraGrid.Columns.GridColumn
End Class
