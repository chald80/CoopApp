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
    public class AllFoodsModel : PageModel
    {
        
        private IFoodsRepository catalog;
        public AllFoodsModel(IFoodsRepository repository)
        {
            catalog = repository;
        }
        public List<Food> Foods { get; private set; } 
       
        [BindProperty]
        public Food Food { get; set; }
        public IActionResult OnGet()
        {
            Foods = catalog.GetAllFoods();
            return Page();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                catalog.AddFood(Food);
                Foods = catalog.GetAllFoods();
            }
            return Page();
        }
    }
}