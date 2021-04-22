'Project: StreamReader
'Author: Tek Chhetri 
'Date: Spring 2021
'Description: 
' Read a file sequentially and display contents based on
' account type specified by user (credit, debit or zero balances).
Imports System.IO ' using classes from this namespace

Public Class CreditInquiry
    Dim FileNameString As String
    Enum AccountType 'constants that represent accounts type
        Positive
        Negative
        Zero
    End Enum
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'exit the program
        Me.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        'promt the user to open a file
        Dim FileDialogResult As DialogResult 'store what button they clicked 

        'create dialog box to choose a file
        Using AccountOpenFileDialog As New OpenFileDialog
            ' we created an object but didn't show it
            FileDialogResult = AccountOpenFileDialog.ShowDialog() 'display dialog and wait WHY ARE WE STORING THE RESULT HERE
            FileNameString = AccountOpenFileDialog.FileName
        End Using

        If FileDialogResult <> DialogResult.Cancel Then
            'must be open
            PositiveBalanceButton.Enabled = True
            NegativeBalanceButton.Enabled = True
            ZeroBalanceButton.Enabled = True
            'HOW TO LIMIT TO ONLY TXT FILES

        End If

        'check what the user said to do, open or cancel

    End Sub

    Private Sub PositiveBalanceButton_Click(sender As Object, e As EventArgs) Handles PositiveBalanceButton.Click
        DisplayAccounts(AccountType.Positive)
    End Sub

    Sub DisplayAccounts(inAccountType As AccountType)
        'read a file and display accounts if we should
        Dim AccountStreamReader As StreamReader = Nothing 'to read text from our file

        'output a header
        accountsTextBox.Text = "The accounts are: " & vbCrLf

        'read from our file
        Try
            'open the file for reading
            AccountStreamReader = New StreamReader(FileNameString)
            'steam is open so read from it
            'use pretest do loop
            Do Until AccountStreamReader.EndOfStream
                'not at the end of the file
                Dim LineString As String = AccountStreamReader.ReadLine 'gets one line at a time
                'break up the string
                Dim FieldsString() As String = LineString.Split(","c) 'c = pass this as a character

                'get individual information
                Dim AccountNumberInteger As Integer = Convert.ToInt32(FieldsString(0))
                Dim FirstNameString As String = FieldsString(1)
                Dim LastNameString As String = FieldsString(2)
                Dim BalanceDecimal As Decimal = Convert.ToDecimal(FieldsString(3))

                'if we get here, we got a good record
                If ShouldDisplay(inAccountType, BalanceDecimal) Then
                    'only get here if we should show the record
                    accountsTextBox.AppendText(AccountNumberInteger.ToString & vbTab & FirstNameString & vbTab & LastNameString & vbTab & BalanceDecimal.ToString("C") & vbCrLf)

                End If

                'close? not here
            Loop

        Catch ex1 As FormatException
            'get here if those parses failed

        Catch ex As IOException 'stream/file problem
            MessageBox.Show("Can't read the file")

        Finally 'runs if the try statement succeed or fails
            'attempt to close files here
            If AccountStreamReader IsNot Nothing Then

                Try
                    AccountStreamReader.Close()
                Catch ex1 As NullReferenceException
                    'the stream was never created
                Catch ex As IOException
                    'had an error opening
                End Try
            End If


        End Try

    End Sub

    Function ShouldDisplay(inType As AccountType, inBalanceDecimal As Decimal) As Boolean
        'determine if we should display this record or not
        If inBalanceDecimal > 0 AndAlso inType = AccountType.Positive Then
            Return True
        ElseIf inBalanceDecimal < 0 AndAlso inType = AccountType.Negative Then
            Return True
        ElseIf inBalanceDecimal = 0 AndAlso inType = AccountType.Zero Then
            Return True 'record should be displayed
        Else
            Return False
        End If
    End Function

    Private Sub NegativeBalanceButton_Click(sender As Object, e As EventArgs) Handles NegativeBalanceButton.Click
        DisplayAccounts(AccountType.Negative)
    End Sub

    Private Sub ZeroBalanceButton_Click(sender As Object, e As EventArgs) Handles ZeroBalanceButton.Click
        DisplayAccounts(AccountType.Zero)
    End Sub
End Class ' Credit Inquiry

