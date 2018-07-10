using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dz2zad1
{
    public class User
    {
        public Role role { get; }
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Firs_name { get; set; }
        public string Last_name { get; set; }
        public  string City { get; set; }
        public string Email { get; set; }

        public User(int id, string firs_name, string lastName, string login, string password, string city,string aEmail, string name_role)
        {
            Id = id;
            Firs_name = firs_name;
            Last_name = lastName;
            Login = login;
            Password = password;
            City = city;
            Email = aEmail;
            role=new Role(name_role);
        }

        public void Rename_user(string firs_name, string lastName, string login, string password, string city, string aEmail, string name_role)
        {
            Firs_name = firs_name;
            Last_name = lastName;
            Login = login;
            Password = password;
            City = city;
            role.Rename_Role(name_role);
        }
    }
}