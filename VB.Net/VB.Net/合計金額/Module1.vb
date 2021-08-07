Module Module1

    Sub Main()
        Dim one As Integer
        Dim two As Integer
        Dim total As Integer

        Console.Write("単価を入力してください")
        one = Integer.Parse(Console.ReadLine())

        Console.Write("数量を入力してください")
        two = Integer.Parse(Console.ReadLine())

        total = one + two
        Console.Write("合計金額は" & Format(total, "#,###") & "円です")
    End Sub

End Module
