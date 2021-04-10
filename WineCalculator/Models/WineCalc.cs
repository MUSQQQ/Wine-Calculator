using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WineCalculator.Models
{
    public class WineCalc
    {
        [Required]
        public string fruit { get; set; }
        [Required]
        public string volume { get; set; }
        [Required]
        public string power { get; set; }
        public bool pasterized {get; set;}
    }
}
