Module Module1

    Sub Main()
        Dim one As Integer
        Dim two As Integer
        Dim three As Integer

        Dim total As Integer
        Dim avarege As Double

        Console.WriteLine("第1科目の結果を入力してください")
        one = Console.ReadLine()

        Console.WriteLine("第2科目の結果を入力してください")
        two = Console.ReadLine()

        Console.WriteLine("第3科目の結果を入力してください")
        three = Console.ReadLine()

        total = one + two + three

        Console.WriteLine("合計は" & total & "点です")

        avarege = total / 3

        Console.WriteLine("平均点は" & Format(avarege, "#,#") & "点です")


    End Sub

End Module
