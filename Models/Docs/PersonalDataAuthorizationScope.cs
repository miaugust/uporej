using System.ComponentModel.DataAnnotations;

namespace Rejupo.Models.Docs
{
    public class PersonalDataAuthorizationScope
    {
        public int Id { get; set; }
        [Display(Name = "Upoważnienie do"), Required]
        public string Scope { get; set; }
    }
}