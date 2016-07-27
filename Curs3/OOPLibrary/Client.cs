using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class Client : User
    {

        public String Id { get; set; }
        public Client(string Name) : base(Name)
        {
        }

        public override void Login(string Name, string Password)
        {
            base.Login(Name, Password);
        }
    }
}