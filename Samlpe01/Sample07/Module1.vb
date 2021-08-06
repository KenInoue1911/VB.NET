Module Module1

    Sub Main()
        Dim score As Integer
        Console.Write("点数を入力してください")
        score = Integer.Parse(Console.ReadLine())

        If score >= 80 Then
            Console.WriteLine("合格です")
        ElseIf score >= 60 Then
            Console.WriteLine("補欠合格です")
        ElseIf score >= 40 Then
            Console.WriteLine("再試験です")
        Else
            Console.WriteLine("不合格です")
        End If

        Console.WriteLine("処理を終了します")

    End Sub

End Module
