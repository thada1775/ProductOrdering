﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models
{
    public class ApplicationRole :IdentityRole
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
