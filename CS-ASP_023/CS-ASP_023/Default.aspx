<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_023.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hours Worksed on Project:
            <asp:TextBox ID="hoursTextBox" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="addHourButton" runat="server" OnClick="addHourButton_Click" Text="AddHour" />
            <br />
            <br />
            <asp:Label ID="okLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
