<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class x_Serial
	Inherits DevExpress.XtraEditors.XtraForm

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
		Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
		Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
		Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
		Me.txtKode = New DevExpress.XtraEditors.MemoEdit()
		Me.txtSerial = New DevExpress.XtraEditors.MemoEdit()
		CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtSerial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LabelControl1
		'
		Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
		Me.LabelControl1.Name = "LabelControl1"
		Me.LabelControl1.Size = New System.Drawing.Size(180, 13)
		Me.LabelControl1.TabIndex = 0
		Me.LabelControl1.Text = "Masukkan Serial Number NuSoft"
		'
		'LabelControl2
		'
		Me.LabelControl2.Location = New System.Drawing.Point(12, 34)
		Me.LabelControl2.Name = "LabelControl2"
		Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
		Me.LabelControl2.TabIndex = 1
		Me.LabelControl2.Text = "Kode Serial"
		'
		'LabelControl3
		'
		Me.LabelControl3.Location = New System.Drawing.Point(12, 120)
		Me.LabelControl3.Name = "LabelControl3"
		Me.LabelControl3.Size = New System.Drawing.Size(66, 13)
		Me.LabelControl3.TabIndex = 3
		Me.LabelControl3.Text = "Serial Number"
		'
		'SimpleButton1
		'
		Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Red
		Me.SimpleButton1.Appearance.Options.UseFont = True
		Me.SimpleButton1.Appearance.Options.UseForeColor = True
		Me.SimpleButton1.Location = New System.Drawing.Point(342, 203)
		Me.SimpleButton1.Name = "SimpleButton1"
		Me.SimpleButton1.Size = New System.Drawing.Size(90, 31)
		Me.SimpleButton1.TabIndex = 5
		Me.SimpleButton1.Text = "&Batal"
		'
		'SimpleButton2
		'
		Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
		Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.Green
		Me.SimpleButton2.Appearance.Options.UseFont = True
		Me.SimpleButton2.Appearance.Options.UseForeColor = True
		Me.SimpleButton2.Location = New System.Drawing.Point(246, 203)
		Me.SimpleButton2.Name = "SimpleButton2"
		Me.SimpleButton2.Size = New System.Drawing.Size(90, 31)
		Me.SimpleButton2.TabIndex = 6
		Me.SimpleButton2.Text = "&Aktifkan"
		'
		'txtKode
		'
		Me.txtKode.Location = New System.Drawing.Point(92, 31)
		Me.txtKode.Name = "txtKode"
		Me.txtKode.Properties.ReadOnly = True
		Me.txtKode.Size = New System.Drawing.Size(340, 80)
		Me.txtKode.TabIndex = 2
		'
		'txtSerial
		'
		Me.txtSerial.Location = New System.Drawing.Point(92, 117)
		Me.txtSerial.Name = "txtSerial"
		Me.txtSerial.Size = New System.Drawing.Size(340, 80)
		Me.txtSerial.TabIndex = 4
		'
		'x_Serial
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(444, 248)
		Me.ControlBox = False
		Me.Controls.Add(Me.SimpleButton2)
		Me.Controls.Add(Me.SimpleButton1)
		Me.Controls.Add(Me.LabelControl3)
		Me.Controls.Add(Me.LabelControl2)
		Me.Controls.Add(Me.LabelControl1)
		Me.Controls.Add(Me.txtKode)
		Me.Controls.Add(Me.txtSerial)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "x_Serial"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "NuSoft"
		CType(Me.txtKode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtSerial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents txtKode As DevExpress.XtraEditors.MemoEdit
	Friend WithEvents txtSerial As DevExpress.XtraEditors.MemoEdit
End Class
