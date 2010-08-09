Partial Class SelectDeviceForm
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.deviceNamesListBox = New System.Windows.Forms.ListBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.okButton = New System.Windows.Forms.Button()
		Me.cancelButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		' 
		' deviceNamesListBox
		' 
		Me.deviceNamesListBox.FormattingEnabled = True
		Me.deviceNamesListBox.Location = New System.Drawing.Point(12, 25)
		Me.deviceNamesListBox.Name = "deviceNamesListBox"
		Me.deviceNamesListBox.Size = New System.Drawing.Size(267, 134)
		Me.deviceNamesListBox.TabIndex = 1
		AddHandler Me.deviceNamesListBox.DoubleClick, New System.EventHandler(AddressOf Me.deviceNamesListBox_DoubleClick)
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(12, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(95, 13)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Available &Devices:"
		' 
		' okButton
		' 
		Me.okButton.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.okButton.Location = New System.Drawing.Point(123, 168)
		Me.okButton.Name = "okButton"
		Me.okButton.Size = New System.Drawing.Size(75, 23)
		Me.okButton.TabIndex = 2
		Me.okButton.Text = "OK"
		Me.okButton.UseVisualStyleBackColor = True
		' 
		' cancelButton
		' 
		Me.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.cancelButton.Location = New System.Drawing.Point(204, 168)
		Me.cancelButton.Name = "cancelButton"
		Me.cancelButton.Size = New System.Drawing.Size(75, 23)
		Me.cancelButton.TabIndex = 3
		Me.cancelButton.Text = "Cancel"
		Me.cancelButton.UseVisualStyleBackColor = True
		' 
		' SelectDeviceForm
		' 
		Me.AcceptButton = Me.okButton
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.cancelButton
		Me.ClientSize = New System.Drawing.Size(291, 203)
		Me.Controls.Add(Me.cancelButton)
		Me.Controls.Add(Me.okButton)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.deviceNamesListBox)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "SelectDeviceForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Select Device"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.SelectDeviceForm_Load)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private deviceNamesListBox As System.Windows.Forms.ListBox
	Private label1 As System.Windows.Forms.Label
	Private okButton As System.Windows.Forms.Button
	Private Shadows cancelButton As System.Windows.Forms.Button
End Class
