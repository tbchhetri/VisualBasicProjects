'Project:     Lab 5
'Programmer:  Tek Chhetri
'Date:        Fall 2021
'Description: This project maintains a checking account balance.
'             The requested transaction is calculated and 
'             the new balance is displayed.
'             A summary includes all transactions.

Public Class CheckingForm
    Const SERVICE_CHARGE_DECIMAL As Decimal = 10

    Dim BalanceDecimal As Decimal = 100
    Dim TotalDepositCountInteger, TotalCheckCountInteger, TotalServiceChargeCountInteger As Integer
    Dim TotalDepositAmountDecimal, TotalCheckAmountDecimal, TotalServiceChargeAmountDecimal As Decimal

#Region "Custom Methods"
    Sub ResetForm() 'clear out the input field and get ready for next transaction
        AmountTextBox.Clear()
        AmountTextBox.Focus()

        'select deposit and unselect other options
        DepositRadioButton.Checked = True
        'unselect
        DepositRadioButton.Checked = False

    End Sub

    Sub MakeDeposit(AmountDecimal As Decimal)
        'add the passed in amount to the balance
        BalanceDecimal += AmountDecimal

        'increment totals
        TotalDepositCountInteger += 1
        TotalDepositAmountDecimal += AmountDecimal

    End Sub

    Sub ServiceCharge(ByRef BalanceDecimal As Decimal, Optional AmountDecimal As Decimal = SERVICE_CHARGE_DECIMAL)
        'perform the service charge
        BalanceDecimal -= AmountDecimal

        'increment totals
        TotalServiceChargeCountInteger += 1
        TotalServiceChargeAmountDecimal += AmountDecimal
    End Sub

    Function WithdrawCheck(ByRef BalanceDecimal As Decimal, AmountDecimal As Decimal) As Decimal 'here we are creating 3 variables
        'withdraw check from out account
        If AmountDecimal <= BalanceDecimal Then
            'we have enough money
            BalanceDecimal -= AmountDecimal

            'increment our totals
            TotalCheckCountInteger += 1
            TotalCheckAmountDecimal += AmountDecimal
        Else
            'aint got enough money
            ServiceCharge(BalanceDecimal) 'SERVICE_CHARGE_DECIMAL is optional
            MessageBox.Show("Insufficient funds, service charge applied")
        End If
        'return new balance
        Return BalanceDecimal
    End Function

#End Region

    Private Sub CheckingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'happens once when the form comes into memory, the very first thing that happpens while opening a form
        'good spot for initializations on the form, hence we gonna prime the balance and display it
        BalanceDecimal = 100
        BalanceTextBox.Text = BalanceDecimal.ToString("C")
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'End the program

        Me.Close()
    End Sub

    Private Sub CalculateTextBox_Click(sender As Object, e As EventArgs) Handles CalculateTextBox.Click
        'Calculate the transaction and display the new balance.
        Dim AmountDecimal As Decimal

        If DepositRadioButton.Checked Or CheckRadioButton.Checked Or ChargeRadioButton.Checked Then
            Try
                AmountDecimal = Decimal.Parse(AmountTextBox.Text)

                'Calculate each transaction and keep track of summary information.
                If DepositRadioButton.Checked Then
                    ' deposit funds
                    MakeDeposit(AmountDecimal)

                ElseIf CheckRadioButton.Checked Then
                    ' withdraw funds 
                    BalanceDecimal = WithdrawCheck(BalanceDecimal, AmountDecimal)
                Else
                    ' perform service charge
                    ServiceCharge(BalanceDecimal, AmountDecimal)

                End If

                ' output results
                BalanceTextBox.Text = BalanceDecimal.ToString("c")

                ' clear form
                ResetForm()


            Catch AmountException As FormatException
                MessageBox.Show("Please make sure that only numeric data has been entered.",
                    "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With AmountTextBox
                    .Focus()
                    .SelectAll()
                End With
            Catch AnyException As Exception
                MessageBox.Show("Error: " & AnyException.Message)
            End Try
        Else
            MessageBox.Show("Please select deposit, check, or service charge", "Input needed")
        End If
    End Sub


    Private Sub ClearTextBox_Click(sender As Object, e As EventArgs) Handles ClearTextBox.Click
        ' clear form
        ResetForm()

    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        ' display summary
        Dim MessageString As String

        MessageString = "Total # of Deposits: " & TotalDepositCountInteger.ToString & ControlChars.NewLine
        MessageString &= "Total Amount of Deposits: " & TotalDepositAmountDecimal.ToString("c") &
            ControlChars.NewLine & ControlChars.NewLine
        MessageString &= "Total # of Checks: " & TotalCheckCountInteger.ToString & ControlChars.NewLine
        MessageString &= "Total Amount of Checks: " & TotalCheckAmountDecimal.ToString("c") &
            ControlChars.NewLine & ControlChars.NewLine
        MessageString &= "Total # of Service Charges: " & TotalServiceChargeCountInteger.ToString & ControlChars.NewLine
        MessageString &= "Total Amount of Service Charges: " & TotalServiceChargeAmountDecimal.ToString("c") &
            ControlChars.NewLine & ControlChars.NewLine

        MessageBox.Show(MessageString, "Account Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class

