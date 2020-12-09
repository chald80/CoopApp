using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using CoopApp.Models;

namespace CoopApp
{
    public class JsonFileWritter
    {
        public static void WriteToJsonFood(Dictionary<int, Food> foods, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(foods, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }

        public static void WriteToJsonOrder(List<Order> orders, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(orders, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }

        public static void WriteToJsonKunde(List<Kunde> kunder, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(kunder, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }


    }
}
