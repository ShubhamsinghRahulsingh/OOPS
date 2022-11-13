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
        Inventory inventory = new Inventory();
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
            catch (Exception e)
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
            Console.WriteLine("\nEnter for which inventory u want to add");
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
        public void EditInventoryData()
        {
            Console.WriteLine("\nEnter the inventory which you want to edit\nInventories are Rice,Wheat and Pulses");
            string editinventory = Console.ReadLine();
            if (editinventory.Equals("Rice"))
            {
                Console.WriteLine("Enter Which Rice type you want to edit");
                string rice = Console.ReadLine();
                foreach (var data in RiceList)
                {
                    if (data.Name.Equals(rice))
                    {
                        Console.WriteLine("select what you want to edit\n1.Name 2.Weight 3.Priceperkg");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter the new Name");
                                data.Name = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the new Weight");
                                data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                Console.WriteLine("Enter the new Price per kg");
                                data.PricePerKg = Convert.ToInt64(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            else if (editinventory.Equals("Wheat"))
            {
                Console.WriteLine("Enter Which Wheat type you want to edit");
                string wheat = Console.ReadLine();
                foreach (var data in WheatList)
                {
                    if (data.Name.Equals(wheat))
                    {
                        Console.WriteLine("select what you want to edit\n1.Name 2.Weight 3.Priceperkg");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter the new Name");
                                data.Name = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the new Weight");
                                data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                Console.WriteLine("Enter the new Price per kg");
                                data.PricePerKg = Convert.ToInt64(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            else if (editinventory.Equals("Pulses"))
            {
                Console.WriteLine("Enter which Pulses type you want to edit");
                string pulses = Console.ReadLine();
                foreach (var data in PulsesList)
                {
                    if (data.Name.Equals(pulses))
                    {
                        Console.WriteLine("select what you want to edit\n1.Name 2.Weight 3.Priceperkg");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter the new Name");
                                data.Name = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the new Weight");
                                data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                Console.WriteLine("Enter the new Price per kg");
                                data.PricePerKg = Convert.ToInt64(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            else
                Console.WriteLine("Invalid Input");
        }
        public void DeleteInventoryData()
        {
            Console.WriteLine("Enter the inventory whose data you want to delete");
            string deleteinventory=Console.ReadLine();
            if(deleteinventory.Equals("Rice"))
            {
                Console.WriteLine("Enter which data you want to delete");
                string delrice = Console.ReadLine();
                Inventory deldata = new Inventory();
                foreach(var del in RiceList)
                {
                  if (del.Name.Equals(delrice))
                    {
                        deldata = del;
                    }
                }
                RiceList.Remove(deldata);
            }
            else if(deleteinventory.Equals("Wheat"))
            {
                Console.WriteLine("Enter which data you want to delete");
                string delwheat = Console.ReadLine();
                Inventory deldata = new Inventory();
                foreach (var del in WheatList)
                {
                    if (del.Name.Equals(delwheat))
                    {
                        deldata = del;
                    }
                }
                WheatList.Remove(deldata);
            }
            else if (deleteinventory.Equals("Pulses"))
            {
                Console.WriteLine("Enter which data you want to delete");
                string delpulses = Console.ReadLine();
                Inventory deldata = new Inventory();
                foreach (var del in PulsesList)
                {
                    if (del.Name.Equals(delpulses))
                    {
                        deldata = del;
                    }
                }
                PulsesList.Remove(deldata);
            }
        }
    }
}
