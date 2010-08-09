Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports SoundCapture

Public Partial Class MainForm
	Inherits Form
	Private m_isListenning As Boolean = False

	Public ReadOnly Property IsListenning() As Boolean
		Get
			Return m_isListenning
		End Get
	End Property

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub closeButton_Click(sender As Object, e As EventArgs)
		Close()
	End Sub

	Private frequencyInfoSource As FrequencyInfoSource

	Private Sub StopListenning()
		m_isListenning = False
		frequencyInfoSource.[Stop]()
		RemoveHandler frequencyInfoSource.FrequencyDetected, New EventHandler(Of FrequencyDetectedEventArgs)(AddressOf frequencyInfoSource_FrequencyDetected)
		frequencyInfoSource = Nothing
	End Sub

	Private Sub StartListenning(device As SoundCaptureDevice)
		m_isListenning = True
		frequencyInfoSource = New SoundFrequencyInfoSource(device)
		AddHandler frequencyInfoSource.FrequencyDetected, New EventHandler(Of FrequencyDetectedEventArgs)(AddressOf frequencyInfoSource_FrequencyDetected)
		frequencyInfoSource.Listen()
	End Sub

	Private Sub frequencyInfoSource_FrequencyDetected(sender As Object, e As FrequencyDetectedEventArgs)
		If InvokeRequired Then
			BeginInvoke(New EventHandler(Of FrequencyDetectedEventArgs)(AddressOf frequencyInfoSource_FrequencyDetected), sender, e)
		Else
			UpdateFrequecyDisplays(e.Frequency)
		End If
	End Sub

	Private Sub UpdateFrequecyDisplays(frequency As Double)
		If frequency > 0 Then
			frequenciesScale1.SignalDetected = True
			frequenciesScale1.CurrentFrequency = frequency

			frequencyTextBox.Enabled = True
			frequencyTextBox.Text = frequency.ToString("f3")

			Dim closestFrequency As Double
			Dim noteName As String = Nothing
			FindClosestNote(frequency, closestFrequency, noteName)
			closeFrequencyTextBox.Enabled = True
			closeFrequencyTextBox.Text = closestFrequency.ToString("f3")
			noteNameTextBox.Enabled = True
			noteNameTextBox.Text = noteName
		Else
			frequenciesScale1.SignalDetected = False

			frequencyTextBox.Enabled = False
			closeFrequencyTextBox.Enabled = False
			noteNameTextBox.Enabled = False
		End If

	End Sub

	Shared NoteNames As String() = {"A", "A#", "B/H", "C", "C#", "D", _
		"D#", "E", "F", "F#", "G", "G#"}
	Shared ToneStep As Double = Math.Pow(2, 1.0 / 12)

	Private Sub FindClosestNote(frequency As Double, _
		<Out> ByRef closestFrequency As Double, <Out> ByRef noteName As String)
		Const  AFrequency As Double = 440.0
		Const  ToneIndexOffsetToPositives As Integer = 120

		Dim toneIndex As Integer = CInt(Math.Truncate(Math.Round(Math.Log(frequency / AFrequency, ToneStep))))
		noteName = NoteNames((ToneIndexOffsetToPositives + toneIndex) Mod NoteNames.Length)
		closestFrequency = Math.Pow(ToneStep, toneIndex) * AFrequency
	End Sub

	Private Sub listenButton_Click(sender As Object, e As EventArgs)
		Dim device As SoundCaptureDevice = Nothing
		Using form As New SelectDeviceForm()
			If form.ShowDialog() = DialogResult.OK Then
				device = form.SelectedDevice
			End If
		End Using

		If device IsNot Nothing Then
			StartListenning(device)
			UpdateListenStopButtons()
		End If
	End Sub

	Private Sub UpdateListenStopButtons()
		listenButton.Enabled = Not m_isListenning
		stopButton.Enabled = m_isListenning
	End Sub

	Private Sub stopButton_Click(sender As Object, e As EventArgs)
		StopListenning()
		UpdateListenStopButtons()
	End Sub

	Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs)
		If IsListenning Then
			StopListenning()
		End If
	End Sub
End Class
