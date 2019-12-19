<%@ Page Title="Login page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="yeetles_13.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<link rel="stylesheet" href="Content/Login.css">    
    <div class="login-box">
  <h1>Login</h1>
  <div class="textbox">
    <i class="fas fa-user"></i>
      <asp:TextBox runat="server" ID="UserNameTextBox" placeholder="User name"></asp:TextBox>
  </div>

 

  <div class="textbox">
    <i class="fas fa-lock"></i>
      <asp:TextBox runat="server" ID="PasswordTextBox" TextMode="Password" placeholder="Password"></asp:TextBox>
  </div>

  <asp:Button runat="server" ID="LoginButton" CssClass="btn" Text="Sign in" OnClick="LoginButton_Click" />

<style>
    
    ::placeholder {
    color: white;
    opacity: 1;
    }
    ::-ms-input-placeholder{
       color: white;

      }
    :-ms-input-placeholder{
       color: white;

      } 
        
 </style>

 
</div>

</asp:Content>


