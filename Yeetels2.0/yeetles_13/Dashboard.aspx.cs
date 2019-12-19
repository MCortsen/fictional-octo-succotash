using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yeetles_13

{
    public partial class Dashboard : Page
    {
        public static List<Project> loadedProjects = new List<Project>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["CurrentProject"] = "10";
            if (Session["CurrentUser"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            //ContentDiv.InnerHtml += CardHtmlString();


        }

        protected void ExpandButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProjectPage.aspx");
        }

        string CardHtmlString()
        {
            string cardHtml = "";
            loadedProjects = Database.GetProjectsByUser(Session["CurrentUser"].ToString());
            for (int i = 0; i < loadedProjects.Count; i++)
            {
                cardHtml += "<div runat='server' class='card'><div runat='server' class='face face1'><div runat='server' class='content'>" +
                    "<img src = 'https://image.flaticon.com/icons/svg/681/681662.svg' alt=''>" +
                    $"<h3>{loadedProjects[i].Title}</h3>" +
                    "</div>" +
                    "</div>" +
                    "<div runat='server' class='face face2'>" +
                    "<div runat='server' class='content'>" +
                    $"<p>Deadline: {loadedProjects[i].EndDate}</p>" +
                    $"<p>Client: {loadedProjects[i].Client}</p>" +
                    $"<p>Lead: {loadedProjects[i].ProjectLead}</p>" +
                    $"<p>Hours: {loadedProjects[i].HoursSpent}/{loadedProjects[i].HoursEstimated}</p>" +
                    "</div>" +
                    "</div>" +
                    "</div>";

            }
            return cardHtml;
        }




    }
}