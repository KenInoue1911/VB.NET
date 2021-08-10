Module Module1

    Sub Main()
        Dim score(2) As Integer

        For cnt As Integer = 0 To 2
            Console.Write((cnt + 1) & "の結果を入力")
            score(cnt) = Integer.Parse(Console.ReadLine())
        Next
        Console.WriteLine()

        For cnt As Integer = 0 To 2
            Console.WriteLine((cnt + 1) & "の結果" & score(cnt))
        Next
        Console.WriteLine()

        Console.WriteLine("合計点は" & score(0) + score(1) + score(2))
        Console.WriteLine("平均点は" & Format((score(0) + score(1) + score(2)) / 3, "#.#"))

    End Sub

End Module
