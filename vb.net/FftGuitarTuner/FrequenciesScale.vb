Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing

Public Partial Class FrequenciesScale
	Inherits UserControl
	Const MinFrequency As Double = 70
	Const MaxFrequency As Double = 1200
	Const AFrequency As Double = 440
	Shared ToneStep As Double = Math.Pow(2, 1.0 / 12)
	Shared Labels As ScaleLabel() = {New ScaleLabel() With { _
		.Title = "E", _
		.Frequency = 82.4069, _
		.Color = Color.LightGreen _
	}, New ScaleLabel() With { _
		.Title = "A", _
		.Frequency = 110.0, _
		.Color = Color.LightGreen _
	}, New ScaleLabel() With { _
		.Title = "D", _
		.Frequency = 146.8324, _
		.Color = Color.LightGreen _
	}, New ScaleLabel() With { _
		.Title = "G", _
		.Frequency = 195.9977, _
		.Color = Color.LightGreen _
	}, New ScaleLabel() With { _
		.Title = "B", _
		.Frequency = 246.9417, _
		.Color = Color.LightGreen _
	}, New ScaleLabel() With { _
		.Title = "E", _
		.Frequency = 329.6276, _
		.Color = Color.LightGreen _
	}, _
		New ScaleLabel() With { _
		.Title = "", _
		.Frequency = 440.0, _
		.Color = Color.Silver _
	}}

	Private m_currentFrequency As Double

	<DefaultValue(0.0)> _
	Public Property CurrentFrequency() As Double
		Get
			Return m_currentFrequency
		End Get
		Set
			If m_currentFrequency <> value Then
				m_currentFrequency = value
				Invalidate()
			End If
		End Set
	End Property

	Private m_signalDetected As Boolean = False

	<DefaultValue(False)> _
	Public Property SignalDetected() As Boolean
		Get
			Return m_signalDetected
		End Get
		Set
			If m_signalDetected <> value Then
				m_signalDetected = value
				Invalidate()
			End If
		End Set
	End Property

	Public Sub New()
		InitializeComponent()

		InitializeComponent2()
	End Sub

	Public Sub New(container As IContainer)
		container.Add(Me)

		InitializeComponent()

		InitializeComponent2()
	End Sub

	Private Sub InitializeComponent2()
		SetStyle(ControlStyles.ResizeRedraw, True)
		SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
	End Sub

	Shared MarkerPen As New Pen(Color.Black)
	Shared ActiveSliderBrush1 As Brush = New SolidBrush(Color.GreenYellow)
	Shared ActiveSliderBrush2 As Brush = New SolidBrush(Color.Green)
	Shared InactiveSliderBrush1 As Brush = New SolidBrush(Color.FromArgb(70, Color.Gray))
	Shared InactiveSliderBrush2 As Brush = New SolidBrush(Color.FromArgb(50, Color.Black))
	Const DisplayPadding As Integer = 5
	Const MarkWidth As Integer = 6
	Const LabelMarkSize As Integer = 9

	Protected Overrides Sub OnPaint(e As PaintEventArgs)
		'base.OnPaint(e);

		Dim minStep As Integer = CInt(Math.Truncate(Math.Floor(GetToneStep(MinFrequency))))
		Dim maxStep As Integer = CInt(Math.Truncate(Math.Ceiling(GetToneStep(MaxFrequency))))

		Dim center As Integer = Width \ 2

		Dim totalSteps As Integer = maxStep - minStep
		Dim stepSize As Single = CSng(Me.Height - 2 * DisplayPadding) / totalSteps

		For i As Integer = 0 To totalSteps
			Dim y As Single = stepSize * i + DisplayPadding

			e.Graphics.DrawLine(MarkerPen, center - MarkWidth \ 2, y, center + MarkWidth \ 2, y)
		Next

		Dim maxTextWidth As Single = e.Graphics.MeasureString("W", Font).Width
		For Each label As ScaleLabel In Labels
			Dim labelBrush As Brush = New SolidBrush(label.Color)
			Dim labelStep As Double = GetToneStep(label.Frequency)
			Dim labelPosition As Single = CSng(stepSize * (maxStep - labelStep) + DisplayPadding)

			Dim labelMarkPosition As New RectangleF(DisplayPadding, labelPosition - LabelMarkSize \ 2, LabelMarkSize, LabelMarkSize)
			e.Graphics.FillEllipse(labelBrush, labelMarkPosition)
			e.Graphics.DrawEllipse(MarkerPen, labelMarkPosition)
			e.Graphics.FillEllipse(Brushes.White, DisplayPadding + LabelMarkSize \ 5, labelPosition - LabelMarkSize \ 3, LabelMarkSize \ 3, LabelMarkSize \ 3)

			Dim titleSize As SizeF = e.Graphics.MeasureString(label.Title, Font)

			e.Graphics.DrawString(label.Title, Font, Brushes.Black, New PointF(Width - DisplayPadding - maxTextWidth / 2 - titleSize.Width / 2, labelPosition - titleSize.Height / 2))
		Next

		If CurrentFrequency > 0 Then
			Dim sliderBrush1 As Brush, sliderBrush2 As Brush
			If Not SignalDetected Then
				sliderBrush1 = InactiveSliderBrush1
				sliderBrush2 = InactiveSliderBrush2
			Else
				sliderBrush1 = ActiveSliderBrush1
				sliderBrush2 = ActiveSliderBrush2
			End If

			Dim sliderStep As Double = GetToneStep(CurrentFrequency)
			Dim sliderPosition As Single = CSng(stepSize * (maxStep - sliderStep) + DisplayPadding)

			e.Graphics.FillPolygon(sliderBrush1, New PointF() {New PointF(center - 10, sliderPosition), New PointF(center, sliderPosition - 5), New PointF(center, sliderPosition + 5), New PointF(center + 10, sliderPosition)})
			e.Graphics.FillPolygon(sliderBrush2, New PointF() {New PointF(center - 10, sliderPosition), New PointF(center, sliderPosition + 5), New PointF(center, sliderPosition - 5), New PointF(center + 10, sliderPosition)})
		End If

	End Sub

	Private Function GetToneStep(frequency As Double) As Double
		Return Math.Log(frequency / AFrequency, ToneStep)
	End Function

	Private Class ScaleLabel
		Public Title As String
		Public Frequency As Double
		Public Color As Color
	End Class
End Class
