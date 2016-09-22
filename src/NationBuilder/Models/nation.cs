using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NationBuilder.Models
{
    [Table("Nations")]
    public class nation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string government { get; set; }
        public string economy { get; set; }
        public string geography { get; set; }

        public int capital { get; set; }

        public int resources { get; set; }


        public int population { get; set; }

        public int stability { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<EventNation> NationEvents { get; set; }
        public string UserId { get; set; }

    }
}
