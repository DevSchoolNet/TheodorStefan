using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roboti
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Robot> lst = new List<Robot>()
            {
                new Robot("Alin",Tip.Inotator,Meserie.Lucru),
                new Robot("George",Tip.Zburator,Meserie.Razboi)
            };

            Stapan sp = new Stapan(lst);
            sp.Pregatiti();
            sp.Munciti();
        }
    }
}
