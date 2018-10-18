using System;
using System.ComponentModel.DataAnnotations;

namespace Rejupo.Models.Docs
{
    public class DocumentBase
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }

        public Employee Owner { get; set; }
        
        public string OwnerId { get; set; }
        
        public DateTime DateCreated { get; set; }
       
        public DateTime? ValidTo { get; set; }
        public DateTime? CancelingDate { get; set; }

    }

}
