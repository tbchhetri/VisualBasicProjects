<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Contact.aspx.vb" Inherits="Lab10.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>Contact Us<br />
            <br />
            </strong>Would love to hear your feedback on this:
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://tbchhetri.github.io/">My Web Page</asp:HyperLink>
            <strong>
            <br />
            <br />
            </strong>
            <asp:HyperLink ID="HomeHyperLink" runat="server" NavigateUrl="~/Default.aspx">Return Home!</asp:HyperLink>
        </div>
    </form>
</body>
</html>
