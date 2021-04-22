'Class Name: BookSale
'Programmer: Tek
'Date: Today's Date
'Description: Handle book sale information.
'Project: Lab 10
Public Class _Default
    Inherits System.Web.UI.Page
    Dim _DiscountDecimal As Decimal 'this gets reinitialized every time we hit submit, http is stateless
    'the first way we can maintain state is by hidden field
    'another method to do this is using cookie


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'change the validation mode
        'runs every single time we visit
        Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None

        'get the current discount total
        _DiscountDecimal = GetDiscount()


        'check if this the first visit to the page
        If Page.IsPostBack Then ' can also use if not Page.IsPostBack then
            'this is our second+ visit, prob from clicking the button
            'we don't usually use this part
        Else
            'this is out first visit, do initialization
            DisplayDiscount() 'output the discount 
        End If

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

                'outputs
                ExtendedPriceTextBox.Text = TheBookSale.ExtendedPrice.ToString("c")
                DiscountTextBox.Text = TheBookSale.Discount.ToString("C")
                DiscountedPriceTextBox.Text = TheBookSale.DiscountedPrice.ToString("c")

                _DiscountDecimal += TheBookSale.Discount
                'Output the result
                DisplayDiscount()
                'update the HIDDEN fIELD   
                UpdateDiscount()

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

    Sub DisplayDiscount()
        DiscountTotalTextBox.Text = _DiscountDecimal.ToString("c")
    End Sub

    Function GetDiscount() As Decimal
        Dim DiscountDecimal As Decimal

        ' DiscountDecimal = Decimal.Parse(DiscountTotalHiddenField.Value) 'get the current value from the hidden field
        If Request.Cookies("Discount") IsNot Nothing Then
            Try
                DiscountDecimal = Decimal.Parse(Request.Cookies("Discount").Value)
            Catch ex As Exception
                DiscountDecimal = 0
            End Try
        End If

        Return DiscountDecimal
    End Function

    Sub UpdateDiscount()
        'update the hiddenField with new total
        'DiscountTotalHiddenField.Value = _DiscountDecimal.ToString

        'updating cookie now
        Response.Cookies("Discount").Value = _DiscountDecimal.ToString
    End Sub
End Class