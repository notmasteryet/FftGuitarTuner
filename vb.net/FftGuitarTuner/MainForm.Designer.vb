Partial Class MainForm
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
		Me.components = New System.ComponentModel.Container()
		Me.closeButton = New System.Windows.Forms.Button()
		Me.listenButton = New System.Windows.Forms.Button()
		Me.stopButton = New System.Windows.Forms.Button()
		Me.frequencyTextBox = New System.Windows.Forms.TextBox()
		Me.hzLabel = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.closeFrequencyTextBox = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.noteNameTextBox = New System.Windows.Forms.TextBox()
		Me.frequenciesScale1 = New FftGuitarTuner.FrequenciesScale(Me.components)
		Me.SuspendLayout()
		' 
		' closeButton
		' 
		Me.closeButton.Location = New System.Drawing.Point(107, 308)
		Me.closeButton.Name = "closeButton"
		Me.closeButton.Size = New System.Drawing.Size(75, 23)
		Me.closeButton.TabIndex = 5
		Me.closeButton.Text = "Close"
		Me.closeButton.UseVisualStyleBackColor = True
		AddHandler Me.closeButton.Click, New System.EventHandler(AddressOf Me.closeButton_Click)
		' 
		' listenButton
		' 
		Me.listenButton.Location = New System.Drawing.Point(107, 12)
		Me.listenButton.Name = "listenButton"
		Me.listenButton.Size = New System.Drawing.Size(75, 23)
		Me.listenButton.TabIndex = 1
		Me.listenButton.Text = "&Listen..."
		Me.listenButton.UseVisualStyleBackColor = True
		AddHandler Me.listenButton.Click, New System.EventHandler(AddressOf Me.listenButton_Click)
		' 
		' stopButton
		' 
		Me.stopButton.Enabled = False
		Me.stopButton.Location = New System.Drawing.Point(107, 42)
		Me.stopButton.Name = "stopButton"
		Me.stopButton.Size = New System.Drawing.Size(75, 23)
		Me.stopButton.TabIndex = 2
		Me.stopButton.Text = "&Stop"
		Me.stopButton.UseVisualStyleBackColor = True
		AddHandler Me.stopButton.Click, New System.EventHandler(AddressOf Me.stopButton_Click)
		' 
		' frequencyTextBox
		' 
		Me.frequencyTextBox.Location = New System.Drawing.Point(107, 137)
		Me.frequencyTextBox.Name = "frequencyTextBox"
		Me.frequencyTextBox.[ReadOnly] = True
		Me.frequencyTextBox.Size = New System.Drawing.Size(54, 20)
		Me.frequencyTextBox.TabIndex = 3
		Me.frequencyTextBox.TabStop = False
		Me.frequencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		' 
		' hzLabel
		' 
		Me.hzLabel.AutoSize = True
		Me.hzLabel.Location = New System.Drawing.Point(167, 140)
		Me.hzLabel.Name = "hzLabel"
		Me.hzLabel.Size = New System.Drawing.Size(18, 13)
		Me.hzLabel.TabIndex = 4
		Me.hzLabel.Text = "hz"
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(107, 162)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(76, 13)
		Me.label1.TabIndex = 6
		Me.label1.Text = "closest note at"
		' 
		' closeFrequencyTextBox
		' 
		Me.closeFrequencyTextBox.Location = New System.Drawing.Point(107, 180)
		Me.closeFrequencyTextBox.Name = "closeFrequencyTextBox"
		Me.closeFrequencyTextBox.[ReadOnly] = True
		Me.closeFrequencyTextBox.Size = New System.Drawing.Size(54, 20)
		Me.closeFrequencyTextBox.TabIndex = 3
		Me.closeFrequencyTextBox.TabStop = False
		Me.closeFrequencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(167, 183)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(18, 13)
		Me.label2.TabIndex = 4
		Me.label2.Text = "hz"
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(119, 209)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(14, 13)
		Me.label3.TabIndex = 7
		Me.label3.Text = "is"
		' 
		' noteNameTextBox
		' 
		Me.noteNameTextBox.Location = New System.Drawing.Point(139, 206)
		Me.noteNameTextBox.Name = "noteNameTextBox"
		Me.noteNameTextBox.[ReadOnly] = True
		Me.noteNameTextBox.Size = New System.Drawing.Size(33, 20)
		Me.noteNameTextBox.TabIndex = 8
		' 
		' frequenciesScale1
		' 
		Me.frequenciesScale1.BackColor = System.Drawing.Color.White
		Me.frequenciesScale1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.frequenciesScale1.Location = New System.Drawing.Point(12, 12)
		Me.frequenciesScale1.Name = "frequenciesScale1"
		Me.frequenciesScale1.Size = New System.Drawing.Size(67, 319)
		Me.frequenciesScale1.TabIndex = 0
		' 
		' MainForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(194, 344)
		Me.Controls.Add(Me.noteNameTextBox)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.frequenciesScale1)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.hzLabel)
		Me.Controls.Add(Me.closeFrequencyTextBox)
		Me.Controls.Add(Me.frequencyTextBox)
		Me.Controls.Add(Me.stopButton)
		Me.Controls.Add(Me.listenButton)
		Me.Controls.Add(Me.closeButton)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "MainForm"
		Me.Text = "FFT Guitar Tuner"
		AddHandler Me.FormClosing, New System.Windows.Forms.FormClosingEventHandler(AddressOf Me.MainForm_FormClosing)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private closeButton As System.Windows.Forms.Button
	Private listenButton As System.Windows.Forms.Button
	Private stopButton As System.Windows.Forms.Button
	Private frequencyTextBox As System.Windows.Forms.TextBox
	Private hzLabel As System.Windows.Forms.Label
	Private frequenciesScale1 As FrequenciesScale
	Private label1 As System.Windows.Forms.Label
	Private closeFrequencyTextBox As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private noteNameTextBox As System.Windows.Forms.TextBox
End Class

