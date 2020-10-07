using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogIn.Model;

namespace Login.Business
{
    public class User : ILogIn
    {
        public bool ValidateUser(string UserName, string PassWord)
        {
           return  GetUsers().Any(x => x.UserName == UserName && x.PassWord == PassWord);
        }

        private List<LogIn.Model.User> GetUsers()
        {
            return new List<LogIn.Model.User>()
            { new LogIn.Model.User(){ UserName="Shiva", PassWord="Sunny@123"},new LogIn.Model.User(){ UserName="Mahendra", PassWord="Sunny@123"}};
        }
    }
}
