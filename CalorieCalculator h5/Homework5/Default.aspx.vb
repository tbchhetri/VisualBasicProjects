'By: TBC
'What: Create a website that calculates the total of fat, carbohydrate, and protein calories. Allow the user to enter (in text boxes) the grams of fat, the grams of carbohydrates, and the grams of protein. Each gram of fat is nine calories; a gram of protein or carbohydrate is four calories.
Public Class _Default
    Inherits System.Web.UI.Page

    Private CalculationsObject As CalculationsClass 'object creation
    Dim _ItemsInteger As Integer 'this gets reinitialized every time we hit submit, http is stateless
    Dim _TotalCaloriesDecimal As Decimal

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'First thing that runs
        _ItemsInteger = GetHiddenItems() '
        _TotalCaloriesDecimal = GetHiddenCalories()
        'DisplayTotals()
    End Sub

    Protected Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        'Creates an instance of your class using the overloaded constructor
        'Displays resulting output from calculation
        'Displays totals on the screen 

        Try
            'This is how we pass info from Default to the class
            CalculationsObject = New CalculationsClass(Decimal.Parse(FatsTextBox.Text), Decimal.Parse(CarbsTextBox.Text), Decimal.Parse(ProteinTextBox.Text))
            _ItemsInteger += 1 ' Keeping track of the number of entries, this is directly linked to  the HiddenFields, see functions below

            'DISPLAY
            CaloriesTextBox.Text = CalculationsObject.ItemCaloriesFunction().ToString
            _TotalCaloriesDecimal += Decimal.Parse(CaloriesTextBox.Text) ' Keeping track of total Calories, this is also linked with the HiddenFields
            DisplayTotals()
            UpdateTotals()
        Catch ex As Exception
        End Try
    End Sub

    Function GetHiddenItems() As Integer
        'This functions get the current value from the Hidden Field value which was created and initialized in the design
        Dim ItemsHiddenInteger As Integer

        ItemsHiddenInteger = Decimal.Parse(ItemsHiddenField.Value) 'get the current value from the hidden field

        Return ItemsHiddenInteger
    End Function

    Function GetHiddenCalories() As Decimal
        'This functions get the current value from the Hidden Field value which was created and initialized in the design
        '?????????Made two functions cuz I needed two returns, could have prob used 2 object level variables
        Dim HiddenDecimal As Decimal

        HiddenDecimal = Decimal.Parse(TotalCaloriesHiddenField.Value) 'get the current value from the hidden field

        Return HiddenDecimal
    End Function

    Sub UpdateTotals()
        'update the hiddenField with new total
        ItemsHiddenField.Value = _ItemsInteger.ToString
        TotalCaloriesHiddenField.Value = _TotalCaloriesDecimal.ToString
    End Sub

    Sub DisplayTotals()
        'display the totals in the respective textBoxes
        TotalItemsTextBox.Text = _ItemsInteger.ToString
        TotalCaloriesTextBox.Text = _TotalCaloriesDecimal.ToString
    End Sub

    Protected Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'clears all fields and calories
        FatsTextBox.Text = ""
        CarbsTextBox.Text = ""
        ProteinTextBox.Text = ""
        CaloriesTextBox.Text = ""
    End Sub

    Protected Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        'resets and clears everything 
        TotalCaloriesHiddenField.Value = 0
        ItemsHiddenField.Value = 0
        TotalCaloriesTextBox.Text = ""
        TotalItemsTextBox.Text = ""

        FatsTextBox.Text = ""
        CarbsTextBox.Text = ""
        ProteinTextBox.Text = ""
        CaloriesTextBox.Text = ""
    End Sub
End Class