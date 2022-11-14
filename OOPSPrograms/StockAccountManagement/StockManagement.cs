using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPrograms.StockAccountManagement
{
    public class StockManagement
    {
        public void ReadStockFile(string file)
        {
            var share=File.ReadAllText(file);
            List<Stock> stocks =JsonConvert.DeserializeObject<List<Stock>>(share);
            foreach(var data in stocks)
            {
                Console.WriteLine("Stock Name: " + data.Name + "\n" + "Number of Shares: " + data.NumberOfShare + "\n" + "PricePerShare: " + data.SharePrice + "\n" + "Total Stock Price: " + data.NumberOfShare * data.SharePrice);
            }
        }
    }
}
