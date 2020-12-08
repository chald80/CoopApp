using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoopApp.Models
{
    public class Kunde
    {
        public int MellemsID { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string PostNR { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Password { get; set; }

        public Section Section { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
