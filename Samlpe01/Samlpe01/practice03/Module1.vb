Module Module1

    Sub Main()
        Console.WriteLine("単価を入力してください")
        Dim prace As Integer = Integer.Parse(Console.ReadLine())

        Console.WriteLine("数量を入力してください")
        Dim value As Integer = Integer.Parse(Console.ReadLine())

        Console.WriteLine("合計金額は" & Format(prace * value, "#,###") & "です")

    End Sub

End Module
