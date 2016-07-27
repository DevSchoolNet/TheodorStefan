using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class PersoanaFizica : Client
    {

        
        public PersoanaFizica(string Name) : base(Name)
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
       
    }
}