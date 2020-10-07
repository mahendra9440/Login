using Login.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LogIn.Server.WebApi.Controllers
{
    [RoutePrefix("api/Login")]
    public class LogInController : ApiController
    {
        private ILogIn _user;

        //Here need to create dependency injuction
        public LogInController()
        {
            _user = new User();
        }

        [HttpGet]
        [Route("Validate/{UserName}/{PassWord}")]
        public IHttpActionResult ValidateUser(string UserName,string PassWord)
        {
            return Ok( _user.ValidateUser(UserName, PassWord));
        }

      
    }
}
