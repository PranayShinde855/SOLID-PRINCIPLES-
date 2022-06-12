using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    // A class should have one and only one reason to change,
    // meaning that a class should have only one job.
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
            Task.Run(() => MailServices.SendMail("pranayshinde855@gmail.com"));
            return result;
        }
    }
}
