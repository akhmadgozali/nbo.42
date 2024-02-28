Friend Class x_Serial
	Private _mode As Mode

	Enum Mode
		User
		Admin
	End Enum
	Sub New(mode As Mode)
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		Icon = My.Resources.NusoftIcon
		If mode = x_Serial.Mode.User Then
			txtKode.Properties.ReadOnly = True
			txtSerial.Properties.ReadOnly = False
			SimpleButton2.Text = "&Aktifkan"
			txtKode.Text = Utils.Serial.GetSerialCode
			txtSerial.Focus()
		Else
			txtKode.Properties.ReadOnly = False
			txtSerial.Properties.ReadOnly = True
			SimpleButton2.Text = "&Generate"
			txtKode.Focus()
		End If
		_mode = mode
	End Sub

	Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
		If _mode = Mode.User Then
			If txtSerial.Text = GetPublicKey() Then
				Dim objWriter As New System.IO.StreamWriter(My.Application.Info.DirectoryPath & "\" & txtKode.Text)
				objWriter.Write(txtSerial.Text)
				objWriter.Close()

				Me.DialogResult = Windows.Forms.DialogResult.OK
			Else
				DevExpress.XtraEditors.XtraMessageBox.Show("Serial yang anda masukkan salah.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
		Else
			txtSerial.Text = GetPublicKey()
		End If
	End Sub
	Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
		Me.DialogResult = Windows.Forms.DialogResult.Cancel
	End Sub

	Private Function GetPublicKey() As String
		Dim h As New NuSoft.Utils.Cryptograph.Encryption.Hash(Utils.Cryptograph.Encryption.Hash.Provider.SHA512)
		Dim d As New NuSoft.Utils.Cryptograph.Encryption.Data(txtKode.Text)
		h.Calculate(d)
		Return h.Value.ToHex
	End Function
End Class