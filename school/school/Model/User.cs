using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    class User
    {
        public int Id;
        public string Nick;
        public string Mail;
        public string Password;
        public string Type;

        public User(string nick, string mail, string password, string type)
        {
            Nick = nick;
            Mail = mail;
            Password = password;
            Type = type;
        }

        public User(int id, string nick, string mail, string password, string type) : this(nick, mail, password, type)
        {
            Id = id;
        }

        public bool CanEdit
        {
            get
            {
                return Type == "admin" || Type == "editor";
            } 
        }
    }
}
