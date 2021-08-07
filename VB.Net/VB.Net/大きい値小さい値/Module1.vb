Module Module1

    Sub Main()
        Dim one As Integer
        Dim two As Integer
        Dim total As Integer

        Console.Write("1つ目の数値を入力してください")
        one = Integer.Parse(Console.ReadLine())

        Console.Write("2つ目の数値を入力してください")
        two = Integer.Parse(Console.ReadLine())

        total = one + two

        If one > two Then
            Console.WriteLine("大きい値は" & one & "です")

        ElseIf two > one Then
            Console.WriteLine("大きい値は" & two & "です")

        Else
            Console.WriteLine("2つの値は等しいです")
        End If
    End Sub

End Module
