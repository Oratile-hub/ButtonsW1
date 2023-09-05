Public Class Form1
    Private Sub btnButton_Click(sender As Object, e As EventArgs) Handles btnButton.Click

        MsgBox("Hi Oratile")
        MsgBox("How are you?")


    End Sub

    Private Sub askAge_Click(sender As Object, e As EventArgs) Handles askAge.Click
        MsgBox("How old are you?")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles anotherWay.Click

        MessageBox.Show("This is another way of writting my message!")

        MessageBox.Show("This is how fast I go")

    End Sub
End Class
