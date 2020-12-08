using CoopApp.Interfaces;
using CoopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopApp.Repositories
{
    public class JsonFoodRepository:IFoodsRepository
    {
        string JsonFileName = @"C:\Users\hald_\Source\Repos\chald80\CoopApp\Book_StoreV10\Data\JsonFoodsStore.json";

        public List<Food> GetAllFoods()
        {
            return JsonFileReader.ReadJsonFood(JsonFileName);
        }
        public void AddFood(Food Food)
        {
            List<Food> Foods = GetAllFoods().ToList();
            Foods.Add(Food);
            JsonFileWritter.WriteToJsonFood(Foods, JsonFileName);
        }
        public Food GetFood(string isbn)
        {
            foreach (var b in GetAllFoods())
            {
                if (b.ISBN == isbn)
                    return b;
            }
            return new Food();
        }
    }
}
