using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class Employee : User, IEmployee
    {
        public Employee(string Name) : base(Name)
        {

        }
        
        public int Wage
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Id
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Departament
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public override void Login(string Id, string Password)
        {
            throw new System.NotImplementedException();
        }
    }
}