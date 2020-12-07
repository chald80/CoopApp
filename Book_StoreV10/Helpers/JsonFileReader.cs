using CoopApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CoopApp
{
    public class JsonFileReader
    {
        public static List<Food> ReadJsonFood(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);

            return JsonSerializer.Deserialize<List<Food>>(jsonString);
        }

        public static List<Order> ReadJsonOrder(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);

            return JsonSerializer.Deserialize<List<Order>>(jsonString);
        }
    }
}
