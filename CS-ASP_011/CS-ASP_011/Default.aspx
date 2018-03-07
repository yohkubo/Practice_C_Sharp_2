<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_011.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &lt;Integer&gt;<br />
            Is&nbsp;
            <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
&nbsp; equal to&nbsp;
            <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
&nbsp; ?<br />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
            &lt;Not specify data type&gt;<br />
            Is&nbsp;
            <asp:TextBox ID="thirdTextBox" runat="server"></asp:TextBox>
&nbsp; equal to&nbsp;
            <asp:TextBox ID="forthTextBox" runat="server"></asp:TextBox>
&nbsp; ?<br />
            <br />
            <br />
            <asp:Button ID="ok2Button" runat="server" OnClick="ok2Button_Click" Text="OK2" />
            <br />
            <br />
            <asp:Label ID="result2Label" runat="server"></asp:Label>
            <br />
            <br />
            &lt;Checkbox&gt;<br />
            <br />
            <asp:CheckBox ID="coolCheckBox" runat="server" Text="Are you cool?" />
            <br />
            <br />
            <asp:Button ID="ok3Button" runat="server" OnClick="ok3Button_Click" Text="OK3" />
            <br />
            <br />
            <asp:Label ID="result3Label" runat="server"></asp:Label>
            <br />
            <br />
            &lt;Radiobuttons&gt;<br />
            If you could only eat one food for the rest of your life, what would you choose?<br />
            <asp:RadioButton ID="pizzaRadioButton" runat="server" GroupName="foodGroup" Text="Pizza" />
            <br />
            <asp:RadioButton ID="saladRadioButton" runat="server" GroupName="foodGroup" Text="Salad" />
            <br />
            <asp:RadioButton ID="pbjRadioButton" runat="server" GroupName="foodGroup" Text="Peanut Butter and Jelly" />
            <br />
            <br />
            <asp:Button ID="ok4Button" runat="server" OnClick="ok4Button_Click" Text="OK4" />
            <br />
            <br />
            <asp:Label ID="result4Label" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
