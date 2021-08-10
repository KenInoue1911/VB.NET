Module Module1

    Sub Main()
        Dim score() As Integer = {1, 2, 3, 4}

        For cnt As Integer = 0 To 3
            Console.WriteLine("スコアは" & score(cnt) & "番号は" & (cnt + 1))
        Next
    End Sub

End Module
