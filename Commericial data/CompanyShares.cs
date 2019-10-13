// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompanyShares.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace ObjectOriented.Commericial_data
{
    using System;

    /// <summary>
    /// Company Shares
    /// </summary>
    public class CompanyShares
    {
        public string nameOfCompany;
        public int sharesPrice;
        public int totalShares;

        /// <summary>
        /// Company Details
        /// </summary>
        public void CompanyDetails()
        {
            Console.WriteLine("Enter the name of Company ::");
            nameOfCompany = Console.ReadLine();

            Console.WriteLine("Enter the total shares ");
            totalShares = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter single share price");
            sharesPrice = Convert.ToInt32(Console.ReadLine());
        }
    }
}
