using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yeetles_13
{
    public partial class CreateProjectPage : System.Web.UI.Page
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
        }

        protected void CreateProjectButton_Click(object sender, EventArgs e)
        {
            Database.CreateProject(TitleTextBox.Text, DescriptionTextArea.Value, StartDateTextBox.Value, EndDateTextBox.Value, Convert.ToDouble(EstimatedHoursTextBox.Text), 0, ClientTextBox.Text, Convert.ToInt32(CvrTextBox.Text), ProjectLeadDropDown.SelectedValue);
            Response.Redirect("Dashboard.aspx");
        }



    }
}