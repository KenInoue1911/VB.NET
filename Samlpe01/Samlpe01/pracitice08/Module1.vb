Module Module1

    Sub Main()
        Dim barth As Integer

        Console.Write("誕生日を入力してください")
        barth = Integer.Parse(Console.ReadLine())

        If 13 > barth And 1 <= barth Then
            Console.WriteLine(barth & "月生まれですね")
        Else
            Console.WriteLine("入力された値が不正です")
        End If
    End Sub

End Module
