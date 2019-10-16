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
        /// <param name="data"></param>
        public void GetSeries(string data)
        {
            string[][] gameConsole = new string[4][];         
            gameConsole[0] = new string[] { "1", "xbox", "300 GB", "15000" };
            gameConsole[1] = new string[] { "2", "playstation", "300 GB", "15000" };
            gameConsole[2] = new string[] { "3", "playstaion2", "800GB", "30000" };
            gameConsole[3] = new string[] { "4", "XboxOne", "1TB", "50000" };
            List<string> list = new List<string>();
            ////iterate GameConsole
            for (int i = 0; i < gameConsole.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    list.Add(gameConsole[i][j]);
                }       
            }

            ////iterate list
            foreach (string i in list)
            {
              if (i.Contains(data))
                {
                    Console.WriteLine(data + " is avaiable");
                }
            }
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
            Console.WriteLine("What do you want");
            string product = Console.ReadLine();
            AdapteeOfSeries adaptee = new AdapteeOfSeries();
             adaptee.GetSeries(product);
        }
    }
}