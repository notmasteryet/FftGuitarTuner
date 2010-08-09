Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports SoundCapture
Imports SoundAnalysis

Class SoundFrequencyInfoSource
	Inherits FrequencyInfoSource
	Private device As SoundCaptureDevice
	Private adapter As _Adapter

	Friend Sub New(device As SoundCaptureDevice)
		Me.device = device
	End Sub

	Public Overrides Sub Listen()
		adapter = New _Adapter(Me, device)
		adapter.Start()
	End Sub

	Public Overrides Sub [Stop]()
		adapter.[Stop]()
	End Sub

	Private Class _Adapter
		Inherits SoundCaptureBase
		Private owner As SoundFrequencyInfoSource

		Const MinFreq As Double = 60
		Const MaxFreq As Double = 1300

		Friend Sub New(owner As SoundFrequencyInfoSource, device As SoundCaptureDevice)
			MyBase.New(device)
			Me.owner = owner
		End Sub

		Protected Overrides Sub ProcessData(data As Short())
			Dim x As Double() = New Double(data.Length - 1) {}
			For i As Integer = 0 To x.Length - 1
				x(i) = data(i) / 32768.0
			Next

			Dim freq As Double = FrequencyUtils.FindFundamentalFrequency(x, SampleRate, MinFreq, MaxFreq)
			owner.OnFrequencyDetected(New FrequencyDetectedEventArgs(freq))
		End Sub
	End Class
End Class
