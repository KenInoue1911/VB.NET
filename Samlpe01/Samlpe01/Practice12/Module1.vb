Module Module1

    Sub Main()
        Dim num As Integer

        Console.Write("数値を入力してください")
        num = Integer.Parse(Console.ReadLine())

        Do While num > 0
            Console.Write("▲")
            num = num - 1
        Loop
    End Sub

End Module
