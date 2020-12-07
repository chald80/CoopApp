using CoopApp.Interfaces;
using CoopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopApp.Repositories
{
    public class JsonOrderRepository :IOrderRepository
    {

        string filePath = @"C:\Users\Anders\OneDrive\Dokumenter\skole\Projekt\Book_StoreV10\Book_StoreV10\Data\JsonFoodOrders.json";

        public List<Order> GetAllOrders()
        {
            return JsonFileReader.ReadJsonOrder(filePath);
        }
        public void AddOrder(Order order)
        {
            List<Order> orders = GetAllOrders().ToList();
            order.OrderID = GetOrderNumber()+1;
            orders.Add(order);
            JsonFileWritter.WriteToJsonOrder(orders, filePath);
        }

        private int GetOrderNumber()
        {
            List<int> ids = new List<int>();
             List<Order>  orders= GetAllOrders().ToList();
            foreach( var o in orders)
            {
                ids.Add(o.OrderID);
            }
            return ids.Max();
        }
    }
}
