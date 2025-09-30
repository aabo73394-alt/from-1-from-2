Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module modulel
        Public x, y As Integer
    End Module

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton3_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x = Integer.Parse(TextBox1.Text)
        Y = Integer.Parse(TextBox2.Text)
    End Sub
End Class
