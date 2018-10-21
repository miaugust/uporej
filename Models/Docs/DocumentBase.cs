using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rejupo.Models.Docs
{
    public class DocumentBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nazwa dokumentu")]
        public string Name { get; set; }

        public Employee Owner { get; set; }
        [Display(Name = "Nr kontrolny osoby powiązanej")]
        public string OwnerId { get; set; }
        [DataType(DataType.Date), Display(Name = "Data utworzenia")]
        public DateTime DateCreated { get; set; }
        [DataType(DataType.Date), Display(Name = "Ważne do")]
        public DateTime? ValidTo { get; set; } 
        [DataType(DataType.Date), Display(Name = "Data anulowania")]
        public DateTime? CancelingDate { get; set; }
        public List<Document_Scope> Document_Scope { get; set; }

    }

}
