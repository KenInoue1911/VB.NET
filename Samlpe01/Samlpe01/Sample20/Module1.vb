Module Module1

    Sub Main()
        Dim str As String = "ABCDEF"
        Dim num As Integer = 4

        Console.WriteLine(Left("ABCDEF", 5))
        Console.WriteLine(Left(str, num))
        Console.WriteLine(Left("ABC" & "DEF", 2 * 2))
        Console.WriteLine(Left(str, 2 * 2))

    End Sub

End Module
