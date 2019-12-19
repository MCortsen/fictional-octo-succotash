<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UP.aspx.cs" Inherits="yeetles_13.UP" %>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="x-ua-compatible" content="ie=edge">
    <title>User Information</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="icon" type="image/png" href="/images/favicon-160x160.png" sizes="160x160">
    <!-- Place favicon.ico in the root directory -->
    <link rel="stylesheet" href="Content/Main.css">
    
</head>

<body>
    <div class="sidebar">
        <button onclick="location.href = 'Dashboard.aspx';" class="btn"><img src="https://image.flaticon.com/icons/svg/467/467272.svg" width="1" height="60" alt=""></i><h3></h3></button>
       
        <%--<br>--%>
<%--<button class="btn"><img src="https://image.flaticon.com/icons/svg/1665/1665578.svg" alt=""></i><h3>Add User</h3></button>--%>
</div>

<div class="container" id="projectcontainer">
  <form id="form" runat="server">
  <div class="row">
          <div class="col-label">
      <label for="lbtitle">ID:</label>
    </div>
    <div class="col-placeholder">
      <label runat="server" id="UserIdLabel" style="color:white"></label> 
    </div>
  </div>
      <br />
<div class="row">
    <div class="col-label">
      <label for="lbphonenumber">Phone Number</label>
    </div>
    <div class="col-placeholder">
      <input runat="server" type="text" id="PhoneNumbeTextBox"  placeholder="Enter phone number.." style="width:150px;" >
    </div>
  </div>
      <div class="row">
    <div class="col-label">
      <label for="lbclient">Email</label>
    </div>
    <div class="col-placeholder">
      <input runat="server" type="text" id="EmailTextBox" placeholder="Enter email.." style="width:150px;" >
    </div>
  </div>
      <div class="row">
          <div class="col-label">
      <label for="lbUsername">User Name:</label>
    </div>
    <div class="col-placeholder">
      <label runat="server" id="UserNameLabel" style="color:white"></label> 
    </div>
  </div>
      <div class="row">
    <div class="col-label">
      <label for="lbclient">Password</label>
    </div>
    <div class="col-placeholder">
      <input runat="server" type="password" id="PasswordInput" placeholder="" style="width:150px;" >
    </div>
  </div>
      <br />

  
      <div class="row">
    <div class="col-label">
      <label id="AdminLabel" runat="server">Admin: </label><input type="checkbox" runat="server" id="AdminCheckBox" style="width:20px;" >
    </div>
    <div class="col-placeholder">
      
    </div>
  </div>
    
  <button class="center-block btn btn-primary" type="submit">
            Save Changes</button>
  </form>
  </div>
    

</body>
</html>



