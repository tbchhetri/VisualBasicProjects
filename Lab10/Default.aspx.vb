'Class Name: BookSale
'Programmer: Tek
'Date: Today's Date
'Description: Handle book sale information.
'Project: Lab 9
Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'change the validation mode
        Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None
    End Sub

    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        'write the code to handel the click
        Dim TheBookSale As BookSale

        'force the validation at the server
        Page.Validate() 'happens at the SERVER, to avoid someone bypassing client side script, for the prople who have HTML and Javascript disabled
        'Check if the valiidaters were successful
        If Page.IsValid = True Then
            Try
                'try to create an instance of book sale and then output results
                TheBookSale = New BookSale(TitleTextBox.Text, Integer.Parse(QuantityTextBox.Text), Decimal.Parse(PriceTextBox.Text))
                ExtendedPriceTextBox.Text = TheBookSale.ExtendedPrice.ToString("c")
                DiscountTextBox.Text = TheBookSale.Discount.ToString("C")
                DiscountedPriceTextBox.Text = TheBookSale.DiscountedPrice.Tostring("c")
            Catch ex As FormatException
                'can't do message box, this would show on the server not on the browser/client
                ErrorLabel.Text = "Enter numeric values: "
            End Try

        Else
            'someone trynna be sneaky
            ErrorLabel.Text = "Must fill out all required fields "
        End If


    End Sub

    Protected Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'clear the form 
        QuantityTextBox.Text = ""
        TitleTextBox.Text = ""
        PriceTextBox.Text = ""
        DiscountTextBox.Text = ""
        ExtendedPriceTextBox.Text = ""
        DiscountedPriceTextBox.Text = ""
    End Sub
End Class