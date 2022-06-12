using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    //Use are using service injection here line No 12. So that the Account class cannot be tightly dependent on Userservices.
    //By using this we can increase flexibilit( changing in UserServices cannot affect the Account).
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
