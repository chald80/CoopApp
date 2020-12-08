using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoopApp.Models;
using CoopApp.Repositories;
using CoopApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoopApp
{
    public class OrderModel : PageModel
    {
        private JsonOrderRepository repository;

        private ShoppingCartService cart;

        public Kunde Student { get; set; }
        public Order Order { get; set; }   
        public List<Food> cartItems { get; set; }

        public OrderModel(JsonOrderRepository repoService, ShoppingCartService cartService)
        {
            repository = repoService;
            cart = cartService;
        }

        public IActionResult OnGet(Kunde st)
        {
            Student = st;              
            cartItems = cart.GetOrderedFoods();
            if (cartItems?.Count() <= 0)
            {
                return Redirect("ShoppingCart");
            }
            return Page();
        }
    }
}