Public Class GlobalRandom
	Private Shared m_random As Random = New Random()

	Public Shared Function NextInt() As Integer
		Return m_random.Next()
	End Function
End Class
