using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Business
{
    public interface ILogIn
    {
        bool ValidateUser(string UserName, string PassWord);
    }
}
