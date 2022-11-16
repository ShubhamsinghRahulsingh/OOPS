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
        StockList stockList=new StockList();

        public void ReadCompanyStockFile(string file)
        {
            var companyStockData = File.ReadAllText(file);
            companyStock = JsonConvert.DeserializeObject<List<StockList>>(companyStockData);
            Display(companyStock);
        }
        public void ReadCustomerStockFile(string file)
        {
            var customerStockData = File.ReadAllText(file);
            customerStock = JsonConvert.DeserializeObject<List<StockList>>(customerStockData);
            Display(customerStock);
        }
        public void PrintStockReport()
        {
            Console.WriteLine("\nEnter whose stocklist you want to check\n1.Companies\n2.Customers");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Display(companyStock);
                    break;
                case 2:
                    Display(customerStock);
                    break;
            }
        }
        public void Display(List<StockList> stock)
        {
            foreach (var data in stock)
            {
                Console.WriteLine("\nStock Name: " + data.Name + "\n" + "Number of Shares: " + data.NumberOfshares + "\n" + "PricePerShare: " + data.PricePerShare + "\n" + "Total Stock Price: " + data.NumberOfshares * data.PricePerShare);
            }
        }
        public void BuyStock(int amount)
        {
            int count1=0, count2 = 0;
            Console.WriteLine("Enter which share customer want to buy");
            string buyStock=Console.ReadLine();
            foreach(var data in companyStock)
            {
                if(data.Name.Equals(buyStock))
                {
                    count1++;
///Console.WriteLine("Enter the amount that customer has");
              //      int amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter how many stocks to buy");
                    int number=Convert.ToInt32(Console.ReadLine());
                    if(amount>number*data.PricePerShare)
                    {
                        data.NumberOfshares -= number;
                        StockList stockk = new StockList();
                        stockk.Name=data.Name;
                        stockk.NumberOfshares = number;
                        stockk.PricePerShare= data.PricePerShare;
                        foreach (var stocks in customerStock.ToList())
                        {
                            if (stocks.Name.Equals(buyStock))
                            {
                                count2++;
                                stocks.NumberOfshares += number;
                            }
                        }
                        if (count2==0)
                        {                          
                            customerStock.Add(stockk);
                        }
                    }
                    else
                        Console.WriteLine("Please select less stocks");
                }
            }
            if(count1==0)
            {
                Console.WriteLine("Stocks unavailable");
            }
        }
        public void SellStock()
        {
            int flag = 0;
            Console.WriteLine("Enter Which stock you want to sell");
            string sellStock = Console.ReadLine();
            Console.WriteLine("Enter numbers of stock to sell");
            int numstock=Convert.ToInt32(Console.ReadLine());
            StockList delstock = new StockList();
            foreach(var stocks in customerStock.ToList())
            {
                if(stocks.Name.Equals(sellStock))
                {
                    if (stocks.NumberOfshares == numstock)
                    {
                        delstock = stocks;
                        customerStock.Remove(delstock);
                    }
                    else
                    {
                        stocks.NumberOfshares -= numstock;
                    }
                }
            }
            foreach(var data in companyStock.ToList())
            {
                if(data.Name.Equals(sellStock))
                {
                    flag++;
                    data.NumberOfshares += numstock;
                }
            }
            
        }
        public void WriteToCustomerJsonfile(string file)
        {
            var customerjson=JsonConvert.SerializeObject(customerStock);
            File.WriteAllText(file, customerjson);
        }
        public void WriteToCompanyJsonfile(string file)
        {
            var companyjson = JsonConvert.SerializeObject(companyStock);
            File.WriteAllText(file, companyjson);
        }

    }
}
