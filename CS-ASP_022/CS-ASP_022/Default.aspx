<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_022.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            From:<br />
            <br />
            <asp:RadioButton ID="chicagoRadioButton" runat="server" GroupName="fromGroup" Text="Chicago" />
            <br />
            <asp:RadioButton ID="newYorkRadioButton" runat="server" GroupName="fromGroup" Text="New York" />
            <br />
            <asp:RadioButton ID="parisRadioButton" runat="server" GroupName="fromGroup" Text="Paris" />
            <br />
            <br />
            To:<br />
            <br />
            <asp:RadioButton ID="toChicagoRadioButton" runat="server" GroupName="toGroup" Text="Chicago" />
            <br />
            <asp:RadioButton ID="toNewYorkRadioButton" runat="server" GroupName="toGroup" Text="New York" />
            <br />
            <asp:RadioButton ID="toParisRadioButton" runat="server" GroupName="toGroup" Text="Paris" />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
