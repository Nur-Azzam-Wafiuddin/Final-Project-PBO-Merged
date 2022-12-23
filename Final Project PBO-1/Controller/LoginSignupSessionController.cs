using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Final_Project_PBO_1.Controller;
using Final_Project_PBO_1.Model;

namespace Final_Project_PBO_1.Controller
{
    internal class LoginSignupSessionController
    {
        public static Account currentAccountLogin;
        public void LoggingIn(Account FoundAccount)
        {
            currentAccountLogin = FoundAccount;
        }
        public Account getLoggedAccount()
        {
            return currentAccountLogin;
        }
    }
}

