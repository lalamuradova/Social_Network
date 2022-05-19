using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social_Network.WebUI.Entities
{
    public class CustomIdentityUser:IdentityUser
    {
        
        public string ImgUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string TownOrCity { get; set; }
        public int PostCode { get; set; }
        public string Description { get; set; }
        public int Follow { get; set; }
        public int Following { get; set; }


    }
}
