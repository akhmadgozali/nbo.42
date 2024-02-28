Namespace NuSoft.Utils.Win
  <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
  Partial Class ExceptionBox
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
      MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExceptionBox))
      Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
      Me.btnCopy = New DevExpress.XtraEditors.SimpleButton()
      Me.btnKeluar = New DevExpress.XtraEditors.SimpleButton()
      Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
      Me.txtNomor = New DevExpress.XtraEditors.TextEdit()
      Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
      Me.txtSumber = New DevExpress.XtraEditors.TextEdit()
      Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
      Me.txtPesan = New DevExpress.XtraEditors.MemoEdit()
      Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
      Me.txtSolusi = New DevExpress.XtraEditors.MemoEdit()
      Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
      Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
      CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.PanelControl1.SuspendLayout()
      CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPesan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSolusi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'PanelControl1
      '
      Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
      Me.PanelControl1.Controls.Add(Me.btnCopy)
      Me.PanelControl1.Controls.Add(Me.btnKeluar)
      Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.PanelControl1.Location = New System.Drawing.Point(0, 317)
      Me.PanelControl1.Name = "PanelControl1"
      Me.PanelControl1.Size = New System.Drawing.Size(343, 49)
      Me.PanelControl1.TabIndex = 4
      '
      'btnCopy
      '
      Me.btnCopy.Appearance.ForeColor = System.Drawing.Color.Green
      Me.btnCopy.Appearance.Options.UseForeColor = True
      Me.btnCopy.Location = New System.Drawing.Point(12, 12)
      Me.btnCopy.Name = "btnCopy"
      Me.btnCopy.Size = New System.Drawing.Size(125, 26)
      Me.btnCopy.TabIndex = 0
      Me.btnCopy.Text = "&Copy to Clipboard"
      '
      'btnKeluar
      '
      Me.btnKeluar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btnKeluar.Appearance.ForeColor = System.Drawing.Color.Red
      Me.btnKeluar.Appearance.Options.UseForeColor = True
      Me.btnKeluar.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnKeluar.Location = New System.Drawing.Point(244, 12)
      Me.btnKeluar.Name = "btnKeluar"
      Me.btnKeluar.Size = New System.Drawing.Size(87, 26)
      Me.btnKeluar.TabIndex = 1
      Me.btnKeluar.Text = "&Keluar"
      '
      'LabelControl1
      '
      Me.LabelControl1.Location = New System.Drawing.Point(13, 55)
      Me.LabelControl1.Name = "LabelControl1"
      Me.LabelControl1.Size = New System.Drawing.Size(31, 13)
      Me.LabelControl1.TabIndex = 8
      Me.LabelControl1.Text = "Nomor"
      '
      'txtNomor
      '
      Me.txtNomor.Location = New System.Drawing.Point(66, 52)
      Me.txtNomor.Name = "txtNomor"
      Me.txtNomor.Properties.ReadOnly = True
      Me.txtNomor.Size = New System.Drawing.Size(265, 20)
      Me.txtNomor.TabIndex = 0
      '
      'LabelControl2
      '
      Me.LabelControl2.Location = New System.Drawing.Point(13, 81)
      Me.LabelControl2.Name = "LabelControl2"
      Me.LabelControl2.Size = New System.Drawing.Size(29, 13)
      Me.LabelControl2.TabIndex = 7
      Me.LabelControl2.Text = "Pesan"
      '
      'txtSumber
      '
      Me.txtSumber.Location = New System.Drawing.Point(66, 276)
      Me.txtSumber.Name = "txtSumber"
      Me.txtSumber.Properties.ReadOnly = True
      Me.txtSumber.Size = New System.Drawing.Size(265, 20)
      Me.txtSumber.TabIndex = 3
      '
      'LabelControl4
      '
      Me.LabelControl4.Location = New System.Drawing.Point(13, 279)
      Me.LabelControl4.Name = "LabelControl4"
      Me.LabelControl4.Size = New System.Drawing.Size(36, 13)
      Me.LabelControl4.TabIndex = 5
      Me.LabelControl4.Text = "Sumber"
      '
      'txtPesan
      '
      Me.txtPesan.Location = New System.Drawing.Point(66, 78)
      Me.txtPesan.Name = "txtPesan"
      Me.txtPesan.Properties.ReadOnly = True
      Me.txtPesan.Size = New System.Drawing.Size(265, 93)
      Me.txtPesan.TabIndex = 1
      '
      'LabelControl3
      '
      Me.LabelControl3.Location = New System.Drawing.Point(13, 180)
      Me.LabelControl3.Name = "LabelControl3"
      Me.LabelControl3.Size = New System.Drawing.Size(27, 13)
      Me.LabelControl3.TabIndex = 6
      Me.LabelControl3.Text = "Solusi"
      '
      'txtSolusi
      '
      Me.txtSolusi.Location = New System.Drawing.Point(66, 177)
      Me.txtSolusi.Name = "txtSolusi"
      Me.txtSolusi.Properties.ReadOnly = True
      Me.txtSolusi.Size = New System.Drawing.Size(265, 93)
      Me.txtSolusi.TabIndex = 2
      '
      'PictureEdit1
      '
      Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
      Me.PictureEdit1.Location = New System.Drawing.Point(9, 8)
      Me.PictureEdit1.Name = "PictureEdit1"
      Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
      Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
      Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
      Me.PictureEdit1.Size = New System.Drawing.Size(49, 43)
      Me.PictureEdit1.TabIndex = 9
      '
      'LabelControl5
      '
      Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
      Me.LabelControl5.Location = New System.Drawing.Point(66, 12)
      Me.LabelControl5.Name = "LabelControl5"
      Me.LabelControl5.Size = New System.Drawing.Size(265, 34)
      Me.LabelControl5.TabIndex = 10
      Me.LabelControl5.Text = "Maaf, ada kesalahan dalam sistem " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dengan rincian sebagai berikut :"
      '
      'ExceptionBox
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(343, 366)
      Me.Controls.Add(Me.LabelControl5)
      Me.Controls.Add(Me.PictureEdit1)
      Me.Controls.Add(Me.LabelControl3)
      Me.Controls.Add(Me.txtSolusi)
      Me.Controls.Add(Me.txtSumber)
      Me.Controls.Add(Me.LabelControl4)
      Me.Controls.Add(Me.LabelControl2)
      Me.Controls.Add(Me.txtNomor)
      Me.Controls.Add(Me.LabelControl1)
      Me.Controls.Add(Me.PanelControl1)
      Me.Controls.Add(Me.txtPesan)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "ExceptionBox"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Kotak Kesalahan"
      CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.PanelControl1.ResumeLayout(False)
      CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPesan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSolusi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Protected Friend WithEvents btnCopy As DevExpress.XtraEditors.SimpleButton
    Protected Friend WithEvents btnKeluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPesan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSolusi As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
  End Class
End Namespace