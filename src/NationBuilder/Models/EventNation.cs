using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NationBuilder.Models
{
    [Table("NationEvents")]
    public class EventNation
    {
        [Key]
        public int NationEventId { get; set; }

        [ForeignKey("Event")]
        public int EventId { get; set; }
        public virtual Event Event { get; set; }

        [ForeignKey("Nation")]
        public int NationId { get; set; }
        public virtual nation Nation { get; set; }
    }
}
