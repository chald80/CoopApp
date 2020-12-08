﻿using CoopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopApp.Interfaces
{
    public interface IFoodsRepository
    {
        List<Food> GetAllFoods();
        void AddFood(Food food);
        Food GetFood(string isbn);
        void DeleteFood(string iSBN);
        void UpdateFood(Food food);
    }
}
