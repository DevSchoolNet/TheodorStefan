using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class PersoanaJuridica : Client
    {
        public List<PersoanaFizica> ListaAngajati { get; set; }

        public string NumeCompanie
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public PersoanaJuridica(string Name) : base(Name)
        {
        }
        public void CreazaCard(String Id)
        {
            Console.WriteLine("Am creat card pt id-ul " + Id);
        }
    }
}