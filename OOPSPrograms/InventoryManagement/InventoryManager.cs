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
        List<Inventory> RiceList;
        List<Inventory> WheatList;
        List<Inventory> PulsesList;
        InventoryData inventories;
        public void ReadJSONFile(string file)
        {
            var json = File.ReadAllText(file);
            inventories = JsonConvert.DeserializeObject<InventoryData>(json);
            RiceList = inventories.Rice;
            WheatList = inventories.Wheat;         
            PulsesList = inventories.Pulses;
        }
        public void Displayy()
        {
            Console.WriteLine("Select 1.Ricelist  2.WheatList 3.PulsesList 4.All ");
            try
            {
                int display = Convert.ToInt32(Console.ReadLine());
                switch (display)
                {
                    case 1:
                        Display(RiceList);
                        break;
                    case 2:
                        Display(WheatList);
                        break;
                    case 3:
                        Display(PulsesList);
                        break;
                    case 4:
                        Display(RiceList);
                        Display(WheatList);
                        Display(PulsesList);
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Display(List<Inventory> inventories)
        {
            foreach (var data in inventories)
            {
                Console.WriteLine("Inventory Name: " + data.Name + "\n" + "Weight: " + data.Weight + "\n" + "Price Per Kg: " + data.PricePerKg + "\n" + "Total Price: " + data.Weight * data.PricePerKg);

            }
        }
        public void AddInventoryData()
        {
            Inventory inventory = new Inventory();
            Console.WriteLine("Enter for which inventory u want to add");
            Console.WriteLine("Select one from Rice ,Wheat and Pulses");
            string addinventory = Console.ReadLine();
            if (addinventory.Equals("Rice"))
            {
                inventory.Name = "D";
                inventory.Weight = 50;
                inventory.PricePerKg = 10.0;
                RiceList.Add(inventory);
            }
            else if (addinventory.Equals("Wheat"))
            {
                inventory.Name = "D";
                inventory.Weight = 50;
                inventory.PricePerKg = 10.0;
                WheatList.Add(inventory);
            }
            else if (addinventory.Equals("Pulses"))
            {
                inventory.Name = "D";
                inventory.Weight = 50;
                inventory.PricePerKg = 10.0;
                PulsesList.Add(inventory);
            }
            else
                Console.WriteLine("Invalid input");
            Console.WriteLine("Inventory Data added successfully");
        }
    }
}
