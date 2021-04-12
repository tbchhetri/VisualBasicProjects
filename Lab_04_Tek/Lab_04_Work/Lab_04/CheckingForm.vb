'Project:     Lab 4
'Programmer:  Tek Chhetri
'Date:        02/17/21
'Description: This project maintains a checking account balance.
'             The requested transaction is calculated and 
'             the new balance is displayed.
'             A summary includes all transactions.

Public Class CheckingForm
    Dim BalanceDecimal As Decimal = 100
    Const SERVICE_CHARGE_DECIMAL As Decimal = 10 'standard bounced check charge

    Dim TotalDepositCountIntegerm, TotalChargeInteger, TotalChargeCountInteger, TotalCheckCountInteger As Integer
    Dim TotalDepositAmountDecimal, TotalCheckAmountDecimal, TotalChargeAmountDecimal As Decimal

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'End the program

        Me.Close()
    End Sub

    Private Sub CalculateTextBox_Click(sender As Object, e As EventArgs) Handles CalculateTextBox.Click
        'Calculate the transaction and display the new balance.
        Dim AmountDecimal As Decimal

        If AmountDecimal < 0 Then
            MessageBox.Show("No negative amounts!")
            Exit Sub
        End If

        Try
            AmountDecimal = Decimal.Parse(AmountTextBox.Text)

            'check if transaction type is selected
            If DepositRadioButton.Checked Or CheckRadioButton.Checked Or ChargeRadioButton.Checked Then

                If DepositRadioButton.Checked Then
                    BalanceDecimal += AmountDecimal

                    TotalDepositCountIntegerm += 1
                    TotalDepositAmountDecimal += AmountDecimal

                ElseIf CheckRadioButton.Checked Then
                    'check if we have enough money
                    If AmountDecimal <= BalanceDecimal Then
                        BalanceDecimal -= AmountDecimal
                        TotalCheckCountInteger += 1
                        TotalCheckAmountDecimal += AmountDecimal
                    Else
                        MessageBox.Show("Insufficient Funds, service charge dedected", "Not enough money", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                        BalanceDecimal -= SERVICE_CHARGE_DECIMAL
                        TotalChargeCountInteger += 1
                        TotalChargeAmountDecimal += SERVICE_CHARGE_DECIMAL
                    End If

                Else
                    BalanceDecimal -= AmountDecimal

                    TotalChargeCountInteger += 1
                    TotalChargeAmountDecimal += AmountDecimal

                End If
            Else
                'no trans selected
                MessageBox.Show("You must select one transaction type", "Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

            'output
            BalanceTextBox.Text = BalanceDecimal.ToString("c")

            'reset for next trans
            With AmountTextBox
                .Focus()
                .SelectAll()
            End With

            DepositRadioButton.Checked = True
            DepositRadioButton.Checked = False
            'CheckRadioButton.Checked = False
            'ChargeRadioButton.Checked = False


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

        ' MessageBox.Show("Please select deposit, check, or service charge", "Input needed")




    End Sub

    Private Sub CheckingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'happens one, default event
        BalanceTextBox.Text = BalanceDecimal.ToString("C")
    End Sub

    Private Sub ClearTextBox_Click(sender As Object, e As EventArgs) Handles ClearTextBox.Click
        AmountTextBox.Clear()

        'select deposit, which unselects check and charge
        DepositRadioButton.Checked = True

        'unselect deposit, hence no radio button
        DepositRadioButton.Checked = False

        AmountTextBox.Focus()
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        Dim MessageString As String

        MessageString = "Total # of deposits: " & TotalDepositCountIntegerm.ToString & ControlChars.NewLine
        MessageString &= "Total amounts of deposits: " & TotalDepositAmountDecimal.ToString("c") & ControlChars.NewLine & Environment.NewLine

        MessageString &= "Total # of checks: " & TotalCheckCountInteger.ToString & ControlChars.NewLine
        MessageString &= "Total amounts of checks: " & TotalCheckAmountDecimal.ToString("c") & ControlChars.NewLine & Environment.NewLine

        MessageString &= "Total # of service charges: " & TotalChargeCountInteger.ToString & ControlChars.NewLine
        MessageString &= "Total amounts of service charge: " & TotalChargeAmountDecimal.ToString("c") & ControlChars.NewLine & Environment.NewLine

        MessageBox.Show(MessageString, "Account Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class

