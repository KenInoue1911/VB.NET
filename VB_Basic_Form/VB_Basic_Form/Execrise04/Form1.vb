Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Dim num2 As Double


        num1 = Integer.Parse(TextBox1.Text)
        num2 = Integer.Parse(TextBox2.Text) / 100



        Label3.Text = Math.Truncate(num1 * (1 + num2))

    End Sub
End Class
