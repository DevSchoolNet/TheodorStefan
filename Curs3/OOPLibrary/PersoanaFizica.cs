using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class PersoanaFizica : Client
    {

        
        public PersoanaFizica(string Name,string Id):base(Name,Id)
        {
        }

        public string Nume
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void CreazaCard()
        {
            Console.WriteLine("S-a creat un card pentru id-ul " + this.Id);
        }

        public override void Login(string Name, string Password)
        {
            Console.WriteLine("Clientul de tipul {0} tocmai s-a logat",this.GetType());
        }
    }
}