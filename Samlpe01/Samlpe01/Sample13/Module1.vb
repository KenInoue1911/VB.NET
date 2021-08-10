Module Module1

    Sub Main()
        Dim password As String = "ABCD"
        Dim input As String

        Do
            Console.Write("パスワードを入力してください")
            input = Console.ReadLine()

        Loop While input <> password
    End Sub

End Module
