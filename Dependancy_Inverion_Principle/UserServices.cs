using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public interface IUserServices
    {
        bool CheckCredentials(string userName, string password);
    }
    public class UserServices : IUserServices
    {
        public bool CheckCredentials(string userName, string password)
        {
            bool userExist;
            //Code to fetch the credentials
            //If credentials mached with data set userExist varialbe to true otherwise false.
            userExist = true;
            return userExist;
        }
    }
}
