using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yeetles_13
{
    public class User
    {
        public int Id { get; }
        public string Name { get; }
        public string PhoneNumber { get; }
        public string Email { get; }
        public string UserName { get; }
        public string Password { get; }
        public bool IsAdmin { get; }


        public User(int id, string name, string phoneNumber, string email, string userName, string password, bool isAdmin)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            UserName = userName;
            Password = password;
            IsAdmin = isAdmin;
        }
    }
}