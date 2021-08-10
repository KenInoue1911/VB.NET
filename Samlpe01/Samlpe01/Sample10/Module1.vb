Module Module1

    Sub Main()
        Dim fire As Integer
        Console.Write("火力を選んでください(1～3)")
        fire = Integer.Parse(Console.ReadLine())

        Select Case (fire)
            Case 1
                Console.WriteLine("弱火にしました")
            Case 2
                Console.WriteLine("中火にしました")
            Case 3
                Console.WriteLine("強火にしました")
            Case Else
                Console.WriteLine("1～3で選んでください")
        End Select
    End Sub

End Module
