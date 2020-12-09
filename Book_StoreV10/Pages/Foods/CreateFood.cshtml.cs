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
    public class CreateFoodModel : PageModel
    {
        private IFoodsRepository repository;
        [BindProperty]
        public Food Food { get; set; }
        public Dictionary<int, Food> Foods { get; set; }
        public CreateFoodModel(IFoodsRepository repo)
        {
            repository = repo;
        }
        public void OnGet()
        {
           Foods = repository.GetAllFoods();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repository.AddFood(Food);
            Foods = repository.GetAllFoods();
            return RedirectToPage("CreateFood");           
        }
    }
}