'Project:     Homework2
'Programmer:  Tek Chhetri
'Date:        Spring21
'Description: Develops a program to record 2 weeks of temperature readings and gives a diagnosis of the average temperature.


Public Class COVIDTemperatureMonitorForm
    Dim PreviousTemperatureDecimal As Decimal 'had to declare this in different scope so that it can store the previous values
    Const NUMBER_OF_ELEMENTS_INTEGER As Integer = 14D

    Sub AllDisplay(UserTemperatureDecimal As Decimal, AverageTemperatureDecimal As Decimal)
        'this function is responsible for displaying infomation in the form

        LastTemperatureTextBox.Text = Math.Round(Val(CurrentTemperatureTextBox.Text), 2) 'Math.Round to convert the decimal to two sig fig

        Select Case UserTemperatureDecimal
            Case 0 To 95
                LastDiagnosisTextBox.Text = "Hypothermia"
            Case 95 To 99
                LastDiagnosisTextBox.Text = "Normal"
            Case 99 To 103
                LastDiagnosisTextBox.Text = "Fever"
            Case > 103
                LastDiagnosisTextBox.Text = "Seek Attention"
            Case Else
                LastDiagnosisTextBox.Text = "Unknown case"
        End Select

        AverageTemperatureTextBox.Text = Math.Round(Val(AverageTemperatureDecimal), 2)

        Select Case UserTemperatureDecimal
            Case 0 To 95
                AverageDiagnosisTextBox.Text = "Hypothermia"
            Case 95 To 99
                AverageDiagnosisTextBox.Text = "Normal"
            Case 99 To 103
                AverageDiagnosisTextBox.Text = "Fever"
            Case > 103
                AverageDiagnosisTextBox.Text = "Seek Attention"
            Case Else
                AverageDiagnosisTextBox.Text = "Unknown case"
        End Select

    End Sub
    Private Sub RecordButton_Click(sender As Object, e As EventArgs) Handles RecordButton.Click
        Dim UserTemperatureDecimal As Decimal
        Dim AverageTemperatureDecimal As Decimal

        CurrentTemperatureTextBox.Focus()
        UserTemperatureDecimal = Math.Round(Decimal.Parse(CurrentTemperatureTextBox.Text), 2)

        If ((UserTemperatureDecimal < 0) Or (UserTemperatureDecimal > 115)) Then 'runs whenever temp is not in range
            MessageBox.Show("Make sure temperature recorded is between 0 and 115", "Incorrect value inputted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CurrentTemperatureTextBox.Clear()
            CurrentTemperatureTextBox.Focus()
        Else

            'store the entered value in a variable
            ''make sure the entered value is between 0-115
            ''keep track of numbe of entries

            ReadingsListBox.Items.Add(UserTemperatureDecimal)
            PreviousTemperatureDecimal += UserTemperatureDecimal ' this adds up all the valid elements being inputted
            AverageTemperatureDecimal = PreviousTemperatureDecimal / ReadingsListBox.Items.Count

            'display the results
            AllDisplay(UserTemperatureDecimal, AverageTemperatureDecimal)
            CurrentTemperatureTextBox.Clear()

            'store till NumberOfElements
            If ReadingsListBox.Items.Count = NUMBER_OF_ELEMENTS_INTEGER Then
                RecordButton.Enabled = False
                'ReadingsListBox.Items.Clear() 'this should go under clear
            End If
        End If

        'clear and get ready for the next entry
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        With CurrentTemperatureTextBox
            .Clear()
            .Enabled = True
            .Focus()
        End With

        'clear all fields
        LastTemperatureTextBox.Clear()
        LastDiagnosisTextBox.Clear()
        AverageTemperatureTextBox.Clear()
        AverageDiagnosisTextBox.Clear()

    End Sub

    Private Sub COVIDTemperatureMonitorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrentTemperatureTextBox.Focus()
    End Sub
End Class
