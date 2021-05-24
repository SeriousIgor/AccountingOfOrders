using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;

namespace AccountingOfOrders
{
    public static class DBOperations
    {
        public static bool LogIn(string login, string password)
        {
            User authorization = null;
            ApplicationContext db = new ApplicationContext();
            authorization = db.Users.Where(user => user.Login == login && user.Password == password).FirstOrDefault();

            return (authorization != null);
        }
        public static string usersList()
        {
            string us = "";
            ApplicationContext db = new ApplicationContext();
            List<User> users = db.Users.ToList();
            foreach(User user in users)
            {
                us += user.Login + " " + user.Password + " | ";
            }
            return us;
        }
    }
}
