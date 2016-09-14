using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class Employee : IEmployee,IUser
    {

        public string Email { get; set; }
        public string UserName { get; }
        public string Password { get; }
        public string _Name { get; set; }


        public void Logout()
        {
            Console.WriteLine("userul s-a deconectat");
        }

        public Employee(string Name,string id)
        {
            this._Name = Name;
            this.Id = id;
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

        public virtual void Login(string _Name, string Password)
        {
           Console.WriteLine("Angajatul cu numele {0} si cu id-ul: {1} tocmai s-a logat ",_Name,Id);
        }
    }
}