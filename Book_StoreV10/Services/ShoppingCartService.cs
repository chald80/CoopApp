using CoopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopApp.Services
{
    public class ShoppingCartService
    {
        List<Food>  _cartItems;
        public ShoppingCartService()
        {
            _cartItems = new List<Food>();
        }

        public void Add(Food food)
        {
            _cartItems.Add(food);
        }

        public List<Food> GetOrderedFoods()
        {
            return _cartItems;
        }

       public void RemoveFood(double VareNumer)
        {
            foreach (var food in _cartItems)
            {
                if (food.VareNummer == VareNumer)
                {
                    _cartItems.Remove(food);
                    break;
                }
            }
        }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0.00M;

            foreach (var v in _cartItems)
            {
                totalPrice = totalPrice + (decimal)v.Pris ;
            }
            return totalPrice;
        }
        
    }
}
