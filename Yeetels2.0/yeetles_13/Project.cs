using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yeetles_13
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Client { get; set; }
        public int CVR { get; set; }
        public double HoursEstimated { get; set; }
        public double HoursSpent { get; set; }
        public string ProjectLead { get; set; }

        public Project(int id, string title, string description, DateTime startDate, DateTime endDate, string client, int cvr, double hoursEstimated, double hoursSpent, string projectLead)
        {
            Id = id;
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Client = client;
            CVR = cvr;
            HoursEstimated = hoursEstimated;
            HoursSpent = hoursSpent;
            ProjectLead = projectLead;
        }
    }
}