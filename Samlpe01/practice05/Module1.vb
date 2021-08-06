Module Module1

    Sub Main()
        Dim age As Integer
        Console.WriteLine("年齢を入力してください")
        age = Integer.Parse(Console.ReadLine())

        If age >= 100 Then
            Console.WriteLine("長命です")
        ElseIf age >= 70 Then
            Console.WriteLine("悠々自適です")
        ElseIf age >= 20 Then
            Console.WriteLine("働き盛りです")
        ElseIf age >= 0 Then
            Console.WriteLine("学習中です")
        Else
            Console.WriteLine("負の値が入力されました")
        End If
    End Sub

End Module
