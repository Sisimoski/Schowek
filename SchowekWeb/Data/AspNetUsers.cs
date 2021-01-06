using System;
using Microsoft.AspNetCore.Identity;

namespace SchowekWeb.Data
{
    public class AspNetUsers : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
