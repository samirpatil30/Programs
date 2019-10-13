// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockProtfolio.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace ObjectOriented.Stock
{
    using System;
    using Newtonsoft.Json; 
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Stock Protfolio
    /// </summary>
    public class StockProtfolio
    {
        /// <summary>
        /// Report Of Stock
        /// </summary>
        public void ReportOfStock()
        {
            ////Model model = new Model();
            Console.WriteLine("Enter the number of shares company currently having");
            int numberOfShares = Convert.ToInt32(Console.ReadLine());

            StockDetails[] stock = new StockDetails[numberOfShares];

            for (int i = 0; i < numberOfShares; i++)
            {
                stock[i] = new StockDetails();
                stock[i].DetailsOfStock();
            }

            ////Create the instance of List
            List<StockDetails> list = new List<StockDetails>();
            //// Iterate NumberOfShears
            for (int i = 0; i < numberOfShares; i++)
            {
                list.Add(stock[i]);
            }

            string jsonOfStock = JsonConvert.SerializeObject(list);
            string path = "./StockFile.json";
            ////Create instance of StreamWriter
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(jsonOfStock);
            streamWriter.Close();
            ////Create instance of StreamReader
            StreamReader streamReader = new StreamReader(path);
            string readFromFile = streamReader.ReadLine();

            double totalPriceOfshares = 0.0;
            ////Create the instance of List
            List<StockDetails> listOne = JsonConvert.DeserializeObject<List<StockDetails>>(readFromFile);
            //// iterate the of listOne
            foreach (StockDetails stockOne in listOne)
            {
                totalPriceOfshares = stockOne.SharePrice * stockOne.NumberOfshares;
                Console.WriteLine("Name Of Company : " + stockOne.StockName);
                Console.WriteLine(stockOne.StockName + " Have :: " + stockOne.NumberOfshares + " shares");
                Console.WriteLine(stockOne.StockName + " single share price ::" + stockOne.SharePrice);
                Console.WriteLine("Total Share Price of Stock " + totalPriceOfshares);
            }

            Console.WriteLine("Where do you want to invest");
            string nameOfStock = Console.ReadLine();
            ////Iterate ListOne
            foreach (StockDetails stockDetail in listOne)
            {
                if (nameOfStock.Equals(stockDetail.StockName))
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
