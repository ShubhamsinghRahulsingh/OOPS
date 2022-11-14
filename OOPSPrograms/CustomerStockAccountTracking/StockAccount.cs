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
        public void ReadStockFile(string file)
        {
            var stockData=File.ReadAllText(file);
            List<StockList> stock = JsonConvert.DeserializeObject<List<StockList>>(stockData);
            foreach(var data in stock)
            {
                Console.WriteLine("Stock Name: " + data.Name + "\n" + "Number of Shares: " + data.NumberOfshares + "\n" + "PricePerShare: " + data.PricePerShare + "\n" + "Total Stock Price: " + data.NumberOfshares * data.PricePerShare);

            }
        }
    }
}
