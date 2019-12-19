<%@ Page Title="Login page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="yeetles_13.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <h1>Log in, ya dingus</h1>
            </td>
        </tr>
        <tr>
            <td>
                <br />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="UserNameLabel" runat="server">Brugernavn: </asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="UserNameTextBox"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td colspan="2">
                <asp:Label runat="server" ID="PasswordLabel">Password: </asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" TextMode="Password" ID="PasswordTextBox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" Text="Login" ID="LoginButton" OnClick="LoginButton_Click" />
            </td>
        </tr>
    </table>

</asp:Content>
