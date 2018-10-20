using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rejupo.Models.Docs
{
    public class AuthorizationScope
    {
        public int Id { get; set; }
        [Display(Name = "Zakres")]
        public string Scope { get; set; }
        public List<Document_Scope> Document_Scope { get; set; }
    }
}