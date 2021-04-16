'By:          Tek Chhetri
'Project:     Homework 4
'Date:        3/30/2021
'Discription: The code for the summary form to display basic stuff
Public Class SummaryForm
    Private Sub SummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalCommissionTextBox.Text = CommissionClass.TotalCommission.ToString("c")
        TotalSalesTextBox.Text = CommissionClass.TotalSales.ToString("c")
        TotalPayTextBox.Text = CommissionClass.TotalPay.ToString("c")
    End Sub

    Private Sub CloseSummaryButton_Click(sender As Object, e As EventArgs) Handles CloseSummaryButton.Click
        Me.Close()
    End Sub

    Private Sub SummaryForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TotalCommissionTextBox.Text = CommissionClass.TotalCommission.ToString("c")
        TotalSalesTextBox.Text = CommissionClass.TotalSales.ToString("c")
        TotalPayTextBox.Text = CommissionClass.TotalPay.ToString("c")
    End Sub
End Class