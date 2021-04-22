<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Lab11._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 395px;
        }
        .auto-style2 {
            width: 153px;
        }
        .auto-style3 {
            width: 153px;
            font-size: x-large;
        }
        .auto-style4 {
            width: 153px;
            text-align: right;
            font-family: "Blackadder ITC";
        }
        .auto-style5 {
            width: 153px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style7 {
            margin-top: 242px;
        }
        .auto-style8 {
            width: 153px;
            text-align: right;
            font-family: "Blackadder ITC";
            height: 63px;
        }
        .auto-style9 {
            height: 63px;
        }
        .auto-style10 {
            width: 153px;
            height: 26px;
        }
        .auto-style11 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="FormPanel" runat="server" Height="403px">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style3"><strong>Entry Form</strong></td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Name:</td>
                        <td>
                            <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NameTextBox" ErrorMessage="Enter your name please" ForeColor="Red">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Email:</td>
                        <td>
                            <asp:TextBox ID="EmailTextBox" runat="server" TextMode="Email"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="EmailTextBox" ErrorMessage="How difficult is it to just put your email address" ForeColor="Red">*</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailTextBox" ErrorMessage="Enter valid" Font-Names="Blackadder ITC" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">name@domain.com</asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Phone:</td>
                        <td>
                            <asp:TextBox ID="PhoneTextBox" runat="server" TextMode="Phone"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style8">Contact Method:</td>
                        <td class="auto-style9">
                            <asp:RadioButtonList ID="ContactMethodRadioButtonList" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem Selected="True">Email</asp:ListItem>
                                <asp:ListItem>Phone</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Comments:</td>
                        <td>
                            <asp:TextBox ID="CommentsTextBox" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5"></td>
                        <td class="auto-style6">
                            <asp:Button ID="SubmitButton" runat="server" Font-Names="Blackadder ITC" Text="Submit" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Names="Blackadder ITC" ForeColor="Red" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style10"></td>
                        <td class="auto-style11"></td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
        <asp:Panel ID="DuplicatePanel" runat="server" CssClass="auto-style7" Font-Names="Blackadder ITC" Height="324px" Visible="False">
            We&#39;re sorry, only one submission per user.</asp:Panel>
    </form>
</body>
</html>
