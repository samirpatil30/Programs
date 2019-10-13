// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockDetails.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace ObjectOriented.Stock
{
    using System;

    /// <summary>
    /// Stock Details
    /// </summary>
    public class StockDetails
    {
        /// <summary>
        /// StockName
        /// </summary>
        public string StockName;

        /// <summary>
        /// NumberOfshares
        /// </summary>       
        public int NumberOfshares;

        /// <summary>
        /// SharePrice
        /// </summary>
        public int SharePrice;

        /// <summary>
        /// Details Of Stock
        /// </summary>
        public void DetailsOfStock()
        {
            Console.WriteLine("Enter the name of Company");
            this.StockName = Console.ReadLine();

            Console.WriteLine("Enter the total number of share");
            this.NumberOfshares = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the price of share");
            this.SharePrice = Convert.ToInt32(Console.ReadLine());
        }
    }
}
