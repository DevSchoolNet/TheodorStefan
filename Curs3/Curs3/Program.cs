using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLibrary;

namespace Curs3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IUser> userList = new List<IUser>(3);
            
            var User1 = new Employee("Ionut");
            var User2 = new FrontOffice("Ilie");
            var User3 = new BackOffice("Gogu");
            userList.Add(User1);
            userList.Add(User2);
            userList.Add(User3);

            if(userList[1] is FrontOffice)
            {
                var fo = userList[1] as FrontOffice;
                fo.AddCustomer("zzz", "123");
            }


            var Userimm = new IMM("Gigi");
            var UserFiz = new PersoanaFizica("George");
            UserFiz.Id = "Geo";
            UserFiz.CreazaCard();

        }
    }
}
