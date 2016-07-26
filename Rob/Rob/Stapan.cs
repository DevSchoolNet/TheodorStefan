using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roboti
{
    class Stapan
    {
        public List<Robot> RobotiSubalterni { get; set; }

        public Stapan(List<Robot> rob)
        {
            RobotiSubalterni = new List<Robot>(rob.Count);
            foreach (Robot r in rob)
            {
                RobotiSubalterni.Add(r);
            }
        }

        public void Pregatiti()
        {
            foreach (Robot r in RobotiSubalterni)
            {
                var value = Enum.GetValues(typeof(Obiecte));
                if (r.MeserieRobot == Meserie.Lucru)
                    r.ObiectFolosit = (Obiecte)value.GetValue(new Random().Next(3));
                else
                    r.ObiectFolosit = (Obiecte)value.GetValue(new Random().Next(4, 6));

            }

        }

        public void Munciti()
        {
            foreach (Robot r in RobotiSubalterni)
            {
                Console.WriteLine(r.Nume + " " + r.ObiectFolosit);
            }
        }

    }
}
