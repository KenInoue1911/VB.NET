Module Module1

    Sub Main()
        Dim fire As Integer
        Console.Write("火力を選んでください（1～3）")
        fire = Integer.Parse(Console.ReadLine())

        If fire = 1 Then
            Console.WriteLine("弱火にしました")
        ElseIf fire = 2 Then
            Console.WriteLine("中火にしました")
        ElseIf fire = 3 Then
            Console.WriteLine("強火にしました")
        Else
            Console.WriteLine("1～3で選んでください")
        End If
    End Sub

End Module
