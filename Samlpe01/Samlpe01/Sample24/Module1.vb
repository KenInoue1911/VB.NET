Module Module1
    Sub MyComp(x As Integer, y As Integer)

        Dim z As Integer

        If x > y Then
            z = x
        Else
            z = y
        End If

        Console.WriteLine("大きい値は" & z)
        Console.WriteLine()
    End Sub

    Sub Main()
        Dim a As Integer
        Dim b As Integer

        Console.Write("整理値を入力")
        a = Integer.Parse(Console.ReadLine())

        Console.Write("整理値を入力")
        b = Integer.Parse(Console.ReadLine())

        MyComp(a, b)

    End Sub

End Module
