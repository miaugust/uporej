using System;
using System.ComponentModel.DataAnnotations;

namespace Rejupo.Models.Docs
{
    public abstract class DocumentBase
    {
        public int Id { get; set; }
        [Display(Name = "Nazwa dokumentu")]
        public string Name { get; set; }

        public Employee Owner { get; set; }
        [Display(Name = "Numer kontrolny pracownika")]
        public string OwnerId { get; set; }
        [Display(Name = "Data utworzenia")]
        public DateTime DateCreated { get; set; }
        [Display(Name = "Ważne do")]
        public DateTime? ValidTo { get; set; }
        public DateTime? CancelingDate { get; set; }
        public Log LastChanged { get; set; }
        public int LastChangedId { get; set; }
    }

}
