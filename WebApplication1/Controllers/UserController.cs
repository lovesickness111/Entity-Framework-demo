using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : ApiController
    {
        public List<User> GetUsers()
        {
            using(TestEntities testEntities = new TestEntities())
            {
                var users = testEntities.Users.ToList();
                foreach (var user in users)
                {
                    Console.Write(user.Name);

                }
                return users;
            }

        }
    }
}
