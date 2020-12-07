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
    public class ShoppingCartModel : PageModel
    {
        public ShoppingCartService ChartService { get; }
        public List<Food> OrderedFoods { get; set; }
        private IFoodsRepository repo;

        public Food  Food{ get; set; }

        public ShoppingCartModel(IFoodsRepository repository , ShoppingCartService chart)
        {
            repo = repository;
            ChartService = chart;
            OrderedFoods = new List<Food>();
       }
        public IActionResult OnGet(string isbn)
        {
            Food food = repo.GetFood(isbn);
            ChartService.Add(food);
            OrderedFoods = ChartService.GetOrderedFoods();
            return Page();
        }

         public IActionResult OnPostDelete(string isbn)
         {
            ChartService.RemoveFood(isbn);
            OrderedFoods = ChartService.GetOrderedFoods();
            return Page();
        }
    }
}