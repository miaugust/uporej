using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Rejupo.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the RejupoUser class
    public class RejupoUser : IdentityUser
    {
        [Required, Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Required, Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Required, Display(Name = "Odział")]
        public string  Division { get; set; }
    }
}
