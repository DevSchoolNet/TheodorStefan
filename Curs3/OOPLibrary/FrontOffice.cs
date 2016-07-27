using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class FrontOffice : Employee, IFrontOffice
    {
        public FrontOffice(string Name) : base(Name)
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
    }
}