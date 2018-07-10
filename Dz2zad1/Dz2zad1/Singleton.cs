using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dz2zad1
{
    public class Singleton
    {
        private static Singleton singleton;
        public List<User> UsersList { get; set; }=new List<User>();
        private int count = 1;
        public void Set_user(string firs_name, string lastName, string login, string password, string city,string email, string name_role)
        {
            UsersList.Add(new User(count, firs_name, lastName, login, password,city,email,name_role));
            count++;
        }

        public static Singleton Instens => singleton ?? (singleton = new Singleton());
    }
}