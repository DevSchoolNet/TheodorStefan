using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annonymus
{
    delegate void showMe(String a);
    class Program
    {
        static void Main(string[] args)
        {
            showMe s = delegate (string a)
              {
                  Console.WriteLine(a);
              };
            s("Aceasta este o metoda anonima!!");
        }
    }
}
