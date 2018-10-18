using System.ComponentModel.DataAnnotations;

namespace Rejupo.Models
{
    public class Division
    {
        [Display(Name = "Numer")]
        public int Id { get; set; }
        [Required, Display(Name = "Oznaczenie (skrót)")]
        public string Abbreviation { get; set; }
        [Display(Name = "Nazwa / Opis")]
        public string Descritption { get; set; }

    }
}
