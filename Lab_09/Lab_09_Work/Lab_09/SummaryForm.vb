Public Class SummaryForm
    Private Sub SummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initialization
        SalesCountTextBox.Text = BookSale.SalesCount.ToString
        SalesTotalTextBox.Text = BookSale.SalesTotal.ToString("c")
        SalesDiscountTextBox.Text = StudentBookSale.DiscountTotal.ToString("c")
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        Me.Close()
    End Sub

    Private Sub SummaryForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'this happens everytime the form is focused
        SalesCountTextBox.Text = BookSale.SalesCount.ToString
        SalesTotalTextBox.Text = BookSale.SalesTotal.ToString("c")
        SalesDiscountTextBox.Text = StudentBookSale.DiscountTotal.ToString("c")
    End Sub
End Class