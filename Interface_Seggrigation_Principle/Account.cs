using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    //ISP is as same as SRP but in this we use separete interfaces for different classes
    //and the interfaces contains the only methods that needs to be implemented.
    //So that the methods not to get forcefully implemented.
    public class Account
    {
        public readonly UserServices _userServices;
        public Account(UserServices userServices)
        {
            _userServices = userServices;
        }
        public bool Login(string userName, string password)
        {
            bool result = _userServices.CheckCredentials(userName, password);
            Task.Run(() => MailServices.SendMail("pranay@gmail.com"));
            return result;
        }
    }
}
