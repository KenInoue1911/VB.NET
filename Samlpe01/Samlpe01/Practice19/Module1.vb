Module Module1

    Sub Star(x As Integer)
        For cnt As Integer = 1 To x
            Console.Write("★")
        Next
    End Sub

    Sub Main()
        Dim num As Integer

        Console.Write("表示回数")
        num = Integer.Parse(Console.ReadLine())

        Star(num)
    End Sub

End Module
