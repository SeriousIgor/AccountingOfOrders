using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingOfOrders
{
    public class User
    {
        [Key]
        public int id_user { get; set; }

        private string login, password, name, surname;
        int admin;

        public User() { }

        public User(int id_user, string login, string password, string name, string surname, int admin)
        {
            this.id_user = id_user;
            this.login = login;
            this.password = password;
            this.name = name;
            this.surname = surname;
            this.admin = admin;
        }

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Admin { get => admin; set => admin = value; }
    }
}
