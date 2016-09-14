using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class IntreprindereMare : PersoanaJuridica,IBackOffice
    {
        public IntreprindereMare(string Name,string id) : base(Name,id)
        {
        }

        public bool ApproveCredit(string CNP)
        {
            throw new NotImplementedException();
        }

        public void SendNotifications(string CNP)
        {
            throw new NotImplementedException();
        }

        public override void Login(string Name, string Password)
        {
            Console.WriteLine("Clientul de tipul {0} tocmai s-a logat", this.GetType());
        }
    }
}