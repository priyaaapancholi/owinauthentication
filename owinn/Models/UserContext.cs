using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace owinn.Models
{
    public class UserContext:IdentityDbContext<User>
    {
        public UserContext():base("UserContext")
        {

        }
    }
}