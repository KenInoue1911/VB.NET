Module Module1

    Sub Main()
        Dim num As Integer

        Do
            Console.Write("金額を入力してください")
            num += Integer.Parse(Console.ReadLine())

            Console.WriteLine("合計金額は" & num & "円です")
            Console.WriteLine("")

        Loop While num < 1000

        Console.WriteLine("合計金額が1000以上になったので終了します")

    End Sub

End Module
