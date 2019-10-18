// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsoleDetails.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// ----------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Adapter
{
    using System;

    /// <summary>
    /// Console Details
    /// </summary>
    public class ConsoleDetails
    {
        /// <summary>
        /// The name
        /// </summary>
        public string name;

        /// <summary>
        /// The memory
        /// </summary>
        public string Memory;

        /// <summary>
        /// The price
        /// </summary>
        public string price;

        public void GetConsoleDetails()
        {
            Console.WriteLine("Enter Console Name");
             this.name = Console.ReadLine();
            Console.WriteLine("Enter Console memory in GB or TB");
            this.Memory = Console.ReadLine();
            Console.WriteLine("Enter Console price");
            this.price = Console.ReadLine();
        }
    }
}
