// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace ObjectOriented
{
    using System;
    using ObjectOriented. Cards;
    using ObjectOriented. Commericial_data;
    using ObjectOriented. Inventory;
    using ObjectOriented.InventoryManagement;
    using ObjectOriented. Stock;
    
    /// <summary>
    /// Entry point in programs
    /// </summary>
    class Program
    {
        public static object StockPortfolio { get; private set; }

        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
           //// Console.WriteLine("1) Regex \n 2)Cards Game \n 3)Inventory Deatils");

            string userChoice = Console.ReadLine();
            do
            {
                Console.WriteLine("1) Regex \n 2)Cards Game \n 3)Inventory Details \n 4)StockReport");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //// Create the instance of ChangeUserData
                        ChangeUserData userData = new ChangeUserData();
                        userData.ReplaceName();
                        break;

                    case 2:
                        CardsGame game = new CardsGame();
                        game.GameOfCards();
                        break;

                    case 3:
                        ManagementOfInventory management = new ManagementOfInventory();
                        management.Menu();
                        break;

                    case 4:
                        StockProtfolio stockPortfolio = new StockProtfolio();
                        stockPortfolio.ReportOfStock();
                        break;
       
                    case 6:
                        SharePurchases share = new SharePurchases();
                        share.StockAcountCreation();
                        share.buyShears();
                           break;
                }
                Console.WriteLine("Do you want to contionue yes or no ::");
                userChoice = Console.ReadLine();
            } 
            while (userChoice == "yes");
       
            Console.ReadKey();
        }       
    }

    /// <summary>
    /// Node
    /// </summary>
    public class Node
    {
        /// <summary>
        /// data
        /// </summary>
        public string data;
        /// <summary>
        /// next
        /// </summary>
        public Node next;
    }
}
