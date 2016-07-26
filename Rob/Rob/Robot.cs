using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roboti
{
    class Robot
    {
        public String Nume { get; set; }

        public void Deplaseaza()
        {
            Console.WriteLine(this.Nume + "se deplaseaza");
        }

        public Tip TipRobot { get; set; }

        public Meserie MeserieRobot { get; set; }

        public Obiecte ObiectFolosit { get; set; }

        public Robot(String nume, Tip tp, Meserie ms)
        {
            this.Nume = nume;
            this.TipRobot = tp;
            this.MeserieRobot = ms;

        }
    }

    public enum Tip
    {
        Zburator,
        Inotator,
        Terestru,
        Subteran
    }

    public enum Meserie
    {
        Lucru,
        Razboi
    }

    public enum Obiecte
    {
        Surubelnita,
        Lopata,
        Sapa,
        Pistol,
        Mitraliera,
        ShotGun
    }


}
