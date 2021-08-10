Module Module1

    Sub Main()
        Dim hour As Integer
        Dim min As Integer

        Console.Write("時間を入力してください")
        hour = Integer.Parse(Console.ReadLine())

        Console.Write("分を入力してください")
        min = Integer.Parse(Console.ReadLine())

        If hour <= 23 And min <= 59 Then
            Console.WriteLine("入力された時刻は" & hour & ":" & min & "です")
        Else
            Console.WriteLine("入力された値が不正です")
        End If
    End Sub

End Module
