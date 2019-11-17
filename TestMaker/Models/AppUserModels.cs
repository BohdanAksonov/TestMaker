using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TestMaker.Models
{
    public class AppUser : IdentityUser
    {
        public virtual List<Test> Tests { get; set; }
    }

}
