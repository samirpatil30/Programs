using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOriented.Stock
{
   public class StockProtfolio
    {
        public void ReportOfStock()
        {
            //Model model = new Model();
            Console.WriteLine("Enter the number of shares company currently having");
            int numberOfShares = Convert.ToInt32(Console.ReadLine());

            StockDetails[] stock = new StockDetails[numberOfShares];

            for(int i = 0; i < numberOfShares; i++)
            {
                stock[i] = new StockDetails();
                stock[i].DetailsOfStock();
            }

            List<StockDetails> list = new List<StockDetails>();
            for(int i = 0; i < numberOfShares; i++)
            {
                list.Add(stock[i]);
            }

            string JsonOfStock = JsonConvert.SerializeObject(list);
            string path = "./StockFile.json";
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(JsonOfStock);
            streamWriter.Close();

            StreamReader streamReader = new StreamReader(path);
            string readFromFile = streamReader.ReadLine();

            double totalPriceOfshares = 0.0;
            List<StockDetails> listOne = JsonConvert.DeserializeObject<List<StockDetails>>(readFromFile);

            foreach (StockDetails stockOne in listOne)
            {
                totalPriceOfshares = stockOne.SharePrice * stockOne.NumberOfshares;
                Console.WriteLine("Name Of Company : " + stockOne.StockName);
                Console.WriteLine(stockOne.StockName+" Have :: " + stockOne.NumberOfshares+" shares");
                Console.WriteLine(stockOne.StockName + " single share price ::" + stockOne.SharePrice);
                Console.WriteLine("Total Share Price of Stock " + totalPriceOfshares);
            }

            Console.WriteLine("Where do you want to invest");
            string nameOfStock = Console.ReadLine();

            foreach(StockDetails stockDetail in listOne)
            {
                if(nameOfStock.Equals(stockDetail.StockName))
                {
                    Console.WriteLine("How many shares you want to purchase");
                    int numbersOfShers = Convert.ToInt32(Console.ReadLine());

                    double totalPRiceOfShares = totalPriceOfshares * stockDetail.SharePrice;
                    int remainingShares = stockDetail.NumberOfshares - numberOfShares;
                    Console.WriteLine("Yoy need to pay " + totalPriceOfshares + " Rs");
                    Console.WriteLine("avaiable share {0} is {1} ", stockDetail.StockName, remainingShares);
                }                
            }
        }
    }
}
