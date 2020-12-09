using CoopApp.Models;
using Newtonsoft.Json;
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
        public static Dictionary<int, Food> ReadJsonFood(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);

            return JsonConvert.DeserializeObject<Dictionary<int, Food>>(jsonString);
        }
     
       /* public static Dictionary<int, Food> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);

            return JsonConvert.DeserializeObject<Dictionary<int, Food>>(jsonString);
        }
       */


        public static List<Order> ReadJsonOrder(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);

            return System.Text.Json.JsonSerializer.Deserialize<List<Order>>(jsonString);
        }

        public static List<Kunde> ReadJsonKunde(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);

            return System.Text.Json.JsonSerializer.Deserialize<List<Kunde>>(jsonString);
        }
    }
}
