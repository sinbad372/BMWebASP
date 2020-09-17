<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BMWebMain.aspx.vb" Inherits="BMWebASP.BMWebMain" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

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
        <div>
            <asp:HyperLink ID="SupervisorVisitLink" runat="server" Font-Bold="True" NavigateUrl="~/UIMain/BMSupervisor.aspx">Create Supervisor Visit<b /></asp:HyperLink>
            <br />
            <asp:HyperLink ID="SeniorVisitLink" runat="server" Font-Bold="True" NavigateUrl="~/UIMain/BMSupervisor.aspx">Create Senior Visit<b /></asp:HyperLink>
        </div>
        <div>
            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="1168px">
            </rsweb:ReportViewer>
        </div>
    </form>
</body>
</html>
