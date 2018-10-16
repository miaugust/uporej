using System;
using System.ComponentModel.DataAnnotations;

namespace Rejupo.Models.Docs
{
    public abstract class DocumentBase
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }

        public Employee Owner { get; set; }
        
        public string OwnerId { get; set; }
        
        public DateTime DateCreated { get; set; }
       
        public DateTime? ValidTo { get; set; }
        public DateTime? CancelingDate { get; set; }
        public Log LastChanged { get; set; }
        public int LastChangedId { get; set; }
    }

}
