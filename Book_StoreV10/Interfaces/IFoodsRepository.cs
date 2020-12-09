using CoopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopApp.Interfaces
{
    public interface IFoodsRepository
    {
        Dictionary<int, Food> GetAllFoods();
        void AddFood(Food food);
        Food GetFood(int VareNummer);
        void DeleteFood(int VareNumer);
        void UpdateFood(Food food);
    }
}
