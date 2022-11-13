using OOPSPrograms.InventoryDataManagement;
using OOPSPrograms.InventoryManagement;
using System;
namespace OOPSPrograms
{
    class Program
    {
        static string jsonFilePath = @"D:\GitRepository\OOPS\OOPSPrograms\InventoryDataManagement\Inventory.json";
        static string jsonDataFilePath = @"D:\GitRepository\OOPS\OOPSPrograms\InventoryManagement\InventoryData.json";
        static void Main(string[] args)
        {
            InventoryManager inventoryManager = new InventoryManager();
            Console.WriteLine("Welcome to the OOPS Programs");
            bool flag = true;
            while(flag)
            {
                try
                {
                    Console.WriteLine("Select from the below options\n1.InventoryDataManagement\n2.InventoryManagement\n3.InventoryDisplay\n4.AddInventoryData\n5.EditInventoryData\n6.DeleteInventorydata\n7.WritetoJsonFile\n8.Exit");
                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                            InventoryDetailManagement inventory = new InventoryDetailManagement();
                            inventory.ReadJSONFile(jsonFilePath);
                            break;
                        case 2:
                            inventoryManager.ReadJSONFile(jsonDataFilePath);
                            inventoryManager.Displayy();
                            break;
                        case 3:
                            inventoryManager.Displayy();
                            break;
                        case 4:
                            inventoryManager.AddInventoryData();
                            break;
                        case 5:
                            inventoryManager.EditInventoryData();
                            break;
                        case 6:
                            inventoryManager.DeleteInventoryData();
                            break;
                        case 7:
                            inventoryManager.WriteToJsonFile(jsonDataFilePath);
                            break;
                        case 8:
                            flag = false;
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }          
        }
    }
}
