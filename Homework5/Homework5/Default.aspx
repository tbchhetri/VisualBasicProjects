<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Homework5._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 40%;
        }
        .auto-style2 {
            width: 208px;
            text-align: right;
        }
        .auto-style3 {
            width: 208px;
            text-align: center;
        }
        .auto-style4 {
            text-align: center;
        }
        .auto-style5 {
            text-align: left;
        }
        .auto-style6 {
            width: 208px;
            text-align: right;
            height: 26px;
        }
        .auto-style7 {
            text-align: left;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style4">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4" colspan="2">
                        <asp:Label ID="Label8" runat="server" Text="CALORIE COUNTER"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:HiddenField ID="TotalCaloriesHiddenField" runat="server" Value="0" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Fat"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="FatsTextBox" runat="server" Width="118px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="FatsRequiredFieldValidator" runat="server" ControlToValidate="FatsTextBox" ErrorMessage="If no fat then input 0." ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="FatRangeValidator" runat="server" ControlToValidate="FatsTextBox" ErrorMessage="Please enter a number between 1 and 1000" ForeColor="Red" MaximumValue="1000" MinimumValue="0">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Carbs"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="CarbsTextBox" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="CarbsRequiredFieldValidator" runat="server" ControlToValidate="CarbsTextBox" ErrorMessage="If no carbs then input 0." ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="CarbsRangeValidator" runat="server" ControlToValidate="CarbsTextBox" ErrorMessage="Please enter a number between 1 and 1000" ForeColor="Red" MaximumValue="1000" MinimumValue="0">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label4" runat="server" Text="Protein"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="ProteinTextBox" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="ProteinRequiredFieldValidator" runat="server" ControlToValidate="ProteinTextBox" ErrorMessage="If no protein then input 0." ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="ProteinRangeValidator" runat="server" ControlToValidate="ProteinTextBox" ErrorMessage="Please enter a number between 1 and 1000" ForeColor="Red" MaximumValue="1000" MinimumValue="0">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:HiddenField ID="ItemsHiddenField" runat="server" Value="0" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="CalculateButton" runat="server" Text="Calculate" />
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="ClearButton" runat="server" CausesValidation="False" Text="Clear" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="ResetButton" runat="server" style="text-align: justify" Text="Reset" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label5" runat="server" Text="Calories for the current item:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="CaloriesTextBox" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label6" runat="server" Text="Total # of items:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TotalItemsTextBox" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label7" runat="server" Text="Total # of Calories:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TotalCaloriesTextBox" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
