using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class Client : IUser
    {
        public string Email { get; set; }
        public string UserName { get; }
        public string Password { get; }

    

        public void Logout()
        {
            Console.WriteLine("userul s-a deconectat");
        }
        public string _name { get; set; }
        public String Id { get; set; }
        public Client(string Name,string id)
        {
            this._name = Name;
            this.Id = id;
        }

        public virtual void Login(string UserName, string Password)
        {
            Console.WriteLine("Clientul cu username-ul:{0} si cu id-ul: {1} tocmai s-a logat",_name,Id);
        }
    }
}