using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class BackOffice : Employee, IBackOffice
    {
        public BackOffice(string Name,string id) : base(Name,id)
        {
        }

        public bool ApproveCredit(string CNP)
        {
            throw new System.NotImplementedException();
        }

        public void SendNotifications(string CNP)
        {
            throw new System.NotImplementedException();
        }

        public override void Login(string _Name, string Password)
        {
            Console.WriteLine("Angajatul de tipul {0} tocmai s-a logat",this.GetType());
        }
    }
}