using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class IntreprindereMare : PersoanaJuridica,IBackOffice
    {
        public IntreprindereMare(string Name) : base(Name)
        {
        }

        public bool ApproveCredit(string CNP)
        {
            throw new NotImplementedException();
        }

        public void SendNotifications(string CNP)
        {
            throw new NotImplementedException();
        }
    }
}