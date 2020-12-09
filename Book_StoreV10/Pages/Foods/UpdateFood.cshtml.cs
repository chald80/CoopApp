using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoopApp.Models;
using CoopApp.Interfaces;

namespace CoopApp
{
    public class UpdateFoodModel : PageModel
    {
        [BindProperty]
        public Food Food { get; set; }
        private IFoodsRepository catalog;
        public UpdateFoodModel(IFoodsRepository repository)
        {
            catalog = repository;
        }
        public void OnGet(int VareNummer)
        {
            Food = catalog.GetFood(VareNummer);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            catalog.UpdateFood(Food);
            return RedirectToPage("GetAllFoods");
        }
    }
}