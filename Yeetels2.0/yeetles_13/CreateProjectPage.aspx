<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateProjectPage.aspx.cs" Inherits="yeetles_13.CreateProjectPage" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="x-ua-compatible" content="ie=edge">
    <title>Cards Group</title>
    <meta name="description" content="Best cards in CSS">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="icon" type="image/png" href="/images/favicon-160x160.png" sizes="160x160">
    <!-- Place favicon.ico in the root directory -->
    <link rel="stylesheet" href="Content/Main.css">
    
</head>

<body>
    <div class="sidebar">
        <button onclick="location.href = 'Dashboard.aspx';" class="btn"><img src="https://image.flaticon.com/icons/svg/467/467272.svg" width="1" height="60" alt=""></i><h3></h3></button>
</div>

<div class="container" id="projectcontainer">
  <form id="form" runat="server">
  <div class="row">
    <div class="col-label">
      <label for="lbtitel">Title</label>
    </div>
    <div class="col-placeholder">
      <asp:TextBox runat="server" ID="TitleTextBox" placeholder="Title" Width="150px"></asp:TextBox>
    </div>
  </div>
<div class="row">
    <div class="col-label">
      <label for="lbprojectlead">Project Lead</label>
    </div>
    <div class="col-placeholder">
        <asp:DropDownList runat="server" ID="ProjectLeadDropDown" Width="175px">
        </asp:DropDownList>
    </div>
  </div>
      <div class="row">
    <div class="col-label">
      <label for="lbclient">Client</label>
    </div>
    <div class="col-placeholder">
            <asp:TextBox runat="server" ID="ClientTextBox" placeholder="Client Name" Width="150px"></asp:TextBox>
    </div>
  </div>
      
<div class="row">
    <div class="col-label">
      <label for="lbcvr">CVR</label>
    </div>
    <div class="col-placeholder">
            <asp:TextBox runat="server" ID="CvrTextBox" placeholder="CVR" Width="150px"></asp:TextBox>
    </div>
  </div>

<div class="row">
    <div class="col-label">
      <label for="lbstartdate">Start Date</label>
    </div>
    <div class="col-placeholder">
      <input type="date" id="StartDateTextBox" runat="server" placeholder="Start of project" style="width:150px;" >
    </div>
  </div>
<div class="row">
    <div class="col-label">
      <label for="lbenddate">End Date</label>
    </div>
    <div class="col-placeholder">
      <input type="date" id="EndDateTextBox" runat="server" placeholder="Deadline" style="width:150px;" >
    </div>
  </div>

<div class="row">
    <div class="col-label">
      <label for="lbhoursestimate">Hours Estimate</label>
    </div>
    <div class="col-placeholder">
    <asp:TextBox runat="server" TextMode="Number" ID="EstimatedHoursTextBox" placeholder="Title" Width="150px"></asp:TextBox>
    </div>
  </div>
      <br />
  <div class="row">
    <div class="col-label">
      <label for="lbdescription">Description</label>
    </div>
      
    <div class="col-placeholder">
      <textarea id="DescriptionTextArea" runat="server" placeholder="Write something.." style="height:200px; width:370px;"></textarea>
    </div>
  </div>
      <br />
  <button id="CreateProjectButton" runat="server" onserverclick="CreateProjectButton_Click" class="center-block btn btn-primary" type="submit" style="width:180px">
            Create</button>
  </form>
    
</div>
</body>
</html>




