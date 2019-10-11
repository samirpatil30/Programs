// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockDetails.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace ObjectOriented.Stock
{
    using System;
    public class StockDetails
    {
        
           
        public string StockName;
        public int NumberOfshares;
        public int SharePrice;

        public void DetailsOfStock()
        {
            Console.WriteLine("Enter the name of Company");
            StockName = Console.ReadLine();

            Console.WriteLine("Enter the total number of share");
            NumberOfshares = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the price of share");
            SharePrice = Convert.ToInt32(Console.ReadLine());
        }
    }
}
