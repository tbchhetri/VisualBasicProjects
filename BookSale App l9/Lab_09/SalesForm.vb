'Program:		Lab #9
'Programmer:	Tek Chhetri
'Date:			3/24/2021 
'Description:	Calculate sales price using the BookSale class.
'				Instantiate TheBookSale as a new object of the BookSale class.

Public Class SalesForm
    ' Declare the new object.
    Private TheBookSale As BookSale
    Private TheStudentBookSale As StudentBookSale

    Private Sub CalculateSaleToolStripMenuItem_Click(ByVal sender As System.Object,
     ByVal e As System.EventArgs) Handles CalculateSaleToolStripMenuItem.Click
        ' Calculate the extended price for the sale.

        Try
            'is it a student or retail
            If StudentCheckBox.Checked Then
                'this is a student
                'Dim obj As New StudentBookSale
                TheStudentBookSale = New StudentBookSale(TitleTextBox.Text,
                 Integer.Parse(QuantityTextBox.Text), Decimal.Parse(PriceTextBox.Text))
                'we now have access to anything marked as public in the base class
                'can't access protected or private
                ExtendedPriceTextBox.Text = TheStudentBookSale.ExtendedPrice.ToString("C")
            Else
                'this Is retail
                TheBookSale = New BookSale(TitleTextBox.Text,
                 Integer.Parse(QuantityTextBox.Text), Decimal.Parse(PriceTextBox.Text))
                ' Calculate and format the result.
                ExtendedPriceTextBox.Text = TheBookSale.ExtendedPrice.ToString("c")
            End If

        Catch ex As Exception
            MessageBox.Show("Enter numeric data.", "R 'n R Book Sales",
              MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

        'open the summary form
        'SummaryForm.SalesCountTextBox.Text = BookSale.SalesCount.ToString
        'SummaryForm.ShowDialog() 'this wil open modally ie can't switch back and forth
        SummaryForm.Show() 'to open modelesly

    End Sub

    Private Sub SalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
