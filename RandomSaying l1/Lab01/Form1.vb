Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Documentation/comments
        'close out of the program
        Me.Close() 'paranthesis usually indicates method/array

    End Sub

    Private Sub Saying1Button_Click(sender As Object, e As EventArgs) Handles Saying1Button.Click
        'display a saying to the screeen
        MessageLabel.Text = "Let's Go Pens!" 'Doublequotation for string
    End Sub

    Private Sub Saying2Button_Click(sender As Object, e As EventArgs) Handles Saying2Button.Click
        MessageLabel.Text = "The early bird gets the worm"
    End Sub

    Private Sub Saying3Button_Click(sender As Object, e As EventArgs) Handles Saying3Button.Click
        MessageLabel.Text = "The greatest glory in living lies not in never falling, but in rising every time we fall"
    End Sub

    Private Sub Saying4Button_Click(sender As Object, e As EventArgs) Handles Saying4Button.Click
        MessageLabel.Text = "The way to get started is to quit talking and begin doing"
    End Sub
End Class
