Public Class Form1
    Dim firstNum As Single
    Dim secNum As Single
    Dim Answer As Single
    Dim arithas As String


    Private Sub button_clic1(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & "1"
    End Sub
    Private Sub button_clic2(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub
    Private Sub button_clic3(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & "3"
    End Sub
    Private Sub button_clic4(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & "4"
    End Sub
    Private Sub button_clic5(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & "5"
    End Sub
    Private Sub button_clic6(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & "6"
    End Sub
    Private Sub button_clic7(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & "7"
    End Sub
    Private Sub button_clic8(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & "8"
    End Sub
    Private Sub button_clic9(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & "9"
    End Sub
    Private Sub button_clic0(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & "0"
    End Sub
    Private Sub button_clic11(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text & "."
    End Sub
    Private Sub button_clic22(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox1.Text = Math.Sin(Convert.ToDouble(TextBox1.Text) * (Math.PI / 100)).ToString
    End Sub
    Private Sub button_clic21(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox1.Text = Math.Cos(Convert.ToDouble(TextBox1.Text) * (Math.PI / 100)).ToString
    End Sub
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        TextBox1.Text = (Convert.ToDouble(TextBox1.Text) * Convert.ToDouble(TextBox1.Text) * Convert.ToDouble(TextBox1.Text) * Convert.ToDouble(TextBox1.Text)).ToString

    End Sub
    Private Sub button_clic20(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox1.Text = Math.Tan(Convert.ToDouble(TextBox1.Text) * (Math.PI / 100)).ToString
    End Sub
    Private Sub button_clic24(sender As Object, e As EventArgs) Handles Button24.Click
        TextBox1.Text = Math.Log10(Convert.ToDouble(TextBox1.Text)).ToString
    End Sub
    Private Sub button_clic19(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox1.Text = Math.Sqrt(Convert.ToDouble(TextBox1.Text)).ToString
    End Sub
    Private Sub button_clic26(sender As Object, e As EventArgs) Handles Button26.Click
        TextBox1.Text = (Convert.ToDouble(TextBox1.Text) * Convert.ToDouble(TextBox1.Text)).ToString
    End Sub

    Private Sub button_clic12(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Clear()
    End Sub
    Private Sub button_clic18(sender As Object, e As EventArgs) Handles Button18.Click
        firstNum = Val(TextBox1.Text)
        TextBox1.Text = "0"
        arithas = "+"
    End Sub

    Private Sub button_clic17(sender As Object, e As EventArgs) Handles Button17.Click
        firstNum = Val(TextBox1.Text)
        TextBox1.Text = "0"
        arithas = "-"
    End Sub
    Private Sub button_clic16(sender As Object, e As EventArgs) Handles Button16.Click
        firstNum = Val(TextBox1.Text)
        TextBox1.Text = "0"
        arithas = "*"
    End Sub

    Private Sub button_clic15(sender As Object, e As EventArgs) Handles Button15.Click
        firstNum = Val(TextBox1.Text)
        TextBox1.Text = "0"
        arithas = "/"
    End Sub

    Private Sub button_clic13(sender As Object, e As EventArgs) Handles Button13.Click
        secNum = Val(TextBox1.Text)
        If arithas = "+" Then
            Answer = firstNum + secNum
        End If
        secNum = Val(TextBox1.Text)
        If arithas = "-" Then
            Answer = firstNum - secNum
        End If
        secNum = Val(TextBox1.Text)
        If arithas = "*" Then
            Answer = firstNum * secNum
        End If
        secNum = Val(TextBox1.Text)
        If arithas = "/" Then
            Answer = firstNum / secNum
        End If
        TextBox1.Text = Answer
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        If Not TextBox1.Text.Length <= 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        End If
    End Sub


End Class
