using NUnit.Framework;
using AccountingOfOrders;
using System.Linq;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;
using System.Collections.Generic;
using System.Configuration;

namespace AccountingOfOrdersTest
{
    public class Tests
    {
        [Test]
        public void GettingUserLoginTest()
        {
            int id_u = 1;
            string login = "login";
            string password = "qwerty";
            User user = new User(id_u, login, password, "test", "test", 1);
            Assert.AreEqual(login, user.Login);
            Assert.AreEqual(id_u, user.id_user);
            Assert.AreEqual(password, user.Password);
        }
        [Test]
        public void LogIn_WithIncorrectData_Test()
        {
            string login = "log";
            string password = "qwerty";

            Assert.IsFalse(DBOperations.LogIn(login, password));
        }
        [Test]
        public void UsersNotNullTest()
        {
            ApplicationContext ac = new ApplicationContext();
            Assert.IsNotNull(ac.Users);
        }
    }
}