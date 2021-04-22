'Project: Lab 6 
'Author: Tek Chhetri
'Date: Spring 21
'Description: Description of the form being created 

Public Class SalarySurvey
    Dim TotalInteger(8) As Integer
    Const BASE_SALARY_DECIMAL As Decimal = 250
    Const COMMISION_BASE_DECIMAl As Decimal = 0.15

    ' handles Calculate Button's Click event
    Private Sub calculateButton_Click(sender As Object,
       e As EventArgs) Handles calculateButton.Click
        Dim SalesAmountDecimal As Decimal ' represents the sales they key in 
        Dim SalaryDecimal As Decimal
        Dim IndexInteger As Integer

        Try
            'validate the sales amount
            'SalesAmountDecimal = Decimal.Parse(amountTextBox.Text)
            SalesAmountDecimal = Convert.ToDecimal(amountTextBox.Text)

            'we got a number
            If SalesAmountDecimal < 0 Then
                MessageBox.Show("Sales amount must be positive or zero")
                Exit Sub 'nothing below this exit sub runs
            End If


            'calculate the salary
            SalaryDecimal = SalesAmountDecimal * COMMISION_BASE_DECIMAl + BASE_SALARY_DECIMAL

            'calculate index, where to put it in the array
            IndexInteger = Convert.ToInt32(Math.Truncate(SalaryDecimal / 100))

            'make sure it doesnt exceed the upper bound
            'If IndexInteger > TotalInteger.GetUpperBound(0) Then
            '    IndexInteger = TotalInteger.GetUpperBound(0)
            'End If
            IndexInteger = Math.Min(IndexInteger, TotalInteger.GetUpperBound(0))

            TotalInteger(IndexInteger) += 1
            'update the display
            UpdateValues()

            'clear inputs
            amountTextBox.Clear()
            amountTextBox.Focus()

        Catch AmountFormatException As Exception
            MessageBox.Show("You must enter a valid amount", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With amountTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub ' calculateButton_Click

    Private Sub SalarySurvey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'happens the first time the form comes into memory

        'display the salary ranges
        rangesLabel.Text = String.Format("$200-$299{0}$300-$399{0}$400-$499{0}$500-$599{0}$600-$699{0}$700-$799{0}$800-$899{0}$800-$899{0}$1000 and over", ControlChars.NewLine)

        'show the initial values
        UpdateValues()
    End Sub

    Sub UpdateValues()

        Dim ValueString As String = ""

        'For CounterInteger As Integer = 0 To TotalInteger.Length - 1 'or GetUpperBound(0) the  zero here means single dim array
        '    ValueString &= TotalInteger(CounterInteger) & Environment.NewLine 'or vbCrLf
        'Next

        For Each ValueInteger As Integer In TotalInteger
            ValueString &= ValueInteger.ToString & Environment.NewLine
        Next

        'we've built our string of salary values
        valuesLabel.Text = ValueString
    End Sub
End Class ' SalarySurvey
