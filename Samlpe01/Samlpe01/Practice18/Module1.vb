Module Module1
    Sub Star()
        Console.Write("★")
    End Sub

    Sub Main()
        Dim num As Integer
        Console.Write("表示回数を入力")
        num = Integer.Parse(Console.ReadLine())

        Do While num > 0
            Star()
            num -= 1
        Loop


    End Sub

End Module
