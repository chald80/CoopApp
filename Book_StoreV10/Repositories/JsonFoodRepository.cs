using CoopApp.Models;
using CoopApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopApp.Services
{
    public class JsonFoodRepository : IFoodsRepository
    {
        string JsonFileName = @"C:\Users\hald_\Source\Repos\chald80\CoopApp\Book_StoreV10\Data\JsonFoodsStore.json";

        public void AddFood(Food food)
        {
            Dictionary<int, Food> foods = GetAllFoods();
            foods.Add(food.VareNummer, food);
            JsonFileWritter.WriteToJsonFood(foods, JsonFileName);
        }

        public Dictionary<int, Food> GetAllFoods()
        {
            return JsonFileReader.ReadJsonFood(JsonFileName);
        }
        public Dictionary<int, Food> FilterFood(string criteria)
        {
            Dictionary<int, Food> foods = GetAllFoods();
            Dictionary<int, Food> filteredFoods = new Dictionary<int, Food>();
            foreach (var p in foods.Values)
            {
                if (p.Navn.StartsWith(criteria))
                {
                    filteredFoods.Add(p.VareNummer, p);
                }
            }
            return filteredFoods;
        }

        public Food GetFood(int VareNummer)
        {
            Dictionary<int, Food> foods = GetAllFoods();
            Food foundFood = foods[VareNummer];
            return foundFood;
        }

        public void UpdateFood(Food food)
        {
            Dictionary<int, Food> foods = GetAllFoods();
            Food foundFood = foods[food.VareNummer];
            foundFood.VareNummer = food.VareNummer;
            foundFood.Navn = food.Navn;
            foundFood.Pris = food.Pris;
            foundFood.Producent = food.Producent;
            foundFood.ImageName = food.ImageName;
            JsonFileWritter.WriteToJsonFood(foods, JsonFileName);
        }

        public void DeleteFood(int Varenummer)
        {
            Dictionary<int, Food> foods = GetAllFoods();
            foods.Remove(Varenummer);
            JsonFileWritter.WriteToJsonFood(foods, JsonFileName);
        }
    }
}
