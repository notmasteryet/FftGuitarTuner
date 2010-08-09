Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports SoundCapture

Public Partial Class SelectDeviceForm
	Inherits Form
	Private devices As SoundCaptureDevice()

	Public ReadOnly Property SelectedDevice() As SoundCaptureDevice
		Get
			Return devices(deviceNamesListBox.SelectedIndex)
		End Get
	End Property

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub SelectDeviceForm_Load(sender As Object, e As EventArgs)
		LoadDevices()
	End Sub

	Private Sub LoadDevices()
		deviceNamesListBox.Items.Clear()

		Dim defaultDeviceIndex As Integer = 0

		devices = SoundCaptureDevice.GetDevices()
		For i As Integer = 0 To devices.Length - 1
			deviceNamesListBox.Items.Add(devices(i).Name)
			If devices(i).IsDefault Then
				defaultDeviceIndex = i
			End If
		Next

		deviceNamesListBox.SelectedIndex = defaultDeviceIndex
	End Sub

	Private Sub deviceNamesListBox_DoubleClick(sender As Object, e As EventArgs)
		If deviceNamesListBox.SelectedIndex < 0 Then
			Return
		End If

		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub
End Class
