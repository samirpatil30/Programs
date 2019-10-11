using Newtonsoft.Json;
using ObjectOriented.Cards;
using ObjectOriented.Inventory;
using ObjectOriented.Inventory_Management;
using ObjectOriented.Stock;
using System;
using System.Collections.Generic;
using System.IO;
namespace ObjectOriented
{
    /// <summary>
    /// Entry point in programs
    /// </summary>
    class Program
    {
        public static object StockPortfolio { get; private set; }

        static void Main(string[] args)
        {
           // Console.WriteLine("1) Regex \n 2)Cards Game \n 3)Inventory Deatils");

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
                        UtilityOfInventory u = new UtilityOfInventory();
                        u.FileJson();
                        break;

                    case 4:
                        StockProtfolio stockPortfolio = new StockProtfolio();
                        stockPortfolio.ReportOfStock();
                        break;

                    case 5:
                        InventoryOperation operation = new InventoryOperation();
                        operation.CreateInventory();
                        operation.ReadInventory();
                        operation.UpdateInventory();
                        break;
                }
                Console.WriteLine("Do you want to contionue yes or no ::");
                userChoice = Console.ReadLine();
            } while (userChoice == "yes");
       
            Console.ReadKey();
        }       
    }
    public class Node
    {
        public string data;
        public Node next;
    }
}
