Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim office() As String = {"Excel", "Word", "Powerpoint", "Acusses"}

        For Each apri As String In office

            istoffice.items.add(apri)

        Next

    End Sub
End Class
