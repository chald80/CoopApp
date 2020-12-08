using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoopApp.Interfaces;
using CoopApp.Models;
using CoopApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CoopApp
{
    public class AllKunderModel : PageModel
    {
            
        private IKunderRepository catalog;
        
        public AllKunderModel(IKunderRepository repository)
        {
            catalog = repository;
        }
        public List<Kunde> Kunder { get; private set; }

        [BindProperty]
        public Kunde Kunde { get; set; }
        public IActionResult OnGet()
        {
            Kunder = catalog.GetAllKunder();
            return Page();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                catalog.AddKunde(Kunde);
                Kunder = catalog.GetAllKunder();
            }
            return Page();
        }
    
    }
}
