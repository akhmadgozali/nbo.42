<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_FusohDataStock
  Inherits Core.Win.Forms.BlankForm

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
    Me.components = New System.ComponentModel.Container()
    Me.xpCol1 = New DevExpress.Xpo.XPCollection(Me.components)
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.txtKode = New DevExpress.XtraEditors.TextEdit()
    Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.btnCari = New DevExpress.XtraEditors.SimpleButton()
    CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.xpCol1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'xpCol1
    '
    Me.xpCol1.ObjectType = GetType(NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Fusoh_StokDetail)
    '
    'LabelControl1
    '
    Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(53, 13)
    Me.LabelControl1.TabIndex = 0
    Me.LabelControl1.Text = "Kode Stock"
    '
    'txtKode
    '
    Me.txtKode.Location = New System.Drawing.Point(84, 9)
    Me.txtKode.Name = "txtKode"
    Me.txtKode.Size = New System.Drawing.Size(209, 20)
    Me.txtKode.TabIndex = 1
    '
    'GridControl1
    '
    Me.GridControl1.DataSource = Me.xpCol1
    Me.GridControl1.Location = New System.Drawing.Point(12, 35)
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.Size = New System.Drawing.Size(627, 337)
    Me.GridControl1.TabIndex = 2
    Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'GridView1
    '
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsDetail.EnableMasterViewMode = False
    '
    'btnCari
    '
    Me.btnCari.Location = New System.Drawing.Point(299, 6)
    Me.btnCari.Name = "btnCari"
    Me.btnCari.Size = New System.Drawing.Size(75, 23)
    Me.btnCari.TabIndex = 3
    Me.btnCari.Text = "Cari"
    '
    'UI_FusohDataStock
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(885, 400)
    Me.Controls.Add(Me.btnCari)
    Me.Controls.Add(Me.GridControl1)
    Me.Controls.Add(Me.txtKode)
    Me.Controls.Add(Me.LabelControl1)
    Me.Name = "UI_FusohDataStock"
    Me.Text = "UI_FusohDataStock"
    CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.xpCol1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents xpCol1 As DevExpress.Xpo.XPCollection
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents txtKode As DevExpress.XtraEditors.TextEdit
  Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents btnCari As DevExpress.XtraEditors.SimpleButton
End Class
