using OOPSPrograms.InventoryDataManagement;
using System;
namespace OOPSPrograms
{
    class Program
    {
        static string jsonFilePath = @"D:\GitRepository\OOPS\OOPSPrograms\InventoryDataManagement\Inventory.json";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the OOPS Programs");
            InventoryDetailManagement inventory= new InventoryDetailManagement();
            inventory.ReadJSONFile(jsonFilePath);
        }
    }
}
