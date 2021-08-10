Module Module1

    Sub Multi(x As Integer)
        Console.WriteLine("2乗した値は" & x * x & "です")
    End Sub

    Sub Main()
        Dim num As Integer
        Console.Write("数値を入力してください")
        num = Integer.Parse(Console.ReadLine())

        Multi(num)

    End Sub

End Module
