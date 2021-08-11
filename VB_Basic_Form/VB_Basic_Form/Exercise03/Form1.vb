Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim num3 As Integer
        Dim num4 As Integer
        Dim num5 As Integer

        num1 = Integer.Parse(TextBox1.Text)
        num2 = Integer.Parse(TextBox2.Text)
        num3 = Integer.Parse(TextBox3.Text)

        num4 = (num1 * num2) / num3
        num5 = (num1 * num2) Mod num3

        Label4.Text = "割り勘" & Format(num4, "#,##") & "円"
        Label5.Text = "端数" & num5 & "円"

    End Sub
End Class
