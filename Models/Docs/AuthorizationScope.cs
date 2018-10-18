using System.ComponentModel.DataAnnotations;

namespace Rejupo.Models.Docs
{
    public class AuthorizationScope
    {
        public int Id { get; set; }
        public string Scope { get; set; }
    }
}