using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace FavoriteToppings
{
    class Program
    {
        static void Main(string[] args)
        {
            //read a file from disk
            var json = File.ReadAllText("./toppings.json");
            //deserialize from json to C#
            //property names in json and C# need to match
            var toppingSelections = JsonConvert.DeserializeObject<List<PizzaSelection>>(json);


            //built in but a little less feature rich.  It is faster though
            toppingSelections = System.Text.Json.JsonSerializer.Deserialize<List<PizzaSelection>>(json);
            
        }
    }
}
