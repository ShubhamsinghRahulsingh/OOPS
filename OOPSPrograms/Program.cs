using OOPSPrograms.CustomerStockAccountTracking;
using OOPSPrograms.InventoryDataManagement;
using OOPSPrograms.InventoryManagement;
using OOPSPrograms.StockAccountManagement;
using System;
namespace OOPSPrograms
{
    class Program
    {
        static string jsonFilePath = @"D:\GitRepository\OOPS\OOPSPrograms\InventoryDataManagement\Inventory.json";
        static string jsonDataFilePath = @"D:\GitRepository\OOPS\OOPSPrograms\InventoryManagement\InventoryData.json";
        static string stockFilePath = @"D:\GitRepository\OOPS\OOPSPrograms\StockAccountManagement\StockList.json";
        static string stockAccountPath = @"D:\GitRepository\OOPS\OOPSPrograms\CustomerStockAccountTracking\StockAccount.json";
        static string customerAccountPath = @"D:\GitRepository\OOPS\OOPSPrograms\CustomerStockAccountTracking\CustomerAccount.json";
        static void Main(string[] args)
        {
            InventoryManager inventoryManager = new InventoryManager();
            StockManagement stock = new StockManagement();
            StockAccount stockAccount = new StockAccount();
            Console.WriteLine("Welcome to the OOPS Programs");
            bool flag = true;
            while(flag)
            {
                try
                {
                    Console.WriteLine("\nSelect from the below options\n1.InventoryDataManagement\n2.InventoryManagement\n3.InventoryDisplay\n4.AddInventoryData\n5.EditInventoryData\n6.DeleteInventorydata\n7.WritetoJsonFile\n8.StockAccountManagement\n9.StockManagement\n10.DisplayStockReports\n11.BuyStocks\n12.SellStock\n13.WriteToJsonFile\n14.Exit");
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
                            stock.ReadStockFile(stockFilePath);
                            break;
                        case 9:
                            Console.WriteLine("\nCompanies Stocks Available:");
                            stockAccount.ReadCompanyStockFile(stockAccountPath);
                            Console.WriteLine("\nCustomers Current stocks status:");
                            stockAccount.ReadCustomerStockFile(customerAccountPath);
                            break;
                        case 10:
                            stockAccount.PrintStockReport();
                            break;
                        case 11:
                            stockAccount.BuyStock(11000);
                            break;
                        case 12:
                            stockAccount.SellStock();
                            break;
                        case 13:
                            stockAccount.WriteToCompanyJsonfile(stockAccountPath);
                            stockAccount.WriteToCustomerJsonfile(customerAccountPath);
                            break;
                        case 14:
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
