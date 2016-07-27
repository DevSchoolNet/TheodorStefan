using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLibrary
{
    public class BackOffice : Employee, IBackOffice
    {
        public BackOffice(string Name) : base(Name)
        {
        }

        public bool ApproveCredit(string CNP)
        {
            throw new System.NotImplementedException();
        }

        public void SendNotifications(string CNP)
        {
            throw new System.NotImplementedException();
        }
    }
}