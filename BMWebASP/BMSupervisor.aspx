<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BMSupervisor.aspx.vb" Inherits="BMWeb.BMSupervisor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="Shourtcut icon" href="../Resources/BusniessMonitor.ico" type="image/x-icon" />
    <title>Business Monitor</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: #00FFFF">
            User ID :
            <asp:Label ID="UserIDLabel" runat="server"></asp:Label>
            | User Name :
            <asp:Label ID="UsernameLabel" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Image ID="Image1" runat="server" Height="140px" ImageUrl="~/Resources/Busniess Monitor.jpg" />
        </div>
        <div style="background-color: #00FFFF; font-size: large; font-weight: bold;">
            Create New Supervisor Visit
        </div>
        <div>
            <b />
            <asp:Label ID="Label1" runat="server" Text="Location : "></asp:Label><asp:DropDownList ID="ddlLocation" runat="server"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
