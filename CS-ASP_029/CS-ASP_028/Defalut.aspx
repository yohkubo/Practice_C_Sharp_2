<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defalut.aspx.cs" Inherits="CS_ASP_028.Defalut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Convert to Cups<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="cupRadioButton" runat="server" AutoPostBack="True" GroupName="scaleGroup" OnCheckedChanged="cupRadioButton_CheckedChanged" Text="Cups" />
            <br />
            <asp:RadioButton ID="pintRadioButton" runat="server" AutoPostBack="True" GroupName="scaleGroup" OnCheckedChanged="pintRadioButton_CheckedChanged" Text="Pints" />
            <br />
            <asp:RadioButton ID="quartRadioButton" runat="server" AutoPostBack="True" GroupName="scaleGroup" OnCheckedChanged="quartRadioButton_CheckedChanged" Text="Quarts" />
            <br />
            <asp:RadioButton ID="gallonRadioButton" runat="server" AutoPostBack="True" GroupName="scaleGroup" OnCheckedChanged="gallonRadioButton_CheckedChanged" Text="Gallons" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
