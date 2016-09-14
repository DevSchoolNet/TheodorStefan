using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLibrary
{

    //dependent class for login action using dependency injection

    public class LoginHandler
    {
        private IUser _user;

        //constructor injection

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
