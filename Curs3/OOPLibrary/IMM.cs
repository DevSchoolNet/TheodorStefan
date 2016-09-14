using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class IMM : PersoanaJuridica
    {
        public IMM(string Name,string id) : base(Name,id)
        {
        }

        public override void Login(string Name, string Password)
        {
            Console.WriteLine("Clientul de tipul {0} tocmai s-a logat", this.GetType());
        }
    }
}