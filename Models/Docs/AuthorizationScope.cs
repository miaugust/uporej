using System.ComponentModel.DataAnnotations;

namespace Rejupo.Models.Docs
{
    public class AuthorizationScope
    {
        public int Id { get; set; }
        [Display(Name = "Zakres")]
        public string Scope { get; set; }
    }
}