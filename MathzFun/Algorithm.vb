Friend Module Algorithm
	''' <summary>
	''' A function for generating a random number.
	''' </summary>
	''' <returns>Integer</returns>
	Public Function Shuffle() As Integer
		Return Math.Ceiling(Rnd() * 1000)
	End Function

	''' <summary>
	''' Provides the question to the user.
	''' </summary>
	Public Sub Generate()
		Main.Label3.Text = Shuffle().ToString
	End Sub
End Module
