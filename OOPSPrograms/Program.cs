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
            Console.WriteLine("Welcome to the OOPS Programs");
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Select 1.InventoryDataManagement 2.InventoryManagement 3.Exit");
                Console.Write("Enter your choice: ");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                            InventoryDetailManagement inventory = new InventoryDetailManagement();
                            inventory.ReadJSONFile(jsonFilePath);
                            break;
                        case 2:
                            InventoryManager inventoryManager = new InventoryManager();
                            inventoryManager.ReadJSONFile(jsonDataFilePath);
                            break;
                        case 3:
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
