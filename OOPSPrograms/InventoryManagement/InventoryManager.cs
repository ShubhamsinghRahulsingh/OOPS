using Newtonsoft.Json;
using OOPSPrograms.InventoryDataManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPrograms.InventoryManagement
{
    public class InventoryManager
    {
        public void ReadJSONFile(string file)
        {
            var json = File.ReadAllText(file);
            InventoryData inventories = JsonConvert.DeserializeObject<InventoryData>(json);
            List<Inventory> RiceList = inventories.Rice;
            Console.WriteLine("RICELIST :");
            Display(RiceList);
            List<Inventory> WheatList = inventories.Wheat;
            Console.WriteLine("WHEATLIST");
            Display(WheatList);
            List<Inventory> PulsesList = inventories.Pulses;
            Console.WriteLine("PULSESLIST");
            Display(PulsesList);
        }
        public void Display(List<Inventory> inventories)
        {
            foreach (var data in inventories)
            {
                Console.WriteLine("Inventory Name: " + data.Name + "\n" + "Weight: " + data.Weight + "\n" + "Price Per Kg: " + data.PricePerKg + "\n" + "Total Price: " + data.Weight * data.PricePerKg);

            }
        }
    }
}
