using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yeetles_13
{
    public partial class ProjectPage : System.Web.UI.Page
    {
        public static List<User> users = new List<User>();
        protected void Page_Load(object sender, EventArgs e)
        {
            users = Database.GetUsers();

            ListItemCollection listItems = new ListItemCollection();
            listItems.Add(new ListItem("None", "0"));
            foreach (User u in users)
            {
                listItems.Add(new ListItem(u.UserName, u.UserName));
            }
            ProjectLeadDropDown.DataSource = listItems;
            ProjectLeadDropDown.DataBind();

            if (Session["CurrentProject"] != null && Session["CurrentUser"] != null)
            {
                Project project = Database.GetProjectById(Convert.ToInt32(Session["CurrentProject"]));
                if (!Database.IsAdmin(Session["CurrentUser"].ToString()))
                {
                    TitleInput.Visible = false;
                    ClientInput.Visible = false;
                    CvrInput.Visible = false;
                    DescriptionTextArea.Visible = false;
                    EstimatedHoursInput.Visible = false;
                    EndDateInput.Visible = false;
                    StartDateInput.Visible = false;
                    ProjectLeadDropDown.Visible = false;
                    SpentHoursInput.Visible = false;

                    TitleLabel.InnerText = project.Title;
                    ClientLabel.InnerText = project.Client;
                    CvrLabel.InnerText = project.CVR.ToString();
                    DescriptionLabel.InnerText = project.Description;
                    EstimatedHoursLabel.InnerText = project.HoursEstimated.ToString();
                    EndDateLabel.InnerText = project.EndDate.ToString("dd-MM-yyyy");
                    StartDateLabel.InnerText = project.StartDate.ToString("dd-MM-yyyy");
                    ProjectLeadLabel.InnerText = project.ProjectLead;
                    SpentHoursLabel.InnerText = project.HoursSpent.ToString();
                }
                else
                {
                    TitleLabel.Visible = false;
                    ClientLabel.Visible = false;
                    CvrLabel.Visible = false;
                    DescriptionLabel.Visible = false;
                    EstimatedHoursLabel.Visible = false;
                    EndDateLabel.Visible = false;
                    StartDateLabel.Visible = false;
                    ProjectLeadLabel.Visible = false;
                    SpentHoursLabel.Visible = false;

                    TitleInput.Value = project.Title;
                    ClientInput.Value = project.Client;
                    CvrInput.Value = project.CVR.ToString();
                    DescriptionTextArea.Value = project.Description;
                    EstimatedHoursInput.Value = project.HoursEstimated.ToString();
                    EndDateInput.Value = project.EndDate.ToString("dd-MM-yyyy");
                    StartDateInput.Value = project.StartDate.ToString("dd-MM-yyyy");
                    ProjectLeadDropDown.SelectedValue = project.ProjectLead;
                    SpentHoursInput.Value = project.HoursSpent.ToString();
                }

                if (Database.IsCheckedIn(Session["CurrentUser"].ToString(), Convert.ToInt32(Session["CurrentProject"])))
                {
                    CheckInButton.Visible = false;
                }
                else
                {
                    CheckOutButton.Visible = false;
                }


            }
            else if (Session["CurrentUser"] != null)
            {
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                Response.Redirect("Default.aspx");
            }

        }
         protected void CheckInButton_Click(object sender, EventArgs e)
        {
            Database.CheckIn(Session["CurrentUser"].ToString(), Convert.ToInt32(Session["CurrentProject"]));
            Response.Redirect("ProjectPage.aspx");
        }
        protected void CheckOutButton_Click(object sender, EventArgs e)
        {
            Database.CheckOut(Session["CurrentUser"].ToString(), Convert.ToInt32(Session["CurrentProject"]));
            Response.Redirect("ProjectPage.aspx");
        }



    }
}