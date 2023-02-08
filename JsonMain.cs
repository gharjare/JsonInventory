using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class JsonMain
    {
        Inventory inventory = new Inventory();
        List<Inventory> InventoryList = new List<Inventory>();

        public Inventory Read(string jFilePath)
        {
            using (StreamReader reader = new StreamReader(jFilePath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Inventory>>(json);
                Console.WriteLine("Name weight price Total value");
                foreach (var item in items)
                {
                    double value = item.price * item.weight;
                    Console.WriteLine(item.name + " " + item.weight + " " + item.price + " " + value);
                }
            }
            return inventory;
        }
    }
}
