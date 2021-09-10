<%@ Page Title="" Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="GotchaSprintEen._Default" %>

<html>
    <body>
        <form id="loginform" runat="server">
            Enter name: <br />
            <asp:TextBox ID="usernameInput" runat="server" /> <br />
            <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" /> <br />
        </form>
    </body>
</html>
