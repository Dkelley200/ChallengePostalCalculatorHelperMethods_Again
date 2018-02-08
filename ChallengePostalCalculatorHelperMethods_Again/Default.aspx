<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods_Again.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Postal Calculator<br />
            <br />
            Width:&nbsp;
            <asp:TextBox ID="widthTextBox" runat="server" OnTextChanged="handleChange" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            Height:&nbsp;
            <asp:TextBox ID="heightTextBox" runat="server" OnTextChanged="handleChange" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            Length:&nbsp;
            <asp:TextBox ID="lengthTextBox" runat="server" OnTextChanged="handleChange" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="groundRadioButton" runat="server" GroupName="shipGroup" Text="Ground" OnCheckedChanged="handleChange" AutoPostBack="True" />
            <br />
            <asp:RadioButton ID="airRadioButton" runat="server" GroupName="shipGroup" Text="Air" OnCheckedChanged="handleChange" AutoPostBack="True" />
            <br />
            <asp:RadioButton ID="nextDayRadioButton" runat="server" OnCheckedChanged="handleChange" Text="Next Day" GroupName="shipGroup" AutoPostBack="True" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
