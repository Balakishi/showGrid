<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showGrid.aspx.cs" Inherits="showGrid.showGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="Drpdwnlist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Drpdwnlist_SelectedIndexChanged"></asp:DropDownList>
            <asp:GridView ID="grid" runat="server" OnSelectedIndexChanged="grid_SelectedIndexChanged"></asp:GridView>
        </div>
    </form>
</body>
</html>
