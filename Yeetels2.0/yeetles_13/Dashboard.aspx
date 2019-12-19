<%@ Page Title="Dashboard" Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="yeetles_13.Dashboard" %>

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
    <script defer src="scriptDashBoard.js"></script>
</head>

<body>
    <div class="sidebar">
        <button onclick="location.href = 'UserPage.aspx';"class="btn"><img src='https://image.flaticon.com/icons/svg/126/126486.svg' alt="" width="100" height="70"></i><h3>User</h3></button>
       <br>
<button onclick="location.href = 'UserCreatePage.aspx';" class="btn"><img src="https://image.flaticon.com/icons/svg/1665/1665578.svg" alt=""width="100" height="30"></i><h3>Add User</h3></button>
</div>

    <div>
     <div class="container">
        <div class="card">
            <div class="face face1">
                <div class="content">
                    <img src="https://image.flaticon.com/icons/svg/681/681662.svg" alt="">
                    <h3>Project</h3>
                </div>
            </div>
            <div class="face face2">
                <div class="content">
                   
                    
                    <p>
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                    </p>
                    
                    <form runat="server">
                    <asp:Button CssClass="button" runat="server" ID="Button1" Text="Expand" OnClick="ExpandButton_Click" style="float:right;"  />
                        </form>
                    <!-- <button data-modal-target="#modal">Read More</button> -->
                </div>


            </div>

        </div>
         <div class="card">
            <div class="face face1">
                <div class="content">
                    <img src="https://image.flaticon.com/icons/svg/681/681662.svg" alt="">
                    <h3>Project</h3>
                </div>
            </div>
            <div class="face face2">
                <div class="content">
                    <p>
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                    </p>
                    </div>
        </div>
</div>
         <div class="card">
            <div class="face face1">
                <div class="content">
                    <img src="https://image.flaticon.com/icons/svg/681/681662.svg" alt="">
                    <h3>Project</h3>
                </div>
            </div>
            <div class="face face2">
                <div class="content">
                    <p>
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                    </p>
                    </div>
        </div>
</div>
 <div class="card">
            <div class="face face1">
                <div class="content">
                    <img src="https://image.flaticon.com/icons/svg/681/681662.svg" alt="">
                    <h3>Project</h3>
                </div>
            </div>
            <div class="face face2">
                <div class="content">
                    <p>
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                    </p>
                    </div>
        </div>
</div>
        <div class="card">
            <div class="face face1">
                <div class="content">
                    <img src="https://image.flaticon.com/icons/svg/681/681662.svg" alt="">
                    <h3>Project</h3>
                </div>
            </div>
            <div class="face face2">
                <div class="content">
                    <p>
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                    </p>
                    </div>
        </div>
</div>
        
        
 
        
       

</body>

</html>
