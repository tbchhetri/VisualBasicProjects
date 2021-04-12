<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Lab10._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 84%;
            height: 352px;
        }
        .auto-style6 {
            width: 554px;
        }
        .auto-style11 {
            width: 133px;
            text-align: right;
        }
        .auto-style12 {
            height: 23px;
            text-align: center;
            font-size: large;
        }
        .auto-style13 {
            width: 133px;
        }
        .auto-style14 {
            width: 308px;
        }
        .auto-style15 {
            width: 133px;
            height: 28px;
        }
        .auto-style16 {
            width: 554px;
            height: 28px;
        }
        .auto-style17 {
            width: 308px;
            height: 28px;
        }
    </style>
</head>
<body bgcolor ="#000000">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style12" colspan="3"><strong aria-readonly="True">R&#39;n R Book Sales</strong></td>
                </tr>
                <tr>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td aria-readonly="True" class="auto-style11">Quantity:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="QuantityTextBox" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvQuantityTextBox" runat="server" ControlToValidate="QuantityTextBox" ErrorMessage="Enter a quantity you must." Font-Bold="True" Font-Underline="False" ForeColor="Red">&lt;------</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvQuantityTextBox" runat="server" ControlToValidate="QuantityTextBox" ErrorMessage="Your Quantity needs to be between 1-200" ForeColor="Red" MaximumValue="200" MinimumValue="1" Type="Integer">Btwn 1-200 plz</asp:RangeValidator>
                    </td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td aria-readonly="True" class="auto-style11">Title:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TitleTextBox" runat="server" Width="196px"></asp:TextBox>
                    </td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td aria-readonly="True" class="auto-style11">Price:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="PriceTextBox" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPriceTextbox" runat="server" ControlToValidate="PriceTextBox" ErrorMessage="Enter a price you must" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvTextBox" runat="server" ControlToValidate="PriceTextBox" ErrorMessage="Price should be numeric" ForeColor="Red" MaximumValue="999999999999.99" MinimumValue="0.00" Type="Currency">$xx.xx</asp:RangeValidator>
                    </td>
                    <td class="auto-style14">
                        <asp:Label ID="ErrorLabel" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td aria-readonly="True" class="auto-style11">Extended Price:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="ExtendedPriceTextBox" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td aria-readonly="True" class="auto-style11">15% Discount:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="DiscountTextBox" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td aria-readonly="True" class="auto-style11">Discounted Price:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="DiscountedPriceTextBox" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style6">
                        <asp:Button ID="SubmitButton" runat="server" Text="Submit" />
                    </td>
                    <td class="auto-style14">
                        <asp:Button ID="Button" runat="server" Text="Submit" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style6">
                        <asp:Button ID="ClearButton" runat="server" CausesValidation="False" Text="Clear" Width="61px" />
                    </td>
                    <td class="auto-style14">
                        <asp:HyperLink ID="ContactHyperLink" runat="server" NavigateUrl="~/Contact.aspx">Contact Us</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15"></td>
                    <td class="auto-style16">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    </td>
                    <td class="auto-style17">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://tbchhetri.github.io/">About Me</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
