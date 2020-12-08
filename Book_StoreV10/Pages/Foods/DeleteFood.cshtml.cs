using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoopApp.Interfaces;
using CoopApp.Models;

namespace CoopApp
{
    public class DeleteFoodModel : PageModel
    {

        [BindProperty]
        public Food Food { get; set; }
        private IFoodsRepository catalog;
        public DeleteFoodModel(IFoodsRepository repository)
        {
            catalog = repository;
        }
        public IActionResult OnGet(string ISBN)
        {
            Food = catalog.GetFood(ISBN);
            return Page();
        }

        public IActionResult OnPost(String ISBN)
        {
            catalog.DeleteFood(ISBN);
            return RedirectToPage("GetAllFoods");
        }
    }
}