
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Entity
{
    public  class User: IdentityUser
    {
        public const string RoleAdmin = "Admin";
        public const string RoleUser = "User";

        public string FullName { get; set; }
    }
}
