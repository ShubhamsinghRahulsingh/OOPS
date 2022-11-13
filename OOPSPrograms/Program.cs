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
                    Console.WriteLine("Select 1.InventoryDataManagement 2.InventoryManagement 3.InventoryDisplay 4.AddInventoryData 5.EditInventoryData 6.Exit");
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
