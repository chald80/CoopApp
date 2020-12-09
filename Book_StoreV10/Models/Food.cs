using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoopApp.Models
{
    public class Food
    {
        [Required(ErrorMessage = "Price required")]
        [Range(typeof(int), "50", "100",
        ErrorMessage = "Prisen skal være mellem 50 og 100, fjols!!")]
        public int VareNummer { get; set; }
        public string Navn { get; set; }
        public double Pris { get; set; }
        public string Producent { get; set; }
        public double SidsteSalgsDato { get; set; }
        public double Fedt { get; set; }
        public double Kulhydrat { get; set; }
        public double Protein { get; set; }
        public string ImageName { get; set; }
    }
}
