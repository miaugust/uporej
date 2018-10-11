using System.ComponentModel.DataAnnotations;

namespace Rejupo.Models
{
    public class Division
    {

        public int Id { get; set; }
        [Required, Display(Name = "Skrót")]
        public string Abbreviation { get; set; }
        [Display(Name = "Opis")]
        public string Descritption { get; set; }

    }
}
