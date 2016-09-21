using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NationBuilder.Models
{
    [Table("Events")]
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string Choice1Words { get; set; }
        public int Choice1Pop { get; set; }
        public int Choice1Stab { get; set; }
        public int Chocie1Res { get; set; }
        public int Choice1Cap { get; set; }
        public string Choice1Outcome { get; set; }

        public string Choice2Words { get; set; }
        public int Choice2Pop { get; set; }
        public int Choice2Stab { get; set; }
        public int Chocie2Res { get; set; }
        public int Choice2Cap { get; set; }
        public string Choice2Outcome { get; set; }

        public string Choice3Words { get; set; }
        public int Choice3Pop { get; set; }
        public int Choice3Stab { get; set; }
        public int Chocie3Res { get; set; }
        public int Choice3Cap { get; set; }
        public string Choice3Outcome { get; set; }



    }
}
