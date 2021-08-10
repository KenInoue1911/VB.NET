Module Module1

    Sub Main()
        Dim math As Integer
        Dim eng As Integer

        Console.Write("数学の点数を入力してください")
        math = Integer.Parse(Console.ReadLine())

        Console.Write("英語の点数を入力してください")
        eng = Integer.Parse(Console.ReadLine())

        If math >= 80 And eng >= 80 Then
            Console.WriteLine("合格です")
        Else
            Console.WriteLine("負合格です")
        End If

        Console.WriteLine("処理を終了します")

    End Sub

End Module
