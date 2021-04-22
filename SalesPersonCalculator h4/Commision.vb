'By:          Tek Chhetri
'Project:     Homework 4
'Date:        3/30/2021
'Discription: Create a project to calculate the weekly salary and commission rate for a sales person based on their weekly sales. 
'''''''''''''''Provide a summary Of the running totals Of the weekly salary And commissions paid And an About Box.
Public Class CommisionForm
    Private EmployeePayObject As CommissionClass
    Private Sub CommisionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Ask for the Salesperson's name and their Weekly Sales (both required and sales must be numeric)

    End Sub

    Private Sub PayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayToolStripMenuItem.Click

        Try
            EmployeePayObject = New CommissionClass(NameTextBox.Text, Decimal.Parse(SalesTextBox.Text))

            'DISPLAY
            PaidTextBox.Text = EmployeePayObject.FindPay(Decimal.Parse(SalesTextBox.Text)).ToString("c")
            CommissionTextBox.Text = EmployeePayObject.FindCommission(Decimal.Parse(SalesTextBox.Text)).ToString("c")

        Catch ex1 As FormatException

        End Try

        NameTextBox.Clear()
        NameTextBox.Focus()
        SalesTextBox.Clear()
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        SummaryForm.Show()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        NameTextBox.Clear()
        NameTextBox.Focus()
        SalesTextBox.Clear()
        PaidTextBox.Clear()
        CommissionTextBox.Clear()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
End Class
