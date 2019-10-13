// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stock.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace ObjectOriented.Stock_Report
{
    using System;

    /// <summary>
    /// Stock
    /// </summary>
    public class Stock
    {
        /// <summary>
        /// nameOfCompany
        /// </summary>
        public string nameOfCompany;
        /// <summary>
        /// numberOfShare
        /// </summary>
        public int numberOfShare;

        /// <summary>
        /// sharePrice
        /// </summary>  
        public int sharePrice;

        /// <summary>
        /// Insert Stock Details
        /// </summary>
        public void InsertStockDetails()
        {
            Console.WriteLine("Enter the name of company");
            this.nameOfCompany = Console.ReadLine();

            Console.WriteLine("Enter the total number of avaiable shares");
            this.numberOfShare = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the price of single share");
            this.sharePrice = Convert.ToInt32(Console.ReadLine());
        }
    }
}
