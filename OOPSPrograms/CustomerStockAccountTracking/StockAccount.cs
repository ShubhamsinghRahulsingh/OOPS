using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPrograms.CustomerStockAccountTracking
{
    public class StockAccount
    {
        List<StockList> companyStock;
        List<StockList> customerStock;

        public void ReadCompanyStockFile(string file)
        {
            var companyStockData = File.ReadAllText(file);
            companyStock = JsonConvert.DeserializeObject<List<StockList>>(companyStockData);
            PrintStockReport(companyStock);
        }
        public void ReadCustomerStockFile(string file)
        {
            var customerStockData = File.ReadAllText(file);
            customerStock = JsonConvert.DeserializeObject<List<StockList>>(customerStockData);
            PrintStockReport(customerStock);
        }
        public void PrintStockReport(List<StockList> stock)
        {
                  foreach(var data in stock)
                  {
                     Console.WriteLine("\nStock Name: " + data.Name + "\n" + "Number of Shares: " + data.NumberOfshares + "\n" + "PricePerShare: " + data.PricePerShare + "\n" + "Total Stock Price: " + data.NumberOfshares * data.PricePerShare);
                  }

        }
    }
}
