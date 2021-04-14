'Project:     LAB 11
'Created by:  TBC
'Discription: Contact form, responsible for controlling the Default.aspx form. The form just takes the user information, validates them and comments and only allows one submission per user. 
Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'check here for the duplicate entry
        If CheckForDuplicate() Then
            'the cookie exists, don't allow new entry
            FormPanel.Visible = False
            DuplicatePanel.Visible = True
        Else
            'cookie doesn't exists, allow entry, hence make the second pannel visible
            FormPanel.Visible = True
            DuplicatePanel.Visible = False

        End If
    End Sub

    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ' validates the page on the server
        Page.Validate() 'so, as soon as user hits submit, runs all the validators 

        ' check for a valid page
        If Page.IsValid Then ' are all the validators valid
            'all validators passed

            'send an email
            SendMessage()

            'prevent duplicates
            PreventDuplicate()

            'redirect to the thank you page
            Response.Redirect("ThankYou.aspx") 'this gets sent back to the client
        End If
    End Sub

    Sub SendMessage()
        'create and send an email
        Dim objMessage As New System.Net.Mail.MailMessage 'for doing emails
        Dim BodyString As String 'build the content of the message we are sending out

        ' build our message body
        BodyString = "Name: " & NameTextBox.Text & vbCrLf
        BodyString &= "Email: " & EmailTextBox.Text & vbCrLf
        BodyString &= "Phone: " & PhoneTextBox.Text & vbCrLf
        BodyString &= "Contact Method: " & ContactMethodRadioButtonList.SelectedValue & vbCrLf
        BodyString &= "Comments: " & CommentsTextBox.Text '&= for appending

        'now populate the message object
        With objMessage
            .From = New Net.Mail.MailAddress("ysu@ourvalleynow.com") 'new is just calling the constructor
            .To.Add(New Net.Mail.MailAddress("tbchhetri@student.ysu.edu"))
            .Subject = "Contact form submission"
            .Body = BodyString

        End With

        'send that message
        Using objClient As New System.Net.Mail.SmtpClient
            With objClient
                .Host = "mail.idmi.net"
                .Port = 587 'or 25 are usual port for sending email
                .EnableSsl = True 'this encrypt the email
                .Credentials = New System.Net.NetworkCredential("ysu@ourvalleynow.com", "Penguins21!")

                Try
                    'send it
                    objClient.Send(objMessage)

                Catch ex As system.Net.Mail.SmtpException

                End Try
            End With
        End Using

    End Sub

    Sub PreventDuplicate()
        'set a cookie to prevent duplicate submissions
        Response.Cookies("IsDuplicate").Value = True
    End Sub

    Function CheckForDuplicate() As Boolean
        'check for the cookie  to prevent dup sub
        Dim isDuplicateBoolean As Boolean = False

        'check if the cookie exists
        If Request.Cookies("IsDuplicate") IsNot Nothing Then
            'the cookie exists

            If Not Boolean.TryParse(Request.Cookies("IsDuplicate").Value, isDuplicateBoolean) Then
                'if I get here the parse failes
                'think of this as the catch block
                isDuplicateBoolean = False
            End If
        End If
        Return isDuplicateBoolean
    End Function
End Class