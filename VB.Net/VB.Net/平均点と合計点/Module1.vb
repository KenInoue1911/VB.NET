Module Module1

    Sub Main()
        Dim one As Integer
        Dim two As Integer
        Dim three As Integer
        Dim total As Integer
        Dim avarege As Double

        Console.Write("第1科目の結果を入力してください")
        one = Integer.Parse(Console.ReadLine())

        Console.Write("第２科目の結果を入力してください")
        two = Integer.Parse(Console.ReadLine())

        Console.Write("第3科目の結果を入力してください")
        three = Integer.Parse(Console.ReadLine())

        total = one + two + three
        Console.WriteLine("合計点は" & total & "点です")

        avarege = total / 3
        Console.WriteLine("平均点は" & Format(avarege, "#.#") & "点です")
    End Sub

End Module
