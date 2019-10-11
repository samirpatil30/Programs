using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Stock_Report
{
     public class Stock
    {
        public string nameOfCompany;
        public int numberOfShare;
        public int sharePrice;

        public void InsertStockDetails()
        {
            Console.WriteLine("Enter the name of company");
            nameOfCompany = Console.ReadLine();

            Console.WriteLine("Enter the total number of avaiable shares");
            numberOfShare = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the price of single share");
            sharePrice = Convert.ToInt32(Console.ReadLine());
        }
    }
}
