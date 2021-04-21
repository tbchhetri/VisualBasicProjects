<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Lab12._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="BooksGridView" runat="server" AllowPaging="True" AllowSorting="True" PageSize="7">
            </asp:GridView>
        </div>
        <asp:HiddenField ID="hfSortOrder" runat="server" Value="ASC" />
        <asp:HiddenField ID="hfSortColumn" runat="server" Value="Title" />
    </form>
</body>
</html>
