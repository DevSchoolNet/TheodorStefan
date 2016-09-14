using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLibrary
{
    public class LoginHandler
    {
        private IUser _user;

        //public LoginHandler(IUser user)
        //{
        //    _user = user;
        //}

        public void LoginAction(IUser concreteUser)
        {
            this._user = concreteUser;
            _user.Login(_user.UserName,_user.Password);
        }
    }
}
