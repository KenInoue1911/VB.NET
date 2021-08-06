Module Module1

    Sub Main()
        Dim one As Integer

        Console.Write("数字を入力してください")
        one = Integer.Parse(Console.ReadLine())
        If one Mod 2 = 0 Then
            Console.WriteLine("入力された値は偶数です")
        Else
            Console.WriteLine("入力された値は奇数です")
        End If


    End Sub

End Module
