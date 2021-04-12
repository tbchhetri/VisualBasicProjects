'By:          Tek Chhetri
'Project:     HomeWork3
'Discription: End user will select a section for theatre and the number of tickets to purchase.
'When they click purchase, what they purchased will be shown as well as the total cost. 
'A summary Of all tickets sold will be kept track Of And updated after Each purchase. 
'There are 4 sectionsEnd user will Select a section For theatre And the number Of tickets To purchase. 
'When they click purchase, what they purchased will be shown As well As the total cost. 
'A summary Of all tickets sold will be kept track Of And updated after Each purchase. There are 4 sections
Public Class TicketSalesForm
    Const ORCHESTRA_DECIMAL As Decimal = 75
    Const MEZZANINE_DECIMAL As Decimal = 60
    Const GENERAL_DECIMAL As Decimal = 25
    Const BALCONY_DECIMAL As Decimal = 12.5


    Private Sub PurchaseButton_Click(sender As Object, e As EventArgs) Handles PurchaseButton.Click
        Dim SeatString As String = SeatListBox.SelectedItem

        Try
            If SeatString = "Orchestra" Then
                AmountDueTextBox.Text = (NumberOfTicketsTextBox.Text * ORCHESTRA_DECIMAL).ToString("c")
                SaleDisplayRichTextBox.Text = "Purchased " & NumberOfTicketsTextBox.Text & " ticket(s) at " & ORCHESTRA_DECIMAL.ToString("c") & " per ticket."
            ElseIf SeatString = "Mezzanine" Then
                AmountDueTextBox.Text = (NumberOfTicketsTextBox.Text * MEZZANINE_DECIMAL).ToString("c")
                SaleDisplayRichTextBox.Text = "Purchased " & NumberOfTicketsTextBox.Text & " ticket(s) at " & MEZZANINE_DECIMAL.ToString("c") & " per ticket."
            ElseIf SeatString = "General" Then
                AmountDueTextBox.Text = (NumberOfTicketsTextBox.Text * GENERAL_DECIMAL).ToString("c")
                SaleDisplayRichTextBox.Text = "Purchased " & NumberOfTicketsTextBox.Text & " ticket(s) at " & GENERAL_DECIMAL.ToString("c") & " per ticket."
            ElseIf SeatString = "Balcony" Then
                AmountDueTextBox.Text = (NumberOfTicketsTextBox.Text * BALCONY_DECIMAL).ToString("c")
                SaleDisplayRichTextBox.Text = "Purchased " & NumberOfTicketsTextBox.Text & " ticket(s) at " & BALCONY_DECIMAL.ToString("c") & " per ticket."
            End If
        Catch ex As Exception
            MessageBox.Show("Please input numbers only")
        End Try

        'display
        SaleDisplayRichTextBox.Text = "Purchased " & NumberOfTicketsTextBox.Text & " ticket(s) at " & ORCHESTRA_DECIMAL.ToString("c") & " per ticket."
    End Sub
End Class
