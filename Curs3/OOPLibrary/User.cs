using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class User : IUser
    {
        public string UserName { get; private set; }

        private string password;
        protected internal string Password
        {
            get
            {
                return password;
            }

            set
            {
                this.password = value;
            }
        }

        public string Email
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private static int users = 0;

        public User(string Name)
        {
            this.UserName = Name;
            users++;
        }

        ~User()
        {
            users--;
        }

        public virtual void Login(string Name, string Password)
        {
            throw new System.NotImplementedException();
        }

        public void Logout()
        {
            throw new System.NotImplementedException();
        }
    }
}