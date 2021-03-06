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
        [Display(Name = "Numer kontrolny")]
        public string ControlNumber { get; set; }
        [Display(Name = "Odział"), Required]
        public string Division { get; set; }
        [Display(Name = "Imię"),Required]
        public string FirstName { get; set; }
        [Display(Name = "Nazwisko"),Required]
        public string LastName { get; set; }
        [Display(Name = "Stanowisko")]
        public string Pos_title { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone, Display(Name = "Telefon")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Aktywny")]
        public bool IsActive { get; set; }
        public DocumentBase Document { get; set; }
        
    }
}
