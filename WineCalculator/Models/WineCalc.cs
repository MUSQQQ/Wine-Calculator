using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WineCalculator.Models
{
    //Model do kalkulatora. Pierwsze trzy zmienne to stringi bo nie wiedziałem 
    //jak ustawić inne typy zmiennych jako możliwe wybory z listy rozwijanej.
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
