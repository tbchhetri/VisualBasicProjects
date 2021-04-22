'Program:		Lab #7
'Programmer:	Tek Chhetri
'Date:			3/17/2021
'Description:	Calculate sales price using the BookSale class.
'				Instantiate TheBookSale as a new object of the BookSale class.

Public Class SalesForm
    ' Declare the new object.
    'Private TheBookSale As BookSaleClass 'here we only created a reference, hence we can't use it
    Private TheBookSale As BookSaleClass

    Private Sub CalculateSaleToolStripMenuItem_Click(ByVal sender As System.Object,
     ByVal e As System.EventArgs) Handles CalculateSaleToolStripMenuItem.Click
        ' Calculate the extended price for the sale.
        Try
            ' instantiate the object and set property
            'TheBookSale = New BookSaleClass
            TheBookSale = New BookSaleClass(TitleTextBox.Text,
                                            Integer.Parse(QuantityTextBox.Text),
                                            Decimal.Parse(PriceTextBox.Text))

            ExtendedPriceTextBox.Text = TheBookSale.ExtendedPrice.ToString("C")
        Catch ex As formatException

        End Try
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        ' Clear the screen controls.

        QuantityTextBox.Clear()
        PriceTextBox.Clear()
        ExtendedPriceTextBox.Clear()
        With TitleTextBox
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ' Exit the program.

        Me.Close()
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        ' Display the sales summary information.
        Dim MessageString As String

        MessageString = "Sales Total: " & BookSaleClass.SalesTotal.ToString("C") & vbCrLf
        MessageString &= "Sales Count: " & BookSaleClass.SalesCount.ToString

        MessageBox.Show(MessageString)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog() 'says oopen up a window modelly
    End Sub
End Class
