using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Alin";
            string b = null;

            string c;
            string d;

            c = a?.Substring(2);
            d = b?.Substring(2);

            Console.WriteLine(c + " " + d);
        }
    }
}
