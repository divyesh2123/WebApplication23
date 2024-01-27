using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication23.Controllers
{
    [RoutePrefix("api/myyser")]
    public class MyUserController : ApiController
    {
        [HttpGet]
        [Route("getusers")]
        public IEnumerable<User> GetUsers()
        {
            EMS_NEWEntities1 eMS_NEWEntities1 = new EMS_NEWEntities1();

             var p = eMS_NEWEntities1.Users.ToList();

            return p;
        }


        [Route("{id:nonzero}")]
        [HttpGet]
        public User GetUser(int id)
        {
            EMS_NEWEntities1 eMS_NEWEntities1 = new EMS_NEWEntities1();

            var p = eMS_NEWEntities1.Users.Find(id);

            return p;
        }

        [HttpDelete]
        public User RemoveUser(int id)
        {
            EMS_NEWEntities1 eMS_NEWEntities1 = new EMS_NEWEntities1();

            var p = eMS_NEWEntities1.Users.Find(id);

            eMS_NEWEntities1.Users.Remove(p);

            eMS_NEWEntities1.SaveChanges();
            return p;
        }

        [HttpPut]
        public User UpdateUser(int id,User user)
        {
            EMS_NEWEntities1 eMS_NEWEntities1 = new EMS_NEWEntities1();

            var p = eMS_NEWEntities1.Users.Find(id);

            p.Email = user.Email;
            p.UserName = user.UserName;

            eMS_NEWEntities1.SaveChanges();
            return p;
        }

        [HttpPost]
        public User AddUser(User user)
        {
            EMS_NEWEntities1 eMS_NEWEntities1 = new EMS_NEWEntities1();
            eMS_NEWEntities1.Users.Add(user);
            eMS_NEWEntities1.SaveChanges();
            return user;
        }




    }
}
