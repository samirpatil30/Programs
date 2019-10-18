// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Interface.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Adapter
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Interface
    /// </summary>
    public interface Interface
    {
        /// <summary>
        /// Get Web Series
        /// </summary>
        void GetWebSeries();
    }

    /// <summary>
    /// Adaptee Of Series
    /// </summary>
    public class AdapteeOfSeries
    {
        /// <summary>
        /// get Series
        /// </summary>
        /// <param name="data">data</param>
        public void GetSeries(string data)
        {
            List<string> list = new List<string>();

            list.Add("xbox 500-GB 15000");
            list.Add("playstation 50-GB 17000");
            list.Add("playstation2 100-GB 24000");
            list.Add("xboxOne 1-TB 50000");

            foreach (string detail in list)
            {
                if (detail.Contains(data))
                {
                    Console.WriteLine("Avaiable");
                    Console.Write(detail);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("i dont have that console");
        }
    }

    /// <summary>
    /// Adapter
    /// </summary>
    public class Adapter : Interface
    {
        /// <summary>
        /// get WebSeries
        /// </summary>
        public void GetWebSeries()
        {
            Console.WriteLine("1)xbox 2)playstation 3)playstation2 4)XboxOne");          
            Console.WriteLine("Which gameing console you want");
            string product = Console.ReadLine();
            //// Create the instance of adaptee
            AdapteeOfSeries adaptee = new AdapteeOfSeries();
             adaptee.GetSeries(product);
        }
    }
}