<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProjectPage.aspx.cs" Inherits="yeetles_13.ProjectPage"%>

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
                <br>
<button class="btn2" id="CheckInButton" runat="server" onserverclick="CheckInButton_Click"><img src="https://image.flaticon.com/icons/png/512/1131/1131876.png" width="" height=""  alt=""></i><h3>Check-in</h3></button>
        <br />
 <button class="btn3" id="CheckOutButton" runat="server" onserverclick="CheckOutButton_Click"><img src="https://image.flaticon.com/icons/png/512/1131/1131876.png" width="" height=""  alt=""></i><h3>Check-Out</h3></button>
        <br />
       
       
</div>

<div class="container" id="projectcontainer">
  <form id="form" runat="server">
        
  <div class="row">
    <div class="col-label">
      <label for="lbtitle">Title:</label>
    </div>
    <div class="col-placeholder">
      <label id="TitleLabel" runat="server" style="color:white"></label>
        <input style="width: 150px;" type="text" runat="server" id="TitleInput" />
    </div>
  </div>
<div class="row">
    <div class="col-label">
      <label for="lbprojectlead">Project Lead:</label>
    </div>
    <div class="col-placeholder">
      <label id="ProjectLeadLabel" runat="server" style="color:white"></label> 
        <asp:DropDownList runat="server" ID="ProjectLeadDropDown" Width="175px"></asp:DropDownList>
    </div>
  </div>
      <div class="row">
    <div class="col-label">
      <label for="lbclient">Client:</label>
    </div>
    <div class="col-placeholder">
      <label id="ClientLabel" runat="server" style="color:white"></label>
        <input type="text" runat="server" id="ClientInput" style="Width:150px;" />
    </div>
  </div>
      
<div class="row">
    <div class="col-label">
      <label for="lbcvr">CVR:</label>
    </div>
    <div class="col-placeholder">
      <label id="CvrLabel" runat="server" style="color:white"></label> 
        <input style="width: 150px;" type="text" runat="server" id="CvrInput" />
    </div>
  </div>

<div class="row">
    <div class="col-label">
      <label for="lbstartdate">Start Date:</label>
    </div>
    <div class="col-placeholder">
      <label id="StartDateLabel" runat="server" style="color:white; width:150px;"></label>
        <input style="width: 150px;" type="Date" runat="server" id="StartDateInput" />
    </div>
  </div>
<div class="row">
    <div class="col-label">
      <label for="lbenddate">End Date:</label>
    </div>
    <div class="col-placeholder">
      <label id="EndDateLabel" runat="server" style="color:white; display:inline; width:100px;"></label>
        <input style="width: 150px;" type="Date" runat="server" id="EndDateInput" />
    </div>
  </div>

<div class="row">
    <div class="col-label">
      <label for="lbhoursestimate">Estimated Hours:</label>
    </div>
    <div class="col-placeholder">
      <label id="EstimatedHoursLabel" runat="server" style="color:white"></label> 
        <input style="width: 150px;" type="text" runat="server" id="EstimatedHoursInput" />
    </div>
  </div>
<div class="row">
    <div class="col-sm-12 col-label">
      <label for="lbhoursspent">Spent Hours:</label>
    </div>
    <div class="col-placeholder">
      <label id="SpentHoursLabel" runat="server" style="color:white"></label> 
        <input style="width: 150px;" type="text" runat="server" id="SpentHoursInput" />
    </div>
  </div>

  <div class="row">
    <div class="col-label">
      <label for="lbdescription">Description:</label>
    </div>
    <div class="col-placeholder">
      <label id="DescriptionLabel" runat="server" style="color:white"></label>
        <textarea style="width: 400px; height: 200px;" runat="server" id="DescriptionTextArea"></textarea>
        </div>
  </div>

          
  <br />
          
      
     <button class="btn" type="submit" style="width:140px">Save Changes</button>

  <%--<button class="center-block btn btn-primary" type="submit">
            Create</button>--%>
 

  </form>
    <div class="AssignmentContainer">
         <ul class="list" style="list-style:none;">
  <li>      
      <input type="checkbox" />
              <label>TOP Project Varme Æbleskiver</label>     
    </li>
  
    </ul>

    </div>

 
    <link href="Content/Modal.css" rel="stylesheet">
  <script defer src="Modal.js"></script>
   
  <button data-modal-target="#modal" class="btnModalOpen">Create Assignment</button>
  <div class="modal" id="modal">
    <div class="modal-header">
      <div class="title">Create an Assignment</div>
      <button data-close-button ="OpenModal" class="close-button">&times;</button>
    </div>
    <div class="modal-body">

        <div class="col-label">
      <label for="Deadline">Deadline</label>
    </div>
    <div class="col-placeholder">
      <input type="date" id="Deadline" placeholder="Enter date.." style="width:170px;" >
    </div>

      <button class="btnModalCreate" style="width:80px; height:40px; font-family:Consolas">Create</button>
    </div>
  </div>
  <div id="overlay"></div>
    
</div>
</body>
</html>
