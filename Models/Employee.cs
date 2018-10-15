using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rejupo.Models.Docs;

namespace Rejupo.Models
{
    public class Employee
    {
        [Key]
        public string ControlNumber { get; set; }
        public string Division { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public AuthorizationToProcesPersonalData AuthorizationToProcesPersonalData { get; set; }
        
    }
}
