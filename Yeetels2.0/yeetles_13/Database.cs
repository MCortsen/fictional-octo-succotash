using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace yeetles_13
{
    public class Database
    {
        public static string ConnectionString = "server=mysql36.unoeuro.com;user id=server07_dk;pwd=pxabr4c5wk;database=server07_dk_db;persistsecurityinfo=True;AllowZeroDateTime=True";

        public static User GetUserById(int id)
        {
            User user = null;
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM User_Table WHERE ID = {id}", conn);
                    command.Connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        user = new User(id, reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetBoolean(6));
                    }
                    command.Connection.Close();
                    return user;
                }
                catch (Exception e)
                {
                    return user;
                }
            }
        }

        public static Project GetProjectById(int id)
        {
            Project project = null;
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM Project_Table WHERE ID = {id}", conn);
                    command.Connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        project = new Project(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetString(5), reader.GetInt32(6), reader.GetDouble(7), reader.GetDouble(8), reader.GetString(9));
                    }
                    command.Connection.Close();
                    return project;
                }
                catch
                {
                    return project;
                }
            }
        }

        public static int GetUserIdByUserName(string userName)
        {
            int id = 0;
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand($"SELECT ID FROM User_Table WHERE UserName = '{userName}'", conn);
                    command.Connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                    command.Connection.Close();
                    return id;
                }
                catch
                {
                    return id;
                }
            }
        }

        public static void CreateProjectAssignment(int projectId, string userName, string Title, DateTime deadLine)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand($"INSERT INTO ProjectAssignment_Table(Title, fk_ProjectID, fk_UserID, IsCompleted, Deadline) VALUES ('{Title}', {projectId}, {GetUserIdByUserName(userName)}, {false}, '{deadLine.ToString("yyyy-MM-dd HH:mm:ss")}')", conn);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }
                catch (Exception e)
                {
                }
            }
        }

        public static void EditUser(string userName, string name, string phonenumber, string email, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand($"UPDATE User_Table SET Name = '{name}', PhoneNumber = '{phonenumber}', Email = '{email}', Password = '{password}' WHERE UserName = '{userName}'", conn);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }
                catch (Exception e)
                {

                }
            }
        }

        public static bool IsCheckedIn(string user, int projectId)
        {
            bool isCheckedIn = false;
            int userId = 0;

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand($"SELECT ID FROM User_Table WHERE UserName = '{user}'", conn);
                    command.Connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        userId = reader.GetInt32(0);
                    }
                    reader.Close();

                    command.CommandText = $"SELECT ID FROM Timestamp_Table WHERE fk_UserID = {userId} AND fk_ProjectID = {projectId} AND EndTime IS NULL";
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isCheckedIn = true;
                    }
                    command.Connection.Close();
                    return isCheckedIn;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
        
        public static void CheckOut(string user, int projectId)
        {
            double hours = 0;
            DateTime endTime = new DateTime();
            int userId = 0;
            DateTime startTime = new DateTime();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand($"SELECT ID FROM User_Table WHERE UserName = '{user}'", conn);
                    command.Connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        userId = reader.GetInt32(0);
                    }               
                    reader.Close();

                    command.CommandText = $"SELECT StartTime FROM Timestamp_Table WHERE fk_UserID = {userId} AND fk_ProjectID = {projectId} AND EndTime IS NULL";
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        startTime = reader.GetDateTime(0);
                    }
                    reader.Close();

                    command.CommandText = $"UPDATE Timestamp_Table SET EndTime = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}, HoursSpent = {(DateTime.Now - startTime).TotalHours}' WHERE fk_ProjectID = {projectId} AND fk_UserID = {userId} AND EndTime IS NULL";
                    command.ExecuteNonQuery();

                    command.CommandText = $"SELECT StartTime, EndTime FROM Timestamp_Table WHERE fk_UserID = {GetUserIdByUserName(user)} AND fk_ProjectID = {projectId}";
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        hours = (reader.GetDateTime(1) - reader.GetDateTime(0)).Hours;
                        endTime = reader.GetDateTime(1);
                    }
                    reader.Close();
                    command.CommandText = $"UPDATE Timestamp_Table SET HoursSpent = {hours} WHERE fk_UserID = {GetUserIdByUserName(user)} AND fk_ProjectID = {projectId} AND EndTime = '{endTime.ToString("yyyy-MM-dd HH:mm:ss")}'";

                    command.ExecuteNonQuery();

                    command.Connection.Close();
                }
                catch (Exception e)
                {
                }
            }
        }

        public static void CheckIn(string user, int projectId)
        {
            int userId = 0;
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand($"SELECT ID FROM User_Table WHERE UserName = '{user}'", conn);
                    command.Connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        userId = reader.GetInt32(0);
                    }
                    reader.Close();

                    command.CommandText = $"INSERT INTO Timestamp_Table(fk_UserID, fk_ProjectID, StartTime) VALUES ({userId}, {projectId}, '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')";
                    command.ExecuteNonQuery();

                    command.Connection.Close();
                }
                catch (Exception e)
                {
                }
            }
        }

        public static bool IsAdmin(string user)
        {
            bool isAdmin = false;
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand($"SELECT IsAdmin FROM User_Table WHERE UserName = '{user}'", conn);
                    command.Connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.GetBoolean(0))
                    {
                        isAdmin = true;
                    }

                    command.Connection.Close();
                }
                catch (Exception e)
                {

                }
            }
            return isAdmin;
        }

        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM User_Table", conn);
                    command.Connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        users.Add(new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetBoolean(6)));
                    }
                    reader.Close();
                    command.Connection.Close();
                    return users;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public List<User> GetUsersByProject(int projectId)
        {
            List<User> users = new List<User>();
            List<int> userIds = new List<int>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand($"SELECT fk_UserID FROM ProjectAssignment_Table WHERE fk_ProjectID = {projectId}", conn);
                    command.Connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        userIds.Add(reader.GetInt32(0));
                    }
                    reader.Close();

                    for (int i = 0; i < userIds.Count; i++)
                    {
                        command.CommandText = $"SELECT * FROM User_Table WHERE ID = {userIds[i]}";
                        reader = command.ExecuteReader();
                        users.Add(new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetBoolean(6)));
                        reader.Close();
                    }

                    command.Connection.Close();
                    return users;
                }
                catch (Exception e)
                {
                    return null;
                }
            }

        }

        public static void CreateUser(string name, string phoneNumber, string email, string userName, string password, bool isAdmin)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand($"SELECT ID FROM User_Table WHERE UserName = {userName}", conn);
                command.Connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.Read())
                {
                    command.CommandText = $"INSERT INTO User_Table(Name, PhoneNumber, Email, UserName, Password, IsAdmin) VALUES ('{name}', '{phoneNumber}', '{email}', '{userName}', '{password}', {isAdmin})";
                    command.ExecuteNonQuery();
                }
                reader.Close();
                command.Connection.Close();
            }
        }


        public static List<Project> GetProjectsByUser(string user)
        {
            List<Project> projects = new List<Project>();
            List<int> projectIds = new List<int>();
            int userId = 0;
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand($"SELECT ID FROM User_Table WHERE UserName = '{user}'", conn);
                    command.Connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    userId = reader.GetInt32(0);
                    reader.Close();

                    command.CommandText = $"SELECT fk_ProjectID FROM ProjectAssignment_Table WHERE fk_UserID = '{userId}'";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (!projectIds.Contains(reader.GetInt32(0)))
                        {
                            projectIds.Add(reader.GetInt32(0));
                        }
                    }
                    reader.Close();

                    for (int i = 0; i < projectIds.Count; i++)
                    {
                        command.CommandText = $"SELECT * FROM Project_Table WHERE ID = {projectIds[i]}";
                        reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            projects.Add(new Project(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetString(5), reader.GetInt32(6), reader.GetDouble(7), reader.GetDouble(8), reader.GetString(9)));
                        }

                        reader.Close();
                    }


                    command.Connection.Close();
                    return projects;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public static void CreateProject(string title, string description, string startDate, string endDate, double hoursEstimated, double hoursSpent, string client = "", int cvr = 0, string projectLead = "")
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand($"INSERT INTO Project_Table(Title, Description, StartDate, EndDate, Client, CVR, HoursEstimate, HoursSpent, ProjectLead) VALUES ('{title}', '{description}', '{startDate}', '{endDate}', '{client}', {cvr}, {hoursEstimated}, {hoursSpent}, '{projectLead}')", conn);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }
                catch (Exception e)
                {
                }
            }
        }

        public static bool Login(string userName, string password)
        {
            bool verification = false;
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand($"SELECT ID FROM User_Table WHERE UserName = '{userName}' AND Password = '{password}'", conn);
                    command.Connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        verification = true;
                    }
                    command.Connection.Close();
                }
                catch (Exception e)
                {
                }
                return verification;
            }
        }
    }
}

