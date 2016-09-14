using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class User : IUser
    {
        public string UserName { get; private set; }

        

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

        public string Password
        {
            get { return this.Password; }
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

        public virtual void Login(string UserName, string Password)
        {
            Console.WriteLine("user-ul s-a logat");
        }

        public void Logout()
        {
            throw new System.NotImplementedException();
        }
    }
}