﻿using Microsoft.AspNetCore.Identity;

namespace HotelProject.EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        public string City { get; set; }
    }
}
