using KYC.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KYC.Web.DbContexts
{
    public class IdentityDB : IdentityDbContext<ApplicationUser>
    {
        public IdentityDB()
            : base("KYCdb")
        { 
        }
        public static IdentityDB Create()
        {
            return new IdentityDB();
        }

    }
}