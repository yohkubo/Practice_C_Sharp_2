 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_012.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Is&nbsp;
            <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
&nbsp; equal to&nbsp;
            <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
&nbsp; ?<br />
            <br />
            <asp:CheckBox ID="oldCheckBox" runat="server" Text="Are you old?" />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
            <br />
            <br />
            Textbox: <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            Checkbox:
            <asp:Label ID="result2Label" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
