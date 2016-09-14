using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class FrontOffice : Employee, IFrontOffice
    {
        public FrontOffice(string Name,string id) : base(Name,id)
        {
        }

        public void AddCustomer(string name, string CNP)
        {
            Console.WriteLine("L-am adaugat pe " + name + " cu CNP-ul " + CNP);
        }

        public bool OpenRelation(string Name, string CNP)
        {
            throw new System.NotImplementedException();
        }

        public override void Login(string _Name, string Password)
        {
           Console.WriteLine("Angajatul de tipul {0} tocmai s-a logat",this.GetType());
        }
    }
}