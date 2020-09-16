<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="BMWebASP.BMLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="Shourtcut icon" href="../Resources/BusniessMonitor.ico" type="image/x-icon" />
    <title>Business Monitor</title>
</head>
<body onload="window.history.forward();" style="background:url('../Resources/Busniess Monitor Name.jpg') no-repeat 50% 0;">
    <form id="form1" runat="server">
        <asp:Login ID="BMLogin" DisplayRememberMe="False" AutoComplete="Off" runat="server" BackColor="#F7F7DE" style="margin-top:200px" align="Center" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" VisibleWhenLoggedIn="False">
            <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
        </asp:Login>
    </form>
</body>
</html>
