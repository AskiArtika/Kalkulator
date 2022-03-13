Public Class Kalkulator
    Dim x, y, r As Integer
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        r = x - y
        TextBox3.Text = r
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        r = x * y
        TextBox3.Text = r
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        r = x / y
        TextBox3.Text = r
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        r = x + y
        TextBox3.Text = r
    End Sub
End Class