Module Module1

    Sub Main()
        Dim num As Integer
        Dim money As Integer
        Dim val As Integer

        money = 0

        Do
            Console.Write("1:預入　2:引き出し　3:照会　4:終了 ")
            num = Integer.Parse(Console.ReadLine())

            Select Case num
                Case 1
                    Console.Write("金額を入力してください")
                    val = Integer.Parse(Console.ReadLine())

                    If (money + val) <= 1000000 Then
                        money = money + val

                    Else
                        Console.WriteLine("1000000を超えています")
                    End If

                Case 2
                    Console.Write("金額を入力してください")
                    money = money - Integer.Parse(Console.ReadLine())

                    If (money - val) <= 0 Then
                        money = money - val

                    Else
                        Console.WriteLine("0未満になっています。")
                    End If

                Case 3
                    Console.WriteLine("現在の金額は" & money)
            End Select

            Console.WriteLine()

        Loop While num <> 0
    End Sub

End Module
