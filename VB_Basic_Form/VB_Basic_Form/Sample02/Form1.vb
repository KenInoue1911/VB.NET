Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String

        name = TextBox1.Text
        Label1.Text = name & "さん、こんにちは"
    End Sub
End Class
