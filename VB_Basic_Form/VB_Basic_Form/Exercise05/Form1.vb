Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox3.Enabled = True

        Else
            TextBox3.Enabled = False

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Dim num2 As Double
        Dim num3 As Double

        num1 = Integer.Parse(TextBox1.Text)
        num2 = 0
        num3 = 0


        If TextBox3.Enabled = True Then

            num3 = Integer.Parse(TextBox3.Text) / 100

        End If

        If RadioButton1.Checked = True Then

            num2 = Integer.Parse(TextBox2.Text) / 100

        End If

        Label4.Text = Math.Truncate(num1 * (1 + num2)) * (1 - num3)





    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class
