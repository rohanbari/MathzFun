Public Class Main
	Private best As Byte = My.Settings.pBest
	Private correct As Byte
	Private answered As Byte
	Private time As Byte
	Private isEven As Boolean

	Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If best = 0 Then
		Else
			Label4.Text = "Personal Best: " + best.ToString
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		sender.Enabled = False
		Generate()
		Clock.Start()

		Button2.Enabled = True
		Button3.Enabled = True
	End Sub

	Private Sub Buttons_Click(sender As Object, e As EventArgs) _
		Handles Button2.Click, Button3.Click

		Generate()
		isEven = CInt(Label3.Text) Mod 2 <> 1

		If isEven Then
			If sender.Text = "Odd" Then
				answered += 1
			Else
				answered += 1
				correct += 1
			End If
		Else
			If sender.Text = "Even" Then
				answered += 1
			Else
				correct += 1
				answered += 1
			End If
		End If
	End Sub

	Private Sub Clock_Tick(sender As Object, e As EventArgs) Handles Clock.Tick
		time += 1
		Label2.Text = time.ToString + " / 30 seconds elapsed"

		If time = 30 Then
			Clock.Stop()
			time = 0

			Button1.Enabled = True
			Button2.Enabled = False
			Button3.Enabled = False

			Label2.Text = "Time is up!"
			Label3.Text = correct.ToString + " correct / " + answered.ToString + " answers"

			If correct > best Then
				My.Settings.pBest = correct
				My.Settings.Save()

				Label4.Text = "Personal Best: " + best.ToString + " correct answers"
			End If
		End If
	End Sub
End Class
