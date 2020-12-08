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
    public class CreateKundeModel : PageModel
    {
        private IKunderRepository repository;
        [BindProperty]
        public Kunde Kunde { get; set; }
        public List<Kunde> Kunder { get; set; }
        public CreateKundeModel(IKunderRepository repo)
        {
            repository = repo;
        }
        public void OnGet()
        {
           Kunder = repository.GetAllKunder();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repository.AddKunde(Kunde);
            Kunder = repository.GetAllKunder();
            return RedirectToPage("CreateKunde");           
        }
    }
}